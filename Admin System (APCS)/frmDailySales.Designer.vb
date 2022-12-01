<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySales
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
        Me.pnlSalesReportDaily = New System.Windows.Forms.Panel()
        Me.btnSalesDetails = New System.Windows.Forms.Button()
        Me.lblDailySalesTotalMoney = New System.Windows.Forms.Label()
        Me.lblDailySalesTotal = New System.Windows.Forms.Label()
        Me.lblDailySalesInitialCash = New System.Windows.Forms.Label()
        Me.lblDailySalesInitial = New System.Windows.Forms.Label()
        Me.lblDailySalesMoney = New System.Windows.Forms.Label()
        Me.lblDailySalesSales = New System.Windows.Forms.Label()
        Me.lblDailySalesReportClose = New System.Windows.Forms.Label()
        Me.lblDailySalesReport = New System.Windows.Forms.Label()
        Me.pnlSalesReportDaily.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSalesReportDaily
        '
        Me.pnlSalesReportDaily.Controls.Add(Me.btnSalesDetails)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesTotalMoney)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesTotal)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesInitialCash)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesInitial)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesMoney)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesSales)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesReportClose)
        Me.pnlSalesReportDaily.Controls.Add(Me.lblDailySalesReport)
        Me.pnlSalesReportDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSalesReportDaily.Location = New System.Drawing.Point(0, 0)
        Me.pnlSalesReportDaily.Name = "pnlSalesReportDaily"
        Me.pnlSalesReportDaily.Size = New System.Drawing.Size(520, 252)
        Me.pnlSalesReportDaily.TabIndex = 0
        '
        'btnSalesDetails
        '
        Me.btnSalesDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSalesDetails.FlatAppearance.BorderSize = 0
        Me.btnSalesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesDetails.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalesDetails.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalesDetails.Location = New System.Drawing.Point(291, 197)
        Me.btnSalesDetails.Name = "btnSalesDetails"
        Me.btnSalesDetails.Size = New System.Drawing.Size(208, 28)
        Me.btnSalesDetails.TabIndex = 13
        Me.btnSalesDetails.Text = "View Sales Details"
        Me.btnSalesDetails.UseVisualStyleBackColor = False
        '
        'lblDailySalesTotalMoney
        '
        Me.lblDailySalesTotalMoney.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDailySalesTotalMoney.Location = New System.Drawing.Point(101, 146)
        Me.lblDailySalesTotalMoney.Name = "lblDailySalesTotalMoney"
        Me.lblDailySalesTotalMoney.Size = New System.Drawing.Size(397, 30)
        Me.lblDailySalesTotalMoney.TabIndex = 9
        Me.lblDailySalesTotalMoney.Text = "0.00"
        Me.lblDailySalesTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDailySalesTotal
        '
        Me.lblDailySalesTotal.AutoSize = True
        Me.lblDailySalesTotal.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDailySalesTotal.Location = New System.Drawing.Point(19, 146)
        Me.lblDailySalesTotal.Name = "lblDailySalesTotal"
        Me.lblDailySalesTotal.Size = New System.Drawing.Size(76, 30)
        Me.lblDailySalesTotal.TabIndex = 8
        Me.lblDailySalesTotal.Text = "TOTAL"
        '
        'lblDailySalesInitialCash
        '
        Me.lblDailySalesInitialCash.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDailySalesInitialCash.Location = New System.Drawing.Point(167, 106)
        Me.lblDailySalesInitialCash.Name = "lblDailySalesInitialCash"
        Me.lblDailySalesInitialCash.Size = New System.Drawing.Size(331, 30)
        Me.lblDailySalesInitialCash.TabIndex = 7
        Me.lblDailySalesInitialCash.Text = "0.00"
        Me.lblDailySalesInitialCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDailySalesInitial
        '
        Me.lblDailySalesInitial.AutoSize = True
        Me.lblDailySalesInitial.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDailySalesInitial.Location = New System.Drawing.Point(19, 106)
        Me.lblDailySalesInitial.Name = "lblDailySalesInitial"
        Me.lblDailySalesInitial.Size = New System.Drawing.Size(142, 30)
        Me.lblDailySalesInitial.TabIndex = 6
        Me.lblDailySalesInitial.Text = "INITIAL CASH"
        '
        'lblDailySalesMoney
        '
        Me.lblDailySalesMoney.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDailySalesMoney.Location = New System.Drawing.Point(95, 65)
        Me.lblDailySalesMoney.Name = "lblDailySalesMoney"
        Me.lblDailySalesMoney.Size = New System.Drawing.Size(403, 30)
        Me.lblDailySalesMoney.TabIndex = 5
        Me.lblDailySalesMoney.Text = "0.00"
        Me.lblDailySalesMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDailySalesSales
        '
        Me.lblDailySalesSales.AutoSize = True
        Me.lblDailySalesSales.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDailySalesSales.Location = New System.Drawing.Point(19, 65)
        Me.lblDailySalesSales.Name = "lblDailySalesSales"
        Me.lblDailySalesSales.Size = New System.Drawing.Size(70, 30)
        Me.lblDailySalesSales.TabIndex = 4
        Me.lblDailySalesSales.Text = "SALES"
        '
        'lblDailySalesReportClose
        '
        Me.lblDailySalesReportClose.AutoSize = True
        Me.lblDailySalesReportClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDailySalesReportClose.Location = New System.Drawing.Point(467, 4)
        Me.lblDailySalesReportClose.Name = "lblDailySalesReportClose"
        Me.lblDailySalesReportClose.Size = New System.Drawing.Size(50, 15)
        Me.lblDailySalesReportClose.TabIndex = 3
        Me.lblDailySalesReportClose.Text = "[ Close ]"
        '
        'lblDailySalesReport
        '
        Me.lblDailySalesReport.AutoSize = True
        Me.lblDailySalesReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDailySalesReport.Location = New System.Drawing.Point(12, 4)
        Me.lblDailySalesReport.Name = "lblDailySalesReport"
        Me.lblDailySalesReport.Size = New System.Drawing.Size(62, 15)
        Me.lblDailySalesReport.TabIndex = 2
        Me.lblDailySalesReport.Text = "Daily Sales"
        '
        'frmDailySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlSalesReportDaily)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDailySales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlSalesReportDaily.ResumeLayout(False)
        Me.pnlSalesReportDaily.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSalesReportDaily As Panel
    Friend WithEvents lblDailySalesReportClose As Label
    Friend WithEvents lblDailySalesReport As Label
    Friend WithEvents lblDailySalesTotalMoney As Label
    Friend WithEvents lblDailySalesTotal As Label
    Friend WithEvents lblDailySalesInitialCash As Label
    Friend WithEvents lblDailySalesInitial As Label
    Friend WithEvents lblDailySalesMoney As Label
    Friend WithEvents lblDailySalesSales As Label
    Friend WithEvents btnSalesDetails As Button
End Class
