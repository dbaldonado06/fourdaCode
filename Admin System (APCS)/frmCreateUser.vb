Imports System.Data.DataTable
Public Class frmCreateUser
    Dim table As New DataTable("table")
    Private Sub frmCreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("ID", Type.GetType("System.Int32"))
        table.Columns.Add("First Name", Type.GetType("System.String"))
        table.Columns.Add("Middle Name", Type.GetType("System.String"))
        table.Columns.Add("Last Name", Type.GetType("System.String"))
        table.Columns.Add("Email", Type.GetType("System.String"))
        table.Columns.Add("Contact Number", Type.GetType("System.Int64"))
        dataGridViewUser.DataSource = table

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        table.Rows.Add(txtBoxID.Text.Trim, txtBoxFname.Text.Trim, txtBoxMiddleName.Text.Trim, txtBoxLname.Text.Trim, txtBoxEmail.Text.Trim, txtBoxContactNumber.Text.Trim)
        dataGridViewUser.DataSource = table
    End Sub

    Private Sub lblFname_Click(sender As Object, e As EventArgs) Handles lblFname.Click

    End Sub

    Private Sub lblLname_Click(sender As Object, e As EventArgs) Handles lblLname.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtBoxContactNumber.TextChanged

    End Sub

    Private Sub picBoxClose_Click(sender As Object, e As EventArgs) Handles picBoxClose.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub txtBoxLname_TextChanged(sender As Object, e As EventArgs) Handles txtBoxLname.TextChanged

    End Sub

    Private Sub txtBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBoxEmail.TextChanged

    End Sub

    Private Sub txtBoxFname_TextChanged(sender As Object, e As EventArgs) Handles txtBoxFname.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxID.TextChanged

    End Sub

    Private Sub txtBoxMiddleName_TextChanged(sender As Object, e As EventArgs) Handles txtBoxMiddleName.TextChanged

    End Sub
End Class