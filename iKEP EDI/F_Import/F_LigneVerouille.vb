Public Class F_LigneVerouille

    Public lesCde As String

    Private Sub F_LigneVerouille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.gCdeVerou.Rows.Clear()

        For Each s In lesCde.Split("!")
            If s <> "" Then Me.gCdeVerou.Rows.Add(s.Split("#")(0), s.Split("#")(1), s.Split("#")(2), s.Split("#")(3))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class