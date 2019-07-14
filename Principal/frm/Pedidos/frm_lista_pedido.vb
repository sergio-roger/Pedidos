Public Class frm_lista_pedido

    Private contr_estado_pedido As Integer = 1
    Private id_pedido As Integer

    Function ConsultarEstadoPedidos(id_estado) As Boolean
        Try
            ConsultarEstadoPedidos = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_cargar_pedidos_activos", id_estado)
            'dgv_pedidos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_pedidos.Rows.Add(dr("id"), dr("codigo_pedido"), dr("codigo_mesa"), dr("estado"))
                End While
            End If

            ConsultarEstadoPedidos = True
        Catch ex As Exception
            ConsultarEstadoPedidos = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Function ObtenerDetallePedido(id As Integer) As Boolean
        Try
            ObtenerDetallePedido = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_obtener_detalle_Pedido", id)
            list_detalle_pedido.Items.Clear()

            If dr.HasRows Then
                While dr.Read
                    'dgv_pedidos.Rows.Add(dr("id"), dr("codigo_pedido"), dr("codigo_mesa"), dr("estado"))
                    Dim coleccion() As String = dr("items").Split(",")

                    For i = 0 To coleccion.Length - 1

                        If (coleccion(i) <> "") Then
                            list_detalle_pedido.Items.Add("* " & coleccion(i))
                        End If
                    Next
                End While
            End If

            ObtenerDetallePedido = True
        Catch ex As Exception
            ObtenerDetallePedido = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub VolverCargarPedidos()
        txt_codigo.Text = ""
        id_pedido = 0
        dgv_pedidos.Rows.Clear()

        If ConsultarEstadoPedidos(contr_estado_pedido) = False Then
            mensaje("Error", "No se puede cargar la tabla", "danger")
        End If
    End Sub

    Private Sub frm_lista_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadena As String = "select ep_id, ep_descripcion from Estado_pedido where ep_estado = 'A'"
            If (CargarCombo(cadena, "ep_id", "ep_descripcion", cmb_estado) = False) Then
                mensaje("Pedido", "No se pudo cargar el combo de mesas", "info")
            End If

            If ConsultarEstadoPedidos(contr_estado_pedido) = False Then
                mensaje("Error", "No se puede cargar la tabla", "danger")
            End If

            cmb_estado.SelectedValue = 2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_pedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                id_pedido = Val(dgv_pedidos.Rows(e.RowIndex).Cells(0).Value)
                txt_codigo.Text = dgv_pedidos.Rows(e.RowIndex).Cells(1).Value

                'Ejecutar el procedimiento almacenado
                If (ObtenerDetallePedido(id_pedido) = False) Then
                    mensaje("Hups", "Algo salio mal al cargar los detales ", "danger")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_despachar_Click(sender As Object, e As EventArgs) Handles btn_despachar.Click
        Try

            If (id_pedido <> 0) Then
                If (ActualizarPedido(id_pedido, cmb_estado.SelectedValue) = False) Then
                    mensaje("Hups", "Algo salió mal al actualizar el pedido ", "alert")
                Else
                    mensaje("Exito", "El pedido ha sido despachado", "info")
                    VolverCargarPedidos()
                End If
            Else
                mensaje("Lista de Pedidos", "Seleccione un pedido para atender", "info")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class