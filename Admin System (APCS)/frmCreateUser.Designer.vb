<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateUser
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
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtBoxFname = New System.Windows.Forms.TextBox()
        Me.txtBoxMiddleName = New System.Windows.Forms.TextBox()
        Me.txtBoxLname = New System.Windows.Forms.TextBox()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxContactNumber = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.dataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtBoxID = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFname.Location = New System.Drawing.Point(798, 446)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(117, 30)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "First Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMiddleName.Location = New System.Drawing.Point(798, 515)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(142, 30)
        Me.lblMiddleName.TabIndex = 2
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLname.Location = New System.Drawing.Point(801, 583)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(114, 30)
        Me.lblLname.TabIndex = 3
        Me.lblLname.Text = "Last Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmail.Location = New System.Drawing.Point(801, 650)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(64, 30)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblContactNumber.Location = New System.Drawing.Point(801, 715)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(173, 30)
        Me.lblContactNumber.TabIndex = 5
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtBoxFname
        '
        Me.txtBoxFname.Location = New System.Drawing.Point(1063, 446)
        Me.txtBoxFname.Name = "txtBoxFname"
        Me.txtBoxFname.Size = New System.Drawing.Size(205, 23)
        Me.txtBoxFname.TabIndex = 6
        '
        'txtBoxMiddleName
        '
        Me.txtBoxMiddleName.Location = New System.Drawing.Point(1063, 516)
        Me.txtBoxMiddleName.Name = "txtBoxMiddleName"
        Me.txtBoxMiddleName.Size = New System.Drawing.Size(205, 23)
        Me.txtBoxMiddleName.TabIndex = 7
        '
        'txtBoxLname
        '
        Me.txtBoxLname.Location = New System.Drawing.Point(1063, 582)
        Me.txtBoxLname.Name = "txtBoxLname"
        Me.txtBoxLname.Size = New System.Drawing.Size(205, 23)
        Me.txtBoxLname.TabIndex = 8
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Location = New System.Drawing.Point(1063, 650)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(205, 23)
        Me.txtBoxEmail.TabIndex = 9
        '
        'txtBoxContactNumber
        '
        Me.txtBoxContactNumber.Location = New System.Drawing.Point(1063, 715)
        Me.txtBoxContactNumber.Name = "txtBoxContactNumber"
        Me.txtBoxContactNumber.Size = New System.Drawing.Size(205, 23)
        Me.txtBoxContactNumber.TabIndex = 10
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.LightGray
        Me.btnCreate.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCreate.Location = New System.Drawing.Point(764, 822)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(101, 39)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'dataGridViewUser
        '
        Me.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewUser.Location = New System.Drawing.Point(43, 361)
        Me.dataGridViewUser.Name = "dataGridViewUser"
        Me.dataGridViewUser.RowTemplate.Height = 25
        Me.dataGridViewUser.Size = New System.Drawing.Size(715, 387)
        Me.dataGridViewUser.TabIndex = 12
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblID.Location = New System.Drawing.Point(801, 376)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(34, 30)
        Me.lblID.TabIndex = 13
        Me.lblID.Text = "ID"
        '
        'txtBoxID
        '
        Me.txtBoxID.Location = New System.Drawing.Point(1063, 385)
        Me.txtBoxID.Name = "txtBoxID"
        Me.txtBoxID.Size = New System.Drawing.Size(205, 23)
        Me.txtBoxID.TabIndex = 14
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightGray
        Me.btnNew.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNew.Location = New System.Drawing.Point(929, 822)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(101, 39)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightGray
        Me.btnUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.Location = New System.Drawing.Point(1094, 822)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 39)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightGray
        Me.btnDelete.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(1261, 822)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 39)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmCreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1940, 1098)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtBoxID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dataGridViewUser)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtBoxContactNumber)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Controls.Add(Me.txtBoxLname)
        Me.Controls.Add(Me.txtBoxMiddleName)
        Me.Controls.Add(Me.txtBoxFname)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblFname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFname As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtBoxFname As TextBox
    Friend WithEvents txtBoxMiddleName As TextBox
    Friend WithEvents txtBoxLname As TextBox
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents txtBoxContactNumber As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents dataGridViewUser As DataGridView
    Friend WithEvents lblID As Label
    Friend WithEvents txtBoxID As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
