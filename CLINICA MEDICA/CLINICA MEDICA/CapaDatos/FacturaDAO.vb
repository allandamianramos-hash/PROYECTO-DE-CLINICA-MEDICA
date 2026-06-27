Imports Npgsql
Imports System.Data

Public Class FacturaDAO

    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

    ' GUARDAR FACTURA
    Public Sub Insertar(f As Factura)
        Using conn As New NpgsqlConnection(conexionString)
            conn.Open()
            Dim query As String = "INSERT INTO pagos_facturas (id_consulta, monto_total, fecha_pago, metodo_pago, estado_pago) VALUES (@id_consulta, @monto, @fecha, @metodo, @estado)"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_consulta", f.IdConsulta)
                cmd.Parameters.AddWithValue("@monto", f.MontoTotal)
                cmd.Parameters.AddWithValue("@fecha", f.FechaPago) ' Al ser DateTime, PostgreSQL lo toma perfecto como timestamp
                cmd.Parameters.AddWithValue("@metodo", f.MetodoPago)
                cmd.Parameters.AddWithValue("@estado", f.EstadoPago)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' MOSTRAR EN LA TABLA
    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        Using conn As New NpgsqlConnection(conexionString)
            conn.Open()
            Dim query As String = "SELECT * FROM pagos_facturas ORDER BY id_factura ASC"
            Using cmd As New NpgsqlCommand(query, conn)
                Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' ACTUALIZAR FACTURA
    Public Sub Actualizar(f As Factura)
        Using conn As New NpgsqlConnection(conexionString)
            conn.Open()
            Dim query As String = "UPDATE pagos_facturas SET id_consulta = @id_consulta, monto_total = @monto, fecha_pago = @fecha, metodo_pago = @metodo, estado_pago = @estado WHERE id_factura = @id_factura"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_consulta", f.IdConsulta)
                cmd.Parameters.AddWithValue("@monto", f.MontoTotal)
                cmd.Parameters.AddWithValue("@fecha", f.FechaPago)
                cmd.Parameters.AddWithValue("@metodo", f.MetodoPago)
                cmd.Parameters.AddWithValue("@estado", f.EstadoPago)
                cmd.Parameters.AddWithValue("@id_factura", f.IdFactura)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' ELIMINAR FACTURA
    Public Sub Eliminar(idFactura As Integer)
        Using conn As New NpgsqlConnection(conexionString)
            conn.Open()
            Dim query As String = "DELETE FROM pagos_facturas WHERE id_factura = @id_factura"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_factura", idFactura)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class