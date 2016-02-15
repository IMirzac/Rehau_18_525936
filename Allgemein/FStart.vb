Public Class FStart

    Protected Overrides Sub OnInitReady(ByVal sender As Object, ByVal e As VisiWinNET.Project.ProjectManagerEventArgs)

        MyBase.OnInitReady(sender, e)

        If e.Success Then
            mSystemStartTime = DateTime.Now

            'Taskleiste.HideStartButton()
            'Taskleiste.HideTaskBar()

            'Fügen Sie hier weitere Initialisierungen hinzu.
            VisiWinNET.Forms.ProjectForms.Load("FCentral")
            VisiWinNET.Forms.ProjectForms.Load("FStatus_Daten")
            VisiWinNET.Forms.ProjectForms.Load("FRecipe")
            VisiWinNET.Forms.ProjectForms.Load("FStatus_Hand")
            VisiWinNET.Forms.ProjectForms.Load("FProtokoll")
            VisiWinNET.Forms.ProjectForms.Load("FTrend")
            VisiWinNET.Forms.ProjectForms.Load("FBenutzerverwaltung")
            VisiWinNET.Forms.ProjectForms.Load("FUser")
            VisiWinNET.Forms.ProjectForms.Load("FEinstellungen")
            VisiWinNET.Forms.ProjectForms.Load("FBildschirm_reinigen")
            VisiWinNET.Forms.ProjectForms.Load("FBedienerfuehrung")
            VisiWinNET.Forms.ProjectForms.Load("FAlarm")
            VisiWinNET.Forms.ProjectForms.Load("FAlarmHistory")
            VisiWinNET.Forms.ProjectForms.Load("FStatistic")
            VisiWinNET.Forms.ProjectForms.Show("FCentral")
        Else
            MessageBox.Show("Project startup failed", "VisiWinNET Standard", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Exit()
        End If

    End Sub

    Protected Overrides Sub OnProjectShutdownStarted()
        'Projekt aufräumen
        MyBase.OnProjectShutdownStarted()

        Taskleiste.ShowStartButton()
        Taskleiste.ShowHideTaskBar()

        'Alle VisiWinNET-Formulare entladen
        For Each frm As Form In VisiWinNET.Forms.ProjectForms.LoadedForms
            If frm IsNot Me Then
                VisiWinNET.Forms.ProjectForms.Unload(frm.Name)
            End If
        Next

        'Alle sonstigen offenen Formulare schließen
        For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
            If Application.OpenForms(i) IsNot Me Then
                Application.OpenForms(i).Close()
            End If
        Next

        'Entfernen Sie hier sonstige instanzierte Objekte (.Dispose).

    End Sub
    Private Shared mSystemStartTime As DateTime
    Public Shared ReadOnly Property SystemStartTime() As DateTime
        Get
            Return mSystemStartTime
        End Get
    End Property

End Class
