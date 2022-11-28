<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQty
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
        Me.lblQtyQuantity = New System.Windows.Forms.Label()
        Me.txtBoxQuantity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQtyQuantity
        '
        Me.lblQtyQuantity.Location = New System.Drawing.Point(-2, 2)
        Me.lblQtyQuantity.Name = "lblQtyQuantity"
        Me.lblQtyQuantity.Size = New System.Drawing.Size(314, 29)
        Me.lblQtyQuantity.TabIndex = 0
        Me.lblQtyQuantity.Text = "------"
        Me.lblQtyQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxQuantity
        '
        Me.txtBoxQuantity.Font = New System.Drawing.Font("Yu Gothic UI", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtBoxQuantity.Location = New System.Drawing.Point(12, 42)
        Me.txtBoxQuantity.Name = "txtBoxQuantity"
        Me.txtBoxQuantity.Size = New System.Drawing.Size(289, 77)
        Me.txtBoxQuantity.TabIndex = 1
        '
        'frmQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBoxQuantity)
        Me.Controls.Add(Me.lblQtyQuantity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQtyQuantity As Label
    Friend WithEvents txtBoxQuantity As TextBox
End Class
