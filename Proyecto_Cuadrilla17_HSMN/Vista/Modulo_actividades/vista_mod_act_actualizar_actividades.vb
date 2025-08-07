Public Class vista_mod_act_actualizar_actividades
    Public IdActividad As Integer
    Private Sub vista_mod_act_actualizar_actividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Aquí puedes cargar los datos de la actividad con IdActividad
        ' Por ejemplo, podrías usar un método de control_actividades para obtener los detalles de la actividad
        Me.CenterToScreen()
        Dim control_actividades As New control_actividades()
        Dim actividad As model_actividades = control_actividades.BuscarPorId(IdActividad)
        If actividad IsNot Nothing Then
            txtnombre.Text = actividad.NombreEvento
            descripcion.Text = actividad.Descripcion
            dt_fecha.Value = actividad.FechaEvento
            txtid.Text = actividad.IdEvento.ToString()
            organizador.Text = actividad.Organizador
        Else
            MessageBox.Show("Actividad no encontrada.")
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ' eliminar actividad
        Dim control_actividades As New control_actividades()
        Dim resultado As Boolean = control_actividades.EliminarEvento(IdActividad)
        If resultado Then
            MessageBox.Show("Actividad eliminada correctamente.")
            Me.Close()
        Else
            MessageBox.Show("Error al eliminar la actividad.")
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ' actualizar actividad
        Dim control_actividades As New control_actividades()
        Dim actividad As New model_actividades With {
            .IdEvento = Convert.ToInt32(txtid.Text),
            .NombreEvento = txtnombre.Text,
            .Descripcion = descripcion.Text,
            .FechaEvento = dt_fecha.Value,
            .Organizador = organizador.Text
        }
        Dim resultado As Boolean = control_actividades.EditarEvento(actividad.IdEvento, actividad.NombreEvento, actividad.Descripcion, actividad.FechaEvento, actividad.Organizador)
        If resultado Then
            MessageBox.Show("Actividad actualizada correctamente.")
            Me.Close()
        Else
            MessageBox.Show("Error al actualizar la actividad.")
        End If
    End Sub
End Class