Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSideA.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcC.Click
        Dim numA, numB, numC As Integer
        numA = txtSideA.Text
        numB = txtSideB.Text
        numC = (numA ^ 2 + numB ^ 2) ^ (1 / 2)
        lblDisplayC.Text = numC

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSideA.Text = ""
        txtSideB.Text = ""
        lblDisplayC.Text = ""
        txtSideA.Focus()

        lblDisplayC.Text = "Display other side"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure to exit application?", "Pythagoras Theorem", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
