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
        Me.pnlSalesRecords = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSaleRecords = New System.Windows.Forms.Label()
        Me.pnlSalesRecords.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSalesRecords
        '
        Me.pnlSalesRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalesRecords.Controls.Add(Me.DataGridView1)
        Me.pnlSalesRecords.Controls.Add(Me.lblSaleRecords)
        Me.pnlSalesRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSalesRecords.Location = New System.Drawing.Point(0, 0)
        Me.pnlSalesRecords.Name = "pnlSalesRecords"
        Me.pnlSalesRecords.Size = New System.Drawing.Size(1079, 788)
        Me.pnlSalesRecords.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(11, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 672)
        Me.DataGridView1.TabIndex = 4
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
        Me.Column2.HeaderText = "PCode"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 67
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Voucher"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 75
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Total Sales"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 79
        '
        'lblSaleRecords
        '
        Me.lblSaleRecords.AutoSize = True
        Me.lblSaleRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblSaleRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaleRecords.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaleRecords.ForeColor = System.Drawing.Color.White
        Me.lblSaleRecords.Location = New System.Drawing.Point(-1, 11)
        Me.lblSaleRecords.Name = "lblSaleRecords"
        Me.lblSaleRecords.Size = New System.Drawing.Size(184, 37)
        Me.lblSaleRecords.TabIndex = 3
        Me.lblSaleRecords.Text = "Sales Records"
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSalesRecords As Panel
    Friend WithEvents lblSaleRecords As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
