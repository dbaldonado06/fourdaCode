Imports System.Data.SqlClient
Module DBConnection
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Sub Connection()
        Dim DSource As String = "Data Source=" + System.Environment.GetEnvironmentVariable("COMPUTERNAME") + "\SQLEXPRESS;"
        Dim IntCatSec As String = "Initial Catalog=APCS_DB;Integrated Security=True"
        Dim ConString As String = DSource + IntCatSec
        Try
            con = New SqlConnection(ConString)
            'code representation above: con = New SqlConnection("Data Source=COMPUTERNAME\SQLEXPRESS;Initial Catalog=APCS_DB;Integrated Security=True") 'connection string'
            con.Open()
        Catch ex As Exception
            MsgBox("Connection error! Check: DBConnection.vb", Title:="DATABASE WARNING!")
            Application.Exit()
        End Try

    End Sub
End Module
