Imports Npgsql
Imports System.Data

Public Class IngresoDAO

    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    Public Function ValidarIngreso(username As String, password As String) As Ingreso

        Dim ingresoEncontrado As Ingreso = Nothing

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim consulta As String = "
                    SELECT 
                        username,
                        rol
                    FROM validar_usuario_login(
                        @username,
                        @password
                    );
                "

                Using comando As New NpgsqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@username", username)
                    comando.Parameters.AddWithValue("@password", password)

                    Using lector As NpgsqlDataReader = comando.ExecuteReader()

                        If lector.Read() Then

                            ingresoEncontrado = New Ingreso()
                            ingresoEncontrado.Username = lector("username").ToString()
                            ingresoEncontrado.Rol = lector("rol").ToString()

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al validar ingreso: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ingresoEncontrado

    End Function

End Class
