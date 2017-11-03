Public Class Form1


    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        Dim strName As String

        strName = txtUsername.Text

        lblGreeting.Text = strName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
