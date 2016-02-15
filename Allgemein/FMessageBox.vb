' Formular (modaler Dialog) zur Anzeige einer Nachricht (MessageBox)

#Region " Template information "
' Diese Region nicht löschen
' Version = 5.100.0.0
' Created by = INOSOFT
' 
#End Region

#Region " Öffentliche Methoden "
' (Beschreibung siehe unten):
' - Show    Aufruf des Dialoges
#End Region

#Region " Aufrufbeispiele!!! "
' (es ist kein Instanzieren des Formulars notwendig, 
'  da die Methoden als "shared" deklariert sind!):

' FMessageBox.Show("Hallo")

' FMessageBox.Show("@FCentral.Text1")

' FMessageBox.Show(VisiWinNET.LanguageSwitching.TextTypes.ClientSystem, "@Components.Time.MonthName.12")

' FMessageBox.Show("Hallo", "@FCentral.Text2")

' FMessageBox.Show("Hallo", "Überschrift")

' FMessageBox.Show("Hallo", "Überschrift", MessageBoxButtons.OK)

' FMessageBox.Show("Hallo", "Überschrift", MessageBoxButtons.OK, MessageBoxIcon.Information)

' FMessageBox.Show("Hallo", "Überschrift", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

' If FMessageBox.Show("Löschen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
'     '...
' End If
#End Region

#Region " Abhängigkeiten/zusätzliche Dateien "
' - Verweise:
'   - VisiWinNET.Standard.Client
' - Indextexte in Gruppe
'   - Dialoge.Common
#End Region

Imports VisiWinNET.LanguageSwitching

Public Class FMessageBox

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen

    End Sub

#Region " Öffentliche Methoden <- hier weitere Beschreibungen "

    Public Enum DialogResultEx
        None = System.Windows.Forms.DialogResult.None
        OK = System.Windows.Forms.DialogResult.OK
        Cancel = System.Windows.Forms.DialogResult.Cancel
        Abort = System.Windows.Forms.DialogResult.Abort
        Retry = System.Windows.Forms.DialogResult.Retry
        Ignore = System.Windows.Forms.DialogResult.Ignore
        Yes = System.Windows.Forms.DialogResult.Yes
        No = System.Windows.Forms.DialogResult.No
        Button1 = 11
        Button2 = 12
        Button3 = 13
    End Enum

    ''' Aufruf des Dialoges zur Anzeige einer Nachricht (MessageBox)
    ''' (kehrt erst zurück, wenn der Dialog geschlossen wird).
    ''' Übergabe:
    '''   textType: Auswahl des Textbereiches, wenn bei Parameter "text" 
    '''             Pfad und Name eines Indextextes angegeben wird. 
    '''   text: Text der anzuzeigenden Meldung:
    '''         - direkte Angabe des Textes, z.B. "Hallo"
    '''         - Angabe von Pfad und Name eines Indextextes mit vorangestelltem @-Zeichen,
    '''           z.B. "@FCentral.Status.Text1"; durch den Parameter "textType" kann der Bereich
    '''           gewählt werden, in dem der Text definiert ist.
    '''   caption: Text für die Fensterüberschrift:
    '''            - direkte Angabe des Textes, z.B. "Hallo"
    '''            - Angabe von Pfad und Name eines Indextextes mit vorangestelltem @-Zeichen,
    '''              z.B. "@FCentral.Status.Text1"; der Parameter "textType" gilt hier nicht!
    '''              Es gilt immer der Bereich "ClientApplication", also die Textgruppe "Benutzertexte".
    '''   buttons: Auswahl der anzuzeigenden Schaltflächen.
    '''   icon: Auswahl des anzuzeigenden Symbols.
    '''   defaultButton: Angabe der Schaltfläche, die bei der Return-Taste betätigt wird.
    ''' Rückgabe:
    '''   ShowMessageBox: DialogResult.???: betätigte Schaltfläche
    Public Overloads Shared Function Show(ByVal text As String) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(TextTypes.ClientApplication, text, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal text As String, ByVal caption As String) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(TextTypes.ClientApplication, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(TextTypes.ClientApplication, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons, ByVal icon As System.Windows.Forms.MessageBoxIcon) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(TextTypes.ClientApplication, text, caption, buttons, icon, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons, ByVal icon As System.Windows.Forms.MessageBoxIcon, ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(TextTypes.ClientApplication, text, caption, buttons, icon, defaultButton)
    End Function

    Public Overloads Shared Function Show(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(textType, text, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String, ByVal caption As String) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(textType, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(textType, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons, ByVal icon As System.Windows.Forms.MessageBoxIcon) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(textType, text, caption, buttons, icon, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons, ByVal icon As System.Windows.Forms.MessageBoxIcon, ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton) As System.Windows.Forms.DialogResult
        Return ShowMessageBox(textType, text, caption, buttons, icon, defaultButton)
    End Function

    Public Overloads Shared Function ShowEx(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons, ByVal icon As System.Windows.Forms.MessageBoxIcon, ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton, ByVal buttonText1 As String, ByVal buttonText2 As String, ByVal buttonText3 As String) As DialogResultEx
        Return ShowMessageBox(textType, text, caption, buttons, icon, defaultButton)
    End Function

#End Region

#Region " Private Methoden "

    Private mIcon As System.Drawing.Icon

    Private Sub picMessageIcon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picMessageIcon.Paint
        e.Graphics.DrawIcon(mIcon, 0, 0)
    End Sub

    Private Shared Function ShowMessageBox(ByVal textType As VisiWinNET.LanguageSwitching.TextTypes, ByVal text As String, ByVal caption As String, ByVal buttons As System.Windows.Forms.MessageBoxButtons, ByVal icon As System.Windows.Forms.MessageBoxIcon, ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton) As System.Windows.Forms.DialogResult
        Dim frm As New FMessageBox
        Dim ret As DialogResult
        Dim graphics As System.Drawing.Graphics
        Dim sizeF As System.Drawing.SizeF

        'Meldetext anzeigen und Größe berechnen
        frm.lblMessage.LocalizedText.TextType = textType
        frm.lblMessage.LocalizedText.Text = text
        graphics = frm.lblMessage.CreateGraphics()
        sizeF = graphics.MeasureString(frm.lblMessage.Text, frm.lblMessage.Font, Screen.PrimaryScreen.WorkingArea.Width * 0.6)
        frm.lblMessage.Size = New Size(sizeF.Width + 2, System.Math.Max(sizeF.Height + 2, frm.picMessageIcon.Height))

        'Überschrift anzeigen und Größe berechnen
        frm.lblCaption.LocalizedText.Text = caption
        graphics = frm.lblCaption.CreateGraphics()
        sizeF = graphics.MeasureString(frm.lblCaption.Text, frm.lblCaption.Font, Screen.PrimaryScreen.WorkingArea.Width * 0.6)
        frm.lblCaption.Tag = CInt(sizeF.Width) + frm.cmdClose.Width + 4

        'Symbol festlegen
        Select Case icon
            Case MessageBoxIcon.Asterisk
                frm.mIcon = SystemIcons.Asterisk
            Case MessageBoxIcon.Error
                frm.mIcon = SystemIcons.Error
            Case MessageBoxIcon.Exclamation
                frm.mIcon = SystemIcons.Exclamation
            Case MessageBoxIcon.Hand, MessageBoxIcon.Stop
                frm.mIcon = SystemIcons.Hand
            Case MessageBoxIcon.Information
                frm.mIcon = SystemIcons.Information
            Case MessageBoxIcon.Question
                frm.mIcon = SystemIcons.Question
            Case MessageBoxIcon.Warning
                frm.mIcon = SystemIcons.Warning
            Case MessageBoxIcon.None
                frm.picMessageIcon.Visible = False
        End Select

        'Schaltflächen beschriften und Größe berechnen
        Select Case buttons
            Case MessageBoxButtons.AbortRetryIgnore
                frm.cmd1.LocalizedText.Text = "cmdAbort"
                frm.cmd1.DialogResult = System.Windows.Forms.DialogResult.Abort
                frm.cmd2.LocalizedText.Text = "cmdRetry"
                frm.cmd2.DialogResult = System.Windows.Forms.DialogResult.Retry
                frm.cmd3.LocalizedText.Text = "cmdIgnore"
                frm.cmd3.DialogResult = System.Windows.Forms.DialogResult.Ignore
                frm.pnlButtons.Width = 3 * frm.cmd1.Left + 3 * frm.cmd1.Width
                frm.cmdClose.Enabled = False
            Case MessageBoxButtons.OK
                frm.cmd1.LocalizedText.Text = "cmdOK"
                frm.cmd1.DialogResult = System.Windows.Forms.DialogResult.OK
                frm.cmd2.Visible = False
                frm.cmd3.Visible = False
                frm.pnlButtons.Width = 2 * frm.cmd1.Left + frm.cmd1.Width
                frm.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK
            Case MessageBoxButtons.OKCancel
                frm.cmd1.LocalizedText.Text = "cmdOK"
                frm.cmd1.DialogResult = System.Windows.Forms.DialogResult.OK
                frm.cmd2.LocalizedText.Text = "cmdCancel"
                frm.cmd2.DialogResult = System.Windows.Forms.DialogResult.Cancel
                frm.cmd3.Visible = False
                frm.pnlButtons.Width = 2.5 * frm.cmd1.Left + 2 * frm.cmd1.Width
                frm.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Case MessageBoxButtons.RetryCancel
                frm.cmd1.LocalizedText.Text = "cmdRetry"
                frm.cmd1.DialogResult = System.Windows.Forms.DialogResult.Retry
                frm.cmd2.LocalizedText.Text = "cmdCancel"
                frm.cmd2.DialogResult = System.Windows.Forms.DialogResult.Cancel
                frm.cmd3.Visible = False
                frm.pnlButtons.Width = 2.5 * frm.cmd1.Left + 2 * frm.cmd1.Width
                frm.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Case MessageBoxButtons.YesNo
                frm.cmd1.LocalizedText.Text = "cmdYes"
                frm.cmd1.DialogResult = System.Windows.Forms.DialogResult.Yes
                frm.cmd2.LocalizedText.Text = "cmdNo"
                frm.cmd2.DialogResult = System.Windows.Forms.DialogResult.No
                frm.cmd3.Visible = False
                frm.pnlButtons.Width = 2.5 * frm.cmd1.Left + 2 * frm.cmd1.Width
                frm.cmdClose.Enabled = False
            Case MessageBoxButtons.YesNoCancel
                frm.cmd1.LocalizedText.Text = "cmdYes"
                frm.cmd1.DialogResult = System.Windows.Forms.DialogResult.Yes
                frm.cmd2.LocalizedText.Text = "cmdNo"
                frm.cmd2.DialogResult = System.Windows.Forms.DialogResult.No
                frm.cmd3.LocalizedText.Text = "cmdCancel"
                frm.cmd3.DialogResult = System.Windows.Forms.DialogResult.Cancel
                frm.pnlButtons.Width = 3 * frm.cmd1.Left + 3 * frm.cmd1.Width
                frm.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End Select

        'Vorgabeschaltfläche festlegen
        Select Case defaultButton
            Case MessageBoxDefaultButton.Button1
                frm.AcceptButton = frm.cmd1
            Case MessageBoxDefaultButton.Button2
                frm.AcceptButton = frm.cmd2
            Case MessageBoxDefaultButton.Button3
                frm.AcceptButton = frm.cmd3
        End Select

        'Größe der MessageBox berechnen und Elemente platzieren
        If icon = MessageBoxIcon.None Then
            frm.lblMessage.Left = frm.picMessageIcon.Left
        End If
        frm.Height = frm.lblMessage.Top + System.Math.Max(frm.lblMessage.Height, frm.picMessageIcon.Height) + frm.pnlButtons.Height + 3 * frm.picMessageIcon.Left
        frm.Width = System.Math.Max(System.Math.Max(CInt(frm.lblCaption.Tag), frm.pnlButtons.Width), frm.lblMessage.Left + frm.lblMessage.Width + frm.picMessageIcon.Left)
        frm.pnlButtons.Left = (frm.ClientSize.Width - frm.pnlButtons.Width) / 2

        'MessageBox anzeigen
        ret = frm.ShowDialog()
        frm.Dispose()
        Return ret

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
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location = New System.Drawing.Point(Me.Location.X - Me.mX + e.X, Me.Location.Y - Me.mY + e.Y)
        End If
    End Sub

#End Region

End Class

