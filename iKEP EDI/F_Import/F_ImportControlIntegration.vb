Public Class F_ImportControlIntegration
    Public limport As Integer

    Sub afficheArticle()
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader

        Try
            sSql = "SELECT distinct ArtCode_Trs FROM CommandeVente_ControleIntegration" & " where importid=" & limport & " order by ArtCode_Trs"

            leRs = SqlLit(sSql, conSqlEDI)

            Me.gArticle.Rows.Clear()
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                Me.gArticle.Rows.Add(leRs("ArtCode_Trs"))
            End While
            leRs.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Sub afficheBilan()
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader
        Dim nbl As Integer = 0
        Dim LigneOK As Boolean

        Try
            sSql = "SELECT Action, statutaction, CodeClient_Trs,NumContrat_Trs,NumCdeEDI_Trs,ArtCode_Trs,Type_Trs,Date_Trs,Qte_Trs,NumCde_Trs,NumLigne_Trs,TypeCde_ERP,NumCde_ERP " _
                & ",NumLigne_ERP,NumCdeEDI_ERP,ArtCode_ERP,Qte_ERP,StatutLigne,date_ERP,CodeClient_ERP FROM CommandeVente_ControleIntegration" _
                & " where importid=" & limport

            If Me.tArticle.Text <> "Tous les articles" Then sSql &= " and ArtCode_Trs='" & Me.tArticle.Text & "'"

            If Me.optionAno.Checked And Not optionOK.Checked Then sSql &= " and statutAction=0"
            If Not Me.optionAno.Checked And optionOK.Checked Then sSql &= " and statutAction=1"
            If Not Me.optionAno.Checked And Not optionOK.Checked Then sSql &= " and 1=2"

            sSql &= " order by NumContrat_Trs,NumCde_Trs,NumLigne_Trs"

            Me.gControle.Rows.Clear()
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                nbl += 1
                If Nz(leRs("StatutAction"), 0) = 1 Then LigneOK = True Else LigneOK = False
                Me.gControle.Rows.Add(leRs("Action"), Me.iML.Images(IIf(LigneOK, 0, 1)), leRs("CodeClient_Trs"), leRs("ArtCode_Trs"), leRs("Date_Trs"), leRs("Type_Trs"), leRs("NumCde_Trs"), leRs("NumLigne_Trs"), leRs("Qte_Trs") _
                , leRs("CodeClient_ERP"), leRs("ArtCode_ERP"), leRs("date_ERP"), leRs("TypeCde_ERP"), leRs("NumCde_ERP"), leRs("NumLigne_ERP"), leRs("Qte_ERP"))
                If Not LigneOK Then

                    If Nz(leRs("Action"), "") = "Suppr" Then
                        For i = 9 To 15 : Me.gControle.Rows(Me.gControle.RowCount - 1).Cells(i).Style.BackColor = coulSuppr : Next i
                    End If

                    If Nz(leRs("Action"), "") = "Modif" Then
                        For i = 2 To 8
                            With Me.gControle.Rows(Me.gControle.RowCount - 1)
                                If Nz(.Cells(i).Value, "") <> Nz(.Cells(i + 7).Value, "") Then
                                    .Cells(i).Style.BackColor = coulSuppr
                                    .Cells(i + 7).Style.BackColor = coulSuppr
                                End If
                            End With
                        Next i
                    End If

                End If
            End While
            leRs.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub F_ImportControlIntegration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficheArticle
        Call afficheBilan()
        Me.Focus()

    End Sub

    Private Sub BAfficher_Click(sender As Object, e As EventArgs) Handles bAfficher.Click
        Call afficheBilan()
    End Sub

    Private Sub GArticle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gArticle.CellContentClick

    End Sub

    Private Sub gArticle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gArticle.CellDoubleClick
        If Me.tArticle.Text <> Me.gArticle.Rows(e.RowIndex).Cells(0).Value Then
            Me.tArticle.Text = Me.gArticle.Rows(e.RowIndex).Cells(0).Value
        Else
            Me.tArticle.Text = "Tous les articles"
        End If
        Call afficheBilan()
    End Sub
End Class