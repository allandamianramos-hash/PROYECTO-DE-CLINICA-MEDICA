Public Class Cita
    Public Property IdCita As Integer
    Public Property IdPaciente As Integer
    Public Property IdMedico As Integer

    Public Property IdEspecialidad As Integer
    Public Property Fecha As Date
    Public Property Hora As TimeSpan ' TimeSpan es ideal para el tipo 'time' de PostgreSQL
    Public Property Estado As String
End Class