Imports System.Windows.Forms
Imports System

Public Class F_Main
    Public Sub fermetout()
        For Each ChildForm In Me.MdiChildren : ChildForm.Close() : Next
    End Sub

    Public Sub MenuDisable()
        Me.mUtil.Enabled = False
        Me.mConfig.Enabled = False
        Me.mTiers.Enabled = False
        Me.mAfferme.Visible = False
        Me.mImport.Visible = False
        Me.mExport.Visible = False
    End Sub

    Public Sub MenuEnable()
        Me.mAfferme.Visible = True
        Me.mImport.Visible = True
        Me.mExport.Visible = True
        Me.mUtil.Enabled = leUser.IsAdmin
        Me.mConfig.Enabled = leUser.IsAdmin
        Me.mTiers.Enabled = leUser.IsAdmin
    End Sub

    Sub ParamInit()

        My.Settings.Reload()
        Modedebug = My.Settings.ModeDebug
        If conSqlEDI.State <> ConnectionState.Closed Then conSqlEDI.Close()
        conSqlEDI.ConnectionString = My.Settings.SQLConEDI & ";Connection Timeout=300"

        'Charge données utilisateur
        If leUser.LitParam(leUser.Login) Then
            Me.sUser.Text = leUser.Login + " | " + leUser.Site + " | "
            Call MenuEnable()
        Else
            Call MenuDisable()
        End If

        If conSqlSilog.State <> ConnectionState.Closed Then conSqlSilog.Close()
        conSqlSilog.ConnectionString = My.Settings.SQLConSilog & ";Server=" & leUser.ServeurERP & ";Database=" & leUser.Base & ";"

    End Sub

    Private Sub F_MainLOad(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.tVersion.Text = My.Application.Info.Version.ToString
        Me.Text = My.Application.Info.ProductName
        leUser.Login = My.User.Name

        Call ParamInit()

    End Sub

    Private Sub UtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mUtil.Click
        Call fermetout()
        F_UsersListe.ShowDialog()
        Call ParamInit()
    End Sub

    Private Sub ParamétresGénérauxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mConfig.Click
        Call fermetout()
        F_ConfigListe.ShowDialog()
        Call ParamInit()
    End Sub

    Private Sub ParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mParam.Click
        If InputBox("Mot de passe ?") = "!KEP" Then
            If F_Param.ShowDialog = Windows.Forms.DialogResult.OK Then
                conSqlEDI.Close()
                Call F_MainLOad(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MMenu_Click(sender As Object, e As EventArgs) Handles mImport.Click
        Call fermetout()
        F_ImportCdeVente.MdiParent = Me
        F_ImportCdeVente.Show()
    End Sub

    Private Sub AffermissementSilogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mAfferme.Click
        Call fermetout()
        F_Afferme.MdiParent = Me
        F_Afferme.Show()
    End Sub

    Private Sub MTiers_Click(sender As Object, e As EventArgs) Handles mTiers.Click
        Call fermetout()
        F_TiersListe.ShowDialog()

    End Sub

    Private Sub F_Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        '    ConnexionFerme(conSqlEDI)
        '   ConnexionFerme(conSqlSilog)
    End Sub

    Private Sub MExport_Click(sender As Object, e As EventArgs) Handles mExport.Click

        Call fermetout()
        F_Export.MdiParent = Me
        F_Export.Show()
    End Sub

    Private Sub AideEnLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideEnLigneToolStripMenuItem.Click
        LienOuvre("index.html")
    End Sub

    Private Sub SUser_Click(sender As Object, e As EventArgs) Handles sUser.Click
    End Sub

    Private Sub sUser_DoubleClick(sender As Object, e As EventArgs) Handles sUser.DoubleClick
        If InputBox("Mot de passe") = "!KEP" Then
            leUser.Login = InputBox("Login")
            Call ParamInit()
        End If
    End Sub

    Private Sub TVersion_Click(sender As Object, e As EventArgs) Handles tVersion.Click
        DocOuvre("http://ikep-erp.fr/2019/10/02/ikep-edi-v2/")
    End Sub

    Private Sub TraitementsTiersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraitementsTiersToolStripMenuItem.Click
        Call fermetout()
        F_TiersTraitListe.ShowDialog()
    End Sub
End Class
