Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Reelcontrol1.spin()
        Label2.Text = Reelcontrol1.itemValue
    End Sub
End Class
