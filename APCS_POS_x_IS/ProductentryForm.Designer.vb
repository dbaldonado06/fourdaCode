<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductentryForm
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtProductEntryID = New System.Windows.Forms.TextBox()
        Me.lblIDProductEntry = New System.Windows.Forms.Label()
        Me.btnProductEntryBrowseImage = New System.Windows.Forms.Button()
        Me.btnProductEntryCancel = New System.Windows.Forms.Button()
        Me.btnProductEntryUpdate = New System.Windows.Forms.Button()
        Me.btnProductEntrySave = New System.Windows.Forms.Button()
        Me.picBoxProductEntry = New System.Windows.Forms.PictureBox()
        Me.comboProductEntryStatus = New System.Windows.Forms.ComboBox()
        Me.lblProductMenuStatus = New System.Windows.Forms.Label()
        Me.lblProductMenuPrice = New System.Windows.Forms.Label()
        Me.txtProductEntryPrice = New System.Windows.Forms.TextBox()
        Me.comboProductEntryCategory = New System.Windows.Forms.ComboBox()
        Me.lblProductMenuCategory = New System.Windows.Forms.Label()
        Me.txtProductEntryDescription = New System.Windows.Forms.TextBox()
        Me.lblProductEntryDescription = New System.Windows.Forms.Label()
        Me.lblProductEntry = New System.Windows.Forms.Label()
        Me.pnlProductEntry = New System.Windows.Forms.Panel()
        CType(Me.picBoxProductEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(594, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 25)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtProductEntryID
        '
        Me.txtProductEntryID.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductEntryID.Enabled = False
        Me.txtProductEntryID.Location = New System.Drawing.Point(135, 168)
        Me.txtProductEntryID.Name = "txtProductEntryID"
        Me.txtProductEntryID.Size = New System.Drawing.Size(499, 23)
        Me.txtProductEntryID.TabIndex = 35
        Me.txtProductEntryID.Text = "(Auto)"
        '
        'lblIDProductEntry
        '
        Me.lblIDProductEntry.AutoSize = True
        Me.lblIDProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIDProductEntry.Location = New System.Drawing.Point(52, 169)
        Me.lblIDProductEntry.Name = "lblIDProductEntry"
        Me.lblIDProductEntry.Size = New System.Drawing.Size(20, 15)
        Me.lblIDProductEntry.TabIndex = 34
        Me.lblIDProductEntry.Text = "ID"
        '
        'btnProductEntryBrowseImage
        '
        Me.btnProductEntryBrowseImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnProductEntryBrowseImage.FlatAppearance.BorderSize = 0
        Me.btnProductEntryBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntryBrowseImage.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntryBrowseImage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductEntryBrowseImage.Location = New System.Drawing.Point(669, 327)
        Me.btnProductEntryBrowseImage.Name = "btnProductEntryBrowseImage"
        Me.btnProductEntryBrowseImage.Size = New System.Drawing.Size(258, 32)
        Me.btnProductEntryBrowseImage.TabIndex = 33
        Me.btnProductEntryBrowseImage.Text = "Browse Image"
        Me.btnProductEntryBrowseImage.UseVisualStyleBackColor = False
        '
        'btnProductEntryCancel
        '
        Me.btnProductEntryCancel.BackColor = System.Drawing.Color.Gray
        Me.btnProductEntryCancel.FlatAppearance.BorderSize = 0
        Me.btnProductEntryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntryCancel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntryCancel.ForeColor = System.Drawing.Color.Black
        Me.btnProductEntryCancel.Location = New System.Drawing.Point(330, 330)
        Me.btnProductEntryCancel.Name = "btnProductEntryCancel"
        Me.btnProductEntryCancel.Size = New System.Drawing.Size(91, 29)
        Me.btnProductEntryCancel.TabIndex = 32
        Me.btnProductEntryCancel.Text = "CANCEL"
        Me.btnProductEntryCancel.UseVisualStyleBackColor = False
        '
        'btnProductEntryUpdate
        '
        Me.btnProductEntryUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnProductEntryUpdate.FlatAppearance.BorderSize = 0
        Me.btnProductEntryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntryUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntryUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductEntryUpdate.Location = New System.Drawing.Point(233, 330)
        Me.btnProductEntryUpdate.Name = "btnProductEntryUpdate"
        Me.btnProductEntryUpdate.Size = New System.Drawing.Size(91, 29)
        Me.btnProductEntryUpdate.TabIndex = 31
        Me.btnProductEntryUpdate.Text = "UPDATE"
        Me.btnProductEntryUpdate.UseVisualStyleBackColor = False
        '
        'btnProductEntrySave
        '
        Me.btnProductEntrySave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnProductEntrySave.FlatAppearance.BorderSize = 0
        Me.btnProductEntrySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntrySave.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntrySave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductEntrySave.Location = New System.Drawing.Point(136, 330)
        Me.btnProductEntrySave.Name = "btnProductEntrySave"
        Me.btnProductEntrySave.Size = New System.Drawing.Size(91, 29)
        Me.btnProductEntrySave.TabIndex = 30
        Me.btnProductEntrySave.Text = "SAVE"
        Me.btnProductEntrySave.UseVisualStyleBackColor = False
        '
        'picBoxProductEntry
        '
        Me.picBoxProductEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBoxProductEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxProductEntry.Location = New System.Drawing.Point(669, 89)
        Me.picBoxProductEntry.Name = "picBoxProductEntry"
        Me.picBoxProductEntry.Size = New System.Drawing.Size(258, 233)
        Me.picBoxProductEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxProductEntry.TabIndex = 29
        Me.picBoxProductEntry.TabStop = False
        '
        'comboProductEntryStatus
        '
        Me.comboProductEntryStatus.BackColor = System.Drawing.SystemColors.Control
        Me.comboProductEntryStatus.FormattingEnabled = True
        Me.comboProductEntryStatus.Location = New System.Drawing.Point(134, 276)
        Me.comboProductEntryStatus.Name = "comboProductEntryStatus"
        Me.comboProductEntryStatus.Size = New System.Drawing.Size(499, 23)
        Me.comboProductEntryStatus.TabIndex = 28
        '
        'lblProductMenuStatus
        '
        Me.lblProductMenuStatus.AutoSize = True
        Me.lblProductMenuStatus.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuStatus.Location = New System.Drawing.Point(53, 281)
        Me.lblProductMenuStatus.Name = "lblProductMenuStatus"
        Me.lblProductMenuStatus.Size = New System.Drawing.Size(40, 15)
        Me.lblProductMenuStatus.TabIndex = 27
        Me.lblProductMenuStatus.Text = "Status"
        '
        'lblProductMenuPrice
        '
        Me.lblProductMenuPrice.AutoSize = True
        Me.lblProductMenuPrice.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuPrice.Location = New System.Drawing.Point(53, 254)
        Me.lblProductMenuPrice.Name = "lblProductMenuPrice"
        Me.lblProductMenuPrice.Size = New System.Drawing.Size(33, 15)
        Me.lblProductMenuPrice.TabIndex = 26
        Me.lblProductMenuPrice.Text = "Price"
        '
        'txtProductEntryPrice
        '
        Me.txtProductEntryPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductEntryPrice.Location = New System.Drawing.Point(134, 250)
        Me.txtProductEntryPrice.Name = "txtProductEntryPrice"
        Me.txtProductEntryPrice.Size = New System.Drawing.Size(499, 23)
        Me.txtProductEntryPrice.TabIndex = 25
        '
        'comboProductEntryCategory
        '
        Me.comboProductEntryCategory.BackColor = System.Drawing.SystemColors.Control
        Me.comboProductEntryCategory.FormattingEnabled = True
        Me.comboProductEntryCategory.Location = New System.Drawing.Point(134, 223)
        Me.comboProductEntryCategory.Name = "comboProductEntryCategory"
        Me.comboProductEntryCategory.Size = New System.Drawing.Size(456, 23)
        Me.comboProductEntryCategory.TabIndex = 24
        '
        'lblProductMenuCategory
        '
        Me.lblProductMenuCategory.AutoSize = True
        Me.lblProductMenuCategory.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuCategory.Location = New System.Drawing.Point(52, 227)
        Me.lblProductMenuCategory.Name = "lblProductMenuCategory"
        Me.lblProductMenuCategory.Size = New System.Drawing.Size(54, 15)
        Me.lblProductMenuCategory.TabIndex = 23
        Me.lblProductMenuCategory.Text = "Category"
        '
        'txtProductEntryDescription
        '
        Me.txtProductEntryDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductEntryDescription.Location = New System.Drawing.Point(134, 196)
        Me.txtProductEntryDescription.Name = "txtProductEntryDescription"
        Me.txtProductEntryDescription.Size = New System.Drawing.Size(499, 23)
        Me.txtProductEntryDescription.TabIndex = 22
        '
        'lblProductEntryDescription
        '
        Me.lblProductEntryDescription.AutoSize = True
        Me.lblProductEntryDescription.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntryDescription.Location = New System.Drawing.Point(52, 198)
        Me.lblProductEntryDescription.Name = "lblProductEntryDescription"
        Me.lblProductEntryDescription.Size = New System.Drawing.Size(68, 15)
        Me.lblProductEntryDescription.TabIndex = 21
        Me.lblProductEntryDescription.Text = "Description"
        '
        'lblProductEntry
        '
        Me.lblProductEntry.AutoSize = True
        Me.lblProductEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntry.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProductEntry.Location = New System.Drawing.Point(3, 8)
        Me.lblProductEntry.Name = "lblProductEntry"
        Me.lblProductEntry.Size = New System.Drawing.Size(145, 30)
        Me.lblProductEntry.TabIndex = 19
        Me.lblProductEntry.Text = "Product Entry"
        '
        'pnlProductEntry
        '
        Me.pnlProductEntry.Controls.Add(Me.Button4)
        Me.pnlProductEntry.Controls.Add(Me.lblProductEntry)
        Me.pnlProductEntry.Controls.Add(Me.txtProductEntryID)
        Me.pnlProductEntry.Controls.Add(Me.lblIDProductEntry)
        Me.pnlProductEntry.Controls.Add(Me.lblProductEntryDescription)
        Me.pnlProductEntry.Controls.Add(Me.btnProductEntryBrowseImage)
        Me.pnlProductEntry.Controls.Add(Me.txtProductEntryDescription)
        Me.pnlProductEntry.Controls.Add(Me.btnProductEntryCancel)
        Me.pnlProductEntry.Controls.Add(Me.lblProductMenuCategory)
        Me.pnlProductEntry.Controls.Add(Me.btnProductEntryUpdate)
        Me.pnlProductEntry.Controls.Add(Me.comboProductEntryCategory)
        Me.pnlProductEntry.Controls.Add(Me.btnProductEntrySave)
        Me.pnlProductEntry.Controls.Add(Me.txtProductEntryPrice)
        Me.pnlProductEntry.Controls.Add(Me.picBoxProductEntry)
        Me.pnlProductEntry.Controls.Add(Me.lblProductMenuPrice)
        Me.pnlProductEntry.Controls.Add(Me.comboProductEntryStatus)
        Me.pnlProductEntry.Controls.Add(Me.lblProductMenuStatus)
        Me.pnlProductEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlProductEntry.Location = New System.Drawing.Point(0, 0)
        Me.pnlProductEntry.Name = "pnlProductEntry"
        Me.pnlProductEntry.Size = New System.Drawing.Size(949, 442)
        Me.pnlProductEntry.TabIndex = 37
        '
        'ProductentryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 442)
        Me.Controls.Add(Me.pnlProductEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductentryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductentryForm"
        CType(Me.picBoxProductEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductEntry.ResumeLayout(False)
        Me.pnlProductEntry.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents txtProductEntryID As TextBox
    Friend WithEvents lblIDProductEntry As Label
    Friend WithEvents btnProductEntryBrowseImage As Button
    Friend WithEvents btnProductEntryCancel As Button
    Friend WithEvents btnProductEntryUpdate As Button
    Friend WithEvents btnProductEntrySave As Button
    Friend WithEvents picBoxProductEntry As PictureBox
    Friend WithEvents comboProductEntryStatus As ComboBox
    Friend WithEvents lblProductMenuStatus As Label
    Friend WithEvents lblProductMenuPrice As Label
    Friend WithEvents txtProductEntryPrice As TextBox
    Friend WithEvents comboProductEntryCategory As ComboBox
    Friend WithEvents lblProductMenuCategory As Label
    Friend WithEvents txtProductEntryDescription As TextBox
    Friend WithEvents lblProductEntryDescription As Label
    Friend WithEvents lblProductEntry As Label
    Friend WithEvents pnlProductEntry As Panel
End Class
