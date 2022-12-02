Imports System.Data.SqlClient
Public Class frmUserEntry
    Public Shared ID As Integer
    Sub switchPanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
        btnUserUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnDashboardUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnPosUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnProdMenuUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnCustomersUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnRecordsUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnDiscountUserEntry.BackColor = Color.FromArgb(53, 92, 125)
        btnStocksInvUserEntry.BackColor = Color.FromArgb(53, 92, 125)

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnUserUserEntry.Click
        switchPanel(frmCreateUser)
        With frmCreateUser
            .dataGridViewUserfrm.Rows.Clear()
            .LoadRecords()
        End With
        btnUserUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDashboardUserEntry.Click
        switchPanel(frmDashboard)
        btnDashboardUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub btnProdMenuUserEntry_Click(sender As Object, e As EventArgs) Handles btnProdMenuUserEntry.Click
        switchPanel(frmProductMenuList)
        btnProdMenuUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub btnCustomersUserEntry_Click(sender As Object, e As EventArgs) Handles btnCustomersUserEntry.Click
        switchPanel(frmCustomers)
        btnCustomersUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub btnRecordsUserEntry_Click(sender As Object, e As EventArgs) Handles btnRecordsUserEntry.Click
        switchPanel(frmSalesSummary)
        btnRecordsUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub btnVouchersUserEntry_Click(sender As Object, e As EventArgs) Handles btnDiscountUserEntry.Click
        switchPanel(frmVoucherDiscount)
        btnDiscountUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub btnStocksInvUserEntry_Click(sender As Object, e As EventArgs) Handles btnStocksInvUserEntry.Click
        switchPanel(frmStocksFoodInventory)
        btnStocksInvUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub btnLogoutUserEntry_Click(sender As Object, e As EventArgs) Handles btnLogoutUserEntry.Click
        Application.Exit()
    End Sub

    Private Sub picBoxCreateUser_Click_1(sender As Object, e As EventArgs) Handles picBoxCreateUser.Click
        frmCreateUser.Show()
    End Sub

    Private Sub btnPosUserEntry_Click(sender As Object, e As EventArgs) Handles btnPosUserEntry.Click
        switchPanel(frmPointOfSale)
        btnPosUserEntry.BackColor = Color.FromArgb(10, 61, 98)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        Connection()
        cmd = New SqlCommand("SELECT FName, MName, LName FROM [Users] WHERE ID = '" & ID & "'")
        cmd.Connection = con
        dr = cmd.ExecuteReader()
        If (dr.Read()) Then
            lblAdminUserEntry.Text = dr("FName") + " " + dr("LName")
        End If
        dr.Close()
    End Sub

End Class