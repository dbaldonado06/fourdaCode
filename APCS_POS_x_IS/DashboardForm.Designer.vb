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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.dataGridViewDashboardBestSellers = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDashboardBestSelling = New System.Windows.Forms.Label()
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
        Me.dashboardPanel.Size = New System.Drawing.Size(1005, 788)
        Me.dashboardPanel.TabIndex = 0
        '
        'dataGridViewDashboardBestSellers
        '
        Me.dataGridViewDashboardBestSellers.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGridViewDashboardBestSellers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewDashboardBestSellers.BackgroundColor = System.Drawing.Color.White
        Me.dataGridViewDashboardBestSellers.ColumnHeadersHeight = 30
        Me.dataGridViewDashboardBestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewDashboardBestSellers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewDashboardBestSellers.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewDashboardBestSellers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewDashboardBestSellers.EnableHeadersVisualStyles = False
        Me.dataGridViewDashboardBestSellers.Location = New System.Drawing.Point(0, 37)
        Me.dataGridViewDashboardBestSellers.Name = "dataGridViewDashboardBestSellers"
        Me.dataGridViewDashboardBestSellers.RowTemplate.Height = 25
        Me.dataGridViewDashboardBestSellers.Size = New System.Drawing.Size(1005, 751)
        Me.dataGridViewDashboardBestSellers.TabIndex = 13
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
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 5
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 58
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Orders"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'lblDashboardBestSelling
        '
        Me.lblDashboardBestSelling.AutoSize = True
        Me.lblDashboardBestSelling.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblDashboardBestSelling.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDashboardBestSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDashboardBestSelling.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDashboardBestSelling.ForeColor = System.Drawing.Color.White
        Me.lblDashboardBestSelling.Image = CType(resources.GetObject("lblDashboardBestSelling.Image"), System.Drawing.Image)
        Me.lblDashboardBestSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDashboardBestSelling.Location = New System.Drawing.Point(0, 0)
        Me.lblDashboardBestSelling.Name = "lblDashboardBestSelling"
        Me.lblDashboardBestSelling.Size = New System.Drawing.Size(266, 37)
        Me.lblDashboardBestSelling.TabIndex = 12
        Me.lblDashboardBestSelling.Text = "     Top 5 Best Selling"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1005, 788)
        Me.Controls.Add(Me.dashboardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.dashboardPanel.ResumeLayout(False)
        Me.dashboardPanel.PerformLayout()
        CType(Me.dataGridViewDashboardBestSellers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents dataGridViewDashboardBestSellers As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lblDashboardBestSelling As Label
End Class
