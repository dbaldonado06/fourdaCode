<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosForm
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
        Me.newtransactionButton = New System.Windows.Forms.Button()
        Me.monthlysalesButton = New System.Windows.Forms.Button()
        Me.clearcartButton = New System.Windows.Forms.Button()
        Me.cancelorderButton = New System.Windows.Forms.Button()
        Me.posPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'newtransactionButton
        '
        Me.newtransactionButton.Location = New System.Drawing.Point(12, 12)
        Me.newtransactionButton.Name = "newtransactionButton"
        Me.newtransactionButton.Size = New System.Drawing.Size(238, 44)
        Me.newtransactionButton.TabIndex = 0
        Me.newtransactionButton.Text = "[F1] New Transaction"
        Me.newtransactionButton.UseVisualStyleBackColor = True
        '
        'monthlysalesButton
        '
        Me.monthlysalesButton.Location = New System.Drawing.Point(256, 12)
        Me.monthlysalesButton.Name = "monthlysalesButton"
        Me.monthlysalesButton.Size = New System.Drawing.Size(238, 44)
        Me.monthlysalesButton.TabIndex = 1
        Me.monthlysalesButton.Text = "[F2] Monthly Sales"
        Me.monthlysalesButton.UseVisualStyleBackColor = True
        '
        'clearcartButton
        '
        Me.clearcartButton.Location = New System.Drawing.Point(500, 12)
        Me.clearcartButton.Name = "clearcartButton"
        Me.clearcartButton.Size = New System.Drawing.Size(238, 44)
        Me.clearcartButton.TabIndex = 2
        Me.clearcartButton.Text = "[F3] Clear Cart"
        Me.clearcartButton.UseVisualStyleBackColor = True
        '
        'cancelorderButton
        '
        Me.cancelorderButton.Location = New System.Drawing.Point(744, 12)
        Me.cancelorderButton.Name = "cancelorderButton"
        Me.cancelorderButton.Size = New System.Drawing.Size(238, 44)
        Me.cancelorderButton.TabIndex = 3
        Me.cancelorderButton.Text = "[F4] Cancel Order"
        Me.cancelorderButton.UseVisualStyleBackColor = True
        '
        'posPanel
        '
        Me.posPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.posPanel.Location = New System.Drawing.Point(0, 0)
        Me.posPanel.Name = "posPanel"
        Me.posPanel.Size = New System.Drawing.Size(1005, 788)
        Me.posPanel.TabIndex = 4
        '
        'PosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 788)
        Me.Controls.Add(Me.cancelorderButton)
        Me.Controls.Add(Me.clearcartButton)
        Me.Controls.Add(Me.monthlysalesButton)
        Me.Controls.Add(Me.newtransactionButton)
        Me.Controls.Add(Me.posPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PosForm"
        Me.Text = "PosForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newtransactionButton As Button
    Friend WithEvents monthlysalesButton As Button
    Friend WithEvents clearcartButton As Button
    Friend WithEvents cancelorderButton As Button
    Friend WithEvents posPanel As Panel
End Class
