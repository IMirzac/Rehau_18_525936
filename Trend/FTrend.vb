Imports VisiWinNET.UserManagement
Imports VisiWinNET.Services.AppService

Public Class FTrend

#Region " Deklarationen "
    'Formular drucken
    Private Const SRCCOPY As Integer = &HCC0020
    Dim memoryImage As Bitmap
    Private Declare Function BitBlt Lib "gdi32.dll" Alias "BitBlt" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As System.Int32) As Long
    Private Shared Start_Zeit As DateTime
    Private Shared Ende_Zeit As DateTime
    Private Shared Zeit_Extern As Boolean
#End Region

#Region " Initialisierung "

    Public Sub New()
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

    Private Sub FTrend_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Zeitachse_initialisieren()
        Call Temperaturachse_initialisieren()
    End Sub

    Private Sub FTrend_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            VWSet("SPS Ofen.Kopplung.Bildnummer", 6000)

            If Zeit_Extern = True Then
                dtiTrend_Start.Value = Start_Zeit
                dtiTrend_Ende.Value = Ende_Zeit
                Zeit_Extern = False
            End If
            Call Zeitachse_skalieren()
            Call Temperaturachse_skalieren()
        End If
    End Sub

#End Region

#Region "Eigenschaften"

    Public Shared Property StartZeit() As DateTime
        Get
            Return Start_Zeit
        End Get
        Set(ByVal value As DateTime)
            Start_Zeit = value
        End Set
    End Property

    Public Shared Property EndeZeit() As DateTime
        Get
            Return Ende_Zeit
        End Get
        Set(ByVal value As DateTime)
            Ende_Zeit = value
        End Set
    End Property

    Public Shared Property ZeitExtern() As Boolean
        Get
            Return Zeit_Extern
        End Get
        Set(ByVal value As Boolean)
            Zeit_Extern = value
        End Set
    End Property
#End Region


#Region " Ereignisse "

    Private Sub cmdAnzeigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnzeigen.Click
        Call Zeitachse_skalieren()
        Call Temperaturachse_skalieren()
    End Sub

    Private Sub cmdDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDrucken.Click
        Dim psdlg As New PageSetupDialog

        With psdlg
            CaptureForm()
            .Document = prdTrend
            .PageSettings.Landscape = True
            If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                prdTrend.PrinterSettings = .PrinterSettings
                prdTrend.Print()
            End If
        End With

    End Sub

    Private Sub tdlOfen_Temperaturen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdlOfen_Temperaturen.DoubleClick
        If tdlOfen_Temperaturen.Authorization.IsAuthorized = True Then
            FTrendSelect.ShowDialog(tdcOfen_Temperaturen, "Temperaturen")
            Call Zeitachse_skalieren()
            Call Temperaturachse_skalieren()
        End If
    End Sub

    Private Sub prdTrend_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdTrend.PrintPage
        e.Graphics.DrawImage(memoryImage, 50, 0)
    End Sub

#End Region

#Region "Öffnetliche Methoden"

    Public Sub ShowTrend(ByVal Start_Zeit As DateTime, ByVal End_Zeit As DateTime, ByVal Bildname_alt As String)
        Dim frm As New FTrend

        frm.dtiTrend_Start.Value = Start_Zeit
        frm.dtiTrend_Ende.Value = End_Zeit
        VisiWinNET.Forms.ProjectForms.Show("FTrend")

    End Sub

#End Region


#Region " Private Methoden "

    Private Sub Zeitachse_initialisieren() ' Eingabe Felder und Zeitachse initialisieren
        dtiTrend_Ende.Value = Now
        dtiTrend_Start.Value = DateAdd(DateInterval.Hour, -1, Now)
        tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
        tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute
        tdcOfen_Temperaturen.TimeScale.To = dtiTrend_Ende.Value
        tdcOfen_Temperaturen.TimeScale.Resolution = dtiTrend_Ende.Value - dtiTrend_Start.Value
        tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunde
        tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute
    End Sub

    Private Sub Zeitachse_skalieren()
        Dim Zeitspanne As TimeSpan

        dtiTrend_Start.Value = dtiTrend_Start.Value
        dtiTrend_Ende.Value = dtiTrend_Ende.Value

        If dtiTrend_Start.Value > Now Or dtiTrend_Ende.Value > Now Then ' Prüfen ob Zeiten in der Zukunft liegen
            FMessageBox.Show("Start/Ende liegt in der Zukunft  !", "Auswahl Zeitraum", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call Zeitachse_initialisieren()
            Exit Sub
        End If

        Zeitspanne = dtiTrend_Ende.Value - dtiTrend_Start.Value
        Select Case Zeitspanne.TotalSeconds ' Falsche Eingaben abfangen
            Case Is < 0
                FMessageBox.Show("Ende liegt vor dem Start !", "Auswahl Zeitraum", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call Zeitachse_initialisieren()
                Exit Sub
            Case Is < 300
                FMessageBox.Show("Zeitraum zu klein !", "Auswahl Zeitraum", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtiTrend_Ende.Value = DateAdd(DateInterval.Second, 300, dtiTrend_Start.Value)
                Zeitspanne = dtiTrend_Ende.Value - dtiTrend_Start.Value
            Case Is > 3456000
                FMessageBox.Show("Zeitraum zu gross !", "Auswahl Zeitraum", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call Zeitachse_initialisieren()
                Exit Sub
        End Select

        If Zeitspanne.TotalDays >= 1 Then ' Tage prüfen
            Select Case Zeitspanne.TotalDays
                Case Is > 30
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/10/2008# - #1/5/2008# ' 5 Tage
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 12:00:00 PM# - #1/1/2008# ' 12 Stunden
                    tdtTasten.LargeChange = #1/10/2008# - #1/5/2008# ' 5 Tage
                    tdtTasten.SmallChange = #1/1/2008 12:00:00 PM# - #1/1/2008# ' 12 Stunden
                    Exit Select
                Case Is > 20
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/6/2008# - #1/3/2008# ' 3 Tage
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 4:00:00 PM# ' 6 Stunden
                    tdtTasten.LargeChange = #1/6/2008# - #1/3/2008# ' 3 Tage
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 4:00:00 PM# ' 6 Stunden
                    Exit Select
                Case Is > 10
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/3/2008# - #1/1/2008# ' 2 Tage
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 6:00:00 PM# ' 4 Stunden
                    tdtTasten.LargeChange = #1/3/2008# - #1/1/2008# ' 2 Tage
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 6:00:00 PM# ' 4 Stunden
                    Exit Select
                Case Is > 5
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/6/2008# - #1/5/2008# ' 1 Tage
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 8:00:00 PM# ' 2 Stunden
                    tdtTasten.LargeChange = #1/6/2008# - #1/5/2008# ' 1 Tage
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 8:00:00 PM# ' 2 Stunden
                    Exit Select
                Case Is > 3
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 11:00:00 PM# - #1/1/2008 1:00:00 PM# ' 10 Stunden
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunden
                    tdtTasten.LargeChange = #1/1/2008 11:00:00 PM# - #1/1/2008 1:00:00 PM# ' 10 Stunden
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunden
                    Exit Select
                Case Is >= 1
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 11:00:00 PM# - #1/1/2008 5:00:00 PM# ' 6 Stunden
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunde
                    tdtTasten.LargeChange = #1/1/2008 11:00:00 PM# - #1/1/2008 5:00:00 PM# ' 6 Stunden
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunde
                    Exit Select
            End Select
            tdcOfen_Temperaturen.TimeScale.To = dtiTrend_Ende.Value
            tdcOfen_Temperaturen.TimeScale.Resolution = Zeitspanne
            Exit Sub
        End If

        If Zeitspanne.TotalHours >= 1 Then ' Stunden prüfen
            Select Case Zeitspanne.TotalHours
                Case Is > 10
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 8:00:00 PM# ' 2 Stunden
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 8:00:00 PM# ' 2 Stunden
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
                    Exit Select
                Case Is > 5
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunde
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:55:00 PM# ' 5 Minuten
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:00:00 PM# ' 1 Stunde
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:55:00 PM# ' 5 Minuten
                    Exit Select
                Case Is > 2
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:30:00 PM# ' 30 Minuten
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:57:00 PM# ' 3 Minuten
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:30:00 PM# ' 30 Minuten
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:57:00 PM# ' 3 Minuten
                    Exit Select
                Case Is >= 1
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute 
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute 
                    Exit Select
            End Select
            tdcOfen_Temperaturen.TimeScale.To = dtiTrend_Ende.Value
            tdcOfen_Temperaturen.TimeScale.Resolution = Zeitspanne
            Exit Sub
        End If

        If Zeitspanne.TotalMinutes >= 1 Then ' Minuten prüfen
            Select Case Zeitspanne.TotalMinutes
                Case Is > 50
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:50:00 PM# ' 10 Minuten
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute
                    Exit Select
                Case Is > 30
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:55:00 PM# ' 5 Minuten
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:30 PM# ' 30 Sekunden
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:55:00 PM# ' 5 Minuten
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:30 PM# ' 30 Sekunden
                    Exit Select
                Case Is > 20
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:57:00 PM# ' 3 Minuten
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:40 PM# ' 20 Sekunden
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:57:00 PM# ' 3 Minuten
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:40 PM# ' 20 Sekunden
                    Exit Select
                Case Is > 10
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:58:00 PM# ' 2 Minuten
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:50 PM# ' 10 Sekunden
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:58:00 PM# ' 2 Minuten
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:50 PM# ' 10 Sekunden
                    Exit Select
                Case Is >= 5
                    tdcOfen_Temperaturen.TimeScale.MajorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute
                    tdcOfen_Temperaturen.TimeScale.MinorAlignment = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:55 PM# ' 5 Sekunden
                    tdtTasten.LargeChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:00 PM# ' 1 Minute
                    tdtTasten.SmallChange = #1/1/2008 10:00:00 PM# - #1/1/2008 9:59:55 PM# ' 5 Sekunden
                    Exit Select
            End Select
            tdcOfen_Temperaturen.TimeScale.To = dtiTrend_Ende.Value
            tdcOfen_Temperaturen.TimeScale.Resolution = Zeitspanne
            Exit Sub
        End If
    End Sub

    Private Sub Temperaturachse_initialisieren()
        Dim Max_Temperatur As Integer = 400
        Dim Min_Temperatur As Integer = 0

        VisiWinNET.Services.AppService.VWSet("Trend.Max_Temperatur", Max_Temperatur)
        VisiWinNET.Services.AppService.VWSet("Trend.Min_Temperatur", Min_Temperatur)
        For index As Integer = 0 To tdcOfen_Temperaturen.Curves.Count - 1
            tdcOfen_Temperaturen.Curves.Item(index).MaxValue = Max_Temperatur
            tdcOfen_Temperaturen.Curves.Item(index).MinValue = Min_Temperatur
        Next index
    End Sub

    Private Sub Temperaturachse_skalieren()
        Dim Max_Temperatur As Integer
        Dim Min_Temperatur As Integer

        Max_Temperatur = VisiWinNET.Services.AppService.VWGet("Trend.Max_Temperatur")
        Min_Temperatur = VisiWinNET.Services.AppService.VWGet("Trend.Min_Temperatur")

        If Max_Temperatur - 50 < Min_Temperatur Then
            Min_Temperatur = Max_Temperatur - 50
            VisiWinNET.Services.AppService.VWSet("Trend.Min_Temperatur", Min_Temperatur)
        End If

        For index As Integer = 0 To tdcOfen_Temperaturen.Curves.Count - 1
            If index = 0 Then
                'Skalierung ist sichtbar und behält die Farbe bei verändern der Trendfarbe 
                tdcOfen_Temperaturen.Curves.Item(index).Scale.Visible = True
                tdcOfen_Temperaturen.Curves.Item(index).Scale.ForeColor = Color.Black
            Else
                tdcOfen_Temperaturen.Curves.Item(index).Scale.Visible = False
            End If
            tdcOfen_Temperaturen.Curves.Item(index).MaxValue = Max_Temperatur
            tdcOfen_Temperaturen.Curves.Item(index).MinValue = Min_Temperatur
            tdcOfen_Temperaturen.Curves.Item(index).Scale.MajorAlignment = 50
            tdcOfen_Temperaturen.Curves.Item(index).Scale.MinorAlignment = 10
        Next index
    End Sub

    Private Sub CaptureForm() 'Formular in Speicher schreiben
        Dim mygraphics As Graphics = Me.CreateGraphics()
        Dim sz As Size = Me.Size
        memoryImage = New Bitmap(sz.Width, sz.Height, mygraphics)

        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc
        Dim dc2 As IntPtr = memoryGraphics.GetHdc
        BitBlt(dc2, 0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height, dc1, 0, 0, SRCCOPY)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub

#End Region

End Class

