Public Class frm_matProducto
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_precio.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo.TextChanged

    End Sub

    Private Sub txt_descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_descripcion.TextChanged

    End Sub

    Private Sub frm_matProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If txt_id.Text > 0 Then
                If fun_cargarProductos() = False Then
                    MsgBox("No exitste Informacion")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_cargarProductos() As Boolean
        Try
            fun_cargarProductos = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & "SELECT [PRO_ID],[CAT_ID],[PRO_CODIGO],[PRO_DESCRIPCION],[PRO_PRECIO],[PRO_LLEVA_IVA],[PRO_ESTADO] FROM [PRODUCTOS]  where  PRO_ID=" & txt_id.Text & ""
            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(str_cadenaSql)

            If dr.HasRows Then
                While dr.Read
                    txt_id.Text = dr("PRO_ID")
                    txt_categoria.Text = dr("CAT_ID")
                    txt_codigo.Text = dr("PRO_CODIGO")
                    txt_descripcion.Text = dr("PRO_DESCRIPCION")
                    txt_precio.Text = dr("PRO_PRECIO")
                    If dr("PRO_LLEVA_IVA") = 1 Then
                        chk_llevaiva.Checked = True
                    Else
                        chk_llevaiva.Checked = False
                    End If
                    If dr("PRO_ESTADO") = "A" Then
                        chk_estado.Checked = True
                    Else
                        chk_estado.Checked = False
                    End If
                End While
                fun_cargarProductos = True
            End If
        Catch ex As Exception
            fun_cargarProductos = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try

    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_categoria.TextChanged

    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            Dim str_mensage, str_titulo As String
            str_mensage = "Realmente deseas Grabar?"
            str_titulo = Me.Text
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox(str_mensage, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo)
            If respuesta = MsgBoxResult.Yes Then
                If fun_grabar() = False Then
                    MsgBox("Error, al Grabar")
                Else
                    MsgBox("La Operación se realizo con éxito")
                    Me.Close()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_grabar() As Boolean
        Try
            fun_grabar = False
            Dim str_cadenaSql As String = ""
            Dim str_estado As String
            Dim llevaiva As Integer
            If chk_estado.Checked = True Then
                str_estado = "A"
            Else
                str_estado = "I"
            End If

            If chk_llevaiva.Checked = True Then
                llevaiva = 1
            Else
                llevaiva = 0
            End If

            If txt_id.Text = 0 Then
                'insertar
                str_cadenaSql = str_cadenaSql & "INSERT INTO PRODUCTOS (CAT_ID,PRO_CODIGO,PRO_DESCRIPCION,PRO_PRECIO,PRO_LLEVA_IVA,PRO_ESTADO) values("
                str_cadenaSql = str_cadenaSql & "" & txt_categoria.Text & ","
                str_cadenaSql = str_cadenaSql & "'" & txt_codigo.Text & "',"
                str_cadenaSql = str_cadenaSql & "'" & txt_descripcion.Text & "',"
                str_cadenaSql = str_cadenaSql & "" & txt_precio.Text & ","
                str_cadenaSql = str_cadenaSql & "" & llevaiva & ","
                str_cadenaSql = str_cadenaSql & "'" & str_estado & "')"
            Else
                'update
                str_cadenaSql = str_cadenaSql & "update PRODUCTOS set "
                str_cadenaSql = str_cadenaSql & "CAT_ID=" & txt_categoria.Text & ","
                str_cadenaSql = str_cadenaSql & "PRO_CODIGO='" & txt_codigo.Text & "',"
                str_cadenaSql = str_cadenaSql & "PRO_DESCRIPCION='" & txt_descripcion.Text & "',"
                str_cadenaSql = str_cadenaSql & "PRO_PRECIO=" & txt_precio.Text & ","
                str_cadenaSql = str_cadenaSql & "PRO_LLEVA_IVA=" & llevaiva & ","
                str_cadenaSql = str_cadenaSql & "PRO_ESTADO='" & str_estado & "'"
                str_cadenaSql = str_cadenaSql & "where PRO_ID=" & txt_id.Text
            End If

            If Conectar() = False Then
                Exit Function
            End If
            If Execute_nonquery(str_cadenaSql) = True Then
                fun_grabar = True
            End If
        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()

        End Try
    End Function
End Class