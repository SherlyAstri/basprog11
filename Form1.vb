Public Class Form1

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        Dim n, i, fac, fib, kuad As Integer
        n = txtn.Text

        fac = 1
        For i = 1 To n
            fac = i * fac
            txtfak.Text = fac

        Next

        fib = 0
        For i = 1 To n
            fib = i + fib
            txtfib.Text = fib
        Next


        kuad = n * n

        txtkuad.Text = kuad

    End Sub
End Class