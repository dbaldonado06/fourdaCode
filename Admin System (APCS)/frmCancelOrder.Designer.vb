<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelOrder
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelOrder))
        Me.lblCancelOrderClose = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dataGridViewProductMenuList = New System.Windows.Forms.DataGridView()
        Me.colSalesRecordsBlank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsTransNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsOrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesRecordsCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCancel = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dataGridViewProductMenuList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCancelOrderClose
        '
        Me.lblCancelOrderClose.AutoSize = True
        Me.lblCancelOrderClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCancelOrderClose.Location = New System.Drawing.Point(1019, 9)
        Me.lblCancelOrderClose.Name = "lblCancelOrderClose"
        Me.lblCancelOrderClose.Size = New System.Drawing.Size(50, 15)
        Me.lblCancelOrderClose.TabIndex = 5
        Me.lblCancelOrderClose.Text = "[ Close ]"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(7, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(92, 15)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Sold Today as of"
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
        Me.dataGridViewProductMenuList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSalesRecordsBlank, Me.colSalesRecordsTransNumber, Me.colSalesRecordsDescription, Me.colSalesRecordsPrice, Me.colSalesRecordsQty, Me.colSalesRecordsTotal, Me.colSalesRecordsOrderNo, Me.colSalesRecordsCashier, Me.Column1, Me.colCancel})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewProductMenuList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewProductMenuList.EnableHeadersVisualStyles = False
        Me.dataGridViewProductMenuList.Location = New System.Drawing.Point(7, 36)
        Me.dataGridViewProductMenuList.Name = "dataGridViewProductMenuList"
        Me.dataGridViewProductMenuList.RowHeadersVisible = False
        Me.dataGridViewProductMenuList.RowTemplate.Height = 25
        Me.dataGridViewProductMenuList.Size = New System.Drawing.Size(1062, 738)
        Me.dataGridViewProductMenuList.TabIndex = 7
        '
        'colSalesRecordsBlank
        '
        Me.colSalesRecordsBlank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsBlank.HeaderText = "ID"
        Me.colSalesRecordsBlank.Name = "colSalesRecordsBlank"
        Me.colSalesRecordsBlank.Visible = False
        Me.colSalesRecordsBlank.Width = 45
        '
        'colSalesRecordsTransNumber
        '
        Me.colSalesRecordsTransNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsTransNumber.HeaderText = "Transaction No"
        Me.colSalesRecordsTransNumber.Name = "colSalesRecordsTransNumber"
        Me.colSalesRecordsTransNumber.Width = 112
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
        'colCancel
        '
        Me.colCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCancel.HeaderText = ""
        Me.colCancel.Image = CType(resources.GetObject("colCancel.Image"), System.Drawing.Image)
        Me.colCancel.Name = "colCancel"
        Me.colCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCancel.Width = 5
        '
        'frmCancelOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.dataGridViewProductMenuList)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCancelOrderClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCancelOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dataGridViewProductMenuList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCancelOrderClose As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dataGridViewProductMenuList As DataGridView
    Friend WithEvents colSalesRecordsBlank As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsTransNumber As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsDescription As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsQty As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsTotal As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsOrderNo As DataGridViewTextBoxColumn
    Friend WithEvents colSalesRecordsCashier As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colCancel As DataGridViewImageColumn
End Class
