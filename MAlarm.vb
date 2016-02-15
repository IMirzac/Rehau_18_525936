' Modul mit Hilfsmethoden für die Meldesystem-Dialoge

#Region " Template information "
' Diese Region nicht löschen
' Version = 6.1.0.0
' Created by = INOSOFT
' 
#End Region

#Region " Öffentliche Methoden "
' (Beschreibung siehe unten):
' FillAlarmClassesList   Füllt ein VisiWin-ListView mit allen definierten Meldeklassen
' FillAlarmGroupsList    Füllt ein VisiWin-ListView mit allen definierten Meldegruppen
#End Region

#Region " Aufrufbeispiele!!! "
' MAlarm.FillAlarmClassesList(lvwClasses)

' MAlarm.FillAlarmGroupsList(lvwGroups)

#End Region

#Region " Abhängigkeiten/zusätzliche Dateien "
' - (keine)
#End Region

Imports VisiWinNET.Alarm
Imports VisiWinNET.LanguageSwitching
Imports VisiWinNET.Forms

Module MAlarm

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    Public Sub FillAlarmClassesList(ByVal lvw As VisiWinNET.Forms.ListView)
        'Füllt ein VisiWin-ListView mit allen definierten Meldeklassen
        'Eingabe:
        '  lvw: zu füllendes VisiWin-ListView, muss zwei Spalten enthalten:
        '       - 1.: Name = "colSelected", ColumnType = CheckBox, Editable = True
        '       - 2.: Name = "colName", ColumnType = LocalizedText
        'Rückgabe:
        '   lvw.Items: gefülltes ListView

        lvw.Items.Clear()
        For Each ac As AlarmClass In AlarmManager.Classes
            lvw.Items.Add(New ListViewItem(True, ac.Text), ac)
        Next
    End Sub

    Public Sub FillAlarmGroupsList(ByVal lvw As VisiWinNET.Forms.ListView)
        'Füllt ein VisiWin-ListView mit allen definierten Meldegruppen
        'Eingabe:
        '  lvw: zu füllendes VisiWin-ListView, muss zwei Spalten enthalten:
        '       - 1.: Name = "colSelected", ColumnType = CheckBox, Editable = True
        '       - 2.: Name = "colName", ColumnType = LocalizedText
        'Rückgabe:
        '   lvw.Items: gefülltes ListView

        lvw.Items.Clear()
        For Each ag As AlarmGroup In AlarmManager.Groups
            lvw.Items.Add(New ListViewItem(True, ag.Text), ag)
        Next
    End Sub

#End Region

End Module
