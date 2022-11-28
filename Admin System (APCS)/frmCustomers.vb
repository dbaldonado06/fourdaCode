Public Class frmCustomers
    Private Sub picBoxCustomers_Click(sender As Object, e As EventArgs) Handles picBoxCustomers.Click
        With frmCustomerEntry
            .ShowDialog()
        End With
    End Sub
End Class