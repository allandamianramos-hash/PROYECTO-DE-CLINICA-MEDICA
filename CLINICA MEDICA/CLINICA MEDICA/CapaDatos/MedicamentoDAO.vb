Imports Npgsql
Imports System.Data

Public Class MedicamentoDAO

    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    Public Function ListarMedicamentos() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT 
                        id_medicamento,
                        nombre_comercial,
                        nombre_generico,
                        concentracion,
                        forma_farmaceutica,
                        precio
                    FROM medicamentos
                    ORDER BY id_medicamento;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al listar medicamentos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Sub Guardar(medicamento As Medicamento)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    INSERT INTO medicamentos
                    (nombre_comercial, nombre_generico, concentracion, forma_farmaceutica, precio)
                    VALUES
                    (@nombre_comercial, @nombre_generico, @concentracion, @forma_farmaceutica, @precio);
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@nombre_comercial", medicamento.NombreComercial)
                    comando.Parameters.AddWithValue("@nombre_generico", medicamento.NombreGenerico)
                    comando.Parameters.AddWithValue("@concentracion", medicamento.Concentracion)
                    comando.Parameters.AddWithValue("@forma_farmaceutica", medicamento.FormaFarmaceutica)
                    comando.Parameters.AddWithValue("@precio", medicamento.Precio)

                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar medicamento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Editar(medicamento As Medicamento)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    UPDATE medicamentos SET
                        nombre_comercial = @nombre_comercial,
                        nombre_generico = @nombre_generico,
                        concentracion = @concentracion,
                        forma_farmaceutica = @forma_farmaceutica,
                        precio = @precio
                    WHERE id_medicamento = @id_medicamento;
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_medicamento", medicamento.IdMedicamento)
                    comando.Parameters.AddWithValue("@nombre_comercial", medicamento.NombreComercial)
                    comando.Parameters.AddWithValue("@nombre_generico", medicamento.NombreGenerico)
                    comando.Parameters.AddWithValue("@concentracion", medicamento.Concentracion)
                    comando.Parameters.AddWithValue("@forma_farmaceutica", medicamento.FormaFarmaceutica)
                    comando.Parameters.AddWithValue("@precio", medicamento.Precio)

                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al editar medicamento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Eliminar(idMedicamento As Integer)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    DELETE FROM medicamentos
                    WHERE id_medicamento = @id_medicamento;
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_medicamento", idMedicamento)
                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar medicamento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
