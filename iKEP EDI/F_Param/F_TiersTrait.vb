Public Class F_TiersTrait
    Public leTraitId As Integer
    Private Sub F_TiersTrait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormVide(Me)
        ComboRempli("SELECT TiersId,TiersNom FROM app.Tiers", Me.lSite, conSqlEDI)
        ComboRempli("SELECT catTraitId,CatTraitLib FROM app.CatTraitement", Me.lCatTrait, conSqlEDI)

        If leTraitId <> 0 Then
            Call FormRempli(Me, "SELECT TiersTraitId, TypeTraitement, ETL, TiersId, CatTraitId FROM app.TiersTraitement where TiersTraitId=" & Me.leTraitId, conSqlEDI)
        End If
    End Sub

    Private Sub bAnnul_Click(sender As Object, e As EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        Me.leTraitId = FormEnreg(Me, "app.TiersTraitement", conSqlEDI)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class