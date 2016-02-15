<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAlarmHistory
    Inherits HMI.FVorlage_Kopf_Fusszeile

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAlarmHistory))
        Me.HistoricalAlarmList1 = New VisiWinNET.Forms.Alarm.HistoricalAlarmList
        Me.lblCount = New VisiWinNET.Forms.Label
        Me.lblStatus = New VisiWinNET.Forms.Label
        Me.Label2 = New VisiWinNET.Forms.Label
        Me.Label1 = New VisiWinNET.Forms.Label
        Me.cmdNotes = New VisiWinNET.Forms.CommandButton
        Me.cmdDetermine = New VisiWinNET.Forms.CommandButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.cmdStoerstatistik = New VisiWinNET.Forms.CommandButton
        CType(Me.HistoricalAlarmList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDetermine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdStoerstatistik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HistoricalAlarmList1
        '
        Me.HistoricalAlarmList1.BackColor = System.Drawing.SystemColors.Window
        Me.HistoricalAlarmList1.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.ActivationTime, "Components.AlarmList.ActivationTime", 150, System.Windows.Forms.HorizontalAlignment.Center, True, True, ""), New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.DeactivationTime, "Components.AlarmList.DeactivationTime", 150, System.Windows.Forms.HorizontalAlignment.Center, True, True, ""), New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.State, "Components.AlarmList.State", 50, System.Windows.Forms.HorizontalAlignment.Center, True, True, ""), New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.Priority, "Components.AlarmList.Priority", 54, System.Windows.Forms.HorizontalAlignment.Center, True, True, ""), New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.Group, "Components.AlarmList.Group", 80, System.Windows.Forms.HorizontalAlignment.Center, True, True, ""), New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.Text, "Components.AlarmList.Text", 424, System.Windows.Forms.HorizontalAlignment.Left, True, True, ""), New VisiWinNET.Forms.Alarm.HistoricalAlarmListColumn(VisiWinNET.Forms.Alarm.HistoricalAlarmProperties.NotesCount, "Components.AlarmList.NotesCount", 50, System.Windows.Forms.HorizontalAlignment.Center, True, True, "")})
        Me.HistoricalAlarmList1.Filter.MaxTime = New Date(CType(0, Long))
        Me.HistoricalAlarmList1.Filter.MinTime = New Date(CType(0, Long))
        Me.HistoricalAlarmList1.FontClass = "Labels"
        Me.HistoricalAlarmList1.Grid = False
        Me.HistoricalAlarmList1.Header.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.HistoricalAlarmList1.Header.FontClass = "Labels"
        Me.HistoricalAlarmList1.Header.Resizable = False
        Me.HistoricalAlarmList1.HistoricalFile = ""
        Me.HistoricalAlarmList1.Location = New System.Drawing.Point(3, 154)
        Me.HistoricalAlarmList1.Name = "HistoricalAlarmList1"
        Me.HistoricalAlarmList1.ScrollBarProperties.BackColorButton = System.Drawing.SystemColors.Control
        Me.HistoricalAlarmList1.ScrollBarProperties.BackColorThumb = System.Drawing.SystemColors.Control
        Me.HistoricalAlarmList1.ScrollBarProperties.ForeColorButton = System.Drawing.SystemColors.ControlText
        Me.HistoricalAlarmList1.ScrollBarProperties.ForeColorButtonDisabled = System.Drawing.SystemColors.GrayText
        Me.HistoricalAlarmList1.ScrollBarProperties.ShowEndButtons = True
        Me.HistoricalAlarmList1.ScrollBarProperties.ShowPageButtons = True
        Me.HistoricalAlarmList1.ScrollBarProperties.Visibility = VisiWinNET.Forms.ScrollBarVisibility.Both
        Me.HistoricalAlarmList1.ScrollBarProperties.Width = 24
        Me.HistoricalAlarmList1.Size = New System.Drawing.Size(1017, 487)

        Me.HistoricalAlarmList1.TabIndex = 1
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.FontClass = "Labels"
        Me.lblCount.LocalizedText.Text = "0"
        Me.lblCount.Location = New System.Drawing.Point(435, 100)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(87, 20)
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.FontClass = "Labels"
        Me.lblStatus.LocalizedText.TextGroup = "Forms.AlarmManagement.State"
        Me.lblStatus.LocalizedText.UseTextOn = False
        Me.lblStatus.Location = New System.Drawing.Point(154, 100)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(181, 20)
        Me.lblStatus.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Value
        Me.lblStatus.VWItem.Name = "__UNLINKED_I2"
        Me.lblStatus.VWItem.Range = CType(3, Long)
        '
        'Label2
        '
        Me.Label2.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.FontClass = "Labels"
        Me.Label2.LocalizedText.Text = "idxCount"
        Me.Label2.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.Label2.Location = New System.Drawing.Point(375, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'Label1
        '
        Me.Label1.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.FontClass = "Labels"
        Me.Label1.LocalizedText.Text = "idxState"
        Me.Label1.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.Label1.Location = New System.Drawing.Point(95, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleRight
        '
        'cmdNotes
        '
        Me.cmdNotes.Authorization.Right = "Bedienen"
        Me.cmdNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotes.FontClass = "Buttons"
        Me.cmdNotes.LocalizedText.Text = "cmdNotes"
        Me.cmdNotes.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.cmdNotes.Location = New System.Drawing.Point(564, 92)
        Me.cmdNotes.Name = "cmdNotes"
        Me.cmdNotes.Size = New System.Drawing.Size(82, 46)
        Me.cmdNotes.TabIndex = 2
        '
        'cmdDetermine
        '
        Me.cmdDetermine.Authorization.Right = "Bedienen"
        Me.cmdDetermine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetermine.FontClass = "Buttons"
        Me.cmdDetermine.LocalizedText.Text = "cmdDetermine"
        Me.cmdDetermine.LocalizedText.TextGroup = "Forms.AlarmManagement"
        Me.cmdDetermine.Location = New System.Drawing.Point(23, 92)
        Me.cmdDetermine.Name = "cmdDetermine"
        Me.cmdDetermine.Size = New System.Drawing.Size(82, 46)
        Me.cmdDetermine.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(154, 124)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(181, 20)
        Me.ProgressBar1.TabIndex = 3
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Störarchiv"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'cmdStoerstatistik
        '
        Me.cmdStoerstatistik.Authorization.Right = "Bedienen"
        Me.cmdStoerstatistik.Events.AddRange(New VisiWinNET.Forms.EventAgent() {New VisiWinNET.Forms.ButtonControlEventAgent("Click", New VisiWinNET.Commands.CommandCollection(New VisiWinNET.Commands.ICommand() {CType(New VisiWinNET.Forms.Commands.ShowForm("FAlarmHistory", VisiWinNET.Forms.FormChangeModes.ShowNewHideActive, 0), VisiWinNET.Commands.ICommand)}))})
        Me.cmdStoerstatistik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStoerstatistik.LocalizedText.Text = "Stöerstatistik"
        Me.cmdStoerstatistik.Location = New System.Drawing.Point(5, 643)
        Me.cmdStoerstatistik.Name = "cmdStoerstatistik"
        Me.cmdStoerstatistik.Size = New System.Drawing.Size(80, 58)
        Me.cmdStoerstatistik.TabIndex = 54
        Me.cmdStoerstatistik.Visible = False
        '
        'FAlarmHistory
        '
        Me.AcceptButton = Me.cmdDetermine
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdStoerstatistik)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmdDetermine)
        Me.Controls.Add(Me.cmdNotes)
        Me.Controls.Add(Me.HistoricalAlarmList1)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAlarmHistory"
        Me.Text = "FAlarmHistoryTouch"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.lblCount, 0)
        Me.Controls.SetChildIndex(Me.HistoricalAlarmList1, 0)
        Me.Controls.SetChildIndex(Me.cmdNotes, 0)
        Me.Controls.SetChildIndex(Me.cmdDetermine, 0)
        Me.Controls.SetChildIndex(Me.ProgressBar1, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.cmdStoerstatistik, 0)
        CType(Me.HistoricalAlarmList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDetermine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdStoerstatistik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	Private WithEvents HistoricalAlarmList1 As VisiWinNET.Forms.Alarm.HistoricalAlarmList
	Private WithEvents lblCount As VisiWinNET.Forms.Label
	Private WithEvents lblStatus As VisiWinNET.Forms.Label
	Private WithEvents Label2 As VisiWinNET.Forms.Label
	Private WithEvents Label1 As VisiWinNET.Forms.Label
	Private WithEvents cmdNotes As VisiWinNET.Forms.CommandButton
	Private WithEvents cmdDetermine As VisiWinNET.Forms.CommandButton
    Private WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents cmdStoerstatistik As VisiWinNET.Forms.CommandButton

End Class
