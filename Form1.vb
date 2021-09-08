Public Class Form1
    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        result.Text = Single.Parse(First.Text) + Single.Parse(Second.Text)
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        result.Text = Single.Parse(First.Text) - Single.Parse(Second.Text)
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        result.Text = Single.Parse(First.Text) * Single.Parse(Second.Text)
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        result.Text = Single.Parse(First.Text) / Single.Parse(Second.Text)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
