Public Class vista_mod_hmo_listar_hermano
    Dim controlador_hermanos As New control_hermanos
    Private Sub vista_mod_hmo_listar_hermano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = WindowState.Maximized

        Dim dt As DataTable = controlador_hermanos.ListarTodos
        dtg_hermanos.DataSource = dt
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frm As New vista_mod_hmo_registrar_hermano
        frm.ShowDialog()
        ' Actualizar la lista después de cerrar el formulario de registro
        Dim dt As DataTable = controlador_hermanos.ListarTodos()
        dtg_hermanos.DataSource = dt
    End Sub

    Private Sub dtg_hermanos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_hermanos.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dtg_hermanos.Rows(e.RowIndex)
            Dim idHermano As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
            Dim frm As New vista_mod_hmo_actualizar_hermano
            frm.IdHermano = idHermano
            frm.ShowDialog()
            ' Actualizar la lista después de cerrar el formulario de actualización
            Dim dt As DataTable = controlador_hermanos.ListarTodos()
            dtg_hermanos.DataSource = dt
        End If
    End Sub
End Class