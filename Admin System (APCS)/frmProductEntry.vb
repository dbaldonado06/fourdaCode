Public Class frmProductEntry
    Private Sub lblProductEntryClose_Click(sender As Object, e As EventArgs) Handles lblProductEntryClose.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmCategory
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnProductEntryBrowseImage.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg,|*jpg|Png,|*.png|Bmp,|*.bmp|Gif,|*.gif|Ico,|*.ico",
                .Multiselect = False, .Title = "Select Image"}

            If ofd.ShowDialog = 1 Then
                picBoxProductEntry.BackgroundImage = Image.FromFile(ofd.FileName)
            End If

        End Using
    End Sub

    Private Sub picBoxProductEntry_Click(sender As Object, e As EventArgs) Handles picBoxProductEntry.Click

    End Sub

    Private Sub comboProductEntryStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProductEntryStatus.SelectedIndexChanged

    End Sub
End Class