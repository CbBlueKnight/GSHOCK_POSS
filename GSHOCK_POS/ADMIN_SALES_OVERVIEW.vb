﻿Public Class ADMIN_SALES_OVERVIEW
    Private Sub DAILY_Click(sender As Object, e As EventArgs)
        ADMIN_DAILY.Show()
    End Sub

    Private Sub WEEKLY_Click(sender As Object, e As EventArgs)
        ADMIN_WEEKLY.Show()
    End Sub

    Private Sub MONTHLY_Click(sender As Object, e As EventArgs)
        ADMIN_MONTHLY.Show()
    End Sub

    Private Sub INVENTORY_Click(sender As Object, e As EventArgs) Handles INVENTORY.Click
        ADMIN_INVENTORY.Show()
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        ADMIN_C1.Show()
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        ADMIN_C2.Show()
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        ADMIN_C3.Show()
    End Sub

    Private Sub MP_Click(sender As Object, e As EventArgs) Handles MP.Click
        Me.Show()
    End Sub

    Private Sub DAILY_Click_1(sender As Object, e As EventArgs) Handles DAILY.Click
        ADMIN_DAILY.Show()
    End Sub

    Private Sub WEEKLY_Click_1(sender As Object, e As EventArgs) Handles WEEKLY.Click
        ADMIN_WEEKLY.Show()
    End Sub

    Private Sub MONTHLY_Click_1(sender As Object, e As EventArgs) Handles MONTHLY.Click
        ADMIN_MONTHLY.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class