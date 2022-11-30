Public Class ProductentryForm
    Private Sub btnProductEntrySave_Click(sender As Object, e As EventArgs) Handles btnProductEntrySave.Click
        Close()
    End Sub

    Private Sub txtProductEntryID_TextChanged(sender As Object, e As EventArgs) Handles txtProductEntryID.TextChanged

    End Sub

    Private Sub lblIDProductEntry_Click(sender As Object, e As EventArgs) Handles lblIDProductEntry.Click

    End Sub

    Private Sub btnProductEntryBrowseImage_Click(sender As Object, e As EventArgs) Handles btnProductEntryBrowseImage.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg,|*jpg|Png,|*.png|Bmp,|*.bmp|Gif,|*.gif|Ico,|*.ico",
                .Multiselect = False, .Title = "Select Image"}

            If ofd.ShowDialog = 1 Then
                picBoxProductEntry.BackgroundImage = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnProductEntryCancel_Click(sender As Object, e As EventArgs) Handles btnProductEntryCancel.Click
        Close()
    End Sub

    Private Sub btnProductEntryUpdate_Click(sender As Object, e As EventArgs) Handles btnProductEntryUpdate.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub picBoxProductEntry_Click(sender As Object, e As EventArgs) Handles picBoxProductEntry.Click

    End Sub

    Private Sub comboProductEntryStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProductEntryStatus.SelectedIndexChanged

    End Sub

    Private Sub lblProductMenuStatus_Click(sender As Object, e As EventArgs) Handles lblProductMenuStatus.Click

    End Sub

    Private Sub lblProductMenuPrice_Click(sender As Object, e As EventArgs) Handles lblProductMenuPrice.Click

    End Sub

    Private Sub txtProductEntryPrice_TextChanged(sender As Object, e As EventArgs) Handles txtProductEntryPrice.TextChanged

    End Sub

    Private Sub comboProductEntryCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProductEntryCategory.SelectedIndexChanged

    End Sub

    Private Sub lblProductMenuCategory_Click(sender As Object, e As EventArgs) Handles lblProductMenuCategory.Click

    End Sub

    Private Sub txtProductEntryDescription_TextChanged(sender As Object, e As EventArgs) Handles txtProductEntryDescription.TextChanged

    End Sub

    Private Sub lblProductEntryDescription_Click(sender As Object, e As EventArgs) Handles lblProductEntryDescription.Click

    End Sub

    Private Sub lblProductEntryClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblProductEntry_Click(sender As Object, e As EventArgs) Handles lblProductEntry.Click

    End Sub

    Private Sub pnlProductEntry_Paint(sender As Object, e As PaintEventArgs) Handles pnlProductEntry.Paint

    End Sub
End Class