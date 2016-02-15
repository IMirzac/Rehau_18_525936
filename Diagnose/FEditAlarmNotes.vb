' Formular (modaler Dialog) zum Bearbeiten der Notizen eines historischen Alarms

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

' If HistoricalAlarmList1.SelectedAlarm IsNot Nothing Then
'     FEditAlarmNotes.ShowDialog(HistoricalAlarmList1.SelectedAlarm.Notes)
'     HistoricalAlarmList1.UpdateList() ' Notizzähler auffrischen
'     cmdNotes.Enabled = False ' Notiz-Schaltfläche deaktivieren, da nichts mehr selektiert ist
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

Public Class FEditAlarmNotes

#Region " Deklarationen "

	Private mNotes As HistoricalAlarmNotes

#End Region

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

	' Aufruf des Dialoges zum Bearbeiten der Notizen eines historischen Alarms
	' (kehrt erst zurück, wenn der Dialog geschlossen wird).
	' Übergabe:
	'   notes: Auflistung der Notizen von einem historischen Alarmeintrag
	' Rückgabe:
	'   (notes): geänderte Auflistung
	Public Overloads Shared Sub ShowDialog(ByVal notes As HistoricalAlarmNotes)
		Dim frm As New FEditAlarmNotes

		frm.mNotes = notes

		frm.RefreshNotesList()

		frm.ShowDialog()

		frm.Dispose()
	End Sub

#End Region

#Region " Private Methoden "

	Private Sub RefreshNotesList()
		'Notizen anzeigen

		lvwNotes.Items.Clear() 'Liste der Notizen löschen
		cmdAdd.Enabled = True
		cmdDelete.Enabled = False

		'Notizliste wieder füllen
		For Each han As HistoricalAlarmNote In mNotes
			Dim lvItem As New VisiWinNET.Forms.ListViewItem(han.TimeStamp, han.User, han.Text)

			'zu jedem Eintrag wird die NoteID gespeichert
			lvItem.Tag = han.ID

			lvwNotes.Items.Add(lvItem)
		Next
	End Sub

	Private Sub lvwNotes_SelectedIndexChanged(ByVal sender As Object, ByVal e As VisiWinNET.Forms.Internals.SelectedIndexChangedEventArgs) Handles lvwNotes.SelectedIndexChanged
		cmdDelete.Enabled = (e.Index >= 0)
	End Sub

	Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
		'Notiz hinzufügen
		Dim han As New HistoricalAlarmNote(vinNote.VWItem.EditableValue)
		If han.Text <> "" Then
			mNotes.Add(han)

			'Anzeige auffrischen
			RefreshNotesList()
		End If
	End Sub

	Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
		If lvwNotes.SelectedItem IsNot Nothing Then
			'Selektierte Notiz löschen
			mNotes.Remove(lvwNotes.SelectedItem.Tag)

			'Anzeige auffrischen
			RefreshNotesList()
		End If
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
		If e.Button = Windows.Forms.MouseButtons.Left Then
			Me.Location = New System.Drawing.Point(Me.Location.X - Me.mX + e.X, Me.Location.Y - Me.mY + e.Y)
		End If
	End Sub

#End Region

End Class
