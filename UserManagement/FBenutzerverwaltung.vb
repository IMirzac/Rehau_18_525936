Imports VisiWinNET.Forms
Imports VisiWinNET.UserManagement
Imports VisiWinNET.LanguageSwitching

Public Class FBenutzerverwaltung

#Region "Deklarationen"

    Private WithEvents m_UserManagement As New UserManager
    Private Shared m_SelectedUserIndex As Integer = -1

#End Region

#Region "Initialisierung"

    Private Sub FBenutzerverwaltung_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 1200)
    End Sub

    Public Sub New()
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        InitBenutzer()
    End Sub


#End Region

#Region "Ereignisse"

    Private Sub cmdBenutzer_hinzufuegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBenutzer_hinzufuegen.Click
        Dim user As VisiWinNET.UserManagement.User

        user = FUser.ShowAddDialog()
        If Not user Is Nothing Then
            Dim item As New ListViewItem
            lsvBenutzer.Items.Add(user.Name, item)
            Benutzerliste_aktualisieren(user, item)
        End If
    End Sub

    Private Sub cmdBenutzer_aendern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBenutzer_aendern.Click
        Dim user As VisiWinNET.UserManagement.User
        Dim item As VisiWinNET.Forms.ListViewItem

        item = lsvBenutzer.SelectedItem
        If Not item Is Nothing Then
            user = FUser.ShowChangeDialog(item.Key)
            If Not user Is Nothing Then
                Benutzerliste_aktualisieren(user, item)
            End If
        End If
    End Sub

    Private Sub cmdBenutzer_loeschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBenutzer_loeschen.Click
        Dim item As VisiWinNET.Forms.ListViewItem
        Dim user As VisiWinNET.UserManagement.User

        item = lsvBenutzer.SelectedItem
        If Not item Is Nothing Then
            user = UserManager.Users.Item(item.Key)
            If user.Group.UsersRemovable Then
                If FMessageBox.Show(TextTypes.ClientSystem, "@Dialogs.UserManagement.msgRemoveUser", Me.lblUeberschrift.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    If UserManager.Users.Remove(item.Key) Then
                        lsvBenutzer.Items.Remove(item)
                    Else

                    End If
                End If
            Else
                If FMessageBox.Show(TextTypes.ClientSystem, "@Dialogs.UserManagement.msgDeactivateUser", Me.lblUeberschrift.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    If UserManager.Users.Remove(item.Key) Then
                        Benutzerliste_aktualisieren(user, item)
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    ''' <summary>
    ''' Aufruf des Dialoges zur Anzeige aller Benutzer
    ''' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ''' Übergabe:
    '''   keine
    ''' Rückgabe:
    '''   keine
    ''' </summary>
    Public Shared Shadows Sub ShowDialog()
        Dim frm As FBenutzerverwaltung = New FBenutzerverwaltung

        CType(frm, Form).ShowDialog()
        frm.Dispose()
    End Sub

#End Region


#Region "Private Methoden"

    Private Sub InitBenutzer()
        If VisiWinNET.Project.ProjectInfo.IsInRunMode Then
            'Alle Benutzer auflisten
            For Each user As VisiWinNET.UserManagement.User In VisiWinNET.UserManagement.UserManager.Users
                Dim item As New ListViewItem
                lsvBenutzer.Items.Add(user.Name, item)
                Benutzerliste_aktualisieren(user, item)
            Next user
        End If
    End Sub

    Private Sub Benutzerliste_aktualisieren(ByVal user As VisiWinNET.UserManagement.User, ByVal item As ListViewItem)
        On Error Resume Next
        item.SubItems.Item("Benutzer") = user.Name
        item.SubItems.Item("Name") = user.FullName
        item.SubItems.Item("Benutzer_Gruppe") = user.Group.Name
        item.SubItems.Item("Status") = Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates." & user.State.ToString)
        item.SubItems.Item("Auto_LogOff_Zeit") = user.Group.AutoLogOffTime.ToString()
        item.SubItems.Item("Kommentar") = user.Comment
    End Sub

#End Region

End Class
