Public Class ChangingFontStyles
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxBold.CheckedChanged
        If chkboxBold.Checked Then
            txtWords.Font = New Font(txtWords.Font, txtWords.Font.Style Or FontStyle.Bold)
        Else
            txtWords.Font = New Font(txtWords.Font, txtWords.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxItalic.CheckedChanged
        If chkboxItalic.Checked Then
            txtWords.Font = New Font(txtWords.Font, txtWords.Font.Style Or FontStyle.Italic)
        Else
            txtWords.Font = New Font(txtWords.Font, txtWords.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxUnderline.CheckedChanged
        If chkboxUnderline.Checked Then
            txtWords.Font = New Font(txtWords.Font, txtWords.Font.Style Or FontStyle.Underline)
        Else
            txtWords.Font = New Font(txtWords.Font, txtWords.Font.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWords.Text = ""
        chkboxBold.Checked = False
        chkboxItalic.Checked = False
        chkboxUnderline.Checked = False
        txtWords.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure to exit application?", "Changing Font Styles", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
