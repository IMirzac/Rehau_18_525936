' Formular (modaler Dialog) zum Hinzufügen oder Ändern eines Benutzers

Imports VisiWinNET.UserManagement
Imports VisiWinNET.LanguageSwitching

Public Class FUser

#Region "Initialisierung"

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen
        InitDialog()

    End Sub

#End Region

#Region " Deklarationen "

    Private mUser As VisiWinNET.UserManagement.User

    Private Enum DialogType
        Add
        Change
    End Enum

    Private mDialogType As DialogType

#End Region

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    ''' <summary>
    ''' Aufruf des Dialoges zum Hinzufügen eines Benutzers
    ''' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ''' Übergabe:
    '''   keine
    ''' Rückgabe:
    '''   ShowAddDialog: VisiWinNET.UserManagement.User : erfolgreich hinzugefügter Benutzer
    '''                  Nothing : Abbruch
    ''' </summary>
    Public Shared Function ShowAddDialog() As VisiWinNET.UserManagement.User
        Dim frm As FUser = New FUser

        frm.lblCaption.LocalizedText.Text = "capAddUser"
        frm.mDialogType = DialogType.Add

        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.Deactivated"), 0)
        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.Active"), 1)
        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.PasswordExpired"), 3)
        frm.cboState.SelectedIndex = 2 'für neue Benutzer den 3. Eintrag vorwählen

        frm.chkChangeMachineCode.VWItem.State = True
        frm.chkChangeMachineCode.Visible = False
        frm.chkChangePassword.VWItem.State = True
        frm.chkChangePassword.Visible = False
        frm.rbtNoDeactivation.VWItem.State = True

        If frm.ShowDialog <> System.Windows.Forms.DialogResult.OK Then
            frm.mUser = Nothing
        End If

        frm.Dispose()
        Return frm.mUser
    End Function

    ''' <summary>
    ''' Aufruf des Dialoges zum Ändern eines Benutzers
    ''' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ''' Übergabe:
    '''   userName: Name des zu ändernden Benutzers
    ''' Rückgabe:
    '''   ShowAddDialog: VisiWinNET.UserManagement.User : erfolgreich hinzugefügter Benutzer
    '''                  Nothing : Abbruch
    ''' </summary>
    Public Shared Function ShowChangeDialog(ByVal userName As String) As VisiWinNET.UserManagement.User
        Dim frm As FUser = New FUser

        frm.lblCaption.LocalizedText.Text = "capChangeUser"
        frm.mDialogType = DialogType.Change

        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.Deactivated"), 0)
        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.Active"), 1)
        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.Invalidated"), 2)
        frm.cboState.Items.Add(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.UserStates.PasswordExpired"), 3)

        frm.vinMachineCode.Label.Text.TextGroup = ""
        frm.vinMachineCode.Label.Text.Text = " "
        frm.vinPassword.Label.Text.TextGroup = ""
        frm.vinPassword.Label.Text.Text = " "
        frm.rbtNoDeactivation.VWItem.State = True

        frm.mUser = UserManager.Users.Item(userName)

        If Not frm.mUser Is Nothing Then
            frm.vinName.VWItem.EditableValue = frm.mUser.Name
            frm.vinName.Enabled = False
            frm.vinFullName.VWItem.EditableValue = frm.mUser.FullName
            frm.vinMachineCode.VWItem.EditableValue = frm.mUser.Code
            frm.vinFullName.Enabled = False

            For Each item As VisiWinNET.Forms.ListItem In frm.cboUserGroups.Items
                If item.Tag = frm.mUser.GroupName Then
                    frm.cboUserGroups.Text = frm.mUser.Group.Text
                    item.Selected = True
                    Exit For
                End If
            Next item

            frm.cboState.SelectedIndex = CInt(frm.mUser.State)

            If frm.mUser.DeactivationTime.ToOADate <> 0 Then
                frm.dtiDeactivationTime.Value = frm.mUser.DeactivationTime
            Else
                frm.dtiDeactivationTime.Enabled = False
            End If

            frm.vinComment.VWItem.EditableValue = frm.mUser.Comment
            If frm.ShowDialog <> System.Windows.Forms.DialogResult.OK Then
                frm.mUser = Nothing
            End If
            frm.Dispose()
            Return frm.mUser
        End If
        Return frm.mUser
    End Function

#End Region

#Region " Private Methoden "

    Private Sub InitDialog()
        For Each userGroup As VisiWinNET.UserManagement.UserGroup In UserManager.Groups
            Me.cboUserGroups.Items.Add(userGroup.Text, userGroup.Name)
        Next userGroup
    End Sub


    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If CheckInput() Then

            If mDialogType = DialogType.Add Then
                mUser = New VisiWinNET.UserManagement.User
            End If

            mUser.Name = vinName.VWItem.EditableValue
            mUser.FullName = vinFullName.VWItem.EditableValue
            mUser.GroupName = Me.cboUserGroups.Items.Item(cboUserGroups.SelectedIndex).Tag
            If chkChangePassword.VWItem.State Then
                mUser.InitialPassword = vinPassword.VWItem.EditableValue
            Else
                mUser.InitialPassword = vbNullString
            End If

            'TODO in Templates
            'mUser.Code = vinMachineCode.VWItem.EditableValue
            If chkChangeMachineCode.VWItem.State Then
                mUser.Code = vinMachineCode.VWItem.EditableValue
            Else
                mUser.Code = vbNullString
            End If

            mUser.State = cboState.Items.Item(cboState.SelectedIndex).Tag
            mUser.Comment = vinComment.VWItem.EditableValue
            If rbtNoDeactivation.VWItem.State Then
                mUser.DeactivationTime = System.DateTime.FromOADate(0)
            ElseIf rbtDeactivationTime.VWItem.State Then
                mUser.DeactivationTime = dtiDeactivationTime.EditableValue
            Else
                Dim ts As TimeSpan = New TimeSpan(vinDeactivationDays.VWItem.EditableValue, vinDeactivationHours.VWItem.EditableValue, vinDeactivationMinutes.VWItem.EditableValue, 0)
                mUser.DeactivationTime = Date.FromOADate(ts.TotalHours)
            End If

            Select Case mDialogType
                Case DialogType.Add
                    'Benutzer hinzufügen
                    Dim enmAddUserSuccess As VisiWinNET.UserManagement.AddUserSuccess
                    enmAddUserSuccess = UserManager.Users.Add(mUser)
                    If enmAddUserSuccess = AddUserSuccess.Succeeded Then
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Else
                        FMessageBox.Show(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.AddUserSuccess." & enmAddUserSuccess.ToString()), Me.lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Case DialogType.Change
                    'Benutzer ändern
                    Dim enmChangeUserSuccess As VisiWinNET.UserManagement.ChangeUserSuccess
                    enmChangeUserSuccess = UserManager.Users.Change(mUser)
                    If enmChangeUserSuccess = ChangeUserSuccess.Succeeded Then
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Else
                        FMessageBox.Show(Localization.GetText(TextTypes.ClientSystem, "Dialogs.UserManagement.ChangeUserSuccess." & enmChangeUserSuccess.ToString()), Me.lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

            End Select
        End If
    End Sub

    Private Sub chkChangeMachineCode_Change(ByVal sender As System.Object, ByVal e As VisiWinNET.DataAccess.DigitalChangeEventArgs) Handles chkChangeMachineCode.Change
        vinMachineCode.Enabled = e.State
        chkChangePassword.VWItem.State = e.State
        chkChangePassword.Enabled = Not e.State
    End Sub

    Private Sub chkChangePassword_Change(ByVal sender As System.Object, ByVal e As VisiWinNET.DataAccess.DigitalChangeEventArgs) Handles chkChangePassword.Change
        vinPassword.Enabled = e.State
        vinRepeatPassword.Enabled = e.State
    End Sub

    Private Sub rbtDeactivationTime_Change(ByVal sender As Object, ByVal e As VisiWinNET.DataAccess.DigitalChangeEventArgs) Handles rbtDeactivationTime.Change
        dtiDeactivationTime.Enabled = e.State
    End Sub

    Private Sub rbtDeactivationDuration_Change(ByVal sender As Object, ByVal e As VisiWinNET.DataAccess.DigitalChangeEventArgs) Handles rbtDeactivationDuration.Change
        vinDeactivationDays.Enabled = e.State
        vinDeactivationHours.Enabled = e.State
        vinDeactivationMinutes.Enabled = e.State
    End Sub

    Private Function CheckInput() As Boolean
        If Me.vinName.VWItem.EditableValue = "" Then
            FMessageBox.Show(TextTypes.ClientSystem, "@Dialogs.UserManagement.AddUserSuccess.NoName", Me.lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            vinName.Focus()
            Return False
        End If
        If Me.cboUserGroups.SelectedIndex < 0 Then
            FMessageBox.Show(TextTypes.ClientSystem, "@Dialogs.UserManagement.AddUserSuccess.NoUserGroup", Me.lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboUserGroups.Focus()
            Return False
        End If
        If Me.vinPassword.VWItem.EditableValue <> Me.vinRepeatPassword.VWItem.EditableValue Then
            FMessageBox.Show(TextTypes.ClientSystem, "@Dialogs.UserManagement.AddUserSuccess.PasswordsNotEqual", Me.lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.vinRepeatPassword.Focus()
            Return False
        End If
        Return True
    End Function

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

