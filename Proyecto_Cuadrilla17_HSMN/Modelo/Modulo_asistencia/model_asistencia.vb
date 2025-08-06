Public Class model_asistencia
    Public Property IdAsistencia As Integer
    Public Property IdPersona As Integer ' Hace referencia a Hermanos.IdHermano
    Public Property IdEvento As Integer ' Hace referencia a Eventos.IdEvento
    Public Property FechaRegistro As DateTime
    Public Property EstadoAsistencia As Boolean
End Class
