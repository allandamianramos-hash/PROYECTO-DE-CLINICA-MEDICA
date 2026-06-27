Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' Evento que se ejecuta al abrir el menú principal
    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Despliega la fecha del día actual elegantemente
        lblFechaActual.Text = "Fecha: " & DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")

        ' Inicializa los marcadores visuales del Dashboard en cero
        InicializarDashboard()
    End Sub

    ' Llena las tarjetas del Dashboard de forma predeterminada mientras conectamos a la base de datos
    Private Sub InicializarDashboard()
        lblNumPacientes.Text = "0"
        lblNumMedicos.Text = "0"
        lblNumCitas.Text = "0"
        lblNumConsultas.Text = "0"
    End Sub

    ' NAVEGACIÓN HACIA LOS MÓDULOS OBLIGATORIOS (Uso de ShowDialog para mantener el orden)
    Private Sub btnModuloPacientes_Click(sender As Object, e As EventArgs) Handles btnModuloPacientes.Click
        ' frmPacientes.ShowDialog()
        MessageBox.Show("Abriendo el Formulario de Pacientes...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frm2.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloMedicos_Click(sender As Object, e As EventArgs) Handles btnModuloMedicos.Click
        ' frmMedicos.ShowDialog()
        MessageBox.Show("Abriendo el Formulario de Médicos...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloEspecialidades_Click(sender As Object, e As EventArgs) Handles btnModuloEspecialidades.Click
        ' frmEspecialidades.ShowDialog()
        MessageBox.Show("Abriendo el Formulario de Especialidades...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloCitas_Click(sender As Object, e As EventArgs) Handles btnModuloCitas.Click
        ' frmCitas.ShowDialog()
        MessageBox.Show("Abriendo el Formulario de Citas Médicas...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloConsultas_Click(sender As Object, e As EventArgs) Handles btnModuloConsultas.Click
        ' frmConsultas.ShowDialog()
        MessageBox.Show("Abriendo el Formulario de Consultas Clínicas...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloRecetas_Click(sender As Object, e As EventArgs) Handles btnModuloRecetas.Click
        ' frmRecetas.ShowDialog()
        MessageBox.Show("Abriendo el Formulario de Recetas...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloReportes_Click(sender As Object, e As EventArgs) Handles btnModuloReportes.Click
        ' frmReportes.ShowDialog()
        MessageBox.Show("Abriendo el Módulo de Reportes Consolidados...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form8.Show()
        Me.Hide()

    End Sub

    ' GESTIÓN DE CIERRE (Cumple con el requerimiento del botón Salir)

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        Form9.Show()
        Me.Hide()

    End Sub
End Class