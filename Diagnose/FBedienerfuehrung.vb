Public Class FBedienerfuehrung

#Region " Initialiserung "

    Private Sub FBedienerfuehrung_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 8000)
    End Sub

#End Region

End Class
