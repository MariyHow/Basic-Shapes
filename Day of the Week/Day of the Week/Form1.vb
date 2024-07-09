Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dayofweek As Integer = DateTimePicker1.Value.DayOfWeek
        Dim status As String
        If dayofweek = 0 Or dayofweek = 6 Then
            status = "weekend"
            picRelax.Visible = True
            picStress.Visible = False
            Me.BackColor = Color.LightBlue
            MessageBox.Show("It's the weekend it's time to relax.")
        Else status = "Weekday"
            picRelax.Visible = False
            picStress.Visible = True
            Me.BackColor = Color.DarkViolet
            MessageBox.Show("It's the weekday it's time to go to work.")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        MessageBox.Show("Your Program has been reset")
        Application.Restart()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picRelax_Click(sender As Object, e As EventArgs) Handles picRelax.Click

    End Sub
End Class
