Imports System.Windows.Forms
Imports System.IO


Public NotInheritable Class F_SSISAttente
    Public limage As Integer
    Sub AttMsg(leTxt)
        Me.tAttTxt.Invoke(Sub()
                              Me.tAttTxt.Text = leTxt
                              Me.Refresh()
                          End Sub)
    End Sub

    Private Sub F_ImportAttente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Visible = (limage = 1)
        Me.PictureBox2.Visible = (limage <> 1)
    End Sub
End Class
