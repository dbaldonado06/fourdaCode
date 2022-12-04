Public Class PosForm
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
        With ManagemenuproductForm
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSCancelOrder_Click(sender As Object, e As EventArgs) Handles btnPOSCancelOrder.Click
        CancelOrderForm.Show()
    End Sub
    Private Sub btnPOSSalesReport_Click(sender As Object, e As EventArgs) Handles btnPOSSalesReport.Click
        With DailySalesForm
            .ShowDialog()
        End With
    End Sub
    Private Sub btnPOSAddVoucher_Click(sender As Object, e As EventArgs) Handles btnPOSAddVoucher.Click
        VoucherForm.Show()
    End Sub
    Private Sub btnPOSStart_Click(sender As Object, e As EventArgs) Handles btnPOSStart.Click
        With StartofDayForm
            .ShowDialog()
        End With
    End Sub

    Private Sub posPanel_Load(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub DateAndTime_Tick(sender As Object, e As EventArgs) Handles DateAndTime.Tick
        RealtimeDate.Text = Date.Now.ToString(String.Format("MMM dd, yy" + Environment.NewLine + "hh: mm: ss tt"))
    End Sub
End Class