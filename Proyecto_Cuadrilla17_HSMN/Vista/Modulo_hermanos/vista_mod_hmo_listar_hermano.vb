Public Class vista_mod_hmo_listar_hermano
    Private Sub vista_mod_hmo_listar_hermano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = WindowState.Maximized
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frm As New vista_mod_hmo_registrar_hermano
        frm.ShowDialog()
    End Sub
End Class