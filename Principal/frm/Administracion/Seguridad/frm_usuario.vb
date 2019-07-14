Public Class frm_usuario

    Private id_usuario As Integer = 0
    Private clave_encri As String

    Function CargarListaPerfiles() As Boolean
        Try
            CargarListaPerfiles = False

            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select per_id, per_nombre from seg_perfil where per_estado ='A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                Dim dt As New DataTable
                dt.Load(dr)
                cbo_perfil.DataSource = dt
                cbo_perfil.DisplayMember = "per_nombre"
                cbo_perfil.ValueMember = "per_id"
                CargarListaPerfiles = True
            Else
                CargarListaPerfiles = False
            End If

        Catch ex As Exception
            CargarListaPerfiles = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Function CargarComboSexo() As Boolean
        Try
            CargarComboSexo = False

            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from sexo where sex_estado = 'A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                Dim dt As New DataTable
                dt.Load(dr)
                cmb_sexo.DataSource = dt
                cmb_sexo.DisplayMember = "sex_descripcion"
                cmb_sexo.ValueMember = "sex_id"
                CargarComboSexo = True
            Else
                CargarComboSexo = False
            End If

        Catch ex As Exception
            CargarComboSexo = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Function fun_validardatos() As Boolean
        Try
            fun_validardatos = False

            If (txt_cedula.Text = String.Empty) Then
                MsgBox("Ingrese una cedula ", MsgBoxStyle.Information, "Cedula")
                txt_cedula.Focus()
                Exit Function
            End If

            If chk_validar.Checked = True Then
                If fun_validacedula(txt_cedula.Text) = False Then
                    MsgBox("N�mero de cédula incorrecto", MsgBoxStyle.Exclamation)
                    Exit Function
                End If
            End If
            If txt_nombres.Text = String.Empty Then
                MsgBox("Ingrese el nombre del usuario", MsgBoxStyle.Exclamation)
                txt_nombres.Focus()
                Exit Function
            End If
            If txt_apellidos.Text = String.Empty Then
                MsgBox("Ingrese el apellido del usuario", MsgBoxStyle.Exclamation)
                txt_apellidos.Focus()
                Exit Function
            End If
            If txt_usuario.Text = String.Empty Then
                MsgBox("Ingrese el nombre del usuario", MsgBoxStyle.Exclamation)
                txt_usuario.Focus()
                Exit Function
            End If

            If txt_clave.Text = String.Empty Then
                MsgBox("Ingrese la clave del usuario", MsgBoxStyle.Critical, "Error en la clave")
                txt_clave.Focus()
                Exit Function
            End If

            If (ExisteDato(txt_cedula.Text, "usu_cedula")) = True Then
                MsgBox("La cedula ya se encuentra registrada", MsgBoxStyle.Exclamation, "Cedula Existente")
                txt_cedula.Text = ""
                txt_cedula.Focus()
                Exit Function
            End If

            If ExisteDato(txt_usuario.Text, "usu_usuario") = True Then
                MsgBox("El nombre del usuario ya existe", MsgBoxStyle.Exclamation, "Ingresar otro usuario")
                txt_usuario.Text = ""
                txt_usuario.Focus()
                Exit Function
            End If

            If txt_clave.Text = String.Empty Then
                MsgBox("Ingrese el nombre la clave", MsgBoxStyle.Exclamation)
                txt_clave.Focus()
                Exit Function
            End If

            If txt_correo.Text <> String.Empty Then
                If validar_Mail(LCase(txt_correo.Text)) = False Then
                    MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " &
                    " por favor seleccione un correo valido", "Validación de     correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_correo.Focus()
                    Exit Function
                End If
            End If
            fun_validardatos = True
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_validardatos = False
        End Try

    End Function

    Private Function ExisteDato(dato As String, campo As String) As Boolean
        Try
            Dim aux_campo As String = ""
            Dim str_cadena_sql As String = "select * from seg_Usuarios where " & campo & " =  '" & dato & "'"

            '1.- Conectar a la bd
            If (Conectar() = False) Then
                Exit Function
            End If

            '2.- Hacer la tarea dentro de la bd 
            dr = Execute_reader(str_cadena_sql)

            If (dr.HasRows) Then  'Si trae filas
                While (dr.Read)
                    aux_campo = dr(campo)
                End While
            End If

            If (aux_campo = "") Then
                Return False
            ElseIf (aux_campo = dato) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function fun_grabar() As Boolean

        Try
            fun_grabar = False

            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_insertar_actualizar_usuario", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@usu_Id", id_usuario)
            cmd.Parameters.AddWithValue("@per_Id", cbo_perfil.SelectedValue)
            cmd.Parameters.AddWithValue("@usu_cedula", txt_cedula.Text)
            cmd.Parameters.AddWithValue("@usu_nombres", txt_nombres.Text)
            cmd.Parameters.AddWithValue("@usu_apellidos", txt_apellidos.Text)
            cmd.Parameters.AddWithValue("@sex_id", cmb_sexo.SelectedValue)
            cmd.Parameters.AddWithValue("@usu_direccion", txt_direccion.Text)
            cmd.Parameters.AddWithValue("@usu_telefono", txt_telefono.Text)
            cmd.Parameters.AddWithValue("@usu_email", txt_correo.Text)
            cmd.Parameters.AddWithValue("@usu_usuario", txt_usuario.Text)
            cmd.Parameters.AddWithValue("@usu_clave", clave_encri)

            Dim mi_foto As Byte()
            mi_foto = ImageToByteArray(pb_foto.Image)
            cmd.Parameters.AddWithValue("@usu_foto", System.Data.SqlDbType.Image).Value = mi_foto

            cmd.Parameters.AddWithValue("@usu_estado", "A")
            cmd.ExecuteNonQuery()
            fun_grabar = True

        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function recuperaUsuario(cedula As String) As Boolean
        Try
            recuperaUsuario = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from seg_Usuarios where usu_cedula = '" & cedula & "' "

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    ' MsgBox("Dentro del while")
                    id_usuario = dr("usu_id")
                    cbo_perfil.SelectedValue = dr("per_id")
                    txt_nombres.Text = dr("usu_nombres")
                    txt_apellidos.Text = dr("usu_apellidos")
                    txt_direccion.Text = dr("usu_direccion")
                    txt_telefono.Text = dr("usu_telefono")
                    txt_correo.Text = IIf(dr("usu_email") Is DBNull.Value, "", dr("usu_email"))
                    txt_usuario.Text = dr("usu_usuario")
                    txt_clave.Text = dr("usu_clave")
                    cmb_sexo.SelectedValue = dr("sex_id")

                    'Falta la foto'
                    If (dr("usu_foto") IsNot DBNull.Value) Then
                        pb_foto.Image = ByteArrayToImage(DirectCast(dr("usu_foto"), Byte()))
                    Else
                        pb_foto.Image = My.Resources.usuario
                    End If

                End While
                recuperaUsuario = True
            End If

        Catch ex As Exception
            recuperaUsuario = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub Limpiar()
        txt_cedula.Text = ""
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_correo.Text = ""
        txt_usuario.Text = ""
        txt_clave.Text = ""
        txt_cedula.Focus()
        id_usuario = 0
    End Sub

    Private Sub frm_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            chk_validar.Checked = True
            clave_encri = ""

            'pb_foto.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "image-default.png")
            pb_foto.Image = My.Resources.usuario

            If (CargarComboSexo() = False) Then
                MsgBox("No se pudo cargar el combo sexo", MsgBoxStyle.Critical, "Error al cargar")
                Exit Sub
            End If

            If (CargarListaPerfiles() = False) Then
                MsgBox("No se pudo cargar los perfiles")
                Exit Sub
            Else
                If (g_str_cedula <> "") Then
                    txt_cedula.Text = g_str_cedula
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

        Try
            chk_validar.Checked = True

            Limpiar()
            txt_cedula.Text = ""
            id_usuario = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If (fun_validardatos() = False) Then
                Exit Sub
            End If

            txt_clave_Leave(Me, New KeyPressEventArgs(ChrW(Keys.End)))

            'Proceso para grabar
            If (fun_grabar()) Then
                MsgBox("Datos registrados correctamente", MsgBoxStyle.Information)
            Else
                MsgBox("La operacion se realizo con exito")
            End If

            Limpiar()
            clave_encri = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                If (recuperaUsuario(txt_cedula.Text) = False) Then
                    MsgBox("El usuario no existe", MsgBoxStyle.Information)
                    Limpiar()
                    txt_cedula.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Try
            Dim archivo As New OpenFileDialog

            archivo.Filter = "Archivo JPG|*.jpg"

            If (archivo.ShowDialog = DialogResult.OK) Then
                pb_foto.Image = Image.FromFile(archivo.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_clave_Leave(sender As Object, e As EventArgs) Handles txt_clave.Leave
        clave_encri = ""

        If (txt_clave.Text.Length < 12) Then
            If (txt_clave.Text <> "") Then
                If (Len(txt_clave.Text) > 3 And Len(txt_clave.Text) < 10) Then
                    'MsgBox("longitud permitida")
                    clave_encri = Encriptar(txt_clave.Text)
                Else
                    MsgBox("La clave debe tener de 4 a 10 caracteres")
                    txt_clave.Focus()
                End If
            End If
        Else
            clave_encri = txt_clave.Text
        End If
    End Sub

    Private Sub btn_buscausuario_Click(sender As Object, e As EventArgs) Handles btn_buscausuario.Click
        Try
            g_str_cedula = ""

            Dim frm As New frm_buscar_usuario
            frm.ShowDialog()

            txt_cedula.Text = g_str_cedula

            If (txt_cedula.Text <> "") Then
                txt_cedula_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            Else
                If (recuperaUsuario(txt_cedula.Text) = False) Then
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If (txt_cedula.Text = String.Empty) Then
                MsgBox("Digite una cedula para eliminar un usuario", MsgBoxStyle.Information, "Cedula")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar a " & txt_nombres.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then

                If (EliminarDatos("sp_eliminar_usuario", "@usu_Id", id_usuario)) Then
                    MsgBox("Usuario eliminado ", MsgBoxStyle.Information, "Registro eliminado")
                    Limpiar()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_usuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        g_str_cedula = ""
    End Sub
End Class