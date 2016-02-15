<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FStatus_Daten
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStatus_Daten))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.lblProgramm_Status = New VisiWinNET.Forms.Label
        Me.votRezept_Beschreibung = New VisiWinNET.Forms.VarOut
        Me.votRezept_Name = New VisiWinNET.Forms.VarOut
        Me.Label7 = New VisiWinNET.Forms.Label
        Me.Label6 = New VisiWinNET.Forms.Label
        Me.cmdRezept_laden = New VisiWinNET.Forms.CommandButton
        Me.Label1 = New VisiWinNET.Forms.Label
        Me.Label2 = New VisiWinNET.Forms.Label
        Me.Label3 = New VisiWinNET.Forms.Label
        Me.vinCharge1_Chargennummer = New VisiWinNET.Forms.VarIn
        Me.Label4 = New VisiWinNET.Forms.Label
        Me.vinCharge1_Chargenindex = New VisiWinNET.Forms.VarIn
        Me.vinCharge1_Artikel = New VisiWinNET.Forms.VarIn
        Me.vinCharge1_Laenge = New VisiWinNET.Forms.VarIn
        Me.vinCharge2_Laenge = New VisiWinNET.Forms.VarIn
        Me.vinCharge2_Artikel = New VisiWinNET.Forms.VarIn
        Me.vinCharge2_Chargenindex = New VisiWinNET.Forms.VarIn
        Me.vinCharge2_Chargennummer = New VisiWinNET.Forms.VarIn
        Me.Label5 = New VisiWinNET.Forms.Label
        Me.Label8 = New VisiWinNET.Forms.Label
        Me.Label9 = New VisiWinNET.Forms.Label
        Me.Label10 = New VisiWinNET.Forms.Label
        Me.vinCharge3_Laenge = New VisiWinNET.Forms.VarIn
        Me.vinCharge3_Artikel = New VisiWinNET.Forms.VarIn
        Me.vinCharge3_Chargenindex = New VisiWinNET.Forms.VarIn
        Me.vinCharge3_Chargennummer = New VisiWinNET.Forms.VarIn
        Me.Label11 = New VisiWinNET.Forms.Label
        Me.Label12 = New VisiWinNET.Forms.Label
        Me.Label13 = New VisiWinNET.Forms.Label
        Me.Label14 = New VisiWinNET.Forms.Label
        Me.vinCharge4_Laenge = New VisiWinNET.Forms.VarIn
        Me.vinCharge4_Artikel = New VisiWinNET.Forms.VarIn
        Me.vinCharge4_Chargenindex = New VisiWinNET.Forms.VarIn
        Me.vinCharge4_Chargennummer = New VisiWinNET.Forms.VarIn
        Me.Label15 = New VisiWinNET.Forms.Label
        Me.Label16 = New VisiWinNET.Forms.Label
        Me.Label17 = New VisiWinNET.Forms.Label
        Me.Label18 = New VisiWinNET.Forms.Label
        Me.vinCharge5_Laenge = New VisiWinNET.Forms.VarIn
        Me.vinCharge5_Artikel = New VisiWinNET.Forms.VarIn
        Me.vinCharge5_Chargenindex = New VisiWinNET.Forms.VarIn
        Me.vinCharge5_Chargennummer = New VisiWinNET.Forms.VarIn
        Me.Label19 = New VisiWinNET.Forms.Label
        Me.Label20 = New VisiWinNET.Forms.Label
        Me.Label21 = New VisiWinNET.Forms.Label
        Me.Label22 = New VisiWinNET.Forms.Label
        Me.Label23 = New VisiWinNET.Forms.Label
        Me.Label26 = New VisiWinNET.Forms.Label
        Me.Label27 = New VisiWinNET.Forms.Label
        Me.Label28 = New VisiWinNET.Forms.Label
        Me.votAbschnitt_Nummer = New VisiWinNET.Forms.VarOut
        Me.Label29 = New VisiWinNET.Forms.Label
        Me.Label30 = New VisiWinNET.Forms.Label
        Me.Label31 = New VisiWinNET.Forms.Label
        Me.votAbschnitt_Anfagstemperatur = New VisiWinNET.Forms.VarOut
        Me.votAbschnitt_Endtemperatur = New VisiWinNET.Forms.VarOut
        Me.lblAbschnitt_Duesenkanal = New VisiWinNET.Forms.Label
        Me.votAbschnitt_Regelabweichung = New VisiWinNET.Forms.VarOut
        Me.Label33 = New VisiWinNET.Forms.Label
        Me.Label34 = New VisiWinNET.Forms.Label
        Me.votStatus_SW_Temperatur = New VisiWinNET.Forms.VarOut
        Me.votStatus_IW_Temeratur = New VisiWinNET.Forms.VarOut
        Me.Label35 = New VisiWinNET.Forms.Label
        Me.votStatus_SW_Zeit_Std = New VisiWinNET.Forms.VarOut
        Me.votStatus_SW_Zeit_Min = New VisiWinNET.Forms.VarOut
        Me.votStatus_SW_Zeit_Sek = New VisiWinNET.Forms.VarOut
        Me.Label36 = New VisiWinNET.Forms.Label
        Me.Label37 = New VisiWinNET.Forms.Label
        Me.Label38 = New VisiWinNET.Forms.Label
        Me.Label39 = New VisiWinNET.Forms.Label
        Me.vot_Status_IW_Zeit_Sek = New VisiWinNET.Forms.VarOut
        Me.votStatus_IW_Zeit_Min = New VisiWinNET.Forms.VarOut
        Me.votStatus_IW_Zeit_Std = New VisiWinNET.Forms.VarOut
        Me.votStatus_IW_Zuluftmenge = New VisiWinNET.Forms.VarOut
        Me.Label24 = New VisiWinNET.Forms.Label
        Me.votStatus_IW_Abluftmenge = New VisiWinNET.Forms.VarOut
        Me.Label25 = New VisiWinNET.Forms.Label
        Me.isvProgramm_Status = New VisiWinNET.Forms.ItemServer(Me.components)
        Me.keyProgramm_Neustart = New VisiWinNET.Forms.Key
        Me.keyProgramm_Stop = New VisiWinNET.Forms.Key
        Me.keyProgramm_Ende = New VisiWinNET.Forms.Key
        Me.cmdProgramm_Start = New VisiWinNET.Forms.CommandButton
        Me.Label40 = New VisiWinNET.Forms.Label
        Me.votStatus_IW_Restzeit_Std = New VisiWinNET.Forms.VarOut
        Me.votStatus_IW_Restzeit_Min = New VisiWinNET.Forms.VarOut
        Me.votStatus_IW_Restzeit_Sek = New VisiWinNET.Forms.VarOut
        Me.Label42 = New VisiWinNET.Forms.Label
        Me.Label41 = New VisiWinNET.Forms.Label
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProgramm_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votRezept_Beschreibung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votRezept_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRezept_laden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge1_Chargennummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge1_Chargenindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge1_Artikel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge1_Laenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge2_Laenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge2_Artikel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge2_Chargenindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge2_Chargennummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge3_Laenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge3_Artikel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge3_Chargenindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge3_Chargennummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge4_Laenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge4_Artikel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge4_Chargenindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge4_Chargennummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge5_Laenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge5_Artikel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge5_Chargenindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinCharge5_Chargennummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votAbschnitt_Nummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votAbschnitt_Anfagstemperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votAbschnitt_Endtemperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAbschnitt_Duesenkanal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votAbschnitt_Regelabweichung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_SW_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Temeratur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_SW_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_SW_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_SW_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vot_Status_IW_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Zuluftmenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Abluftmenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isvProgramm_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyProgramm_Neustart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyProgramm_Stop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyProgramm_Ende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdProgramm_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Restzeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Restzeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votStatus_IW_Restzeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Status Daten"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'lblProgramm_Status
        '
        Me.lblProgramm_Status.BackColor = System.Drawing.Color.Yellow
        Me.lblProgramm_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramm_Status.LocalizedText.TextGroup = "Textlisten.Programm_Status"
        Me.lblProgramm_Status.LocalizedText.TextPrefix = "Programm_Status"
        Me.lblProgramm_Status.LocalizedText.UseTextOn = False
        Me.lblProgramm_Status.Location = New System.Drawing.Point(320, 93)
        Me.lblProgramm_Status.Name = "lblProgramm_Status"
        Me.lblProgramm_Status.Size = New System.Drawing.Size(393, 37)
        Me.lblProgramm_Status.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Value
        Me.lblProgramm_Status.VWItem.Name = "SPS Ofen.Arbeit_PC.Programm_Status"
        Me.lblProgramm_Status.VWItem.Range = CType(2, Long)
        '
        'votRezept_Beschreibung
        '
        Me.votRezept_Beschreibung.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votRezept_Beschreibung.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Beschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votRezept_Beschreibung.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Beschreibung.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Beschreibung.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Beschreibung.Location = New System.Drawing.Point(398, 174)
        Me.votRezept_Beschreibung.Name = "votRezept_Beschreibung"
        Me.votRezept_Beschreibung.Size = New System.Drawing.Size(246, 35)
        Me.votRezept_Beschreibung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Beschreibung.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Beschreibung.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Beschreibung.Unit.SizeRatio = 0.25
        Me.votRezept_Beschreibung.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Beschreibung.VWItem.Name = "SPS Ofen.Status.Rezept_Beschreibung"
        '
        'votRezept_Name
        '
        Me.votRezept_Name.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votRezept_Name.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votRezept_Name.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Name.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Name.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Name.Location = New System.Drawing.Point(398, 137)
        Me.votRezept_Name.Name = "votRezept_Name"
        Me.votRezept_Name.Size = New System.Drawing.Size(246, 31)
        Me.votRezept_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Name.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Name.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Name.Unit.SizeRatio = 0.25
        Me.votRezept_Name.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Name.VWItem.Name = "SPS Ofen.Status.Rezept_Name"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.LocalizedText.Text = "Beschreibung:"
        Me.Label7.Location = New System.Drawing.Point(231, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 31)
        Me.Label7.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.LocalizedText.Text = "Programm:"
        Me.Label6.Location = New System.Drawing.Point(231, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 31)
        Me.Label6.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'cmdRezept_laden
        '
        Me.cmdRezept_laden.Authorization.Right = "Programmvorwahl"
        Me.cmdRezept_laden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRezept_laden.LocalizedText.Text = "laden"
        Me.cmdRezept_laden.Location = New System.Drawing.Point(685, 147)
        Me.cmdRezept_laden.Name = "cmdRezept_laden"
        Me.cmdRezept_laden.Size = New System.Drawing.Size(87, 40)
        Me.cmdRezept_laden.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.LocalizedText.Text = "Charge 1:"
        Me.Label1.Location = New System.Drawing.Point(162, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 30)
        Me.Label1.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.LocalizedText.Text = "Artikel:"
        Me.Label2.Location = New System.Drawing.Point(388, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 30)
        Me.Label2.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.LocalizedText.Text = "Länge:"
        Me.Label3.Location = New System.Drawing.Point(705, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 30)
        Me.Label3.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinCharge1_Chargennummer
        '
        Me.vinCharge1_Chargennummer.Authorization.Right = "Bedienen"
        Me.vinCharge1_Chargennummer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Chargennummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge1_Chargennummer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Chargennummer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Chargennummer.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Chargennummer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Chargennummer.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge1_Chargennummer.LimitMax.Value = 6
        Me.vinCharge1_Chargennummer.Location = New System.Drawing.Point(248, 215)
        Me.vinCharge1_Chargennummer.Name = "vinCharge1_Chargennummer"
        Me.vinCharge1_Chargennummer.Size = New System.Drawing.Size(81, 30)
        Me.vinCharge1_Chargennummer.TabIndex = 61
        Me.vinCharge1_Chargennummer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Chargennummer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Chargennummer.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Chargennummer.Unit.SizeRatio = 0.25
        Me.vinCharge1_Chargennummer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Chargennummer.VWItem.Name = "SPS Ofen.Status.Charge1.Chargennummer"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.LocalizedText.Text = "-"
        Me.Label4.Location = New System.Drawing.Point(329, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 30)
        Me.Label4.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinCharge1_Chargenindex
        '
        Me.vinCharge1_Chargenindex.Authorization.Right = "Bedienen"
        Me.vinCharge1_Chargenindex.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Chargenindex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge1_Chargenindex.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Chargenindex.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Chargenindex.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Chargenindex.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Chargenindex.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge1_Chargenindex.LimitMax.Value = 99
        Me.vinCharge1_Chargenindex.Location = New System.Drawing.Point(340, 215)
        Me.vinCharge1_Chargenindex.Name = "vinCharge1_Chargenindex"
        Me.vinCharge1_Chargenindex.Size = New System.Drawing.Size(30, 30)
        Me.vinCharge1_Chargenindex.TabIndex = 64
        Me.vinCharge1_Chargenindex.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Chargenindex.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Chargenindex.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Chargenindex.Unit.SizeRatio = 0.25
        Me.vinCharge1_Chargenindex.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Chargenindex.VWItem.Name = "SPS Ofen.Status.Charge1.Chargenindex"
        '
        'vinCharge1_Artikel
        '
        Me.vinCharge1_Artikel.Authorization.Right = "Bedienen"
        Me.vinCharge1_Artikel.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge1_Artikel.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Artikel.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Artikel.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Artikel.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Artikel.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge1_Artikel.LimitMax.Value = 20
        Me.vinCharge1_Artikel.Location = New System.Drawing.Point(450, 215)
        Me.vinCharge1_Artikel.Name = "vinCharge1_Artikel"
        Me.vinCharge1_Artikel.Size = New System.Drawing.Size(241, 30)
        Me.vinCharge1_Artikel.TabIndex = 65
        Me.vinCharge1_Artikel.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Artikel.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Artikel.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Artikel.Unit.SizeRatio = 0.25
        Me.vinCharge1_Artikel.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Artikel.VWItem.Name = "SPS Ofen.Status.Charge1.Artikel"
        '
        'vinCharge1_Laenge
        '
        Me.vinCharge1_Laenge.Authorization.Right = "Bedienen"
        Me.vinCharge1_Laenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Laenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge1_Laenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Laenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge1_Laenge.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge1_Laenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Laenge.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge1_Laenge.LimitMax.Value = 99999
        Me.vinCharge1_Laenge.Location = New System.Drawing.Point(778, 215)
        Me.vinCharge1_Laenge.Name = "vinCharge1_Laenge"
        Me.vinCharge1_Laenge.Size = New System.Drawing.Size(85, 30)
        Me.vinCharge1_Laenge.TabIndex = 76
        Me.vinCharge1_Laenge.Unit.BackColor = System.Drawing.Color.Blue
        Me.vinCharge1_Laenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge1_Laenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vinCharge1_Laenge.Unit.ForeColor = System.Drawing.SystemColors.Window
        Me.vinCharge1_Laenge.Unit.SizeRatio = 0.25
        Me.vinCharge1_Laenge.Unit.Text.Text = "m"
        Me.vinCharge1_Laenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge1_Laenge.VWItem.Name = "SPS Ofen.Status.Charge1.Laenge"
        '
        'vinCharge2_Laenge
        '
        Me.vinCharge2_Laenge.Authorization.Right = "Bedienen"
        Me.vinCharge2_Laenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Laenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge2_Laenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Laenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Laenge.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Laenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Laenge.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge2_Laenge.LimitMax.Value = 99999
        Me.vinCharge2_Laenge.Location = New System.Drawing.Point(778, 249)
        Me.vinCharge2_Laenge.Name = "vinCharge2_Laenge"
        Me.vinCharge2_Laenge.Size = New System.Drawing.Size(85, 30)
        Me.vinCharge2_Laenge.TabIndex = 94
        Me.vinCharge2_Laenge.Unit.BackColor = System.Drawing.Color.Blue
        Me.vinCharge2_Laenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Laenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vinCharge2_Laenge.Unit.ForeColor = System.Drawing.SystemColors.Window
        Me.vinCharge2_Laenge.Unit.SizeRatio = 0.25
        Me.vinCharge2_Laenge.Unit.Text.Text = "m"
        Me.vinCharge2_Laenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Laenge.VWItem.Name = "SPS Ofen.Status.Charge2.Laenge"
        '
        'vinCharge2_Artikel
        '
        Me.vinCharge2_Artikel.Authorization.Right = "Bedienen"
        Me.vinCharge2_Artikel.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge2_Artikel.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Artikel.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Artikel.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Artikel.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Artikel.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge2_Artikel.LimitMax.Value = 20
        Me.vinCharge2_Artikel.Location = New System.Drawing.Point(450, 249)
        Me.vinCharge2_Artikel.Name = "vinCharge2_Artikel"
        Me.vinCharge2_Artikel.Size = New System.Drawing.Size(241, 30)
        Me.vinCharge2_Artikel.TabIndex = 93
        Me.vinCharge2_Artikel.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Artikel.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Artikel.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Artikel.Unit.SizeRatio = 0.25
        Me.vinCharge2_Artikel.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Artikel.VWItem.Name = "SPS Ofen.Status.Charge2.Artikel"
        '
        'vinCharge2_Chargenindex
        '
        Me.vinCharge2_Chargenindex.Authorization.Right = "Bedienen"
        Me.vinCharge2_Chargenindex.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Chargenindex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge2_Chargenindex.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Chargenindex.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Chargenindex.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Chargenindex.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Chargenindex.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge2_Chargenindex.LimitMax.Value = 99
        Me.vinCharge2_Chargenindex.Location = New System.Drawing.Point(340, 249)
        Me.vinCharge2_Chargenindex.Name = "vinCharge2_Chargenindex"
        Me.vinCharge2_Chargenindex.Size = New System.Drawing.Size(30, 30)
        Me.vinCharge2_Chargenindex.TabIndex = 92
        Me.vinCharge2_Chargenindex.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Chargenindex.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Chargenindex.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Chargenindex.Unit.SizeRatio = 0.25
        Me.vinCharge2_Chargenindex.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Chargenindex.VWItem.Name = "SPS Ofen.Status.Charge2.Chargenindex"
        '
        'vinCharge2_Chargennummer
        '
        Me.vinCharge2_Chargennummer.Authorization.Right = "Bedienen"
        Me.vinCharge2_Chargennummer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Chargennummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge2_Chargennummer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Chargennummer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Chargennummer.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Chargennummer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Chargennummer.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge2_Chargennummer.LimitMax.Value = 6
        Me.vinCharge2_Chargennummer.Location = New System.Drawing.Point(248, 249)
        Me.vinCharge2_Chargennummer.Name = "vinCharge2_Chargennummer"
        Me.vinCharge2_Chargennummer.Size = New System.Drawing.Size(81, 30)
        Me.vinCharge2_Chargennummer.TabIndex = 91
        Me.vinCharge2_Chargennummer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge2_Chargennummer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge2_Chargennummer.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge2_Chargennummer.Unit.SizeRatio = 0.25
        Me.vinCharge2_Chargennummer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge2_Chargennummer.VWItem.Name = "SPS Ofen.Status.Charge2.Chargennummer"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Blue
        Me.Label5.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.LocalizedText.Text = "Länge:"
        Me.Label5.Location = New System.Drawing.Point(705, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 30)
        Me.Label5.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.LocalizedText.Text = "Artikel:"
        Me.Label8.Location = New System.Drawing.Point(388, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 30)
        Me.Label8.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.LocalizedText.Text = "Charge 2:"
        Me.Label9.Location = New System.Drawing.Point(162, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 30)
        Me.Label9.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Blue
        Me.Label10.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.LocalizedText.Text = "-"
        Me.Label10.Location = New System.Drawing.Point(329, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 30)
        Me.Label10.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinCharge3_Laenge
        '
        Me.vinCharge3_Laenge.Authorization.Right = "Bedienen"
        Me.vinCharge3_Laenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Laenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge3_Laenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Laenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Laenge.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Laenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Laenge.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge3_Laenge.LimitMax.Value = 99999
        Me.vinCharge3_Laenge.Location = New System.Drawing.Point(778, 283)
        Me.vinCharge3_Laenge.Name = "vinCharge3_Laenge"
        Me.vinCharge3_Laenge.Size = New System.Drawing.Size(85, 30)
        Me.vinCharge3_Laenge.TabIndex = 106
        Me.vinCharge3_Laenge.Unit.BackColor = System.Drawing.Color.Blue
        Me.vinCharge3_Laenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Laenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vinCharge3_Laenge.Unit.ForeColor = System.Drawing.SystemColors.Window
        Me.vinCharge3_Laenge.Unit.SizeRatio = 0.25
        Me.vinCharge3_Laenge.Unit.Text.Text = "m"
        Me.vinCharge3_Laenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Laenge.VWItem.Name = "SPS Ofen.Status.Charge3.Laenge"
        '
        'vinCharge3_Artikel
        '
        Me.vinCharge3_Artikel.Authorization.Right = "Bedienen"
        Me.vinCharge3_Artikel.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge3_Artikel.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Artikel.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Artikel.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Artikel.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Artikel.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge3_Artikel.LimitMax.Value = 20
        Me.vinCharge3_Artikel.Location = New System.Drawing.Point(450, 283)
        Me.vinCharge3_Artikel.Name = "vinCharge3_Artikel"
        Me.vinCharge3_Artikel.Size = New System.Drawing.Size(241, 30)
        Me.vinCharge3_Artikel.TabIndex = 105
        Me.vinCharge3_Artikel.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Artikel.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Artikel.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Artikel.Unit.SizeRatio = 0.25
        Me.vinCharge3_Artikel.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Artikel.VWItem.Name = "SPS Ofen.Status.Charge3.Artikel"
        '
        'vinCharge3_Chargenindex
        '
        Me.vinCharge3_Chargenindex.Authorization.Right = "Bedienen"
        Me.vinCharge3_Chargenindex.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Chargenindex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge3_Chargenindex.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Chargenindex.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Chargenindex.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Chargenindex.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Chargenindex.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge3_Chargenindex.LimitMax.Value = 99
        Me.vinCharge3_Chargenindex.Location = New System.Drawing.Point(340, 283)
        Me.vinCharge3_Chargenindex.Name = "vinCharge3_Chargenindex"
        Me.vinCharge3_Chargenindex.Size = New System.Drawing.Size(30, 30)
        Me.vinCharge3_Chargenindex.TabIndex = 104
        Me.vinCharge3_Chargenindex.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Chargenindex.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Chargenindex.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Chargenindex.Unit.SizeRatio = 0.25
        Me.vinCharge3_Chargenindex.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Chargenindex.VWItem.Name = "SPS Ofen.Status.Charge3.Chargenindex"
        '
        'vinCharge3_Chargennummer
        '
        Me.vinCharge3_Chargennummer.Authorization.Right = "Bedienen"
        Me.vinCharge3_Chargennummer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Chargennummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge3_Chargennummer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Chargennummer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Chargennummer.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Chargennummer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Chargennummer.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge3_Chargennummer.LimitMax.Value = 6
        Me.vinCharge3_Chargennummer.Location = New System.Drawing.Point(248, 283)
        Me.vinCharge3_Chargennummer.Name = "vinCharge3_Chargennummer"
        Me.vinCharge3_Chargennummer.Size = New System.Drawing.Size(81, 30)
        Me.vinCharge3_Chargennummer.TabIndex = 103
        Me.vinCharge3_Chargennummer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge3_Chargennummer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge3_Chargennummer.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge3_Chargennummer.Unit.SizeRatio = 0.25
        Me.vinCharge3_Chargennummer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge3_Chargennummer.VWItem.Name = "SPS Ofen.Status.Charge3.Chargennummer"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Blue
        Me.Label11.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.LocalizedText.Text = "Länge:"
        Me.Label11.Location = New System.Drawing.Point(705, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 30)
        Me.Label11.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Blue
        Me.Label12.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.LocalizedText.Text = "Artikel:"
        Me.Label12.Location = New System.Drawing.Point(388, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 30)
        Me.Label12.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Blue
        Me.Label13.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.LocalizedText.Text = "Charge 3:"
        Me.Label13.Location = New System.Drawing.Point(162, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 30)
        Me.Label13.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Blue
        Me.Label14.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.LocalizedText.Text = "-"
        Me.Label14.Location = New System.Drawing.Point(329, 283)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 30)
        Me.Label14.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinCharge4_Laenge
        '
        Me.vinCharge4_Laenge.Authorization.Right = "Bedienen"
        Me.vinCharge4_Laenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Laenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge4_Laenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Laenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Laenge.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Laenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Laenge.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge4_Laenge.LimitMax.Value = 99999
        Me.vinCharge4_Laenge.Location = New System.Drawing.Point(778, 317)
        Me.vinCharge4_Laenge.Name = "vinCharge4_Laenge"
        Me.vinCharge4_Laenge.Size = New System.Drawing.Size(85, 30)
        Me.vinCharge4_Laenge.TabIndex = 118
        Me.vinCharge4_Laenge.Unit.BackColor = System.Drawing.Color.Blue
        Me.vinCharge4_Laenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Laenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vinCharge4_Laenge.Unit.ForeColor = System.Drawing.SystemColors.Window
        Me.vinCharge4_Laenge.Unit.SizeRatio = 0.25
        Me.vinCharge4_Laenge.Unit.Text.Text = "m"
        Me.vinCharge4_Laenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Laenge.VWItem.Name = "SPS Ofen.Status.Charge4.Laenge"
        '
        'vinCharge4_Artikel
        '
        Me.vinCharge4_Artikel.Authorization.Right = "Bedienen"
        Me.vinCharge4_Artikel.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge4_Artikel.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Artikel.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Artikel.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Artikel.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Artikel.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge4_Artikel.LimitMax.Value = 20
        Me.vinCharge4_Artikel.Location = New System.Drawing.Point(450, 317)
        Me.vinCharge4_Artikel.Name = "vinCharge4_Artikel"
        Me.vinCharge4_Artikel.Size = New System.Drawing.Size(241, 30)
        Me.vinCharge4_Artikel.TabIndex = 117
        Me.vinCharge4_Artikel.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Artikel.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Artikel.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Artikel.Unit.SizeRatio = 0.25
        Me.vinCharge4_Artikel.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Artikel.VWItem.Name = "SPS Ofen.Status.Charge4.Artikel"
        '
        'vinCharge4_Chargenindex
        '
        Me.vinCharge4_Chargenindex.Authorization.Right = "Bedienen"
        Me.vinCharge4_Chargenindex.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Chargenindex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge4_Chargenindex.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Chargenindex.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Chargenindex.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Chargenindex.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Chargenindex.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge4_Chargenindex.LimitMax.Value = 99
        Me.vinCharge4_Chargenindex.Location = New System.Drawing.Point(340, 317)
        Me.vinCharge4_Chargenindex.Name = "vinCharge4_Chargenindex"
        Me.vinCharge4_Chargenindex.Size = New System.Drawing.Size(30, 30)
        Me.vinCharge4_Chargenindex.TabIndex = 116
        Me.vinCharge4_Chargenindex.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Chargenindex.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Chargenindex.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Chargenindex.Unit.SizeRatio = 0.25
        Me.vinCharge4_Chargenindex.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Chargenindex.VWItem.Name = "SPS Ofen.Status.Charge4.Chargenindex"
        '
        'vinCharge4_Chargennummer
        '
        Me.vinCharge4_Chargennummer.Authorization.Right = "Bedienen"
        Me.vinCharge4_Chargennummer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Chargennummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge4_Chargennummer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Chargennummer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Chargennummer.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Chargennummer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Chargennummer.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge4_Chargennummer.LimitMax.Value = 6
        Me.vinCharge4_Chargennummer.Location = New System.Drawing.Point(248, 317)
        Me.vinCharge4_Chargennummer.Name = "vinCharge4_Chargennummer"
        Me.vinCharge4_Chargennummer.Size = New System.Drawing.Size(81, 30)
        Me.vinCharge4_Chargennummer.TabIndex = 115
        Me.vinCharge4_Chargennummer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge4_Chargennummer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge4_Chargennummer.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge4_Chargennummer.Unit.SizeRatio = 0.25
        Me.vinCharge4_Chargennummer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge4_Chargennummer.VWItem.Name = "SPS Ofen.Status.Charge4.Chargennummer"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Blue
        Me.Label15.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.LocalizedText.Text = "Länge:"
        Me.Label15.Location = New System.Drawing.Point(705, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 30)
        Me.Label15.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Blue
        Me.Label16.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.LocalizedText.Text = "Artikel:"
        Me.Label16.Location = New System.Drawing.Point(388, 317)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 30)
        Me.Label16.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Blue
        Me.Label17.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.LocalizedText.Text = "Charge 4:"
        Me.Label17.Location = New System.Drawing.Point(162, 317)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 30)
        Me.Label17.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Blue
        Me.Label18.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.LocalizedText.Text = "-"
        Me.Label18.Location = New System.Drawing.Point(329, 317)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 30)
        Me.Label18.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinCharge5_Laenge
        '
        Me.vinCharge5_Laenge.Authorization.Right = "Bedienen"
        Me.vinCharge5_Laenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Laenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge5_Laenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Laenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Laenge.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Laenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Laenge.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge5_Laenge.LimitMax.Value = 99999
        Me.vinCharge5_Laenge.Location = New System.Drawing.Point(778, 351)
        Me.vinCharge5_Laenge.Name = "vinCharge5_Laenge"
        Me.vinCharge5_Laenge.Size = New System.Drawing.Size(85, 30)
        Me.vinCharge5_Laenge.TabIndex = 130
        Me.vinCharge5_Laenge.Unit.BackColor = System.Drawing.Color.Blue
        Me.vinCharge5_Laenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Laenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vinCharge5_Laenge.Unit.ForeColor = System.Drawing.SystemColors.Window
        Me.vinCharge5_Laenge.Unit.SizeRatio = 0.25
        Me.vinCharge5_Laenge.Unit.Text.Text = "m"
        Me.vinCharge5_Laenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Laenge.VWItem.Name = "SPS Ofen.Status.Charge5.Laenge"
        '
        'vinCharge5_Artikel
        '
        Me.vinCharge5_Artikel.Authorization.Right = "Bedienen"
        Me.vinCharge5_Artikel.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge5_Artikel.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Artikel.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Artikel.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Artikel.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Artikel.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge5_Artikel.LimitMax.Value = 20
        Me.vinCharge5_Artikel.Location = New System.Drawing.Point(450, 351)
        Me.vinCharge5_Artikel.Name = "vinCharge5_Artikel"
        Me.vinCharge5_Artikel.Size = New System.Drawing.Size(241, 30)
        Me.vinCharge5_Artikel.TabIndex = 129
        Me.vinCharge5_Artikel.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Artikel.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Artikel.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Artikel.Unit.SizeRatio = 0.25
        Me.vinCharge5_Artikel.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Artikel.VWItem.Name = "SPS Ofen.Status.Charge5.Artikel"
        '
        'vinCharge5_Chargenindex
        '
        Me.vinCharge5_Chargenindex.Authorization.Right = "Bedienen"
        Me.vinCharge5_Chargenindex.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Chargenindex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge5_Chargenindex.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Chargenindex.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Chargenindex.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Chargenindex.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Chargenindex.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge5_Chargenindex.LimitMax.Value = 99
        Me.vinCharge5_Chargenindex.Location = New System.Drawing.Point(340, 351)
        Me.vinCharge5_Chargenindex.Name = "vinCharge5_Chargenindex"
        Me.vinCharge5_Chargenindex.Size = New System.Drawing.Size(30, 30)
        Me.vinCharge5_Chargenindex.TabIndex = 128
        Me.vinCharge5_Chargenindex.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Chargenindex.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Chargenindex.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Chargenindex.Unit.SizeRatio = 0.25
        Me.vinCharge5_Chargenindex.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Chargenindex.VWItem.Name = "SPS Ofen.Status.Charge5.Chargenindex"
        '
        'vinCharge5_Chargennummer
        '
        Me.vinCharge5_Chargennummer.Authorization.Right = "Bedienen"
        Me.vinCharge5_Chargennummer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Chargennummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinCharge5_Chargennummer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Chargennummer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Chargennummer.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Chargennummer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Chargennummer.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinCharge5_Chargennummer.LimitMax.Value = 6
        Me.vinCharge5_Chargennummer.Location = New System.Drawing.Point(248, 351)
        Me.vinCharge5_Chargennummer.Name = "vinCharge5_Chargennummer"
        Me.vinCharge5_Chargennummer.Size = New System.Drawing.Size(81, 30)
        Me.vinCharge5_Chargennummer.TabIndex = 127
        Me.vinCharge5_Chargennummer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinCharge5_Chargennummer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinCharge5_Chargennummer.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinCharge5_Chargennummer.Unit.SizeRatio = 0.25
        Me.vinCharge5_Chargennummer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinCharge5_Chargennummer.VWItem.Name = "SPS Ofen.Status.Charge5.Chargennummer"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Blue
        Me.Label19.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.LocalizedText.Text = "Länge:"
        Me.Label19.Location = New System.Drawing.Point(705, 351)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 30)
        Me.Label19.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Blue
        Me.Label20.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.LocalizedText.Text = "Artikel:"
        Me.Label20.Location = New System.Drawing.Point(388, 351)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 30)
        Me.Label20.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Blue
        Me.Label21.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.LocalizedText.Text = "Charge 5:"
        Me.Label21.Location = New System.Drawing.Point(162, 351)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 30)
        Me.Label21.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Blue
        Me.Label22.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.LocalizedText.Text = "-"
        Me.Label22.Location = New System.Drawing.Point(329, 351)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(12, 30)
        Me.Label22.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Blue
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(144, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(739, 310)
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.LocalizedText.Text = "Anfangstemperatur:"
        Me.Label26.Location = New System.Drawing.Point(144, 475)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 27)
        Me.Label26.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.LocalizedText.Text = "Abschnitt:"
        Me.Label27.Location = New System.Drawing.Point(144, 442)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(136, 27)
        Me.Label27.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Yellow
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.LocalizedText.Text = "Abschnitt Daten"
        Me.Label28.Location = New System.Drawing.Point(144, 408)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(262, 28)
        Me.Label28.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votAbschnitt_Nummer
        '
        Me.votAbschnitt_Nummer.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votAbschnitt_Nummer.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Nummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votAbschnitt_Nummer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votAbschnitt_Nummer.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Nummer.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votAbschnitt_Nummer.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Nummer.Location = New System.Drawing.Point(286, 442)
        Me.votAbschnitt_Nummer.Name = "votAbschnitt_Nummer"
        Me.votAbschnitt_Nummer.Size = New System.Drawing.Size(120, 27)
        Me.votAbschnitt_Nummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votAbschnitt_Nummer.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Nummer.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votAbschnitt_Nummer.Unit.SizeRatio = 0.25
        Me.votAbschnitt_Nummer.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Nummer.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Abschnitt"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.LocalizedText.Text = "Endtemperatur:"
        Me.Label29.Location = New System.Drawing.Point(144, 508)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 27)
        Me.Label29.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.LocalizedText.Text = "Regelabweichung:"
        Me.Label30.Location = New System.Drawing.Point(144, 541)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(136, 27)
        Me.Label30.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.LocalizedText.Text = "Düsenkanal:"
        Me.Label31.Location = New System.Drawing.Point(144, 574)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 27)
        Me.Label31.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votAbschnitt_Anfagstemperatur
        '
        Me.votAbschnitt_Anfagstemperatur.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votAbschnitt_Anfagstemperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Anfagstemperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votAbschnitt_Anfagstemperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Anfagstemperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votAbschnitt_Anfagstemperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Anfagstemperatur.Location = New System.Drawing.Point(286, 475)
        Me.votAbschnitt_Anfagstemperatur.Name = "votAbschnitt_Anfagstemperatur"
        Me.votAbschnitt_Anfagstemperatur.Size = New System.Drawing.Size(120, 27)
        Me.votAbschnitt_Anfagstemperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votAbschnitt_Anfagstemperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Anfagstemperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.votAbschnitt_Anfagstemperatur.Unit.SizeRatio = 0.25
        Me.votAbschnitt_Anfagstemperatur.Unit.Text.Text = "°C"
        Me.votAbschnitt_Anfagstemperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Anfagstemperatur.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.Start_Temperatur"
        '
        'votAbschnitt_Endtemperatur
        '
        Me.votAbschnitt_Endtemperatur.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votAbschnitt_Endtemperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Endtemperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votAbschnitt_Endtemperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Endtemperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votAbschnitt_Endtemperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Endtemperatur.Location = New System.Drawing.Point(286, 508)
        Me.votAbschnitt_Endtemperatur.Name = "votAbschnitt_Endtemperatur"
        Me.votAbschnitt_Endtemperatur.Size = New System.Drawing.Size(120, 27)
        Me.votAbschnitt_Endtemperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votAbschnitt_Endtemperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Endtemperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.votAbschnitt_Endtemperatur.Unit.SizeRatio = 0.25
        Me.votAbschnitt_Endtemperatur.Unit.Text.Text = "°C"
        Me.votAbschnitt_Endtemperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Endtemperatur.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.End_Temperatur"
        '
        'lblAbschnitt_Duesenkanal
        '
        Me.lblAbschnitt_Duesenkanal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblAbschnitt_Duesenkanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbschnitt_Duesenkanal.LocalizedText.TextGroup = "Textlisten.aus_ein"
        Me.lblAbschnitt_Duesenkanal.LocalizedText.TextPrefix = "aus_ein"
        Me.lblAbschnitt_Duesenkanal.LocalizedText.UseTextOn = False
        Me.lblAbschnitt_Duesenkanal.Location = New System.Drawing.Point(286, 574)
        Me.lblAbschnitt_Duesenkanal.Name = "lblAbschnitt_Duesenkanal"
        Me.lblAbschnitt_Duesenkanal.Size = New System.Drawing.Size(120, 27)
        Me.lblAbschnitt_Duesenkanal.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.VW_Duesenkanal"
        '
        'votAbschnitt_Regelabweichung
        '
        Me.votAbschnitt_Regelabweichung.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votAbschnitt_Regelabweichung.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Regelabweichung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votAbschnitt_Regelabweichung.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Regelabweichung.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votAbschnitt_Regelabweichung.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Regelabweichung.Location = New System.Drawing.Point(286, 541)
        Me.votAbschnitt_Regelabweichung.Name = "votAbschnitt_Regelabweichung"
        Me.votAbschnitt_Regelabweichung.Size = New System.Drawing.Size(120, 27)
        Me.votAbschnitt_Regelabweichung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votAbschnitt_Regelabweichung.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votAbschnitt_Regelabweichung.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.votAbschnitt_Regelabweichung.Unit.SizeRatio = 0.25
        Me.votAbschnitt_Regelabweichung.Unit.Text.Text = "°C"
        Me.votAbschnitt_Regelabweichung.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votAbschnitt_Regelabweichung.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.Regelabweichung"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Yellow
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.LocalizedText.Text = "Status Daten                 Soll                       Ist"
        Me.Label33.Location = New System.Drawing.Point(491, 408)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(392, 28)
        Me.Label33.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.LocalizedText.Text = "Temperatur:"
        Me.Label34.Location = New System.Drawing.Point(491, 442)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(136, 27)
        Me.Label34.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votStatus_SW_Temperatur
        '
        Me.votStatus_SW_Temperatur.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_SW_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_SW_Temperatur.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_SW_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Temperatur.Location = New System.Drawing.Point(634, 442)
        Me.votStatus_SW_Temperatur.Name = "votStatus_SW_Temperatur"
        Me.votStatus_SW_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.votStatus_SW_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_SW_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Temperatur.Unit.SizeRatio = 0.25
        Me.votStatus_SW_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Temperatur.VWItem.Name = "SPS Ofen.Arbeit_PC.Temperatur_Regler_Sollwert"
        '
        'votStatus_IW_Temeratur
        '
        Me.votStatus_IW_Temeratur.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Temeratur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Temeratur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Temeratur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Temeratur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Temeratur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Temeratur.Location = New System.Drawing.Point(763, 442)
        Me.votStatus_IW_Temeratur.Name = "votStatus_IW_Temeratur"
        Me.votStatus_IW_Temeratur.Size = New System.Drawing.Size(120, 27)
        Me.votStatus_IW_Temeratur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Temeratur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Temeratur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.votStatus_IW_Temeratur.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Temeratur.Unit.Text.Text = "°C"
        Me.votStatus_IW_Temeratur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Temeratur.VWItem.Name = "SPS Ofen.Arbeit.Temperatur_Regler_Istwert"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.LocalizedText.Text = "Laufzeit:"
        Me.Label35.Location = New System.Drawing.Point(491, 475)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(136, 27)
        Me.Label35.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votStatus_SW_Zeit_Std
        '
        Me.votStatus_SW_Zeit_Std.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_SW_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_SW_Zeit_Std.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_SW_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Zeit_Std.Location = New System.Drawing.Point(634, 475)
        Me.votStatus_SW_Zeit_Std.Name = "votStatus_SW_Zeit_Std"
        Me.votStatus_SW_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_SW_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_SW_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Zeit_Std.Unit.SizeRatio = 0.25
        Me.votStatus_SW_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Zeit_Std.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.Zeit_Std"
        '
        'votStatus_SW_Zeit_Min
        '
        Me.votStatus_SW_Zeit_Min.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_SW_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_SW_Zeit_Min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_SW_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Zeit_Min.Location = New System.Drawing.Point(677, 475)
        Me.votStatus_SW_Zeit_Min.Name = "votStatus_SW_Zeit_Min"
        Me.votStatus_SW_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_SW_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_SW_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Zeit_Min.Unit.SizeRatio = 0.25
        Me.votStatus_SW_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Zeit_Min.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.Zeit_Min"
        '
        'votStatus_SW_Zeit_Sek
        '
        Me.votStatus_SW_Zeit_Sek.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_SW_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_SW_Zeit_Sek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_SW_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Zeit_Sek.Location = New System.Drawing.Point(721, 475)
        Me.votStatus_SW_Zeit_Sek.Name = "votStatus_SW_Zeit_Sek"
        Me.votStatus_SW_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_SW_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_SW_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_SW_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_SW_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.votStatus_SW_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_SW_Zeit_Sek.VWItem.Name = "SPS Ofen.Arbeit.Status_SW.Zeit_Sek"
        '
        'Label36
        '
        Me.Label36.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.LocalizedText.Text = ":"
        Me.Label36.Location = New System.Drawing.Point(712, 475)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(10, 24)
        Me.Label36.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.LocalizedText.Text = ":"
        Me.Label37.Location = New System.Drawing.Point(668, 476)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(10, 24)
        Me.Label37.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.LocalizedText.Text = ":"
        Me.Label38.Location = New System.Drawing.Point(841, 475)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(10, 24)
        Me.Label38.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.LocalizedText.Text = ":"
        Me.Label39.Location = New System.Drawing.Point(797, 476)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(10, 24)
        Me.Label39.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vot_Status_IW_Zeit_Sek
        '
        Me.vot_Status_IW_Zeit_Sek.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.vot_Status_IW_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vot_Status_IW_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vot_Status_IW_Zeit_Sek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vot_Status_IW_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vot_Status_IW_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vot_Status_IW_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vot_Status_IW_Zeit_Sek.Location = New System.Drawing.Point(850, 475)
        Me.vot_Status_IW_Zeit_Sek.Name = "vot_Status_IW_Zeit_Sek"
        Me.vot_Status_IW_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vot_Status_IW_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vot_Status_IW_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vot_Status_IW_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vot_Status_IW_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vot_Status_IW_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vot_Status_IW_Zeit_Sek.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Zeit_Sek"
        '
        'votStatus_IW_Zeit_Min
        '
        Me.votStatus_IW_Zeit_Min.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Zeit_Min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_IW_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Zeit_Min.Location = New System.Drawing.Point(806, 475)
        Me.votStatus_IW_Zeit_Min.Name = "votStatus_IW_Zeit_Min"
        Me.votStatus_IW_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_IW_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Zeit_Min.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Zeit_Min.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Zeit_Min"
        '
        'votStatus_IW_Zeit_Std
        '
        Me.votStatus_IW_Zeit_Std.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Zeit_Std.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_IW_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Zeit_Std.Location = New System.Drawing.Point(763, 475)
        Me.votStatus_IW_Zeit_Std.Name = "votStatus_IW_Zeit_Std"
        Me.votStatus_IW_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_IW_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Zeit_Std.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Zeit_Std.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Zeit_Std"
        '
        'votStatus_IW_Zuluftmenge
        '
        Me.votStatus_IW_Zuluftmenge.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Zuluftmenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zuluftmenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Zuluftmenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zuluftmenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Zuluftmenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Zuluftmenge.Location = New System.Drawing.Point(763, 541)
        Me.votStatus_IW_Zuluftmenge.Name = "votStatus_IW_Zuluftmenge"
        Me.votStatus_IW_Zuluftmenge.Size = New System.Drawing.Size(120, 27)
        Me.votStatus_IW_Zuluftmenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Zuluftmenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Zuluftmenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.votStatus_IW_Zuluftmenge.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Zuluftmenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Zuluftmenge.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Zuluftmenge"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.LocalizedText.Text = "Zuluftmenge:"
        Me.Label24.Location = New System.Drawing.Point(491, 541)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(136, 27)
        Me.Label24.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votStatus_IW_Abluftmenge
        '
        Me.votStatus_IW_Abluftmenge.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Abluftmenge.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Abluftmenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Abluftmenge.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Abluftmenge.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Abluftmenge.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Abluftmenge.Location = New System.Drawing.Point(763, 574)
        Me.votStatus_IW_Abluftmenge.Name = "votStatus_IW_Abluftmenge"
        Me.votStatus_IW_Abluftmenge.Size = New System.Drawing.Size(120, 27)
        Me.votStatus_IW_Abluftmenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Abluftmenge.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Abluftmenge.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.votStatus_IW_Abluftmenge.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Abluftmenge.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Abluftmenge.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Abluftmenge"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.LocalizedText.Text = "Abluftmenge:"
        Me.Label25.Location = New System.Drawing.Point(491, 574)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 27)
        Me.Label25.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'isvProgramm_Status
        '
        Me.isvProgramm_Status.VWItem.Name = "SPS Ofen.Arbeit_PC.Programm_Status"
        '
        'keyProgramm_Neustart
        '
        Me.keyProgramm_Neustart.Authorization.Right = "Bedienen"
        Me.keyProgramm_Neustart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyProgramm_Neustart.LocalizedText.Text = "Neustart"
        Me.keyProgramm_Neustart.Location = New System.Drawing.Point(918, 112)
        Me.keyProgramm_Neustart.Name = "keyProgramm_Neustart"
        Me.keyProgramm_Neustart.SetMode = VisiWinNET.Forms.SetMode.BitOn
        Me.keyProgramm_Neustart.Size = New System.Drawing.Size(82, 56)
        Me.keyProgramm_Neustart.TabIndex = 1074
        Me.keyProgramm_Neustart.VWItem.BitNumber = 9
        Me.keyProgramm_Neustart.VWItem.Name = "SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC"
        '
        'keyProgramm_Stop
        '
        Me.keyProgramm_Stop.Authorization.Right = "Bedienen"
        Me.keyProgramm_Stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyProgramm_Stop.LocalizedText.Text = "Stop"
        Me.keyProgramm_Stop.Location = New System.Drawing.Point(918, 192)
        Me.keyProgramm_Stop.Name = "keyProgramm_Stop"
        Me.keyProgramm_Stop.SetMode = VisiWinNET.Forms.SetMode.BitOn
        Me.keyProgramm_Stop.Size = New System.Drawing.Size(82, 56)
        Me.keyProgramm_Stop.TabIndex = 1075
        Me.keyProgramm_Stop.VWItem.BitNumber = 10
        Me.keyProgramm_Stop.VWItem.Name = "SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC"
        '
        'keyProgramm_Ende
        '
        Me.keyProgramm_Ende.Authorization.Right = "Bedienen"
        Me.keyProgramm_Ende.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyProgramm_Ende.LocalizedText.Text = "Ende"
        Me.keyProgramm_Ende.Location = New System.Drawing.Point(29, 192)
        Me.keyProgramm_Ende.Name = "keyProgramm_Ende"
        Me.keyProgramm_Ende.SetMode = VisiWinNET.Forms.SetMode.BitOn
        Me.keyProgramm_Ende.Size = New System.Drawing.Size(82, 56)
        Me.keyProgramm_Ende.TabIndex = 1076
        Me.keyProgramm_Ende.VWItem.BitNumber = 11
        Me.keyProgramm_Ende.VWItem.Name = "SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC"
        '
        'cmdProgramm_Start
        '
        Me.cmdProgramm_Start.Authorization.Right = "Bedienen"
        Me.cmdProgramm_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProgramm_Start.LocalizedText.Text = "Start"
        Me.cmdProgramm_Start.Location = New System.Drawing.Point(29, 112)
        Me.cmdProgramm_Start.Name = "cmdProgramm_Start"
        Me.cmdProgramm_Start.Size = New System.Drawing.Size(82, 56)
        Me.cmdProgramm_Start.TabIndex = 1136
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.LocalizedText.Text = "Restlaufzeit:"
        Me.Label40.Location = New System.Drawing.Point(491, 508)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(136, 27)
        Me.Label40.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'votStatus_IW_Restzeit_Std
        '
        Me.votStatus_IW_Restzeit_Std.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Restzeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Restzeit_Std.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_IW_Restzeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Restzeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Restzeit_Std.Location = New System.Drawing.Point(763, 508)
        Me.votStatus_IW_Restzeit_Std.Name = "votStatus_IW_Restzeit_Std"
        Me.votStatus_IW_Restzeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_IW_Restzeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Restzeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Restzeit_Std.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Restzeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Restzeit_Std.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Restzeit_Std"
        '
        'votStatus_IW_Restzeit_Min
        '
        Me.votStatus_IW_Restzeit_Min.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Restzeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Restzeit_Min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_IW_Restzeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Restzeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Restzeit_Min.Location = New System.Drawing.Point(806, 508)
        Me.votStatus_IW_Restzeit_Min.Name = "votStatus_IW_Restzeit_Min"
        Me.votStatus_IW_Restzeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_IW_Restzeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Restzeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Restzeit_Min.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Restzeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Restzeit_Min.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Restzeit_Min"
        '
        'votStatus_IW_Restzeit_Sek
        '
        Me.votStatus_IW_Restzeit_Sek.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votStatus_IW_Restzeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votStatus_IW_Restzeit_Sek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.votStatus_IW_Restzeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Restzeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Restzeit_Sek.Location = New System.Drawing.Point(850, 508)
        Me.votStatus_IW_Restzeit_Sek.Name = "votStatus_IW_Restzeit_Sek"
        Me.votStatus_IW_Restzeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.votStatus_IW_Restzeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.votStatus_IW_Restzeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votStatus_IW_Restzeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votStatus_IW_Restzeit_Sek.Unit.SizeRatio = 0.25
        Me.votStatus_IW_Restzeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votStatus_IW_Restzeit_Sek.VWItem.Name = "SPS Ofen.Arbeit.Status_IW.Restzeit_Sek"
        '
        'Label42
        '
        Me.Label42.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.LocalizedText.Text = ":"
        Me.Label42.Location = New System.Drawing.Point(797, 509)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(10, 24)
        Me.Label42.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.LocalizedText.Text = ":"
        Me.Label41.Location = New System.Drawing.Point(841, 508)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(10, 24)
        Me.Label41.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'FStatus_Daten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.votStatus_IW_Restzeit_Sek)
        Me.Controls.Add(Me.votStatus_IW_Restzeit_Min)
        Me.Controls.Add(Me.votStatus_IW_Restzeit_Std)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.cmdProgramm_Start)
        Me.Controls.Add(Me.keyProgramm_Ende)
        Me.Controls.Add(Me.keyProgramm_Stop)
        Me.Controls.Add(Me.keyProgramm_Neustart)
        Me.Controls.Add(Me.votStatus_IW_Abluftmenge)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.votStatus_IW_Zuluftmenge)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.vot_Status_IW_Zeit_Sek)
        Me.Controls.Add(Me.votStatus_IW_Zeit_Min)
        Me.Controls.Add(Me.votStatus_IW_Zeit_Std)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.votStatus_SW_Zeit_Sek)
        Me.Controls.Add(Me.votStatus_SW_Zeit_Min)
        Me.Controls.Add(Me.votStatus_SW_Zeit_Std)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.votStatus_IW_Temeratur)
        Me.Controls.Add(Me.votStatus_SW_Temperatur)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.votAbschnitt_Regelabweichung)
        Me.Controls.Add(Me.lblAbschnitt_Duesenkanal)
        Me.Controls.Add(Me.votAbschnitt_Endtemperatur)
        Me.Controls.Add(Me.votAbschnitt_Anfagstemperatur)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.votAbschnitt_Nummer)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.vinCharge5_Laenge)
        Me.Controls.Add(Me.vinCharge5_Artikel)
        Me.Controls.Add(Me.vinCharge5_Chargenindex)
        Me.Controls.Add(Me.vinCharge5_Chargennummer)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.vinCharge4_Laenge)
        Me.Controls.Add(Me.vinCharge4_Artikel)
        Me.Controls.Add(Me.vinCharge4_Chargenindex)
        Me.Controls.Add(Me.vinCharge4_Chargennummer)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.vinCharge3_Laenge)
        Me.Controls.Add(Me.vinCharge3_Artikel)
        Me.Controls.Add(Me.vinCharge3_Chargenindex)
        Me.Controls.Add(Me.vinCharge3_Chargennummer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.vinCharge2_Laenge)
        Me.Controls.Add(Me.vinCharge2_Artikel)
        Me.Controls.Add(Me.vinCharge2_Chargenindex)
        Me.Controls.Add(Me.vinCharge2_Chargennummer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.vinCharge1_Laenge)
        Me.Controls.Add(Me.vinCharge1_Artikel)
        Me.Controls.Add(Me.vinCharge1_Chargenindex)
        Me.Controls.Add(Me.vinCharge1_Chargennummer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdRezept_laden)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.votRezept_Beschreibung)
        Me.Controls.Add(Me.votRezept_Name)
        Me.Controls.Add(Me.lblProgramm_Status)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label23)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FStatus_Daten"
        Me.Text = "FStatus_Daten"
        Me.Controls.SetChildIndex(Me.Label23, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.lblProgramm_Status, 0)
        Me.Controls.SetChildIndex(Me.votRezept_Name, 0)
        Me.Controls.SetChildIndex(Me.votRezept_Beschreibung, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.cmdRezept_laden, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.vinCharge1_Chargennummer, 0)
        Me.Controls.SetChildIndex(Me.vinCharge1_Chargenindex, 0)
        Me.Controls.SetChildIndex(Me.vinCharge1_Artikel, 0)
        Me.Controls.SetChildIndex(Me.vinCharge1_Laenge, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.vinCharge2_Chargennummer, 0)
        Me.Controls.SetChildIndex(Me.vinCharge2_Chargenindex, 0)
        Me.Controls.SetChildIndex(Me.vinCharge2_Artikel, 0)
        Me.Controls.SetChildIndex(Me.vinCharge2_Laenge, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.vinCharge3_Chargennummer, 0)
        Me.Controls.SetChildIndex(Me.vinCharge3_Chargenindex, 0)
        Me.Controls.SetChildIndex(Me.vinCharge3_Artikel, 0)
        Me.Controls.SetChildIndex(Me.vinCharge3_Laenge, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.vinCharge4_Chargennummer, 0)
        Me.Controls.SetChildIndex(Me.vinCharge4_Chargenindex, 0)
        Me.Controls.SetChildIndex(Me.vinCharge4_Artikel, 0)
        Me.Controls.SetChildIndex(Me.vinCharge4_Laenge, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.vinCharge5_Chargennummer, 0)
        Me.Controls.SetChildIndex(Me.vinCharge5_Chargenindex, 0)
        Me.Controls.SetChildIndex(Me.vinCharge5_Artikel, 0)
        Me.Controls.SetChildIndex(Me.vinCharge5_Laenge, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.votAbschnitt_Nummer, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.Label31, 0)
        Me.Controls.SetChildIndex(Me.votAbschnitt_Anfagstemperatur, 0)
        Me.Controls.SetChildIndex(Me.votAbschnitt_Endtemperatur, 0)
        Me.Controls.SetChildIndex(Me.lblAbschnitt_Duesenkanal, 0)
        Me.Controls.SetChildIndex(Me.votAbschnitt_Regelabweichung, 0)
        Me.Controls.SetChildIndex(Me.Label33, 0)
        Me.Controls.SetChildIndex(Me.Label34, 0)
        Me.Controls.SetChildIndex(Me.votStatus_SW_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Temeratur, 0)
        Me.Controls.SetChildIndex(Me.Label35, 0)
        Me.Controls.SetChildIndex(Me.votStatus_SW_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.votStatus_SW_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.votStatus_SW_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label37, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vot_Status_IW_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label39, 0)
        Me.Controls.SetChildIndex(Me.Label38, 0)
        Me.Controls.SetChildIndex(Me.Label24, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Zuluftmenge, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Abluftmenge, 0)
        Me.Controls.SetChildIndex(Me.keyProgramm_Neustart, 0)
        Me.Controls.SetChildIndex(Me.keyProgramm_Stop, 0)
        Me.Controls.SetChildIndex(Me.keyProgramm_Ende, 0)
        Me.Controls.SetChildIndex(Me.cmdProgramm_Start, 0)
        Me.Controls.SetChildIndex(Me.Label40, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Restzeit_Std, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Restzeit_Min, 0)
        Me.Controls.SetChildIndex(Me.votStatus_IW_Restzeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label42, 0)
        Me.Controls.SetChildIndex(Me.Label41, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProgramm_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votRezept_Beschreibung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votRezept_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRezept_laden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge1_Chargennummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge1_Chargenindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge1_Artikel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge1_Laenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge2_Laenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge2_Artikel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge2_Chargenindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge2_Chargennummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge3_Laenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge3_Artikel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge3_Chargenindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge3_Chargennummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge4_Laenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge4_Artikel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge4_Chargenindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge4_Chargennummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge5_Laenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge5_Artikel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge5_Chargenindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinCharge5_Chargennummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votAbschnitt_Nummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votAbschnitt_Anfagstemperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votAbschnitt_Endtemperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAbschnitt_Duesenkanal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votAbschnitt_Regelabweichung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_SW_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Temeratur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_SW_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_SW_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_SW_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vot_Status_IW_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Zuluftmenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Abluftmenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isvProgramm_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyProgramm_Neustart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyProgramm_Stop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyProgramm_Ende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdProgramm_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Restzeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Restzeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votStatus_IW_Restzeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents lblProgramm_Status As VisiWinNET.Forms.Label
    Friend WithEvents votRezept_Beschreibung As VisiWinNET.Forms.VarOut
    Friend WithEvents votRezept_Name As VisiWinNET.Forms.VarOut
    Friend WithEvents Label7 As VisiWinNET.Forms.Label
    Friend WithEvents Label6 As VisiWinNET.Forms.Label
    Friend WithEvents cmdRezept_laden As VisiWinNET.Forms.CommandButton
    Friend WithEvents Label1 As VisiWinNET.Forms.Label
    Friend WithEvents Label2 As VisiWinNET.Forms.Label
    Friend WithEvents Label3 As VisiWinNET.Forms.Label
    Friend WithEvents vinCharge1_Chargennummer As VisiWinNET.Forms.VarIn
    Friend WithEvents Label4 As VisiWinNET.Forms.Label
    Friend WithEvents vinCharge1_Chargenindex As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge1_Artikel As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge1_Laenge As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge2_Laenge As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge2_Artikel As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge2_Chargenindex As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge2_Chargennummer As VisiWinNET.Forms.VarIn
    Friend WithEvents Label5 As VisiWinNET.Forms.Label
    Friend WithEvents Label8 As VisiWinNET.Forms.Label
    Friend WithEvents Label9 As VisiWinNET.Forms.Label
    Friend WithEvents Label10 As VisiWinNET.Forms.Label
    Friend WithEvents vinCharge3_Laenge As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge3_Artikel As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge3_Chargenindex As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge3_Chargennummer As VisiWinNET.Forms.VarIn
    Friend WithEvents Label11 As VisiWinNET.Forms.Label
    Friend WithEvents Label12 As VisiWinNET.Forms.Label
    Friend WithEvents Label13 As VisiWinNET.Forms.Label
    Friend WithEvents Label14 As VisiWinNET.Forms.Label
    Friend WithEvents vinCharge4_Laenge As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge4_Artikel As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge4_Chargenindex As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge4_Chargennummer As VisiWinNET.Forms.VarIn
    Friend WithEvents Label15 As VisiWinNET.Forms.Label
    Friend WithEvents Label16 As VisiWinNET.Forms.Label
    Friend WithEvents Label17 As VisiWinNET.Forms.Label
    Friend WithEvents Label18 As VisiWinNET.Forms.Label
    Friend WithEvents vinCharge5_Laenge As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge5_Artikel As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge5_Chargenindex As VisiWinNET.Forms.VarIn
    Friend WithEvents vinCharge5_Chargennummer As VisiWinNET.Forms.VarIn
    Friend WithEvents Label19 As VisiWinNET.Forms.Label
    Friend WithEvents Label20 As VisiWinNET.Forms.Label
    Friend WithEvents Label21 As VisiWinNET.Forms.Label
    Friend WithEvents Label22 As VisiWinNET.Forms.Label
    Friend WithEvents Label23 As VisiWinNET.Forms.Label
    Friend WithEvents Label26 As VisiWinNET.Forms.Label
    Friend WithEvents Label27 As VisiWinNET.Forms.Label
    Friend WithEvents Label28 As VisiWinNET.Forms.Label
    Friend WithEvents votAbschnitt_Nummer As VisiWinNET.Forms.VarOut
    Friend WithEvents Label29 As VisiWinNET.Forms.Label
    Friend WithEvents Label30 As VisiWinNET.Forms.Label
    Friend WithEvents Label31 As VisiWinNET.Forms.Label
    Friend WithEvents votAbschnitt_Anfagstemperatur As VisiWinNET.Forms.VarOut
    Friend WithEvents votAbschnitt_Endtemperatur As VisiWinNET.Forms.VarOut
    Friend WithEvents lblAbschnitt_Duesenkanal As VisiWinNET.Forms.Label
    Friend WithEvents votAbschnitt_Regelabweichung As VisiWinNET.Forms.VarOut
    Friend WithEvents Label33 As VisiWinNET.Forms.Label
    Friend WithEvents Label34 As VisiWinNET.Forms.Label
    Friend WithEvents votStatus_SW_Temperatur As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_IW_Temeratur As VisiWinNET.Forms.VarOut
    Friend WithEvents Label35 As VisiWinNET.Forms.Label
    Friend WithEvents votStatus_SW_Zeit_Std As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_SW_Zeit_Min As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_SW_Zeit_Sek As VisiWinNET.Forms.VarOut
    Friend WithEvents Label36 As VisiWinNET.Forms.Label
    Friend WithEvents Label37 As VisiWinNET.Forms.Label
    Friend WithEvents Label38 As VisiWinNET.Forms.Label
    Friend WithEvents Label39 As VisiWinNET.Forms.Label
    Friend WithEvents vot_Status_IW_Zeit_Sek As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_IW_Zeit_Min As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_IW_Zeit_Std As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_IW_Zuluftmenge As VisiWinNET.Forms.VarOut
    Friend WithEvents Label24 As VisiWinNET.Forms.Label
    Friend WithEvents votStatus_IW_Abluftmenge As VisiWinNET.Forms.VarOut
    Friend WithEvents Label25 As VisiWinNET.Forms.Label
    Friend WithEvents isvProgramm_Status As VisiWinNET.Forms.ItemServer
    Friend WithEvents keyProgramm_Neustart As VisiWinNET.Forms.Key
    Friend WithEvents keyProgramm_Stop As VisiWinNET.Forms.Key
    Friend WithEvents keyProgramm_Ende As VisiWinNET.Forms.Key
    Friend WithEvents cmdProgramm_Start As VisiWinNET.Forms.CommandButton
    Friend WithEvents Label40 As VisiWinNET.Forms.Label
    Friend WithEvents votStatus_IW_Restzeit_Std As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_IW_Restzeit_Min As VisiWinNET.Forms.VarOut
    Friend WithEvents votStatus_IW_Restzeit_Sek As VisiWinNET.Forms.VarOut
    Friend WithEvents Label42 As VisiWinNET.Forms.Label
    Friend WithEvents Label41 As VisiWinNET.Forms.Label
End Class
