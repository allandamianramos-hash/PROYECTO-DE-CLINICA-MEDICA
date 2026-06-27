Imports System.Data
Public Class Form7

    Dim tablaRecetas As New DataTable
    Dim posicion As Integer = 0

    Private Sub FormRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdReceta.ReadOnly = True

        cmbIdConsulta.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMedicamento.DropDownStyle = ComboBoxStyle.DropDownList

        dgvRecetas.AllowUserToAddRows = False
        dgvRecetas.ReadOnly = True
        dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecetas.MultiSelect = False
        dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        CargarCombos()
        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub CargarCombos()

        Dim dao As New RecetaDAO()

        Dim tablaConsultas As DataTable = dao.ObtenerConsultas()
        cmbIdConsulta.DataSource = tablaConsultas
        cmbIdConsulta.DisplayMember = "descripcion_consulta"
        cmbIdConsulta.ValueMember = "id_consulta"
        cmbIdConsulta.SelectedIndex = -1

        Dim tablaMedicamentos As DataTable = dao.ObtenerMedicamentos()
        cmbMedicamento.DataSource = tablaMedicamentos
        cmbMedicamento.DisplayMember = "descripcion_medicamento"
        cmbMedicamento.ValueMember = "id_medicamento"
        cmbMedicamento.SelectedIndex = -1

    End Sub

    Private Sub CargarTablaRecetas()

        Dim dao As New RecetaDAO()

        tablaRecetas = dao.ListarRecetas()
        dgvRecetas.DataSource = tablaRecetas

        If dgvRecetas.Columns.Contains("id_receta") Then dgvRecetas.Columns("id_receta").HeaderText = "ID Receta"
        If dgvRecetas.Columns.Contains("id_consulta") Then dgvRecetas.Columns("id_consulta").HeaderText = "ID Consulta"
        If dgvRecetas.Columns.Contains("fecha_emision") Then dgvRecetas.Columns("fecha_emision").HeaderText = "Fecha Emisión"
        If dgvRecetas.Columns.Contains("id_detalle") Then dgvRecetas.Columns("id_detalle").Visible = False
        If dgvRecetas.Columns.Contains("id_medicamento") Then dgvRecetas.Columns("id_medicamento").HeaderText = "ID Medicamento"
        If dgvRecetas.Columns.Contains("medicamento") Then dgvRecetas.Columns("medicamento").HeaderText = "Medicamento"
        If dgvRecetas.Columns.Contains("dosis") Then dgvRecetas.Columns("dosis").HeaderText = "Dosis"
        If dgvRecetas.Columns.Contains("indicaciones") Then dgvRecetas.Columns("indicaciones").HeaderText = "Indicaciones"

    End Sub

    Private Function ValidarCampos() As Boolean

        If cmbIdConsulta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el identificador de la consulta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbIdConsulta.Focus()
            Return False
        End If

        If cmbMedicamento.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un medicamento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMedicamento.Focus()
            Return False
        End If

        If txtDosis.Text.Trim() = "" Then
            MessageBox.Show("Ingrese la dosis.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDosis.Focus()
            Return False
        End If

        If txtIndicaciones.Text.Trim() = "" Then
            MessageBox.Show("Ingrese las indicaciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIndicaciones.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub LimpiarCampos()

        txtIdReceta.Clear()
        txtDosis.Clear()
        txtIndicaciones.Clear()
        txtBuscar.Clear()

        If cmbIdConsulta.DataSource IsNot Nothing Then cmbIdConsulta.SelectedIndex = -1
        If cmbMedicamento.DataSource IsNot Nothing Then cmbMedicamento.SelectedIndex = -1

        posicion = 0
        cmbIdConsulta.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        Dim receta As New Receta()

        receta.IdConsulta = CInt(cmbIdConsulta.SelectedValue)
        receta.IdMedicamento = CInt(cmbMedicamento.SelectedValue)
        receta.Dosis = txtDosis.Text.Trim()
        receta.Indicaciones = txtIndicaciones.Text.Trim()

        Dim dao As New RecetaDAO()
        dao.Guardar(receta)

        MessageBox.Show("Receta guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarCombos()
        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtIdReceta.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una receta para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        Dim receta As New Receta()

        receta.IdReceta = CInt(txtIdReceta.Text)
        receta.IdConsulta = CInt(cmbIdConsulta.SelectedValue)
        receta.IdMedicamento = CInt(cmbMedicamento.SelectedValue)
        receta.Dosis = txtDosis.Text.Trim()
        receta.Indicaciones = txtIndicaciones.Text.Trim()

        Dim dao As New RecetaDAO()
        dao.Editar(receta)

        MessageBox.Show("Receta editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtIdReceta.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una receta para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea eliminar esta receta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        Dim dao As New RecetaDAO()
        dao.Eliminar(CInt(txtIdReceta.Text))

        MessageBox.Show("Receta eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Try
            If tablaRecetas Is Nothing OrElse tablaRecetas.Rows.Count = 0 Then Exit Sub

            Dim texto As String = txtBuscar.Text.Trim().Replace("'", "''")

            If texto = "" Then
                tablaRecetas.DefaultView.RowFilter = ""
            Else
                tablaRecetas.DefaultView.RowFilter =
                    "medicamento LIKE '%" & texto & "%' OR " &
                    "dosis LIKE '%" & texto & "%' OR " &
                    "indicaciones LIKE '%" & texto & "%'"
            End If

            dgvRecetas.DataSource = tablaRecetas

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvRecetas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecetas.CellClick

        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            MostrarReceta()
        End If

    End Sub

    Private Sub MostrarReceta()

        If dgvRecetas.Rows.Count = 0 Then Exit Sub
        If posicion < 0 OrElse posicion >= dgvRecetas.Rows.Count Then Exit Sub

        dgvRecetas.ClearSelection()
        dgvRecetas.Rows(posicion).Selected = True
        dgvRecetas.CurrentCell = dgvRecetas.Rows(posicion).Cells("id_receta")

        Dim fila As DataGridViewRow = dgvRecetas.Rows(posicion)

        txtIdReceta.Text = fila.Cells("id_receta").Value.ToString()

        cmbIdConsulta.SelectedValue = CInt(fila.Cells("id_consulta").Value)
        cmbMedicamento.SelectedValue = CInt(fila.Cells("id_medicamento").Value)

        txtDosis.Text = fila.Cells("dosis").Value.ToString()
        txtIndicaciones.Text = fila.Cells("indicaciones").Value.ToString()

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvRecetas.Rows.Count > 0 Then
            posicion = 0
            MostrarReceta()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If dgvRecetas.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                MostrarReceta()
            Else
                MessageBox.Show("Ya está en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvRecetas.Rows.Count > 0 Then

            If posicion < dgvRecetas.Rows.Count - 1 Then
                posicion += 1
                MostrarReceta()
            Else
                MessageBox.Show("Ya está en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvRecetas.Rows.Count > 0 Then
            posicion = dgvRecetas.Rows.Count - 1
            MostrarReceta()
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