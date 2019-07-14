Public Class frm_buscar_usuario

    Private Sub frm_buscar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_opcion.SelectedValue = "Apellidos"

            If Buscar_usuario("2") = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Buscar_usuario(opcion As String) As Boolean
        Try
            Buscar_usuario = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_Buscar_usuario", txt_buscar.Text, opcion)
            dgv_usuarios.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_usuarios.Rows.Add(dr("usu_cedula"),
                        dr("nombres"), dr("per_nombre"), dr("usu_estado"))
                End While
                Buscar_usuario = True
            End If
        Catch ex As Exception
            Buscar_usuario = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            Select Case cmb_opcion.Text
                Case "Cedula"
                    If Buscar_usuario("1") = False Then
                    End If
                Case "Apellidos"
                    If Buscar_usuario("2") = False Then
                    End If
                Case "Nombres"
                    If Buscar_usuario("3") = False Then
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