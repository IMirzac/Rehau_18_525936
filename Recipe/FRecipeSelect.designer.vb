<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRecipeSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRecipeSelect))
        Me.cmdOK = New VisiWinNET.Forms.CommandButton
        Me.cmdCancel = New VisiWinNET.Forms.CommandButton
        Me.grp = New VisiWinNET.Forms.GroupBox
        Me.RecipeList1 = New VisiWinNET.Forms.Recipe.RecipeList
        Me.lblExistingRecipes = New VisiWinNET.Forms.Label
        Me.vinDescription = New VisiWinNET.Forms.VarIn
        Me.vinName = New VisiWinNET.Forms.VarIn
        Me.cmdClose2 = New VisiWinNET.Forms.CommandButton
        Me.lblCaption = New VisiWinNET.Forms.Label
        Me.cmdDelete = New VisiWinNET.Forms.CommandButton
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        CType(Me.RecipeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExistingRecipes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Blink.FinalBlinkState = False
        Me.cmdOK.FontClass = "Buttons"
        Me.cmdOK.ImageAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        Me.cmdOK.LocalizedText.Text = "cmdOK"
        Me.cmdOK.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdOK.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdOK.Location = New System.Drawing.Point(504, 364)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 36)
        Me.cmdOK.TabIndex = 2
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Blink.FinalBlinkState = False
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FontClass = "Buttons"
        Me.cmdCancel.ImageAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        Me.cmdCancel.LocalizedText.Text = "cmdCancel"
        Me.cmdCancel.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdCancel.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdCancel.Location = New System.Drawing.Point(596, 364)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 36)
        Me.cmdCancel.TabIndex = 3
        '
        'grp
        '
        Me.grp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.grp.Controls.Add(Me.RecipeList1)
        Me.grp.Controls.Add(Me.lblExistingRecipes)
        Me.grp.Controls.Add(Me.vinDescription)
        Me.grp.Controls.Add(Me.vinName)
        Me.grp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp.Location = New System.Drawing.Point(8, 28)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(684, 328)
        Me.grp.TabIndex = 0
        '
        'RecipeList1
        '
        Me.RecipeList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecipeList1.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.Recipe.RecipeListColumn(VisiWinNET.Forms.Recipe.RecipeListProperties.FileName, "FileName", "Dateiname", 194, System.Windows.Forms.HorizontalAlignment.Left, True, True), New VisiWinNET.Forms.Recipe.RecipeListColumn(VisiWinNET.Forms.Recipe.RecipeListProperties.FileDescription, "FileDescription", "Beschreibung", 201, System.Windows.Forms.HorizontalAlignment.Left, True, True), New VisiWinNET.Forms.Recipe.RecipeListColumn(VisiWinNET.Forms.Recipe.RecipeListProperties.FileChangedAt, "FileChangedAt", "Änderungsdatum", 112, System.Windows.Forms.HorizontalAlignment.Center, True, True), New VisiWinNET.Forms.Recipe.RecipeListColumn(VisiWinNET.Forms.Recipe.RecipeListProperties.FileChangedBy, "FileChangedBy", "geändert von", 135, System.Windows.Forms.HorizontalAlignment.Left, True, True)})
        Me.RecipeList1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RecipeList1.Location = New System.Drawing.Point(8, 84)
        Me.RecipeList1.Name = "RecipeList1"
        Me.RecipeList1.ScrollBarProperties.Width = 19
        Me.RecipeList1.Size = New System.Drawing.Size(668, 236)
        Me.RecipeList1.TabIndex = 2
        '
        'lblExistingRecipes
        '
        Me.lblExistingRecipes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExistingRecipes.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblExistingRecipes.FontClass = "Labels"
        Me.lblExistingRecipes.LocalizedText.Text = "lblExistingRecipes"
        Me.lblExistingRecipes.LocalizedText.TextGroup = "Forms.RecipeManagement"
        Me.lblExistingRecipes.LocalizedText.TextPrefix = "lblExistingRecipes"
        Me.lblExistingRecipes.Location = New System.Drawing.Point(8, 64)
        Me.lblExistingRecipes.Name = "lblExistingRecipes"
        Me.lblExistingRecipes.Size = New System.Drawing.Size(668, 20)
        Me.lblExistingRecipes.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinDescription
        '
        Me.vinDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vinDescription.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDescription.FontClass = "Inputs"
        Me.vinDescription.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDescription.Label.FontClass = "Labels"
        Me.vinDescription.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDescription.Label.SizeRatio = 0.15
        Me.vinDescription.Label.Text.Text = "lblDescription"
        Me.vinDescription.Label.Text.TextGroup = "Forms.RecipeManagement"
        Me.vinDescription.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinDescription.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnInput
        Me.vinDescription.LimitMax.Value = 60
        Me.vinDescription.Location = New System.Drawing.Point(8, 36)
        Me.vinDescription.Name = "vinDescription"
        Me.vinDescription.Padding = 0
        Me.vinDescription.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinDescription.RestoreOnLostFocus = False
        Me.vinDescription.Size = New System.Drawing.Size(668, 24)
        Me.vinDescription.TabIndex = 1
        Me.vinDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDescription.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinDescription.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinDescription.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinDescription.Unit.SizeRatio = 0.25
        Me.vinDescription.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinDescription.VWItem.Name = "__UNLINKED_BSTR"
        '
        'vinName
        '
        Me.vinName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vinName.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinName.FontClass = "Inputs"
        Me.vinName.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinName.Label.FontClass = "Labels"
        Me.vinName.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinName.Label.SizeRatio = 0.15
        Me.vinName.Label.Text.Text = "lblName"
        Me.vinName.Label.Text.TextGroup = "Forms.RecipeManagement"
        Me.vinName.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vinName.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnInput
        Me.vinName.LimitMax.Value = 12
        Me.vinName.Location = New System.Drawing.Point(8, 8)
        Me.vinName.Name = "vinName"
        Me.vinName.Padding = 0
        Me.vinName.RegionLayout = VisiWinNET.Forms.VarInRegionLayouts.LabelLeft
        Me.vinName.RestoreOnLostFocus = False
        Me.vinName.Size = New System.Drawing.Size(668, 24)
        Me.vinName.TabIndex = 0
        Me.vinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinName.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinName.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinName.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinName.Unit.SizeRatio = 0.4
        Me.vinName.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinName.VWItem.Name = "__UNLINKED_BSTR"
        '
        'cmdClose2
        '
        Me.cmdClose2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose2.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose2.LocalizedText.Text = "r"
        Me.cmdClose2.Location = New System.Drawing.Point(678, 2)
        Me.cmdClose2.Name = "cmdClose2"
        Me.cmdClose2.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose2.TabIndex = 4
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
        Me.lblCaption.LocalizedText.Text = "capLoadRecipe"
        Me.lblCaption.LocalizedText.TextGroup = "Forms.RecipeManagement"
        Me.lblCaption.LocalizedText.TextPrefix = "capLoadRecipe"
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(698, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Authorization.Right = "Programmänderungen"
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Blink.FinalBlinkState = False
        Me.cmdDelete.FontClass = "Buttons"
        Me.cmdDelete.ImageAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        Me.cmdDelete.LocalizedText.Text = "cmdDelete"
        Me.cmdDelete.LocalizedText.TextGroup = "Forms.RecipeManagement"
        Me.cmdDelete.LocalizedText.TextOn = "cmdDelete"
        Me.cmdDelete.LocalizedText.TextPrefix = "cmdDelete"
        Me.cmdDelete.Location = New System.Drawing.Point(16, 364)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(88, 36)
        Me.cmdDelete.TabIndex = 1
        '
        'FRecipeSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose2)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRecipeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        CType(Me.RecipeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExistingRecipes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	Private WithEvents cmdOK As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdCancel As VisiWinNET.Forms.CommandButton
	Private WithEvents grp As VisiWinNET.Forms.GroupBox
	Private WithEvents vinName As VisiWinNET.Forms.VarIn
	Private WithEvents vinDescription As VisiWinNET.Forms.VarIn
	Private WithEvents cmdClose2 As VisiWinNET.Forms.CommandButton
	Private WithEvents lblCaption As VisiWinNET.Forms.Label
	Private WithEvents lblExistingRecipes As VisiWinNET.Forms.Label
	Private WithEvents RecipeList1 As VisiWinNET.Forms.Recipe.RecipeList
	Private WithEvents cmdDelete As VisiWinNET.Forms.CommandButton

End Class
