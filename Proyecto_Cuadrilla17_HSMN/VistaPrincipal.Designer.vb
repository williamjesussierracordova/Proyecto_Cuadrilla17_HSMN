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
        Me.ModuloHermanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SesionToolStripMenuItem, Me.ModuloHermanosToolStripMenuItem, Me.ModuloActividadesToolStripMenuItem, Me.ModuloAsistenciaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(993, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.SesionToolStripMenuItem.Text = "Sesion"
        '
        'ModuloHermanosToolStripMenuItem
        '
        Me.ModuloHermanosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DToolStripMenuItem})
        Me.ModuloHermanosToolStripMenuItem.Name = "ModuloHermanosToolStripMenuItem"
        Me.ModuloHermanosToolStripMenuItem.Size = New System.Drawing.Size(178, 29)
        Me.ModuloHermanosToolStripMenuItem.Text = "Modulo Hermanos"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DToolStripMenuItem.Text = "D"
        '
        'ModuloActividadesToolStripMenuItem
        '
        Me.ModuloActividadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadesToolStripMenuItem})
        Me.ModuloActividadesToolStripMenuItem.Name = "ModuloActividadesToolStripMenuItem"
        Me.ModuloActividadesToolStripMenuItem.Size = New System.Drawing.Size(187, 29)
        Me.ModuloActividadesToolStripMenuItem.Text = "Modulo Actividades"
        '
        'ModuloAsistenciaToolStripMenuItem
        '
        Me.ModuloAsistenciaToolStripMenuItem.Name = "ModuloAsistenciaToolStripMenuItem"
        Me.ModuloAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(174, 29)
        Me.ModuloAsistenciaToolStripMenuItem.Text = "Modulo Asistencia"
        '
        'ActividadesToolStripMenuItem
        '
        Me.ActividadesToolStripMenuItem.Name = "ActividadesToolStripMenuItem"
        Me.ActividadesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ActividadesToolStripMenuItem.Text = "Actividades"
        '
        'VistaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 557)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VistaPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
