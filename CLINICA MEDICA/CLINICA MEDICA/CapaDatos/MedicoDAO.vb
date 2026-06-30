Imports Npgsql

Public Class MedicoDAO

    ' 1. MÉTODO PARA MOSTRAR (Se queda igual porque no hay función específica en BD)
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT id_medico, id_especialidad, nombre, apellido, telefono, correo_electronico, codigo_colegiacion FROM medicos"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Using cmd As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(cmd)
                    Try
                        conn.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Error al cargar médicos: " & ex.Message)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' 2. MÉTODO PARA GUARDAR (Conectado a registrar_medico)
    Public Sub Insertar(medico As Medico)
        ' 🚨 Agregamos el parámetro @cod al final
        Dim query As String = "CALL registrar_medico(@nom, @ape, @esp, @tel, @mail, @cod)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nom", medico.Nombre)
                    cmd.Parameters.AddWithValue("@ape", medico.Apellido)
                    cmd.Parameters.AddWithValue("@esp", medico.EspecialidadId)
                    cmd.Parameters.AddWithValue("@tel", medico.Telefono)
                    cmd.Parameters.AddWithValue("@mail", medico.Correo)
                    ' 🚨 Ahora sí le mandamos el código que generaste en el formulario
                    cmd.Parameters.AddWithValue("@cod", medico.CodigoColegiacion)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al insertar médico: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 3. MÉTODO PARA ELIMINAR (Se queda igual, usa SQL directo)
    Public Sub Eliminar(id As Integer)
        Dim query As String = "DELETE FROM medicos WHERE id_medico = @id"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar médico de la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 4. MÉTODO PARA EDITAR (Conectado a actualizar_medico)
    Public Sub Editar(medico As Medico)
        ' 🚨 Agregamos el parámetro @cod al final
        Dim query As String = "CALL actualizar_medico(@id, @nom, @ape, @esp, @tel, @mail, @cod)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", medico.IdMedico)
                    cmd.Parameters.AddWithValue("@nom", medico.Nombre)
                    cmd.Parameters.AddWithValue("@ape", medico.Apellido)
                    cmd.Parameters.AddWithValue("@esp", medico.EspecialidadId)
                    cmd.Parameters.AddWithValue("@tel", medico.Telefono)
                    cmd.Parameters.AddWithValue("@mail", medico.Correo)
                    ' 🚨 Enviamos el código
                    cmd.Parameters.AddWithValue("@cod", medico.CodigoColegiacion)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al actualizar médico en la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub
End Class