<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVorlage_Kopf_Fusszeile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVorlage_Kopf_Fusszeile))
        Me.keyFunktionstaste1 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste2 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste3 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste4 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste5 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste6 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste7 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste8 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste9 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste10 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste11 = New VisiWinNET.Forms.Key
        Me.keyFunktionstaste12 = New VisiWinNET.Forms.Key
        Me.sisTasten_Bedienerfuehrung_Diagnose = New VisiWinNET.Forms.StateItemServer(Me.components)
        CType(Me.keyFunktionstaste1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyFunktionstaste12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sisTasten_Bedienerfuehrung_Diagnose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'keyFunktionstaste1
        '
        Me.keyFunktionstaste1.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste1.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FCentral", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste1.LocalizedText.Text = "Grundmenü"
        Me.keyFunktionstaste1.Location = New System.Drawing.Point(5, 707)
        Me.keyFunktionstaste1.Name = "keyFunktionstaste1"
        Me.keyFunktionstaste1.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste1.TabIndex = 1001
        '
        'keyFunktionstaste2
        '
        Me.keyFunktionstaste2.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste2.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FStatus_Daten", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste2.LocalizedText.Text = "Status  Daten"
        Me.keyFunktionstaste2.Location = New System.Drawing.Point(90, 707)
        Me.keyFunktionstaste2.Name = "keyFunktionstaste2"
        Me.keyFunktionstaste2.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste2.TabIndex = 1002
        '
        'keyFunktionstaste3
        '
        Me.keyFunktionstaste3.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste3.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FRecipe", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste3.LocalizedText.Text = "Programme"
        Me.keyFunktionstaste3.Location = New System.Drawing.Point(175, 707)
        Me.keyFunktionstaste3.Name = "keyFunktionstaste3"
        Me.keyFunktionstaste3.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste3.TabIndex = 1003
        '
        'keyFunktionstaste4
        '
        Me.keyFunktionstaste4.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste4.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FStatus_Hand", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste4.LocalizedText.Text = "Status        Hand"
        Me.keyFunktionstaste4.Location = New System.Drawing.Point(260, 707)
        Me.keyFunktionstaste4.Name = "keyFunktionstaste4"
        Me.keyFunktionstaste4.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste4.TabIndex = 1004
        '
        'keyFunktionstaste5
        '
        Me.keyFunktionstaste5.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste5.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FProtokoll", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste5.LocalizedText.Text = "Protokoll"
        Me.keyFunktionstaste5.Location = New System.Drawing.Point(345, 707)
        Me.keyFunktionstaste5.Name = "keyFunktionstaste5"
        Me.keyFunktionstaste5.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste5.TabIndex = 1005
        '
        'keyFunktionstaste6
        '
        Me.keyFunktionstaste6.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste6.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FTrend", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste6.LocalizedText.Text = "Trend"
        Me.keyFunktionstaste6.Location = New System.Drawing.Point(430, 707)
        Me.keyFunktionstaste6.Name = "keyFunktionstaste6"
        Me.keyFunktionstaste6.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste6.TabIndex = 1006
        '
        'keyFunktionstaste7
        '
        Me.keyFunktionstaste7.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste7.Location = New System.Drawing.Point(515, 707)
        Me.keyFunktionstaste7.Name = "keyFunktionstaste7"
        Me.keyFunktionstaste7.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste7.TabIndex = 1007
        '
        'keyFunktionstaste8
        '
        Me.keyFunktionstaste8.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste8.Location = New System.Drawing.Point(600, 707)
        Me.keyFunktionstaste8.Name = "keyFunktionstaste8"
        Me.keyFunktionstaste8.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste8.TabIndex = 1008
        '
        'keyFunktionstaste9
        '
        Me.keyFunktionstaste9.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste9.Location = New System.Drawing.Point(685, 707)
        Me.keyFunktionstaste9.Name = "keyFunktionstaste9"
        Me.keyFunktionstaste9.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste9.TabIndex = 1009
        '
        'keyFunktionstaste10
        '
        Me.keyFunktionstaste10.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste10.Location = New System.Drawing.Point(770, 707)
        Me.keyFunktionstaste10.Name = "keyFunktionstaste10"
        Me.keyFunktionstaste10.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste10.TabIndex = 1010
        '
        'keyFunktionstaste11
        '
        Me.keyFunktionstaste11.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste11.Blink.BlinkColor = System.Drawing.Color.Yellow
        Me.keyFunktionstaste11.Blink.BlinkCycle = 2
        Me.keyFunktionstaste11.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FBedienerfuehrung", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste11.LocalizedText.Text = "Bediener-führung"
        Me.keyFunktionstaste11.Location = New System.Drawing.Point(855, 707)
        Me.keyFunktionstaste11.MonitorLED.ColorOff = System.Drawing.SystemColors.ButtonFace
        Me.keyFunktionstaste11.MonitorLED.ColorOn = System.Drawing.Color.Yellow
        Me.keyFunktionstaste11.Name = "keyFunktionstaste11"
        Me.keyFunktionstaste11.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste11.TabIndex = 1011
        Me.keyFunktionstaste11.VWItemMonitor.BitNumber = 8
        '
        'keyFunktionstaste12
        '
        Me.keyFunktionstaste12.Authorization.Right = "Bedienen"
        Me.keyFunktionstaste12.Blink.BlinkCycle = 2
        Me.keyFunktionstaste12.Blink.Mode = VisiWinNET.Services.BlinkMode.BlinkColor
        Me.keyFunktionstaste12.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.InputControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FAlarm", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.keyFunktionstaste12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyFunktionstaste12.LocalizedText.Text = "Diagnose"
        Me.keyFunktionstaste12.Location = New System.Drawing.Point(940, 707)
        Me.keyFunktionstaste12.MonitorLED.ColorOff = System.Drawing.SystemColors.ButtonFace
        Me.keyFunktionstaste12.MonitorLED.ColorOn = System.Drawing.Color.Red
        Me.keyFunktionstaste12.Name = "keyFunktionstaste12"
        Me.keyFunktionstaste12.Size = New System.Drawing.Size(80, 58)
        Me.keyFunktionstaste12.TabIndex = 1012
        Me.keyFunktionstaste12.VWItemMonitor.BitNumber = 9
        '
        'sisTasten_Bedienerfuehrung_Diagnose
        '
        Me.sisTasten_Bedienerfuehrung_Diagnose.VWItem.BitEvents = True
        Me.sisTasten_Bedienerfuehrung_Diagnose.VWItem.Name = "SPS Ofen.Kopplung.Status_Bit_an_PC"
        '
        'FVorlage_Kopf_Fusszeile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.keyFunktionstaste12)
        Me.Controls.Add(Me.keyFunktionstaste11)
        Me.Controls.Add(Me.keyFunktionstaste10)
        Me.Controls.Add(Me.keyFunktionstaste9)
        Me.Controls.Add(Me.keyFunktionstaste8)
        Me.Controls.Add(Me.keyFunktionstaste7)
        Me.Controls.Add(Me.keyFunktionstaste6)
        Me.Controls.Add(Me.keyFunktionstaste5)
        Me.Controls.Add(Me.keyFunktionstaste4)
        Me.Controls.Add(Me.keyFunktionstaste3)
        Me.Controls.Add(Me.keyFunktionstaste2)
        Me.Controls.Add(Me.keyFunktionstaste1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FVorlage_Kopf_Fusszeile"
        Me.Text = "FVorlage"
        Me.Controls.SetChildIndex(Me.keyFunktionstaste1, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste2, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste3, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste4, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste5, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste6, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste7, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste8, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste9, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste10, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste11, 0)
        Me.Controls.SetChildIndex(Me.keyFunktionstaste12, 0)
        CType(Me.keyFunktionstaste1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyFunktionstaste12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sisTasten_Bedienerfuehrung_Diagnose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents keyFunktionstaste1 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste2 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste3 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste4 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste5 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste6 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste7 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste8 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste9 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste10 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste11 As VisiWinNET.Forms.Key
    Friend WithEvents keyFunktionstaste12 As VisiWinNET.Forms.Key
    Friend WithEvents sisTasten_Bedienerfuehrung_Diagnose As VisiWinNET.Forms.StateItemServer
End Class
