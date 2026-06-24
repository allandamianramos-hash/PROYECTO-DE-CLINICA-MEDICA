Public Class Form8
    ' Instancia del validador visual para la interfaz
    Private errorValidador As New ErrorProvider()

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial de la UI
        cmbFiltroSeleccion.Enabled = False
        rdbCitasDia.Checked = True
    End Sub

    ' Control dinámico de la interfaz según el reporte seleccionado
    Private Sub rdbHistorial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHistorial.CheckedChanged, rdbMedicos.CheckedChanged
        If rdbHistorial.Checked Then
            cmbFiltroSeleccion.Enabled = True
            ' Cambiamos el texto del label para orientar al usuario
            lblFiltro.Text = "Seleccione un Paciente (Registro de Prueba):"
            ' NOTA: Aquí cargaremos los datos al ComboBox después

        ElseIf rdbMedicos.Checked Then
            cmbFiltroSeleccion.Enabled = True
            ' Adaptamos el texto para la entidad correspondiente
            lblFiltro.Text = "Seleccione un Médico:"
            ' NOTA: Aquí cargaremos los datos al ComboBox después

        End If
    End Sub

    Private Sub rdbCitasDia_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCitasDia.CheckedChanged
        If rdbCitasDia.Checked Then
            cmbFiltroSeleccion.Enabled = False
            cmbFiltroSeleccion.SelectedIndex = -1 ' Limpia la selección
            ' Indicamos claramente que no se requiere elegir nada
            lblFiltro.Text = "Filtro no requerido"
            errorValidador.Clear()
        End If
    End Sub

    ' VALIDACIONES OBLIGATORIAS ANTES DE GENERAR EL REPORTE
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        errorValidador.Clear()

        ' 1. Validar que si requiere un filtro específico, este haya sido seleccionado
        If cmbFiltroSeleccion.Enabled AndAlso cmbFiltroSeleccion.SelectedIndex = -1 Then
            errorValidador.SetError(cmbFiltroSeleccion, "Debe seleccionar un elemento de la lista para filtrar este reporte.")
            Return
        End If

        ' Ejecución visual simulada del reporte
        If rdbCitasDia.Checked Then
            MessageBox.Show("Invocando función 'obtener_citas_hoy' en PostgreSQL. Cargando datos...", "Reporte Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf rdbHistorial.Checked Then
            MessageBox.Show("Invocando función 'historial_clinico_paciente' filtrado por ID. Cargando datos...", "Reporte Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf rdbMedicos.Checked Then
            MessageBox.Show("Invocando función 'rendimiento_medicos_mes' con métricas agregadas (COUNT/GROUP BY). Cargando datos...", "Reporte Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' NOTA: Aquí se asignará el DataTable resultante al dgvResultados.DataSource
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        rdbCitasDia.Checked = True
        cmbFiltroSeleccion.SelectedIndex = -1
        cmbFiltroSeleccion.Enabled = False
        dgvResultados.DataSource = Nothing
        errorValidador.Clear()
    End Sub

    ' BOTONES DE SISTEMA
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close() ' Regresa al Dashboard principal
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit() ' Cierre total seguro
    End Sub
End Class