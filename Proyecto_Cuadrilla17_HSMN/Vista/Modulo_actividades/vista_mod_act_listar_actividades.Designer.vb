<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vista_mod_act_listar_actividades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgactividades = New System.Windows.Forms.DataGridView()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        CType(Me.dtgactividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actividades"
        '
        'dtgactividades
        '
        Me.dtgactividades.AllowUserToAddRows = False
        Me.dtgactividades.AllowUserToDeleteRows = False
        Me.dtgactividades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgactividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgactividades.Location = New System.Drawing.Point(18, 135)
        Me.dtgactividades.Name = "dtgactividades"
        Me.dtgactividades.ReadOnly = True
        Me.dtgactividades.RowHeadersWidth = 62
        Me.dtgactividades.RowTemplate.Height = 28
        Me.dtgactividades.Size = New System.Drawing.Size(950, 369)
        Me.dtgactividades.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Location = New System.Drawing.Point(867, 92)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 35)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'vista_mod_act_listar_actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 515)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.dtgactividades)
        Me.Controls.Add(Me.Label1)
        Me.Name = "vista_mod_act_listar_actividades"
        Me.Text = "Actividades"
        CType(Me.dtgactividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgactividades As DataGridView
    Friend WithEvents btnRegistrar As Button
End Class
