Imports Npgsql

Public Class Form6

    Dim posicion As Integer = 0
    ' Cadena de conexión global del formulario
    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

    Private Function ConvertirADateTime(valor As Object) As DateTime
        If valor Is Nothing OrElse IsDBNull(valor) Then Return DateTime.Now

        Dim tipoDato As String = valor.GetType().Name

        If tipoDato = "DateOnly" Then
            Return DirectCast(valor, DateOnly).ToDateTime(TimeOnly.MinValue)
        End If

        If tipoDato = "TimeOnly" Then
            Dim soloHora As TimeOnly = DirectCast(valor, TimeOnly)
            Return DateTime.Today.Add(soloHora.ToTimeSpan())
        End If

        If tipoDato = "TimeSpan" Then
            Dim lapso As TimeSpan = DirectCast(valor, TimeSpan)
            Return DateTime.Today.Add(lapso)
        End If

        Try
            Return Convert.ToDateTime(valor)
        Catch ex As Exception
            Return DateTime.Now
        End Try
    End Function

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdConsulta.ReadOnly = True

        ' Ajustes visuales de la tabla
        dgvConsultas.AllowUserToAddRows = False
        dgvConsultas.ReadOnly = True
        dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvConsultas.MultiSelect = False

        Try
            Dim dao As New ConsultaDAO()
            dgvConsultas.DataSource = dao.Mostrar()

            If dgvConsultas.Columns.Contains("id_consulta") Then dgvConsultas.Columns("id_consulta").HeaderText = "ID Consulta"
            If dgvConsultas.Columns.Contains("id_cita") Then dgvConsultas.Columns("id_cita").HeaderText = "ID Cita"
            If dgvConsultas.Columns.Contains("peso_kg") Then dgvConsultas.Columns("peso_kg").HeaderText = "Peso (Kg)"
            If dgvConsultas.Columns.Contains("estatura_m") Then dgvConsultas.Columns("estatura_m").HeaderText = "Estatura (M)"
        Catch ex As Exception
            MessageBox.Show("Error al cargar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtIdConsulta.Clear()
        txtPeso.Clear()
        txtEstatura.Clear()
        txtSintomas.Clear()
        txtDiagnostico.Clear()
        txtObservaciones.Clear()
        txtCita.Clear()
        dtpFechaConsulta.Value = DateTime.Now
        dtpHoraConsulta.Value = DateTime.Now
        txtCita.Focus()
    End Sub

    Private Function EsCitaInvalida(idCita As Integer) As Boolean
        Dim esInvalida As Boolean = False
        ' 🚨 FIX: Ahora también contamos si esa cita ya existe en la tabla de consultas
        Dim query As String = "SELECT fecha, id_estado, (SELECT COUNT(*) FROM consultas WHERE id_cita = @id) AS uso FROM citas WHERE id_cita = @id"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("id", idCita)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim fechaCita As DateTime = ConvertirADateTime(reader("fecha"))
                            Dim idEstado As Integer = Convert.ToInt32(reader("id_estado"))
                            Dim uso As Integer = Convert.ToInt32(reader("uso"))

                            ' Si la fecha es futura, está cancelada (6) O ya fue usada para otra consulta (>0)
                            If fechaCita.Date > DateTime.Today Or idEstado = 6 Or uso > 0 Then
                                esInvalida = True
                            End If
                        Else
                            ' Si no encuentra la cita, también es inválida
                            esInvalida = True
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Silencioso
            End Try
        End Using
        Return esInvalida
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtCita.Text) Then
            MessageBox.Show("Debe ingresar el ID de una cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim citaSeleccionadaId As Integer = Convert.ToInt32(Val(txtCita.Text))

        If EsCitaInvalida(citaSeleccionadaId) Then
            MessageBox.Show("Esta cita no es válida. Razones posibles:" & vbCrLf & "- Es una cita para el futuro." & vbCrLf & "- La cita fue cancelada." & vbCrLf & "- Ya se registró una consulta para esta cita.", "Cita Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim nuevaConsulta As New Consulta()
            nuevaConsulta.IdCita = citaSeleccionadaId
            nuevaConsulta.Peso = Convert.ToDecimal(Val(txtPeso.Text))
            nuevaConsulta.Estatura = Convert.ToDecimal(Val(txtEstatura.Text))
            nuevaConsulta.Sintomas = txtSintomas.Text
            nuevaConsulta.Diagnostico = txtDiagnostico.Text
            nuevaConsulta.Observaciones = txtObservaciones.Text
            nuevaConsulta.Fecha = dtpFechaConsulta.Value.Date
            nuevaConsulta.Hora = dtpHoraConsulta.Value.TimeOfDay

            Dim dao As New ConsultaDAO()
            dao.Insertar(nuevaConsulta)

            MessageBox.Show("¡Consulta guardada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            Form1.CargarEstadisticas()
            dgvConsultas.DataSource = dao.Mostrar()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- MANEJO DE SELECCIÓN Y DATOS ---
    Private Sub dgvConsultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultas.CellClick
        If e.RowIndex >= 0 Then
            ' 🚨 FIX: Sincronizamos la variable de navegación
            posicion = e.RowIndex
            CargarDatosFila(dgvConsultas.Rows(posicion))
        End If
    End Sub

    Private Sub CargarDatosFila(fila As DataGridViewRow)
        Try
            txtIdConsulta.Text = fila.Cells("id_consulta").Value.ToString()
            txtCita.Text = fila.Cells("id_cita").Value.ToString()
            txtPeso.Text = fila.Cells("peso_kg").Value.ToString()
            txtEstatura.Text = fila.Cells("estatura_m").Value.ToString()
            txtSintomas.Text = fila.Cells("sintomas").Value.ToString()
            txtDiagnostico.Text = fila.Cells("diagnostico").Value.ToString()
            txtObservaciones.Text = fila.Cells("observaciones").Value.ToString()

            Dim colFecha As String = If(dgvConsultas.Columns.Contains("fecha_consulta"), "fecha_consulta", "fecha")
            Dim colHora As String = If(dgvConsultas.Columns.Contains("hora_consulta"), "hora_consulta", "hora")

            dtpFechaConsulta.Value = ConvertirADateTime(fila.Cells(colFecha).Value)
            dtpHoraConsulta.Value = ConvertirADateTime(fila.Cells(colHora).Value)

        Catch ex As Exception
            MessageBox.Show("Hubo un detalle al cargar la fila: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub MostrarRegistro()
        If dgvConsultas.Rows.Count = 0 Then Exit Sub
        dgvConsultas.ClearSelection()
        dgvConsultas.Rows(posicion).Selected = True
        CargarDatosFila(dgvConsultas.Rows(posicion))
    End Sub

    ' --- BOTONES DE NAVEGACIÓN ---
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If dgvConsultas.Rows.Count > 0 Then posicion = 0 : MostrarRegistro()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then posicion -= 1 : MostrarRegistro()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dgvConsultas.Rows.Count - 1 Then posicion += 1 : MostrarRegistro()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If dgvConsultas.Rows.Count > 0 Then posicion = dgvConsultas.Rows.Count - 1 : MostrarRegistro()
    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If String.IsNullOrWhiteSpace(txtIdConsulta.Text) Then
            MessageBox.Show("Primero seleccione una consulta de la tabla inferior para editarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtCita.Text) Then
            MessageBox.Show("Debe ingresar el ID de una cita válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim c As New Consulta()

            c.IdConsulta = Convert.ToInt32(txtIdConsulta.Text)
            c.IdCita = Convert.ToInt32(Val(txtCita.Text))

            c.Peso = Convert.ToDecimal(Val(txtPeso.Text))
            c.Estatura = Convert.ToDecimal(Val(txtEstatura.Text))
            c.Sintomas = txtSintomas.Text
            c.Diagnostico = txtDiagnostico.Text
            c.Observaciones = txtObservaciones.Text
            c.Fecha = dtpFechaConsulta.Value.Date
            c.Hora = dtpHoraConsulta.Value.TimeOfDay

            Dim dao As New ConsultaDAO()
            dao.Actualizar(c)

            MessageBox.Show("¡El registro se actualizó correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()
            Form1.CargarEstadisticas()
            dgvConsultas.DataSource = dao.Mostrar()

        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIdConsulta.Text) Then
            MessageBox.Show("Primero seleccione una consulta para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Eliminar este registro de consulta médica?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim dao As New ConsultaDAO()
                dao.Eliminar(Convert.ToInt32(txtIdConsulta.Text))

                MessageBox.Show("Consulta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpiarCampos()
                Form1.CargarEstadisticas()
                dgvConsultas.DataSource = dao.Mostrar()

            Catch ex As Exception
                ' 🚨 FIX: Escudo protector por si la consulta ya tiene recetas emitidas
                If ex.Message.Contains("recetas y medicamentos") Or ex.Message.Contains("violates foreign key") Then
                    MessageBox.Show("No se puede eliminar esta consulta porque ya se le emitieron recetas y medicamentos.", "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Error al eliminar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            If dgvConsultas.DataSource Is Nothing Then Exit Sub
            Dim texto = txtBuscar.Text.Trim().Replace("'", "''")
            Dim dv As DataView = TryCast(dgvConsultas.DataSource, DataView)
            If dv Is Nothing Then dv = CType(dgvConsultas.DataSource, DataTable).DefaultView

            ' 🚨 FIX: Ahora el buscador encuentra por Diagnóstico, Síntomas u Observaciones
            dv.RowFilter = "diagnostico LIKE '%" & texto & "%' OR sintomas LIKE '%" & texto & "%' OR observaciones LIKE '%" & texto & "%'"
        Catch ex As Exception
            ' Silencioso
        End Try
    End Sub

End Class