Public Class FStatus_Hand

#Region " Initialisierung "

    Private Sub FStatus_Hand_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 4000)
    End Sub

#End Region

End Class
