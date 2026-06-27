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
                        c.id_cita,
                        p.nombre || ' ' || p.apellido AS paciente,
                        m.nombre || ' ' || m.apellido AS medico,
                        e.nombre_estado AS estado,
                        c.fecha::text AS fecha,
                        to_char(c.hora, 'HH24:MI:SS') AS hora
                    FROM citas c
                    INNER JOIN pacientes p ON c.id_paciente = p.id_paciente
                    INNER JOIN medicos m ON c.id_medico = m.id_medico
                    INNER JOIN estados_cita e ON c.id_estado = e.id_estado
                    WHERE c.fecha = @fecha::date
                    ORDER BY c.hora;
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
                        q.id_consulta,
                        p.nombre || ' ' || p.apellido AS paciente,
                        m.nombre || ' ' || m.apellido AS medico,
                        q.peso_kg,
                        q.estatura_m,
                        q.sintomas,
                        q.diagnostico,
                        q.observaciones,
                        q.fecha_consulta::text AS fecha_consulta,
                        to_char(q.hora_consulta, 'HH24:MI:SS') AS hora_consulta
                    FROM consultas q
                    INNER JOIN citas c ON q.id_cita = c.id_cita
                    INNER JOIN pacientes p ON c.id_paciente = p.id_paciente
                    INNER JOIN medicos m ON c.id_medico = m.id_medico
                    WHERE p.id_paciente = @id_paciente
                    ORDER BY q.fecha_consulta, q.hora_consulta;
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
                        m.id_medico,
                        m.nombre || ' ' || m.apellido AS medico,
                        COUNT(DISTINCT c.id_cita) AS total_citas,
                        COUNT(DISTINCT q.id_consulta) AS total_consultas
                    FROM medicos m
                    LEFT JOIN citas c ON m.id_medico = c.id_medico
                    LEFT JOIN consultas q ON c.id_cita = q.id_cita
                    GROUP BY m.id_medico, m.nombre, m.apellido
                    ORDER BY total_consultas DESC, total_citas DESC;
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

End Class
