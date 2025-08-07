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

    Public Function BuscarPorId(id As Integer) As model_actividades
        Dim actividadencontrada As model_actividades = Nothing

        Using conn As New SqlConnection(conexionString)
            Dim query As String = "SELECT * FROM Eventos WHERE id_evento = @Id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Id", id)

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    actividadencontrada = New model_actividades() With {
                        .IdEvento = Convert.ToInt32(reader("id_evento")),
                        .Descripcion = reader("descripcion").ToString(),
                        .FechaEvento = Convert.ToDateTime(reader("fecha_evento")),
                        .NombreEvento = reader("nombre_evento").ToString(),
                        .Organizador = reader("organizador").ToString()
                    }
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar actividad: " & ex.Message)
            End Try
        End Using

        Return actividadencontrada
    End Function

    Public Function RegistrarEvento(nombre As String, descripcion As String, fecha As DateTime, organizador As String) As Boolean
        Dim query As String = "INSERT INTO Eventos (nombre_evento, Descripcion, fecha_evento,organizador) VALUES (@Nombre, @Descripcion, @FechaEvento,@organizador)"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Descripcion", descripcion)
            command.Parameters.AddWithValue("@FechaEvento", fecha)
            command.Parameters.AddWithValue("@organizador", organizador)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function EditarEvento(id As Integer, nombre As String, descripcion As String, fecha As DateTime, organizador As String) As Boolean
        Dim query As String = "UPDATE Eventos SET nombre_evento = @Nombre, Descripcion = @Descripcion, fecha_evento = @FechaEvento, organizador=@organizador WHERE Id_Evento = @IdEvento"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdEvento", id)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Descripcion", descripcion)
            command.Parameters.AddWithValue("@FechaEvento", fecha)
            command.Parameters.AddWithValue("@organizador", organizador)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function EliminarEvento(id As Integer) As Boolean
        Dim query As String = "DELETE FROM Eventos WHERE Id_Evento = @IdEvento"
        Using connection As New SqlConnection(conexionString),
              command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdEvento", id)

            connection.Open()
            Return command.ExecuteNonQuery() > 0
        End Using
    End Function
End Class
