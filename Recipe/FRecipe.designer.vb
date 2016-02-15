<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRecipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRecipe))
        Me.lblUeberschrift = New VisiWinNET.Forms.Label
        Me.Label3 = New VisiWinNET.Forms.Label
        Me.Label4 = New VisiWinNET.Forms.Label
        Me.vaiAbschnitt01_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label5 = New VisiWinNET.Forms.Label
        Me.vaiAbschnitt01_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.vaiAbschnitt01_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.VarIn1 = New VisiWinNET.Forms.VarIn
        Me.Label1 = New VisiWinNET.Forms.Label
        Me.Label2 = New VisiWinNET.Forms.Label
        Me.cmdRezept_laden = New VisiWinNET.Forms.CommandButton
        Me.cmdRezept_speichern = New VisiWinNET.Forms.CommandButton
        Me.Label6 = New VisiWinNET.Forms.Label
        Me.Label7 = New VisiWinNET.Forms.Label
        Me.Label8 = New VisiWinNET.Forms.Label
        Me.votRezept_Name = New VisiWinNET.Forms.VarOut
        Me.votRezept_Beschreibung = New VisiWinNET.Forms.VarOut
        Me.vinAbschnitt02_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt02_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt02_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label9 = New VisiWinNET.Forms.Label
        Me.Label10 = New VisiWinNET.Forms.Label
        Me.Label11 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt02_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label12 = New VisiWinNET.Forms.Label
        Me.Label13 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt03_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt03_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt03_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label14 = New VisiWinNET.Forms.Label
        Me.Label15 = New VisiWinNET.Forms.Label
        Me.Label16 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt03_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label17 = New VisiWinNET.Forms.Label
        Me.Label18 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt04_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt04_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt04_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label19 = New VisiWinNET.Forms.Label
        Me.Label20 = New VisiWinNET.Forms.Label
        Me.Label21 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt04_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label22 = New VisiWinNET.Forms.Label
        Me.Label23 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt05_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt05_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt05__Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label24 = New VisiWinNET.Forms.Label
        Me.Label25 = New VisiWinNET.Forms.Label
        Me.Label26 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt05_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label27 = New VisiWinNET.Forms.Label
        Me.Label28 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt06_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt06_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt06_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label29 = New VisiWinNET.Forms.Label
        Me.Label30 = New VisiWinNET.Forms.Label
        Me.Label31 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt06_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label32 = New VisiWinNET.Forms.Label
        Me.Label33 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt07_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt07_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt07_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label34 = New VisiWinNET.Forms.Label
        Me.Label35 = New VisiWinNET.Forms.Label
        Me.Label36 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt07_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label37 = New VisiWinNET.Forms.Label
        Me.Label38 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt08_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt08_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt08_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label39 = New VisiWinNET.Forms.Label
        Me.Label40 = New VisiWinNET.Forms.Label
        Me.Label41 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt08_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label42 = New VisiWinNET.Forms.Label
        Me.Label43 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt09_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt09_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt09_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label44 = New VisiWinNET.Forms.Label
        Me.Label45 = New VisiWinNET.Forms.Label
        Me.Label46 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt09_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label47 = New VisiWinNET.Forms.Label
        Me.Label48 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt10_Zeit_Sek = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt10_Zeit_Min = New VisiWinNET.Forms.VarIn
        Me.vinAbschnitt10_Zeit_Std = New VisiWinNET.Forms.VarIn
        Me.Label49 = New VisiWinNET.Forms.Label
        Me.Label50 = New VisiWinNET.Forms.Label
        Me.Label51 = New VisiWinNET.Forms.Label
        Me.vinAbschnitt10_Temperatur = New VisiWinNET.Forms.VarIn
        Me.Label52 = New VisiWinNET.Forms.Label
        Me.Label53 = New VisiWinNET.Forms.Label
        Me.Label56 = New VisiWinNET.Forms.Label
        Me.Label57 = New VisiWinNET.Forms.Label
        Me.vinRegelabweichung = New VisiWinNET.Forms.VarIn
        Me.Label58 = New VisiWinNET.Forms.Label
        Me.cmbVW_Duesenkanal = New VisiWinNET.Forms.ComboBox
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaiAbschnitt01_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaiAbschnitt01_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaiAbschnitt01_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarIn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRezept_laden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRezept_speichern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votRezept_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.votRezept_Beschreibung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt02_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt02_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt02_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt02_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt03_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt03_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt03_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt03_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt04_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt04_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt04_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt04_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt05_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt05_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt05__Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt05_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt06_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt06_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt06_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt06_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt07_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt07_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt07_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt07_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt08_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt08_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt08_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt08_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt09_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt09_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt09_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt09_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt10_Zeit_Sek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt10_Zeit_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt10_Zeit_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinAbschnitt10_Temperatur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vinRegelabweichung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVW_Duesenkanal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUeberschrift
        '
        Me.lblUeberschrift.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.lblUeberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschrift.LocalizedText.Text = "Programme"
        Me.lblUeberschrift.Location = New System.Drawing.Point(209, 18)
        Me.lblUeberschrift.Name = "lblUeberschrift"
        Me.lblUeberschrift.Size = New System.Drawing.Size(587, 37)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.LocalizedText.Text = "Abschnitt 01              Soll"
        Me.Label3.Location = New System.Drawing.Point(36, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 28)
        Me.Label3.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.LocalizedText.Text = "Temperatur:"
        Me.Label4.Location = New System.Drawing.Point(36, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 27)
        Me.Label4.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vaiAbschnitt01_Temperatur
        '
        Me.vaiAbschnitt01_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vaiAbschnitt01_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiAbschnitt01_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vaiAbschnitt01_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiAbschnitt01_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiAbschnitt01_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vaiAbschnitt01_Temperatur.LimitMax.Value = 280
        Me.vaiAbschnitt01_Temperatur.Location = New System.Drawing.Point(178, 269)
        Me.vaiAbschnitt01_Temperatur.Name = "vaiAbschnitt01_Temperatur"
        Me.vaiAbschnitt01_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vaiAbschnitt01_Temperatur.TabIndex = 1
        Me.vaiAbschnitt01_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vaiAbschnitt01_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vaiAbschnitt01_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiAbschnitt01_Temperatur.Unit.SizeRatio = 0.25
        Me.vaiAbschnitt01_Temperatur.Unit.Text.Text = "°C"
        Me.vaiAbschnitt01_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiAbschnitt01_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt01.Temperatur"
        Me.vaiAbschnitt01_Temperatur.VWItem.RecipeMember = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.LocalizedText.Text = "Zeit:"
        Me.Label5.Location = New System.Drawing.Point(36, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 27)
        Me.Label5.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vaiAbschnitt01_Zeit_Std
        '
        Me.vaiAbschnitt01_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vaiAbschnitt01_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiAbschnitt01_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vaiAbschnitt01_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiAbschnitt01_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiAbschnitt01_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vaiAbschnitt01_Zeit_Std.LimitMax.Value = 99
        Me.vaiAbschnitt01_Zeit_Std.Location = New System.Drawing.Point(178, 302)
        Me.vaiAbschnitt01_Zeit_Std.Name = "vaiAbschnitt01_Zeit_Std"
        Me.vaiAbschnitt01_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vaiAbschnitt01_Zeit_Std.TabIndex = 2
        Me.vaiAbschnitt01_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vaiAbschnitt01_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vaiAbschnitt01_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiAbschnitt01_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vaiAbschnitt01_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiAbschnitt01_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt01.Zeit_Std"
        Me.vaiAbschnitt01_Zeit_Std.VWItem.RecipeMember = True
        '
        'vaiAbschnitt01_Zeit_Min
        '
        Me.vaiAbschnitt01_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vaiAbschnitt01_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaiAbschnitt01_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vaiAbschnitt01_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiAbschnitt01_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiAbschnitt01_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vaiAbschnitt01_Zeit_Min.LimitMax.Value = 59
        Me.vaiAbschnitt01_Zeit_Min.Location = New System.Drawing.Point(221, 302)
        Me.vaiAbschnitt01_Zeit_Min.Name = "vaiAbschnitt01_Zeit_Min"
        Me.vaiAbschnitt01_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vaiAbschnitt01_Zeit_Min.TabIndex = 3
        Me.vaiAbschnitt01_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vaiAbschnitt01_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vaiAbschnitt01_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vaiAbschnitt01_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vaiAbschnitt01_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vaiAbschnitt01_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vaiAbschnitt01_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt01.Zeit_Min"
        Me.vaiAbschnitt01_Zeit_Min.VWItem.RecipeMember = True
        '
        'VarIn1
        '
        Me.VarIn1.Authorization.Right = "Programmänderungen"
        Me.VarIn1.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.VarIn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VarIn1.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.VarIn1.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.VarIn1.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.VarIn1.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.VarIn1.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.VarIn1.LimitMax.Value = 59
        Me.VarIn1.Location = New System.Drawing.Point(265, 302)
        Me.VarIn1.Name = "VarIn1"
        Me.VarIn1.Size = New System.Drawing.Size(33, 27)
        Me.VarIn1.TabIndex = 4
        Me.VarIn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VarIn1.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.VarIn1.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.VarIn1.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.VarIn1.Unit.SizeRatio = 0.25
        Me.VarIn1.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.VarIn1.VWItem.Name = "SPS Ofen.Rezept.Abschnitt01.Zeit_Sek"
        Me.VarIn1.VWItem.RecipeMember = True
        '
        'Label1
        '
        Me.Label1.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.LocalizedText.Text = ":"
        Me.Label1.Location = New System.Drawing.Point(212, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 24)
        Me.Label1.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.LocalizedText.Text = ":"
        Me.Label2.Location = New System.Drawing.Point(256, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 24)
        Me.Label2.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'cmdRezept_laden
        '
        Me.cmdRezept_laden.Authorization.Right = "Bedienen"
        Me.cmdRezept_laden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRezept_laden.LocalizedText.Text = "laden"
        Me.cmdRezept_laden.Location = New System.Drawing.Point(680, 113)
        Me.cmdRezept_laden.Name = "cmdRezept_laden"
        Me.cmdRezept_laden.Size = New System.Drawing.Size(87, 40)
        Me.cmdRezept_laden.TabIndex = 54
        '
        'cmdRezept_speichern
        '
        Me.cmdRezept_speichern.Authorization.Right = "Programmänderungen"
        Me.cmdRezept_speichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRezept_speichern.LocalizedText.Text = "speichern"
        Me.cmdRezept_speichern.Location = New System.Drawing.Point(680, 163)
        Me.cmdRezept_speichern.Name = "cmdRezept_speichern"
        Me.cmdRezept_speichern.Size = New System.Drawing.Size(87, 40)
        Me.cmdRezept_speichern.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.LocalizedText.Text = "Programm:"
        Me.Label6.Location = New System.Drawing.Point(235, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 31)
        Me.Label6.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.LocalizedText.Text = "Beschreibung:"
        Me.Label7.Location = New System.Drawing.Point(235, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 31)
        Me.Label7.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(577, 109)
        '
        'votRezept_Name
        '
        Me.votRezept_Name.BackColor = System.Drawing.SystemColors.Control
        Me.votRezept_Name.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votRezept_Name.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votRezept_Name.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Name.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Name.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Name.Location = New System.Drawing.Point(390, 122)
        Me.votRezept_Name.Name = "votRezept_Name"
        Me.votRezept_Name.Size = New System.Drawing.Size(246, 31)
        Me.votRezept_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Name.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Name.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Name.Unit.SizeRatio = 0.25
        Me.votRezept_Name.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Name.VWItem.Name = "SPS Ofen.Rezept.Rezept_Name"
        '
        'votRezept_Beschreibung
        '
        Me.votRezept_Beschreibung.BackColor = System.Drawing.SystemColors.Control
        Me.votRezept_Beschreibung.DataBackColor = System.Drawing.SystemColors.ControlDark
        Me.votRezept_Beschreibung.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Beschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votRezept_Beschreibung.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Beschreibung.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Beschreibung.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Beschreibung.Location = New System.Drawing.Point(390, 159)
        Me.votRezept_Beschreibung.Name = "votRezept_Beschreibung"
        Me.votRezept_Beschreibung.Size = New System.Drawing.Size(246, 35)
        Me.votRezept_Beschreibung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Beschreibung.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.votRezept_Beschreibung.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.votRezept_Beschreibung.Unit.SizeRatio = 0.25
        Me.votRezept_Beschreibung.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.votRezept_Beschreibung.VWItem.Name = "SPS Ofen.Rezept.Rezept_Beschreibung"
        '
        'vinAbschnitt02_Zeit_Sek
        '
        Me.vinAbschnitt02_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt02_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt02_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt02_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt02_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt02_Zeit_Sek.Location = New System.Drawing.Point(265, 415)
        Me.vinAbschnitt02_Zeit_Sek.Name = "vinAbschnitt02_Zeit_Sek"
        Me.vinAbschnitt02_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt02_Zeit_Sek.TabIndex = 8
        Me.vinAbschnitt02_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt02_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt02_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt02_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt02.Zeit_Sek"
        Me.vinAbschnitt02_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt02_Zeit_Min
        '
        Me.vinAbschnitt02_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt02_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt02_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt02_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt02_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt02_Zeit_Min.Location = New System.Drawing.Point(221, 415)
        Me.vinAbschnitt02_Zeit_Min.Name = "vinAbschnitt02_Zeit_Min"
        Me.vinAbschnitt02_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt02_Zeit_Min.TabIndex = 7
        Me.vinAbschnitt02_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt02_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt02_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt02_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt02.Zeit_Min"
        Me.vinAbschnitt02_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt02_Zeit_Std
        '
        Me.vinAbschnitt02_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt02_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt02_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt02_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt02_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt02_Zeit_Std.Location = New System.Drawing.Point(178, 415)
        Me.vinAbschnitt02_Zeit_Std.Name = "vinAbschnitt02_Zeit_Std"
        Me.vinAbschnitt02_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt02_Zeit_Std.TabIndex = 6
        Me.vinAbschnitt02_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt02_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt02_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt02_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt02.Zeit_Std"
        Me.vinAbschnitt02_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label9
        '
        Me.Label9.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.LocalizedText.Text = ":"
        Me.Label9.Location = New System.Drawing.Point(256, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 24)
        Me.Label9.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.LocalizedText.Text = ":"
        Me.Label10.Location = New System.Drawing.Point(212, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 24)
        Me.Label10.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.LocalizedText.Text = "Zeit:"
        Me.Label11.Location = New System.Drawing.Point(36, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 27)
        Me.Label11.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt02_Temperatur
        '
        Me.vinAbschnitt02_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt02_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt02_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt02_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt02_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt02_Temperatur.Location = New System.Drawing.Point(178, 382)
        Me.vinAbschnitt02_Temperatur.Name = "vinAbschnitt02_Temperatur"
        Me.vinAbschnitt02_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt02_Temperatur.TabIndex = 5
        Me.vinAbschnitt02_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt02_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt02_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt02_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt02_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt02_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt02_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt02_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt02.Temperatur"
        Me.vinAbschnitt02_Temperatur.VWItem.RecipeMember = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.LocalizedText.Text = "Temperatur:"
        Me.Label12.Location = New System.Drawing.Point(36, 382)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 27)
        Me.Label12.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Yellow
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.LocalizedText.Text = "Abschnitt 02              Soll"
        Me.Label13.Location = New System.Drawing.Point(36, 348)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(262, 28)
        Me.Label13.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt03_Zeit_Sek
        '
        Me.vinAbschnitt03_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt03_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt03_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt03_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt03_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt03_Zeit_Sek.Location = New System.Drawing.Point(265, 529)
        Me.vinAbschnitt03_Zeit_Sek.Name = "vinAbschnitt03_Zeit_Sek"
        Me.vinAbschnitt03_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt03_Zeit_Sek.TabIndex = 12
        Me.vinAbschnitt03_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt03_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt03_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt03_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt03.Zeit_Sek"
        Me.vinAbschnitt03_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt03_Zeit_Min
        '
        Me.vinAbschnitt03_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt03_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt03_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt03_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt03_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt03_Zeit_Min.Location = New System.Drawing.Point(221, 529)
        Me.vinAbschnitt03_Zeit_Min.Name = "vinAbschnitt03_Zeit_Min"
        Me.vinAbschnitt03_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt03_Zeit_Min.TabIndex = 11
        Me.vinAbschnitt03_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt03_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt03_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt03_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt03.Zeit_Min"
        Me.vinAbschnitt03_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt03_Zeit_Std
        '
        Me.vinAbschnitt03_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt03_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt03_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt03_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt03_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt03_Zeit_Std.Location = New System.Drawing.Point(178, 529)
        Me.vinAbschnitt03_Zeit_Std.Name = "vinAbschnitt03_Zeit_Std"
        Me.vinAbschnitt03_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt03_Zeit_Std.TabIndex = 10
        Me.vinAbschnitt03_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt03_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt03_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt03_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt03.Zeit_Std"
        Me.vinAbschnitt03_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label14
        '
        Me.Label14.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.LocalizedText.Text = ":"
        Me.Label14.Location = New System.Drawing.Point(256, 529)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 24)
        Me.Label14.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.LocalizedText.Text = ":"
        Me.Label15.Location = New System.Drawing.Point(212, 530)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 24)
        Me.Label15.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.LocalizedText.Text = "Zeit:"
        Me.Label16.Location = New System.Drawing.Point(36, 529)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 27)
        Me.Label16.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt03_Temperatur
        '
        Me.vinAbschnitt03_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt03_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt03_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt03_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt03_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt03_Temperatur.Location = New System.Drawing.Point(178, 496)
        Me.vinAbschnitt03_Temperatur.Name = "vinAbschnitt03_Temperatur"
        Me.vinAbschnitt03_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt03_Temperatur.TabIndex = 9
        Me.vinAbschnitt03_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt03_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt03_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt03_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt03_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt03_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt03_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt03_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt03.Temperatur"
        Me.vinAbschnitt03_Temperatur.VWItem.RecipeMember = True
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.LocalizedText.Text = "Temperatur:"
        Me.Label17.Location = New System.Drawing.Point(36, 496)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 27)
        Me.Label17.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Yellow
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.LocalizedText.Text = "Abschnitt 03              Soll"
        Me.Label18.Location = New System.Drawing.Point(36, 462)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(262, 28)
        Me.Label18.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt04_Zeit_Sek
        '
        Me.vinAbschnitt04_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt04_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt04_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt04_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt04_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt04_Zeit_Sek.Location = New System.Drawing.Point(265, 644)
        Me.vinAbschnitt04_Zeit_Sek.Name = "vinAbschnitt04_Zeit_Sek"
        Me.vinAbschnitt04_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt04_Zeit_Sek.TabIndex = 16
        Me.vinAbschnitt04_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt04_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt04_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt04_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt04.Zeit_Sek"
        Me.vinAbschnitt04_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt04_Zeit_Min
        '
        Me.vinAbschnitt04_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt04_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt04_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt04_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt04_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt04_Zeit_Min.Location = New System.Drawing.Point(221, 644)
        Me.vinAbschnitt04_Zeit_Min.Name = "vinAbschnitt04_Zeit_Min"
        Me.vinAbschnitt04_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt04_Zeit_Min.TabIndex = 15
        Me.vinAbschnitt04_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt04_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt04_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt04_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt04.Zeit_Min"
        Me.vinAbschnitt04_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt04_Zeit_Std
        '
        Me.vinAbschnitt04_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt04_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt04_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt04_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt04_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt04_Zeit_Std.Location = New System.Drawing.Point(178, 644)
        Me.vinAbschnitt04_Zeit_Std.Name = "vinAbschnitt04_Zeit_Std"
        Me.vinAbschnitt04_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt04_Zeit_Std.TabIndex = 14
        Me.vinAbschnitt04_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt04_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt04_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt04_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt04.Zeit_Std"
        Me.vinAbschnitt04_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label19
        '
        Me.Label19.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.LocalizedText.Text = ":"
        Me.Label19.Location = New System.Drawing.Point(256, 644)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 24)
        Me.Label19.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.LocalizedText.Text = ":"
        Me.Label20.Location = New System.Drawing.Point(212, 645)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(10, 24)
        Me.Label20.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.LocalizedText.Text = "Zeit:"
        Me.Label21.Location = New System.Drawing.Point(36, 644)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 27)
        Me.Label21.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt04_Temperatur
        '
        Me.vinAbschnitt04_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt04_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt04_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt04_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt04_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt04_Temperatur.Location = New System.Drawing.Point(178, 611)
        Me.vinAbschnitt04_Temperatur.Name = "vinAbschnitt04_Temperatur"
        Me.vinAbschnitt04_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt04_Temperatur.TabIndex = 13
        Me.vinAbschnitt04_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt04_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt04_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt04_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt04_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt04_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt04_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt04_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt04.Temperatur"
        Me.vinAbschnitt04_Temperatur.VWItem.RecipeMember = True
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.LocalizedText.Text = "Temperatur:"
        Me.Label22.Location = New System.Drawing.Point(36, 611)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 27)
        Me.Label22.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Yellow
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.LocalizedText.Text = "Abschnitt 04              Soll"
        Me.Label23.Location = New System.Drawing.Point(36, 577)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(262, 28)
        Me.Label23.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt05_Zeit_Sek
        '
        Me.vinAbschnitt05_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt05_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt05_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt05_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt05_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt05_Zeit_Sek.Location = New System.Drawing.Point(609, 302)
        Me.vinAbschnitt05_Zeit_Sek.Name = "vinAbschnitt05_Zeit_Sek"
        Me.vinAbschnitt05_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt05_Zeit_Sek.TabIndex = 20
        Me.vinAbschnitt05_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt05_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt05_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt05_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt05.Zeit_Sek"
        Me.vinAbschnitt05_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt05_Zeit_Min
        '
        Me.vinAbschnitt05_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt05_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt05_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt05_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt05_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt05_Zeit_Min.Location = New System.Drawing.Point(565, 302)
        Me.vinAbschnitt05_Zeit_Min.Name = "vinAbschnitt05_Zeit_Min"
        Me.vinAbschnitt05_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt05_Zeit_Min.TabIndex = 19
        Me.vinAbschnitt05_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt05_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt05_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt05_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt05.Zeit_Min"
        Me.vinAbschnitt05_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt05__Zeit_Std
        '
        Me.vinAbschnitt05__Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt05__Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05__Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt05__Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05__Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt05__Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05__Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05__Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt05__Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt05__Zeit_Std.Location = New System.Drawing.Point(522, 302)
        Me.vinAbschnitt05__Zeit_Std.Name = "vinAbschnitt05__Zeit_Std"
        Me.vinAbschnitt05__Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt05__Zeit_Std.TabIndex = 18
        Me.vinAbschnitt05__Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt05__Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05__Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt05__Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05__Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt05__Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05__Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt05.Zeit_Std"
        Me.vinAbschnitt05__Zeit_Std.VWItem.RecipeMember = True
        '
        'Label24
        '
        Me.Label24.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.LocalizedText.Text = ":"
        Me.Label24.Location = New System.Drawing.Point(600, 302)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 24)
        Me.Label24.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.LocalizedText.Text = ":"
        Me.Label25.Location = New System.Drawing.Point(556, 303)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 24)
        Me.Label25.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.LocalizedText.Text = "Zeit:"
        Me.Label26.Location = New System.Drawing.Point(380, 302)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 27)
        Me.Label26.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt05_Temperatur
        '
        Me.vinAbschnitt05_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt05_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt05_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt05_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt05_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt05_Temperatur.Location = New System.Drawing.Point(522, 269)
        Me.vinAbschnitt05_Temperatur.Name = "vinAbschnitt05_Temperatur"
        Me.vinAbschnitt05_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt05_Temperatur.TabIndex = 17
        Me.vinAbschnitt05_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt05_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt05_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt05_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt05_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt05_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt05_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt05_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt05.Temperatur"
        Me.vinAbschnitt05_Temperatur.VWItem.RecipeMember = True
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.LocalizedText.Text = "Temperatur:"
        Me.Label27.Location = New System.Drawing.Point(380, 269)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(136, 27)
        Me.Label27.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Yellow
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.LocalizedText.Text = "Abschnitt 05              Soll"
        Me.Label28.Location = New System.Drawing.Point(380, 235)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(262, 28)
        Me.Label28.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt06_Zeit_Sek
        '
        Me.vinAbschnitt06_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt06_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt06_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt06_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt06_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt06_Zeit_Sek.Location = New System.Drawing.Point(609, 415)
        Me.vinAbschnitt06_Zeit_Sek.Name = "vinAbschnitt06_Zeit_Sek"
        Me.vinAbschnitt06_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt06_Zeit_Sek.TabIndex = 24
        Me.vinAbschnitt06_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt06_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt06_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt06_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt06.Zeit_Sek"
        Me.vinAbschnitt06_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt06_Zeit_Min
        '
        Me.vinAbschnitt06_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt06_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt06_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt06_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt06_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt06_Zeit_Min.Location = New System.Drawing.Point(565, 415)
        Me.vinAbschnitt06_Zeit_Min.Name = "vinAbschnitt06_Zeit_Min"
        Me.vinAbschnitt06_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt06_Zeit_Min.TabIndex = 23
        Me.vinAbschnitt06_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt06_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt06_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt06_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt06.Zeit_Min"
        Me.vinAbschnitt06_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt06_Zeit_Std
        '
        Me.vinAbschnitt06_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt06_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt06_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt06_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt06_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt06_Zeit_Std.Location = New System.Drawing.Point(522, 415)
        Me.vinAbschnitt06_Zeit_Std.Name = "vinAbschnitt06_Zeit_Std"
        Me.vinAbschnitt06_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt06_Zeit_Std.TabIndex = 22
        Me.vinAbschnitt06_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt06_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt06_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt06_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt06.Zeit_Std"
        Me.vinAbschnitt06_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label29
        '
        Me.Label29.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.LocalizedText.Text = ":"
        Me.Label29.Location = New System.Drawing.Point(600, 415)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(10, 24)
        Me.Label29.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.LocalizedText.Text = ":"
        Me.Label30.Location = New System.Drawing.Point(556, 416)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(10, 24)
        Me.Label30.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.LocalizedText.Text = "Zeit:"
        Me.Label31.Location = New System.Drawing.Point(380, 415)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 27)
        Me.Label31.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt06_Temperatur
        '
        Me.vinAbschnitt06_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt06_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt06_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt06_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt06_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt06_Temperatur.Location = New System.Drawing.Point(522, 382)
        Me.vinAbschnitt06_Temperatur.Name = "vinAbschnitt06_Temperatur"
        Me.vinAbschnitt06_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt06_Temperatur.TabIndex = 21
        Me.vinAbschnitt06_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt06_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt06_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt06_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt06_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt06_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt06_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt06_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt06.Temperatur"
        Me.vinAbschnitt06_Temperatur.VWItem.RecipeMember = True
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.LocalizedText.Text = "Temperatur:"
        Me.Label32.Location = New System.Drawing.Point(380, 382)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(136, 27)
        Me.Label32.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Yellow
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.LocalizedText.Text = "Abschnitt 06              Soll"
        Me.Label33.Location = New System.Drawing.Point(380, 348)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(262, 28)
        Me.Label33.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt07_Zeit_Sek
        '
        Me.vinAbschnitt07_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt07_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt07_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt07_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt07_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt07_Zeit_Sek.Location = New System.Drawing.Point(609, 529)
        Me.vinAbschnitt07_Zeit_Sek.Name = "vinAbschnitt07_Zeit_Sek"
        Me.vinAbschnitt07_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt07_Zeit_Sek.TabIndex = 28
        Me.vinAbschnitt07_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt07_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt07_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt07_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt07.Zeit_Sek"
        Me.vinAbschnitt07_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt07_Zeit_Min
        '
        Me.vinAbschnitt07_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt07_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt07_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt07_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt07_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt07_Zeit_Min.Location = New System.Drawing.Point(565, 529)
        Me.vinAbschnitt07_Zeit_Min.Name = "vinAbschnitt07_Zeit_Min"
        Me.vinAbschnitt07_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt07_Zeit_Min.TabIndex = 27
        Me.vinAbschnitt07_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt07_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt07_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt07_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt07.Zeit_Min"
        Me.vinAbschnitt07_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt07_Zeit_Std
        '
        Me.vinAbschnitt07_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt07_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt07_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt07_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt07_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt07_Zeit_Std.Location = New System.Drawing.Point(522, 529)
        Me.vinAbschnitt07_Zeit_Std.Name = "vinAbschnitt07_Zeit_Std"
        Me.vinAbschnitt07_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt07_Zeit_Std.TabIndex = 26
        Me.vinAbschnitt07_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt07_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt07_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt07_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt07.Zeit_Std"
        Me.vinAbschnitt07_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label34
        '
        Me.Label34.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.LocalizedText.Text = ":"
        Me.Label34.Location = New System.Drawing.Point(600, 529)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(10, 24)
        Me.Label34.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.LocalizedText.Text = ":"
        Me.Label35.Location = New System.Drawing.Point(556, 530)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(10, 24)
        Me.Label35.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.LocalizedText.Text = "Zeit:"
        Me.Label36.Location = New System.Drawing.Point(380, 529)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(136, 27)
        Me.Label36.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt07_Temperatur
        '
        Me.vinAbschnitt07_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt07_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt07_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt07_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt07_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt07_Temperatur.Location = New System.Drawing.Point(522, 496)
        Me.vinAbschnitt07_Temperatur.Name = "vinAbschnitt07_Temperatur"
        Me.vinAbschnitt07_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt07_Temperatur.TabIndex = 25
        Me.vinAbschnitt07_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt07_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt07_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt07_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt07_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt07_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt07_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt07_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt07.Temperatur"
        Me.vinAbschnitt07_Temperatur.VWItem.RecipeMember = True
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.LocalizedText.Text = "Temperatur:"
        Me.Label37.Location = New System.Drawing.Point(380, 496)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(136, 27)
        Me.Label37.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Yellow
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.LocalizedText.Text = "Abschnitt 07              Soll"
        Me.Label38.Location = New System.Drawing.Point(380, 462)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(262, 28)
        Me.Label38.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt08_Zeit_Sek
        '
        Me.vinAbschnitt08_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt08_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt08_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt08_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt08_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt08_Zeit_Sek.Location = New System.Drawing.Point(609, 644)
        Me.vinAbschnitt08_Zeit_Sek.Name = "vinAbschnitt08_Zeit_Sek"
        Me.vinAbschnitt08_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt08_Zeit_Sek.TabIndex = 32
        Me.vinAbschnitt08_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt08_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt08_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt08_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt08.Zeit_Sek"
        Me.vinAbschnitt08_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt08_Zeit_Min
        '
        Me.vinAbschnitt08_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt08_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt08_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt08_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt08_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt08_Zeit_Min.Location = New System.Drawing.Point(565, 644)
        Me.vinAbschnitt08_Zeit_Min.Name = "vinAbschnitt08_Zeit_Min"
        Me.vinAbschnitt08_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt08_Zeit_Min.TabIndex = 31
        Me.vinAbschnitt08_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt08_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt08_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt08_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt08.Zeit_Min"
        Me.vinAbschnitt08_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt08_Zeit_Std
        '
        Me.vinAbschnitt08_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt08_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt08_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt08_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt08_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt08_Zeit_Std.Location = New System.Drawing.Point(522, 644)
        Me.vinAbschnitt08_Zeit_Std.Name = "vinAbschnitt08_Zeit_Std"
        Me.vinAbschnitt08_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt08_Zeit_Std.TabIndex = 30
        Me.vinAbschnitt08_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt08_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt08_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt08_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt08.Zeit_Std"
        Me.vinAbschnitt08_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label39
        '
        Me.Label39.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.LocalizedText.Text = ":"
        Me.Label39.Location = New System.Drawing.Point(600, 644)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(10, 24)
        Me.Label39.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.LocalizedText.Text = ":"
        Me.Label40.Location = New System.Drawing.Point(556, 645)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(10, 24)
        Me.Label40.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.LocalizedText.Text = "Zeit:"
        Me.Label41.Location = New System.Drawing.Point(380, 644)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(136, 27)
        Me.Label41.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt08_Temperatur
        '
        Me.vinAbschnitt08_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt08_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt08_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt08_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt08_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt08_Temperatur.Location = New System.Drawing.Point(522, 611)
        Me.vinAbschnitt08_Temperatur.Name = "vinAbschnitt08_Temperatur"
        Me.vinAbschnitt08_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt08_Temperatur.TabIndex = 29
        Me.vinAbschnitt08_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt08_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt08_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt08_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt08_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt08_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt08_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt08_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt08.Temperatur"
        Me.vinAbschnitt08_Temperatur.VWItem.RecipeMember = True
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.LocalizedText.Text = "Temperatur:"
        Me.Label42.Location = New System.Drawing.Point(380, 611)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(136, 27)
        Me.Label42.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Yellow
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.LocalizedText.Text = "Abschnitt 08              Soll"
        Me.Label43.Location = New System.Drawing.Point(380, 577)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(262, 28)
        Me.Label43.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt09_Zeit_Sek
        '
        Me.vinAbschnitt09_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt09_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt09_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt09_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt09_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt09_Zeit_Sek.Location = New System.Drawing.Point(948, 302)
        Me.vinAbschnitt09_Zeit_Sek.Name = "vinAbschnitt09_Zeit_Sek"
        Me.vinAbschnitt09_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt09_Zeit_Sek.TabIndex = 36
        Me.vinAbschnitt09_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt09_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt09_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt09_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt09.Zeit_Sek"
        Me.vinAbschnitt09_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt09_Zeit_Min
        '
        Me.vinAbschnitt09_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt09_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt09_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt09_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt09_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt09_Zeit_Min.Location = New System.Drawing.Point(904, 302)
        Me.vinAbschnitt09_Zeit_Min.Name = "vinAbschnitt09_Zeit_Min"
        Me.vinAbschnitt09_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt09_Zeit_Min.TabIndex = 35
        Me.vinAbschnitt09_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt09_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt09_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt09_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt09.Zeit_Min"
        Me.vinAbschnitt09_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt09_Zeit_Std
        '
        Me.vinAbschnitt09_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt09_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt09_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt09_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt09_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt09_Zeit_Std.Location = New System.Drawing.Point(861, 302)
        Me.vinAbschnitt09_Zeit_Std.Name = "vinAbschnitt09_Zeit_Std"
        Me.vinAbschnitt09_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt09_Zeit_Std.TabIndex = 34
        Me.vinAbschnitt09_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt09_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt09_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt09_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt09.Zeit_Std"
        Me.vinAbschnitt09_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label44
        '
        Me.Label44.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.LocalizedText.Text = ":"
        Me.Label44.Location = New System.Drawing.Point(939, 302)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(10, 24)
        Me.Label44.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label45
        '
        Me.Label45.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.LocalizedText.Text = ":"
        Me.Label45.Location = New System.Drawing.Point(895, 303)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(10, 24)
        Me.Label45.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.LocalizedText.Text = "Zeit:"
        Me.Label46.Location = New System.Drawing.Point(719, 302)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(136, 27)
        Me.Label46.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt09_Temperatur
        '
        Me.vinAbschnitt09_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt09_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt09_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt09_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt09_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt09_Temperatur.Location = New System.Drawing.Point(861, 269)
        Me.vinAbschnitt09_Temperatur.Name = "vinAbschnitt09_Temperatur"
        Me.vinAbschnitt09_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt09_Temperatur.TabIndex = 33
        Me.vinAbschnitt09_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt09_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt09_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt09_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt09_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt09_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt09_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt09_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt09.Temperatur"
        Me.vinAbschnitt09_Temperatur.VWItem.RecipeMember = True
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.LocalizedText.Text = "Temperatur:"
        Me.Label47.Location = New System.Drawing.Point(719, 269)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(136, 27)
        Me.Label47.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Yellow
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.LocalizedText.Text = "Abschnitt 09              Soll"
        Me.Label48.Location = New System.Drawing.Point(719, 235)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(262, 28)
        Me.Label48.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt10_Zeit_Sek
        '
        Me.vinAbschnitt10_Zeit_Sek.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt10_Zeit_Sek.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Sek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt10_Zeit_Sek.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Sek.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt10_Zeit_Sek.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Zeit_Sek.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Zeit_Sek.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt10_Zeit_Sek.LimitMax.Value = 59
        Me.vinAbschnitt10_Zeit_Sek.Location = New System.Drawing.Point(948, 415)
        Me.vinAbschnitt10_Zeit_Sek.Name = "vinAbschnitt10_Zeit_Sek"
        Me.vinAbschnitt10_Zeit_Sek.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt10_Zeit_Sek.TabIndex = 40
        Me.vinAbschnitt10_Zeit_Sek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt10_Zeit_Sek.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Sek.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt10_Zeit_Sek.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Zeit_Sek.Unit.SizeRatio = 0.25
        Me.vinAbschnitt10_Zeit_Sek.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Zeit_Sek.VWItem.Name = "SPS Ofen.Rezept.Abschnitt10.Zeit_Sek"
        Me.vinAbschnitt10_Zeit_Sek.VWItem.RecipeMember = True
        '
        'vinAbschnitt10_Zeit_Min
        '
        Me.vinAbschnitt10_Zeit_Min.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt10_Zeit_Min.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt10_Zeit_Min.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Min.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt10_Zeit_Min.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Zeit_Min.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Zeit_Min.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt10_Zeit_Min.LimitMax.Value = 59
        Me.vinAbschnitt10_Zeit_Min.Location = New System.Drawing.Point(904, 415)
        Me.vinAbschnitt10_Zeit_Min.Name = "vinAbschnitt10_Zeit_Min"
        Me.vinAbschnitt10_Zeit_Min.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt10_Zeit_Min.TabIndex = 39
        Me.vinAbschnitt10_Zeit_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt10_Zeit_Min.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Min.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt10_Zeit_Min.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Zeit_Min.Unit.SizeRatio = 0.25
        Me.vinAbschnitt10_Zeit_Min.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Zeit_Min.VWItem.Name = "SPS Ofen.Rezept.Abschnitt10.Zeit_Min"
        Me.vinAbschnitt10_Zeit_Min.VWItem.RecipeMember = True
        '
        'vinAbschnitt10_Zeit_Std
        '
        Me.vinAbschnitt10_Zeit_Std.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt10_Zeit_Std.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Std.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt10_Zeit_Std.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Std.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt10_Zeit_Std.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Zeit_Std.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Zeit_Std.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt10_Zeit_Std.LimitMax.Value = 99
        Me.vinAbschnitt10_Zeit_Std.Location = New System.Drawing.Point(861, 415)
        Me.vinAbschnitt10_Zeit_Std.Name = "vinAbschnitt10_Zeit_Std"
        Me.vinAbschnitt10_Zeit_Std.Size = New System.Drawing.Size(33, 27)
        Me.vinAbschnitt10_Zeit_Std.TabIndex = 38
        Me.vinAbschnitt10_Zeit_Std.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt10_Zeit_Std.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Zeit_Std.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt10_Zeit_Std.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Zeit_Std.Unit.SizeRatio = 0.25
        Me.vinAbschnitt10_Zeit_Std.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Zeit_Std.VWItem.Name = "SPS Ofen.Rezept.Abschnitt10.Zeit_Std"
        Me.vinAbschnitt10_Zeit_Std.VWItem.RecipeMember = True
        '
        'Label49
        '
        Me.Label49.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.LocalizedText.Text = ":"
        Me.Label49.Location = New System.Drawing.Point(939, 415)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(10, 24)
        Me.Label49.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label50
        '
        Me.Label50.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.LocalizedText.Text = ":"
        Me.Label50.Location = New System.Drawing.Point(895, 416)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(10, 24)
        Me.Label50.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.LocalizedText.Text = "Zeit:"
        Me.Label51.Location = New System.Drawing.Point(719, 415)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(136, 27)
        Me.Label51.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinAbschnitt10_Temperatur
        '
        Me.vinAbschnitt10_Temperatur.Authorization.Right = "Programmänderungen"
        Me.vinAbschnitt10_Temperatur.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Temperatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinAbschnitt10_Temperatur.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Temperatur.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinAbschnitt10_Temperatur.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Temperatur.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Temperatur.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinAbschnitt10_Temperatur.LimitMax.Value = 280
        Me.vinAbschnitt10_Temperatur.Location = New System.Drawing.Point(861, 382)
        Me.vinAbschnitt10_Temperatur.Name = "vinAbschnitt10_Temperatur"
        Me.vinAbschnitt10_Temperatur.Size = New System.Drawing.Size(120, 27)
        Me.vinAbschnitt10_Temperatur.TabIndex = 37
        Me.vinAbschnitt10_Temperatur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinAbschnitt10_Temperatur.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinAbschnitt10_Temperatur.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinAbschnitt10_Temperatur.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinAbschnitt10_Temperatur.Unit.SizeRatio = 0.25
        Me.vinAbschnitt10_Temperatur.Unit.Text.Text = "°C"
        Me.vinAbschnitt10_Temperatur.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinAbschnitt10_Temperatur.VWItem.Name = "SPS Ofen.Rezept.Abschnitt10.Temperatur"
        Me.vinAbschnitt10_Temperatur.VWItem.RecipeMember = True
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.LocalizedText.Text = "Temperatur:"
        Me.Label52.Location = New System.Drawing.Point(719, 382)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(136, 27)
        Me.Label52.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Yellow
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.LocalizedText.Text = "Abschnitt 10              Soll"
        Me.Label53.Location = New System.Drawing.Point(719, 348)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(262, 28)
        Me.Label53.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.LocalizedText.Text = "Regelabweichung:"
        Me.Label56.Location = New System.Drawing.Point(719, 578)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(136, 27)
        Me.Label56.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Yellow
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.LocalizedText.Text = "Allgemein                  Soll"
        Me.Label57.Location = New System.Drawing.Point(719, 544)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(262, 28)
        Me.Label57.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'vinRegelabweichung
        '
        Me.vinRegelabweichung.Authorization.Right = "Programmänderungen"
        Me.vinRegelabweichung.DataBorder.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinRegelabweichung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vinRegelabweichung.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinRegelabweichung.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.vinRegelabweichung.Label.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinRegelabweichung.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinRegelabweichung.LimitCheck = VisiWinNET.Forms.LimitCheckMode.OnEnter
        Me.vinRegelabweichung.LimitMax.Value = 100
        Me.vinRegelabweichung.Location = New System.Drawing.Point(861, 578)
        Me.vinRegelabweichung.Name = "vinRegelabweichung"
        Me.vinRegelabweichung.Size = New System.Drawing.Size(120, 27)
        Me.vinRegelabweichung.TabIndex = 42
        Me.vinRegelabweichung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vinRegelabweichung.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None
        Me.vinRegelabweichung.Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vinRegelabweichung.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vinRegelabweichung.Unit.SizeRatio = 0.25
        Me.vinRegelabweichung.Unit.Text.Text = "°C"
        Me.vinRegelabweichung.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.vinRegelabweichung.VWItem.Name = "SPS Ofen.Rezept.Regelabweichung"
        Me.vinRegelabweichung.VWItem.RecipeMember = True
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.LocalizedText.Text = "Düsenkanal:"
        Me.Label58.Location = New System.Drawing.Point(719, 611)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(136, 27)
        Me.Label58.TextAlign = VisiWinNET.Forms.ContentAlign.MiddleLeft
        '
        'cmbVW_Duesenkanal
        '
        Me.cmbVW_Duesenkanal.Authorization.Right = "Programmänderungen"
        Me.cmbVW_Duesenkanal.Editable = False
        Me.cmbVW_Duesenkanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVW_Duesenkanal.Items.AddRange(New VisiWinNET.Forms.ListItem() {New VisiWinNET.Forms.ListItem("aus"), New VisiWinNET.Forms.ListItem("ein")})
        Me.cmbVW_Duesenkanal.Location = New System.Drawing.Point(861, 611)
        Me.cmbVW_Duesenkanal.Mode = VisiWinNET.Forms.ListBoxModes.Automatic
        Me.cmbVW_Duesenkanal.Name = "cmbVW_Duesenkanal"
        Me.cmbVW_Duesenkanal.ScrollBarProperties.Width = 23
        Me.cmbVW_Duesenkanal.Size = New System.Drawing.Size(120, 27)
        Me.cmbVW_Duesenkanal.TabIndex = 43
        Me.cmbVW_Duesenkanal.TextGroup = "Textlisten.aus_ein"
        Me.cmbVW_Duesenkanal.TextPrefix = "aus_ein"
        Me.cmbVW_Duesenkanal.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Value
        Me.cmbVW_Duesenkanal.VWItem.Name = "SPS Ofen.Rezept.VW_Duesenkanal"
        Me.cmbVW_Duesenkanal.VWItem.RecipeMember = True
        '
        'FRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmbVW_Duesenkanal)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.vinRegelabweichung)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.vinAbschnitt10_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt10_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt10_Zeit_Std)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.vinAbschnitt10_Temperatur)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.vinAbschnitt09_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt09_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt09_Zeit_Std)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.vinAbschnitt09_Temperatur)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.vinAbschnitt08_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt08_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt08_Zeit_Std)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.vinAbschnitt08_Temperatur)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.vinAbschnitt07_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt07_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt07_Zeit_Std)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.vinAbschnitt07_Temperatur)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.vinAbschnitt06_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt06_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt06_Zeit_Std)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.vinAbschnitt06_Temperatur)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.vinAbschnitt05_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt05_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt05__Zeit_Std)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.vinAbschnitt05_Temperatur)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.vinAbschnitt04_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt04_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt04_Zeit_Std)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.vinAbschnitt04_Temperatur)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.vinAbschnitt03_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt03_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt03_Zeit_Std)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.vinAbschnitt03_Temperatur)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.vinAbschnitt02_Zeit_Sek)
        Me.Controls.Add(Me.vinAbschnitt02_Zeit_Min)
        Me.Controls.Add(Me.vinAbschnitt02_Zeit_Std)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.vinAbschnitt02_Temperatur)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.votRezept_Beschreibung)
        Me.Controls.Add(Me.votRezept_Name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdRezept_speichern)
        Me.Controls.Add(Me.cmdRezept_laden)
        Me.Controls.Add(Me.VarIn1)
        Me.Controls.Add(Me.vaiAbschnitt01_Zeit_Min)
        Me.Controls.Add(Me.vaiAbschnitt01_Zeit_Std)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vaiAbschnitt01_Temperatur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUeberschrift)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRecipe"
        Me.Text = "FRecipe"
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.lblUeberschrift, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.vaiAbschnitt01_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.vaiAbschnitt01_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vaiAbschnitt01_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.VarIn1, 0)
        Me.Controls.SetChildIndex(Me.cmdRezept_laden, 0)
        Me.Controls.SetChildIndex(Me.cmdRezept_speichern, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.votRezept_Name, 0)
        Me.Controls.SetChildIndex(Me.votRezept_Beschreibung, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt02_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt02_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt02_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt02_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt03_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt03_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt03_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt03_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label23, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt04_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt04_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt04_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt04_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt05_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.Label24, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt05__Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt05_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt05_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label33, 0)
        Me.Controls.SetChildIndex(Me.Label32, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt06_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label31, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt06_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt06_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt06_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label38, 0)
        Me.Controls.SetChildIndex(Me.Label37, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt07_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.Label35, 0)
        Me.Controls.SetChildIndex(Me.Label34, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt07_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt07_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt07_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label43, 0)
        Me.Controls.SetChildIndex(Me.Label42, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt08_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label41, 0)
        Me.Controls.SetChildIndex(Me.Label40, 0)
        Me.Controls.SetChildIndex(Me.Label39, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt08_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt08_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt08_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label48, 0)
        Me.Controls.SetChildIndex(Me.Label47, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt09_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label46, 0)
        Me.Controls.SetChildIndex(Me.Label45, 0)
        Me.Controls.SetChildIndex(Me.Label44, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt09_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt09_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt09_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label53, 0)
        Me.Controls.SetChildIndex(Me.Label52, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt10_Temperatur, 0)
        Me.Controls.SetChildIndex(Me.Label51, 0)
        Me.Controls.SetChildIndex(Me.Label50, 0)
        Me.Controls.SetChildIndex(Me.Label49, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt10_Zeit_Std, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt10_Zeit_Min, 0)
        Me.Controls.SetChildIndex(Me.vinAbschnitt10_Zeit_Sek, 0)
        Me.Controls.SetChildIndex(Me.Label57, 0)
        Me.Controls.SetChildIndex(Me.Label56, 0)
        Me.Controls.SetChildIndex(Me.vinRegelabweichung, 0)
        Me.Controls.SetChildIndex(Me.Label58, 0)
        Me.Controls.SetChildIndex(Me.cmbVW_Duesenkanal, 0)
        CType(Me.lblUeberschrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaiAbschnitt01_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaiAbschnitt01_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaiAbschnitt01_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarIn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRezept_laden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRezept_speichern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votRezept_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.votRezept_Beschreibung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt02_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt02_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt02_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt02_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt03_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt03_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt03_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt03_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt04_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt04_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt04_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt04_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt05_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt05_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt05__Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt05_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt06_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt06_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt06_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt06_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt07_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt07_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt07_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt07_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt08_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt08_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt08_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt08_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt09_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt09_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt09_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt09_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt10_Zeit_Sek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt10_Zeit_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt10_Zeit_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinAbschnitt10_Temperatur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vinRegelabweichung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVW_Duesenkanal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUeberschrift As VisiWinNET.Forms.Label
    Friend WithEvents Label3 As VisiWinNET.Forms.Label
    Friend WithEvents Label4 As VisiWinNET.Forms.Label
    Friend WithEvents vaiAbschnitt01_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label5 As VisiWinNET.Forms.Label
    Friend WithEvents vaiAbschnitt01_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents vaiAbschnitt01_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents VarIn1 As VisiWinNET.Forms.VarIn
    Friend WithEvents Label1 As VisiWinNET.Forms.Label
    Friend WithEvents Label2 As VisiWinNET.Forms.Label
    Friend WithEvents cmdRezept_laden As VisiWinNET.Forms.CommandButton
    Friend WithEvents cmdRezept_speichern As VisiWinNET.Forms.CommandButton
    Friend WithEvents Label6 As VisiWinNET.Forms.Label
    Friend WithEvents Label7 As VisiWinNET.Forms.Label
    Friend WithEvents Label8 As VisiWinNET.Forms.Label
    Friend WithEvents votRezept_Name As VisiWinNET.Forms.VarOut
    Friend WithEvents votRezept_Beschreibung As VisiWinNET.Forms.VarOut
    Friend WithEvents vinAbschnitt02_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt02_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt02_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label9 As VisiWinNET.Forms.Label
    Friend WithEvents Label10 As VisiWinNET.Forms.Label
    Friend WithEvents Label11 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt02_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label12 As VisiWinNET.Forms.Label
    Friend WithEvents Label13 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt03_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt03_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt03_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label14 As VisiWinNET.Forms.Label
    Friend WithEvents Label15 As VisiWinNET.Forms.Label
    Friend WithEvents Label16 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt03_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label17 As VisiWinNET.Forms.Label
    Friend WithEvents Label18 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt04_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt04_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt04_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label19 As VisiWinNET.Forms.Label
    Friend WithEvents Label20 As VisiWinNET.Forms.Label
    Friend WithEvents Label21 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt04_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label22 As VisiWinNET.Forms.Label
    Friend WithEvents Label23 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt05_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt05_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt05__Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label24 As VisiWinNET.Forms.Label
    Friend WithEvents Label25 As VisiWinNET.Forms.Label
    Friend WithEvents Label26 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt05_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label27 As VisiWinNET.Forms.Label
    Friend WithEvents Label28 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt06_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt06_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt06_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label29 As VisiWinNET.Forms.Label
    Friend WithEvents Label30 As VisiWinNET.Forms.Label
    Friend WithEvents Label31 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt06_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label32 As VisiWinNET.Forms.Label
    Friend WithEvents Label33 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt07_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt07_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt07_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label34 As VisiWinNET.Forms.Label
    Friend WithEvents Label35 As VisiWinNET.Forms.Label
    Friend WithEvents Label36 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt07_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label37 As VisiWinNET.Forms.Label
    Friend WithEvents Label38 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt08_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt08_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt08_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label39 As VisiWinNET.Forms.Label
    Friend WithEvents Label40 As VisiWinNET.Forms.Label
    Friend WithEvents Label41 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt08_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label42 As VisiWinNET.Forms.Label
    Friend WithEvents Label43 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt09_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt09_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt09_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label44 As VisiWinNET.Forms.Label
    Friend WithEvents Label45 As VisiWinNET.Forms.Label
    Friend WithEvents Label46 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt09_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label47 As VisiWinNET.Forms.Label
    Friend WithEvents Label48 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt10_Zeit_Sek As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt10_Zeit_Min As VisiWinNET.Forms.VarIn
    Friend WithEvents vinAbschnitt10_Zeit_Std As VisiWinNET.Forms.VarIn
    Friend WithEvents Label49 As VisiWinNET.Forms.Label
    Friend WithEvents Label50 As VisiWinNET.Forms.Label
    Friend WithEvents Label51 As VisiWinNET.Forms.Label
    Friend WithEvents vinAbschnitt10_Temperatur As VisiWinNET.Forms.VarIn
    Friend WithEvents Label52 As VisiWinNET.Forms.Label
    Friend WithEvents Label53 As VisiWinNET.Forms.Label
    Friend WithEvents Label56 As VisiWinNET.Forms.Label
    Friend WithEvents Label57 As VisiWinNET.Forms.Label
    Friend WithEvents vinRegelabweichung As VisiWinNET.Forms.VarIn
    Friend WithEvents Label58 As VisiWinNET.Forms.Label
    Friend WithEvents cmbVW_Duesenkanal As VisiWinNET.Forms.ComboBox
End Class
