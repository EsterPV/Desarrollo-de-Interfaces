Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()

    End Sub

    Private Sub hideSubmenu()
        PanelConfiguracion.Visible = False
        PanelMedia.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        showSubmenu(PanelMedia)
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        showSubmenu(PanelConfiguracion)
    End Sub

    Private currentForm As Form = Nothing

    Private Sub openChildForm(childForm As Form) 'Método con un variable que es un formulario
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False 'el formulario que se abre se comporta como un control, un nivel inferior
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelCentral.Controls.Add(childForm) 'Agregamos los controles del formulario al formulario que se abre
        panelCentral.Tag = childForm 'Asociamos el formulario hijo al panel contenedor
        childForm.BringToFront() 'Traemos al formulario al frente
        childForm.Show() ' Mostramos el formulario hijo

    End Sub

    Private Sub btnLista1_Click(sender As Object, e As EventArgs) Handles btnLista1.Click
        openChildForm(FormLista1)
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If FormLista1.Visible = True Then
            FormLista1.selectedSong()
        End If
        If FormLista2.Visible = True Then
            FormLista2.selectedSong()
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If FormLista1.Visible = True Then
            FormLista1.backSong()
        End If
        If FormLista2.Visible = True Then
            FormLista2.backSong()
        End If
    End Sub

    Private Sub btnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        If FormLista1.Visible = True Then
            FormLista1.nextSong()
        End If
        If FormLista2.Visible = True Then
            FormLista2.nextSong()
        End If
    End Sub

    Private Sub btnLista2_Click(sender As Object, e As EventArgs) Handles btnLista2.Click
        openChildForm(FormLista2)
    End Sub
End Class
