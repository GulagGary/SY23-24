Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography.Pkcs

Public Class Form1
    Dim records(50) As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Fields1.Text = ""
        Fields2.Text = ""
        Fields3.Text = ""
        Fields4.Text = ""
        Fields5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim outFile As New StreamWriter("Data.txt")
        outFile.Write(Fields1.Text)
        outFile.Write("|")
        outFile.Write(Fields2.Text)
        outFile.Write("|")
        outFile.Write(Fields3.Text)
        outFile.Write("|")
        outFile.Write(Fields4.Text)
        outFile.Write("|")
        outFile.Write(Fields5.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim idx As Integer = 0
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(idx) = inFile.ReadLine
                idx = idx + 1
            End While
            inFile.Close()
            showrecord(0)
        End If
    End Sub
    Public Sub showrecord(index As Integer)
        Dim fields() As String
        fields = records(index).Split("|")
    End Sub
End Class

