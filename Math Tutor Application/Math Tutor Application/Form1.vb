Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblAnswer.Visible = True

    End Sub

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
