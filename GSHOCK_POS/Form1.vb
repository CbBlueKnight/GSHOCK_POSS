﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim GShockIcon = Svg.SvgDocument.Open(My.Settings.GSHOCKSVG)
            GShockIcon.Width = 106.28
            GShockIcon.Height = 17.98
            Dim GShockGitmap = GShockIcon.Draw()
            PictureBox1.Image = GShockGitmap
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
