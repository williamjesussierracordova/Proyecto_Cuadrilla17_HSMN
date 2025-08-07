Public Class vista_mod_act_listar_actividades
    Dim dt As New DataTable
    Dim control_actividades As New control_actividades

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'mostrar ventana registrar actividades
        Dim ventanaRegistrar As New vista_mod_act_registrar_actividades()
        ventanaRegistrar.ShowDialog()

        ' Actualizar la lista después de cerrar el formulario de registro
        dt = control_actividades.ListarEventos()
        dtgactividades.DataSource = dt
    End Sub


    Private Sub vista_mod_act_listar_actividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Cargar los datos de las actividades en el DataGridView
        dt = control_actividades.ListarEventos()
        dtgactividades.DataSource = dt
    End Sub

    Private Sub dtgactividades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgactividades.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dtgactividades.Rows(e.RowIndex)
            Dim idActividad As Integer = Convert.ToInt32(selectedRow.Cells("id_evento").Value)
            ' Mostrar la ventana de actualización de actividades
            Dim ventanaActualizar As New vista_mod_act_actualizar_actividades()
            ventanaActualizar.IdActividad = idActividad
            ventanaActualizar.ShowDialog()
            ' Actualizar la lista después de cerrar el formulario de actualización
            dt = control_actividades.ListarEventos()
            dtgactividades.DataSource = dt
        End If
    End Sub

End Class