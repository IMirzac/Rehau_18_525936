<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProtokoll
    Inherits HMI.FVorlage_Kopf_Fuss_Stoerzeile
    Public WithEvents New_Alarm As VisiWinNET.Alarm.CurrentAlarms = New VisiWinNET.Alarm.CurrentAlarms()

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
            New_Alarm.Dispose()
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.Label1 = New VisiWinNET.Forms.Label
        Me.sisProtokollierung = New VisiWinNET.Forms.StateItemServer(Me.components)
        Me.Label2 = New VisiWinNET.Forms.Label
        Me.Label3 = New VisiWinNET.Forms.Label
        Me.lblArtikel = New VisiWinNET.Forms.Label
        Me.lblLaenge = New VisiWinNET.Forms.Label
        Me.Label5 = New VisiWinNET.Forms.Label
        Me.Label6 = New VisiWinNET.Forms.Label
        Me.Label7 = New VisiWinNET.Forms.Label
        Me.Label8 = New VisiWinNET.Forms.Label
        Me.Label9 = New VisiWinNET.Forms.Label
        Me.Label10 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt01_Zeit_Std = New VisiWinNET.Forms.Label
        Me.lblAbschnitt01_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt01_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.Label20 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt01_Temperatur = New VisiWinNET.Forms.Label
        Me.Label14 = New VisiWinNET.Forms.Label
        Me.Label134 = New VisiWinNET.Forms.Label
        Me.Label137 = New VisiWinNET.Forms.Label
        Me.Label136 = New VisiWinNET.Forms.Label
        Me.Label24 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt02_Temperatur = New VisiWinNET.Forms.Label
        Me.Label26 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt02_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt02_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt02_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label30 = New VisiWinNET.Forms.Label
        Me.Label31 = New VisiWinNET.Forms.Label
        Me.Label32 = New VisiWinNET.Forms.Label
        Me.Label33 = New VisiWinNET.Forms.Label
        Me.Label34 = New VisiWinNET.Forms.Label
        Me.Label35 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt03_Temperatur = New VisiWinNET.Forms.Label
        Me.Label37 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt03_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt03_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt03_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label41 = New VisiWinNET.Forms.Label
        Me.Label42 = New VisiWinNET.Forms.Label
        Me.Label43 = New VisiWinNET.Forms.Label
        Me.Label44 = New VisiWinNET.Forms.Label
        Me.Label45 = New VisiWinNET.Forms.Label
        Me.Label46 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt04_Temperatur = New VisiWinNET.Forms.Label
        Me.Label48 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt04_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt04_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt04_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label52 = New VisiWinNET.Forms.Label
        Me.Label53 = New VisiWinNET.Forms.Label
        Me.Label54 = New VisiWinNET.Forms.Label
        Me.Label55 = New VisiWinNET.Forms.Label
        Me.Label56 = New VisiWinNET.Forms.Label
        Me.Label57 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt05_Temperatur = New VisiWinNET.Forms.Label
        Me.Label59 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt05_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt05_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt05_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label63 = New VisiWinNET.Forms.Label
        Me.Label64 = New VisiWinNET.Forms.Label
        Me.Label65 = New VisiWinNET.Forms.Label
        Me.Label66 = New VisiWinNET.Forms.Label
        Me.Label67 = New VisiWinNET.Forms.Label
        Me.Label68 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt06_Temperatur = New VisiWinNET.Forms.Label
        Me.Label70 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt06_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt06_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt06_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label74 = New VisiWinNET.Forms.Label
        Me.Label75 = New VisiWinNET.Forms.Label
        Me.Label76 = New VisiWinNET.Forms.Label
        Me.Label77 = New VisiWinNET.Forms.Label
        Me.Label78 = New VisiWinNET.Forms.Label
        Me.Label79 = New VisiWinNET.Forms.Label
        Me.lblRegelabweichung = New VisiWinNET.Forms.Label
        Me.Label81 = New VisiWinNET.Forms.Label
        Me.Label87 = New VisiWinNET.Forms.Label
        Me.Label88 = New VisiWinNET.Forms.Label
        Me.Label89 = New VisiWinNET.Forms.Label
        Me.Label101 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt10_Temperatur = New VisiWinNET.Forms.Label
        Me.Label103 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt10_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt10_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt10_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label107 = New VisiWinNET.Forms.Label
        Me.Label108 = New VisiWinNET.Forms.Label
        Me.Label109 = New VisiWinNET.Forms.Label
        Me.Label110 = New VisiWinNET.Forms.Label
        Me.Label111 = New VisiWinNET.Forms.Label
        Me.Label112 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt09_Temperatur = New VisiWinNET.Forms.Label
        Me.Label114 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt09_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt09_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt09_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label118 = New VisiWinNET.Forms.Label
        Me.Label119 = New VisiWinNET.Forms.Label
        Me.Label120 = New VisiWinNET.Forms.Label
        Me.Label121 = New VisiWinNET.Forms.Label
        Me.Label122 = New VisiWinNET.Forms.Label
        Me.Label123 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt08_Temperatur = New VisiWinNET.Forms.Label
        Me.Label125 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt08_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt08_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt08_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label129 = New VisiWinNET.Forms.Label
        Me.Label130 = New VisiWinNET.Forms.Label
        Me.Label131 = New VisiWinNET.Forms.Label
        Me.Label132 = New VisiWinNET.Forms.Label
        Me.Label133 = New VisiWinNET.Forms.Label
        Me.Label135 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt07_Temperatur = New VisiWinNET.Forms.Label
        Me.Label139 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt07_Zeit_Sek = New VisiWinNET.Forms.Label
        Me.lblAbschnitt07_Zeit_Min = New VisiWinNET.Forms.Label
        Me.lblAbschnitt07_Zeit_Std = New VisiWinNET.Forms.Label
        Me.Label143 = New VisiWinNET.Forms.Label
        Me.Label144 = New VisiWinNET.Forms.Label
        Me.Label145 = New VisiWinNET.Forms.Label
        Me.Label146 = New VisiWinNET.Forms.Label
        Me.Label147 = New VisiWinNET.Forms.Label
        Me.Label11 = New VisiWinNET.Forms.Label
        Me.lblRezept_Name = New VisiWinNET.Forms.Label
        Me.lblRezept_Beschreibung = New VisiWinNET.Forms.Label
        Me.lblProtokoll_Benutzer = New VisiWinNET.Forms.Label
        Me.Label15 = New VisiWinNET.Forms.Label
        Me.Label13 = New VisiWinNET.Forms.Label
        Me.Label16 = New VisiWinNET.Forms.Label
        Me.lblDuesenkanal = New VisiWinNET.Forms.Label
        Me.lblBelueftung = New VisiWinNET.Forms.Label
        Me.dgvProzess_Meldungen = New System.Windows.Forms.DataGridView
        Me.Label17 = New VisiWinNET.Forms.Label
        Me.Label4 = New VisiWinNET.Forms.Label
        Me.dgvStoer_Meldungen = New System.Windows.Forms.DataGridView
        Me.Label12 = New VisiWinNET.Forms.Label
        Me.lblEndbewertung_Datum_Zeit = New VisiWinNET.Forms.Label
        Me.vinEndbewertung1 = New VisiWinNET.Forms.VarIn
        Me.lblEndbewertung_Benutzer = New VisiWinNET.Forms.Label
        Me.Label19 = New VisiWinNET.Forms.Label
        Me.Label21 = New VisiWinNET.Forms.Label
        Me.Label22 = New VisiWinNET.Forms.Label
        Me.cmdEndbewertung_speichern = New VisiWinNET.Forms.CommandButton
        Me.vinEndbewertung2 = New VisiWinNET.Forms.VarIn
        Me.vinEndbewertung3 = New VisiWinNET.Forms.VarIn
        Me.cmdProtokoll_drucken = New VisiWinNET.Forms.CommandButton
        Me.prdProtokoll = New System.Windows.Forms.PrintDialog
        Me.Label92 = New VisiWinNET.Forms.Label
        Me.Label90 = New VisiWinNET.Forms.Label
        Me.lblAbschnitt_Ende_Temperatur = New VisiWinNET.Forms.Label
        Me.Label99 = New VisiWinNET.Forms.Label
        Me.Label100 = New VisiWinNET.Forms.Label
        Me.lblCharge = New VisiWinNET.Forms.Label
        Me.keyTrend = New VisiWinNET.Forms.Key
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sisProtokollierung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblArtikel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLaenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt01_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt01_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt01_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt01_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label137, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label136, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt02_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt02_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt02_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt02_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt03_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt03_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt03_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt03_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt04_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt04_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt04_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt04_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt05_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt05_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt05_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt05_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt06_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt06_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt06_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt06_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRegelabweichung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt10_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt10_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt10_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt10_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt09_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt09_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt09_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt09_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt08_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt08_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt08_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt08_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label135, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt07_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label139, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt07_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt07_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt07_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label143, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label144, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label145, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label146, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label147, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRezept_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRezept_Beschreibung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProtokoll_Benutzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDuesenkanal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBelueftung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProzess_Meldungen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStoer_Meldungen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEndbewertung_Datum_Zeit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinEndbewertung1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEndbewertung_Benutzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdEndbewertung_speichern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinEndbewertung2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinEndbewertung3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdProtokoll_drucken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt_Ende_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Protokoll"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'Label1
        '
        Me.Label1.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.LocalizedText.Text = "Charge:"
        Me.Label1.Location = New System.Drawing.Point(31, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 36)
        Me.Label1.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'sisProtokollierung
        '
        Me.sisProtokollierung.VWItem.BitEvents = True
        Me.sisProtokollierung.VWItem.Name = "SPS Ofen.Arbeit_PC.Statusbit_an_PC_Protokollierung"
        '
        'Label2
        '
        Me.Label2.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.LocalizedText.Text = "Artikel:"
        Me.Label2.Location = New System.Drawing.Point(31, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 27)
        Me.Label2.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.LocalizedText.Text = "Länge:"
        Me.Label3.Location = New System.Drawing.Point(363, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 27)
        Me.Label3.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblArtikel
        '
        Me.lblArtikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikel.Location = New System.Drawing.Point(149, 140)
        Me.lblArtikel.Name = "lblArtikel"
        Me.lblArtikel.Size = New System.Drawing.Size(208, 27)
        Me.lblArtikel.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblLaenge
        '
        Me.lblLaenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaenge.Location = New System.Drawing.Point(436, 140)
        Me.lblLaenge.Name = "lblLaenge"
        Me.lblLaenge.Size = New System.Drawing.Size(90, 27)
        Me.lblLaenge.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.LocalizedText.Text = "m"
        Me.Label5.Location = New System.Drawing.Point(532, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 27)
        Me.Label5.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.LocalizedText.Text = ":"
        Me.Label6.Location = New System.Drawing.Point(204, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 24)
        Me.Label6.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.LocalizedText.Text = ":"
        Me.Label7.Location = New System.Drawing.Point(168, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 24)
        Me.Label7.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.LocalizedText.Text = "Zeit:"
        Me.Label8.Location = New System.Drawing.Point(30, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.LocalizedText.Text = "Temperatur:"
        Me.Label9.Location = New System.Drawing.Point(30, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Yellow
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.LocalizedText.Text = "Abschnitt 01                  Soll"
        Me.Label10.Location = New System.Drawing.Point(30, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 20)
        Me.Label10.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblAbschnitt01_Zeit_Std
        '
        Me.lblAbschnitt01_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt01_Zeit_Std.Location = New System.Drawing.Point(140, 304)
        Me.lblAbschnitt01_Zeit_Std.Name = "lblAbschnitt01_Zeit_Std"
        Me.lblAbschnitt01_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt01_Zeit_Min
        '
        Me.lblAbschnitt01_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt01_Zeit_Min.Location = New System.Drawing.Point(176, 304)
        Me.lblAbschnitt01_Zeit_Min.Name = "lblAbschnitt01_Zeit_Min"
        Me.lblAbschnitt01_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt01_Zeit_Sek
        '
        Me.lblAbschnitt01_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt01_Zeit_Sek.Location = New System.Drawing.Point(212, 304)
        Me.lblAbschnitt01_Zeit_Sek.Name = "lblAbschnitt01_Zeit_Sek"
        Me.lblAbschnitt01_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(140, 281)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt01_Temperatur
        '
        Me.lblAbschnitt01_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt01_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt01_Temperatur.Location = New System.Drawing.Point(143, 284)
        Me.lblAbschnitt01_Temperatur.Name = "lblAbschnitt01_Temperatur"
        Me.lblAbschnitt01_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label14
        '
        Me.Label14.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.LocalizedText.Text = "°C"
        Me.Label14.Location = New System.Drawing.Point(213, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 16)
        '
        'Label134
        '
        Me.Label134.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(14, 92)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(997, 84)
        '
        'Label137
        '
        Me.Label137.BackColor = System.Drawing.SystemColors.Control
        Me.Label137.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label137.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label137.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label137.LocalizedText.Text = "Programm:"
        Me.Label137.Location = New System.Drawing.Point(38, 190)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(76, 23)
        Me.Label137.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label136
        '
        Me.Label136.BackColor = System.Drawing.SystemColors.Control
        Me.Label136.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label136.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label136.LocalizedText.Text = "Beschreibung:"
        Me.Label136.Location = New System.Drawing.Point(38, 218)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(100, 23)
        Me.Label136.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.LocalizedText.Text = "°C"
        Me.Label24.Location = New System.Drawing.Point(214, 354)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt02_Temperatur
        '
        Me.lblAbschnitt02_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt02_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt02_Temperatur.Location = New System.Drawing.Point(144, 354)
        Me.lblAbschnitt02_Temperatur.Name = "lblAbschnitt02_Temperatur"
        Me.lblAbschnitt02_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(141, 351)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt02_Zeit_Sek
        '
        Me.lblAbschnitt02_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt02_Zeit_Sek.Location = New System.Drawing.Point(213, 374)
        Me.lblAbschnitt02_Zeit_Sek.Name = "lblAbschnitt02_Zeit_Sek"
        Me.lblAbschnitt02_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt02_Zeit_Min
        '
        Me.lblAbschnitt02_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt02_Zeit_Min.Location = New System.Drawing.Point(177, 374)
        Me.lblAbschnitt02_Zeit_Min.Name = "lblAbschnitt02_Zeit_Min"
        Me.lblAbschnitt02_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt02_Zeit_Std
        '
        Me.lblAbschnitt02_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt02_Zeit_Std.Location = New System.Drawing.Point(141, 374)
        Me.lblAbschnitt02_Zeit_Std.Name = "lblAbschnitt02_Zeit_Std"
        Me.lblAbschnitt02_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label30
        '
        Me.Label30.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.LocalizedText.Text = ":"
        Me.Label30.Location = New System.Drawing.Point(205, 371)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(10, 24)
        Me.Label30.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.LocalizedText.Text = ":"
        Me.Label31.Location = New System.Drawing.Point(169, 371)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(10, 24)
        Me.Label31.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.LocalizedText.Text = "Zeit:"
        Me.Label32.Location = New System.Drawing.Point(31, 374)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(107, 20)
        Me.Label32.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.LocalizedText.Text = "Temperatur:"
        Me.Label33.Location = New System.Drawing.Point(31, 351)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(107, 20)
        Me.Label33.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Yellow
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.LocalizedText.Text = "Abschnitt 02                  Soll"
        Me.Label34.Location = New System.Drawing.Point(31, 329)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(210, 20)
        Me.Label34.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.LocalizedText.Text = "°C"
        Me.Label35.Location = New System.Drawing.Point(214, 424)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt03_Temperatur
        '
        Me.lblAbschnitt03_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt03_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt03_Temperatur.Location = New System.Drawing.Point(144, 424)
        Me.lblAbschnitt03_Temperatur.Name = "lblAbschnitt03_Temperatur"
        Me.lblAbschnitt03_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(141, 421)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt03_Zeit_Sek
        '
        Me.lblAbschnitt03_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt03_Zeit_Sek.Location = New System.Drawing.Point(213, 444)
        Me.lblAbschnitt03_Zeit_Sek.Name = "lblAbschnitt03_Zeit_Sek"
        Me.lblAbschnitt03_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt03_Zeit_Min
        '
        Me.lblAbschnitt03_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt03_Zeit_Min.Location = New System.Drawing.Point(177, 444)
        Me.lblAbschnitt03_Zeit_Min.Name = "lblAbschnitt03_Zeit_Min"
        Me.lblAbschnitt03_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt03_Zeit_Std
        '
        Me.lblAbschnitt03_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt03_Zeit_Std.Location = New System.Drawing.Point(141, 444)
        Me.lblAbschnitt03_Zeit_Std.Name = "lblAbschnitt03_Zeit_Std"
        Me.lblAbschnitt03_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label41
        '
        Me.Label41.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.LocalizedText.Text = ":"
        Me.Label41.Location = New System.Drawing.Point(205, 441)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(10, 24)
        Me.Label41.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label42
        '
        Me.Label42.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.LocalizedText.Text = ":"
        Me.Label42.Location = New System.Drawing.Point(169, 441)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(10, 24)
        Me.Label42.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.LocalizedText.Text = "Zeit:"
        Me.Label43.Location = New System.Drawing.Point(31, 444)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(107, 20)
        Me.Label43.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.LocalizedText.Text = "Temperatur:"
        Me.Label44.Location = New System.Drawing.Point(31, 421)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(107, 20)
        Me.Label44.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Yellow
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.LocalizedText.Text = "Abschnitt 03                  Soll"
        Me.Label45.Location = New System.Drawing.Point(31, 399)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(210, 20)
        Me.Label45.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.LocalizedText.Text = "°C"
        Me.Label46.Location = New System.Drawing.Point(213, 494)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt04_Temperatur
        '
        Me.lblAbschnitt04_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt04_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt04_Temperatur.Location = New System.Drawing.Point(143, 494)
        Me.lblAbschnitt04_Temperatur.Name = "lblAbschnitt04_Temperatur"
        Me.lblAbschnitt04_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(140, 491)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt04_Zeit_Sek
        '
        Me.lblAbschnitt04_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt04_Zeit_Sek.Location = New System.Drawing.Point(212, 514)
        Me.lblAbschnitt04_Zeit_Sek.Name = "lblAbschnitt04_Zeit_Sek"
        Me.lblAbschnitt04_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt04_Zeit_Min
        '
        Me.lblAbschnitt04_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt04_Zeit_Min.Location = New System.Drawing.Point(176, 514)
        Me.lblAbschnitt04_Zeit_Min.Name = "lblAbschnitt04_Zeit_Min"
        Me.lblAbschnitt04_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt04_Zeit_Std
        '
        Me.lblAbschnitt04_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt04_Zeit_Std.Location = New System.Drawing.Point(140, 514)
        Me.lblAbschnitt04_Zeit_Std.Name = "lblAbschnitt04_Zeit_Std"
        Me.lblAbschnitt04_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label52
        '
        Me.Label52.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.LocalizedText.Text = ":"
        Me.Label52.Location = New System.Drawing.Point(204, 511)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(10, 24)
        Me.Label52.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label53
        '
        Me.Label53.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.LocalizedText.Text = ":"
        Me.Label53.Location = New System.Drawing.Point(168, 511)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(10, 24)
        Me.Label53.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.LocalizedText.Text = "Zeit:"
        Me.Label54.Location = New System.Drawing.Point(30, 514)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(107, 20)
        Me.Label54.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.LocalizedText.Text = "Temperatur:"
        Me.Label55.Location = New System.Drawing.Point(30, 491)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(107, 20)
        Me.Label55.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Yellow
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.LocalizedText.Text = "Abschnitt 04                  Soll"
        Me.Label56.Location = New System.Drawing.Point(30, 469)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(210, 20)
        Me.Label56.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label57
        '
        Me.Label57.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.LocalizedText.Text = "°C"
        Me.Label57.Location = New System.Drawing.Point(214, 564)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt05_Temperatur
        '
        Me.lblAbschnitt05_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt05_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt05_Temperatur.Location = New System.Drawing.Point(144, 564)
        Me.lblAbschnitt05_Temperatur.Name = "lblAbschnitt05_Temperatur"
        Me.lblAbschnitt05_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(141, 561)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt05_Zeit_Sek
        '
        Me.lblAbschnitt05_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt05_Zeit_Sek.Location = New System.Drawing.Point(213, 584)
        Me.lblAbschnitt05_Zeit_Sek.Name = "lblAbschnitt05_Zeit_Sek"
        Me.lblAbschnitt05_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt05_Zeit_Min
        '
        Me.lblAbschnitt05_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt05_Zeit_Min.Location = New System.Drawing.Point(177, 584)
        Me.lblAbschnitt05_Zeit_Min.Name = "lblAbschnitt05_Zeit_Min"
        Me.lblAbschnitt05_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt05_Zeit_Std
        '
        Me.lblAbschnitt05_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt05_Zeit_Std.Location = New System.Drawing.Point(141, 584)
        Me.lblAbschnitt05_Zeit_Std.Name = "lblAbschnitt05_Zeit_Std"
        Me.lblAbschnitt05_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label63
        '
        Me.Label63.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.LocalizedText.Text = ":"
        Me.Label63.Location = New System.Drawing.Point(205, 583)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(10, 24)
        Me.Label63.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label64
        '
        Me.Label64.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.LocalizedText.Text = ":"
        Me.Label64.Location = New System.Drawing.Point(169, 583)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(10, 24)
        Me.Label64.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.LocalizedText.Text = "Zeit:"
        Me.Label65.Location = New System.Drawing.Point(31, 584)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(107, 20)
        Me.Label65.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.LocalizedText.Text = "Temperatur:"
        Me.Label66.Location = New System.Drawing.Point(31, 561)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(107, 20)
        Me.Label66.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Yellow
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.LocalizedText.Text = "Abschnitt 05                  Soll"
        Me.Label67.Location = New System.Drawing.Point(31, 539)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(210, 20)
        Me.Label67.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label68
        '
        Me.Label68.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.LocalizedText.Text = "°C"
        Me.Label68.Location = New System.Drawing.Point(213, 634)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt06_Temperatur
        '
        Me.lblAbschnitt06_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt06_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt06_Temperatur.Location = New System.Drawing.Point(143, 634)
        Me.lblAbschnitt06_Temperatur.Name = "lblAbschnitt06_Temperatur"
        Me.lblAbschnitt06_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(140, 631)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt06_Zeit_Sek
        '
        Me.lblAbschnitt06_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt06_Zeit_Sek.Location = New System.Drawing.Point(212, 654)
        Me.lblAbschnitt06_Zeit_Sek.Name = "lblAbschnitt06_Zeit_Sek"
        Me.lblAbschnitt06_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt06_Zeit_Min
        '
        Me.lblAbschnitt06_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt06_Zeit_Min.Location = New System.Drawing.Point(176, 654)
        Me.lblAbschnitt06_Zeit_Min.Name = "lblAbschnitt06_Zeit_Min"
        Me.lblAbschnitt06_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt06_Zeit_Std
        '
        Me.lblAbschnitt06_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt06_Zeit_Std.Location = New System.Drawing.Point(140, 654)
        Me.lblAbschnitt06_Zeit_Std.Name = "lblAbschnitt06_Zeit_Std"
        Me.lblAbschnitt06_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label74
        '
        Me.Label74.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.LocalizedText.Text = ":"
        Me.Label74.Location = New System.Drawing.Point(204, 653)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(10, 24)
        Me.Label74.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label75
        '
        Me.Label75.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.LocalizedText.Text = ":"
        Me.Label75.Location = New System.Drawing.Point(168, 653)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(10, 24)
        Me.Label75.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.LocalizedText.Text = "Zeit:"
        Me.Label76.Location = New System.Drawing.Point(30, 654)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(107, 20)
        Me.Label76.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.LocalizedText.Text = "Temperatur:"
        Me.Label77.Location = New System.Drawing.Point(30, 631)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(107, 20)
        Me.Label77.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.Yellow
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.LocalizedText.Text = "Abschnitt 06                  Soll"
        Me.Label78.Location = New System.Drawing.Point(30, 609)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(210, 20)
        Me.Label78.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label79
        '
        Me.Label79.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.LocalizedText.Text = "°C"
        Me.Label79.Location = New System.Drawing.Point(429, 612)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(20, 16)
        '
        'lblRegelabweichung
        '
        Me.lblRegelabweichung.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblRegelabweichung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegelabweichung.Location = New System.Drawing.Point(359, 612)
        Me.lblRegelabweichung.Name = "lblRegelabweichung"
        Me.lblRegelabweichung.Size = New System.Drawing.Size(70, 16)
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(356, 609)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(100, 20)
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.LocalizedText.Text = "Belüftung:"
        Me.Label87.Location = New System.Drawing.Point(246, 654)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(107, 20)
        Me.Label87.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label88
        '
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.LocalizedText.Text = "Regelabweichung:"
        Me.Label88.Location = New System.Drawing.Point(246, 609)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(107, 20)
        Me.Label88.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.Yellow
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.LocalizedText.Text = "Allgemein                      Soll"
        Me.Label89.Location = New System.Drawing.Point(246, 584)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(210, 20)
        Me.Label89.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label101
        '
        Me.Label101.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.LocalizedText.Text = "°C"
        Me.Label101.Location = New System.Drawing.Point(429, 494)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt10_Temperatur
        '
        Me.lblAbschnitt10_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt10_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt10_Temperatur.Location = New System.Drawing.Point(359, 494)
        Me.lblAbschnitt10_Temperatur.Name = "lblAbschnitt10_Temperatur"
        Me.lblAbschnitt10_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label103
        '
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(356, 491)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt10_Zeit_Sek
        '
        Me.lblAbschnitt10_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt10_Zeit_Sek.Location = New System.Drawing.Point(428, 514)
        Me.lblAbschnitt10_Zeit_Sek.Name = "lblAbschnitt10_Zeit_Sek"
        Me.lblAbschnitt10_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt10_Zeit_Min
        '
        Me.lblAbschnitt10_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt10_Zeit_Min.Location = New System.Drawing.Point(392, 514)
        Me.lblAbschnitt10_Zeit_Min.Name = "lblAbschnitt10_Zeit_Min"
        Me.lblAbschnitt10_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt10_Zeit_Std
        '
        Me.lblAbschnitt10_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt10_Zeit_Std.Location = New System.Drawing.Point(356, 514)
        Me.lblAbschnitt10_Zeit_Std.Name = "lblAbschnitt10_Zeit_Std"
        Me.lblAbschnitt10_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label107
        '
        Me.Label107.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.LocalizedText.Text = ":"
        Me.Label107.Location = New System.Drawing.Point(420, 511)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(10, 24)
        Me.Label107.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label108
        '
        Me.Label108.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.LocalizedText.Text = ":"
        Me.Label108.Location = New System.Drawing.Point(384, 511)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(10, 24)
        Me.Label108.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label109
        '
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.LocalizedText.Text = "Zeit:"
        Me.Label109.Location = New System.Drawing.Point(246, 514)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(107, 20)
        Me.Label109.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label110
        '
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.LocalizedText.Text = "Temperatur:"
        Me.Label110.Location = New System.Drawing.Point(246, 491)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(107, 20)
        Me.Label110.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label111
        '
        Me.Label111.BackColor = System.Drawing.Color.Yellow
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.LocalizedText.Text = "Abschnitt 10                  Soll"
        Me.Label111.Location = New System.Drawing.Point(246, 469)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(210, 20)
        Me.Label111.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label112
        '
        Me.Label112.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.LocalizedText.Text = "°C"
        Me.Label112.Location = New System.Drawing.Point(430, 424)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt09_Temperatur
        '
        Me.lblAbschnitt09_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt09_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt09_Temperatur.Location = New System.Drawing.Point(360, 424)
        Me.lblAbschnitt09_Temperatur.Name = "lblAbschnitt09_Temperatur"
        Me.lblAbschnitt09_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label114
        '
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(357, 421)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt09_Zeit_Sek
        '
        Me.lblAbschnitt09_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt09_Zeit_Sek.Location = New System.Drawing.Point(429, 444)
        Me.lblAbschnitt09_Zeit_Sek.Name = "lblAbschnitt09_Zeit_Sek"
        Me.lblAbschnitt09_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt09_Zeit_Min
        '
        Me.lblAbschnitt09_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt09_Zeit_Min.Location = New System.Drawing.Point(393, 444)
        Me.lblAbschnitt09_Zeit_Min.Name = "lblAbschnitt09_Zeit_Min"
        Me.lblAbschnitt09_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt09_Zeit_Std
        '
        Me.lblAbschnitt09_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt09_Zeit_Std.Location = New System.Drawing.Point(357, 444)
        Me.lblAbschnitt09_Zeit_Std.Name = "lblAbschnitt09_Zeit_Std"
        Me.lblAbschnitt09_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label118
        '
        Me.Label118.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.LocalizedText.Text = ":"
        Me.Label118.Location = New System.Drawing.Point(421, 441)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(10, 24)
        Me.Label118.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label119
        '
        Me.Label119.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.LocalizedText.Text = ":"
        Me.Label119.Location = New System.Drawing.Point(385, 441)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(10, 24)
        Me.Label119.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label120
        '
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.LocalizedText.Text = "Zeit:"
        Me.Label120.Location = New System.Drawing.Point(247, 444)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(107, 20)
        Me.Label120.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label121
        '
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.LocalizedText.Text = "Temperatur:"
        Me.Label121.Location = New System.Drawing.Point(247, 421)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(107, 20)
        Me.Label121.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label122
        '
        Me.Label122.BackColor = System.Drawing.Color.Yellow
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.LocalizedText.Text = "Abschnitt 09                  Soll"
        Me.Label122.Location = New System.Drawing.Point(247, 399)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(210, 20)
        Me.Label122.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label123
        '
        Me.Label123.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.LocalizedText.Text = "°C"
        Me.Label123.Location = New System.Drawing.Point(430, 354)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt08_Temperatur
        '
        Me.lblAbschnitt08_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt08_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt08_Temperatur.Location = New System.Drawing.Point(360, 354)
        Me.lblAbschnitt08_Temperatur.Name = "lblAbschnitt08_Temperatur"
        Me.lblAbschnitt08_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label125
        '
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.Location = New System.Drawing.Point(357, 351)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt08_Zeit_Sek
        '
        Me.lblAbschnitt08_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt08_Zeit_Sek.Location = New System.Drawing.Point(429, 374)
        Me.lblAbschnitt08_Zeit_Sek.Name = "lblAbschnitt08_Zeit_Sek"
        Me.lblAbschnitt08_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt08_Zeit_Min
        '
        Me.lblAbschnitt08_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt08_Zeit_Min.Location = New System.Drawing.Point(393, 374)
        Me.lblAbschnitt08_Zeit_Min.Name = "lblAbschnitt08_Zeit_Min"
        Me.lblAbschnitt08_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt08_Zeit_Std
        '
        Me.lblAbschnitt08_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt08_Zeit_Std.Location = New System.Drawing.Point(357, 374)
        Me.lblAbschnitt08_Zeit_Std.Name = "lblAbschnitt08_Zeit_Std"
        Me.lblAbschnitt08_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label129
        '
        Me.Label129.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.LocalizedText.Text = ":"
        Me.Label129.Location = New System.Drawing.Point(421, 371)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(10, 24)
        Me.Label129.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label130
        '
        Me.Label130.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.LocalizedText.Text = ":"
        Me.Label130.Location = New System.Drawing.Point(385, 371)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(10, 24)
        Me.Label130.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label131
        '
        Me.Label131.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.LocalizedText.Text = "Zeit:"
        Me.Label131.Location = New System.Drawing.Point(247, 374)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(107, 20)
        Me.Label131.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label132
        '
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.LocalizedText.Text = "Temperatur:"
        Me.Label132.Location = New System.Drawing.Point(247, 351)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(107, 20)
        Me.Label132.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label133
        '
        Me.Label133.BackColor = System.Drawing.Color.Yellow
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.LocalizedText.Text = "Abschnitt 08                  Soll"
        Me.Label133.Location = New System.Drawing.Point(247, 329)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(210, 20)
        Me.Label133.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label135
        '
        Me.Label135.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label135.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.LocalizedText.Text = "°C"
        Me.Label135.Location = New System.Drawing.Point(429, 284)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(20, 16)
        '
        'lblAbschnitt07_Temperatur
        '
        Me.lblAbschnitt07_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt07_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt07_Temperatur.Location = New System.Drawing.Point(359, 284)
        Me.lblAbschnitt07_Temperatur.Name = "lblAbschnitt07_Temperatur"
        Me.lblAbschnitt07_Temperatur.Size = New System.Drawing.Size(70, 16)
        '
        'Label139
        '
        Me.Label139.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.Location = New System.Drawing.Point(356, 281)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(100, 20)
        '
        'lblAbschnitt07_Zeit_Sek
        '
        Me.lblAbschnitt07_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt07_Zeit_Sek.Location = New System.Drawing.Point(428, 304)
        Me.lblAbschnitt07_Zeit_Sek.Name = "lblAbschnitt07_Zeit_Sek"
        Me.lblAbschnitt07_Zeit_Sek.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt07_Zeit_Min
        '
        Me.lblAbschnitt07_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt07_Zeit_Min.Location = New System.Drawing.Point(392, 304)
        Me.lblAbschnitt07_Zeit_Min.Name = "lblAbschnitt07_Zeit_Min"
        Me.lblAbschnitt07_Zeit_Min.Size = New System.Drawing.Size(28, 20)
        '
        'lblAbschnitt07_Zeit_Std
        '
        Me.lblAbschnitt07_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt07_Zeit_Std.Location = New System.Drawing.Point(356, 304)
        Me.lblAbschnitt07_Zeit_Std.Name = "lblAbschnitt07_Zeit_Std"
        Me.lblAbschnitt07_Zeit_Std.Size = New System.Drawing.Size(28, 20)
        '
        'Label143
        '
        Me.Label143.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label143.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label143.LocalizedText.Text = ":"
        Me.Label143.Location = New System.Drawing.Point(420, 301)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(10, 24)
        Me.Label143.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label144
        '
        Me.Label144.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label144.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.LocalizedText.Text = ":"
        Me.Label144.Location = New System.Drawing.Point(384, 301)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(10, 24)
        Me.Label144.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label145
        '
        Me.Label145.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label145.LocalizedText.Text = "Zeit:"
        Me.Label145.Location = New System.Drawing.Point(246, 304)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(107, 20)
        Me.Label145.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label146
        '
        Me.Label146.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label146.LocalizedText.Text = "Temperatur:"
        Me.Label146.Location = New System.Drawing.Point(246, 281)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(107, 20)
        Me.Label146.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label147
        '
        Me.Label147.BackColor = System.Drawing.Color.Yellow
        Me.Label147.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label147.LocalizedText.Text = "Abschnitt 07                  Soll"
        Me.Label147.Location = New System.Drawing.Point(246, 259)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(210, 20)
        Me.Label147.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(454, 495)
        '
        'lblRezept_Name
        '
        Me.lblRezept_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRezept_Name.Location = New System.Drawing.Point(149, 190)
        Me.lblRezept_Name.Name = "lblRezept_Name"
        Me.lblRezept_Name.Size = New System.Drawing.Size(246, 23)
        Me.lblRezept_Name.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblRezept_Beschreibung
        '
        Me.lblRezept_Beschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRezept_Beschreibung.Location = New System.Drawing.Point(149, 218)
        Me.lblRezept_Beschreibung.Name = "lblRezept_Beschreibung"
        Me.lblRezept_Beschreibung.Size = New System.Drawing.Size(246, 35)
        Me.lblRezept_Beschreibung.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblProtokoll_Benutzer
        '
        Me.lblProtokoll_Benutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtokoll_Benutzer.Location = New System.Drawing.Point(668, 140)
        Me.lblProtokoll_Benutzer.Name = "lblProtokoll_Benutzer"
        Me.lblProtokoll_Benutzer.Size = New System.Drawing.Size(230, 27)
        Me.lblProtokoll_Benutzer.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.LocalizedText.Text = "Benutzer:"
        Me.Label15.Location = New System.Drawing.Point(576, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 27)
        Me.Label15.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.LocalizedText.Text = "Protokoll"
        Me.Label13.Location = New System.Drawing.Point(209, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(587, 37)
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.LocalizedText.Text = "Düsenkanal:"
        Me.Label16.Location = New System.Drawing.Point(246, 631)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 20)
        Me.Label16.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblDuesenkanal
        '
        Me.lblDuesenkanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuesenkanal.Location = New System.Drawing.Point(356, 631)
        Me.lblDuesenkanal.Name = "lblDuesenkanal"
        Me.lblDuesenkanal.Size = New System.Drawing.Size(100, 20)
        '
        'lblBelueftung
        '
        Me.lblBelueftung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBelueftung.Location = New System.Drawing.Point(356, 654)
        Me.lblBelueftung.Name = "lblBelueftung"
        Me.lblBelueftung.Size = New System.Drawing.Size(100, 20)
        '
        'dgvProzess_Meldungen
        '
        Me.dgvProzess_Meldungen.AllowUserToAddRows = False
        Me.dgvProzess_Meldungen.AllowUserToDeleteRows = False
        Me.dgvProzess_Meldungen.AllowUserToResizeColumns = False
        Me.dgvProzess_Meldungen.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProzess_Meldungen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProzess_Meldungen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProzess_Meldungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProzess_Meldungen.Location = New System.Drawing.Point(479, 207)
        Me.dgvProzess_Meldungen.MultiSelect = False
        Me.dgvProzess_Meldungen.Name = "dgvProzess_Meldungen"
        Me.dgvProzess_Meldungen.ReadOnly = True
        Me.dgvProzess_Meldungen.RowHeadersVisible = False
        Me.dgvProzess_Meldungen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProzess_Meldungen.Size = New System.Drawing.Size(532, 97)
        Me.dgvProzess_Meldungen.TabIndex = 1154
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Chartreuse
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.LocalizedText.Text = "Prozess"
        Me.Label17.Location = New System.Drawing.Point(479, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(532, 20)
        Me.Label17.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.LocalizedText.Text = "Störungen"
        Me.Label4.Location = New System.Drawing.Point(479, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(532, 20)
        Me.Label4.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'dgvStoer_Meldungen
        '
        Me.dgvStoer_Meldungen.AllowUserToAddRows = False
        Me.dgvStoer_Meldungen.AllowUserToDeleteRows = False
        Me.dgvStoer_Meldungen.AllowUserToResizeColumns = False
        Me.dgvStoer_Meldungen.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStoer_Meldungen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStoer_Meldungen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStoer_Meldungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStoer_Meldungen.Location = New System.Drawing.Point(479, 360)
        Me.dgvStoer_Meldungen.MultiSelect = False
        Me.dgvStoer_Meldungen.Name = "dgvStoer_Meldungen"
        Me.dgvStoer_Meldungen.ReadOnly = True
        Me.dgvStoer_Meldungen.RowHeadersVisible = False
        Me.dgvStoer_Meldungen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStoer_Meldungen.Size = New System.Drawing.Size(532, 97)
        Me.dgvStoer_Meldungen.TabIndex = 1296
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.LocalizedText.Text = "Bemerkung"
        Me.Label12.Location = New System.Drawing.Point(479, 487)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(532, 20)
        Me.Label12.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'lblEndbewertung_Datum_Zeit
        '
        Me.lblEndbewertung_Datum_Zeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndbewertung_Datum_Zeit.Location = New System.Drawing.Point(479, 530)
        Me.lblEndbewertung_Datum_Zeit.Name = "lblEndbewertung_Datum_Zeit"
        Me.lblEndbewertung_Datum_Zeit.Size = New System.Drawing.Size(91, 74)
        '
        'vinEndbewertung1
        '
        Me.vinEndbewertung1.Authorization.Right = "Bedienen"
        Me.vinEndbewertung1.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinEndbewertung1.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung1.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinEndbewertung1.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinEndbewertung1.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung1.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnInput
        Me.vinEndbewertung1.LimitMax.Value = 50
        Me.vinEndbewertung1.Location = New System.Drawing.Point(671, 530)
        Me.vinEndbewertung1.Name = "vinEndbewertung1"
        Me.vinEndbewertung1.Size = New System.Drawing.Size(340, 24)
        Me.vinEndbewertung1.TabIndex = 1900
        Me.vinEndbewertung1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung1.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung1.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinEndbewertung1.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinEndbewertung1.Unit.SizeRatio = 0.25
        Me.vinEndbewertung1.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung1.VWItem.Name = "Protokoll.Endbewertung1"
        '
        'lblEndbewertung_Benutzer
        '
        Me.lblEndbewertung_Benutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndbewertung_Benutzer.Location = New System.Drawing.Point(576, 530)
        Me.lblEndbewertung_Benutzer.Name = "lblEndbewertung_Benutzer"
        Me.lblEndbewertung_Benutzer.Size = New System.Drawing.Size(90, 74)
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.LocalizedText.Text = "Datum/Zeit"
        Me.Label19.Location = New System.Drawing.Point(479, 507)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 20)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.LocalizedText.Text = "Benutzer"
        Me.Label21.Location = New System.Drawing.Point(576, 507)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 20)
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.LocalizedText.Text = "Text"
        Me.Label22.Location = New System.Drawing.Point(671, 507)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(340, 20)
        '
        'cmdEndbewertung_speichern
        '
        Me.cmdEndbewertung_speichern.Authorization.Right = "Bedienen"
        Me.cmdEndbewertung_speichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEndbewertung_speichern.LocalizedText.Text = "speichern"
        Me.cmdEndbewertung_speichern.Location = New System.Drawing.Point(479, 613)
        Me.cmdEndbewertung_speichern.Name = "cmdEndbewertung_speichern"
        Me.cmdEndbewertung_speichern.Size = New System.Drawing.Size(83, 58)
        Me.cmdEndbewertung_speichern.TabIndex = 1595
        '
        'vinEndbewertung2
        '
        Me.vinEndbewertung2.Authorization.Right = "Bedienen"
        Me.vinEndbewertung2.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinEndbewertung2.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung2.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinEndbewertung2.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinEndbewertung2.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung2.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnInput
        Me.vinEndbewertung2.LimitMax.Value = 50
        Me.vinEndbewertung2.Location = New System.Drawing.Point(671, 555)
        Me.vinEndbewertung2.Name = "vinEndbewertung2"
        Me.vinEndbewertung2.Size = New System.Drawing.Size(340, 24)
        Me.vinEndbewertung2.TabIndex = 1901
        Me.vinEndbewertung2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung2.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung2.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinEndbewertung2.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinEndbewertung2.Unit.SizeRatio = 0.25
        Me.vinEndbewertung2.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung2.VWItem.Name = "Protokoll.Endbewertung2"
        '
        'vinEndbewertung3
        '
        Me.vinEndbewertung3.Authorization.Right = "Bedienen"
        Me.vinEndbewertung3.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinEndbewertung3.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung3.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinEndbewertung3.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinEndbewertung3.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung3.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnInput
        Me.vinEndbewertung3.LimitMax.Value = 50
        Me.vinEndbewertung3.Location = New System.Drawing.Point(671, 580)
        Me.vinEndbewertung3.Name = "vinEndbewertung3"
        Me.vinEndbewertung3.Size = New System.Drawing.Size(340, 24)
        Me.vinEndbewertung3.TabIndex = 1902
        Me.vinEndbewertung3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung3.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinEndbewertung3.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinEndbewertung3.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinEndbewertung3.Unit.SizeRatio = 0.25
        Me.vinEndbewertung3.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinEndbewertung3.VWItem.Name = "Protokoll.Endbewertung3"
        '
        'cmdProtokoll_drucken
        '
        Me.cmdProtokoll_drucken.Authorization.Right = "Bedienen"
        Me.cmdProtokoll_drucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProtokoll_drucken.LocalizedText.Text = "drucken"
        Me.cmdProtokoll_drucken.Location = New System.Drawing.Point(928, 613)
        Me.cmdProtokoll_drucken.Name = "cmdProtokoll_drucken"
        Me.cmdProtokoll_drucken.Size = New System.Drawing.Size(83, 58)
        Me.cmdProtokoll_drucken.TabIndex = 2052
        '
        'prdProtokoll
        '
        Me.prdProtokoll.UseEXDialog = True
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(357, 561)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(100, 20)
        Me.Label92.Visible = False
        '
        'Label90
        '
        Me.Label90.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.LocalizedText.Text = "°C"
        Me.Label90.Location = New System.Drawing.Point(430, 564)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(20, 16)
        Me.Label90.Visible = False
        '
        'lblAbschnitt_Ende_Temperatur
        '
        Me.lblAbschnitt_Ende_Temperatur.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblAbschnitt_Ende_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt_Ende_Temperatur.Location = New System.Drawing.Point(360, 564)
        Me.lblAbschnitt_Ende_Temperatur.Name = "lblAbschnitt_Ende_Temperatur"
        Me.lblAbschnitt_Ende_Temperatur.Size = New System.Drawing.Size(70, 16)
        Me.lblAbschnitt_Ende_Temperatur.Visible = False
        '
        'Label99
        '
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.LocalizedText.Text = "Temperatur:"
        Me.Label99.Location = New System.Drawing.Point(247, 561)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(107, 20)
        Me.Label99.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        Me.Label99.Visible = False
        '
        'Label100
        '
        Me.Label100.BackColor = System.Drawing.Color.Yellow
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.LocalizedText.Text = "Abschnitt Ende             Soll"
        Me.Label100.Location = New System.Drawing.Point(247, 539)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(210, 20)
        Me.Label100.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        Me.Label100.Visible = False
        '
        'lblCharge
        '
        Me.lblCharge.BackColor = System.Drawing.SystemColors.Control
        Me.lblCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharge.Location = New System.Drawing.Point(149, 102)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(208, 27)
        Me.lblCharge.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'keyTrend
        '
        Me.keyTrend.Authorization.Right = "Bedienen"
        Me.keyTrend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyTrend.LocalizedText.Text = "Trend"
        Me.keyTrend.Location = New System.Drawing.Point(703, 613)
        Me.keyTrend.Name = "keyTrend"
        Me.keyTrend.Size = New System.Drawing.Size(83, 58)
        Me.keyTrend.TabIndex = 2201
        '
        'FProtokoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.keyTrend)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.cmdProtokoll_drucken)
        Me.Controls.Add(Me.vinEndbewertung3)
        Me.Controls.Add(Me.vinEndbewertung2)
        Me.Controls.Add(Me.cmdEndbewertung_speichern)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblEndbewertung_Benutzer)
        Me.Controls.Add(Me.vinEndbewertung1)
        Me.Controls.Add(Me.lblEndbewertung_Datum_Zeit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvStoer_Meldungen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dgvProzess_Meldungen)
        Me.Controls.Add(Me.lblBelueftung)
        Me.Controls.Add(Me.lblDuesenkanal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblProtokoll_Benutzer)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblRezept_Beschreibung)
        Me.Controls.Add(Me.lblRezept_Name)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.lblRegelabweichung)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label87)
        Me.Controls.Add(Me.Label88)
        Me.Controls.Add(Me.Label89)
        Me.Controls.Add(Me.Label90)
        Me.Controls.Add(Me.lblAbschnitt_Ende_Temperatur)
        Me.Controls.Add(Me.Label92)
        Me.Controls.Add(Me.Label99)
        Me.Controls.Add(Me.Label100)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.lblAbschnitt10_Temperatur)
        Me.Controls.Add(Me.Label103)
        Me.Controls.Add(Me.lblAbschnitt10_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt10_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt10_Zeit_Std)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.Label110)
        Me.Controls.Add(Me.Label111)
        Me.Controls.Add(Me.Label112)
        Me.Controls.Add(Me.lblAbschnitt09_Temperatur)
        Me.Controls.Add(Me.Label114)
        Me.Controls.Add(Me.lblAbschnitt09_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt09_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt09_Zeit_Std)
        Me.Controls.Add(Me.Label118)
        Me.Controls.Add(Me.Label119)
        Me.Controls.Add(Me.Label120)
        Me.Controls.Add(Me.Label121)
        Me.Controls.Add(Me.Label122)
        Me.Controls.Add(Me.Label123)
        Me.Controls.Add(Me.lblAbschnitt08_Temperatur)
        Me.Controls.Add(Me.Label125)
        Me.Controls.Add(Me.lblAbschnitt08_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt08_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt08_Zeit_Std)
        Me.Controls.Add(Me.Label129)
        Me.Controls.Add(Me.Label130)
        Me.Controls.Add(Me.Label131)
        Me.Controls.Add(Me.Label132)
        Me.Controls.Add(Me.Label133)
        Me.Controls.Add(Me.Label135)
        Me.Controls.Add(Me.lblAbschnitt07_Temperatur)
        Me.Controls.Add(Me.Label139)
        Me.Controls.Add(Me.lblAbschnitt07_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt07_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt07_Zeit_Std)
        Me.Controls.Add(Me.Label143)
        Me.Controls.Add(Me.Label144)
        Me.Controls.Add(Me.Label145)
        Me.Controls.Add(Me.Label146)
        Me.Controls.Add(Me.Label147)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.lblAbschnitt06_Temperatur)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.lblAbschnitt06_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt06_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt06_Zeit_Std)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.lblAbschnitt05_Temperatur)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.lblAbschnitt05_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt05_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt05_Zeit_Std)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.lblAbschnitt04_Temperatur)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.lblAbschnitt04_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt04_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt04_Zeit_Std)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.lblAbschnitt03_Temperatur)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.lblAbschnitt03_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt03_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt03_Zeit_Std)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblAbschnitt02_Temperatur)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblAbschnitt02_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt02_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt02_Zeit_Std)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label136)
        Me.Controls.Add(Me.Label137)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblAbschnitt01_Temperatur)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblAbschnitt01_Zeit_Sek)
        Me.Controls.Add(Me.lblAbschnitt01_Zeit_Min)
        Me.Controls.Add(Me.lblAbschnitt01_Zeit_Std)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLaenge)
        Me.Controls.Add(Me.lblArtikel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.Label134)
        Me.Controls.Add(Me.Label11)
        Me.Name = "FProtokoll"
        Me.Text = "FProtokoll"
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label134, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblArtikel, 0)
        Me.Controls.SetChildIndex(Me.lblLaenge, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt01_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt01_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt01_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt01_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label137, 0)
        Me.Controls.SetChildIndex(Me.Label136, 0)
        Me.Controls.SetChildIndex(Me.Label34, 0)
        Me.Controls.SetChildIndex(Me.Label33, 0)
        Me.Controls.SetChildIndex(Me.Label32, 0)
        Me.Controls.SetChildIndex(Me.Label31, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt02_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt02_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt02_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt02_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label24, 0)
        Me.Controls.SetChildIndex(Me.Label45, 0)
        Me.Controls.SetChildIndex(Me.Label44, 0)
        Me.Controls.SetChildIndex(Me.Label43, 0)
        Me.Controls.SetChildIndex(Me.Label42, 0)
        Me.Controls.SetChildIndex(Me.Label41, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt03_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt03_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt03_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label37, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt03_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label35, 0)
        Me.Controls.SetChildIndex(Me.Label56, 0)
        Me.Controls.SetChildIndex(Me.Label55, 0)
        Me.Controls.SetChildIndex(Me.Label54, 0)
        Me.Controls.SetChildIndex(Me.Label53, 0)
        Me.Controls.SetChildIndex(Me.Label52, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt04_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt04_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt04_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label48, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt04_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label46, 0)
        Me.Controls.SetChildIndex(Me.Label67, 0)
        Me.Controls.SetChildIndex(Me.Label66, 0)
        Me.Controls.SetChildIndex(Me.Label65, 0)
        Me.Controls.SetChildIndex(Me.Label64, 0)
        Me.Controls.SetChildIndex(Me.Label63, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt05_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt05_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt05_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label59, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt05_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label57, 0)
        Me.Controls.SetChildIndex(Me.Label78, 0)
        Me.Controls.SetChildIndex(Me.Label77, 0)
        Me.Controls.SetChildIndex(Me.Label76, 0)
        Me.Controls.SetChildIndex(Me.Label75, 0)
        Me.Controls.SetChildIndex(Me.Label74, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt06_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt06_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt06_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label70, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt06_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label68, 0)
        Me.Controls.SetChildIndex(Me.Label147, 0)
        Me.Controls.SetChildIndex(Me.Label146, 0)
        Me.Controls.SetChildIndex(Me.Label145, 0)
        Me.Controls.SetChildIndex(Me.Label144, 0)
        Me.Controls.SetChildIndex(Me.Label143, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt07_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt07_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt07_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label139, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt07_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label135, 0)
        Me.Controls.SetChildIndex(Me.Label133, 0)
        Me.Controls.SetChildIndex(Me.Label132, 0)
        Me.Controls.SetChildIndex(Me.Label131, 0)
        Me.Controls.SetChildIndex(Me.Label130, 0)
        Me.Controls.SetChildIndex(Me.Label129, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt08_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt08_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt08_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label125, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt08_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label123, 0)
        Me.Controls.SetChildIndex(Me.Label122, 0)
        Me.Controls.SetChildIndex(Me.Label121, 0)
        Me.Controls.SetChildIndex(Me.Label120, 0)
        Me.Controls.SetChildIndex(Me.Label119, 0)
        Me.Controls.SetChildIndex(Me.Label118, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt09_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt09_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt09_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label114, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt09_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label112, 0)
        Me.Controls.SetChildIndex(Me.Label111, 0)
        Me.Controls.SetChildIndex(Me.Label110, 0)
        Me.Controls.SetChildIndex(Me.Label109, 0)
        Me.Controls.SetChildIndex(Me.Label108, 0)
        Me.Controls.SetChildIndex(Me.Label107, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt10_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt10_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt10_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label103, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt10_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label101, 0)
        Me.Controls.SetChildIndex(Me.Label100, 0)
        Me.Controls.SetChildIndex(Me.Label99, 0)
        Me.Controls.SetChildIndex(Me.Label92, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt_Ende_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label90, 0)
        Me.Controls.SetChildIndex(Me.Label89, 0)
        Me.Controls.SetChildIndex(Me.Label88, 0)
        Me.Controls.SetChildIndex(Me.Label87, 0)
        Me.Controls.SetChildIndex(Me.Label81, 0)
        Me.Controls.SetChildIndex(Me.lblRegelabweichung, 0)
        Me.Controls.SetChildIndex(Me.Label79, 0)
        Me.Controls.SetChildIndex(Me.lblRezept_Name, 0)
        Me.Controls.SetChildIndex(Me.lblRezept_Beschreibung, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.lblProtokoll_Benutzer, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.lblDuesenkanal, 0)
        Me.Controls.SetChildIndex(Me.lblBelueftung, 0)
        Me.Controls.SetChildIndex(Me.dgvProzess_Meldungen, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.dgvStoer_Meldungen, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.lblEndbewertung_Datum_Zeit, 0)
        Me.Controls.SetChildIndex(Me.vinEndbewertung1, 0)
        Me.Controls.SetChildIndex(Me.lblEndbewertung_Benutzer, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.cmdEndbewertung_speichern, 0)
        Me.Controls.SetChildIndex(Me.vinEndbewertung2, 0)
        Me.Controls.SetChildIndex(Me.vinEndbewertung3, 0)
        Me.Controls.SetChildIndex(Me.cmdProtokoll_drucken, 0)
        Me.Controls.SetChildIndex(Me.lblCharge, 0)
        Me.Controls.SetChildIndex(Me.keyTrend, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sisProtokollierung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblArtikel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLaenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt01_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt01_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt01_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt01_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label137, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label136, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt02_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt02_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt02_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt02_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt03_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt03_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt03_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt03_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt04_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt04_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt04_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt04_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt05_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt05_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt05_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt05_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt06_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt06_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt06_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt06_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRegelabweichung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt10_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt10_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt10_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt10_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt09_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt09_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt09_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt09_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt08_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt08_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt08_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt08_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label135, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt07_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label139, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt07_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt07_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt07_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label143, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label144, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label145, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label146, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label147, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRezept_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRezept_Beschreibung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProtokoll_Benutzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDuesenkanal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBelueftung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProzess_Meldungen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStoer_Meldungen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEndbewertung_Datum_Zeit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinEndbewertung1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEndbewertung_Benutzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdEndbewertung_speichern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinEndbewertung2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinEndbewertung3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdProtokoll_drucken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt_Ende_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyTrend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents Label1 As VisiWinNET.Forms.Label
    Friend WithEvents sisProtokollierung As VisiWinNET.Forms.StateItemServer
    Friend WithEvents Label2 As VisiWinNET.Forms.Label
    Friend WithEvents Label3 As VisiWinNET.Forms.Label
    Friend WithEvents lblArtikel As VisiWinNET.Forms.Label
    Friend WithEvents lblLaenge As VisiWinNET.Forms.Label
    Friend WithEvents Label5 As VisiWinNET.Forms.Label
    Friend WithEvents Label6 As VisiWinNET.Forms.Label
    Friend WithEvents Label7 As VisiWinNET.Forms.Label
    Friend WithEvents Label8 As VisiWinNET.Forms.Label
    Friend WithEvents Label9 As VisiWinNET.Forms.Label
    Friend WithEvents Label10 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt01_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt01_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt01_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents Label20 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt01_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label14 As VisiWinNET.Forms.Label
    Friend WithEvents Label134 As VisiWinNET.Forms.Label
    Friend WithEvents Label137 As VisiWinNET.Forms.Label
    Friend WithEvents Label136 As VisiWinNET.Forms.Label
    Friend WithEvents Label24 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt02_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label26 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt02_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt02_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt02_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label30 As VisiWinNET.Forms.Label
    Friend WithEvents Label31 As VisiWinNET.Forms.Label
    Friend WithEvents Label32 As VisiWinNET.Forms.Label
    Friend WithEvents Label33 As VisiWinNET.Forms.Label
    Friend WithEvents Label34 As VisiWinNET.Forms.Label
    Friend WithEvents Label35 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt03_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label37 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt03_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt03_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt03_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label41 As VisiWinNET.Forms.Label
    Friend WithEvents Label42 As VisiWinNET.Forms.Label
    Friend WithEvents Label43 As VisiWinNET.Forms.Label
    Friend WithEvents Label44 As VisiWinNET.Forms.Label
    Friend WithEvents Label45 As VisiWinNET.Forms.Label
    Friend WithEvents Label46 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt04_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label48 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt04_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt04_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt04_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label52 As VisiWinNET.Forms.Label
    Friend WithEvents Label53 As VisiWinNET.Forms.Label
    Friend WithEvents Label54 As VisiWinNET.Forms.Label
    Friend WithEvents Label55 As VisiWinNET.Forms.Label
    Friend WithEvents Label56 As VisiWinNET.Forms.Label
    Friend WithEvents Label57 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt05_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label59 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt05_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt05_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt05_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label63 As VisiWinNET.Forms.Label
    Friend WithEvents Label64 As VisiWinNET.Forms.Label
    Friend WithEvents Label65 As VisiWinNET.Forms.Label
    Friend WithEvents Label66 As VisiWinNET.Forms.Label
    Friend WithEvents Label67 As VisiWinNET.Forms.Label
    Friend WithEvents Label68 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt06_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label70 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt06_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt06_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt06_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label74 As VisiWinNET.Forms.Label
    Friend WithEvents Label75 As VisiWinNET.Forms.Label
    Friend WithEvents Label76 As VisiWinNET.Forms.Label
    Friend WithEvents Label77 As VisiWinNET.Forms.Label
    Friend WithEvents Label78 As VisiWinNET.Forms.Label
    Friend WithEvents Label79 As VisiWinNET.Forms.Label
    Friend WithEvents lblRegelabweichung As VisiWinNET.Forms.Label
    Friend WithEvents Label81 As VisiWinNET.Forms.Label
    Friend WithEvents Label87 As VisiWinNET.Forms.Label
    Friend WithEvents Label88 As VisiWinNET.Forms.Label
    Friend WithEvents Label89 As VisiWinNET.Forms.Label
    Friend WithEvents Label101 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt10_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label103 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt10_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt10_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt10_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label107 As VisiWinNET.Forms.Label
    Friend WithEvents Label108 As VisiWinNET.Forms.Label
    Friend WithEvents Label109 As VisiWinNET.Forms.Label
    Friend WithEvents Label110 As VisiWinNET.Forms.Label
    Friend WithEvents Label111 As VisiWinNET.Forms.Label
    Friend WithEvents Label112 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt09_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label114 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt09_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt09_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt09_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label118 As VisiWinNET.Forms.Label
    Friend WithEvents Label119 As VisiWinNET.Forms.Label
    Friend WithEvents Label120 As VisiWinNET.Forms.Label
    Friend WithEvents Label121 As VisiWinNET.Forms.Label
    Friend WithEvents Label122 As VisiWinNET.Forms.Label
    Friend WithEvents Label123 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt08_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label125 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt08_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt08_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt08_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label129 As VisiWinNET.Forms.Label
    Friend WithEvents Label130 As VisiWinNET.Forms.Label
    Friend WithEvents Label131 As VisiWinNET.Forms.Label
    Friend WithEvents Label132 As VisiWinNET.Forms.Label
    Friend WithEvents Label133 As VisiWinNET.Forms.Label
    Friend WithEvents Label135 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt07_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label139 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt07_Zeit_Sek As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt07_Zeit_Min As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt07_Zeit_Std As VisiWinNET.Forms.Label
    Friend WithEvents Label143 As VisiWinNET.Forms.Label
    Friend WithEvents Label144 As VisiWinNET.Forms.Label
    Friend WithEvents Label145 As VisiWinNET.Forms.Label
    Friend WithEvents Label146 As VisiWinNET.Forms.Label
    Friend WithEvents Label147 As VisiWinNET.Forms.Label
    Friend WithEvents Label11 As VisiWinNET.Forms.Label
    Friend WithEvents lblRezept_Name As VisiWinNET.Forms.Label
    Friend WithEvents lblRezept_Beschreibung As VisiWinNET.Forms.Label
    Friend WithEvents lblProtokoll_Benutzer As VisiWinNET.Forms.Label
    Friend WithEvents Label15 As VisiWinNET.Forms.Label
    Friend WithEvents Label13 As VisiWinNET.Forms.Label
    Friend WithEvents Label16 As VisiWinNET.Forms.Label
    Friend WithEvents lblDuesenkanal As VisiWinNET.Forms.Label
    Friend WithEvents lblBelueftung As VisiWinNET.Forms.Label
    Friend WithEvents dgvProzess_Meldungen As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As VisiWinNET.Forms.Label
    Friend WithEvents Label4 As VisiWinNET.Forms.Label
    Friend WithEvents dgvStoer_Meldungen As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As VisiWinNET.Forms.Label
    Friend WithEvents lblEndbewertung_Datum_Zeit As VisiWinNET.Forms.Label
    Friend WithEvents vinEndbewertung1 As VisiWinNET.Forms.VarIn
    Friend WithEvents lblEndbewertung_Benutzer As VisiWinNET.Forms.Label
    Friend WithEvents Label19 As VisiWinNET.Forms.Label
    Friend WithEvents Label21 As VisiWinNET.Forms.Label
    Friend WithEvents Label22 As VisiWinNET.Forms.Label
    Friend WithEvents cmdEndbewertung_speichern As VisiWinNET.Forms.CommandButton
    Friend WithEvents vinEndbewertung2 As VisiWinNET.Forms.VarIn
    Friend WithEvents vinEndbewertung3 As VisiWinNET.Forms.VarIn
    Friend WithEvents cmdProtokoll_drucken As VisiWinNET.Forms.CommandButton
    Friend WithEvents prdProtokoll As System.Windows.Forms.PrintDialog
    Friend WithEvents Label92 As VisiWinNET.Forms.Label
    Friend WithEvents Label90 As VisiWinNET.Forms.Label
    Friend WithEvents lblAbschnitt_Ende_Temperatur As VisiWinNET.Forms.Label
    Friend WithEvents Label99 As VisiWinNET.Forms.Label
    Friend WithEvents Label100 As VisiWinNET.Forms.Label
    Friend WithEvents lblCharge As VisiWinNET.Forms.Label
    Friend WithEvents keyTrend As VisiWinNET.Forms.Key

End Class
