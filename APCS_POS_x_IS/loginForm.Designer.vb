<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minimizeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.userProfile = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.minimizeButton)
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 47)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Athena Perb's Catering Service"
        '
        'minimizeButton
        '
        Me.minimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.minimizeButton.BackgroundImage = CType(resources.GetObject("minimizeButton.BackgroundImage"), System.Drawing.Image)
        Me.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.minimizeButton.FlatAppearance.BorderSize = 0
        Me.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizeButton.ForeColor = System.Drawing.Color.Transparent
        Me.minimizeButton.Location = New System.Drawing.Point(255, 12)
        Me.minimizeButton.Name = "minimizeButton"
        Me.minimizeButton.Size = New System.Drawing.Size(31, 24)
        Me.minimizeButton.TabIndex = 1
        Me.minimizeButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.BackgroundImage = CType(resources.GetObject("exitButton.BackgroundImage"), System.Drawing.Image)
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exitButton.FlatAppearance.BorderSize = 0
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.ForeColor = System.Drawing.Color.Transparent
        Me.exitButton.Location = New System.Drawing.Point(292, 11)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(30, 25)
        Me.exitButton.TabIndex = 1
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'userProfile
        '
        Me.userProfile.BackColor = System.Drawing.Color.Transparent
        Me.userProfile.BackgroundImage = CType(resources.GetObject("userProfile.BackgroundImage"), System.Drawing.Image)
        Me.userProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userProfile.Location = New System.Drawing.Point(87, 54)
        Me.userProfile.Name = "userProfile"
        Me.userProfile.Size = New System.Drawing.Size(157, 159)
        Me.userProfile.TabIndex = 1
        Me.userProfile.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(69, 230)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "Username"
        Me.TextBox1.Size = New System.Drawing.Size(189, 30)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(69, 287)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "Password"
        Me.TextBox2.Size = New System.Drawing.Size(189, 30)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(109, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.userProfile)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "loginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents exitButton As Button
    Friend WithEvents userProfile As PictureBox
    Private WithEvents minimizeButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
