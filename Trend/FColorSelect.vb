' Formular (modaler Dialog) zum Auswählen einer Farbe

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

' Dim color As System.Drawing.Color
' (color = ...)
' FColorSelect.ShowDialog(color)
' ... = color

' Dim color As System.Drawing.Color
' (color = ...)
' If FColorSelect.ShowDialog(color) = Windows.Forms.DialogResult.OK Then
'     ... = color
' End If

#End Region

#Region " Abhängigkeiten/zusätzliche Dateien "
' - Verweise:
'   - VisiWinNET.Standard.Forms
' - IndexTexts in Gruppe
'   - Benutzertexte.Forms.FColorSelect
'   - Dialogs.Common
#End Region

Public Class FColorSelect

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        InitDialog()
    End Sub

#Region " Deklarationen "

    Private cmdSelection As VisiWinNET.Forms.CommandButton = Nothing

#End Region

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    ' <summary>
    ' Aufruf des Dialoges zum Auswählen einer Farbe
    ' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ' Übergabe:
    '   color: Farbe, die im Dialog selektiert werden soll
    ' Rückgabe:
    '   color: Farbe, die im Dialog selektiert wurde
    '   ShowLogOn: Windows.Forms.DialogResult.OK: Farbe ausgewählt
    '              DialogResult.Cancel: Abbruch
    ' </summary>
    Public Overloads Shared Function ShowDialog(ByRef color As Color) As DialogResult
        Dim frm As New FColorSelect
        Dim ret As DialogResult

        If color.IsEmpty Then
            color = Drawing.Color.Black
            frm.cmdSelection = frm.cmdIndividualColor
        End If
        frm.vinRed.VWItem.Value = color.R
        frm.vinGreen.VWItem.Value = color.G
        frm.vinBlue.VWItem.Value = color.B
        frm.cmdIndividualColor.BackColor = color
        For Each ctr As Control In frm.grp.Controls
            If TypeOf ctr Is VisiWinNET.Forms.CommandButton Then
                If ctr.BackColor.ToArgb = color.ToArgb And frm.cmdSelection Is Nothing Then
                    frm.cmdSelection = ctr
                End If
            End If
        Next

        ret = frm.ShowDialog()
        If ret = Windows.Forms.DialogResult.OK Then
            color = frm.cmdSelection.BackColor
        End If
        frm.Dispose()
        Return ret
    End Function

#End Region

#Region " Private Methoden "

    Private Sub InitDialog()
        'Die GotFocus-Ereignisse aller CommandButtons mit einer gemeinsamen Funktion verbinden.
        For Each ctr As Control In grp.Controls
            If TypeOf ctr Is VisiWinNET.Forms.CommandButton Then
                AddHandler ctr.GotFocus, AddressOf CommandButton_GotFocus
            End If
        Next
    End Sub

    Private Sub FColorSelect_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.cmdSelection.Focus()
    End Sub

    Private Sub CommandButton_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Angeklickten Button merken
        cmdSelection = sender
        'und mit einem Markierungsrahmen versehen
        pbxSelection.Left = cmdSelection.Left - 4
        pbxSelection.Top = cmdSelection.Top - 4
    End Sub

    Private Sub vin_Change(ByVal sender As System.Object, ByVal e As VisiWinNET.DataAccess.ChangeEventArgs) _
        Handles vinRed.Change, vinGreen.Change, vinBlue.Change
        cmdIndividualColor.BackColor = Color.FromArgb(vinRed.VWItem.Value, vinGreen.VWItem.Value, vinBlue.VWItem.Value)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'Diese Funktion sorgt dafür, dass die Selektion auch mit den Pfeil-hoch- und
        'Pfeil-runter-Tasten funktioniert.
        Dim pt As Point, ctr As Control
        If Not cmdSelection Is Nothing Then
            pt = cmdSelection.Location
            Select Case keyData
                Case Keys.Down
                    pt.Y = pt.Y + 2 * cmdSelection.Height
                Case Keys.Up
                    pt.Y = pt.Y - cmdSelection.Height
            End Select
            Select Case keyData
                Case Keys.Down, Keys.Up
                    ctr = Me.grp.GetChildAtPoint(pt)
                    If Not ctr Is Nothing Then
                        If TypeOf ctr Is VisiWinNET.Forms.CommandButton Then
                            ctr.Focus()
                            ProcessCmdKey = True
                        End If
                    End If
            End Select
        End If
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
