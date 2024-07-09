Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim Grade1 As Double = CDbl(txtGrade1.Text)
        Dim Grade2 As Double = CDbl(txtGrade2.Text)
        Dim Grade3 As Double = CDbl(txtGrade3.Text)
        Dim Grade4 As Double = CDbl(txtGrade4.Text)
        Dim Grade5 As Double = CDbl(txtGrade5.Text)

        Dim AvgGrade = (Grade1 + Grade2 + Grade3 + Grade4 + Grade5) / 5
        Label1.Text = AvgGrade

        If (AvgGrade >= 90) Then
            txtAvgGrade.Text = "A"
            picBoxA.Visible = True
            picBoxB.Visible = False
            picBoxC.Visible = False
            picBoxD.Visible = False
            picBoxF.Visible = False
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            Me.BackColor = Color.Aqua
        ElseIf (AvgGrade >= 80) Then
            txtAvgGrade.Text = "B"
            picBoxA.Visible = False
            picBoxB.Visible = True
            picBoxC.Visible = False
            picBoxD.Visible = False
            picBoxF.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            Me.BackColor = Color.Green
        ElseIf (AvgGrade >= 70) Then
            txtAvgGrade.Text = "C"
            picBoxA.Visible = False
            picBoxB.Visible = False
            picBoxC.Visible = True
            picBoxD.Visible = False
            picBoxF.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            Me.BackColor = Color.Yellow
        ElseIf (AvgGrade > 60) Then
            txtAvgGrade.Text = "D"
            picBoxA.Visible = False
            picBoxB.Visible = False
            picBoxC.Visible = False
            picBoxD.Visible = True
            picBoxF.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            Me.BackColor = Color.Orange
        ElseIf (AvgGrade >= 0) Then
            txtAvgGrade.Text = "F"
            picBoxA.Visible = False
            picBoxB.Visible = False
            picBoxC.Visible = False
            picBoxD.Visible = False
            picBoxF.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = True
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        MessageBox.Show("Your program has been reset")
        Application.Restart()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
