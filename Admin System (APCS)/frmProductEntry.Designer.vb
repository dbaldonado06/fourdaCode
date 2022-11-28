<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductEntry
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
        Me.lblProductEntry = New System.Windows.Forms.Label()
        Me.lblProductEntryClose = New System.Windows.Forms.Label()
        Me.lblProductEntryDescription = New System.Windows.Forms.Label()
        Me.txtProductEntryDescription = New System.Windows.Forms.TextBox()
        Me.lblProductMenuCategory = New System.Windows.Forms.Label()
        Me.comboProductEntryCategory = New System.Windows.Forms.ComboBox()
        Me.txtProductEntryPrice = New System.Windows.Forms.TextBox()
        Me.lblProductMenuPrice = New System.Windows.Forms.Label()
        Me.comboProductEntryStatus = New System.Windows.Forms.ComboBox()
        Me.lblProductMenuStatus = New System.Windows.Forms.Label()
        Me.picBoxProductEntry = New System.Windows.Forms.PictureBox()
        Me.btnProductEntrySave = New System.Windows.Forms.Button()
        Me.btnProductEntryUpdate = New System.Windows.Forms.Button()
        Me.btnProductEntryCancel = New System.Windows.Forms.Button()
        Me.btnProductEntryBrowseImage = New System.Windows.Forms.Button()
        Me.txtProductEntryID = New System.Windows.Forms.TextBox()
        Me.lblIDProductEntry = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pnlProductEntry = New System.Windows.Forms.Panel()
        CType(Me.picBoxProductEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductEntry
        '
        Me.lblProductEntry.AutoSize = True
        Me.lblProductEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntry.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProductEntry.Location = New System.Drawing.Point(0, 5)
        Me.lblProductEntry.Name = "lblProductEntry"
        Me.lblProductEntry.Size = New System.Drawing.Size(145, 30)
        Me.lblProductEntry.TabIndex = 0
        Me.lblProductEntry.Text = "Product Entry"
        '
        'lblProductEntryClose
        '
        Me.lblProductEntryClose.AutoSize = True
        Me.lblProductEntryClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProductEntryClose.Location = New System.Drawing.Point(909, 5)
        Me.lblProductEntryClose.Name = "lblProductEntryClose"
        Me.lblProductEntryClose.Size = New System.Drawing.Size(50, 15)
        Me.lblProductEntryClose.TabIndex = 1
        Me.lblProductEntryClose.Text = "[ Close ]"
        '
        'lblProductEntryDescription
        '
        Me.lblProductEntryDescription.AutoSize = True
        Me.lblProductEntryDescription.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntryDescription.Location = New System.Drawing.Point(49, 195)
        Me.lblProductEntryDescription.Name = "lblProductEntryDescription"
        Me.lblProductEntryDescription.Size = New System.Drawing.Size(68, 15)
        Me.lblProductEntryDescription.TabIndex = 2
        Me.lblProductEntryDescription.Text = "Description"
        '
        'txtProductEntryDescription
        '
        Me.txtProductEntryDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductEntryDescription.Location = New System.Drawing.Point(131, 193)
        Me.txtProductEntryDescription.Name = "txtProductEntryDescription"
        Me.txtProductEntryDescription.Size = New System.Drawing.Size(499, 23)
        Me.txtProductEntryDescription.TabIndex = 3
        '
        'lblProductMenuCategory
        '
        Me.lblProductMenuCategory.AutoSize = True
        Me.lblProductMenuCategory.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuCategory.Location = New System.Drawing.Point(49, 224)
        Me.lblProductMenuCategory.Name = "lblProductMenuCategory"
        Me.lblProductMenuCategory.Size = New System.Drawing.Size(54, 15)
        Me.lblProductMenuCategory.TabIndex = 4
        Me.lblProductMenuCategory.Text = "Category"
        '
        'comboProductEntryCategory
        '
        Me.comboProductEntryCategory.BackColor = System.Drawing.SystemColors.Control
        Me.comboProductEntryCategory.FormattingEnabled = True
        Me.comboProductEntryCategory.Location = New System.Drawing.Point(131, 220)
        Me.comboProductEntryCategory.Name = "comboProductEntryCategory"
        Me.comboProductEntryCategory.Size = New System.Drawing.Size(456, 23)
        Me.comboProductEntryCategory.TabIndex = 5
        '
        'txtProductEntryPrice
        '
        Me.txtProductEntryPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductEntryPrice.Location = New System.Drawing.Point(131, 247)
        Me.txtProductEntryPrice.Name = "txtProductEntryPrice"
        Me.txtProductEntryPrice.Size = New System.Drawing.Size(499, 23)
        Me.txtProductEntryPrice.TabIndex = 6
        '
        'lblProductMenuPrice
        '
        Me.lblProductMenuPrice.AutoSize = True
        Me.lblProductMenuPrice.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuPrice.Location = New System.Drawing.Point(50, 251)
        Me.lblProductMenuPrice.Name = "lblProductMenuPrice"
        Me.lblProductMenuPrice.Size = New System.Drawing.Size(33, 15)
        Me.lblProductMenuPrice.TabIndex = 7
        Me.lblProductMenuPrice.Text = "Price"
        '
        'comboProductEntryStatus
        '
        Me.comboProductEntryStatus.BackColor = System.Drawing.SystemColors.Control
        Me.comboProductEntryStatus.FormattingEnabled = True
        Me.comboProductEntryStatus.Location = New System.Drawing.Point(131, 273)
        Me.comboProductEntryStatus.Name = "comboProductEntryStatus"
        Me.comboProductEntryStatus.Size = New System.Drawing.Size(499, 23)
        Me.comboProductEntryStatus.TabIndex = 9
        '
        'lblProductMenuStatus
        '
        Me.lblProductMenuStatus.AutoSize = True
        Me.lblProductMenuStatus.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductMenuStatus.Location = New System.Drawing.Point(50, 278)
        Me.lblProductMenuStatus.Name = "lblProductMenuStatus"
        Me.lblProductMenuStatus.Size = New System.Drawing.Size(40, 15)
        Me.lblProductMenuStatus.TabIndex = 8
        Me.lblProductMenuStatus.Text = "Status"
        '
        'picBoxProductEntry
        '
        Me.picBoxProductEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBoxProductEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxProductEntry.Location = New System.Drawing.Point(666, 86)
        Me.picBoxProductEntry.Name = "picBoxProductEntry"
        Me.picBoxProductEntry.Size = New System.Drawing.Size(258, 233)
        Me.picBoxProductEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxProductEntry.TabIndex = 10
        Me.picBoxProductEntry.TabStop = False
        '
        'btnProductEntrySave
        '
        Me.btnProductEntrySave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnProductEntrySave.FlatAppearance.BorderSize = 0
        Me.btnProductEntrySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntrySave.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntrySave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductEntrySave.Location = New System.Drawing.Point(133, 327)
        Me.btnProductEntrySave.Name = "btnProductEntrySave"
        Me.btnProductEntrySave.Size = New System.Drawing.Size(91, 29)
        Me.btnProductEntrySave.TabIndex = 11
        Me.btnProductEntrySave.Text = "SAVE"
        Me.btnProductEntrySave.UseVisualStyleBackColor = False
        '
        'btnProductEntryUpdate
        '
        Me.btnProductEntryUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnProductEntryUpdate.FlatAppearance.BorderSize = 0
        Me.btnProductEntryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntryUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntryUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductEntryUpdate.Location = New System.Drawing.Point(230, 327)
        Me.btnProductEntryUpdate.Name = "btnProductEntryUpdate"
        Me.btnProductEntryUpdate.Size = New System.Drawing.Size(91, 29)
        Me.btnProductEntryUpdate.TabIndex = 12
        Me.btnProductEntryUpdate.Text = "UPDATE"
        Me.btnProductEntryUpdate.UseVisualStyleBackColor = False
        '
        'btnProductEntryCancel
        '
        Me.btnProductEntryCancel.BackColor = System.Drawing.Color.Gray
        Me.btnProductEntryCancel.FlatAppearance.BorderSize = 0
        Me.btnProductEntryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntryCancel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntryCancel.ForeColor = System.Drawing.Color.Black
        Me.btnProductEntryCancel.Location = New System.Drawing.Point(327, 327)
        Me.btnProductEntryCancel.Name = "btnProductEntryCancel"
        Me.btnProductEntryCancel.Size = New System.Drawing.Size(91, 29)
        Me.btnProductEntryCancel.TabIndex = 13
        Me.btnProductEntryCancel.Text = "CANCEL"
        Me.btnProductEntryCancel.UseVisualStyleBackColor = False
        '
        'btnProductEntryBrowseImage
        '
        Me.btnProductEntryBrowseImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnProductEntryBrowseImage.FlatAppearance.BorderSize = 0
        Me.btnProductEntryBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductEntryBrowseImage.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProductEntryBrowseImage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductEntryBrowseImage.Location = New System.Drawing.Point(666, 324)
        Me.btnProductEntryBrowseImage.Name = "btnProductEntryBrowseImage"
        Me.btnProductEntryBrowseImage.Size = New System.Drawing.Size(258, 32)
        Me.btnProductEntryBrowseImage.TabIndex = 14
        Me.btnProductEntryBrowseImage.Text = "Browse Image"
        Me.btnProductEntryBrowseImage.UseVisualStyleBackColor = False
        '
        'txtProductEntryID
        '
        Me.txtProductEntryID.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductEntryID.Enabled = False
        Me.txtProductEntryID.Location = New System.Drawing.Point(132, 165)
        Me.txtProductEntryID.Name = "txtProductEntryID"
        Me.txtProductEntryID.Size = New System.Drawing.Size(499, 23)
        Me.txtProductEntryID.TabIndex = 16
        Me.txtProductEntryID.Text = "(Auto)"
        '
        'lblIDProductEntry
        '
        Me.lblIDProductEntry.AutoSize = True
        Me.lblIDProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIDProductEntry.Location = New System.Drawing.Point(49, 166)
        Me.lblIDProductEntry.Name = "lblIDProductEntry"
        Me.lblIDProductEntry.Size = New System.Drawing.Size(20, 15)
        Me.lblIDProductEntry.TabIndex = 15
        Me.lblIDProductEntry.Text = "ID"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(591, 218)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 25)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'pnlProductEntry
        '
        Me.pnlProductEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProductEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProductEntry.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlProductEntry.Location = New System.Drawing.Point(0, 0)
        Me.pnlProductEntry.Name = "pnlProductEntry"
        Me.pnlProductEntry.Size = New System.Drawing.Size(969, 451)
        Me.pnlProductEntry.TabIndex = 18
        '
        'frmProductEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(969, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtProductEntryID)
        Me.Controls.Add(Me.lblIDProductEntry)
        Me.Controls.Add(Me.btnProductEntryBrowseImage)
        Me.Controls.Add(Me.btnProductEntryCancel)
        Me.Controls.Add(Me.btnProductEntryUpdate)
        Me.Controls.Add(Me.btnProductEntrySave)
        Me.Controls.Add(Me.picBoxProductEntry)
        Me.Controls.Add(Me.comboProductEntryStatus)
        Me.Controls.Add(Me.lblProductMenuStatus)
        Me.Controls.Add(Me.lblProductMenuPrice)
        Me.Controls.Add(Me.txtProductEntryPrice)
        Me.Controls.Add(Me.comboProductEntryCategory)
        Me.Controls.Add(Me.lblProductMenuCategory)
        Me.Controls.Add(Me.txtProductEntryDescription)
        Me.Controls.Add(Me.lblProductEntryDescription)
        Me.Controls.Add(Me.lblProductEntryClose)
        Me.Controls.Add(Me.lblProductEntry)
        Me.Controls.Add(Me.pnlProductEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProductEntry"
        CType(Me.picBoxProductEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProductEntry As Label
    Friend WithEvents lblProductEntryClose As Label
    Friend WithEvents lblProductEntryDescription As Label
    Friend WithEvents txtProductEntryDescription As TextBox
    Friend WithEvents lblProductMenuCategory As Label
    Friend WithEvents comboProductEntryCategory As ComboBox
    Friend WithEvents txtProductEntryPrice As TextBox
    Friend WithEvents lblProductMenuPrice As Label
    Friend WithEvents comboProductEntryStatus As ComboBox
    Friend WithEvents lblProductMenuStatus As Label
    Friend WithEvents picBoxProductEntry As PictureBox
    Friend WithEvents btnProductEntrySave As Button
    Friend WithEvents btnProductEntryUpdate As Button
    Friend WithEvents btnProductEntryCancel As Button
    Friend WithEvents btnProductEntryBrowseImage As Button
    Friend WithEvents txtProductEntryID As TextBox
    Friend WithEvents lblIDProductEntry As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents pnlProductEntry As Panel
End Class
