Public Class Form1
    Dim c As New Clicker
    Dim d As New Clicker
    Dim f As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = NumericUpDown1.Value
        c.click()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        d.increment = NumericUpDown2.Value
        d.click()
        TextBox2.Text = d.count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        d.reset()
        TextBox2.Text = d.count
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        f.increment = NumericUpDown3.Value
        f.click()
        TextBox3.Text = f.count
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        f.reset()
        TextBox2.Text = f.count
    End Sub
End Class
