Imports Npgsql
Imports System.Data

Public Class ConsultaDAO

    ' Purificador de texto
    Private Function SanitizarTexto(val As Object) As Object
        If val Is Nothing Then Return DBNull.Value
        Dim texto As String = val.ToString()
        Dim textoLimpio As String = texto.Replace(Chr(0), "").Trim()
        If textoLimpio = "" Then Return DBNull.Value
        Return textoLimpio
    End Function

    ' GUARDAR
    Public Sub Insertar(c As Consulta)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "INSERT INTO consultas (id_cita, peso_kg, estatura_m, sintomas, diagnostico, observaciones, fecha_consulta, hora_consulta) VALUES (@id_cita, @peso, @estatura, @sintomas, @diag, @obs, @fecha, @hora)"
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
        End Using
    End Sub

    ' MOSTRAR
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "SELECT * FROM consultas ORDER BY id_consulta ASC"
            Using cmd As New NpgsqlCommand(query, conn)
                Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' ACTUALIZAR
    Public Sub Actualizar(c As Consulta)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "UPDATE consultas SET id_cita=@id_cita, peso_kg=@peso, estatura_m=@estatura, sintomas=@sintomas, diagnostico=@diag, observaciones=@obs, fecha_consulta=@fecha, hora_consulta=@hora WHERE id_consulta=@id"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_cita", c.IdCita)
                cmd.Parameters.AddWithValue("@peso", c.Peso)
                cmd.Parameters.AddWithValue("@estatura", c.Estatura)
                cmd.Parameters.AddWithValue("@sintomas", SanitizarTexto(c.Sintomas))
                cmd.Parameters.AddWithValue("@diag", SanitizarTexto(c.Diagnostico))
                cmd.Parameters.AddWithValue("@obs", SanitizarTexto(c.Observaciones))
                cmd.Parameters.AddWithValue("@fecha", c.Fecha)
                cmd.Parameters.AddWithValue("@hora", c.Hora)
                cmd.Parameters.AddWithValue("@id", c.IdConsulta)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' ELIMINAR
    Public Sub Eliminar(id As Integer)
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "DELETE FROM consultas WHERE id_consulta = @id"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' EXTRA: Cargar combos
    Public Function ObtenerCitasParaCombo() As DataTable
        Dim dt As New DataTable()
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open()
            ' Cargamos el ID de la cita para vincularla fácilmente
            Dim query As String = "SELECT id_cita, ('Cita #' || id_cita || ' - ' || fecha_cita) AS descripcion FROM citas"
            Using cmd As New NpgsqlCommand(query, conn)
                Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function
End Class