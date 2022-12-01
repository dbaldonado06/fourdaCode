<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrders))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOrdersOrderNo = New System.Windows.Forms.Label()
        Me.txtOrdersOrderNo = New System.Windows.Forms.TextBox()
        Me.pnlOrders = New System.Windows.Forms.Panel()
        Me.dataGridViewPOSOrders = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditProducMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDeleteProductMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnOrdersCancel = New System.Windows.Forms.Button()
        Me.btnOrdersUpdate = New System.Windows.Forms.Button()
        Me.btnOrdersSave = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlOrders.SuspendLayout()
        CType(Me.dataGridViewPOSOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Orders"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel2.Text = "Close"
        '
        'lblOrdersOrderNo
        '
        Me.lblOrdersOrderNo.AutoSize = True
        Me.lblOrdersOrderNo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrdersOrderNo.Location = New System.Drawing.Point(15, 403)
        Me.lblOrdersOrderNo.Name = "lblOrdersOrderNo"
        Me.lblOrdersOrderNo.Size = New System.Drawing.Size(59, 15)
        Me.lblOrdersOrderNo.TabIndex = 4
        Me.lblOrdersOrderNo.Text = "Order No."
        '
        'txtOrdersOrderNo
        '
        Me.txtOrdersOrderNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtOrdersOrderNo.Location = New System.Drawing.Point(79, 398)
        Me.txtOrdersOrderNo.Name = "txtOrdersOrderNo"
        Me.txtOrdersOrderNo.Size = New System.Drawing.Size(388, 23)
        Me.txtOrdersOrderNo.TabIndex = 5
        '
        'pnlOrders
        '
        Me.pnlOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrders.Controls.Add(Me.dataGridViewPOSOrders)
        Me.pnlOrders.Controls.Add(Me.btnOrdersCancel)
        Me.pnlOrders.Controls.Add(Me.btnOrdersUpdate)
        Me.pnlOrders.Controls.Add(Me.btnOrdersSave)
        Me.pnlOrders.Controls.Add(Me.txtOrdersOrderNo)
        Me.pnlOrders.Controls.Add(Me.lblOrdersOrderNo)
        Me.pnlOrders.Controls.Add(Me.ToolStrip1)
        Me.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOrders.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrders.Name = "pnlOrders"
        Me.pnlOrders.Size = New System.Drawing.Size(969, 451)
        Me.pnlOrders.TabIndex = 0
        '
        'dataGridViewPOSOrders
        '
        Me.dataGridViewPOSOrders.AllowUserToAddRows = False
        Me.dataGridViewPOSOrders.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPOSOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewPOSOrders.ColumnHeadersHeight = 30
        Me.dataGridViewPOSOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewPOSOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column2, Me.colEditProducMenu, Me.colDeleteProductMenu})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPOSOrders.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewPOSOrders.EnableHeadersVisualStyles = False
        Me.dataGridViewPOSOrders.Location = New System.Drawing.Point(12, 30)
        Me.dataGridViewPOSOrders.Name = "dataGridViewPOSOrders"
        Me.dataGridViewPOSOrders.RowHeadersVisible = False
        Me.dataGridViewPOSOrders.RowTemplate.Height = 25
        Me.dataGridViewPOSOrders.Size = New System.Drawing.Size(945, 334)
        Me.dataGridViewPOSOrders.TabIndex = 15
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Orders"
        Me.Column2.Name = "Column2"
        '
        'colEditProducMenu
        '
        Me.colEditProducMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditProducMenu.HeaderText = ""
        Me.colEditProducMenu.Image = CType(resources.GetObject("colEditProducMenu.Image"), System.Drawing.Image)
        Me.colEditProducMenu.Name = "colEditProducMenu"
        Me.colEditProducMenu.Width = 5
        '
        'colDeleteProductMenu
        '
        Me.colDeleteProductMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDeleteProductMenu.HeaderText = ""
        Me.colDeleteProductMenu.Image = CType(resources.GetObject("colDeleteProductMenu.Image"), System.Drawing.Image)
        Me.colDeleteProductMenu.Name = "colDeleteProductMenu"
        Me.colDeleteProductMenu.Width = 5
        '
        'btnOrdersCancel
        '
        Me.btnOrdersCancel.BackColor = System.Drawing.Color.Gray
        Me.btnOrdersCancel.FlatAppearance.BorderSize = 0
        Me.btnOrdersCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersCancel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrdersCancel.ForeColor = System.Drawing.Color.Black
        Me.btnOrdersCancel.Location = New System.Drawing.Point(660, 398)
        Me.btnOrdersCancel.Name = "btnOrdersCancel"
        Me.btnOrdersCancel.Size = New System.Drawing.Size(91, 23)
        Me.btnOrdersCancel.TabIndex = 14
        Me.btnOrdersCancel.Text = "CANCEL"
        Me.btnOrdersCancel.UseVisualStyleBackColor = False
        '
        'btnOrdersUpdate
        '
        Me.btnOrdersUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOrdersUpdate.FlatAppearance.BorderSize = 0
        Me.btnOrdersUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrdersUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOrdersUpdate.Location = New System.Drawing.Point(568, 398)
        Me.btnOrdersUpdate.Name = "btnOrdersUpdate"
        Me.btnOrdersUpdate.Size = New System.Drawing.Size(91, 23)
        Me.btnOrdersUpdate.TabIndex = 13
        Me.btnOrdersUpdate.Text = "UPDATE"
        Me.btnOrdersUpdate.UseVisualStyleBackColor = False
        '
        'btnOrdersSave
        '
        Me.btnOrdersSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOrdersSave.FlatAppearance.BorderSize = 0
        Me.btnOrdersSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersSave.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrdersSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOrdersSave.Location = New System.Drawing.Point(476, 398)
        Me.btnOrdersSave.Name = "btnOrdersSave"
        Me.btnOrdersSave.Size = New System.Drawing.Size(91, 23)
        Me.btnOrdersSave.TabIndex = 12
        Me.btnOrdersSave.Text = "SAVE"
        Me.btnOrdersSave.UseVisualStyleBackColor = False
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(969, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrders"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlOrders.ResumeLayout(False)
        Me.pnlOrders.PerformLayout()
        CType(Me.dataGridViewPOSOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblOrdersOrderNo As Label
    Friend WithEvents txtOrdersOrderNo As TextBox
    Friend WithEvents pnlOrders As Panel
    Friend WithEvents btnOrdersSave As Button
    Friend WithEvents btnOrdersUpdate As Button
    Friend WithEvents btnOrdersCancel As Button
    Friend WithEvents dataGridViewPOSOrders As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents colEditProducMenu As DataGridViewImageColumn
    Friend WithEvents colDeleteProductMenu As DataGridViewImageColumn
End Class
