Imports Npgsql

Public Class EspecialidadDAO

    ' 1. MÉTODO PARA MOSTRAR LAS ESPECIALIDADES
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        ' CORREGIDO: Cambiamos "nombre" por "nombre_especialidad"
        Dim query As String = "SELECT id_especialidad, nombre_especialidad, descripcion FROM especialidades ORDER BY id_especialidad"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Error al cargar especialidades: " & ex.Message)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' 2. MÉTODO PARA INSERTAR
    Public Sub Insertar(esp As Especialidad)
        Dim query As String = "CALL registrar_especialidad(@nom, @des)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nom", esp.Nombre)
                    cmd.Parameters.AddWithValue("@des", esp.Descripcion)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al registrar especialidad: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 3. MÉTODO PARA EDITAR
    Public Sub Editar(esp As Especialidad)
        Dim query As String = "CALL actualizar_especialidad(@id, @nom, @des)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", esp.IdEspecialidad)
                    cmd.Parameters.AddWithValue("@nom", esp.Nombre)
                    cmd.Parameters.AddWithValue("@des", esp.Descripcion)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al modificar especialidad: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 4. MÉTODO PARA ELIMINAR
    Public Sub Eliminar(id As Integer)
        Dim query As String = "CALL eliminar_especialidad(@id)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar especialidad: " & ex.Message)
            End Try
        End Using
    End Sub
End Class