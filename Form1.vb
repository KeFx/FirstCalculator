Public Class Form1
    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        result.Text = Single.Parse(First.Text) + Single.Parse(Second.Text)
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        result.Text = First.Text - Second.Text
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        result.Text = First.Text * Second.Text
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        result.Text = First.Text / Second.Text
    End Sub

    Private Sub First_KeyPress(sender As Object, e As KeyPressEventArgs) Handles First.KeyPress
        If IsKeyCharAsNumberValid(sender, e) <> True Then
            errorForFirst.Text = "invalid input"
            e.Handled = True
        Else
            errorForFirst.Text = ""
        End If
    End Sub

    Private Sub Second_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Second.KeyPress
        If IsKeyCharAsNumberValid(sender, e) <> True Then
            errorForSecond.Text = "invalid input"
            e.Handled = True
        Else
            errorForSecond.Text = ""

        End If
    End Sub

    Private Function IsKeyCharAsNumberValid(textBox As TextBox, e As KeyPressEventArgs) As Boolean
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            Return True
        End If

        Try
            Single.Parse(textBox.Text + e.KeyChar + "0")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
