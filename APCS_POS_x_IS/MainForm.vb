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

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub ProfilePic_Click(sender As Object, e As EventArgs) Handles ProfilePic.Click

    End Sub

    Private Sub btnPOSNewTransaction_Click(sender As Object, e As EventArgs) Handles btnPOSNewTransaction.Click
        NewtransactionForm.Show()
    End Sub

    Private Sub btnPOSSettlePayment_Click(sender As Object, e As EventArgs) Handles btnPOSSettlePayment.Click
        SettlepaymentForm.Show()
    End Sub

    Private Sub btnPOSCancelOrder_Click(sender As Object, e As EventArgs) Handles btnPOSCancelOrder.Click
        ManageordersForm.Show()
    End Sub

    Private Sub btnPOSManageProductMenu_Click(sender As Object, e As EventArgs) Handles btnPOSManageProductMenu.Click
        ManagemenuproductForm.Show()
    End Sub

    Private Sub btnPOSManageOrders_Click(sender As Object, e As EventArgs) Handles btnPOSManageOrders.Click
        ManageordersForm.Show()
    End Sub
End Class