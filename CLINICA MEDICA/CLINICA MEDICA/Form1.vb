Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Npgsql

Public Class Form1

    ' 1. Movemos la cadena de conexión hasta arriba para que todo el formulario pueda verla
    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

    ' 2. Usamos Activated en lugar de Load para que se actualice cada vez que vuelves al menú
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblFechaActual.Text = "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")
        CargarEstadisticas()
        ConfigurarPermisos()
    End Sub

    ' Llena las tarjetas del Dashboard de forma predeterminada mientras conectamos a la base de datos
    Private Sub InicializarDashboard()
        lblNumPacientes.Text = "0"
        lblNumMedicos.Text = "0"
        lblNumCitas.Text = "0"
        lblNumConsultas.Text = "0"
    End Sub

    ' --- SECCIÓN DE NAVEGACIÓN ---

    Private Sub btnModuloPacientes_Click(sender As Object, e As EventArgs) Handles btnModuloPacientes.Click
        MessageBox.Show("Abriendo el Formulario de Pacientes...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frm2.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloMedicos_Click(sender As Object, e As EventArgs) Handles btnModuloMedicos.Click
        MessageBox.Show("Abriendo el Formulario de Médicos...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloEspecialidades_Click(sender As Object, e As EventArgs) Handles btnModuloEspecialidades.Click
        MessageBox.Show("Abriendo el Formulario de Especialidades...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloCitas_Click(sender As Object, e As EventArgs) Handles btnModuloCitas.Click
        MessageBox.Show("Abriendo el Formulario de Citas Médicas...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloConsultas_Click(sender As Object, e As EventArgs) Handles btnModuloConsultas.Click
        MessageBox.Show("Abriendo el Formulario de Consultas Clínicas...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloRecetas_Click(sender As Object, e As EventArgs) Handles btnModuloRecetas.Click
        MessageBox.Show("Abriendo el Formulario de Recetas...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloReportes_Click(sender As Object, e As EventArgs) Handles btnModuloReportes.Click
        MessageBox.Show("Abriendo el Módulo de Reportes Consolidados...", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Hide()
    End Sub

    ' --- GESTIÓN DE CIERRE ---
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' --- LÓGICA DEL DASHBOARD EN TIEMPO REAL ---

    Public Sub CargarEstadisticas()
        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Dim fechaHoy As DateTime = DateTime.Now.Date
                Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay

                ' 1. Pacientes registrados
                ActualizarLabel(conn, "SELECT COUNT(*) FROM pacientes", lblNumPacientes, "Pacientes: ")

                ' 2. MÉDICOS ACTIVOS (Magia en tiempo real con soporte de madrugadas)
                Dim queryMedicos As String = "
                    SELECT COUNT(DISTINCT id_medico) 
                    FROM disponibilidad_medico 
                    WHERE (hora_inicio <= hora_fin AND @horaActual >= hora_inicio AND @horaActual <= hora_fin)
                       OR (hora_inicio > hora_fin AND (@horaActual >= hora_inicio OR @horaActual <= hora_fin))"

                Using cmdMedicos As New NpgsqlCommand(queryMedicos, conn)
                    cmdMedicos.Parameters.AddWithValue("horaActual", horaActual)
                    Dim countMedicos = cmdMedicos.ExecuteScalar()
                    lblNumMedicos.Text = "Médicos activos: " & If(countMedicos IsNot Nothing, countMedicos.ToString(), "0")
                End Using

                ' 3. Citas para hoy
                Dim queryCitas As String = "SELECT COUNT(*) FROM citas WHERE fecha = @fechaHoy AND hora >= @horaActual AND id_estado IN (1, 2, 3, 4)"
                Using cmdCitas As New NpgsqlCommand(queryCitas, conn)
                    cmdCitas.Parameters.AddWithValue("fechaHoy", fechaHoy)
                    cmdCitas.Parameters.AddWithValue("horaActual", horaActual)
                    Dim countCitas = cmdCitas.ExecuteScalar()
                    lblNumCitas.Text = "Citas para hoy: " & If(countCitas IsNot Nothing, countCitas.ToString(), "0")
                End Using

                ' 4. Consultas realizadas
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

    ' --- FUNCIÓN PARA BLOQUEAR BOTONES SEGÚN EL ROL ---
    Private Sub ConfigurarPermisos()

        btnModuloPacientes.Enabled = True
        btnModuloMedicos.Enabled = True
        btnModuloEspecialidades.Enabled = True
        btnModuloCitas.Enabled = True
        btnModuloConsultas.Enabled = True
        btnModuloRecetas.Enabled = True
        btnModuloReportes.Enabled = True
        btnMedicamentos.Enabled = True
        Button2.Enabled = True
        Button1.Enabled = True

        Select Case SesionGlobal.RolActual

            Case "Recepcionista"

                btnModuloConsultas.Enabled = False
                btnModuloRecetas.Enabled = False
                btnModuloReportes.Enabled = False
                btnMedicamentos.Enabled = False
                btnModuloMedicos.Enabled = False

            Case "Medico"
                ' El doctor atiende pacientes y da recetas, pero no administra personal ni cobra en caja
                btnModuloMedicos.Enabled = False
                btnModuloReportes.Enabled = False
                Button2.Enabled = False ' Bloqueamos Facturas
                btnMedicamentos.Enabled = False ' Solo Farmacia toca el inventario de medicinas

            Case "Farmacia"
                ' El de farmacia solo despacha medicinas viendo las recetas, no toca a los pacientes
                btnModuloPacientes.Enabled = False
                btnModuloMedicos.Enabled = False
                btnModuloEspecialidades.Enabled = False
                btnModuloCitas.Enabled = False
                btnModuloConsultas.Enabled = False
                btnModuloReportes.Enabled = False
                Button2.Enabled = False
                Button1.Enabled = False

        End Select
    End Sub
End Class