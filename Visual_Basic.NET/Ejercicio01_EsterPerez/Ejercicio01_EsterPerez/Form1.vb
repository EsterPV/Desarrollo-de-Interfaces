Public Class Form1
    Private Sub rdAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rdAzul.CheckedChanged



        If (rdAzul.Checked) Then

            boxResultado.BackColor = Color.Blue


        End If



    End Sub

    Private Sub rdRojo_CheckedChanged(sender As Object, e As EventArgs) Handles rdRojo.CheckedChanged

        If (rdRojo.Checked) Then

            boxResultado.BackColor = Color.Red


        End If
    End Sub

    Private Sub rdVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rdVerde.CheckedChanged

        If (rdVerde.Checked) Then

            boxResultado.BackColor = Color.Green


        End If
    End Sub

    Private Sub rdAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rdAmarillo.CheckedChanged

        If (rdAmarillo.Checked) Then

            boxResultado.BackColor = Color.Yellow


        End If
    End Sub

    Private Sub rdArriba_CheckedChanged(sender As Object, e As EventArgs) Handles rdArriba.CheckedChanged

        If (rdArriba.Checked) Then

            boxResultado.Top = 15





        End If
    End Sub

    Private Sub rdAbajo_CheckedChanged(sender As Object, e As EventArgs) Handles rdAbajo.CheckedChanged
        If (rdAbajo.Checked) Then

            boxResultado.Top = 115





        End If

    End Sub
End Class
