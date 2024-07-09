Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHappy.Click
        If btnHappy.Enabled = True Then
            btnSad.Enabled = False
            picHappy.Visible = True
            picSad.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSad.Click
        If btnSad.Enabled = True Then
            btnHappy.Enabled = False
            picHappy.Visible = False
            picSad.Visible = True
        End If

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If btnHappy.Enabled = True Then
            MessageBox.Show("You have selected the happy face")
        ElseIf btnHappy.Enabled = False Then
            MessageBox.Show("You have selected the sad face")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
