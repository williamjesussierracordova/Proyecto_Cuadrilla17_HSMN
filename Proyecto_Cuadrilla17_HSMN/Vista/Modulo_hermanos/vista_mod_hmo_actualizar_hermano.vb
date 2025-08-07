Public Class vista_mod_hmo_actualizar_hermano
    Public Property IdHermano As Integer
    Private Sub vista_mod_hmo_actualizar_hermano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ' Cargar los datos del hermano a actualizar
        Dim controlador_hermanos As New control_hermanos
        Dim hermano As model_hermanos = controlador_hermanos.BuscarPorId(IdHermano)
        If hermano IsNot Nothing Then
            id.Text = hermano.IdHermano.ToString()
            nombres.Text = hermano.Nombres
            apellidopaterno.Text = hermano.ApellidoPaterno
            apellidomaterno.Text = hermano.ApellidoMaterno
            dt_nacimiento.Value = hermano.FechaNacimiento
            direccion.Text = hermano.Direccion
            distrito.Text = hermano.Distrito
            telefono.Text = hermano.Telefono
            celular.Text = hermano.Celular
            correo_electronico.Text = hermano.CorreoElectronico
            dni.Text = hermano.NumeroDNI
            conyuge.Text = hermano.NombreConyuge
            profesion.Text = hermano.ProfesionOcupacion
            centro_laboral.Text = hermano.NombreCentroLaboral
            direccion_laboral.Text = hermano.DireccionLaboral
            distrito_laboral.Text = hermano.DistritoLaboral
            telefono_laboral.Text = hermano.TelefonoLaboral
            ' asignar el estado civil que esta como texto al combobox
            cbxestadocivil.SelectedItem = hermano.EstadoCivil
            cargo.Text = hermano.CargoOcupado
            number_anio_ingreso.Value = hermano.AnioIngreso
            cuadrilla.Value = If(String.IsNullOrEmpty(hermano.CuadrillaGrupoRama), 0, Convert.ToInt32(hermano.CuadrillaGrupoRama))
            codigo_hermandad.Text = hermano.CodigoHSMN
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' eliminar el registro del hermano
        Dim controlador_hermanos As New control_hermanos
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este hermano?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim success As Boolean = controlador_hermanos.Eliminar(IdHermano)
            If success Then
                MessageBox.Show("Hermano eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al eliminar el hermano.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ' Actualizar los datos del hermano
        Dim controlador_hermanos As New control_hermanos
        Dim hermano As New model_hermanos With {
            .IdHermano = Convert.ToInt32(id.Text),
            .Nombres = nombres.Text,
            .ApellidoPaterno = apellidopaterno.Text,
            .ApellidoMaterno = apellidomaterno.Text,
            .FechaNacimiento = dt_nacimiento.Value,
            .Direccion = direccion.Text,
            .Distrito = distrito.Text,
            .Telefono = telefono.Text,
            .Celular = celular.Text,
            .CorreoElectronico = correo_electronico.Text,
            .NumeroDNI = dni.Text,
            .EstadoCivil = If(cbxestadocivil.SelectedItem IsNot Nothing, cbxestadocivil.SelectedItem.ToString(), String.Empty),
            .NombreConyuge = conyuge.Text,
            .ProfesionOcupacion = profesion.Text,
            .NombreCentroLaboral = centro_laboral.Text,
            .DireccionLaboral = direccion_laboral.Text,
            .DistritoLaboral = distrito_laboral.Text,
            .TelefonoLaboral = telefono_laboral.Text,
            .CargoOcupado = cargo.Text,
            .AnioIngreso = Convert.ToInt32(number_anio_ingreso.Value),
            .CuadrillaGrupoRama = cuadrilla.Value.ToString(),
            .CodigoHSMN = codigo_hermandad.Text
        }
        Dim success As Boolean = controlador_hermanos.Actualizar(hermano)
        If success Then
            MessageBox.Show("Hermano actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Error al actualizar el hermano.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class