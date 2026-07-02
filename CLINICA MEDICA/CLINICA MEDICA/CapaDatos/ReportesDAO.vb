Imports Npgsql
Imports System.Data

Public Class ReportesDAO

    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    Public Function ObtenerFechasCitas() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT DISTINCT
                        fecha::text AS fecha_texto
                    FROM citas
                    ORDER BY fecha_texto;
                "

                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar fechas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ObtenerPacientes() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        id_paciente,
                        nombre || ' ' || apellido AS paciente
                    FROM pacientes
                    ORDER BY id_paciente;
                "

                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar pacientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ObtenerMedicos() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        id_medico,
                        nombre || ' ' || apellido AS medico
                    FROM medicos
                    ORDER BY id_medico;
                "

                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar médicos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ReporteCitasPorDia(fechaSeleccionada As String) As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        id AS id_cita,
                        paciente,
                        medico,
                        hora,
                        estado
                    FROM consultar_citas_por_fecha(@fecha::date);
                "

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@fecha", fechaSeleccionada)

                    Using adaptador As New NpgsqlDataAdapter(comando)
                        adaptador.Fill(tabla)
                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al generar reporte de citas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function HistorialClinicoPaciente(idPaciente As Integer) As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        fecha,
                        medico,
                        diagnostico,
                        observaciones,
                        medicamentos
                    FROM consultar_historial_medico(@id_paciente);
                "

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@id_paciente", idPaciente)

                    Using adaptador As New NpgsqlDataAdapter(comando)
                        adaptador.Fill(tabla)
                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al generar historial clínico: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ProductividadMedicos() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        id_medico,
                        medico,
                        total_citas,
                        total_consultas
                    FROM productividad_medicos();
                "

                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al generar productividad de médicos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ProductividadMedicoPorId(idMedico As Integer) As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        id_medico,
                        medico,
                        total_citas,
                        total_consultas
                    FROM productividad_medico_por_id(@id_medico);
                "

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@id_medico", idMedico)

                    Using adaptador As New NpgsqlDataAdapter(comando)
                        adaptador.Fill(tabla)
                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al generar productividad del médico: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function EstadisticasGenerales() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT
                        metrica,
                        valor
                    FROM estadisticas_generales();
                "

                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al generar estadísticas generales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

End Class