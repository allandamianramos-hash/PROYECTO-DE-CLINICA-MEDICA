Public Class Form6




    Dim tablaConsultas As New DataTable
        Dim posicion As Integer = 0

        Private Sub FormConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' ID no editable
            txtIdConsulta.ReadOnly = True

            ' ComboBox de citas
            cmbIdCita.DropDownStyle = ComboBoxStyle.DropDownList
            cmbIdCita.Items.Clear()

            For i As Integer = 1 To 100
                cmbIdCita.Items.Add("Cita " & i)
            Next

            cmbIdCita.SelectedIndex = -1

            ' TextBox multilínea
            txtDiagnostico.Multiline = True
            txtObservaciones.Multiline = True

            txtDiagnostico.ScrollBars = ScrollBars.Vertical
            txtObservaciones.ScrollBars = ScrollBars.Vertical

            ' Configuración del DataGridView
            dgvConsultas.AllowUserToAddRows = False
            dgvConsultas.ReadOnly = True
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvConsultas.MultiSelect = False
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Crear columnas
            tablaConsultas.Columns.Add("id_consulta")
            tablaConsultas.Columns.Add("id_cita")
            tablaConsultas.Columns.Add("diagnostico")
            tablaConsultas.Columns.Add("observaciones")

            dgvConsultas.DataSource = tablaConsultas

            ' Cambiar títulos de columnas
            dgvConsultas.Columns("id_consulta").HeaderText = "ID Consulta"
            dgvConsultas.Columns("id_cita").HeaderText = "ID Cita"
            dgvConsultas.Columns("diagnostico").HeaderText = "Diagnóstico"
            dgvConsultas.Columns("observaciones").HeaderText = "Observaciones"

            GenerarId()

        End Sub

        Private Sub GenerarId()

            txtIdConsulta.Text = (tablaConsultas.Rows.Count + 1).ToString()

        End Sub

        Private Function ValidarCampos() As Boolean

            If cmbIdCita.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione el ID de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbIdCita.Focus()
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

            txtIdConsulta.Clear()
            txtDiagnostico.Clear()
            txtObservaciones.Clear()

            cmbIdCita.SelectedIndex = -1

            dgvConsultas.DataSource = tablaConsultas

            GenerarId()
            cmbIdCita.Focus()

        End Sub

        Private Function LimpiarTextoFiltro(texto As String) As String

            Return texto.Replace("'", "''")

        End Function

        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

            LimpiarCampos()

        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

            If ValidarCampos() = False Then Exit Sub

            tablaConsultas.Rows.Add(
            txtIdConsulta.Text,
            cmbIdCita.SelectedIndex + 1,
            txtDiagnostico.Text.Trim(),
            txtObservaciones.Text.Trim()
        )

            MessageBox.Show("Consulta guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        End Sub

        Private Sub dgvConsultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultas.CellClick

            If e.RowIndex >= 0 Then

                posicion = e.RowIndex

                txtIdConsulta.Text = dgvConsultas.Rows(posicion).Cells("id_consulta").Value.ToString()

                Dim idCita As Integer = CInt(dgvConsultas.Rows(posicion).Cells("id_cita").Value)
                cmbIdCita.SelectedIndex = idCita - 1

                txtDiagnostico.Text = dgvConsultas.Rows(posicion).Cells("diagnostico").Value.ToString()
                txtObservaciones.Text = dgvConsultas.Rows(posicion).Cells("observaciones").Value.ToString()

            End If

        End Sub

        Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

            If dgvConsultas.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione una consulta para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ValidarCampos() = False Then Exit Sub

            posicion = dgvConsultas.CurrentRow.Index

            dgvConsultas.Rows(posicion).Cells("id_cita").Value = cmbIdCita.SelectedIndex + 1
            dgvConsultas.Rows(posicion).Cells("diagnostico").Value = txtDiagnostico.Text.Trim()
            dgvConsultas.Rows(posicion).Cells("observaciones").Value = txtObservaciones.Text.Trim()

            MessageBox.Show("Consulta editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            If dgvConsultas.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione una consulta para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show("¿Desea eliminar esta consulta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then

                dgvConsultas.Rows.RemoveAt(dgvConsultas.CurrentRow.Index)

                MessageBox.Show("Consulta eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpiarCampos()

            End If

        End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

        Dim buscar As String

        buscar = InputBox("Ingrese diagnóstico u observación que desea buscar:", "Buscar consulta")

        If buscar.Trim = "" Then
            dgvConsultas.DataSource = tablaConsultas
            Exit Sub
        End If

        Dim vista As New DataView(tablaConsultas)
        Dim textoBuscar = LimpiarTextoFiltro(buscar.Trim)

        vista.RowFilter = String.Format(
        "diagnostico LIKE '%{0}%' OR observaciones LIKE '%{0}%'",
        textoBuscar
    )

        dgvConsultas.DataSource = vista

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

            txtIdConsulta.Text = dgvConsultas.Rows(posicion).Cells("id_consulta").Value.ToString()

            Dim idCita As Integer = CInt(dgvConsultas.Rows(posicion).Cells("id_cita").Value)
            cmbIdCita.SelectedIndex = idCita - 1

            txtDiagnostico.Text = dgvConsultas.Rows(posicion).Cells("diagnostico").Value.ToString()
            txtObservaciones.Text = dgvConsultas.Rows(posicion).Cells("observaciones").Value.ToString()

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