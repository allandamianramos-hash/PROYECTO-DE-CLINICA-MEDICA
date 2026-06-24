'Formulario de citas médicas.
Public Class Form5

    'Controla la posición actual para navegación.
    Private indiceActual As Integer = 0
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El identificador es generado automáticamente
        'por PostgreSQL mediante SERIAL.
        txtIdCita.ReadOnly = True

        'Evita inserción manual de filas.
        dgvCitas.AllowUserToAddRows = False

        'Configurar estados disponibles.
        cmbEstado.Items.Clear()

        cmbEstado.Items.Add("Programada")
        cmbEstado.Items.Add("Completada")
        cmbEstado.Items.Add("Cancelada")

        'Configurar hora.
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.ShowUpDown = True

    End Sub
    Private Sub LimpiarCampos()

        'Limpiar controles.
        txtIdCita.Clear()
        txtBuscar.Clear()

        'Deseleccionar cajas de combo.
        cmbPaciente.SelectedIndex = -1
        cmbMedico.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1

        'Restablecer fecha y hora.
        dtpFecha.Value = Date.Today
        dtpHora.Value = Date.Now

        'Mover cursor al primer campo.
        cmbPaciente.Focus()

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Preparar formulario para nueva cita.
        LimpiarCampos()

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Restablecer formulario.
        LimpiarCampos()

    End Sub
    Private Function ValidarCampos() As Boolean

        'Validar paciente.
        If cmbPaciente.SelectedIndex = -1 Then

            MessageBox.Show(
            "Debe seleccionar un paciente.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            cmbPaciente.Focus()

            Return False

        End If

        'Validar médico.
        If cmbMedico.SelectedIndex = -1 Then

            MessageBox.Show(
            "Debe seleccionar un médico.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            cmbMedico.Focus()

            Return False

        End If

        'Validar estado.
        If cmbEstado.SelectedIndex = -1 Then

            MessageBox.Show(
            "Debe seleccionar un estado.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            cmbEstado.Focus()

            Return False

        End If

        'Validar fecha.
        If dtpFecha.Value.Date < Date.Today Then

            MessageBox.Show(
            "No puede programar una cita en una fecha pasada.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            dtpFecha.Focus()

            Return False

        End If

        Return True

    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Ejecutar validaciones.
        If Not ValidarCampos() Then Exit Sub

        MessageBox.Show(
        "Cita registrada correctamente.",
        "Información",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

        'Posteriormente:
        '
        'CALL registrar_cita(...)
        '
        'El procedimiento validará:
        '1. Existencia del paciente.
        '2. Horarios duplicados.
        '3. Integridad referencial.

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        'Verificar selección.
        If txtIdCita.Text = "" Then

            MessageBox.Show(
            "Seleccione una cita.",
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub

        End If

        If Not ValidarCampos() Then Exit Sub

        MessageBox.Show(
        "Cita modificada correctamente.",
        "Información",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

        'Posteriormente:
        '
        'CALL actualizar_cita(...)

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'Comprobar selección.
        If txtIdCita.Text = "" Then

            MessageBox.Show(
            "Seleccione una cita.",
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub

        End If

        If MessageBox.Show(
        "¿Desea eliminar esta cita?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) = DialogResult.Yes Then

            MessageBox.Show(
            "Cita eliminada correctamente.",
            "Información",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            'Posteriormente:
            '
            'CALL eliminar_cita(...)

        End If

    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        'Este evento se ejecutará cada vez
        'que el usuario escriba.

        'Posteriormente permitirá:
        '
        'Buscar por:
        ' - Código de cita.
        ' - Paciente.
        ' - Médico.
        ' - Fecha.

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

        MessageBox.Show("Registro siguiente.")

    End Sub
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        'Posteriormente permitirá posicionarse
        'en el último registro de la base de datos.

        MessageBox.Show("Último registro.")

    End Sub
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        Form1.Show()
        Me.Hide()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Cerrar completamente el sistema.
        Application.Exit()

    End Sub
End Class