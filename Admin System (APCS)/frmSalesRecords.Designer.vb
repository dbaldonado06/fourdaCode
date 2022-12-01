<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesRecords))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSalesRecords = New System.Windows.Forms.Panel()
        Me.picBoxPreview = New System.Windows.Forms.PictureBox()
        Me.dateSalesTo = New System.Windows.Forms.DateTimePicker()
        Me.lblDateRange = New System.Windows.Forms.Label()
        Me.dateSalesFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dataGridViewProductMenuList = New System.Windows.Forms.DataGridView()
        Me.picBoxSalesRecordClose = New System.Windows.Forms.PictureBox()
        Me.lblSaleRecords = New System.Windows.Forms.Label()
        Me.colSalesRecordsBlank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsTransNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsSubT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsVat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsOrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSalesRecords.SuspendLayout()
        CType(Me.picBoxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewProductMenuList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxSalesRecordClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSalesRecords
        '
        Me.pnlSalesRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalesRecords.Controls.Add(Me.picBoxPreview)
        Me.pnlSalesRecords.Controls.Add(Me.dateSalesTo)
        Me.pnlSalesRecords.Controls.Add(Me.lblDateRange)
        Me.pnlSalesRecords.Controls.Add(Me.dateSalesFrom)
        Me.pnlSalesRecords.Controls.Add(Me.lblTotal)
        Me.pnlSalesRecords.Controls.Add(Me.dataGridViewProductMenuList)
        Me.pnlSalesRecords.Controls.Add(Me.picBoxSalesRecordClose)
        Me.pnlSalesRecords.Controls.Add(Me.lblSaleRecords)
        Me.pnlSalesRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSalesRecords.Location = New System.Drawing.Point(0, 0)
        Me.pnlSalesRecords.Name = "pnlSalesRecords"
        Me.pnlSalesRecords.Size = New System.Drawing.Size(1079, 788)
        Me.pnlSalesRecords.TabIndex = 0
        '
        'picBoxPreview
        '
        Me.picBoxPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBoxPreview.Image = CType(resources.GetObject("picBoxPreview.Image"), System.Drawing.Image)
        Me.picBoxPreview.Location = New System.Drawing.Point(1011, 11)
        Me.picBoxPreview.Name = "picBoxPreview"
        Me.picBoxPreview.Size = New System.Drawing.Size(24, 24)
        Me.picBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPreview.TabIndex = 11
        Me.picBoxPreview.TabStop = False
        '
        'dateSalesTo
        '
        Me.dateSalesTo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateSalesTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateSalesTo.Location = New System.Drawing.Point(127, 85)
        Me.dateSalesTo.Name = "dateSalesTo"
        Me.dateSalesTo.Size = New System.Drawing.Size(120, 23)
        Me.dateSalesTo.TabIndex = 10
        '
        'lblDateRange
        '
        Me.lblDateRange.AutoSize = True
        Me.lblDateRange.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDateRange.Location = New System.Drawing.Point(1, 63)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Size = New System.Drawing.Size(123, 15)
        Me.lblDateRange.TabIndex = 9
        Me.lblDateRange.Text = "Filter Date [From - To]"
        '
        'dateSalesFrom
        '
        Me.dateSalesFrom.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateSalesFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateSalesFrom.Location = New System.Drawing.Point(3, 85)
        Me.dateSalesFrom.Name = "dateSalesFrom"
        Me.dateSalesFrom.Size = New System.Drawing.Size(120, 23)
        Me.dateSalesFrom.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(-6, 751)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(1071, 33)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dataGridViewProductMenuList
        '
        Me.dataGridViewProductMenuList.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.dataGridViewProductMenuList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewProductMenuList.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewProductMenuList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewProductMenuList.ColumnHeadersHeight = 30
        Me.dataGridViewProductMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewProductMenuList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSalesRecordsBlank, Me.colSalesRecordsTransNumber, Me.colSalesRecordsSubT, Me.colSalesRecordsVat, Me.colSalesRecordsTotal, Me.colSalesRecordsOrderNo, Me.colSalesRecordsCashier, Me.Column1, Me.colSalesRecordsTime})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewProductMenuList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewProductMenuList.EnableHeadersVisualStyles = False
        Me.dataGridViewProductMenuList.Location = New System.Drawing.Point(3, 115)
        Me.dataGridViewProductMenuList.Name = "dataGridViewProductMenuList"
        Me.dataGridViewProductMenuList.RowHeadersVisible = False
        Me.dataGridViewProductMenuList.RowTemplate.Height = 25
        Me.dataGridViewProductMenuList.Size = New System.Drawing.Size(1062, 633)
        Me.dataGridViewProductMenuList.TabIndex = 6
        '
        'picBoxSalesRecordClose
        '
        Me.picBoxSalesRecordClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxSalesRecordClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBoxSalesRecordClose.Image = CType(resources.GetObject("picBoxSalesRecordClose.Image"), System.Drawing.Image)
        Me.picBoxSalesRecordClose.Location = New System.Drawing.Point(1041, 11)
        Me.picBoxSalesRecordClose.Name = "picBoxSalesRecordClose"
        Me.picBoxSalesRecordClose.Size = New System.Drawing.Size(24, 24)
        Me.picBoxSalesRecordClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxSalesRecordClose.TabIndex = 5
        Me.picBoxSalesRecordClose.TabStop = False
        '
        'lblSaleRecords
        '
        Me.lblSaleRecords.AutoSize = True
        Me.lblSaleRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblSaleRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaleRecords.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaleRecords.ForeColor = System.Drawing.Color.White
        Me.lblSaleRecords.Location = New System.Drawing.Point(-1, 5)
        Me.lblSaleRecords.Name = "lblSaleRecords"
        Me.lblSaleRecords.Size = New System.Drawing.Size(184, 37)
        Me.lblSaleRecords.TabIndex = 3
        Me.lblSaleRecords.Text = "Sales Records"
        '
        'colSalesRecordsBlank
        '
        Me.colSalesRecordsBlank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsBlank.HeaderText = "#"
        Me.colSalesRecordsBlank.Name = "colSalesRecordsBlank"
        Me.colSalesRecordsBlank.Width = 39
        '
        'colSalesRecordsTransNumber
        '
        Me.colSalesRecordsTransNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesRecordsTransNumber.HeaderText = "Transaction No"
        Me.colSalesRecordsTransNumber.Name = "colSalesRecordsTransNumber"
        '
        'colSalesRecordsSubT
        '
        Me.colSalesRecordsSubT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSalesRecordsSubT.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSalesRecordsSubT.HeaderText = "Sub-Total"
        Me.colSalesRecordsSubT.Name = "colSalesRecordsSubT"
        Me.colSalesRecordsSubT.Width = 83
        '
        'colSalesRecordsVat
        '
        Me.colSalesRecordsVat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSalesRecordsVat.DefaultCellStyle = DataGridViewCellStyle4
        Me.colSalesRecordsVat.HeaderText = "VAT"
        Me.colSalesRecordsVat.Name = "colSalesRecordsVat"
        Me.colSalesRecordsVat.Width = 54
        '
        'colSalesRecordsTotal
        '
        Me.colSalesRecordsTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSalesRecordsTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.colSalesRecordsTotal.HeaderText = "Total"
        Me.colSalesRecordsTotal.Name = "colSalesRecordsTotal"
        Me.colSalesRecordsTotal.Width = 58
        '
        'colSalesRecordsOrderNo
        '
        Me.colSalesRecordsOrderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsOrderNo.HeaderText = "Order No"
        Me.colSalesRecordsOrderNo.Name = "colSalesRecordsOrderNo"
        Me.colSalesRecordsOrderNo.Width = 81
        '
        'colSalesRecordsCashier
        '
        Me.colSalesRecordsCashier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsCashier.HeaderText = "Cashier"
        Me.colSalesRecordsCashier.Name = "colSalesRecordsCashier"
        Me.colSalesRecordsCashier.Width = 70
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 57
        '
        'colSalesRecordsTime
        '
        Me.colSalesRecordsTime.HeaderText = "Time"
        Me.colSalesRecordsTime.Name = "colSalesRecordsTime"
        '
        'frmSalesRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlSalesRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesRecords"
        Me.Text = "frmSalesRecords"
        Me.pnlSalesRecords.ResumeLayout(False)
        Me.pnlSalesRecords.PerformLayout()
        CType(Me.picBoxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewProductMenuList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxSalesRecordClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSalesRecords As Panel
    Friend WithEvents lblSaleRecords As Label
    Friend WithEvents picBoxSalesRecordClose As PictureBox
    Friend WithEvents dataGridViewProductMenuList As DataGridView
    Friend WithEvents dateSalesFrom As DateTimePicker
    Friend WithEvents lblTotal As Label
    Friend WithEvents dateSalesTo As DateTimePicker
    Friend WithEvents lblDateRange As Label
    Friend WithEvents picBoxPreview As PictureBox
    Friend WithEvents colSalesRecordsBlank As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsTransNumber As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsSubT As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsVat As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsTotal As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsOrderNo As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsCashier As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsTime As DataGridViewTextBoxColumn
End Class
