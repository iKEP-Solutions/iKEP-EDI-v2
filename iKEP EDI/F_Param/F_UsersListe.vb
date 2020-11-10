Public Class F_UsersListe

    Sub listeUser()
        Dim leRs As OleDb.OleDbDataReader
        Me.gUser.Rows.Clear()
        leRs = sqlLit("Select Userid,UserLogin from app.Users", conSqlEDI)
        While leRs.Read
            Me.gUser.Rows.Add(leRs("Userid"), leRs("UserLogin"))
        End While
        leRs.Close()
    End Sub

    Private Sub F_ParamTiers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call listeUser()
    End Sub

    Private Sub TiersPLus_Click(sender As System.Object, e As System.EventArgs) Handles TiersPLus.Click
        F_Users.UserId = 0
        If F_Users.ShowDialog = Windows.Forms.DialogResult.OK Then listeUser()
    End Sub

    Private Sub gTiers_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gUser.CellDoubleClick
        F_Users.UserId = Me.gUser.Rows(e.RowIndex).Cells("UserId").Value
        If F_Users.ShowDialog = Windows.Forms.DialogResult.OK Then listeUser()

    End Sub

    Private Sub gTiers_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gUser.CellContentClick

    End Sub

    Private Sub TiersMoins_Click(sender As Object, e As EventArgs) Handles TiersMoins.Click
        If MsgBox("Supprimer l'utilisateur  " & Me.gUser.SelectedRows(0).Cells("userLogin").Value & " ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            sqlDo("Delete from app.Users where UserLogin='" & Me.gUser.SelectedRows(0).Cells("userLogin").Value & "'", conSqlEDI)
            sqlDo("Delete from app.TiersUser where UserLogin='" & Me.gUser.SelectedRows(0).Cells("userLogin").Value & "'", conSqlEDI)
            Call listeUser()
        End If
    End Sub
End Class