Imports Npgsql

Public Class CitaDAO

    ' 1. MÉTODO PARA MOSTRAR LAS CITAS
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        ' 🚨 FIX: Extraemos c.id_estado y e.nombre_estado uniéndolo con la tabla estados_cita
        Dim query As String = "SELECT c.id_cita, c.id_paciente, p.nombre AS nombre_paciente, c.id_medico, m.nombre AS nombre_medico, c.fecha, c.hora, c.id_estado, e.nombre_estado AS estado FROM citas c INNER JOIN pacientes p ON c.id_paciente = p.id_paciente INNER JOIN medicos m ON c.id_medico = m.id_medico INNER JOIN estados_cita e ON c.id_estado = e.id_estado ORDER BY c.fecha DESC"

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
        ' Quitamos el @idEsp de la consulta
        Dim query As String = "CALL registrar_cita(@idPac, @idMed, @fec::date, @hor::time, @idEst)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idPac", cita.IdPaciente)
                    cmd.Parameters.AddWithValue("@idMed", cita.IdMedico)

                    ' Aquí eliminamos la línea de cita.IdEspecialidad

                    cmd.Parameters.AddWithValue("@fec", cita.Fecha)
                    cmd.Parameters.AddWithValue("@hor", cita.Hora)
                    ' Convertimos el valor a número entero para la base de datos
                    cmd.Parameters.AddWithValue("@idEst", Convert.ToInt32(cita.Estado))

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al registrar la cita: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 3. MÉTODO PARA EDITAR
    Public Sub Editar(cita As Cita)
        Dim query As String = "CALL actualizar_cita(@idCita, @fec::date, @hor::time, @idEst)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idCita", cita.IdCita)
                    cmd.Parameters.AddWithValue("@fec", cita.Fecha)
                    cmd.Parameters.AddWithValue("@hor", cita.Hora)
                    ' Convertimos el valor a número entero
                    cmd.Parameters.AddWithValue("@idEst", Convert.ToInt32(cita.Estado))

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

    Public Function ListarCitas() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT c.id_cita, p.nombre AS nombre_paciente, m.nombre AS nombre_medico, c.fecha, c.hora FROM citas c JOIN pacientes p ON c.id_paciente = p.id_paciente JOIN medicos m ON c.id_medico = m.id_medico ORDER BY c.id_cita DESC"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using da As New NpgsqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ListarPacientes() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT id_paciente, nombre, apellido, telefono, sexo FROM pacientes ORDER BY id_paciente DESC"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using da As New NpgsqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Class