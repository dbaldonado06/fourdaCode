<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterUser))
        Me.pnlTopRegUser = New System.Windows.Forms.Panel()
        Me.picBoxRegUserClose = New System.Windows.Forms.PictureBox()
        Me.lblRegUser = New System.Windows.Forms.Label()
        Me.picBoxRegUserAthena = New System.Windows.Forms.PictureBox()
        Me.lblRegUserUsername = New System.Windows.Forms.Label()
        Me.lblRegUserPassword = New System.Windows.Forms.Label()
        Me.lblRegUserName = New System.Windows.Forms.Label()
        Me.txtBoxRegUserUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserName = New System.Windows.Forms.TextBox()
        Me.btnRegUserSave = New System.Windows.Forms.Button()
        Me.btnRegUserCancel = New System.Windows.Forms.Button()
        Me.pnlRegUser = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblRegUserConfirmPassword = New System.Windows.Forms.Label()
        Me.pnlTopRegUser.SuspendLayout()
        CType(Me.picBoxRegUserClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxRegUserAthena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopRegUser
        '
        Me.pnlTopRegUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.pnlTopRegUser.Controls.Add(Me.picBoxRegUserClose)
        Me.pnlTopRegUser.Controls.Add(Me.lblRegUser)
        Me.pnlTopRegUser.Controls.Add(Me.picBoxRegUserAthena)
        Me.pnlTopRegUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopRegUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopRegUser.Name = "pnlTopRegUser"
        Me.pnlTopRegUser.Size = New System.Drawing.Size(414, 48)
        Me.pnlTopRegUser.TabIndex = 0
        '
        'picBoxRegUserClose
        '
        Me.picBoxRegUserClose.Image = CType(resources.GetObject("picBoxRegUserClose.Image"), System.Drawing.Image)
        Me.picBoxRegUserClose.Location = New System.Drawing.Point(369, 4)
        Me.picBoxRegUserClose.Name = "picBoxRegUserClose"
        Me.picBoxRegUserClose.Size = New System.Drawing.Size(41, 39)
        Me.picBoxRegUserClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxRegUserClose.TabIndex = 2
        Me.picBoxRegUserClose.TabStop = False
        '
        'lblRegUser
        '
        Me.lblRegUser.AutoSize = True
        Me.lblRegUser.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUser.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRegUser.Location = New System.Drawing.Point(139, 9)
        Me.lblRegUser.Name = "lblRegUser"
        Me.lblRegUser.Size = New System.Drawing.Size(140, 30)
        Me.lblRegUser.TabIndex = 1
        Me.lblRegUser.Text = "Register User"
        '
        'picBoxRegUserAthena
        '
        Me.picBoxRegUserAthena.Image = CType(resources.GetObject("picBoxRegUserAthena.Image"), System.Drawing.Image)
        Me.picBoxRegUserAthena.Location = New System.Drawing.Point(0, -7)
        Me.picBoxRegUserAthena.Name = "picBoxRegUserAthena"
        Me.picBoxRegUserAthena.Size = New System.Drawing.Size(79, 66)
        Me.picBoxRegUserAthena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxRegUserAthena.TabIndex = 0
        Me.picBoxRegUserAthena.TabStop = False
        '
        'lblRegUserUsername
        '
        Me.lblRegUserUsername.AutoSize = True
        Me.lblRegUserUsername.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserUsername.Location = New System.Drawing.Point(25, 81)
        Me.lblRegUserUsername.Name = "lblRegUserUsername"
        Me.lblRegUserUsername.Size = New System.Drawing.Size(83, 21)
        Me.lblRegUserUsername.TabIndex = 1
        Me.lblRegUserUsername.Text = "Username"
        '
        'lblRegUserPassword
        '
        Me.lblRegUserPassword.AutoSize = True
        Me.lblRegUserPassword.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserPassword.Location = New System.Drawing.Point(25, 123)
        Me.lblRegUserPassword.Name = "lblRegUserPassword"
        Me.lblRegUserPassword.Size = New System.Drawing.Size(79, 21)
        Me.lblRegUserPassword.TabIndex = 2
        Me.lblRegUserPassword.Text = "Password"
        '
        'lblRegUserName
        '
        Me.lblRegUserName.AutoSize = True
        Me.lblRegUserName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserName.Location = New System.Drawing.Point(25, 201)
        Me.lblRegUserName.Name = "lblRegUserName"
        Me.lblRegUserName.Size = New System.Drawing.Size(53, 21)
        Me.lblRegUserName.TabIndex = 5
        Me.lblRegUserName.Text = "Name"
        '
        'txtBoxRegUserUsername
        '
        Me.txtBoxRegUserUsername.Location = New System.Drawing.Point(174, 83)
        Me.txtBoxRegUserUsername.Name = "txtBoxRegUserUsername"
        Me.txtBoxRegUserUsername.Size = New System.Drawing.Size(208, 23)
        Me.txtBoxRegUserUsername.TabIndex = 6
        '
        'txtBoxRegUserPassword
        '
        Me.txtBoxRegUserPassword.Location = New System.Drawing.Point(174, 121)
        Me.txtBoxRegUserPassword.Name = "txtBoxRegUserPassword"
        Me.txtBoxRegUserPassword.Size = New System.Drawing.Size(208, 23)
        Me.txtBoxRegUserPassword.TabIndex = 7
        '
        'txtBoxRegUserName
        '
        Me.txtBoxRegUserName.Location = New System.Drawing.Point(174, 201)
        Me.txtBoxRegUserName.Name = "txtBoxRegUserName"
        Me.txtBoxRegUserName.Size = New System.Drawing.Size(208, 23)
        Me.txtBoxRegUserName.TabIndex = 10
        '
        'btnRegUserSave
        '
        Me.btnRegUserSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRegUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUserSave.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegUserSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegUserSave.Location = New System.Drawing.Point(91, 263)
        Me.btnRegUserSave.Name = "btnRegUserSave"
        Me.btnRegUserSave.Size = New System.Drawing.Size(105, 30)
        Me.btnRegUserSave.TabIndex = 11
        Me.btnRegUserSave.Text = "SAVE"
        Me.btnRegUserSave.UseVisualStyleBackColor = False
        '
        'btnRegUserCancel
        '
        Me.btnRegUserCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnRegUserCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUserCancel.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegUserCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegUserCancel.Location = New System.Drawing.Point(202, 263)
        Me.btnRegUserCancel.Name = "btnRegUserCancel"
        Me.btnRegUserCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnRegUserCancel.TabIndex = 12
        Me.btnRegUserCancel.Text = "CANCEL"
        Me.btnRegUserCancel.UseVisualStyleBackColor = False
        '
        'pnlRegUser
        '
        Me.pnlRegUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRegUser.Controls.Add(Me.btnRegUserSave)
        Me.pnlRegUser.Controls.Add(Me.btnRegUserCancel)
        Me.pnlRegUser.Controls.Add(Me.TextBox1)
        Me.pnlRegUser.Controls.Add(Me.lblRegUserConfirmPassword)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserName)
        Me.pnlRegUser.Controls.Add(Me.lblRegUserName)
        Me.pnlRegUser.Controls.Add(Me.lblRegUserUsername)
        Me.pnlRegUser.Controls.Add(Me.lblRegUserPassword)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserPassword)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserUsername)
        Me.pnlRegUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRegUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegUser.Name = "pnlRegUser"
        Me.pnlRegUser.Size = New System.Drawing.Size(414, 328)
        Me.pnlRegUser.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(174, 162)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 23)
        Me.TextBox1.TabIndex = 15
        '
        'lblRegUserConfirmPassword
        '
        Me.lblRegUserConfirmPassword.AutoSize = True
        Me.lblRegUserConfirmPassword.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserConfirmPassword.Location = New System.Drawing.Point(25, 162)
        Me.lblRegUserConfirmPassword.Name = "lblRegUserConfirmPassword"
        Me.lblRegUserConfirmPassword.Size = New System.Drawing.Size(141, 21)
        Me.lblRegUserConfirmPassword.TabIndex = 14
        Me.lblRegUserConfirmPassword.Text = "Confirm Password"
        '
        'RegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(414, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTopRegUser)
        Me.Controls.Add(Me.pnlRegUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterUser"
        Me.pnlTopRegUser.ResumeLayout(False)
        Me.pnlTopRegUser.PerformLayout()
        CType(Me.picBoxRegUserClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxRegUserAthena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegUser.ResumeLayout(False)
        Me.pnlRegUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopRegUser As Panel
    Friend WithEvents lblRegUser As Label
    Friend WithEvents picBoxRegUserAthena As PictureBox
    Friend WithEvents lblRegUserUsername As Label
    Friend WithEvents lblRegUserPassword As Label
    Friend WithEvents lblRegUserName As Label
    Friend WithEvents txtBoxRegUserUsername As TextBox
    Friend WithEvents txtBoxRegUserPassword As TextBox
    Friend WithEvents txtBoxRegUserName As TextBox
    Friend WithEvents btnRegUserSave As Button
    Friend WithEvents btnRegUserCancel As Button
    Friend WithEvents picBoxRegUserClose As PictureBox
    Friend WithEvents pnlRegUser As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblRegUserConfirmPassword As Label
End Class
