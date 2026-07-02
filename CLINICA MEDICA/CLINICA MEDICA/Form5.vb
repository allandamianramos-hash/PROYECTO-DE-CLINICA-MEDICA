Imports Npgsql
Imports System.Data
Imports System.Globalization

Public Class Form5

    Dim cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"
    Dim posicion As Integer = 0
    Dim tablaCitas As New DataTable

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdCita.ReadOnly = True
        dgvCitas.AllowUserToAddRows = False
        dgvCitas.ReadOnly = True
        dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCitas.MultiSelect = False
        dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList

        dtpFecha.Format = DateTimePickerFormat.Short
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.ShowUpDown = True

        CargarComboPacientes()
        CargarComboMedicos()
        CargarEstados()
        CargarTablaCitas()
        LimpiarCampos()
    End Sub

    ' --- CARGAS CON EL DAO ---

    Private Sub CargarComboPacientes()
        Try
            Dim dao As New CitaDAO()
            cmbPaciente.DataSource = dao.ObtenerPacientes()
            cmbPaciente.DisplayMember = "nombre_completo"
            cmbPaciente.ValueMember = "id_paciente"
            cmbPaciente.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarComboMedicos()
        Try
            Dim dao As New CitaDAO()
            cmbMedico.DataSource = dao.ObtenerMedicos()
            cmbMedico.DisplayMember = "nombre_completo"
            cmbMedico.ValueMember = "id_medico"
            cmbMedico.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarEstados()
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                Dim consulta As String = "SELECT id_estado, nombre_estado FROM estados_cita ORDER BY id_estado;"
                Dim adaptador As New NpgsqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable
                adaptador.Fill(tabla)
                cmbEstado.DataSource = tabla
                cmbEstado.DisplayMember = "nombre_estado"
                cmbEstado.ValueMember = "id_estado"
                cmbEstado.SelectedIndex = -1
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarTablaCitas()
        Try
            Dim dao As New CitaDAO()
            tablaCitas = dao.Mostrar()
            dgvCitas.DataSource = tablaCitas

            ' Ocultamos los IDs internos
            If dgvCitas.Columns.Contains("id_paciente") Then dgvCitas.Columns("id_paciente").Visible = False
            If dgvCitas.Columns.Contains("id_medico") Then dgvCitas.Columns("id_medico").Visible = False
            If dgvCitas.Columns.Contains("id_estado") Then dgvCitas.Columns("id_estado").Visible = False ' Ocultamos el número de estado

            ' Renombrar cabeceras
            If dgvCitas.Columns.Contains("id_cita") Then dgvCitas.Columns("id_cita").HeaderText = "ID Cita"
            If dgvCitas.Columns.Contains("nombre_paciente") Then dgvCitas.Columns("nombre_paciente").HeaderText = "Paciente"
            If dgvCitas.Columns.Contains("nombre_medico") Then dgvCitas.Columns("nombre_medico").HeaderText = "Médico"
            If dgvCitas.Columns.Contains("fecha") Then dgvCitas.Columns("fecha").HeaderText = "Fecha"
            If dgvCitas.Columns.Contains("hora") Then dgvCitas.Columns("hora").HeaderText = "Hora"
            If dgvCitas.Columns.Contains("estado") Then dgvCitas.Columns("estado").HeaderText = "Estado"

        Catch ex As Exception
            MessageBox.Show("Error al cargar citas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- VALIDACIONES ---

    Private Function ValidarCampos() As Boolean
        If cmbPaciente.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cmbMedico.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un médico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cmbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el estado de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarCampos()
        txtIdCita.Clear()
        txtBuscar.Clear()
        cmbPaciente.SelectedIndex = -1
        cmbMedico.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        dtpFecha.Value = Date.Today
        dtpHora.Value = Date.Now
        posicion = 0
        cmbPaciente.Focus()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' --- CRUD (Conectado al DAO) ---

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarCampos() = False Then Exit Sub

        Dim medicoSeleccionado As Integer = Convert.ToInt32(cmbMedico.SelectedValue)
        Dim horaDeseada As TimeSpan = dtpHora.Value.TimeOfDay

        If Not MedicoEstaDisponible(medicoSeleccionado, horaDeseada) Then
            MessageBox.Show("El médico seleccionado no está disponible en ese horario. Por favor, revise sus horas de atención.", "Horario Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim cita As New Cita()
            cita.IdPaciente = CInt(cmbPaciente.SelectedValue)
            cita.IdMedico = CInt(cmbMedico.SelectedValue)
            cita.Fecha = dtpFecha.Value.Date
            cita.Hora = dtpHora.Value.TimeOfDay
            ' 🚨 Enviamos el ID numérico del estado convertido en texto temporalmente
            cita.Estado = cmbEstado.SelectedValue.ToString()

            ' Averiguamos la especialidad del médico seleccionado
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                Dim cmd As New NpgsqlCommand("SELECT id_especialidad FROM medicos WHERE id_medico = @id", conexion)
                cmd.Parameters.AddWithValue("@id", cita.IdMedico)
                cita.IdEspecialidad = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Guardamos usando el DAO
            Dim dao As New CitaDAO()
            dao.Insertar(cita)

            MessageBox.Show("Cita guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarTablaCitas()
            LimpiarCampos()
            Form1.CargarEstadisticas()

        Catch ex As Exception
            MessageBox.Show("Error al guardar la cita: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtIdCita.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una cita para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        Try
            Dim cita As New Cita()
            cita.IdCita = CInt(txtIdCita.Text)
            cita.Fecha = dtpFecha.Value.Date
            cita.Hora = dtpHora.Value.TimeOfDay
            ' 🚨 Enviamos el ID numérico
            cita.Estado = cmbEstado.SelectedValue.ToString()

            Dim dao As New CitaDAO()
            dao.Editar(cita)

            MessageBox.Show("Cita editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarTablaCitas()
            LimpiarCampos()
            Form1.CargarEstadisticas()

        Catch ex As Exception
            MessageBox.Show("Error al editar la cita: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdCita.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una cita para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar esta cita?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim dao As New CitaDAO()
                dao.Eliminar(CInt(txtIdCita.Text))

                MessageBox.Show("Cita eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCitas()
                LimpiarCampos()
                Form1.CargarEstadisticas()
            Catch ex As Exception
                If ex.Message.Contains("violates foreign key") Or ex.Message.Contains("violación de llave foránea") Then
                    MessageBox.Show("No puedes eliminar esta cita porque ya tiene una consulta médica registrada.", "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Error al eliminar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub

    ' --- BUSCADOR Y NAVEGACIÓN ---

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            If tablaCitas Is Nothing OrElse tablaCitas.Rows.Count = 0 Then Exit Sub
            Dim texto As String = txtBuscar.Text.Trim().Replace("'", "''")

            tablaCitas.DefaultView.RowFilter =
                "nombre_paciente LIKE '%" & texto & "%' OR " &
                "nombre_medico LIKE '%" & texto & "%' OR " &
                "estado LIKE '%" & texto & "%'"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellClick
        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            MostrarCita()
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If dgvCitas.Rows.Count > 0 Then
            posicion = 0
            MostrarCita()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            MostrarCita()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dgvCitas.Rows.Count - 1 Then
            posicion += 1
            MostrarCita()
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If dgvCitas.Rows.Count > 0 Then
            posicion = dgvCitas.Rows.Count - 1
            MostrarCita()
        End If
    End Sub

    Private Sub MostrarCita()
        If dgvCitas.Rows.Count = 0 Then Exit Sub

        Try
            dgvCitas.ClearSelection()
            dgvCitas.Rows(posicion).Selected = True

            Dim fila As DataGridViewRow = dgvCitas.Rows(posicion)

            txtIdCita.Text = fila.Cells("id_cita").Value.ToString()
            cmbPaciente.SelectedValue = CInt(fila.Cells("id_paciente").Value)
            cmbMedico.SelectedValue = CInt(fila.Cells("id_medico").Value)

            ' 🚨 Ahora seteamos el estado de manera súper limpia leyendo el ID
            cmbEstado.SelectedValue = CInt(fila.Cells("id_estado").Value)

            ' Procesamiento de Fecha
            Dim tipoDatoFecha As String = fila.Cells("fecha").Value.GetType().Name
            If tipoDatoFecha = "DateOnly" Then
                Dim fechaOnly As DateOnly = DirectCast(fila.Cells("fecha").Value, DateOnly)
                dtpFecha.Value = fechaOnly.ToDateTime(TimeOnly.MinValue)
            Else
                dtpFecha.Value = Convert.ToDateTime(fila.Cells("fecha").Value)
            End If

            ' Procesamiento de Hora
            Dim tipoDatoHora As String = fila.Cells("hora").Value.GetType().Name
            If tipoDatoHora = "TimeOnly" Then
                Dim horaOnly As TimeOnly = DirectCast(fila.Cells("hora").Value, TimeOnly)
                dtpHora.Value = Date.Today.Add(horaOnly.ToTimeSpan())
            ElseIf tipoDatoHora = "TimeSpan" Then
                dtpHora.Value = Date.Today.Add(DirectCast(fila.Cells("hora").Value, TimeSpan))
            Else
                dtpHora.Value = Convert.ToDateTime(fila.Cells("hora").Value)
            End If

        Catch ex As Exception
            ' Silencioso para navegación rápida
        End Try
    End Sub

    ' --- NAVEGACIÓN DE PANTALLA ---

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' --- FUNCIÓN DE DISPONIBILIDAD ---

    Private Function MedicoEstaDisponible(idMedico As Integer, horaCita As TimeSpan) As Boolean
        Dim estaDisponible As Boolean = False

        Dim query As String = "
            SELECT COUNT(*) 
            FROM disponibilidad_medico 
            WHERE id_medico = @idMedico 
            AND (
                (hora_inicio <= hora_fin AND @horaCita >= hora_inicio AND @horaCita <= hora_fin)
                OR 
                (hora_inicio > hora_fin AND (@horaCita >= hora_inicio OR @horaCita <= hora_fin))
            )"

        Using conn As New NpgsqlConnection(cadenaConexion)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("idMedico", idMedico)
                    cmd.Parameters.AddWithValue("horaCita", horaCita)

                    Dim coincidencias As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If coincidencias > 0 Then estaDisponible = True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al verificar disponibilidad: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return estaDisponible
    End Function
End Class