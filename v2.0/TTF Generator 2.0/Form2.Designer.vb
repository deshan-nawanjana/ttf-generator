<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button47 = New System.Windows.Forms.Button
        Me.Button46 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 34)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Convert Unicode to TTF - Copy your Unicode text into Clipboard and press 'Convert" & _
            "'"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.Location = New System.Drawing.Point(0, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(613, 332)
        Me.TextBox1.TabIndex = 66
        Me.TextBox1.Text = "Past here..."
        Me.TextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(613, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 332)
        Me.Panel3.TabIndex = 67
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button47)
        Me.Panel4.Controls.Add(Me.Button46)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 189)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 143)
        Me.Panel4.TabIndex = 65
        '
        'Button47
        '
        Me.Button47.BackColor = System.Drawing.Color.Gray
        Me.Button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button47.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button47.Image = Global.TTF_Generator_2._0.My.Resources.Resources.Entypo_2715_1__48
        Me.Button47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button47.Location = New System.Drawing.Point(16, 76)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(160, 58)
        Me.Button47.TabIndex = 65
        Me.Button47.Text = "       Cancel"
        Me.Button47.UseVisualStyleBackColor = False
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.Gray
        Me.Button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button46.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button46.Image = Global.TTF_Generator_2._0.My.Resources.Resources.Entypo_2713_0__48
        Me.Button46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button46.Location = New System.Drawing.Point(16, 11)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(160, 58)
        Me.Button46.TabIndex = 64
        Me.Button46.Text = "       Convert"
        Me.Button46.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 366)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = """"
        Me.Text = "Form2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button47 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button
End Class
