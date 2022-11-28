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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picBoxDashboardMonthlySales = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardMonthlyExpenses = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardMonthlyCustomers = New System.Windows.Forms.PictureBox()
        Me.lblDashboardMonthlySales = New System.Windows.Forms.Label()
        Me.picBoxDashboardSalesIcon = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardExpensesIcon = New System.Windows.Forms.PictureBox()
        Me.picBoxDashboardCustomersIcon = New System.Windows.Forms.PictureBox()
        Me.lblDashboardMonthlyExpenses = New System.Windows.Forms.Label()
        Me.lblDashboardMonthlyCstomers = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblDashboardBestSelling = New System.Windows.Forms.Label()
        Me.dataGridViewDashboardBestSellers = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.picBoxDashboardMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardMonthlyExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardMonthlyCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardSalesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardExpensesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDashboardCustomersIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewDashboardBestSellers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblDashboardMonthlySales
        '
        Me.lblDashboardMonthlySales.AutoSize = True
        Me.lblDashboardMonthlySales.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblDashboardMonthlySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardMonthlySales.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardMonthlySales.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboardMonthlySales.Location = New System.Drawing.Point(176, 170)
        Me.lblDashboardMonthlySales.Name = "lblDashboardMonthlySales"
        Me.lblDashboardMonthlySales.Size = New System.Drawing.Size(133, 25)
        Me.lblDashboardMonthlySales.TabIndex = 3
        Me.lblDashboardMonthlySales.Text = "Monthly Sales"
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
        'lblDashboardMonthlyExpenses
        '
        Me.lblDashboardMonthlyExpenses.AutoSize = True
        Me.lblDashboardMonthlyExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.lblDashboardMonthlyExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardMonthlyExpenses.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardMonthlyExpenses.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboardMonthlyExpenses.Location = New System.Drawing.Point(490, 170)
        Me.lblDashboardMonthlyExpenses.Name = "lblDashboardMonthlyExpenses"
        Me.lblDashboardMonthlyExpenses.Size = New System.Drawing.Size(168, 25)
        Me.lblDashboardMonthlyExpenses.TabIndex = 7
        Me.lblDashboardMonthlyExpenses.Text = "Monthly Expenses"
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
        Me.lblDashboardBestSelling.Location = New System.Drawing.Point(-2, 296)
        Me.lblDashboardBestSelling.Name = "lblDashboardBestSelling"
        Me.lblDashboardBestSelling.Size = New System.Drawing.Size(266, 37)
        Me.lblDashboardBestSelling.TabIndex = 10
        Me.lblDashboardBestSelling.Text = "     Top 5 Best Selling"
        '
        'dataGridViewDashboardBestSellers
        '
        Me.dataGridViewDashboardBestSellers.AllowUserToAddRows = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGridViewDashboardBestSellers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridViewDashboardBestSellers.BackgroundColor = System.Drawing.Color.White
        Me.dataGridViewDashboardBestSellers.ColumnHeadersHeight = 30
        Me.dataGridViewDashboardBestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewDashboardBestSellers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewDashboardBestSellers.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataGridViewDashboardBestSellers.EnableHeadersVisualStyles = False
        Me.dataGridViewDashboardBestSellers.Location = New System.Drawing.Point(90, 385)
        Me.dataGridViewDashboardBestSellers.Name = "dataGridViewDashboardBestSellers"
        Me.dataGridViewDashboardBestSellers.RowTemplate.Height = 25
        Me.dataGridViewDashboardBestSellers.Size = New System.Drawing.Size(674, 269)
        Me.dataGridViewDashboardBestSellers.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 5
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 58
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "Orders"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.dataGridViewDashboardBestSellers)
        Me.Controls.Add(Me.lblDashboardBestSelling)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.lblDashboardMonthlyCstomers)
        Me.Controls.Add(Me.lblDashboardMonthlyExpenses)
        Me.Controls.Add(Me.picBoxDashboardCustomersIcon)
        Me.Controls.Add(Me.picBoxDashboardExpensesIcon)
        Me.Controls.Add(Me.picBoxDashboardSalesIcon)
        Me.Controls.Add(Me.lblDashboardMonthlySales)
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
        CType(Me.dataGridViewDashboardBestSellers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxDashboardMonthlySales As PictureBox
    Friend WithEvents picBoxDashboardMonthlyExpenses As PictureBox
    Friend WithEvents picBoxDashboardMonthlyCustomers As PictureBox
    Friend WithEvents lblDashboardMonthlySales As Label
    Friend WithEvents picBoxDashboardSalesIcon As PictureBox
    Friend WithEvents picBoxDashboardExpensesIcon As PictureBox
    Friend WithEvents picBoxDashboardCustomersIcon As PictureBox
    Friend WithEvents lblDashboardMonthlyExpenses As Label
    Friend WithEvents lblDashboardMonthlyCstomers As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblDashboardBestSelling As Label
    Friend WithEvents dataGridViewDashboardBestSellers As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
