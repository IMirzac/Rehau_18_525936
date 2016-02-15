<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBedienerfuehrung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBedienerfuehrung))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.altBedienerführung = New VisiWinNET.Forms.Alarm.AlarmList
        Me.cmdzurueck = New VisiWinNET.Forms.CommandButton
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.altBedienerführung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Bedienerführung"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'altBedienerführung
        '
        Me.altBedienerführung.AlarmFilter.DesiredClasses = "Meldung"
        Me.altBedienerführung.AlarmFilter.DesiredGroups = "Meldungen.Bedienerfuehrungen"
        Me.altBedienerführung.AlarmFilter.DesiredStates = VisiWinNET.Alarm.AlarmStates.Active
        Me.altBedienerführung.BackColorSelected = System.Drawing.SystemColors.HighlightText
        Me.altBedienerführung.Columns.AddRange(New VisiWinNET.Forms.Alarm.AlarmColumn() {New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.ActivationTime, 134, VisiWinNET.Forms.ContentAlign.TopLeft), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.Text, 855, VisiWinNET.Forms.ContentAlign.TopLeft)})
        Me.altBedienerführung.CurrentCursor = System.Windows.Forms.Cursors.Default
        Me.altBedienerführung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altBedienerführung.ForeColorSelected = System.Drawing.SystemColors.Highlight
        Me.altBedienerführung.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.altBedienerführung.Header.Resizable = False
        Me.altBedienerführung.Location = New System.Drawing.Point(2, 85)
        Me.altBedienerführung.Name = "altBedienerführung"
        Me.altBedienerführung.ScrollBarProperties.Width = 24
        Me.altBedienerführung.SelectedIndex = -1
        Me.altBedienerführung.Size = New System.Drawing.Size(1019, 525)

        Me.altBedienerführung.TabIndex = 41
        '
        'cmdzurueck
        '
        Me.cmdzurueck.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.FormHistoryBack(VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdzurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdzurueck.LocalizedText.Text = "zurück"
        Me.cmdzurueck.Location = New System.Drawing.Point(940, 616)
        Me.cmdzurueck.Name = "cmdzurueck"
        Me.cmdzurueck.Size = New System.Drawing.Size(80, 58)
        Me.cmdzurueck.TabIndex = 1015
        '
        'FBedienerfuehrung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdzurueck)
        Me.Controls.Add(Me.altBedienerführung)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FBedienerfuehrung"
        Me.Text = "FBedienerfuehrung"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.altBedienerführung, 0)
        Me.Controls.SetChildIndex(Me.cmdzurueck, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.altBedienerführung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents altBedienerführung As VisiWinNET.Forms.Alarm.AlarmList
    Friend WithEvents cmdzurueck As VisiWinNET.Forms.CommandButton
End Class
