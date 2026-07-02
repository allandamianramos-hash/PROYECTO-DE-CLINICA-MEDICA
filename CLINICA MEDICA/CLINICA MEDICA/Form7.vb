Imports System.Data

Public Class Form7

    Dim tablaRecetas As New DataTable
    Dim posicion As Integer = 0
    Dim tablaMedicamentosCompleta As New DataTable
    Dim detallesMedicamentos As New Dictionary(Of Integer, DetalleReceta)
    Dim cargandoDatos As Boolean = False

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdReceta.ReadOnly = True

        cmbIdConsulta.DropDownStyle = ComboBoxStyle.DropDownList

        dgvRecetas.AllowUserToAddRows = False
        dgvRecetas.ReadOnly = True
        dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecetas.MultiSelect = False
        dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        CargarCombos()
        CargarMedicamentos()
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

    End Sub

    Private Sub CargarTodasLasConsultas()

        Dim dao As New RecetaDAO()

        Dim tablaConsultas As DataTable = dao.ObtenerTodasLasConsultas()

        cmbIdConsulta.DataSource = tablaConsultas
        cmbIdConsulta.DisplayMember = "descripcion_consulta"
        cmbIdConsulta.ValueMember = "id_consulta"
        cmbIdConsulta.SelectedIndex = -1

    End Sub

    Private Sub CargarMedicamentos()

        Dim dao As New RecetaDAO()

        tablaMedicamentosCompleta = dao.ObtenerMedicamentos()

        clbMedicamentos.DataSource = Nothing
        clbMedicamentos.DataSource = tablaMedicamentosCompleta
        clbMedicamentos.DisplayMember = "medicamento"
        clbMedicamentos.ValueMember = "id_medicamento"

    End Sub

    Private Sub MostrarTodosLosMedicamentos()

        cargandoDatos = True

        clbMedicamentos.DataSource = Nothing
        clbMedicamentos.DataSource = tablaMedicamentosCompleta
        clbMedicamentos.DisplayMember = "medicamento"
        clbMedicamentos.ValueMember = "id_medicamento"

        cargandoDatos = False

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

        If cmbIdConsulta.SelectedIndex = -1 OrElse cmbIdConsulta.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione el identificador de la consulta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbIdConsulta.Focus()
            Return False
        End If

        If detallesMedicamentos.Count = 0 Then
            MessageBox.Show("Seleccione al menos un medicamento e ingrese su dosis e indicaciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clbMedicamentos.Focus()
            Return False
        End If

        For Each item As KeyValuePair(Of Integer, DetalleReceta) In detallesMedicamentos

            If item.Value.Dosis Is Nothing OrElse item.Value.Dosis.Trim() = "" Then
                MessageBox.Show("Debe ingresar dosis para todos los medicamentos seleccionados.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If item.Value.Indicaciones Is Nothing OrElse item.Value.Indicaciones.Trim() = "" Then
                MessageBox.Show("Debe ingresar indicaciones para todos los medicamentos seleccionados.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

        Next

        Return True

    End Function

    Private Function ObtenerDetallesMedicamentos() As List(Of DetalleReceta)

        Dim lista As New List(Of DetalleReceta)

        For Each item As KeyValuePair(Of Integer, DetalleReceta) In detallesMedicamentos
            lista.Add(item.Value)
        Next

        Return lista

    End Function

    Private Sub LimpiarMedicamentosMarcados()

        cargandoDatos = True

        For i As Integer = 0 To clbMedicamentos.Items.Count - 1
            clbMedicamentos.SetItemChecked(i, False)
        Next

        cargandoDatos = False

    End Sub

    Private Sub LimpiarCampos()

        txtIdReceta.Clear()
        txtBuscar.Clear()

        If cmbIdConsulta.DataSource IsNot Nothing Then cmbIdConsulta.SelectedIndex = -1

        MostrarTodosLosMedicamentos()
        LimpiarMedicamentosMarcados()

        detallesMedicamentos.Clear()

        posicion = 0
        cmbIdConsulta.Focus()

    End Sub

    Private Sub clbMedicamentos_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbMedicamentos.ItemCheck

        If cargandoDatos = True Then Exit Sub
        If e.Index < 0 Then Exit Sub

        Dim fila As DataRowView = CType(clbMedicamentos.Items(e.Index), DataRowView)
        Dim idMedicamento As Integer = CInt(fila("id_medicamento"))
        Dim nombreMedicamento As String = fila("medicamento").ToString()

        If e.NewValue = CheckState.Checked Then

            Dim dosis As String = InputBox("Ingrese la dosis para: " & nombreMedicamento, "Dosis del medicamento")

            If dosis.Trim() = "" Then
                MessageBox.Show("Debe ingresar una dosis.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.NewValue = CheckState.Unchecked
                Exit Sub
            End If

            Dim indicaciones As String = InputBox("Ingrese las indicaciones para: " & nombreMedicamento, "Indicaciones del medicamento")

            If indicaciones.Trim() = "" Then
                MessageBox.Show("Debe ingresar las indicaciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.NewValue = CheckState.Unchecked
                Exit Sub
            End If

            Dim detalle As New DetalleReceta()
            detalle.IdMedicamento = idMedicamento
            detalle.Dosis = dosis.Trim()
            detalle.Indicaciones = indicaciones.Trim()

            If detallesMedicamentos.ContainsKey(idMedicamento) Then
                detallesMedicamentos(idMedicamento) = detalle
            Else
                detallesMedicamentos.Add(idMedicamento, detalle)
            End If

        ElseIf e.NewValue = CheckState.Unchecked Then

            If detallesMedicamentos.ContainsKey(idMedicamento) Then
                detallesMedicamentos.Remove(idMedicamento)
            End If

        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        Dim receta As New Receta()

        receta.IdConsulta = CInt(cmbIdConsulta.SelectedValue)
        receta.Detalles = ObtenerDetallesMedicamentos()

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
        receta.Detalles = ObtenerDetallesMedicamentos()

        Dim dao As New RecetaDAO()
        dao.Editar(receta)

        MessageBox.Show("Receta editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarCombos()
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

        CargarCombos()
        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        CargarCombos()
        CargarTablaRecetas()
        LimpiarCampos()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Try
            If tablaMedicamentosCompleta Is Nothing OrElse tablaMedicamentosCompleta.Rows.Count = 0 Then Exit Sub

            Dim texto As String = txtBuscar.Text.Trim().Replace("'", "''")

            cargandoDatos = True

            If texto = "" Then

                clbMedicamentos.DataSource = Nothing
                clbMedicamentos.DataSource = tablaMedicamentosCompleta
                clbMedicamentos.DisplayMember = "medicamento"
                clbMedicamentos.ValueMember = "id_medicamento"

            Else

                Dim vista As New DataView(tablaMedicamentosCompleta)
                vista.RowFilter = "medicamento LIKE '%" & texto & "%'"

                clbMedicamentos.DataSource = Nothing
                clbMedicamentos.DataSource = vista
                clbMedicamentos.DisplayMember = "medicamento"
                clbMedicamentos.ValueMember = "id_medicamento"

            End If

            cargandoDatos = False

            MarcarMedicamentosGuardados()

        Catch ex As Exception
            cargandoDatos = False
            MessageBox.Show("Error al buscar medicamento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MarcarMedicamentosGuardados()

        cargandoDatos = True

        For i As Integer = 0 To clbMedicamentos.Items.Count - 1

            Dim item As DataRowView = CType(clbMedicamentos.Items(i), DataRowView)
            Dim idMedicamento As Integer = CInt(item("id_medicamento"))

            If detallesMedicamentos.ContainsKey(idMedicamento) Then
                clbMedicamentos.SetItemChecked(i, True)
            Else
                clbMedicamentos.SetItemChecked(i, False)
            End If

        Next

        cargandoDatos = False

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

        CargarTodasLasConsultas()

        cmbIdConsulta.SelectedValue = CInt(fila.Cells("id_consulta").Value)

        txtBuscar.Clear()
        MostrarTodosLosMedicamentos()
        LimpiarMedicamentosMarcados()
        detallesMedicamentos.Clear()

        Dim dao As New RecetaDAO()
        Dim medicamentosReceta As DataTable = dao.ObtenerMedicamentosPorReceta(CInt(txtIdReceta.Text))

        For Each medRow As DataRow In medicamentosReceta.Rows

            Dim detalle As New DetalleReceta()

            detalle.IdMedicamento = CInt(medRow("id_medicamento"))
            detalle.Dosis = medRow("dosis").ToString()
            detalle.Indicaciones = medRow("indicaciones").ToString()

            If detallesMedicamentos.ContainsKey(detalle.IdMedicamento) Then
                detallesMedicamentos(detalle.IdMedicamento) = detalle
            Else
                detallesMedicamentos.Add(detalle.IdMedicamento, detalle)
            End If

        Next

        MarcarMedicamentosGuardados()

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