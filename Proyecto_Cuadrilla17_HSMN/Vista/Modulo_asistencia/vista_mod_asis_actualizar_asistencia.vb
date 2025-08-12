Public Class vista_mod_asis_actualizar_asistencia

    Public Property IdEvento As Integer
    Dim control_hermanos As New control_hermanos
    Dim data_table_hermanos As New DataTable

    Dim control_asistencia As New control_asistencia
    Dim data_table_asistentes As New DataTable

    Dim control_eventos As New control_actividades
    Dim model_evento As model_actividades
    Private Sub vista_mod_asis_actualizar_asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ' recibiremos la lista de hermanos asistentes al evento seleccionado
        ' esta lista solo contendra a los hermanos asistentes , en el datagridview tendran que estar todos los hermanos
        ' tanto los que asistieron como los que no asistieron
        model_evento = control_eventos.BuscarPorId(IdEvento)

        txtactividad_nombre.Text = model_evento.NombreEvento

        'primero listaremos todos los hermanos
        Dim hermanos As DataTable = control_hermanos.ListarTodos_asistencia()
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

        ' ahora marcaremos los hermanos que asistieron al evento con un true , el dato que tendremos sera el id de los hermanos asistentes

        data_table_asistentes = control_asistencia.listar_hermanos_asistentes_x_evento(IdEvento)
        If data_table_asistentes IsNot Nothing AndAlso data_table_asistentes.Rows.Count > 0 Then
            For Each row As DataRow In data_table_asistentes.Rows
                Dim idHermano As Integer = Convert.ToInt32(row("id_persona"))
                Console.Write("Id Hermano Asistente: " & idHermano.ToString())
                ' buscar el hermano en el datagridview y marcar la asistencia
                For Each dgvRow As DataGridViewRow In dtgasistencia.Rows
                    If Convert.ToInt32(dgvRow.Cells("id").Value) = idHermano Then
                        dgvRow.Cells("Asistencia").Value = True ' Marcar asistencia como true
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        ' eliminar todas las asistencias del evento seleccionado
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar todas las asistencias para esta actividad?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim exito As Boolean = control_asistencia.EliminarAsistencia_evento(IdEvento)
            If exito Then
                MessageBox.Show("Asistencias eliminadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al eliminar las asistencias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        ' actualizar la asistencia de todos los hermanos de la lista
        ' primero eliminaremos todas las asistencias del evento seleccionado
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea actualizar las asistencias para esta actividad? Esto eliminará las asistencias actuales y registrará las nuevas.", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim exitoEliminar As Boolean = control_asistencia.EliminarAsistencia_evento(IdEvento)
            If exitoEliminar Then
                ' Ahora registramos las nuevas asistencias
                For control_asistenciass As Integer = 0 To dtgasistencia.Rows.Count - 1
                    Dim row As DataGridViewRow = dtgasistencia.Rows(control_asistenciass)
                    Dim idHermano As Integer = Convert.ToInt32(row.Cells("id").Value)
                    Dim asistencia As Boolean = Convert.ToBoolean(row.Cells("asistencia").Value)
                    ' Registrar la asistencia solo si se marcó como presente
                    If asistencia Then
                        Dim resultado As Boolean = control_asistencia.RegistrarAsistencia(idHermano, IdEvento, asistencia)
                        If Not resultado Then
                            MessageBox.Show($"Error al registrar la asistencia para el hermano con ID {idHermano}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                MessageBox.Show("Asistencias actualizadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al eliminar las asistencias actuales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub
End Class