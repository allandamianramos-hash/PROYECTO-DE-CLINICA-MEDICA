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
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()

            Using cmd As New NpgsqlCommand("CALL registrar_cita(@idPac, @idMed, @fec, @hor, @idEst)", conn)
                ' Los enteros se mapean bien directo
                cmd.Parameters.AddWithValue("@idPac", cita.IdPaciente)
                cmd.Parameters.AddWithValue("@idMed", cita.IdMedico)

                ' 1. OBLIGAMOS a que se envíe como DATE puro
                Dim pFecha As New NpgsqlParameter("@fec", NpgsqlTypes.NpgsqlDbType.Date)
                pFecha.Value = cita.Fecha.Date
                cmd.Parameters.Add(pFecha)

                ' 2. OBLIGAMOS a que se envíe como TIME puro
                Dim pHora As New NpgsqlParameter("@hor", NpgsqlTypes.NpgsqlDbType.Time)
                pHora.Value = cita.Hora ' Asegúrate de que cita.Hora sea un TimeSpan
                cmd.Parameters.Add(pHora)

                ' 3. OBLIGAMOS a que el estado se envíe como INTEGER (Su ID)
                Dim pEstado As New NpgsqlParameter("@idEst", NpgsqlTypes.NpgsqlDbType.Integer)
                pEstado.Value = Convert.ToInt32(cita.Estado) ' Si cita.Estado es String, usa el ID numérico aquí
                cmd.Parameters.Add(pEstado)

                cmd.ExecuteNonQuery()
            End Using
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

    Public Function ListarCitas() As DataTable
        Dim dt As New DataTable()
        ' Tu consulta SQL (la que usas para mostrar los datos en el grid)
        Dim query As String = "SELECT c.id_cita, p.nombre AS nombre_paciente, m.nombre AS nombre_medico, c.fecha, c.hora FROM citas c JOIN pacientes p ON c.id_paciente = p.id_paciente JOIN medicos m ON c.id_medico = m.id_medico ORDER BY c.id_cita DESC"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using da As New NpgsqlDataAdapter(cmd)
                    da.Fill(dt) ' Llenamos el DataTable con los datos frescos de la BD
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