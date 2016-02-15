
Public Class FCentral

#Region " Initialisierung "

    Private Sub FCentral_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 1000)
    End Sub

#End Region

#Region " Ereignisse "

    Private Sub TiKopfzeile_Kopplung_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiKopfzeile_Kopplung.Tick
        ' Anzeige Kommunikation PC <-> SPS nicht i.O.
        If VisiWinNET.Services.AppService.VWGetBit("SPS Ofen.Kopplung.Koordinierung", 8) = False Then
            VisiWinNET.Services.AppService.VWSet("Kopplung.Status_SPS_Kopplung_niO", True)
        Else
            VisiWinNET.Services.AppService.VWSet("Kopplung.Status_SPS_Kopplung_niO", False)
        End If
        VisiWinNET.Services.AppService.VWSetBit("SPS Ofen.Kopplung.Koordinierung", 8, False)
    End Sub

#End Region

End Class
