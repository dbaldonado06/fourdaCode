Imports System.Data
Imports System.Data.SqlClient
Module DBConnection
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Sub Connection()
        con = New SqlConnection("Data Source=IAMNAD\SQLEXPRESS;Initial Catalog=APCS_DB;Integrated Security=True") 'connection string'
        con.Open()
        'Dim conStr As String() = {"sasasa", "Data Source=IAMNAD\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"}
        'Dim i As Integer
        'For i = 0 To conStr.Length - 1
        '    con = New SqlConnection(conStr(i))
        '    Try
        '        con.Open()
        '    Catch ex As Exception

        '    End Try
        '    If (con.Open()) Then

        '    Else
        '        MsgBox("invalid connection string, add your own connection string inside dbconnection module!")
        '    End If
        'Next
    End Sub
End Module
