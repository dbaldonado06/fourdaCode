Public Class frmUserEntry

    Sub switchPanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBoxUserEntry.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnUserUserEntry.Click
        switchPanel(frmCreateUser)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDashboardUserEntry.Click
        switchPanel(frmDashboard)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblAdminUserEntry.Click

    End Sub

    Private Sub frmUserEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picBoxCreateUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnProdMenuUserEntry_Click(sender As Object, e As EventArgs) Handles btnProdMenuUserEntry.Click
        switchPanel(frmProductMenuList)
    End Sub

    Private Sub btnCustomersUserEntry_Click(sender As Object, e As EventArgs) Handles btnCustomersUserEntry.Click
        switchPanel(frmCustomers)
    End Sub

    Private Sub btnRecordsUserEntry_Click(sender As Object, e As EventArgs) Handles btnRecordsUserEntry.Click
        switchPanel(frmSalesRecords)
    End Sub

    Private Sub btnVouchersUserEntry_Click(sender As Object, e As EventArgs) Handles btnVouchersUserEntry.Click

    End Sub

    Private Sub btnStocksInvUserEntry_Click(sender As Object, e As EventArgs) Handles btnStocksInvUserEntry.Click

    End Sub

    Private Sub btnLogoutUserEntry_Click(sender As Object, e As EventArgs) Handles btnLogoutUserEntry.Click
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub pnl3UserEntry_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub picBoxCreateUser_Click_1(sender As Object, e As EventArgs) Handles picBoxCreateUser.Click
        frmCreateUser.Show()
    End Sub

    Private Sub btnPosUserEntry_Click(sender As Object, e As EventArgs) Handles btnPosUserEntry.Click
        switchPanel(frmPointOfSale)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class