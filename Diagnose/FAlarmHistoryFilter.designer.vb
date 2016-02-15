<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAlarmHistoryFilter
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAlarmHistoryFilter))
        Me.cmdCancel = New VisiWinNET.Forms.CommandButton
        Me.cmdOK = New VisiWinNET.Forms.CommandButton
        Me.fraFilter = New VisiWinNET.Forms.GroupBox
        Me.lvwGroups = New VisiWinNET.Forms.ListView
        Me.lvwClasses = New VisiWinNET.Forms.ListView
        Me.fraStates = New VisiWinNET.Forms.GroupBox
        Me.chkState5 = New VisiWinNET.Forms.CheckBox
        Me.chkState4 = New VisiWinNET.Forms.CheckBox
        Me.chkState3 = New VisiWinNET.Forms.CheckBox
        Me.chkState2 = New VisiWinNET.Forms.CheckBox
        Me.chkState1 = New VisiWinNET.Forms.CheckBox
        Me.fraPriority = New VisiWinNET.Forms.GroupBox
        Me.Label2 = New VisiWinNET.Forms.Label
        Me.vinMaxPriority = New VisiWinNET.Forms.VarIn
        Me.vinMinPriority = New VisiWinNET.Forms.VarIn
        Me.rbtPriorityFromTo = New VisiWinNET.Forms.RadioButton
        Me.rbtPriorityAll = New VisiWinNET.Forms.RadioButton
        Me.fraDateTime = New VisiWinNET.Forms.GroupBox
        Me.Label1 = New VisiWinNET.Forms.Label
        Me.DateTimeIn2 = New VisiWinNET.Forms.DateTimeIn
        Me.DateTimeIn1 = New VisiWinNET.Forms.DateTimeIn
        Me.rbtTimeFilterLastWeek = New VisiWinNET.Forms.RadioButton
        Me.rbtTimeFilterYesterday = New VisiWinNET.Forms.RadioButton
        Me.rbtTimeFilterFromTo = New VisiWinNET.Forms.RadioButton
        Me.rbtTimeFilterThisWeek = New VisiWinNET.Forms.RadioButton
        Me.rbtTimeFilterToday = New VisiWinNET.Forms.RadioButton
        Me.rbtTimeFilterAll = New VisiWinNET.Forms.RadioButton
        Me.cmdClose = New VisiWinNET.Forms.CommandButton
        Me.lblCaption = New VisiWinNET.Forms.Label
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fraFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraFilter.SuspendLayout()
        CType(Me.lvwGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvwClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fraStates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraStates.SuspendLayout()
        CType(Me.chkState5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkState4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkState3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkState2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkState1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fraPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPriority.SuspendLayout()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinMaxPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinMinPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtPriorityFromTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtPriorityAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fraDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDateTime.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeIn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeIn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTimeFilterLastWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTimeFilterYesterday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTimeFilterFromTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTimeFilterThisWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTimeFilterToday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTimeFilterAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FontClass = "Buttons"
        Me.cmdCancel.LocalizedText.Text = "cmdCancel"
        Me.cmdCancel.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdCancel.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdCancel.Location = New System.Drawing.Point(412, 441)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 28)
        Me.cmdCancel.TabIndex = 2
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.FontClass = "Buttons"
        Me.cmdOK.LocalizedText.Text = "cmdOK"
        Me.cmdOK.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdOK.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdOK.Location = New System.Drawing.Point(316, 441)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 28)
        Me.cmdOK.TabIndex = 1
        '
        'fraFilter
        '
        Me.fraFilter.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.fraFilter.Controls.Add(Me.lvwGroups)
        Me.fraFilter.Controls.Add(Me.lvwClasses)
        Me.fraFilter.Controls.Add(Me.fraStates)
        Me.fraFilter.Controls.Add(Me.fraPriority)
        Me.fraFilter.Controls.Add(Me.fraDateTime)
        Me.fraFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraFilter.Location = New System.Drawing.Point(8, 28)
        Me.fraFilter.Name = "fraFilter"
        Me.fraFilter.Size = New System.Drawing.Size(501, 405)
        Me.fraFilter.TabIndex = 0
        '
        'lvwGroups
        '
        Me.lvwGroups.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.ListViewCheckBoxColumn("", "", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colSelected", 30, System.Windows.Forms.HorizontalAlignment.Center, VisiWinNET.Forms.ColumnTypes.CheckBox, True, True, CType(19, Short), True), New VisiWinNET.Forms.ListViewTextColumn("hdrGroups", "Forms.AlarmManagement", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colName", 142, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True)})
        Me.lvwGroups.FontClass = "Labels"
        Me.lvwGroups.Header.FontClass = "Captions"
        Me.lvwGroups.Location = New System.Drawing.Point(272, 10)
        Me.lvwGroups.Name = "lvwGroups"
        Me.lvwGroups.Size = New System.Drawing.Size(219, 238)

        Me.lvwGroups.TabIndex = 3
        '
        'lvwClasses
        '
        Me.lvwClasses.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.ListViewCheckBoxColumn("", "", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colSelected", 30, System.Windows.Forms.HorizontalAlignment.Center, VisiWinNET.Forms.ColumnTypes.CheckBox, True, True, CType(19, Short), True), New VisiWinNET.Forms.ListViewTextColumn("hdrClasses", "Forms.AlarmManagement", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colName", 142, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True)})
        Me.lvwClasses.FontClass = "Labels"
        Me.lvwClasses.Header.FontClass = "Captions"
        Me.lvwClasses.Location = New System.Drawing.Point(272, 256)
        Me.lvwClasses.Name = "lvwClasses"
        Me.lvwClasses.Size = New System.Drawing.Size(219, 140)

        Me.lvwClasses.TabIndex = 4
        Me.lvwClasses.Visible = False
        '
        'fraStates
        '
        Me.fraStates.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.fraStates.Controls.Add(Me.chkState5)
        Me.fraStates.Controls.Add(Me.chkState4)
        Me.fraStates.Controls.Add(Me.chkState3)
        Me.fraStates.Controls.Add(Me.chkState2)
        Me.fraStates.Controls.Add(Me.chkState1)
        Me.fraStates.FontClass = "Captions"
        Me.fraStates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraStates.LocalizedText.Text = "fraStates"
        Me.fraStates.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.fraStates.Location = New System.Drawing.Point(8, 252)
        Me.fraStates.Name = "fraStates"
        Me.fraStates.Size = New System.Drawing.Size(260, 144)
        Me.fraStates.TabIndex = 2
        Me.fraStates.Visible = False
        '
        'chkState5
        '
        Me.chkState5.FontClass = "Labels"
        Me.chkState5.LocalizedText.Text = "chkResetted"
        Me.chkState5.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.chkState5.Location = New System.Drawing.Point(8, 116)
        Me.chkState5.Name = "chkState5"
        Me.chkState5.Size = New System.Drawing.Size(244, 18)
        Me.chkState5.TabIndex = 4
        Me.chkState5.Tag = "Gruppe1"
        Me.chkState5.Visible = False
        Me.chkState5.VWItem.Name = "__UNLINKED_BOOL"
        '
        'chkState4
        '
        Me.chkState4.FontClass = "Labels"
        Me.chkState4.LocalizedText.Text = "chkAckDeactivated"
        Me.chkState4.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.chkState4.Location = New System.Drawing.Point(8, 92)
        Me.chkState4.Name = "chkState4"
        Me.chkState4.Size = New System.Drawing.Size(244, 18)
        Me.chkState4.TabIndex = 3
        Me.chkState4.Tag = "Gruppe1"
        Me.chkState4.Visible = False
        Me.chkState4.VWItem.Name = "__UNLINKED_BOOL"
        '
        'chkState3
        '
        Me.chkState3.FontClass = "Labels"
        Me.chkState3.LocalizedText.Text = "chkActiveAck"
        Me.chkState3.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.chkState3.Location = New System.Drawing.Point(8, 44)
        Me.chkState3.Name = "chkState3"
        Me.chkState3.Size = New System.Drawing.Size(244, 18)
        Me.chkState3.TabIndex = 1
        Me.chkState3.Tag = "Gruppe1"
        Me.chkState3.Visible = False
        Me.chkState3.VWItem.Name = "__UNLINKED_BOOL"
        '
        'chkState2
        '
        Me.chkState2.FontClass = "Labels"
        Me.chkState2.LocalizedText.Text = "chkDeactivated"
        Me.chkState2.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.chkState2.Location = New System.Drawing.Point(8, 68)
        Me.chkState2.Name = "chkState2"
        Me.chkState2.Size = New System.Drawing.Size(244, 18)
        Me.chkState2.TabIndex = 2
        Me.chkState2.Tag = "Gruppe1"
        Me.chkState2.Visible = False
        Me.chkState2.VWItem.Name = "__UNLINKED_BOOL"
        '
        'chkState1
        '
        Me.chkState1.FontClass = "Labels"
        Me.chkState1.LocalizedText.Text = "chkActivated"
        Me.chkState1.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.chkState1.Location = New System.Drawing.Point(8, 20)
        Me.chkState1.Name = "chkState1"
        Me.chkState1.Size = New System.Drawing.Size(244, 18)
        Me.chkState1.TabIndex = 0
        Me.chkState1.Tag = "Gruppe1"
        Me.chkState1.Visible = False
        Me.chkState1.VWItem.Name = "__UNLINKED_BOOL"
        '
        'fraPriority
        '
        Me.fraPriority.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.fraPriority.Controls.Add(Me.Label2)
        Me.fraPriority.Controls.Add(Me.vinMaxPriority)
        Me.fraPriority.Controls.Add(Me.vinMinPriority)
        Me.fraPriority.Controls.Add(Me.rbtPriorityFromTo)
        Me.fraPriority.Controls.Add(Me.rbtPriorityAll)
        Me.fraPriority.FontClass = "Captions"
        Me.fraPriority.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPriority.LocalizedText.Text = "fraPriority"
        Me.fraPriority.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.fraPriority.Location = New System.Drawing.Point(8, 152)
        Me.fraPriority.Name = "fraPriority"
        Me.fraPriority.Size = New System.Drawing.Size(260, 96)
        Me.fraPriority.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label2.FontClass = "Labels"
        Me.Label2.LocalizedText.Text = "optTo"
        Me.Label2.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.Label2.Location = New System.Drawing.Point(92, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'vinMaxPriority
        '
        Me.vinMaxPriority.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMaxPriority.FontClass = "Inputs"
        Me.vinMaxPriority.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMaxPriority.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinMaxPriority.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinMaxPriority.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinMaxPriority.Location = New System.Drawing.Point(132, 68)
        Me.vinMaxPriority.Name = "vinMaxPriority"
        Me.vinMaxPriority.Size = New System.Drawing.Size(60, 20)
        Me.vinMaxPriority.TabIndex = 3
        Me.vinMaxPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinMaxPriority.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMaxPriority.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinMaxPriority.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinMaxPriority.Unit.SizeRatio = 0.25
        Me.vinMaxPriority.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinMaxPriority.VWItem.Name = "__UNLINKED_UI2"
        '
        'vinMinPriority
        '
        Me.vinMinPriority.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMinPriority.FontClass = "Inputs"
        Me.vinMinPriority.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMinPriority.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinMinPriority.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinMinPriority.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinMinPriority.Location = New System.Drawing.Point(132, 44)
        Me.vinMinPriority.Name = "vinMinPriority"
        Me.vinMinPriority.Size = New System.Drawing.Size(60, 20)
        Me.vinMinPriority.TabIndex = 2
        Me.vinMinPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinMinPriority.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinMinPriority.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinMinPriority.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinMinPriority.Unit.SizeRatio = 0.25
        Me.vinMinPriority.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinMinPriority.VWItem.Name = "__UNLINKED_UI2"
        '
        'rbtPriorityFromTo
        '
        Me.rbtPriorityFromTo.FontClass = "Labels"
        Me.rbtPriorityFromTo.LocalizedText.Text = "optFrom"
        Me.rbtPriorityFromTo.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtPriorityFromTo.Location = New System.Drawing.Point(8, 44)
        Me.rbtPriorityFromTo.Name = "rbtPriorityFromTo"
        Me.rbtPriorityFromTo.OptionGroup.Number = 2
        Me.rbtPriorityFromTo.Size = New System.Drawing.Size(120, 20)
        Me.rbtPriorityFromTo.TabIndex = 1
        Me.rbtPriorityFromTo.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtPriorityAll
        '
        Me.rbtPriorityAll.FontClass = "Labels"
        Me.rbtPriorityAll.LocalizedText.Text = "optAll"
        Me.rbtPriorityAll.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtPriorityAll.Location = New System.Drawing.Point(8, 20)
        Me.rbtPriorityAll.Name = "rbtPriorityAll"
        Me.rbtPriorityAll.OptionGroup.Number = 2
        Me.rbtPriorityAll.Size = New System.Drawing.Size(120, 20)
        Me.rbtPriorityAll.TabIndex = 0
        Me.rbtPriorityAll.VWItem.Name = "__UNLINKED_BOOL"
        '
        'fraDateTime
        '
        Me.fraDateTime.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.fraDateTime.Controls.Add(Me.Label1)
        Me.fraDateTime.Controls.Add(Me.DateTimeIn2)
        Me.fraDateTime.Controls.Add(Me.DateTimeIn1)
        Me.fraDateTime.Controls.Add(Me.rbtTimeFilterLastWeek)
        Me.fraDateTime.Controls.Add(Me.rbtTimeFilterYesterday)
        Me.fraDateTime.Controls.Add(Me.rbtTimeFilterFromTo)
        Me.fraDateTime.Controls.Add(Me.rbtTimeFilterThisWeek)
        Me.fraDateTime.Controls.Add(Me.rbtTimeFilterToday)
        Me.fraDateTime.Controls.Add(Me.rbtTimeFilterAll)
        Me.fraDateTime.FontClass = "Captions"
        Me.fraDateTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDateTime.LocalizedText.Text = "fraTime"
        Me.fraDateTime.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.fraDateTime.Location = New System.Drawing.Point(8, 4)
        Me.fraDateTime.Name = "fraDateTime"
        Me.fraDateTime.Size = New System.Drawing.Size(260, 144)
        Me.fraDateTime.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label1.FontClass = "Labels"
        Me.Label1.LocalizedText.Text = "optTo"
        Me.Label1.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.Label1.Location = New System.Drawing.Point(92, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'DateTimeIn2
        '
        Me.DateTimeIn2.ButtonWidth = 1
        Me.DateTimeIn2.DateTimeFormat.Mode = VisiWinNET.LanguageSwitching.DateTimeMode.DateOnly
        Me.DateTimeIn2.FontClass = "Inputs"
        Me.DateTimeIn2.Location = New System.Drawing.Point(132, 116)
        Me.DateTimeIn2.Name = "DateTimeIn2"
        Me.DateTimeIn2.ShowUpDown = False
        Me.DateTimeIn2.Size = New System.Drawing.Size(120, 20)
        Me.DateTimeIn2.TabIndex = 7
        Me.DateTimeIn2.TimeSettings.Delay1 = 1000
        Me.DateTimeIn2.TimeSettings.Delay2 = 3000
        Me.DateTimeIn2.TimeSettings.Delay3 = 3000
        Me.DateTimeIn2.TimeSettings.Interval1 = 500
        Me.DateTimeIn2.TimeSettings.Interval2 = 250
        Me.DateTimeIn2.TimeSettings.Interval3 = 100
        Me.DateTimeIn2.UpDownStyle = VisiWinNET.Forms.DateTimeInButtonStyle.Horizontal
        '
        'DateTimeIn1
        '
        Me.DateTimeIn1.ButtonWidth = 1
        Me.DateTimeIn1.DateTimeFormat.Mode = VisiWinNET.LanguageSwitching.DateTimeMode.DateOnly
        Me.DateTimeIn1.FontClass = "Inputs"
        Me.DateTimeIn1.Location = New System.Drawing.Point(132, 92)
        Me.DateTimeIn1.Name = "DateTimeIn1"
        Me.DateTimeIn1.ShowUpDown = False
        Me.DateTimeIn1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimeIn1.TabIndex = 6
        Me.DateTimeIn1.TimeSettings.Delay1 = 1000
        Me.DateTimeIn1.TimeSettings.Delay2 = 3000
        Me.DateTimeIn1.TimeSettings.Delay3 = 3000
        Me.DateTimeIn1.TimeSettings.Interval1 = 500
        Me.DateTimeIn1.TimeSettings.Interval2 = 250
        Me.DateTimeIn1.TimeSettings.Interval3 = 100
        '
        'rbtTimeFilterLastWeek
        '
        Me.rbtTimeFilterLastWeek.FontClass = "Labels"
        Me.rbtTimeFilterLastWeek.LocalizedText.Text = "optLastWeek"
        Me.rbtTimeFilterLastWeek.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtTimeFilterLastWeek.Location = New System.Drawing.Point(132, 68)
        Me.rbtTimeFilterLastWeek.Name = "rbtTimeFilterLastWeek"
        Me.rbtTimeFilterLastWeek.OptionGroup.Number = 1
        Me.rbtTimeFilterLastWeek.Size = New System.Drawing.Size(120, 20)
        Me.rbtTimeFilterLastWeek.TabIndex = 4
        Me.rbtTimeFilterLastWeek.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtTimeFilterYesterday
        '
        Me.rbtTimeFilterYesterday.FontClass = "Labels"
        Me.rbtTimeFilterYesterday.LocalizedText.Text = "optYesterday"
        Me.rbtTimeFilterYesterday.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtTimeFilterYesterday.Location = New System.Drawing.Point(132, 44)
        Me.rbtTimeFilterYesterday.Name = "rbtTimeFilterYesterday"
        Me.rbtTimeFilterYesterday.OptionGroup.Number = 1
        Me.rbtTimeFilterYesterday.Size = New System.Drawing.Size(120, 20)
        Me.rbtTimeFilterYesterday.TabIndex = 2
        Me.rbtTimeFilterYesterday.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtTimeFilterFromTo
        '
        Me.rbtTimeFilterFromTo.FontClass = "Labels"
        Me.rbtTimeFilterFromTo.LocalizedText.Text = "optFrom"
        Me.rbtTimeFilterFromTo.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtTimeFilterFromTo.Location = New System.Drawing.Point(8, 92)
        Me.rbtTimeFilterFromTo.Name = "rbtTimeFilterFromTo"
        Me.rbtTimeFilterFromTo.OptionGroup.Number = 1
        Me.rbtTimeFilterFromTo.Size = New System.Drawing.Size(120, 20)
        Me.rbtTimeFilterFromTo.TabIndex = 5
        Me.rbtTimeFilterFromTo.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtTimeFilterThisWeek
        '
        Me.rbtTimeFilterThisWeek.FontClass = "Labels"
        Me.rbtTimeFilterThisWeek.LocalizedText.Text = "optThisWeek"
        Me.rbtTimeFilterThisWeek.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtTimeFilterThisWeek.Location = New System.Drawing.Point(8, 68)
        Me.rbtTimeFilterThisWeek.Name = "rbtTimeFilterThisWeek"
        Me.rbtTimeFilterThisWeek.OptionGroup.Number = 1
        Me.rbtTimeFilterThisWeek.Size = New System.Drawing.Size(120, 20)
        Me.rbtTimeFilterThisWeek.TabIndex = 3
        Me.rbtTimeFilterThisWeek.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtTimeFilterToday
        '
        Me.rbtTimeFilterToday.FontClass = "Labels"
        Me.rbtTimeFilterToday.LocalizedText.Text = "optToday"
        Me.rbtTimeFilterToday.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtTimeFilterToday.Location = New System.Drawing.Point(8, 44)
        Me.rbtTimeFilterToday.Name = "rbtTimeFilterToday"
        Me.rbtTimeFilterToday.OptionGroup.Number = 1
        Me.rbtTimeFilterToday.Size = New System.Drawing.Size(120, 20)
        Me.rbtTimeFilterToday.TabIndex = 1
        Me.rbtTimeFilterToday.VWItem.Name = "__UNLINKED_BOOL"
        '
        'rbtTimeFilterAll
        '
        Me.rbtTimeFilterAll.FontClass = "Labels"
        Me.rbtTimeFilterAll.LocalizedText.Text = "optAll"
        Me.rbtTimeFilterAll.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.rbtTimeFilterAll.Location = New System.Drawing.Point(8, 20)
        Me.rbtTimeFilterAll.Name = "rbtTimeFilterAll"
        Me.rbtTimeFilterAll.OptionGroup.Number = 1
        Me.rbtTimeFilterAll.Size = New System.Drawing.Size(120, 20)
        Me.rbtTimeFilterAll.TabIndex = 0
        Me.rbtTimeFilterAll.VWItem.Name = "__UNLINKED_BOOL"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose.LocalizedText.Text = "r"
        Me.cmdClose.Location = New System.Drawing.Point(496, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.TabStop = False
        Me.cmdClose.TextAlign = VisiWinNET.Forms.ContentAlign.TopLeft
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCaption.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblCaption.FontClass = "Captions"
        Me.lblCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCaption.LocalizedText.Text = "capFilter"
        Me.lblCaption.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(518, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'FAlarmHistoryFilter
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(516, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.fraFilter)
        Me.Controls.Add(Me.lblCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAlarmHistoryFilter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fraFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraFilter.ResumeLayout(False)
        CType(Me.lvwGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvwClasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fraStates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraStates.ResumeLayout(False)
        CType(Me.chkState5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkState4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkState3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkState2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkState1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fraPriority, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPriority.ResumeLayout(False)
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinMaxPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinMinPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtPriorityFromTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtPriorityAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fraDateTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDateTime.ResumeLayout(False)
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeIn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeIn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTimeFilterLastWeek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTimeFilterYesterday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTimeFilterFromTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTimeFilterThisWeek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTimeFilterToday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTimeFilterAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	Private WithEvents cmdCancel As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdOK As VisiWinNET.Forms.CommandButton
	Private WithEvents fraFilter As VisiWinNET.Forms.GroupBox
	Private WithEvents fraStates As VisiWinNET.Forms.GroupBox
	Private WithEvents chkState5 As VisiWinNET.Forms.CheckBox
	Private WithEvents chkState4 As VisiWinNET.Forms.CheckBox
	Private WithEvents chkState3 As VisiWinNET.Forms.CheckBox
	Private WithEvents chkState2 As VisiWinNET.Forms.CheckBox
	Private WithEvents chkState1 As VisiWinNET.Forms.CheckBox
	Private WithEvents fraPriority As VisiWinNET.Forms.GroupBox
	Private WithEvents Label2 As VisiWinNET.Forms.Label
	Private WithEvents vinMaxPriority As VisiWinNET.Forms.VarIn
	Private WithEvents vinMinPriority As VisiWinNET.Forms.VarIn
	Private WithEvents rbtPriorityFromTo As VisiWinNET.Forms.RadioButton
	Private WithEvents rbtPriorityAll As VisiWinNET.Forms.RadioButton
	Private WithEvents fraDateTime As VisiWinNET.Forms.GroupBox
	Private WithEvents Label1 As VisiWinNET.Forms.Label
	Private WithEvents DateTimeIn2 As VisiWinNET.Forms.DateTimeIn
	Private WithEvents DateTimeIn1 As VisiWinNET.Forms.DateTimeIn
	Private WithEvents rbtTimeFilterLastWeek As VisiWinNET.Forms.RadioButton
	Private WithEvents rbtTimeFilterYesterday As VisiWinNET.Forms.RadioButton
	Private WithEvents rbtTimeFilterFromTo As VisiWinNET.Forms.RadioButton
	Private WithEvents rbtTimeFilterThisWeek As VisiWinNET.Forms.RadioButton
	Private WithEvents rbtTimeFilterToday As VisiWinNET.Forms.RadioButton
	Private WithEvents rbtTimeFilterAll As VisiWinNET.Forms.RadioButton
	Private WithEvents cmdClose As VisiWinNET.Forms.CommandButton
	Private WithEvents lblCaption As VisiWinNET.Forms.Label
	Private WithEvents lvwClasses As VisiWinNET.Forms.ListView
	Private WithEvents lvwGroups As VisiWinNET.Forms.ListView

End Class
