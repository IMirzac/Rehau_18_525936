' Formular (modaler Dialog) zum Auswählen der Trendkurven für das Trend-Steuerelement

#Region " Template information "
' Diese Region nicht löschen
' Version = 6.0.0.0
' Created by = INOSOFT
' 
#End Region

#Region " Öffentliche Methoden "
' (Beschreibung siehe unten):
' - ShowDialog     Aufruf des Dialoges
#End Region

#Region " Aufrufbeispiele!!! "
' (es ist kein Instanzieren des Formulars notwendig, 
'  da die Methoden als "shared" deklariert sind!):

' FTrendSelect.ShowDialog(tChart)

' FTrendSelect.ShowDialog(tChart, Archive)

#End Region

#Region " Abhängigkeiten/zusätzliche Dateien "
' - Formular:
'   - FColorSelect
' - Verweise:
'   - VisiWinNET.Standard.Client
'   - VisiWinNET.Standard.Forms
' - IndexTexts in Gruppe
'   - Benutzertexte.Forms.FTrendSelect
'   - Dialogs.Common
#End Region

Public Class FTrendSelect

    Public Sub New()
        MyBase.New()

        'Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        'Diese Spalte wird ausgeblendet, da die Einstellung "Anzeige Skala" nicht verändert werden soll
        lvwSelectedTrends.Columns("colScaleVisible").Visible = False

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

#Region " Deklarationen "

    Private mTrendChart As VisiWinNET.Forms.Trend.TrendChart

#End Region

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    ' <summary>
    ' Aufruf des Dialoges zum Auswählen von Trendkurven aus beliebigen Archiven
    ' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ' Übergabe:
    '   tChart: TrendChart-Steuerelement, das konfiguriert werden soll
    ' Rückgabe:
    '   (tChart): TrendChart-Steuerelement mit zugewiesenen Trendkurven
    '   ShowLogOn: Windows.Forms.DialogResult.OK: Trends ausgewählt und zugewiesen
    '              DialogResult.Cancel: Abbruch
    ' </summary>
    Public Overloads Shared Function ShowDialog(ByVal tChart As VisiWinNET.Forms.Trend.TrendChart _
                                               ) As DialogResult
        Return ShowDialog(tChart, "")
    End Function

    ' <summary>
    ' Aufruf des Dialoges zum Auswählen von Trendkurven aus einem Archiv
    ' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ' Übergabe:
    '   tChart: TrendChart-Steuerelement, das konfiguriert werden soll
    '   sArchive: Name des Archivs, aus dem Trends ausgewählt werden können
    ' Rückgabe:
    '   (tChart): TrendChart-Steuerelement mit zugewiesenen Trendkurven
    '   ShowLogOn: Windows.Forms.DialogResult.OK: Trends ausgewählt und zugewiesen
    '              DialogResult.Cancel: Abbruch
    ' </summary>
    Public Overloads Shared Function ShowDialog(ByVal tChart As VisiWinNET.Forms.Trend.TrendChart, _
                                                ByVal sArchive As String _
                                               ) As DialogResult
        Dim frm As New FTrendSelect
        Return frm.InitDialog(tChart, sArchive)
    End Function

#End Region

#Region " Private Methoden "

    Private Function InitDialog(ByVal tChart As VisiWinNET.Forms.Trend.TrendChart, ByVal sArchive As String) As DialogResult
        Dim ret As DialogResult

        'bisherige Trendkurven im TrendChart auflisten
        For Each curve As VisiWinNET.Forms.Trend.TrendCurve In tChart.Curves
            AddSelection(lvwSelectedTrends, curve.Archive, curve.Trend, curve.LineColor, curve.Scale.Visible)
        Next

        'Alle definierten Archive auflisten
        For Each arc As VisiWinNET.Trend.Archive In VisiWinNET.Trend.TrendManager.Archives
            cmbArchives.Items.Add(IIf(arc.Text.Length > 0, arc.Text, arc.Name), arc.Name)
        Next

        If sArchive.Length = 0 Then
            'Auswahl freigeben
            cmbArchives.Enabled = True
            cmbArchives.SelectedIndex = 0
        Else
            'Archiv angegeben -> Auswahl sperren
            cmbArchives.Enabled = False
            For i As Integer = 0 To cmbArchives.Items.Count - 1
                If cmbArchives.Items(i).Tag = sArchive Then
                    'und in der Auswahl selektieren
                    cmbArchives.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

        ret = Me.ShowDialog()

        If ret = Windows.Forms.DialogResult.OK Then
            'Auswahl zurück ins TrendChart schreiben
            tChart.BeginInit()
            tChart.Curves.Clear()
            For Each itm As VisiWinNET.Forms.ListViewItem In lvwSelectedTrends.Items
                Dim curve As VisiWinNET.Forms.Trend.TrendCurve = New VisiWinNET.Forms.Trend.TrendCurve
                Dim trd As VisiWinNET.Trend.Trend
                Dim col As Color
                Dim astr() As String
                astr = Split(itm.Key, vbNullChar)
                trd = VisiWinNET.Trend.TrendManager.Archives(astr(0)).Trends(astr(1))
                curve.Archive = trd.Archive
                curve.Trend = trd.Name
                curve.Style = VisiWinNET.Forms.Trend.TrendCurveStyles.Interpolated

                'entfällt weil die Skalierung beim Aktualisieren der Trendanzeige erfolgt
                'curve.Scale.MajorAlignment = (curve.MaxValue - curve.MinValue) / 5
                'curve.Scale.MinorAlignment = curve.Scale.MajorAlignment / 2

                col = itm.Tag
                curve.Scale.ForeColor = col
                curve.LineColor = col
                curve.Scale.Visible = itm.Values.Item("colScaleVisible")
                tChart.Curves.Add(curve)
            Next
            tChart.EndInit()
        End If

        Me.Dispose()
        Return ret
    End Function

    Private Sub cmbArchives_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArchives.SelectedIndexChanged
        FillAvailableTrends()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If lstAvailableTrends.SelectedIndex > -1 And cmbArchives.SelectedIndex > -1 Then
            AddSelection(lvwSelectedTrends, _
                         cmbArchives.Items(cmbArchives.SelectedIndex).Tag, _
                         lstAvailableTrends.Items(lstAvailableTrends.SelectedIndex).Tag, _
                         GetNextColor, _
                         True)
            lstAvailableTrends.Items.RemoveAt(lstAvailableTrends.SelectedIndex)
        End If
    End Sub

    Private Sub cmdAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAll.Click
        Dim itm As VisiWinNET.Forms.ListItem
        For Each itm In lstAvailableTrends.Items
            AddSelection(lvwSelectedTrends, _
                         cmbArchives.Items(cmbArchives.SelectedIndex).Tag, _
                         itm.Tag, _
                         GetNextColor, _
                         True)
        Next itm
        lstAvailableTrends.Clear()
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If lvwSelectedTrends.SelectedIndex > -1 Then
            lvwSelectedTrends.Items.RemoveAt(lvwSelectedTrends.SelectedIndex)
            FillAvailableTrends()
        End If
    End Sub

    Private Sub cmdRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveAll.Click
        lvwSelectedTrends.Items.Clear()
        FillAvailableTrends()
    End Sub

    Private Sub lstAvailableTrends_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAvailableTrends.DoubleClick
        cmdAdd.PerformClick()
    End Sub

    Private Sub lvwSelectedTrends_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwSelectedTrends.DoubleClick
        cmdChangeColor.PerformClick()
    End Sub

    Private Sub cmdChangeColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeColor.Click
        If lvwSelectedTrends.SelectedIndex > -1 Then
            Dim col As Color
            col = lvwSelectedTrends.SelectedItem.Tag
            If FColorSelect.ShowDialog(col) = Windows.Forms.DialogResult.OK Then
                Dim bmp As New Bitmap(lvwSelectedTrends.Columns.Item("colColor").Width, lvwSelectedTrends.ItemHeight)
                Dim grph As Graphics
                grph = Graphics.FromImage(bmp)
                grph.FillRectangle(New SolidBrush(col), 0, 0, bmp.Width, bmp.Height)
                lvwSelectedTrends.SelectedItem.SubItems.Item("colColor") = bmp
                lvwSelectedTrends.SelectedItem.Tag = col
            End If
        End If
    End Sub

    Private Sub FillAvailableTrends()

        If cmbArchives.SelectedIndex = -1 Then Return

        Dim s As String

        lstAvailableTrends.Items.Clear()
        s = cmbArchives.Items(cmbArchives.SelectedIndex).Tag
        For Each trd As VisiWinNET.Trend.Trend In VisiWinNET.Trend.TrendManager.Archives(s).Trends
            Dim itm As VisiWinNET.Forms.ListViewItem
            itm = lvwSelectedTrends.Items(s & vbNullChar & trd.Name)
            If itm Is Nothing Then
                lstAvailableTrends.Items.Add(trd.Text, trd.Name)
            End If
        Next
    End Sub

    Private Sub AddSelection(ByVal lvw As VisiWinNET.Forms.ListView, _
                             ByVal archiveName As String, _
                             ByVal trendName As String, _
                             ByVal color As Color, _
                             ByVal Visible As Boolean)
        Dim itm As New VisiWinNET.Forms.ListViewItem
        Dim bmp As New Bitmap(lvw.Columns.Item("colColor").Width, lvw.ItemHeight)
        Dim grph As Graphics
        Dim archive As VisiWinNET.Trend.Archive
        Dim trend As VisiWinNET.Trend.Trend
        Dim curve As VisiWinNET.Forms.Trend.TrendCurve = New VisiWinNET.Forms.Trend.TrendCurve

        archive = VisiWinNET.Trend.TrendManager.Archives(archiveName)
        trend = archive.Trends(trendName)
        lvw.Items.Add(archiveName & vbNullChar & trendName, itm)
        itm.SubItems.Item("colArchive") = IIf(archive.Text.Length > 0, archive.Text, archive.Name)
        itm.SubItems.Item("colTrend") = trend.Text
        itm.SubItems.Item("colScaleVisible") = Visible
        If color.Equals(color.Empty) Or color.Equals(Drawing.Color.Black) Then
            color = trend.DisplayParameters.PenColor
        End If
        grph = Graphics.FromImage(bmp)
        grph.FillRectangle(New SolidBrush(color), 0, 0, bmp.Width, bmp.Height)
        itm.SubItems.Item("colColor") = bmp
        itm.Tag = color
    End Sub

    Private Function GetNextColor() As Color
        'Gibt für eine Trendkurve die nächstmögliche unterschiedliche Farbe zurück
        Dim aColor() As Color = _
            {Color.FromArgb(0, 0, 255), _
             Color.FromArgb(0, 255, 0), _
             Color.FromArgb(255, 0, 0), _
             Color.FromArgb(0, 255, 255), _
             Color.FromArgb(255, 0, 255), _
             Color.FromArgb(255, 255, 0), _
             Color.FromArgb(0, 0, 128), _
             Color.FromArgb(0, 128, 0), _
             Color.FromArgb(128, 0, 0), _
             Color.FromArgb(0, 128, 128), _
             Color.FromArgb(128, 0, 128), _
             Color.FromArgb(128, 128, 0)}

        For Each itm As VisiWinNET.Forms.ListViewItem In lvwSelectedTrends.Items
            Dim i As Integer
            i = Array.IndexOf(aColor, itm.Tag)
            If i >= 0 Then
                aColor(i) = Color.Empty
            End If
        Next
        For Each col As Color In aColor
            If Not col.Equals(Color.Empty) Then
                Return col
                Exit Function
            End If
        Next
        Return Color.Empty
    End Function

#End Region

#Region " Private Methoden: Formular verschieben "

    Private mX As Integer
    Private mY As Integer

    Private Sub lblCaption_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseDown
        Me.mX = e.X
        Me.mY = e.Y
    End Sub

    Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = New System.Drawing.Point(Me.Location.X - Me.mX + e.X, Me.Location.Y - Me.mY + e.Y)
        End If
    End Sub

#End Region

End Class
