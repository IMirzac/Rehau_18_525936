<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTrend
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
        Dim ScaleAutoAlignment1 As VisiWinNET.Forms.Internals.ScaleAutoAlignment = New VisiWinNET.Forms.Internals.ScaleAutoAlignment
        Dim LogarithmProperties1 As VisiWinNET.Forms.Internals.LogarithmProperties = New VisiWinNET.Forms.Internals.LogarithmProperties
        Dim ScaleAutoAlignment2 As VisiWinNET.Forms.Internals.ScaleAutoAlignment = New VisiWinNET.Forms.Internals.ScaleAutoAlignment
        Dim LogarithmProperties2 As VisiWinNET.Forms.Internals.LogarithmProperties = New VisiWinNET.Forms.Internals.LogarithmProperties
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FTrend))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.tdcOfen_Temperaturen = New VisiWinNET.Forms.Trend.TrendChart
        Me.tdtTasten = New VisiWinNET.Forms.Trend.TrendTime
        Me.cmdAnzeigen = New VisiWinNET.Forms.CommandButton
        Me.dtiTrend_Start = New VisiWinNET.Forms.DateTimeIn
        Me.dtiTrend_Ende = New VisiWinNET.Forms.DateTimeIn
        Me.lblTrend_Start = New VisiWinNET.Forms.Label
        Me.lblTrend_Ende = New VisiWinNET.Forms.Label
        Me.lblMax_Temperatur = New VisiWinNET.Forms.Label
        Me.lblMin_Temperatur = New VisiWinNET.Forms.Label
        Me.vaiTrend_Max_Temperatur = New VisiWinNET.Forms.VarIn
        Me.vaiTrend_Min_Temperatur = New VisiWinNET.Forms.VarIn
        Me.tdlOfen_Temperaturen = New VisiWinNET.Forms.Trend.TrendLegend
        Me.cmdDrucken = New VisiWinNET.Forms.CommandButton
        Me.prdTrend = New System.Drawing.Printing.PrintDocument
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdcOfen_Temperaturen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdtTasten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdAnzeigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiTrend_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiTrend_Ende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTrend_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTrend_Ende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMax_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMin_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaiTrend_Max_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaiTrend_Min_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdlOfen_Temperaturen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDrucken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Ofen Temperaturen"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'tdcOfen_Temperaturen
        '
        Me.tdcOfen_Temperaturen.Authorization.Right = "Bedienen"
        Me.tdcOfen_Temperaturen.Curves.Add(New VisiWinNET.Forms.Trend.TrendCurve(0, 400, VisiWinNET.Forms.Trend.TrendCurveStyles.Interpolated, 1, VisiWinNET.Forms.Trend.CurveLineStyles.Solid, System.Drawing.Color.Red, "Temperaturen", "Regler_Sollwert", "", New VisiWinNET.Forms.Trend.TrendScale(0, New System.Drawing.Font("Microsoft Sans Serif", 7.8!), System.Drawing.Color.Black, 50, 10, 26, True, ScaleAutoAlignment1, LogarithmProperties1, VisiWinNET.Forms.Trend.TrendScaleUnitLayouts.None, VisiWinNET.Forms.Format.Number, VisiWinNET.Forms.LimitsVisibilities.Always), New VisiWinNET.Forms.PropertyBindingCollection(New VisiWinNET.Forms.IPropertyBinding(-1) {}), True))
        Me.tdcOfen_Temperaturen.Curves.Add(New VisiWinNET.Forms.Trend.TrendCurve(0, 400, VisiWinNET.Forms.Trend.TrendCurveStyles.Interpolated, 1, VisiWinNET.Forms.Trend.CurveLineStyles.Solid, System.Drawing.Color.DodgerBlue, "Temperaturen", "Regler_Istwert", "", New VisiWinNET.Forms.Trend.TrendScale(0, New System.Drawing.Font("Microsoft Sans Serif", 7.8!), System.Drawing.Color.DodgerBlue, 20, 10, 26, False, ScaleAutoAlignment2, LogarithmProperties2, VisiWinNET.Forms.Trend.TrendScaleUnitLayouts.None, VisiWinNET.Forms.Format.Number, VisiWinNET.Forms.LimitsVisibilities.Always), New VisiWinNET.Forms.PropertyBindingCollection(New VisiWinNET.Forms.IPropertyBinding(-1) {}), True))
        Me.tdcOfen_Temperaturen.Location = New System.Drawing.Point(5, 102)
        Me.tdcOfen_Temperaturen.Marker.Slider.AutoSize = False
        Me.tdcOfen_Temperaturen.Marker.Slider.Size = New System.Drawing.Size(30, 30)
        Me.tdcOfen_Temperaturen.Marker.Slider.Style = VisiWinNET.Forms.SliderStyles.Thumb
        Me.tdcOfen_Temperaturen.Marker.Slider.Visible = True
        Me.tdcOfen_Temperaturen.Marker.Visible = True
        Me.tdcOfen_Temperaturen.Name = "tdcOfen_Temperaturen"
        Me.tdcOfen_Temperaturen.Notes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.tdcOfen_Temperaturen.Size = New System.Drawing.Size(1015, 449)
        Me.tdcOfen_Temperaturen.TimeScale.DateTimeFormat.Mode = VisiWinNET.LanguageSwitching.DateTimeMode.TimeCRDate
        Me.tdcOfen_Temperaturen.TimeScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdcOfen_Temperaturen.TimeScale.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'tdtTasten
        '
        Me.tdtTasten.Authorization.Right = "Bedienen"
        Me.tdtTasten.BackColor = System.Drawing.SystemColors.Control
        Me.tdtTasten.DateTimeInProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdtTasten.DateTimeInProperties.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tdtTasten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdtTasten.LargeChange = System.TimeSpan.Parse("01:00:00")
        Me.tdtTasten.Location = New System.Drawing.Point(346, 557)
        Me.tdtTasten.Name = "tdtTasten"
        Me.tdtTasten.ScrollBarProperties.ShowEndButtons = True
        Me.tdtTasten.ScrollBarProperties.ShowPageButtons = True
        Me.tdtTasten.ScrollBarProperties.Width = 157
        Me.tdtTasten.Size = New System.Drawing.Size(254, 60)
        Me.tdtTasten.SmallChange = System.TimeSpan.Parse("00:01:00")
        Me.tdtTasten.TabIndex = 47
        Me.tdtTasten.TrendChart = Me.tdcOfen_Temperaturen
        '
        'cmdAnzeigen
        '
        Me.cmdAnzeigen.Authorization.Right = "Bedienen"
        Me.cmdAnzeigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnzeigen.LocalizedText.Text = "anzeigen"
        Me.cmdAnzeigen.Location = New System.Drawing.Point(940, 554)
        Me.cmdAnzeigen.Name = "cmdAnzeigen"
        Me.cmdAnzeigen.Size = New System.Drawing.Size(80, 58)
        Me.cmdAnzeigen.TabIndex = 55
        '
        'dtiTrend_Start
        '
        Me.dtiTrend_Start.Authorization.Right = "Bedienen"
        Me.dtiTrend_Start.ButtonWidth = 1
        Me.dtiTrend_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiTrend_Start.Location = New System.Drawing.Point(768, 554)
        Me.dtiTrend_Start.Name = "dtiTrend_Start"
        Me.dtiTrend_Start.ShowUpDown = False
        Me.dtiTrend_Start.Size = New System.Drawing.Size(152, 30)
        Me.dtiTrend_Start.TabIndex = 56
        Me.dtiTrend_Start.TimeSettings.Delay1 = 1000
        Me.dtiTrend_Start.TimeSettings.Delay2 = 3000
        Me.dtiTrend_Start.TimeSettings.Delay3 = 3000
        Me.dtiTrend_Start.TimeSettings.Interval1 = 500
        Me.dtiTrend_Start.TimeSettings.Interval2 = 250
        Me.dtiTrend_Start.TimeSettings.Interval3 = 100
        '
        'dtiTrend_Ende
        '
        Me.dtiTrend_Ende.Authorization.Right = "Bedienen"
        Me.dtiTrend_Ende.ButtonWidth = 1
        Me.dtiTrend_Ende.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiTrend_Ende.Location = New System.Drawing.Point(768, 587)
        Me.dtiTrend_Ende.Name = "dtiTrend_Ende"
        Me.dtiTrend_Ende.ShowUpDown = False
        Me.dtiTrend_Ende.Size = New System.Drawing.Size(152, 30)
        Me.dtiTrend_Ende.TabIndex = 60
        Me.dtiTrend_Ende.TimeSettings.Delay1 = 1000
        Me.dtiTrend_Ende.TimeSettings.Delay2 = 3000
        Me.dtiTrend_Ende.TimeSettings.Delay3 = 3000
        Me.dtiTrend_Ende.TimeSettings.Interval1 = 500
        Me.dtiTrend_Ende.TimeSettings.Interval2 = 250
        Me.dtiTrend_Ende.TimeSettings.Interval3 = 100
        '
        'lblTrend_Start
        '
        Me.lblTrend_Start.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblTrend_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrend_Start.LocalizedText.Text = "Start Zeitpunkt:"
        Me.lblTrend_Start.Location = New System.Drawing.Point(649, 555)
        Me.lblTrend_Start.Name = "lblTrend_Start"
        Me.lblTrend_Start.Size = New System.Drawing.Size(114, 28)
        Me.lblTrend_Start.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblTrend_Ende
        '
        Me.lblTrend_Ende.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblTrend_Ende.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrend_Ende.LocalizedText.Text = "End Zeitpunkt:"
        Me.lblTrend_Ende.Location = New System.Drawing.Point(649, 588)
        Me.lblTrend_Ende.Name = "lblTrend_Ende"
        Me.lblTrend_Ende.Size = New System.Drawing.Size(114, 28)
        Me.lblTrend_Ende.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblMax_Temperatur
        '
        Me.lblMax_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblMax_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax_Temperatur.LocalizedText.Text = "Max. Temperatur:"
        Me.lblMax_Temperatur.Location = New System.Drawing.Point(649, 622)
        Me.lblMax_Temperatur.Name = "lblMax_Temperatur"
        Me.lblMax_Temperatur.Size = New System.Drawing.Size(114, 28)
        Me.lblMax_Temperatur.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblMin_Temperatur
        '
        Me.lblMin_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblMin_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin_Temperatur.LocalizedText.Text = "Min. Temperatur:"
        Me.lblMin_Temperatur.Location = New System.Drawing.Point(649, 649)
        Me.lblMin_Temperatur.Name = "lblMin_Temperatur"
        Me.lblMin_Temperatur.Size = New System.Drawing.Size(114, 28)
        Me.lblMin_Temperatur.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vaiTrend_Max_Temperatur
        '
        Me.vaiTrend_Max_Temperatur.Authorization.Right = "Einstellungen"
        Me.vaiTrend_Max_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiTrend_Max_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiTrend_Max_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiTrend_Max_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vaiTrend_Max_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiTrend_Max_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiTrend_Max_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vaiTrend_Max_Temperatur.LimitMax.Value = 400
        Me.vaiTrend_Max_Temperatur.LimitMin.Value = 200
        Me.vaiTrend_Max_Temperatur.Location = New System.Drawing.Point(768, 618)
        Me.vaiTrend_Max_Temperatur.Name = "vaiTrend_Max_Temperatur"
        Me.vaiTrend_Max_Temperatur.Size = New System.Drawing.Size(91, 30)
        Me.vaiTrend_Max_Temperatur.TabIndex = 68
        Me.vaiTrend_Max_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vaiTrend_Max_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiTrend_Max_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiTrend_Max_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiTrend_Max_Temperatur.Unit.SizeRatio = 0.25
        Me.vaiTrend_Max_Temperatur.Unit.Text.Text = "°C"
        Me.vaiTrend_Max_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiTrend_Max_Temperatur.VWItem.Name = "Trend.Max_Temperatur"
        '
        'vaiTrend_Min_Temperatur
        '
        Me.vaiTrend_Min_Temperatur.Authorization.Right = "Einstellungen"
        Me.vaiTrend_Min_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiTrend_Min_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiTrend_Min_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiTrend_Min_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vaiTrend_Min_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiTrend_Min_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiTrend_Min_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vaiTrend_Min_Temperatur.LimitMax.Value = 350
        Me.vaiTrend_Min_Temperatur.Location = New System.Drawing.Point(768, 649)
        Me.vaiTrend_Min_Temperatur.Name = "vaiTrend_Min_Temperatur"
        Me.vaiTrend_Min_Temperatur.Size = New System.Drawing.Size(91, 31)
        Me.vaiTrend_Min_Temperatur.TabIndex = 76
        Me.vaiTrend_Min_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vaiTrend_Min_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiTrend_Min_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiTrend_Min_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiTrend_Min_Temperatur.Unit.SizeRatio = 0.25
        Me.vaiTrend_Min_Temperatur.Unit.Text.Text = "°C"
        Me.vaiTrend_Min_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiTrend_Min_Temperatur.VWItem.Name = "Trend.Min_Temperatur"
        '
        'tdlOfen_Temperaturen
        '
        Me.tdlOfen_Temperaturen.Authorization.Right = "Einstellungen"
        Me.tdlOfen_Temperaturen.Columns.AddRange(New VisiWinNET.Forms.Internals.ListViewBaseColumn() {New VisiWinNET.Forms.Trend.TrendLegendColumn(VisiWinNET.Forms.Trend.TrendLegendProperties.TrendText, "Trend", 99, System.Windows.Forms.HorizontalAlignment.Center, True, True), New VisiWinNET.Forms.Trend.TrendLegendColumn(VisiWinNET.Forms.Trend.TrendLegendProperties.Color, "Farbe", 42, System.Windows.Forms.HorizontalAlignment.Center, False, True), New VisiWinNET.Forms.Trend.TrendLegendColumn(VisiWinNET.Forms.Trend.TrendLegendProperties.MarkedValue, "Markierter Wert", 83, System.Windows.Forms.HorizontalAlignment.Center, False, True)})
        Me.tdlOfen_Temperaturen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdlOfen_Temperaturen.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdlOfen_Temperaturen.Header.Resizable = False
        Me.tdlOfen_Temperaturen.ItemHeight = 16
        Me.tdlOfen_Temperaturen.Location = New System.Drawing.Point(27, 557)
        Me.tdlOfen_Temperaturen.Name = "tdlOfen_Temperaturen"
        Me.tdlOfen_Temperaturen.ScrollBarProperties.Visibility = VisiWinNET.Forms.ScrollBarVisibility.None
        Me.tdlOfen_Temperaturen.ScrollBarProperties.Width = 24
        Me.tdlOfen_Temperaturen.Size = New System.Drawing.Size(228, 55)

        Me.tdlOfen_Temperaturen.TrendChart = Me.tdcOfen_Temperaturen
        '
        'cmdDrucken
        '
        Me.cmdDrucken.Authorization.Right = "Bedienen"
        Me.cmdDrucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDrucken.LocalizedText.Text = "drucken"
        Me.cmdDrucken.Location = New System.Drawing.Point(940, 619)
        Me.cmdDrucken.Name = "cmdDrucken"
        Me.cmdDrucken.Size = New System.Drawing.Size(80, 58)
        Me.cmdDrucken.TabIndex = 1021
        '
        'prdTrend
        '
        Me.prdTrend.DocumentName = "Trend"
        '
        'FTrend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmdDrucken)
        Me.Controls.Add(Me.vaiTrend_Min_Temperatur)
        Me.Controls.Add(Me.vaiTrend_Max_Temperatur)
        Me.Controls.Add(Me.lblMin_Temperatur)
        Me.Controls.Add(Me.lblMax_Temperatur)
        Me.Controls.Add(Me.lblTrend_Ende)
        Me.Controls.Add(Me.lblTrend_Start)
        Me.Controls.Add(Me.dtiTrend_Ende)
        Me.Controls.Add(Me.dtiTrend_Start)
        Me.Controls.Add(Me.cmdAnzeigen)
        Me.Controls.Add(Me.tdtTasten)
        Me.Controls.Add(Me.tdcOfen_Temperaturen)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.tdlOfen_Temperaturen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FTrend"
        Me.Text = "FTrend"
        Me.Controls.SetChildIndex(Me.tdlOfen_Temperaturen, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.tdcOfen_Temperaturen, 0)
        Me.Controls.SetChildIndex(Me.tdtTasten, 0)
        Me.Controls.SetChildIndex(Me.cmdAnzeigen, 0)
        Me.Controls.SetChildIndex(Me.dtiTrend_Start, 0)
        Me.Controls.SetChildIndex(Me.dtiTrend_Ende, 0)
        Me.Controls.SetChildIndex(Me.lblTrend_Start, 0)
        Me.Controls.SetChildIndex(Me.lblTrend_Ende, 0)
        Me.Controls.SetChildIndex(Me.lblMax_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.lblMin_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.vaiTrend_Max_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.vaiTrend_Min_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.cmdDrucken, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdcOfen_Temperaturen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdtTasten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdAnzeigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiTrend_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiTrend_Ende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTrend_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTrend_Ende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMax_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMin_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaiTrend_Max_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaiTrend_Min_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdlOfen_Temperaturen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDrucken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents tdcOfen_Temperaturen As VisiWinNET.Forms.Trend.TrendChart
    Friend WithEvents tdtTasten As VisiWinNET.Forms.Trend.TrendTime
    Friend WithEvents cmdAnzeigen As VisiWinNET.Forms.CommandButton
    Friend WithEvents dtiTrend_Start As VisiWinNET.Forms.DateTimeIn
    Friend WithEvents dtiTrend_Ende As VisiWinNET.Forms.DateTimeIn
    Friend WithEvents lblTrend_Start As VisiWinNET.Forms.Label
    Friend WithEvents lblTrend_Ende As VisiWinNET.Forms.Label
    Friend WithEvents lblMax_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents lblMin_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents vaiTrend_Max_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents vaiTrend_Min_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents tdlOfen_Temperaturen As VisiWinNET.Forms.Trend.TrendLegend
    Friend WithEvents cmdDrucken As VisiWinNET.Forms.CommandButton
    Friend WithEvents prdTrend As System.Drawing.Printing.PrintDocument
End Class
