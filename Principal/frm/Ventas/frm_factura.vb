Public Class frm_factura
    Dim valorIva As Double
    Dim id_persona As Long = 0
    Dim numitems As Integer = 18
    Dim codigo_p As Integer = 0
    Dim cantidad_p As Integer = 2
    Dim precio_p As Integer = 3
    Dim sub_total_p As Integer = 4
    Dim aplicaIva_p As Integer = 5
    Dim valorIva_p As Integer = 6
    Dim Total_p As Integer = 7
    Dim pro_Id_p As Integer = 8
    Dim id_factura As Integer = 0
    Dim accion_p As Integer = 9
    Dim subtota_p As Integer = 10
    Dim stock As Integer = 18
    Dim pro_id As Integer = 19
    Private aux_id_cod As String
    Private aux_cant_pro As String
    Private aux_precio_pro As String
    Private aux_base_imponible_pro As String
    Private aux_iva As String
    Private aux_aplica_iva As String
    Private aux_total_pro As String
    Private aux_estado_pro As String
    Private existe_persona = False
    Private Sub btn_buscarClientes_Click(sender As Object, e As EventArgs) Handles btn_buscarClientes.Click
        Try

            g_str_cedula = ""
            frm_buscarCliente.ShowDialog()
            If g_str_cedula <> "" Then
                txt_ruc.Text = g_str_cedula
                txt_ruc_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub generarLineas()
        For i = 0 To numitems
            dgv.Rows.Add("")
        Next
    End Sub

    Private Sub txt_ruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruc.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
                If fun_recuperarPersona(txt_ruc.Text) = False Then
                    'MsgBox("usuario no existe")
                    sub_limpiar()
                    txt_nombre.Focus()
                    id_persona = 0
                Else
                    txt_codigo.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub sub_limpiar()
        txt_apellidos.Text = ""
        txt_nombre.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_correo.Text = ""
    End Sub
    Function fun_recuperaridPersona(ByVal cedula As String) As Long
        Try
            fun_recuperaridPersona = 0
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & "SELECT * "
            str_cadenaSql = str_cadenaSql & "FROM Cliente "
            str_cadenaSql = str_cadenaSql & "where cli_cedula='" & cedula & "'"
            dr = Execute_reader(str_cadenaSql)
            If dr.HasRows Then
                While dr.Read
                    fun_recuperaridPersona = dr("cli_id")
                End While
            End If
        Catch ex As Exception
            fun_recuperaridPersona = 0
        Finally
            dr.Close()
        End Try
    End Function
    Function fun_recuperarPersona(ByVal ruc As String) As Boolean
        Try
            fun_recuperarPersona = False
            Dim cadena_sql As String = ""
            cadena_sql = cadena_sql & "select * "
            cadena_sql = cadena_sql & " from Cliente"
            cadena_sql = cadena_sql & " where cli_estado='A' and cli_cedula like '" & ruc & "'"
            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(cadena_sql)
            dgv.Rows.Clear()
            If dr.HasRows Then
                While dr.Read
                    id_persona = dr("cli_id")
                    txt_nombre.Text = dr("cli_nombres")
                    txt_apellidos.Text = dr("cli_apellidos")
                    txt_telefono.Text = dr("cli_celular")
                    txt_direccion.Text = dr("cli_direccion")
                    txt_correo.Text = dr("cli_correo")
                End While
                fun_recuperarPersona = True
            End If

        Catch ex As Exception
            fun_recuperarPersona = False
        End Try
    End Function

    Private Sub frm_facturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fecha As Date = Now
            msk_fecha.Text = Format(fecha, g_str_formatoFechaPantalla)
            chk_estado.Checked = True
            If recuperarIva() = False Then
                MsgBox("No se pudo cargar el IVA")
                Exit Sub
            End If

            'generarLineas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eli_Click(sender As Object, e As EventArgs)
        Try


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'detalle de la factura
    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
                If txt_codigo.Text <> "" Then
                    If fun_buscarProducto(txt_codigo.Text) = False Then
                        limpiar_articulo()
                    Else
                        txt_cantp.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperarProducto(ByVal cod As String) As Boolean
        Try
            fun_recuperarProducto = False
            Dim cadena_sql As String = ""
            cadena_sql = cadena_sql & "select * "
            cadena_sql = cadena_sql & " from Pedido"
            cadena_sql = cadena_sql & " where ep_estado ='A' and ep_id like '" & cod & "'"

            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(cadena_sql)
            'dgv.Rows.Clear()
            If dr.HasRows Then
                While dr.Read
                    txt_id_producto.Text = dr("PRO_ID")
                    txt_codigo.Text = dr("PRO_CODIGO")
                    txt_Descripción.Text = dr("PRO_DESCRIPCION")
                    txt_precio.Text = dr("PRO_PRECIOVENTA")
                    txt_stockp.Text = dr("PRO_STOCK")
                    txt_aplica_iva.Text = dr("PRO_LLEVA_IVA")


                    If (dr("PRO_LLEVA_IVA") = 1) Then
                        txt_iva.Text = (dr("PRO_PRECIOVENTA") * 0.12)
                    End If

                End While
                fun_recuperarProducto = True
            End If

        Catch ex As Exception
            fun_recuperarProducto = False
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_buscarProducto(ByVal codigo As String) As Boolean
        Try
            fun_buscarProducto = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = " select * from productos where pro_codigo='" & codigo & "'"
            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(str_cadenaSql)
            If dr.HasRows Then
                While dr.Read
                    txt_Descripción.Text = dr("pro_descripcion")
                    txt_cantp.Text = 1
                    txt_precio.Text = dr("pro_precioventa")
                    txt_stockp.Text = dr("pro_stock")
                    txt_aplica_iva.Text = dr("pro_lleva_iva")
                    txt_id_producto.Text = dr("pro_id")
                End While
                fun_buscarProducto = True
            End If
        Catch ex As Exception
            fun_buscarProducto = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function
    'fin Delegate detalle de la factura
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try

            If txt_codigo.Text <> "" And Val(txt_cantp.Text) > 0 Then
                dgv.Rows.Add(txt_codigo.Text, txt_Descripción.Text, txt_cantp.Text, txt_precio.Text, 0, txt_aplica_iva.Text, 0, 0, txt_id_producto.Text)
                limpiar_articulo()
                txt_codigo.Focus()
                multiplicar()
                sumar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_cantp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantp.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
                btn_add_Click(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub limpiar_articulo()
        txt_codigo.Text = ""
        txt_cantp.Text = ""
        txt_Descripción.Text = ""
        txt_stockp.Text = ""
        txt_aplica_iva.Text = ""
        txt_precio.Text = ""
        txt_id_producto.Text = ""
        'falta la foto

    End Sub

    Sub multiplicar()
        Try
            If dgv.RowCount > 0 Then

                For fila = 0 To dgv.RowCount - 1
                    'calcular el subtotal
                    dgv.Rows(fila).Cells(sub_total_p).Value = (dgv.Rows(fila).Cells(cantidad_p).Value) * (dgv.Rows(fila).Cells(precio_p).Value)
                    'calcular el iva
                    If dgv.Rows(fila).Cells(aplicaIva_p).Value = 1 Then
                        dgv.Rows(fila).Cells(valorIva_p).Value = (dgv.Rows(fila).Cells(sub_total_p).Value) * valorIva
                    Else
                        dgv.Rows(fila).Cells(valorIva_p).Value = 0
                    End If
                    'calcular el total
                    dgv.Rows(fila).Cells(Total_p).Value = (dgv.Rows(fila).Cells(sub_total_p).Value) + (dgv.Rows(fila).Cells(valorIva_p).Value)
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub sumar()
        Try
            Dim dbl_subtotal As Double = 0
            Dim dbl_basecero As Double = 0
            Dim dbl_iva As Double = 0
            Dim dbl_total As Double = 0
            Dim dbl_totalunidades As Double = 0

            If dgv.RowCount > 0 Then

                For fila = 0 To dgv.RowCount - 1
                    If dgv.Rows(fila).Cells(aplicaIva_p).Value = 1 Then
                        dbl_subtotal = dbl_subtotal + dgv.Rows(fila).Cells(sub_total_p).Value
                    Else
                        dbl_basecero = dbl_basecero + dgv.Rows(fila).Cells(sub_total_p).Value
                    End If
                    dbl_iva = dbl_iva + dgv.Rows(fila).Cells(valorIva_p).Value
                    dbl_totalunidades = dbl_totalunidades + CDbl(dgv.Rows(fila).Cells(cantidad_p).Value)
                Next
                dbl_total = dbl_subtotal + dbl_basecero + dbl_iva

                txt_subtotal.Text = Format(dbl_subtotal, g_str_forrmatoNumero)
                txt_baseCero.Text = Format(dbl_basecero, g_str_forrmatoNumero)
                txt_iva.Text = Format(dbl_iva, g_str_forrmatoNumero)
                txt_total.Text = Format(dbl_total, g_str_forrmatoNumero)
                txt_total_pagar.Text = txt_total.Text
                txt_total_unidades.Text = dbl_totalunidades
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function recuperarIva() As Boolean
        Try
            recuperarIva = False
            If Conectar() = False Then
                Exit Function
            End If

            ''''  dr = Execute_reader("sp_recuperaValorParametrica", "IVA")
            If dr.HasRows Then
                While dr.Read
                    valorIva = CDbl(dr("DETP_VALOR")) / 100
                End While
                recuperarIva = True
            End If
        Catch ex As Exception
            recuperarIva = False
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function
    Private Sub txt_efectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_efectivo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9 Then
                txt_cambio.Text = Format(CDbl(txt_efectivo.Text) - CDbl(txt_total_pagar.Text), g_str_forrmatoNumero)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            ' validar
            If fun_validar() = False Then
                Exit Sub
            End If
            If fun_preguntaRespuesta("Realmente dese Grabar?") = MsgBoxResult.Yes Then
                ''se procede a grabar
                If id_factura = 0 Then
                    'a grabar la factura
                    If fun_grabarFactura() = True Then
                        MsgBox("La operación se realizó con éxito")
                    Else

                        MsgBox("Ocurrió un error al grabar")
                    End If
                Else
                    'Anular la factura
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabarFactura() As Boolean

        Try
            Dim id_per As Long
            fun_grabarFactura = False
            Dim id_cabFac As Long
            'paso 1: conectar a la BD
            If Conectar() = False Then Exit Function
            'paso 2: Iniciar la transacción
            If fun_iniciatransaccion() = False Then Exit Function
            'paso 3 registrar al cliente
            If fun_actualiza_Persona() = False Then Exit Function
            id_per = fun_recuperaridPersona(txt_ruc.Text)
            'Registrar al cliente si no existe
            If (existe_persona = False) Then
                GrabarPersona()
            End If
            id_persona = ObtenerIdPersona(txt_ruc.Text)
            'paso 4: grabar la cabecera
            If fun_grabarCabFactura() = False Then Exit Function
            'paso 5: recuperar el id de la CabeceraFactura
            id_cabFac = fun_recuperaridCabecera(txt_num_fac.Text)
            If id_cabFac = 0 Then Exit Function
            'paso 6 grabar el detalle
            If fun_insertarDetalle(id_cabFac) = False Then Exit Function
            'paso 7 confirmo la finalización de la transacción
            If fun_commit() = False Then Exit Function
            fun_grabarFactura = True
        Catch ex As Exception
            fun_grabarFactura = False
        Finally
            If fun_grabarFactura = False Then
                fun_rolbak()
            End If
            Desconectar()
        End Try
    End Function
    Function fun_validar() As Boolean
        Try
            fun_validar = False
            'verificar si el número de factura no está repetido
            If fun_verificarFactura() > 0 Then
                MsgBox("Verifique, el numero de factura ya está registrado")
                Exit Function
            End If
            If txt_num_fac.Text = "" Then
                MsgBox("Ingrese el numero de la Factura")
                txt_num_fac.Focus()
                Exit Function
            End If
            If dgv.RowCount < 1 Then
                MsgBox("Ingrese al menos un producto")
                txt_codigo.Focus()
                Exit Function
            End If
            fun_validar = True
        Catch ex As Exception
            fun_validar = False
        End Try

    End Function
    Function fun_verificarFactura() As Long
        Try

            If Conectar() = False Then
                Exit Function
            End If
            fun_verificarFactura = fun_recuperaridCabecera(txt_num_fac.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try

    End Function
    Function fun_actualiza_Persona() As Boolean
        Try
            fun_actualiza_Persona = False
            If Execute_nonquery("sp_ManPersona", id_persona, txt_ruc.Text, txt_nombre.Text, txt_apellidos.Text, txt_direccion.Text, txt_telefono.Text, txt_correo.Text) Then
                fun_actualiza_Persona = True
            End If
        Catch ex As Exception
            fun_actualiza_Persona = False
        End Try
    End Function
    Function fun_grabarCabFactura() As Boolean
        Try
            fun_grabarCabFactura = False
            Dim estado As String
            If chk_estado.Checked = True Then
                estado = "A"
            Else
                estado = "E"
            End If
            If Execute_nonquery("sp_cab_movimientoVenta", txt_num_fac.Text, "ING", id_persona, Format(CDate(msk_fecha.Text), g_str_formatoFecBd), CDbl(txt_baseCero.Text), CDbl(txt_subtotal.Text), CDbl(txt_iva.Text), CDbl(txt_total.Text), estado, g_int_id_usuario, Format(CDate(Now), g_str_formatoFecBd)) Then
                fun_grabarCabFactura = True
            End If
        Catch ex As Exception
            fun_grabarCabFactura = False
        End Try
    End Function
    Function fun_recuperaridCabecera(ByVal num_fac As Long) As Long
        Try
            fun_recuperaridCabecera = 0
            ' Dim cadena_sql As String = "select CABMOV_ID from cab_movimiento where cabmov_num_doc=" & txt_num_fac.Text
            ' dr = fun_EjecutaConsultaSql(cadena_sql)
            dr = Execute_reader("sp_recuperaIdfac", num_fac)
            If dr.HasRows Then
                While dr.Read
                    fun_recuperaridCabecera = dr("CAB_ID")
                End While
            End If
        Catch ex As Exception
            fun_recuperaridCabecera = 0
        Finally
            dr.Close()
        End Try
    End Function
    'informacion de detalles
    Function fun_insertarDetalle(ByVal id_cabFac As Long) As Boolean
        Try
            fun_insertarDetalle = False
            Dim cadenasql As String = ""
            For fila = 0 To dgv.RowCount - 1
                If Execute_nonquery("sp_detalle_pedidos", id_cabFac, dgv(pro_Id_p, fila).Value, (dgv(cantidad_p, fila).Value) * -1, dgv(precio_p, fila).Value, dgv(sub_total_p, fila).Value, dgv(valorIva_p, fila).Value, dgv(Total_p, fila).Value, "A") = False Then
                    fun_insertarDetalle = False
                    Exit Function
                End If
                ''''   If Execute_nonquery("sp_disstock", dgv.Rows(fila).Cells(pro_Id_p).Value, dgv.Rows(fila).Cells(cantidad_p).Value) Then


             ''''   End If
            Next
            fun_insertarDetalle = True
        Catch ex As Exception
            fun_insertarDetalle = False
        End Try
    End Function
    Private Function Grabar_movimiento(ByVal cab_id As Integer) As Boolean
        Try
            Grabar_movimiento = False

            'If Conectar() = False Then
            '    Exit Function
            'End If

            cmd = New SqlClient.SqlCommand("sp_detalleMovimiento", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CAB_ID", cab_id)
            cmd.Parameters.AddWithValue("@PROD_ID", Val(aux_id_cod))
            cmd.Parameters.AddWithValue("@DET_CANTIDAD", Val(aux_cant_pro))
            cmd.Parameters.AddWithValue("@DET_PRECIO", aux_precio_pro)
            cmd.Parameters.AddWithValue("@DET_BASE_IMPONIBLE", 0)
            cmd.Parameters.AddWithValue("@DET_IVA", Double.Parse(aux_aplica_iva))
            cmd.Parameters.AddWithValue("@DET_TOTAL", Double.Parse(aux_total_pro))
            cmd.Parameters.AddWithValue("@DET_ESTADO", "A")

            cmd.ExecuteNonQuery()
            Grabar_movimiento = True

        Catch ex As Exception
            Grabar_movimiento = False
            MsgBox(ex.Message)
        Finally
            'Desconectar()
        End Try

    End Function
    'fin de informacion de detalles
    Private Function ObtenerIdPersona(text As String) As Long
        Try
            ObtenerIdPersona = 0
            Dim cadena_sql As String = ""

            cadena_sql = "select PER_ID from Cliente where cli_cedula = '" & text & "'"

            'If Conectar() = False Then
            '    Exit Function
            'End If

            dr = Execute_reader(cadena_sql)

            If dr.HasRows Then
                While dr.Read
                    ObtenerIdPersona = dr("cli_id")
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ObtenerIdPersona = 0
        Finally
            dr.Close()
            'Desconectar()
        End Try
    End Function

    Private Sub GrabarPersona()
        Try

            'If Conectar() = False Then
            '    Exit Sub
            'End If

            cmd = New SqlClient.SqlCommand("sp_ManPersona", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@per_id", 0)
            cmd.Parameters.AddWithValue("@PER_IDENTIFICACION", txt_ruc.Text)
            cmd.Parameters.AddWithValue("@PER_NOMBRES", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@PER_APELLIDOS", txt_apellidos.Text)
            cmd.Parameters.AddWithValue("@PER_DIRECCION", txt_direccion.Text)
            cmd.Parameters.AddWithValue("@PER_TELEFONO", txt_telefono.Text)
            cmd.Parameters.AddWithValue("@PER_CORREO", txt_correo.Text)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Desconectar()
        End Try
    End Sub


End Class