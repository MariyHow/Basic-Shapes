Imports System.Runtime.ConstrainedExecution
Imports System.Transactions

Public Class Form1
    Dim Squareyards As Double = CDbl(TextBox1.Text)
    Dim Costpersqyard As Double = CDbl(TextBox2.Text)
    Dim Laborpersqyard As Double = CDbl(TextBox3.Text)
    Dim Prepcost As Double = CDbl(TextBox4.Text)
    Dim Discount As Double = CDbl(TextBox5.Text)
    Private dimReceipt As Object

    Private Sub btnCustomer1_Click(sender As Object, e As EventArgs) Handles btnCustomer1.Click
        Squareyards = 17
        Costpersqyard = 18.5
        Laborpersqyard = 3.5
        Prepcost = 38.5
        Discount = 0.02
    End Sub

    Private Sub btnCustomer2_Click(sender As Object, e As EventArgs) Handles btnCustomer2.Click
        Squareyards = 40
        Costpersqyard = 24.95
        Laborpersqyard = 2.95
        Prepcost = 0.00
        Discount = 0.14
    End Sub

    Private Sub btnCustomer3_Click(sender As Object, e As EventArgs) Handles btnCustomer3.Click
        Squareyards = 23
        Costpersqyard = 16.8
        Laborpersqyard = 3.25
        Prepcost = 57.95
        Discount = 0.00
    End Sub

    Private Sub btnCustomer4_Click(sender As Object, e As EventArgs) Handles btnCustomer4.Click
        Squareyards = 26
        Costpersqyard = 21.25
        Laborpersqyard = 0.00
        Prepcost = 80.0
        Discount = 0.02
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        lbReceipt.Items.Clear()
        CalclbReceipt()
        Dim a As Double = CDbl(TextBox1.Text)
        Dim b As Double = CDbl(TextBox1.Text)
        Dim c As Double = CDbl(TextBox1.Text)
        Dim d As Double = CDbl(TextBox1.Text)
        Dim p As Double = CDbl(TextBox1.Text * TextBox3.Text * TextBox4.Text)
        Dim f As Double = CDbl(TextBox2.Text * TextBox1.Text * 0.02)
        Dim l As Double = CDbl(TextBox1.Text * TextBox2.Text * 0.04)

        Dim g As Double = CDbl(TextBox5.Text * TextBox1.Text * 0.04)

        lbReceipt.Items.Add("          Maripot Carpet Store           ")
        lbReceipt.Items.Add("Square Yards Purchased:            $ " & a)
        lbReceipt.Items.Add("Cost per yard:                     $ " & b)
        lbReceipt.Items.Add("Labor per square yard:             $ " & c)
        lbReceipt.Items.Add("Floor prepartation cost:           $ " & d)
        lbReceipt.Items.Add("Cost for Carpet:                   $ " & p)
        lbReceipt.Items.Add("Discount on carpet:                $ " & f)
        lbReceipt.Items.Add("Tax on carpet:                     $ " & g)
        lbReceipt.Items.Add("Total:                             $" & a + b + c + d + p + f + l + g)
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        lbReceipt.Items.Clear()
    End Sub

    Private Sub Receipt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbReceipt.SelectedIndexChanged
        lbReceipt.Items.Add()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
