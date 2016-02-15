<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEinstellungen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEinstellungen))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.dtiDatum_Uhrzeit = New VisiWinNET.Forms.DateTimeIn
        Me.lblDatum_Uhrzeit = New VisiWinNET.Forms.Label
        Me.cmdDatum_Uhrzeit_speichern = New VisiWinNET.Forms.CommandButton
        Me.cmdBildschirm_reinigen = New VisiWinNET.Forms.CommandButton
        Me.cmdEnd = New VisiWinNET.Forms.CommandButton
        Me.tiDatum_Uhrzeit_aktuallisieren = New System.Windows.Forms.Timer(Me.components)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDatum_Uhrzeit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDatum_Uhrzeit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDatum_Uhrzeit_speichern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBildschirm_reinigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Einstellungen"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'dtiDatum_Uhrzeit
        '
        Me.dtiDatum_Uhrzeit.Authorization.Right = "Einstellungen"
        Me.dtiDatum_Uhrzeit.BackColor = System.Drawing.SystemColors.Menu
        Me.dtiDatum_Uhrzeit.ButtonWidth = 1
        Me.dtiDatum_Uhrzeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiDatum_Uhrzeit.Location = New System.Drawing.Point(181, 333)
        Me.dtiDatum_Uhrzeit.Name = "dtiDatum_Uhrzeit"
        Me.dtiDatum_Uhrzeit.ShowUpDown = False
        Me.dtiDatum_Uhrzeit.Size = New System.Drawing.Size(627, 103)
        Me.dtiDatum_Uhrzeit.TabIndex = 41
        Me.dtiDatum_Uhrzeit.TimeSettings.Delay1 = 1000
        Me.dtiDatum_Uhrzeit.TimeSettings.Delay2 = 3000
        Me.dtiDatum_Uhrzeit.TimeSettings.Delay3 = 3000
        Me.dtiDatum_Uhrzeit.TimeSettings.Interval1 = 500
        Me.dtiDatum_Uhrzeit.TimeSettings.Interval2 = 250
        Me.dtiDatum_Uhrzeit.TimeSettings.Interval3 = 100
        Me.dtiDatum_Uhrzeit.VWItem.Name = "__UNLINKED_DATE"
        '
        'lblDatum_Uhrzeit
        '
        Me.lblDatum_Uhrzeit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblDatum_Uhrzeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatum_Uhrzeit.LocalizedText.Text = "Datum / Uhrzeit"
        Me.lblDatum_Uhrzeit.Location = New System.Drawing.Point(294, 241)
        Me.lblDatum_Uhrzeit.Name = "lblDatum_Uhrzeit"
        Me.lblDatum_Uhrzeit.Size = New System.Drawing.Size(410, 44)
        '
        'cmdDatum_Uhrzeit_speichern
        '
        Me.cmdDatum_Uhrzeit_speichern.Authorization.Right = "Einstellungen"
        Me.cmdDatum_Uhrzeit_speichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatum_Uhrzeit_speichern.LocalizedText.Text = "Datum / Uhrzeit speichern"
        Me.cmdDatum_Uhrzeit_speichern.Location = New System.Drawing.Point(410, 465)
        Me.cmdDatum_Uhrzeit_speichern.Name = "cmdDatum_Uhrzeit_speichern"
        Me.cmdDatum_Uhrzeit_speichern.Size = New System.Drawing.Size(173, 60)
        Me.cmdDatum_Uhrzeit_speichern.TabIndex = 44
        '
        'cmdBildschirm_reinigen
        '
        Me.cmdBildschirm_reinigen.Authorization.Right = "Bedienen"
        Me.cmdBildschirm_reinigen.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FBildschirm_reinigen", VisiWinNET.Forms.FormChangeModes.ShowNew, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdBildschirm_reinigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBildschirm_reinigen.LocalizedText.Text = "Bildschirm reinigen"
        Me.cmdBildschirm_reinigen.Location = New System.Drawing.Point(940, 92)
        Me.cmdBildschirm_reinigen.Name = "cmdBildschirm_reinigen"
        Me.cmdBildschirm_reinigen.Size = New System.Drawing.Size(82, 56)
        Me.cmdBildschirm_reinigen.TabIndex = 47
        '
        'cmdEnd
        '
        Me.cmdEnd.Authorization.Right = "Administrieren"
        Me.cmdEnd.Command.Command = VisiWinNET.Forms.ApplicationCommands.ExitApplication
        Me.cmdEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.LocalizedText.Text = "Ende"
        Me.cmdEnd.Location = New System.Drawing.Point(1, 92)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(82, 56)
        Me.cmdEnd.TabIndex = 48
        '
        'tiDatum_Uhrzeit_aktuallisieren
        '
        Me.tiDatum_Uhrzeit_aktuallisieren.Enabled = True
        Me.tiDatum_Uhrzeit_aktuallisieren.Interval = 1000
        '
        'FEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdBildschirm_reinigen)
        Me.Controls.Add(Me.cmdDatum_Uhrzeit_speichern)
        Me.Controls.Add(Me.lblDatum_Uhrzeit)
        Me.Controls.Add(Me.dtiDatum_Uhrzeit)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FEinstellungen"
        Me.Text = "FEinstellungen"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.dtiDatum_Uhrzeit, 0)
        Me.Controls.SetChildIndex(Me.lblDatum_Uhrzeit, 0)
        Me.Controls.SetChildIndex(Me.cmdDatum_Uhrzeit_speichern, 0)
        Me.Controls.SetChildIndex(Me.cmdBildschirm_reinigen, 0)
        Me.Controls.SetChildIndex(Me.cmdEnd, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDatum_Uhrzeit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDatum_Uhrzeit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDatum_Uhrzeit_speichern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBildschirm_reinigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents dtiDatum_Uhrzeit As VisiWinNET.Forms.DateTimeIn
    Friend WithEvents lblDatum_Uhrzeit As VisiWinNET.Forms.Label
    Friend WithEvents cmdDatum_Uhrzeit_speichern As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdBildschirm_reinigen As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdEnd As VisiWinNET.Forms.CommandButton
    Friend WithEvents tiDatum_Uhrzeit_aktuallisieren As System.Windows.Forms.Timer
End Class
