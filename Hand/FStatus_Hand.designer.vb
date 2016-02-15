<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FStatus_Hand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStatus_Hand))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.lblEL_Duesenkanal = New VisiWinNET.Forms.Label
        Me.lblDuesenkanal = New VisiWinNET.Forms.Label
        Me.keyDuesenkanal_ein = New VisiWinNET.Forms.Key
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEL_Duesenkanal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDuesenkanal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyDuesenkanal_ein, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Status Hand"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'lblEL_Duesenkanal
        '
        Me.lblEL_Duesenkanal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEL_Duesenkanal.BackColorOn = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEL_Duesenkanal.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEL_Duesenkanal.Border.Color3 = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEL_Duesenkanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEL_Duesenkanal.LocalizedText.Text = "aus_ein"
        Me.lblEL_Duesenkanal.LocalizedText.TextGroup = "Textlisten.aus_ein"
        Me.lblEL_Duesenkanal.LocalizedText.TextOn = "aus_ein0"
        Me.lblEL_Duesenkanal.LocalizedText.TextPrefix = "aus_ein"
        Me.lblEL_Duesenkanal.LocalizedText.UseTextOn = False
        Me.lblEL_Duesenkanal.Location = New System.Drawing.Point(310, 180)
        Me.lblEL_Duesenkanal.Name = "lblEL_Duesenkanal"
        Me.lblEL_Duesenkanal.Size = New System.Drawing.Size(403, 40)
        Me.lblEL_Duesenkanal.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Value
        Me.lblEL_Duesenkanal.VWItem.Name = "SPS Ofen.Arbeit_PC.ELDuesenkanal"
        '
        'lblDuesenkanal
        '
        Me.lblDuesenkanal.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblDuesenkanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuesenkanal.LocalizedText.Text = "Düsenkanal"
        Me.lblDuesenkanal.Location = New System.Drawing.Point(128, 137)
        Me.lblDuesenkanal.Name = "lblDuesenkanal"
        Me.lblDuesenkanal.Size = New System.Drawing.Size(766, 37)
        '
        'keyDuesenkanal_ein
        '
        Me.keyDuesenkanal_ein.Authorization.Right = "Bedienen"
        Me.keyDuesenkanal_ein.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.keyDuesenkanal_ein.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyDuesenkanal_ein.ForeColor = System.Drawing.SystemColors.ControlText
        Me.keyDuesenkanal_ein.LocalizedText.Text = "Ein"
        Me.keyDuesenkanal_ein.Location = New System.Drawing.Point(6, 153)
        Me.keyDuesenkanal_ein.Name = "keyDuesenkanal_ein"
        Me.keyDuesenkanal_ein.SetMode = VisiWinNET.Forms.SetMode.KeyMode
        Me.keyDuesenkanal_ein.Size = New System.Drawing.Size(116, 80)
        Me.keyDuesenkanal_ein.TabIndex = 43
        Me.keyDuesenkanal_ein.VWItem.BitNumber = 4
        Me.keyDuesenkanal_ein.VWItem.Name = "SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC"
        '
        'FStatus_Hand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.keyDuesenkanal_ein)
        Me.Controls.Add(Me.lblDuesenkanal)
        Me.Controls.Add(Me.lblEL_Duesenkanal)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FStatus_Hand"
        Me.Text = "FStatus_Hand"
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.lblEL_Duesenkanal, 0)
        Me.Controls.SetChildIndex(Me.lblDuesenkanal, 0)
        Me.Controls.SetChildIndex(Me.keyDuesenkanal_ein, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEL_Duesenkanal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDuesenkanal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyDuesenkanal_ein, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents lblEL_Duesenkanal As VisiWinNET.Forms.Label
    Friend WithEvents lblDuesenkanal As VisiWinNET.Forms.Label
    Friend WithEvents keyDuesenkanal_ein As VisiWinNET.Forms.Key
End Class
