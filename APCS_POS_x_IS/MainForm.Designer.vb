<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.RealtimeDate = New System.Windows.Forms.Label()
        Me.RoleLbl = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.PosButton = New System.Windows.Forms.Button()
        Me.DashboardButton = New System.Windows.Forms.Button()
        Me.ProfileButton = New System.Windows.Forms.Button()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.UserLabelPOS = New System.Windows.Forms.Label()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.DatexTime = New System.Windows.Forms.Timer(Me.components)
        Me.LeftPanel.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.RealtimeDate)
        Me.LeftPanel.Controls.Add(Me.RoleLbl)
        Me.LeftPanel.Controls.Add(Me.LogoutButton)
        Me.LeftPanel.Controls.Add(Me.PosButton)
        Me.LeftPanel.Controls.Add(Me.DashboardButton)
        Me.LeftPanel.Controls.Add(Me.ProfileButton)
        Me.LeftPanel.Controls.Add(Me.ProfilePanel)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(307, 788)
        Me.LeftPanel.TabIndex = 0
        '
        'RealtimeDate
        '
        Me.RealtimeDate.BackColor = System.Drawing.Color.Black
        Me.RealtimeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RealtimeDate.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RealtimeDate.ForeColor = System.Drawing.Color.Lime
        Me.RealtimeDate.Location = New System.Drawing.Point(0, 381)
        Me.RealtimeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.RealtimeDate.Name = "RealtimeDate"
        Me.RealtimeDate.Size = New System.Drawing.Size(307, 126)
        Me.RealtimeDate.TabIndex = 5
        Me.RealtimeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoleLbl
        '
        Me.RoleLbl.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RoleLbl.ForeColor = System.Drawing.Color.White
        Me.RoleLbl.Location = New System.Drawing.Point(0, 201)
        Me.RoleLbl.Name = "RoleLbl"
        Me.RoleLbl.Size = New System.Drawing.Size(307, 31)
        Me.RoleLbl.TabIndex = 3
        Me.RoleLbl.Text = "Role"
        Me.RoleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RoleLbl.UseCompatibleTextRendering = True
        '
        'LogoutButton
        '
        Me.LogoutButton.FlatAppearance.BorderSize = 0
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogoutButton.ForeColor = System.Drawing.Color.White
        Me.LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), System.Drawing.Image)
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(2, 729)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(304, 38)
        Me.LogoutButton.TabIndex = 4
        Me.LogoutButton.Text = "LOGOUT"
        Me.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'PosButton
        '
        Me.PosButton.FlatAppearance.BorderSize = 0
        Me.PosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PosButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PosButton.ForeColor = System.Drawing.Color.White
        Me.PosButton.Image = CType(resources.GetObject("PosButton.Image"), System.Drawing.Image)
        Me.PosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PosButton.Location = New System.Drawing.Point(0, 336)
        Me.PosButton.Name = "PosButton"
        Me.PosButton.Size = New System.Drawing.Size(307, 42)
        Me.PosButton.TabIndex = 3
        Me.PosButton.Text = "POINT OF SALE"
        Me.PosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PosButton.UseVisualStyleBackColor = True
        '
        'DashboardButton
        '
        Me.DashboardButton.FlatAppearance.BorderSize = 0
        Me.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DashboardButton.ForeColor = System.Drawing.Color.White
        Me.DashboardButton.Image = CType(resources.GetObject("DashboardButton.Image"), System.Drawing.Image)
        Me.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardButton.Location = New System.Drawing.Point(0, 290)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.Size = New System.Drawing.Size(307, 42)
        Me.DashboardButton.TabIndex = 2
        Me.DashboardButton.Text = "DASHBOARD"
        Me.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardButton.UseVisualStyleBackColor = True
        '
        'ProfileButton
        '
        Me.ProfileButton.FlatAppearance.BorderSize = 0
        Me.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfileButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProfileButton.ForeColor = System.Drawing.Color.White
        Me.ProfileButton.Image = CType(resources.GetObject("ProfileButton.Image"), System.Drawing.Image)
        Me.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProfileButton.Location = New System.Drawing.Point(0, 244)
        Me.ProfileButton.Name = "ProfileButton"
        Me.ProfileButton.Size = New System.Drawing.Size(307, 42)
        Me.ProfileButton.TabIndex = 1
        Me.ProfileButton.Text = "USERS"
        Me.ProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProfileButton.UseVisualStyleBackColor = True
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfilePanel.Controls.Add(Me.UserLabelPOS)
        Me.ProfilePanel.Controls.Add(Me.ProfilePic)
        Me.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(307, 203)
        Me.ProfilePanel.TabIndex = 0
        '
        'UserLabelPOS
        '
        Me.UserLabelPOS.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserLabelPOS.ForeColor = System.Drawing.Color.White
        Me.UserLabelPOS.Location = New System.Drawing.Point(-1, 169)
        Me.UserLabelPOS.Name = "UserLabelPOS"
        Me.UserLabelPOS.Size = New System.Drawing.Size(307, 31)
        Me.UserLabelPOS.TabIndex = 2
        Me.UserLabelPOS.Text = "Full Name"
        Me.UserLabelPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UserLabelPOS.UseCompatibleTextRendering = True
        '
        'ProfilePic
        '
        Me.ProfilePic.Image = CType(resources.GetObject("ProfilePic.Image"), System.Drawing.Image)
        Me.ProfilePic.Location = New System.Drawing.Point(-1, -1)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(307, 203)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ProfilePic.TabIndex = 0
        Me.ProfilePic.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(307, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1079, 788)
        Me.MainPanel.TabIndex = 1
        '
        'DatexTime
        '
        Me.DatexTime.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LeftPanel.ResumeLayout(False)
        Me.ProfilePanel.ResumeLayout(False)
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents ProfilePic As PictureBox
    Friend WithEvents ProfileButton As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents PosButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents UserLabelPOS As Label
    Friend WithEvents RoleLbl As Label
    Friend WithEvents RealtimeDate As Label
    Friend WithEvents DatexTime As Timer
End Class
