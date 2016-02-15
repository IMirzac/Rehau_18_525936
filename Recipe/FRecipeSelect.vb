' Formular (modaler Dialog) zum Laden oder Speichern einer Rezeptdatei

#Region " Template information "
' Diese Region nicht löschen
' Version = 6.0.0.0
' Created by = INOSOFT
' 
#End Region

#Region " Öffentliche Methoden "
' (Beschreibung siehe unten):
' - ShowLoadDialog     Aufruf des Dialoges zum Laden einer Rezeptdatei
' - ShowSaveDialog     Aufruf des Dialoges zum Speichern einer Rezeptdatei
#End Region

#Region " Aufrufbeispiele!!! "
' (es ist kein Instanzieren des Formulars notwendig, 
'  da die Methoden als "shared" deklariert sind!):

' FRecipeSelect.ShowLoadDialog(mRecipeClass)

' Dim s As String
' s = FRecipeSelect.ShowLoadDialog(mRecipeClass)
' If s.Length > 0 Then
'     '...
' End If

' FRecipeSelect.ShowSaveDialog(mRecipeClass)

' Dim s As String
' s = FRecipeSelect.ShowSaveDialog(mRecipeClass)
' If s.Length > 0 Then
'     '...
' End If

#End Region

#Region " Abhängigkeiten/zusätzliche Dateien "
' - Formular:
'   - FMessageBox
' - Indextexte in Gruppe
'   - Dialogs.Common
'   - Benutzertexte.Forms.RecipeManagement
#End Region

Imports VisiWinNET.Recipe
Imports VisiWinNET.Forms

Public Class FRecipeSelect

    Public Sub New()
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

#Region " Deklarationen "

    Private Enum DialogType
        Load
        Save
    End Enum

    Private mDialogType As DialogType
  
#End Region

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    ' Aufruf des Dialoges zum Laden einer Rezeptdatei
    ' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ' Übergabe:
    '   recipeClass: Initialisiertes Rezeptobjekt
    '   SPS = True Werte direkt in SPS schreiben
    '   SPS = False Werte in Rezeptpuffer schreiben
    ' Rückgabe:
    '   ShowLoadDialog: Name des geladenen Rezeptes
    '                   oder "" bei Fehler oder Abbruch
  
    Public Shared Sub ShowLoadDialog(ByVal recipeClass As String, ByVal RezeptName As String, ByVal RezeptBeschreibung As String)
        Dim frm As New FRecipeSelect

        frm.mDialogType = DialogType.Load
        frm.RecipeList1.ClassName = recipeClass
        frm.RecipeList1.UpdateFileView()
        frm.vinDescription.Enabled = False
        frm.lblCaption.Text = "@Forms.RecipeManagement.capLoadRecipe"
        If VisiWinNET.Services.AppService.VWGet("Rezept.Werte_in_SPS_schreiben") = True Then
            frm.vinName.Text = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Rezept_Name")
            frm.vinDescription.Text = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Status.Rezept_Beschreibung")
        Else
            frm.vinName.Text = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Name")
            frm.vinDescription.Text = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Beschreibung")
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frm.vinName.Text <> Nothing Then
                RezeptName = frm.vinName.Text
            Else
                RezeptName = ""
            End If
            If frm.vinDescription.Text <> Nothing Then
                RezeptBeschreibung = frm.vinDescription.Text
            Else
                RezeptBeschreibung = ""
            End If
        End If
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Name", RezeptName)
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Beschreibung", RezeptBeschreibung)
        frm.Dispose()

    End Sub

    ' Aufruf des Dialoges zum Speichern einer Rezeptdatei
    ' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ' Übergabe:
    '   recipeClass: Initialisiertes Rezeptobjekt
    ' Rückgabe:
    '   ShowSaveAsDialog: Name des gespeicherten Rezeptes
    '                     oder "" bei Fehler oder Abbruch
    ' (Datei): Gespeicherte Rezeptwerte

    Public Shared Function ShowSaveAsDialog(ByVal recipeClass As String) As String
        Dim frm As New FRecipeSelect
        Dim sRecipe As String = ""

        frm.mDialogType = DialogType.Save
        frm.RecipeList1.ClassName = recipeClass
        frm.RecipeList1.UpdateFileView()
        frm.lblCaption.Text = "@Forms.RecipeManagement.capSaveRecipe"
        frm.vinName.Text = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Name")
        frm.vinDescription.Text = VisiWinNET.Services.AppService.VWGet("SPS Ofen.Rezept.Rezept_Beschreibung")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sRecipe = frm.vinName.Text
        End If

        frm.Dispose()
        Return sRecipe
    End Function

#End Region

#Region " Private Methoden "

    Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Select Case mDialogType
            Case DialogType.Load
                'Datei laden
                If RecipeList1.RecipeClass.IsExistingRecipeFile(vinName.Text) = False Then
                    FMessageBox.Show("@Forms.RecipeManagement.msgRecipeNotExists", lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                RecipeList1.RecipeClass.Load(vinName.Text, False)
                'weiter geht es im Ereignis "RecipeList1_LoadDone"
            Case DialogType.Save
                'Nicht gespeichert, weil schon vorhanden
                If RecipeList1.RecipeClass.IsExistingRecipeFile(vinName.Text) Then
                    If FMessageBox.Show("@Forms.RecipeManagement.msgRecipeExists", lblCaption.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
                'Datei speichern
                RecipeList1.RecipeClass.Save(vinName.Text, vinDescription.Text, True, False)
                'weiter geht es im Ereignis "RecipeList1_SaveRecipeDone"
        End Select
    End Sub

    Private Sub RecipeList1_LoadDone(ByVal sender As Object, ByVal e As VisiWinNET.Recipe.LoadRecipeEventArgs) Handles RecipeList1.LoadDone
        If e.Result <> LoadRecipeResults.Succeeded Then
            FMessageBox.Show("@Forms.RecipeManagement.LoadRecipeResults." & e.Result.ToString, lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If VisiWinNET.Services.AppService.VWGet("Rezept.Werte_in_SPS_schreiben") = True Then
                VisiWinNET.Services.AppService.VWSet("SPS Ofen.Status.Rezept_Name", e.FileName)
                VisiWinNET.Services.AppService.VWSet("SPS Ofen.Status.Rezept_Beschreibung", RecipeList1.RecipeClass.Files.Item(e.FileName).Description)
                RecipeList1.RecipeClass.Set()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Name", e.FileName)
                VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Beschreibung", RecipeList1.RecipeClass.Files.Item(e.FileName).Description)
            End If
        End If
    End Sub

    Private Sub RecipeList1_SaveDone(ByVal sender As Object, ByVal e As VisiWinNET.Recipe.SaveRecipeEventArgs) Handles RecipeList1.SaveDone
        If e.Result <> SaveRecipeResults.Succeeded Then
            FMessageBox.Show("@Forms.RecipeManagement.SaveRecipeResults." & e.Result.ToString, lblCaption.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Name", e.FileName)
            VisiWinNET.Services.AppService.VWSet("SPS Ofen.Rezept.Rezept_Beschreibung", RecipeList1.RecipeClass.Files.Item(e.FileName).Description)
        End If
    End Sub

    Private Sub RecipeList1_SetDone(ByVal sender As Object, ByVal e As VisiWinNET.Recipe.SetRecipeEventArgs) Handles RecipeList1.SetDone
        If e.Result = SetRecipeResults.Succeeded Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            VisiWinNET.Services.AppService.VWSetBit("SPS Ofen.Arbeit_PC.Allg_Steuerbit_von_PC", 0, True)
        Else
            MsgBox("Error", , "Rezept in SPS schreiben")
        End If
    End Sub

    Private Sub RecipeList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As VisiWinNET.Forms.Internals.SelectedIndexChangedEventArgs) Handles RecipeList1.SelectedIndexChanged
        If e.Index > -1 Then
            Me.vinName.Text = RecipeList1.SelectedRecipeFile.FileName
            Me.vinDescription.Text = RecipeList1.SelectedRecipeFile.Description
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'Wenn ein Rezept ausgewählt ist
        If RecipeList1.SelectedIndex >= 0 Then
            'dann löschen
            RecipeList1.RecipeClass.Files.Delete(RecipeList1.SelectedRecipeFile.FileName)
            vinName.Text = ""
            vinDescription.Text = ""
            'und Liste neu anzeigen
            RecipeList1.UpdateFileView()
        End If
    End Sub

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
