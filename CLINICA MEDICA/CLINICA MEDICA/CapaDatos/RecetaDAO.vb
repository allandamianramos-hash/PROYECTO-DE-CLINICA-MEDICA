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
                        r.fecha_emision::text AS fecha_emision,
                        dr.id_detalle,
                        dr.id_medicamento,
                        m.nombre_comercial AS medicamento,
                        dr.dosis,
                        dr.frecuencia_indicacion AS indicaciones
                    FROM recetas r
                    INNER JOIN detalle_receta dr ON r.id_receta = dr.id_receta
                    INNER JOIN medicamentos m ON dr.id_medicamento = m.id_medicamento
                    ORDER BY r.id_receta, dr.id_detalle;
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

    Public Function ObtenerMedicamentosPorReceta(idReceta As Integer) As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT id_medicamento
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

    Public Sub Guardar(receta As Receta)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Using transaccion = conexion.BeginTransaction()

                    Try
                        Dim sqlReceta As String = "
                            INSERT INTO recetas
                            (id_consulta, fecha_emision)
                            VALUES
                            (@id_consulta, CURRENT_DATE)
                            RETURNING id_receta;
                        "

                        Dim idRecetaGenerado As Integer

                        Using comando As New NpgsqlCommand(sqlReceta, conexion, transaccion)

                            comando.Parameters.AddWithValue("@id_consulta", receta.IdConsulta)
                            idRecetaGenerado = CInt(comando.ExecuteScalar())

                        End Using

                        For Each idMedicamento As Integer In receta.Medicamentos

                            Dim sqlDetalle As String = "
                                INSERT INTO detalle_receta
                                (id_receta, id_medicamento, dosis, frecuencia_indicacion)
                                VALUES
                                (@id_receta, @id_medicamento, @dosis, @indicaciones);
                            "

                            Using comandoDetalle As New NpgsqlCommand(sqlDetalle, conexion, transaccion)

                                comandoDetalle.Parameters.AddWithValue("@id_receta", idRecetaGenerado)
                                comandoDetalle.Parameters.AddWithValue("@id_medicamento", idMedicamento)
                                comandoDetalle.Parameters.AddWithValue("@dosis", receta.Dosis)
                                comandoDetalle.Parameters.AddWithValue("@indicaciones", receta.Indicaciones)

                                comandoDetalle.ExecuteNonQuery()

                            End Using

                        Next

                        transaccion.Commit()

                    Catch
                        transaccion.Rollback()
                        Throw
                    End Try

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

                Using transaccion = conexion.BeginTransaction()

                    Try
                        Dim sqlReceta As String = "
                            UPDATE recetas SET
                                id_consulta = @id_consulta
                            WHERE id_receta = @id_receta;
                        "

                        Using comando As New NpgsqlCommand(sqlReceta, conexion, transaccion)

                            comando.Parameters.AddWithValue("@id_receta", receta.IdReceta)
                            comando.Parameters.AddWithValue("@id_consulta", receta.IdConsulta)
                            comando.ExecuteNonQuery()

                        End Using

                        Dim sqlBorrarDetalle As String = "
                            DELETE FROM detalle_receta
                            WHERE id_receta = @id_receta;
                        "

                        Using comandoBorrar As New NpgsqlCommand(sqlBorrarDetalle, conexion, transaccion)

                            comandoBorrar.Parameters.AddWithValue("@id_receta", receta.IdReceta)
                            comandoBorrar.ExecuteNonQuery()

                        End Using

                        For Each idMedicamento As Integer In receta.Medicamentos

                            Dim sqlDetalle As String = "
                                INSERT INTO detalle_receta
                                (id_receta, id_medicamento, dosis, frecuencia_indicacion)
                                VALUES
                                (@id_receta, @id_medicamento, @dosis, @indicaciones);
                            "

                            Using comandoDetalle As New NpgsqlCommand(sqlDetalle, conexion, transaccion)

                                comandoDetalle.Parameters.AddWithValue("@id_receta", receta.IdReceta)
                                comandoDetalle.Parameters.AddWithValue("@id_medicamento", idMedicamento)
                                comandoDetalle.Parameters.AddWithValue("@dosis", receta.Dosis)
                                comandoDetalle.Parameters.AddWithValue("@indicaciones", receta.Indicaciones)

                                comandoDetalle.ExecuteNonQuery()

                            End Using

                        Next

                        transaccion.Commit()

                    Catch
                        transaccion.Rollback()
                        Throw
                    End Try

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

                Using transaccion = conexion.BeginTransaction()

                    Try
                        Dim sqlDetalle As String = "
                            DELETE FROM detalle_receta
                            WHERE id_receta = @id_receta;
                        "

                        Using comandoDetalle As New NpgsqlCommand(sqlDetalle, conexion, transaccion)

                            comandoDetalle.Parameters.AddWithValue("@id_receta", idReceta)
                            comandoDetalle.ExecuteNonQuery()

                        End Using

                        Dim sqlReceta As String = "
                            DELETE FROM recetas
                            WHERE id_receta = @id_receta;
                        "

                        Using comandoReceta As New NpgsqlCommand(sqlReceta, conexion, transaccion)

                            comandoReceta.Parameters.AddWithValue("@id_receta", idReceta)
                            comandoReceta.ExecuteNonQuery()

                        End Using

                        transaccion.Commit()

                    Catch
                        transaccion.Rollback()
                        Throw
                    End Try

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar receta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
