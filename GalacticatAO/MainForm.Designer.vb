<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PicDrawOnScreen = New System.Windows.Forms.PictureBox()
        Me.Life1 = New System.Windows.Forms.PictureBox()
        Me.Life2 = New System.Windows.Forms.PictureBox()
        Me.Life3 = New System.Windows.Forms.PictureBox()
        CType(Me.PicDrawOnScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Life1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Life2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Life3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'PicDrawOnScreen
        '
        Me.PicDrawOnScreen.Location = New System.Drawing.Point(62, 118)
        Me.PicDrawOnScreen.Name = "PicDrawOnScreen"
        Me.PicDrawOnScreen.Size = New System.Drawing.Size(100, 50)
        Me.PicDrawOnScreen.TabIndex = 1
        Me.PicDrawOnScreen.TabStop = False
        '
        'Life1
        '
        Me.Life1.BackColor = System.Drawing.Color.Transparent
        Me.Life1.Image = CType(resources.GetObject("Life1.Image"), System.Drawing.Image)
        Me.Life1.Location = New System.Drawing.Point(1200, -4)
        Me.Life1.Name = "Life1"
        Me.Life1.Size = New System.Drawing.Size(51, 50)
        Me.Life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Life1.TabIndex = 2
        Me.Life1.TabStop = False
        '
        'Life2
        '
        Me.Life2.BackColor = System.Drawing.Color.Transparent
        Me.Life2.Image = CType(resources.GetObject("Life2.Image"), System.Drawing.Image)
        Me.Life2.Location = New System.Drawing.Point(1257, -4)
        Me.Life2.Name = "Life2"
        Me.Life2.Size = New System.Drawing.Size(51, 50)
        Me.Life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Life2.TabIndex = 3
        Me.Life2.TabStop = False
        '
        'Life3
        '
        Me.Life3.BackColor = System.Drawing.Color.Transparent
        Me.Life3.Image = CType(resources.GetObject("Life3.Image"), System.Drawing.Image)
        Me.Life3.Location = New System.Drawing.Point(1314, -4)
        Me.Life3.Name = "Life3"
        Me.Life3.Size = New System.Drawing.Size(51, 50)
        Me.Life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Life3.TabIndex = 4
        Me.Life3.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Life3)
        Me.Controls.Add(Me.Life2)
        Me.Controls.Add(Me.Life1)
        Me.Controls.Add(Me.PicDrawOnScreen)
        Me.Name = "MainForm"
        Me.Text = "Galacticat by Alexandre O"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PicDrawOnScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Life1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Life2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Life3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PicDrawOnScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Life1 As System.Windows.Forms.PictureBox
    Friend WithEvents Life2 As System.Windows.Forms.PictureBox
    Friend WithEvents Life3 As System.Windows.Forms.PictureBox

End Class
