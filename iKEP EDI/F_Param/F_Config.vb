Public Class F_Config

    Public CfgId As Integer

    Private Sub F_Tiers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call formVide(Me)
        If CfgId <> 0 Then
            Call FormRempli(Me, "SELECT CfgId,CfgName,CheminSSIS,CheminImport,CheminExport FROM app.Config where CfgId=" & Me.CfgId, conSqlEDI)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.CfgId = FormEnreg(Me, "app.Config", conSqlEDI)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class