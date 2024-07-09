Imports System.Runtime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2
    Public employeeinfo() = Form1.stemployee
    Public employeenum(employeeinfo.Length)
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ln(employeeinfo.Length)
        Dim fn(employeeinfo.Length)

        For i = 0 To employeeinfo.Length - 1
            Dim line = employeeinfo(i).Split(","c)
            ln(i) = (line(0))
            fn(i) = (line(1))
            employeenum(i) = (line(2))
            DataGridView1.Rows.Add(ln(i), fn(i), employeenum(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userInput As String = TextBox1.Text
        Dim numVar As Integer = 0
        numVar = Array.IndexOf(employeenum, userInput)
        If numVar <> -1 Then
            TextBox1.Text = employeeinfo(numVar)
        Else
            TextBox1.Text = "Employee Not found" & numVar
        End If
    End Sub

End Class