Imports System.Data.SqlClient
Public Class SetQuantity
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Dispose()
        PosForm.Cancel = True
    End Sub

    Private Sub SaveQuantity_Click(sender As Object, e As EventArgs) Handles SaveQuantity.Click
        PosForm.buttonPressed = True
        PosForm.getQty = GetQuantity.Value.ToString
        Me.Dispose()
    End Sub
End Class