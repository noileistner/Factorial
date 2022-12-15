Public Class Form1
    Dim Number, x As Integer
    Dim f As Long

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number = TextBox.Text

        If Number > 20 Then
            LabelResult.Text = "No puc calcular el factorial de números majors que 20!"
            Return
        End If

        f = 1
        For x = 1 To Number
            f *= x
        Next
        LabelResult.Text = Str(f)
    End Sub
End Class
