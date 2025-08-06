Public Class VistaPrincipal
    Private Sub VistaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = WindowState.Maximized
    End Sub

    Private Sub ActividadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadesToolStripMenuItem.Click
        mostrarVentana(New vista_mod_act_listar_actividades())
    End Sub

    Private Sub mostrarVentana(ByRef ventana As Form)
        If ventana IsNot Nothing Then
            ventana.MdiParent = Me
            ventana.Show()
        End If
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click
        mostrarVentana(New vista_mod_asis_listar_asistencia())
    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click
        mostrarVentana(New vista_mod_hmo_listar_hermano())
    End Sub
End Class
