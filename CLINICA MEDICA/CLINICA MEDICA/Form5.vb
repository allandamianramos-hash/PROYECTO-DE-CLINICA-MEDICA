'Formulario de citas médicas.
Public Class Form5

    'Controla la posición actual para navegación.
    Private indiceActual As Integer = 0
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdCita.ReadOnly = True
        dgvCitas.AllowUserToAddRows = False

        ' 1. Cargar Pacientes
        CargarComboPacientes()

        ' 2. Cargar Médicos
        CargarComboMedicos()

        ' 3. Configurar Estados
        cmbEstado.Items.Clear()
        cmbEstado.Items.Add("Programada")
        cmbEstado.Items.Add("Completada")
        cmbEstado.Items.Add("Cancelada")

        CargarTabla()
    End Sub

    Private Sub CargarComboPacientes()
        Dim dao As New CitaDAO()
        Dim dt As DataTable = dao.ObtenerPacientes()

        cmbPaciente.DataSource = dt
        cmbPaciente.DisplayMember = "nombre_completo" ' Lo que el usuario ve
        cmbPaciente.ValueMember = "id_paciente"      ' El ID real detrás de escena
        cmbPaciente.SelectedIndex = -1
    End Sub

    Private Sub CargarComboMedicos()
        Dim dao As New CitaDAO()
        Dim dt As DataTable = dao.ObtenerMedicos()

        cmbMedico.DataSource = dt
        cmbMedico.DisplayMember = "nombre_completo"
        cmbMedico.ValueMember = "id_medico"
        cmbMedico.SelectedIndex = -1
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

        If String.IsNullOrWhiteSpace(cmbPaciente.Text) Then
            MessageBox.Show("Por favor, escriba el nombre del paciente.")
            Return False
        End If

        If cmbMedico.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un médico.")
            Return False
        End If

        ' Agrega aquí tus otras validaciones...
        Return True

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

    ' --- MÉTODO PARA CARGAR DATOS EN LA TABLA ---
    Private Sub CargarTabla()
        Try
            Dim dao As New CitaDAO()
            Dim dt As DataTable = dao.Mostrar()

            ' --- DIAGNÓSTICO ---
            MessageBox.Show("Registros recibidos de la BD: " & dt.Rows.Count)
            ' -------------------

            dgvCitas.DataSource = dt
        Catch ex As Exception
            ' Si hay error, esto nos dirá exactamente cuál es
            MessageBox.Show("Error en CargarTabla: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Exit Sub

        Try
            Dim idPaciente As Integer

            ' Si el índice es -1, el usuario escribió un nombre nuevo que no está en el combo
            If cmbPaciente.SelectedIndex = -1 Then
                ' Pedimos ambos datos
                Dim apellido As String = InputBox("Ingrese el APELLIDO del paciente:", "Nuevo Paciente")
                Dim fechaInput As String = InputBox("Ingrese la FECHA DE NACIMIENTO (YYYY-MM-DD):", "Nuevo Paciente", "2000-01-01")

                Dim fechaNac As DateTime
                If Not DateTime.TryParse(fechaInput, fechaNac) Then
                    MessageBox.Show("Fecha inválida.")
                    Exit Sub
                End If

                Dim daoP As New PacienteDAO()
                idPaciente = daoP.RegistrarYRetornarID(cmbPaciente.Text, apellido, fechaNac)
            Else
                idPaciente = Convert.ToInt32(cmbPaciente.SelectedValue)
            End If

            ' Guardamos la cita (tu código existente de citaDAO...)
            Dim cita As New Cita()
            cita.IdPaciente = idPaciente
            cita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue)
            cita.Fecha = dtpFecha.Value.Date
            cita.Hora = dtpHora.Value.TimeOfDay
            cita.Estado = (cmbEstado.SelectedIndex + 1)

            Dim daoC As New CitaDAO()
            daoC.Insertar(cita)

            MessageBox.Show("Cita registrada correctamente.", "Éxito")
            CargarTabla()
            ' Limpiar y recargar combos aquí
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtIdCita.Text = "" Then
            MessageBox.Show("Seleccione una cita de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidarCampos() Then Exit Sub

        Try
            Dim cita As New Cita()
            cita.IdCita = Convert.ToInt32(txtIdCita.Text)
            cita.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue)
            cita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue)
            cita.Fecha = dtpFecha.Value.Date
            cita.Hora = dtpHora.Value.TimeOfDay
            cita.Estado = (cmbEstado.SelectedIndex + 1).ToString()

            Dim dao As New CitaDAO()
            dao.Editar(cita)

            MessageBox.Show("Cita modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdCita.Text = "" Then
            MessageBox.Show("Seleccione una cita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim dao As New CitaDAO()
                dao.Eliminar(Convert.ToInt32(txtIdCita.Text))

                MessageBox.Show("Cita eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ' Verificamos que el datasource no esté nulo
        If dgvCitas.DataSource IsNot Nothing Then
            Dim dv As DataView = CType(dgvCitas.DataSource, DataTable).DefaultView

            ' Filtramos por nombre de paciente o médico
            ' Usamos OR para buscar en ambos campos
            dv.RowFilter = String.Format("nombre_paciente LIKE '%{0}%' OR nombre_medico LIKE '%{0}%'", txtBuscar.Text.Trim())
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

    Private Sub dgvCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvCitas.Rows(e.RowIndex)

            txtIdCita.Text = fila.Cells("id_cita").Value.ToString()
            cmbPaciente.SelectedValue = fila.Cells("id_paciente").Value
            cmbMedico.SelectedValue = fila.Cells("id_medico").Value
            dtpFecha.Value = Convert.ToDateTime(fila.Cells("fecha").Value)
            ' Para la hora, convertimos el string/time a DateTime
            dtpHora.Value = DateTime.Today.Add(TimeSpan.Parse(fila.Cells("hora").Value.ToString()))

            ' Convertimos el ID de estado a índice (si tu ID es 1, 2, 3, restamos 1 para el índice)
            cmbEstado.SelectedIndex = Convert.ToInt32(fila.Cells("id_estado").Value) - 1
        End If
    End Sub
End Class