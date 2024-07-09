Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Security.Cyptography.Pkcs
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public before() As String
    Public after() As String
    Dim text() As String = IO.File.ReadAllLines("sampleTextese.txt")
    Dim paragraph() As String = IO.File.ReadAllLines("sampleparagraph.txt")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim before(text.Count - 1)
        ReDim after(text.Count - 1)

        For i = 0 To text.Count - 1
            ListBox1.Items.Add(text(i))
            Dim tx = text(i).Split(","c)
            before(i) = tx(0)
            after(i) = tx(1)
            ListBox1.Items.Add(before(i))
            ListBox1.Items.Add(after(i))
        Next
        Dim splitparagraph = paragraph(0).Split(" "c)
        For p = 0 To splitparagraph.Count - 1



            Dim ya As Boolean = False
            Dim ind As Integer = -1

            For t = 0 To before.Count - 1
                If splitparagraph(p).CompareTo(before(t)) = 0 Then
                    ya = True
                    ind = t
                    t = before.Count
                Else
                    ya = False
                End If
            Next
            If ya.Equals(True) Then
                ListBox2.Items.Add(after(ind))
            Else
                ListBox2.Items.Add(splitparagraph(p))
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
