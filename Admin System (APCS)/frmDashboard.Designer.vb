<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picBoxDashboardMonthlySales = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardMonthlyExpenses = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardMonthlyCustomers = New System.Windows.Forms.PictureBox()
        Me.lblDashboardSales = New System.Windows.Forms.Label()
        Me.picBoxDashboardSalesIcon = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardExpensesIcon = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardCustomersIcon = New System.Windows.Forms.PictureBox()
        Me.lblDashboardTotalProducts = New System.Windows.Forms.Label()
        Me.lblDashboardMonthlyCstomers = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblDashboardBestSelling = New System.Windows.Forms.Label()
        Me.dateDashboardTo = New System.Windows.Forms.DateTimePicker()
        Me.lblDashboardDateRange = New System.Windows.Forms.Label()
        Me.dateDashboardFrom = New System.Windows.Forms.DateTimePicker()
        Me.dataGridViewBestSelling = New System.Windows.Forms.DataGridView()
        Me.colSalesRecordsBlank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.picBoxDashboardMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardMonthlyExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardMonthlyCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardSalesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardExpensesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardCustomersIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewBestSelling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxDashboardMonthlySales
        '
        Me.picBoxDashboardMonthlySales.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.picBoxDashboardMonthlySales.Location = New System.Drawing.Point(58, 102)
        Me.picBoxDashboardMonthlySales.Name = "picBoxDashboardMonthlySales"
        Me.picBoxDashboardMonthlySales.Size = New System.Drawing.Size(272, 127)
        Me.picBoxDashboardMonthlySales.TabIndex = 0
        Me.picBoxDashboardMonthlySales.TabStop = False
        '
        'picBoxDashboardMonthlyExpenses
        '
        Me.picBoxDashboardMonthlyExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.picBoxDashboardMonthlyExpenses.Location = New System.Drawing.Point(379, 102)
        Me.picBoxDashboardMonthlyExpenses.Name = "picBoxDashboardMonthlyExpenses"
        Me.picBoxDashboardMonthlyExpenses.Size = New System.Drawing.Size(284, 127)
        Me.picBoxDashboardMonthlyExpenses.TabIndex = 1
        Me.picBoxDashboardMonthlyExpenses.TabStop = False
        '
        'picBoxDashboardMonthlyCustomers
        '
        Me.picBoxDashboardMonthlyCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.picBoxDashboardMonthlyCustomers.Location = New System.Drawing.Point(714, 102)
        Me.picBoxDashboardMonthlyCustomers.Name = "picBoxDashboardMonthlyCustomers"
        Me.picBoxDashboardMonthlyCustomers.Size = New System.Drawing.Size(292, 127)
        Me.picBoxDashboardMonthlyCustomers.TabIndex = 2
        Me.picBoxDashboardMonthlyCustomers.TabStop = False
        '
        'lblDashboardSales
        '
        Me.lblDashboardSales.AutoSize = True
        Me.lblDashboardSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblDashboardSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardSales.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardSales.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboardSales.Location = New System.Drawing.Point(176, 170)
        Me.lblDashboardSales.Name = "lblDashboardSales"
        Me.lblDashboardSales.Size = New System.Drawing.Size(101, 25)
        Me.lblDashboardSales.TabIndex = 3
        Me.lblDashboardSales.Text = "Total Sales"
        '
        'picBoxDashboardSalesIcon
        '
        Me.picBoxDashboardSalesIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.picBoxDashboardSalesIcon.Image = CType(resources.GetObject("picBoxDashboardSalesIcon.Image"), System.Drawing.Image)
        Me.picBoxDashboardSalesIcon.Location = New System.Drawing.Point(73, 142)
        Me.picBoxDashboardSalesIcon.Name = "picBoxDashboardSalesIcon"
        Me.picBoxDashboardSalesIcon.Size = New System.Drawing.Size(84, 75)
        Me.picBoxDashboardSalesIcon.TabIndex = 4
        Me.picBoxDashboardSalesIcon.TabStop = False
        '
        'picBoxDashboardExpensesIcon
        '
        Me.picBoxDashboardExpensesIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.picBoxDashboardExpensesIcon.Image = CType(resources.GetObject("picBoxDashboardExpensesIcon.Image"), System.Drawing.Image)
        Me.picBoxDashboardExpensesIcon.Location = New System.Drawing.Point(400, 142)
        Me.picBoxDashboardExpensesIcon.Name = "picBoxDashboardExpensesIcon"
        Me.picBoxDashboardExpensesIcon.Size = New System.Drawing.Size(84, 75)
        Me.picBoxDashboardExpensesIcon.TabIndex = 5
        Me.picBoxDashboardExpensesIcon.TabStop = False
        '
        'picBoxDashboardCustomersIcon
        '
        Me.picBoxDashboardCustomersIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.picBoxDashboardCustomersIcon.Image = CType(resources.GetObject("picBoxDashboardCustomersIcon.Image"), System.Drawing.Image)
        Me.picBoxDashboardCustomersIcon.Location = New System.Drawing.Point(735, 142)
        Me.picBoxDashboardCustomersIcon.Name = "picBoxDashboardCustomersIcon"
        Me.picBoxDashboardCustomersIcon.Size = New System.Drawing.Size(84, 75)
        Me.picBoxDashboardCustomersIcon.TabIndex = 6
        Me.picBoxDashboardCustomersIcon.TabStop = False
        '
        'lblDashboardTotalProducts
        '
        Me.lblDashboardTotalProducts.AutoSize = True
        Me.lblDashboardTotalProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.lblDashboardTotalProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardTotalProducts.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardTotalProducts.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboardTotalProducts.Location = New System.Drawing.Point(490, 170)
        Me.lblDashboardTotalProducts.Name = "lblDashboardTotalProducts"
        Me.lblDashboardTotalProducts.Size = New System.Drawing.Size(125, 25)
        Me.lblDashboardTotalProducts.TabIndex = 7
        Me.lblDashboardTotalProducts.Text = "Total Product"
        '
        'lblDashboardMonthlyCstomers
        '
        Me.lblDashboardMonthlyCstomers.AutoSize = True
        Me.lblDashboardMonthlyCstomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDashboardMonthlyCstomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardMonthlyCstomers.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardMonthlyCstomers.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboardMonthlyCstomers.Location = New System.Drawing.Point(825, 170)
        Me.lblDashboardMonthlyCstomers.Name = "lblDashboardMonthlyCstomers"
        Me.lblDashboardMonthlyCstomers.Size = New System.Drawing.Size(181, 25)
        Me.lblDashboardMonthlyCstomers.TabIndex = 8
        Me.lblDashboardMonthlyCstomers.Text = "Monthly Customers"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboard.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboard.ForeColor = System.Drawing.Color.White
        Me.lblDashboard.Location = New System.Drawing.Point(-2, 19)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(150, 37)
        Me.lblDashboard.TabIndex = 9
        Me.lblDashboard.Text = "Dashboard"
        '
        'lblDashboardBestSelling
        '
        Me.lblDashboardBestSelling.AutoSize = True
        Me.lblDashboardBestSelling.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblDashboardBestSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardBestSelling.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardBestSelling.ForeColor = System.Drawing.Color.White
        Me.lblDashboardBestSelling.Image = CType(resources.GetObject("lblDashboardBestSelling.Image"), System.Drawing.Image)
        Me.lblDashboardBestSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDashboardBestSelling.Location = New System.Drawing.Point(-2, 274)
        Me.lblDashboardBestSelling.Name = "lblDashboardBestSelling"
        Me.lblDashboardBestSelling.Size = New System.Drawing.Size(266, 37)
        Me.lblDashboardBestSelling.TabIndex = 10
        Me.lblDashboardBestSelling.Text = "     Top 5 Best Selling"
        '
        'dateDashboardTo
        '
        Me.dateDashboardTo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateDashboardTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDashboardTo.Location = New System.Drawing.Point(134, 370)
        Me.dateDashboardTo.Name = "dateDashboardTo"
        Me.dateDashboardTo.Size = New System.Drawing.Size(120, 23)
        Me.dateDashboardTo.TabIndex = 22
        '
        'lblDashboardDateRange
        '
        Me.lblDashboardDateRange.AutoSize = True
        Me.lblDashboardDateRange.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardDateRange.Location = New System.Drawing.Point(10, 352)
        Me.lblDashboardDateRange.Name = "lblDashboardDateRange"
        Me.lblDashboardDateRange.Size = New System.Drawing.Size(123, 15)
        Me.lblDashboardDateRange.TabIndex = 21
        Me.lblDashboardDateRange.Text = "Filter Date [From - To]"
        '
        'dateDashboardFrom
        '
        Me.dateDashboardFrom.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateDashboardFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDashboardFrom.Location = New System.Drawing.Point(10, 370)
        Me.dateDashboardFrom.Name = "dateDashboardFrom"
        Me.dateDashboardFrom.Size = New System.Drawing.Size(120, 23)
        Me.dateDashboardFrom.TabIndex = 20
        '
        'dataGridViewBestSelling
        '
        Me.dataGridViewBestSelling.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.dataGridViewBestSelling.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewBestSelling.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewBestSelling.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewBestSelling.ColumnHeadersHeight = 30
        Me.dataGridViewBestSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewBestSelling.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSalesRecordsBlank, Me.colSalesRecordsDescription, Me.colSalesRecordsPrice, Me.colSalesRecordsQty, Me.colSalesRecordsTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewBestSelling.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewBestSelling.EnableHeadersVisualStyles = False
        Me.dataGridViewBestSelling.Location = New System.Drawing.Point(10, 399)
        Me.dataGridViewBestSelling.Name = "dataGridViewBestSelling"
        Me.dataGridViewBestSelling.RowHeadersVisible = False
        Me.dataGridViewBestSelling.RowTemplate.Height = 25
        Me.dataGridViewBestSelling.Size = New System.Drawing.Size(1057, 377)
        Me.dataGridViewBestSelling.TabIndex = 19
        '
        'colSalesRecordsBlank
        '
        Me.colSalesRecordsBlank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsBlank.HeaderText = "#"
        Me.colSalesRecordsBlank.Name = "colSalesRecordsBlank"
        Me.colSalesRecordsBlank.Width = 39
        '
        'colSalesRecordsDescription
        '
        Me.colSalesRecordsDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesRecordsDescription.HeaderText = "Description"
        Me.colSalesRecordsDescription.Name = "colSalesRecordsDescription"
        '
        'colSalesRecordsPrice
        '
        Me.colSalesRecordsPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSalesRecordsPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSalesRecordsPrice.HeaderText = "Price"
        Me.colSalesRecordsPrice.Name = "colSalesRecordsPrice"
        Me.colSalesRecordsPrice.Width = 58
        '
        'colSalesRecordsQty
        '
        Me.colSalesRecordsQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSalesRecordsQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.colSalesRecordsQty.HeaderText = "Qty (per person/pax)"
        Me.colSalesRecordsQty.Name = "colSalesRecordsQty"
        Me.colSalesRecordsQty.Width = 142
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
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.dateDashboardTo)
        Me.Controls.Add(Me.lblDashboardDateRange)
        Me.Controls.Add(Me.dateDashboardFrom)
        Me.Controls.Add(Me.dataGridViewBestSelling)
        Me.Controls.Add(Me.lblDashboardBestSelling)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.lblDashboardMonthlyCstomers)
        Me.Controls.Add(Me.lblDashboardTotalProducts)
        Me.Controls.Add(Me.picBoxDashboardCustomersIcon)
        Me.Controls.Add(Me.picBoxDashboardExpensesIcon)
        Me.Controls.Add(Me.picBoxDashboardSalesIcon)
        Me.Controls.Add(Me.lblDashboardSales)
        Me.Controls.Add(Me.picBoxDashboardMonthlyCustomers)
        Me.Controls.Add(Me.picBoxDashboardMonthlyExpenses)
        Me.Controls.Add(Me.picBoxDashboardMonthlySales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        CType(Me.picBoxDashboardMonthlySales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDashboardMonthlyExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDashboardMonthlyCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDashboardSalesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDashboardExpensesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDashboardCustomersIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewBestSelling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxDashboardMonthlySales As PictureBox
    Friend WithEvents picBoxDashboardMonthlyExpenses As PictureBox
    Friend WithEvents picBoxDashboardMonthlyCustomers As PictureBox
    Friend WithEvents lblDashboardSales As Label
    Friend WithEvents picBoxDashboardSalesIcon As PictureBox
    Friend WithEvents picBoxDashboardExpensesIcon As PictureBox
    Friend WithEvents picBoxDashboardCustomersIcon As PictureBox
    Friend WithEvents lblDashboardTotalProducts As Label
    Friend WithEvents lblDashboardMonthlyCstomers As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblDashboardBestSelling As Label
    Friend WithEvents dateDashboardTo As DateTimePicker
    Friend WithEvents lblDashboardDateRange As Label
    Friend WithEvents dateDashboardFrom As DateTimePicker
    Friend WithEvents dataGridViewBestSelling As DataGridView
    Friend WithEvents colSalesRecordsBlank As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsDescription As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsQty As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsTotal As DataGridViewTextBoxColumn
End Class
