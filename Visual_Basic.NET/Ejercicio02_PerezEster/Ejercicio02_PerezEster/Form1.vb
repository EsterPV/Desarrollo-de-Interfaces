Public Class Form1

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click

        OpenFileDialog1.Filter = "JPG | *.jpg; *.png"

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        If txtNombre.Text.Length = 0 Then
            MessageBox.Show("El campo nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("La contraseña debe ser de 6 caracteres o más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If DateDiff(DateInterval.Year, dtpFecha.Value, Date.Now) <= 18 Then
            MessageBox.Show("El usuario debe ser mayor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If IsNothing(PictureBox1.Image) Then
            MessageBox.Show("Debe escoger una foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If txtNombre.Text.Length >= 1 And txtPassword.Text >= 6 And DateDiff(DateInterval.Year, dtpFecha.Value, Date.Now) >= 18 And IsNothing(PictureBox1.Image) = False Then
            MessageBox.Show("Usuario creado correctamente", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
