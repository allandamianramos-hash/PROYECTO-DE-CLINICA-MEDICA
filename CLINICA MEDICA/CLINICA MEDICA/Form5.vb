'Formulario de citas médicas
Imports Npgsql
Imports System.Data
Imports System.Globalization

Public Class Form5

    Dim cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"
    Dim posicion As Integer = 0

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

    Private Sub CargarComboPacientes()

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT 
                        id_paciente,
                        nombre || ' ' || apellido AS nombre_completo
                    FROM pacientes
                    ORDER BY id_paciente;
                "

                Dim adaptador As New NpgsqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable

                adaptador.Fill(tabla)

                cmbPaciente.DataSource = tabla
                cmbPaciente.DisplayMember = "nombre_completo"
                cmbPaciente.ValueMember = "id_paciente"
                cmbPaciente.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar pacientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarComboMedicos()

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT 
                        id_medico,
                        nombre || ' ' || apellido AS nombre_completo
                    FROM medicos
                    ORDER BY id_medico;
                "

                Dim adaptador As New NpgsqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable

                adaptador.Fill(tabla)

                cmbMedico.DataSource = tabla
                cmbMedico.DisplayMember = "nombre_completo"
                cmbMedico.ValueMember = "id_medico"
                cmbMedico.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar médicos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
<<<<<<< HEAD
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
=======

    Private Sub CargarEstados()

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT 
                        id_estado,
                        nombre_estado
                    FROM estados_cita
                    ORDER BY id_estado;
                "

                Dim adaptador As New NpgsqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable

                adaptador.Fill(tabla)

                cmbEstado.DataSource = tabla
                cmbEstado.DisplayMember = "nombre_estado"
                cmbEstado.ValueMember = "id_estado"
                cmbEstado.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar estados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
>>>>>>> fc3cdc4b0c481da1983059a8cadd5186a3f012fc

    Private Sub CargarTablaCitas()

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT 
                        c.id_cita,
                        c.id_paciente,
                        p.nombre AS nombre_paciente,
                        c.id_medico,
                        m.nombre AS nombre_medico,
                        c.fecha::text AS fecha,
                        to_char(c.hora, 'HH24:MI:SS') AS hora,
                        c.id_estado,
                        e.nombre_estado
                    FROM citas c
                    INNER JOIN pacientes p ON c.id_paciente = p.id_paciente
                    INNER JOIN medicos m ON c.id_medico = m.id_medico
                    INNER JOIN estados_cita e ON c.id_estado = e.id_estado
                    ORDER BY c.id_cita;
                "

                Dim adaptador As New NpgsqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable

                adaptador.Fill(tabla)

                dgvCitas.DataSource = tabla

                If dgvCitas.Columns.Contains("id_cita") Then dgvCitas.Columns("id_cita").HeaderText = "ID Cita"
                If dgvCitas.Columns.Contains("id_paciente") Then dgvCitas.Columns("id_paciente").HeaderText = "ID Paciente"
                If dgvCitas.Columns.Contains("nombre_paciente") Then dgvCitas.Columns("nombre_paciente").HeaderText = "Paciente"
                If dgvCitas.Columns.Contains("id_medico") Then dgvCitas.Columns("id_medico").HeaderText = "ID Médico"
                If dgvCitas.Columns.Contains("nombre_medico") Then dgvCitas.Columns("nombre_medico").HeaderText = "Médico"
                If dgvCitas.Columns.Contains("fecha") Then dgvCitas.Columns("fecha").HeaderText = "Fecha"
                If dgvCitas.Columns.Contains("hora") Then dgvCitas.Columns("hora").HeaderText = "Hora"
                If dgvCitas.Columns.Contains("id_estado") Then dgvCitas.Columns("id_estado").HeaderText = "ID Estado"
                If dgvCitas.Columns.Contains("nombre_estado") Then dgvCitas.Columns("nombre_estado").HeaderText = "Estado"

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar citas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidarCampos() As Boolean

        If cmbPaciente.SelectedIndex = -1 OrElse cmbPaciente.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPaciente.Focus()
            Return False
        End If

        If cmbMedico.SelectedIndex = -1 OrElse cmbMedico.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un médico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMedico.Focus()
            Return False
        End If

        If cmbEstado.SelectedIndex = -1 OrElse cmbEstado.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione el estado de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbEstado.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub LimpiarCampos()

        txtIdCita.Clear()
        txtBuscar.Clear()

        If cmbPaciente.DataSource IsNot Nothing Then cmbPaciente.SelectedIndex = -1
        If cmbMedico.DataSource IsNot Nothing Then cmbMedico.SelectedIndex = -1
        If cmbEstado.DataSource IsNot Nothing Then cmbEstado.SelectedIndex = -1

        dtpFecha.Value = Date.Today
        dtpHora.Value = Date.Now

        posicion = 0
        cmbPaciente.Focus()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        CargarTablaCitas()
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    INSERT INTO citas
                    (id_paciente, id_medico, id_estado, fecha, hora)
                    VALUES
                    (@id_paciente, @id_medico, @id_estado, @fecha, @hora);
                "

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@id_paciente", CInt(cmbPaciente.SelectedValue))
                    comando.Parameters.AddWithValue("@id_medico", CInt(cmbMedico.SelectedValue))
                    comando.Parameters.AddWithValue("@id_estado", CInt(cmbEstado.SelectedValue))
                    comando.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date)
                    comando.Parameters.AddWithValue("@hora", dtpHora.Value.TimeOfDay)

                    comando.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Cita guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarTablaCitas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtIdCita.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una cita para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    UPDATE citas SET
                        id_paciente = @id_paciente,
                        id_medico = @id_medico,
                        id_estado = @id_estado,
                        fecha = @fecha,
                        hora = @hora
                    WHERE id_cita = @id_cita;
                "

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@id_cita", CInt(txtIdCita.Text))
                    comando.Parameters.AddWithValue("@id_paciente", CInt(cmbPaciente.SelectedValue))
                    comando.Parameters.AddWithValue("@id_medico", CInt(cmbMedico.SelectedValue))
                    comando.Parameters.AddWithValue("@id_estado", CInt(cmbEstado.SelectedValue))
                    comando.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date)
                    comando.Parameters.AddWithValue("@hora", dtpHora.Value.TimeOfDay)

                    Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

                    If filasAfectadas = 0 Then
                        MessageBox.Show("No se encontró la cita para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                End Using

            End Using

            MessageBox.Show("Cita editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarTablaCitas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al editar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtIdCita.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una cita para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea eliminar esta cita?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "DELETE FROM citas WHERE id_cita = @id_cita;"

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@id_cita", CInt(txtIdCita.Text))
                    comando.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Cita eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarTablaCitas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Try
            If dgvCitas.DataSource Is Nothing Then Exit Sub

            Dim tabla As DataTable = TryCast(dgvCitas.DataSource, DataTable)

            If tabla Is Nothing Then Exit Sub

            Dim texto As String = txtBuscar.Text.Trim().Replace("'", "''")

            tabla.DefaultView.RowFilter =
                "nombre_paciente LIKE '%" & texto & "%' OR " &
                "nombre_medico LIKE '%" & texto & "%' OR " &
                "nombre_estado LIKE '%" & texto & "%' OR " &
                "fecha LIKE '%" & texto & "%' OR " &
                "hora LIKE '%" & texto & "%'"

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        If dgvCitas.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                MostrarCita()
            Else
                MessageBox.Show("Ya está en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvCitas.Rows.Count > 0 Then

            If posicion < dgvCitas.Rows.Count - 1 Then
                posicion += 1
                MostrarCita()
            Else
                MessageBox.Show("Ya está en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

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
        If posicion < 0 OrElse posicion >= dgvCitas.Rows.Count Then Exit Sub

        dgvCitas.ClearSelection()
        dgvCitas.Rows(posicion).Selected = True
        dgvCitas.CurrentCell = dgvCitas.Rows(posicion).Cells("id_cita")

        Dim fila As DataGridViewRow = dgvCitas.Rows(posicion)

        txtIdCita.Text = fila.Cells("id_cita").Value.ToString()

        cmbPaciente.SelectedValue = CInt(fila.Cells("id_paciente").Value)
        cmbMedico.SelectedValue = CInt(fila.Cells("id_medico").Value)
        cmbEstado.SelectedValue = CInt(fila.Cells("id_estado").Value)

        Dim fechaTexto As String = fila.Cells("fecha").Value.ToString().Trim()
        Dim fechaConvertida As DateTime

        If DateTime.TryParseExact(fechaTexto,
                                  "yyyy-MM-dd",
                                  CultureInfo.InvariantCulture,
                                  DateTimeStyles.None,
                                  fechaConvertida) Then

            dtpFecha.Value = fechaConvertida

        ElseIf DateTime.TryParse(fechaTexto, fechaConvertida) Then

            dtpFecha.Value = fechaConvertida

        Else

            MessageBox.Show("No se pudo convertir la fecha: " & fechaTexto, "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        Dim horaTexto As String = fila.Cells("hora").Value.ToString().Trim()
        Dim horaSpan As TimeSpan

        If TimeSpan.TryParse(horaTexto, horaSpan) Then

            dtpHora.Value = Date.Today.Add(horaSpan)

        Else

            Dim horaConvertida As DateTime

            If DateTime.TryParse(horaTexto, horaConvertida) Then
                dtpHora.Value = Date.Today.Add(horaConvertida.TimeOfDay)
            Else
                MessageBox.Show("No se pudo convertir la hora: " & horaTexto, "Error de hora", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

End Class