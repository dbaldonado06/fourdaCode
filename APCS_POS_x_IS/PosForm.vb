Public Class PosForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles posPanel.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub newtransactionButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub posPanel_Paint(sender As Object, e As PaintEventArgs) Handles posPanel.Paint

    End Sub

    Private Sub pnlPOSMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlPOSMenu.Paint

    End Sub

    Private Sub lblPOSOrderNo_Click(sender As Object, e As EventArgs) Handles lblPOSOrderNo.Click

    End Sub

    Private Sub pnlPOSCategories_Paint(sender As Object, e As PaintEventArgs) Handles pnlPOSCategories.Paint

    End Sub

    Private Sub lblRole_Click(sender As Object, e As EventArgs) Handles lblRole.Click

    End Sub

    Private Sub lblOrderNumber_Click(sender As Object, e As EventArgs) Handles lblOrderNumber.Click

    End Sub

    Private Sub lblTransactionNumber_Click(sender As Object, e As EventArgs) Handles lblTransactionNumber.Click

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub dataGridViewPOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewPOS.CellContentClick

    End Sub

    Private Sub pnlBottomDashboardPOS_Paint(sender As Object, e As PaintEventArgs) Handles pnlBottomDashboardPOS.Paint

    End Sub

    Private Sub pnlTopPOS_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopPOS.Paint

    End Sub

    Private Sub lblPOSTransactionNo_Click(sender As Object, e As EventArgs) Handles lblPOSTransactionNo.Click

    End Sub

    Private Sub btnPOSNewTransaction_Click(sender As Object, e As EventArgs) Handles btnPOSNewTransaction.Click
        NewtransactionForm.Show()
    End Sub

    Private Sub btnPOSSettlePayment_Click(sender As Object, e As EventArgs) Handles btnPOSSettlePayment.Click
        SettlepaymentForm.Show()
    End Sub

    Private Sub btnPOSManageOrders_Click(sender As Object, e As EventArgs) Handles btnPOSManageOrders.Click
        ManageordersForm.Show()
    End Sub

    Private Sub btnPOSManageProductMenu_Click(sender As Object, e As EventArgs) Handles btnPOSManageProductMenu.Click
        ManagemenuproductForm.Show()
    End Sub

    Private Sub btnPOSCancelOrder_Click(sender As Object, e As EventArgs) Handles btnPOSCancelOrder.Click
        ManageordersForm.Show()
    End Sub

    Private Sub btnBlank_Click(sender As Object, e As EventArgs) Handles btnBlank.Click

    End Sub

    Private Sub btnPOSMonthlyReport_Click(sender As Object, e As EventArgs) Handles btnPOSMonthlyReport.Click

    End Sub

    Private Sub btnPOSAddVoucher_Click(sender As Object, e As EventArgs) Handles btnPOSAddVoucher.Click

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub picBoxPOSAthena_Click(sender As Object, e As EventArgs) Handles picBoxPOSAthena.Click

    End Sub

    Private Sub lblPOSAthenaPerbs_Click(sender As Object, e As EventArgs) Handles lblPOSAthenaPerbs.Click

    End Sub

    Private Sub lblPOSSoftware_Click(sender As Object, e As EventArgs) Handles lblPOSSoftware.Click

    End Sub
End Class