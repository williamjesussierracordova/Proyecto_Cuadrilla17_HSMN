Imports System.Data.SqlClient

Public Class control_actividades

    Public Function ListarEventos() As DataTable
        Dim query As String = "SELECT * FROM Eventos"
        Using connection As New SqlConnection(conexionString),
              adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function RegistrarEvento(nombre As String, descripcion As String, fecha As DateTime) As Boolean
        Dim query As String = "INSERT INTO Eventos (Nombre, Descripcion, FechaEvento) VALUES (@Nombre, @Descripcion, @FechaEvento)"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Descripcion", descripcion)
            command.Parameters.AddWithValue("@FechaEvento", fecha)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function EditarEvento(id As Integer, nombre As String, descripcion As String, fecha As DateTime) As Boolean
        Dim query As String = "UPDATE Eventos SET Nombre = @Nombre, Descripcion = @Descripcion, FechaEvento = @FechaEvento WHERE IdEvento = @IdEvento"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdEvento", id)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Descripcion", descripcion)
            command.Parameters.AddWithValue("@FechaEvento", fecha)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function EliminarEvento(id As Integer) As Boolean
        Dim query As String = "DELETE FROM Eventos WHERE IdEvento = @IdEvento"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdEvento", id)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function
End Class
