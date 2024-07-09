Imports System.IO

Public Class Form1
    Public username As String = userinput("Enter username:")
    Public password As String = userinput2("Enter password:")
    Public userinput As String
    Public userinput2 As String
    Public Grocerylist As New ArrayList
    Dim list() As String = IO.File.ReadAllLines("Grocerylist.txt")
    Dim combined As String = username & password
    Dim codeArray(,) As String = {{username, password}, {username, password}}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = "VisualBasics"
        password = "needatleastaB"
        Do
            userinput = InputBox("What is your username?")
            If (userinput <> username) Then
                MessageBox.Show("Sorry that is the wrong username")
            ElseIf (userinput = username) Then
                Print("What is the password?")
            End If
        Loop Until userinput = username

        Do
            If (userinput2 = password) Then
                MessageBox.Show("Access Granted!")
            ElseIf (userinput2 <> password) Then
                MessageBox.Show("Sorry that is the wrong password")
            End If
        Loop Until userinput2 = password
    End Sub
End Class