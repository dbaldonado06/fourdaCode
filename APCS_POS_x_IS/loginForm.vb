Public Class loginForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles userProfile.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Hide()
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
