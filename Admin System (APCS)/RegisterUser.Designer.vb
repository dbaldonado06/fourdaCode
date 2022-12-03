<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterUser))
        Me.picBoxRegUserAthena = New System.Windows.Forms.PictureBox()
        Me.txtBoxRegUserFirstname = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserEmail = New System.Windows.Forms.TextBox()
        Me.btnRegUserSave = New System.Windows.Forms.Button()
        Me.pnlRegUser = New System.Windows.Forms.Panel()
        Me.btnRegUserUpdate = New System.Windows.Forms.Button()
        Me.txtUserAge = New System.Windows.Forms.TextBox()
        Me.RUWarningLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxRoleSelection = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxRegUserAddress = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.txtBoxRegUserPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserLastname = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUserMiddlename = New System.Windows.Forms.TextBox()
        Me.btnCancelUser = New System.Windows.Forms.Button()
        Me.lblRegUser = New System.Windows.Forms.Label()
        Me.txtBoxRegUserContactNum = New System.Windows.Forms.TextBox()
        CType(Me.picBoxRegUserAthena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBoxRegUserAthena
        '
        Me.picBoxRegUserAthena.Image = CType(resources.GetObject("picBoxRegUserAthena.Image"), System.Drawing.Image)
        Me.picBoxRegUserAthena.Location = New System.Drawing.Point(-1, 0)
        Me.picBoxRegUserAthena.Name = "picBoxRegUserAthena"
        Me.picBoxRegUserAthena.Size = New System.Drawing.Size(145, 83)
        Me.picBoxRegUserAthena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxRegUserAthena.TabIndex = 0
        Me.picBoxRegUserAthena.TabStop = False
        '
        'txtBoxRegUserFirstname
        '
        Me.txtBoxRegUserFirstname.Location = New System.Drawing.Point(16, 85)
        Me.txtBoxRegUserFirstname.Name = "txtBoxRegUserFirstname"
        Me.txtBoxRegUserFirstname.PlaceholderText = "Firstname"
        Me.txtBoxRegUserFirstname.Size = New System.Drawing.Size(128, 23)
        Me.txtBoxRegUserFirstname.TabIndex = 6
        '
        'txtBoxRegUserUsername
        '
        Me.txtBoxRegUserUsername.Location = New System.Drawing.Point(16, 125)
        Me.txtBoxRegUserUsername.Name = "txtBoxRegUserUsername"
        Me.txtBoxRegUserUsername.PlaceholderText = "Username"
        Me.txtBoxRegUserUsername.Size = New System.Drawing.Size(186, 23)
        Me.txtBoxRegUserUsername.TabIndex = 7
        '
        'txtBoxRegUserEmail
        '
        Me.txtBoxRegUserEmail.Location = New System.Drawing.Point(208, 238)
        Me.txtBoxRegUserEmail.Name = "txtBoxRegUserEmail"
        Me.txtBoxRegUserEmail.PlaceholderText = "Email example@mail.net"
        Me.txtBoxRegUserEmail.Size = New System.Drawing.Size(204, 23)
        Me.txtBoxRegUserEmail.TabIndex = 10
        '
        'btnRegUserSave
        '
        Me.btnRegUserSave.AccessibleName = "saveBtn"
        Me.btnRegUserSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRegUserSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUserSave.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegUserSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegUserSave.Location = New System.Drawing.Point(109, 287)
        Me.btnRegUserSave.Name = "btnRegUserSave"
        Me.btnRegUserSave.Size = New System.Drawing.Size(105, 30)
        Me.btnRegUserSave.TabIndex = 11
        Me.btnRegUserSave.Text = "SAVE"
        Me.btnRegUserSave.UseVisualStyleBackColor = False
        '
        'pnlRegUser
        '
        Me.pnlRegUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRegUser.Controls.Add(Me.btnRegUserUpdate)
        Me.pnlRegUser.Controls.Add(Me.txtUserAge)
        Me.pnlRegUser.Controls.Add(Me.RUWarningLbl)
        Me.pnlRegUser.Controls.Add(Me.Label3)
        Me.pnlRegUser.Controls.Add(Me.ComboBoxRoleSelection)
        Me.pnlRegUser.Controls.Add(Me.Label2)
        Me.pnlRegUser.Controls.Add(Me.Label1)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserAddress)
        Me.pnlRegUser.Controls.Add(Me.GenderComboBox)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserPassword)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserLastname)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserMiddlename)
        Me.pnlRegUser.Controls.Add(Me.btnCancelUser)
        Me.pnlRegUser.Controls.Add(Me.lblRegUser)
        Me.pnlRegUser.Controls.Add(Me.btnRegUserSave)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserContactNum)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserEmail)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserUsername)
        Me.pnlRegUser.Controls.Add(Me.txtBoxRegUserFirstname)
        Me.pnlRegUser.Controls.Add(Me.picBoxRegUserAthena)
        Me.pnlRegUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRegUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegUser.Name = "pnlRegUser"
        Me.pnlRegUser.Size = New System.Drawing.Size(430, 330)
        Me.pnlRegUser.TabIndex = 13
        '
        'btnRegUserUpdate
        '
        Me.btnRegUserUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRegUserUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUserUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegUserUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegUserUpdate.Location = New System.Drawing.Point(220, 287)
        Me.btnRegUserUpdate.Name = "btnRegUserUpdate"
        Me.btnRegUserUpdate.Size = New System.Drawing.Size(105, 30)
        Me.btnRegUserUpdate.TabIndex = 26
        Me.btnRegUserUpdate.Text = "UPDATE"
        Me.btnRegUserUpdate.UseVisualStyleBackColor = False
        '
        'txtUserAge
        '
        Me.txtUserAge.Location = New System.Drawing.Point(336, 201)
        Me.txtUserAge.Name = "txtUserAge"
        Me.txtUserAge.PlaceholderText = "Age"
        Me.txtUserAge.Size = New System.Drawing.Size(76, 23)
        Me.txtUserAge.TabIndex = 25
        '
        'RUWarningLbl
        '
        Me.RUWarningLbl.Location = New System.Drawing.Point(-1, 264)
        Me.RUWarningLbl.Name = "RUWarningLbl"
        Me.RUWarningLbl.Size = New System.Drawing.Size(430, 20)
        Me.RUWarningLbl.TabIndex = 24
        Me.RUWarningLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(223, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Select Role:"
        '
        'ComboBoxRoleSelection
        '
        Me.ComboBoxRoleSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxRoleSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRoleSelection.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.ComboBoxRoleSelection.Location = New System.Drawing.Point(310, 125)
        Me.ComboBoxRoleSelection.Name = "ComboBoxRoleSelection"
        Me.ComboBoxRoleSelection.Size = New System.Drawing.Size(102, 23)
        Me.ComboBoxRoleSelection.Sorted = True
        Me.ComboBoxRoleSelection.TabIndex = 22
        Me.ComboBoxRoleSelection.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(223, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Gender:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(154, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fill out the form carefully for registration"
        '
        'txtBoxRegUserAddress
        '
        Me.txtBoxRegUserAddress.Location = New System.Drawing.Point(16, 201)
        Me.txtBoxRegUserAddress.Multiline = True
        Me.txtBoxRegUserAddress.Name = "txtBoxRegUserAddress"
        Me.txtBoxRegUserAddress.PlaceholderText = "Type adress..."
        Me.txtBoxRegUserAddress.Size = New System.Drawing.Size(186, 60)
        Me.txtBoxRegUserAddress.TabIndex = 19
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Female", "Male", "Prefer not to respond"})
        Me.GenderComboBox.Location = New System.Drawing.Point(286, 165)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(126, 23)
        Me.GenderComboBox.Sorted = True
        Me.GenderComboBox.TabIndex = 0
        Me.GenderComboBox.TabStop = False
        '
        'txtBoxRegUserPassword
        '
        Me.txtBoxRegUserPassword.Location = New System.Drawing.Point(16, 165)
        Me.txtBoxRegUserPassword.Name = "txtBoxRegUserPassword"
        Me.txtBoxRegUserPassword.PlaceholderText = "Password"
        Me.txtBoxRegUserPassword.Size = New System.Drawing.Size(186, 23)
        Me.txtBoxRegUserPassword.TabIndex = 18
        Me.txtBoxRegUserPassword.UseSystemPasswordChar = True
        '
        'txtBoxRegUserLastname
        '
        Me.txtBoxRegUserLastname.Location = New System.Drawing.Point(284, 85)
        Me.txtBoxRegUserLastname.Name = "txtBoxRegUserLastname"
        Me.txtBoxRegUserLastname.PlaceholderText = "Lastname"
        Me.txtBoxRegUserLastname.Size = New System.Drawing.Size(128, 23)
        Me.txtBoxRegUserLastname.TabIndex = 17
        '
        'txtBoxRegUserMiddlename
        '
        Me.txtBoxRegUserMiddlename.Location = New System.Drawing.Point(150, 85)
        Me.txtBoxRegUserMiddlename.Name = "txtBoxRegUserMiddlename"
        Me.txtBoxRegUserMiddlename.PlaceholderText = "Middlename"
        Me.txtBoxRegUserMiddlename.Size = New System.Drawing.Size(128, 23)
        Me.txtBoxRegUserMiddlename.TabIndex = 16
        '
        'btnCancelUser
        '
        Me.btnCancelUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelUser.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelUser.FlatAppearance.BorderSize = 0
        Me.btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelUser.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelUser.ForeColor = System.Drawing.Color.Black
        Me.btnCancelUser.Location = New System.Drawing.Point(378, -2)
        Me.btnCancelUser.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancelUser.Name = "btnCancelUser"
        Me.btnCancelUser.Size = New System.Drawing.Size(51, 22)
        Me.btnCancelUser.TabIndex = 0
        Me.btnCancelUser.TabStop = False
        Me.btnCancelUser.Text = "[ esc ]"
        Me.btnCancelUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelUser.UseVisualStyleBackColor = False
        '
        'lblRegUser
        '
        Me.lblRegUser.AutoSize = True
        Me.lblRegUser.Font = New System.Drawing.Font("Bell MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRegUser.Location = New System.Drawing.Point(149, 20)
        Me.lblRegUser.Name = "lblRegUser"
        Me.lblRegUser.Size = New System.Drawing.Size(129, 26)
        Me.lblRegUser.TabIndex = 1
        Me.lblRegUser.Text = "Create User"
        '
        'txtBoxRegUserContactNum
        '
        Me.txtBoxRegUserContactNum.Location = New System.Drawing.Point(208, 201)
        Me.txtBoxRegUserContactNum.Name = "txtBoxRegUserContactNum"
        Me.txtBoxRegUserContactNum.PlaceholderText = "Contact Number 09*********"
        Me.txtBoxRegUserContactNum.Size = New System.Drawing.Size(122, 23)
        Me.txtBoxRegUserContactNum.TabIndex = 15
        '
        'RegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(430, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlRegUser)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterUser"
        CType(Me.picBoxRegUserAthena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegUser.ResumeLayout(False)
        Me.pnlRegUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBoxRegUserAthena As PictureBox
    Friend WithEvents txtBoxRegUserFirstname As TextBox
    Friend WithEvents txtBoxRegUserUsername As TextBox
    Friend WithEvents txtBoxRegUserEmail As TextBox
    Friend WithEvents btnRegUserSave As Button
    Friend WithEvents pnlRegUser As Panel
    Friend WithEvents txtBoxRegUserContactNum As TextBox
    Friend WithEvents lblRegUser As Label
    Friend WithEvents btnCancelUser As Button
    Friend WithEvents txtBoxRegUserPassword As TextBox
    Friend WithEvents txtBoxRegUserLastname As TextBox
    Friend WithEvents txtBoxRegUserMiddlename As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents txtBoxRegUserAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxRoleSelection As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RUWarningLbl As Label
    Friend WithEvents txtUserAge As TextBox
    Friend WithEvents btnRegUserUpdate As Button
End Class
