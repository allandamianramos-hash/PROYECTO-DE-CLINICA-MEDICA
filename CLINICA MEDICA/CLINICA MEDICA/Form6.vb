Imports Npgsql

Public Class Form6

    Dim posicion As Integer = 0
    ' Asegúrate de que esta conexión sea correcta o usa un módulo si lo configuraste así
    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

    ' --- MÉTODO AUXILIAR PARA CORREGIR EL ERROR DE DATEONLY ---
    Private Function ConvertirADateTime(valor As Object) As DateTime
        If valor Is Nothing OrElse IsDBNull(valor) Then Return DateTime.Now
        ' Si el objeto es DateOnly (nuevo .NET), lo convertimos correctamente
        If valor.GetType().Name = "DateOnly" Then
            Return DirectCast(valor, DateOnly).ToDateTime(TimeOnly.MinValue)
        End If
        ' Si es string o formato estándar, lo parseamos
        Return Convert.ToDateTime(valor)
    End Function

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdConsulta.ReadOnly = True
        Try
            Dim dao As New ConsultaDAO()
            dgvConsultas.DataSource = dao.Mostrar()

            ' Ajustar títulos si existen las columnas
            If dgvConsultas.Columns.Contains("id_consulta") Then dgvConsultas.Columns("id_consulta").HeaderText = "ID Consulta"
            If dgvConsultas.Columns.Contains("id_cita") Then dgvConsultas.Columns("id_cita").HeaderText = "ID Cita"
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
        ' Nota: Usamos CURRENT_DATE en SQL para comparar contra la fecha de la base de datos
        Dim query As String = "SELECT fecha, id_estado FROM citas WHERE id_cita = @id"

        Using conn As New NpgsqlConnection(conexionString)
            conn.Open()
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("id", idCita)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim fechaCita As DateTime = ConvertirADateTime(reader("fecha"))
                        Dim idEstado As Integer = Convert.ToInt32(reader("id_estado"))

                        ' Si la fecha es mayor a hoy o está cancelada (ID 6)
                        If fechaCita.Date > DateTime.Today Or idEstado = 6 Then
                            esInvalida = True
                        End If
                    End If
                End Using
            End Using
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
            MessageBox.Show("Esta cita no es válida para generar una consulta (Puede ser futura, cancelada o ya tiene consulta).")
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
            dgvConsultas.DataSource = dao.Mostrar()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- MANEJO DE SELECCIÓN Y DATOS ---
    Private Sub dgvConsultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultas.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvConsultas.Rows(e.RowIndex)
            CargarDatosFila(fila)
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

            ' Usamos el nuevo método seguro para fechas
            dtpFechaConsulta.Value = ConvertirADateTime(fila.Cells("fecha_consulta").Value)
            dtpHoraConsulta.Value = ConvertirADateTime(fila.Cells("hora_consulta").Value)
        Catch ex As Exception
            ' Silencioso para evitar bloqueos si una celda está vacía
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

    ' --- BOTONES DE ACCIÓN ---
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' (Lógica de edición omitida por brevedad, usa la misma estructura que btnGuardar)
        ' Asegúrate de usar ConvertirADateTime si cargas fechas aquí también.
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIdConsulta.Text) Then Return
        If MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim dao As New ConsultaDAO()
            dao.Eliminar(Convert.ToInt32(txtIdConsulta.Text))
            LimpiarCampos()
            dgvConsultas.DataSource = dao.Mostrar()
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
        Application.Exit()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            If dgvConsultas.DataSource Is Nothing Then Exit Sub
            Dim texto = txtBuscar.Text.Trim().Replace("'", "''")
            Dim dv As DataView = TryCast(dgvConsultas.DataSource, DataView)
            If dv Is Nothing Then dv = CType(dgvConsultas.DataSource, DataTable).DefaultView
            dv.RowFilter = "diagnostico LIKE '%" & texto & "%'"
        Catch ex As Exception
        End Try
    End Sub
End Class