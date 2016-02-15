Public Class FBildschirm_reinigen
#Region " Initialisierung "

    Private Sub FBildschirm_reinigen_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TiBildschirm_reinigen.Enabled = True
        PgbBildschirm_reinigen.Value = 0
    End Sub

    Private Sub FBildschirm_reinigen_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 1110)
    End Sub

#End Region

#Region " Ereignisse "

    Private Sub TiBildschirm_reinigen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiBildschirm_reinigen.Tick
        PgbBildschirm_reinigen.Value = PgbBildschirm_reinigen.Value + 10
        If PgbBildschirm_reinigen.Value >= 100 Then
            TiBildschirm_reinigen.Enabled = False
            Me.Close()
        End If
    End Sub

#End Region

End Class
