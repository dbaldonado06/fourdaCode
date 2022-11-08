Imports System.Data.DataTable
Imports System.DirectoryServices.ActiveDirectory

Public Class frmCreateUser
    Dim table As New DataTable("table")
    Dim index As Integer
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

    Private Sub picBoxClose_Click(sender As Object, e As EventArgs)
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

    Private Sub lblMiddleName_Click(sender As Object, e As EventArgs) Handles lblMiddleName.Click

    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub lblContactNumber_Click(sender As Object, e As EventArgs) Handles lblContactNumber.Click

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtBoxID.Text = ""

        txtBoxFname.Text = ""

        txtBoxMiddleName.Text = ""

        txtBoxLname.Text = ""

        txtBoxEmail.Text = ""

        txtBoxContactNumber.Text = ""

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim newData As DataGridViewRow

        newData = dataGridViewUser.Rows(index)

        newData.Cells(0).Value = txtBoxID.Text

        newData.Cells(1).Value = txtBoxFname.Text

        newData.Cells(2).Value = txtBoxMiddleName.Text

        newData.Cells(3).Value = txtBoxLname.Text

        newData.Cells(4).Value = txtBoxEmail.Text

        newData.Cells(5).Value = txtBoxContactNumber.Text

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dataGridViewUser.Rows.RemoveAt(index)
    End Sub

    Private Sub dataGridViewUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewUser.CellContentClick

    End Sub

    Private Sub dataGridViewUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewUser.CellClick

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow

        selectedRow = dataGridViewUser.Rows(index)

        txtBoxID.Text = selectedRow.Cells(0).Value

        txtBoxFname.Text = selectedRow.Cells(1).Value.ToString

        txtBoxMiddleName.Text = selectedRow.Cells(2).Value.ToString

        txtBoxLname.Text = selectedRow.Cells(3).Value.ToString

        txtBoxEmail.Text = selectedRow.Cells(4).Value.ToString

        txtBoxContactNumber.Text = selectedRow.Cells(5).Value

    End Sub
End Class