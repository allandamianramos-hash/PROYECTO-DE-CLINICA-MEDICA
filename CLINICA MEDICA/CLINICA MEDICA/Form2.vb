'Clase del formulario de pacientes\

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Npgsql
Public Class frm2


    'Variable que permitirá controlar la posición actual
    'cuando se implemente la navegación de registros.
    Private indiceActual As Integer = 0
    Dim posicion As Integer = 0

    ' Método para refrescar el DataGridView
    ' --- Evento Load: Aquí se inicializa todo al abrir ---
    ' --- Evento Load ---
    Private Sub frmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración visual
        cmbSexo.Items.Clear()
        cmbSexo.Items.Add("M")
        cmbSexo.Items.Add("F")
        txtIdPaciente.ReadOnly = True
        dgvPacientes.AllowUserToAddRows = False

        ' Llamada única a CargarTabla
        CargarTabla()
    End Sub

    ' --- Método CargarTabla (ÚNICO Y DEFINITIVO) ---
    Private Sub CargarTabla()
        Try
            Dim dao As New PacienteDAO()
            dgvPacientes.DataSource = dao.Mostrar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los registros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LimpiarCampos()

        'Vacía todas las cajas de texto.
        txtIdPaciente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtBuscar.Clear()

        'Quita la selección actual de la caja de combo.
        cmbSexo.SelectedIndex = -1

        'Restablece la fecha al día actual.
        dtpFechaNac.Value = Date.Today

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Llama al método encargado de limpiar controles.
        LimpiarCampos()

    End Sub
    Private Function ValidarCampos() As Boolean

        'Validar nombre.
        If txtNombre.Text.Trim = "" Then

            MessageBox.Show("Debe ingresar el nombre.")

            txtNombre.Focus()

            Return False

        End If

        'Validar apellido.
        If txtApellido.Text.Trim = "" Then

            MessageBox.Show("Debe ingresar el apellido.")

            txtApellido.Focus()

            Return False

        End If

        'Validar sexo.
        If cmbSexo.SelectedIndex = -1 Then

            MessageBox.Show("Debe seleccionar el sexo.")

            cmbSexo.Focus()

            Return False

        End If

        'Validar teléfono.
        If txtTelefono.Text.Trim = "" Then

            MessageBox.Show("Debe ingresar el teléfono.")

            txtTelefono.Focus()

            Return False

        End If

        'Validar correo.
        If txtCorreo.Text.Trim = "" Then

            MessageBox.Show("Debe ingresar el correo electrónico.")

            txtCorreo.Focus()

            Return False

        End If

        'Validación simple del formato del correo.
        If Not txtCorreo.Text.Contains("@") Then

            MessageBox.Show("Correo electrónico inválido.")

            txtCorreo.Focus()

            Return False

        End If

        'Si todas las validaciones son correctas.
        Return True

    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Exit Sub

        Try
            Dim nuevoPaciente As New Paciente()
            nuevoPaciente.Nombre = txtNombre.Text.Trim()
            nuevoPaciente.Apellido = txtApellido.Text.Trim()
            nuevoPaciente.Sexo = cmbSexo.Text.Trim()
            nuevoPaciente.Telefono = txtTelefono.Text.Trim()
            nuevoPaciente.Correo = txtCorreo.Text.Trim()
            nuevoPaciente.Direccion = txtDireccion.Text.Trim()
            nuevoPaciente.FechaNacimiento = dtpFechaNac.Value

            Dim dao As New PacienteDAO()
            dao.Insertar(nuevoPaciente)

            MessageBox.Show("¡Paciente guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarTabla() ' Refresca tu DataGridView
            LimpiarCampos()
            Form1.CargarEstadisticas() 'Llama a esta funcion del form1

        Catch ex As Exception
            MessageBox.Show("Error al intentar procesar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' 1. Verificar que exista un registro seleccionado.
        If txtIdPaciente.Text = "" Then
            MessageBox.Show("Seleccione un registro de la tabla para editar.")
            Exit Sub
        End If

        ' 2. Validar los datos (usando tu método existente).
        If Not ValidarCampos() Then Exit Sub

        ' 3. Intentar la actualización en la base de datos.
        Try
            ' Empaquetamos los datos del formulario en el objeto Paciente
            Dim p As New Paciente()
            p.IdPaciente = Convert.ToInt32(txtIdPaciente.Text)
            p.Nombre = txtNombre.Text
            p.Apellido = txtApellido.Text
            p.FechaNacimiento = dtpFechaNac.Value

            ' Asegúrate de que el formato coincida (si usas solo una letra 'M' o 'F')
            If cmbSexo.Text.Length > 0 Then
                p.Sexo = Convert.ToChar(cmbSexo.Text.Substring(0, 1))
            End If

            p.Telefono = txtTelefono.Text
            p.Correo = txtCorreo.Text
            p.Direccion = txtDireccion.Text

            ' Llamamos al DAO para actualizar
            Dim dao As New PacienteDAO()
            dao.Actualizar(p)

            ' Éxito
            MessageBox.Show("Paciente actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refrescamos la tabla y limpiamos los campos para dejarlo listo para otra acción
            CargarTabla()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtIdPaciente.Text) Then
            MessageBox.Show("Selecciona un paciente de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Seguro que quieres borrar a este paciente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try
                Dim dao As New PacienteDAO()
                dao.Eliminar(Convert.ToInt32(txtIdPaciente.Text))

                MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                LimpiarCampos()
                Form1.CargarEstadisticas()
            Catch ex As Exception
                ' Aquí saltará la alerta inteligente desde Neon si el paciente tiene historial
                MessageBox.Show(ex.Message, "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ' Si el buscador está vacío, mostramos todo. Si tiene texto, filtramos.
        If String.IsNullOrWhiteSpace(txtBuscar.Text) Then
            CargarTabla()
        Else
            Try
                Dim dao As New PacienteDAO()
                dgvPacientes.DataSource = dao.Buscar(txtBuscar.Text)
            Catch ex As Exception
                ' Silencioso o manejo de error simple
            End Try
        End If
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvPacientes.Rows.Count > 0 Then
            posicion = 0
            MostrarRegistro()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If dgvPacientes.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya está en el primer registro.")
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvPacientes.Rows.Count > 0 Then

            If posicion < dgvPacientes.Rows.Count - 1 Then
                posicion += 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya está en el último registro.")
            End If

        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvPacientes.Rows.Count > 0 Then
            posicion = dgvPacientes.Rows.Count - 1
            MostrarRegistro()
        End If

    End Sub

    Private Sub MostrarRegistro()

        If dgvPacientes.Rows.Count = 0 Then Exit Sub

        dgvPacientes.ClearSelection()
        dgvPacientes.Rows(posicion).Selected = True
        dgvPacientes.CurrentCell = dgvPacientes.Rows(posicion).Cells(0)

        txtIdPaciente.Text = dgvPacientes.Rows(posicion).Cells("id_paciente").Value.ToString()
        txtNombre.Text = dgvPacientes.Rows(posicion).Cells("nombre").Value.ToString()
        txtApellido.Text = dgvPacientes.Rows(posicion).Cells("apellido").Value.ToString()

        Dim fechaValor = dgvPacientes.Rows(posicion).Cells("fecha_nacimiento").Value

        If TypeOf fechaValor Is DateOnly Then
            Dim fechaOnly As DateOnly = DirectCast(fechaValor, DateOnly)
            dtpFechaNac.Value = fechaOnly.ToDateTime(TimeOnly.MinValue)
        Else
            dtpFechaNac.Value = Convert.ToDateTime(fechaValor)
        End If

        cmbSexo.Text = dgvPacientes.Rows(posicion).Cells("sexo").Value.ToString()
        txtDireccion.Text = dgvPacientes.Rows(posicion).Cells("direccion").Value.ToString()
        txtTelefono.Text = dgvPacientes.Rows(posicion).Cells("telefono").Value.ToString()
        txtCorreo.Text = dgvPacientes.Rows(posicion).Cells("correo_electronico").Value.ToString()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        'Permitir únicamente letras,
        'espacios y teclas de control.
        If Not Char.IsLetter(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) And
           e.KeyChar <> " "c Then

            'Bloquear el carácter.
            e.Handled = True

        End If

    End Sub
    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress

        'Permitir únicamente letras,
        'espacios y teclas de control.
        If Not Char.IsLetter(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) And
           e.KeyChar <> " "c Then

            e.Handled = True

        End If

    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        If Not Char.IsDigit(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) And
           e.KeyChar <> "-"c Then

            e.Handled = True

        End If

    End Sub

    Private Sub dgvPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellContentClick

    End Sub

    Private Sub dgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
        If e.RowIndex >= 0 Then
            posicion = e.RowIndex

            MostrarRegistro()
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Function ConvertirADateTime(valor As Object) As DateTime
        If valor Is Nothing OrElse IsDBNull(valor) Then Return DateTime.Now
        Dim tipoDato As String = valor.GetType().Name

        If tipoDato = "TimeOnly" Then
            Dim soloHora As TimeOnly = DirectCast(valor, TimeOnly)
            Return DateTime.Today.Add(soloHora.ToTimeSpan())
        ElseIf tipoDato = "DateOnly" Then
            Dim soloFecha As DateOnly = DirectCast(valor, DateOnly)
            Return soloFecha.ToDateTime(TimeOnly.MinValue)
        ElseIf tipoDato = "TimeSpan" Then
            Return DateTime.Today.Add(DirectCast(valor, TimeSpan))
        End If

        Try
            Return Convert.ToDateTime(valor)
        Catch ex As Exception
            Return DateTime.Now
        End Try
    End Function

End Class