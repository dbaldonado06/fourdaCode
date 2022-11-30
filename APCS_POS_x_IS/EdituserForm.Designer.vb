<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EdituserForm
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
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDProductEntry = New System.Windows.Forms.Label()
        Me.lblProductEntryDescription = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.lblProductMenuCategory = New System.Windows.Forms.Label()
        Me.phonenumbTextBox = New System.Windows.Forms.TextBox()
        Me.lblProductMenuPrice = New System.Windows.Forms.Label()
        Me.lblProductMenuStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelButton
        '
        Me.cancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelButton.Location = New System.Drawing.Point(502, 223)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(74, 27)
        Me.cancelButton.TabIndex = 0
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveButton.Location = New System.Drawing.Point(422, 223)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(74, 27)
        Me.saveButton.TabIndex = 1
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 37)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDIT"
        '
        'lblIDProductEntry
        '
        Me.lblIDProductEntry.AutoSize = True
        Me.lblIDProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIDProductEntry.Location = New System.Drawing.Point(6, 44)
        Me.lblIDProductEntry.Name = "lblIDProductEntry"
        Me.lblIDProductEntry.Size = New System.Drawing.Size(60, 15)
        Me.lblIDProductEntry.TabIndex = 44
        Me.lblIDProductEntry.Text = "Username"
        '
        'lblProductEntryDescription
        '
        Me.lblProductEntryDescription.AutoSize = True
        Me.lblProductEntryDescription.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntryDescription.Location = New System.Drawing.Point(6, 73)
        Me.lblProductEntryDescription.Name = "lblProductEntryDescription"
        Me.lblProductEntryDescription.Size = New System.Drawing.Size(57, 15)
        Me.lblProductEntryDescription.TabIndex = 36
        Me.lblProductEntryDescription.Text = "Password"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.passwordTextBox.Location = New System.Drawing.Point(99, 71)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(476, 23)
        Me.passwordTextBox.TabIndex = 37
        '
        'lblProductMenuCategory
        '
        Me.lblProductMenuCategory.AutoSize = True
        Me.lblProductMenuCategory.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuCategory.Location = New System.Drawing.Point(6, 102)
        Me.lblProductMenuCategory.Name = "lblProductMenuCategory"
        Me.lblProductMenuCategory.Size = New System.Drawing.Size(0, 15)
        Me.lblProductMenuCategory.TabIndex = 38
        '
        'phonenumbTextBox
        '
        Me.phonenumbTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.phonenumbTextBox.Location = New System.Drawing.Point(99, 125)
        Me.phonenumbTextBox.Name = "phonenumbTextBox"
        Me.phonenumbTextBox.Size = New System.Drawing.Size(476, 23)
        Me.phonenumbTextBox.TabIndex = 40
        '
        'lblProductMenuPrice
        '
        Me.lblProductMenuPrice.AutoSize = True
        Me.lblProductMenuPrice.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuPrice.Location = New System.Drawing.Point(7, 129)
        Me.lblProductMenuPrice.Name = "lblProductMenuPrice"
        Me.lblProductMenuPrice.Size = New System.Drawing.Size(88, 15)
        Me.lblProductMenuPrice.TabIndex = 41
        Me.lblProductMenuPrice.Text = "Phone Number"
        '
        'lblProductMenuStatus
        '
        Me.lblProductMenuStatus.AutoSize = True
        Me.lblProductMenuStatus.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuStatus.Location = New System.Drawing.Point(7, 156)
        Me.lblProductMenuStatus.Name = "lblProductMenuStatus"
        Me.lblProductMenuStatus.Size = New System.Drawing.Size(36, 15)
        Me.lblProductMenuStatus.TabIndex = 42
        Me.lblProductMenuStatus.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(7, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Address"
        '
        'addressTextBox
        '
        Me.addressTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.addressTextBox.Location = New System.Drawing.Point(100, 99)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(476, 23)
        Me.addressTextBox.TabIndex = 47
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.emailTextBox.Location = New System.Drawing.Point(100, 153)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(476, 23)
        Me.emailTextBox.TabIndex = 48
        '
        'usernameTextBox
        '
        Me.usernameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.usernameTextBox.Location = New System.Drawing.Point(100, 44)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(476, 23)
        Me.usernameTextBox.TabIndex = 49
        '
        'EdituserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 261)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblIDProductEntry)
        Me.Controls.Add(Me.lblProductEntryDescription)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.lblProductMenuCategory)
        Me.Controls.Add(Me.phonenumbTextBox)
        Me.Controls.Add(Me.lblProductMenuPrice)
        Me.Controls.Add(Me.lblProductMenuStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.cancelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EdituserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EdituserForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIDProductEntry As Label
    Friend WithEvents lblProductEntryDescription As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents lblProductMenuCategory As Label
    Friend WithEvents phonenumbTextBox As TextBox
    Friend WithEvents lblProductMenuPrice As Label
    Friend WithEvents lblProductMenuStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents usernameTextBox As TextBox
End Class
