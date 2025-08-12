Public Class vista_mod_asis_listar_asistencia
    Dim control_asistencia As New control_asistencia
    Dim data_table_asistencia As New DataTable
    Private Sub vista_mod_asis_listar_asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = WindowState.Maximized

        data_table_asistencia = control_asistencia.ListarAsistencias()
        dtgasistencia.DataSource = data_table_asistencia
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frm As New vista_mod_asis_registrar_asistencia
        frm.ShowDialog()
    End Sub

    Private Sub dtgasistencia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgasistencia.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dtgasistencia.Rows(e.RowIndex)
            Dim idevento As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)
            Dim frm As New vista_mod_asis_actualizar_asistencia
            frm.IdEvento = idevento
            frm.ShowDialog()
            ' Actualizar la lista después de cerrar el formulario de actualización
            Dim dt As DataTable = control_asistencia.ListarAsistencias()
            dtgasistencia.DataSource = dt
        End If
    End Sub
End Class