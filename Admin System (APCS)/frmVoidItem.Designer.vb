<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoidItem))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblManageItem = New System.Windows.Forms.Label()
        Me.picBoxManageItem = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picBoxManageItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picBoxManageItem)
        Me.Panel1.Controls.Add(Me.lblManageItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 34)
        Me.Panel1.TabIndex = 0
        '
        'lblManageItem
        '
        Me.lblManageItem.AutoSize = True
        Me.lblManageItem.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblManageItem.ForeColor = System.Drawing.SystemColors.Control
        Me.lblManageItem.Location = New System.Drawing.Point(12, 9)
        Me.lblManageItem.Name = "lblManageItem"
        Me.lblManageItem.Size = New System.Drawing.Size(73, 17)
        Me.lblManageItem.TabIndex = 0
        Me.lblManageItem.Text = "VOID ITEM"
        '
        'picBoxManageItem
        '
        Me.picBoxManageItem.Image = CType(resources.GetObject("picBoxManageItem.Image"), System.Drawing.Image)
        Me.picBoxManageItem.Location = New System.Drawing.Point(396, 3)
        Me.picBoxManageItem.Name = "picBoxManageItem"
        Me.picBoxManageItem.Size = New System.Drawing.Size(29, 28)
        Me.picBoxManageItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxManageItem.TabIndex = 1
        Me.picBoxManageItem.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 23)
        Me.TextBox1.TabIndex = 1
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirm.Location = New System.Drawing.Point(316, 91)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(79, 23)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'frmVoidItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 148)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmVoidItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBoxManageItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblManageItem As Label
    Friend WithEvents picBoxManageItem As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnConfirm As Button
End Class
