<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vista_mod_hmo_registrar_hermano
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vista_mod_hmo_registrar_hermano))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dt_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.correo_electronico = New System.Windows.Forms.TextBox()
        Me.celular = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.distrito = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.apellido_materno = New System.Windows.Forms.TextBox()
        Me.apellido_paterno = New System.Windows.Forms.TextBox()
        Me.nombres = New System.Windows.Forms.TextBox()
        Me.cbx_estado_civil = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cargo_laboral = New System.Windows.Forms.TextBox()
        Me.telefono_laboral = New System.Windows.Forms.TextBox()
        Me.distrito_laboral = New System.Windows.Forms.TextBox()
        Me.direccion_laboral = New System.Windows.Forms.TextBox()
        Me.centro_laboral = New System.Windows.Forms.TextBox()
        Me.profesion = New System.Windows.Forms.TextBox()
        Me.conyuge = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.codigo_hermandad = New System.Windows.Forms.TextBox()
        Me.number_cuadrilla = New System.Windows.Forms.NumericUpDown()
        Me.number_ingreso = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.number_cuadrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_ingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripSeparator4, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 5, 4, 5)
        Me.ToolStrip1.Size = New System.Drawing.Size(798, 54)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(39, 41)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        Me.ToolStripButton5.ToolTipText = "Guardar registro"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(10, 2, 10, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(39, 39)
        Me.ToolStripButton4.ToolTipText = "Cancelar Operación"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(774, 485)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dt_fecha_nacimiento)
        Me.TabPage1.Controls.Add(Me.dni)
        Me.TabPage1.Controls.Add(Me.correo_electronico)
        Me.TabPage1.Controls.Add(Me.celular)
        Me.TabPage1.Controls.Add(Me.telefono)
        Me.TabPage1.Controls.Add(Me.distrito)
        Me.TabPage1.Controls.Add(Me.direccion)
        Me.TabPage1.Controls.Add(Me.apellido_materno)
        Me.TabPage1.Controls.Add(Me.apellido_paterno)
        Me.TabPage1.Controls.Add(Me.nombres)
        Me.TabPage1.Controls.Add(Me.cbx_estado_civil)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(766, 452)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dt_fecha_nacimiento
        '
        Me.dt_fecha_nacimiento.Location = New System.Drawing.Point(201, 142)
        Me.dt_fecha_nacimiento.Name = "dt_fecha_nacimiento"
        Me.dt_fecha_nacimiento.Size = New System.Drawing.Size(367, 26)
        Me.dt_fecha_nacimiento.TabIndex = 21
        '
        'dni
        '
        Me.dni.Location = New System.Drawing.Point(201, 391)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(367, 26)
        Me.dni.TabIndex = 20
        '
        'correo_electronico
        '
        Me.correo_electronico.Location = New System.Drawing.Point(201, 351)
        Me.correo_electronico.Name = "correo_electronico"
        Me.correo_electronico.Size = New System.Drawing.Size(367, 26)
        Me.correo_electronico.TabIndex = 19
        '
        'celular
        '
        Me.celular.Location = New System.Drawing.Point(201, 311)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(367, 26)
        Me.celular.TabIndex = 18
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(201, 270)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(367, 26)
        Me.telefono.TabIndex = 17
        '
        'distrito
        '
        Me.distrito.Location = New System.Drawing.Point(201, 228)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(367, 26)
        Me.distrito.TabIndex = 16
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(201, 186)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(546, 26)
        Me.direccion.TabIndex = 15
        '
        'apellido_materno
        '
        Me.apellido_materno.Location = New System.Drawing.Point(201, 97)
        Me.apellido_materno.Name = "apellido_materno"
        Me.apellido_materno.Size = New System.Drawing.Size(367, 26)
        Me.apellido_materno.TabIndex = 14
        '
        'apellido_paterno
        '
        Me.apellido_paterno.Location = New System.Drawing.Point(201, 57)
        Me.apellido_paterno.Name = "apellido_paterno"
        Me.apellido_paterno.Size = New System.Drawing.Size(367, 26)
        Me.apellido_paterno.TabIndex = 13
        '
        'nombres
        '
        Me.nombres.Location = New System.Drawing.Point(201, 21)
        Me.nombres.Name = "nombres"
        Me.nombres.Size = New System.Drawing.Size(262, 26)
        Me.nombres.TabIndex = 12
        '
        'cbx_estado_civil
        '
        Me.cbx_estado_civil.FormattingEnabled = True
        Me.cbx_estado_civil.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Viudo/a", "Divorciado/a", "Separado/a"})
        Me.cbx_estado_civil.Location = New System.Drawing.Point(587, 18)
        Me.cbx_estado_civil.Name = "cbx_estado_civil"
        Me.cbx_estado_civil.Size = New System.Drawing.Size(160, 28)
        Me.cbx_estado_civil.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(489, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Estado civil:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DNI:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Correo electronico:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Distrito:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de nacimiento"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cargo_laboral)
        Me.TabPage2.Controls.Add(Me.telefono_laboral)
        Me.TabPage2.Controls.Add(Me.distrito_laboral)
        Me.TabPage2.Controls.Add(Me.direccion_laboral)
        Me.TabPage2.Controls.Add(Me.centro_laboral)
        Me.TabPage2.Controls.Add(Me.profesion)
        Me.TabPage2.Controls.Add(Me.conyuge)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(766, 452)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adicionales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cargo_laboral
        '
        Me.cargo_laboral.Location = New System.Drawing.Point(214, 287)
        Me.cargo_laboral.Name = "cargo_laboral"
        Me.cargo_laboral.Size = New System.Drawing.Size(513, 26)
        Me.cargo_laboral.TabIndex = 20
        '
        'telefono_laboral
        '
        Me.telefono_laboral.Location = New System.Drawing.Point(214, 243)
        Me.telefono_laboral.Name = "telefono_laboral"
        Me.telefono_laboral.Size = New System.Drawing.Size(513, 26)
        Me.telefono_laboral.TabIndex = 19
        '
        'distrito_laboral
        '
        Me.distrito_laboral.Location = New System.Drawing.Point(214, 202)
        Me.distrito_laboral.Name = "distrito_laboral"
        Me.distrito_laboral.Size = New System.Drawing.Size(513, 26)
        Me.distrito_laboral.TabIndex = 18
        '
        'direccion_laboral
        '
        Me.direccion_laboral.Location = New System.Drawing.Point(214, 156)
        Me.direccion_laboral.Name = "direccion_laboral"
        Me.direccion_laboral.Size = New System.Drawing.Size(513, 26)
        Me.direccion_laboral.TabIndex = 17
        '
        'centro_laboral
        '
        Me.centro_laboral.Location = New System.Drawing.Point(214, 111)
        Me.centro_laboral.Name = "centro_laboral"
        Me.centro_laboral.Size = New System.Drawing.Size(513, 26)
        Me.centro_laboral.TabIndex = 16
        '
        'profesion
        '
        Me.profesion.Location = New System.Drawing.Point(214, 66)
        Me.profesion.Name = "profesion"
        Me.profesion.Size = New System.Drawing.Size(513, 26)
        Me.profesion.TabIndex = 15
        '
        'conyuge
        '
        Me.conyuge.Location = New System.Drawing.Point(214, 22)
        Me.conyuge.Name = "conyuge"
        Me.conyuge.Size = New System.Drawing.Size(513, 26)
        Me.conyuge.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 293)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 20)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Cargo que ocupa:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 249)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Teléfono:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 20)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Distrito:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Dirección:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Centro laboral:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(170, 20)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Profesión u ocupación:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Conyuge:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.codigo_hermandad)
        Me.TabPage3.Controls.Add(Me.number_cuadrilla)
        Me.TabPage3.Controls.Add(Me.number_ingreso)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(766, 452)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hermandad"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'codigo_hermandad
        '
        Me.codigo_hermandad.Location = New System.Drawing.Point(177, 120)
        Me.codigo_hermandad.Name = "codigo_hermandad"
        Me.codigo_hermandad.Size = New System.Drawing.Size(195, 26)
        Me.codigo_hermandad.TabIndex = 10
        '
        'number_cuadrilla
        '
        Me.number_cuadrilla.Location = New System.Drawing.Point(177, 69)
        Me.number_cuadrilla.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.number_cuadrilla.Name = "number_cuadrilla"
        Me.number_cuadrilla.Size = New System.Drawing.Size(195, 26)
        Me.number_cuadrilla.TabIndex = 9
        Me.number_cuadrilla.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'number_ingreso
        '
        Me.number_ingreso.Location = New System.Drawing.Point(177, 23)
        Me.number_ingreso.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.number_ingreso.Name = "number_ingreso"
        Me.number_ingreso.Size = New System.Drawing.Size(195, 26)
        Me.number_ingreso.TabIndex = 8
        Me.number_ingreso.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(21, 127)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 20)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Código:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(21, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 20)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Cuadrilla:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 20)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Año de ingreso:"
        '
        'vista_mod_hmo_registrar_hermano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 583)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "vista_mod_hmo_registrar_hermano"
        Me.Text = "vista_mod_hmo_registrar_hermano"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.number_cuadrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_ingreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dni As TextBox
    Friend WithEvents correo_electronico As TextBox
    Friend WithEvents celular As TextBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents distrito As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents apellido_materno As TextBox
    Friend WithEvents apellido_paterno As TextBox
    Friend WithEvents nombres As TextBox
    Friend WithEvents cbx_estado_civil As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dt_fecha_nacimiento As DateTimePicker
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cargo_laboral As TextBox
    Friend WithEvents telefono_laboral As TextBox
    Friend WithEvents distrito_laboral As TextBox
    Friend WithEvents direccion_laboral As TextBox
    Friend WithEvents centro_laboral As TextBox
    Friend WithEvents profesion As TextBox
    Friend WithEvents conyuge As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents codigo_hermandad As TextBox
    Friend WithEvents number_cuadrilla As NumericUpDown
    Friend WithEvents number_ingreso As NumericUpDown
    Friend WithEvents Label21 As Label
End Class
