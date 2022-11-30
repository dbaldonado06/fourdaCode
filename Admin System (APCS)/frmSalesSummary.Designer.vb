<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesSummary))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picBoxSalesRecordClose = New System.Windows.Forms.PictureBox()
        Me.dataGridViewBestSelling = New System.Windows.Forms.DataGridView()
        Me.colSalesRecordsBlank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryYearly = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryYearlyTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryQuarter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryQuarterTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryMonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryMonthTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryDaily = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSummaryDailyTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSalesSummary = New System.Windows.Forms.Label()
        CType(Me.picBoxSalesRecordClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewBestSelling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxSalesRecordClose
        '
        Me.picBoxSalesRecordClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxSalesRecordClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBoxSalesRecordClose.Image = CType(resources.GetObject("picBoxSalesRecordClose.Image"), System.Drawing.Image)
        Me.picBoxSalesRecordClose.Location = New System.Drawing.Point(1041, 12)
        Me.picBoxSalesRecordClose.Name = "picBoxSalesRecordClose"
        Me.picBoxSalesRecordClose.Size = New System.Drawing.Size(24, 24)
        Me.picBoxSalesRecordClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxSalesRecordClose.TabIndex = 6
        Me.picBoxSalesRecordClose.TabStop = False
        '
        'dataGridViewBestSelling
        '
        Me.dataGridViewBestSelling.AllowUserToAddRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.dataGridViewBestSelling.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dataGridViewBestSelling.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewBestSelling.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewBestSelling.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dataGridViewBestSelling.ColumnHeadersHeight = 30
        Me.dataGridViewBestSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridViewBestSelling.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSalesRecordsBlank, Me.colSalesSummaryYearly, Me.colSalesSummaryYearlyTotal})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewBestSelling.DefaultCellStyle = DataGridViewCellStyle20
        Me.dataGridViewBestSelling.EnableHeadersVisualStyles = False
        Me.dataGridViewBestSelling.Location = New System.Drawing.Point(35, 91)
        Me.dataGridViewBestSelling.Name = "dataGridViewBestSelling"
        Me.dataGridViewBestSelling.RowHeadersVisible = False
        Me.dataGridViewBestSelling.RowTemplate.Height = 25
        Me.dataGridViewBestSelling.Size = New System.Drawing.Size(247, 683)
        Me.dataGridViewBestSelling.TabIndex = 20
        '
        'colSalesRecordsBlank
        '
        Me.colSalesRecordsBlank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesRecordsBlank.HeaderText = "#"
        Me.colSalesRecordsBlank.Name = "colSalesRecordsBlank"
        Me.colSalesRecordsBlank.Width = 39
        '
        'colSalesSummaryYearly
        '
        Me.colSalesSummaryYearly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesSummaryYearly.HeaderText = "Year"
        Me.colSalesSummaryYearly.Name = "colSalesSummaryYearly"
        '
        'colSalesSummaryYearlyTotal
        '
        Me.colSalesSummaryYearlyTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSalesSummaryYearlyTotal.DefaultCellStyle = DataGridViewCellStyle19
        Me.colSalesSummaryYearlyTotal.HeaderText = "Total"
        Me.colSalesSummaryYearlyTotal.Name = "colSalesSummaryYearlyTotal"
        Me.colSalesSummaryYearlyTotal.Width = 58
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colSalesSummaryQuarter, Me.colSalesSummaryQuarterTotal})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(288, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(247, 683)
        Me.DataGridView1.TabIndex = 21
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.colSalesSummaryMonth, Me.colSalesSummaryMonthTotal})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(541, 91)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(247, 683)
        Me.DataGridView2.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'colSalesSummaryQuarter
        '
        Me.colSalesSummaryQuarter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesSummaryQuarter.HeaderText = "Quarter"
        Me.colSalesSummaryQuarter.Name = "colSalesSummaryQuarter"
        '
        'colSalesSummaryQuarterTotal
        '
        Me.colSalesSummaryQuarterTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSalesSummaryQuarterTotal.DefaultCellStyle = DataGridViewCellStyle23
        Me.colSalesSummaryQuarterTotal.HeaderText = "Total"
        Me.colSalesSummaryQuarterTotal.Name = "colSalesSummaryQuarterTotal"
        Me.colSalesSummaryQuarterTotal.Width = 58
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "#"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 39
        '
        'colSalesSummaryMonth
        '
        Me.colSalesSummaryMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesSummaryMonth.HeaderText = "Month"
        Me.colSalesSummaryMonth.Name = "colSalesSummaryMonth"
        '
        'colSalesSummaryMonthTotal
        '
        Me.colSalesSummaryMonthTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSalesSummaryMonthTotal.DefaultCellStyle = DataGridViewCellStyle27
        Me.colSalesSummaryMonthTotal.HeaderText = "Total"
        Me.colSalesSummaryMonthTotal.Name = "colSalesSummaryMonthTotal"
        Me.colSalesSummaryMonthTotal.Width = 58
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridView3.ColumnHeadersHeight = 30
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.colSalesSummaryDaily, Me.colSalesSummaryDailyTotal})
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.Location = New System.Drawing.Point(794, 91)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowTemplate.Height = 25
        Me.DataGridView3.Size = New System.Drawing.Size(247, 683)
        Me.DataGridView3.TabIndex = 23
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 39
        '
        'colSalesSummaryDaily
        '
        Me.colSalesSummaryDaily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesSummaryDaily.HeaderText = "Daily"
        Me.colSalesSummaryDaily.Name = "colSalesSummaryDaily"
        '
        'colSalesSummaryDailyTotal
        '
        Me.colSalesSummaryDailyTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSalesSummaryDailyTotal.DefaultCellStyle = DataGridViewCellStyle31
        Me.colSalesSummaryDailyTotal.HeaderText = "Total"
        Me.colSalesSummaryDailyTotal.Name = "colSalesSummaryDailyTotal"
        Me.colSalesSummaryDailyTotal.Width = 58
        '
        'lblSalesSummary
        '
        Me.lblSalesSummary.AutoSize = True
        Me.lblSalesSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblSalesSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSalesSummary.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSalesSummary.ForeColor = System.Drawing.Color.White
        Me.lblSalesSummary.Location = New System.Drawing.Point(0, 4)
        Me.lblSalesSummary.Name = "lblSalesSummary"
        Me.lblSalesSummary.Size = New System.Drawing.Size(203, 37)
        Me.lblSalesSummary.TabIndex = 24
        Me.lblSalesSummary.Text = "Sales Summary"
        '
        'frmSalesSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSalesSummary)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dataGridViewBestSelling)
        Me.Controls.Add(Me.picBoxSalesRecordClose)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSalesSummary"
        CType(Me.picBoxSalesRecordClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewBestSelling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxSalesRecordClose As PictureBox
    Friend WithEvents dataGridViewBestSelling As DataGridView
    Friend WithEvents colSalesRecordsBlank As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryYearly As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryYearlyTotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryQuarter As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryQuarterTotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryMonth As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryMonthTotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryDaily As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSummaryDailyTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblSalesSummary As Label
End Class
