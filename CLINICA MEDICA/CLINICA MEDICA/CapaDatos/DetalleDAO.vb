Imports Npgsql
Imports System.Data

Public Class DetalleFacturaDAO

    ' Tu cadena de conexión intacta hacia Neon
    Private ReadOnly cadenaConexion As String = "Host=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KIjvXm6uzAi;SSL Mode=Require;Trust Server Certificate=true"

    ' 🌟 MÉTODO MOSTRAR: El que jala los datos para llenar tu DataGridView
    Public Function Mostrar() As DataTable
        Dim tabla As New DataTable
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                ' Consulta SQL limpia para jalar los detalles ordenados
                Dim consulta As String = "
                    SELECT 
                        id_detalle_factura, 
                        id_factura, 
                        id_medicamento, 
                        cantidad, 
                        precio_unitario, 
                        subtotal 
                    FROM detalle_factura 
                    ORDER BY id_detalle_factura ASC;
                "
                Using adaptador As New NpgsqlDataAdapter(consulta, conexion)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles de las facturas: " & ex.Message, "Error DAO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tabla
    End Function

    Public Sub Guardar(detalle As DetalleFactura)
        Try
            Using conexion As New NpgsqlConnection(cadenaConexion)
                conexion.Open()
                ' Llamamos al procedimiento almacenado tal como lo haces con las citas o pacientes
                Dim consulta As String = "CALL registrar_detalle_factura(@id_factura, @id_medicamento, @cantidad, @precio_unitario, @subtotal);"

                Using comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id_factura", detalle.IdFactura)
                    comando.Parameters.AddWithValue("@id_medicamento", detalle.IdMedicamento)
                    comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad)
                    comando.Parameters.AddWithValue("@precio_unitario", detalle.PrecioUnitario)
                    comando.Parameters.AddWithValue("@subtotal", detalle.Subtotal)

                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar el detalle: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class