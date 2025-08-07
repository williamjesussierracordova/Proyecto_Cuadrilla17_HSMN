Public Class vista_mod_act_registrar_actividades
    Dim control_actividades As New control_actividades

    Private Sub vista_mod_act_registrar_actividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        'guardar actividad
        Dim nombre As String = txtnombre.Text.Trim()
        Dim descripcion As String = txtdescripcion.Text.Trim()
        Dim fecha As DateTime = dt_fecha.Value
        Dim organizador As String = txtorganizador.Text.Trim()

        If String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(descripcion) Or String.IsNullOrEmpty(organizador) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim resultado As Boolean = control_actividades.RegistrarEvento(nombre, descripcion, fecha, organizador)
        If resultado Then
            MessageBox.Show("Actividad registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Error al registrar la actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class