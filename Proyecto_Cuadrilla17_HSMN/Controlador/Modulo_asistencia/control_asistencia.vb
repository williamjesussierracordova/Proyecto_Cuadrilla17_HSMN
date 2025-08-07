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

    Public Function RegistrarAsistencia(idPersona As Integer, idEvento As Integer, asistencia As Boolean) As Boolean
        Dim query As String = "INSERT INTO Asistencias (Id_Persona, Id_Evento,estado_asistencia) VALUES (@IdPersona, @IdEvento, @asistencia)"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdPersona", idPersona)
            command.Parameters.AddWithValue("@IdEvento", idEvento)
            command.Parameters.AddWithValue("@asistencia", asistencia)

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
