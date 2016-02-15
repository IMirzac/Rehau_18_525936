'Wenn der Programmregler wie gehabt funktionieren soll müssen in der Bildmaske die Elemente des
'Abschnitts Endtemperatur wieder sichtbar gemacht werden.
'Bei dieser Anlage wir die Temperatur eines Abschnitts sowohl als Start-
'als auch als Endtemperatur verwendet => keine geregelten Aufheizphasen möglich

Public Class FRecipe

#Region " Deklarationen "

    Private WithEvents mRecipeClass As VisiWinNET.Recipe.RecipeClass
    Dim TEm As Integer
#End Region

#Region " Initialisierung "

    Private Sub FRecipe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Rezeptwerte werden initialisiert indem sie aus der SPS gelesen werden (nur bei Anzeige über Puffer)
        mRecipeClass.Get()
    End Sub

    Private Sub FRecipe_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim Rezept_Name As String
        'Rezept laden
        Rezept_Name = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Name")
        If mRecipeClass.IsExistingRecipeFile(Rezept_Name) = True Then
            mRecipeClass.Load(VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Name"), False)
            'weiter mit LoadDone
        End If
    End Sub


    Private Sub FRecipe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 3000)
    End Sub

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen
        mRecipeClass = VisiWinNET.Recipe.RecipeManager.Classes("Rezepte")
    End Sub

#End Region

#Region " Ereignisse "

    Private Sub cmdRezept_laden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRezept_laden.Click
        'Rezept laden

        VisiWinNET.Services.AppService.VWSet("Rezept.Werte_in_SPS_schreiben", False)
       
        Dim Rezept_Name As String
        Dim Rezept_Beschreibung As String

        'Rezept laden
        Rezept_Name = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Name")
        Rezept_Beschreibung = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Beschreibung")

        FRecipeSelect.ShowLoadDialog(mRecipeClass.Name, Rezept_Name, Rezept_Beschreibung)
        



    End Sub

    Private Sub cmdRezept_speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRezept_speichern.Click
        'Rezept speichern
        Dim Rezept_Name As String
        Rezept_Name = FRecipeSelect.ShowSaveAsDialog(mRecipeClass.Name)
    End Sub
    'Auswertung ob Rezeptwert aus der SPS lesen erfolgreichwar
    Private Sub mRecipeClass_GetDone(ByVal sender As Object, ByVal e As VisiWinNET.Recipe.GetRecipeEventArgs) Handles mRecipeClass.GetDone
        'Die Daten wurden von der SPS gelesen
        If e.Result = VisiWinNET.Recipe.GetRecipeResults.Succeeded Then
            mRecipeClass.StartEdit()
        Else
            MsgBox("Error", , "Rezept lesen")
        End If
    End Sub
    'Auswertung ob Rezept aus Datei lesen erfolgreich war
    Private Sub mRecipeClass_LoadDone(ByVal sender As Object, ByVal e As VisiWinNET.Recipe.LoadRecipeEventArgs) Handles mRecipeClass.LoadDone
        If e.Result <> VisiWinNET.Recipe.LoadRecipeResults.Succeeded Then
            FMessageBox.Show("@Forms.RecipeManagement.LoadRecipeResults." & e.Result.ToString, "@Forms.RecipeManagement.capLoadRecipe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

    Private Sub CommandButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Name", "bla bla bla")
    End Sub
End Class
