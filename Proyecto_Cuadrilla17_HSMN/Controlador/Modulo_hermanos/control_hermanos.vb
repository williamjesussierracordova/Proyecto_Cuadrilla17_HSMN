Imports System.Data.SqlClient
Imports System.Data

Public Class control_hermanos

    Public Function ListarTodos() As DataTable
        Using conn As New SqlConnection(Conexion.conexionString)
            Dim query As String = "SELECT * FROM VISTA_RESUMEN_HERMANOS"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ListarTodos_asistencia() As DataTable
        Using conn As New SqlConnection(Conexion.conexionString)
            Dim query As String = "SELECT id_hermano as id,apellido_paterno,apellido_materno,nombres FROM hermanos order by apellido_paterno"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function BuscarPorId(id As Integer) As model_hermanos
        Dim hermanoEncontrado As model_hermanos = Nothing

        Using conn As New SqlConnection(conexionString)
            Dim query As String = "SELECT * FROM Hermanos WHERE id_hermano = @Id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Id", id)

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    hermanoEncontrado = New model_hermanos() With {
                        .IdHermano = Convert.ToInt32(reader("id_hermano")),
                        .AnioIngreso = Convert.ToInt32(reader("anio_ingreso")),
                        .CuadrillaGrupoRama = reader("cuadrilla_grupo_rama").ToString(),
                        .CodigoHSMN = reader("codigo_hsmn").ToString(),
                        .ApellidoPaterno = reader("apellido_paterno").ToString(),
                        .ApellidoMaterno = reader("apellido_materno").ToString(),
                        .Nombres = reader("nombres").ToString(),
                        .FechaNacimiento = Convert.ToDateTime(reader("fecha_nacimiento")),
                        .Direccion = reader("direccion").ToString(),
                        .Distrito = reader("distrito").ToString(),
                        .Telefono = reader("telefono").ToString(),
                        .Celular = reader("celular").ToString(),
                        .CorreoElectronico = reader("correo_electronico").ToString(),
                        .NumeroDNI = reader("numero_dni").ToString(),
                        .EstadoCivil = reader("estado_civil").ToString(),
                        .NombreConyuge = reader("nombre_conyuge").ToString(),
                        .ProfesionOcupacion = reader("profesion_ocupacion").ToString(),
                        .NombreCentroLaboral = reader("nombre_centro_laboral").ToString(),
                        .DireccionLaboral = reader("direccion_laboral").ToString(),
                        .DistritoLaboral = reader("distrito_laboral").ToString(),
                        .TelefonoLaboral = reader("telefono_laboral").ToString(),
                        .CargoOcupado = reader("cargo_ocupado").ToString()
                    }
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar hermano: " & ex.Message)
            End Try
        End Using

        Return hermanoEncontrado
    End Function

    Public Function Registrar(h As model_hermanos) As Boolean
        Using conn As New SqlConnection(Conexion.conexionString)
            Dim query As String = "INSERT INTO Hermanos (anio_ingreso, cuadrilla_grupo_rama, codigo_hsmn, apellido_paterno, apellido_materno, nombres, fecha_nacimiento, direccion, distrito, telefono, celular, correo_electronico, numero_dni, estado_civil, nombre_conyuge, profesion_ocupacion, nombre_centro_laboral, direccion_laboral, distrito_laboral, telefono_laboral, cargo_ocupado) 
                                   VALUES (@anio, @grupo, @codigo, @paterno, @materno, @nombres, @fecha_nac, @direccion, @distrito, @telefono, @celular, @correo, @dni, @civil, @conyuge, @profesion, @centro, @dir_lab, @dist_lab, @tel_lab, @cargo)"
            Using cmd As New SqlCommand(query, conn)
                With cmd.Parameters
                    .AddWithValue("@anio", h.AnioIngreso)
                    .AddWithValue("@grupo", h.CuadrillaGrupoRama)
                    .AddWithValue("@codigo", h.CodigoHSMN)
                    .AddWithValue("@paterno", h.ApellidoPaterno)
                    .AddWithValue("@materno", h.ApellidoMaterno)
                    .AddWithValue("@nombres", h.Nombres)
                    .AddWithValue("@fecha_nac", h.FechaNacimiento)
                    .AddWithValue("@direccion", h.Direccion)
                    .AddWithValue("@distrito", h.Distrito)
                    .AddWithValue("@telefono", h.Telefono)
                    .AddWithValue("@celular", h.Celular)
                    .AddWithValue("@correo", h.CorreoElectronico)
                    .AddWithValue("@dni", h.NumeroDNI)
                    .AddWithValue("@civil", h.EstadoCivil)
                    .AddWithValue("@conyuge", h.NombreConyuge)
                    .AddWithValue("@profesion", h.ProfesionOcupacion)
                    .AddWithValue("@centro", h.NombreCentroLaboral)
                    .AddWithValue("@dir_lab", h.DireccionLaboral)
                    .AddWithValue("@dist_lab", h.DistritoLaboral)
                    .AddWithValue("@tel_lab", h.TelefonoLaboral)
                    .AddWithValue("@cargo", h.CargoOcupado)
                End With
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Actualizar(h As model_hermanos) As Boolean
        Using conn As New SqlConnection(Conexion.conexionString)
            Dim query As String = "UPDATE Hermanos SET anio_ingreso=@anio, cuadrilla_grupo_rama=@grupo, codigo_hsmn=@codigo, apellido_paterno=@paterno, apellido_materno=@materno, nombres=@nombres, fecha_nacimiento=@fecha_nac, direccion=@direccion, distrito=@distrito, telefono=@telefono, celular=@celular, correo_electronico=@correo, numero_dni=@dni, estado_civil=@civil, nombre_conyuge=@conyuge, profesion_ocupacion=@profesion, nombre_centro_laboral=@centro, direccion_laboral=@dir_lab, distrito_laboral=@dist_lab, telefono_laboral=@tel_lab, cargo_ocupado=@cargo WHERE id_hermano=@id"
            Using cmd As New SqlCommand(query, conn)
                With cmd.Parameters
                    .AddWithValue("@id", h.IdHermano)
                    .AddWithValue("@anio", h.AnioIngreso)
                    .AddWithValue("@grupo", h.CuadrillaGrupoRama)
                    .AddWithValue("@codigo", h.CodigoHSMN)
                    .AddWithValue("@paterno", h.ApellidoPaterno)
                    .AddWithValue("@materno", h.ApellidoMaterno)
                    .AddWithValue("@nombres", h.Nombres)
                    .AddWithValue("@fecha_nac", h.FechaNacimiento)
                    .AddWithValue("@direccion", h.Direccion)
                    .AddWithValue("@distrito", h.Distrito)
                    .AddWithValue("@telefono", h.Telefono)
                    .AddWithValue("@celular", h.Celular)
                    .AddWithValue("@correo", h.CorreoElectronico)
                    .AddWithValue("@dni", h.NumeroDNI)
                    .AddWithValue("@civil", h.EstadoCivil)
                    .AddWithValue("@conyuge", h.NombreConyuge)
                    .AddWithValue("@profesion", h.ProfesionOcupacion)
                    .AddWithValue("@centro", h.NombreCentroLaboral)
                    .AddWithValue("@dir_lab", h.DireccionLaboral)
                    .AddWithValue("@dist_lab", h.DistritoLaboral)
                    .AddWithValue("@tel_lab", h.TelefonoLaboral)
                    .AddWithValue("@cargo", h.CargoOcupado)
                End With
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Eliminar(idHermano As Integer) As Boolean
        Using conn As New SqlConnection(Conexion.conexionString)
            Dim query As String = "DELETE FROM Hermanos WHERE id_hermano = @id"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idHermano)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

End Class
