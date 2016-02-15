<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVorlage_Kopf_Fuss_Stoerzeile
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVorlage_Kopf_Fuss_Stoerzeile))
        Me.alnStoerzeile = New VisiWinNET.Forms.Alarm.AlarmLine
        Me.VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile = New VisiWinNET.Forms.StateItemServer(Me.components)
        CType(Me.alnStoerzeile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'alnStoerzeile
        '
        Me.alnStoerzeile.AlarmFilter.DesiredGroups = "Alarme.Allgemein;Alarme.Ofen;Systemalarm"
        Me.alnStoerzeile.Columns.AddRange(New VisiWinNET.Forms.Alarm.AlarmColumn() {New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.ActivationTime, 111, VisiWinNET.Forms.ContentAlign.MiddleLeft, True), New VisiWinNET.Forms.Alarm.AlarmColumn(VisiWinNET.Forms.Alarm.AlarmProperties.Text, 672, VisiWinNET.Forms.ContentAlign.MiddleLeft, True)})
        Me.alnStoerzeile.DisplayMode = VisiWinNET.Forms.Alarm.AlarmLineDisplayModes.SingleLine
        Me.alnStoerzeile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alnStoerzeile.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.alnStoerzeile.Location = New System.Drawing.Point(5, 680)
        Me.alnStoerzeile.Name = "alnStoerzeile"
        Me.alnStoerzeile.Size = New System.Drawing.Size(1017, 21)
        Me.alnStoerzeile.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        Me.alnStoerzeile.Visible = False
        '
        'VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile
        '
        Me.VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile.VWItem.BitEvents = True
        Me.VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile.VWItem.Name = "SPS Ofen.Kopplung.Status_Bit_an_PC"
        Me.VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile.VWItem.WatchedBitNo = 9
        '
        'FVorlage_Kopf_Fuss_Stoerzeile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.alnStoerzeile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FVorlage_Kopf_Fuss_Stoerzeile"
        Me.Text = "FVorlage_Kopf_Fusszeile_Stoerzeile"
        Me.Controls.SetChildIndex(Me.alnStoerzeile, 0)
        CType(Me.alnStoerzeile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents alnStoerzeile As VisiWinNET.Forms.Alarm.AlarmLine
    Friend WithEvents VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile As VisiWinNET.Forms.StateItemServer
End Class
