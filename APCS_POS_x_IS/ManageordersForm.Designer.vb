﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageordersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageordersForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtOrdersOrderNo = New System.Windows.Forms.TextBox()
        Me.lblOrdersOrderNo = New System.Windows.Forms.Label()
        Me.pnlOrders = New System.Windows.Forms.Panel()
        Me.dataGridViewPOS = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditProducMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDeleteProductMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnOrdersCancel = New System.Windows.Forms.Button()
        Me.btnOrdersUpdate = New System.Windows.Forms.Button()
        Me.btnOrdersSave = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlOrders.SuspendLayout()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1035, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "Orders"
        '
        'txtOrdersOrderNo
        '
        Me.txtOrdersOrderNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtOrdersOrderNo.Location = New System.Drawing.Point(79, 398)
        Me.txtOrdersOrderNo.Name = "txtOrdersOrderNo"
        Me.txtOrdersOrderNo.Size = New System.Drawing.Size(664, 23)
        Me.txtOrdersOrderNo.TabIndex = 5
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
        'pnlOrders
        '
        Me.pnlOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrders.Controls.Add(Me.dataGridViewPOS)
        Me.pnlOrders.Controls.Add(Me.btnOrdersCancel)
        Me.pnlOrders.Controls.Add(Me.btnOrdersUpdate)
        Me.pnlOrders.Controls.Add(Me.btnOrdersSave)
        Me.pnlOrders.Controls.Add(Me.txtOrdersOrderNo)
        Me.pnlOrders.Controls.Add(Me.lblOrdersOrderNo)
        Me.pnlOrders.Controls.Add(Me.ToolStrip1)
        Me.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOrders.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrders.Name = "pnlOrders"
        Me.pnlOrders.Size = New System.Drawing.Size(1037, 541)
        Me.pnlOrders.TabIndex = 1
        '
        'dataGridViewPOS
        '
        Me.dataGridViewPOS.AllowUserToAddRows = False
        Me.dataGridViewPOS.BackgroundColor = System.Drawing.SystemColors.Control
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
        Me.dataGridViewPOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column2, Me.colEditProducMenu, Me.colDeleteProductMenu})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewPOS.EnableHeadersVisualStyles = False
        Me.dataGridViewPOS.Location = New System.Drawing.Point(12, 30)
        Me.dataGridViewPOS.Name = "dataGridViewPOS"
        Me.dataGridViewPOS.RowHeadersVisible = False
        Me.dataGridViewPOS.RowTemplate.Height = 25
        Me.dataGridViewPOS.Size = New System.Drawing.Size(1012, 334)
        Me.dataGridViewPOS.TabIndex = 15
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
        Me.btnOrdersCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrdersCancel.BackColor = System.Drawing.Color.Gray
        Me.btnOrdersCancel.FlatAppearance.BorderSize = 0
        Me.btnOrdersCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersCancel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrdersCancel.ForeColor = System.Drawing.Color.Black
        Me.btnOrdersCancel.Location = New System.Drawing.Point(933, 395)
        Me.btnOrdersCancel.Name = "btnOrdersCancel"
        Me.btnOrdersCancel.Size = New System.Drawing.Size(91, 23)
        Me.btnOrdersCancel.TabIndex = 14
        Me.btnOrdersCancel.Text = "CANCEL"
        Me.btnOrdersCancel.UseVisualStyleBackColor = False
        '
        'btnOrdersUpdate
        '
        Me.btnOrdersUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrdersUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOrdersUpdate.FlatAppearance.BorderSize = 0
        Me.btnOrdersUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrdersUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOrdersUpdate.Location = New System.Drawing.Point(841, 395)
        Me.btnOrdersUpdate.Name = "btnOrdersUpdate"
        Me.btnOrdersUpdate.Size = New System.Drawing.Size(91, 23)
        Me.btnOrdersUpdate.TabIndex = 13
        Me.btnOrdersUpdate.Text = "UPDATE"
        Me.btnOrdersUpdate.UseVisualStyleBackColor = False
        '
        'btnOrdersSave
        '
        Me.btnOrdersSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrdersSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOrdersSave.FlatAppearance.BorderSize = 0
        Me.btnOrdersSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersSave.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrdersSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOrdersSave.Location = New System.Drawing.Point(749, 395)
        Me.btnOrdersSave.Name = "btnOrdersSave"
        Me.btnOrdersSave.Size = New System.Drawing.Size(91, 23)
        Me.btnOrdersSave.TabIndex = 12
        Me.btnOrdersSave.Text = "SAVE"
        Me.btnOrdersSave.UseVisualStyleBackColor = False
        '
        'ManageordersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 541)
        Me.Controls.Add(Me.pnlOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageordersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageordersForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlOrders.ResumeLayout(False)
        Me.pnlOrders.PerformLayout()
        CType(Me.dataGridViewPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtOrdersOrderNo As TextBox
    Friend WithEvents lblOrdersOrderNo As Label
    Friend WithEvents pnlOrders As Panel
    Friend WithEvents dataGridViewPOS As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents colEditProducMenu As DataGridViewImageColumn
    Friend WithEvents colDeleteProductMenu As DataGridViewImageColumn
    Friend WithEvents btnOrdersCancel As Button
    Friend WithEvents btnOrdersUpdate As Button
    Friend WithEvents btnOrdersSave As Button
End Class