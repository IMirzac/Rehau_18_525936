' Formular zur Anzeige historischer Alarme
Imports VisiWinNET.Alarm

#Region " Template information "
' Diese Region nicht löschen
' Version = 6.1.0.0
' Created by = INOSOFT
' 
#End Region

#Region " Öffentliche Methoden "
' - (keine)
#End Region

Public Class FAlarmHistory

    Private WithEvents mRuntimeAlarms As New VisiWinNET.Alarm.HistoricalAlarms

#Region " Initialisierung "

    Private Sub FAlarmHistory_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 9100)
    End Sub

#End Region

#Region " Private Methoden "

    Private Sub cmdDetermine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetermine.Click
        If FAlarmHistoryFilter.ShowDialog(HistoricalAlarmList1.Filter) = Windows.Forms.DialogResult.OK Then
            cmdDetermine.Enabled = False
            cmdNotes.Enabled = False

            lblStatus.VWItem.State = 1 'Status "Ermittle ..." anzeigen
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True

            HistoricalAlarmList1.UpdateList()
        End If
    End Sub

    Private Sub HistoricalAlarmList1_UpdateListFinished(ByVal sender As System.Object, ByVal e As VisiWinNET.Forms.Alarm.HistoricalAlarmList.UpdateListFinishedEventArgs) Handles HistoricalAlarmList1.UpdateListFinished
        cmdDetermine.Enabled = True
        cmdNotes.Enabled = True

        lblStatus.VWItem.Value = 2 'Status "OK" anzeigen
        ProgressBar1.Visible = False

        ' Ergebnis eintragen
        lblCount.Text = HistoricalAlarmList1.Alarms.Count
    End Sub

    Private Sub HistoricalAlarmList1_UpdateListProgress(ByVal sender As System.Object, ByVal e As VisiWinNET.Forms.Alarm.HistoricalAlarmList.UpdateListProgressEventArgs) Handles HistoricalAlarmList1.UpdateListProgress
        ProgressBar1.Value = e.Progress
    End Sub

    Private Sub cmdNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotes.Click
        If HistoricalAlarmList1.SelectedAlarm IsNot Nothing Then
            FEditAlarmNotes.ShowDialog(HistoricalAlarmList1.SelectedAlarm.Notes)
            HistoricalAlarmList1.UpdateList() 'Notizzähler auffrischen
            cmdNotes.Enabled = False 'Notiz-Schaltfläche deaktivieren, da nichts mehr selektiert ist
        End If
    End Sub

    Private Sub mRuntimeAlarms_AsyncAlarmRequestFinished(ByVal sender As Object, ByVal e As VisiWinNET.Alarm.AsyncRequestSuccessArgs) Handles mRuntimeAlarms.AsyncAlarmRequestFinished
        ' Auswertung der Systemlaufzeiten
        Dim tsSystemOnline As TimeSpan = TimeSpan.Zero
        Dim tsSystemWithErrors As TimeSpan = TimeSpan.Zero

        ' wie lange lief das System insgesamt, wie lange mit und ohne Fehler

        ' zuerst die historischen Einträge bestimmen
        Dim HA As VisiWinNET.Alarm.HistoricalAlarmItem
        For Each HA In mRuntimeAlarms.Alarms
            ' nur historische Alarm untersuchen, wo gekommen und gegangen eingetragen ist
            If HA.State = AlarmStates.Inactive Or HA.State = AlarmStates.InactiveAck Or HA.State = AlarmStates.Cleared Then
                If HA.Param2 = 0 Then
                    ' System (Visualisierung) läuft (als Alarmeintrag gespeichert, Param2 = 0)
                    tsSystemOnline = tsSystemOnline.Add(HA.DeactivationTime.Subtract(HA.ActivationTime))
                ElseIf HA.Param2 = -1 Then
                    ' mindestens ein Fehler steht an (als Statusvariable der Oberalarmgruppe gespeichert, Param2 = -1)
                    tsSystemWithErrors = tsSystemWithErrors.Add(HA.DeactivationTime.Subtract(HA.ActivationTime))
                End If
            End If
        Next

        ' dann noch die aktuelle Laufzeit dazu
        tsSystemOnline = tsSystemOnline.Add(DateTime.Now.Subtract(FStart.SystemStartTime))

        ' !!! die aktuell anstehenden Fehler müssten auch noch berücksichtigt werden,
        ' aber das würde hier zu weit führen !!!

        ' Auswertung der anstehenden Alarme
        Dim StatData As New Hashtable
        Dim statEntry As FStatistic.AlarmStat

        ' hier kann nicht mit "For each" durchgelaufen werden, da in der Version 5.1.1 noch ein 
        ' Fehler war, das Demo aber trotzdem funktionieren sollte
        For i As Integer = 0 To HistoricalAlarmList1.Alarms.Count - 1
            ' nur historische Alarm untersuchen, wo gekommen und gegangen eingetragen ist
            HA = HistoricalAlarmList1.Alarms(i)
            If HA.State = AlarmStates.Inactive Or HA.State = AlarmStates.InactiveAck Or HA.State = AlarmStates.Cleared Then
                ' Eintrag schon drin?
                statEntry = StatData.Item(HA.Param2)
                If statEntry Is Nothing Then
                    ' neuen Eintrag erzeugen

                    statEntry = New FStatistic.AlarmStat
                    statEntry.strAlarmTextID = HA.LocalizableText
                    statEntry.nAlarmNo = HA.Param2
                    If HA.ActivationCounter = 0 Then statEntry.nActivationCounter = 1 Else statEntry.nActivationCounter = HA.ActivationCounter
                    statEntry.tsMaxDuration = HA.DeactivationTime.Subtract(HA.ActivationTime)
                    statEntry.nAverageActivationPerDay = 0
                    statEntry.tsAverageDurationPerDay = TimeSpan.MinValue
                    StatData.Add(HA.Param2, statEntry)
                Else
                    ' Eintrag erweitern

                    statEntry.nActivationCounter = statEntry.nActivationCounter + HA.ActivationCounter
                    statEntry.tsMaxDuration = statEntry.tsMaxDuration.Add(HA.DeactivationTime.Subtract(HA.ActivationTime))
                End If
            End If
        Next

        ' FAlarmStatistics nur laden
        Dim FStat As FStatistic = VisiWinNET.Forms.ProjectForms.Load("FStatistic")
        FStat.StatData = StatData
        FStat.StatDays = CInt(tsSystemOnline.TotalDays - 0.00001157407407) + 1
        FStat.SystemOnline = tsSystemOnline
        FStat.SystemWithErrors = tsSystemWithErrors
        VisiWinNET.Forms.ProjectForms.Show("FStatistic")
    End Sub


#End Region

#Region " Ereignisse "
    Private Sub cmdStoerstatistik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStoerstatistik.Click

        HistoricalAlarmList1.Filter.DesiredGroups = "Alarme"
        HistoricalAlarmList1.Filter.DesiredClasses = "Alarme"
        mRuntimeAlarms.Filter = HistoricalAlarmList1.Filter
        mRuntimeAlarms.GetHistoricalData()

    End Sub
#End Region

End Class
