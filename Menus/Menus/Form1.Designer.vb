<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Field1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Field2 = New System.Windows.Forms.TextBox()
        Me.Field3 = New System.Windows.Forms.TextBox()
        Me.Field4 = New System.Windows.Forms.TextBox()
        Me.Field5 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.firstbutton = New System.Windows.Forms.Button()
        Me.prevbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.lastbutton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Field1
        '
        Me.Field1.Location = New System.Drawing.Point(332, 142)
        Me.Field1.Multiline = True
        Me.Field1.Name = "Field1"
        Me.Field1.Size = New System.Drawing.Size(125, 34)
        Me.Field1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1082, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.CloseToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(601, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Field2
        '
        Me.Field2.Location = New System.Drawing.Point(332, 200)
        Me.Field2.Name = "Field2"
        Me.Field2.Size = New System.Drawing.Size(125, 27)
        Me.Field2.TabIndex = 3
        '
        'Field3
        '
        Me.Field3.Location = New System.Drawing.Point(332, 253)
        Me.Field3.Name = "Field3"
        Me.Field3.Size = New System.Drawing.Size(125, 27)
        Me.Field3.TabIndex = 4
        '
        'Field4
        '
        Me.Field4.Location = New System.Drawing.Point(332, 310)
        Me.Field4.Name = "Field4"
        Me.Field4.Size = New System.Drawing.Size(125, 27)
        Me.Field4.TabIndex = 5
        '
        'Field5
        '
        Me.Field5.Location = New System.Drawing.Point(332, 364)
        Me.Field5.Name = "Field5"
        Me.Field5.Size = New System.Drawing.Size(125, 27)
        Me.Field5.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'firstbutton
        '
        Me.firstbutton.Location = New System.Drawing.Point(27, 52)
        Me.firstbutton.Name = "firstbutton"
        Me.firstbutton.Size = New System.Drawing.Size(94, 29)
        Me.firstbutton.TabIndex = 7
        Me.firstbutton.Text = "First"
        Me.firstbutton.UseVisualStyleBackColor = True
        '
        'prevbutton
        '
        Me.prevbutton.Location = New System.Drawing.Point(27, 101)
        Me.prevbutton.Name = "prevbutton"
        Me.prevbutton.Size = New System.Drawing.Size(94, 29)
        Me.prevbutton.TabIndex = 8
        Me.prevbutton.Text = "Previous"
        Me.prevbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(27, 157)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 9
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'lastbutton
        '
        Me.lastbutton.Location = New System.Drawing.Point(27, 213)
        Me.lastbutton.Name = "lastbutton"
        Me.lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.lastbutton.TabIndex = 10
        Me.lastbutton.Text = "Last"
        Me.lastbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 548)
        Me.Controls.Add(Me.lastbutton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.prevbutton)
        Me.Controls.Add(Me.firstbutton)
        Me.Controls.Add(Me.Field5)
        Me.Controls.Add(Me.Field4)
        Me.Controls.Add(Me.Field3)
        Me.Controls.Add(Me.Field2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Field1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Field1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Field2 As TextBox
    Friend WithEvents Field3 As TextBox
    Friend WithEvents Field4 As TextBox
    Friend WithEvents Field5 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents firstbutton As Button
    Friend WithEvents prevbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents lastbutton As Button
End Class
