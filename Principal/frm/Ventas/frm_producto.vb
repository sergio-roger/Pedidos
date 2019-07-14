Public Class frm_producto
    Dim pos_codigo As Integer = 0
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            Dim frm As New frm_matProducto
            frm.txt_id.Text = 0
            frm.ShowDialog()
            If fun_cargarProductos() = False Then
                MsgBox("No existen Perfiles")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frm_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_cargarProductos() = False Then
                MsgBox("No existen Productos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_cargarProductos() As Boolean
        Try
            fun_cargarProductos = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & "SELECT TOP (10) [PRO_ID],[CAT_ID],[PRO_CODIGO],[PRO_DESCRIPCION],[PRO_PRECIO],[PRO_LLEVA_IVA],[PRO_ESTADO] FROM [PRODUCTOS]  where PRO_DESCRIPCION Like '" & txt_buscar.Text & "%'"
            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(str_cadenaSql)
            dgv_datos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_datos.Rows.Add(dr("PRO_ID"), dr("CAT_ID"), dr("PRO_CODIGO"), dr("PRO_DESCRIPCION"), dr("PRO_PRECIO"), dr("PRO_LLEVA_IVA"), dr("PRO_ESTADO"))
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

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            fun_cargarProductos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub dgv_datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellContentClick

    End Sub

    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim frm As New frm_matProducto
                frm.txt_id.Text = dgv_datos.Rows(e.RowIndex).Cells(pos_codigo).Value
                frm.ShowDialog()
                If fun_cargarProductos() = False Then
                    MsgBox("No exitste Informacion")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class