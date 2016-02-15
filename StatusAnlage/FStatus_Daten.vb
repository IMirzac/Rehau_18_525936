Imports System.Environment
Imports VisiWinNET.Services.AppService

Public Class FStatus_Daten

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen
        mRecipeClass = VisiWinNET.Recipe.RecipeManager.Classes("Rezepte")

    End Sub

#Region " Deklarationen "

    Private WithEvents mRecipeClass As VisiWinNET.Recipe.RecipeClass
    Private vinChargennummer(5) As VisiWinNET.Forms.VarIn

#End Region

#Region " Initialisierung "

    Private Sub FStatus_Daten_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VWSet("SPS Ofen.Kopplung.Bildnummer", 2000)
        Call Objekt_Freigabe()
    End Sub

#End Region

#Region " Ereignisse "

    Private Sub cmdRezept_laden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRezept_laden.Click
        'Rezept laden

        VWSet("Rezept.Werte_in_SPS_schreiben", True)

        Dim Rezept_Name As String
        Dim Rezept_Beschreibung As String

        'Rezept laden
        Rezept_Name = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Name")
        Rezept_Beschreibung = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Beschreibung")

        FRecipeSelect.ShowLoadDialog(mRecipeClass.Name, Rezept_Name, Rezept_Beschreibung)
    End Sub

    Private Sub cmdProgramm_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProgramm_Start.Click
        Dim Zaehler As Integer
        Dim Chargennummer(4) As String
        Dim ChargenIndex(4) As String
        Dim MsgText As String
        Dim String_iO(4) As Boolean
        Dim File_iO(4) As Boolean
        Dim Chargen_leer As Boolean
        Dim Charge_doppelt As Boolean = False
        Dim Fehler As Boolean = False

        'Prüfen ob Startfreigabe i.O.
        If VWGetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 0) = False Then
            FMessageBox.Show("Keine Startfreigabe !", "Meldung Programm Start !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Werte lesen / initialisieren
        Chargen_leer = True
        MsgText = ""

        For Zaehler = 0 To 4
            Chargennummer(Zaehler) = VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler + 1) & ".Chargennummer")
            ChargenIndex(Zaehler) = CStr(VWGet("SPS Ofen.Status.Charge" & CStr(Zaehler + 1) & ".Chargenindex"))
        Next

        'Prüfen ob Zeichen gültig
        For Zaehler = 0 To 4
            If Chargennummer(Zaehler) <> "" Then 'Prüfen ob Eintrag vorhanden
                Chargen_leer = False 'Min. eine gültige Charge vorhanden
                String_iO(Zaehler) = String_Check(Chargennummer(Zaehler) & ChargenIndex(Zaehler))
                If String_iO(Zaehler) = True Then 'Prüfen ob String gültige Zeichen enthält
                    File_iO(Zaehler) = Not (Record_Exist(Chargennummer(Zaehler) & ChargenIndex(Zaehler)))
                    If File_iO(Zaehler) = False Then 'Prüfen ob Datei vorhanden
                        Fehler = True
                        Chargen_leer = False 'Min. eine gültige Charge vorhanden
                    End If
                Else
                    Fehler = True
                End If
            Else
                'Wenn Chargennummer leer dann wird keine Charge erzeugt deshalb IO für diese Eintäge
                String_iO(Zaehler) = True
                File_iO(Zaehler) = True
            End If
        Next Zaehler

        If Fehler = False Then
            If Chargennummer(0) <> Chargennummer(1) And Chargennummer(0) <> Chargennummer(2) And Chargennummer(0) <> Chargennummer(3) And Chargennummer(0) <> Chargennummer(4) Or Chargennummer(0) = "" Then
                If Chargennummer(1) <> Chargennummer(2) And Chargennummer(1) <> Chargennummer(3) And Chargennummer(1) <> Chargennummer(4) Or Chargennummer(1) = "" Then
                    If Chargennummer(2) <> Chargennummer(3) And Chargennummer(2) <> Chargennummer(4) Or Chargennummer(2) = "" Then
                        If Chargennummer(3) = Chargennummer(4) And Chargennummer(3) <> "" And Chargennummer(4) <> "" Then
                            Charge_doppelt = True
                            Fehler = True
                        End If
                    Else
                        Charge_doppelt = True
                        Fehler = True
                    End If
                Else
                    Charge_doppelt = True
                    Fehler = True
                End If
            Else
                Charge_doppelt = True
                Fehler = True
            End If
        End If

        'Auswertungen anzeigen
        If Fehler = False And Chargen_leer = False Then
            'Programm Start
            VWSetBit("SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC", 8, True)
        Else
            If Charge_doppelt = False Then
                If Chargen_leer = False Then 'Chargen leer ?
                    For Zaehler = 0 To 4
                        If String_iO(Zaehler) = False Then 'Zeichen gültig ?
                            MsgText = MsgText & "Charge " & CStr(Zaehler + 1) & " enthält ungültige Zeichen !"
                            If Zaehler <> 4 Then
                                MsgText = MsgText & NewLine
                            End If
                        Else
                            If File_iO(Zaehler) = False Then 'Datei vorhanden ?
                                MsgText = MsgText & "Charge " & CStr(Zaehler + 1) & " existriert bereits !"
                                If Zaehler <> 4 Then
                                    MsgText = MsgText & NewLine
                                End If
                            End If
                        End If
                    Next
                    FMessageBox.Show(MsgText, "Fehler Programm Start !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FMessageBox.Show("  Charge 1 leer !    " & NewLine & "  Charge 2 leer !    " & NewLine & "  Charge 3 leer !    " & NewLine & "  Charge 4 leer !    " & NewLine & "  Charge 5 leer !    ", "Fehler Programm Start !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                FMessageBox.Show("Charge doppelt vergeben !", "Fehler Programm Start !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub isvProgramm_Status_Change(ByVal sender As System.Object, ByVal e As VisiWinNET.DataAccess.ChangeEventArgs) Handles isvProgramm_Status.Change
        Call Objekt_Freigabe()
    End Sub

#End Region

#Region " Private Methoden "

    Private Sub Objekt_Freigabe()
        Dim Programm_Status As Integer = VWGet("SPS Ofen.Arbeit_PC.Programm_Status")

        'Programm Tasten freigeben / sperren
        Select Case Programm_Status
            Case 0
                cmdProgramm_Start.Enabled = True
                keyProgramm_Stop.Enabled = False
                keyProgramm_Neustart.Enabled = False
                keyProgramm_Ende.Enabled = False
            Case 1
                cmdProgramm_Start.Enabled = False
                keyProgramm_Stop.Enabled = True
                keyProgramm_Neustart.Enabled = False
                keyProgramm_Ende.Enabled = True
            Case 2
                cmdProgramm_Start.Enabled = False
                keyProgramm_Stop.Enabled = False
                keyProgramm_Neustart.Enabled = True
                keyProgramm_Ende.Enabled = True
        End Select

        ' Rezept laden und Eingabe Chargen freigeben / sperren
        If Programm_Status = 0 Then
            cmdRezept_laden.Enabled = True
            vinCharge1_Chargennummer.Enabled = True
            vinCharge1_Chargenindex.Enabled = True
            vinCharge1_Artikel.Enabled = True
            vinCharge1_Laenge.Enabled = True
            vinCharge2_Chargennummer.Enabled = True
            vinCharge2_Chargenindex.Enabled = True
            vinCharge2_Artikel.Enabled = True
            vinCharge2_Laenge.Enabled = True
            vinCharge3_Chargennummer.Enabled = True
            vinCharge3_Chargenindex.Enabled = True
            vinCharge3_Artikel.Enabled = True
            vinCharge3_Laenge.Enabled = True
            vinCharge4_Chargennummer.Enabled = True
            vinCharge4_Chargenindex.Enabled = True
            vinCharge4_Artikel.Enabled = True
            vinCharge4_Laenge.Enabled = True
            vinCharge5_Chargennummer.Enabled = True
            vinCharge5_Chargenindex.Enabled = True
            vinCharge5_Artikel.Enabled = True
            vinCharge5_Laenge.Enabled = True
        Else
            cmdRezept_laden.Enabled = False
            vinCharge1_Chargennummer.Enabled = False
            vinCharge1_Chargenindex.Enabled = False
            vinCharge1_Artikel.Enabled = False
            vinCharge1_Laenge.Enabled = False
            vinCharge2_Chargennummer.Enabled = False
            vinCharge2_Chargenindex.Enabled = False
            vinCharge2_Artikel.Enabled = False
            vinCharge2_Laenge.Enabled = False
            vinCharge3_Chargennummer.Enabled = False
            vinCharge3_Chargenindex.Enabled = False
            vinCharge3_Artikel.Enabled = False
            vinCharge3_Laenge.Enabled = False
            vinCharge4_Chargennummer.Enabled = False
            vinCharge4_Chargenindex.Enabled = False
            vinCharge4_Artikel.Enabled = False
            vinCharge4_Laenge.Enabled = False
            vinCharge5_Chargennummer.Enabled = False
            vinCharge5_Chargenindex.Enabled = False
            vinCharge5_Artikel.Enabled = False
            vinCharge5_Laenge.Enabled = False
        End If
        Me.Update()
    End Sub

#End Region

    Private Sub CommandButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VWSetBit("SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung", 0, True)
    End Sub
End Class
