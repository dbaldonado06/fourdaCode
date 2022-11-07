Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub switchPanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub UsersButton_Click(sender As Object, e As EventArgs) Handles UsersButton.Click
        switchPanel(UsersForm)
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        switchPanel(DashboardForm)
    End Sub

    Private Sub PosButton_Click(sender As Object, e As EventArgs) Handles PosButton.Click
        switchPanel(PosForm)
    End Sub


    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        loginForm.Show()
        Close()
    End Sub

End Class