Public Class FStatistic

#Region "lokale Datentypen"

    Public Class AlarmStat
        Public strAlarmTextID As String             ' Alarmtext sprachumschaltbar
        Public nAlarmNo As Integer                  ' Alarmnummer
        Public nActivationCounter As Integer        ' Alarmzähler ingesamt
        Public nAverageActivationPerDay As Integer  ' durschschnittl. Alarmzähler pro Tag
        Public tsMaxDuration As TimeSpan            ' max. Alarmdauer
        Public tsAverageDurationPerDay As TimeSpan  ' durschschnittl. Alarmdauer pro Tag
    End Class

#End Region

    Private mAlarmsOnly As Boolean
    Private mAlarmTime As TimeSpan
    Private mTopAlarms(2) As Double
    Private mTopAlarmCounter As Integer

    Private mStatData As Hashtable
    Public WriteOnly Property StatData() As Hashtable
        Set(ByVal Value As Hashtable)
            mStatData = Value
        End Set
    End Property

    Private mStatDays As Integer
    Public WriteOnly Property StatDays() As Integer
        Set(ByVal Value As Integer)
            mStatDays = Value
        End Set
    End Property

    Private mSystemOnline As TimeSpan
    Public WriteOnly Property SystemOnline() As TimeSpan
        Set(ByVal Value As TimeSpan)
            mSystemOnline = Value
        End Set
    End Property

    Private mSystemWithErrors As TimeSpan
    Public WriteOnly Property SystemWithErrors() As TimeSpan
        Set(ByVal Value As TimeSpan)
            mSystemWithErrors = Value
        End Set
    End Property

    ' den Überschriftstext anpassen
    Private Sub FAlarmStatistics_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 9200)
        ' Balken initialisieren
        mAlarmTime = TimeSpan.Zero
        mAlarmsOnly = False

        ' Maximum bestimmen und Durchschnittswerte bestimmen
        Dim MaxAlarmCounter As Integer = 0
        Dim MaxAlarmSeconds As Double = 0.0

        Dim Data As AlarmStat
        For Each Data In mStatData.Values
            ' Maximalwerte für die Balken
            mAlarmTime = mAlarmTime.Add(Data.tsMaxDuration)
            If Data.nActivationCounter > MaxAlarmCounter Then MaxAlarmCounter = Data.nActivationCounter
            If Data.tsMaxDuration.TotalSeconds > MaxAlarmSeconds Then MaxAlarmSeconds = Data.tsMaxDuration.TotalSeconds

            ' Durchschnitswerte
            Data.nAverageActivationPerDay = CInt(CDbl(Data.nActivationCounter) / CDbl(mStatDays) + 0.5)
            Data.tsAverageDurationPerDay = TimeSpan.FromSeconds(Data.tsMaxDuration.TotalSeconds / CDbl(mStatDays))
        Next

        ' die Ergebnisse in die Tabelle eintragen
        listView1.Items.Clear()
        For Each Data In mStatData.Values
            ' Millisekunden brauchen wir hier nicht
            Dim tsSeconds As TimeSpan = TimeSpan.FromSeconds(CDbl(CInt(Data.tsMaxDuration.TotalSeconds + 0.5)))
            Dim tsAvrgSeconds As TimeSpan = TimeSpan.FromSeconds(CDbl(CInt(Data.tsAverageDurationPerDay.TotalSeconds + 0.5)))

            ' 2 Balken zeichnen
            Dim AlarmBar As New Bitmap(70, 30)
            Dim gbAlarm As Graphics = Graphics.FromImage(AlarmBar)
            gbAlarm.FillRectangle(New SolidBrush(System.Drawing.Color.Red), New Rectangle(4, 4, CInt(CDbl(Data.nActivationCounter) * 60.0 / CDbl(MaxAlarmCounter) + 0.5), 20))
            Dim DurationBar As New Bitmap(70, 30)
            Dim gbDuration As Graphics = Graphics.FromImage(DurationBar)
            gbDuration.FillRectangle(New SolidBrush(System.Drawing.Color.Red), New Rectangle(4, 4, CInt(CDbl(Data.tsMaxDuration.TotalSeconds) * 60.0 / CDbl(MaxAlarmSeconds) + 0.5), 20))

            ' eine Zeile in das Listview
            Dim lvI As New VisiWinNET.Forms.ListViewItem(Data.strAlarmTextID, Data.nAlarmNo, Data.nActivationCounter, AlarmBar, Data.nAverageActivationPerDay, tsSeconds.ToString(), DurationBar, tsAvrgSeconds.ToString())
            listView1.Items.Add(lvI)
        Next

        ' Liste sortieren
        listView1.Sort("MaxDuration", False)

        ' die 3 am längsten anstehenden Alarme nehmen
        Dim i As Integer
        For i = 0 To 2
            If (i >= listView1.Items.Count) Then Exit For
            mTopAlarms(i) = TimeSpan.Parse(listView1.Items(i).Values(5).ToString()).TotalSeconds
        Next
        mTopAlarmCounter = i

    End Sub

End Class
