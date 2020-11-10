Public Class F_Param

    Private Sub F_Param_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        pGrid1.SelectedObject = My.Settings
    End Sub

    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        My.Settings.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()

    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        My.Settings.Reload()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        '        Me.Dispose()
    End Sub

    Private Sub bTestCon_Click(sender As System.Object, e As System.EventArgs) Handles bTestCon.Click
        Try
            If ConnexionTest(My.Settings.SQLConEDI) Then
                MessageBox.Show("Connexion SQL réussie")
            Else
                MessageBox.Show("Echec Connexion SQL")
            End If


            If ConnexionTest(My.Settings.SQLConSilog & ";Server=" & leUser.ServeurERP & ";Database=" & leUser.Base & ";") Then
                MessageBox.Show("Connexion SILOG réussie")
            Else
                MessageBox.Show("Echec Connexion SILOG : " & My.Settings.SQLConSilog & ";Server=" & leUser.ServeurERP & ";Database=" & leUser.Base & ";")
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class