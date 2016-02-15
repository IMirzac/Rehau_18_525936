Imports System.IO
Imports System.Data.OleDb

Module MPublic_Methods
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Protokoll_Pfad)

    Public Function String_leer(ByVal text As String) As String
        If text.Length = 0 Then
            String_leer = " "
        Else
            String_leer = text
        End If

    End Function

    Public Function String_Check(ByVal text As String) As Boolean
        'Prüfen ob in einem String nur gültige Zeichen vorhanden sind
        Dim Zaehler As Integer
        Dim IO_Zeichen As String = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRTSUVW"

        For Zaehler = 1 To text.Length
            ' test = text.ToCharArray(Zaehler, 1)
            If IO_Zeichen.IndexOf(text.Chars(Zaehler - 1)) = -1 Then
                String_Check = False
                Exit Function
            End If
        Next Zaehler
        String_Check = True
    End Function

    Public Sub Bild_zurueck()
        Dim Bildname As String
        If Bildname_aktuell <> Nothing And Bildname_alt <> Nothing Then
            Bildname = Bildname_aktuell
            VisiWinNET.Forms.ProjectForms.Show(Bildname_alt)
            VisiWinNET.Forms.ProjectForms.Hide(Bildname)
        End If
    End Sub

    Public Function Record_Exist(ByVal charge As String) As Boolean
        'Prüfen ob Datei in Pfad "Path" mit dem Namen "File" (mit Endung) wvorhanden ist
        Dim ds As New DataSet()
        conn.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM Kopfdaten WHERE Charge = '" + charge + "';", conn)
        Dim cb As New OleDbCommandBuilder(da)
        da.Fill(ds, "Kopfdaten")
        conn.Close()

        If ds.Tables("Kopfdaten").Rows.Count = 0 Then
            Record_Exist = False
            Exit Function
        End If
        Record_Exist = True
    End Function

#Region "DB - Functions "
    'Load Charges query
    Public Function ReadChargesForRecipeSelect() As DataSet

        Dim ds As New DataSet()
        conn.Open()
        Dim da As New OleDbDataAdapter("SELECT Charge, DatumZeit FROM Kopfdaten;", conn)
        Dim cb As New OleDbCommandBuilder(da)
        da.Fill(ds, "Kopfdaten")
        conn.Close()

        ReadChargesForRecipeSelect = ds
    End Function

    Public Function ReadDataForProtokol(ByVal charge As String, ByVal table As String) As DataSet

        Dim ds As New DataSet()
        conn.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM " + table + " Where Charge = '" + charge + "';", conn)
        Dim cb As New OleDbCommandBuilder(da)
        da.Fill(ds, table)
        conn.Close()
        ReadDataForProtokol = ds

    End Function

    Public Sub WriteDataForProtokol(ByVal charge As String, ByVal table As String, ByVal Updatetable As DataSet)

        conn.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM " + table + " Where Charge = '" + charge + "';", conn)
        Dim cb As New OleDbCommandBuilder(da)

        da.Update(Updatetable, table)
        conn.Close()

    End Sub

    Public Function LoadChargeFromBD() As String

        Dim sql As String = "SELECT * FROM Ini "
        'Update Ini table / Generating Charge number
        Dim Charge_to_Load As String = ""
        Dim Last_Index As String = ""
        LoadChargeFromBD = ""

        '1 - last date as string
        '2 - index
        '3 - charge
        Dim ds As New DataSet
        conn.Open()
        Dim AccessCommand As New OleDbCommand(sql, conn)
        Dim da As New OleDbDataAdapter(AccessCommand)
        Dim cb As New OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        da.Fill(ds, "Ini")

        If DateTime.Parse(ds.Tables("Ini").Rows(0)("LastDate")) < DateTime.Now.Date Then
            Dim Last_Year As String = DateTime.Now.Year.ToString
            Last_Year = DateTime.Now.Year.ToString.Substring(2)

            Dim Last_Month As String = CorectingValues(DateTime.Now.Month, 1)
            Dim Last_Day As String = CorectingValues(DateTime.Now.Day, 1)
            Last_Index = CorectingValues(1, 2)

            Charge_to_Load = Last_Year + Last_Month + Last_Day + Last_Index
        ElseIf DateTime.Parse(ds.Tables("Ini").Rows(0)("LastDate")).Year > DateTime.Now.Date.Year And DateTime.Parse(ds.Tables("Ini").Rows(0)("LastDate")).Month > DateTime.Now.Date.Month And DateTime.Parse(ds.Tables("Ini").Rows(0)("LastDate")).Day > DateTime.Now.Date.Day Then


            FMessageBox.Show("Check Date and Time of the PC. ", "Fehler !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Charge_to_Load = (Integer.Parse(DateTime.Now.Year.ToString.Substring(2) + CorectingValues(DateTime.Now.Month, 1) + CorectingValues(DateTime.Now.Day, 1) + CorectingValues(ds.Tables("Ini").Rows(0)("Index"), 2)) + 1).ToString
            Last_Index = (Integer.Parse(CorectingValues(ds.Tables("Ini").Rows(0)("Index"), 2)) + 1).ToString
        End If


        ds.Tables("Ini").Rows(0).Item("LastDate") = Now.ToString("dd.MM.yyyy HH:mm:ss")
        ds.Tables("Ini").Rows(0).Item("Index") = Last_Index
        ds.Tables("Ini").Rows(0).Item("Charge") = Charge_to_Load
        da.Update(ds, "Ini")

        LoadChargeFromBD = Charge_to_Load
        conn.Close()
    End Function

    Function CorectingValues(ByVal value As Integer, ByVal param As Integer) As String
        'param - 1 - Date corecting
        'param - 2 - index corecting

        Dim retrunValue = value.ToString()
        If param = 1 Then
            For index As Integer = 1 To 2 - value.ToString.Length
                retrunValue = "0" + retrunValue
            Next
            Return retrunValue
        ElseIf param = 2 Then
            For index As Integer = 1 To 4 - value.ToString.Length
                retrunValue = "0" + retrunValue
            Next
            Return retrunValue
        Else : Return retrunValue
        End If

    End Function

    Public Function Datenbank_Eintrag(ByVal sql As String) As Boolean
        Dim cmd As New OleDbCommand(sql, conn)
        Datenbank_Eintrag = True
        Try
            conn.Open()
            'SQL-Befehl wird gegen die Datenbank gefahren:
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Fehler_write_to_DB(ex.ToString)
            Datenbank_Eintrag = False
        End Try
        conn.Close()
    End Function

    Public Sub Kopfdaten_schreiben(ByVal Chargennummer As String, ByVal Chargenindex As String, ByVal Zaehler As Integer)
        Dim Rezept As String = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Rezept_Name")
        Dim Artikel As String = String_leer(VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler) & ".Artikel"))
        Dim Laenge As Integer = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler) & ".Laenge")
        Dim Bediener As String = String_leer(VisiWinNET.Services.AppService.VWGet("__CURRENT_USER.FULLNAME"))
        Dim sql As String = "INSERT INTO Kopfdaten (DatumZeit, Charge, Artikel, Laenge, Bediener) VALUES ('" & Now & "', '" & Chargennummer & Chargenindex & "', '" & Artikel & "', '" & Laenge & "', '" & Bediener & "')"
        Call Datenbank_Eintrag(sql)
    End Sub

    Public Sub Rezept_schreiben(ByVal Chargennummer As String, ByVal Chargenindex As String)

        Dim ds As New DataSet()
        Dim Zeile As DataRow
        Dim Zaehler As Integer

        conn.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM Rezept", conn)
        Dim cb As New OleDbCommandBuilder(da)

        da.Fill(ds, "Rezept")
        Zeile = ds.Tables("Rezept").NewRow()
        With Zeile
            .Item("DatumZeit") = Now
            .Item("Rezept") = String_leer(CStr(VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Rezept_Name")))
            .Item("RezeptBeschreibung") = String_leer(CStr(VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Rezept_Beschreibung")))
            .Item("Charge") = Chargennummer + Chargenindex
            For Zaehler = 1 To 10
                .Item("Temperatur_" & Zaehler.ToString("00")) = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Abschnitt" & Zaehler.ToString("00") & ".Temperatur")
                .Item("Zeit_Std_" & Zaehler.ToString("00")) = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Abschnitt" & Zaehler.ToString("00") & ".Zeit_Std")
                .Item("Zeit_Min_" & Zaehler.ToString("00")) = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Abschnitt" & Zaehler.ToString("00") & ".Zeit_Min")
                .Item("Zeit_Sek_" & Zaehler.ToString("00")) = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Abschnitt" & Zaehler.ToString("00") & ".Zeit_Sek")
            Next
            .Item("Temperatur_Ende") = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.AbschnittEnde.Temperatur")
            .Item("Regelabweichung") = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Regelabweichung")
            If VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.VW_Belueftung") = 1 Then
                .Item("Belueftung") = "ein"
            Else
                .Item("Belueftung") = "aus"
            End If
            If VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.VW_Duesenkanal") = 1 Then
                .Item("Duesenkanal") = "ein"
            Else
                .Item("Duesenkanal") = "aus"
            End If
        End With
        ds.Tables("Rezept").Rows.Add(Zeile)
        da.Update(ds, "Rezept")
        conn.Close()
    End Sub

    Public Sub Meldung_eintragen(ByVal Tabelle As String, ByVal Chargennummer As String, ByVal Chargenindex As String, ByVal Kennung As String, ByVal Meldetext As String)
        Dim sql As String = "INSERT INTO " & Tabelle & " (Charge, DatumZeit, Kennung, Meldetext) VALUES ('" + Chargennummer + Chargenindex + "', '" & Now & " ', '" & Kennung & "','" & Meldetext & "')"
        Call Datenbank_Eintrag(sql)
    End Sub

    Public Sub Fehler_write_to_DB(ByVal fehler As String)
        FMessageBox.Show(fehler, "Fehler Datenbank !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim Sql As String = "INSERT INTO Meld ( DateX, Message) VALUES ('" & Now.ToString("dd.MM.yyyy HH:mm:ss") & "','" & fehler.Replace("'", "*") + " " & "')"
        If Datenbank_Eintrag(Sql) = False Then
            Exit Sub
        End If
    End Sub

    Public Function CheckNull(ByVal Obj As Object) As String

        If IsDBNull(Obj) Then
            Try
                CheckNull = Obj
            Catch ex As Exception
                Fehler_write_to_DB(ex.ToString)
            End Try
            CheckNull = ""
        Else
            CheckNull = Obj
        End If
    End Function
#End Region
End Module
