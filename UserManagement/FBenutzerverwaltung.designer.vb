<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBenutzerverwaltung
    Inherits HMI.FVorlage_Kopf_Fuss_Stoerzeile

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBenutzerverwaltung))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.lsvBenutzer = New VisiWinNET.Forms.ListView
        Me.cmdBenutzer_hinzufuegen = New VisiWinNET.Forms.CommandButton
        Me.cmdBenutzer_aendern = New VisiWinNET.Forms.CommandButton
        Me.cmdBenutzer_loeschen = New VisiWinNET.Forms.CommandButton
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lsvBenutzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBenutzer_hinzufuegen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBenutzer_aendern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBenutzer_loeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "lblUeberschrift"
        Me.lblUeberschrift.LocalizedText.TextGroup = "Benutzerverwaltung"
        Me.lblUeberschrift.LocalizedText.TextOn = "lblUeberschrift"
        Me.lblUeberschrift.LocalizedText.TextPrefix = "lblUeberschrift"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'lsvBenutzer
        '
        Me.lsvBenutzer.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.ListViewTextColumn("lblName", "Benutzerverwaltung", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Benutzer", 100, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True), New VisiWinNET.Forms.ListViewTextColumn("lblUserName", "Benutzerverwaltung", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Name", 100, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True), New VisiWinNET.Forms.ListViewTextColumn("lblUserGroup", "Benutzerverwaltung", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Benutzer_Gruppe", 116, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True), New VisiWinNET.Forms.ListViewTextColumn("lblUserState", "Benutzerverwaltung", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Status", 100, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True), New VisiWinNET.Forms.ListViewTextColumn("lblAutoLogOffTime", "Benutzerverwaltung", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Auto_LogOff_Zeit", 100, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True), New VisiWinNET.Forms.ListViewTextColumn("lblComment", "Benutzerverwaltung", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Kommentar", 487, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, False, True)})
        Me.lsvBenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBenutzer.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBenutzer.Header.Height = 25
        Me.lsvBenutzer.Location = New System.Drawing.Point(5, 92)
        Me.lsvBenutzer.Name = "lsvBenutzer"
        Me.lsvBenutzer.ScrollBarProperties.Width = 24
        Me.lsvBenutzer.Size = New System.Drawing.Size(1017, 519)

        Me.lsvBenutzer.TabIndex = 41
        '
        'cmdBenutzer_hinzufuegen
        '
        Me.cmdBenutzer_hinzufuegen.Authorization.Right = "Benutzerverwaltung"
        Me.cmdBenutzer_hinzufuegen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBenutzer_hinzufuegen.LocalizedText.Text = "cbBenutzer_hinzufügen"
        Me.cmdBenutzer_hinzufuegen.LocalizedText.TextGroup = "Benutzerverwaltung"
        Me.cmdBenutzer_hinzufuegen.LocalizedText.TextOn = "cbBenutzer_hinzufügen"
        Me.cmdBenutzer_hinzufuegen.LocalizedText.TextPrefix = "cbBenutzer_hinzufügen"
        Me.cmdBenutzer_hinzufuegen.Location = New System.Drawing.Point(770, 617)
        Me.cmdBenutzer_hinzufuegen.Name = "cmdBenutzer_hinzufuegen"
        Me.cmdBenutzer_hinzufuegen.Size = New System.Drawing.Size(80, 58)
        Me.cmdBenutzer_hinzufuegen.TabIndex = 43
        '
        'cmdBenutzer_aendern
        '
        Me.cmdBenutzer_aendern.Authorization.Right = "Benutzerverwaltung"
        Me.cmdBenutzer_aendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBenutzer_aendern.LocalizedText.Text = "cbBenutzer_ändern"
        Me.cmdBenutzer_aendern.LocalizedText.TextGroup = "Benutzerverwaltung"
        Me.cmdBenutzer_aendern.LocalizedText.TextOn = "cbBenutzer_ändern"
        Me.cmdBenutzer_aendern.LocalizedText.TextPrefix = "cbBenutzer_ändern"
        Me.cmdBenutzer_aendern.Location = New System.Drawing.Point(855, 617)
        Me.cmdBenutzer_aendern.Name = "cmdBenutzer_aendern"
        Me.cmdBenutzer_aendern.Size = New System.Drawing.Size(80, 58)
        Me.cmdBenutzer_aendern.TabIndex = 45
        '
        'cmdBenutzer_loeschen
        '
        Me.cmdBenutzer_loeschen.Authorization.Right = "Benutzerverwaltung"
        Me.cmdBenutzer_loeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBenutzer_loeschen.LocalizedText.Text = "cbBenutzer_loeschen"
        Me.cmdBenutzer_loeschen.LocalizedText.TextGroup = "Benutzerverwaltung"
        Me.cmdBenutzer_loeschen.LocalizedText.TextOn = "cbBenutzer_loeschen"
        Me.cmdBenutzer_loeschen.LocalizedText.TextPrefix = "cbBenutzer_loeschen"
        Me.cmdBenutzer_loeschen.Location = New System.Drawing.Point(940, 617)
        Me.cmdBenutzer_loeschen.Name = "cmdBenutzer_loeschen"
        Me.cmdBenutzer_loeschen.Size = New System.Drawing.Size(80, 58)
        Me.cmdBenutzer_loeschen.TabIndex = 47
        '
        'FBenutzerverwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdBenutzer_loeschen)
        Me.Controls.Add(Me.cmdBenutzer_aendern)
        Me.Controls.Add(Me.cmdBenutzer_hinzufuegen)
        Me.Controls.Add(Me.lsvBenutzer)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FBenutzerverwaltung"
        Me.Text = "FBenutzerverwalung"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.lsvBenutzer, 0)
        Me.Controls.SetChildIndex(Me.cmdBenutzer_hinzufuegen, 0)
        Me.Controls.SetChildIndex(Me.cmdBenutzer_aendern, 0)
        Me.Controls.SetChildIndex(Me.cmdBenutzer_loeschen, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lsvBenutzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBenutzer_hinzufuegen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBenutzer_aendern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBenutzer_loeschen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents cmdBenutzer_hinzufuegen As VisiWinNET.Forms.CommandButton
    Private WithEvents lsvBenutzer As VisiWinNET.Forms.ListView
    Friend WithEvents cmdBenutzer_aendern As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBenutzer_loeschen As VisiWinNET.Forms.CommandButton
End Class
