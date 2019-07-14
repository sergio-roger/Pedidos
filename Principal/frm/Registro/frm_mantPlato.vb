Public Class frm_mantPlato

    Private Sub frm_mantPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_opcion.SelectedValue = "Código"

            If BuscarPlato("1") = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function BuscarPlato(opcion As String) As Boolean
        Try
            BuscarPlato = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_buscar_plato", txt_buscar.Text, opcion)
            dgv_usuarios.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_usuarios.Rows.Add(dr("men_id"), dr("men_codigo"),
                        dr("men_plato"), dr("modalidad"), dr("men_precio"), dr("men_estado"))
                End While
                BuscarPlato = True
            End If
        Catch ex As Exception
            BuscarPlato = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            Select Case cmb_opcion.Text
                Case "Código"
                    If BuscarPlato("1") = False Then
                    End If
                Case "Plato"
                    If BuscarPlato("2") = False Then
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                g_str_codigo = dgv_usuarios.Rows(e.RowIndex).Cells(1).Value
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class