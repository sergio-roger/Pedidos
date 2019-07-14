<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_combo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel_descuento = New System.Windows.Forms.GroupBox()
        Me.lbl_porcentaje = New System.Windows.Forms.Label()
        Me.txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_descuento = New System.Windows.Forms.CheckBox()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_imagen = New System.Windows.Forms.Button()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.txt_bebida = New System.Windows.Forms.TextBox()
        Me.labellll = New System.Windows.Forms.Label()
        Me.txt_contenido3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_contenido2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_contenido1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_modalidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_buscaPCombo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.panel_descuento.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.panel_descuento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chk_descuento)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_imagen)
        Me.GroupBox1.Controls.Add(Me.pb_foto)
        Me.GroupBox1.Controls.Add(Me.txt_bebida)
        Me.GroupBox1.Controls.Add(Me.labellll)
        Me.GroupBox1.Controls.Add(Me.txt_contenido3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_contenido2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_contenido1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_modalidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(130, 19)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(136, 22)
        Me.txt_codigo.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "* Código"
        '
        'panel_descuento
        '
        Me.panel_descuento.BackColor = System.Drawing.Color.White
        Me.panel_descuento.Controls.Add(Me.lbl_porcentaje)
        Me.panel_descuento.Controls.Add(Me.txt_porcentaje)
        Me.panel_descuento.Location = New System.Drawing.Point(363, 100)
        Me.panel_descuento.Name = "panel_descuento"
        Me.panel_descuento.Size = New System.Drawing.Size(185, 58)
        Me.panel_descuento.TabIndex = 60
        Me.panel_descuento.TabStop = False
        '
        'lbl_porcentaje
        '
        Me.lbl_porcentaje.AutoSize = True
        Me.lbl_porcentaje.BackColor = System.Drawing.Color.White
        Me.lbl_porcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_porcentaje.ForeColor = System.Drawing.Color.Black
        Me.lbl_porcentaje.Location = New System.Drawing.Point(2, 21)
        Me.lbl_porcentaje.Name = "lbl_porcentaje"
        Me.lbl_porcentaje.Size = New System.Drawing.Size(89, 13)
        Me.lbl_porcentaje.TabIndex = 61
        Me.lbl_porcentaje.Text = "  Porcentaje %"
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_porcentaje.Location = New System.Drawing.Point(106, 16)
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.ReadOnly = True
        Me.txt_porcentaje.Size = New System.Drawing.Size(67, 22)
        Me.txt_porcentaje.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(365, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "  Descuento"
        '
        'chk_descuento
        '
        Me.chk_descuento.AutoSize = True
        Me.chk_descuento.Location = New System.Drawing.Point(521, 83)
        Me.chk_descuento.Name = "chk_descuento"
        Me.chk_descuento.Size = New System.Drawing.Size(15, 14)
        Me.chk_descuento.TabIndex = 58
        Me.chk_descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_descuento.UseVisualStyleBackColor = True
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(436, 50)
        Me.txt_precio.Mask = "00.00"
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 22)
        Me.txt_precio.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(365, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "* Precio"
        '
        'btn_imagen
        '
        Me.btn_imagen.BackColor = System.Drawing.Color.Black
        Me.btn_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_imagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imagen.ForeColor = System.Drawing.Color.White
        Me.btn_imagen.Location = New System.Drawing.Point(130, 374)
        Me.btn_imagen.Name = "btn_imagen"
        Me.btn_imagen.Size = New System.Drawing.Size(315, 40)
        Me.btn_imagen.TabIndex = 55
        Me.btn_imagen.Text = "Seleccionar Imagen"
        Me.btn_imagen.UseVisualStyleBackColor = False
        '
        'pb_foto
        '
        Me.pb_foto.Image = Global.Principal.My.Resources.Resources.default_image
        Me.pb_foto.Location = New System.Drawing.Point(130, 181)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(315, 180)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto.TabIndex = 54
        Me.pb_foto.TabStop = False
        '
        'txt_bebida
        '
        Me.txt_bebida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bebida.Location = New System.Drawing.Point(130, 139)
        Me.txt_bebida.Name = "txt_bebida"
        Me.txt_bebida.Size = New System.Drawing.Size(204, 22)
        Me.txt_bebida.TabIndex = 53
        '
        'labellll
        '
        Me.labellll.AutoSize = True
        Me.labellll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labellll.Location = New System.Drawing.Point(13, 145)
        Me.labellll.Name = "labellll"
        Me.labellll.Size = New System.Drawing.Size(61, 13)
        Me.labellll.TabIndex = 52
        Me.labellll.Text = "* Bebidas"
        '
        'txt_contenido3
        '
        Me.txt_contenido3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contenido3.Location = New System.Drawing.Point(130, 109)
        Me.txt_contenido3.Name = "txt_contenido3"
        Me.txt_contenido3.Size = New System.Drawing.Size(204, 22)
        Me.txt_contenido3.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "  Contenido 3"
        '
        'txt_contenido2
        '
        Me.txt_contenido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contenido2.Location = New System.Drawing.Point(130, 79)
        Me.txt_contenido2.Name = "txt_contenido2"
        Me.txt_contenido2.Size = New System.Drawing.Size(204, 22)
        Me.txt_contenido2.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "* Contenido 2"
        '
        'txt_contenido1
        '
        Me.txt_contenido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contenido1.Location = New System.Drawing.Point(130, 49)
        Me.txt_contenido1.Name = "txt_contenido1"
        Me.txt_contenido1.Size = New System.Drawing.Size(204, 22)
        Me.txt_contenido1.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "* Contenido 1"
        '
        'cmb_modalidad
        '
        Me.cmb_modalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_modalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_modalidad.FormattingEnabled = True
        Me.cmb_modalidad.Location = New System.Drawing.Point(363, 14)
        Me.cmb_modalidad.Name = "cmb_modalidad"
        Me.cmb_modalidad.Size = New System.Drawing.Size(173, 24)
        Me.cmb_modalidad.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "* Modalidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(230, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(263, 31)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Módulo de Combos"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Tomato
        Me.btn_eliminar.BackgroundImage = Global.Principal.My.Resources.Resources.boton_borrar_n
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Location = New System.Drawing.Point(601, 278)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(90, 50)
        Me.btn_eliminar.TabIndex = 42
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_nuevo.BackgroundImage = Global.Principal.My.Resources.Resources.boton_nuevo_n
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(601, 137)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(90, 50)
        Me.btn_nuevo.TabIndex = 43
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_grabar.BackgroundImage = Global.Principal.My.Resources.Resources.boton_guardar_n
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(601, 206)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(90, 50)
        Me.btn_grabar.TabIndex = 41
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_buscaPCombo
        '
        Me.btn_buscaPCombo.BackgroundImage = Global.Principal.My.Resources.Resources.boton_buscar
        Me.btn_buscaPCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscaPCombo.Location = New System.Drawing.Point(601, 68)
        Me.btn_buscaPCombo.Name = "btn_buscaPCombo"
        Me.btn_buscaPCombo.Size = New System.Drawing.Size(90, 50)
        Me.btn_buscaPCombo.TabIndex = 44
        Me.btn_buscaPCombo.UseVisualStyleBackColor = True
        '
        'frm_combo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(717, 507)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_buscaPCombo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_combo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel_descuento.ResumeLayout(False)
        Me.panel_descuento.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_modalidad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_contenido3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_contenido2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_contenido1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_bebida As TextBox
    Friend WithEvents labellll As Label
    Friend WithEvents btn_imagen As Button
    Friend WithEvents pb_foto As PictureBox
    Friend WithEvents panel_descuento As GroupBox
    Friend WithEvents lbl_porcentaje As Label
    Friend WithEvents txt_porcentaje As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chk_descuento As CheckBox
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_buscaPCombo As Button
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label5 As Label
End Class
