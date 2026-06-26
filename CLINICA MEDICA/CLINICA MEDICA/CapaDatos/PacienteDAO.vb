Imports Npgsql
Imports System.Data

Public Class PacienteDAO

    ' Método para GUARDAR un paciente en la base de datos
    Public Sub Insertar(paciente As Paciente)
        ' ⚡ AQUÍ SE DECLARA "conn"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()

                ' ⚡ AQUÍ SE DECLARA "query"
                Dim query As String = "INSERT INTO pacientes (nombre, apellido, fecha_nacimiento, sexo, direccion, telefono, correo_electronico) VALUES (@nom, @ape, @fec, @sex, @dir, @tel, @mail)"

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nom", SanitizarTexto(paciente.Nombre))
                    cmd.Parameters.AddWithValue("@ape", SanitizarTexto(paciente.Apellido))
                    cmd.Parameters.AddWithValue("@fec", If(paciente.FechaNacimiento = Nothing OrElse paciente.FechaNacimiento = DateTime.MinValue, DBNull.Value, paciente.FechaNacimiento))
                    cmd.Parameters.AddWithValue("@sex", SanitizarTexto(paciente.Sexo))
                    cmd.Parameters.AddWithValue("@tel", SanitizarTexto(paciente.Telefono))
                    cmd.Parameters.AddWithValue("@mail", SanitizarTexto(paciente.Correo))
                    cmd.Parameters.AddWithValue("@dir", SanitizarTexto(paciente.Direccion))

                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al insertar el registro de prueba: " & ex.Message)
            End Try
        End Using
    End Sub
    ' Método para MOSTRAR los registros en tu DataGridView
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM pacientes WHERE activo = true"

                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al cargar la tabla desde Neon: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    ' Método para ELIMINAR un registro físicamente
    Public Sub Eliminar(id As Integer)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Dim query As String = "DELETE FROM pacientes WHERE id_paciente = @id"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar el registro: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Método para ACTUALIZAR un paciente existente
    Public Sub Actualizar(paciente As Paciente)
        ' ⚡ AQUÍ SE DECLARA "conn"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()

                ' ⚡ AQUÍ SE DECLARA "query"
                Dim query As String = "UPDATE pacientes SET nombre=@nom, apellido=@ape, fecha_nacimiento=@fec, sexo=@sex, telefono=@tel, correo_electronico=@mail, direccion=@dir WHERE id_paciente=@id"

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nom", SanitizarTexto(paciente.Nombre))
                    cmd.Parameters.AddWithValue("@ape", SanitizarTexto(paciente.Apellido))
                    cmd.Parameters.AddWithValue("@fec", If(paciente.FechaNacimiento = Nothing OrElse paciente.FechaNacimiento = DateTime.MinValue, DBNull.Value, paciente.FechaNacimiento))
                    cmd.Parameters.AddWithValue("@sex", SanitizarTexto(paciente.Sexo))
                    cmd.Parameters.AddWithValue("@tel", SanitizarTexto(paciente.Telefono))
                    cmd.Parameters.AddWithValue("@mail", SanitizarTexto(paciente.Correo))
                    cmd.Parameters.AddWithValue("@dir", SanitizarTexto(paciente.Direccion))
                    cmd.Parameters.AddWithValue("@id", paciente.IdPaciente)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error al actualizar el registro: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Método para BUSCAR pacientes por filtro de texto
    Public Function Buscar(filtro As String) As DataTable
        Dim dt As New DataTable()
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM pacientes WHERE nombre ILIKE @filtro OR apellido ILIKE @filtro"

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al buscar registros: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    ' Método para deshabilitar un paciente (Borrado lógico)
    Public Sub EliminarLogico(id As Integer)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Dim query As String = "UPDATE pacientes SET activo = false WHERE id_paciente = @id"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Error en borrado lógico: " & ex.Message)
            End Try
        End Using
    End Sub

    ' CORREGIDO: Se arregló la sintaxis del IF que estaba rota, los paréntesis y el cierre de la clase
    Public Function RegistrarYRetornarID(nombre As String, apellido As String, fechaNac As DateTime) As Integer
        ' ⚡ AQUÍ SE DECLARA "query"
        Dim query As String = "INSERT INTO pacientes (nombre, apellido, fecha_nacimiento) VALUES (@nom, @ape, @fec) RETURNING id_paciente"

        ' ⚡ AQUÍ SE DECLARA "conn"
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn) ' ¡Corregido el "New New"!
                    cmd.Parameters.AddWithValue("@nom", SanitizarTexto(nombre))
                    cmd.Parameters.AddWithValue("@ape", SanitizarTexto(apellido))
                    cmd.Parameters.AddWithValue("@fec", fechaNac)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                Throw New Exception("Error al registrar y retornar ID: " & ex.Message)
            End Try
        End Using
    End Function

    Private Function SanitizarTexto(val As Object) As Object
        If val Is Nothing Then Return DBNull.Value

        ' Convertimos a cadena de texto de forma segura
        Dim texto As String = val.ToString()

        ' Eliminamos de raíz cualquier byte nulo (0x00) invisible
        Dim textoLimpio As String = texto.Replace(Chr(0), "").Trim()

        If textoLimpio = "" Then Return DBNull.Value
        Return textoLimpio
    End Function

End Class