<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido
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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_mesa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.rdb_combo = New System.Windows.Forms.RadioButton()
        Me.rdb_plato = New System.Windows.Forms.RadioButton()
        Me.btn_buscar_p = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgv_pedido = New System.Windows.Forms.DataGridView()
        Me.col_check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_codigo_pedido = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.txt_id_aux = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(18, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 25)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Módulo de Pedidos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 71)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(17, 38)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(166, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_mesa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 71)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "*  Mesa"
        '
        'cmb_mesa
        '
        Me.cmb_mesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mesa.FormattingEnabled = True
        Me.cmb_mesa.Location = New System.Drawing.Point(8, 34)
        Me.cmb_mesa.Name = "cmb_mesa"
        Me.cmb_mesa.Size = New System.Drawing.Size(133, 24)
        Me.cmb_mesa.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Mesa"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_add)
        Me.GroupBox4.Controls.Add(Me.rdb_combo)
        Me.GroupBox4.Controls.Add(Me.rdb_plato)
        Me.GroupBox4.Controls.Add(Me.btn_buscar_p)
        Me.GroupBox4.Controls.Add(Me.txt_precio)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txt_cantidad)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_descripcion)
        Me.GroupBox4.Controls.Add(Me.txt_codigo)
        Me.GroupBox4.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(11, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(498, 112)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Orden"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Brown
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(400, 11)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(90, 36)
        Me.btn_add.TabIndex = 64
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'rdb_combo
        '
        Me.rdb_combo.AutoSize = True
        Me.rdb_combo.Location = New System.Drawing.Point(321, 81)
        Me.rdb_combo.Name = "rdb_combo"
        Me.rdb_combo.Size = New System.Drawing.Size(64, 18)
        Me.rdb_combo.TabIndex = 63
        Me.rdb_combo.TabStop = True
        Me.rdb_combo.Text = "Combos"
        Me.rdb_combo.UseVisualStyleBackColor = True
        '
        'rdb_plato
        '
        Me.rdb_plato.AutoSize = True
        Me.rdb_plato.Location = New System.Drawing.Point(321, 36)
        Me.rdb_plato.Name = "rdb_plato"
        Me.rdb_plato.Size = New System.Drawing.Size(53, 18)
        Me.rdb_plato.TabIndex = 62
        Me.rdb_plato.TabStop = True
        Me.rdb_plato.Text = "Plato"
        Me.rdb_plato.UseVisualStyleBackColor = True
        '
        'btn_buscar_p
        '
        Me.btn_buscar_p.BackgroundImage = Global.Principal.My.Resources.Resources.boton_buscar
        Me.btn_buscar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar_p.Location = New System.Drawing.Point(400, 54)
        Me.btn_buscar_p.Name = "btn_buscar_p"
        Me.btn_buscar_p.Size = New System.Drawing.Size(90, 50)
        Me.btn_buscar_p.TabIndex = 55
        Me.btn_buscar_p.UseVisualStyleBackColor = True
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(203, 33)
        Me.txt_precio.Mask = "00.00"
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 22)
        Me.txt_precio.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(205, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(205, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Precio"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(203, 79)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(101, 22)
        Me.txt_cantidad.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descripcion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Codigo"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(11, 78)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(167, 22)
        Me.txt_descripcion.TabIndex = 55
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(11, 33)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(167, 22)
        Me.txt_codigo.TabIndex = 55
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.cmb_estado)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(360, 84)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(149, 71)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "*  ESTADO"
        '
        'cmb_estado
        '
        Me.cmb_estado.BackColor = System.Drawing.Color.Black
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.Enabled = False
        Me.cmb_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_estado.ForeColor = System.Drawing.Color.White
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(8, 34)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(133, 24)
        Me.cmb_estado.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Mesa"
        '
        'dgv_pedido
        '
        Me.dgv_pedido.AllowUserToAddRows = False
        Me.dgv_pedido.AllowUserToDeleteRows = False
        Me.dgv_pedido.BackgroundColor = System.Drawing.Color.Black
        Me.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_check, Me.col_id, Me.col_codigo, Me.col_pedido, Me.col_tipo, Me.col_cantidad, Me.col_precio, Me.col_descuento, Me.col_porcentaje, Me.col_subtotal, Me.col_total})
        Me.dgv_pedido.GridColor = System.Drawing.Color.White
        Me.dgv_pedido.Location = New System.Drawing.Point(12, 391)
        Me.dgv_pedido.Name = "dgv_pedido"
        Me.dgv_pedido.Size = New System.Drawing.Size(498, 165)
        Me.dgv_pedido.TabIndex = 52
        '
        'col_check
        '
        Me.col_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.col_check.HeaderText = "Eliminar"
        Me.col_check.Name = "col_check"
        Me.col_check.Visible = False
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        '
        'col_codigo
        '
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Width = 70
        '
        'col_pedido
        '
        Me.col_pedido.HeaderText = "Pedido"
        Me.col_pedido.Name = "col_pedido"
        Me.col_pedido.Width = 170
        '
        'col_tipo
        '
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.Name = "col_tipo"
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio U"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.Width = 60
        '
        'col_descuento
        '
        Me.col_descuento.HeaderText = "Descuento"
        Me.col_descuento.Name = "col_descuento"
        '
        'col_porcentaje
        '
        Me.col_porcentaje.HeaderText = "Porcentaje"
        Me.col_porcentaje.Name = "col_porcentaje"
        '
        'col_subtotal
        '
        Me.col_subtotal.HeaderText = "Subtotal"
        Me.col_subtotal.Name = "col_subtotal"
        '
        'col_total
        '
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_nuevo.BackgroundImage = Global.Principal.My.Resources.Resources.nuevo_50_45
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Location = New System.Drawing.Point(344, 5)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(50, 45)
        Me.btn_nuevo.TabIndex = 55
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_grabar.BackgroundImage = Global.Principal.My.Resources.Resources.grabar_50_45
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.Location = New System.Drawing.Point(400, 5)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(50, 45)
        Me.btn_grabar.TabIndex = 54
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.Color.Tomato
        Me.btn_borrar.BackgroundImage = Global.Principal.My.Resources.Resources.borrar_50_45
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar.Location = New System.Drawing.Point(456, 5)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(50, 45)
        Me.btn_borrar.TabIndex = 53
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_nuevo)
        Me.Panel1.Controls.Add(Me.btn_borrar)
        Me.Panel1.Controls.Add(Me.btn_grabar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 55)
        Me.Panel1.TabIndex = 56
        '
        'txt_codigo_pedido
        '
        Me.txt_codigo_pedido.Location = New System.Drawing.Point(90, 63)
        Me.txt_codigo_pedido.Name = "txt_codigo_pedido"
        Me.txt_codigo_pedido.ReadOnly = True
        Me.txt_codigo_pedido.Size = New System.Drawing.Size(110, 20)
        Me.txt_codigo_pedido.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Código"
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(293, 63)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(100, 20)
        Me.txt_descuento.TabIndex = 57
        Me.txt_descuento.Visible = False
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.Location = New System.Drawing.Point(405, 63)
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.Size = New System.Drawing.Size(100, 20)
        Me.txt_porcentaje.TabIndex = 58
        Me.txt_porcentaje.Visible = False
        '
        'txt_id_aux
        '
        Me.txt_id_aux.Location = New System.Drawing.Point(219, 63)
        Me.txt_id_aux.Name = "txt_id_aux"
        Me.txt_id_aux.Size = New System.Drawing.Size(65, 20)
        Me.txt_id_aux.TabIndex = 59
        Me.txt_id_aux.Visible = False
        '
        'frm_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(524, 566)
        Me.Controls.Add(Me.txt_id_aux)
        Me.Controls.Add(Me.txt_porcentaje)
        Me.Controls.Add(Me.txt_descuento)
        Me.Controls.Add(Me.txt_codigo_pedido)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_pedido)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_mesa As ComboBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_estado As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_buscar_p As Button
    Friend WithEvents rdb_combo As RadioButton
    Friend WithEvents rdb_plato As RadioButton
    Friend WithEvents dgv_pedido As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_codigo_pedido As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_porcentaje As TextBox
    Friend WithEvents txt_id_aux As TextBox
    Friend WithEvents col_check As DataGridViewCheckBoxColumn
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_codigo As DataGridViewTextBoxColumn
    Friend WithEvents col_pedido As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents col_descuento As DataGridViewTextBoxColumn
    Friend WithEvents col_porcentaje As DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
End Class
