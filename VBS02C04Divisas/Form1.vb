Public Class Form1
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TXT1.TextChanged

    End Sub

    Private Sub Cambio_Click(sender As Object, e As EventArgs) Handles Cambio.Click
        Dim cambio As Double
        Dim centimos = New Integer() {50, 20, 10, 5, 2, 1}
        Dim monedas(5) As Integer
        Dim index As Integer
        Dim txt As String

        'students(0)'

        cambio = CDbl(TXTEuros.Text.Trim) * 100

        'calculos'

        While 0 < cambio

            monedas(index) = Int(cambio / centimos(index))
            cambio = cambio - (centimos(index) * monedas(index))
            index = index + 1
        End While

        'For index As Integer = 1 To 5'
        'monedas(index) = Int(cambio / centimos(index))
        'cambio = cambio - (centimos(index) * monedas(index))
        'Next 




        TXT50.Text = monedas(0)
        TXT20.Text = monedas(1)
        TXT10.Text = monedas(2)
        TXT5.Text = monedas(3)
        TXT2.Text = monedas(4)
        TXT1.Text = monedas(5)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TXTEuros_TextChanged(sender As Object, e As EventArgs) Handles TXTEuros.TextChanged

    End Sub
End Class
