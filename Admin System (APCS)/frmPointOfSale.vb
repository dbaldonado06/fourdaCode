Imports System.Data.SqlClient

Public Class frmPointOfSale
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPOSSettlePayment.Click
        With frmSettlePayment
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSNewTransaction_Click(sender As Object, e As EventArgs) Handles btnPOSNewTransaction.Click
        With frmSelectOrder
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSManageProductMenu_Click(sender As Object, e As EventArgs) Handles btnPOSManageProductMenu.Click
        With frmProductMenuList
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSManageOrders_Click(sender As Object, e As EventArgs) Handles btnPOSManageOrders.Click
        With frmOrders
            .ShowDialog()
        End With
    End Sub
    Private Sub btnPOSStart_Click(sender As Object, e As EventArgs) Handles btnPOSStart.Click
        With frmStartOfDay
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSSalesReport_Click(sender As Object, e As EventArgs) Handles btnPOSSalesReport.Click
        With frmDailySales
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSCancelOrder_Click(sender As Object, e As EventArgs) Handles btnPOSCancelOrder.Click
        With frmCancelOrder
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSAddVoucher_Click(sender As Object, e As EventArgs) Handles btnPOSAddVoucher.Click
        With frmVoucherDiscount
            .ShowDialog()
        End With
    End Sub
    Private Sub frmPointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Date.Now.ToString("y")
        posClock.Text = Date.Now.ToString(String.Format("MMM dd, yy" + Environment.NewLine + "hh:mm:ss:tt"))
    End Sub
End Class