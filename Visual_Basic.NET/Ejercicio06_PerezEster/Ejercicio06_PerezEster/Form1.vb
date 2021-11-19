Public Class Form1
    Private Sub btnAnhadir_Click(sender As Object, e As EventArgs) Handles btnAnhadir.Click
        ListBoxPeliculas.Items.Add(txtAnhadir.Text)
        txtAnhadir.Text = ""
        txtAnhadir.Focus()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim guardar As New SaveFileDialog
        guardar.Filter = "Archivo Text | *.txt"
        If guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(guardar.FileName)

            For Each item In ListBoxPeliculas.Items
                sw.WriteLine(item.ToString())
            Next

            sw.Close()
        End If

        Dim respuesta As MsgBoxResult
        respuesta = MessageBox.Show("¿Desea limpiar la lista", "Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = vbYes Then
            ListBoxPeliculas.Items.Clear()
        End If

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim ruta As String = ""
        Dim abrirFD As New OpenFileDialog()
        With abrirFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Text(*.Txt*.txt)|*.Txt;*txt|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = .FileName
            End If
        End With
        Dim sr As New System.IO.StreamReader(ruta)
        While Not sr.EndOfStream
            ListBoxPeliculas.Items.Add(sr.ReadLine())
        End While
        sr.Close()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub txtAnhadir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnhadir.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnAnhadir.PerformClick()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPeliculas.SelectedIndexChanged
        Dim I As String
        I = ListBoxPeliculas.SelectedItem
        If ListBoxPeliculas.SelectedItem = "Trainspotting" Then
            PictureBoxPortada.Image = My.Resources.trainspotting_carátula
        End If
        If ListBoxPeliculas.SelectedItem = "Luca" Then
            PictureBoxPortada.Image = My.Resources.Luca_cover
        End If
        If ListBoxPeliculas.SelectedItem = "Spencer" Then
            PictureBoxPortada.Image = My.Resources.Spencer
        End If
        If ListBoxPeliculas.SelectedItem = "Last night in Soho" Then
            PictureBoxPortada.Image = My.Resources.ltima_noche_en_el_Soho_763337056_large
        End If
        If ListBoxPeliculas.SelectedItem = "Una joven prometedora" Then
            PictureBoxPortada.Image = My.Resources.Una_joven_prometedora_192277202_large
        End If
        If ListBoxPeliculas.SelectedItem = "El club de la lucha" Then
            PictureBoxPortada.Image = My.Resources.El_club_de_la_lucha_996839610_large

        End If
        If ListBoxPeliculas.SelectedItem = "Scott Pilgrim VS the world" Then
            PictureBoxPortada.Image = My.Resources.ScottPilgrim
        End If
        If ListBoxPeliculas.SelectedItem = "Hereditary" Then
            PictureBoxPortada.Image = My.Resources.Hereditary_411242403_large
        End If
    End Sub
End Class



