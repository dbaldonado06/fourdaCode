<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMenuList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductMenuList))
        Me.pnlProductMenuList = New System.Windows.Forms.Panel()
        Me.dataGridViewProductMenuList = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditProducMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDeleteProductMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripProductList = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripProductListClose = New System.Windows.Forms.ToolStripButton()
        Me.toolStripProductListCreate = New System.Windows.Forms.ToolStripButton()
        Me.pnlMainProductMenuList = New System.Windows.Forms.Panel()
        Me.pnlProductMenuList.SuspendLayout()
        CType(Me.dataGridViewProductMenuList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlProductMenuList
        '
        Me.pnlProductMenuList.Controls.Add(Me.dataGridViewProductMenuList)
        Me.pnlProductMenuList.Controls.Add(Me.ToolStrip1)
        Me.pnlProductMenuList.Controls.Add(Me.pnlMainProductMenuList)
        Me.pnlProductMenuList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProductMenuList.Location = New System.Drawing.Point(0, 0)
        Me.pnlProductMenuList.Name = "pnlProductMenuList"
        Me.pnlProductMenuList.Size = New System.Drawing.Size(1079, 788)
        Me.pnlProductMenuList.TabIndex = 0
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
        Me.dataGridViewProductMenuList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8, Me.Column6, Me.Column9, Me.colEditProducMenu, Me.colDeleteProductMenu})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewProductMenuList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewProductMenuList.EnableHeadersVisualStyles = False
        Me.dataGridViewProductMenuList.Location = New System.Drawing.Point(12, 28)
        Me.dataGridViewProductMenuList.Name = "dataGridViewProductMenuList"
        Me.dataGridViewProductMenuList.RowHeadersVisible = False
        Me.dataGridViewProductMenuList.RowTemplate.Height = 25
        Me.dataGridViewProductMenuList.Size = New System.Drawing.Size(1055, 733)
        Me.dataGridViewProductMenuList.TabIndex = 4
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 39
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Category"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 79
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "Qty (per person/pax)"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 142
        '
        'Column8
        '
        Me.Column8.HeaderText = "Price Per Pack"
        Me.Column8.Name = "Column8"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Image"
        Me.Column6.Name = "Column6"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Status"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 65
        '
        'colEditProducMenu
        '
        Me.colEditProducMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditProducMenu.HeaderText = ""
        Me.colEditProducMenu.Name = "colEditProducMenu"
        Me.colEditProducMenu.Width = 5
        '
        'colDeleteProductMenu
        '
        Me.colDeleteProductMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDeleteProductMenu.HeaderText = ""
        Me.colDeleteProductMenu.Name = "colDeleteProductMenu"
        Me.colDeleteProductMenu.Width = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripProductList, Me.toolStripProductListClose, Me.toolStripProductListCreate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1079, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripProductList
        '
        Me.toolStripProductList.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.toolStripProductList.Name = "toolStripProductList"
        Me.toolStripProductList.Size = New System.Drawing.Size(88, 22)
        Me.toolStripProductList.Text = "PRODUCT LIST"
        '
        'toolStripProductListClose
        '
        Me.toolStripProductListClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolStripProductListClose.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.toolStripProductListClose.Image = CType(resources.GetObject("toolStripProductListClose.Image"), System.Drawing.Image)
        Me.toolStripProductListClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripProductListClose.Name = "toolStripProductListClose"
        Me.toolStripProductListClose.Size = New System.Drawing.Size(55, 22)
        Me.toolStripProductListClose.Text = "Close"
        '
        'toolStripProductListCreate
        '
        Me.toolStripProductListCreate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolStripProductListCreate.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.toolStripProductListCreate.Image = CType(resources.GetObject("toolStripProductListCreate.Image"), System.Drawing.Image)
        Me.toolStripProductListCreate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripProductListCreate.Name = "toolStripProductListCreate"
        Me.toolStripProductListCreate.Size = New System.Drawing.Size(87, 22)
        Me.toolStripProductListCreate.Text = "Create New"
        '
        'pnlMainProductMenuList
        '
        Me.pnlMainProductMenuList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMainProductMenuList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainProductMenuList.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainProductMenuList.Name = "pnlMainProductMenuList"
        Me.pnlMainProductMenuList.Size = New System.Drawing.Size(1079, 788)
        Me.pnlMainProductMenuList.TabIndex = 5
        '
        'frmProductMenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlProductMenuList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductMenuList"
        Me.Text = "frmProductMenuList"
        Me.pnlProductMenuList.ResumeLayout(False)
        Me.pnlProductMenuList.PerformLayout()
        CType(Me.dataGridViewProductMenuList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProductMenuList As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolStripProductList As ToolStripLabel
    Friend WithEvents toolStripProductListClose As ToolStripButton
    Friend WithEvents toolStripProductListCreate As ToolStripButton
    Friend WithEvents pnlMainProductMenuList As Panel
    Friend WithEvents dataGridViewProductMenuList As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents colEditProducMenu As DataGridViewImageColumn
    Friend WithEvents colDeleteProductMenu As DataGridViewImageColumn
End Class
