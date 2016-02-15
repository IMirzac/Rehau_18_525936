<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMessageBox
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

    'Erforderliche Designervariable.
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Die folgende Prozedur ist für den Windows Form-Designer erforderlich
    'Sie kann mit dem Windows Form-Designer modifiziert werden.  
    'Verwenden Sie nicht den Code-Editor zur Bearbeitung.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMessageBox))
        Me.cmdClose = New VisiWinNET.Forms.CommandButton
        Me.lblCaption = New VisiWinNET.Forms.Label
        Me.cmd2 = New VisiWinNET.Forms.CommandButton
        Me.cmd1 = New VisiWinNET.Forms.CommandButton
        Me.picMessageIcon = New System.Windows.Forms.PictureBox
        Me.cmd3 = New VisiWinNET.Forms.CommandButton
        Me.lblMessage = New VisiWinNET.Forms.Label
        Me.pnlButtons = New System.Windows.Forms.Panel
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMessageIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose.LocalizedText.Text = "r"
        Me.cmdClose.Location = New System.Drawing.Point(406, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose.TabIndex = 19
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
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(426, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'cmd2
        '
        Me.cmd2.Blink.FinalBlinkState = False
        Me.cmd2.FontClass = "Buttons"
        Me.cmd2.LocalizedText.Text = "cmdCancel"
        Me.cmd2.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmd2.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmd2.Location = New System.Drawing.Point(112, 0)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(88, 28)
        Me.cmd2.TabIndex = 22
        '
        'cmd1
        '
        Me.cmd1.Blink.FinalBlinkState = False
        Me.cmd1.FontClass = "Buttons"
        Me.cmd1.LocalizedText.Text = "cmdOK"
        Me.cmd1.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmd1.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmd1.Location = New System.Drawing.Point(16, 0)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(88, 28)
        Me.cmd1.TabIndex = 21
        '
        'picMessageIcon
        '
        Me.picMessageIcon.Location = New System.Drawing.Point(12, 32)
        Me.picMessageIcon.Name = "picMessageIcon"
        Me.picMessageIcon.Size = New System.Drawing.Size(32, 32)
        Me.picMessageIcon.TabIndex = 23
        Me.picMessageIcon.TabStop = False
        '
        'cmd3
        '
        Me.cmd3.Blink.FinalBlinkState = False
        Me.cmd3.FontClass = "Buttons"
        Me.cmd3.LocalizedText.Text = "cmdNo"
        Me.cmd3.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmd3.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmd3.Location = New System.Drawing.Point(208, 0)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(88, 28)
        Me.cmd3.TabIndex = 24
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblMessage.LocalizedText.Text = "Text"
        Me.lblMessage.Location = New System.Drawing.Point(56, 32)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(360, 148)
        Me.lblMessage.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pnlButtons.Controls.Add(Me.cmd1)
        Me.pnlButtons.Controls.Add(Me.cmd2)
        Me.pnlButtons.Controls.Add(Me.cmd3)
        Me.pnlButtons.Location = New System.Drawing.Point(50, 192)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(310, 28)
        Me.pnlButtons.TabIndex = 26
        '
        'FMessageBox
        '
        Me.AcceptButton = Me.cmd1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(426, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picMessageIcon)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMessageIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	Private WithEvents cmdClose As VisiWinNET.Forms.CommandButton
	Private WithEvents lblCaption As VisiWinNET.Forms.Label
	Private WithEvents picMessageIcon As System.Windows.Forms.PictureBox
	Private WithEvents lblMessage As VisiWinNET.Forms.Label
	Private WithEvents cmd2 As VisiWinNET.Forms.CommandButton
	Private WithEvents cmd1 As VisiWinNET.Forms.CommandButton
	Private WithEvents cmd3 As VisiWinNET.Forms.CommandButton
	Private WithEvents pnlButtons As System.Windows.Forms.Panel

End Class
