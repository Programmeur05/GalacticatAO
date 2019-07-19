<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinningScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinningScreen))
        Me.PlayAgain = New System.Windows.Forms.Button()
        Me.backtomenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PlayAgain
        '
        Me.PlayAgain.BackgroundImage = CType(resources.GetObject("PlayAgain.BackgroundImage"), System.Drawing.Image)
        Me.PlayAgain.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.Location = New System.Drawing.Point(296, 518)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(311, 84)
        Me.PlayAgain.TabIndex = 0
        Me.PlayAgain.Text = "Yes"
        Me.PlayAgain.UseVisualStyleBackColor = True
        '
        'backtomenu
        '
        Me.backtomenu.BackgroundImage = CType(resources.GetObject("backtomenu.BackgroundImage"), System.Drawing.Image)
        Me.backtomenu.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backtomenu.Location = New System.Drawing.Point(788, 518)
        Me.backtomenu.Name = "backtomenu"
        Me.backtomenu.Size = New System.Drawing.Size(314, 84)
        Me.backtomenu.TabIndex = 1
        Me.backtomenu.Text = "No"
        Me.backtomenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 86.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(413, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(641, 156)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VICTORY "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(455, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(506, 112)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Another one ?"
        '
        'WinningScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backtomenu)
        Me.Controls.Add(Me.PlayAgain)
        Me.Name = "WinningScreen"
        Me.Text = "WinningScreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayAgain As System.Windows.Forms.Button
    Friend WithEvents backtomenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
