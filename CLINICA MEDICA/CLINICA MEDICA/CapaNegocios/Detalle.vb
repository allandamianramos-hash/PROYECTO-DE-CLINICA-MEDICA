Public Class DetalleFactura

    ' Propiedades que reflejan exactamente las columnas de tu tabla en Neon
    Public Property IdDetalleFactura As Integer
    Public Property IdFactura As Integer
    Public Property IdMedicamento As Integer
    Public Property Cantidad As Integer
    Public Property PrecioUnitario As Decimal
    Public Property Subtotal As Decimal

    ' Constructor vacío (Buenas prácticas de POO)
    Public Sub New()
    End Sub

    ' Constructor con parámetros por si ocupas instanciar un detalle rápido en memoria
    Public Sub New(idFactura As Integer, idMedicamento As Integer, cant As Integer, precio As Decimal, subT As Decimal)
        Me.IdFactura = idFactura
        Me.IdMedicamento = idMedicamento
        Me.Cantidad = cant
        Me.PrecioUnitario = precio
        Me.Subtotal = subT
    End Sub

End Class