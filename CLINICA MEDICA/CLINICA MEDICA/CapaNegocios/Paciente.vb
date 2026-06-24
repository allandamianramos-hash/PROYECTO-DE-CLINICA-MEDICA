Public Class Paciente
    ' Propiedades que mapean la información de prueba hacia PostgreSQL
    Public Property IdPaciente As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property FechaNacimiento As Date
    Public Property Sexo As Char
    Public Property Telefono As String
    Public Property Correo As String
    Public Property Direccion As String

    ' Constructor vacío (Obligatorio para crear objetos limpios en memoria)
    Public Sub New()
    End Sub

    ' Constructor con parámetros (Opcional, para empaquetar datos en una sola línea de código)
    Public Sub New(nom As String, ape As String, fecha As Date, sex As Char, tel As String, mail As String, dir As String)
        Me.Nombre = nom
        Me.Apellido = ape
        Me.FechaNacimiento = fecha
        Me.Sexo = sex
        Me.Telefono = tel
        Me.Correo = mail
        Me.Direccion = dir
    End Sub
End Class
