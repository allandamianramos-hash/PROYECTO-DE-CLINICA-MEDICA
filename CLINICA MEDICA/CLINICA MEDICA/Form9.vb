Imports System.Data
Imports System.Globalization

Public Class Form9

    Dim tablaMedicamentos As New DataTable
    Dim posicion As Integer = 0

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdMedicamento.ReadOnly = True

        cmbFormaFarmaceutica.DropDownStyle = ComboBoxStyle.DropDownList
        CargarFormasFarmaceuticas()

        dgvMedicamentos.AllowUserToAddRows = False
        dgvMedicamentos.ReadOnly = True
        dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicamentos.MultiSelect = False
        dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        CargarTablaMedicamentos()
        LimpiarCampos()

    End Sub

    Private Sub CargarFormasFarmaceuticas()

        cmbFormaFarmaceutica.Items.Clear()

        cmbFormaFarmaceutica.Items.Add("Tableta")
        cmbFormaFarmaceutica.Items.Add("Cápsula")
        cmbFormaFarmaceutica.Items.Add("Jarabe")
        cmbFormaFarmaceutica.Items.Add("Crema")
        cmbFormaFarmaceutica.Items.Add("Ampolla")
        cmbFormaFarmaceutica.Items.Add("Inhalador")
        cmbFormaFarmaceutica.Items.Add("Gotas oftálmicas")
        cmbFormaFarmaceutica.Items.Add("Gotas óticas")
        cmbFormaFarmaceutica.Items.Add("Suspensión")
        cmbFormaFarmaceutica.Items.Add("Solución oral")
        cmbFormaFarmaceutica.Items.Add("Sobre")
        cmbFormaFarmaceutica.Items.Add("Frasco ampolla")

        cmbFormaFarmaceutica.SelectedIndex = -1

    End Sub

    Private Sub CargarTablaMedicamentos()

        Dim dao As New MedicamentoDAO()

        tablaMedicamentos = dao.ListarMedicamentos()
        dgvMedicamentos.DataSource = tablaMedicamentos

        FormatearColumnas()

    End Sub

    Private Sub FormatearColumnas()

        If dgvMedicamentos.Columns.Contains("id_medicamento") Then dgvMedicamentos.Columns("id_medicamento").HeaderText = "ID Medicamento"
        If dgvMedicamentos.Columns.Contains("nombre_comercial") Then dgvMedicamentos.Columns("nombre_comercial").HeaderText = "Nombre Comercial"
        If dgvMedicamentos.Columns.Contains("nombre_generico") Then dgvMedicamentos.Columns("nombre_generico").HeaderText = "Nombre Genérico"
        If dgvMedicamentos.Columns.Contains("concentracion") Then dgvMedicamentos.Columns("concentracion").HeaderText = "Concentración"
        If dgvMedicamentos.Columns.Contains("forma_farmaceutica") Then dgvMedicamentos.Columns("forma_farmaceutica").HeaderText = "Forma Farmacéutica"
        If dgvMedicamentos.Columns.Contains("precio") Then dgvMedicamentos.Columns("precio").HeaderText = "Precio"

    End Sub

    Private Function ValidarCampos() As Boolean

        If txtNombreComercial.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre comercial.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreComercial.Focus()
            Return False
        End If

        If txtNombreGenerico.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre genérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreGenerico.Focus()
            Return False
        End If

        If txtConcentracion.Text.Trim() = "" Then
            MessageBox.Show("Ingrese la concentración.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConcentracion.Focus()
            Return False
        End If

        If cmbFormaFarmaceutica.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la forma farmacéutica.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbFormaFarmaceutica.Focus()
            Return False
        End If

        If txtPrecio.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el precio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        End If

        Dim precio As Decimal

        If Decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, precio) = False AndAlso
           Decimal.TryParse(txtPrecio.Text.Trim(), precio) = False Then

            MessageBox.Show("Ingrese un precio válido. Ejemplo: 25.00", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False

        End If

        If precio < 0 Then
            MessageBox.Show("El precio no puede ser negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function ObtenerPrecio() As Decimal

        Dim precio As Decimal

        If Decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, precio) Then
            Return precio
        End If

        Decimal.TryParse(txtPrecio.Text.Trim(), precio)
        Return precio

    End Function

    Private Sub LimpiarCampos()

        txtIdMedicamento.Clear()
        txtNombreComercial.Clear()
        txtNombreGenerico.Clear()
        txtConcentracion.Clear()
        txtPrecio.Clear()
        txtBuscar.Clear()

        cmbFormaFarmaceutica.SelectedIndex = -1

        posicion = 0
        txtNombreComercial.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        Dim medicamento As New Medicamento()

        medicamento.NombreComercial = txtNombreComercial.Text.Trim()
        medicamento.NombreGenerico = txtNombreGenerico.Text.Trim()
        medicamento.Concentracion = txtConcentracion.Text.Trim()
        medicamento.FormaFarmaceutica = cmbFormaFarmaceutica.Text
        medicamento.Precio = ObtenerPrecio()

        Dim dao As New MedicamentoDAO()
        dao.Guardar(medicamento)

        MessageBox.Show("Medicamento guardado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaMedicamentos()
        LimpiarCampos()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtIdMedicamento.Text.Trim() = "" Then
            MessageBox.Show("Seleccione un medicamento para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        Dim medicamento As New Medicamento()

        medicamento.IdMedicamento = CInt(txtIdMedicamento.Text)
        medicamento.NombreComercial = txtNombreComercial.Text.Trim()
        medicamento.NombreGenerico = txtNombreGenerico.Text.Trim()
        medicamento.Concentracion = txtConcentracion.Text.Trim()
        medicamento.FormaFarmaceutica = cmbFormaFarmaceutica.Text
        medicamento.Precio = ObtenerPrecio()

        Dim dao As New MedicamentoDAO()
        dao.Editar(medicamento)

        MessageBox.Show("Medicamento editado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaMedicamentos()
        LimpiarCampos()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtIdMedicamento.Text.Trim() = "" Then
            MessageBox.Show("Seleccione un medicamento para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea eliminar este medicamento?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        Dim dao As New MedicamentoDAO()
        dao.Eliminar(CInt(txtIdMedicamento.Text))

        MessageBox.Show("Medicamento eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTablaMedicamentos()
        LimpiarCampos()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        CargarTablaMedicamentos()
        LimpiarCampos()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Try
            Dim dao As New MedicamentoDAO()
            Dim texto As String = txtBuscar.Text.Trim()

            If texto = "" Then
                tablaMedicamentos = dao.ListarMedicamentos()
            Else
                tablaMedicamentos = dao.BuscarMedicamentos(texto)
            End If

            dgvMedicamentos.DataSource = tablaMedicamentos
            FormatearColumnas()

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvMedicamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentos.CellClick

        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            MostrarMedicamento()
        End If

    End Sub

    Private Sub MostrarMedicamento()

        If dgvMedicamentos.Rows.Count = 0 Then Exit Sub
        If posicion < 0 OrElse posicion >= dgvMedicamentos.Rows.Count Then Exit Sub

        dgvMedicamentos.ClearSelection()
        dgvMedicamentos.Rows(posicion).Selected = True
        dgvMedicamentos.CurrentCell = dgvMedicamentos.Rows(posicion).Cells("id_medicamento")

        Dim fila As DataGridViewRow = dgvMedicamentos.Rows(posicion)

        txtIdMedicamento.Text = fila.Cells("id_medicamento").Value.ToString()
        txtNombreComercial.Text = fila.Cells("nombre_comercial").Value.ToString()
        txtNombreGenerico.Text = fila.Cells("nombre_generico").Value.ToString()
        txtConcentracion.Text = fila.Cells("concentracion").Value.ToString()
        cmbFormaFarmaceutica.Text = fila.Cells("forma_farmaceutica").Value.ToString()
        txtPrecio.Text = fila.Cells("precio").Value.ToString()

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvMedicamentos.Rows.Count > 0 Then
            posicion = 0
            MostrarMedicamento()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If dgvMedicamentos.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                MostrarMedicamento()
            Else
                MessageBox.Show("Ya está en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvMedicamentos.Rows.Count > 0 Then

            If posicion < dgvMedicamentos.Rows.Count - 1 Then
                posicion += 1
                MostrarMedicamento()
            Else
                MessageBox.Show("Ya está en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvMedicamentos.Rows.Count > 0 Then
            posicion = dgvMedicamentos.Rows.Count - 1
            MostrarMedicamento()
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