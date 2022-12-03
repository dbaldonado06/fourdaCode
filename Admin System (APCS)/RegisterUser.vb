Imports System.Data.SqlClient
Public Class RegisterUser
    Public UNdr As SqlDataReader
    Public CNdr As SqlDataReader
    Public EMdr As SqlDataReader
    Public IDdr As SqlDataReader
    Public InCmd As SqlCommand

    Private Sub btnCancelUser_Click(sender As Object, e As EventArgs) Handles btnCancelUser.Click
        Me.Dispose()
    End Sub

    Private Sub RegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRoleSelection.Text = "Employee"
        GenderComboBox.Text = "Prefer not to respond"
    End Sub
    Sub LoadWarning(WarningMsg As String)
        RUWarningLbl.ForeColor = Color.Red
        RUWarningLbl.Text = WarningMsg
    End Sub

    Private Sub btnRegUserSave_Click(sender As Object, e As EventArgs) Handles btnRegUserSave.Click
        Dim i As Integer = 2
        Dim userRowAff As Integer = 0
        Dim EmpRowAff As Integer = 0
        Dim UID As Integer
        If (txtBoxRegUserFirstname.Text = "" And
            txtBoxRegUserMiddlename.Text = "" And
            txtBoxRegUserLastname.Text = "" And
            txtBoxRegUserUsername.Text = "" And
            txtBoxRegUserPassword.Text = "" And
            txtBoxRegUserAddress.Text = "" And
            txtBoxRegUserContactNum.Text = "" And
            txtBoxRegUserEmail.Text = "" And
            txtUserAge.Text = "") Then
            txtBoxRegUserFirstname.Focus()
            LoadWarning("Complete the form!")
        ElseIf (txtBoxRegUserContactNum.Text.Length <> 11) Then
            txtBoxRegUserContactNum.Focus()
            LoadWarning("Invalid number!")
        ElseIf (Not IsNumeric(txtUserAge.Text)) Then
            txtUserAge.Focus()
            txtUserAge.Text = ""
            LoadWarning("The symbol you enter is not valid character for age!")
        Else
            LoadWarning("")
        End If
        Try
            Dim UsernameChecker, ContactnumChecker, EmailChecker As Boolean
            Connection()
            cmd = New SqlCommand("SELECT Username FROM [Users] WHERE Username = '" & txtBoxRegUserUsername.Text & "'") With {
                                .Connection = con}
            UNdr = cmd.ExecuteReader()
            UsernameChecker = UNdr.Read()
            UNdr.Close()
            cmd = New SqlCommand("SELECT ContactNumber FROM [Employees] WHERE ContactNumber = '" & txtBoxRegUserContactNum.Text & "'") With {
                                .Connection = con}
            CNdr = cmd.ExecuteReader()
            ContactnumChecker = CNdr.Read()
            CNdr.Close()
            cmd = New SqlCommand("SELECT EmailAdress FROM [Employees] WHERE EmailAdress = '" & txtBoxRegUserEmail.Text & "'") With {
                                .Connection = con}
            EMdr = cmd.ExecuteReader()
            EmailChecker = EMdr.Read()
            EMdr.Close()
            If (UsernameChecker) Then
                txtBoxRegUserUsername.Focus()
                txtBoxRegUserUsername.Text = ""
                LoadWarning("Username is taken.")
            ElseIf (ContactnumChecker) Then
                txtBoxRegUserContactNum.Focus()
                LoadWarning("""*********" + txtBoxRegUserContactNum.Text.ToString.Substring(7, 4) + """ is already used.")
                txtBoxRegUserContactNum.Text = ""
            ElseIf (EmailChecker) Then
                txtBoxRegUserEmail.Focus()
                Dim emlStr As String
                emlStr = txtBoxRegUserEmail.Text.ToString
                LoadWarning("""" + emlStr.Substring(0, 3) + "****" + emlStr.Substring(7) + """ is already used.")
                txtBoxRegUserEmail.Text = ""
            Else
                If (ComboBoxRoleSelection.Text = "Admin") Then
                    i = 1
                End If

                cmd = New SqlCommand("INSERT INTO [Users](Username,Password,Usertype,FName,MName,LName)
                                VALUES('" & txtBoxRegUserUsername.Text & "','" & txtBoxRegUserPassword.Text & "','" & i & "','" & txtBoxRegUserFirstname.Text & "','" & txtBoxRegUserMiddlename.Text & "','" & txtBoxRegUserLastname.Text & "' )") With {
                                    .Connection = con
                                    }
                userRowAff = cmd.ExecuteNonQuery()

                InCmd = New SqlCommand("SELECT ID FROM [Users] WHERE Username = '" & txtBoxRegUserUsername.Text & "'") With {
                                    .Connection = con}
                IDdr = InCmd.ExecuteReader()
                If (IDdr.Read()) Then
                    UID = IDdr("ID")
                End If
                IDdr.Close()
                cmd = New SqlCommand("INSERT INTO [Employees](UserID,Gender,Age,Adress,ContactNumber,EmailAdress)
                                VALUES('" & UID & "','" & GenderComboBox.Text & "','" & txtUserAge.Text & "','" & txtBoxRegUserAddress.Text & "','" & txtBoxRegUserContactNum.Text & "','" & txtBoxRegUserEmail.Text & "' )") With {
                                    .Connection = con
                                    }
                EmpRowAff = cmd.ExecuteNonQuery()
                If (userRowAff > 0 And EmpRowAff > 0) Then
                    MsgBox(txtBoxRegUserUsername.Text + " is now registered!", Title:="Registration Complete!")
                    userRowAff = 0
                    userRowAff = 0
                    Me.Dispose()
                Else
                    MsgBox("Not stored in database")
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception

        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnRegUserUpdate_Click(sender As Object, e As EventArgs) Handles btnRegUserUpdate.Click

    End Sub
End Class