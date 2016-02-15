' Modul mit Hilfsmethoden f�r die Meldesystem-Dialoge

#Region " Template information "
' Diese Region nicht l�schen
' Version = 6.1.0.0
' Created by = INOSOFT
' 
#End Region

#Region " �ffentliche Methoden "
' (Beschreibung siehe unten):
' FillAlarmClassesList   F�llt ein VisiWin-ListView mit allen definierten Meldeklassen
' FillAlarmGroupsList    F�llt ein VisiWin-ListView mit allen definierten Meldegruppen
#End Region

#Region " Aufrufbeispiele!!! "
' MAlarm.FillAlarmClassesList(lvwClasses)

' MAlarm.FillAlarmGroupsList(lvwGroups)

#End Region

#Region " Abh�ngigkeiten/zus�tzliche Dateien "
' - (keine)
#End Region

Imports VisiWinNET.Alarm
Imports VisiWinNET.LanguageSwitching
Imports VisiWinNET.Forms

Module MAlarm

#Region " �ffentliche Methoden <- hier weitere Beschreibungen "

    Public Sub FillAlarmClassesList(ByVal lvw As VisiWinNET.Forms.ListView)
        'F�llt ein VisiWin-ListView mit allen definierten Meldeklassen
        'Eingabe:
        '  lvw: zu f�llendes VisiWin-ListView, muss zwei Spalten enthalten:
        '       - 1.: Name = "colSelected", ColumnType = CheckBox, Editable = True
        '       - 2.: Name = "colName", ColumnType = LocalizedText
        'R�ckgabe:
        '   lvw.Items: gef�lltes ListView

        lvw.Items.Clear()
        For Each ac As AlarmClass In AlarmManager.Classes
            lvw.Items.Add(New ListViewItem(True, ac.Text), ac)
        Next
    End Sub

    Public Sub FillAlarmGroupsList(ByVal lvw As VisiWinNET.Forms.ListView)
        'F�llt ein VisiWin-ListView mit allen definierten Meldegruppen
        'Eingabe:
        '  lvw: zu f�llendes VisiWin-ListView, muss zwei Spalten enthalten:
        '       - 1.: Name = "colSelected", ColumnType = CheckBox, Editable = True
        '       - 2.: Name = "colName", ColumnType = LocalizedText
        'R�ckgabe:
        '   lvw.Items: gef�lltes ListView

        lvw.Items.Clear()
        For Each ag As AlarmGroup In AlarmManager.Groups
            lvw.Items.Add(New ListViewItem(True, ag.Text), ag)
        Next
    End Sub

#End Region

End Module
