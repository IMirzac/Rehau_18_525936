Public Class FVorlage_Kopf_Fusszeile
#Region " Ereignisse "

    Private Sub sisTasten_Bedienerfuehrung_Diagnose_BitChange(ByVal sender As Object, ByVal e As VisiWinNET.DataAccess.BitChangeEventArgs) Handles sisTasten_Bedienerfuehrung_Diagnose.BitChange
        Select Case e.BitNumber
            Case 8
                If e.BitValue = True Then
                    keyFunktionstaste11.Blink.Enabled = True
                    keyFunktionstaste11.Blink.Mode = VisiWinNET.Services.BlinkMode.BlinkColor
                Else
                    keyFunktionstaste11.Blink.Enabled = False
                    keyFunktionstaste11.Blink.Mode = VisiWinNET.Services.BlinkMode.EventOnly
                End If
            Case 9
                If e.BitValue = True Then
                    keyFunktionstaste12.Blink.Enabled = True
                    keyFunktionstaste12.Blink.Mode = VisiWinNET.Services.BlinkMode.BlinkColor
                Else
                    keyFunktionstaste12.Blink.Enabled = False
                    keyFunktionstaste12.Blink.Mode = VisiWinNET.Services.BlinkMode.EventOnly
                End If
        End Select
        Me.Update()
    End Sub

#End Region
End Class

