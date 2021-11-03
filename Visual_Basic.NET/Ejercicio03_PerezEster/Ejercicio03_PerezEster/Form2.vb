Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario As String = Form1.txtNombre.Text

        lblBienvenido.Text += usuario
    End Sub

    Private Sub btnSolicitud_Click(sender As Object, e As EventArgs) Handles btnSolicitud.Click


        Dim solucion As Double
        Dim porcentaje As Double


        If cbRaza.SelectedItem = "Hombre" Or cbRaza.SelectedItem = "Hobbit" Then
            porcentaje = (Val(txtPrestamo.Text) * 10) / 100
            solucion = Val(txtPrestamo.Text) + porcentaje
            Form3.txtSolucion.Text = solucion
        ElseIf cbRaza.SelectedItem = "Orco" Or cbRaza.SelectedItem = "Elfo" Then

            porcentaje = (Val(txtPrestamo.Text) * 15) / 100
            solucion = Val(txtPrestamo.Text) + porcentaje
            Form3.txtSolucion.Text = solucion
        Else
            solucion = Val(txtPrestamo.Text)
            Form3.txtSolucion.Text = solucion
        End If


        If cbLugar.SelectedItem = "La Comarca" Or cbLugar.SelectedItem = "Rivendel" Then
            solucion = solucion + 95
            Form3.txtSolucion.Text = solucion
        Else
            Form3.txtSolucion.Text = solucion
        End If

        If cbCuotas.SelectedItem = "6 meses" Then
            solucion = solucion / 6
            Form3.txtSolucion.Text = solucion
        ElseIf cbCuotas.SelectedItem = "12 meses" Then
            solucion = solucion / 12
            Form3.txtSolucion.Text = solucion

        ElseIf cbCuotas.SelectedItem = "24 meses" Then
            solucion = solucion / 24
            Form3.txtSolucion.Text = solucion

        ElseIf cbCuotas.SelectedItem = "36 meses" Then
            solucion = solucion / 36
            Form3.txtSolucion.Text = solucion

        End If



        If txtPrestamo.Text.Length <= 0 Or cbCuotas.SelectedItem = "" Or cbLugar.SelectedItem = "" Or cbRaza.SelectedItem = "" Then
            MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form3.Show()
            Me.Hide()
        End If






    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class