<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PosForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.posPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VAT = New System.Windows.Forms.Label()
        Me.SubTot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPOSEnd = New System.Windows.Forms.Button()
        Me.btnPOSStart = New System.Windows.Forms.Button()
        Me.DateOrder = New System.Windows.Forms.Label()
        Me.LblTranNo = New System.Windows.Forms.Label()
        Me.dataGridViewPMenus = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodCategory = New System.Windows.Forms.ComboBox()
        Me.lblPOSTransactionNo = New System.Windows.Forms.Label()
        Me.dataGridViewPOS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTransactionNumber = New System.Windows.Forms.Label()
        Me.lblPOSOrderNo = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBoxPOSAthena = New System.Windows.Forms.PictureBox()
        Me.lblPOSSoftware = New System.Windows.Forms.Label()
        Me.posPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dataGridViewPMenus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottomDashboardPOS.SuspendLayout()
        Me.pnlTopPOS.SuspendLayout()
        CType(Me.picBoxPOSAthena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'posPanel
        '
        Me.posPanel.BackColor = System.Drawing.Color.White
        Me.posPanel.Controls.Add(Me.Panel1)
        Me.posPanel.Controls.Add(Me.btnPOSEnd)
        Me.posPanel.Controls.Add(Me.btnPOSStart)
        Me.posPanel.Controls.Add(Me.DateOrder)
        Me.posPanel.Controls.Add(Me.LblTranNo)
        Me.posPanel.Controls.Add(Me.dataGridViewPMenus)
        Me.posPanel.Controls.Add(Me.FoodCategory)
        Me.posPanel.Controls.Add(Me.lblPOSTransactionNo)
        Me.posPanel.Controls.Add(Me.dataGridViewPOS)
        Me.posPanel.Controls.Add(Me.lblTransactionNumber)
        Me.posPanel.Controls.Add(Me.lblPOSOrderNo)
        Me.posPanel.Controls.Add(Me.lblOrderNumber)
        Me.posPanel.Controls.Add(Me.pnlBottomDashboardPOS)
        Me.posPanel.Controls.Add(Me.pnlTopPOS)
        Me.posPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.posPanel.Location = New System.Drawing.Point(0, 0)
        Me.posPanel.Name = "posPanel"
        Me.posPanel.Size = New System.Drawing.Size(1079, 788)
        Me.posPanel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TotalLbl)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.VAT)
        Me.Panel1.Controls.Add(Me.SubTot)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(602, 602)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 117)
        Me.Panel1.TabIndex = 28
        '
        'TotalLbl
        '
        Me.TotalLbl.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalLbl.ForeColor = System.Drawing.Color.Lime
        Me.TotalLbl.Location = New System.Drawing.Point(155, 78)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(296, 34)
        Me.TotalLbl.TabIndex = 5
        Me.TotalLbl.Text = "0.00"
        Me.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(7, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TOTAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VAT
        '
        Me.VAT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VAT.ForeColor = System.Drawing.Color.Lime
        Me.VAT.Location = New System.Drawing.Point(155, 42)
        Me.VAT.Name = "VAT"
        Me.VAT.Size = New System.Drawing.Size(296, 34)
        Me.VAT.TabIndex = 3
        Me.VAT.Text = "0.00"
        Me.VAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubTot
        '
        Me.SubTot.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SubTot.ForeColor = System.Drawing.Color.Lime
        Me.SubTot.Location = New System.Drawing.Point(155, 2)
        Me.SubTot.Name = "SubTot"
        Me.SubTot.Size = New System.Drawing.Size(296, 42)
        Me.SubTot.TabIndex = 2
        Me.SubTot.Text = "0.00"
        Me.SubTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(7, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 34)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "VAT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(7, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SUBTOTAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPOSEnd
        '
        Me.btnPOSEnd.BackColor = System.Drawing.Color.DimGray
        Me.btnPOSEnd.FlatAppearance.BorderSize = 0
        Me.btnPOSEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOSEnd.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPOSEnd.ForeColor = System.Drawing.Color.White
        Me.btnPOSEnd.Image = CType(resources.GetObject("btnPOSEnd.Image"), System.Drawing.Image)
        Me.btnPOSEnd.Location = New System.Drawing.Point(438, 49)
        Me.btnPOSEnd.Name = "btnPOSEnd"
        Me.btnPOSEnd.Size = New System.Drawing.Size(160, 35)
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
        Me.btnPOSStart.Location = New System.Drawing.Point(275, 49)
        Me.btnPOSStart.Name = "btnPOSStart"
        Me.btnPOSStart.Size = New System.Drawing.Size(160, 35)
        Me.btnPOSStart.TabIndex = 23
        Me.btnPOSStart.Text = " [ START OF THE DAY ]"
        Me.btnPOSStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPOSStart.UseVisualStyleBackColor = False
        '
        'DateOrder
        '
        Me.DateOrder.BackColor = System.Drawing.Color.Transparent
        Me.DateOrder.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateOrder.ForeColor = System.Drawing.Color.Crimson
        Me.DateOrder.Location = New System.Drawing.Point(794, 91)
        Me.DateOrder.Name = "DateOrder"
        Me.DateOrder.Size = New System.Drawing.Size(179, 20)
        Me.DateOrder.TabIndex = 27
        Me.DateOrder.Text = "000000000"
        '
        'LblTranNo
        '
        Me.LblTranNo.BackColor = System.Drawing.Color.Transparent
        Me.LblTranNo.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTranNo.ForeColor = System.Drawing.Color.Crimson
        Me.LblTranNo.Location = New System.Drawing.Point(794, 65)
        Me.LblTranNo.Name = "LblTranNo"
        Me.LblTranNo.Size = New System.Drawing.Size(179, 20)
        Me.LblTranNo.TabIndex = 26
        Me.LblTranNo.Text = "000000000"
        '
        'dataGridViewPMenus
        '
        Me.dataGridViewPMenus.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dataGridViewPMenus.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewPMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewPMenus.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewPMenus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGridViewPMenus.ColumnHeadersHeight = 30
        Me.dataGridViewPMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewPMenus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.PCode, Me.TName, Me.TPrice})
        Me.dataGridViewPMenus.Location = New System.Drawing.Point(4, 86)
        Me.dataGridViewPMenus.Name = "dataGridViewPMenus"
        Me.dataGridViewPMenus.ReadOnly = True
        Me.dataGridViewPMenus.RowTemplate.Height = 25
        Me.dataGridViewPMenus.Size = New System.Drawing.Size(595, 633)
        Me.dataGridViewPMenus.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'PCode
        '
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(4)
        Me.PCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.PCode.HeaderText = "Product Code"
        Me.PCode.Name = "PCode"
        Me.PCode.ReadOnly = True
        '
        'TName
        '
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4)
        Me.TName.DefaultCellStyle = DataGridViewCellStyle4
        Me.TName.HeaderText = "Name"
        Me.TName.Name = "TName"
        Me.TName.ReadOnly = True
        '
        'TPrice
        '
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(4)
        Me.TPrice.DefaultCellStyle = DataGridViewCellStyle5
        Me.TPrice.HeaderText = "Price"
        Me.TPrice.Name = "TPrice"
        Me.TPrice.ReadOnly = True
        '
        'FoodCategory
        '
        Me.FoodCategory.BackColor = System.Drawing.SystemColors.Window
        Me.FoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FoodCategory.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FoodCategory.FormattingEnabled = True
        Me.FoodCategory.ItemHeight = 15
        Me.FoodCategory.Location = New System.Drawing.Point(4, 57)
        Me.FoodCategory.Name = "FoodCategory"
        Me.FoodCategory.Size = New System.Drawing.Size(160, 23)
        Me.FoodCategory.TabIndex = 24
        '
        'lblPOSTransactionNo
        '
        Me.lblPOSTransactionNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPOSTransactionNo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSTransactionNo.Location = New System.Drawing.Point(675, 67)
        Me.lblPOSTransactionNo.Name = "lblPOSTransactionNo"
        Me.lblPOSTransactionNo.Size = New System.Drawing.Size(113, 15)
        Me.lblPOSTransactionNo.TabIndex = 17
        Me.lblPOSTransactionNo.Text = "TRANSACTION NO:"
        Me.lblPOSTransactionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dataGridViewPOS
        '
        Me.dataGridViewPOS.AllowUserToAddRows = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGridViewPOS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewPOS.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataGridViewPOS.ColumnHeadersHeight = 30
        Me.dataGridViewPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewPOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn2, Me.PName, Me.DataGridViewTextBoxColumn3, Me.TQuantity, Me.TTotal})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPOS.DefaultCellStyle = DataGridViewCellStyle13
        Me.dataGridViewPOS.EnableHeadersVisualStyles = False
        Me.dataGridViewPOS.Location = New System.Drawing.Point(602, 122)
        Me.dataGridViewPOS.Name = "dataGridViewPOS"
        Me.dataGridViewPOS.ReadOnly = True
        Me.dataGridViewPOS.RowHeadersVisible = False
        Me.dataGridViewPOS.RowTemplate.Height = 25
        Me.dataGridViewPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewPOS.Size = New System.Drawing.Size(454, 479)
        Me.dataGridViewPOS.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(4)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.FillWeight = 253.8071!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 20
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 105
        '
        'PName
        '
        Me.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(4)
        Me.PName.DefaultCellStyle = DataGridViewCellStyle9
        Me.PName.FillWeight = 69.15269!
        Me.PName.HeaderText = "Name"
        Me.PName.MinimumWidth = 50
        Me.PName.Name = "PName"
        Me.PName.ReadOnly = True
        Me.PName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.82721!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 58
        '
        'TQuantity
        '
        Me.TQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(4)
        Me.TQuantity.DefaultCellStyle = DataGridViewCellStyle11
        Me.TQuantity.FillWeight = 75.38581!
        Me.TQuantity.HeaderText = "Quantity"
        Me.TQuantity.Name = "TQuantity"
        Me.TQuantity.ReadOnly = True
        Me.TQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TQuantity.Width = 78
        '
        'TTotal
        '
        Me.TTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(4)
        Me.TTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.TTotal.FillWeight = 50.82721!
        Me.TTotal.HeaderText = "Total"
        Me.TTotal.Name = "TTotal"
        Me.TTotal.ReadOnly = True
        Me.TTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TTotal.Width = 57
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
        Me.lblPOSOrderNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPOSOrderNo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSOrderNo.Location = New System.Drawing.Point(707, 93)
        Me.lblPOSOrderNo.Name = "lblPOSOrderNo"
        Me.lblPOSOrderNo.Size = New System.Drawing.Size(84, 15)
        Me.lblPOSOrderNo.TabIndex = 18
        Me.lblPOSOrderNo.Text = "ORDER DATE:"
        Me.lblPOSOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pnlTopPOS.Controls.Add(Me.Label1)
        Me.pnlTopPOS.Controls.Add(Me.picBoxPOSAthena)
        Me.pnlTopPOS.Controls.Add(Me.lblPOSSoftware)
        Me.pnlTopPOS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopPOS.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopPOS.Name = "pnlTopPOS"
        Me.pnlTopPOS.Size = New System.Drawing.Size(1079, 46)
        Me.pnlTopPOS.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(609, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ATHENA PERB'S"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picBoxPOSAthena
        '
        Me.picBoxPOSAthena.Image = CType(resources.GetObject("picBoxPOSAthena.Image"), System.Drawing.Image)
        Me.picBoxPOSAthena.Location = New System.Drawing.Point(-10, -6)
        Me.picBoxPOSAthena.Name = "picBoxPOSAthena"
        Me.picBoxPOSAthena.Size = New System.Drawing.Size(79, 63)
        Me.picBoxPOSAthena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxPOSAthena.TabIndex = 2
        Me.picBoxPOSAthena.TabStop = False
        '
        'lblPOSSoftware
        '
        Me.lblPOSSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPOSSoftware.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPOSSoftware.ForeColor = System.Drawing.Color.White
        Me.lblPOSSoftware.Location = New System.Drawing.Point(843, 1)
        Me.lblPOSSoftware.Name = "lblPOSSoftware"
        Me.lblPOSSoftware.Size = New System.Drawing.Size(213, 46)
        Me.lblPOSSoftware.TabIndex = 0
        Me.lblPOSSoftware.Text = "| POS SOFTWARE"
        Me.lblPOSSoftware.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.Panel1.ResumeLayout(False)
        CType(Me.dataGridViewPMenus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottomDashboardPOS.ResumeLayout(False)
        Me.pnlTopPOS.ResumeLayout(False)
        CType(Me.picBoxPOSAthena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents posPanel As Panel
    Friend WithEvents lblTransactionNumber As Label
    Friend WithEvents lblPOSOrderNo As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblPOSTransactionNo As Label
    Friend WithEvents dataGridViewPOS As DataGridView
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
    Friend WithEvents lblPOSSoftware As Label
    Friend WithEvents btnPOSEnd As Button
    Friend WithEvents btnPOSStart As Button
    Friend WithEvents FoodCategory As ComboBox
    Friend WithEvents dataGridViewPMenus As DataGridView
    Friend WithEvents LblTranNo As Label
    Friend WithEvents DateOrder As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PCode As DataGridViewTextBoxColumn
    Friend WithEvents TName As DataGridViewTextBoxColumn
    Friend WithEvents TPrice As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TTotal As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VAT As Label
    Friend WithEvents SubTot As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalLbl As Label
    Friend WithEvents Label5 As Label
End Class
