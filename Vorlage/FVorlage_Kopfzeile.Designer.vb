<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVorlage_Kopfzeile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVorlage_Kopfzeile))
        Me.VWPBKopfzeile_Logo = New VisiWinNET.Forms.PictureBox
        Me.lblBenutzer = New VisiWinNET.Forms.Label
        Me.votBenutzer = New VisiWinNET.Forms.VarOut
        Me.VWLbKopfzeile_Rahmen = New VisiWinNET.Forms.Label
        Me.dtoDatum_Uhrzeit = New VisiWinNET.Forms.DateTimeOut
        Me.lblBetriebsart = New VisiWinNET.Forms.Label
        Me.picKopfzeile = New VisiWinNET.Forms.PictureBox
        Me.lblKopplungSPS = New VisiWinNET.Forms.Label
        CType(Me.VWPBKopfzeile_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBenutzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votBenutzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWLbKopfzeile_Rahmen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtoDatum_Uhrzeit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBetriebsart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKopfzeile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKopplungSPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VWPBKopfzeile_Logo
        '
        Me.VWPBKopfzeile_Logo.Location = New System.Drawing.Point(0, 0)
        Me.VWPBKopfzeile_Logo.Name = "VWPBKopfzeile_Logo"
        Me.VWPBKopfzeile_Logo.Size = New System.Drawing.Size(0, 0)
        '
        'lblBenutzer
        '
        Me.lblBenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBenutzer.LocalizedText.Text = "Benutzer:"
        Me.lblBenutzer.Location = New System.Drawing.Point(801, 31)
        Me.lblBenutzer.Name = "lblBenutzer"
        Me.lblBenutzer.Size = New System.Drawing.Size(219, 24)
        Me.lblBenutzer.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votBenutzer
        '
        Me.votBenutzer.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votBenutzer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votBenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votBenutzer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votBenutzer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votBenutzer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votBenutzer.Location = New System.Drawing.Point(876, 37)
        Me.votBenutzer.Name = "votBenutzer"
        Me.votBenutzer.Size = New System.Drawing.Size(135, 15)
        Me.votBenutzer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votBenutzer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votBenutzer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votBenutzer.Unit.SizeRatio = 0.25
        Me.votBenutzer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votBenutzer.VWItem.Name = "__CURRENT_USER.FULLNAME"
        '
        'VWLbKopfzeile_Rahmen
        '
        Me.VWLbKopfzeile_Rahmen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VWLbKopfzeile_Rahmen.Location = New System.Drawing.Point(2, 2)
        Me.VWLbKopfzeile_Rahmen.Name = "VWLbKopfzeile_Rahmen"
        Me.VWLbKopfzeile_Rahmen.Size = New System.Drawing.Size(1022, 82)
        '
        'dtoDatum_Uhrzeit
        '
        Me.dtoDatum_Uhrzeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtoDatum_Uhrzeit.Location = New System.Drawing.Point(801, 6)
        Me.dtoDatum_Uhrzeit.Name = "dtoDatum_Uhrzeit"
        Me.dtoDatum_Uhrzeit.Size = New System.Drawing.Size(218, 24)
        Me.dtoDatum_Uhrzeit.TabIndex = 32
        '
        'lblBetriebsart
        '
        Me.lblBetriebsart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBetriebsart.Location = New System.Drawing.Point(801, 57)
        Me.lblBetriebsart.Name = "lblBetriebsart"
        Me.lblBetriebsart.Size = New System.Drawing.Size(219, 24)
        Me.lblBetriebsart.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        Me.lblBetriebsart.Visible = False
        '
        'picKopfzeile
        '
        Me.picKopfzeile.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("picKopfzeile.Images"), System.Drawing.Image)})
        Me.picKopfzeile.ImageSizeMode = VisiWinNET.Forms.ImageSizeModes.StretchImage
        Me.picKopfzeile.Location = New System.Drawing.Point(8, 8)
        Me.picKopfzeile.Name = "picKopfzeile"
        Me.picKopfzeile.Size = New System.Drawing.Size(159, 60)
        '
        'lblKopplungSPS
        '
        Me.lblKopplungSPS.BackColor = System.Drawing.SystemColors.Control
        Me.lblKopplungSPS.BackColorOn = System.Drawing.Color.Red
        Me.lblKopplungSPS.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblKopplungSPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKopplungSPS.ForeColor = System.Drawing.SystemColors.Control
        Me.lblKopplungSPS.LocalizedText.Text = "Kommunikation zur SPS gestört"
        Me.lblKopplungSPS.Location = New System.Drawing.Point(407, 59)
        Me.lblKopplungSPS.Name = "lblKopplungSPS"
        Me.lblKopplungSPS.Size = New System.Drawing.Size(193, 21)
        Me.lblKopplungSPS.VWItem.BitEvents = True
        Me.lblKopplungSPS.VWItem.Name = "Kopplung.Status_SPS_Kopplung_niO"
        Me.lblKopplungSPS.VWItem.Range = CType(2, Long)
        '
        'FVorlage_Kopfzeile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblKopplungSPS)
        Me.Controls.Add(Me.lblBetriebsart)
        Me.Controls.Add(Me.dtoDatum_Uhrzeit)
        Me.Controls.Add(Me.picKopfzeile)
        Me.Controls.Add(Me.votBenutzer)
        Me.Controls.Add(Me.lblBenutzer)
        Me.Controls.Add(Me.VWPBKopfzeile_Logo)
        Me.Controls.Add(Me.VWLbKopfzeile_Rahmen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FVorlage_Kopfzeile"
        CType(Me.VWPBKopfzeile_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBenutzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votBenutzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWLbKopfzeile_Rahmen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtoDatum_Uhrzeit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBetriebsart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKopfzeile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKopplungSPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VWPBKopfzeile_Logo As VisiWinNET.Forms.PictureBox
    Friend WithEvents lblBenutzer As VisiWinNET.Forms.Label
    Friend WithEvents votBenutzer As VisiWinNET.Forms.VarOut
    Friend WithEvents VWLbKopfzeile_Rahmen As VisiWinNET.Forms.Label
    Friend WithEvents picKopfzeile As VisiWinNET.Forms.PictureBox
    Friend WithEvents dtoDatum_Uhrzeit As VisiWinNET.Forms.DateTimeOut
    Friend WithEvents lblBetriebsart As VisiWinNET.Forms.Label
    Friend WithEvents lblKopplungSPS As VisiWinNET.Forms.Label
End Class
