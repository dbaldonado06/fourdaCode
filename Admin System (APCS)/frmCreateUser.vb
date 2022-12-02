Imports System.Data.SqlClient
Public Class frmCreateUser
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        RegisterUser.Show()
    End Sub

    Sub LoadRecords()

        Connection()
        cmd = New SqlCommand("SELECT * FROM [Users],[Owner],[Employees]") With {
            .Connection = con
        }
        Dim i As Integer
        dr = cmd.ExecuteReader
        'still have an error not fix yet
        While dr.Read()
            i += 1
            dataGridViewUserfrm.Rows.Add(i, dr.Item("Username").ToString, dr.Item("Password").ToString, dr.Item("Adress").ToString, dr.Item("ContactNumber").ToString, dr.Item("EmailAdress").ToString)
        End While
        con.Close()
        dr.Close()
    End Sub
End Class