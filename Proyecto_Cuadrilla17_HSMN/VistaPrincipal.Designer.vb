<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloHermanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SesionToolStripMenuItem, Me.ModuloHermanosToolStripMenuItem, Me.ModuloActividadesToolStripMenuItem, Me.ModuloAsistenciaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarContraseaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.SesionToolStripMenuItem.Text = "Sesion"
        Me.SesionToolStripMenuItem.Visible = False
        '
        'CambiarContraseaToolStripMenuItem
        '
        Me.CambiarContraseaToolStripMenuItem.Name = "CambiarContraseaToolStripMenuItem"
        Me.CambiarContraseaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambiarContraseaToolStripMenuItem.Text = "Cambiar contraseña"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'ModuloHermanosToolStripMenuItem
        '
        Me.ModuloHermanosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DToolStripMenuItem})
        Me.ModuloHermanosToolStripMenuItem.Name = "ModuloHermanosToolStripMenuItem"
        Me.ModuloHermanosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ModuloHermanosToolStripMenuItem.Text = "Modulo Hermanos"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DToolStripMenuItem.Text = "Lista hermanos"
        '
        'ModuloActividadesToolStripMenuItem
        '
        Me.ModuloActividadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadesToolStripMenuItem})
        Me.ModuloActividadesToolStripMenuItem.Name = "ModuloActividadesToolStripMenuItem"
        Me.ModuloActividadesToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModuloActividadesToolStripMenuItem.Text = "Modulo Actividades"
        '
        'ActividadesToolStripMenuItem
        '
        Me.ActividadesToolStripMenuItem.Name = "ActividadesToolStripMenuItem"
        Me.ActividadesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ActividadesToolStripMenuItem.Text = "Actividades"
        '
        'ModuloAsistenciaToolStripMenuItem
        '
        Me.ModuloAsistenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsistenciaToolStripMenuItem})
        Me.ModuloAsistenciaToolStripMenuItem.Name = "ModuloAsistenciaToolStripMenuItem"
        Me.ModuloAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ModuloAsistenciaToolStripMenuItem.Text = "Modulo Asistencia"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(662, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(20, 19)
        Me.ToolStripStatusLabel1.Text = "Id:"
        Me.ToolStripStatusLabel1.Visible = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(35, 19)
        Me.ToolStripStatusLabel2.Text = "txtid"
        Me.ToolStripStatusLabel2.Visible = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel3.Text = "Usuario:"
        Me.ToolStripStatusLabel3.Visible = False
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel4.Text = "txtusuario"
        Me.ToolStripStatusLabel4.Visible = False
        '
        'VistaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 362)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "VistaPrincipal"
        Me.Text = "Sistema Cuadrilla 17"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModuloHermanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModuloActividadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActividadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModuloAsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContraseaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
End Class
