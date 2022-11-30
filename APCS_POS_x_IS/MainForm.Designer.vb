<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.PosButton = New System.Windows.Forms.Button()
        Me.DashboardButton = New System.Windows.Forms.Button()
        Me.UsersButton = New System.Windows.Forms.Button()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.EmployeeText = New System.Windows.Forms.Label()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.posPanel = New System.Windows.Forms.Panel()
        Me.lblTransactionNumber = New System.Windows.Forms.Label()
        Me.lblPOSOrderNo = New System.Windows.Forms.Label()
        Me.pnlPOSCategories = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblPOSTransactionNo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dataGridViewPOS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPOSDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlBottomDashboardPOS = New System.Windows.Forms.Panel()
        Me.btnBlank = New System.Windows.Forms.Button()
        Me.btnPOSManageOrders = New System.Windows.Forms.Button()
        Me.btnPOSMonthlyReport = New System.Windows.Forms.Button()
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
        Me.pnlPOSMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.LeftPanel.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.posPanel.SuspendLayout()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottomDashboardPOS.SuspendLayout()
        Me.pnlTopPOS.SuspendLayout()
        CType(Me.picBoxPOSAthena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.LogoutButton)
        Me.LeftPanel.Controls.Add(Me.PosButton)
        Me.LeftPanel.Controls.Add(Me.DashboardButton)
        Me.LeftPanel.Controls.Add(Me.UsersButton)
        Me.LeftPanel.Controls.Add(Me.ProfilePanel)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(307, 788)
        Me.LeftPanel.TabIndex = 0
        '
        'LogoutButton
        '
        Me.LogoutButton.FlatAppearance.BorderSize = 0
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogoutButton.ForeColor = System.Drawing.Color.White
        Me.LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), System.Drawing.Image)
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(0, 707)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(304, 38)
        Me.LogoutButton.TabIndex = 4
        Me.LogoutButton.Text = "LOGOUT"
        Me.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'PosButton
        '
        Me.PosButton.FlatAppearance.BorderSize = 0
        Me.PosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PosButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PosButton.ForeColor = System.Drawing.Color.White
        Me.PosButton.Image = CType(resources.GetObject("PosButton.Image"), System.Drawing.Image)
        Me.PosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PosButton.Location = New System.Drawing.Point(0, 310)
        Me.PosButton.Name = "PosButton"
        Me.PosButton.Size = New System.Drawing.Size(307, 42)
        Me.PosButton.TabIndex = 3
        Me.PosButton.Text = "POINT OF SALE"
        Me.PosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PosButton.UseVisualStyleBackColor = True
        '
        'DashboardButton
        '
        Me.DashboardButton.FlatAppearance.BorderSize = 0
        Me.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DashboardButton.ForeColor = System.Drawing.Color.White
        Me.DashboardButton.Image = CType(resources.GetObject("DashboardButton.Image"), System.Drawing.Image)
        Me.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardButton.Location = New System.Drawing.Point(0, 264)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.Size = New System.Drawing.Size(307, 42)
        Me.DashboardButton.TabIndex = 2
        Me.DashboardButton.Text = "DASHBOARD"
        Me.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardButton.UseVisualStyleBackColor = True
        '
        'UsersButton
        '
        Me.UsersButton.FlatAppearance.BorderSize = 0
        Me.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsersButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsersButton.ForeColor = System.Drawing.Color.White
        Me.UsersButton.Image = CType(resources.GetObject("UsersButton.Image"), System.Drawing.Image)
        Me.UsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsersButton.Location = New System.Drawing.Point(0, 218)
        Me.UsersButton.Name = "UsersButton"
        Me.UsersButton.Size = New System.Drawing.Size(307, 42)
        Me.UsersButton.TabIndex = 1
        Me.UsersButton.Text = "USERS"
        Me.UsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UsersButton.UseVisualStyleBackColor = True
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfilePanel.Controls.Add(Me.EmployeeText)
        Me.ProfilePanel.Controls.Add(Me.ProfilePic)
        Me.ProfilePanel.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(307, 203)
        Me.ProfilePanel.TabIndex = 0
        '
        'EmployeeText
        '
        Me.EmployeeText.AutoSize = True
        Me.EmployeeText.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmployeeText.ForeColor = System.Drawing.Color.White
        Me.EmployeeText.Location = New System.Drawing.Point(96, 169)
        Me.EmployeeText.Name = "EmployeeText"
        Me.EmployeeText.Size = New System.Drawing.Size(109, 28)
        Me.EmployeeText.TabIndex = 1
        Me.EmployeeText.Text = "EMPLOYEE"
        '
        'ProfilePic
        '
        Me.ProfilePic.Image = CType(resources.GetObject("ProfilePic.Image"), System.Drawing.Image)
        Me.ProfilePic.Location = New System.Drawing.Point(-1, -1)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(307, 203)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ProfilePic.TabIndex = 0
        Me.ProfilePic.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.posPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(307, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1079, 788)
        Me.MainPanel.TabIndex = 1
        '
        'posPanel
        '
        Me.posPanel.BackColor = System.Drawing.Color.White
        Me.posPanel.Controls.Add(Me.lblTransactionNumber)
        Me.posPanel.Controls.Add(Me.lblPOSOrderNo)
        Me.posPanel.Controls.Add(Me.pnlPOSCategories)
        Me.posPanel.Controls.Add(Me.lblRole)
        Me.posPanel.Controls.Add(Me.lblOrderNumber)
        Me.posPanel.Controls.Add(Me.lblPOSTransactionNo)
        Me.posPanel.Controls.Add(Me.lblName)
        Me.posPanel.Controls.Add(Me.dataGridViewPOS)
        Me.posPanel.Controls.Add(Me.pnlBottomDashboardPOS)
        Me.posPanel.Controls.Add(Me.pnlTopPOS)
        Me.posPanel.Controls.Add(Me.pnlPOSMenu)
        Me.posPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.posPanel.Location = New System.Drawing.Point(0, 0)
        Me.posPanel.Name = "posPanel"
        Me.posPanel.Size = New System.Drawing.Size(1079, 788)
        Me.posPanel.TabIndex = 5
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
        'pnlPOSCategories
        '
        Me.pnlPOSCategories.BackColor = System.Drawing.Color.White
        Me.pnlPOSCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPOSCategories.Location = New System.Drawing.Point(-14, 114)
        Me.pnlPOSCategories.Name = "pnlPOSCategories"
        Me.pnlPOSCategories.Size = New System.Drawing.Size(131, 610)
        Me.pnlPOSCategories.TabIndex = 16
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
        'dataGridViewPOS
        '
        Me.dataGridViewPOS.AllowUserToAddRows = False
        Me.dataGridViewPOS.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dataGridViewPOS.ColumnHeadersHeight = 30
        Me.dataGridViewPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewPOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.colPOSDelete})
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPOS.DefaultCellStyle = DataGridViewCellStyle25
        Me.dataGridViewPOS.EnableHeadersVisualStyles = False
        Me.dataGridViewPOS.Location = New System.Drawing.Point(662, 114)
        Me.dataGridViewPOS.Name = "dataGridViewPOS"
        Me.dataGridViewPOS.RowHeadersVisible = False
        Me.dataGridViewPOS.RowTemplate.Height = 25
        Me.dataGridViewPOS.Size = New System.Drawing.Size(377, 607)
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
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column4.HeaderText = "Order"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 62
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle24
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
        'pnlBottomDashboardPOS
        '
        Me.pnlBottomDashboardPOS.BackColor = System.Drawing.Color.White
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnBlank)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSManageOrders)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSMonthlyReport)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSManageProductMenu)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSCancelOrder)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSAddVoucher)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSSettlePayment)
        Me.pnlBottomDashboardPOS.Controls.Add(Me.btnPOSNewTransaction)
        Me.pnlBottomDashboardPOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomDashboardPOS.Location = New System.Drawing.Point(0, 721)
        Me.pnlBottomDashboardPOS.Name = "pnlBottomDashboardPOS"
        Me.pnlBottomDashboardPOS.Size = New System.Drawing.Size(1079, 67)
        Me.pnlBottomDashboardPOS.TabIndex = 13
        '
        'btnBlank
        '
        Me.btnBlank.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnBlank.FlatAppearance.BorderSize = 0
        Me.btnBlank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlank.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBlank.ForeColor = System.Drawing.Color.White
        Me.btnBlank.Location = New System.Drawing.Point(928, 27)
        Me.btnBlank.Name = "btnBlank"
        Me.btnBlank.Size = New System.Drawing.Size(137, 40)
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
        Me.btnPOSManageOrders.Location = New System.Drawing.Point(663, 27)
        Me.btnPOSManageOrders.Name = "btnPOSManageOrders"
        Me.btnPOSManageOrders.Size = New System.Drawing.Size(126, 40)
        Me.btnPOSManageOrders.TabIndex = 7
        Me.btnPOSManageOrders.Text = "[F6] MANAGE ORDERS"
        Me.btnPOSManageOrders.UseVisualStyleBackColor = False
        '
        'btnPOSMonthlyReport
        '
        Me.btnPOSMonthlyReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSMonthlyReport.FlatAppearance.BorderSize = 0
        Me.btnPOSMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSMonthlyReport.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSMonthlyReport.ForeColor = System.Drawing.Color.White
        Me.btnPOSMonthlyReport.Location = New System.Drawing.Point(790, 27)
        Me.btnPOSMonthlyReport.Name = "btnPOSMonthlyReport"
        Me.btnPOSMonthlyReport.Size = New System.Drawing.Size(137, 40)
        Me.btnPOSMonthlyReport.TabIndex = 6
        Me.btnPOSMonthlyReport.Text = " [F7] MONTHLY SALES REPORT"
        Me.btnPOSMonthlyReport.UseVisualStyleBackColor = False
        '
        'btnPOSManageProductMenu
        '
        Me.btnPOSManageProductMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPOSManageProductMenu.FlatAppearance.BorderSize = 0
        Me.btnPOSManageProductMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSManageProductMenu.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSManageProductMenu.ForeColor = System.Drawing.Color.White
        Me.btnPOSManageProductMenu.Location = New System.Drawing.Point(531, 27)
        Me.btnPOSManageProductMenu.Name = "btnPOSManageProductMenu"
        Me.btnPOSManageProductMenu.Size = New System.Drawing.Size(131, 41)
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
        Me.btnPOSCancelOrder.Location = New System.Drawing.Point(399, 27)
        Me.btnPOSCancelOrder.Name = "btnPOSCancelOrder"
        Me.btnPOSCancelOrder.Size = New System.Drawing.Size(131, 42)
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
        Me.btnPOSAddVoucher.Size = New System.Drawing.Size(131, 41)
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
        Me.btnPOSSettlePayment.Location = New System.Drawing.Point(135, 27)
        Me.btnPOSSettlePayment.Name = "btnPOSSettlePayment"
        Me.btnPOSSettlePayment.Size = New System.Drawing.Size(131, 41)
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
        Me.btnPOSNewTransaction.Location = New System.Drawing.Point(2, 27)
        Me.btnPOSNewTransaction.Name = "btnPOSNewTransaction"
        Me.btnPOSNewTransaction.Size = New System.Drawing.Size(131, 41)
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
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 46)
        Me.Panel1.TabIndex = 0
        '
        'picBoxPOSAthena
        '
        Me.picBoxPOSAthena.Image = CType(resources.GetObject("picBoxPOSAthena.Image"), System.Drawing.Image)
        Me.picBoxPOSAthena.Location = New System.Drawing.Point(-1, -8)
        Me.picBoxPOSAthena.Name = "picBoxPOSAthena"
        Me.picBoxPOSAthena.Size = New System.Drawing.Size(63, 69)
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
        'pnlPOSMenu
        '
        Me.pnlPOSMenu.BackColor = System.Drawing.Color.White
        Me.pnlPOSMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPOSMenu.Location = New System.Drawing.Point(118, 114)
        Me.pnlPOSMenu.Name = "pnlPOSMenu"
        Me.pnlPOSMenu.Size = New System.Drawing.Size(542, 610)
        Me.pnlPOSMenu.TabIndex = 15
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LeftPanel.ResumeLayout(False)
        Me.ProfilePanel.ResumeLayout(False)
        Me.ProfilePanel.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.posPanel.ResumeLayout(False)
        Me.posPanel.PerformLayout()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottomDashboardPOS.ResumeLayout(False)
        Me.pnlTopPOS.ResumeLayout(False)
        Me.pnlTopPOS.PerformLayout()
        CType(Me.picBoxPOSAthena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents EmployeeText As Label
    Friend WithEvents ProfilePic As PictureBox
    Friend WithEvents UsersButton As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents PosButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents MainPanel As Panel
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
    Friend WithEvents btnPOSMonthlyReport As Button
    Friend WithEvents btnPOSManageProductMenu As Button
    Friend WithEvents btnPOSCancelOrder As Button
    Friend WithEvents btnPOSAddVoucher As Button
    Friend WithEvents btnPOSSettlePayment As Button
    Friend WithEvents btnPOSNewTransaction As Button
    Friend WithEvents pnlTopPOS As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBoxPOSAthena As PictureBox
    Friend WithEvents lblPOSAthenaPerbs As Label
    Friend WithEvents lblPOSSoftware As Label
    Friend WithEvents pnlPOSMenu As FlowLayoutPanel
End Class
