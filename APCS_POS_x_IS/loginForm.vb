Imports System.Data.SqlClient
Public Class loginForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Loginbutton.Click
        If (UsernameText.Text = "" Or PasswordText.Text = "") Then
            UsernameText.Focus() 'focus username textbox'
            WarningLabel.ForeColor = Color.Red
            WarningLabel.Text = "Enter Username Or Password!"
            Exit Sub
        End If
        Try
            Connection()
            cmd = New SqlCommand("SELECT * FROM [Users] WHERE Username='" & UsernameText.Text & "' AND Password = '" & PasswordText.Text & "'")
            cmd.Connection = con
            dr = cmd.ExecuteReader()
            PosForm.DateAndTime.Start()
            If (dr.Read()) Then

                With MainForm
                    .UserLabelPOS.Text = dr("FName") + " " + dr("MName") + ". " + dr("LName")
                    .Show()
                    .switchPanel(PosForm)
                    Me.Hide()
                End With
            Else
                WarningLabel.ForeColor = Color.Red
                WarningLabel.Text = "Invalid Username Or Password!"
                UsernameText.Text = ""
                PasswordText.Text = ""
                UsernameText.Focus() 'focus username textbox'
            End If
        Catch ex As Exception
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Loginbutton_Click(sender As Object, e As EventArgs) Handles Loginbutton.Click

    End Sub
End Class
