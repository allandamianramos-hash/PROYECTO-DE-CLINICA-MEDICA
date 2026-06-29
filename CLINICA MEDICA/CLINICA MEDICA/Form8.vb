Imports System.Data

Public Class Form8

    Dim tablaReportes As New DataTable
    Dim posicion As Integer = 0

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvResultados.AllowUserToAddRows = False
        dgvResultados.ReadOnly = True
        dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResultados.MultiSelect = False
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cmbFiltroSeleccion.DropDownStyle = ComboBoxStyle.DropDownList

        rdbCitasDia.Checked = True
        CargarFechasCitas()

    End Sub

    Private Sub rdbCitasDia_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCitasDia.CheckedChanged

        If rdbCitasDia.Checked Then
            CargarFechasCitas()
        End If

    End Sub

    Private Sub rdbHistorial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHistorial.CheckedChanged

        If rdbHistorial.Checked Then
            CargarPacientes()
        End If

    End Sub

    Private Sub rdbMedicos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMedicos.CheckedChanged

        If rdbMedicos.Checked Then
            CargarMedicos()
        End If

    End Sub

    Private Sub CargarFechasCitas()

        Dim dao As New ReportesDAO()
        Dim tabla As DataTable = dao.ObtenerFechasCitas()

        cmbFiltroSeleccion.DataSource = tabla
        cmbFiltroSeleccion.DisplayMember = "fecha_texto"
        cmbFiltroSeleccion.ValueMember = "fecha_texto"
        cmbFiltroSeleccion.SelectedIndex = -1

    End Sub

    Private Sub CargarPacientes()

        Dim dao As New ReportesDAO()
        Dim tabla As DataTable = dao.ObtenerPacientes()

        cmbFiltroSeleccion.DataSource = tabla
        cmbFiltroSeleccion.DisplayMember = "paciente"
        cmbFiltroSeleccion.ValueMember = "id_paciente"
        cmbFiltroSeleccion.SelectedIndex = -1

    End Sub

    Private Sub CargarMedicos()

        Dim dao As New ReportesDAO()
        Dim tabla As DataTable = dao.ObtenerMedicos()

        cmbFiltroSeleccion.DataSource = tabla
        cmbFiltroSeleccion.DisplayMember = "medico"
        cmbFiltroSeleccion.ValueMember = "id_medico"
        cmbFiltroSeleccion.SelectedIndex = -1

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If rdbCitasDia.Checked Then
            GenerarReporteCitasDia()

        ElseIf rdbHistorial.Checked Then
            GenerarHistorialPaciente()

        ElseIf rdbMedicos.Checked Then
            GenerarProductividadMedicos()

        Else
            MessageBox.Show("Seleccione un tipo de reporte.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub GenerarReporteCitasDia()

        If cmbFiltroSeleccion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una fecha para generar el reporte.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dao As New ReportesDAO()

        tablaReportes = dao.ReporteCitasPorDia(cmbFiltroSeleccion.SelectedValue.ToString())
        dgvResultados.DataSource = tablaReportes

        posicion = 0

    End Sub

    Private Sub GenerarHistorialPaciente()

        If cmbFiltroSeleccion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un paciente para generar el historial.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dao As New ReportesDAO()

        tablaReportes = dao.HistorialClinicoPaciente(CInt(cmbFiltroSeleccion.SelectedValue))
        dgvResultados.DataSource = tablaReportes

        posicion = 0

    End Sub

    Private Sub GenerarProductividadMedicos()

        Dim dao As New ReportesDAO()

        tablaReportes = dao.ProductividadMedicos()
        dgvResultados.DataSource = tablaReportes

        posicion = 0

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        dgvResultados.DataSource = Nothing
        tablaReportes.Clear()

        If cmbFiltroSeleccion.DataSource IsNot Nothing Then
            cmbFiltroSeleccion.SelectedIndex = -1
        End If

        posicion = 0

    End Sub

    Private Sub dgvResultados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultados.CellClick

        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            SeleccionarFila()
        End If

    End Sub

    Private Sub SeleccionarFila()

        If dgvResultados.Rows.Count = 0 Then Exit Sub
        If posicion < 0 OrElse posicion >= dgvResultados.Rows.Count Then Exit Sub

        dgvResultados.ClearSelection()
        dgvResultados.Rows(posicion).Selected = True
        dgvResultados.CurrentCell = dgvResultados.Rows(posicion).Cells(0)

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        If dgvResultados.Rows.Count > 0 Then
            posicion = 0
            SeleccionarFila()
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click

        If dgvResultados.Rows.Count > 0 Then

            If posicion > 0 Then
                posicion -= 1
                SeleccionarFila()
            Else
                MessageBox.Show("Ya está en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If dgvResultados.Rows.Count > 0 Then

            If posicion < dgvResultados.Rows.Count - 1 Then
                posicion += 1
                SeleccionarFila()
            Else
                MessageBox.Show("Ya está en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        If dgvResultados.Rows.Count > 0 Then
            posicion = dgvResultados.Rows.Count - 1
            SeleccionarFila()
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