Imports System.Data

Public Class Form11

    Dim tablaDisponibilidad As New DataTable
    Dim posicion As Integer = 0

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdDisponibilidad.ReadOnly = True

        dgvDisponibilidad.AllowUserToAddRows = False
        dgvDisponibilidad.ReadOnly = True
        dgvDisponibilidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDisponibilidad.MultiSelect = False
        dgvDisponibilidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList

        dtpHoraInicio.Format = DateTimePickerFormat.Time
        dtpHoraInicio.ShowUpDown = True

        dtpHoraFin.Format = DateTimePickerFormat.Time
        dtpHoraFin.ShowUpDown = True

        CargarMedicos()
        CargarTabla()
        LimpiarCampos()

    End Sub

    Private Function ConvertirADateTime(valor As Object) As DateTime

        If valor Is Nothing OrElse IsDBNull(valor) Then Return DateTime.Now

        Dim tipoDato As String = valor.GetType().Name

        If tipoDato = "TimeOnly" Then
            Dim soloHora As TimeOnly = DirectCast(valor, TimeOnly)
            Return DateTime.Today.Add(soloHora.ToTimeSpan())

        ElseIf tipoDato = "TimeSpan" Then
            Return DateTime.Today.Add(DirectCast(valor, TimeSpan))
        End If

        Try
            Return Convert.ToDateTime(valor)
        Catch ex As Exception
            Return DateTime.Now
        End Try

    End Function

    Private Sub CargarMedicos()

        Dim dao As New DisponibilidadDAO()
        Dim tabla As DataTable = dao.ObtenerMedicos()

        cmbMedico.DataSource = tabla
        cmbMedico.DisplayMember = "descripcion_medico"
        cmbMedico.ValueMember = "id_medico"
        cmbMedico.SelectedIndex = -1

    End Sub

    Private Sub CargarTabla()

        Dim dao As New DisponibilidadDAO()

        tablaDisponibilidad = dao.ListarDisponibilidad()
        dgvDisponibilidad.DataSource = tablaDisponibilidad

        FormatearColumnas()

    End Sub

    Private Sub FormatearColumnas()

        If dgvDisponibilidad.Columns.Contains("id_disponibilidad") Then dgvDisponibilidad.Columns("id_disponibilidad").HeaderText = "ID Disponibilidad"
        If dgvDisponibilidad.Columns.Contains("id_medico") Then dgvDisponibilidad.Columns("id_medico").HeaderText = "ID Médico"
        If dgvDisponibilidad.Columns.Contains("medico") Then dgvDisponibilidad.Columns("medico").HeaderText = "Médico"
        If dgvDisponibilidad.Columns.Contains("hora_inicio") Then dgvDisponibilidad.Columns("hora_inicio").HeaderText = "Hora Inicio"
        If dgvDisponibilidad.Columns.Contains("hora_fin") Then dgvDisponibilidad.Columns("hora_fin").HeaderText = "Hora Fin"

    End Sub

    Private Function ValidarCampos() As Boolean

        If cmbMedico.SelectedIndex = -1 OrElse cmbMedico.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un médico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMedico.Focus()
            Return False
        End If

        If dtpHoraFin.Value.TimeOfDay <= dtpHoraInicio.Value.TimeOfDay Then
            MessageBox.Show("La hora final debe ser mayor que la hora inicial.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpHoraFin.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub LimpiarCampos()

        txtIdDisponibilidad.Clear()

        If cmbMedico.DataSource IsNot Nothing Then
            cmbMedico.SelectedIndex = -1
        End If

        dtpHoraInicio.Value = DateTime.Now
        dtpHoraFin.Value = DateTime.Now.AddHours(1)

        posicion = 0
        cmbMedico.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarCampos() = False Then Exit Sub

        Dim disponibilidad As New Disponibilidad()

        disponibilidad.IdMedico = CInt(cmbMedico.SelectedValue)
        disponibilidad.HoraInicio = dtpHoraInicio.Value.TimeOfDay
        disponibilidad.HoraFin = dtpHoraFin.Value.TimeOfDay

        Dim dao As New DisponibilidadDAO()
        dao.Guardar(disponibilidad)

        MessageBox.Show("Horario guardado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTabla()
        LimpiarCampos()

        Try
            Form1.CargarEstadisticas()
        Catch
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtIdDisponibilidad.Text.Trim() = "" Then
            MessageBox.Show("Seleccione un registro de la tabla para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub

        Dim disponibilidad As New Disponibilidad()

        disponibilidad.IdDisponibilidad = CInt(txtIdDisponibilidad.Text)
        disponibilidad.IdMedico = CInt(cmbMedico.SelectedValue)
        disponibilidad.HoraInicio = dtpHoraInicio.Value.TimeOfDay
        disponibilidad.HoraFin = dtpHoraFin.Value.TimeOfDay

        Dim dao As New DisponibilidadDAO()
        dao.Editar(disponibilidad)

        MessageBox.Show("Horario actualizado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTabla()
        LimpiarCampos()

        Try
            Form1.CargarEstadisticas()
        Catch
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtIdDisponibilidad.Text.Trim() = "" Then
            MessageBox.Show("Seleccione un registro para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea eliminar este horario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        Dim dao As New DisponibilidadDAO()
        dao.Eliminar(CInt(txtIdDisponibilidad.Text))

        MessageBox.Show("Horario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarTabla()
        LimpiarCampos()

        Try
            Form1.CargarEstadisticas()
        Catch
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        CargarTabla()
        LimpiarCampos()

    End Sub

    Private Sub dgvDisponibilidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisponibilidad.CellClick

        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            MostrarRegistro()
        End If

    End Sub

    Private Sub MostrarRegistro()

        If dgvDisponibilidad.Rows.Count = 0 Then Exit Sub
        If posicion < 0 OrElse posicion >= dgvDisponibilidad.Rows.Count Then Exit Sub

        dgvDisponibilidad.ClearSelection()
        dgvDisponibilidad.Rows(posicion).Selected = True
        dgvDisponibilidad.CurrentCell = dgvDisponibilidad.Rows(posicion).Cells("id_disponibilidad")

        Try
            Dim fila As DataGridViewRow = dgvDisponibilidad.Rows(posicion)

            txtIdDisponibilidad.Text = fila.Cells("id_disponibilidad").Value.ToString()
            cmbMedico.SelectedValue = CInt(fila.Cells("id_medico").Value)
            dtpHoraInicio.Value = ConvertirADateTime(fila.Cells("hora_inicio").Value)
            dtpHoraFin.Value = ConvertirADateTime(fila.Cells("hora_fin").Value)

        Catch ex As Exception
            MessageBox.Show("Error al mostrar registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvDisponibilidad.Rows.Count > 0 Then
            posicion = 0
            MostrarRegistro()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If dgvDisponibilidad.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya estás en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvDisponibilidad.Rows.Count > 0 Then

            If posicion < dgvDisponibilidad.Rows.Count - 1 Then
                posicion += 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya estás en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvDisponibilidad.Rows.Count > 0 Then
            posicion = dgvDisponibilidad.Rows.Count - 1
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

End Class