Public Class frmProductMenuList
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles toolStripProductListCreate.Click
        With frmProductEntry
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles toolStripProductListClose.Click
        Me.Dispose()
    End Sub

    Private Sub dataGridViewPOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewProductMenuList.CellContentClick

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles toolStripProductList.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class