Public Class Form3


    Dim tablaMedicos As New DataTable
        Dim posicion As Integer = 0

        Private Sub FrmMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' ID no editable
            txtIdMedico.ReadOnly = True

            ' ComboBox especialidades según tu tabla
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList
            cmbEspecialidad.Items.Clear()

            cmbEspecialidad.Items.Add("Cardiología")
            cmbEspecialidad.Items.Add("Pediatría")
            cmbEspecialidad.Items.Add("Dermatología")
            cmbEspecialidad.Items.Add("Ginecología")
            cmbEspecialidad.Items.Add("Neurología")
            cmbEspecialidad.Items.Add("Odontología")
            cmbEspecialidad.Items.Add("Oftalmología")
            cmbEspecialidad.Items.Add("Ortopedia")
            cmbEspecialidad.Items.Add("Psicología")
            cmbEspecialidad.Items.Add("Medicina General")

            cmbEspecialidad.SelectedIndex = -1

            ' Configuración del DataGridView
            dgvMedicos.AllowUserToAddRows = False
            dgvMedicos.ReadOnly = True
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMedicos.MultiSelect = False
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Crear columnas de la tabla
            tablaMedicos.Columns.Add("id_medico")
            tablaMedicos.Columns.Add("id_especialidad")
            tablaMedicos.Columns.Add("nombre")
            tablaMedicos.Columns.Add("apellido")
            tablaMedicos.Columns.Add("telefono")
            tablaMedicos.Columns.Add("correo_electronico")
            tablaMedicos.Columns.Add("codigo_colegiacion")

            dgvMedicos.DataSource = tablaMedicos

            ' Cambiar títulos del DataGridView
            dgvMedicos.Columns("id_medico").HeaderText = "ID Médico"
            dgvMedicos.Columns("id_especialidad").HeaderText = "ID Especialidad"
            dgvMedicos.Columns("nombre").HeaderText = "Nombre"
            dgvMedicos.Columns("apellido").HeaderText = "Apellido"
            dgvMedicos.Columns("telefono").HeaderText = "Teléfono"
            dgvMedicos.Columns("correo_electronico").HeaderText = "Correo Electrónico"
            dgvMedicos.Columns("codigo_colegiacion").HeaderText = "Código Colegiación"

            GenerarId()

        End Sub

        Private Sub GenerarId()

            Dim nuevoId As Integer = tablaMedicos.Rows.Count + 1
            txtIdMedico.Text = nuevoId.ToString()

        End Sub

        Private Function GenerarCodigo() As String

            Return "MED-" & CInt(txtIdMedico.Text).ToString("000")

        End Function

        Private Function ValidarCampos() As Boolean

            If txtNombre.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el nombre del médico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNombre.Focus()
                Return False
            End If

            If txtApellido.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el apellido del médico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtApellido.Focus()
                Return False
            End If

            If cmbEspecialidad.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una especialidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbEspecialidad.Focus()
                Return False
            End If

            If txtTelefono.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el teléfono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTelefono.Focus()
                Return False
            End If

            If txtCorreo.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el correo electrónico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCorreo.Focus()
                Return False
            End If

            If Not txtCorreo.Text.Contains("@") Then
                MessageBox.Show("Ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCorreo.Focus()
                Return False
            End If

            Return True

        End Function

        Private Sub LimpiarCampos()

            txtIdMedico.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtTelefono.Clear()
            txtCorreo.Clear()
            txtBuscar.Clear()

            cmbEspecialidad.SelectedIndex = -1

            GenerarId()
            txtNombre.Focus()

        End Sub

        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

            LimpiarCampos()

        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

            If ValidarCampos() = False Then Exit Sub

            tablaMedicos.Rows.Add(
            txtIdMedico.Text,
            cmbEspecialidad.SelectedIndex + 1,
            txtNombre.Text.Trim(),
            txtApellido.Text.Trim(),
            txtTelefono.Text.Trim(),
            txtCorreo.Text.Trim(),
            GenerarCodigo()
        )

            MessageBox.Show("Médico guardado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        End Sub

        Private Sub dgvMedicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicos.CellClick

            If e.RowIndex >= 0 Then

                posicion = e.RowIndex

                txtIdMedico.Text = dgvMedicos.Rows(posicion).Cells("id_medico").Value.ToString()

                Dim idEspecialidad As Integer = CInt(dgvMedicos.Rows(posicion).Cells("id_especialidad").Value)
                cmbEspecialidad.SelectedIndex = idEspecialidad - 1

                txtNombre.Text = dgvMedicos.Rows(posicion).Cells("nombre").Value.ToString()
                txtApellido.Text = dgvMedicos.Rows(posicion).Cells("apellido").Value.ToString()
                txtTelefono.Text = dgvMedicos.Rows(posicion).Cells("telefono").Value.ToString()
                txtCorreo.Text = dgvMedicos.Rows(posicion).Cells("correo_electronico").Value.ToString()

            End If

        End Sub

        Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

            If dgvMedicos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un médico para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ValidarCampos() = False Then Exit Sub

            posicion = dgvMedicos.CurrentRow.Index

            dgvMedicos.Rows(posicion).Cells("id_especialidad").Value = cmbEspecialidad.SelectedIndex + 1
            dgvMedicos.Rows(posicion).Cells("nombre").Value = txtNombre.Text.Trim()
            dgvMedicos.Rows(posicion).Cells("apellido").Value = txtApellido.Text.Trim()
            dgvMedicos.Rows(posicion).Cells("telefono").Value = txtTelefono.Text.Trim()
            dgvMedicos.Rows(posicion).Cells("correo_electronico").Value = txtCorreo.Text.Trim()

            MessageBox.Show("Médico editado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            If dgvMedicos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un médico para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show("¿Desea eliminar este médico?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then

                dgvMedicos.Rows.RemoveAt(dgvMedicos.CurrentRow.Index)

                MessageBox.Show("Médico eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpiarCampos()

            End If

        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

            LimpiarCampos()

        End Sub

        Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

            Dim vista As New DataView(tablaMedicos)

            vista.RowFilter = String.Format(
            "nombre LIKE '%{0}%' OR apellido LIKE '%{0}%' OR telefono LIKE '%{0}%' OR correo_electronico LIKE '%{0}%' OR codigo_colegiacion LIKE '%{0}%'",
            txtBuscar.Text.Trim()
        )

            dgvMedicos.DataSource = vista

        End Sub

        Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

            If dgvMedicos.Rows.Count > 0 Then
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

            If posicion < dgvMedicos.Rows.Count - 1 Then
                posicion += 1
                MostrarRegistro()
            End If

        End Sub

        Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

            If dgvMedicos.Rows.Count > 0 Then
                posicion = dgvMedicos.Rows.Count - 1
                MostrarRegistro()
            End If

        End Sub

        Private Sub MostrarRegistro()

            If dgvMedicos.Rows.Count = 0 Then Exit Sub

            dgvMedicos.ClearSelection()
            dgvMedicos.Rows(posicion).Selected = True

            txtIdMedico.Text = dgvMedicos.Rows(posicion).Cells("id_medico").Value.ToString()

            Dim idEspecialidad As Integer = CInt(dgvMedicos.Rows(posicion).Cells("id_especialidad").Value)
            cmbEspecialidad.SelectedIndex = idEspecialidad - 1

            txtNombre.Text = dgvMedicos.Rows(posicion).Cells("nombre").Value.ToString()
            txtApellido.Text = dgvMedicos.Rows(posicion).Cells("apellido").Value.ToString()
            txtTelefono.Text = dgvMedicos.Rows(posicion).Cells("telefono").Value.ToString()
            txtCorreo.Text = dgvMedicos.Rows(posicion).Cells("correo_electronico").Value.ToString()

        End Sub

        Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

            ' Si tienes menú principal, cambia FrmMenuPrincipal por el nombre real.
            ' FrmMenuPrincipal.Show()
            ' Me.Hide()

            Me.Close()

        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                Application.Exit()
            End If

        End Sub


End Class