Public Class F_Tiers
    Public TiersId As Integer


    Sub listeSiteERP()
        Dim leRs As OleDb.OleDbDataReader

        Me.gTiersSiteERP.Rows.Clear()
        leRs = sqlLit("SELECT TSEId,SiteCode,CodeEDI,CodeERP FROM app.TiersSiteERP where TiersId=" & Me.TiersId, conSqlEDI)
        While leRs.Read
            Me.gTiersSiteERP.Rows.Add(leRs("TSEId"), leRs("SiteCode"), leRs("CodeEDI"), leRs("CodeERP"))
        End While
        leRs.Close()

    End Sub

    Sub listeDoc()
        Dim leRs As OleDb.OleDbDataReader

        Me.gDoc.Rows.Clear()
        leRs = sqlLit("SELECT tiersid,docNom,Docref from app.TiersDoc where TiersId=" & Me.TiersId, conSqlEDI)
        While leRs.Read
            Me.gDoc.Rows.Add(leRs("tiersid"), leRs("docNom"), leRs("Docref"))
        End While
        leRs.Close()

    End Sub


    Sub listeUser()
        Dim leRs As OleDb.OleDbDataReader

        Me.gUser.Rows.Clear()
        leRs = sqlLit("Select  UserLogin FROM app.TiersUser where TiersId=" & Me.TiersId, conSqlEDI)
        While leRs.Read
            Me.gUser.Rows.Add(leRs("UserLogin"))
        End While
        leRs.Close()

    End Sub

    Private Sub F_Tiers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call formVide(Me)
        Me.gUser.Rows.Clear()

        If TiersId <> 0 Then
            Call FormRempli(Me, "select TiersId,TiersNom,tiersLoadFile from app.Tiers where TiersId=" & Me.TiersId, conSqlEDI)
            Call listeUser()
            Call listeSiteERP()
            Call listeDoc
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.TiersId = FormEnreg(Me, "app.Tiers", conSqlEDI)

        sqlDo("Delete from app.TiersUser where tiersid=" & Me.TiersId, conSqlEDI)
        For i = 0 To Me.gUser.Rows.Count - 1
            If Me.gUser.Rows(i).Cells("Nom").Value <> "" Then sqlDo("Insert into app.TiersUser (TiersId, UserLogin) values (" & Me.TiersId & ",'" & Me.gUser.Rows(i).Cells("Nom").Value & "')", conSqlEDI)
        Next

        sqlDo("Delete from app.TiersSiteERP where tiersid=" & Me.TiersId, conSqlEDI)
        For i = 0 To Me.gTiersSiteERP.Rows.Count - 1
            With Me.gTiersSiteERP.Rows(i)
                If nz(.Cells("SiteCode").Value, "") <> "" Then sqlDo("Insert into app.TiersSiteERP (TiersId, SiteCode,CodeEDI,CodeERP) values (" & Me.TiersId & ",'" & .Cells("SiteCode").Value & "','" & .Cells("CodeEDI").Value & "','" & .Cells("CodeERP").Value & "')", conSqlEDI)
            End With
        Next

        sqlDo("Delete from app.TiersDoc where tiersid=" & Me.TiersId, conSqlEDI)
        For i = 0 To Me.gDoc.Rows.Count - 1
            With Me.gDoc.Rows(i)
                If nz(.Cells("DocNom").Value, "") <> "" Then sqlDo("Insert into app.TiersDoc (TiersId, DocNom,DocRef) values (" & Me.TiersId & ",'" & .Cells("DocNom").Value & "','" & .Cells("DocRef").Value & "')", conSqlEDI)
            End With
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub gUser_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gUser.CellContentClick

    End Sub
End Class