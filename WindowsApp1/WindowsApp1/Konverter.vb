Public Class Konverter

    Public Function convertToCelcius(ByVal nilai As Double) As Double

        Return 5 / 9 * (nilai - 32)

    End Function

    Public Function convertToFarenheit(ByVal nilai As Double) As Double
        Return (nilai * 9 / 5) + 32
    End Function

End Class
