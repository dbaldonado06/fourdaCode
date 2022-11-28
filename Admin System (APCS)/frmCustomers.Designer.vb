<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Me.pnlCustomers = New System.Windows.Forms.Panel()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.dataGridViewUserfrm = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picBoxCustomers = New System.Windows.Forms.PictureBox()
        Me.pnlCustomers.SuspendLayout()
        CType(Me.dataGridViewUserfrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustomers
        '
        Me.pnlCustomers.Controls.Add(Me.picBoxCustomers)
        Me.pnlCustomers.Controls.Add(Me.lblCustomers)
        Me.pnlCustomers.Controls.Add(Me.dataGridViewUserfrm)
        Me.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomers.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustomers.Name = "pnlCustomers"
        Me.pnlCustomers.Size = New System.Drawing.Size(1079, 788)
        Me.pnlCustomers.TabIndex = 0
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCustomers.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomers.ForeColor = System.Drawing.Color.White
        Me.lblCustomers.Location = New System.Drawing.Point(0, 9)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(148, 37)
        Me.lblCustomers.TabIndex = 4
        Me.lblCustomers.Text = "Customers"
        '
        'dataGridViewUserfrm
        '
        Me.dataGridViewUserfrm.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dataGridViewUserfrm.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewUserfrm.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewUserfrm.ColumnHeadersHeight = 30
        Me.dataGridViewUserfrm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewUserfrm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dataGridViewUserfrm.Location = New System.Drawing.Point(25, 139)
        Me.dataGridViewUserfrm.Name = "dataGridViewUserfrm"
        Me.dataGridViewUserfrm.RowTemplate.Height = 25
        Me.dataGridViewUserfrm.Size = New System.Drawing.Size(1020, 450)
        Me.dataGridViewUserfrm.TabIndex = 3
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 64
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Location"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 78
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Phone Number"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "Service Type"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 96
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.HeaderText = "QTY"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 53
        '
        'Column9
        '
        Me.Column9.HeaderText = "Receive Date"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Payment"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Date Deposit"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Fully Paid Date"
        Me.Column12.Name = "Column12"
        '
        'picBoxCustomers
        '
        Me.picBoxCustomers.Image = CType(resources.GetObject("picBoxCustomers.Image"), System.Drawing.Image)
        Me.picBoxCustomers.Location = New System.Drawing.Point(999, 12)
        Me.picBoxCustomers.Name = "picBoxCustomers"
        Me.picBoxCustomers.Size = New System.Drawing.Size(46, 46)
        Me.picBoxCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxCustomers.TabIndex = 5
        Me.picBoxCustomers.TabStop = False
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlCustomers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomers"
        Me.Text = "frmCustomers"
        Me.pnlCustomers.ResumeLayout(False)
        Me.pnlCustomers.PerformLayout()
        CType(Me.dataGridViewUserfrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCustomers As Panel
    Friend WithEvents lblCustomers As Label
    Friend WithEvents dataGridViewUserfrm As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents picBoxCustomers As PictureBox
End Class
