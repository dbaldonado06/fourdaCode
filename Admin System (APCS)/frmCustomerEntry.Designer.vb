<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerEntry))
        Me.pnlCustomerEntry = New System.Windows.Forms.Panel()
        Me.btnCustomersCancel = New System.Windows.Forms.Button()
        Me.btnCustomersSave = New System.Windows.Forms.Button()
        Me.txtBoxFullyPaidDate = New System.Windows.Forms.TextBox()
        Me.lblFullyPaidDate = New System.Windows.Forms.Label()
        Me.txtBoxDateDeposit = New System.Windows.Forms.TextBox()
        Me.lblDepositDate = New System.Windows.Forms.Label()
        Me.txtModeOfPayment = New System.Windows.Forms.TextBox()
        Me.lblModeOfPayment = New System.Windows.Forms.Label()
        Me.txtBoxReceiveDate = New System.Windows.Forms.TextBox()
        Me.lblReceiveDate = New System.Windows.Forms.Label()
        Me.txtBoxDateOrder = New System.Windows.Forms.TextBox()
        Me.lblDateOfOrder = New System.Windows.Forms.Label()
        Me.txtBoxOrders = New System.Windows.Forms.TextBox()
        Me.lblOrders = New System.Windows.Forms.Label()
        Me.txtBoxQty = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtBoxServiceType = New System.Windows.Forms.TextBox()
        Me.lblTypeOfService = New System.Windows.Forms.Label()
        Me.txtBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtBoxLocation = New System.Windows.Forms.TextBox()
        Me.lblCustomerLocation = New System.Windows.Forms.Label()
        Me.txtBoxCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.pnlTopCustomersEntry = New System.Windows.Forms.Panel()
        Me.picBoxRegUserClose = New System.Windows.Forms.PictureBox()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.picBoxCustomersEntryAthena = New System.Windows.Forms.PictureBox()
        Me.pnlCustomerEntry.SuspendLayout()
        Me.pnlTopCustomersEntry.SuspendLayout()
        CType(Me.picBoxRegUserClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxCustomersEntryAthena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustomerEntry
        '
        Me.pnlCustomerEntry.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCustomerEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCustomerEntry.Controls.Add(Me.btnCustomersCancel)
        Me.pnlCustomerEntry.Controls.Add(Me.btnCustomersSave)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxFullyPaidDate)
        Me.pnlCustomerEntry.Controls.Add(Me.lblFullyPaidDate)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxDateDeposit)
        Me.pnlCustomerEntry.Controls.Add(Me.lblDepositDate)
        Me.pnlCustomerEntry.Controls.Add(Me.txtModeOfPayment)
        Me.pnlCustomerEntry.Controls.Add(Me.lblModeOfPayment)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxReceiveDate)
        Me.pnlCustomerEntry.Controls.Add(Me.lblReceiveDate)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxDateOrder)
        Me.pnlCustomerEntry.Controls.Add(Me.lblDateOfOrder)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxOrders)
        Me.pnlCustomerEntry.Controls.Add(Me.lblOrders)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxQty)
        Me.pnlCustomerEntry.Controls.Add(Me.lblQty)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxServiceType)
        Me.pnlCustomerEntry.Controls.Add(Me.lblTypeOfService)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxPhoneNumber)
        Me.pnlCustomerEntry.Controls.Add(Me.lblPhoneNumber)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxLocation)
        Me.pnlCustomerEntry.Controls.Add(Me.lblCustomerLocation)
        Me.pnlCustomerEntry.Controls.Add(Me.txtBoxCustomerName)
        Me.pnlCustomerEntry.Controls.Add(Me.lblCustomerName)
        Me.pnlCustomerEntry.Controls.Add(Me.pnlTopCustomersEntry)
        Me.pnlCustomerEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomerEntry.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustomerEntry.Name = "pnlCustomerEntry"
        Me.pnlCustomerEntry.Size = New System.Drawing.Size(441, 755)
        Me.pnlCustomerEntry.TabIndex = 0
        '
        'btnCustomersCancel
        '
        Me.btnCustomersCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCustomersCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomersCancel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCustomersCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCustomersCancel.Location = New System.Drawing.Point(242, 686)
        Me.btnCustomersCancel.Name = "btnCustomersCancel"
        Me.btnCustomersCancel.Size = New System.Drawing.Size(88, 33)
        Me.btnCustomersCancel.TabIndex = 32
        Me.btnCustomersCancel.Text = "CANCEL"
        Me.btnCustomersCancel.UseVisualStyleBackColor = False
        '
        'btnCustomersSave
        '
        Me.btnCustomersSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCustomersSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomersSave.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCustomersSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCustomersSave.Location = New System.Drawing.Point(120, 686)
        Me.btnCustomersSave.Name = "btnCustomersSave"
        Me.btnCustomersSave.Size = New System.Drawing.Size(77, 33)
        Me.btnCustomersSave.TabIndex = 31
        Me.btnCustomersSave.Text = "SAVE"
        Me.btnCustomersSave.UseVisualStyleBackColor = False
        '
        'txtBoxFullyPaidDate
        '
        Me.txtBoxFullyPaidDate.Location = New System.Drawing.Point(197, 608)
        Me.txtBoxFullyPaidDate.Name = "txtBoxFullyPaidDate"
        Me.txtBoxFullyPaidDate.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxFullyPaidDate.TabIndex = 28
        '
        'lblFullyPaidDate
        '
        Me.lblFullyPaidDate.AutoSize = True
        Me.lblFullyPaidDate.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFullyPaidDate.Location = New System.Drawing.Point(31, 611)
        Me.lblFullyPaidDate.Name = "lblFullyPaidDate"
        Me.lblFullyPaidDate.Size = New System.Drawing.Size(115, 21)
        Me.lblFullyPaidDate.TabIndex = 27
        Me.lblFullyPaidDate.Text = "Fully Paid Date"
        '
        'txtBoxDateDeposit
        '
        Me.txtBoxDateDeposit.Location = New System.Drawing.Point(197, 570)
        Me.txtBoxDateDeposit.Name = "txtBoxDateDeposit"
        Me.txtBoxDateDeposit.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxDateDeposit.TabIndex = 26
        '
        'lblDepositDate
        '
        Me.lblDepositDate.AutoSize = True
        Me.lblDepositDate.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDepositDate.Location = New System.Drawing.Point(31, 571)
        Me.lblDepositDate.Name = "lblDepositDate"
        Me.lblDepositDate.Size = New System.Drawing.Size(105, 21)
        Me.lblDepositDate.TabIndex = 25
        Me.lblDepositDate.Text = "Date Deposit"
        '
        'txtModeOfPayment
        '
        Me.txtModeOfPayment.Location = New System.Drawing.Point(196, 531)
        Me.txtModeOfPayment.Name = "txtModeOfPayment"
        Me.txtModeOfPayment.Size = New System.Drawing.Size(214, 23)
        Me.txtModeOfPayment.TabIndex = 24
        '
        'lblModeOfPayment
        '
        Me.lblModeOfPayment.AutoSize = True
        Me.lblModeOfPayment.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblModeOfPayment.Location = New System.Drawing.Point(30, 534)
        Me.lblModeOfPayment.Name = "lblModeOfPayment"
        Me.lblModeOfPayment.Size = New System.Drawing.Size(143, 21)
        Me.lblModeOfPayment.TabIndex = 23
        Me.lblModeOfPayment.Text = "Mode Of Payment"
        '
        'txtBoxReceiveDate
        '
        Me.txtBoxReceiveDate.Location = New System.Drawing.Point(197, 493)
        Me.txtBoxReceiveDate.Name = "txtBoxReceiveDate"
        Me.txtBoxReceiveDate.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxReceiveDate.TabIndex = 22
        '
        'lblReceiveDate
        '
        Me.lblReceiveDate.AutoSize = True
        Me.lblReceiveDate.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReceiveDate.Location = New System.Drawing.Point(31, 495)
        Me.lblReceiveDate.Name = "lblReceiveDate"
        Me.lblReceiveDate.Size = New System.Drawing.Size(105, 21)
        Me.lblReceiveDate.TabIndex = 21
        Me.lblReceiveDate.Text = "Receive Date"
        '
        'txtBoxDateOrder
        '
        Me.txtBoxDateOrder.Location = New System.Drawing.Point(196, 454)
        Me.txtBoxDateOrder.Name = "txtBoxDateOrder"
        Me.txtBoxDateOrder.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxDateOrder.TabIndex = 20
        '
        'lblDateOfOrder
        '
        Me.lblDateOfOrder.AutoSize = True
        Me.lblDateOfOrder.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDateOfOrder.Location = New System.Drawing.Point(32, 456)
        Me.lblDateOfOrder.Name = "lblDateOfOrder"
        Me.lblDateOfOrder.Size = New System.Drawing.Size(111, 21)
        Me.lblDateOfOrder.TabIndex = 19
        Me.lblDateOfOrder.Text = "Date of Order"
        '
        'txtBoxOrders
        '
        Me.txtBoxOrders.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxOrders.Location = New System.Drawing.Point(197, 305)
        Me.txtBoxOrders.Name = "txtBoxOrders"
        Me.txtBoxOrders.Size = New System.Drawing.Size(214, 135)
        Me.txtBoxOrders.TabIndex = 18
        '
        'lblOrders
        '
        Me.lblOrders.AutoSize = True
        Me.lblOrders.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrders.Location = New System.Drawing.Point(29, 306)
        Me.lblOrders.Name = "lblOrders"
        Me.lblOrders.Size = New System.Drawing.Size(109, 21)
        Me.lblOrders.TabIndex = 17
        Me.lblOrders.Text = "List of Orders"
        '
        'txtBoxQty
        '
        Me.txtBoxQty.Location = New System.Drawing.Point(197, 263)
        Me.txtBoxQty.Name = "txtBoxQty"
        Me.txtBoxQty.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxQty.TabIndex = 16
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQty.Location = New System.Drawing.Point(28, 264)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(159, 21)
        Me.lblQty.TabIndex = 15
        Me.lblQty.Text = "Qty(per person/pax)"
        '
        'txtBoxServiceType
        '
        Me.txtBoxServiceType.Location = New System.Drawing.Point(197, 221)
        Me.txtBoxServiceType.Name = "txtBoxServiceType"
        Me.txtBoxServiceType.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxServiceType.TabIndex = 14
        '
        'lblTypeOfService
        '
        Me.lblTypeOfService.AutoSize = True
        Me.lblTypeOfService.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTypeOfService.Location = New System.Drawing.Point(28, 222)
        Me.lblTypeOfService.Name = "lblTypeOfService"
        Me.lblTypeOfService.Size = New System.Drawing.Size(121, 21)
        Me.lblTypeOfService.TabIndex = 13
        Me.lblTypeOfService.Text = "Type of Service"
        '
        'txtBoxPhoneNumber
        '
        Me.txtBoxPhoneNumber.Location = New System.Drawing.Point(196, 179)
        Me.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber"
        Me.txtBoxPhoneNumber.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxPhoneNumber.TabIndex = 12
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(27, 180)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(120, 21)
        Me.lblPhoneNumber.TabIndex = 11
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtBoxLocation
        '
        Me.txtBoxLocation.Location = New System.Drawing.Point(196, 137)
        Me.txtBoxLocation.Name = "txtBoxLocation"
        Me.txtBoxLocation.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxLocation.TabIndex = 10
        '
        'lblCustomerLocation
        '
        Me.lblCustomerLocation.AutoSize = True
        Me.lblCustomerLocation.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerLocation.Location = New System.Drawing.Point(28, 135)
        Me.lblCustomerLocation.Name = "lblCustomerLocation"
        Me.lblCustomerLocation.Size = New System.Drawing.Size(73, 21)
        Me.lblCustomerLocation.TabIndex = 9
        Me.lblCustomerLocation.Text = "Location"
        '
        'txtBoxCustomerName
        '
        Me.txtBoxCustomerName.Location = New System.Drawing.Point(196, 91)
        Me.txtBoxCustomerName.Name = "txtBoxCustomerName"
        Me.txtBoxCustomerName.Size = New System.Drawing.Size(214, 23)
        Me.txtBoxCustomerName.TabIndex = 8
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(28, 91)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(53, 21)
        Me.lblCustomerName.TabIndex = 7
        Me.lblCustomerName.Text = "Name"
        '
        'pnlTopCustomersEntry
        '
        Me.pnlTopCustomersEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.pnlTopCustomersEntry.Controls.Add(Me.picBoxRegUserClose)
        Me.pnlTopCustomersEntry.Controls.Add(Me.lblCustomers)
        Me.pnlTopCustomersEntry.Controls.Add(Me.picBoxCustomersEntryAthena)
        Me.pnlTopCustomersEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopCustomersEntry.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopCustomersEntry.Name = "pnlTopCustomersEntry"
        Me.pnlTopCustomersEntry.Size = New System.Drawing.Size(439, 57)
        Me.pnlTopCustomersEntry.TabIndex = 0
        '
        'picBoxRegUserClose
        '
        Me.picBoxRegUserClose.Image = CType(resources.GetObject("picBoxRegUserClose.Image"), System.Drawing.Image)
        Me.picBoxRegUserClose.Location = New System.Drawing.Point(377, 2)
        Me.picBoxRegUserClose.Name = "picBoxRegUserClose"
        Me.picBoxRegUserClose.Size = New System.Drawing.Size(57, 54)
        Me.picBoxRegUserClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxRegUserClose.TabIndex = 3
        Me.picBoxRegUserClose.TabStop = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomers.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCustomers.Location = New System.Drawing.Point(148, 12)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(182, 32)
        Me.lblCustomers.TabIndex = 2
        Me.lblCustomers.Text = "Customer Entry"
        '
        'picBoxCustomersEntryAthena
        '
        Me.picBoxCustomersEntryAthena.Image = CType(resources.GetObject("picBoxCustomersEntryAthena.Image"), System.Drawing.Image)
        Me.picBoxCustomersEntryAthena.Location = New System.Drawing.Point(-3, -4)
        Me.picBoxCustomersEntryAthena.Name = "picBoxCustomersEntryAthena"
        Me.picBoxCustomersEntryAthena.Size = New System.Drawing.Size(102, 66)
        Me.picBoxCustomersEntryAthena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxCustomersEntryAthena.TabIndex = 1
        Me.picBoxCustomersEntryAthena.TabStop = False
        '
        'frmCustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 755)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlCustomerEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerEntry"
        Me.pnlCustomerEntry.ResumeLayout(False)
        Me.pnlCustomerEntry.PerformLayout()
        Me.pnlTopCustomersEntry.ResumeLayout(False)
        Me.pnlTopCustomersEntry.PerformLayout()
        CType(Me.picBoxRegUserClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxCustomersEntryAthena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCustomerEntry As Panel
    Friend WithEvents pnlTopCustomersEntry As Panel
    Friend WithEvents picBoxCustomersEntryAthena As PictureBox
    Friend WithEvents lblCustomers As Label
    Friend WithEvents picBoxRegUserClose As PictureBox
    Friend WithEvents txtBoxPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtBoxLocation As TextBox
    Friend WithEvents lblCustomerLocation As Label
    Friend WithEvents txtBoxCustomerName As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtBoxOrders As TextBox
    Friend WithEvents lblOrders As Label
    Friend WithEvents txtBoxQty As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents txtBoxServiceType As TextBox
    Friend WithEvents lblTypeOfService As Label
    Friend WithEvents txtModeOfPayment As TextBox
    Friend WithEvents lblModeOfPayment As Label
    Friend WithEvents txtBoxReceiveDate As TextBox
    Friend WithEvents lblReceiveDate As Label
    Friend WithEvents txtBoxDateOrder As TextBox
    Friend WithEvents lblDateOfOrder As Label
    Friend WithEvents txtBoxFullyPaidDate As TextBox
    Friend WithEvents lblFullyPaidDate As Label
    Friend WithEvents txtBoxDateDeposit As TextBox
    Friend WithEvents lblDepositDate As Label
    Friend WithEvents btnCustomersCancel As Button
    Friend WithEvents btnCustomersSave As Button
End Class
