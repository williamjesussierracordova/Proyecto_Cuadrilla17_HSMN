Imports System.Data.SqlClient

Public Class control_asistencia

    Public Function ListarAsistencias() As DataTable
        Dim query As String = "
            SELECT * FROM VISTA_RESUMEN_ASISTENCIAS ORDER BY fecha_evento DESC
        "
        Using connection As New SqlConnection(conexionString),
              adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function listar_hermanos_asistentes_x_evento(id_evento As Integer) As DataTable
        Dim query As String = "
            SELECT * FROM Asistencias WHERE id_evento = @IdEvento
        "
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdEvento", id_evento)
            Using adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
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

    Public Function EliminarAsistencia_evento(idEvento As Integer) As Boolean
        Dim query As String = "DELETE FROM Asistencias WHERE id_evento = @IdEvento"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdEvento", idEvento)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function
End Class
