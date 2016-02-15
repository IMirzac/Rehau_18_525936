<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FStatistic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStatistic))
        Me.listView1 = New VisiWinNET.Forms.ListView
        Me.cmdzurueck = New VisiWinNET.Forms.CommandButton
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        CType(Me.listView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.ListViewLocalizedTextColumn("Text", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Text", 253, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.LocalizedText, True, True), New VisiWinNET.Forms.ListViewNumericalColumn("Number", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "Number", 80, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Numerical, True, True), New VisiWinNET.Forms.ListViewNumericalColumn("MaxActivation", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "MaxAlarms", 70, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Numerical, True, True), New VisiWinNET.Forms.ListViewImageColumn("MaxActivation", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "MaxAlarmsBar", 70, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Image, False, True), New VisiWinNET.Forms.ListViewNumericalColumn("AvrgActivation", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "AvrgAlarms", 80, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Numerical, True, True), New VisiWinNET.Forms.ListViewTextColumn("MaxDuration", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "MaxDuration", 70, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True), New VisiWinNET.Forms.ListViewImageColumn("MaxDuration", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "MaxDurationsBar", 70, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Image, False, True), New VisiWinNET.Forms.ListViewTextColumn("AvrgDuration", "FAlarmStatistics.Columns", VisiWinNET.LanguageSwitching.TextTypes.ClientApplication, "AvrgDuration", 70, System.Windows.Forms.HorizontalAlignment.Left, VisiWinNET.Forms.ColumnTypes.Text, True, True)})
        Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.listView1.Header.Height = 30
        Me.listView1.Header.Resizable = False
        Me.listView1.ItemHeight = 30
        Me.listView1.Location = New System.Drawing.Point(3, 103)
        Me.listView1.Name = "listView1"
        Me.listView1.ScrollBarProperties.Width = 24
        Me.listView1.Size = New System.Drawing.Size(1017, 532)

        Me.listView1.TabIndex = 112
        '
        'cmdzurueck
        '
        Me.cmdzurueck.Authorization.Right = "Bedienen"
        Me.cmdzurueck.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.FormHistoryBack(VisiWinNET.Forms.FormChangeModes.ShowNewCloseActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdzurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdzurueck.LocalizedText.Text = "zurück"
        Me.cmdzurueck.Location = New System.Drawing.Point(940, 642)
        Me.cmdzurueck.Name = "cmdzurueck"
        Me.cmdzurueck.Size = New System.Drawing.Size(80, 58)
        Me.cmdzurueck.TabIndex = 121
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Störstatistik"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'FStatistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.cmdzurueck)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FStatistic"
        Me.Text = "FStatistic"
        Me.Controls.SetChildIndex(Me.cmdzurueck, 0)
        Me.Controls.SetChildIndex(Me.listView1, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        CType(Me.listView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdzurueck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listView1 As VisiWinNET.Forms.ListView
    Friend WithEvents cmdzurueck As VisiWinNET.Forms.CommandButton
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
End Class
