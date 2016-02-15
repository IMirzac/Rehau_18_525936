<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCentral
    Inherits HMI.FVorlage_Kopfzeile

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCentral))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.UserManagementDialogs = New VisiWinNET.Forms.UserManagementDialogs(Me.components)
        Me.cmdBildumschaltung1 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung2 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung3 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung6 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung9 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung7 = New VisiWinNET.Forms.CommandButton
        Me.CmdBenutzer = New VisiWinNET.Forms.CommandButton
        Me.CmbBenutzer_abmelden = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung8 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung4 = New VisiWinNET.Forms.CommandButton
        Me.cmdBildumschaltung5 = New VisiWinNET.Forms.CommandButton
        Me.TiKopfzeile_Kopplung = New System.Windows.Forms.Timer(Me.components)
        Me.TouchKeyboard = New VisiWinNET.Forms.TouchKeyboard(Me.components)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdBenutzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbBenutzer_abmelden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildumschaltung5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TouchKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Grundmenü"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'cmdBildumschaltung1
        '
        Me.cmdBildumschaltung1.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung1.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung1.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FStatus_Daten", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung1.LocalizedText.Text = "Status Daten"
        Me.cmdBildumschaltung1.Location = New System.Drawing.Point(307, 143)
        Me.cmdBildumschaltung1.Name = "cmdBildumschaltung1"
        Me.cmdBildumschaltung1.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung1.TabIndex = 41
        '
        'cmdBildumschaltung2
        '
        Me.cmdBildumschaltung2.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung2.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung2.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FRecipe", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung2.LocalizedText.Text = "Programme"
        Me.cmdBildumschaltung2.Location = New System.Drawing.Point(307, 206)
        Me.cmdBildumschaltung2.Name = "cmdBildumschaltung2"
        Me.cmdBildumschaltung2.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung2.TabIndex = 42
        '
        'cmdBildumschaltung3
        '
        Me.cmdBildumschaltung3.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung3.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung3.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FStatus_Hand", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung3.LocalizedText.Text = "Status Hand"
        Me.cmdBildumschaltung3.Location = New System.Drawing.Point(307, 269)
        Me.cmdBildumschaltung3.Name = "cmdBildumschaltung3"
        Me.cmdBildumschaltung3.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung3.TabIndex = 43
        '
        'cmdBildumschaltung6
        '
        Me.cmdBildumschaltung6.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung6.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung6.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FEinstellungen", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung6.LocalizedText.Text = "Einstellungen"
        Me.cmdBildumschaltung6.Location = New System.Drawing.Point(307, 458)
        Me.cmdBildumschaltung6.Name = "cmdBildumschaltung6"
        Me.cmdBildumschaltung6.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung6.TabIndex = 44
        '
        'cmdBildumschaltung9
        '
        Me.cmdBildumschaltung9.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung9.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FAlarm", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung9.LocalizedText.Text = "Diagnose"
        Me.cmdBildumschaltung9.Location = New System.Drawing.Point(307, 647)
        Me.cmdBildumschaltung9.Name = "cmdBildumschaltung9"
        Me.cmdBildumschaltung9.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung9.TabIndex = 46
        '
        'cmdBildumschaltung7
        '
        Me.cmdBildumschaltung7.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung7.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung7.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FBenutzerverwaltung", VisiWinNET.Forms.FormChangeModes.ShowNew, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung7.LocalizedText.Text = "Benutzerverwaltung"
        Me.cmdBildumschaltung7.Location = New System.Drawing.Point(307, 521)
        Me.cmdBildumschaltung7.Name = "cmdBildumschaltung7"
        Me.cmdBildumschaltung7.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung7.TabIndex = 45
        '
        'CmdBenutzer
        '
        Me.CmdBenutzer.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.ShowLogOnDialog(Me.UserManagementDialogs, 0), VisiWinNET.Commands.ICommand)}))})
        Me.CmdBenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBenutzer.LocalizedText.Text = "Benutzer"
        Me.CmdBenutzer.Location = New System.Drawing.Point(856, 116)
        Me.CmdBenutzer.Name = "CmdBenutzer"
        Me.CmdBenutzer.Size = New System.Drawing.Size(133, 55)
        Me.CmdBenutzer.TabIndex = 47
        '
        'CmbBenutzer_abmelden
        '
        Me.CmbBenutzer_abmelden.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.UserManagement.Commands.LogoffUser(0), VisiWinNET.Commands.ICommand)}))})
        Me.CmbBenutzer_abmelden.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBenutzer_abmelden.LocalizedText.Text = "Benutzer abmelden"
        Me.CmbBenutzer_abmelden.Location = New System.Drawing.Point(856, 197)
        Me.CmbBenutzer_abmelden.Name = "CmbBenutzer_abmelden"
        Me.CmbBenutzer_abmelden.Size = New System.Drawing.Size(133, 55)
        Me.CmbBenutzer_abmelden.TabIndex = 48
        '
        'cmdBildumschaltung8
        '
        Me.cmdBildumschaltung8.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung8.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung8.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FBedienerfuehrung", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung8.LocalizedText.Text = "Bedienerführung"
        Me.cmdBildumschaltung8.Location = New System.Drawing.Point(307, 584)
        Me.cmdBildumschaltung8.Name = "cmdBildumschaltung8"
        Me.cmdBildumschaltung8.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung8.TabIndex = 50
        '
        'cmdBildumschaltung4
        '
        Me.cmdBildumschaltung4.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung4.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung4.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FProtokoll", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung4.LocalizedText.Text = "Protokoll"
        Me.cmdBildumschaltung4.Location = New System.Drawing.Point(307, 332)
        Me.cmdBildumschaltung4.Name = "cmdBildumschaltung4"
        Me.cmdBildumschaltung4.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung4.TabIndex = 54
        '
        'cmdBildumschaltung5
        '
        Me.cmdBildumschaltung5.Authorization.Right = "Bedienen"
        Me.cmdBildumschaltung5.BackColor = System.Drawing.Color.Cyan
        Me.cmdBildumschaltung5.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FTrend", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildumschaltung5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildumschaltung5.LocalizedText.Text = "Trend"
        Me.cmdBildumschaltung5.Location = New System.Drawing.Point(307, 395)
        Me.cmdBildumschaltung5.Name = "cmdBildumschaltung5"
        Me.cmdBildumschaltung5.Size = New System.Drawing.Size(393, 57)
        Me.cmdBildumschaltung5.TabIndex = 55
        '
        'TiKopfzeile_Kopplung
        '
        Me.TiKopfzeile_Kopplung.Enabled = True
        Me.TiKopfzeile_Kopplung.Interval = 4000
        '
        'FCentral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdBildumschaltung5)
        Me.Controls.Add(Me.cmdBildumschaltung4)
        Me.Controls.Add(Me.cmdBildumschaltung8)
        Me.Controls.Add(Me.CmbBenutzer_abmelden)
        Me.Controls.Add(Me.CmdBenutzer)
        Me.Controls.Add(Me.cmdBildumschaltung9)
        Me.Controls.Add(Me.cmdBildumschaltung7)
        Me.Controls.Add(Me.cmdBildumschaltung6)
        Me.Controls.Add(Me.cmdBildumschaltung3)
        Me.Controls.Add(Me.cmdBildumschaltung2)
        Me.Controls.Add(Me.cmdBildumschaltung1)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCentral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FCentral"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung1, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung2, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung3, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung6, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung7, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung9, 0)
        Me.Controls.SetChildIndex(Me.CmdBenutzer, 0)
        Me.Controls.SetChildIndex(Me.CmbBenutzer_abmelden, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung8, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung4, 0)
        Me.Controls.SetChildIndex(Me.cmdBildumschaltung5, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdBenutzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbBenutzer_abmelden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildumschaltung5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TouchKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents UserManagementDialogs As VisiWinNET.Forms.UserManagementDialogs
    Friend WithEvents cmdBildumschaltung1 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung2 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung3 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung6 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung9 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung7 As VisiWinNET.Forms.CommandButton
    Friend WithEvents CmdBenutzer As VisiWinNET.Forms.CommandButton
    Friend WithEvents CmbBenutzer_abmelden As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung8 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung4 As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildumschaltung5 As VisiWinNET.Forms.CommandButton
    Friend WithEvents TiKopfzeile_Kopplung As System.Windows.Forms.Timer
    Friend WithEvents TouchKeyboard As VisiWinNET.Forms.TouchKeyboard

End Class
