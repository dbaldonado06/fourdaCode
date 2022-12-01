<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.dataGridViewDashboardBestSellers = New System.Windows.Forms.DataGridView()
        Me.lblDashboardBestSelling = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dashboardPanel.SuspendLayout()
        CType(Me.dataGridViewDashboardBestSellers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboardPanel
        '
        Me.dashboardPanel.BackColor = System.Drawing.Color.White
        Me.dashboardPanel.Controls.Add(Me.dataGridViewDashboardBestSellers)
        Me.dashboardPanel.Controls.Add(Me.lblDashboardBestSelling)
        Me.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardPanel.Location = New System.Drawing.Point(0, 0)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.Size = New System.Drawing.Size(1079, 788)
        Me.dashboardPanel.TabIndex = 0
        '
        'dataGridViewDashboardBestSellers
        '
        Me.dataGridViewDashboardBestSellers.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGridViewDashboardBestSellers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewDashboardBestSellers.BackgroundColor = System.Drawing.Color.White
        Me.dataGridViewDashboardBestSellers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewDashboardBestSellers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dataGridViewDashboardBestSellers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewDashboardBestSellers.ColumnHeadersHeight = 30
        Me.dataGridViewDashboardBestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewDashboardBestSellers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewDashboardBestSellers.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridViewDashboardBestSellers.EnableHeadersVisualStyles = False
        Me.dataGridViewDashboardBestSellers.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dataGridViewDashboardBestSellers.Location = New System.Drawing.Point(0, 125)
        Me.dataGridViewDashboardBestSellers.Name = "dataGridViewDashboardBestSellers"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewDashboardBestSellers.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewDashboardBestSellers.RowTemplate.Height = 25
        Me.dataGridViewDashboardBestSellers.Size = New System.Drawing.Size(1067, 788)
        Me.dataGridViewDashboardBestSellers.TabIndex = 13
        '
        'lblDashboardBestSelling
        '
        Me.lblDashboardBestSelling.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblDashboardBestSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardBestSelling.Font = New System.Drawing.Font("Yu Gothic UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardBestSelling.ForeColor = System.Drawing.Color.White
        Me.lblDashboardBestSelling.Image = CType(resources.GetObject("lblDashboardBestSelling.Image"), System.Drawing.Image)
        Me.lblDashboardBestSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDashboardBestSelling.Location = New System.Drawing.Point(0, 9)
        Me.lblDashboardBestSelling.Name = "lblDashboardBestSelling"
        Me.lblDashboardBestSelling.Size = New System.Drawing.Size(280, 79)
        Me.lblDashboardBestSelling.TabIndex = 12
        Me.lblDashboardBestSelling.Text = "Top 5 Best Selling"
        Me.lblDashboardBestSelling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 96
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Orders"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 116
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1079, 788)
        Me.Controls.Add(Me.dashboardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.dashboardPanel.ResumeLayout(False)
        CType(Me.dataGridViewDashboardBestSellers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents dataGridViewDashboardBestSellers As DataGridView
    Friend WithEvents lblDashboardBestSelling As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
