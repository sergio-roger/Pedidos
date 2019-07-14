<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mesero_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuPpal = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lbl_hora = New System.Windows.Forms.ToolStripLabel()
        Me.lbl_fecha = New System.Windows.Forms.ToolStripLabel()
        Me.lbl_usuario = New System.Windows.Forms.ToolStripLabel()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPpal
        '
        Me.MenuPpal.BackColor = System.Drawing.Color.White
        Me.MenuPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPpal.Name = "MenuPpal"
        Me.MenuPpal.Size = New System.Drawing.Size(640, 24)
        Me.MenuPpal.TabIndex = 2
        Me.MenuPpal.Text = "MenuStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_hora, Me.lbl_fecha, Me.lbl_usuario})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 658)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(640, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbl_hora
        '
        Me.lbl_hora.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.White
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(102, 22)
        Me.lbl_hora.Text = "ToolStripLabel1"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.White
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(103, 22)
        Me.lbl_fecha.Text = "ToolStripLabel2"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(102, 22)
        Me.lbl_usuario.Text = "ToolStripLabel1"
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.BackColor = System.Drawing.Color.Black
        Me.lbl_perfil.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_perfil.ForeColor = System.Drawing.Color.White
        Me.lbl_perfil.Location = New System.Drawing.Point(5, 661)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(139, 18)
        Me.lbl_perfil.TabIndex = 11
        Me.lbl_perfil.Text = "Gerente Comercial"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_mesero_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Principal.My.Resources.Resources.fondo_mesero_tablet
        Me.ClientSize = New System.Drawing.Size(640, 683)
        Me.Controls.Add(Me.MenuPpal)
        Me.Controls.Add(Me.lbl_perfil)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frm_mesero_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPpal As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lbl_hora As ToolStripLabel
    Friend WithEvents lbl_fecha As ToolStripLabel
    Friend WithEvents lbl_usuario As ToolStripLabel
    Friend WithEvents lbl_perfil As Label
    Friend WithEvents Timer1 As Timer
End Class
