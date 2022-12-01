<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewSalesDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewSalesDetails))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolStripSalesDetails = New System.Windows.Forms.ToolStrip()
        Me.toolStripViewSalesDetails = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripSalesDetailsClose = New System.Windows.Forms.ToolStripButton()
        Me.dataGridViewPOSSalesDetails = New System.Windows.Forms.DataGridView()
        Me.pnlViewDetails = New System.Windows.Forms.Panel()
        Me.colFrmDailySalesBlank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmDailySalesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmDailySalesTransNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmDailySalesDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmDailySalesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmDailySalesQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmDailySalesTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalDailySales = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripSalesDetails.SuspendLayout()
        CType(Me.dataGridViewPOSSalesDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStripSalesDetails
        '
        Me.toolStripSalesDetails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripViewSalesDetails, Me.toolStripSalesDetailsClose, Me.lblTotalDailySales})
        Me.toolStripSalesDetails.Location = New System.Drawing.Point(0, 0)
        Me.toolStripSalesDetails.Name = "toolStripSalesDetails"
        Me.toolStripSalesDetails.Size = New System.Drawing.Size(1077, 25)
        Me.toolStripSalesDetails.TabIndex = 5
        Me.toolStripSalesDetails.Text = "ToolStrip1"
        '
        'toolStripViewSalesDetails
        '
        Me.toolStripViewSalesDetails.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.toolStripViewSalesDetails.Name = "toolStripViewSalesDetails"
        Me.toolStripViewSalesDetails.Size = New System.Drawing.Size(91, 22)
        Me.toolStripViewSalesDetails.Text = "SALES DETAILS"
        '
        'toolStripSalesDetailsClose
        '
        Me.toolStripSalesDetailsClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolStripSalesDetailsClose.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.toolStripSalesDetailsClose.Image = CType(resources.GetObject("toolStripSalesDetailsClose.Image"), System.Drawing.Image)
        Me.toolStripSalesDetailsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSalesDetailsClose.Name = "toolStripSalesDetailsClose"
        Me.toolStripSalesDetailsClose.Size = New System.Drawing.Size(55, 22)
        Me.toolStripSalesDetailsClose.Text = "Close"
        '
        'dataGridViewPOSSalesDetails
        '
        Me.dataGridViewPOSSalesDetails.AllowUserToAddRows = False
        Me.dataGridViewPOSSalesDetails.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPOSSalesDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewPOSSalesDetails.ColumnHeadersHeight = 30
        Me.dataGridViewPOSSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewPOSSalesDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFrmDailySalesBlank, Me.colFrmDailySalesID, Me.colFrmDailySalesTransNo, Me.colFrmDailySalesDescription, Me.colFrmDailySalesPrice, Me.colFrmDailySalesQty, Me.colFrmDailySalesTotal})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPOSSalesDetails.DefaultCellStyle = DataGridViewCellStyle10
        Me.dataGridViewPOSSalesDetails.EnableHeadersVisualStyles = False
        Me.dataGridViewPOSSalesDetails.Location = New System.Drawing.Point(12, 41)
        Me.dataGridViewPOSSalesDetails.Name = "dataGridViewPOSSalesDetails"
        Me.dataGridViewPOSSalesDetails.RowHeadersVisible = False
        Me.dataGridViewPOSSalesDetails.RowTemplate.Height = 25
        Me.dataGridViewPOSSalesDetails.Size = New System.Drawing.Size(1055, 733)
        Me.dataGridViewPOSSalesDetails.TabIndex = 6
        '
        'pnlViewDetails
        '
        Me.pnlViewDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewDetails.Location = New System.Drawing.Point(0, 0)
        Me.pnlViewDetails.Name = "pnlViewDetails"
        Me.pnlViewDetails.Size = New System.Drawing.Size(1077, 786)
        Me.pnlViewDetails.TabIndex = 7
        '
        'colFrmDailySalesBlank
        '
        Me.colFrmDailySalesBlank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFrmDailySalesBlank.HeaderText = "#"
        Me.colFrmDailySalesBlank.Name = "colFrmDailySalesBlank"
        Me.colFrmDailySalesBlank.Width = 39
        '
        'colFrmDailySalesID
        '
        Me.colFrmDailySalesID.HeaderText = "ID"
        Me.colFrmDailySalesID.Name = "colFrmDailySalesID"
        Me.colFrmDailySalesID.Visible = False
        '
        'colFrmDailySalesTransNo
        '
        Me.colFrmDailySalesTransNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFrmDailySalesTransNo.HeaderText = "Transaction No"
        Me.colFrmDailySalesTransNo.Name = "colFrmDailySalesTransNo"
        Me.colFrmDailySalesTransNo.Width = 111
        '
        'colFrmDailySalesDescription
        '
        Me.colFrmDailySalesDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFrmDailySalesDescription.HeaderText = "Description"
        Me.colFrmDailySalesDescription.Name = "colFrmDailySalesDescription"
        '
        'colFrmDailySalesPrice
        '
        Me.colFrmDailySalesPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colFrmDailySalesPrice.DefaultCellStyle = DataGridViewCellStyle7
        Me.colFrmDailySalesPrice.HeaderText = "Price"
        Me.colFrmDailySalesPrice.Name = "colFrmDailySalesPrice"
        Me.colFrmDailySalesPrice.Width = 58
        '
        'colFrmDailySalesQty
        '
        Me.colFrmDailySalesQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFrmDailySalesQty.DefaultCellStyle = DataGridViewCellStyle8
        Me.colFrmDailySalesQty.HeaderText = "Qty (per person/pax)"
        Me.colFrmDailySalesQty.Name = "colFrmDailySalesQty"
        Me.colFrmDailySalesQty.Width = 142
        '
        'colFrmDailySalesTotal
        '
        Me.colFrmDailySalesTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colFrmDailySalesTotal.DefaultCellStyle = DataGridViewCellStyle9
        Me.colFrmDailySalesTotal.HeaderText = "Total"
        Me.colFrmDailySalesTotal.Name = "colFrmDailySalesTotal"
        Me.colFrmDailySalesTotal.Width = 57
        '
        'lblTotalDailySales
        '
        Me.lblTotalDailySales.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTotalDailySales.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalDailySales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lblTotalDailySales.Name = "lblTotalDailySales"
        Me.lblTotalDailySales.Size = New System.Drawing.Size(37, 22)
        Me.lblTotalDailySales.Text = "0.00"
        '
        'frmViewSalesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.toolStripSalesDetails)
        Me.Controls.Add(Me.dataGridViewPOSSalesDetails)
        Me.Controls.Add(Me.pnlViewDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmViewSalesDetails"
        Me.toolStripSalesDetails.ResumeLayout(False)
        Me.toolStripSalesDetails.PerformLayout()
        CType(Me.dataGridViewPOSSalesDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolStripSalesDetails As ToolStrip
    Friend WithEvents toolStripViewSalesDetails As ToolStripLabel
    Friend WithEvents toolStripSalesDetailsClose As ToolStripButton
    Friend WithEvents dataGridViewPOSSalesDetails As DataGridView
    Friend WithEvents pnlViewDetails As Panel
    Friend WithEvents colFrmDailySalesBlank As DataGridViewTextBoxColumn
    Friend WithEvents colFrmDailySalesID As DataGridViewTextBoxColumn
    Friend WithEvents colFrmDailySalesTransNo As DataGridViewTextBoxColumn
    Friend WithEvents colFrmDailySalesDescription As DataGridViewTextBoxColumn
    Friend WithEvents colFrmDailySalesPrice As DataGridViewTextBoxColumn
    Friend WithEvents colFrmDailySalesQty As DataGridViewTextBoxColumn
    Friend WithEvents colFrmDailySalesTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalDailySales As ToolStripLabel
End Class
