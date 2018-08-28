Imports info.lundin.math
Public Class Metodo_biseccion
    Dim a, b, n, ec As Single
    Dim fa, fb As Single
    Dim x(50), er(50) As Single
    Dim i, redon As Integer
    Dim cadena As String
    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        n = tcs.Text
        a = ta.Text
        b = tb.Text
        redon = n + 2
        ec = 0.5 * 10 ^ (-n)
        x(i) = (a + b) / 2
        er(i) = 1
        salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon), Math.Round(b, redon), Math.Round(f(a), redon), Math.Round(f(x(i)), redon), Math.Round(f(b), redon), Math.Round(er(i), redon))
        Do While er(i) > ec
            If f(a) * f(x(i)) < 0 Then
                b = x(i)
            Else
                a = x(i)
            End If
            x(i + 1) = (a + b) / 2
            er(i + 1) = Math.Abs((x(i + 1) - x(i)) / x(i + 1))

            salida.Rows.Add(i + 1, Math.Round(a, redon), Math.Round(x(i + 1), redon), Math.Round(b, redon), Math.Round(f(a), redon), Math.Round(f(x(i + 1)), redon), Math.Round(f(b), redon), Math.Round(er(i + 1), redon))

            i = i + 1
        Loop
    End Sub
End Class
