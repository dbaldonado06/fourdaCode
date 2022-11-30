<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettlepaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettlepaymentForm))
        Me.pnlSettlePayment = New System.Windows.Forms.Panel()
        Me.btnSettlePaymentAcceptPayment = New System.Windows.Forms.Button()
        Me.lblSettlePaymentChange = New System.Windows.Forms.Label()
        Me.txtBoxSettlePaymentChange = New System.Windows.Forms.TextBox()
        Me.txtBoxSettlePaymentAddVoucher = New System.Windows.Forms.TextBox()
        Me.lblSettlePaymentAddVoucher = New System.Windows.Forms.Label()
        Me.txtBoxSettlePaymentCash = New System.Windows.Forms.TextBox()
        Me.lblSettlePaymentCash = New System.Windows.Forms.Label()
        Me.txtBoxSettlePaymentTotal = New System.Windows.Forms.TextBox()
        Me.lblSettlePaymentTotal = New System.Windows.Forms.Label()
        Me.picBoxAthenaSettlePayment = New System.Windows.Forms.PictureBox()
        Me.pnlSettlePayment.SuspendLayout()
        CType(Me.picBoxAthenaSettlePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSettlePayment
        '
        Me.pnlSettlePayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSettlePayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettlePayment.Controls.Add(Me.btnSettlePaymentAcceptPayment)
        Me.pnlSettlePayment.Controls.Add(Me.lblSettlePaymentChange)
        Me.pnlSettlePayment.Controls.Add(Me.txtBoxSettlePaymentChange)
        Me.pnlSettlePayment.Controls.Add(Me.txtBoxSettlePaymentAddVoucher)
        Me.pnlSettlePayment.Controls.Add(Me.lblSettlePaymentAddVoucher)
        Me.pnlSettlePayment.Controls.Add(Me.txtBoxSettlePaymentCash)
        Me.pnlSettlePayment.Controls.Add(Me.lblSettlePaymentCash)
        Me.pnlSettlePayment.Controls.Add(Me.txtBoxSettlePaymentTotal)
        Me.pnlSettlePayment.Controls.Add(Me.lblSettlePaymentTotal)
        Me.pnlSettlePayment.Controls.Add(Me.picBoxAthenaSettlePayment)
        Me.pnlSettlePayment.Location = New System.Drawing.Point(8, 8)
        Me.pnlSettlePayment.Name = "pnlSettlePayment"
        Me.pnlSettlePayment.Size = New System.Drawing.Size(344, 572)
        Me.pnlSettlePayment.TabIndex = 1
        '
        'btnSettlePaymentAcceptPayment
        '
        Me.btnSettlePaymentAcceptPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSettlePaymentAcceptPayment.FlatAppearance.BorderSize = 0
        Me.btnSettlePaymentAcceptPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettlePaymentAcceptPayment.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSettlePaymentAcceptPayment.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSettlePaymentAcceptPayment.Location = New System.Drawing.Point(11, 479)
        Me.btnSettlePaymentAcceptPayment.Name = "btnSettlePaymentAcceptPayment"
        Me.btnSettlePaymentAcceptPayment.Size = New System.Drawing.Size(321, 72)
        Me.btnSettlePaymentAcceptPayment.TabIndex = 12
        Me.btnSettlePaymentAcceptPayment.Text = "ACCEPT PAYMENT"
        Me.btnSettlePaymentAcceptPayment.UseVisualStyleBackColor = False
        '
        'lblSettlePaymentChange
        '
        Me.lblSettlePaymentChange.AutoSize = True
        Me.lblSettlePaymentChange.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSettlePaymentChange.Location = New System.Drawing.Point(136, 371)
        Me.lblSettlePaymentChange.Name = "lblSettlePaymentChange"
        Me.lblSettlePaymentChange.Size = New System.Drawing.Size(69, 20)
        Me.lblSettlePaymentChange.TabIndex = 8
        Me.lblSettlePaymentChange.Text = "CHANGE"
        '
        'txtBoxSettlePaymentChange
        '
        Me.txtBoxSettlePaymentChange.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxSettlePaymentChange.Location = New System.Drawing.Point(11, 396)
        Me.txtBoxSettlePaymentChange.Name = "txtBoxSettlePaymentChange"
        Me.txtBoxSettlePaymentChange.Size = New System.Drawing.Size(321, 54)
        Me.txtBoxSettlePaymentChange.TabIndex = 6
        '
        'txtBoxSettlePaymentAddVoucher
        '
        Me.txtBoxSettlePaymentAddVoucher.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxSettlePaymentAddVoucher.Location = New System.Drawing.Point(11, 309)
        Me.txtBoxSettlePaymentAddVoucher.Name = "txtBoxSettlePaymentAddVoucher"
        Me.txtBoxSettlePaymentAddVoucher.Size = New System.Drawing.Size(321, 54)
        Me.txtBoxSettlePaymentAddVoucher.TabIndex = 5
        '
        'lblSettlePaymentAddVoucher
        '
        Me.lblSettlePaymentAddVoucher.AutoSize = True
        Me.lblSettlePaymentAddVoucher.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSettlePaymentAddVoucher.Location = New System.Drawing.Point(115, 285)
        Me.lblSettlePaymentAddVoucher.Name = "lblSettlePaymentAddVoucher"
        Me.lblSettlePaymentAddVoucher.Size = New System.Drawing.Size(114, 20)
        Me.lblSettlePaymentAddVoucher.TabIndex = 4
        Me.lblSettlePaymentAddVoucher.Text = "ADD VOUCHER"
        '
        'txtBoxSettlePaymentCash
        '
        Me.txtBoxSettlePaymentCash.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxSettlePaymentCash.Location = New System.Drawing.Point(11, 222)
        Me.txtBoxSettlePaymentCash.Name = "txtBoxSettlePaymentCash"
        Me.txtBoxSettlePaymentCash.Size = New System.Drawing.Size(321, 54)
        Me.txtBoxSettlePaymentCash.TabIndex = 3
        '
        'lblSettlePaymentCash
        '
        Me.lblSettlePaymentCash.AutoSize = True
        Me.lblSettlePaymentCash.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSettlePaymentCash.Location = New System.Drawing.Point(145, 198)
        Me.lblSettlePaymentCash.Name = "lblSettlePaymentCash"
        Me.lblSettlePaymentCash.Size = New System.Drawing.Size(47, 20)
        Me.lblSettlePaymentCash.TabIndex = 2
        Me.lblSettlePaymentCash.Text = "CASH"
        '
        'txtBoxSettlePaymentTotal
        '
        Me.txtBoxSettlePaymentTotal.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxSettlePaymentTotal.Location = New System.Drawing.Point(11, 134)
        Me.txtBoxSettlePaymentTotal.Name = "txtBoxSettlePaymentTotal"
        Me.txtBoxSettlePaymentTotal.Size = New System.Drawing.Size(321, 54)
        Me.txtBoxSettlePaymentTotal.TabIndex = 1
        '
        'lblSettlePaymentTotal
        '
        Me.lblSettlePaymentTotal.AutoSize = True
        Me.lblSettlePaymentTotal.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSettlePaymentTotal.Location = New System.Drawing.Point(145, 111)
        Me.lblSettlePaymentTotal.Name = "lblSettlePaymentTotal"
        Me.lblSettlePaymentTotal.Size = New System.Drawing.Size(52, 20)
        Me.lblSettlePaymentTotal.TabIndex = 0
        Me.lblSettlePaymentTotal.Text = "TOTAL"
        '
        'picBoxAthenaSettlePayment
        '
        Me.picBoxAthenaSettlePayment.Image = CType(resources.GetObject("picBoxAthenaSettlePayment.Image"), System.Drawing.Image)
        Me.picBoxAthenaSettlePayment.Location = New System.Drawing.Point(87, -3)
        Me.picBoxAthenaSettlePayment.Name = "picBoxAthenaSettlePayment"
        Me.picBoxAthenaSettlePayment.Size = New System.Drawing.Size(168, 134)
        Me.picBoxAthenaSettlePayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAthenaSettlePayment.TabIndex = 13
        Me.picBoxAthenaSettlePayment.TabStop = False
        '
        'SettlepaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 592)
        Me.Controls.Add(Me.pnlSettlePayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettlepaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettlepaymentForm"
        Me.pnlSettlePayment.ResumeLayout(False)
        Me.pnlSettlePayment.PerformLayout()
        CType(Me.picBoxAthenaSettlePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSettlePayment As Panel
    Friend WithEvents btnSettlePaymentAcceptPayment As Button
    Friend WithEvents lblSettlePaymentChange As Label
    Friend WithEvents txtBoxSettlePaymentChange As TextBox
    Friend WithEvents txtBoxSettlePaymentAddVoucher As TextBox
    Friend WithEvents lblSettlePaymentAddVoucher As Label
    Friend WithEvents txtBoxSettlePaymentCash As TextBox
    Friend WithEvents lblSettlePaymentCash As Label
    Friend WithEvents txtBoxSettlePaymentTotal As TextBox
    Friend WithEvents lblSettlePaymentTotal As Label
    Friend WithEvents picBoxAthenaSettlePayment As PictureBox
End Class
