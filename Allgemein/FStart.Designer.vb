<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FStart
    Inherits VisiWinNET.Forms.StartForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStart))
        Me.LbStart = New System.Windows.Forms.Label
        Me.PBStart_Logo = New System.Windows.Forms.PictureBox
        Me.LbStart_Firma = New System.Windows.Forms.Label
        CType(Me.PBStart_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbStart
        '
        Me.LbStart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LbStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbStart.Location = New System.Drawing.Point(0, 0)
        Me.LbStart.Name = "LbStart"
        Me.LbStart.Size = New System.Drawing.Size(466, 330)
        Me.LbStart.TabIndex = 6
        '
        'PBStart_Logo
        '
        Me.PBStart_Logo.Image = CType(resources.GetObject("PBStart_Logo.Image"), System.Drawing.Image)
        Me.PBStart_Logo.Location = New System.Drawing.Point(82, 65)
        Me.PBStart_Logo.Name = "PBStart_Logo"
        Me.PBStart_Logo.Size = New System.Drawing.Size(310, 114)
        Me.PBStart_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBStart_Logo.TabIndex = 1
        Me.PBStart_Logo.TabStop = False
        '
        'LbStart_Firma
        '
        Me.LbStart_Firma.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LbStart_Firma.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStart_Firma.Location = New System.Drawing.Point(104, 182)
        Me.LbStart_Firma.Name = "LbStart_Firma"
        Me.LbStart_Firma.Size = New System.Drawing.Size(273, 45)
        Me.LbStart_Firma.TabIndex = 7
        Me.LbStart_Firma.Text = "ERNST REINHARDT GMBH Industrieofen- und Maschinenbau"
        Me.LbStart_Firma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 330)
        Me.Controls.Add(Me.LbStart_Firma)
        Me.Controls.Add(Me.PBStart_Logo)
        Me.Controls.Add(Me.LbStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Image = CType(resources.GetObject("$this.Image"), System.Drawing.Image)
        Me.Name = "FStart"
        Me.Project = "Rehau_18_525936"
        Me.Text = "FStart"
        CType(Me.PBStart_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbStart As System.Windows.Forms.Label
    Friend WithEvents PBStart_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents LbStart_Firma As System.Windows.Forms.Label

End Class
