Public Class frm_servir_pedido

    Private id_estado_servir = 2
    Private id_pedido As Integer = 0

    Function CargarPedidos(opcion As Integer, id_estado As Integer, cadena As String) As Boolean
        Try
            CargarPedidos = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_obtener_pedido_servir", opcion, id_estado, cadena)
            dgv_pedidos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    If (opcion = 0) Then
                        dgv_pedidos.Rows.Add(dr("id"), dr("codigo"), dr("cedula"), dr("nombres"), dr("mesa"), dr("estado"))
                    End If

                    If (opcion = 1) Then
                        id_pedido = dr("id")
                        txt_codigo_pedido.Text = dr("codigo")
                        txt_cedula.Text = dr("cedula")
                        txt_nombres.Text = dr("nombres")
                        cmb_mesa.Text = dr("mesa")
                    End If
                End While
            End If

            CargarPedidos = True
        Catch ex As Exception
            CargarPedidos = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub Limpiar()
        txt_codigo_pedido.Text = ""
        txt_cedula.Text = ""
        txt_nombres.Text = ""
        txt_codigo_pedido.Focus()
    End Sub

    Private Sub VolverCargarPedidos()

        If CargarPedidos(0, id_estado_servir, "") = False Then
            mensaje("Error", "No se puede cargar la tabla", "danger")
        End If
    End Sub

    Private Sub frm_servir_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadena As String = "select ep_id, ep_descripcion from Estado_pedido where ep_estado = 'A'"
            If (CargarCombo(cadena, "ep_id", "ep_descripcion", cmb_estado) = False) Then
                mensaje("Pedido", "No se pudo cargar el combo de mesas", "info")
            End If

            Dim cadenaMesa As String = "select mesa_id, mesa_codigo from Mesa where mesa_estado = 'A'"
            If (CargarCombo(cadenaMesa, "mesa_id", "mesa_codigo", cmb_mesa) = False) Then
                mensaje("Pedido", "No se pudo cargar el combo de mesas", "info")
            End If

            If CargarPedidos(0, id_estado_servir, "") = False Then
                mensaje("Error", "No se puede cargar la tabla", "danger")
            End If

            cmb_estado.SelectedValue = 4

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_pedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo_pedido.KeyPress
        Try
            If (Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 9) Then
                If (CargarPedidos(1, id_estado_servir, txt_codigo_pedido.Text) = False) Then
                    MsgBox("El código no existe", MsgBoxStyle.Information)
                    Limpiar()
                    txt_codigo_pedido.Focus()
                Else
                    btn_servir.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_pedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                id_pedido = Val(dgv_pedidos.Rows(e.RowIndex).Cells(0).Value)
                txt_codigo_pedido.Text = dgv_pedidos.Rows(e.RowIndex).Cells(1).Value
                txt_cedula.Text = dgv_pedidos.Rows(e.RowIndex).Cells(2).Value
                txt_nombres.Text = dgv_pedidos.Rows(e.RowIndex).Cells(3).Value
                cmb_mesa.Text = dgv_pedidos.Rows(e.RowIndex).Cells(4).Value
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_servir_Click(sender As Object, e As EventArgs) Handles btn_servir.Click
        Try

            If (id_pedido <> 0) Then
                If (ActualizarPedido(id_pedido, cmb_estado.SelectedValue) = False) Then
                    mensaje("Hups", "Algo salió mal al actualizar el pedido ", "alert")
                Else
                    mensaje("Exito", "El pedido ha sido servido", "info")
                    Limpiar()
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