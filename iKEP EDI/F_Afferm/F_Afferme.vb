Public Class F_Afferme

    Sub afficheAfferme()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim client As String = ""


        AttenteDemarre("Lecture en cours...")

        Try

            Me.gAfferme.Visible = False
            Me.gAfferme.Rows.Clear()

            sSql = "select nocommande, nolignecommande, l.codeclient, C.nomclient,datesouhplustard, codearticleprestto,quantitecommandee" _
            & " from comc L" _
            & " left join cli C on C.codeclient=L.codeclient " _
            & " where resteExpedier='O' And qteprevueouFerme='P'"
            If Me.tClient.Text <> "" Then sSql &= " and ( l.codeclient like '%" & Me.tClient.Text & "%' or C.nomclient like '%" & Me.tClient.Text & "%')"
            If Me.tArticle.Text <> "" Then sSql &= " and codearticleprestto like '%" & Me.tArticle.Text & "%'"
            sSql &= " and datesouhplustard<='" & Now.AddMonths(Me.tHorizon.Text).ToShortDateString & "' order by l.codeclient,nocommande,nolignecommande,datesouhplustard"

            lers = sqlLit(sSql, conSqlSilog)
            While lers.Read
                Me.gAfferme.Rows.Add(nz(lers("codeclient"), "") & " - " & nz(lers("nomclient"), ""), False, nz(lers("nocommande"), ""), nz(lers("nolignecommande"), ""), nz(lers("datesouhplustard"), ""), nz(lers("codearticleprestto"), ""), Val(nz(lers("quantitecommandee"), 0)), lers("codeclient"))
            End While
            lers.Close()
            Me.gAfferme.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AttenteFin()
    End Sub

    Private Sub F_Afferme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        My.Settings.Reload()
        Me.tHorizon.Text = My.Settings.HorizonAfferme
        '        Call afficheAfferme()
    End Sub

    Private Sub CSel_CheckedChanged(sender As Object, e As EventArgs) Handles cSel.CheckedChanged
        For i = 0 To Me.gAfferme.RowCount - 1
            If Me.gAfferme.Rows(i).Cells("Client").Value <> "" Then Me.gAfferme.Rows(i).Cells("sel").Value = Me.cSel.Checked
        Next
    End Sub

    Private Sub BAfficher_Click(sender As Object, e As EventArgs) Handles bAfficher.Click
        My.Settings.HorizonAfferme = Val(Me.tHorizon.Text)
        My.Settings.Save()
        Call afficheAfferme()

    End Sub

    Private Sub TClient_TextChanged(sender As Object, e As EventArgs) Handles tClient.TextChanged

    End Sub

    Private Sub tClient_KeyUp(sender As Object, e As KeyEventArgs) Handles tClient.KeyUp
        If e.KeyCode = Keys.Enter Then Call afficheAfferme()
    End Sub

    Private Sub tHorizon_KeyUp(sender As Object, e As KeyEventArgs) Handles tHorizon.KeyUp
        If e.KeyCode = Keys.Enter Then Call afficheAfferme()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sSql As String = ""
        Dim laCommande As String = ""
        Dim lIdent As String = "EDI_JOUR"

        If MsgBox("Affermir les commandes  ?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Question) <> MsgBoxResult.Ok Then Exit Sub

        For i = 0 To Me.gAfferme.RowCount - 1
            With Me.gAfferme.Rows(i)
                If nz(.Cells("Sel").Value, False) = True Then

                    'ecrit dans MACRO_COMC 
                    sSql = "insert into MACRO_COMC (CodeClient,NoCommande,NoLigneCommande ,CodeArticleprestto,QtePrevueOuFerme,ident) values (" _
                                    & "'" & .Cells("CodeClient").Value & "','" & .Cells("NumCde").Value & "','" & .Cells("NumLigne").Value & "','" & .Cells("Article").Value _
                                   & "','F','" & lIdent & "')"
                    sqlDo(sSql, conSqlSilog)

                End If

            End With
        Next
        'ecrit dans MACRO_COME
        sSql = "insert into macro_come (codeclient, NoCommande, ident) (select  distinct CodeClient, NoCommande, ident From MACRO_COMC Where ident ='" & lIdent & "')"
        sqlDo(sSql, conSqlSilog)

        Call afficheAfferme()
    End Sub

    Private Sub tArticle_KeyUp(sender As Object, e As KeyEventArgs) Handles tArticle.KeyUp
        If e.KeyCode = Keys.Enter Then Call afficheAfferme()
    End Sub
End Class