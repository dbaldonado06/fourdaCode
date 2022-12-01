<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartofDayForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblStartOfDayInitialPrice = New System.Windows.Forms.Label()
        Me.txtBoxStartOfDay = New System.Windows.Forms.TextBox()
        Me.lblProductEntryClose = New System.Windows.Forms.Label()
        Me.lblStartOfDay = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.lblStartOfDayInitialPrice)
        Me.Panel1.Controls.Add(Me.txtBoxStartOfDay)
        Me.Panel1.Controls.Add(Me.lblProductEntryClose)
        Me.Panel1.Controls.Add(Me.lblStartOfDay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 179)
        Me.Panel1.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(306, 118)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(74, 24)
        Me.btnStart.TabIndex = 17
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblStartOfDayInitialPrice
        '
        Me.lblStartOfDayInitialPrice.AutoSize = True
        Me.lblStartOfDayInitialPrice.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStartOfDayInitialPrice.Location = New System.Drawing.Point(45, 93)
        Me.lblStartOfDayInitialPrice.Name = "lblStartOfDayInitialPrice"
        Me.lblStartOfDayInitialPrice.Size = New System.Drawing.Size(65, 15)
        Me.lblStartOfDayInitialPrice.TabIndex = 16
        Me.lblStartOfDayInitialPrice.Text = "Initial Cash"
        '
        'txtBoxStartOfDay
        '
        Me.txtBoxStartOfDay.BackColor = System.Drawing.SystemColors.Control
        Me.txtBoxStartOfDay.Location = New System.Drawing.Point(120, 89)
        Me.txtBoxStartOfDay.Name = "txtBoxStartOfDay"
        Me.txtBoxStartOfDay.Size = New System.Drawing.Size(260, 23)
        Me.txtBoxStartOfDay.TabIndex = 15
        '
        'lblProductEntryClose
        '
        Me.lblProductEntryClose.AutoSize = True
        Me.lblProductEntryClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProductEntryClose.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProductEntryClose.Location = New System.Drawing.Point(385, 8)
        Me.lblProductEntryClose.Name = "lblProductEntryClose"
        Me.lblProductEntryClose.Size = New System.Drawing.Size(56, 17)
        Me.lblProductEntryClose.TabIndex = 14
        Me.lblProductEntryClose.Text = "[ Close ]"
        '
        'lblStartOfDay
        '
        Me.lblStartOfDay.AutoSize = True
        Me.lblStartOfDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblStartOfDay.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStartOfDay.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStartOfDay.Location = New System.Drawing.Point(-1, 8)
        Me.lblStartOfDay.Name = "lblStartOfDay"
        Me.lblStartOfDay.Size = New System.Drawing.Size(172, 30)
        Me.lblStartOfDay.TabIndex = 13
        Me.lblStartOfDay.Text = "Start Of The Day"
        '
        'FormStartofDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(448, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormStartofDay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents lblStartOfDayInitialPrice As Label
    Friend WithEvents txtBoxStartOfDay As TextBox
    Friend WithEvents lblProductEntryClose As Label
    Friend WithEvents lblStartOfDay As Label
End Class
