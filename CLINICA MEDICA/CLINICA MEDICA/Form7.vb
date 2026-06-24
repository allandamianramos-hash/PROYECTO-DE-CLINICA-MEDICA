Public Class Form7


    Dim tablaRecetas As New DataTable
    Dim tablaMedicamentos As New DataTable
    Dim posicion As Integer = 0

    Private Sub FormReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdReceta.ReadOnly = True

        ' ComboBox consultas
        cmbIdConsulta.DropDownStyle = ComboBoxStyle.DropDownList
        cmbIdConsulta.Items.Clear()

        For i As Integer = 1 To 100
            cmbIdConsulta.Items.Add("Consulta " & i)
        Next

        cmbIdConsulta.SelectedIndex = -1

        ' ComboBox medicamentos
        cmbMedicamento.DropDownStyle = ComboBoxStyle.DropDownList
        CargarMedicamentos()

        ' TextBox multilínea
        txtIndicaciones.Multiline = True
        txtIndicaciones.ScrollBars = ScrollBars.Vertical

        ' Configuración DataGridView
        dgvRecetas.AllowUserToAddRows = False
        dgvRecetas.ReadOnly = True
        dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecetas.MultiSelect = False
        dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Columnas del DataGridView
        tablaRecetas.Columns.Add("id_receta")
        tablaRecetas.Columns.Add("id_consulta")
        tablaRecetas.Columns.Add("id_medicamento")
        tablaRecetas.Columns.Add("medicamento")
        tablaRecetas.Columns.Add("dosis")
        tablaRecetas.Columns.Add("frecuencia_indicacion")

        dgvRecetas.DataSource = tablaRecetas

        dgvRecetas.Columns("id_receta").HeaderText = "ID Receta"
        dgvRecetas.Columns("id_consulta").HeaderText = "ID Consulta"
        dgvRecetas.Columns("id_medicamento").HeaderText = "ID Medicamento"
        dgvRecetas.Columns("medicamento").HeaderText = "Medicamento"
        dgvRecetas.Columns("dosis").HeaderText = "Dosis"
        dgvRecetas.Columns("frecuencia_indicacion").HeaderText = "Indicaciones"

        GenerarId()

    End Sub

    Private Sub CargarMedicamentos()

        tablaMedicamentos.Columns.Add("id_medicamento", GetType(Integer))
        tablaMedicamentos.Columns.Add("nombre_medicamento", GetType(String))

        tablaMedicamentos.Rows.Add(1, "Panadol - Paracetamol 500 mg")
        tablaMedicamentos.Rows.Add(2, "Tylenol - Paracetamol 500 mg")
        tablaMedicamentos.Rows.Add(3, "Advil - Ibuprofeno 400 mg")
        tablaMedicamentos.Rows.Add(4, "Motrin - Ibuprofeno 600 mg")
        tablaMedicamentos.Rows.Add(5, "Amoxil - Amoxicilina 500 mg")
        tablaMedicamentos.Rows.Add(6, "Clamoxin - Amoxicilina Ácido Clavulánico 875/125 mg")
        tablaMedicamentos.Rows.Add(7, "Loratadina MK - Loratadina 10 mg")
        tablaMedicamentos.Rows.Add(8, "Claritin - Loratadina 10 mg")
        tablaMedicamentos.Rows.Add(9, "Omeprazol Genfar - Omeprazol 20 mg")
        tablaMedicamentos.Rows.Add(10, "Losec - Omeprazol 20 mg")
        tablaMedicamentos.Rows.Add(11, "Losartán MK - Losartán 50 mg")
        tablaMedicamentos.Rows.Add(12, "Cozaar - Losartán 100 mg")
        tablaMedicamentos.Rows.Add(13, "Metformina La Santé - Metformina 850 mg")
        tablaMedicamentos.Rows.Add(14, "Glucophage - Metformina 500 mg")
        tablaMedicamentos.Rows.Add(15, "Salbutamol Inhalador - Salbutamol 100 mcg/dosis")
        tablaMedicamentos.Rows.Add(16, "Ventolin - Salbutamol 100 mcg/dosis")
        tablaMedicamentos.Rows.Add(17, "Diclofenaco MK - Diclofenaco 50 mg")
        tablaMedicamentos.Rows.Add(18, "Voltaren - Diclofenaco 75 mg")
        tablaMedicamentos.Rows.Add(19, "Azitromicina Genfar - Azitromicina 500 mg")
        tablaMedicamentos.Rows.Add(20, "Zitromax - Azitromicina 500 mg")
        tablaMedicamentos.Rows.Add(21, "Cetrine - Cetirizina 10 mg")
        tablaMedicamentos.Rows.Add(22, "Zyrtec - Cetirizina 10 mg")
        tablaMedicamentos.Rows.Add(23, "Allegra - Fexofenadina 120 mg")
        tablaMedicamentos.Rows.Add(24, "Telfast - Fexofenadina 180 mg")
        tablaMedicamentos.Rows.Add(25, "Aspirina - Ácido Acetilsalicílico 100 mg")
        tablaMedicamentos.Rows.Add(26, "Aspirina Forte - Ácido Acetilsalicílico 500 mg")
        tablaMedicamentos.Rows.Add(27, "Naproxeno MK - Naproxeno 500 mg")
        tablaMedicamentos.Rows.Add(28, "Apronax - Naproxeno 550 mg")
        tablaMedicamentos.Rows.Add(29, "Dolex Gripa")
        tablaMedicamentos.Rows.Add(30, "Tabcin")
        tablaMedicamentos.Rows.Add(31, "Buscapina")
        tablaMedicamentos.Rows.Add(32, "Buscapina Compositum")
        tablaMedicamentos.Rows.Add(33, "Sertal")
        tablaMedicamentos.Rows.Add(34, "Plidan")
        tablaMedicamentos.Rows.Add(35, "Ranitidina Genfar")
        tablaMedicamentos.Rows.Add(36, "Famotidina MK")
        tablaMedicamentos.Rows.Add(37, "Pantoprazol La Santé")
        tablaMedicamentos.Rows.Add(38, "Esomeprazol MK")
        tablaMedicamentos.Rows.Add(39, "Enalapril MK")
        tablaMedicamentos.Rows.Add(40, "Captopril Genfar")
        tablaMedicamentos.Rows.Add(41, "Amlodipino MK")
        tablaMedicamentos.Rows.Add(42, "Norvasc")
        tablaMedicamentos.Rows.Add(43, "Atenolol Genfar")
        tablaMedicamentos.Rows.Add(44, "Propranolol MK")
        tablaMedicamentos.Rows.Add(45, "Hidroclorotiazida MK")
        tablaMedicamentos.Rows.Add(46, "Furosemida Genfar")
        tablaMedicamentos.Rows.Add(47, "Atorvastatina MK")
        tablaMedicamentos.Rows.Add(48, "Lipitor")
        tablaMedicamentos.Rows.Add(49, "Simvastatina Genfar")
        tablaMedicamentos.Rows.Add(50, "Rosuvastatina MK")
        tablaMedicamentos.Rows.Add(51, "Glibenclamida MK")
        tablaMedicamentos.Rows.Add(52, "Glimepirida Genfar")
        tablaMedicamentos.Rows.Add(53, "Insulina NPH")
        tablaMedicamentos.Rows.Add(54, "Insulina Rápida")
        tablaMedicamentos.Rows.Add(55, "Ciprofloxacino MK")
        tablaMedicamentos.Rows.Add(56, "Ciproxin")
        tablaMedicamentos.Rows.Add(57, "Levofloxacino Genfar")
        tablaMedicamentos.Rows.Add(58, "Claritromicina MK")
        tablaMedicamentos.Rows.Add(59, "Metronidazol Genfar")
        tablaMedicamentos.Rows.Add(60, "Flagyl")
        tablaMedicamentos.Rows.Add(61, "Albendazol MK")
        tablaMedicamentos.Rows.Add(62, "Zentel")
        tablaMedicamentos.Rows.Add(63, "Mebendazol Genfar")
        tablaMedicamentos.Rows.Add(64, "Fluconazol MK")
        tablaMedicamentos.Rows.Add(65, "Diflucan")
        tablaMedicamentos.Rows.Add(66, "Clotrimazol MK")
        tablaMedicamentos.Rows.Add(67, "Canesten")
        tablaMedicamentos.Rows.Add(68, "Aciclovir Genfar")
        tablaMedicamentos.Rows.Add(69, "Zovirax")
        tablaMedicamentos.Rows.Add(70, "Prednisona MK")
        tablaMedicamentos.Rows.Add(71, "Dexametasona Genfar")
        tablaMedicamentos.Rows.Add(72, "Betametasona MK")
        tablaMedicamentos.Rows.Add(73, "Hidrocortisona MK")
        tablaMedicamentos.Rows.Add(74, "Lágrimas Artificiales")
        tablaMedicamentos.Rows.Add(75, "Tobramicina Oftálmica")
        tablaMedicamentos.Rows.Add(76, "Gentamicina Oftálmica")
        tablaMedicamentos.Rows.Add(77, "Neomicina Polimixina")
        tablaMedicamentos.Rows.Add(78, "Ambroxol MK")
        tablaMedicamentos.Rows.Add(79, "Mucosolvan")
        tablaMedicamentos.Rows.Add(80, "Dextrometorfano Genfar")
        tablaMedicamentos.Rows.Add(81, "Vick Jarabe")
        tablaMedicamentos.Rows.Add(82, "Loperamida MK")
        tablaMedicamentos.Rows.Add(83, "Imodium")
        tablaMedicamentos.Rows.Add(84, "Suero Oral")
        tablaMedicamentos.Rows.Add(85, "Pedialyte")
        tablaMedicamentos.Rows.Add(86, "Hierro MK")
        tablaMedicamentos.Rows.Add(87, "Ácido Fólico Genfar")
        tablaMedicamentos.Rows.Add(88, "Vitamina C MK")
        tablaMedicamentos.Rows.Add(89, "Complejo B")
        tablaMedicamentos.Rows.Add(90, "Calcio D")
        tablaMedicamentos.Rows.Add(91, "Ketorolaco MK")
        tablaMedicamentos.Rows.Add(92, "Ketorolaco Inyectable")
        tablaMedicamentos.Rows.Add(93, "Tramadol Genfar")
        tablaMedicamentos.Rows.Add(94, "Lidocaína")
        tablaMedicamentos.Rows.Add(95, "Bupivacaína")
        tablaMedicamentos.Rows.Add(96, "Sertralina MK")
        tablaMedicamentos.Rows.Add(97, "Fluoxetina Genfar")
        tablaMedicamentos.Rows.Add(98, "Diazepam Genfar")
        tablaMedicamentos.Rows.Add(99, "Clonazepam MK")
        tablaMedicamentos.Rows.Add(100, "Melatonina")

        cmbMedicamento.DataSource = tablaMedicamentos
        cmbMedicamento.DisplayMember = "nombre_medicamento"
        cmbMedicamento.ValueMember = "id_medicamento"
        cmbMedicamento.SelectedIndex = -1

    End Sub

    Private Sub GenerarId()
        txtIdReceta.Text = (tablaRecetas.Rows.Count + 1).ToString()
    End Sub

    Private Function ValidarCampos() As Boolean

        If cmbIdConsulta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una consulta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        cmbIdConsulta.SelectedIndex = -1
        cmbMedicamento.SelectedIndex = -1

        dgvRecetas.DataSource = tablaRecetas

        GenerarId()
        cmbIdConsulta.Focus()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        tablaRecetas.Rows.Add(
            txtIdReceta.Text,
            cmbIdConsulta.SelectedIndex + 1,
            CInt(cmbMedicamento.SelectedValue),
            cmbMedicamento.Text,
            txtDosis.Text.Trim(),
            txtIndicaciones.Text.Trim()
        )

        MessageBox.Show("Receta guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LimpiarCampos()

    End Sub

    Private Sub dgvRecetas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecetas.CellClick

        If e.RowIndex >= 0 Then

            posicion = e.RowIndex

            txtIdReceta.Text = dgvRecetas.Rows(posicion).Cells("id_receta").Value.ToString()

            Dim idConsulta As Integer = CInt(dgvRecetas.Rows(posicion).Cells("id_consulta").Value)
            cmbIdConsulta.SelectedIndex = idConsulta - 1

            cmbMedicamento.SelectedValue = CInt(dgvRecetas.Rows(posicion).Cells("id_medicamento").Value)

            txtDosis.Text = dgvRecetas.Rows(posicion).Cells("dosis").Value.ToString()
            txtIndicaciones.Text = dgvRecetas.Rows(posicion).Cells("frecuencia_indicacion").Value.ToString()

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If dgvRecetas.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione una receta para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        posicion = dgvRecetas.CurrentRow.Index

        dgvRecetas.Rows(posicion).Cells("id_consulta").Value = cmbIdConsulta.SelectedIndex + 1
        dgvRecetas.Rows(posicion).Cells("id_medicamento").Value = CInt(cmbMedicamento.SelectedValue)
        dgvRecetas.Rows(posicion).Cells("medicamento").Value = cmbMedicamento.Text
        dgvRecetas.Rows(posicion).Cells("dosis").Value = txtDosis.Text.Trim()
        dgvRecetas.Rows(posicion).Cells("frecuencia_indicacion").Value = txtIndicaciones.Text.Trim()

        MessageBox.Show("Receta editada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LimpiarCampos()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If dgvRecetas.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione una receta para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea eliminar esta receta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            dgvRecetas.Rows.RemoveAt(dgvRecetas.CurrentRow.Index)
            MessageBox.Show("Receta eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

        Dim buscar = InputBox("Ingrese medicamento, dosis o indicación:", "Buscar receta")

        If buscar.Trim = "" Then
            dgvRecetas.DataSource = tablaRecetas
            Exit Sub
        End If

        Dim vista As New DataView(tablaRecetas)

        vista.RowFilter = String.Format(
            "medicamento LIKE '%{0}%' OR dosis LIKE '%{0}%' OR frecuencia_indicacion LIKE '%{0}%'",
            buscar.Trim
        )

        dgvRecetas.DataSource = vista

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvRecetas.Rows.Count > 0 Then
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

        If posicion < dgvRecetas.Rows.Count - 1 Then
            posicion += 1
            MostrarRegistro()
        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvRecetas.Rows.Count > 0 Then
            posicion = dgvRecetas.Rows.Count - 1
            MostrarRegistro()
        End If

    End Sub

    Private Sub MostrarRegistro()

        If dgvRecetas.Rows.Count = 0 Then Exit Sub

        dgvRecetas.ClearSelection()
        dgvRecetas.Rows(posicion).Selected = True

        txtIdReceta.Text = dgvRecetas.Rows(posicion).Cells("id_receta").Value.ToString()

        Dim idConsulta As Integer = CInt(dgvRecetas.Rows(posicion).Cells("id_consulta").Value)
        cmbIdConsulta.SelectedIndex = idConsulta - 1

        cmbMedicamento.SelectedValue = CInt(dgvRecetas.Rows(posicion).Cells("id_medicamento").Value)

        txtDosis.Text = dgvRecetas.Rows(posicion).Cells("dosis").Value.ToString()
        txtIndicaciones.Text = dgvRecetas.Rows(posicion).Cells("frecuencia_indicacion").Value.ToString()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class