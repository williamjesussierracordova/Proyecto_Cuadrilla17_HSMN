Public Class vista_mod_asis_listar_asistencia
    Private Sub vista_mod_asis_listar_asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = WindowState.Maximized
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frm As New vista_mod_asis_registrar_asistencia
        frm.ShowDialog()
    End Sub
End Class