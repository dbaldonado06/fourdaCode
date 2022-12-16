Imports System.Data.SqlClient

Public Class MainForm
    Public Shared role As Integer
    Sub switchPanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub UsersButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
        switchPanel(UsersForm)
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        switchPanel(DashboardForm)
    End Sub

    Private Sub PosButton_Click(sender As Object, e As EventArgs) Handles PosButton.Click
        switchPanel(PosForm)
    End Sub


    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Dispose()
        loginForm.Show()
    End Sub

    Private Sub btnPOSNewTransaction_Click(sender As Object, e As EventArgs)
        With NewtransactionForm
            .Show()
        End With
    End Sub

    Private Sub btnPOSSettlePayment_Click(sender As Object, e As EventArgs)
        SettlepaymentForm.Show()
    End Sub

    Private Sub btnPOSCancelOrder_Click(sender As Object, e As EventArgs)
        ManageordersForm.Show()
    End Sub

    Private Sub btnPOSManageProductMenu_Click(sender As Object, e As EventArgs)
        ManagemenuproductForm.Show()
    End Sub

    Private Sub btnPOSManageOrders_Click(sender As Object, e As EventArgs)
        ManageordersForm.Show()
    End Sub

    Private Sub btnPOSStart_Click(sender As Object, e As EventArgs)
        With StartofDayForm
            .ShowDialog()
        End With
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatexTime.Start()
    End Sub
    Private Sub DatexTime_Tick(sender As Object, e As EventArgs) Handles DatexTime.Tick
        RealtimeDate.Text = Date.Now.ToString(String.Format("| dddd |" + Environment.NewLine + "MMMM dd, yy" + Environment.NewLine + "hh: mm: ss | tt"))
    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub
End Class