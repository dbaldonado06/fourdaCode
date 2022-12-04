Imports System.Data.SqlClient
Public Class frmCreateUser
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        RegisterUser.btnRegUserUpdate.Enabled = False
        RegisterUser.Show()
        dataGridViewUserfrm.ClearSelection()
    End Sub

    Sub LoadRecords()
        dataGridViewUserfrm.ClearSelection()

        Connection()
        cmd = New SqlCommand("SELECT E.EmployeeID, U.Username, U.FName, U.MName, U.LName, E.EmailAdress, E.Adress, E.ContactNumber FROM [Employees] E
                            INNER JOIN [Users] U
                            ON E.UserID = U.ID") With {
                            .Connection = con
                            }
        Dim i As Integer
        dr = cmd.ExecuteReader
        While dr.Read()
            i += 1
            dataGridViewUserfrm.Rows.Add(i, dr.Item("Username").ToString,
                                         dr.Item("FName").ToString + " " + dr.Item("MName").ToString + ". " + dr.Item("LName").ToString,
                                         dr.Item("EmailAdress").ToString, dr.Item("Adress").ToString, dr.Item("ContactNumber").ToString)
        End While
        con.Close()
        dr.Close()
    End Sub
End Class