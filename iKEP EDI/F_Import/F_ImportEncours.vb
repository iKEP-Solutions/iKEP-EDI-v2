Public Class F_ImportEncours
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Sub AfficheNbLigne()
        Dim leRs As OleDb.OleDbDataReader
        Dim sSql As String
        Dim nbLignes As Integer = 0

        Me.gEncours.Visible = False
        Me.gEncours.Rows.Clear()

        sSql = "select codeclient, nocommande,count(*) as NbL from macro_comc where ident ='EDI_JOUR' group by codeclient, nocommande"
        leRs = SqlLit(sSql, conSqlSilog)
        While leRs.Read
            Me.gEncours.Rows.Add(leRs("codeclient"), leRs("nocommande"), leRs("NbL"))
            nbLignes += leRs("Nbl")
        End While
        leRs.Close()

        Me.tNbLigJour.Text = nbLignes

        Me.gEncours.Visible = True
    End Sub
    Private Sub F_Encours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AfficheNbLigne()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call AfficheNbLigne()
    End Sub
End Class