Public Class frm_mantCliente

    Function BuscarCliente(opcion As String) As Boolean
        Try
            BuscarCliente = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_Buscar_Cliente", txt_buscar.Text, opcion)
            dgv_usuarios.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_usuarios.Rows.Add(dr("cli_cedula"),
                        dr("nombres"), dr("cli_estado"))
                End While
                BuscarCliente = True
            End If
        Catch ex As Exception
            BuscarCliente = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub frm_mantCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_opcion.SelectedValue = "Cedula"

            If BuscarCliente("1") = False Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            Select Case cmb_opcion.Text
                Case "Cedula"
                    If BuscarCliente("1") = False Then
                    End If
                Case "Apellidos"
                    If BuscarCliente("2") = False Then
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                g_str_cedula = dgv_usuarios.Rows(e.RowIndex).Cells(0).Value
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class