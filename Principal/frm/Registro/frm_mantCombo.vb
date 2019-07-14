Public Class frm_mantCombo

    Function BuscarCombo(opcion As String) As Boolean
        Try
            BuscarCombo = False
            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_buscar_combo", txt_buscar.Text, opcion)
            dgv_usuarios.Rows.Clear()

            If dr.HasRows Then
                While dr.Read

                    Dim des As String = If(dr("descuento") = True, "Si", "No")

                    dgv_usuarios.Rows.Add(dr("com_id"), dr("com_codigo"),
                     dr("modalidad"), dr("com_contenido1"), dr("com_bebida"), dr("com_precio"),
                    des, dr("porcentaje"), dr("com_estado"))
                End While
                BuscarCombo = True
            End If
        Catch ex As Exception
            BuscarCombo = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub frm_mantCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_opcion.SelectedValue = "Código"

            If BuscarCombo("1") = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            Select Case cmb_opcion.Text
                Case "Código"
                    If BuscarCombo("1") = False Then
                    End If
                Case "Contenido 1"
                    If BuscarCombo("2") = False Then
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