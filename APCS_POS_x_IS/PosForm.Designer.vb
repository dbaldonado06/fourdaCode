<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PosForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.posPanel = New System.Windows.Forms.Panel()
        Me.btnPOSEnd = New System.Windows.Forms.Button()
        Me.btnPOSStart = New System.Windows.Forms.Button()
        Me.pnlPOSCategories = New System.Windows.Forms.FlowLayoutPanel()
        Me.dataGridViewPOS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPOSDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlPOSMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTransactionNumber = New System.Windows.Forms.Label()
        Me.lblPOSOrderNo = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblPOSTransactionNo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlBottomDashboardPOS = New System.Windows.Forms.Panel()
        Me.btnBlank = New System.Windows.Forms.Button()
        Me.btnPOSManageOrders = New System.Windows.Forms.Button()
        Me.btnPOSSalesReport = New System.Windows.Forms.Button()
        Me.btnPOSManageProductMenu = New System.Windows.Forms.Button()
        Me.btnPOSCancelOrder = New System.Windows.Forms.Button()
        Me.btnPOSAddVoucher = New System.Windows.Forms.Button()
        Me.btnPOSSettlePayment = New System.Windows.Forms.Button()
        Me.btnPOSNewTransaction = New System.Windows.Forms.Button()
        Me.pnlTopPOS = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBoxPOSAthena = New System.Windows.Forms.PictureBox()
        Me.lblPOSAthenaPerbs = New System.Windows.Forms.Label()
        Me.lblPOSSoftware = New System.Windows.Forms.Label()
        Me.posPanel.SuspendLayout()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottomDashboardPOS.SuspendLayout()
        Me.pnlTopPOS.SuspendLayout()
        CType(Me.picBoxPOSAthena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'posPanel
        '
        Me.posPanel.BackColor = System.Drawing.Color.White
        Me.posPanel.Controls.Add(Me.btnPOSEnd)
        Me.posPanel.Controls.Add(Me.btnPOSStart)
        Me.posPanel.Controls.Add(Me.pnlPOSCategories)
        Me.posPanel.Controls.Add(Me.dataGridViewPOS)
        Me.posPanel.Controls.Add(Me.pnlPOSMenu)
        Me.posPanel.Controls.Add(Me.lblTransactionNumber)
        Me.posPanel.Controls.Add(Me.lblPOSOrderNo)
        Me.posPanel.Controls.Add(Me.lblRole)
        Me.posPanel.Controls.Add(Me.lblOrderNumber)
        Me.posPanel.Controls.Add(Me.lblPOSTransactionNo)
        Me.posPanel.Controls.Add(Me.lblName)
        Me.posPanel.Controls.Add(Me.pnlBottomDashboardPOS)
        Me.posPanel.Controls.Add(Me.pnlTopPOS)
        Me.posPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.posPanel.Location = New System.Drawing.Point(0, 0)
        Me.posPanel.Name = "posPanel"
        Me.posPanel.Size = New System.Drawing.Size(1079, 788)
        Me.posPanel.TabIndex = 4
        '
        'btnPOSEnd
        '
        Me.btnPOSEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSEnd.FlatAppearance.BorderSize = 0
        Me.btnPOSEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSEnd.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSEnd.ForeColor = System.Drawing.Color.White
        Me.btnPOSEnd.Image = CType(resources.GetObject("btnPOSEnd.Image"), System.Drawing.Image)
        Me.btnPOSEnd.Location = New System.Drawing.Point(844, 674)
        Me.btnPOSEnd.Name = "btnPOSEnd"
        Me.btnPOSEnd.Size = New System.Drawing.Size(172, 40)
        Me.btnPOSEnd.TabIndex = 24
        Me.btnPOSEnd.Text = " [ END OF THE DAY ]"
        Me.btnPOSEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPOSEnd.UseVisualStyleBackColor = False
        '
        'btnPOSStart
        '
        Me.btnPOSStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPOSStart.FlatAppearance.BorderSize = 0
        Me.btnPOSStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSStart.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSStart.ForeColor = System.Drawing.Color.White
        Me.btnPOSStart.Image = CType(resources.GetObject("btnPOSStart.Image"), System.Drawing.Image)
        Me.btnPOSStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPOSStart.Location = New System.Drawing.Point(666, 674)
        Me.btnPOSStart.Name = "btnPOSStart"
        Me.btnPOSStart.Size = New System.Drawing.Size(172, 40)
        Me.btnPOSStart.TabIndex = 23
        Me.btnPOSStart.Text = " [ START OF THE DAY ]"
        Me.btnPOSStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPOSStart.UseVisualStyleBackColor = False
        '
        'pnlPOSCategories
        '
        Me.pnlPOSCategories.BackColor = System.Drawing.Color.White
        Me.pnlPOSCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPOSCategories.Location = New System.Drawing.Point(-14, 114)
        Me.pnlPOSCategories.Name = "pnlPOSCategories"
        Me.pnlPOSCategories.Size = New System.Drawing.Size(131, 600)
        Me.pnlPOSCategories.TabIndex = 16
        '
        'dataGridViewPOS
        '
        Me.dataGridViewPOS.AllowUserToAddRows = False
        Me.dataGridViewPOS.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewPOS.ColumnHeadersHeight = 30
        Me.dataGridViewPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewPOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.colPOSDelete})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPOS.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridViewPOS.EnableHeadersVisualStyles = False
        Me.dataGridViewPOS.Location = New System.Drawing.Point(662, 114)
        Me.dataGridViewPOS.Name = "dataGridViewPOS"
        Me.dataGridViewPOS.RowHeadersVisible = False
        Me.dataGridViewPOS.RowTemplate.Height = 25
        Me.dataGridViewPOS.Size = New System.Drawing.Size(404, 554)
        Me.dataGridViewPOS.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Order"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 62
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 57
        '
        'colPOSDelete
        '
        Me.colPOSDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPOSDelete.HeaderText = ""
        Me.colPOSDelete.Name = "colPOSDelete"
        Me.colPOSDelete.Width = 5
        '
        'pnlPOSMenu
        '
        Me.pnlPOSMenu.BackColor = System.Drawing.Color.White
        Me.pnlPOSMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPOSMenu.Location = New System.Drawing.Point(118, 114)
        Me.pnlPOSMenu.Name = "pnlPOSMenu"
        Me.pnlPOSMenu.Size = New System.Drawing.Size(542, 600)
        Me.pnlPOSMenu.TabIndex = 15
        '
        'lblTransactionNumber
        '
        Me.lblTransactionNumber.AutoSize = True
        Me.lblTransactionNumber.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTransactionNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblTransactionNumber.Location = New System.Drawing.Point(118, 65)
        Me.lblTransactionNumber.Name = "lblTransactionNumber"
        Me.lblTransactionNumber.Size = New System.Drawing.Size(0, 15)
        Me.lblTransactionNumber.TabIndex = 19
        '
        'lblPOSOrderNo
        '
        Me.lblPOSOrderNo.AutoSize = True
        Me.lblPOSOrderNo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSOrderNo.Location = New System.Drawing.Point(49, 90)
        Me.lblPOSOrderNo.Name = "lblPOSOrderNo"
        Me.lblPOSOrderNo.Size = New System.Drawing.Size(69, 15)
        Me.lblPOSOrderNo.TabIndex = 18
        Me.lblPOSOrderNo.Text = "ORDER NO."
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRole.Location = New System.Drawing.Point(967, 90)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(35, 15)
        Me.lblRole.TabIndex = 22
        Me.lblRole.Text = "ROLE"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblOrderNumber.Location = New System.Drawing.Point(118, 90)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(0, 15)
        Me.lblOrderNumber.TabIndex = 20
        '
        'lblPOSTransactionNo
        '
        Me.lblPOSTransactionNo.AutoSize = True
        Me.lblPOSTransactionNo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSTransactionNo.Location = New System.Drawing.Point(5, 65)
        Me.lblPOSTransactionNo.Name = "lblPOSTransactionNo"
        Me.lblPOSTransactionNo.Size = New System.Drawing.Size(113, 15)
        Me.lblPOSTransactionNo.TabIndex = 17
        Me.lblPOSTransactionNo.Text = "TRANSACTION NO."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(961, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 15)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "NAME"
        '
        'pnlBottomDashboardPOS
        '
        Me.pnlBottomDashboardPOS.BackColor = System.Drawing.Color.White
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnBlank)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSManageOrders)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSSalesReport)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSManageProductMenu)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSCancelOrder)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSAddVoucher)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSSettlePayment)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSNewTransaction)
        Me.pnlBottomDashboardPOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomDashboardPOS.Location = New System.Drawing.Point(0, 720)
        Me.pnlBottomDashboardPOS.Name = "pnlBottomDashboardPOS"
        Me.pnlBottomDashboardPOS.Size = New System.Drawing.Size(1079, 68)
        Me.pnlBottomDashboardPOS.TabIndex = 13
        '
        'btnBlank
        '
        Me.btnBlank.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnBlank.FlatAppearance.BorderSize = 0
        Me.btnBlank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlank.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBlank.ForeColor = System.Drawing.Color.White
        Me.btnBlank.Location = New System.Drawing.Point(933, 27)
        Me.btnBlank.Name = "btnBlank"
        Me.btnBlank.Size = New System.Drawing.Size(138, 40)
        Me.btnBlank.TabIndex = 8
        Me.btnBlank.UseVisualStyleBackColor = False
        '
        'btnPOSManageOrders
        '
        Me.btnPOSManageOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSManageOrders.FlatAppearance.BorderSize = 0
        Me.btnPOSManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSManageOrders.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSManageOrders.ForeColor = System.Drawing.Color.White
        Me.btnPOSManageOrders.Location = New System.Drawing.Point(666, 27)
        Me.btnPOSManageOrders.Name = "btnPOSManageOrders"
        Me.btnPOSManageOrders.Size = New System.Drawing.Size(127, 40)
        Me.btnPOSManageOrders.TabIndex = 7
        Me.btnPOSManageOrders.Text = "[F6] MANAGE ORDERS"
        Me.btnPOSManageOrders.UseVisualStyleBackColor = False
        '
        'btnPOSSalesReport
        '
        Me.btnPOSSalesReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSSalesReport.FlatAppearance.BorderSize = 0
        Me.btnPOSSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSSalesReport.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSSalesReport.ForeColor = System.Drawing.Color.White
        Me.btnPOSSalesReport.Location = New System.Drawing.Point(794, 27)
        Me.btnPOSSalesReport.Name = "btnPOSSalesReport"
        Me.btnPOSSalesReport.Size = New System.Drawing.Size(138, 40)
        Me.btnPOSSalesReport.TabIndex = 6
        Me.btnPOSSalesReport.Text = " [F7] SALES REPORT"
        Me.btnPOSSalesReport.UseVisualStyleBackColor = False
        '
        'btnPOSManageProductMenu
        '
        Me.btnPOSManageProductMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSManageProductMenu.FlatAppearance.BorderSize = 0
        Me.btnPOSManageProductMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSManageProductMenu.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSManageProductMenu.ForeColor = System.Drawing.Color.White
        Me.btnPOSManageProductMenu.Location = New System.Drawing.Point(533, 27)
        Me.btnPOSManageProductMenu.Name = "btnPOSManageProductMenu"
        Me.btnPOSManageProductMenu.Size = New System.Drawing.Size(132, 41)
        Me.btnPOSManageProductMenu.TabIndex = 4
        Me.btnPOSManageProductMenu.Text = " [F5] MANAGE PRODUCT MENU"
        Me.btnPOSManageProductMenu.UseVisualStyleBackColor = False
        '
        'btnPOSCancelOrder
        '
        Me.btnPOSCancelOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSCancelOrder.FlatAppearance.BorderSize = 0
        Me.btnPOSCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSCancelOrder.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSCancelOrder.ForeColor = System.Drawing.Color.White
        Me.btnPOSCancelOrder.Location = New System.Drawing.Point(400, 27)
        Me.btnPOSCancelOrder.Name = "btnPOSCancelOrder"
        Me.btnPOSCancelOrder.Size = New System.Drawing.Size(132, 42)
        Me.btnPOSCancelOrder.TabIndex = 3
        Me.btnPOSCancelOrder.Text = "[F4] CANCEL ORDER"
        Me.btnPOSCancelOrder.UseVisualStyleBackColor = False
        '
        'btnPOSAddVoucher
        '
        Me.btnPOSAddVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSAddVoucher.FlatAppearance.BorderSize = 0
        Me.btnPOSAddVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSAddVoucher.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSAddVoucher.ForeColor = System.Drawing.Color.White
        Me.btnPOSAddVoucher.Location = New System.Drawing.Point(267, 27)
        Me.btnPOSAddVoucher.Name = "btnPOSAddVoucher"
        Me.btnPOSAddVoucher.Size = New System.Drawing.Size(132, 41)
        Me.btnPOSAddVoucher.TabIndex = 2
        Me.btnPOSAddVoucher.Text = " [F3] ADD VOUCHER"
        Me.btnPOSAddVoucher.UseVisualStyleBackColor = False
        '
        'btnPOSSettlePayment
        '
        Me.btnPOSSettlePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSSettlePayment.FlatAppearance.BorderSize = 0
        Me.btnPOSSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSSettlePayment.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSSettlePayment.ForeColor = System.Drawing.Color.White
        Me.btnPOSSettlePayment.Location = New System.Drawing.Point(134, 27)
        Me.btnPOSSettlePayment.Name = "btnPOSSettlePayment"
        Me.btnPOSSettlePayment.Size = New System.Drawing.Size(132, 41)
        Me.btnPOSSettlePayment.TabIndex = 1
        Me.btnPOSSettlePayment.Text = "[F2]  SETTLE PAYMENT"
        Me.btnPOSSettlePayment.UseVisualStyleBackColor = False
        '
        'btnPOSNewTransaction
        '
        Me.btnPOSNewTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPOSNewTransaction.FlatAppearance.BorderSize = 0
        Me.btnPOSNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSNewTransaction.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSNewTransaction.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPOSNewTransaction.Location = New System.Drawing.Point(1, 27)
        Me.btnPOSNewTransaction.Name = "btnPOSNewTransaction"
        Me.btnPOSNewTransaction.Size = New System.Drawing.Size(132, 41)
        Me.btnPOSNewTransaction.TabIndex = 0
        Me.btnPOSNewTransaction.Text = "[F1]  NEW TRANSACTION"
        Me.btnPOSNewTransaction.UseVisualStyleBackColor = False
        '
        'pnlTopPOS
        '
        Me.pnlTopPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pnlTopPOS.Controls.Add(Me.Panel1)
        Me.pnlTopPOS.Controls.Add(Me.picBoxPOSAthena)
        Me.pnlTopPOS.Controls.Add(Me.lblPOSAthenaPerbs)
        Me.pnlTopPOS.Controls.Add(Me.lblPOSSoftware)
        Me.pnlTopPOS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopPOS.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopPOS.Name = "pnlTopPOS"
        Me.pnlTopPOS.Size = New System.Drawing.Size(1079, 46)
        Me.pnlTopPOS.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(-9, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(11, 46)
        Me.Panel1.TabIndex = 0
        '
        'picBoxPOSAthena
        '
        Me.picBoxPOSAthena.Image = CType(resources.GetObject("picBoxPOSAthena.Image"), System.Drawing.Image)
        Me.picBoxPOSAthena.Location = New System.Drawing.Point(-1, -8)
        Me.picBoxPOSAthena.Name = "picBoxPOSAthena"
        Me.picBoxPOSAthena.Size = New System.Drawing.Size(64, 69)
        Me.picBoxPOSAthena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxPOSAthena.TabIndex = 2
        Me.picBoxPOSAthena.TabStop = False
        '
        'lblPOSAthenaPerbs
        '
        Me.lblPOSAthenaPerbs.AutoSize = True
        Me.lblPOSAthenaPerbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPOSAthenaPerbs.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSAthenaPerbs.ForeColor = System.Drawing.Color.White
        Me.lblPOSAthenaPerbs.Location = New System.Drawing.Point(224, 16)
        Me.lblPOSAthenaPerbs.Name = "lblPOSAthenaPerbs"
        Me.lblPOSAthenaPerbs.Size = New System.Drawing.Size(109, 17)
        Me.lblPOSAthenaPerbs.TabIndex = 1
        Me.lblPOSAthenaPerbs.Text = "| ATHENA PERBS"
        '
        'lblPOSSoftware
        '
        Me.lblPOSSoftware.AutoSize = True
        Me.lblPOSSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPOSSoftware.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSSoftware.ForeColor = System.Drawing.Color.White
        Me.lblPOSSoftware.Location = New System.Drawing.Point(70, 10)
        Me.lblPOSSoftware.Name = "lblPOSSoftware"
        Me.lblPOSSoftware.Size = New System.Drawing.Size(148, 25)
        Me.lblPOSSoftware.TabIndex = 0
        Me.lblPOSSoftware.Text = "POS SOFTWARE"
        '
        'PosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.Controls.Add(Me.posPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PosForm"
        Me.Text = "PosForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.posPanel.ResumeLayout(False)
        Me.posPanel.PerformLayout()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottomDashboardPOS.ResumeLayout(False)
        Me.pnlTopPOS.ResumeLayout(False)
        Me.pnlTopPOS.PerformLayout()
        CType(Me.picBoxPOSAthena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents posPanel As Panel
    Friend WithEvents lblTransactionNumber As Label
    Friend WithEvents lblPOSOrderNo As Label
    Friend WithEvents pnlPOSCategories As FlowLayoutPanel
    Friend WithEvents lblRole As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblPOSTransactionNo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents dataGridViewPOS As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents colPOSDelete As DataGridViewImageColumn
    Friend WithEvents pnlBottomDashboardPOS As Panel
    Friend WithEvents btnBlank As Button
    Friend WithEvents btnPOSManageOrders As Button
    Friend WithEvents btnPOSSalesReport As Button
    Friend WithEvents btnPOSManageProductMenu As Button
    Friend WithEvents btnPOSCancelOrder As Button
    Friend WithEvents btnPOSAddVoucher As Button
    Friend WithEvents btnPOSSettlePayment As Button
    Friend WithEvents btnPOSNewTransaction As Button
    Friend WithEvents pnlTopPOS As Panel
    Friend WithEvents picBoxPOSAthena As PictureBox
    Friend WithEvents lblPOSAthenaPerbs As Label
    Friend WithEvents lblPOSSoftware As Label
    Friend WithEvents pnlPOSMenu As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPOSEnd As Button
    Friend WithEvents btnPOSStart As Button
End Class
