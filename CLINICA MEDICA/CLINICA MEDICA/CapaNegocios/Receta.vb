Public Class Receta

    Public Property IdReceta As Integer
    Public Property IdConsulta As Integer
    Public Property Dosis As String
    Public Property Indicaciones As String
    Public Property Medicamentos As New List(Of Integer)

End Class