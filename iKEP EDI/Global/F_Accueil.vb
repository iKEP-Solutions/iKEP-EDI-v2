Public NotInheritable Class F_Accueil


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ApplicationTitle.Text = My.Application.Info.Title
        Version.Text = "V " & My.Application.Info.Version.ToString
    End Sub

End Class
