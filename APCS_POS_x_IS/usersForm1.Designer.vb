<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.sidenabvarPanel1 = New System.Windows.Forms.Panel()
        Me.logoutButton4 = New System.Windows.Forms.Button()
        Me.posButton3 = New System.Windows.Forms.Button()
        Me.dashboardButton2 = New System.Windows.Forms.Button()
        Me.usersButton1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.profilePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.employeeLabel1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.sidenabvarPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.profilePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidenabvarPanel1
        '
        Me.sidenabvarPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.sidenabvarPanel1.Controls.Add(Me.logoutButton4)
        Me.sidenabvarPanel1.Controls.Add(Me.posButton3)
        Me.sidenabvarPanel1.Controls.Add(Me.dashboardButton2)
        Me.sidenabvarPanel1.Controls.Add(Me.usersButton1)
        Me.sidenabvarPanel1.Controls.Add(Me.Panel2)
        Me.sidenabvarPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidenabvarPanel1.ForeColor = System.Drawing.Color.White
        Me.sidenabvarPanel1.Location = New System.Drawing.Point(0, 0)
        Me.sidenabvarPanel1.Name = "sidenabvarPanel1"
        Me.sidenabvarPanel1.Size = New System.Drawing.Size(236, 494)
        Me.sidenabvarPanel1.TabIndex = 1
        '
        'logoutButton4
        '
        Me.logoutButton4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutButton4.FlatAppearance.BorderSize = 0
        Me.logoutButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.logoutButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logoutButton4.ForeColor = System.Drawing.Color.White
        Me.logoutButton4.Image = CType(resources.GetObject("logoutButton4.Image"), System.Drawing.Image)
        Me.logoutButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutButton4.Location = New System.Drawing.Point(0, 457)
        Me.logoutButton4.Name = "logoutButton4"
        Me.logoutButton4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.logoutButton4.Size = New System.Drawing.Size(236, 37)
        Me.logoutButton4.TabIndex = 4
        Me.logoutButton4.Text = "Logout"
        Me.logoutButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logoutButton4.UseVisualStyleBackColor = True
        '
        'posButton3
        '
        Me.posButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.posButton3.FlatAppearance.BorderSize = 0
        Me.posButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.posButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.posButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.posButton3.ForeColor = System.Drawing.Color.White
        Me.posButton3.Image = CType(resources.GetObject("posButton3.Image"), System.Drawing.Image)
        Me.posButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.posButton3.Location = New System.Drawing.Point(0, 247)
        Me.posButton3.Name = "posButton3"
        Me.posButton3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.posButton3.Size = New System.Drawing.Size(236, 37)
        Me.posButton3.TabIndex = 3
        Me.posButton3.Text = "Point of Sale"
        Me.posButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.posButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.posButton3.UseVisualStyleBackColor = True
        '
        'dashboardButton2
        '
        Me.dashboardButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboardButton2.FlatAppearance.BorderSize = 0
        Me.dashboardButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.dashboardButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dashboardButton2.ForeColor = System.Drawing.Color.White
        Me.dashboardButton2.Image = CType(resources.GetObject("dashboardButton2.Image"), System.Drawing.Image)
        Me.dashboardButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardButton2.Location = New System.Drawing.Point(0, 210)
        Me.dashboardButton2.Name = "dashboardButton2"
        Me.dashboardButton2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dashboardButton2.Size = New System.Drawing.Size(236, 37)
        Me.dashboardButton2.TabIndex = 2
        Me.dashboardButton2.Text = "Dashboard"
        Me.dashboardButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dashboardButton2.UseVisualStyleBackColor = True
        '
        'usersButton1
        '
        Me.usersButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.usersButton1.FlatAppearance.BorderSize = 0
        Me.usersButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.usersButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.usersButton1.ForeColor = System.Drawing.Color.White
        Me.usersButton1.Image = CType(resources.GetObject("usersButton1.Image"), System.Drawing.Image)
        Me.usersButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usersButton1.Location = New System.Drawing.Point(0, 173)
        Me.usersButton1.Name = "usersButton1"
        Me.usersButton1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.usersButton1.Size = New System.Drawing.Size(236, 37)
        Me.usersButton1.TabIndex = 1
        Me.usersButton1.Text = "Users"
        Me.usersButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usersButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.usersButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.employeeLabel1)
        Me.Panel2.Controls.Add(Me.profilePictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 173)
        Me.Panel2.TabIndex = 0
        '
        'profilePictureBox1
        '
        Me.profilePictureBox1.Image = CType(resources.GetObject("profilePictureBox1.Image"), System.Drawing.Image)
        Me.profilePictureBox1.Location = New System.Drawing.Point(37, 12)
        Me.profilePictureBox1.Name = "profilePictureBox1"
        Me.profilePictureBox1.Size = New System.Drawing.Size(156, 125)
        Me.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilePictureBox1.TabIndex = 0
        Me.profilePictureBox1.TabStop = False
        '
        'employeeLabel1
        '
        Me.employeeLabel1.AutoSize = True
        Me.employeeLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.employeeLabel1.Location = New System.Drawing.Point(54, 140)
        Me.employeeLabel1.Name = "employeeLabel1"
        Me.employeeLabel1.Size = New System.Drawing.Size(118, 30)
        Me.employeeLabel1.TabIndex = 2
        Me.employeeLabel1.Text = "EMPLOYEE"
        Me.employeeLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(236, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(642, 494)
        Me.Panel3.TabIndex = 2
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 494)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.sidenabvarPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "Form1"
        Me.sidenabvarPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.profilePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents sidenabvarPanel1 As Panel
    Friend WithEvents usersButton1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logoutButton4 As Button
    Friend WithEvents posButton3 As Button
    Friend WithEvents dashboardButton2 As Button
    Friend WithEvents profilePictureBox1 As PictureBox
    Friend WithEvents employeeLabel1 As Label
    Friend WithEvents Panel3 As Panel
End Class
