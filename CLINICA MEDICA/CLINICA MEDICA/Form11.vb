Imports Npgsql
Imports System.Data

Public Class Form11

    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"
    Dim posicion As Integer = 0

    Private Sub frmDisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdDisponibilidad.ReadOnly = True
        dgvDisponibilidad.AllowUserToAddRows = False
        dgvDisponibilidad.ReadOnly = True
        dgvDisponibilidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList

        CargarMedicos()
        CargarTabla()
    End Sub

    ' --- MÉTODO PARA CONVERTIR LAS HORAS DE POSTGRESQL ---
    Private Function ConvertirADateTime(valor As Object) As DateTime
        If valor Is Nothing OrElse IsDBNull(valor) Then Return DateTime.Now

        Dim tipoDato As String = valor.GetType().Name
        If tipoDato = "TimeOnly" Then
            Dim soloHora As TimeOnly = DirectCast(valor, TimeOnly)
            Return DateTime.Today.Add(soloHora.ToTimeSpan())
        ElseIf tipoDato = "TimeSpan" Then
            Return DateTime.Today.Add(DirectCast(valor, TimeSpan))
        End If

        Try
            Return Convert.ToDateTime(valor)
        Catch ex As Exception
            Return DateTime.Now
        End Try
    End Function

    ' --- CARGAS DE DATOS ---
    Private Sub CargarMedicos()
        Dim query As String = "SELECT id_medico, id_medico::text AS descripcion_medico FROM medicos"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                Dim da As New NpgsqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cmbMedico.DataSource = dt
                cmbMedico.DisplayMember = "descripcion_medico"
                cmbMedico.ValueMember = "id_medico"
                cmbMedico.SelectedIndex = -1
            Catch ex As Exception
                MessageBox.Show("Error al cargar médicos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CargarTabla()
        ' 🚨 Se quitó la columna motivo de la consulta
        Dim query As String = "SELECT id_disponibilidad, id_medico, hora_inicio, hora_fin FROM disponibilidad_medico ORDER BY id_disponibilidad ASC"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                Dim da As New NpgsqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvDisponibilidad.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar la tabla: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LimpiarCampos()
        txtIdDisponibilidad.Clear()
        cmbMedico.SelectedIndex = -1
        dtpHoraInicio.Value = DateTime.Now
        dtpHoraFin.Value = DateTime.Now
        cmbMedico.Focus()
    End Sub

    ' --- ACCIONES CRUD ---
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbMedico.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un médico.")
            Return
        End If

        ' 🚨 Se quitó el campo motivo del INSERT
        Dim query As String = "INSERT INTO disponibilidad_medico (id_medico, hora_inicio, hora_fin) VALUES (@idMedico, @horaInicio, @horaFin)"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("idMedico", Convert.ToInt32(cmbMedico.SelectedValue))
                    cmd.Parameters.AddWithValue("horaInicio", dtpHoraInicio.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("horaFin", dtpHoraFin.Value.TimeOfDay)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Horario guardado correctamente.", "Éxito")
                CargarTabla()
                LimpiarCampos()

                ' Actualizamos el menú
                Form1.CargarEstadisticas()
            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If String.IsNullOrWhiteSpace(txtIdDisponibilidad.Text) Then
            MessageBox.Show("Seleccione un registro de la tabla para editar.")
            Return
        End If

        ' 🚨 Se quitó el campo motivo del UPDATE
        Dim query As String = "UPDATE disponibilidad_medico SET id_medico = @idMedico, hora_inicio = @horaInicio, hora_fin = @horaFin WHERE id_disponibilidad = @id"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("idMedico", Convert.ToInt32(cmbMedico.SelectedValue))
                    cmd.Parameters.AddWithValue("horaInicio", dtpHoraInicio.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("horaFin", dtpHoraFin.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("id", Convert.ToInt32(txtIdDisponibilidad.Text))

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Horario actualizado correctamente.", "Éxito")
                CargarTabla()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al editar: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIdDisponibilidad.Text) Then
            MessageBox.Show("Seleccione un registro para eliminar.")
            Return
        End If

        If MessageBox.Show("¿Desea eliminar este horario?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim query As String = "DELETE FROM disponibilidad_medico WHERE id_disponibilidad = @id"

            Using conn As New NpgsqlConnection(conexionString)
                Try
                    conn.Open()
                    Using cmd As New NpgsqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(txtIdDisponibilidad.Text))
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Horario eliminado.")
                    CargarTabla()
                    LimpiarCampos()

                    ' Actualizamos el menú
                    Form1.CargarEstadisticas()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Hide()
    End Sub

    ' --- SELECCIÓN EN LA TABLA ---
    Private Sub dgvDisponibilidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisponibilidad.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim fila As DataGridViewRow = dgvDisponibilidad.Rows(e.RowIndex)

                txtIdDisponibilidad.Text = fila.Cells("id_disponibilidad").Value.ToString()
                cmbMedico.SelectedValue = Convert.ToInt32(fila.Cells("id_medico").Value)

                ' Traduce las horas de PostgreSQL al formato de Visual Basic
                dtpHoraInicio.Value = ConvertirADateTime(fila.Cells("hora_inicio").Value)
                dtpHoraFin.Value = ConvertirADateTime(fila.Cells("hora_fin").Value)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnRegresar_Click_1(sender As Object, e As EventArgs) Handles btnRegresar.Click
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


    Private Sub MostrarRegistro()

        If dgvDisponibilidad.Rows.Count = 0 Then Exit Sub


        dgvDisponibilidad.ClearSelection()
        dgvDisponibilidad.Rows(posicion).Selected = True


        dgvDisponibilidad.FirstDisplayedScrollingRowIndex = posicion


        Try
            Dim fila As DataGridViewRow = dgvDisponibilidad.Rows(posicion)

            txtIdDisponibilidad.Text = fila.Cells("id_disponibilidad").Value.ToString()
            cmbMedico.SelectedValue = Convert.ToInt32(fila.Cells("id_medico").Value)
            dtpHoraInicio.Value = ConvertirADateTime(fila.Cells("hora_inicio").Value)
            dtpHoraFin.Value = ConvertirADateTime(fila.Cells("hora_fin").Value)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If dgvDisponibilidad.Rows.Count > 0 Then
            posicion = 0
            MostrarRegistro()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If dgvDisponibilidad.Rows.Count > 0 Then
            If posicion > 0 Then
                posicion -= 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya estás en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If dgvDisponibilidad.Rows.Count > 0 Then

            If posicion < dgvDisponibilidad.Rows.Count - 1 Then
                posicion += 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya estás en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If dgvDisponibilidad.Rows.Count > 0 Then
            posicion = dgvDisponibilidad.Rows.Count - 1
            MostrarRegistro()
        End If
    End Sub

End Class