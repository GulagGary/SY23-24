Imports System.IO
Imports System.Net.Http
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.Pkcs

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim r As String
        r += Field1.Text
        r += "|"
        r += Field2.Text
        r += "|"
        r += Field3.Text
        r += "|"
        r += Field4.Text
        r += "|"
        r += Field5.Text
        r += "|"
        r += PictureBox1.ImageLocation
        records(current) = r
        savetofile()
    End Sub
    Sub savetofile()
        Dim outfile As New StreamWriter("data.txt")
        For index = 0 To count - 1
            outfile.WriteLine(records(index))
        Next
        outfile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
                showrecord(0)
            End While
        End If
    End Sub
    Public Sub showrecord(index As Integer)
        If records(index) <> Nothing Then
            Dim fields() As String
            fields = records(index).Split("|")
            Field1.Text = fields(0)
            Field2.Text = fields(1)
            Field3.Text = fields(2)
            Field4.Text = fields(3)
            Field5.Text = fields(4)
            If File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub firstbutton_Click(sender As Object, e As EventArgs) Handles Firstbutton.Click
        current = 0
        showrecord(current)
    End Sub

    Private Sub lastbutton_Click(sender As Object, e As EventArgs) Handles Lastbutton.Click
        current = count - 1
        showrecord(current)
    End Sub
End Class
