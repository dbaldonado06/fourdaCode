<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPassword
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
        Me.lblAdminPass = New System.Windows.Forms.Label()
        Me.txtBoxAdminPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAdminPass
        '
        Me.lblAdminPass.AutoSize = True
        Me.lblAdminPass.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAdminPass.Location = New System.Drawing.Point(12, 9)
        Me.lblAdminPass.Name = "lblAdminPass"
        Me.lblAdminPass.Size = New System.Drawing.Size(163, 15)
        Me.lblAdminPass.TabIndex = 14
        Me.lblAdminPass.Text = "Enter Administrator Password"
        '
        'txtBoxAdminPassword
        '
        Me.txtBoxAdminPassword.Location = New System.Drawing.Point(12, 27)
        Me.txtBoxAdminPassword.Name = "txtBoxAdminPassword"
        Me.txtBoxAdminPassword.Size = New System.Drawing.Size(333, 23)
        Me.txtBoxAdminPassword.TabIndex = 15
        '
        'frmAdminPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 78)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBoxAdminPassword)
        Me.Controls.Add(Me.lblAdminPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdminPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAdminPass As Label
    Friend WithEvents txtBoxAdminPassword As TextBox
End Class
