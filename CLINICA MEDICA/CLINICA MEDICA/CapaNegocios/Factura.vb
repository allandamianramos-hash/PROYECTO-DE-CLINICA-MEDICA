Public Class Factura

    Public Property IdFactura As Integer
    Public Property IdConsulta As Integer
    Public Property MontoTotal As Decimal
    Public Property FechaPago As DateTime
    Public Property MetodoPago As String
    Public Property EstadoPago As String
    Public Property Detalles As New List(Of Detalle)

End Class

Public Class Detalle

    Public Property IdMedicamento As Integer
    Public Property Cantidad As Integer
    Public Property PrecioUnitario As Decimal
    Public Property Subtotal As Decimal

End Class