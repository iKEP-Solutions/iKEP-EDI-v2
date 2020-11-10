Public Class F_Users
    Public UserId As Integer


    Sub listeDroit()
        Me.cDroit.Items.Clear()
        Me.cDroit.Items.Add(New ListItem(0, "Admin"))
        Me.cDroit.Items.Add(New ListItem(1, "Utilisateur"))
    End Sub

    Private Sub F_Tiers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call formVide(Me)
        ComboRempli("Select sitecode, sitenom from app.site", Me.lSite, conSqlEDI)
        ComboRempli("SELECT CfgId,CfgName FROM app.Config", Me.lConfig, conSqlEDI)
        Call listeDroit()

        If UserId <> 0 Then
            Call FormRempli(Me, "select UserId,UserLogin,CfgId,Droit,SIteCode from app.Users where UserId=" & Me.UserId, conSqlEDI)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.UserId = FormEnreg(Me, "app.Users", conSqlEDI)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class