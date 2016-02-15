<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTrendSelect
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

    'HINWEIS: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdAdd = New VisiWinNET.Forms.CommandButton
        Me.grpExistingTrends = New VisiWinNET.Forms.GroupBox
        Me.cmdAddAll = New VisiWinNET.Forms.CommandButton
        Me.lstAvailableTrends = New VisiWinNET.Forms.ListBox
        Me.cmbArchives = New VisiWinNET.Forms.ComboBox
        Me.cmdRemoveAll = New VisiWinNET.Forms.CommandButton
        Me.cmdRemove = New VisiWinNET.Forms.CommandButton
        Me.lvwSelectedTrends = New VisiWinNET.Forms.ListView
        Me.cmdChangeColor = New VisiWinNET.Forms.CommandButton
        Me.lblSelectedTrends = New VisiWinNET.Forms.Label
        Me.lblAvailableTrends = New VisiWinNET.Forms.Label
        Me.lblArchives = New VisiWinNET.Forms.Label
        Me.Trend = New System.Windows.Forms.ColumnHeader
        Me.Archive = New System.Windows.Forms.ColumnHeader
        Me.cmdOK = New VisiWinNET.Forms.CommandButton
        Me.cmdCancel = New VisiWinNET.Forms.CommandButton
        Me.cmdClose2 = New VisiWinNET.Forms.CommandButton
        Me.lblCaption = New VisiWinNET.Forms.Label
        CType(Me.cmdAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpExistingTrends, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExistingTrends.SuspendLayout()
        CType(Me.cmdAddAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstAvailableTrends, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArchives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRemoveAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvwSelectedTrends, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdChangeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSelectedTrends, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAvailableTrends, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblArchives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAdd.LocalizedText.Text = "è"
        Me.cmdAdd.Location = New System.Drawing.Point(220, 68)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 28)
        Me.cmdAdd.TabIndex = 3
        '
        'grpExistingTrends
        '
        Me.grpExistingTrends.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExistingTrends.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.grpExistingTrends.Controls.Add(Me.cmdAddAll)
        Me.grpExistingTrends.Controls.Add(Me.lstAvailableTrends)
        Me.grpExistingTrends.Controls.Add(Me.cmbArchives)
        Me.grpExistingTrends.Controls.Add(Me.cmdRemoveAll)
        Me.grpExistingTrends.Controls.Add(Me.cmdRemove)
        Me.grpExistingTrends.Controls.Add(Me.cmdAdd)
        Me.grpExistingTrends.Controls.Add(Me.lvwSelectedTrends)
        Me.grpExistingTrends.Controls.Add(Me.cmdChangeColor)
        Me.grpExistingTrends.Controls.Add(Me.lblSelectedTrends)
        Me.grpExistingTrends.Controls.Add(Me.lblAvailableTrends)
        Me.grpExistingTrends.Controls.Add(Me.lblArchives)
        Me.grpExistingTrends.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpExistingTrends.Location = New System.Drawing.Point(8, 28)
        Me.grpExistingTrends.Name = "grpExistingTrends"
        Me.grpExistingTrends.Size = New System.Drawing.Size(724, 252)
        Me.grpExistingTrends.TabIndex = 4
        '
        'cmdAddAll
        '
        Me.cmdAddAll.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAddAll.LocalizedText.Text = "èèè"
        Me.cmdAddAll.Location = New System.Drawing.Point(220, 100)
        Me.cmdAddAll.Name = "cmdAddAll"
        Me.cmdAddAll.Size = New System.Drawing.Size(56, 28)
        Me.cmdAddAll.TabIndex = 14
        '
        'lstAvailableTrends
        '
        Me.lstAvailableTrends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstAvailableTrends.FontClass = "Inputs"
        Me.lstAvailableTrends.IntegralHeight = False
        Me.lstAvailableTrends.Location = New System.Drawing.Point(8, 68)
        Me.lstAvailableTrends.Name = "lstAvailableTrends"
        Me.lstAvailableTrends.Size = New System.Drawing.Size(204, 176)
        Me.lstAvailableTrends.TabIndex = 4
        Me.lstAvailableTrends.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientApplication
        '
        'cmbArchives
        '
        Me.cmbArchives.Editable = False
        Me.cmbArchives.FocusRect = True
        Me.cmbArchives.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmbArchives.FontClass = "Inputs"
        Me.cmbArchives.Location = New System.Drawing.Point(8, 24)
        Me.cmbArchives.Name = "cmbArchives"
        Me.cmbArchives.Size = New System.Drawing.Size(204, 23)
        Me.cmbArchives.TabIndex = 3
        '
        'cmdRemoveAll
        '
        Me.cmdRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemoveAll.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdRemoveAll.LocalizedText.Text = "ççç"
        Me.cmdRemoveAll.Location = New System.Drawing.Point(220, 180)
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.Size = New System.Drawing.Size(56, 28)
        Me.cmdRemoveAll.TabIndex = 8
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdRemove.LocalizedText.Text = "ç"
        Me.cmdRemove.Location = New System.Drawing.Point(220, 148)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(56, 28)
        Me.cmdRemove.TabIndex = 7
        '
        'lvwSelectedTrends
        '
        Me.lvwSelectedTrends.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwSelectedTrends.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.ListViewCheckBoxColumn("colScaleVisible", "Forms.FTrendSelect", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colScaleVisible", 44, System.Windows.Forms.HorizontalAlignment.Center, VisiWinNET.Forms.ColumnTypes.CheckBox, True, True, CType(0, Short), True), New VisiWinNET.Forms.ListViewImageColumn("colColor", "Forms.FTrendSelect", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colColor", 44, System.Windows.Forms.HorizontalAlignment.Center, VisiWinNET.Forms.ColumnTypes.Image, False, True), New VisiWinNET.Forms.ListViewTextColumn("colArchive", "Forms.FTrendSelect", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colArchive", 160, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True), New VisiWinNET.Forms.ListViewTextColumn("colTrend", "Forms.FTrendSelect", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "colTrend", 161, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True)})
        Me.lvwSelectedTrends.Header.FontClass = "Labels"
        Me.lvwSelectedTrends.Header.Height = 32
        Me.lvwSelectedTrends.Location = New System.Drawing.Point(284, 24)
        Me.lvwSelectedTrends.Name = "lvwSelectedTrends"
        Me.lvwSelectedTrends.ScrollBarProperties.Width = 19
        Me.lvwSelectedTrends.Size = New System.Drawing.Size(432, 220)

        Me.lvwSelectedTrends.TabIndex = 2
        '
        'cmdChangeColor
        '
        Me.cmdChangeColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdChangeColor.Blink.FinalBlinkState = False
        Me.cmdChangeColor.FontClass = "Buttons"
        Me.cmdChangeColor.LocalizedText.Text = "cmdChangeColor"
        Me.cmdChangeColor.LocalizedText.TextGroup = "Forms.FTrendSelect"
        Me.cmdChangeColor.Location = New System.Drawing.Point(220, 212)
        Me.cmdChangeColor.Name = "cmdChangeColor"
        Me.cmdChangeColor.Size = New System.Drawing.Size(56, 32)
        Me.cmdChangeColor.TabIndex = 13
        '
        'lblSelectedTrends
        '
        Me.lblSelectedTrends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSelectedTrends.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblSelectedTrends.FontClass = "Labels"
        Me.lblSelectedTrends.LocalizedText.Text = "lblSelectedTrends"
        Me.lblSelectedTrends.LocalizedText.TextGroup = "Forms.FTrendSelect"
        Me.lblSelectedTrends.Location = New System.Drawing.Point(288, 8)
        Me.lblSelectedTrends.Name = "lblSelectedTrends"
        Me.lblSelectedTrends.Size = New System.Drawing.Size(424, 16)
        Me.lblSelectedTrends.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblAvailableTrends
        '
        Me.lblAvailableTrends.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAvailableTrends.FontClass = "Labels"
        Me.lblAvailableTrends.LocalizedText.Text = "lblAvailableTrends"
        Me.lblAvailableTrends.LocalizedText.TextGroup = "Forms.FTrendSelect"
        Me.lblAvailableTrends.Location = New System.Drawing.Point(12, 52)
        Me.lblAvailableTrends.Name = "lblAvailableTrends"
        Me.lblAvailableTrends.Size = New System.Drawing.Size(200, 16)
        Me.lblAvailableTrends.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblArchives
        '
        Me.lblArchives.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblArchives.FontClass = "Labels"
        Me.lblArchives.LocalizedText.Text = "lblArchives"
        Me.lblArchives.LocalizedText.TextGroup = "Forms.FTrendSelect"
        Me.lblArchives.Location = New System.Drawing.Point(12, 8)
        Me.lblArchives.Name = "lblArchives"
        Me.lblArchives.Size = New System.Drawing.Size(200, 16)
        Me.lblArchives.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Trend
        '
        Me.Trend.Width = 96
        '
        'Archive
        '
        Me.Archive.Width = 100
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Blink.FinalBlinkState = False
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.FontClass = "Buttons"
        Me.cmdOK.LocalizedText.Text = "cmdOK"
        Me.cmdOK.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdOK.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdOK.Location = New System.Drawing.Point(544, 288)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 28)
        Me.cmdOK.TabIndex = 11
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Blink.FinalBlinkState = False
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FontClass = "Buttons"
        Me.cmdCancel.LocalizedText.Text = "cmdCancel"
        Me.cmdCancel.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdCancel.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdCancel.Location = New System.Drawing.Point(636, 288)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 28)
        Me.cmdCancel.TabIndex = 12
        '
        'cmdClose2
        '
        Me.cmdClose2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose2.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose2.LocalizedText.Text = "r"
        Me.cmdClose2.Location = New System.Drawing.Point(719, 2)
        Me.cmdClose2.Name = "cmdClose2"
        Me.cmdClose2.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose2.TabIndex = 14
        Me.cmdClose2.TabStop = False
        Me.cmdClose2.TextAlign = VisiWinNET.Forms.ContentAlign.TopLeft
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCaption.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCaption.FontClass = "Captions"
        Me.lblCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCaption.LocalizedText.Text = "capTrendSelect"
        Me.lblCaption.LocalizedText.TextGroup = "Forms.FTrendSelect"
        Me.lblCaption.LocalizedText.TextPrefix = "capTrendSelect"
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(738, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'FTrendSelect
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(738, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose2)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.grpExistingTrends)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 308)
        Me.Name = "FTrendSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cmdAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpExistingTrends, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExistingTrends.ResumeLayout(False)
        CType(Me.cmdAddAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstAvailableTrends, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArchives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRemoveAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvwSelectedTrends, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdChangeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSelectedTrends, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAvailableTrends, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblArchives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	Private WithEvents cmbArchives As VisiWinNET.Forms.ComboBox
	Private WithEvents Trend As System.Windows.Forms.ColumnHeader
	Private WithEvents Archive As System.Windows.Forms.ColumnHeader
	Private WithEvents cmdOK As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdCancel As VisiWinNET.Forms.CommandButton
	Private WithEvents grpExistingTrends As VisiWinNET.Forms.GroupBox
	Private WithEvents lblArchives As VisiWinNET.Forms.Label
	Private WithEvents lstAvailableTrends As VisiWinNET.Forms.ListBox
	Private WithEvents lvwSelectedTrends As VisiWinNET.Forms.ListView
	Private WithEvents lblAvailableTrends As VisiWinNET.Forms.Label
	Private WithEvents lblSelectedTrends As VisiWinNET.Forms.Label
	Private WithEvents cmdAdd As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdRemoveAll As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdRemove As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdAddAll As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdClose2 As VisiWinNET.Forms.CommandButton
	Private WithEvents lblCaption As VisiWinNET.Forms.Label
	Private WithEvents cmdChangeColor As VisiWinNET.Forms.CommandButton

End Class
