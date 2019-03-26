Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try
            Dim nilai As Double = Convert.ToDouble(TextBoxCelcius.Text)
            Dim konverter As Object
            konverter = New Konverter()
            TextBoxFarenheit.Text = konverter.convertToFarenheit(nilai)
            errorMessage.Visible = False

        Catch ex As Exception
            errorMessage.Text = "Input Harus Angka"
            errorMessage.Visible = True




        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim nilai As Double = Convert.ToDouble(TextBoxFarenheit.Text)
            Dim konverter As Object
            konverter = New Konverter()
            TextBoxCelcius.Text = konverter.convertToCelcius(nilai)
            errorMessage.Visible = False
        Catch ex As Exception

            errorMessage.Text = "Input Harus Angka"
            errorMessage.Visible = True

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles errorMessage.Click

    End Sub
End Class