Public Class frm_buscarCliente
    Private Sub frm_buscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fun_buscarCliente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub



    Function fun_buscarCliente() As Boolean
        Try
            fun_buscarCliente = False
            Dim cadena_sql As String = ""
            cadena_sql = cadena_sql & "select * "
            cadena_sql = cadena_sql & " from Cliente"
            cadena_sql = cadena_sql & " where cli_estado='A' and cli_apellidos like '" & txt_buscar.Text & "%'"
            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(cadena_sql)
            dgv.Rows.Clear()
            If dr.HasRows Then
                While dr.Read
                    dgv.Rows.Add(dr("cli_cedula"), dr("cli_apellidos"), dr("cli_nombres"), dr("cli_direccion"), dr("cli_celular"))
                End While
            End If
            fun_buscarCliente = True
        Catch ex As Exception
            fun_buscarCliente = False
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try
            If e.RowIndex = -1 Then
                Return
            End If
            g_str_cedula = dgv.Rows(e.RowIndex).Cells(0).Value
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            fun_buscarCliente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class