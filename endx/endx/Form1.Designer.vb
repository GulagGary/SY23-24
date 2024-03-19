<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2DPlatformer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Fuchsia
        Me.picPlayer.Location = New System.Drawing.Point(12, 312)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(100, 50)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picAir
        '
        Me.picAir.Location = New System.Drawing.Point(12, 12)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(776, 281)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'picGround
        '
        Me.picGround.Location = New System.Drawing.Point(12, 368)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(776, 50)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'frm2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picAir)
        Me.Name = "frm2DPlatformer"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
End Class
