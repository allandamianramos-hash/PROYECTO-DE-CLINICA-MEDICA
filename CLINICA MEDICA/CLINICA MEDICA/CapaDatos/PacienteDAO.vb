Imports Npgsql

Public Class PacienteDAO

    ' Método para GUARDAR una estructura de datos de prueba en Neon
    Public Sub Insertar(paciente As Paciente)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            Try
                conn.Open()

                ' CORREGIDO: Cambiamos los "..." por tus verdaderos parámetros en orden
                Dim query As String = "INSERT INTO pacientes (nombre, apellido, fecha_nacimiento, sexo, direccion, telefono, correo_electronico) VALUES (@nom, @ape, @fec, @sex, @dir, @tel, @mail)"

                Using cmd As New NpgsqlCommand(query, conn)
                    ' Mapeamos las propiedades del objeto a los parámetros de PostgreSQL
                    cmd.Parameters.AddWithValue("@nom", paciente.Nombre)
                    cmd.Parameters.AddWithValue("@ape", paciente.Apellido)
                    cmd.Parameters.AddWithValue("@fec", paciente.FechaNacimiento)
                    cmd.Parameters.AddWithValue("@sex", paciente.Sexo)
                    cmd.Parameters.AddWithValue("@tel", paciente.Telefono)
                    cmd.Parameters.AddWithValue("@mail", paciente.Correo)
                    cmd.Parameters.AddWithValue("@dir", paciente.Direccion)

                    cmd.ExecuteNonQuery() ' Ejecuta la instrucción en la base de datos
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
                ' Consulta básica para traer toda la tabla ordenada
                ' En tu método Mostrar() de PacienteDAO:
                Dim query As String = "SELECT * FROM pacientes WHERE activo = true"

                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader) ' Llena la tabla de memoria con los datos de PostgreSQL
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al cargar la tabla desde Neon: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    ' Método para ELIMINAR un registro
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

    Public Sub Actualizar(paciente As Paciente)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "UPDATE pacientes SET nombre=@nom, apellido=@ape, fecha_nacimiento=@fec, sexo=@sex, telefono=@tel, correo_electronico=@mail, direccion=@dir WHERE id_paciente=@id"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nom", paciente.Nombre)
                cmd.Parameters.AddWithValue("@ape", paciente.Apellido)
                cmd.Parameters.AddWithValue("@fec", paciente.FechaNacimiento)
                cmd.Parameters.AddWithValue("@sex", paciente.Sexo)
                cmd.Parameters.AddWithValue("@tel", paciente.Telefono)
                cmd.Parameters.AddWithValue("@mail", paciente.Correo)
                cmd.Parameters.AddWithValue("@dir", paciente.Direccion)
                cmd.Parameters.AddWithValue("@id", paciente.IdPaciente)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Buscar(filtro As String) As DataTable
        Dim dt As New DataTable()
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            ' Buscamos en nombre o apellido. El % es un comodín (busca cualquier cosa antes o después)
            Dim query As String = "SELECT * FROM pacientes WHERE nombre ILIKE @filtro OR apellido ILIKE @filtro"

            Using cmd As New NpgsqlCommand(query, conn)
                ' Le añadimos los signos % para buscar coincidencias parciales
                cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")

                Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub EliminarLogico(id As Integer)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            ' Aquí usamos @id porque VB.NET lo reemplazará por el número real
            Dim query As String = "UPDATE pacientes SET activo = false WHERE id_paciente = @id"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Añadimos el parámetro fechaNacimiento
    Public Function RegistrarYRetornarID(nombre As String, apellido As String, fechaNac As DateTime) As Integer
        Dim query As String = "INSERT INTO pacientes (nombre, apellido, fecha_nacimiento) VALUES (@nom, @ape, @fec) RETURNING id_paciente"

        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@ape", apellido)
                cmd.Parameters.AddWithValue("@fec", fechaNac) ' Enviamos la fecha
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function
End Class