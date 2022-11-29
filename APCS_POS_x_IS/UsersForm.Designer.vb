<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersForm))
        Me.usersDataGridView = New System.Windows.Forms.DataGridView()
        Me.usernameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passwordColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phonenumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.usersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usersDataGridView
        '
        Me.usersDataGridView.AllowUserToResizeColumns = False
        Me.usersDataGridView.AllowUserToResizeRows = False
        Me.usersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.usersDataGridView.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.usersDataGridView.ColumnHeadersHeight = 40
        Me.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.usersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usernameColumn, Me.passwordColumn, Me.addressColumn, Me.phonenumberColumn, Me.emailColumn, Me.editColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usersDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.usersDataGridView.EnableHeadersVisualStyles = False
        Me.usersDataGridView.Location = New System.Drawing.Point(12, 59)
        Me.usersDataGridView.Name = "usersDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.usersDataGridView.RowHeadersVisible = False
        Me.usersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.usersDataGridView.RowTemplate.Height = 25
        Me.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usersDataGridView.Size = New System.Drawing.Size(912, 294)
        Me.usersDataGridView.TabIndex = 0
        '
        'usernameColumn
        '
        Me.usernameColumn.HeaderText = "USERNAME"
        Me.usernameColumn.Name = "usernameColumn"
        '
        'passwordColumn
        '
        Me.passwordColumn.HeaderText = "PASSWORD"
        Me.passwordColumn.Name = "passwordColumn"
        Me.passwordColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'addressColumn
        '
        Me.addressColumn.HeaderText = "ADDRESS"
        Me.addressColumn.Name = "addressColumn"
        '
        'phonenumberColumn
        '
        Me.phonenumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phonenumberColumn.HeaderText = "PHONE NUMBER"
        Me.phonenumberColumn.Name = "phonenumberColumn"
        '
        'emailColumn
        '
        Me.emailColumn.HeaderText = "EMAIL"
        Me.emailColumn.Name = "emailColumn"
        '
        'editColumn
        '
        Me.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.editColumn.HeaderText = ""
        Me.editColumn.Image = CType(resources.GetObject("editColumn.Image"), System.Drawing.Image)
        Me.editColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.editColumn.Name = "editColumn"
        Me.editColumn.Width = 21
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1005, 788)
        Me.Controls.Add(Me.usersDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsersForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.usersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usersDataGridView As DataGridView
    Friend WithEvents usernameColumn As DataGridViewTextBoxColumn
    Friend WithEvents passwordColumn As DataGridViewTextBoxColumn
    Friend WithEvents addressColumn As DataGridViewTextBoxColumn
    Friend WithEvents phonenumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents emailColumn As DataGridViewTextBoxColumn
    Friend WithEvents editColumn As DataGridViewImageColumn
End Class
