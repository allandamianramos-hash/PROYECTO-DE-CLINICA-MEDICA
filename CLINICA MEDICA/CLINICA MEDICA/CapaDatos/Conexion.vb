Imports Npgsql

Public Class Conexion
    'Imports Npgsql
    ' Cadena de conexión estructurada con las credenciales de tu servidor Neon 
    Private Shared ReadOnly cadenaConexion As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

        ' Función para que las futuras clases de datos obtengan la conexión limpia
        Public Shared Function ObtenerConexion() As NpgsqlConnection
            Return New NpgsqlConnection(cadenaConexion)
        End Function

    ' FUNCIÓN DE PRUEBA: Para verificar el enlace con internet
    Public Shared Function ProbarEnlace() As Boolean
        ' Usamos la instrucción Using para asegurar que la conexión se cierre sola pase lo que pase
        Using conn As NpgsqlConnection = ObtenerConexion()
            Try
                conn.Open() ' Intentamos abrir la compuerta al servidor de Neon
                Return True ' Si llega aquí, la conexión fue un éxito rotundo
            Catch ex As NpgsqlException
                ' Si el servidor de Neon rebota la conexión, se captura aquí
                Throw New Exception("Error de PostgreSQL: " & ex.Message)
            Catch ex As Exception
                ' Cualquier otro error (como falta de internet) se captura aquí
                Throw New Exception("Error general de conectividad: " & ex.Message)
            End Try
        End Using
    End Function

    Public Sub Registrar(cita As Cita)
        ' Aquí estamos creando 'conn' usando tu clase de conexión
        ' Asegúrate de que "Conexion" y "ObtenerConexion()" coincidan con los nombres de tus archivos
        Using conn As NpgsqlConnection = Conexion.ObtenerConexion()
            conn.Open() ' Abrimos la conexión aquí

            Using cmd As New NpgsqlCommand("CALL registrar_cita(@idPac, @idMed, @fec, @hor, @idEst)", conn)
                cmd.Parameters.AddWithValue("@idPac", cita.IdPaciente)
                ' ... (resto de tus parámetros)
                cmd.ExecuteNonQuery()
            End Using
        End Using ' La conexión se cierra sola aquí al terminar el Using
    End Sub
End Class
