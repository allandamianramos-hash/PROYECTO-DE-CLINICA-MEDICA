Public Class Form4
    ' Variable global para guardar los datos y usar el buscador
    Private tablaEspecialidades As New DataTable
    Private indiceActual As Integer = 0

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdEspecialidad.ReadOnly = True
        dgvEspecialidades.AllowUserToAddRows = False
        dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEspecialidades.MultiSelect = False
        dgvEspecialidades.ReadOnly = True

        ' Cargamos los datos desde Neon
        CargarTabla()
    End Sub

    ' --- MÉTODO NUEVO PARA CARGAR DESDE LA BASE DE DATOS ---
    ' --- MÉTODO NUEVO PARA CARGAR DESDE LA BASE DE DATOS ---
    Private Sub CargarTabla()
        Try
            Dim dao As New EspecialidadDAO()
            tablaEspecialidades = dao.Mostrar()
            dgvEspecialidades.DataSource = tablaEspecialidades

            ' 1. Columna ID: Que sea lo más pequeña posible
            If dgvEspecialidades.Columns.Contains("id_especialidad") Then
                dgvEspecialidades.Columns("id_especialidad").HeaderText = "ID"
                dgvEspecialidades.Columns("id_especialidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

            ' 2. Columna Nombre: Que se ajuste al tamaño del texto del nombre
            If dgvEspecialidades.Columns.Contains("nombre_especialidad") Then
                dgvEspecialidades.Columns("nombre_especialidad").HeaderText = "Especialidad"
                dgvEspecialidades.Columns("nombre_especialidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

            ' 3. Columna Descripción: LA MAGIA AQUÍ. Que robe todo el espacio a la derecha (Fill)
            If dgvEspecialidades.Columns.Contains("descripcion") Then
                dgvEspecialidades.Columns("descripcion").HeaderText = "Descripción"
                dgvEspecialidades.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvEspecialidades.Columns("descripcion").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            End If

            ' Si la ventana se hace pequeñita y el "Fill" ya no da más, entonces sí bajará de línea
            dgvEspecialidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtIdEspecialidad.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtBuscar.Clear()
        txtNombre.Focus()
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtNombre.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar el nombre de la especialidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        If txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar la descripción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Focus()
            Return False
        End If

        Return True
    End Function

    ' --- BOTÓN GUARDAR (Conectado al DAO) ---
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Exit Sub

        Try
            Dim esp As New Especialidad()
            esp.Nombre = txtNombre.Text.Trim()
            esp.Descripcion = txtDescripcion.Text.Trim()

            Dim dao As New EspecialidadDAO()
            dao.Insertar(esp)

            MessageBox.Show("Especialidad guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- BOTÓN EDITAR (Conectado al DAO) ---
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtIdEspecialidad.Text = "" Then
            MessageBox.Show("Seleccione una especialidad de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidarCampos() Then Exit Sub

        Try
            Dim esp As New Especialidad()
            esp.IdEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text)
            esp.Nombre = txtNombre.Text.Trim()
            esp.Descripcion = txtDescripcion.Text.Trim()

            Dim dao As New EspecialidadDAO()
            dao.Editar(esp)

            MessageBox.Show("Especialidad modificada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- BOTÓN ELIMINAR (Conectado al DAO) ---
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdEspecialidad.Text = "" Then
            MessageBox.Show("Seleccione una especialidad de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar esta especialidad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim idEliminar As Integer = Convert.ToInt32(txtIdEspecialidad.Text)
                Dim dao As New EspecialidadDAO()
                dao.Eliminar(idEliminar)

                MessageBox.Show("Especialidad eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- EVENTO CELLCLICK (Para pasar datos de la tabla a los TextBox) ---
    Private Sub dgvEspecialidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEspecialidades.CellClick
        If e.RowIndex >= 0 Then
            indiceActual = e.RowIndex
            MostrarRegistro()
        End If
    End Sub

    ' --- BUSCADOR EN TIEMPO REAL ---
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim vista As New DataView(tablaEspecialidades)
        ' Filtramos usando el nombre exacto de tu columna en la base de datos
        vista.RowFilter = String.Format("nombre_especialidad LIKE '%{0}%' OR descripcion LIKE '%{0}%'", txtBuscar.Text.Trim())
        dgvEspecialidades.DataSource = vista
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    ' --- NAVEGACIÓN DE REGISTROS ---
    Private Sub MostrarRegistro()
        If dgvEspecialidades.Rows.Count = 0 Then Exit Sub
        dgvEspecialidades.ClearSelection()
        dgvEspecialidades.Rows(indiceActual).Selected = True

        Dim fila As DataGridViewRow = dgvEspecialidades.Rows(indiceActual)
        txtIdEspecialidad.Text = fila.Cells("id_especialidad").Value.ToString()
        txtNombre.Text = fila.Cells("nombre_especialidad").Value.ToString() ' Ojo aquí
        txtDescripcion.Text = fila.Cells("descripcion").Value.ToString()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If dgvEspecialidades.Rows.Count > 0 Then
            indiceActual = 0
            MostrarRegistro()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If indiceActual > 0 Then
            indiceActual -= 1
            MostrarRegistro()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If indiceActual < dgvEspecialidades.Rows.Count - 1 Then
            indiceActual += 1
            MostrarRegistro()
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If dgvEspecialidades.Rows.Count > 0 Then
            indiceActual = dgvEspecialidades.Rows.Count - 1
            MostrarRegistro()
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

    Private Sub dgvEspecialidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEspecialidades.CellContentClick

    End Sub
End Class