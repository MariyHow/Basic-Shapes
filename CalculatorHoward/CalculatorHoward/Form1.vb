Public Class Form1

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum1.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum1.Text
        End If
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum2.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum2.Text
        End If
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum3.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum3.Text
        End If
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum4.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum4.Text
        End If
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum5.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum5.Text
        End If
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum6.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum6.Text
        End If
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum7.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum7.Text
        End If
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum8.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum8.Text
        End If
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum9.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum9.Text
        End If
    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        If rbNumber1.Checked = True Then
            txtFirstNum.Text &= btnNum0.Text
        ElseIf rbNumber2.Checked = True Then
            txtSecondNum.Text &= btnNum0.Text
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        MessageBox.Show("Your Program has been cleared")
        txtFirstNum.Text = " "
        txtSecondNum.Text = " "
        txtCalculation.Text = " "
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        LabelOperation.Text = btnAddition.Text
        LabelOperation.Visible = True
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        LabelOperation.Text = btnSubtraction.Text
        LabelOperation.Visible = True
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        LabelOperation.Text = btnMultiplication.Text
        LabelOperation.Visible = True
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        LabelOperation.Text = btnDivision.Text
        LabelOperation.Visible = True
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim num1, num2 As Double
        num1 = txtFirstNum.Text
        num2 = txtSecondNum.Text
        If LabelOperation.Text.Equals("+") Then
            txtCalculation.Text = num1 + num2
        ElseIf LabelOperation.Text.Equals("-") Then
            txtCalculation.Text = num1 - num2
        ElseIf LabelOperation.Text.Equals("*") Then
            txtCalculation.Text = num1 * num2
        ElseIf LabelOperation.Text.Equals("/") Then
            txtCalculation.Text = num1 / num2
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
