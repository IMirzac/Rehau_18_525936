<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBedienerfuehrung
    Inherits HMI.FVorlage_Kopf_Fuss_Stoerzeile

    'Das Formular �berschreibt den L�schvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer ben�tigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist f�r den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer m�glich.
    'Das Bearbeiten mit dem Code-Editor ist nicht m�glich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBedienerfuehrung))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.altBedienerf�hrung = New VisiWinNET.Forms.Alarm.AlarmList
        Me.cmdzurueck = New VisiWinNET.Forms.CommandButton
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.altBedienerf�hrung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Bedienerf�hrung"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'altBedienerf�hrung
        '
        Me.altBedienerf�hrung.AlarmFilter.DesiredClasses = "Meldung"
        Me.altBedienerf�hrung.AlarmFilter.DesiredGroups = "Meldungen.Bedienerfuehrungen"
        Me.altBedienerf�hrung.AlarmFilter.DesiredStates = VisiWinNET.Alarm.AlarmStates.Active
        Me.altBedienerf�hrung.BackColorSelected = System.Drawing.SystemColors.HighlightText
        Me.altBedienerf�hrung.Columns.AddRange(New VisiWinNET.Forms.Alarm.AlarmColumn() {New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.ActivationTime, 134, VisiWinNET.Forms.ContentAlign.TopLeft), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.Text, 855, VisiWinNET.Forms.ContentAlign.TopLeft)})
        Me.altBedienerf�hrung.CurrentCursor = System.Windows.Forms.Cursors.Default
        Me.altBedienerf�hrung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altBedienerf�hrung.ForeColorSelected = System.Drawing.SystemColors.Highlight
        Me.altBedienerf�hrung.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.altBedienerf�hrung.Header.Resizable = False
        Me.altBedienerf�hrung.Location = New System.Drawing.Point(2, 85)
        Me.altBedienerf�hrung.Name = "altBedienerf�hrung"
        Me.altBedienerf�hrung.ScrollBarProperties.Width = 24
        Me.altBedienerf�hrung.SelectedIndex = -1
        Me.altBedienerf�hrung.Size = New System.Drawing.Size(1019, 525)

        Me.altBedienerf�hrung.TabIndex = 41
        '
        'cmdzurueck
        '
        Me.cmdzurueck.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.FormHistoryBack(VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdzurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdzurueck.LocalizedText.Text = "zur�ck"
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
        Me.Controls.Add(Me.altBedienerf�hrung)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FBedienerfuehrung"
        Me.Text = "FBedienerfuehrung"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.altBedienerf�hrung, 0)
        Me.Controls.SetChildIndex(Me.cmdzurueck, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.altBedienerf�hrung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents altBedienerf�hrung As VisiWinNET.Forms.Alarm.AlarmList
    Friend WithEvents cmdzurueck As VisiWinNET.Forms.CommandButton
End Class
