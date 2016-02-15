<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUser
    Inherits System.Windows.Forms.Form

    ' Die Form überschreibt den Löschvorgang der Basisklasse, um Komponenten zu bereinigen.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Für Windows Form-Designer erforderlich
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Die folgende Prozedur ist für den Windows Form-Designer erforderlich
    'Sie kann mit dem Windows Form-Designer modifiziert werden.  
    'Verwenden Sie nicht den Code-Editor zur Bearbeitung.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUser))
        Me.cmdCancel = New VisiWinNET.Forms.CommandButton
        Me.cmdOK = New VisiWinNET.Forms.CommandButton
        Me.grp = New VisiWinNET.Forms.GroupBox
        Me.chkChangeMachineCode = New VisiWinNET.Forms.CheckBox
        Me.chkChangePassword = New VisiWinNET.Forms.CheckBox
        Me.cboState = New VisiWinNET.Forms.ComboBox
        Me.vinDeactivationMinutes = New VisiWinNET.Forms.VarIn
        Me.vinDeactivationHours = New VisiWinNET.Forms.VarIn
        Me.vinDeactivationDays = New VisiWinNET.Forms.VarIn
        Me.dtiDeactivationTime = New VisiWinNET.Forms.DateTimeIn
        Me.rbtDeactivationDuration = New VisiWinNET.Forms.RadioButton
        Me.rbtDeactivationTime = New VisiWinNET.Forms.RadioButton
        Me.rbtNoDeactivation = New VisiWinNET.Forms.RadioButton
        Me.lblDeactivation = New VisiWinNET.Forms.Label
        Me.vinComment = New VisiWinNET.Forms.VarIn
        Me.vinMachineCode = New VisiWinNET.Forms.VarIn
        Me.vinRepeatPassword = New VisiWinNET.Forms.VarIn
        Me.vinPassword = New VisiWinNET.Forms.VarIn
        Me.vinFullName = New VisiWinNET.Forms.VarIn
        Me.cboUserGroups = New VisiWinNET.Forms.ComboBox
        Me.lblUserGroup = New VisiWinNET.Forms.Label
        Me.lblState = New VisiWinNET.Forms.Label
        Me.vinName = New VisiWinNET.Forms.VarIn
        Me.cmdClose = New VisiWinNET.Forms.CommandButton
        Me.lblCaption = New VisiWinNET.Forms.Label
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        CType(Me.chkChangeMachineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinDeactivationMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinDeactivationHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinDeactivationDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDeactivationTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtDeactivationDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtDeactivationTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtNoDeactivation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDeactivation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinMachineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinRepeatPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinFullName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUserGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Blink.FinalBlinkState = False
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FontClass = "Buttons"
        Me.cmdCancel.LocalizedText.Text = "cmdCancel"
        Me.cmdCancel.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdCancel.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdCancel.Location = New System.Drawing.Point(388, 356)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 28)
        Me.cmdCancel.TabIndex = 18
        '
        'cmdOK
        '
        Me.cmdOK.Blink.FinalBlinkState = False
        Me.cmdOK.FontClass = "Buttons"
        Me.cmdOK.LocalizedText.Text = "cmdOK"
        Me.cmdOK.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdOK.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdOK.Location = New System.Drawing.Point(296, 356)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 28)
        Me.cmdOK.TabIndex = 17
        '
        'grp
        '
        Me.grp.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.grp.Controls.Add(Me.chkChangeMachineCode)
        Me.grp.Controls.Add(Me.chkChangePassword)
        Me.grp.Controls.Add(Me.cboState)
        Me.grp.Controls.Add(Me.vinDeactivationMinutes)
        Me.grp.Controls.Add(Me.vinDeactivationHours)
        Me.grp.Controls.Add(Me.vinDeactivationDays)
        Me.grp.Controls.Add(Me.dtiDeactivationTime)
        Me.grp.Controls.Add(Me.rbtDeactivationDuration)
        Me.grp.Controls.Add(Me.rbtDeactivationTime)
        Me.grp.Controls.Add(Me.rbtNoDeactivation)
        Me.grp.Controls.Add(Me.lblDeactivation)
        Me.grp.Controls.Add(Me.vinComment)
        Me.grp.Controls.Add(Me.vinMachineCode)
        Me.grp.Controls.Add(Me.vinRepeatPassword)
        Me.grp.Controls.Add(Me.vinPassword)
        Me.grp.Controls.Add(Me.vinFullName)
        Me.grp.Controls.Add(Me.cboUserGroups)
        Me.grp.Controls.Add(Me.lblUserGroup)
        Me.grp.Controls.Add(Me.lblState)
        Me.grp.Controls.Add(Me.vinName)
        Me.grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp.Location = New System.Drawing.Point(8, 28)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(476, 320)
        Me.grp.TabIndex = 0
        '
        'chkChangeMachineCode
        '
        Me.chkChangeMachineCode.CheckAlign = VisiWinNET.Forms.CheckAlignment.Right
        Me.chkChangeMachineCode.FontClass = "Labels"
        Me.chkChangeMachineCode.LocalizedText.Text = "chkChangeMachineCode"
        Me.chkChangeMachineCode.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.chkChangeMachineCode.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.chkChangeMachineCode.Location = New System.Drawing.Point(8, 64)
        Me.chkChangeMachineCode.Name = "chkChangeMachineCode"
        Me.chkChangeMachineCode.Size = New System.Drawing.Size(126, 24)
        Me.chkChangeMachineCode.TabIndex = 19
        Me.chkChangeMachineCode.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        Me.chkChangeMachineCode.VWItem.Name = "__UNLINKED_BOOL"
        '
        'chkChangePassword
        '
        Me.chkChangePassword.CheckAlign = VisiWinNET.Forms.CheckAlignment.Right
        Me.chkChangePassword.FontClass = "Labels"
        Me.chkChangePassword.LocalizedText.Text = "chkChangePassword"
        Me.chkChangePassword.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.chkChangePassword.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.chkChangePassword.Location = New System.Drawing.Point(8, 120)
        Me.chkChangePassword.Name = "chkChangePassword"
        Me.chkChangePassword.Size = New System.Drawing.Size(126, 24)
        Me.chkChangePassword.TabIndex = 5
        Me.chkChangePassword.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        Me.chkChangePassword.VWItem.Name = "__UNLINKED_BOOL"
        '
        'cboState
        '
        Me.cboState.Blink.FinalBlinkState = False
        Me.cboState.Editable = False
        Me.cboState.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cboState.FontClass = "Inputs"
        Me.cboState.Location = New System.Drawing.Point(138, 176)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(330, 24)
        Me.cboState.TabIndex = 8
        '
        'vinDeactivationMinutes
        '
        Me.vinDeactivationMinutes.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationMinutes.FontClass = "Inputs"
        Me.vinDeactivationMinutes.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationMinutes.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinDeactivationMinutes.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDeactivationMinutes.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDeactivationMinutes.Location = New System.Drawing.Point(392, 260)
        Me.vinDeactivationMinutes.Name = "vinDeactivationMinutes"
        Me.vinDeactivationMinutes.RestoreOnLostFocus = False
        Me.vinDeactivationMinutes.Size = New System.Drawing.Size(76, 24)
        Me.vinDeactivationMinutes.TabIndex = 15
        Me.vinDeactivationMinutes.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationMinutes.Unit.FontClass = "Labels"
        Me.vinDeactivationMinutes.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDeactivationMinutes.Unit.SizeRatio = 0.45
        Me.vinDeactivationMinutes.Unit.Text.Text = "untMinutes"
        Me.vinDeactivationMinutes.Unit.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinDeactivationMinutes.Unit.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinDeactivationMinutes.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDeactivationMinutes.VWItem.Name = "__UNLINKED_I2"
        '
        'vinDeactivationHours
        '
        Me.vinDeactivationHours.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationHours.FontClass = "Inputs"
        Me.vinDeactivationHours.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationHours.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinDeactivationHours.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDeactivationHours.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDeactivationHours.Location = New System.Drawing.Point(316, 260)
        Me.vinDeactivationHours.Name = "vinDeactivationHours"
        Me.vinDeactivationHours.RestoreOnLostFocus = False
        Me.vinDeactivationHours.Size = New System.Drawing.Size(76, 24)
        Me.vinDeactivationHours.TabIndex = 14
        Me.vinDeactivationHours.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationHours.Unit.FontClass = "Labels"
        Me.vinDeactivationHours.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDeactivationHours.Unit.SizeRatio = 0.45
        Me.vinDeactivationHours.Unit.Text.Text = "untHours"
        Me.vinDeactivationHours.Unit.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinDeactivationHours.Unit.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinDeactivationHours.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDeactivationHours.VWItem.Name = "__UNLINKED_I2"
        '
        'vinDeactivationDays
        '
        Me.vinDeactivationDays.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationDays.FontClass = "Inputs"
        Me.vinDeactivationDays.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationDays.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinDeactivationDays.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDeactivationDays.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDeactivationDays.Location = New System.Drawing.Point(240, 260)
        Me.vinDeactivationDays.Name = "vinDeactivationDays"
        Me.vinDeactivationDays.RestoreOnLostFocus = False
        Me.vinDeactivationDays.Size = New System.Drawing.Size(76, 24)
        Me.vinDeactivationDays.TabIndex = 13
        Me.vinDeactivationDays.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDeactivationDays.Unit.FontClass = "Labels"
        Me.vinDeactivationDays.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDeactivationDays.Unit.SizeRatio = 0.45
        Me.vinDeactivationDays.Unit.Text.Text = "untDays"
        Me.vinDeactivationDays.Unit.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinDeactivationDays.Unit.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinDeactivationDays.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDeactivationDays.VWItem.Name = "__UNLINKED_I2"
        '
        'dtiDeactivationTime
        '
        Me.dtiDeactivationTime.ButtonWidth = 1
        Me.dtiDeactivationTime.Enabled = False
        Me.dtiDeactivationTime.FontClass = "Inputs"
        Me.dtiDeactivationTime.Location = New System.Drawing.Point(240, 232)
        Me.dtiDeactivationTime.Name = "dtiDeactivationTime"
        Me.dtiDeactivationTime.ShowLeftRight = True
        Me.dtiDeactivationTime.Size = New System.Drawing.Size(228, 24)
        Me.dtiDeactivationTime.TabIndex = 12
        Me.dtiDeactivationTime.TimeSettings.Delay1 = 1000
        Me.dtiDeactivationTime.TimeSettings.Delay2 = 3000
        Me.dtiDeactivationTime.TimeSettings.Delay3 = 3000
        Me.dtiDeactivationTime.TimeSettings.Interval1 = 500
        Me.dtiDeactivationTime.TimeSettings.Interval2 = 250
        Me.dtiDeactivationTime.TimeSettings.Interval3 = 100
        Me.dtiDeactivationTime.UpDownStyle = VisiWinNET.Forms.DateTimeInButtonStyle.Horizontal
        '
        'rbtDeactivationDuration
        '
        Me.rbtDeactivationDuration.CheckSize = 24
        Me.rbtDeactivationDuration.FontClass = "Labels"
        Me.rbtDeactivationDuration.LocalizedText.Text = "rbtDeactivationDuration"
        Me.rbtDeactivationDuration.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.rbtDeactivationDuration.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.rbtDeactivationDuration.Location = New System.Drawing.Point(138, 259)
        Me.rbtDeactivationDuration.Name = "rbtDeactivationDuration"
        Me.rbtDeactivationDuration.OptionGroup.Number = 1
        Me.rbtDeactivationDuration.Size = New System.Drawing.Size(98, 26)
        Me.rbtDeactivationDuration.TabIndex = 11
        Me.rbtDeactivationDuration.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtDeactivationTime
        '
        Me.rbtDeactivationTime.FontClass = "Labels"
        Me.rbtDeactivationTime.LocalizedText.Text = "rbtDeactivationTime"
        Me.rbtDeactivationTime.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.rbtDeactivationTime.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.rbtDeactivationTime.Location = New System.Drawing.Point(138, 232)
        Me.rbtDeactivationTime.Name = "rbtDeactivationTime"
        Me.rbtDeactivationTime.OptionGroup.Number = 1
        Me.rbtDeactivationTime.Size = New System.Drawing.Size(110, 24)
        Me.rbtDeactivationTime.TabIndex = 10
        Me.rbtDeactivationTime.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtNoDeactivation
        '
        Me.rbtNoDeactivation.FontClass = "Labels"
        Me.rbtNoDeactivation.LocalizedText.Text = "rbtNoDeactivation"
        Me.rbtNoDeactivation.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.rbtNoDeactivation.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.rbtNoDeactivation.Location = New System.Drawing.Point(138, 204)
        Me.rbtNoDeactivation.Name = "rbtNoDeactivation"
        Me.rbtNoDeactivation.OptionGroup.Number = 1
        Me.rbtNoDeactivation.Size = New System.Drawing.Size(98, 24)
        Me.rbtNoDeactivation.TabIndex = 9
        Me.rbtNoDeactivation.VWItem.Name = "__UNLINKED_BOOL"
        '
        'lblDeactivation
        '
        Me.lblDeactivation.Blink.FinalBlinkState = False
        Me.lblDeactivation.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblDeactivation.FontClass = "Labels"
        Me.lblDeactivation.LocalizedText.Text = "lblDeactivation"
        Me.lblDeactivation.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.lblDeactivation.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.lblDeactivation.Location = New System.Drawing.Point(8, 204)
        Me.lblDeactivation.Name = "lblDeactivation"
        Me.lblDeactivation.Size = New System.Drawing.Size(130, 24)
        Me.lblDeactivation.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'vinComment
        '
        Me.vinComment.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinComment.FocusNext = True
        Me.vinComment.FontClass = "Inputs"
        Me.vinComment.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinComment.Label.FontClass = "Labels"
        Me.vinComment.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinComment.Label.SizeRatio = 0.28
        Me.vinComment.Label.Text.Text = "lblComment"
        Me.vinComment.Label.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinComment.Label.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinComment.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinComment.Location = New System.Drawing.Point(8, 288)
        Me.vinComment.Name = "vinComment"
        Me.vinComment.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinComment.RestoreOnLostFocus = False
        Me.vinComment.Size = New System.Drawing.Size(460, 24)
        Me.vinComment.TabIndex = 16
        Me.vinComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinComment.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinComment.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinComment.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinComment.Unit.SizeRatio = 0.25
        Me.vinComment.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinComment.VWItem.Name = "__UNLINKED_BSTR"
        '
        'vinMachineCode
        '
        Me.vinMachineCode.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMachineCode.FocusNext = True
        Me.vinMachineCode.FontClass = "Inputs"
        Me.vinMachineCode.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMachineCode.Label.FontClass = "Labels"
        Me.vinMachineCode.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinMachineCode.Label.SizeRatio = 0.28
        Me.vinMachineCode.Label.Text.Text = "lblMachineCode"
        Me.vinMachineCode.Label.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinMachineCode.Label.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinMachineCode.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinMachineCode.Location = New System.Drawing.Point(8, 64)
        Me.vinMachineCode.Name = "vinMachineCode"
        Me.vinMachineCode.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinMachineCode.RestoreOnLostFocus = False
        Me.vinMachineCode.Size = New System.Drawing.Size(460, 24)
        Me.vinMachineCode.TabIndex = 3
        Me.vinMachineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinMachineCode.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMachineCode.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinMachineCode.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinMachineCode.Unit.SizeRatio = 0.25
        Me.vinMachineCode.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinMachineCode.VWItem.Name = "__UNLINKED_BSTR"
        '
        'vinRepeatPassword
        '
        Me.vinRepeatPassword.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinRepeatPassword.FocusNext = True
        Me.vinRepeatPassword.FontClass = "Inputs"
        Me.vinRepeatPassword.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinRepeatPassword.Label.FontClass = "Labels"
        Me.vinRepeatPassword.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinRepeatPassword.Label.SizeRatio = 0.28
        Me.vinRepeatPassword.Label.Text.Text = "lblRepeatPassword"
        Me.vinRepeatPassword.Label.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinRepeatPassword.Label.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinRepeatPassword.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinRepeatPassword.Location = New System.Drawing.Point(8, 148)
        Me.vinRepeatPassword.Name = "vinRepeatPassword"
        Me.vinRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.vinRepeatPassword.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinRepeatPassword.RestoreOnLostFocus = False
        Me.vinRepeatPassword.Size = New System.Drawing.Size(460, 24)
        Me.vinRepeatPassword.TabIndex = 7
        Me.vinRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinRepeatPassword.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinRepeatPassword.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinRepeatPassword.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinRepeatPassword.Unit.SizeRatio = 0.25
        Me.vinRepeatPassword.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinRepeatPassword.VWItem.Name = "__UNLINKED_BSTR"
        '
        'vinPassword
        '
        Me.vinPassword.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinPassword.FocusNext = True
        Me.vinPassword.FontClass = "Inputs"
        Me.vinPassword.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinPassword.Label.FontClass = "Labels"
        Me.vinPassword.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinPassword.Label.SizeRatio = 0.28
        Me.vinPassword.Label.Text.Text = "lblPassword"
        Me.vinPassword.Label.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinPassword.Label.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinPassword.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinPassword.Location = New System.Drawing.Point(8, 120)
        Me.vinPassword.Name = "vinPassword"
        Me.vinPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.vinPassword.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinPassword.RestoreOnLostFocus = False
        Me.vinPassword.Size = New System.Drawing.Size(460, 24)
        Me.vinPassword.TabIndex = 6
        Me.vinPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinPassword.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinPassword.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinPassword.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinPassword.Unit.SizeRatio = 0.25
        Me.vinPassword.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinPassword.VWItem.Name = "__UNLINKED_BSTR"
        '
        'vinFullName
        '
        Me.vinFullName.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinFullName.FocusNext = True
        Me.vinFullName.FontClass = "Inputs"
        Me.vinFullName.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinFullName.Label.FontClass = "Labels"
        Me.vinFullName.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinFullName.Label.SizeRatio = 0.28
        Me.vinFullName.Label.Text.Text = "lblFullName"
        Me.vinFullName.Label.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinFullName.Label.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinFullName.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinFullName.Location = New System.Drawing.Point(8, 36)
        Me.vinFullName.Name = "vinFullName"
        Me.vinFullName.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinFullName.RestoreOnLostFocus = False
        Me.vinFullName.Size = New System.Drawing.Size(460, 24)
        Me.vinFullName.TabIndex = 2
        Me.vinFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinFullName.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinFullName.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinFullName.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinFullName.Unit.SizeRatio = 0.25
        Me.vinFullName.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinFullName.VWItem.Name = "__UNLINKED_BSTR"
        '
        'cboUserGroups
        '
        Me.cboUserGroups.Blink.FinalBlinkState = False
        Me.cboUserGroups.Editable = False
        Me.cboUserGroups.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cboUserGroups.FontClass = "Inputs"
        Me.cboUserGroups.Location = New System.Drawing.Point(138, 92)
        Me.cboUserGroups.Name = "cboUserGroups"
        Me.cboUserGroups.Size = New System.Drawing.Size(330, 24)
        Me.cboUserGroups.TabIndex = 4
        '
        'lblUserGroup
        '
        Me.lblUserGroup.Blink.FinalBlinkState = False
        Me.lblUserGroup.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUserGroup.FontClass = "Labels"
        Me.lblUserGroup.LocalizedText.Text = "lblUserGroup"
        Me.lblUserGroup.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.lblUserGroup.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.lblUserGroup.Location = New System.Drawing.Point(3, 92)
        Me.lblUserGroup.Name = "lblUserGroup"
        Me.lblUserGroup.Size = New System.Drawing.Size(130, 24)
        Me.lblUserGroup.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'lblState
        '
        Me.lblState.Blink.FinalBlinkState = False
        Me.lblState.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblState.FontClass = "Labels"
        Me.lblState.LocalizedText.Text = "lblState"
        Me.lblState.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.lblState.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.lblState.Location = New System.Drawing.Point(8, 176)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(130, 24)
        Me.lblState.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'vinName
        '
        Me.vinName.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinName.FocusNext = True
        Me.vinName.FontClass = "Inputs"
        Me.vinName.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinName.Label.FontClass = "Labels"
        Me.vinName.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinName.Label.SizeRatio = 0.28
        Me.vinName.Label.Text.Text = "lblName"
        Me.vinName.Label.Text.TextGroup = "Dialogs.UserManagement"
        Me.vinName.Label.Text.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.vinName.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinName.Location = New System.Drawing.Point(8, 8)
        Me.vinName.Name = "vinName"
        Me.vinName.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinName.RestoreOnLostFocus = False
        Me.vinName.Size = New System.Drawing.Size(460, 24)
        Me.vinName.TabIndex = 1
        Me.vinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinName.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinName.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinName.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinName.Unit.SizeRatio = 0.25
        Me.vinName.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinName.VWItem.Name = "__UNLINKED_BSTR"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose.LocalizedText.Text = "r"
        Me.cmdClose.Location = New System.Drawing.Point(470, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.TabStop = False
        Me.cmdClose.TextAlign = VisiWinNET.Forms.ContentAlign.TopLeft
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCaption.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCaption.FontClass = "Captions"
        Me.lblCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCaption.LocalizedText.Text = "capAddUser"
        Me.lblCaption.LocalizedText.TextGroup = "Dialogs.UserManagement"
        Me.lblCaption.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(490, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'FUser
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(490, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.grp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        CType(Me.chkChangeMachineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinDeactivationMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinDeactivationHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinDeactivationDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDeactivationTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtDeactivationDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtDeactivationTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtNoDeactivation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDeactivation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinMachineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinRepeatPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinFullName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUserGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents cmdCancel As VisiWinNET.Forms.CommandButton
    Private WithEvents cmdOK As VisiWinNET.Forms.CommandButton
    Private WithEvents grp As VisiWinNET.Forms.GroupBox
    Private WithEvents vinComment As VisiWinNET.Forms.VarIn
    Private WithEvents vinMachineCode As VisiWinNET.Forms.VarIn
    Private WithEvents vinRepeatPassword As VisiWinNET.Forms.VarIn
    Private WithEvents vinPassword As VisiWinNET.Forms.VarIn
    Private WithEvents vinFullName As VisiWinNET.Forms.VarIn
    Private WithEvents cboUserGroups As VisiWinNET.Forms.ComboBox
    Private WithEvents lblUserGroup As VisiWinNET.Forms.Label
    Private WithEvents lblState As VisiWinNET.Forms.Label
    Private WithEvents vinName As VisiWinNET.Forms.VarIn
    Private WithEvents cboState As VisiWinNET.Forms.ComboBox
    Private WithEvents cmdClose As VisiWinNET.Forms.CommandButton
    Private WithEvents lblCaption As VisiWinNET.Forms.Label
    Private WithEvents dtiDeactivationTime As VisiWinNET.Forms.DateTimeIn
    Private WithEvents rbtDeactivationDuration As VisiWinNET.Forms.RadioButton
    Private WithEvents rbtDeactivationTime As VisiWinNET.Forms.RadioButton
    Private WithEvents rbtNoDeactivation As VisiWinNET.Forms.RadioButton
    Private WithEvents lblDeactivation As VisiWinNET.Forms.Label
    Private WithEvents vinDeactivationDays As VisiWinNET.Forms.VarIn
    Private WithEvents vinDeactivationHours As VisiWinNET.Forms.VarIn
    Private WithEvents vinDeactivationMinutes As VisiWinNET.Forms.VarIn
    Private WithEvents chkChangePassword As VisiWinNET.Forms.CheckBox
    Private WithEvents chkChangeMachineCode As VisiWinNET.Forms.CheckBox

End Class
