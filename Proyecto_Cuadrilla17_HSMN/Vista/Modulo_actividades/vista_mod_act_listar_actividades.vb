Public Class vista_mod_act_listar_actividades
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'mostrar ventana registrar actividades
        Dim ventanaRegistrar As New vista_mod_act_registrar_actividades()
        ventanaRegistrar.ShowDialog()
    End Sub


End Class