Public Class F_ImportArchive
    Public leTiers As Integer
    Sub ImportListe()
        Me.cImport.Items.Clear()
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader
        Dim d As Date
        Try
            sSql = "select top 70 importid,dateimport  from app.import where userlogin='" & leUser.Login & "' and tiersid=" & leTiers & " order by importid desc"
            Me.cImport.Items.Clear()
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                d = leRs(1)
                Me.cImport.Items.Add(New ListItem(leRs(0), "Import " & leRs(0) & " du " & d.ToString("dd/MM/yyyy HH:mm")))
            End While
            leRs.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub afficheArticle()
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader

        If Me.cImport.SelectedIndex < 0 Then Exit Sub
        Try
            sSql = "SELECT ArtCode_ERP,min(DateTransfert) as dateTransfert FROM CommandeVente_Transfert where importid=" & Me.cImport.SelectedItem.value & " group by artcode_ERP order by dateTransfert desc"
            Me.gArticle.Rows.Clear()
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                Me.gArticle.Rows.Add(leRs("ArtCode_ERP"), leRs("dateTransfert"))
            End While
            leRs.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Sub afficheBilan()
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader

        If Me.cImport.SelectedIndex < 0 Then Exit Sub

        Try
            sSql = "SELECT NumContrat, ArtCode_ERP, TypeBesoin, DateBesoin, QteBesoin, NumCde_ERP, NumLigne_ERP, NumLigne_Prop, CodeClient " _
                & " FROM CommandeVente_Transfert" _
                & " WHERE NumLigne_Prop <> '' and statuttransfert<>'T' and  importid=" & Me.cImport.SelectedItem.value

            If Me.tArticle.Text <> "Tous les articles" Then sSql &= " and ArtCode_ERP='" & Me.tArticle.Text & "'"

            sSql &= " order by NumContrat,Article, NumCde_ERP,dateBesoin"
            Me.gControle.Rows.Clear()
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                Me.gControle.Rows.Add(leRs("CodeClient"), leRs("NumContrat"), leRs("ArtCode_ERP"), Date2Grid(leRs("DateBesoin")), leRs("TypeBesoin"), leRs("QteBesoin"), leRs("NumCde_ERP"), leRs("NumLigne_ERP"), leRs("NumLigne_Prop"))
            End While
            leRs.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub gArticle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gArticle.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If Me.tArticle.Text <> Me.gArticle.Rows(e.RowIndex).Cells(0).Value Then
            Me.tArticle.Text = Me.gArticle.Rows(e.RowIndex).Cells(0).Value
        Else
            Me.tArticle.Text = "Tous les articles"
        End If
        Call afficheBilan()
    End Sub

    Private Sub F_ImportArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ImportListe()
    End Sub

    Private Sub CImport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cImport.SelectedIndexChanged
        Call afficheArticle()
        Call afficheBilan()
    End Sub

    Private Sub GArticle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gArticle.CellContentClick

    End Sub
End Class