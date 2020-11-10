Public Class F_TiersTraitListe
    Sub listeTiers()
        Dim leRs As OleDb.OleDbDataReader

        Me.gTraitement.Rows.Clear()
        leRs = SqlLit("Select app.TiersTraitement.TiersTraitId, app.Tiers.TiersNom, app.CatTraitement.CatTraitLib, app.TiersTraitement.TypeTraitement, app.TiersTraitement.ETL " _
            & " FROM app.Tiers INNER JOIN app.TiersTraitement ON app.Tiers.TiersId = app.TiersTraitement.TiersId " _
            & " INNER JOIN app.CatTraitement ON app.TiersTraitement.CatTraitId = app.CatTraitement.catTraitId", conSqlEDI)
        While leRs.Read
            Me.gTraitement.Rows.Add(leRs("TiersTraitId"), leRs("TiersNom"), leRs("CatTraitLib"), leRs("TypeTraitement"), leRs("ETL"))
        End While
        leRs.Close()

    End Sub

    Private Sub F_TiersTrait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call listeTiers()
    End Sub

    Private Sub gTiers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gTraitement.CellContentClick

    End Sub

    Private Sub gTiers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gTraitement.CellDoubleClick
        F_TiersTrait.leTraitId = Me.gTraitement.Rows(e.RowIndex).Cells("TiersTraitId").Value
        If F_TiersTrait.ShowDialog = Windows.Forms.DialogResult.OK Then listeTiers()
    End Sub

    Private Sub TiersPLus_Click(sender As Object, e As EventArgs) Handles TiersPLus.Click
        F_TiersTrait.leTraitId = 0
        If F_TiersTrait.ShowDialog = Windows.Forms.DialogResult.OK Then listeTiers()
    End Sub

    Private Sub TiersMoins_Click(sender As Object, e As EventArgs) Handles TiersMoins.Click
        If MsgBox("Supprimer le Traitement  " & Me.gTraitement.SelectedRows(0).Cells("ETL").Value & " ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            SqlDo("Delete from app.TiersTraitement where TiersTraitId='" & Me.gTraitement.SelectedRows(0).Cells("TiersTraitId").Value & "'", conSqlEDI)
            Call listeTiers()
        End If
    End Sub
End Class