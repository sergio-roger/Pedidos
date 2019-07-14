<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modalidad_aux
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.per_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_empieza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_termina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_hora_termina = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_hora_empieza = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(136, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 31)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Módulo de Modalidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_datos)
        Me.GroupBox1.Controls.Add(Me.date_hora_termina)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.date_hora_empieza)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 276)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.per_Id, Me.per_nombre, Me.col_empieza, Me.col_termina, Me.per_estado})
        Me.dgv_datos.Location = New System.Drawing.Point(18, 112)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.ReadOnly = True
        Me.dgv_datos.Size = New System.Drawing.Size(431, 150)
        Me.dgv_datos.TabIndex = 40
        '
        'per_Id
        '
        Me.per_Id.HeaderText = "Codigo"
        Me.per_Id.Name = "per_Id"
        Me.per_Id.ReadOnly = True
        Me.per_Id.Width = 67
        '
        'per_nombre
        '
        Me.per_nombre.HeaderText = "Descripcion"
        Me.per_nombre.Name = "per_nombre"
        Me.per_nombre.ReadOnly = True
        Me.per_nombre.Width = 152
        '
        'col_empieza
        '
        Me.col_empieza.HeaderText = "Empieza"
        Me.col_empieza.Name = "col_empieza"
        Me.col_empieza.ReadOnly = True
        '
        'col_termina
        '
        Me.col_termina.HeaderText = "Termina"
        Me.col_termina.Name = "col_termina"
        Me.col_termina.ReadOnly = True
        '
        'per_estado
        '
        Me.per_estado.HeaderText = "Estado"
        Me.per_estado.Name = "per_estado"
        Me.per_estado.ReadOnly = True
        Me.per_estado.Width = 50
        '
        'date_hora_termina
        '
        Me.date_hora_termina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_hora_termina.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.date_hora_termina.Location = New System.Drawing.Point(306, 72)
        Me.date_hora_termina.Name = "date_hora_termina"
        Me.date_hora_termina.ShowUpDown = True
        Me.date_hora_termina.Size = New System.Drawing.Size(143, 26)
        Me.date_hora_termina.TabIndex = 39
        Me.date_hora_termina.Value = New Date(2019, 6, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "*  Hora Termina"
        '
        'date_hora_empieza
        '
        Me.date_hora_empieza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_hora_empieza.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.date_hora_empieza.Location = New System.Drawing.Point(21, 72)
        Me.date_hora_empieza.Name = "date_hora_empieza"
        Me.date_hora_empieza.ShowUpDown = True
        Me.date_hora_empieza.Size = New System.Drawing.Size(143, 26)
        Me.date_hora_empieza.TabIndex = 37
        Me.date_hora_empieza.Value = New Date(2019, 6, 21, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "*  Hora Empieza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "*  Descripcion"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(134, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(315, 22)
        Me.txt_descripcion.TabIndex = 34
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Tomato
        Me.btn_eliminar.BackgroundImage = Global.Principal.My.Resources.Resources.boton_borrar_n
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Location = New System.Drawing.Point(510, 220)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(90, 50)
        Me.btn_eliminar.TabIndex = 35
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_grabar.BackgroundImage = Global.Principal.My.Resources.Resources.boton_guardar_n
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(510, 140)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(90, 50)
        Me.btn_grabar.TabIndex = 34
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_nuevo.BackgroundImage = Global.Principal.My.Resources.Resources.boton_nuevo_n
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(510, 68)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(90, 50)
        Me.btn_nuevo.TabIndex = 33
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'frm_modalidad_aux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(637, 361)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_modalidad_aux"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_modalidad_aux"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_datos As DataGridView
    Friend WithEvents per_Id As DataGridViewTextBoxColumn
    Friend WithEvents per_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_empieza As DataGridViewTextBoxColumn
    Friend WithEvents col_termina As DataGridViewTextBoxColumn
    Friend WithEvents per_estado As DataGridViewTextBoxColumn
    Friend WithEvents date_hora_termina As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents date_hora_empieza As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
End Class
