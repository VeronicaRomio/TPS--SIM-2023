Public Class GeneradorVariables
    Dim random As Random

    Sub New()
        random = New Random
    End Sub

    Public Function generarUniforme(ByVal a As Integer, ByVal b As Integer) As Double
        Return a + random.NextDouble() * (b - a)
    End Function

    Public Function generarExponencialNegativa(ByVal media As Double) As Double
        Return media * -1 * Math.Log(1 - random.NextDouble())
    End Function

    Public Function generarNormal(ByVal media As Double, ByVal desviacionEst As Double) As Double
        Dim acu As Double = 0
        For index = 1 To 12
            acu += random.NextDouble()

        Next index
        acu -= 6
        Return acu * desviacionEst + media
    End Function


End Class
