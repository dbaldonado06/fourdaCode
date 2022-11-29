Public Class frmCustomerEntry
    Private Sub lblPhoneNumber_Click(sender As Object, e As EventArgs) Handles lblPhoneNumber.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPhoneNumber.TextChanged

    End Sub

    Private Sub pnlCustomerEntry_Paint(sender As Object, e As PaintEventArgs) Handles pnlCustomerEntry.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblModeOfPayment.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtModeOfPayment.TextChanged

    End Sub

    Private Sub picBoxRegUserClose_Click(sender As Object, e As EventArgs) Handles picBoxRegUserClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnCustomersCancel_Click(sender As Object, e As EventArgs) Handles btnCustomersCancel.Click
        Me.Dispose()
    End Sub
End Class