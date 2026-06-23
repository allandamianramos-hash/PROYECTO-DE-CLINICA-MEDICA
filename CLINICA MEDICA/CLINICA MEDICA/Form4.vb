'Formulario de especialidades.
Public Class Form4
    'Controlará la posición actual para la navegación
    'de registros cuando se implemente la base de datos.
    Private indiceActual As Integer = 0
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El identificador es generado automáticamente
        'por PostgreSQL mediante SERIAL.
        txtIdEspecialidad.ReadOnly = True

        'Evita que el usuario agregue filas manualmente.
        dgvEspecialidades.AllowUserToAddRows = False

    End Sub
    Private Sub LimpiarCampos()

        'Limpia los controles de captura.
        txtIdEspecialidad.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtBuscar.Clear()

        'Posiciona el cursor en el nombre.
        txtNombre.Focus()

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Preparar formulario para ingresar un nuevo registro.
        LimpiarCampos()

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Restablecer todos los controles.
        LimpiarCampos()

    End Sub
    Private Function ValidarCampos() As Boolean

        'Validar nombre de especialidad.
        If txtNombre.Text.Trim = "" Then

            MessageBox.Show(
            "Debe ingresar el nombre de la especialidad.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            txtNombre.Focus()

            Return False

        End If

        'Validar descripción.
        If txtDescripcion.Text.Trim = "" Then

            MessageBox.Show(
            "Debe ingresar la descripción.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            txtDescripcion.Focus()

            Return False

        End If

        'Todas las validaciones fueron superadas.
        Return True

    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Verificar campos obligatorios.
        If Not ValidarCampos() Then Exit Sub

        MessageBox.Show(
        "Especialidad guardada correctamente.",
        "Información",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

        'Posteriormente aquí se ejecutará:
        '
        'CALL registrar_especialidad(
        '    txtNombre.Text,
        '    txtDescripcion.Text
        ')

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        'Comprobar que exista un registro seleccionado.
        If txtIdEspecialidad.Text = "" Then

            MessageBox.Show(
            "Seleccione una especialidad.",
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub

        End If

        If Not ValidarCampos() Then Exit Sub

        MessageBox.Show(
        "Especialidad modificada correctamente.",
        "Información",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

        'Posteriormente:
        '
        'CALL actualizar_especialidad(...)

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'Verificar selección previa.
        If txtIdEspecialidad.Text = "" Then

            MessageBox.Show(
            "Seleccione una especialidad.",
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub

        End If

        'Solicitar confirmación.
        If MessageBox.Show(
        "¿Desea eliminar esta especialidad?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) = DialogResult.Yes Then

            MessageBox.Show(
            "Especialidad eliminada.",
            "Información",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            'Posteriormente:
            '
            'CALL eliminar_especialidad(...)

        End If

    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        'Este evento se ejecutará automáticamente
        'cada vez que el usuario escriba.

        'Posteriormente se utilizará para
        'filtrar especialidades por nombre.

    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        'Permitir letras, espacios y teclas de control.
        If Not Char.IsLetter(e.KeyChar) And
       Not Char.IsControl(e.KeyChar) And
       e.KeyChar <> " "c Then

            e.Handled = True

        End If

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

        Form1.Show()
        Me.Hide()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Cerrar completamente la aplicación.
        Application.Exit()

    End Sub
End Class