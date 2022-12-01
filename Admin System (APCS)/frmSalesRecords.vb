Public Class frmSalesRecords
    Private Sub pnlSalesRecords_Paint(sender As Object, e As PaintEventArgs) Handles pnlSalesRecords.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub picBoxSalesRecordClose_Click(sender As Object, e As EventArgs) Handles picBoxSalesRecordClose.Click
        Me.Dispose()
    End Sub

    Private Sub picBoxPreview_Click(sender As Object, e As EventArgs) Handles picBoxPreview.Click
        With frmPrintPreview
            .ShowDialog()
        End With
    End Sub
End Class