Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCaption1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Num, Num1 As Integer
        Dim sum, dif, prod, quo As Single
        Num = txtNum.Text
        Num1 = txtNum1.Text
        sum = Num + Num1
        dif = Num - Num1
        prod = Num * Num1
        quo = Num / Num1
        lblDisplaySum.Text = sum
        lblDisplayDif.Text = dif
        lblDisplayProd.Text = prod
        lblDisplayQuo.Text = quo
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure to exit application?", "Math Operations", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNum.Text = ""
        txtNum1.Text = ""
        lblDisplaySum.Text = ""
        lblDisplayDif.Text = ""
        lblDisplayProd.Text = ""
        lblDisplayQuo.Text = ""
        txtNum.Focus()

        lblDisplaySum.Text = "_______"
        lblDisplayDif.Text = "_______"
        lblDisplayProd.Text = "_______"
        lblDisplayQuo.Text = "_______"
    End Sub
End Class
