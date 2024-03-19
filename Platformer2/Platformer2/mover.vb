Public Class mover
    Public Property speed As Integer = 10
    Public Property Interval As Integer = 500
    Public Property sprite As PictureBox
    Dim xdir As Integer = 1
    Dim ydir As Integer = 0
    Private Sub mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = Interval
        Timer1.Enabled = True
        If Not sprite Is Nothing Then
            sprite.Left = Me.Left
            sprite.Top = Me.Top
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += xdir * speed
            sprite.Top += ydir * speed
            If sprite.Left > Me.Left + Me.Width And xdir = 1 Then
                xdir = 0
                ydir = 1
            End If
            If sprite.Left < Me.Left + Me.Width And xdir = -1 Then
                xdir = 0
                ydir = -1
            End If
            If sprite.Top > Me.Left + Me.Width And ydir = 1 Then
                ydir = 0
                xdir = -1
            End If
            If sprite.Top < Me.Left + Me.Width And ydir = -1 Then
                ydir = 0
                xdir = 1
            End If
        End If
    End Sub

End Class
