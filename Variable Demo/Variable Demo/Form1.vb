﻿Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowName_Click_1(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim strFullName As String

        strFullName = txtFirstName.Text & " " & txtLastName.Text

        lblFullName.Text = strFullName
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty
    End Sub
End Class

