Public Class Receta

    Public Property IdReceta As Integer
    Public Property IdConsulta As Integer
    Public Property Detalles As New List(Of DetalleReceta)

End Class

Public Class DetalleReceta

    Public Property IdMedicamento As Integer
    Public Property Dosis As String
    Public Property Indicaciones As String

End Class