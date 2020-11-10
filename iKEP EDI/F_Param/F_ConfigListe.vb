Public Class F_ConfigListe

    Sub listeConfig()
        Dim leRs As OleDb.OleDbDataReader
        Me.gUser.Rows.Clear()
        leRs = sqlLit("SELECT CfgId,CfgName,CheminSSIS,CheminImport,CheminExport FROM app.Config", conSqlEDI)
        While leRs.Read
            Me.gUser.Rows.Add(leRs("CfgId"), leRs("CfgName"), leRs("CheminSSIS"), leRs("CheminImport"), leRs("CheminExport"))
        End While
        leRs.Close()
    End Sub

    Private Sub F_ParamTiers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call listeConfig()
    End Sub

    Private Sub TiersPLus_Click(sender As System.Object, e As System.EventArgs) Handles TiersPLus.Click
        F_Config.CfgId = 0
        If F_Config.ShowDialog = Windows.Forms.DialogResult.OK Then listeConfig()
    End Sub

    Private Sub gTiers_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gUser.CellDoubleClick
        F_Config.CfgId = Me.gUser.Rows(e.RowIndex).Cells("CfgId").Value
        If F_Config.ShowDialog = Windows.Forms.DialogResult.OK Then listeConfig()

    End Sub

    Private Sub gTiers_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gUser.CellContentClick

    End Sub

    Private Sub TiersMoins_Click(sender As System.Object, e As System.EventArgs) Handles TiersMoins.Click

    End Sub
End Class