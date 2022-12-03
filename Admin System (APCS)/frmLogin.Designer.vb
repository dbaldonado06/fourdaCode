<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minimizeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.lblLoginAthenaPerbs = New System.Windows.Forms.Label()
        Me.btnLoginUser = New System.Windows.Forms.Button()
        Me.txtBoxLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxLoginUsername = New System.Windows.Forms.TextBox()
        Me.userProfile = New System.Windows.Forms.PictureBox()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minimizeButton)
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Controls.Add(Me.lblLoginAthenaPerbs)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 35)
        Me.Panel1.TabIndex = 9
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
        Me.minimizeButton.TabIndex = 4
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
        Me.exitButton.TabIndex = 5
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'lblLoginAthenaPerbs
        '
        Me.lblLoginAthenaPerbs.AutoSize = True
        Me.lblLoginAthenaPerbs.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLoginAthenaPerbs.ForeColor = System.Drawing.Color.White
        Me.lblLoginAthenaPerbs.Location = New System.Drawing.Point(5, 9)
        Me.lblLoginAthenaPerbs.Name = "lblLoginAthenaPerbs"
        Me.lblLoginAthenaPerbs.Size = New System.Drawing.Size(200, 17)
        Me.lblLoginAthenaPerbs.TabIndex = 3
        Me.lblLoginAthenaPerbs.Text = "Athena Perb's Catering Service"
        '
        'btnLoginUser
        '
        Me.btnLoginUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnLoginUser.ForeColor = System.Drawing.Color.White
        Me.btnLoginUser.Location = New System.Drawing.Point(95, 272)
        Me.btnLoginUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginUser.Name = "btnLoginUser"
        Me.btnLoginUser.Size = New System.Drawing.Size(103, 33)
        Me.btnLoginUser.TabIndex = 13
        Me.btnLoginUser.Text = "LOGIN"
        Me.btnLoginUser.UseVisualStyleBackColor = False
        '
        'txtBoxLoginPassword
        '
        Me.txtBoxLoginPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxLoginPassword.Location = New System.Drawing.Point(60, 215)
        Me.txtBoxLoginPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxLoginPassword.Name = "txtBoxLoginPassword"
        Me.txtBoxLoginPassword.PlaceholderText = "Password"
        Me.txtBoxLoginPassword.Size = New System.Drawing.Size(166, 26)
        Me.txtBoxLoginPassword.TabIndex = 12
        Me.txtBoxLoginPassword.Text = "fourdaCode"
        Me.txtBoxLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxLoginPassword.UseSystemPasswordChar = True
        '
        'txtBoxLoginUsername
        '
        Me.txtBoxLoginUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxLoginUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoxLoginUsername.Location = New System.Drawing.Point(60, 172)
        Me.txtBoxLoginUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxLoginUsername.Name = "txtBoxLoginUsername"
        Me.txtBoxLoginUsername.PlaceholderText = "Username"
        Me.txtBoxLoginUsername.Size = New System.Drawing.Size(166, 26)
        Me.txtBoxLoginUsername.TabIndex = 11
        Me.txtBoxLoginUsername.Text = "Administrator"
        Me.txtBoxLoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.userProfile.TabIndex = 10
        Me.userProfile.TabStop = False
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WarningLabel.Location = New System.Drawing.Point(57, 243)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(0, 15)
        Me.WarningLabel.TabIndex = 14
        Me.WarningLabel.Tag = ""
        Me.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.btnLoginUser)
        Me.Controls.Add(Me.txtBoxLoginPassword)
        Me.Controls.Add(Me.txtBoxLoginUsername)
        Me.Controls.Add(Me.userProfile)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.userProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLoginAthenaPerbs As Label
    Private WithEvents minimizeButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents btnLoginUser As Button
    Friend WithEvents txtBoxLoginPassword As TextBox
    Friend WithEvents txtBoxLoginUsername As TextBox
    Friend WithEvents userProfile As PictureBox
    Friend WithEvents WarningLabel As Label
End Class
