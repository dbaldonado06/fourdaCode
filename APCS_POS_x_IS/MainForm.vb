Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        loginForm.Show()
        Close()
    End Sub
End Class