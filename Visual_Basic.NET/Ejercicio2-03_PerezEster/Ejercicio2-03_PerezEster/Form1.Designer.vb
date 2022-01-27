<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.PanelConfiguracion = New System.Windows.Forms.Panel()
        Me.btnConfi2 = New System.Windows.Forms.Button()
        Me.btnConfi1 = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.PanelMedia = New System.Windows.Forms.Panel()
        Me.btnLista3 = New System.Windows.Forms.Button()
        Me.btnLista2 = New System.Windows.Forms.Button()
        Me.btnLista1 = New System.Windows.Forms.Button()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelReproductor = New System.Windows.Forms.Panel()
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.PanelBarra.SuspendLayout()
        Me.PanelConfiguracion.SuspendLayout()
        Me.PanelMedia.SuspendLayout()
        Me.PanelReproductor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarra
        '
        Me.PanelBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.PanelBarra.Controls.Add(Me.PanelConfiguracion)
        Me.PanelBarra.Controls.Add(Me.btnConfiguracion)
        Me.PanelBarra.Controls.Add(Me.PanelMedia)
        Me.PanelBarra.Controls.Add(Me.btnMedia)
        Me.PanelBarra.Controls.Add(Me.PanelLogo)
        Me.PanelBarra.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBarra.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(214, 558)
        Me.PanelBarra.TabIndex = 0
        '
        'PanelConfiguracion
        '
        Me.PanelConfiguracion.Controls.Add(Me.btnConfi2)
        Me.PanelConfiguracion.Controls.Add(Me.btnConfi1)
        Me.PanelConfiguracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelConfiguracion.Location = New System.Drawing.Point(0, 333)
        Me.PanelConfiguracion.Name = "PanelConfiguracion"
        Me.PanelConfiguracion.Size = New System.Drawing.Size(214, 100)
        Me.PanelConfiguracion.TabIndex = 4
        '
        'btnConfi2
        '
        Me.btnConfi2.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnConfi2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfi2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnConfi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfi2.Location = New System.Drawing.Point(0, 29)
        Me.btnConfi2.Name = "btnConfi2"
        Me.btnConfi2.Size = New System.Drawing.Size(214, 29)
        Me.btnConfi2.TabIndex = 2
        Me.btnConfi2.Text = "Configuración 2"
        Me.btnConfi2.UseVisualStyleBackColor = False
        '
        'btnConfi1
        '
        Me.btnConfi1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnConfi1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfi1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnConfi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfi1.Location = New System.Drawing.Point(0, 0)
        Me.btnConfi1.Name = "btnConfi1"
        Me.btnConfi1.Size = New System.Drawing.Size(214, 29)
        Me.btnConfi1.TabIndex = 1
        Me.btnConfi1.Text = "Configuración 1"
        Me.btnConfi1.UseVisualStyleBackColor = False
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Georgia Pro Cond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.Location = New System.Drawing.Point(0, 289)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(214, 44)
        Me.btnConfiguracion.TabIndex = 3
        Me.btnConfiguracion.Text = "Configuración"
        Me.btnConfiguracion.UseVisualStyleBackColor = False
        '
        'PanelMedia
        '
        Me.PanelMedia.Controls.Add(Me.btnLista3)
        Me.PanelMedia.Controls.Add(Me.btnLista2)
        Me.PanelMedia.Controls.Add(Me.btnLista1)
        Me.PanelMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMedia.Location = New System.Drawing.Point(0, 169)
        Me.PanelMedia.Name = "PanelMedia"
        Me.PanelMedia.Size = New System.Drawing.Size(214, 120)
        Me.PanelMedia.TabIndex = 2
        '
        'btnLista3
        '
        Me.btnLista3.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnLista3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLista3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLista3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista3.Location = New System.Drawing.Point(0, 58)
        Me.btnLista3.Name = "btnLista3"
        Me.btnLista3.Size = New System.Drawing.Size(214, 29)
        Me.btnLista3.TabIndex = 2
        Me.btnLista3.Text = "Lista 3"
        Me.btnLista3.UseVisualStyleBackColor = False
        '
        'btnLista2
        '
        Me.btnLista2.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnLista2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLista2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLista2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista2.Location = New System.Drawing.Point(0, 29)
        Me.btnLista2.Name = "btnLista2"
        Me.btnLista2.Size = New System.Drawing.Size(214, 29)
        Me.btnLista2.TabIndex = 1
        Me.btnLista2.Text = "Lista 2"
        Me.btnLista2.UseVisualStyleBackColor = False
        '
        'btnLista1
        '
        Me.btnLista1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnLista1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLista1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLista1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista1.Location = New System.Drawing.Point(0, 0)
        Me.btnLista1.Name = "btnLista1"
        Me.btnLista1.Size = New System.Drawing.Size(214, 29)
        Me.btnLista1.TabIndex = 0
        Me.btnLista1.Text = "Lista 1"
        Me.btnLista1.UseVisualStyleBackColor = False
        '
        'btnMedia
        '
        Me.btnMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedia.Font = New System.Drawing.Font("Georgia Pro Cond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedia.Location = New System.Drawing.Point(0, 118)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Size = New System.Drawing.Size(214, 51)
        Me.btnMedia.TabIndex = 1
        Me.btnMedia.Text = "Media"
        Me.btnMedia.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PanelLogo.BackgroundImage = Global.Ejercicio2_03_PerezEster.My.Resources.Resources.icons8_notas_musicales_96
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(214, 118)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelReproductor
        '
        Me.PanelReproductor.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PanelReproductor.Controls.Add(Me.btnAdelante)
        Me.PanelReproductor.Controls.Add(Me.btnAtras)
        Me.PanelReproductor.Controls.Add(Me.btnPause)
        Me.PanelReproductor.Controls.Add(Me.btnPlay)
        Me.PanelReproductor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelReproductor.Location = New System.Drawing.Point(214, 430)
        Me.PanelReproductor.Name = "PanelReproductor"
        Me.PanelReproductor.Size = New System.Drawing.Size(796, 128)
        Me.PanelReproductor.TabIndex = 1
        '
        'btnAdelante
        '
        Me.btnAdelante.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnAdelante.BackgroundImage = Global.Ejercicio2_03_PerezEster.My.Resources.Resources.icons8_chevron_derecha_en_círculo_30
        Me.btnAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdelante.Location = New System.Drawing.Point(497, 44)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(66, 38)
        Me.btnAdelante.TabIndex = 3
        Me.btnAdelante.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnAtras.BackgroundImage = Global.Ejercicio2_03_PerezEster.My.Resources.Resources.icons8_chevron_izquierda_en_círculo_30
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(250, 44)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(71, 38)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnPause.BackgroundImage = Global.Ejercicio2_03_PerezEster.My.Resources.Resources.icons8_pausa_30
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Location = New System.Drawing.Point(337, 44)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(64, 38)
        Me.btnPause.TabIndex = 1
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnPlay.BackgroundImage = Global.Ejercicio2_03_PerezEster.My.Resources.Resources.icons8_play_30
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Location = New System.Drawing.Point(418, 44)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(61, 38)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'panelCentral
        '
        Me.panelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.panelCentral.BackgroundImage = Global.Ejercicio2_03_PerezEster.My.Resources.Resources.icons8_music_festival_100
        Me.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.Location = New System.Drawing.Point(214, 0)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(796, 430)
        Me.panelCentral.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 558)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.PanelReproductor)
        Me.Controls.Add(Me.PanelBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reproductor"
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelConfiguracion.ResumeLayout(False)
        Me.PanelMedia.ResumeLayout(False)
        Me.PanelReproductor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarra As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelMedia As Panel
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents PanelConfiguracion As Panel
    Friend WithEvents btnLista3 As Button
    Friend WithEvents btnLista2 As Button
    Friend WithEvents btnLista1 As Button
    Friend WithEvents PanelReproductor As Panel
    Friend WithEvents btnMedia As Button
    Friend WithEvents panelCentral As Panel
    Friend WithEvents btnConfi2 As Button
    Friend WithEvents btnConfi1 As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnAdelante As Button
    Friend WithEvents btnAtras As Button
End Class
