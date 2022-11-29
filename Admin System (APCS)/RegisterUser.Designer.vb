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
        Me.lblRegUserAddress = New System.Windows.Forms.Label()
        Me.lblRegUserPhoneNumber = New System.Windows.Forms.Label()
        Me.lblRegUserEmail = New System.Windows.Forms.Label()
        Me.txtBoxRegUserUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserAddress = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserEmail = New System.Windows.Forms.TextBox()
        Me.btnRegUserSave = New System.Windows.Forms.Button()
        Me.btnRegUserCancel = New System.Windows.Forms.Button()
        Me.pnlRegUser = New System.Windows.Forms.Panel()
        Me.pnlTopRegUser.SuspendLayout()
        CType(Me.picBoxRegUserClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxRegUserAthena, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTopRegUser.Size = New System.Drawing.Size(372, 57)
        Me.pnlTopRegUser.TabIndex = 0
        '
        'picBoxRegUserClose
        '
        Me.picBoxRegUserClose.Image = CType(resources.GetObject("picBoxRegUserClose.Image"), System.Drawing.Image)
        Me.picBoxRegUserClose.Location = New System.Drawing.Point(312, 2)
        Me.picBoxRegUserClose.Name = "picBoxRegUserClose"
        Me.picBoxRegUserClose.Size = New System.Drawing.Size(56, 54)
        Me.picBoxRegUserClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxRegUserClose.TabIndex = 2
        Me.picBoxRegUserClose.TabStop = False
        '
        'lblRegUser
        '
        Me.lblRegUser.AutoSize = True
        Me.lblRegUser.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUser.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRegUser.Location = New System.Drawing.Point(126, 9)
        Me.lblRegUser.Name = "lblRegUser"
        Me.lblRegUser.Size = New System.Drawing.Size(159, 32)
        Me.lblRegUser.TabIndex = 1
        Me.lblRegUser.Text = "Register User"
        '
        'picBoxRegUserAthena
        '
        Me.picBoxRegUserAthena.Image = CType(resources.GetObject("picBoxRegUserAthena.Image"), System.Drawing.Image)
        Me.picBoxRegUserAthena.Location = New System.Drawing.Point(0, 0)
        Me.picBoxRegUserAthena.Name = "picBoxRegUserAthena"
        Me.picBoxRegUserAthena.Size = New System.Drawing.Size(109, 70)
        Me.picBoxRegUserAthena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxRegUserAthena.TabIndex = 0
        Me.picBoxRegUserAthena.TabStop = False
        '
        'lblRegUserUsername
        '
        Me.lblRegUserUsername.AutoSize = True
        Me.lblRegUserUsername.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserUsername.Location = New System.Drawing.Point(43, 109)
        Me.lblRegUserUsername.Name = "lblRegUserUsername"
        Me.lblRegUserUsername.Size = New System.Drawing.Size(83, 21)
        Me.lblRegUserUsername.TabIndex = 1
        Me.lblRegUserUsername.Text = "Username"
        '
        'lblRegUserPassword
        '
        Me.lblRegUserPassword.AutoSize = True
        Me.lblRegUserPassword.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserPassword.Location = New System.Drawing.Point(43, 161)
        Me.lblRegUserPassword.Name = "lblRegUserPassword"
        Me.lblRegUserPassword.Size = New System.Drawing.Size(79, 21)
        Me.lblRegUserPassword.TabIndex = 2
        Me.lblRegUserPassword.Text = "Password"
        '
        'lblRegUserAddress
        '
        Me.lblRegUserAddress.AutoSize = True
        Me.lblRegUserAddress.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserAddress.Location = New System.Drawing.Point(43, 214)
        Me.lblRegUserAddress.Name = "lblRegUserAddress"
        Me.lblRegUserAddress.Size = New System.Drawing.Size(70, 21)
        Me.lblRegUserAddress.TabIndex = 3
        Me.lblRegUserAddress.Text = "Address"
        '
        'lblRegUserPhoneNumber
        '
        Me.lblRegUserPhoneNumber.AutoSize = True
        Me.lblRegUserPhoneNumber.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserPhoneNumber.Location = New System.Drawing.Point(43, 270)
        Me.lblRegUserPhoneNumber.Name = "lblRegUserPhoneNumber"
        Me.lblRegUserPhoneNumber.Size = New System.Drawing.Size(120, 21)
        Me.lblRegUserPhoneNumber.TabIndex = 4
        Me.lblRegUserPhoneNumber.Text = "Phone Number"
        '
        'lblRegUserEmail
        '
        Me.lblRegUserEmail.AutoSize = True
        Me.lblRegUserEmail.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUserEmail.Location = New System.Drawing.Point(43, 315)
        Me.lblRegUserEmail.Name = "lblRegUserEmail"
        Me.lblRegUserEmail.Size = New System.Drawing.Size(48, 21)
        Me.lblRegUserEmail.TabIndex = 5
        Me.lblRegUserEmail.Text = "Email"
        '
        'txtBoxRegUserUsername
        '
        Me.txtBoxRegUserUsername.Location = New System.Drawing.Point(175, 107)
        Me.txtBoxRegUserUsername.Name = "txtBoxRegUserUsername"
        Me.txtBoxRegUserUsername.Size = New System.Drawing.Size(159, 23)
        Me.txtBoxRegUserUsername.TabIndex = 6
        '
        'txtBoxRegUserPassword
        '
        Me.txtBoxRegUserPassword.Location = New System.Drawing.Point(175, 159)
        Me.txtBoxRegUserPassword.Name = "txtBoxRegUserPassword"
        Me.txtBoxRegUserPassword.Size = New System.Drawing.Size(159, 23)
        Me.txtBoxRegUserPassword.TabIndex = 7
        '
        'txtBoxRegUserAddress
        '
        Me.txtBoxRegUserAddress.Location = New System.Drawing.Point(175, 212)
        Me.txtBoxRegUserAddress.Name = "txtBoxRegUserAddress"
        Me.txtBoxRegUserAddress.Size = New System.Drawing.Size(159, 23)
        Me.txtBoxRegUserAddress.TabIndex = 8
        '
        'txtBoxRegUserPhoneNumber
        '
        Me.txtBoxRegUserPhoneNumber.Location = New System.Drawing.Point(175, 268)
        Me.txtBoxRegUserPhoneNumber.Name = "txtBoxRegUserPhoneNumber"
        Me.txtBoxRegUserPhoneNumber.Size = New System.Drawing.Size(159, 23)
        Me.txtBoxRegUserPhoneNumber.TabIndex = 9
        '
        'txtBoxRegUserEmail
        '
        Me.txtBoxRegUserEmail.Location = New System.Drawing.Point(175, 313)
        Me.txtBoxRegUserEmail.Name = "txtBoxRegUserEmail"
        Me.txtBoxRegUserEmail.Size = New System.Drawing.Size(159, 23)
        Me.txtBoxRegUserEmail.TabIndex = 10
        '
        'btnRegUserSave
        '
        Me.btnRegUserSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRegUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUserSave.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegUserSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegUserSave.Location = New System.Drawing.Point(86, 394)
        Me.btnRegUserSave.Name = "btnRegUserSave"
        Me.btnRegUserSave.Size = New System.Drawing.Size(77, 33)
        Me.btnRegUserSave.TabIndex = 11
        Me.btnRegUserSave.Text = "SAVE"
        Me.btnRegUserSave.UseVisualStyleBackColor = False
        '
        'btnRegUserCancel
        '
        Me.btnRegUserCancel.BackColor = System.Drawing.Color.Gray
        Me.btnRegUserCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUserCancel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegUserCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegUserCancel.Location = New System.Drawing.Point(208, 394)
        Me.btnRegUserCancel.Name = "btnRegUserCancel"
        Me.btnRegUserCancel.Size = New System.Drawing.Size(88, 33)
        Me.btnRegUserCancel.TabIndex = 12
        Me.btnRegUserCancel.Text = "CANCEL"
        Me.btnRegUserCancel.UseVisualStyleBackColor = False
        '
        'pnlRegUser
        '
        Me.pnlRegUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRegUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRegUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegUser.Name = "pnlRegUser"
        Me.pnlRegUser.Size = New System.Drawing.Size(372, 455)
        Me.pnlRegUser.TabIndex = 13
        '
        'RegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(372, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegUserCancel)
        Me.Controls.Add(Me.btnRegUserSave)
        Me.Controls.Add(Me.txtBoxRegUserEmail)
        Me.Controls.Add(Me.txtBoxRegUserPhoneNumber)
        Me.Controls.Add(Me.txtBoxRegUserAddress)
        Me.Controls.Add(Me.txtBoxRegUserPassword)
        Me.Controls.Add(Me.txtBoxRegUserUsername)
        Me.Controls.Add(Me.lblRegUserEmail)
        Me.Controls.Add(Me.lblRegUserPhoneNumber)
        Me.Controls.Add(Me.lblRegUserAddress)
        Me.Controls.Add(Me.lblRegUserPassword)
        Me.Controls.Add(Me.lblRegUserUsername)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTopRegUser As Panel
    Friend WithEvents lblRegUser As Label
    Friend WithEvents picBoxRegUserAthena As PictureBox
    Friend WithEvents lblRegUserUsername As Label
    Friend WithEvents lblRegUserPassword As Label
    Friend WithEvents lblRegUserAddress As Label
    Friend WithEvents lblRegUserPhoneNumber As Label
    Friend WithEvents lblRegUserEmail As Label
    Friend WithEvents txtBoxRegUserUsername As TextBox
    Friend WithEvents txtBoxRegUserPassword As TextBox
    Friend WithEvents txtBoxRegUserAddress As TextBox
    Friend WithEvents txtBoxRegUserPhoneNumber As TextBox
    Friend WithEvents txtBoxRegUserEmail As TextBox
    Friend WithEvents btnRegUserSave As Button
    Friend WithEvents btnRegUserCancel As Button
    Friend WithEvents picBoxRegUserClose As PictureBox
    Friend WithEvents pnlRegUser As Panel
End Class
