<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Me.lblProductEntryClose = New System.Windows.Forms.Label()
        Me.lblCategoryEntry = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.btnPOSAddVoucher = New System.Windows.Forms.Button()
        Me.pnlCategoryEntry = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblProductEntryClose
        '
        Me.lblProductEntryClose.AutoSize = True
        Me.lblProductEntryClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProductEntryClose.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntryClose.Location = New System.Drawing.Point(723, 6)
        Me.lblProductEntryClose.Name = "lblProductEntryClose"
        Me.lblProductEntryClose.Size = New System.Drawing.Size(56, 17)
        Me.lblProductEntryClose.TabIndex = 2
        Me.lblProductEntryClose.Text = "[ Close ]"
        '
        'lblCategoryEntry
        '
        Me.lblCategoryEntry.AutoSize = True
        Me.lblCategoryEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblCategoryEntry.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCategoryEntry.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCategoryEntry.Location = New System.Drawing.Point(0, 6)
        Me.lblCategoryEntry.Name = "lblCategoryEntry"
        Me.lblCategoryEntry.Size = New System.Drawing.Size(157, 30)
        Me.lblCategoryEntry.TabIndex = 3
        Me.lblCategoryEntry.Text = "Category Entry"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.SystemColors.Control
        Me.txtCategory.Location = New System.Drawing.Point(99, 92)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(593, 23)
        Me.txtCategory.TabIndex = 5
        '
        'btnPOSAddVoucher
        '
        Me.btnPOSAddVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSAddVoucher.FlatAppearance.BorderSize = 0
        Me.btnPOSAddVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSAddVoucher.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSAddVoucher.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPOSAddVoucher.Location = New System.Drawing.Point(99, 138)
        Me.btnPOSAddVoucher.Name = "btnPOSAddVoucher"
        Me.btnPOSAddVoucher.Size = New System.Drawing.Size(91, 29)
        Me.btnPOSAddVoucher.TabIndex = 12
        Me.btnPOSAddVoucher.Text = "SAVE"
        Me.btnPOSAddVoucher.UseVisualStyleBackColor = False
        '
        'pnlCategoryEntry
        '
        Me.pnlCategoryEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCategoryEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCategoryEntry.Location = New System.Drawing.Point(0, 0)
        Me.pnlCategoryEntry.Name = "pnlCategoryEntry"
        Me.pnlCategoryEntry.Size = New System.Drawing.Size(789, 215)
        Me.pnlCategoryEntry.TabIndex = 13
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 215)
        Me.Controls.Add(Me.btnPOSAddVoucher)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.lblCategoryEntry)
        Me.Controls.Add(Me.lblProductEntryClose)
        Me.Controls.Add(Me.pnlCategoryEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategory"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCategory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProductEntryClose As Label
    Friend WithEvents lblCategoryEntry As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents btnPOSAddVoucher As Button
    Friend WithEvents pnlCategoryEntry As Panel
End Class
