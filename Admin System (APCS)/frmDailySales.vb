Public Class frmDailySales
    Private Sub lblDailySalesReportClose_Click(sender As Object, e As EventArgs) Handles lblDailySalesReportClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSalesDetails_Click(sender As Object, e As EventArgs) Handles btnSalesDetails.Click
        With frmViewSalesDetails
            .ShowDialog()
        End With
    End Sub
End Class