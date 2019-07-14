Public Class frm_plato

    Private id_plato As Integer = 0

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

    Private Function ValidarDatos() As Boolean

        Try
            ValidarDatos = False

            If (txt_codigo.Text = "") Then
                mensaje("Plato", "Ingrese nombre de un pato", "info")
                Exit Function
            End If

            If (txt_precio.MaskFull) Then
            Else
                mensaje("Plato", "Format de precio 04,75 ", "alert")
                txt_precio.Focus()
                Exit Function
            End If

            Dim c1 As String = "men_codigo = '" & txt_codigo.Text & "'"
            Dim c2 As String = "men_estado = 'A'"

            If (ExisteDato("Menu", c1, c2, "men_codigo", txt_codigo.Text.Trim) And id_plato = 0) = True Then
                MsgBox("El código ya se encuentra registrado", MsgBoxStyle.Exclamation, "Codigo Existente")
                txt_codigo.Text = ""
                txt_codigo.Focus()
                Exit Function
            End If

            ValidarDatos = True
        Catch ex As Exception
            ValidarDatos = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function Grabar() As Boolean

        Try
            Grabar = False

            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_insertar_actualizar_plato2", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@men_id", id_plato)
            cmd.Parameters.AddWithValue("@men_codigo", txt_codigo.Text)
            cmd.Parameters.AddWithValue("@men_plato", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@mod_id", cmb_modalidad.SelectedValue)
            cmd.Parameters.AddWithValue("@men_descripcion", txt_descripcion.Text)
            cmd.Parameters.AddWithValue("@men_precio", Double.Parse(txt_precio.Text))

            Dim mi_foto As Byte()
            mi_foto = ImageToByteArray(pb_foto.Image)
            cmd.Parameters.AddWithValue("@men_imagen", System.Data.SqlDbType.Image).Value = mi_foto

            cmd.Parameters.AddWithValue("@men_estado", "A")
            cmd.ExecuteNonQuery()

            Grabar = True

        Catch ex As Exception
            Grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Sub Limpiar()
        txt_nombre.Text = ""
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
        txt_precio.Text = ""
        id_plato = 0
        pb_foto.Image = My.Resources.default_image
        txt_codigo.Focus()
    End Sub

    Private Sub frm_plato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadena As String = "select mod_id, mod_descripcion from Modalidad where mod_estado = 'A'"
            If (CargarCombo(cadena, "mod_id", "mod_descripcion") = False) Then
                'MsgBox("No se pudo cargar el combo", MsgBoxStyle.Critical, "Platos")
                mensaje("Platos", "No se pudo cargar el combo", "info")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If (ValidarDatos = False) Then
                Exit Sub
            End If

            'Proceso para grabar
            If (Grabar()) Then
                If (id_plato = 0) Then
                    mensaje("Registro", "Se guardo correctamente", "info")
                Else
                    mensaje("Actalizar", "Se ha actualizado el plato", "info")
                End If
            End If

            Limpiar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function RecuperarPlato(codigo As String) As Boolean
        Try
            RecuperarPlato = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from Menu where men_codigo = '" & codigo & "' and men_estado = 'A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    ' MsgBox("Dentro del while")
                    id_plato = dr("men_id")
                    txt_codigo.Text = dr("men_codigo")
                    cmb_modalidad.SelectedValue = dr("mod_id")
                    txt_nombre.Text = dr("men_plato")
                    txt_descripcion.Text = dr("men_descripcion")
                    txt_precio.Text = Agregar_cero(dr("men_precio").ToString())

                    'Falta la foto'
                    If (dr("men_imagen") IsNot DBNull.Value) Then
                        pb_foto.Image = ByteArrayToImage(DirectCast(dr("men_imagen"), Byte()))
                    Else
                        pb_foto.Image = My.Resources.default_image
                    End If

                End While
                RecuperarPlato = True
            End If

        Catch ex As Exception
            RecuperarPlato = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar()
    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                If (RecuperarPlato(txt_codigo.Text)) Then
                Else
                    txt_nombre.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If (txt_codigo.Text = String.Empty) Then
                MsgBox("Digite una código para eliminar un plato", MsgBoxStyle.Information, "Plato")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar a " & txt_codigo.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then

                If (EliminarDatos("sp_eliminar_plato", "@men_id", id_plato)) Then
                    mensaje("Plato", "Plato Eliminado", "info")
                    Limpiar()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscaPlato_Click(sender As Object, e As EventArgs) Handles btn_buscaPlato.Click
        Try
            g_str_codigo = ""

            Dim frm As New frm_mantPlato
            frm.ShowDialog()

            txt_codigo.Text = g_str_codigo

            If (txt_codigo.Text <> "") Then
                txt_codigo_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            Else
                If (RecuperarPlato(txt_codigo.Text) = False) Then
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