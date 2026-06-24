Imports Npgsql

Public Class MedicoDAO
    ' 1. MÉTODO PARA MOSTRAR
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        ' Nota: Asegúrate de que los nombres de las columnas coincidan con los de tu base de datos
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

    ' 2. MÉTODO PARA GUARDAR (Actualizado con tus campos reales)
    Public Sub Insertar(medico As Medico)
        ' Ajustamos el query para que use id_especialidad y codigo_colegiacion
        Dim query As String = "INSERT INTO medicos (id_especialidad, nombre, apellido, telefono, correo_electronico, codigo_colegiacion) VALUES (@esp, @nom, @ape, @tel, @mail, @cod)"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@esp", medico.EspecialidadId)
                    cmd.Parameters.AddWithValue("@nom", medico.Nombre)
                    cmd.Parameters.AddWithValue("@ape", medico.Apellido)
                    cmd.Parameters.AddWithValue("@tel", medico.Telefono)
                    cmd.Parameters.AddWithValue("@mail", medico.Correo)
                    cmd.Parameters.AddWithValue("@cod", medico.CodigoColegiacion)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al insertar médico: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 3. NUEVO: MÉTODO PARA ELIMINAR (Esto quitará tu tercer error)
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

    Public Sub Editar(medico As Medico)
        ' Consulta SQL con UPDATE para modificar los datos según el id_medico
        Dim query As String = "UPDATE medicos SET id_especialidad = @esp, nombre = @nom, apellido = @ape, telefono = @tel, correo_electronico = @mail WHERE id_medico = @id"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", medico.IdMedico)
                    cmd.Parameters.AddWithValue("@esp", medico.EspecialidadId)
                    cmd.Parameters.AddWithValue("@nom", medico.Nombre)
                    cmd.Parameters.AddWithValue("@ape", medico.Apellido)
                    cmd.Parameters.AddWithValue("@tel", medico.Telefono)
                    cmd.Parameters.AddWithValue("@mail", medico.Correo)

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al actualizar médico en la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub
End Class