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
End Class
