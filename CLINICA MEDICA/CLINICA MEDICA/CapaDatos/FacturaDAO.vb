Imports Npgsql
Imports System.Data

Public Class FacturaDAO

    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    Public Function ObtenerConsultas() As DataTable

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
            MessageBox.Show("Error al cargar consultas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        nombre_comercial,
                        nombre_generico,
                        concentracion,
                        precio,
                        nombre_comercial || ' - ' || nombre_generico || ' - L. ' || precio AS descripcion
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

    Public Function ListarFacturas() As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT 
                        id_factura,
                        id_consulta,
                        monto_total,
                        fecha_pago::text AS fecha_pago,
                        metodo_pago,
                        estado_pago
                    FROM pagos_facturas
                    ORDER BY id_factura;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al listar facturas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Sub Guardar(factura As Factura)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    INSERT INTO pagos_facturas
                    (id_consulta, monto_total, fecha_pago, metodo_pago, estado_pago)
                    VALUES
                    (@id_consulta, @monto_total, @fecha_pago, @metodo_pago, @estado_pago);
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_consulta", factura.IdConsulta)
                    comando.Parameters.AddWithValue("@monto_total", factura.MontoTotal)
                    comando.Parameters.AddWithValue("@fecha_pago", factura.FechaPago)
                    comando.Parameters.AddWithValue("@metodo_pago", factura.MetodoPago)
                    comando.Parameters.AddWithValue("@estado_pago", factura.EstadoPago)

                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Editar(factura As Factura)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    UPDATE pagos_facturas SET
                        id_consulta = @id_consulta,
                        monto_total = @monto_total,
                        fecha_pago = @fecha_pago,
                        metodo_pago = @metodo_pago,
                        estado_pago = @estado_pago
                    WHERE id_factura = @id_factura;
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_factura", factura.IdFactura)
                    comando.Parameters.AddWithValue("@id_consulta", factura.IdConsulta)
                    comando.Parameters.AddWithValue("@monto_total", factura.MontoTotal)
                    comando.Parameters.AddWithValue("@fecha_pago", factura.FechaPago)
                    comando.Parameters.AddWithValue("@metodo_pago", factura.MetodoPago)
                    comando.Parameters.AddWithValue("@estado_pago", factura.EstadoPago)

                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al editar factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Eliminar(idFactura As Integer)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    DELETE FROM pagos_facturas
                    WHERE id_factura = @id_factura;
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_factura", idFactura)
                    comando.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class