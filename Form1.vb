Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim resultado As calculo = New calculo()
        txtResultado.Text = resultado.Hipotenusa(txtX2.Text, txtX1.Text, txtY2.Text, txtY1.Text)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtX1.Clear()
        txtX2.Clear()
        txtY1.Clear()
        txtY2.Clear()
        txtResultado.Clear()

    End Sub
End Class
