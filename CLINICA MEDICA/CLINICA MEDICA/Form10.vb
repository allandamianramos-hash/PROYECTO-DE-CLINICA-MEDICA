Imports System.Data
Imports System.Globalization

Public Class Form10

    Dim tablaFacturas As New DataTable
    Dim posicion As Integer = 0
    Dim cantidadesMedicamentos As New Dictionary(Of Integer, Integer)

    Dim precioFijoConsulta As Decimal = 500D
    Dim actualizandoLista As Boolean = False
    Dim tablaMedicamentosGlobal As DataTable

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdFactura.ReadOnly = True
        txtMontoTotal.ReadOnly = True

        cmbConsulta.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstadoPago.DropDownStyle = ComboBoxStyle.DropDownList

        dtpFechaPago.Format = DateTimePickerFormat.Custom
        dtpFechaPago.CustomFormat = "dd/MM/yyyy HH:mm:ss"

        dgvFacturas.AllowUserToAddRows = False
        dgvFacturas.ReadOnly = True
        dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFacturas.MultiSelect = False
        dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        CargarCombos()
        CargarMedicamentosAdquiridos()
        CargarTablaFacturas()
        LimpiarCampos()

    End Sub

    Private Sub CargarCombos()

        Dim dao As New FacturaDAO()
        Dim tablaConsultas As DataTable = dao.ObtenerConsultas()

        cmbConsulta.DataSource = tablaConsultas
        cmbConsulta.DisplayMember = "descripcion_consulta"
        cmbConsulta.ValueMember = "id_consulta"
        cmbConsulta.SelectedIndex = -1

        cmbMetodoPago.Items.Clear()
        cmbMetodoPago.Items.Add("Efectivo")
        cmbMetodoPago.Items.Add("Tarjeta")
        cmbMetodoPago.Items.Add("Transferencia")
        cmbMetodoPago.SelectedIndex = -1

        cmbEstadoPago.Items.Clear()
        cmbEstadoPago.Items.Add("Pagado")
        cmbEstadoPago.Items.Add("Pendiente")
        cmbEstadoPago.Items.Add("Cancelado")
        cmbEstadoPago.SelectedIndex = -1

    End Sub

    Private Sub CargarMedicamentosAdquiridos()

        Dim dao As New FacturaDAO()

        tablaMedicamentosGlobal = dao.ObtenerMedicamentos()

        clbMedicamentos.DataSource = tablaMedicamentosGlobal
        clbMedicamentos.DisplayMember = "descripcion"
        clbMedicamentos.ValueMember = "id_medicamento"

    End Sub

    Private Sub CargarTablaFacturas()

        Dim dao As New FacturaDAO()

        tablaFacturas = dao.ListarFacturas()
        dgvFacturas.DataSource = tablaFacturas

        If dgvFacturas.Columns.Contains("id_factura") Then dgvFacturas.Columns("id_factura").HeaderText = "ID Factura"
        If dgvFacturas.Columns.Contains("id_consulta") Then dgvFacturas.Columns("id_consulta").HeaderText = "ID Consulta"
        If dgvFacturas.Columns.Contains("monto_total") Then dgvFacturas.Columns("monto_total").HeaderText = "Monto Total"
        If dgvFacturas.Columns.Contains("fecha_pago") Then dgvFacturas.Columns("fecha_pago").HeaderText = "Fecha de Pago"
        If dgvFacturas.Columns.Contains("metodo_pago") Then dgvFacturas.Columns("metodo_pago").HeaderText = "Método de Pago"
        If dgvFacturas.Columns.Contains("estado_pago") Then dgvFacturas.Columns("estado_pago").HeaderText = "Estado de Pago"

    End Sub

    Private Function ValidarCampos() As Boolean

        If cmbConsulta.SelectedIndex = -1 OrElse cmbConsulta.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione una consulta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbConsulta.Focus()
            Return False
        End If

        If cmbMetodoPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el método de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMetodoPago.Focus()
            Return False
        End If

        If cmbEstadoPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el estado de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbEstadoPago.Focus()
            Return False
        End If

        If ObtenerMonto() < precioFijoConsulta Then
            MessageBox.Show("El monto total no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True

    End Function

    Private Function ObtenerMonto() As Decimal

        Dim monto As Decimal

        If Decimal.TryParse(txtMontoTotal.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, monto) Then
            Return monto
        End If

        Decimal.TryParse(txtMontoTotal.Text.Trim(), monto)
        Return monto

    End Function

    Private Function ObtenerDetallesFactura() As List(Of DetalleFactura)

        Dim lista As New List(Of DetalleFactura)

        If tablaMedicamentosGlobal Is Nothing Then Return lista

        For Each kvp As KeyValuePair(Of Integer, Integer) In cantidadesMedicamentos

            Dim idMed As Integer = kvp.Key
            Dim cantidad As Integer = kvp.Value

            Dim filas() As DataRow = tablaMedicamentosGlobal.Select("id_medicamento = " & idMed)

            If filas.Length > 0 Then

                Dim precio As Decimal = CDec(filas(0)("precio"))

                Dim detalle As New DetalleFactura()
                detalle.IdMedicamento = idMed
                detalle.Cantidad = cantidad
                detalle.PrecioUnitario = precio
                detalle.Subtotal = precio * cantidad

                lista.Add(detalle)

            End If

        Next

        Return lista

    End Function

    Private Sub LimpiarCampos()

        txtIdFactura.Clear()
        txtMontoTotal.Text = precioFijoConsulta.ToString("0.00")

        If cmbConsulta.DataSource IsNot Nothing Then cmbConsulta.SelectedIndex = -1
        cmbMetodoPago.SelectedIndex = -1
        cmbEstadoPago.SelectedIndex = -1

        actualizandoLista = True

        If clbMedicamentos.Items.Count > 0 Then
            For i As Integer = 0 To clbMedicamentos.Items.Count - 1
                clbMedicamentos.SetItemChecked(i, False)
            Next
        End If

        actualizandoLista = False

        cantidadesMedicamentos.Clear()

        If txtBuscarMedicamento IsNot Nothing Then
            txtBuscarMedicamento.Clear()
        End If

        If tablaMedicamentosGlobal IsNot Nothing Then
            tablaMedicamentosGlobal.DefaultView.RowFilter = ""
        End If

        dtpFechaPago.Value = Date.Now

        posicion = 0
        cmbConsulta.Focus()

    End Sub

    Private Sub clbMedicamentos_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbMedicamentos.ItemCheck

        If actualizandoLista Then Exit Sub
        If e.Index < 0 Then Exit Sub

        Dim fila As DataRowView = CType(clbMedicamentos.Items(e.Index), DataRowView)
        Dim idMedicamento As Integer = CInt(fila("id_medicamento"))

        If e.NewValue = CheckState.Checked Then

            Dim nombreMedicamento As String = fila("descripcion").ToString()
            Dim cantidadTexto As String = InputBox("Ingrese la cantidad adquirida de: " & nombreMedicamento, "Cantidad", "1")
            Dim cantidad As Integer

            If Integer.TryParse(cantidadTexto, cantidad) = False OrElse cantidad <= 0 Then
                MessageBox.Show("Cantidad inválida. Se usará cantidad 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cantidad = 1
            End If

            If cantidadesMedicamentos.ContainsKey(idMedicamento) Then
                cantidadesMedicamentos(idMedicamento) = cantidad
            Else
                cantidadesMedicamentos.Add(idMedicamento, cantidad)
            End If

        ElseIf e.NewValue = CheckState.Unchecked Then

            If cantidadesMedicamentos.ContainsKey(idMedicamento) Then
                cantidadesMedicamentos.Remove(idMedicamento)
            End If

        End If

        Me.BeginInvoke(New MethodInvoker(AddressOf CalcularTotalMedicamentos))

    End Sub

    Private Sub CalcularTotalMedicamentos()

        Dim total As Decimal = precioFijoConsulta

        If tablaMedicamentosGlobal IsNot Nothing Then

            For Each kvp As KeyValuePair(Of Integer, Integer) In cantidadesMedicamentos

                Dim idMed As Integer = kvp.Key
                Dim cantidad As Integer = kvp.Value

                Dim filas() As DataRow = tablaMedicamentosGlobal.Select("id_medicamento = " & idMed)

                If filas.Length > 0 Then
                    Dim precio As Decimal = CDec(filas(0)("precio"))
                    total += precio * cantidad
                End If

            Next

        End If

        txtMontoTotal.Text = total.ToString("0.00")

    End Sub

    Private Sub txtBuscarMedicamento_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarMedicamento.TextChanged

        If tablaMedicamentosGlobal Is Nothing Then Exit Sub

        Try
            actualizandoLista = True

            Dim filtro As String = txtBuscarMedicamento.Text.Trim().Replace("'", "''")
            tablaMedicamentosGlobal.DefaultView.RowFilter = "descripcion LIKE '%" & filtro & "%'"

            For i As Integer = 0 To clbMedicamentos.Items.Count - 1

                Dim fila As DataRowView = CType(clbMedicamentos.Items(i), DataRowView)
                Dim idMed As Integer = CInt(fila("id_medicamento"))

                If cantidadesMedicamentos.ContainsKey(idMed) Then
                    clbMedicamentos.SetItemChecked(i, True)
                Else
                    clbMedicamentos.SetItemChecked(i, False)
                End If

            Next

            actualizandoLista = False

        Catch ex As Exception
            actualizandoLista = False
            MessageBox.Show("Error al buscar medicamento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MarcarMedicamentosFactura(idFactura As Integer)

        cantidadesMedicamentos.Clear()

        Dim dao As New FacturaDAO()
        Dim tablaDetalle As DataTable = dao.ObtenerDetalleFactura(idFactura)

        For Each fila As DataRow In tablaDetalle.Rows

            Dim idMedicamento As Integer = CInt(fila("id_medicamento"))
            Dim cantidad As Integer = CInt(fila("cantidad"))

            If cantidadesMedicamentos.ContainsKey(idMedicamento) Then
                cantidadesMedicamentos(idMedicamento) = cantidad
            Else
                cantidadesMedicamentos.Add(idMedicamento, cantidad)
            End If

        Next

        If tablaMedicamentosGlobal IsNot Nothing Then
            tablaMedicamentosGlobal.DefaultView.RowFilter = ""
        End If

        actualizandoLista = True

        For i As Integer = 0 To clbMedicamentos.Items.Count - 1

            Dim item As DataRowView = CType(clbMedicamentos.Items(i), DataRowView)
            Dim idMed As Integer = CInt(item("id_medicamento"))

            If cantidadesMedicamentos.ContainsKey(idMed) Then
                clbMedicamentos.SetItemChecked(i, True)
            Else
                clbMedicamentos.SetItemChecked(i, False)
            End If

        Next

        actualizandoLista = False

        CalcularTotalMedicamentos()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        Dim factura As New Factura()
        factura.IdConsulta = CInt(cmbConsulta.SelectedValue)
        factura.MontoTotal = ObtenerMonto()
        factura.FechaPago = dtpFechaPago.Value
        factura.MetodoPago = cmbMetodoPago.Text
        factura.EstadoPago = cmbEstadoPago.Text
        factura.Detalles = ObtenerDetallesFactura()

        Dim dao As New FacturaDAO()
        dao.Guardar(factura)

        MessageBox.Show("Factura guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaFacturas()
        LimpiarCampos()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtIdFactura.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una factura para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        Dim factura As New Factura()
        factura.IdFactura = CInt(txtIdFactura.Text)
        factura.IdConsulta = CInt(cmbConsulta.SelectedValue)
        factura.MontoTotal = ObtenerMonto()
        factura.FechaPago = dtpFechaPago.Value
        factura.MetodoPago = cmbMetodoPago.Text
        factura.EstadoPago = cmbEstadoPago.Text
        factura.Detalles = ObtenerDetallesFactura()

        Dim dao As New FacturaDAO()
        dao.Editar(factura)

        MessageBox.Show("Factura editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaFacturas()
        LimpiarCampos()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtIdFactura.Text.Trim() = "" Then
            MessageBox.Show("Seleccione una factura para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Desea eliminar esta factura?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        Dim dao As New FacturaDAO()
        dao.Eliminar(CInt(txtIdFactura.Text))

        MessageBox.Show("Factura eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaFacturas()
        LimpiarCampos()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        CargarTablaFacturas()
        LimpiarCampos()

    End Sub

    Private Sub dgvFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturas.CellClick

        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            MostrarFactura()
        End If

    End Sub

    Private Sub MostrarFactura()

        If dgvFacturas.Rows.Count = 0 Then Exit Sub
        If posicion < 0 OrElse posicion >= dgvFacturas.Rows.Count Then Exit Sub

        dgvFacturas.ClearSelection()
        dgvFacturas.Rows(posicion).Selected = True
        dgvFacturas.CurrentCell = dgvFacturas.Rows(posicion).Cells("id_factura")

        Dim fila As DataGridViewRow = dgvFacturas.Rows(posicion)

        txtIdFactura.Text = fila.Cells("id_factura").Value.ToString()
        cmbConsulta.SelectedValue = CInt(fila.Cells("id_consulta").Value)
        txtMontoTotal.Text = fila.Cells("monto_total").Value.ToString()
        cmbMetodoPago.Text = fila.Cells("metodo_pago").Value.ToString()
        cmbEstadoPago.Text = fila.Cells("estado_pago").Value.ToString()

        Dim fechaTexto As String = fila.Cells("fecha_pago").Value.ToString()
        Dim fechaConvertida As DateTime

        If DateTime.TryParse(fechaTexto, fechaConvertida) Then
            dtpFechaPago.Value = fechaConvertida
        Else
            dtpFechaPago.Value = Date.Now
        End If

        MarcarMedicamentosFactura(CInt(txtIdFactura.Text))

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvFacturas.Rows.Count > 0 Then
            posicion = 0
            MostrarFactura()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If dgvFacturas.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                MostrarFactura()
            Else
                MessageBox.Show("Ya está en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvFacturas.Rows.Count > 0 Then

            If posicion < dgvFacturas.Rows.Count - 1 Then
                posicion += 1
                MostrarFactura()
            Else
                MessageBox.Show("Ya está en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvFacturas.Rows.Count > 0 Then
            posicion = dgvFacturas.Rows.Count - 1
            MostrarFactura()
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