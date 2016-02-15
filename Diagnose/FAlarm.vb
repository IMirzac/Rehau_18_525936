Public Class FAlarm

#Region " Initialisierung "

    Private Sub FAlarm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 9000)
    End Sub

#End Region

    Private Sub cmdzurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdzurueck.Click

    End Sub

End Class
