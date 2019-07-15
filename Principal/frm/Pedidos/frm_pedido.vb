Public Class frm_pedido

    Private id_pedido As Integer
    Private id_comida As String
    Private tipo As String

    Private subtotal_col As Integer = 8 + 1
    Private cantidad_col As Integer = 4 + 1
    Private precio_col As Integer = 5 + 1
    Private descuento_col As Integer = 6 + 1
    Private porcentaje_col As Integer = 7 + 1
    Private total_col As Integer = 9 + 1

    Private existeCliente As Boolean
    Private idCliente As Integer
    Private idusuario As Integer = g_int_id_usuario
    Private numero_pedido As Integer = 0
    'Variables auxiliares que ayudaran a guardar el detalle pedido temporalmente
    Private aux_cod As String
    Private aux_pedido As String
    Private aux_tipo As String
    Private aux_cantidad As String
    Private aux_precio As String
    Private aux_descuento As String
    Private aux_porcentaje As String
    Private aux_subtotal As String
    Private aux_total As String
    Private aux_id As String

    Private Function Obtener_N_Pedido() As Integer
        'select (count(*) + 1) from Pedido
        Dim n_pedido As Integer = 0
        Try
            Dim str_cadenaSql As String = "select (count(*) + 1) as numero from Pedido"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    n_pedido = dr("numero")
                End While
            End If
            Return n_pedido

        Catch ex As Exception
            MsgBox(ex.Message)
            Return n_pedido

        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub CargarCombos()
        Dim cadena As String = "select mesa_id, mesa_codigo from Mesa where mesa_estado = 'A'"
        If (CargarCombo(cadena, "mesa_id", "mesa_codigo", cmb_mesa) = False) Then
            mensaje("Pedido", "No se pudo cargar el combo de mesas", "info")
        End If

        Dim cadena_estado As String = "select ep_id, ep_descripcion from Estado_pedido where ep_estado = 'A'"
        If (CargarCombo(cadena_estado, "ep_id", "ep_descripcion", cmb_estado) = False) Then
            mensaje("Pedido", "No se pudo cargar el combo de Pedidos", "info")
        End If
    End Sub

    Private Function RecuperarComida(consultaSql As String, tabla As String, campo_id As String, campo_codigo As String, campo_desc As String, campo_precio As String) As Boolean
        Try
            RecuperarComida = False
            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(consultaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    ' MsgBox("Dentro del while")
                    txt_id_aux.Text = dr(campo_id)
                    id_comida = dr(campo_codigo)
                    txt_descripcion.Text = dr(campo_desc)
                    txt_precio.Text = Agregar_cero(dr(campo_precio).ToString())
                    txt_cantidad.Text = 1

                    If (tabla = "Menu") Then 'Si es un plato
                        txt_descuento.Text = "no"
                        txt_porcentaje.Text = 0
                    Else                       ' Si es un combo
                        If (dr("com_posee_descuento")) Then
                            txt_descuento.Text = "si"
                            txt_porcentaje.Text = dr("com_porcentaje_descuento")
                        Else
                            txt_descuento.Text = "no"
                            txt_porcentaje.Text = 0
                        End If
                    End If
                End While

                txt_cantidad.Focus()
                RecuperarComida = True
            End If

        Catch ex As Exception
            RecuperarComida = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub Multiplicar()
        Try
            If (dgv_pedido.RowCount > 0) Then

                For fila = 0 To dgv_pedido.RowCount - 1
                    'dgv_pedido.Rows(fila).Cells(subototal_p).Value = (dgv.Rows(fila).Cells(cant_p).Value) * (dgv_pedido.Rows(fila).Cells(precio_p).Value)
                    'Calcular el Iva'
                    If (dgv_pedido.Rows(fila).Cells(descuento_col).Value = "si") Then  'Aplica descuento
                        Dim axu_desc As Double
                        axu_desc = (dgv_pedido.Rows(fila).Cells(precio_col).Value * dgv_pedido.Rows(fila).Cells(porcentaje_col).Value) / 100
                        dgv_pedido.Rows(fila).Cells(subtotal_col).Value = (dgv_pedido.Rows(fila).Cells(precio_col).Value - axu_desc)
                    Else
                        dgv_pedido.Rows(fila).Cells(subtotal_col).Value = dgv_pedido.Rows(fila).Cells(precio_col).Value
                    End If

                    dgv_pedido.Rows(fila).Cells(total_col).Value = dgv_pedido.Rows(fila).Cells(subtotal_col).Value * dgv_pedido.Rows(fila).Cells(cantidad_col).Value
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        txt_codigo.Text = ""
        rdb_plato.Checked = True
        rdb_combo.Checked = False
        txt_descripcion.Text = ""
        txt_cantidad.Text = ""
        txt_precio.Text = ""
        txt_descuento.Text = ""
        txt_porcentaje.Text = ""
        dgv_pedido.Rows.Clear()
        txt_codigo_pedido.Focus()
    End Sub

    Private Sub LimpiarOrden()
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
        txt_cantidad.Text = ""
        txt_precio.Text = ""
        txt_descuento.Text = ""
        txt_porcentaje.Text = ""
        txt_id_aux.Text = ""
        rdb_plato.Checked = True
        txt_codigo.Focus()
    End Sub

    Private Function Validar() As Boolean
        Try
            Validar = False

            If (txt_codigo_pedido.Text = "") Then
                mensaje("Pedido", "Ingrese un coódigo de Pedido ! ", "info")
                txt_codigo_pedido.Focus()
                Exit Function
            End If

            If (dgv_pedido.RowCount < 1) Then
                mensaje("Pedido", "Ingrese al menos un plato o un combo", "info")
                txt_codigo.Focus()
                Exit Function
            End If


            Dim c1 As String = "pe_codigo = '" & txt_codigo_pedido.Text & "'"
            Dim c2 As String = "ped_estad = 'A'"

            If (ExisteDato("Pedido", c1, c2, "pe_codigo", txt_codigo_pedido.Text.Trim) And id_pedido = 0) = True Then
                MsgBox("El código ya se encuentra registrado", MsgBoxStyle.Exclamation, "Codigo Existente")
                txt_codigo_pedido.Text = ""
                txt_codigo_pedido.Focus()
                Exit Function
            End If

            Validar = True

        Catch ex As Exception
            Validar = False
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function ObtenerIdCliente(text As String) As Long
        Try
            ObtenerIdCliente = 0
            Dim cadena_sql As String = ""

            cadena_sql = "select cli_id from Cliente where cli_cedula = '" & text & "' and cli_estado = 'A'"

            'If Conectar() = False Then
            '    Exit Function
            'End If

            dr = Execute_reader(cadena_sql)

            If dr.HasRows Then
                While dr.Read
                    ObtenerIdCliente = dr("cli_id")
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ObtenerIdCliente = 0
        Finally
            dr.Close()
            'Desconectar()
        End Try
    End Function

    Private Function GrabarCabeceraPedido() As Boolean
        Try
            GrabarCabeceraPedido = False

            cmd = New SqlClient.SqlCommand("sp_insertar_actualizar_pedido", cnn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@ped_id", id_pedido)
            cmd.Parameters.AddWithValue("@usu_id", idusuario)
            cmd.Parameters.AddWithValue("@mesa_id", cmb_mesa.SelectedValue)
            cmd.Parameters.AddWithValue("@ep_id", cmb_estado.SelectedValue)
            cmd.Parameters.AddWithValue("@ped_observacion", "")
            cmd.Parameters.AddWithValue("@ped_estado", "A")
            cmd.Parameters.AddWithValue("@pe_codigo", numero_pedido)

            cmd.ExecuteNonQuery()

            GrabarCabeceraPedido = True

        Catch ex As Exception
            GrabarCabeceraPedido = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function GrabarPedido() As Boolean
        Try
            GrabarPedido = False

            'Conectar a la bd 
            If (Conectar() = False) Then
                Exit Function
            End If

            If (Conectar()) = False Then
            End If

            'Guardar datos en la tabla cab_movimiento con su procedure store
            If (GrabarCabeceraPedido()) Then
                Dim cadena As String = "select ped_id from Pedido where ped_estad = 'A' and pe_codigo = '" & txt_codigo_pedido.Text & "'"
                id_pedido = ObtenerId(cadena, "ped_id")
                GrabarPedido = True
            Else
                GrabarPedido = False
            End If

            'Guardar dlos detalle pedido
            If (id_pedido > 0 And GrabarPedido = True) Then
                If (ObtenerDatosTablaDetallePedido(id_pedido) = False) Then
                    mensaje("Pedido", "Error al grabaar los detalle-pedido", "danger")
                End If

            End If

        Catch ex As Exception
            GrabarPedido = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function ObtenerDatosTablaDetallePedido(ByVal pedido_id As Integer) As Boolean

        Dim i As Integer = 1

        Try
            ObtenerDatosTablaDetallePedido = False

            For Each Fila In dgv_pedido.Rows.Cast(Of DataGridViewRow)()

                aux_id = Fila.Cells("col_id").Value.ToString()
                aux_cod = Fila.Cells("col_codigo").Value.ToString()
                aux_pedido = Fila.Cells("col_pedido").Value.ToString()
                aux_tipo = Fila.Cells("col_tipo").Value.ToString()
                aux_cantidad = Fila.Cells("col_cantidad").Value.ToString()
                aux_precio = Fila.Cells("col_precio").Value.ToString()
                aux_descuento = Fila.Cells("col_descuento").Value.ToString()
                aux_porcentaje = Fila.Cells("col_porcentaje").Value.ToString()
                aux_subtotal = Fila.Cells("col_subtotal").Value.ToString()
                aux_total = Fila.Cells("col_total").Value.ToString()

                'Relizar insercciones en la tabla Detalle-Pedido
                If (GrabarDetallePedido(pedido_id) = False) Then
                End If

                LimpiarVariablesAuxiliares()
                i = i + 1
            Next
            ObtenerDatosTablaDetallePedido = True
        Catch ex As Exception
            ObtenerDatosTablaDetallePedido = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function GrabarDetallePedido(ByVal pedido_id As Integer) As Boolean
        Try
            GrabarDetallePedido = False

            If Conectar() = False Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_insertar_actualizar_detallePedido", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0

            cmd.Parameters.AddWithValue("@n_pedido", numero_pedido)
            cmd.Parameters.AddWithValue("@dep_codigo_pedido_bebida", CInt(aux_id))
            cmd.Parameters.AddWithValue("@det_pedido", aux_pedido)
            cmd.Parameters.AddWithValue("@det_tipo", aux_tipo)
            cmd.Parameters.AddWithValue("@det_cantidad", CInt(aux_cantidad))
            cmd.Parameters.AddWithValue("@det_precio", Double.Parse(aux_precio))

            Dim desc As Boolean = If(aux_descuento = "si", True, False)
            cmd.Parameters.AddWithValue("@det_descuento", desc)
            cmd.Parameters.AddWithValue("@det_porcentaje", CInt(aux_porcentaje))
            cmd.Parameters.AddWithValue("@det_subtotal", Double.Parse(aux_subtotal))
            cmd.Parameters.AddWithValue("@det_total", Double.Parse(aux_total))

            cmd.ExecuteNonQuery()
            GrabarDetallePedido = True

        Catch ex As Exception
            GrabarDetallePedido = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Function

    Private Sub LimpiarVariablesAuxiliares()

        aux_cod = ""
        aux_pedido = ""
        aux_tipo = ""
        aux_cantidad = ""
        aux_precio = ""
        aux_descuento = ""
        aux_porcentaje = ""
        aux_subtotal = ""
        aux_total = ""

    End Sub

    Private Sub frm_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'MsgBox(g_perfil_id & " ->" & g_str_nombres)
            txt_usuario.Text = g_str_nombres
            txt_usuario.ReadOnly = True

            CargarCombos()
            numero_pedido = Obtener_N_Pedido()
            txt_codigo_pedido.Text = numero_pedido.ToString()
            rdb_combo.Checked = False
            rdb_plato.Checked = True
            txt_codigo_pedido.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        Try
            Dim consulta As String = ""

            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then

                If (rdb_plato.Checked = True) Then  'Recupera plato
                    consulta = "select men_id, men_codigo, men_plato, men_precio from Menu where men_codigo = '" & txt_codigo.Text & "' and men_estado = 'A'"
                    If (RecuperarComida(consulta, "Menu", "men_id", "men_codigo", "men_plato", "men_precio") = False) Then
                        mensaje("Error", "El codigo para el plato no existe !", "danger")
                        txt_codigo.Text = ""
                    Else
                        tipo = "Comida"
                    End If
                Else
                    consulta = "select com_id, com_codigo, com_contenido1, com_precio,com_posee_descuento,com_porcentaje_descuento from Combo where com_codigo = '" & txt_codigo.Text & "' and com_estado = 'A'"
                    If (RecuperarComida(consulta, "Combo", "com_id", "com_codigo", "com_contenido1", "com_precio") = False) Then
                        mensaje("Error", "El codigo para el Combo no existe !", "danger")
                        txt_codigo.Text = ""
                    Else
                        tipo = "Combo"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_p_Click(sender As Object, e As EventArgs) Handles btn_buscar_p.Click
        Try
            Dim consulta As String
            g_str_codigo = ""

            If (rdb_plato.Checked = True) Then ''Buscar plato
                Dim frm As New frm_mantPlato
                frm.ShowDialog()

                txt_codigo.Text = g_str_codigo

                If (txt_codigo.Text <> "") Then
                    txt_codigo_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
                Else
                    consulta = "select men_codigo, men_plato, men_precio from Menu where men_codigo = '" & txt_codigo.Text & "' and men_estado = 'A'"
                    If (RecuperarComida(consulta, "Menu", "men_id", "men_codigo", "men_plato", "men_precio") = False) Then
                    End If
                End If
            Else
                Dim frm As New frm_mantCombo
                frm.ShowDialog()

                txt_codigo.Text = g_str_codigo

                If (txt_codigo.Text <> "") Then
                    txt_codigo_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
                Else
                    consulta = "select com_codigo, com_contenido1, com_precio from Combo where com_codigo = '" & txt_codigo.Text & "' and com_estado = 'A'"
                    If (RecuperarComida(consulta, "Combo", "com_id", "com_codigo", "com_contenido1", "com_precio") = False) Then
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If (txt_codigo.Text = "") Then
                mensaje("Pedido", "Ingrese un codigo", "danger")
                txt_codigo.Focus()
                Exit Sub
            End If
            If (txt_cantidad.Text = "") Then
                mensaje("Pedido", "Ingrese una cantidad", "alert")
                txt_cantidad.Focus()
                Exit Sub
            End If

            If (txt_cantidad.Text <> "" And Val(txt_cantidad.Text) > 0) Then
                dgv_pedido.Rows.Add(False, txt_id_aux.Text, id_comida, txt_descripcion.Text, tipo, txt_cantidad.Text, txt_precio.Text,
                 txt_descuento.Text, txt_porcentaje.Text)
                Multiplicar()
                LimpiarOrden()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar()
    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                btn_add_Click(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        Try
            If (Validar() = False) Then
                Exit Sub
            End If

            If (PreguntaRespuesta("Realmente desea Grabar ? ", "Confirmar Transacción") = MsgBoxResult.Yes) Then
                'MsgBox("Procediendo a guardar la factura", MsgBoxStyle.Information, "Registrar datos")

                If (Conectar() = False) Then
                End If

                If (GrabarPedido() = False) Then
                    MsgBox("Hubo un error al guardar el Pedido", MsgBoxStyle.Critical, "Error")
                Else
                    Limpiar()
                    MsgBox("Pedido guardado correctamente", MsgBoxStyle.Information, "Exito al Guardar")
                End If
            Else
                MsgBox("No se registrara los datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_pedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedido.CellContentClick

    End Sub

    Private Sub dgv_pedido_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedido.CellClick
        Try
            If e.RowIndex > -1 Then
                dgv_pedido.Rows(e.RowIndex).Cells(0).Value = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_pedido.KeyDown
        Dim li_index As Integer

        If e.KeyCode = Keys.Delete Then

            e.Handled = True

            li_index = CType(sender, DataGridView).CurrentRow.Index
            dgv_pedido.Rows.RemoveAt(li_index)

        End If
    End Sub
End Class