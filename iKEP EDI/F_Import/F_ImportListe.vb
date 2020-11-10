Imports System.IO
Public Class F_ImportListe

    Public leTiersId As Integer
    Public lImportId As Integer = 0

    Private Sub F_ImportListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader
        Dim cmb As New DataGridViewComboBoxColumn

        Me.gFichier.Rows.Clear()
        sSql = "SELECT distinct TypeTraitement FROM app.TiersTraitement where tiersid=" & leTiersId
        leRs = SqlLit(sSql, conSqlEDI)
        cmb.HeaderText = "Type"
        cmb.Name = "FicType"
        cmb.FillWeight = 30

        While leRs.Read
            cmb.Items.Add(leRs(0))

            '   Me.gTiers.Columns("TypeTrait")
        End While
        leRs.Close()
        Me.gFichier.Columns.Add(cmb)
        Call TiersPLus_Click(Nothing, Nothing)
    End Sub

    Private Sub TiersPLus_Click(sender As Object, e As EventArgs) Handles TiersPLus.Click
        Dim c As DataGridViewComboBoxCell
        oFileDialog.FileName = ""
        If oFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.gFichier.Rows.Add("", oFileDialog.FileName)
            c = Me.gFichier.Rows(Me.gFichier.RowCount - 1).Cells("FicType")
            If c.Items.Count = 1 Then Me.gFichier.Rows(Me.gFichier.RowCount - 1).Cells("FicType").Value = c.Items(0)
        End If

    End Sub

    Private Sub TiersMoins_Click(sender As Object, e As EventArgs) Handles TiersMoins.Click
        Me.gFichier.Rows.RemoveAt(Me.gFichier.SelectedRows(0).Index)
    End Sub

    Function ImportCdeVente(FichierSource As String, TypeFichier As String, MAZ As String) As Boolean
        Dim lETL As String
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader
        Dim importOK As Boolean = False
        Dim lesParam As New List(Of SSISParam)

        Try
            StatutBar("Recherche Traitement Tiers...")
            lETL = ""
            sSql = "select ETL from app.TiersTraitement where CatTraitId=1 and TypeTraitement='" & TypeFichier & "' and TiersId=" & Me.leTiersId
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                lETL = Nz(leRs(0), "")
            End While
            leRs.Close()

            If lETL <> "" Then
                StatutBar("Execution Traitement Tiers...")
                lesParam.Clear()
                lesParam.Add(New SSISParam("FichierSource", leUser.RepImport & FichierSource, "PACKAGE"))
                lesParam.Add(New SSISParam("TiersId", Me.leTiersId, "PACKAGE"))
                lesParam.Add(New SSISParam("UserLogin", leUser.Login, "PACKAGE"))
                '                lesParam.Add(New SSISParam("ServerSql", conSqlEDI.DataSource, "PROJET"))
                If SSISexecute(leUser.RepSSIS, lETL & ".dtsx", lesParam, "Importation des données") Then importOK = True
            End If
            StatutBar("")

        Catch ex As Exception
            MsgBox(ex.Message)
            importOK = False
            Throw New Exception(ex.Message)
        End Try
        Return importOK

    End Function

    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        'verif des type de chaque ligne
        Dim b As Boolean = False
        Dim lextension As String = ""
        Dim leNomSourceServer As String = ""
        Dim leNomSourcelocal As String = ""
        Dim nblignes As Integer = 0

        For i = 0 To Me.gFichier.RowCount - 1
            If Nz(Me.gFichier.Rows(i).Cells(1).Value, "") = "" Then b = True
        Next

        If b Then
            MsgBox("Certains fichier à importer n'ont pas de type", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
        Else
            Try
                b = False
                Me.gFichier.ClearSelection()
                SqlDo("Delete from commandeVente_EDI where tiersid=" & Me.leTiersId & " and userlogin='" & leUser.Login & "'", conSqlEDI)

                For i = 0 To Me.gFichier.RowCount - 1
                    Me.gFichier.Rows(i).Cells(0).Style.BackColor = Color.FromArgb(255, 100, 100)
                    StatutBar("Transfert Fichier sur serveur")
                    leNomSourcelocal = Me.gFichier.Rows(i).Cells("FicLocal").Value
                    lextension = leNomSourcelocal.Substring(leNomSourcelocal.LastIndexOf("."), leNomSourcelocal.Length - leNomSourcelocal.LastIndexOf("."))
                    leNomSourceServer = "\" & F_ImportCdeVente.lTiers.Text & "_" & Now.ToString("yyyyMMdd_HHmm") & "_" & i & lextension

                    StatutBar("Transfert du fichier sur serveur")
                    AttenteDemarre("Transfert " & leNomSourcelocal & " du fichier sur le serveur", 2)
                    FileCopy(leNomSourcelocal, leUser.RepImport & leNomSourceServer)
                    Me.gFichier.Rows(i).Cells("FicServ").Value = leUser.RepImport & leNomSourceServer
                    AttenteFin()

                    If ImportCdeVente(leNomSourceServer, Me.gFichier.Rows(i).Cells("FicType").Value, IIf(i = 0, "O", "N")) Then b = True
                Next i
            Catch ex As Exception
                Me.Focus()
                MessageBox.Show(ex.Message)
            End Try

            If b Then Me.DialogResult = DialogResult.OK Else Me.DialogResult = DialogResult.Cancel
            Me.Close()
            StatutBar("")

        End If
    End Sub

    Private Sub bAnnul_Click(sender As Object, e As EventArgs) Handles bAnnul.Click
        Me.gFichier.Rows.Clear()
        Me.DialogResult = DialogResult.No
        Me.Dispose()
    End Sub

    Private Sub gFichier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gFichier.CellContentClick

    End Sub
End Class