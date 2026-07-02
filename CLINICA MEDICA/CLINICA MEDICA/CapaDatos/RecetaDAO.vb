Imports Npgsql
Imports System.Data

Public Class RecetaDAO

    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    Public Function ObtenerConsultas() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT 
                        c.id_consulta,
                        'Consulta ' || c.id_consulta || ' - ' || c.diagnostico AS descripcion_consulta
                    FROM consultas c
                    WHERE c.id_consulta NOT IN (
                        SELECT id_consulta FROM recetas
                    )
                    ORDER BY c.id_consulta;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar consultas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ObtenerTodasLasConsultas() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT 
                        id_consulta,
                        'Consulta ' || id_consulta || ' - ' || diagnostico AS descripcion_consulta
                    FROM consultas
                    ORDER BY id_consulta;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar todas las consultas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ObtenerMedicamentos() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT 
                        id_medicamento,
                        nombre_comercial || ' - ' || nombre_generico || ' ' || concentracion AS medicamento
                    FROM medicamentos
                    ORDER BY id_medicamento;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar medicamentos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Function ListarRecetas() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT
                        r.id_receta,
                        r.id_consulta,
                        r.medicamentos,
                        r.dosis,
                        r.indicaciones
                    FROM recetas r
                    ORDER BY r.id_receta;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al listar recetas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Sub Guardar(receta As Receta)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim medicamentosTexto As String = ""
                Dim dosisTexto As String = ""
                Dim indicacionesTexto As String = ""

                For Each detalle As DetalleReceta In receta.Detalles

                    medicamentosTexto &= "Medicamento ID: " & detalle.IdMedicamento.ToString() & "; "
                    dosisTexto &= detalle.Dosis & "; "
                    indicacionesTexto &= detalle.Indicaciones & "; "

                Next

                Dim sql As String = "
                    CALL registrar_receta(
                        @id_consulta,
                        @medicamentos,
                        @dosis,
                        @indicaciones
                    );
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_consulta", receta.IdConsulta)
                    comando.Parameters.AddWithValue("@medicamentos", medicamentosTexto)
                    comando.Parameters.AddWithValue("@dosis", dosisTexto)
                    comando.Parameters.AddWithValue("@indicaciones", indicacionesTexto)

                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar receta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Editar(receta As Receta)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim medicamentosTexto As String = ""
                Dim dosisTexto As String = ""
                Dim indicacionesTexto As String = ""

                For Each detalle As DetalleReceta In receta.Detalles

                    medicamentosTexto &= "Medicamento ID: " & detalle.IdMedicamento.ToString() & "; "
                    dosisTexto &= detalle.Dosis & "; "
                    indicacionesTexto &= detalle.Indicaciones & "; "

                Next

                Dim sql As String = "
                    UPDATE recetas SET
                        id_consulta = @id_consulta,
                        medicamentos = @medicamentos,
                        dosis = @dosis,
                        indicaciones = @indicaciones
                    WHERE id_receta = @id_receta;
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_receta", receta.IdReceta)
                    comando.Parameters.AddWithValue("@id_consulta", receta.IdConsulta)
                    comando.Parameters.AddWithValue("@medicamentos", medicamentosTexto)
                    comando.Parameters.AddWithValue("@dosis", dosisTexto)
                    comando.Parameters.AddWithValue("@indicaciones", indicacionesTexto)

                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al editar receta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Eliminar(idReceta As Integer)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    DELETE FROM recetas
                    WHERE id_receta = @id_receta;
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_receta", idReceta)
                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar receta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function ObtenerMedicamentosPorReceta(idReceta As Integer) As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                SELECT 
                    id_medicamento,
                    dosis,
                    frecuencia_indicacion AS indicaciones
                FROM detalle_receta
                WHERE id_receta = @id_receta;
            "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_receta", idReceta)

                    Using adaptador As New NpgsqlDataAdapter(comando)
                        adaptador.Fill(tabla)
                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al obtener medicamentos de receta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

End Class