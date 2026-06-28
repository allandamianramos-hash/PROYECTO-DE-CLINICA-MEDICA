Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Npgsql
Public Class Form1
    ' Evento que se ejecuta al abrir el menú principal
    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Ponemos la fecha actual
        lblFechaActual.Text = "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")

        ' 2. Disparamos la búsqueda a la base de datos
        CargarEstadisticas()
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
        Form3.Show
        Hide
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

    Private Sub CargarEstadisticas()
        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()

                ' Tomamos la fecha y hora reales de tu computadora
                Dim fechaHoy As DateTime = DateTime.Now.Date
                Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay

                ' 1. Pacientes (Sigue usando tu función auxiliar original)
                ActualizarLabel(conn, "SELECT COUNT(*) FROM pacientes", lblNumPacientes, "Pacientes: ")

                ' 2. Médicos Activos
                ActualizarLabel(conn, "SELECT COUNT(*) FROM medicos", lblNumMedicos, "Médicos activos: ")

                ' 3. CITAS PRÓXIMAS PARA HOY (Con zona horaria local)
                ' Filtra fechas de hoy, horas que aún no pasan, y estados pendientes/programados (Ajusta los IDs 1,2,3 si difieren)
                Dim queryCitas As String = "SELECT COUNT(*) FROM citas WHERE fecha = @fechaHoy AND hora >= @horaActual AND id_estado IN (1, 2, 3, 4)"
                Using cmdCitas As New NpgsqlCommand(queryCitas, conn)
                    cmdCitas.Parameters.AddWithValue("fechaHoy", fechaHoy)
                    cmdCitas.Parameters.AddWithValue("horaActual", horaActual)

                    Dim countCitas = cmdCitas.ExecuteScalar()
                    lblNumCitas.Text = "Citas para hoy: " & If(countCitas IsNot Nothing, countCitas.ToString(), "0")
                End Using

                ' 4. CONSULTAS REALIZADAS HOY (Filtrando por Atendida/Finalizada = IDs 5, 9)
                ' OJO: Si la columna en tu tabla consultas se llama solo "fecha" y no "fecha_consulta", cámbiala aquí
                Dim queryConsultas As String = "SELECT COUNT(c.id_consulta) FROM consultas c INNER JOIN citas ci ON c.id_cita = ci.id_cita WHERE c.fecha_consulta = @fechaHoy AND ci.id_estado IN (5, 9)"
                Using cmdConsultas As New NpgsqlCommand(queryConsultas, conn)
                    cmdConsultas.Parameters.AddWithValue("fechaHoy", fechaHoy)

                    Dim countConsultas = cmdConsultas.ExecuteScalar()
                    lblNumConsultas.Text = "Consultas realizadas: " & If(countConsultas IsNot Nothing, countConsultas.ToString(), "0")
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al cargar estadísticas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ActualizarLabel(conn As NpgsqlConnection, query As String, label As Label, prefijo As String)
        Using cmd As New NpgsqlCommand(query, conn)
            Dim resultado = cmd.ExecuteScalar()

            label.Text = prefijo & If(resultado IsNot Nothing, resultado.ToString(), "0")
        End Using
    End Sub

    ' Esta es la cadena de conexión (asegúrate de que sea la misma que usas en otros formularios)
    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

    ' Este evento se ejecuta automáticamente al abrir el formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Fecha actual
        lblFechaActual.Text = ("Fecha: ") & DateTime.Now.ToString("dd/MM/yyyy")

        ' 2. Cargar las demás métricas de la base de datos
        CargarEstadisticas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form10.Show()
        Me.Hide()

    End Sub
End Class