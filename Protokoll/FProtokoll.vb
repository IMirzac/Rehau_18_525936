'Wenn der Programmregler Standard funktionieren soll müssen in der Bildmaske die Elemente des
'Abschnitts Endtemperatur wieder sichtbar gemacht werden und im Report müssen die Farbe
'der Elemente des Abschnitts Endtemperatur von weis auf schwarz geändert werden (bei Überschrift
'Rahmenfarbe zusätzlich auf schwarz setzen).
'Bei dieser Anlage wir die Temperatur eines Abschnitts sowohl als Start-
'als auch als Endtemperatur verwendet => keine geregelten Aufheizphasen möglich.

Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Imports System.Environment
Imports System.Drawing.Printing
Imports VisiWinNET.Services.AppService
Public Class FProtokoll

#Region " Initialisierung "

    Private Sub FProtokoll_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblCharge.Text = "" 'Charge initialisieren
    End Sub

    Private Sub FProtokoll_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VWSet("SPS Ofen.Kopplung.Bildnummer", 5000)
    End Sub

#End Region

#Region " Ereignisse "

    Private Sub lblCharge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCharge.Click
        Dim Charge As String
        Charge = FProtokollSelect.ShowProtokollDialog()
        If Charge <> "" Then
            lblCharge.Text = Charge
        End If
        If lblCharge.Text <> "" Then
            Call Kopfdaten_lesen()
            Call Rezept_lesen()
            Call Prozess_Meldungen_anzeigen()
            Call Stoer_Meldungen_anzeigen()
            Call Endbewertung_lesen()
        End If
    End Sub

    Private Sub cmdEndbewertung_speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEndbewertung_speichern.Click
        
        Call Endbewertung_schreiben(lblCharge.Text)
        Call Endbewertung_lesen()
    End Sub

    Private Sub cmdProtokoll_drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProtokoll_drucken.Click
        Dim DS As New DataSet()
        Dim rp As New crpProtokoll()
        Dim ps As New PrinterSettings
        rp.Database.Tables("Bewertung").SetDataSource(ReadDataForProtokol(lblCharge.Text, "Bewertung").Tables("Bewertung"))
        rp.Database.Tables("Kopfdaten").SetDataSource(ReadDataForProtokol(lblCharge.Text, "Kopfdaten").Tables("Kopfdaten"))
        rp.Database.Tables("Prozess").SetDataSource(ReadDataForProtokol(lblCharge.Text, "Prozess").Tables("Prozess"))
        rp.Database.Tables("Rezept").SetDataSource(ReadDataForProtokol(lblCharge.Text, "Rezept").Tables("Rezept"))
        rp.Database.Tables("Stoerungen").SetDataSource(ReadDataForProtokol(lblCharge.Text, "Stoerungen").Tables("Stoerungen"))

        Try

            ps.PrinterName = rp.PrintOptions.PrinterName
            prdProtokoll.PrinterSettings = ps
            If prdProtokoll.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                rp.PrintOptions.PrinterName = prdProtokoll.PrinterSettings.PrinterName
                rp.PrintToPrinter(0, True, 0, 0)
            End If
            Exit Sub

        Catch ex As Exception
            FMessageBox.Show("Keine Daten vorhanden / ausgewählt !", "Protokoll drucken", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub New_Alarm_NewAlarm(ByVal sender As Object, ByVal e As VisiWinNET.Alarm.AlarmEventArgs) Handles New_Alarm.NewAlarm
        'Störungen in Chargenprotokolle eintragen
        If VWGet("SPS Ofen.Arbeit_PC.Programm_Status") <> 0 Then
            If e.Alarm.Group.Name <> "Bedienerfuehrungen" Then
                Call Chargen_Meldungen("Stoerungen", e.Alarm.Group.Name, e.Alarm.Text)
            End If
        End If
    End Sub

    Private Sub keyTrend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles keyTrend.Click
        Dim Anzahlzeile As Integer

        Anzahlzeile = dgvProzess_Meldungen.Rows.Count
        If Anzahlzeile >= 2 Then
            FTrend.StartZeit = dgvProzess_Meldungen.Rows(0).Cells(2).Value
            FTrend.EndeZeit = dgvProzess_Meldungen.Rows(Anzahlzeile - 1).Cells(2).Value
            FTrend.ZeitExtern = True
            VisiWinNET.Forms.ProjectForms.Hide("FProtokoll")
            VisiWinNET.Forms.ProjectForms.Show("FTrend")
        Else
            FMessageBox.Show("Keine Charge ausgewählt oder ungültiger Zeitraum", "Trendanzeige")
        End If
       
    End Sub


    Private Sub sisProtokollierung_BitChange(ByVal sender As Object, ByVal e As VisiWinNET.DataAccess.BitChangeEventArgs) Handles sisProtokollierung.BitChange
        Select Case e.BitNumber
            Case 8 'Programm Start
                If e.BitValue = True Then 'Protokolldatei kopieren
                    Call Chargen_erzeugen()
                    VWSetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 8, 0) 'Protokollbit rücksetzen
                End If
            Case 9 'Programm Neustart
                If e.BitValue = True Then
                    Call Chargen_Meldungen("Prozess", "Meldung", "Charge Neustart !")
                    VWSetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 9, 0) 'Protokollbit rücksetzen
                End If
            Case 10 'Programm Stop
                If e.BitValue = True Then
                    Call Chargen_Meldungen("Prozess", "Meldung", "Charge Stop !")
                    VWSetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 10, 0) 'Protokollbit rücksetzen
                End If
            Case 11 'Programm Reset
                If e.BitValue = True Then
                    Call Chargen_Meldungen("Prozess", "Meldung", "Charge Abbruch !")
                    VWSetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 11, 0) 'Protokollbit rücksetzen
                End If
            Case 12 'Programm Ende
                If e.BitValue = True Then
                    Call Chargen_Meldungen("Prozess", "Meldung", "Charge Ende !")
                    VWSetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 12, 0) 'Protokollbit rücksetzen
                End If
        End Select
    End Sub
#End Region

#Region " Private Methoden "

    Private Sub Kopfdaten_lesen()
        If lblCharge.Text = "" Then 'Abbruch wenn keine Eintrag vorhanden
            Exit Sub
        End If

        Dim Zeile = ReadDataForProtokol(lblCharge.Text, "Kopfdaten").Tables("Kopfdaten").Rows.Item(0)
        With Zeile
            lblArtikel.Text = .Item("Artikel")
            lblLaenge.Text = CStr(.Item("Laenge"))
            lblProtokoll_Benutzer.Text = .Item("Bediener")
        End With
    End Sub

    Private Sub Rezept_lesen()

        If lblCharge.Text = "" Then 'Abbruch wenn keine Eintrag vorhanden
            Exit Sub
        End If
        Try
            Dim Zeile = ReadDataForProtokol(lblCharge.Text, "Rezept").Tables("Rezept").Rows.Item(0)
            With Zeile
                lblRezept_Name.Text = .Item("Rezept")
                lblRezept_Beschreibung.Text = .Item("RezeptBeschreibung")
                lblAbschnitt01_Temperatur.Text = .Item("Temperatur_01")
                lblAbschnitt01_Zeit_Std.Text = .Item("Zeit_Std_01")
                lblAbschnitt01_Zeit_Min.Text = .Item("Zeit_Min_01")
                lblAbschnitt01_Zeit_Sek.Text = .Item("Zeit_Sek_01")
                lblAbschnitt02_Temperatur.Text = .Item("Temperatur_02")
                lblAbschnitt02_Zeit_Std.Text = .Item("Zeit_Std_02")
                lblAbschnitt02_Zeit_Min.Text = .Item("Zeit_Min_02")
                lblAbschnitt02_Zeit_Sek.Text = .Item("Zeit_Sek_02")
                lblAbschnitt03_Temperatur.Text = .Item("Temperatur_03")
                lblAbschnitt03_Zeit_Std.Text = .Item("Zeit_Std_03")
                lblAbschnitt03_Zeit_Min.Text = .Item("Zeit_Min_03")
                lblAbschnitt03_Zeit_Sek.Text = .Item("Zeit_Sek_03")
                lblAbschnitt04_Temperatur.Text = .Item("Temperatur_04")
                lblAbschnitt04_Zeit_Std.Text = .Item("Zeit_Std_04")
                lblAbschnitt04_Zeit_Min.Text = .Item("Zeit_Min_04")
                lblAbschnitt04_Zeit_Sek.Text = .Item("Zeit_Sek_04")
                lblAbschnitt05_Temperatur.Text = .Item("Temperatur_05")
                lblAbschnitt05_Zeit_Std.Text = .Item("Zeit_Std_05")
                lblAbschnitt05_Zeit_Min.Text = .Item("Zeit_Min_05")
                lblAbschnitt05_Zeit_Sek.Text = .Item("Zeit_Sek_05")
                lblAbschnitt06_Temperatur.Text = .Item("Temperatur_06")
                lblAbschnitt06_Zeit_Std.Text = .Item("Zeit_Std_06")
                lblAbschnitt06_Zeit_Min.Text = .Item("Zeit_Min_06")
                lblAbschnitt06_Zeit_Sek.Text = .Item("Zeit_Sek_06")
                lblAbschnitt07_Temperatur.Text = .Item("Temperatur_07")
                lblAbschnitt07_Zeit_Std.Text = .Item("Zeit_Std_07")
                lblAbschnitt07_Zeit_Min.Text = .Item("Zeit_Min_07")
                lblAbschnitt07_Zeit_Sek.Text = .Item("Zeit_Sek_07")
                lblAbschnitt08_Temperatur.Text = .Item("Temperatur_08")
                lblAbschnitt08_Zeit_Std.Text = .Item("Zeit_Std_08")
                lblAbschnitt08_Zeit_Min.Text = .Item("Zeit_Min_08")
                lblAbschnitt08_Zeit_Sek.Text = .Item("Zeit_Sek_09")
                lblAbschnitt09_Temperatur.Text = .Item("Temperatur_09")
                lblAbschnitt09_Zeit_Std.Text = .Item("Zeit_Std_09")
                lblAbschnitt09_Zeit_Min.Text = .Item("Zeit_Min_09")
                lblAbschnitt09_Zeit_Sek.Text = .Item("Zeit_Sek_09")
                lblAbschnitt10_Temperatur.Text = .Item("Temperatur_10")
                lblAbschnitt10_Zeit_Std.Text = .Item("Zeit_Std_10")
                lblAbschnitt10_Zeit_Min.Text = .Item("Zeit_Min_10")
                lblAbschnitt10_Zeit_Sek.Text = .Item("Zeit_Sek_10")
                lblAbschnitt_Ende_Temperatur.Text = .Item("Temperatur_Ende")
                lblRegelabweichung.Text = .Item("Regelabweichung")
                lblDuesenkanal.Text = .Item("Duesenkanal")
                lblBelueftung.Text = .Item("Belueftung")
            End With
        Catch ex As Exception
            Fehler_write_to_DB(ex.ToString)
        End Try
       


    End Sub

    Private Sub Prozess_Meldungen_anzeigen()

        If lblCharge.Text = "" Then 'Abbruch wenn keine Eintrag vorhanden
            Exit Sub
        End If
        Try
            dgvProzess_Meldungen.DataSource = ReadDataForProtokol(lblCharge.Text, "Prozess").Tables("Prozess")
            'Nicht benötigte Spalten ausblenden
            dgvProzess_Meldungen.Columns("ID").Visible = False
            dgvProzess_Meldungen.Columns("Kennung").Visible = False
            'Spaltenüberschrift bestimmen
            dgvProzess_Meldungen.Columns("DatumZeit").HeaderText = "Datum/Uhrzeit"
            dgvProzess_Meldungen.Columns("Meldetext").HeaderText = "Meldetext"
            'Spalteneingenschaften einstellen
            dgvProzess_Meldungen.Columns("DatumZeit").DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss"
            dgvProzess_Meldungen.Columns("DatumZeit").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvProzess_Meldungen.Columns("Meldetext").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProzess_Meldungen.Columns("DatumZeit").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvProzess_Meldungen.Columns("Meldetext").SortMode = DataGridViewColumnSortMode.NotSortable
        Catch ex As Exception
            Fehler_write_to_DB(ex.ToString)
        End Try
       

    End Sub

    Private Sub Stoer_Meldungen_anzeigen()

        If lblCharge.Text = "" Then 'Abbruch wenn keine Eintrag vorhanden
            Exit Sub
        End If

        Try
            dgvStoer_Meldungen.DataSource = ReadDataForProtokol(lblCharge.Text, "Stoerungen").Tables("Stoerungen")
            'Nicht benötigte Spalten ausblenden
            dgvStoer_Meldungen.Columns("ID").Visible = False
            'Spaltenüberschrift bestimmen
            dgvStoer_Meldungen.Columns("DatumZeit").HeaderText = "Datum/Uhrzeit"
            dgvStoer_Meldungen.Columns("Kennung").HeaderText = "Kennung"
            dgvStoer_Meldungen.Columns("Meldetext").HeaderText = "Meldetext"
            'Spalteneingenschaften einstellen
            dgvStoer_Meldungen.Columns("DatumZeit").DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss"
            dgvStoer_Meldungen.Columns("DatumZeit").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvStoer_Meldungen.Columns("Kennung").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvStoer_Meldungen.Columns("Meldetext").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvStoer_Meldungen.Columns("DatumZeit").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvStoer_Meldungen.Columns("Kennung").SortMode = DataGridViewColumnSortMode.NotSortable
            dgvStoer_Meldungen.Columns("Meldetext").SortMode = DataGridViewColumnSortMode.NotSortable
        Catch ex As Exception
            Fehler_write_to_DB(ex.ToString)
        End Try
        

    End Sub

    Private Sub Endbewertung_lesen()

        If lblCharge.Text = "" Then 'Abbruch wenn keine Eintrag vorhanden
            Exit Sub
        End If
        Try
            If ReadDataForProtokol(lblCharge.Text, "Bewertung").Tables("Bewertung").Rows.Count <> 0 Then
                Dim Zeile = ReadDataForProtokol(lblCharge.Text, "Bewertung").Tables("Bewertung").Rows.Item(0)
                With Zeile
                    lblEndbewertung_Datum_Zeit.Text = CheckNull(.Item("DatumZeit"))
                    lblEndbewertung_Benutzer.Text = CheckNull(.Item("Bediener"))
                    VWSet("Protokoll.Endbewertung1", CheckNull(.Item("Kommentar1")))
                    VWSet("Protokoll.Endbewertung2", CheckNull(.Item("Kommentar2")))
                    VWSet("Protokoll.Endbewertung3", CheckNull(.Item("Kommentar3")))
                End With
            Else
                lblEndbewertung_Datum_Zeit.Text = ""
                lblEndbewertung_Benutzer.Text = ""
                VWSet("Protokoll.Endbewertung1", "")
                VWSet("Protokoll.Endbewertung2", "")
                VWSet("Protokoll.Endbewertung3", "")
            End If
        Catch ex As Exception
            Fehler_write_to_DB(ex.ToString)
        End Try
        

    End Sub


    Private Sub Chargen_erzeugen()
        Dim Zaehler As Integer
        Dim Chargennummer As String
        Dim Chargenindex As String

        For Zaehler = 1 To 5
            Chargennummer = VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler) & ".Chargennummer")
            If Chargennummer <> "" Then
                Chargenindex = CStr(VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler) & ".Chargenindex"))
                
                Call Kopfdaten_schreiben(Chargennummer, Chargenindex, Zaehler)
                Call Rezept_schreiben(Chargennummer, Chargenindex)
                Call Meldung_eintragen("Prozess", Chargennummer, Chargenindex, "Meldung", "Charge Start !")
                'VWSetBit("SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC", 12, 1) 'Programm abbrechen
            End If
        Next
    End Sub

   

    

    Private Sub Chargen_Meldungen(ByVal Tabelle As String, ByVal Kennung As String, ByVal Meldetext As String) 'Chargen prüfen und Meldung eintragen
        Dim Zaehler As Integer
        Dim Chargennummer As String
        Dim Chargenindex As String

        For Zaehler = 1 To 5
            Chargennummer = VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler) & ".Chargennummer")
            If Chargennummer <> "" Then
                Chargenindex = CStr(VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler) & ".Chargenindex"))
                Call Meldung_eintragen(Tabelle, Chargennummer, Chargenindex, Kennung, Meldetext)
            End If
        Next
    End Sub

    

    Private Sub Endbewertung_schreiben(ByVal Chargennummer As String)

        If lblCharge.Text = "" Then 'Abbruch wenn keine Eintrag vorhanden
            FMessageBox.Show("Bewertung kann nicht gespeichert werden ! Es ist kein Protokoll ausgewählt", "Fehler Bewertung speichern !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim ds = ReadDataForProtokol(lblCharge.Text, "Bewertung")
        Dim Zeile
        If ds.Tables("Bewertung").Rows.Count <> 0 Then

            Zeile = ds.Tables("Bewertung").Rows.Item(0)
        Else
            Zeile = ds.Tables("Bewertung").NewRow()
        End If
        With Zeile
            .Item("Charge") = Chargennummer
            .Item("DatumZeit") = Now.ToString
            .Item("Bediener") = String_leer(VWGet("__CURRENT_USER.FULLNAME"))
            .Item("Kommentar1") = String_leer(VWGet("Protokoll.Endbewertung1"))
            .Item("Kommentar2") = String_leer(VWGet("Protokoll.Endbewertung2"))
            .Item("Kommentar3") = String_leer(VWGet("Protokoll.Endbewertung3"))
        End With
        ds.Tables("Bewertung").Rows.Add(Zeile)
        WriteDataForProtokol(lblCharge.Text, "Bewertung", ds)
    End Sub

    

#End Region

   
<<<<<<< HEAD
    Private Sub CommandButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

=======
    Private Sub CommandButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandButton1.Click
        fdsgfasdjk gf f asdf asdf asd
>>>>>>> refs/remotes/origin/2016_02_04_IuMi
        'LoadChargeFromBD()
        Call Chargen_erzeugen()
        'Record_Exist("160205000000")
        'Call Kopfdaten_schreiben(1, 2, 3)
        ' Call Rezept_schreiben(1, 2)
        'Call Meldung_eintragen("Prozess", 1, 2, "Meldung", "Charge Start !")
        Chargen_Meldungen("Prozess", "Meldung", "Charge Neustart !")
        Chargen_Meldungen("Prozess", "Meldung", "Charge Stop !")
        Chargen_Meldungen("Prozess", "Meldung", "Charge Abbruch !")
        Chargen_Meldungen("Prozess", "Meldung", "Charge Ende !")
    End Sub
End Class
