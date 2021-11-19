Imports System.IO

Public Class Form1

    Dim validar, validarDni As Boolean
    Dim filaActual As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim archivoLeer As StreamReader
        archivoLeer = New StreamReader(".\datos.txt")

        While Not archivoLeer.EndOfStream
            Dim cadena As String = archivoLeer.ReadLine
            Dim leer As String() = cadena.Split(New Char() {";"})
            dgvContactos.Rows.Add(leer)
        End While
        archivoLeer.Close()
    End Sub
    Function ValidarDatos(parnombre As String, pardni As String, partelefono As String, pardireccion As String, parsexo As String) As Boolean
        If parnombre = "" Then
            MsgBox("Ingrese el nombre", MsgBoxStyle.Critical, "Información")
            ErrorProviderValidar.SetError(txtNombre, "Ingrese nombre")
            validar = False
        ElseIf pardni = "" Then
            ErrorProviderValidar.SetError(txtDni, "Ingrese DNI")
            MsgBox("Ingrese el dni", MsgBoxStyle.Critical, "Información")
            validar = False
        ElseIf partelefono = "" Then
            MsgBox("Ingrese el telefono", MsgBoxStyle.Critical, "Información")
            ErrorProviderValidar.SetError(txtTelefono, "Ingrese telefono")
            validar = False
        ElseIf pardireccion = "" Then
            MsgBox("Ingrese la direccion", MsgBoxStyle.Critical, "Información")
            ErrorProviderValidar.SetError(txtDireccion, "Ingrese direccion")
            validar = False
        ElseIf parsexo = "" Then
            MsgBox("Seleccione el sexo", MsgBoxStyle.Critical, "Información")
            ErrorProviderValidar.SetError(cboSexo, "Seleccione el sexo")
            validar = False
        Else
            validar = True
            ErrorProviderValidar.SetError(txtNombre, "")
            ErrorProviderValidar.SetError(txtDni, "")
            ErrorProviderValidar.SetError(txtTelefono, "")
            ErrorProviderValidar.SetError(txtDireccion, "")
            ErrorProviderValidar.SetError(cboSexo, "")
        End If
        Return validar
    End Function

    Function ValidarIdentificacion(pardni As String) As Boolean

        validarDni = True
        For i = 0 To dgvContactos.RowCount - 1
            If pardni = dgvContactos.Rows(i).Cells("DNI").Value Then
                MsgBox("Ya existe un contacto con ese dni", MsgBoxStyle.Critical, "Información")
                ErrorProviderValidar.SetError(txtDni, "Ingrese otro DNI")
                validarDni = False
                Exit For
            Else
                ErrorProviderValidar.SetError(txtDni, "")
                validarDni = True
            End If

        Next
        Return validarDni

    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        validar = ValidarDatos(txtNombre.Text, txtDni.Text, txtTelefono.Text, txtDireccion.Text, cboSexo.Text)
        If validar = True Then
            validarDni = ValidarIdentificacion(txtDni.Text)
            If (validarDni = True) Then
                dgvContactos.Rows.Add(txtNombre.Text, txtDni.Text, txtTelefono.Text, txtDireccion.Text, cboSexo.Text)
                MsgBox("El contacto se ha registrado")
                limpiar()
            End If
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        filaActual = dgvContactos.CurrentRow.Index
        If validar = True Then
            If txtDni.Text <> dgvContactos.Rows(filaActual).Cells("DNI").Value Then
                validarDni = ValidarIdentificacion(txtDni.Text)
            End If
            If validarDni = True Then
                dgvContactos.Rows(filaActual).Cells("NOMBRE").Value = txtNombre.Text
                dgvContactos.Rows(filaActual).Cells("DNI").Value = txtDni.Text
                dgvContactos.Rows(filaActual).Cells("TELEFONO").Value = txtTelefono.Text
                dgvContactos.Rows(filaActual).Cells("DIRECCION").Value = txtDireccion.Text
                dgvContactos.Rows(filaActual).Cells("SEXO").Value = cboSexo.Text
                activarBotones()
                limpiar()
            End If
        End If

    End Sub

    Private Sub dgvContactos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContactos.CellDoubleClick
        filaActual = dgvContactos.CurrentRow.Index
        txtNombre.Text = dgvContactos.Rows(filaActual).Cells("NOMBRE").Value
        txtDni.Text = dgvContactos.Rows(filaActual).Cells("DNI").Value
        txtTelefono.Text = dgvContactos.Rows(filaActual).Cells("TELEFONO").Value
        txtDireccion.Text = dgvContactos.Rows(filaActual).Cells("DIRECCION").Value
        cboSexo.Text = dgvContactos.Rows(filaActual).Cells("SEXO").Value
        DesactivarBotones()


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim pregunta As String
        pregunta = MsgBox("¿Está segura que desea eliminar este contacto", MsgBoxStyle.YesNo, "Información")
        If pregunta = vbYes Then
            filaActual = dgvContactos.CurrentRow.Index
            dgvContactos.Rows.Remove(dgvContactos.Rows(filaActual))
            MsgBox("El contacto se ha eliminado")
            ActivarBotones()
            limpiar()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub GuardarDatos()
        Dim archivoEscritura As StreamWriter
        Dim linea As String
        archivoEscritura = New StreamWriter(".\datos.txt")
        With dgvContactos
            For i = 0 To .RowCount - 1
                linea = .Rows(i).Cells("NOMBRE").Value & ";" &
                        .Rows(i).Cells("DNI").Value & ";" &
                        .Rows(i).Cells("TELEFONO").Value & ";" &
                        .Rows(i).Cells("DIRECCION").Value & ";" &
                        .Rows(i).Cells("SEXO").Value & ";"
                archivoEscritura.WriteLine(linea)
            Next
            MsgBox("Los datos se han guardado correctamente")
        End With
        archivoEscritura.Close()
    End Sub


    Private Sub limpiar()
        txtNombre.Clear()
        txtDni.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()
        cboSexo.Text = ""
    End Sub

    Private Sub ActivarBotones()
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub



    Private Sub DesactivarBotones()
        btnAgregar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True

    End Sub

End Class
