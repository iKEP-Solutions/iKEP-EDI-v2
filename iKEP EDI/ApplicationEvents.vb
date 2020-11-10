Namespace My
    ' Les événements suivants sont disponibles pour MyApplication :
    ' Startup : Déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : Déclenché après la fermeture de tous les formulaires de l'application.  Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : Déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : Déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : Déclenché quand la connexion réseau est connectée ou déconnectée.
    Partial Friend Class MyApplication

        'Private Sub test(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
        '    Try
        '        MessageBox.Show(e.Exception.Message)
        '        ConnexionFerme(conSqlEDI)
        '        ConnexionFerme(conSqlSilog)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Sub


        'Private Sub TESTCON() Handles Me.NetworkAvailabilityChanged
        '    If Not My.Computer.Network.IsAvailable Then
        '        MsgBox("Aucune Connexion Internet")
        '        F_Main.MenuDisable()
        '    Else
        '        F_Main.MenuEnable()
        '    End If
        'End Sub
    End Class
End Namespace
