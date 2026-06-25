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

        CargarTablaCitas()
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
        CargarTablaCitas()
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
        ' 1. Validar Paciente: DEBE ser seleccionado de la lista (SelectedIndex no puede ser -1)
        If cmbPaciente.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un paciente de la lista." & vbCrLf & "Si el paciente es nuevo, regístrelo primero en la ventana de Pacientes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' 2. Validar Médico
        If cmbMedico.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un médico de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Puedes agregar más validaciones aquí si lo necesitas (estado, etc.)

        Return True
    End Function

    ' --- MÉTODO PARA CARGAR DATOS EN LA TABLA ---
    Private Sub CargarTablaCitas() ' Le cambiamos el nombre para que quede claro que es de citas
        Try
            ' 1. Usamos el DAO de Citas (no el de pacientes)
            Dim daoC As New CitaDAO()

            dgvCitas.DataSource = daoC.Mostrar() ' O el método que uses en tu CitaDAO para hacer el SELECT

        Catch ex As Exception
            MessageBox.Show("Error al refrescar la tabla de citas: " & ex.Message, "Error Visual")
        End Try

    End Sub


    Private Sub LimpiarCajas()
        ' Justo al final de tu código de guardar exitoso:
        LimpiarCampos()       ' Limpia los combos para el siguiente registro
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
            CargarTablaCitas()
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
                CargarTablaCitas()
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' 1. Creamos el objeto
            Dim nuevaCita As New Cita()

            ' 2. Asignamos los demás datos que ya tienes listos
            nuevaCita.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue)
            nuevaCita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue)
            nuevaCita.Fecha = dtpFecha.Value.Date
            nuevaCita.Hora = dtpHora.Value.TimeOfDay ' El que corregimos para TimeSpan


            ' Creamos una variable para guardar el número del ID
            Dim idEstadoSeleccionado As Integer

            ' Traducimos la palabra del combo al número que espera PostgreSQL
            Select Case cmbEstado.Text.Trim()
                Case "Programada"
                    idEstadoSeleccionado = 1 ' 👈 Cámbialo si en tu BD "Programada" no es el ID 1
                Case "Cancelada"
                    idEstadoSeleccionado = 2 ' 👈 Cámbialo si en tu BD "Cancelada" no es el ID 2
                Case "Atendida", "Realizada"
                    idEstadoSeleccionado = 3
                Case Else
                    idEstadoSeleccionado = 1
            End Select

            ' Ahora sí, le pasamos el número entero a la propiedad sin que truene
            nuevaCita.Estado = idEstadoSeleccionado

            ' 3. Envío al DAO para guardar en la Base de Datos de Neon
            Dim daoCita As New CitaDAO()
            daoCita.Insertar(nuevaCita)

            MessageBox.Show("¡Cita agendada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al guardar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class