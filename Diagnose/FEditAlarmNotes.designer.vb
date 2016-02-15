<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEditAlarmNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEditAlarmNotes))
        Me.cmdOK = New VisiWinNET.Forms.CommandButton
        Me.grpNotes = New VisiWinNET.Forms.GroupBox
        Me.vinNote = New VisiWinNET.Forms.VarIn
        Me.lvwNotes = New VisiWinNET.Forms.ListView
        Me.cmdDelete = New VisiWinNET.Forms.CommandButton
        Me.cmdAdd = New VisiWinNET.Forms.CommandButton
        Me.cmdClose = New VisiWinNET.Forms.CommandButton
        Me.lblCaption = New VisiWinNET.Forms.Label
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotes.SuspendLayout()
        CType(Me.vinNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvwNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.FontClass = "Buttons"
        Me.cmdOK.LocalizedText.Text = "cmdClose"
        Me.cmdOK.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdOK.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdOK.Location = New System.Drawing.Point(652, 504)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 28)
        Me.cmdOK.TabIndex = 1
        '
        'grpNotes
        '
        Me.grpNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNotes.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox
        Me.grpNotes.Controls.Add(Me.vinNote)
        Me.grpNotes.Controls.Add(Me.lvwNotes)
        Me.grpNotes.Controls.Add(Me.cmdDelete)
        Me.grpNotes.Controls.Add(Me.cmdAdd)
        Me.grpNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpNotes.LocalizedText.TextGroup = "FEditAlarmNotes"
        Me.grpNotes.Location = New System.Drawing.Point(8, 28)
        Me.grpNotes.Name = "grpNotes"
        Me.grpNotes.Size = New System.Drawing.Size(740, 468)
        Me.grpNotes.TabIndex = 0
        '
        'vinNote
        '
        Me.vinNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vinNote.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinNote.FontClass = "Inputs"
        Me.vinNote.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinNote.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinNote.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinNote.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinNote.Location = New System.Drawing.Point(8, 432)
        Me.vinNote.Name = "vinNote"
        Me.vinNote.RestoreOnLostFocus = False
        Me.vinNote.Size = New System.Drawing.Size(536, 28)
        Me.vinNote.TabIndex = 1
        Me.vinNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinNote.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinNote.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinNote.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinNote.Unit.SizeRatio = 0.25
        Me.vinNote.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinNote.VWItem.Name = "__UNLINKED_BSTR"
        Me.vinNote.WriteOnReturn = False
        '
        'lvwNotes
        '
        Me.lvwNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwNotes.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.ListViewDateColumn("TimeStamp", "Components.NoteList", VisiWinNET.LanguageSwitching.TextTypes.ClientSystem, "colTimeStamp", 150, System.Windows.Forms.HorizontalAlignment.Center, VisiWinNET.Forms.ColumnTypes.[Date], True, "@LongDate", "@LongTime", True), New VisiWinNET.Forms.ListViewTextColumn("User", "Components.NoteList", VisiWinNET.LanguageSwitching.TextTypes.ClientSystem, "colUser", 100, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True), New VisiWinNET.Forms.ListViewTextColumn("Note", "Components.NoteList", VisiWinNET.LanguageSwitching.TextTypes.ClientSystem, "colNote", 450, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True)})
        Me.lvwNotes.FontClass = "Labels"
        Me.lvwNotes.Grid = False
        Me.lvwNotes.Header.FontClass = "Labels"
        Me.lvwNotes.Location = New System.Drawing.Point(8, 8)
        Me.lvwNotes.Name = "lvwNotes"
        Me.lvwNotes.Size = New System.Drawing.Size(724, 416)

        Me.lvwNotes.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdDelete.FontClass = "Buttons"
        Me.cmdDelete.LocalizedText.Text = "cmdDelete"
        Me.cmdDelete.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdDelete.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdDelete.Location = New System.Drawing.Point(644, 432)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(88, 28)
        Me.cmdDelete.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.FontClass = "Buttons"
        Me.cmdAdd.LocalizedText.Text = "cmdAdd"
        Me.cmdAdd.LocalizedText.TextGroup = "Dialogs.Common"
        Me.cmdAdd.LocalizedText.TextType = VisiWinNET.LanguageSwitching.TextTypes.ClientSystem
        Me.cmdAdd.Location = New System.Drawing.Point(552, 432)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(88, 28)
        Me.cmdAdd.TabIndex = 2
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Marlett", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdClose.LocalizedText.Text = "r"
        Me.cmdClose.Location = New System.Drawing.Point(734, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(18, 16)
        Me.cmdClose.TabIndex = 2
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
        Me.lblCaption.LocalizedText.Text = "capNotes"
        Me.lblCaption.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(754, 20)
        Me.lblCaption.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'FEditAlarmNotes
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(754, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.grpNotes)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FEditAlarmNotes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotes.ResumeLayout(False)
        CType(Me.vinNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvwNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	Private WithEvents cmdOK As VisiWinNET.Forms.CommandButton
	Private WithEvents grpNotes As VisiWinNET.Forms.GroupBox
	Private WithEvents cmdDelete As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdAdd As VisiWinNET.Forms.CommandButton
	Private WithEvents lvwNotes As VisiWinNET.Forms.ListView
	Private WithEvents vinNote As VisiWinNET.Forms.VarIn
	Private WithEvents cmdClose As VisiWinNET.Forms.CommandButton
	Private WithEvents lblCaption As VisiWinNET.Forms.Label

End Class
