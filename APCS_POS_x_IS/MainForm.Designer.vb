<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.UsersButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeText = New System.Windows.Forms.Label()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LeftPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.SlateGray
        Me.LeftPanel.Controls.Add(Me.Button1)
        Me.LeftPanel.Controls.Add(Me.UsersButton)
        Me.LeftPanel.Controls.Add(Me.Panel1)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(307, 638)
        Me.LeftPanel.TabIndex = 0
        '
        'UsersButton
        '
        Me.UsersButton.FlatAppearance.BorderSize = 0
        Me.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsersButton.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsersButton.ForeColor = System.Drawing.Color.White
        Me.UsersButton.Image = CType(resources.GetObject("UsersButton.Image"), System.Drawing.Image)
        Me.UsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsersButton.Location = New System.Drawing.Point(12, 218)
        Me.UsersButton.Name = "UsersButton"
        Me.UsersButton.Size = New System.Drawing.Size(283, 42)
        Me.UsersButton.TabIndex = 1
        Me.UsersButton.Text = "USERS"
        Me.UsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UsersButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EmployeeText)
        Me.Panel1.Controls.Add(Me.ProfilePic)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 203)
        Me.Panel1.TabIndex = 0
        '
        'EmployeeText
        '
        Me.EmployeeText.AutoSize = True
        Me.EmployeeText.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmployeeText.ForeColor = System.Drawing.Color.White
        Me.EmployeeText.Location = New System.Drawing.Point(98, 169)
        Me.EmployeeText.Name = "EmployeeText"
        Me.EmployeeText.Size = New System.Drawing.Size(109, 28)
        Me.EmployeeText.TabIndex = 1
        Me.EmployeeText.Text = "EMPLOYEE"
        '
        'ProfilePic
        '
        Me.ProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfilePic.Image = CType(resources.GetObject("ProfilePic.Image"), System.Drawing.Image)
        Me.ProfilePic.Location = New System.Drawing.Point(-1, -1)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(307, 203)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ProfilePic.TabIndex = 0
        Me.ProfilePic.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "USERS"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1005, 638)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LeftPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmployeeText As Label
    Friend WithEvents ProfilePic As PictureBox
    Friend WithEvents UsersButton As Button
    Friend WithEvents Button1 As Button
End Class
