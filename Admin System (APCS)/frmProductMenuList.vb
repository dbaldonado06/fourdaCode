Public Class frmProductMenuList
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With frmProductEntry
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Dispose()
    End Sub
End Class