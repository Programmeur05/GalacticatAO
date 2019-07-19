<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectDif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectDif))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.checkbox1 = New System.Windows.Forms.Button()
        Me.Checkbox3 = New System.Windows.Forms.Button()
        Me.Checkbox2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(362, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 112)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Difficulty"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(500, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Easy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(500, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 63)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Medium"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(500, 530)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 63)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Hard"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Segoe Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(29, 27)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(119, 30)
        Me.Back.TabIndex = 4
        Me.Back.Text = "<--- Menu"
        Me.Back.UseVisualStyleBackColor = True
        '
        'checkbox1
        '
        Me.checkbox1.BackColor = System.Drawing.Color.Transparent
        Me.checkbox1.Font = New System.Drawing.Font("Ink Free", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox1.ForeColor = System.Drawing.Color.Lime
        Me.checkbox1.Location = New System.Drawing.Point(432, 340)
        Me.checkbox1.Name = "checkbox1"
        Me.checkbox1.Size = New System.Drawing.Size(45, 48)
        Me.checkbox1.TabIndex = 5
        Me.checkbox1.Text = "V"
        Me.checkbox1.UseVisualStyleBackColor = False
        '
        'Checkbox3
        '
        Me.Checkbox3.BackColor = System.Drawing.Color.Transparent
        Me.Checkbox3.Font = New System.Drawing.Font("Ink Free", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkbox3.ForeColor = System.Drawing.Color.Lime
        Me.Checkbox3.Location = New System.Drawing.Point(432, 541)
        Me.Checkbox3.Name = "Checkbox3"
        Me.Checkbox3.Size = New System.Drawing.Size(45, 48)
        Me.Checkbox3.TabIndex = 6
        Me.Checkbox3.Text = "V"
        Me.Checkbox3.UseVisualStyleBackColor = False
        Me.Checkbox3.Visible = False
        '
        'Checkbox2
        '
        Me.Checkbox2.BackColor = System.Drawing.Color.Transparent
        Me.Checkbox2.Font = New System.Drawing.Font("Ink Free", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkbox2.ForeColor = System.Drawing.Color.Lime
        Me.Checkbox2.Location = New System.Drawing.Point(432, 441)
        Me.Checkbox2.Name = "Checkbox2"
        Me.Checkbox2.Size = New System.Drawing.Size(45, 48)
        Me.Checkbox2.TabIndex = 7
        Me.Checkbox2.Text = "V"
        Me.Checkbox2.UseVisualStyleBackColor = False
        Me.Checkbox2.Visible = False
        '
        'Timer1
        '
        '
        'SelectDif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Checkbox2)
        Me.Controls.Add(Me.Checkbox3)
        Me.Controls.Add(Me.checkbox1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SelectDif"
        Me.Text = "SelectDif"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents checkbox1 As System.Windows.Forms.Button
    Friend WithEvents Checkbox3 As System.Windows.Forms.Button
    Friend WithEvents Checkbox2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
