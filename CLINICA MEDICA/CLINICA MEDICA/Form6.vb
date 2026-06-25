Public Class Form6

    Dim posicion As Integer = 0

    Private Sub FormConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdConsulta.ReadOnly = True

        Try
            Dim dao As New ConsultaDAO()
            dgvConsultas.DataSource = dao.Mostrar()

            ' Ajustar títulos si es necesario
            dgvConsultas.Columns("id_consulta").HeaderText = "ID Consulta"
            dgvConsultas.Columns("id_cita").HeaderText = "ID Cita"
        Catch ex As Exception
            MessageBox.Show("Error al cargar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtCita.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el ID de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCita.Focus()
            Return False
        End If

        If txtDiagnostico.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el diagnóstico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDiagnostico.Focus()
            Return False
        End If

        If txtObservaciones.Text.Trim() = "" Then
            MessageBox.Show("Ingrese las observaciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtObservaciones.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LimpiarCampos()
        ' Limpiar TextBox
        txtIdConsulta.Clear()
        txtPeso.Clear()
        txtEstatura.Clear()
        txtSintomas.Clear()
        txtDiagnostico.Clear()
        txtObservaciones.Clear()
        txtCita.Clear()

        ' Reiniciar Fechas a la fecha y hora actual
        dtpFechaConsulta.Value = DateTime.Now
        dtpHoraConsulta.Value = DateTime.Now

        ' Devolver el enfoque al primer campo
        txtCita.Focus()
    End Sub

    Private Function LimpiarTextoFiltro(texto As String) As String

        Return texto.Replace("'", "''")

    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        LimpiarCampos()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Pequeña validación rápida
        If String.IsNullOrWhiteSpace(txtCita.Text) Then
            MessageBox.Show("Debe ingresar el ID de una cita válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim nuevaConsulta As New Consulta()

            ' Asignamos los datos (Convirtiendo peso y estatura de texto a números decimales seguros)
            nuevaConsulta.IdCita = Convert.ToInt32(Val(txtCita.Text))

            ' Uso de Val() para evitar errores si el usuario deja el peso o estatura vacíos o con letras
            nuevaConsulta.Peso = Convert.ToDecimal(Val(txtPeso.Text))
            nuevaConsulta.Estatura = Convert.ToDecimal(Val(txtEstatura.Text))

            nuevaConsulta.Sintomas = txtSintomas.Text
            nuevaConsulta.Diagnostico = txtDiagnostico.Text
            nuevaConsulta.Observaciones = txtObservaciones.Text

            nuevaConsulta.Fecha = dtpFechaConsulta.Value.Date
            nuevaConsulta.Hora = dtpHoraConsulta.Value.TimeOfDay ' ¡Nuestro viejo truco del TimeSpan!

            ' Enviamos al DAO
            Dim dao As New ConsultaDAO()
            dao.Insertar(nuevaConsulta)

            MessageBox.Show("¡Consulta guardada exitosamente en Neon!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refrescar pantalla
            LimpiarCampos()
            dgvConsultas.DataSource = dao.Mostrar()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvConsultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultas.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim fila As DataGridViewRow = dgvConsultas.Rows(e.RowIndex)

                ' Cargar IDs
                txtIdConsulta.Text = fila.Cells("id_consulta").Value.ToString()
                txtCita.Text = fila.Cells("id_cita").Value.ToString() ' 👈 Adaptado a tu nuevo TextBox

                ' Cargar datos de texto y números
                txtPeso.Text = fila.Cells("peso_kg").Value.ToString()
                txtEstatura.Text = fila.Cells("estatura_m").Value.ToString()
                txtSintomas.Text = fila.Cells("sintomas").Value.ToString()
                txtDiagnostico.Text = fila.Cells("diagnostico").Value.ToString()
                txtObservaciones.Text = fila.Cells("observaciones").Value.ToString()

                ' 🛡️ FIX PARA LA FECHA (DateOnly)
                If Not IsDBNull(fila.Cells("fecha_consulta").Value) Then
                    ' Lo pasamos a String primero para que DateTime lo entienda sin chistar
                    Dim textoFecha As String = fila.Cells("fecha_consulta").Value.ToString()
                    dtpFechaConsulta.Value = DateTime.Parse(textoFecha)
                End If

                ' 🛡️ FIX PARA LA HORA (TimeOnly o TimeSpan)
                If Not IsDBNull(fila.Cells("hora_consulta").Value) Then
                    Dim textoHora As String = fila.Cells("hora_consulta").Value.ToString()
                    dtpHoraConsulta.Value = DateTime.Parse(textoHora)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al leer la fila: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvConsultas.CurrentRow Is Nothing OrElse String.IsNullOrWhiteSpace(txtIdConsulta.Text) Then
            MessageBox.Show("Primero seleccione una consulta de la tabla inferior para editarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validación arreglada para el TextBox
        If String.IsNullOrWhiteSpace(txtCita.Text) Then
            MessageBox.Show("Debe ingresar el ID de una cita válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim c As New Consulta()

            c.IdConsulta = Convert.ToInt32(txtIdConsulta.Text)

            ' Extracción arreglada para el TextBox
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

            MessageBox.Show("¡La estructura del registro se actualizó correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()
            dgvConsultas.DataSource = dao.Mostrar()

        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' 1. Validamos que haya un ID en el cuadro de texto (es decir, que hayan seleccionado algo)
        If String.IsNullOrWhiteSpace(txtIdConsulta.Text) Then
            MessageBox.Show("Por favor, seleccione una consulta de la tabla inferior para eliminarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Preguntamos al usuario si está completamente seguro
        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este registro de consulta de forma permanente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                ' Extraemos el ID de la pantalla
                Dim idConsulta As Integer = Convert.ToInt32(txtIdConsulta.Text)

                ' Llamamos al DAO para que ejecute el DELETE en PostgreSQL
                Dim dao As New ConsultaDAO()
                dao.Eliminar(idConsulta)

                MessageBox.Show("Consulta eliminada correctamente de la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiamos los cuadros y refrescamos la tabla para que desaparezca el registro
                LimpiarCampos()
                dgvConsultas.DataSource = dao.Mostrar()

            Catch ex As Exception
                MessageBox.Show("Error al intentar eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarCampos()

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvConsultas.Rows.Count > 0 Then
            posicion = 0
            MostrarRegistro()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If posicion > 0 Then
            posicion -= 1
            MostrarRegistro()
        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If posicion < dgvConsultas.Rows.Count - 1 Then
            posicion += 1
            MostrarRegistro()
        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvConsultas.Rows.Count > 0 Then
            posicion = dgvConsultas.Rows.Count - 1
            MostrarRegistro()
        End If

    End Sub

    Private Sub MostrarRegistro()
        If dgvConsultas.Rows.Count = 0 Then Exit Sub

        dgvConsultas.ClearSelection()
        dgvConsultas.Rows(posicion).Selected = True

        Dim fila As DataGridViewRow = dgvConsultas.Rows(posicion)

        Try
            ' Cargar IDs
            txtIdConsulta.Text = fila.Cells("id_consulta").Value.ToString()
            txtCita.Text = fila.Cells("id_cita").Value.ToString()

            ' Cargar datos
            txtPeso.Text = fila.Cells("peso_kg").Value.ToString()
            txtEstatura.Text = fila.Cells("estatura_m").Value.ToString()
            txtSintomas.Text = fila.Cells("sintomas").Value.ToString()
            txtDiagnostico.Text = fila.Cells("diagnostico").Value.ToString()
            txtObservaciones.Text = fila.Cells("observaciones").Value.ToString()

            ' Fechas seguras
            If Not IsDBNull(fila.Cells("fecha_consulta").Value) Then
                dtpFechaConsulta.Value = DateTime.Parse(fila.Cells("fecha_consulta").Value.ToString())
            End If

            If Not IsDBNull(fila.Cells("hora_consulta").Value) Then
                dtpHoraConsulta.Value = DateTime.Parse(fila.Cells("hora_consulta").Value.ToString())
            End If

        Catch ex As Exception
        End Try
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

    Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            ' 1. Obtenemos los datos actuales que están cargados en tu DataGridView
            ' (Usamos un bloque Try-Catch por si la tabla aún no se ha cargado al abrir el programa)
            Dim dt As DataTable = CType(dgvConsultas.DataSource, DataTable)

            If dt Is Nothing Then Exit Sub

            ' 2. Creamos una "Vista" para poder filtrar la tabla sin ir a la base de datos de nuevo
            Dim vista As New DataView(dt)

            ' 3. Limpiamos el texto (Reemplazamos la comilla simple por doble comilla para que no truene el SQL)
            Dim textoBuscar As String = txtBuscar.Text.Trim().Replace("'", "''")

            ' 4. Aplicamos el filtro: Buscamos coincidencias en síntomas, diagnóstico u observaciones
            If textoBuscar = "" Then
                vista.RowFilter = "" ' Si el usuario borra el texto, mostramos toda la tabla de nuevo
            Else
                vista.RowFilter = String.Format("sintomas LIKE '%{0}%' OR diagnostico LIKE '%{0}%' OR observaciones LIKE '%{0}%'", textoBuscar)
            End If

            ' 5. Le devolvemos los datos filtrados a la tabla visual
            dgvConsultas.DataSource = vista

        Catch ex As Exception
            ' Si hay algún error menor al escribir rápido, lo silenciamos para no molestar al usuario
        End Try

    End Sub
End Class