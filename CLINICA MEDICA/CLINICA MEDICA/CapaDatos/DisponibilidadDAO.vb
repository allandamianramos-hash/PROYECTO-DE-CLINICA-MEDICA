Imports Npgsql
Imports NpgsqlTypes
Imports System.Data

Public Class DisponibilidadDAO

    ' Tu cadena de conexión intacta
    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    Public Function ObtenerMedicos() As DataTable
        Dim tabla As New DataTable
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                Dim consulta As String = "
                    SELECT 
                        id_medico,
                        nombre || ' ' || apellido AS descripcion_medico
                    FROM medicos
                    ORDER BY id_medico;
                "
                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar médicos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tabla
    End Function

    Public Function ListarDisponibilidad() As DataTable
        Dim tabla As New DataTable
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                Dim consulta As String = "
                    SELECT
                        id_disponibilidad,
                        id_medico,
                        medico,
                        hora_inicio,
                        hora_fin
                    FROM listar_disponibilidad_medico();
                "
                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar disponibilidad: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tabla
    End Function

    Public Sub Guardar(disponibilidad As Disponibilidad)
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                ' 🚨 Conectado al nuevo procedimiento que SÍ acepta madrugadas
                Dim consulta As String = "CALL registrar_disponibilidad_medico(@id_medico, @hora_inicio, @hora_fin);"

                Using comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id_medico", disponibilidad.IdMedico)
                    comando.Parameters.Add("@hora_inicio", NpgsqlDbType.Time).Value = disponibilidad.HoraInicio
                    comando.Parameters.Add("@hora_fin", NpgsqlDbType.Time).Value = disponibilidad.HoraFin

                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar disponibilidad: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Editar(disponibilidad As Disponibilidad)
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                ' 🚨 Conectado al nuevo procedimiento
                Dim consulta As String = "CALL actualizar_disponibilidad_medico(@id_disponibilidad, @id_medico, @hora_inicio, @hora_fin);"

                Using comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id_disponibilidad", disponibilidad.IdDisponibilidad)
                    comando.Parameters.AddWithValue("@id_medico", disponibilidad.IdMedico)
                    comando.Parameters.Add("@hora_inicio", NpgsqlDbType.Time).Value = disponibilidad.HoraInicio
                    comando.Parameters.Add("@hora_fin", NpgsqlDbType.Time).Value = disponibilidad.HoraFin

                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al editar disponibilidad: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Eliminar(idDisponibilidad As Integer)
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                Dim consulta As String = "CALL eliminar_disponibilidad_medico(@id_disponibilidad);"

                Using comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id_disponibilidad", idDisponibilidad)
                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar disponibilidad: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class