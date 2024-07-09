Public Class Form1
    Public num1, num2 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim num1 As Integer = CInt(Int((100 * Rnd()) + 1))
        Dim num2 As Integer
        Do
            num2 = Val(InputBox("Enter a number between 0 and 100"))
            If (num2 > num1) Then
                MessageBox.Show("Sorry your number is too high, Try Again.")
                Me.BackColor = Color.Red
            ElseIf (num2 < num1) Then
                MessageBox.Show("Sorry your number is too low, Try Again.")
                Me.BackColor = Color.Blue
            ElseIf (num2 = num1) Then
                MessageBox.Show(num2, "YOU GUESSED THE HIDDEN NUMBER, WERE YOU CHEATING?")
                Me.BackColor = Color.Green
            End If

        Loop Until num2 = num1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Your program has been reset")
        Application.Restart()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
