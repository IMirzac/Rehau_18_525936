Public Class FVorlage_Kopf_Fuss_Stoerzeile

    Private Sub VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile_BitChange(ByVal sender As Object, ByVal e As VisiWinNET.DataAccess.BitChangeEventArgs) Handles VWSsVorlage_Kopf_Fuss_Stoerzeile_Stoerzeile.BitChange
        ' Stoerzeile ein- bzw. ausblenden
        If e.BitValue = True Then
            alnStoerzeile.Visible = True
        Else
            alnStoerzeile.Visible = False
        End If
    End Sub
End Class
