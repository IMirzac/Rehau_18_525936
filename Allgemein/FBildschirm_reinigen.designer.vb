<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBildschirm_reinigen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBildschirm_reinigen))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.lblBildschirm_reinigen = New VisiWinNET.Forms.Label
        Me.PgbBildschirm_reinigen = New System.Windows.Forms.ProgressBar
        Me.TiBildschirm_reinigen = New System.Windows.Forms.Timer(Me.components)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBildschirm_reinigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Bildschirm reinigen"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'lblBildschirm_reinigen
        '
        Me.lblBildschirm_reinigen.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblBildschirm_reinigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBildschirm_reinigen.LocalizedText.Text = "Der Bildschirm kann jetzt gereinigt werden !"
        Me.lblBildschirm_reinigen.Location = New System.Drawing.Point(129, 264)
        Me.lblBildschirm_reinigen.Name = "lblBildschirm_reinigen"
        Me.lblBildschirm_reinigen.Size = New System.Drawing.Size(758, 37)
        '
        'PgbBildschirm_reinigen
        '
        Me.PgbBildschirm_reinigen.Location = New System.Drawing.Point(232, 362)
        Me.PgbBildschirm_reinigen.Name = "PgbBildschirm_reinigen"
        Me.PgbBildschirm_reinigen.Size = New System.Drawing.Size(575, 72)
        Me.PgbBildschirm_reinigen.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PgbBildschirm_reinigen.TabIndex = 42
        '
        'TiBildschirm_reinigen
        '
        Me.TiBildschirm_reinigen.Interval = 2000
        '
        'FBildschirm_reinigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.PgbBildschirm_reinigen)
        Me.Controls.Add(Me.lblBildschirm_reinigen)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FBildschirm_reinigen"
        Me.Text = "FBildschirm_reinigen"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.lblBildschirm_reinigen, 0)
        Me.Controls.SetChildIndex(Me.PgbBildschirm_reinigen, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBildschirm_reinigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents lblBildschirm_reinigen As VisiWinNET.Forms.Label
    Friend WithEvents PgbBildschirm_reinigen As System.Windows.Forms.ProgressBar
    Friend WithEvents TiBildschirm_reinigen As System.Windows.Forms.Timer
End Class
