Public Class F_Doc

    Public leTiersid As Integer

    Private Sub F_Doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim leRs As OleDb.OleDbDataReader

        Me.gDoc.Rows.Clear()
        leRs = sqlLit("SELECT tiersid,docNom,Docref from app.TiersDoc where TiersId=" & leTiersid, conSqlEDI)
        While leRs.Read
            Me.gDoc.Rows.Add(leRs("tiersid"), leRs("docNom"), leRs("Docref"))
        End While
        leRs.Close()

    End Sub

    Private Sub GDoc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gDoc.CellContentClick

    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gDoc.CellDoubleClick
        DocOuvre(Me.gDoc.Rows(e.RowIndex).Cells("Docref").Value)

    End Sub
End Class