<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProtokollSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProtokollSelect))
        Me.lblCaption = New VisiWinNET.Forms.Label
        Me.dgvProtokolle = New System.Windows.Forms.DataGridView
        Me.grpCharge = New VisiWinNET.Forms.GroupBox
        Me.cmdClose2 = New VisiWinNET.Forms.CommandButton
        Me.cmdCancel = New VisiWinNET.Forms.CommandButton
        Me.cmdOK = New VisiWinNET.Forms.CommandButton
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProtokolle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCharge.SuspendLayout()
        CType(Me.cmdClose2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCaption.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCaption.FontClass = "Captions"
        Me.lblCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCaption.LocalizedText.Text = "Protokoll laden"
        Me.lblCaption.LocalizedText.TextPrefix = "capLoadRecipe"
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(468, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'dgvProtokolle
        '
        Me.dgvProtokolle.AllowUserToAddRows = False
        Me.dgvProtokolle.AllowUserToDeleteRows = False
        Me.dgvProtokolle.AllowUserToResizeColumns = False
        Me.dgvProtokolle.AllowUserToResizeRows = False
        Me.dgvProtokolle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProtokolle.EnableHeadersVisualStyles = False
        Me.dgvProtokolle.Location = New System.Drawing.Point(25, 15)
        Me.dgvProtokolle.MultiSelect = False
        Me.dgvProtokolle.Name = "dgvProtokolle"
        Me.dgvProtokolle.ReadOnly = True
        Me.dgvProtokolle.RowHeadersVisible = False
        Me.dgvProtokolle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProtokolle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProtokolle.Size = New System.Drawing.Size(323, 231)
        Me.dgvProtokolle.TabIndex = 8
        '
        'grpCharge
        '
        Me.grpCharge.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.grpCharge.Controls.Add(Me.dgvProtokolle)
        Me.grpCharge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpCharge.Location = New System.Drawing.Point(43, 43)
        Me.grpCharge.Name = "grpCharge"
        Me.grpCharge.Size = New System.Drawing.Size(374, 264)
        Me.grpCharge.TabIndex = 15
        '
        'cmdClose2
        '
        Me.cmdClose2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose2.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose2.LocalizedText.Text = "r"
        Me.cmdClose2.Location = New System.Drawing.Point(448, 2)
        Me.cmdClose2.Name = "cmdClose2"
        Me.cmdClose2.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose2.TabIndex = 16
        Me.cmdClose2.TabStop = False
        Me.cmdClose2.TextAlign = VisiWinNET.Forms.ContentAlign.TopLeft
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
        Me.cmdCancel.Location = New System.Drawing.Point(368, 313)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 36)
        Me.cmdCancel.TabIndex = 19
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
        Me.cmdOK.Location = New System.Drawing.Point(273, 313)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 36)
        Me.cmdOK.TabIndex = 18
        '
        'FProtokollSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(468, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdClose2)
        Me.Controls.Add(Me.grpCharge)
        Me.Controls.Add(Me.lblCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FProtokollSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProtokolle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCharge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCharge.ResumeLayout(False)
        CType(Me.cmdClose2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblCaption As VisiWinNET.Forms.Label
    Friend WithEvents dgvProtokolle As System.Windows.Forms.DataGridView
    Friend WithEvents grpCharge As VisiWinNET.Forms.GroupBox
    Private WithEvents cmdClose2 As VisiWinNET.Forms.CommandButton
    Private WithEvents cmdCancel As VisiWinNET.Forms.CommandButton
    Private WithEvents cmdOK As VisiWinNET.Forms.CommandButton
End Class
