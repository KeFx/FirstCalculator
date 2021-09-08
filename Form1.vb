Public Class Form1
    Dim n1 As Single
    Dim n2 As Single


    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click

        result.Text = n1 + n2
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        result.Text = n1 - n2
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        result.Text = n1 * n2
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        result.Text = n1 / n2
    End Sub

    Private Sub Second_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Second.KeyPress
        If isKeyCharAsNumberInputValid(sender, e) <> True Then
            errorForSecond.Text = "invalid input. number only"
            e.Handled = True
        Else
            errorForSecond.Text = ""
        End If



    End Sub

    Private Sub First_KeyPress(sender As Object, e As KeyPressEventArgs) Handles First.KeyPress
        e.Handled = isKeyCharAsNumberInputValid(sender, e) <> True
    End Sub

    Private Function isKeyCharAsNumberInputValid(textBox As TextBox, e As KeyPressEventArgs) As Boolean
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

    Private Sub errorForSecond_Click(sender As Object, e As EventArgs) Handles errorForSecond.Click

    End Sub

    Private Sub Second_TextChanged(sender As Object, e As EventArgs) Handles Second.TextChanged

    End Sub
End Class
