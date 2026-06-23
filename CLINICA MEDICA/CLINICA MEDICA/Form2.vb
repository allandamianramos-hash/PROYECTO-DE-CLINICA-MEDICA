'Clase del formulario de pacientes
Public Class frm2


    'Variable que permitirá controlar la posición actual
    'cuando se implemente la navegación de registros.
    Private indiceActual As Integer = 0
    Private Sub frmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Limpiar posibles elementos existentes.
        cmbSexo.Items.Clear()

        'Agregar las opciones permitidas según la tabla.
        cmbSexo.Items.Add("M")
        cmbSexo.Items.Add("F")

        'El ID se genera automáticamente en PostgreSQL,
        'por lo tanto no debe ser editable.
        txtIdPaciente.ReadOnly = True

        'Evita que el usuario agregue filas manualmente.
        dgvPacientes.AllowUserToAddRows = False

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Limpia todos los controles del formulario.
        LimpiarCampos()

        'Coloca el cursor en el campo Nombre.
        txtNombre.Focus()

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

        'Ejecutar validaciones.
        If Not ValidarCampos() Then Exit Sub

        'Mensaje temporal.
        MessageBox.Show("Paciente guardado correctamente.")

        'Aquí posteriormente se llamará al procedimiento:
        '
        'CALL registrar_paciente(...)
        '
        'utilizando Npgsql.

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        'Verificar que exista un registro seleccionado.
        If txtIdPaciente.Text = "" Then

            MessageBox.Show("Seleccione un registro.")

            Exit Sub

        End If

        'Validar los datos.
        If Not ValidarCampos() Then Exit Sub

        'Mensaje temporal.
        MessageBox.Show("Paciente actualizado correctamente.")

        'Aquí posteriormente se llamará:
        '
        'CALL actualizar_paciente(...)

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'Verificar selección.
        If txtIdPaciente.Text = "" Then

            MessageBox.Show("Seleccione un paciente.")

            Exit Sub

        End If

        'Solicitar confirmación al usuario.
        If MessageBox.Show(
        "¿Desea eliminar este paciente?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) = DialogResult.Yes Then

            MessageBox.Show("Paciente eliminado.")

            'Posteriormente:
            '
            'CALL eliminar_paciente(...)

        End If

    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        'Cada vez que el usuario escriba,
        'este evento se ejecutará.

        'Posteriormente permitirá buscar
        'pacientes por nombre o apellido
        'en PostgreSQL.

    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        'Mover al primer registro.
        indiceActual = 0

        MessageBox.Show("Primer registro.")

    End Sub
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        'Retroceder una posición.
        If indiceActual > 0 Then

            indiceActual -= 1

        End If

        MessageBox.Show("Registro anterior.")

    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        'Avanzar una posición.
        indiceActual += 1

        MessageBox.Show("Siguiente registro.")

    End Sub
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        'Cuando exista conexión a la base de datos,
        'aquí se posicionará el último registro.

        MessageBox.Show("Último registro.")

    End Sub
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        'Muestra el formulario del menú principal.
        Form1.Show()
        'Cerrar únicamente este formulario
        'y regresar al formulario anterior.
        Me.Close()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Cerrar completamente la aplicación.
        Application.Exit()

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

        'Permitir únicamente números.
        If Not Char.IsDigit(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) Then

            'Bloquear cualquier letra o símbolo.
            e.Handled = True

        End If

    End Sub
End Class