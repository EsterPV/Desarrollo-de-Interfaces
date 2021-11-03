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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdAmarillo = New System.Windows.Forms.RadioButton()
        Me.rdVerde = New System.Windows.Forms.RadioButton()
        Me.rdRojo = New System.Windows.Forms.RadioButton()
        Me.rdAzul = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdArriba = New System.Windows.Forms.RadioButton()
        Me.rdAbajo = New System.Windows.Forms.RadioButton()
        Me.boxResultado = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdAmarillo)
        Me.GroupBox1.Controls.Add(Me.rdVerde)
        Me.GroupBox1.Controls.Add(Me.rdRojo)
        Me.GroupBox1.Controls.Add(Me.rdAzul)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colores"
        '
        'rdAmarillo
        '
        Me.rdAmarillo.AutoSize = True
        Me.rdAmarillo.BackColor = System.Drawing.Color.Yellow
        Me.rdAmarillo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdAmarillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAmarillo.ForeColor = System.Drawing.Color.Maroon
        Me.rdAmarillo.Location = New System.Drawing.Point(21, 153)
        Me.rdAmarillo.Name = "rdAmarillo"
        Me.rdAmarillo.Size = New System.Drawing.Size(98, 24)
        Me.rdAmarillo.TabIndex = 3
        Me.rdAmarillo.TabStop = True
        Me.rdAmarillo.Text = "Amarillo"
        Me.rdAmarillo.UseVisualStyleBackColor = False
        '
        'rdVerde
        '
        Me.rdVerde.AutoSize = True
        Me.rdVerde.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdVerde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdVerde.ForeColor = System.Drawing.Color.Green
        Me.rdVerde.Location = New System.Drawing.Point(21, 112)
        Me.rdVerde.Name = "rdVerde"
        Me.rdVerde.Size = New System.Drawing.Size(82, 24)
        Me.rdVerde.TabIndex = 2
        Me.rdVerde.TabStop = True
        Me.rdVerde.Text = "Verde"
        Me.rdVerde.UseVisualStyleBackColor = True
        '
        'rdRojo
        '
        Me.rdRojo.AutoSize = True
        Me.rdRojo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRojo.ForeColor = System.Drawing.Color.Red
        Me.rdRojo.Location = New System.Drawing.Point(21, 68)
        Me.rdRojo.Name = "rdRojo"
        Me.rdRojo.Size = New System.Drawing.Size(71, 24)
        Me.rdRojo.TabIndex = 1
        Me.rdRojo.TabStop = True
        Me.rdRojo.Text = "Rojo"
        Me.rdRojo.UseVisualStyleBackColor = True
        '
        'rdAzul
        '
        Me.rdAzul.AutoSize = True
        Me.rdAzul.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAzul.ForeColor = System.Drawing.Color.Blue
        Me.rdAzul.Location = New System.Drawing.Point(21, 25)
        Me.rdAzul.Name = "rdAzul"
        Me.rdAzul.Size = New System.Drawing.Size(69, 24)
        Me.rdAzul.TabIndex = 0
        Me.rdAzul.TabStop = True
        Me.rdAzul.Text = "Azul"
        Me.rdAzul.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Ejercicio01_EsterPerez.My.Resources.Resources.istockphoto_524428147_612x612
        Me.GroupBox2.Controls.Add(Me.rdArriba)
        Me.GroupBox2.Controls.Add(Me.rdAbajo)
        Me.GroupBox2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Posición"
        '
        'rdArriba
        '
        Me.rdArriba.AutoSize = True
        Me.rdArriba.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.rdArriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdArriba.Location = New System.Drawing.Point(21, 50)
        Me.rdArriba.Name = "rdArriba"
        Me.rdArriba.Size = New System.Drawing.Size(82, 24)
        Me.rdArriba.TabIndex = 4
        Me.rdArriba.TabStop = True
        Me.rdArriba.Text = "Arriba"
        Me.rdArriba.UseVisualStyleBackColor = True
        '
        'rdAbajo
        '
        Me.rdAbajo.AutoSize = True
        Me.rdAbajo.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.rdAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdAbajo.Location = New System.Drawing.Point(21, 100)
        Me.rdAbajo.Name = "rdAbajo"
        Me.rdAbajo.Size = New System.Drawing.Size(80, 24)
        Me.rdAbajo.TabIndex = 5
        Me.rdAbajo.TabStop = True
        Me.rdAbajo.Text = "Abajo"
        Me.rdAbajo.UseVisualStyleBackColor = True
        '
        'boxResultado
        '
        Me.boxResultado.Location = New System.Drawing.Point(380, 23)
        Me.boxResultado.Name = "boxResultado"
        Me.boxResultado.Size = New System.Drawing.Size(382, 195)
        Me.boxResultado.TabIndex = 2
        Me.boxResultado.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.boxResultado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Colores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdAmarillo As RadioButton
    Friend WithEvents rdVerde As RadioButton
    Friend WithEvents rdRojo As RadioButton
    Friend WithEvents rdAzul As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdArriba As RadioButton
    Friend WithEvents rdAbajo As RadioButton
    Friend WithEvents boxResultado As GroupBox
End Class
