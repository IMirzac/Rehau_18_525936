' Formular (modaler Dialog) zum Einstellen eines Filters zur Ermittlung von historischen Alarmen
' Achtung: Auf dem Formular befinden sich noch ausgeblendete Objekte, die für weiter
' Auswahlkriterien verwendet werden können. (=> Formular größer machen und Ojekt.Visible = True setzen
#Region " Template information "
' Diese Region nicht löschen
' Version = 6.1.0.0
' Created by = INOSOFT
' 
#End Region

#Region " Öffentliche Methoden "
' (Beschreibung siehe unten):
' - ShowDialog    Aufruf des Dialoges
#End Region

#Region " Aufrufbeispiele!!! "
' (es ist kein Instanzieren des Formulars notwendig, 
'  da die Methoden als "shared" deklariert sind!):

' If FAlarmHistoryFilter.ShowDialog(HistoricalAlarmList1.Filter) = Windows.Forms.DialogResult.OK Then
'     ' ...
'     HistoricalAlarmList1.UpdateList()
' End If

#End Region

#Region " Abhängigkeiten/zusätzliche Dateien "
' - Modul:
'   - MAlarm
' - Indextexte in Gruppe
'   - Dialogs.Common
'   - Benutzertexte.Forms.AlarmManagement
#End Region

Imports VisiWinNET.Alarm

Public Class FAlarmHistoryFilter

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

	Public Overloads Shared Function ShowDialog(ByVal historicalAlarmFilter As HistoricalAlarmFilter) As DialogResult
		'Aufruf des Dialoges, z.B. aus der historischen Alarmansicht.
		'Übergabe:
		'  historicalAlarmFilter: VisiWinNET.Alarm.HistoricalAlarmFilter-Objekt
		'Rückgabe:
		'  historicalAlarmFilter: VisiWinNET.Alarm.HistoricalAlarmFilter-Objekt mit gesetzten Eigenschaften
		'                         (aus den eingestellten Dialogoptionen)
		'  ShowDialog: Windows.Forms.DialogResult.OK: Filter gesetzt
		'              Windows.Forms.DialogResult.Cancel: Abbruch

		Dim frm As New FAlarmHistoryFilter
		Dim ret As Windows.Forms.DialogResult

		ret = frm.ShowDialog() ' modal anzeigen

		If ret = Windows.Forms.DialogResult.OK Then
			' Filter für Datumseinstellungen
			Select Case True
				Case frm.rbtTimeFilterAll.VWItem.State		' alles
					historicalAlarmFilter.MinTime = DateTime.MinValue
					historicalAlarmFilter.MaxTime = DateTime.MinValue

				Case frm.rbtTimeFilterToday.VWItem.State	  ' heute
					historicalAlarmFilter.MinTime = DateTime.Now.Date
					historicalAlarmFilter.MaxTime = historicalAlarmFilter.MinTime.Add(TimeSpan.FromDays(1))

				Case frm.rbtTimeFilterThisWeek.VWItem.State		 ' diese Woche
					historicalAlarmFilter.MinTime = DateTime.Now.Date.Add(TimeSpan.FromDays(-DateTime.Now.Date.DayOfWeek))
					historicalAlarmFilter.MaxTime = historicalAlarmFilter.MinTime.Add(TimeSpan.FromDays(7))

				Case frm.rbtTimeFilterFromTo.VWItem.State	   ' von ... bis ...
					historicalAlarmFilter.MinTime = frm.DateTimeIn1.Value
					historicalAlarmFilter.MaxTime = frm.DateTimeIn2.Value.Add(TimeSpan.FromDays(1))

				Case frm.rbtTimeFilterYesterday.VWItem.State	  ' gestern
					historicalAlarmFilter.MinTime = DateTime.Now.Date.Add(TimeSpan.FromDays(-1.0))
					historicalAlarmFilter.MaxTime = historicalAlarmFilter.MinTime.Add(TimeSpan.FromDays(1))

				Case frm.rbtTimeFilterLastWeek.VWItem.State		 ' letzte Woche
					historicalAlarmFilter.MinTime = DateTime.Now.Date.Add(TimeSpan.FromDays(-DateTime.Now.Date.DayOfWeek - 7))
					historicalAlarmFilter.MaxTime = historicalAlarmFilter.MinTime.Add(TimeSpan.FromDays(7))
			End Select

			' Gruppenfilter (z.B. nichts anwählen, dann sind auch die Systemalarme dabei)
			historicalAlarmFilter.DesiredGroups = ""
			For Each itm As VisiWinNET.Forms.ListViewItem In frm.lvwGroups.Items
				If itm.Values("colSelected") = True Then
					historicalAlarmFilter.DesiredGroups &= CType(itm.Tag, VisiWinNET.Alarm.AlarmGroup).Name & ";"
				End If
			Next

			' Klassenfilter (z.B. nichts anwählen, dann sind auch die Systemalarme dabei)
			historicalAlarmFilter.DesiredClasses = ""
			For Each itm As VisiWinNET.Forms.ListViewItem In frm.lvwClasses.Items
				If itm.Values("colSelected") = True Then
					historicalAlarmFilter.DesiredClasses &= CType(itm.Tag, VisiWinNET.Alarm.AlarmClass).Name & ";"
				End If
			Next

			'Prioritätsfilter
			Select Case True
				Case frm.rbtPriorityAll.VWItem.State 'Alles
					historicalAlarmFilter.MinPriority = -1
					historicalAlarmFilter.MaxPriority = -1

				Case frm.rbtPriorityFromTo.VWItem.State	'von ... bis ...
					historicalAlarmFilter.MinPriority = frm.vinMinPriority.VWItem.EditableValue
					historicalAlarmFilter.MaxPriority = frm.vinMaxPriority.VWItem.EditableValue
			End Select

			'Statusfilter
			historicalAlarmFilter.DesiredStates = VisiWinNET.Alarm.AlarmStates.None
			If frm.chkState1.VWItem.State Then historicalAlarmFilter.DesiredStates = historicalAlarmFilter.DesiredStates Or VisiWinNET.Alarm.AlarmStates.Active
			If frm.chkState2.VWItem.State Then historicalAlarmFilter.DesiredStates = historicalAlarmFilter.DesiredStates Or VisiWinNET.Alarm.AlarmStates.Inactive
			If frm.chkState3.VWItem.State Then historicalAlarmFilter.DesiredStates = historicalAlarmFilter.DesiredStates Or VisiWinNET.Alarm.AlarmStates.ActiveAck
			If frm.chkState4.VWItem.State Then historicalAlarmFilter.DesiredStates = historicalAlarmFilter.DesiredStates Or VisiWinNET.Alarm.AlarmStates.InactiveAck
			If frm.chkState5.VWItem.State Then historicalAlarmFilter.DesiredStates = historicalAlarmFilter.DesiredStates Or VisiWinNET.Alarm.AlarmStates.Cleared
		End If

		frm.Dispose()
		Return ret
	End Function

#End Region

#Region " Private Methoden "

	Private Sub FAlarmHistoryFilter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		FillAlarmClassesList(lvwClasses)
		FillAlarmGroupsList(lvwGroups)
		rbtTimeFilterAll.VWItem.State = True	'Zeitfilter "Alles" wird angewählt
		DateTimeIn1.Value = DateTime.Now.Date
		DateTimeIn2.Value = DateTimeIn1.Value
		rbtPriorityAll.VWItem.State = True		  ' Prioritätsfilter "Alles" wird angewählt
		' alle Zustände, dazu braucht man keinen auswählen
	End Sub

#End Region

#Region " Private Methoden: Formular verschieben "

	Private mX As Integer
	Private mY As Integer

	Private Sub lblCaption_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseDown
		Me.mX = e.X
		Me.mY = e.Y
	End Sub

	Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseMove
		If e.Button = System.Windows.Forms.MouseButtons.Left Then
			Me.Location = New System.Drawing.Point(Me.Location.X - Me.mX + e.X, Me.Location.Y - Me.mY + e.Y)
		End If
	End Sub

#End Region

End Class
