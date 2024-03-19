Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Newcontrol1.spin()
        Newcontrol2.spin()
        Newcontrol3.spin()
        Label1.Text = Newcontrol1.itemvalue
        Label2.Text = Newcontrol2.itemvalue
        Label3.Text = Newcontrol3.itemvalue
        Timer2.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Newcontrol1.itemvalue
        Label2.Text = Newcontrol2.itemvalue
        Label3.Text = Newcontrol3.itemvalue
        Timer1.Enabled = False
    End Sub

    Private Sub Newcontrol2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class
