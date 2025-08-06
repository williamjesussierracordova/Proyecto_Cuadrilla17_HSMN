Imports System.Data.SqlClient

Public Class control_asistencia

    Public Function ListarAsistencias() As DataTable
        Dim query As String = "
            SELECT A.IdAsistencia, P.Nombre AS Persona, E.Nombre AS Evento, A.FechaAsistencia
            FROM Asistencias A
            JOIN Personas P ON A.IdPersona = P.IdPersona
            JOIN Eventos E ON A.IdEvento = E.IdEvento
        "
        Using connection As New SqlConnection(conexionString),
              adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function RegistrarAsistencia(idPersona As Integer, idEvento As Integer, fecha As DateTime) As Boolean
        Dim query As String = "INSERT INTO Asistencias (IdPersona, IdEvento, FechaAsistencia) VALUES (@IdPersona, @IdEvento, @FechaAsistencia)"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdPersona", idPersona)
            command.Parameters.AddWithValue("@IdEvento", idEvento)
            command.Parameters.AddWithValue("@FechaAsistencia", fecha)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function EliminarAsistencia(id As Integer) As Boolean
        Dim query As String = "DELETE FROM Asistencias WHERE IdAsistencia = @IdAsistencia"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdAsistencia", id)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function
End Class
