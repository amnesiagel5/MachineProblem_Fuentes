Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtName.Text = ""
        TxtAge.Text = ""
        TxtHeight.Text = ""
        TxtWeight.Text = ""
        TxtName.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result = MessageBox.Show("Are you sure to exit application?", "BMI Calculator", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnBMICalc_Click(sender As Object, e As EventArgs) Handles BtnBMICalc.Click
        Dim h, w, bmi As Single

        h = TxtHeight.Text
        w = TxtWeight.Text
        bmi = (w) / (h ^ 2)

        'MsgBox("BMI is: " & bmi & " kg/m2.")

        If bmi <= 18.5 Then
            Me.BackColor = Color.Yellow
            MsgBox("Hi! " & TxtName.Text & "." & vbCrLf & "You are " & TxtAge.Text & " years old." & vbCrLf & "Your BMI is " & bmi & " and you're Underweight.")
            Me.BackColor = Color.WhiteSmoke
        ElseIf bmi <= 24.9 Then
            Me.BackColor = Color.Green
            MsgBox("Hi! " & TxtName.Text & "." & vbCrLf & "You are " & TxtAge.Text & " years old." & vbCrLf & "Your BMI is " & bmi & " and you're in Normal Weight.")
            Me.BackColor = Color.WhiteSmoke
        ElseIf bmi <= 29.9 Then
            Me.BackColor = Color.Orange
            MsgBox("Hi! " & TxtName.Text & "." & vbCrLf & "You are " & TxtAge.Text & " years old." & vbCrLf & "Your BMI is " & bmi & " and you're Overweight.")
            Me.BackColor = Color.WhiteSmoke
        ElseIf bmi >= 30 Then
            Me.BackColor = Color.Red
            MsgBox("Hi! " & TxtName.Text & "." & vbCrLf & "You are " & TxtAge.Text & " years old." & vbCrLf & "Your BMI is " & bmi & " and you're Obese.")
            Me.BackColor = Color.WhiteSmoke
        End If
    End Sub
End Class
