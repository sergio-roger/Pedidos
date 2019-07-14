Public Class frm_estado_pedido

    Function ConsultarEstadoPedidos(id_estado As Integer, codigo As String) As Boolean
        Try
            ConsultarEstadoPedidos = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_consultar_pedidos", id_estado, codigo)
            dgv_pedidos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read

                    dgv_pedidos.Rows.Add(dr("id"), dr("codigo"), dr("cliente"), dr("mesa"), dr("estado"))
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

    Private Sub frm_estado_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadena As String = "select ep_id, ep_descripcion from  Estado_pedido where ep_estado = 'A'"
            If (CargarCombo(cadena, "ep_id", "ep_descripcion", cmb_estado) = False) Then
                'MsgBox("No se pudo cargar el combo", MsgBoxStyle.Critical, "Platos")
                mensaje("Pedidos", "No se pudo cargar los estado de los Pedidos", "info")
            End If


            If ConsultarEstadoPedidos(cmb_estado.SelectedValue, "") = False Then
                mensaje("Error", "No se puede cargar la tabla", "danger")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_pedido_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo_pedido.TextChanged
        Try
            If ConsultarEstadoPedidos(cmb_estado.SelectedValue, txt_codigo_pedido.Text) = False Then
                mensaje("Error", "No se puede cargar la tabla", "danger")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_estado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_estado.SelectionChangeCommitted

        If (cmb_estado.Left > 0) Then

            If (txt_codigo_pedido.Text = "") Then
                If ConsultarEstadoPedidos(cmb_estado.SelectedValue, "") = False Then
                    mensaje("Error", "No se puede cargar la tabla", "danger")
                End If
            Else
                If ConsultarEstadoPedidos(cmb_estado.SelectedValue, "") = False Then
                    mensaje("Error", "No se puede cargar la tabla", "danger")
                End If
            End If
        End If
    End Sub
End Class