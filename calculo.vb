Public Class calculo
    Public x1 As Double
    Public x2 As Double
    Public y1 As Double
    Public y2 As Double
    Public resul As Double
    Public Sub New()
    End Sub

    'Metodos
    Public Sub New(x1 As Double, x2 As Double, y1 As Double, y2 As Double, resul As Double)
        Me.x1 = x1
        Me.x2 = x2
        Me.y1 = y1
        Me.y2 = y2
        Me.resul = resul
    End Sub

    Public Function Hipotenusa(x1 As Double, x2 As Double, y1 As Double, y2 As Double)
        Me.resul = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2))
        Return resul
    End Function
End Class
