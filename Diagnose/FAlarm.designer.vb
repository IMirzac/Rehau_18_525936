<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAlarm
    Inherits HMI.FVorlage_Kopf_Fusszeile

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAlarm))
        Me.altAlarm = New VisiWinNET.Forms.Alarm.AlarmList
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.keyLampentest = New VisiWinNET.Forms.Key
        Me.keyHupe_aus = New VisiWinNET.Forms.Key
        Me.keyStoerung_quittieren = New VisiWinNET.Forms.Key
        Me.cmdStoerarchiv = New VisiWinNET.Forms.CommandButton
        Me.cmdzurueck = New VisiWinNET.Forms.CommandButton
        CType(Me.altAlarm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyLampentest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyHupe_aus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyStoerung_quittieren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdStoerarchiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'altAlarm
        '
        Me.altAlarm.AlarmFilter.DesiredClasses = "Alarm"
        Me.altAlarm.AlarmFilter.DesiredGroups = "Alarme"
        Me.altAlarm.AlarmFilter.DesiredStates = VisiWinNET.Alarm.AlarmStates.Active
        Me.altAlarm.BackColorSelected = System.Drawing.SystemColors.HighlightText
        Me.altAlarm.Columns.AddRange(New VisiWinNET.Forms.Alarm.AlarmColumn() {New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.ActivationTime, 148, VisiWinNET.Forms.ContentAlign.TopCenter, ""), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.State, 72, VisiWinNET.Forms.ContentAlign.TopCenter, ""), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.Priority, 64, VisiWinNET.Forms.ContentAlign.TopCenter, ""), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.Group, 72, VisiWinNET.Forms.ContentAlign.TopCenter, ""), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.Text, 631, VisiWinNET.Forms.ContentAlign.TopLeft, "")})
        Me.altAlarm.CurrentCursor = System.Windows.Forms.Cursors.Default
        Me.altAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altAlarm.ForeColorSelected = System.Drawing.SystemColors.Highlight
        Me.altAlarm.Location = New System.Drawing.Point(3, 93)
        Me.altAlarm.Name = "altAlarm"
        Me.altAlarm.ScrollBarProperties.BackColorButton = System.Drawing.SystemColors.Control
        Me.altAlarm.ScrollBarProperties.BackColorThumb = System.Drawing.SystemColors.Control
        Me.altAlarm.ScrollBarProperties.ForeColorButton = System.Drawing.SystemColors.ControlText
        Me.altAlarm.ScrollBarProperties.ForeColorButtonDisabled = System.Drawing.SystemColors.GrayText
        Me.altAlarm.ScrollBarProperties.Visibility = VisiWinNET.Forms.ScrollBarVisibility.Both
        Me.altAlarm.ScrollBarProperties.Width = 24
        Me.altAlarm.SelectedIndex = -1
        Me.altAlarm.Size = New System.Drawing.Size(1012, 547)

        Me.altAlarm.TabIndex = 39
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Diagnose"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'keyLampentest
        '
        Me.keyLampentest.Authorization.Right = "Bedienen"
        Me.keyLampentest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyLampentest.LocalizedText.Text = "Lampentest"
        Me.keyLampentest.Location = New System.Drawing.Point(685, 643)
        Me.keyLampentest.Name = "keyLampentest"
        Me.keyLampentest.SetMode = VisiWinNET.Forms.SetMode.KeyMode
        Me.keyLampentest.Size = New System.Drawing.Size(80, 58)
        Me.keyLampentest.TabIndex = 48
        Me.keyLampentest.VWItem.BitNumber = 8
        Me.keyLampentest.VWItem.Name = "SPS Ofen.Kopplung.Tasten_von_PC"
        '
        'keyHupe_aus
        '
        Me.keyHupe_aus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyHupe_aus.LocalizedText.Text = "Hupe          aus"
        Me.keyHupe_aus.Location = New System.Drawing.Point(770, 643)
        Me.keyHupe_aus.Name = "keyHupe_aus"
        Me.keyHupe_aus.SetMode = VisiWinNET.Forms.SetMode.KeyMode
        Me.keyHupe_aus.Size = New System.Drawing.Size(80, 58)
        Me.keyHupe_aus.TabIndex = 50
        Me.keyHupe_aus.VWItem.BitNumber = 9
        Me.keyHupe_aus.VWItem.Name = "SPS Ofen.Kopplung.Tasten_von_PC"
        '
        'keyStoerung_quittieren
        '
        Me.keyStoerung_quittieren.Authorization.Right = "Bedienen"
        Me.keyStoerung_quittieren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyStoerung_quittieren.LocalizedText.Text = "Störung quittieren"
        Me.keyStoerung_quittieren.Location = New System.Drawing.Point(855, 643)
        Me.keyStoerung_quittieren.Name = "keyStoerung_quittieren"
        Me.keyStoerung_quittieren.SetMode = VisiWinNET.Forms.SetMode.KeyMode
        Me.keyStoerung_quittieren.Size = New System.Drawing.Size(80, 58)
        Me.keyStoerung_quittieren.TabIndex = 51
        Me.keyStoerung_quittieren.VWItem.BitNumber = 10
        Me.keyStoerung_quittieren.VWItem.Name = "SPS Ofen.Kopplung.Tasten_von_PC"
        '
        'cmdStoerarchiv
        '
        Me.cmdStoerarchiv.Authorization.Right = "Bedienen"
        Me.cmdStoerarchiv.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FAlarmHistory", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdStoerarchiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStoerarchiv.LocalizedText.Text = "Stöerarchiv"
        Me.cmdStoerarchiv.Location = New System.Drawing.Point(5, 643)
        Me.cmdStoerarchiv.Name = "cmdStoerarchiv"
        Me.cmdStoerarchiv.Size = New System.Drawing.Size(80, 58)
        Me.cmdStoerarchiv.TabIndex = 53
        '
        'cmdzurueck
        '
        Me.cmdzurueck.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.FormHistoryBack(VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdzurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdzurueck.LocalizedText.Text = "zurück"
        Me.cmdzurueck.Location = New System.Drawing.Point(940, 643)
        Me.cmdzurueck.Name = "cmdzurueck"
        Me.cmdzurueck.Size = New System.Drawing.Size(80, 58)
        Me.cmdzurueck.TabIndex = 122
        '
        'FAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdzurueck)
        Me.Controls.Add(Me.cmdStoerarchiv)
        Me.Controls.Add(Me.keyStoerung_quittieren)
        Me.Controls.Add(Me.keyHupe_aus)
        Me.Controls.Add(Me.keyLampentest)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.altAlarm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAlarm"
        Me.Text = "FAlarm"
        Me.Controls.SetChildIndex(Me.altAlarm, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.keyLampentest, 0)
        Me.Controls.SetChildIndex(Me.keyHupe_aus, 0)
        Me.Controls.SetChildIndex(Me.keyStoerung_quittieren, 0)
        Me.Controls.SetChildIndex(Me.cmdStoerarchiv, 0)
        Me.Controls.SetChildIndex(Me.cmdzurueck, 0)
        CType(Me.altAlarm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyLampentest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyHupe_aus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyStoerung_quittieren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdStoerarchiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents altAlarm As VisiWinNET.Forms.Alarm.AlarmList
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents keyLampentest As VisiWinNET.Forms.Key
    Friend WithEvents keyHupe_aus As VisiWinNET.Forms.Key
    Friend WithEvents keyStoerung_quittieren As VisiWinNET.Forms.Key
    Friend WithEvents cmdStoerarchiv As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdzurueck As VisiWinNET.Forms.CommandButton
End Class
