Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmLogin
    Private Sub btnLoginUser_Click(sender As Object, e As EventArgs) Handles btnLoginUser.Click
        If (txtBoxLoginUsername.Text = "" Or txtBoxLoginPassword.Text = "") Then
            txtBoxLoginUsername.Focus() 'focus username textbox'
            WarningLabel.ForeColor = Color.Red
            WarningLabel.Text = " Enter Username Or Password!"
            Exit Sub
        End If
        Try
            Connection()
            cmd = New SqlCommand("SELECT * FROM [Users] WHERE Username='" & txtBoxLoginUsername.Text & "' AND Password = '" & txtBoxLoginPassword.Text & "'")
            cmd.Connection = con
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                If (dr("Usertype") = 1) Then
                    frmUserEntry.ID = dr("Usertype")
                    With frmUserEntry
                        .Show()
                        .switchPanel(frmDashboard)
                        Me.Hide()
                    End With
                Else
                    MsgBox("Hello " + dr("Username") + ", you have been denied to access the SYSTEM!", Title:="Warning!")
                    txtBoxLoginUsername.Text = ""
                    txtBoxLoginPassword.Text = ""
                    txtBoxLoginUsername.Focus() 'focus username textbox'
                End If
            Else
                WarningLabel.ForeColor = Color.Red
                WarningLabel.Text = "Invalid Username Or Password!"
                txtBoxLoginUsername.Text = ""
                txtBoxLoginPassword.Text = ""
                txtBoxLoginUsername.Focus() 'focus username textbox'
            End If
        Catch ex As Exception

        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Dispose()
    End Sub

    Private Sub minimizeButton_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sender.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        DGP.AddLine(20, 0, sender.Width - 20, 0)

        'top right corner
        DGP.AddArc(New Rectangle(sender.Width - 20, 0, 20, 20), -90, 90)
        DGP.AddLine(sender.Width, 20, sender.Width, sender.Height - 20)

        'bottom right corner
        DGP.AddArc(New Rectangle(sender.Width - 20, sender.Height - 20, 20, 20), 0, 90)
        DGP.AddLine(sender.Width - 20, sender.Height, 20, sender.Height)

        'bottom left corner
        DGP.AddArc(New Rectangle(0, sender.Height - 20, 20, 20), 90, 90)
        DGP.CloseFigure()

        sender.Region = New Region(DGP)

    End Sub

End Class