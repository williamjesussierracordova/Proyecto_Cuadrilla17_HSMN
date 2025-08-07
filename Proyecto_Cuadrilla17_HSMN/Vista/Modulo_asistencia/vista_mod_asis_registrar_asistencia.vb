Public Class vista_mod_asis_registrar_asistencia
    Dim control_actividad As New control_actividades
    Dim control_hermano As New control_hermanos
    Dim control_asistencia As New control_asistencia
    Private Sub vista_mod_asis_registrar_asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        ' cargar las actividades en el combo box
        Dim actividades As DataTable = control_actividad.ListarEventos()
        If actividades IsNot Nothing AndAlso actividades.Rows.Count > 0 Then
            cbx_actividad.DataSource = actividades
            cbx_actividad.DisplayMember = "nombre_evento"
            cbx_actividad.ValueMember = "id_evento"
        Else
            MessageBox.Show("No se encontraron actividades disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' en el datagridview se cargaran los hermanos y se podra marcar la asistencia

        Dim hermanos As DataTable = control_hermano.ListarTodos_asistencia()
        If hermanos IsNot Nothing AndAlso hermanos.Rows.Count > 0 Then
            dtgasistencia.DataSource = hermanos
            dtgasistencia.Columns("id").Visible = False ' Ocultar la columna de ID
            dtgasistencia.Columns("nombres").HeaderText = "Nombres"
            dtgasistencia.Columns("apellido_paterno").HeaderText = "Apellido pat"
            dtgasistencia.Columns("apellido_materno").HeaderText = "Apellido mat"

            dtgasistencia.Columns("nombres").ReadOnly = True
            dtgasistencia.Columns("apellido_paterno").ReadOnly = True
            dtgasistencia.Columns("apellido_materno").ReadOnly = True

            ' la columna asistencia no existe por lo que se creara una columna nueva
            Dim colAsistencia As New DataGridViewCheckBoxColumn()
            colAsistencia.Name = "asistencia"
            colAsistencia.HeaderText = "Asistencia"
            colAsistencia.ReadOnly = False ' Permitir editar la columna de asistencia
            dtgasistencia.Columns.Add(colAsistencia)

        Else
            MessageBox.Show("No se encontraron hermanos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ' Validar que se haya seleccionado una actividad
        If cbx_actividad.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' registrar la asistencia de todos los hermanos de la lista 
        Dim idEvento As Integer = Convert.ToInt32(cbx_actividad.SelectedValue)
        For control_asistenciass As Integer = 0 To dtgasistencia.Rows.Count - 1
            Dim row As DataGridViewRow = dtgasistencia.Rows(control_asistenciass)
            Dim idHermano As Integer = Convert.ToInt32(row.Cells("id").Value)
            Dim asistencia As Boolean = Convert.ToBoolean(row.Cells("asistencia").Value)
            ' Registrar la asistencia solo si se marcó como presente
            If asistencia Then
                Dim resultado As Boolean = control_asistencia.RegistrarAsistencia(idHermano, idEvento, asistencia)
                If Not resultado Then
                    MessageBox.Show($"Error al registrar la asistencia para el hermano con ID {idHermano}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub
End Class