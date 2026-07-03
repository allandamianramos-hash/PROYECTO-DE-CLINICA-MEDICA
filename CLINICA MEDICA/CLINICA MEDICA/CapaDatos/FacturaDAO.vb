Imports Npgsql
Imports System.Data

Public Class FacturaDAO

    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    ' 🌟 MÉTODO PARA OBTENER SOLO CONSULTAS SIN PAGAR

    Public Function ObtenerConsultas() As DataTable
        Dim tabla As New DataTable
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()

                ' 🛠️ FIX: Ahora viajamos a través de la tabla citas (ci) para llegar al paciente (p)
                Dim sql As String = "
                    SELECT 
                        co.id_consulta, 
                        'Consulta #' || co.id_consulta || ' - ' || p.nombre || ' ' || p.apellido AS descripcion_consulta
                    FROM consultas co
                    JOIN citas ci ON co.id_cita = ci.id_cita
                    JOIN pacientes p ON ci.id_paciente = p.id_paciente
                    WHERE co.id_consulta NOT IN (
                        SELECT id_consulta FROM pagos_facturas
                    )
                    ORDER BY co.fecha_consulta ASC;
                "

                Using adaptador As New NpgsqlDataAdapter(sql, conexion)
                    adaptador.Fill(tabla)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar las consultas pendientes: " & ex.Message, "Error DAO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Function ObtenerDetalleFactura(idFactura As Integer) As DataTable

        Dim tabla As New DataTable

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    SELECT
                        id_medicamento,
                        cantidad,
                        precio_unitario,
                        subtotal
                    FROM obtener_detalle_factura(@id_factura);
                "

                Using comando As New NpgsqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id_factura", idFactura)

                    Using adaptador As New NpgsqlDataAdapter(comando)
                        adaptador.Fill(tabla)
                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al obtener detalle de factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return tabla

    End Function

    Public Sub Guardar(factura As Factura)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Using transaccion = conexion.BeginTransaction()

                    Try
                        Dim idFacturaGenerada As Integer = 0

                        Dim sqlFactura As String = "
                            CALL registrar_factura(
                                @id_consulta,
                                @monto_total,
                                @fecha_pago,
                                @metodo_pago,
                                @estado_pago,
                                NULL
                            );
                        "

                        Using comando As New NpgsqlCommand(sqlFactura, conexion, transaccion)

                            comando.Parameters.AddWithValue("@id_consulta", factura.IdConsulta)
                            comando.Parameters.AddWithValue("@monto_total", factura.MontoTotal)
                            comando.Parameters.AddWithValue("@fecha_pago", factura.FechaPago)
                            comando.Parameters.AddWithValue("@metodo_pago", factura.MetodoPago)
                            comando.Parameters.AddWithValue("@estado_pago", factura.EstadoPago)

                            Using lector As NpgsqlDataReader = comando.ExecuteReader()

                                If lector.Read() Then
                                    idFacturaGenerada = CInt(lector("p_id_factura"))
                                End If

                            End Using

                        End Using

                        For Each detalle As Detalle In factura.Detalles

                            Dim sqlDetalle As String = "
                                CALL registrar_detalle_factura(
                                    @id_factura,
                                    @id_medicamento,
                                    @cantidad,
                                    @precio_unitario,
                                    @subtotal
                                );
                            "

                            Using comandoDetalle As New NpgsqlCommand(sqlDetalle, conexion, transaccion)

                                comandoDetalle.Parameters.AddWithValue("@id_factura", idFacturaGenerada)
                                comandoDetalle.Parameters.AddWithValue("@id_medicamento", detalle.IdMedicamento)
                                comandoDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad)
                                comandoDetalle.Parameters.AddWithValue("@precio_unitario", detalle.PrecioUnitario)
                                comandoDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal)

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
            MessageBox.Show("Error al guardar factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Editar(factura As Factura)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Using transaccion = conexion.BeginTransaction()

                    Try
                        Dim sqlFactura As String = "
                            CALL actualizar_factura(
                                @id_factura,
                                @id_consulta,
                                @monto_total,
                                @fecha_pago,
                                @metodo_pago,
                                @estado_pago
                            );
                        "

                        Using comando As New NpgsqlCommand(sqlFactura, conexion, transaccion)

                            comando.Parameters.AddWithValue("@id_factura", factura.IdFactura)
                            comando.Parameters.AddWithValue("@id_consulta", factura.IdConsulta)
                            comando.Parameters.AddWithValue("@monto_total", factura.MontoTotal)
                            comando.Parameters.AddWithValue("@fecha_pago", factura.FechaPago)
                            comando.Parameters.AddWithValue("@metodo_pago", factura.MetodoPago)
                            comando.Parameters.AddWithValue("@estado_pago", factura.EstadoPago)

                            comando.ExecuteNonQuery()

                        End Using

                        Dim sqlEliminarDetalle As String = "
                            CALL eliminar_detalle_factura_por_factura(@id_factura);
                        "

                        Using comandoEliminar As New NpgsqlCommand(sqlEliminarDetalle, conexion, transaccion)

                            comandoEliminar.Parameters.AddWithValue("@id_factura", factura.IdFactura)
                            comandoEliminar.ExecuteNonQuery()

                        End Using

                        For Each detalle As Detalle In factura.Detalles

                            Dim sqlDetalle As String = "
                                CALL registrar_detalle_factura(
                                    @id_factura,
                                    @id_medicamento,
                                    @cantidad,
                                    @precio_unitario,
                                    @subtotal
                                );
                            "

                            Using comandoDetalle As New NpgsqlCommand(sqlDetalle, conexion, transaccion)

                                comandoDetalle.Parameters.AddWithValue("@id_factura", factura.IdFactura)
                                comandoDetalle.Parameters.AddWithValue("@id_medicamento", detalle.IdMedicamento)
                                comandoDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad)
                                comandoDetalle.Parameters.AddWithValue("@precio_unitario", detalle.PrecioUnitario)
                                comandoDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal)

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
            MessageBox.Show("Error al editar factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Eliminar(idFactura As Integer)

        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)

                conexion.Open()

                Dim sql As String = "
                    CALL eliminar_factura_completa(@id_factura);
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