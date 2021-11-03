Public Class Form1
    Private Sub btnPrestamo_Click(sender As Object, e As EventArgs) Handles btnPrestamo.Click

        Dim User As String


        If txtNombre.Text.Length = 0 Then

            ErrorProvider1.SetError(Me.txtNombre, "vacío")
        Else
            User = txtNombre.Text
            MessageBox.Show("Se ha registrado correctamente", "Bienvenidx " & User, MessageBoxButtons.OK)
            Form2.Show()
            Me.Hide()
        End If




    End Sub



    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
