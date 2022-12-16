<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetQuantity
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveQuantity = New System.Windows.Forms.Button()
        Me.GetQuantity = New System.Windows.Forms.NumericUpDown()
        CType(Me.GetQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "QUANTITY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CancelButton.ForeColor = System.Drawing.Color.Black
        Me.CancelButton.Location = New System.Drawing.Point(151, -5)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(50, 27)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.TabStop = False
        Me.CancelButton.Text = "[ esc ]"
        Me.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'SaveQuantity
        '
        Me.SaveQuantity.AccessibleName = "saveBtn"
        Me.SaveQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.SaveQuantity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveQuantity.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaveQuantity.ForeColor = System.Drawing.SystemColors.Control
        Me.SaveQuantity.Location = New System.Drawing.Point(63, 90)
        Me.SaveQuantity.Name = "SaveQuantity"
        Me.SaveQuantity.Size = New System.Drawing.Size(64, 26)
        Me.SaveQuantity.TabIndex = 12
        Me.SaveQuantity.Text = "SAVE"
        Me.SaveQuantity.UseVisualStyleBackColor = False
        '
        'GetQuantity
        '
        Me.GetQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GetQuantity.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GetQuantity.Location = New System.Drawing.Point(12, 38)
        Me.GetQuantity.Name = "GetQuantity"
        Me.GetQuantity.Size = New System.Drawing.Size(167, 46)
        Me.GetQuantity.TabIndex = 13
        Me.GetQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GetQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SetQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(191, 123)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.GetQuantity)
        Me.Controls.Add(Me.SaveQuantity)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "testForm"
        CType(Me.GetQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveQuantity As Button
    Friend WithEvents GetQuantity As NumericUpDown
End Class
