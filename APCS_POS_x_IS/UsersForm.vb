Public Class UsersForm
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersDataGridView.CellContentClick

    End Sub

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EdituserForm.Show()
    End Sub
End Class