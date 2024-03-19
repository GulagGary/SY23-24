Public Class frm2DPlatformer
    Dim movespeed As Integer = 15

    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += 15
    End Sub

    Private Sub frm2DPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
