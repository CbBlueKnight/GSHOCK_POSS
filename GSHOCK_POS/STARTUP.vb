Public Class STARTUP
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MANAGER_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ADMIN_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class