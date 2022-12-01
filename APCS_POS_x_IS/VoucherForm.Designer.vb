<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoucherForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoucherForm))
        Me.pnlVoucherDiscount = New System.Windows.Forms.Panel()
        Me.btnVoucherCancel = New System.Windows.Forms.Button()
        Me.btnVoucherUpdate = New System.Windows.Forms.Button()
        Me.btnVoucherSave = New System.Windows.Forms.Button()
        Me.txtVouchersPercent = New System.Windows.Forms.TextBox()
        Me.lblVouchersPercent = New System.Windows.Forms.Label()
        Me.dataGridViewVoucher = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVoucher = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtVouchersDescription = New System.Windows.Forms.TextBox()
        Me.lblVouchersDescription = New System.Windows.Forms.Label()
        Me.pnlVoucherDiscount.SuspendLayout()
        CType(Me.dataGridViewVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlVoucherDiscount
        '
        Me.pnlVoucherDiscount.Controls.Add(Me.btnVoucherCancel)
        Me.pnlVoucherDiscount.Controls.Add(Me.btnVoucherUpdate)
        Me.pnlVoucherDiscount.Controls.Add(Me.btnVoucherSave)
        Me.pnlVoucherDiscount.Controls.Add(Me.txtVouchersPercent)
        Me.pnlVoucherDiscount.Controls.Add(Me.lblVouchersPercent)
        Me.pnlVoucherDiscount.Controls.Add(Me.dataGridViewVoucher)
        Me.pnlVoucherDiscount.Controls.Add(Me.lblVoucher)
        Me.pnlVoucherDiscount.Controls.Add(Me.PictureBox1)
        Me.pnlVoucherDiscount.Controls.Add(Me.txtVouchersDescription)
        Me.pnlVoucherDiscount.Controls.Add(Me.lblVouchersDescription)
        Me.pnlVoucherDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVoucherDiscount.Location = New System.Drawing.Point(0, 0)
        Me.pnlVoucherDiscount.Name = "pnlVoucherDiscount"
        Me.pnlVoucherDiscount.Size = New System.Drawing.Size(1077, 786)
        Me.pnlVoucherDiscount.TabIndex = 35
        '
        'btnVoucherCancel
        '
        Me.btnVoucherCancel.BackColor = System.Drawing.Color.Gray
        Me.btnVoucherCancel.FlatAppearance.BorderSize = 0
        Me.btnVoucherCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucherCancel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVoucherCancel.ForeColor = System.Drawing.Color.Black
        Me.btnVoucherCancel.Location = New System.Drawing.Point(344, 148)
        Me.btnVoucherCancel.Name = "btnVoucherCancel"
        Me.btnVoucherCancel.Size = New System.Drawing.Size(91, 29)
        Me.btnVoucherCancel.TabIndex = 44
        Me.btnVoucherCancel.Text = "CANCEL"
        Me.btnVoucherCancel.UseVisualStyleBackColor = False
        '
        'btnVoucherUpdate
        '
        Me.btnVoucherUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnVoucherUpdate.FlatAppearance.BorderSize = 0
        Me.btnVoucherUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucherUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVoucherUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVoucherUpdate.Location = New System.Drawing.Point(247, 148)
        Me.btnVoucherUpdate.Name = "btnVoucherUpdate"
        Me.btnVoucherUpdate.Size = New System.Drawing.Size(91, 29)
        Me.btnVoucherUpdate.TabIndex = 43
        Me.btnVoucherUpdate.Text = "UPDATE"
        Me.btnVoucherUpdate.UseVisualStyleBackColor = False
        '
        'btnVoucherSave
        '
        Me.btnVoucherSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnVoucherSave.FlatAppearance.BorderSize = 0
        Me.btnVoucherSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucherSave.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVoucherSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVoucherSave.Location = New System.Drawing.Point(150, 148)
        Me.btnVoucherSave.Name = "btnVoucherSave"
        Me.btnVoucherSave.Size = New System.Drawing.Size(91, 29)
        Me.btnVoucherSave.TabIndex = 42
        Me.btnVoucherSave.Text = "SAVE"
        Me.btnVoucherSave.UseVisualStyleBackColor = False
        '
        'txtVouchersPercent
        '
        Me.txtVouchersPercent.BackColor = System.Drawing.SystemColors.Control
        Me.txtVouchersPercent.Location = New System.Drawing.Point(150, 119)
        Me.txtVouchersPercent.Name = "txtVouchersPercent"
        Me.txtVouchersPercent.Size = New System.Drawing.Size(499, 23)
        Me.txtVouchersPercent.TabIndex = 41
        '
        'lblVouchersPercent
        '
        Me.lblVouchersPercent.AutoSize = True
        Me.lblVouchersPercent.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVouchersPercent.Location = New System.Drawing.Point(52, 127)
        Me.lblVouchersPercent.Name = "lblVouchersPercent"
        Me.lblVouchersPercent.Size = New System.Drawing.Size(56, 15)
        Me.lblVouchersPercent.TabIndex = 40
        Me.lblVouchersPercent.Text = "PERCENT"
        '
        'dataGridViewVoucher
        '
        Me.dataGridViewVoucher.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.dataGridViewVoucher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewVoucher.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewVoucher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewVoucher.ColumnHeadersHeight = 30
        Me.dataGridViewVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewVoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewVoucher.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewVoucher.EnableHeadersVisualStyles = False
        Me.dataGridViewVoucher.Location = New System.Drawing.Point(52, 204)
        Me.dataGridViewVoucher.Name = "dataGridViewVoucher"
        Me.dataGridViewVoucher.RowHeadersVisible = False
        Me.dataGridViewVoucher.RowTemplate.Height = 25
        Me.dataGridViewVoucher.Size = New System.Drawing.Size(967, 556)
        Me.dataGridViewVoucher.TabIndex = 37
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "PERCENT"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 81
        '
        'lblVoucher
        '
        Me.lblVoucher.AutoSize = True
        Me.lblVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblVoucher.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVoucher.ForeColor = System.Drawing.Color.White
        Me.lblVoucher.Location = New System.Drawing.Point(0, 9)
        Me.lblVoucher.Name = "lblVoucher"
        Me.lblVoucher.Size = New System.Drawing.Size(151, 37)
        Me.lblVoucher.TabIndex = 36
        Me.lblVoucher.Text = "DISCOUNT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1028, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'txtVouchersDescription
        '
        Me.txtVouchersDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtVouchersDescription.Location = New System.Drawing.Point(150, 79)
        Me.txtVouchersDescription.Name = "txtVouchersDescription"
        Me.txtVouchersDescription.Size = New System.Drawing.Size(499, 23)
        Me.txtVouchersDescription.TabIndex = 39
        '
        'lblVouchersDescription
        '
        Me.lblVouchersDescription.AutoSize = True
        Me.lblVouchersDescription.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVouchersDescription.Location = New System.Drawing.Point(52, 82)
        Me.lblVouchersDescription.Name = "lblVouchersDescription"
        Me.lblVouchersDescription.Size = New System.Drawing.Size(83, 15)
        Me.lblVouchersDescription.TabIndex = 38
        Me.lblVouchersDescription.Text = "DESCRIPTION"
        '
        'VoucherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlVoucherDiscount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VoucherForm"
        Me.pnlVoucherDiscount.ResumeLayout(False)
        Me.pnlVoucherDiscount.PerformLayout()
        CType(Me.dataGridViewVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlVoucherDiscount As Panel
    Friend WithEvents btnVoucherCancel As Button
    Friend WithEvents btnVoucherUpdate As Button
    Friend WithEvents btnVoucherSave As Button
    Friend WithEvents txtVouchersPercent As TextBox
    Friend WithEvents lblVouchersPercent As Label
    Friend WithEvents dataGridViewVoucher As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lblVoucher As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtVouchersDescription As TextBox
    Friend WithEvents lblVouchersDescription As Label
End Class
