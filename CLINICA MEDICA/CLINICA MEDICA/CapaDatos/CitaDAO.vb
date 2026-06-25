Imports Npgsql

Public Class CitaDAO

    ' 1. MÉTODO PARA MOSTRAR LAS CITAS (Con INNER JOIN para ver nombres)
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT c.id_cita, c.id_paciente, p.nombre AS nombre_paciente, c.id_medico, m.nombre AS nombre_medico, c.fecha, c.hora, c.id_estado FROM citas c INNER JOIN pacientes p ON c.id_paciente = p.id_paciente INNER JOIN medicos m ON c.id_medico = m.id_medico ORDER BY c.fecha DESC"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Error al cargar citas: " & ex.Message)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' 2. MÉTODO PARA INSERTAR
    Public Sub Insertar(cita As Cita)
        ' 1. Obtén tu conexión (asegúrate de que tu variable 'conn' sea la que usas en tu proyecto)
        Using cmd As New NpgsqlCommand("CALL registrar_cita(@idPac, @idMed, @fec, @hor, @idEst)", conn)
            cmd.Parameters.AddWithValue("@idPac", cita.IdPaciente)
            cmd.Parameters.AddWithValue("@idMed", cita.IdMedico)

            ' Esto debe ser tipo DATE
            cmd.Parameters.AddWithValue("@fec", CType(cita.Fecha, DateTime).Date)

            ' Esto debe ser tipo TIME (TimeSpan en VB suele funcionar bien con TIME en Postgres)
            cmd.Parameters.AddWithValue("@hor", TimeSpan.Parse(cita.Hora.ToString()))

            ' Esto debe ser INTEGER
            cmd.Parameters.AddWithValue("@idEst", cita.Estado)

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' 3. MÉTODO PARA EDITAR
    Public Sub Editar(cita As Cita)
        Dim query As String = "CALL actualizar_cita(@idCita, @idPac, @idMed, @fec, @hor, @est)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idCita", cita.IdCita)
                    cmd.Parameters.AddWithValue("@idPac", cita.IdPaciente)
                    cmd.Parameters.AddWithValue("@idMed", cita.IdMedico)
                    cmd.Parameters.AddWithValue("@fec", cita.Fecha)
                    cmd.Parameters.AddWithValue("@hor", cita.Hora)
                    cmd.Parameters.AddWithValue("@est", cita.Estado)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al modificar la cita: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 4. MÉTODO PARA ELIMINAR
    Public Sub Eliminar(id As Integer)
        Dim query As String = "CALL eliminar_cita(@id)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar la cita: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- MÉTODOS AUXILIARES PARA LLENAR LOS COMBOBOX ---

    Public Function ObtenerPacientes() As DataTable
        Dim dt As New DataTable()
        ' Concatenamos nombre y apellido para que se vea mejor en la lista
        Dim query As String = "SELECT id_paciente, nombre || ' ' || apellido AS nombre_completo FROM pacientes ORDER BY nombre"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ObtenerMedicos() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT id_medico, nombre || ' ' || apellido AS nombre_completo FROM medicos ORDER BY nombre"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function



End Class