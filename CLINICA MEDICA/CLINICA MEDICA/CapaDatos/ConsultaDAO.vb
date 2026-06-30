Imports Npgsql
Imports System.Data

Public Class ConsultaDAO

    ' Purificador de texto (Se queda intacto, ¡muy buena función!)
    Private Function SanitizarTexto(val As Object) As Object
        If val Is Nothing Then Return DBNull.Value
        Dim texto As String = val.ToString()
        Dim textoLimpio As String = texto.Replace(Chr(0), "").Trim()
        If textoLimpio = "" Then Return DBNull.Value
        Return textoLimpio
    End Function

    ' 1. MÉTODO PARA INSERTAR
    Public Sub Insertar(c As Consulta)
        ' 🚨 Invocamos el Procedimiento Almacenado y casteamos fecha/hora
        Dim query As String = "CALL registrar_consulta(@id_cita, @peso, @estatura, @sintomas, @diag, @obs, @fecha::date, @hora::time)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_cita", c.IdCita)
                    cmd.Parameters.AddWithValue("@peso", c.Peso)
                    cmd.Parameters.AddWithValue("@estatura", c.Estatura)
                    cmd.Parameters.AddWithValue("@sintomas", SanitizarTexto(c.Sintomas))
                    cmd.Parameters.AddWithValue("@diag", SanitizarTexto(c.Diagnostico))
                    cmd.Parameters.AddWithValue("@obs", SanitizarTexto(c.Observaciones))
                    cmd.Parameters.AddWithValue("@fecha", c.Fecha)
                    cmd.Parameters.AddWithValue("@hora", c.Hora)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al registrar la consulta: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 2. MÉTODO PARA MOSTRAR
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        ' Usamos la consulta directa ordenando las más recientes primero
        Dim query As String = "SELECT * FROM consultas ORDER BY id_consulta DESC"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Error al cargar las consultas: " & ex.Message)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' 3. MÉTODO PARA ACTUALIZAR
    Public Sub Actualizar(c As Consulta)
        ' 🚨 Invocamos el Procedimiento Almacenado
        Dim query As String = "CALL actualizar_consulta(@id, @id_cita, @peso, @estatura, @sintomas, @diag, @obs, @fecha::date, @hora::time)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", c.IdConsulta)
                    cmd.Parameters.AddWithValue("@id_cita", c.IdCita)
                    cmd.Parameters.AddWithValue("@peso", c.Peso)
                    cmd.Parameters.AddWithValue("@estatura", c.Estatura)
                    cmd.Parameters.AddWithValue("@sintomas", SanitizarTexto(c.Sintomas))
                    cmd.Parameters.AddWithValue("@diag", SanitizarTexto(c.Diagnostico))
                    cmd.Parameters.AddWithValue("@obs", SanitizarTexto(c.Observaciones))
                    cmd.Parameters.AddWithValue("@fecha", c.Fecha)
                    cmd.Parameters.AddWithValue("@hora", c.Hora)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al modificar la consulta: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 4. MÉTODO PARA ELIMINAR
    Public Sub Eliminar(id As Integer)
        ' 🚨 Invocamos el Procedimiento Almacenado
        Dim query As String = "CALL eliminar_consulta(@id)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar la consulta: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 5. EXTRA: Cargar combos
    Public Function ObtenerCitasParaCombo() As DataTable
        Dim dt As New DataTable()
        ' 🚨 FIX: Cambiamos fecha_cita por fecha (nombre real de tu columna en tabla citas)
        Dim query As String = "SELECT id_cita, ('Cita #' || id_cita || ' - ' || fecha) AS descripcion FROM citas ORDER BY id_cita DESC"

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