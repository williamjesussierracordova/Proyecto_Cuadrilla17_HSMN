Public Class vista_mod_hmo_registrar_hermano
    Private Sub vista_mod_hmo_registrar_hermano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ' Registrar un nuevo hermano
        Dim controlador_hermanos As New control_hermanos
        Dim hermano As New model_hermanos With {
            .Nombres = nombres.Text,
            .ApellidoPaterno = apellido_paterno.Text,
            .ApellidoMaterno = apellido_materno.Text,
            .FechaNacimiento = dt_fecha_nacimiento.Value,
            .Direccion = direccion.Text,
            .Distrito = distrito.Text,
            .Telefono = telefono.Text,
            .Celular = celular.Text,
            .CorreoElectronico = correo_electronico.Text,
            .NumeroDNI = dni.Text,
            .EstadoCivil = If(cbx_estado_civil.SelectedItem IsNot Nothing, cbx_estado_civil.SelectedItem.ToString(), String.Empty),
            .NombreConyuge = conyuge.Text,
            .ProfesionOcupacion = profesion.Text,
            .NombreCentroLaboral = centro_laboral.Text,
            .DireccionLaboral = direccion_laboral.Text,
            .DistritoLaboral = distrito_laboral.Text,
            .TelefonoLaboral = telefono_laboral.Text,
            .CargoOcupado = cargo_laboral.Text,
            .AnioIngreso = Convert.ToInt32(number_ingreso.Value),
            .CuadrillaGrupoRama = number_cuadrilla.Value.ToString(),
            .CodigoHSMN = codigo_hermandad.Text
        }
        Dim success As Boolean = controlador_hermanos.Registrar(hermano)
        If success Then
            MessageBox.Show("Hermano registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Error al registrar el hermano.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class