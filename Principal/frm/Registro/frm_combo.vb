Public Class frm_combo

    Private id_combo As Integer

    Function CargarCombo(cadena As String, campo_id As String, campo_llenar As String) As Boolean
        Try
            CargarCombo = False

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(cadena)

            If (dr.HasRows) Then
                Dim dt As New DataTable
                dt.Load(dr)
                cmb_modalidad.DataSource = dt
                cmb_modalidad.DisplayMember = campo_llenar
                cmb_modalidad.ValueMember = campo_id
                CargarCombo = True
            Else
                CargarCombo = False
            End If

        Catch ex As Exception
            CargarCombo = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub btn_imagen_Click(sender As Object, e As EventArgs) Handles btn_imagen.Click
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

    Private Sub Limpiar()
        txt_codigo.Text = ""
        txt_contenido1.Text = ""
        txt_contenido2.Text = ""
        txt_contenido3.Text = ""
        txt_bebida.Text = ""
        txt_precio.Text = ""
        pb_foto.Image = My.Resources.default_image
        panel_descuento.BackColor = Color.White
        lbl_porcentaje.BackColor = Color.White
        lbl_porcentaje.ForeColor = Color.Black
        txt_porcentaje.Text = ""
        chk_descuento.Checked = False
        txt_porcentaje.ReadOnly = False
        id_combo = 0
        txt_codigo.Focus()
    End Sub

    Private Sub Cahnge_desc()
        If (chk_descuento.Checked = True) Then
            panel_descuento.BackColor = Color.Black
            lbl_porcentaje.BackColor = Color.Black
            lbl_porcentaje.ForeColor = Color.White
            txt_porcentaje.ReadOnly = False
            txt_porcentaje.Focus()
        Else
            panel_descuento.BackColor = Color.White
            lbl_porcentaje.BackColor = Color.White
            lbl_porcentaje.ForeColor = Color.Black
            txt_porcentaje.ReadOnly = True
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            ValidarDatos = False

            If (txt_codigo.Text = "") Then
                mensaje("Combo", "Ingrese un código para el combo", "info")
                txt_codigo.Focus()
                Exit Function
            End If

            If (txt_contenido1.Text = "") Then
                mensaje("Combo", "Ingrese un contendio para el combo", "info")
                txt_contenido1.Focus()
                Exit Function
            End If

            If (txt_contenido2.Text = "") Then
                mensaje("Combo", "Ingrese un segundo contendio para el combo", "info")
                txt_contenido2.Focus()
                Exit Function
            End If

            If (txt_bebida.Text = "") Then
                mensaje("Combo", "Ingrese una bebida para el combo", "info")
                txt_bebida.Focus()
                Exit Function
            End If

            If (txt_precio.MaskFull) Then
            Else
                mensaje("Combo", "Format de precio 04,75 ", "alert")
                txt_precio.Focus()
                Exit Function
            End If

            Dim c1 As String = "com_codigo = '" & txt_codigo.Text & "'"
            Dim c2 As String = "com_estado = 'A'"

            If (ExisteDato("Combo", c1, c2, "com_codigo", txt_codigo.Text.Trim) And id_combo = 0) = True Then
                MsgBox("El coódigo ya se encuentra registrado", MsgBoxStyle.Exclamation, "Codigo Existente")
                txt_codigo.Text = ""
                txt_codigo.Focus()
                Exit Function
            End If

            ValidarDatos = True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Grabar() As Boolean
        Try
            Grabar = False

            If (Conectar() = False) Then
                Exit Function
            End If
            Dim desc As Boolean = If(chk_descuento.Checked = True, True, False)

            cmd = New SqlClient.SqlCommand("sp_insertar_actualizar_combo", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@com_id", id_combo)
            cmd.Parameters.AddWithValue("@com_codigo", txt_codigo.Text)
            cmd.Parameters.AddWithValue("@mod_id", cmb_modalidad.SelectedValue)
            cmd.Parameters.AddWithValue("@com_contenido1", txt_contenido1.Text)
            cmd.Parameters.AddWithValue("@com_contenido2", txt_contenido2.Text)
            cmd.Parameters.AddWithValue("@com_contenido3", txt_contenido3.Text)
            cmd.Parameters.AddWithValue("@com_bebida", txt_bebida.Text)

            Dim mi_foto As Byte()
            mi_foto = ImageToByteArray(pb_foto.Image)

            cmd.Parameters.AddWithValue("@com_imagen", System.Data.SqlDbType.Image).Value = mi_foto
            cmd.Parameters.AddWithValue("@com_precio", Double.Parse(txt_precio.Text))
            cmd.Parameters.AddWithValue("@com_posee_descuento", desc)
            cmd.Parameters.AddWithValue("@com_porcentaje_descuento", txt_porcentaje.Text)
            cmd.Parameters.AddWithValue("@com_estado", "A")
            cmd.ExecuteNonQuery()

            Grabar = True

        Catch ex As Exception
            Grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function RecuperarCombo(codigo As String) As Boolean
        Try
            RecuperarCombo = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from Combo where com_estado = 'A' and com_codigo = '" & codigo & "'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    id_combo = dr("com_id")
                    txt_codigo.Text = dr("com_codigo")
                    cmb_modalidad.SelectedValue = dr("mod_id")
                    txt_contenido1.Text = dr("com_contenido1")
                    txt_contenido2.Text = dr("com_contenido2")
                    txt_contenido3.Text = dr("com_contenido3")
                    txt_bebida.Text = dr("com_bebida")

                    'Imagen
                    If (dr("com_imagen") IsNot DBNull.Value) Then
                        pb_foto.Image = ByteArrayToImage(DirectCast(dr("com_imagen"), Byte()))
                    Else
                        pb_foto.Image = My.Resources.default_image
                    End If

                    txt_precio.Text = Agregar_cero(dr("com_precio").ToString())

                    If (dr("com_posee_descuento") = True) Then
                        chk_descuento.Checked = True
                        txt_porcentaje.Text = dr("com_porcentaje_descuento")
                    Else
                        txt_porcentaje.ReadOnly = False
                        txt_porcentaje.Text = ""
                        txt_porcentaje.ReadOnly = True
                        chk_descuento.Checked = False
                    End If
                    chk_descuento_CheckedChanged(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))

                End While
                RecuperarCombo = True
            End If

        Catch ex As Exception
            RecuperarCombo = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub frm_combo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadena As String = "select mod_id, mod_descripcion from Modalidad where mod_estado = 'A'"
            txt_porcentaje.ReadOnly = True

            If (CargarCombo(cadena, "mod_id", "mod_descripcion") = False) Then
                'MsgBox("No se pudo cargar el combo", MsgBoxStyle.Critical, "Platos")
                mensaje("Platos", "No se pudo cargar el combo", "info")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar()
    End Sub

    Private Sub chk_descuento_CheckedChanged(sender As Object, e As EventArgs) Handles chk_descuento.CheckedChanged
        Cahnge_desc()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If (ValidarDatos = False) Then
                Exit Sub
            End If

            'txt_clave_Leave(Me, New KeyPressEventArgs(ChrW(Keys.End)))

            'Proceso para grabar
            If (Grabar()) Then
                If (id_combo = 0) Then
                    mensaje("Registro", "Se guardo correctamente", "info")
                Else
                    mensaje("Actalizar", "Se ha actualizado el Combo", "info")
                End If
            End If
            Limpiar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                If (RecuperarCombo(txt_codigo.Text)) Then
                Else
                    txt_contenido1.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contenido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contenido1.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                txt_contenido2.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contenido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contenido2.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                txt_contenido3.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contenido3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contenido3.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                txt_bebida.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_bebida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bebida.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                btn_imagen.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If (txt_codigo.Text = String.Empty) Then
                mensaje("Combo", "Digite una código para eliminar un Combo", "info")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar a " & txt_codigo.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then

                If (EliminarDatos("sp_eliminar_combo", "@com_id", id_combo)) Then
                    mensaje("Plato", "Combo Eliminado", "info")
                    Limpiar()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscaPCombo_Click(sender As Object, e As EventArgs) Handles btn_buscaPCombo.Click
        Try
            g_str_codigo = ""

            Dim frm As New frm_mantCombo
            frm.ShowDialog()

            txt_codigo.Text = g_str_codigo

            If (txt_codigo.Text <> "") Then
                txt_codigo_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            Else
                If (RecuperarCombo(txt_codigo.Text) = False) Then
                    txt_codigo.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            g_str_codigo = ""
        End Try
    End Sub
End Class