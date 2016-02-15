Imports System.Data
Imports System.IO

Public Class FProtokollSelect

    Public Sub New()
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        With dgvProtokolle
            .DataSource = ReadChargesForRecipeSelect().Tables("Kopfdaten")
            .Columns(0).MinimumWidth = 160
            .Columns(0).HeaderText = "Charge"
            .Columns(1).MinimumWidth = 160
            .Columns(1).HeaderText = "Datum/Zeit"
        End With
    End Sub


#Region " Ereignisse "

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

#Region " Öffentliche Methoden"

    Public Shared Function ShowProtokollDialog() As String
        Dim frm As New FProtokollSelect
        Dim Charge As String = ""
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frm.dgvProtokolle.Rows.Count > 0 Then
                Charge = frm.dgvProtokolle.Item("Charge", frm.dgvProtokolle.SelectedRows.Item(0).Index).Value
            End If
        End If
        frm.Dispose()
        Return Charge
    End Function
#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class
