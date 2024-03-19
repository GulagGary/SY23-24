Public Class productcontrol
    Public Property ProductName As String
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property PropertyCount As Integer
    Private Sub Product_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductImage
        ID_Label.Text = ProductID
        Price_label.Text = ProductPrice.ToString("C2")
    End Sub
    Public Sub buy()
        If PropertyCount > 0 Then
            PropertyCount -= 1
        End If
        If PropertyCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class

