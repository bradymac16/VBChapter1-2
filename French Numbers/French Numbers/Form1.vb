Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnone_Click(sender As Object, e As EventArgs) Handles btnone.Click
        MessageBox.Show("UN")


    End Sub

    Private Sub btntwo_Click(sender As Object, e As EventArgs) Handles btntwo.Click
        MessageBox.Show("DEUX")
    End Sub

    Private Sub btnfour_Click(sender As Object, e As EventArgs) Handles btnfour.Click
        MessageBox.Show("trois")
    End Sub

    Private Sub btnthree_Click(sender As Object, e As EventArgs) Handles btnthree.Click
        MessageBox.Show("quatre")
    End Sub

    Private Sub btnfive_Click(sender As Object, e As EventArgs) Handles btnfive.Click
        MessageBox.Show("cinq")
    End Sub
End Class
