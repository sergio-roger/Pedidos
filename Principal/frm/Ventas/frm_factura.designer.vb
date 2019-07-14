<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_factura
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_cambio = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_total_pagar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_total_unidades = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.msk_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscarClientes = New System.Windows.Forms.Button()
        Me.chk_consumidor = New System.Windows.Forms.CheckBox()
        Me.chk_validar = New System.Windows.Forms.CheckBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_num_fac = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pb_imagen = New System.Windows.Forms.PictureBox()
        Me.txt_id_producto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_aplica_iva = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_baseCero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cantp = New System.Windows.Forms.TextBox()
        Me.txt_Descripción = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_stockp = New System.Windows.Forms.TextBox()
        Me.btn_buscarProducto = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_eli = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aplica_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Controls.Add(Me.txt_cambio)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txt_efectivo)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txt_total_pagar)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txt_total_unidades)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1020, 67)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        '
        'txt_cambio
        '
        Me.txt_cambio.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txt_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cambio.Location = New System.Drawing.Point(870, 13)
        Me.txt_cambio.Name = "txt_cambio"
        Me.txt_cambio.ReadOnly = True
        Me.txt_cambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_cambio.Size = New System.Drawing.Size(142, 47)
        Me.txt_cambio.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(804, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "CAMBIO $:"
        '
        'txt_efectivo
        '
        Me.txt_efectivo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo.Location = New System.Drawing.Point(636, 13)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_efectivo.Size = New System.Drawing.Size(162, 47)
        Me.txt_efectivo.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(550, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "EFECTIVO $:"
        '
        'txt_total_pagar
        '
        Me.txt_total_pagar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_total_pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_pagar.Location = New System.Drawing.Point(363, 13)
        Me.txt_total_pagar.Name = "txt_total_pagar"
        Me.txt_total_pagar.ReadOnly = True
        Me.txt_total_pagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total_pagar.Size = New System.Drawing.Size(181, 47)
        Me.txt_total_pagar.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(230, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "TOTAL POR PAGAR:"
        '
        'txt_total_unidades
        '
        Me.txt_total_unidades.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_total_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_unidades.Location = New System.Drawing.Point(128, 13)
        Me.txt_total_unidades.Name = "txt_total_unidades"
        Me.txt_total_unidades.ReadOnly = True
        Me.txt_total_unidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total_unidades.Size = New System.Drawing.Size(96, 47)
        Me.txt_total_unidades.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "TOTAL UNIDADES:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txt_correo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.msk_fecha)
        Me.GroupBox1.Controls.Add(Me.btn_buscarClientes)
        Me.GroupBox1.Controls.Add(Me.chk_consumidor)
        Me.GroupBox1.Controls.Add(Me.chk_validar)
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_ruc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_num_fac)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 151)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(533, 88)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(155, 20)
        Me.txt_correo.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(468, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Correo:"
        '
        'msk_fecha
        '
        Me.msk_fecha.Location = New System.Drawing.Point(780, 15)
        Me.msk_fecha.Mask = "##/##/####"
        Me.msk_fecha.Name = "msk_fecha"
        Me.msk_fecha.Size = New System.Drawing.Size(69, 20)
        Me.msk_fecha.TabIndex = 26
        '
        'btn_buscarClientes
        '
        Me.btn_buscarClientes.Location = New System.Drawing.Point(247, 35)
        Me.btn_buscarClientes.Name = "btn_buscarClientes"
        Me.btn_buscarClientes.Size = New System.Drawing.Size(38, 24)
        Me.btn_buscarClientes.TabIndex = 25
        Me.btn_buscarClientes.UseVisualStyleBackColor = True
        '
        'chk_consumidor
        '
        Me.chk_consumidor.AutoSize = True
        Me.chk_consumidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_consumidor.Location = New System.Drawing.Point(368, 40)
        Me.chk_consumidor.Name = "chk_consumidor"
        Me.chk_consumidor.Size = New System.Drawing.Size(122, 17)
        Me.chk_consumidor.TabIndex = 24
        Me.chk_consumidor.Text = "Consumidor Final"
        Me.chk_consumidor.UseVisualStyleBackColor = True
        '
        'chk_validar
        '
        Me.chk_validar.AutoSize = True
        Me.chk_validar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_validar.Location = New System.Drawing.Point(297, 39)
        Me.chk_validar.Name = "chk_validar"
        Me.chk_validar.Size = New System.Drawing.Size(65, 17)
        Me.chk_validar.TabIndex = 21
        Me.chk_validar.Text = "Validar"
        Me.chk_validar.UseVisualStyleBackColor = True
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_estado.Location = New System.Drawing.Point(888, 14)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(112, 17)
        Me.chk_estado.TabIndex = 21
        Me.chk_estado.Text = "Estado Factura"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(102, 112)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(339, 32)
        Me.txt_direccion.TabIndex = 5
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(102, 85)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(339, 20)
        Me.txt_apellidos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellidos:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(531, 62)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(155, 20)
        Me.txt_telefono.TabIndex = 6
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(102, 62)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(339, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nombre:"
        '
        'txt_ruc
        '
        Me.txt_ruc.Location = New System.Drawing.Point(102, 39)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(139, 20)
        Me.txt_ruc.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(701, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dirección:"
        '
        'txt_num_fac
        '
        Me.txt_num_fac.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_num_fac.Location = New System.Drawing.Point(102, 14)
        Me.txt_num_fac.Name = "txt_num_fac"
        Me.txt_num_fac.Size = New System.Drawing.Size(139, 20)
        Me.txt_num_fac.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(466, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ruc/ci:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num fac."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.pb_imagen)
        Me.GroupBox2.Controls.Add(Me.txt_id_producto)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txt_aplica_iva)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btn_eli)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1020, 410)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'pb_imagen
        '
        Me.pb_imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_imagen.Location = New System.Drawing.Point(794, 74)
        Me.pb_imagen.Name = "pb_imagen"
        Me.pb_imagen.Size = New System.Drawing.Size(205, 197)
        Me.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_imagen.TabIndex = 34
        Me.pb_imagen.TabStop = False
        '
        'txt_id_producto
        '
        Me.txt_id_producto.Location = New System.Drawing.Point(868, 24)
        Me.txt_id_producto.Name = "txt_id_producto"
        Me.txt_id_producto.ReadOnly = True
        Me.txt_id_producto.Size = New System.Drawing.Size(54, 20)
        Me.txt_id_producto.TabIndex = 33
        Me.txt_id_producto.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(727, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "valor Iva"
        Me.Label23.Visible = False
        '
        'txt_aplica_iva
        '
        Me.txt_aplica_iva.Location = New System.Drawing.Point(791, 28)
        Me.txt_aplica_iva.Name = "txt_aplica_iva"
        Me.txt_aplica_iva.ReadOnly = True
        Me.txt_aplica_iva.Size = New System.Drawing.Size(54, 20)
        Me.txt_aplica_iva.TabIndex = 31
        Me.txt_aplica_iva.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Controls.Add(Me.btn_imprimir)
        Me.GroupBox4.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox4.Controls.Add(Me.btn_cancelar)
        Me.GroupBox4.Controls.Add(Me.btn_grabar)
        Me.GroupBox4.Location = New System.Drawing.Point(709, 302)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(307, 83)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_imprimir.Location = New System.Drawing.Point(158, 17)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(67, 52)
        Me.btn_imprimir.TabIndex = 33
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Nuevo.Location = New System.Drawing.Point(6, 21)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(73, 52)
        Me.btn_Nuevo.TabIndex = 30
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(231, 17)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(71, 54)
        Me.btn_cancelar.TabIndex = 32
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(85, 19)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(67, 52)
        Me.btn_grabar.TabIndex = 31
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txt_baseCero)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txt_total)
        Me.GroupBox5.Controls.Add(Me.txt_iva)
        Me.GroupBox5.Controls.Add(Me.txt_subtotal)
        Me.GroupBox5.Location = New System.Drawing.Point(513, 277)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(190, 118)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Base Cero:"
        '
        'txt_baseCero
        '
        Me.txt_baseCero.Location = New System.Drawing.Point(83, 40)
        Me.txt_baseCero.Name = "txt_baseCero"
        Me.txt_baseCero.ReadOnly = True
        Me.txt_baseCero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_baseCero.Size = New System.Drawing.Size(91, 20)
        Me.txt_baseCero.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Iva %:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Sub Total:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(83, 92)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total.Size = New System.Drawing.Size(91, 20)
        Me.txt_total.TabIndex = 27
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(83, 66)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.ReadOnly = True
        Me.txt_iva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_iva.Size = New System.Drawing.Size(91, 20)
        Me.txt_iva.TabIndex = 25
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(83, 15)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_subtotal.Size = New System.Drawing.Size(91, 20)
        Me.txt_subtotal.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_cantp)
        Me.GroupBox3.Controls.Add(Me.txt_Descripción)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_precio)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_stockp)
        Me.GroupBox3.Controls.Add(Me.btn_buscarProducto)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_codigo)
        Me.GroupBox3.Controls.Add(Me.btn_add)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(697, 67)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(336, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Cantidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Descripción:"
        '
        'txt_cantp
        '
        Me.txt_cantp.Location = New System.Drawing.Point(400, 15)
        Me.txt_cantp.Name = "txt_cantp"
        Me.txt_cantp.Size = New System.Drawing.Size(54, 20)
        Me.txt_cantp.TabIndex = 10
        '
        'txt_Descripción
        '
        Me.txt_Descripción.Location = New System.Drawing.Point(96, 41)
        Me.txt_Descripción.Name = "txt_Descripción"
        Me.txt_Descripción.ReadOnly = True
        Me.txt_Descripción.Size = New System.Drawing.Size(358, 20)
        Me.txt_Descripción.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(460, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Precio"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(525, 15)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.ReadOnly = True
        Me.txt_precio.Size = New System.Drawing.Size(54, 20)
        Me.txt_precio.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(461, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Stock"
        '
        'txt_stockp
        '
        Me.txt_stockp.Location = New System.Drawing.Point(525, 41)
        Me.txt_stockp.Name = "txt_stockp"
        Me.txt_stockp.ReadOnly = True
        Me.txt_stockp.Size = New System.Drawing.Size(54, 20)
        Me.txt_stockp.TabIndex = 25
        '
        'btn_buscarProducto
        '
        Me.btn_buscarProducto.Location = New System.Drawing.Point(260, 9)
        Me.btn_buscarProducto.Name = "btn_buscarProducto"
        Me.btn_buscarProducto.Size = New System.Drawing.Size(31, 30)
        Me.btn_buscarProducto.TabIndex = 24
        Me.btn_buscarProducto.Text = "?"
        Me.btn_buscarProducto.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Código"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(96, 15)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(157, 20)
        Me.txt_codigo.TabIndex = 9
        '
        'btn_add
        '
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(601, 13)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(79, 48)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Añadir"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_eli
        '
        Me.btn_eli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eli.Location = New System.Drawing.Point(710, 123)
        Me.btn_eli.Name = "btn_eli"
        Me.btn_eli.Size = New System.Drawing.Size(56, 52)
        Me.btn_eli.TabIndex = 3
        Me.btn_eli.Text = "Eliminar"
        Me.btn_eli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eli.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion, Me.Cantidad, Me.precio, Me.subtotal, Me.aplica_iva, Me.iva_pro, Me.total, Me.id_producto})
        Me.dgv.Location = New System.Drawing.Point(8, 96)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(695, 175)
        Me.dgv.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio/u"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'aplica_iva
        '
        Me.aplica_iva.HeaderText = "aplica_iva"
        Me.aplica_iva.Name = "aplica_iva"
        Me.aplica_iva.ReadOnly = True
        '
        'iva_pro
        '
        Me.iva_pro.HeaderText = "iva producto"
        Me.iva_pro.Name = "iva_pro"
        Me.iva_pro.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "ID_PRODUCTO"
        Me.id_producto.Name = "id_producto"
        '
        'frm_facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1049, 638)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_facturar"
        Me.Text = "Facturación"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txt_cambio As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_efectivo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_total_pagar As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_total_unidades As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents msk_fecha As MaskedTextBox
    Friend WithEvents btn_buscarClientes As Button
    Friend WithEvents chk_consumidor As CheckBox
    Friend WithEvents chk_validar As CheckBox
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_apellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_ruc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_num_fac As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pb_imagen As PictureBox
    Friend WithEvents txt_id_producto As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_aplica_iva As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_iva As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_cantp As TextBox
    Friend WithEvents txt_Descripción As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_stockp As TextBox
    Friend WithEvents btn_buscarProducto As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_eli As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_baseCero As TextBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents aplica_iva As DataGridViewTextBoxColumn
    Friend WithEvents iva_pro As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
End Class
