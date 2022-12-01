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
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.Loginbutton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.minimizeButton)
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Athena Perb's Catering Service"
        '
        'minimizeButton
        '
        Me.minimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.minimizeButton.FlatAppearance.BorderSize = 0
        Me.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizeButton.ForeColor = System.Drawing.Color.Transparent
        Me.minimizeButton.Image = CType(resources.GetObject("minimizeButton.Image"), System.Drawing.Image)
        Me.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.minimizeButton.Location = New System.Drawing.Point(227, 0)
        Me.minimizeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.minimizeButton.Name = "minimizeButton"
        Me.minimizeButton.Size = New System.Drawing.Size(28, 35)
        Me.minimizeButton.TabIndex = 1
        Me.minimizeButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exitButton.FlatAppearance.BorderSize = 0
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.ForeColor = System.Drawing.Color.Transparent
        Me.exitButton.Image = CType(resources.GetObject("exitButton.Image"), System.Drawing.Image)
        Me.exitButton.Location = New System.Drawing.Point(256, 0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(28, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'userProfile
        '
        Me.userProfile.BackColor = System.Drawing.Color.Transparent
        Me.userProfile.BackgroundImage = CType(resources.GetObject("userProfile.BackgroundImage"), System.Drawing.Image)
        Me.userProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userProfile.Location = New System.Drawing.Point(76, 40)
        Me.userProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.userProfile.Name = "userProfile"
        Me.userProfile.Size = New System.Drawing.Size(137, 119)
        Me.userProfile.TabIndex = 1
        Me.userProfile.TabStop = False
        '
        'UsernameText
        '
        Me.UsernameText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.UsernameText.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UsernameText.Location = New System.Drawing.Point(60, 172)
        Me.UsernameText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.PlaceholderText = "Username"
        Me.UsernameText.Size = New System.Drawing.Size(166, 26)
        Me.UsernameText.TabIndex = 2
        Me.UsernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordText
        '
        Me.PasswordText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.PasswordText.Location = New System.Drawing.Point(60, 215)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PlaceholderText = "Password"
        Me.PasswordText.Size = New System.Drawing.Size(166, 26)
        Me.PasswordText.TabIndex = 3
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Loginbutton
        '
        Me.Loginbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Loginbutton.ForeColor = System.Drawing.Color.White
        Me.Loginbutton.Location = New System.Drawing.Point(95, 272)
        Me.Loginbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Loginbutton.Name = "Loginbutton"
        Me.Loginbutton.Size = New System.Drawing.Size(103, 33)
        Me.Loginbutton.TabIndex = 4
        Me.Loginbutton.Text = "LOGIN"
        Me.Loginbutton.UseVisualStyleBackColor = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.Loginbutton)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UsernameText)
        Me.Controls.Add(Me.userProfile)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents UsernameText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents Loginbutton As Button
    Friend WithEvents Label1 As Label
End Class
