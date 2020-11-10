Public Class F_TiersListe

    Sub listeTiers()
        Dim leRs As OleDb.OleDbDataReader

        Me.gTiers.Rows.Clear()
        leRs = SqlLit("Select TiersId,TiersNom FROM app.Tiers", conSqlEDI)
        While leRs.Read
            Me.gTiers.Rows.Add(leRs("TiersId"), leRs("TiersNom"))
        End While
        leRs.Close()

    End Sub

    Private Sub F_ParamTiers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call listeTiers()
    End Sub


    Private Sub TiersPLus_Click(sender As System.Object, e As System.EventArgs) Handles TiersPLus.Click
        F_Tiers.TiersId = 0
        If F_Tiers.ShowDialog = Windows.Forms.DialogResult.OK Then listeTiers()
    End Sub

    Private Sub gTiers_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gTiers.CellContentClick

    End Sub

    Private Sub gTiers_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gTiers.CellDoubleClick
        F_Tiers.TiersId = Me.gTiers.Rows(e.RowIndex).Cells("TiersId").Value
        If F_Tiers.ShowDialog = Windows.Forms.DialogResult.OK Then listeTiers()

    End Sub

    Private Sub TiersMoins_Click(sender As Object, e As EventArgs) Handles TiersMoins.Click
        If MsgBox("Supprimer le tiers " & Me.gTiers.SelectedRows(0).Cells("Nom").Value & " ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            sqlDo("Delete from app.Tiers where tiersid=" & Me.gTiers.SelectedRows(0).Cells("Tiersid").Value, conSqlEDI)
            sqlDo("Delete from app.TiersSiteERP where tiersid=" & Me.gTiers.SelectedRows(0).Cells("Tiersid").Value, conSqlEDI)
            sqlDo("Delete from app.TiersUser where tiersid=" & Me.gTiers.SelectedRows(0).Cells("Tiersid").Value, conSqlEDI)
            SqlDo("Delete from app.TiersTraitement where tiersid=" & Me.gTiers.SelectedRows(0).Cells("Tiersid").Value, conSqlEDI)
            Call listeTiers()
        End If
    End Sub
End Class