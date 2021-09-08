Public Class Form1
    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        result.Text = Integer.Parse(First.Text) + Integer.Parse(Second.Text)
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        result.Text = Integer.Parse(First.Text) - Integer.Parse(Second.Text)
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click

    End Sub
End Class
