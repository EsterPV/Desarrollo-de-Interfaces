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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnhadir = New System.Windows.Forms.TextBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnAnhadir = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBoxPortada = New System.Windows.Forms.PictureBox()
        Me.ListBoxPeliculas = New System.Windows.Forms.ListBox()
        CType(Me.PictureBoxPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(269, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista Películas"
        '
        'txtAnhadir
        '
        Me.txtAnhadir.Location = New System.Drawing.Point(45, 73)
        Me.txtAnhadir.Name = "txtAnhadir"
        Me.txtAnhadir.Size = New System.Drawing.Size(274, 22)
        Me.txtAnhadir.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.Gold
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(62, 355)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(123, 36)
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnAnhadir
        '
        Me.btnAnhadir.BackColor = System.Drawing.Color.Gold
        Me.btnAnhadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnhadir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnhadir.Location = New System.Drawing.Point(365, 66)
        Me.btnAnhadir.Name = "btnAnhadir"
        Me.btnAnhadir.Size = New System.Drawing.Size(117, 29)
        Me.btnAnhadir.TabIndex = 3
        Me.btnAnhadir.Text = "Añadir"
        Me.btnAnhadir.UseVisualStyleBackColor = False
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.Gold
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Location = New System.Drawing.Point(359, 355)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(123, 36)
        Me.btnImportar.TabIndex = 4
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Coral
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(622, 355)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 36)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PictureBoxPortada
        '
        Me.PictureBoxPortada.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxPortada.Location = New System.Drawing.Point(547, 117)
        Me.PictureBoxPortada.Name = "PictureBoxPortada"
        Me.PictureBoxPortada.Size = New System.Drawing.Size(198, 200)
        Me.PictureBoxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPortada.TabIndex = 6
        Me.PictureBoxPortada.TabStop = False
        '
        'ListBoxPeliculas
        '
        Me.ListBoxPeliculas.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ListBoxPeliculas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPeliculas.ForeColor = System.Drawing.Color.White
        Me.ListBoxPeliculas.FormattingEnabled = True
        Me.ListBoxPeliculas.ItemHeight = 20
        Me.ListBoxPeliculas.Items.AddRange(New Object() {"Trainspotting", "Luca", "Spencer", "Last night in Soho", "Una joven prometedora", "El club de la lucha", "Scott Pilgrim VS the world"})
        Me.ListBoxPeliculas.Location = New System.Drawing.Point(45, 117)
        Me.ListBoxPeliculas.Name = "ListBoxPeliculas"
        Me.ListBoxPeliculas.Size = New System.Drawing.Size(437, 184)
        Me.ListBoxPeliculas.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.BackgroundImage = Global.Ejercicio06_PerezEster.My.Resources.Resources.claqueta_cultivo_fondo_negro_23_2147698844_1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBoxPeliculas)
        Me.Controls.Add(Me.PictureBoxPortada)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnAnhadir)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.txtAnhadir)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Lista Películas"
        CType(Me.PictureBoxPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnhadir As TextBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnAnhadir As Button
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBoxPortada As PictureBox
    Friend WithEvents ListBoxPeliculas As ListBox
End Class
