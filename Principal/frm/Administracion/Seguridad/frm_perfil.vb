Public Class frm_perfil

    Private id_perfil As Integer = 0

    Private Function CargarTablaPerfil() As Boolean

        Try
            CargarTablaPerfil = False

            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_buscar_perfil", txt_buscar.Text)
            dgv_datos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_datos.Rows.Add(dr("per_id"), dr("per_nombre"), dr("per_estado"))
                End While
                CargarTablaPerfil = True
            End If
        Catch ex As Exception
            CargarTablaPerfil = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try

    End Function

    Private Function ValidarDatos() As Boolean
        Try
            ValidarDatos = False

            If (txt_buscar.Text = "") Then
                MsgBox("Ingrese un nombre de perfil", MsgBoxStyle.Information, "Perfil")
                txt_buscar.Focus()
                Exit Function
            End If

            If (txt_descripcion.Text = "") Then
                MsgBox("Ingrese una descripcion ", MsgBoxStyle.Information, "Descripcion")
                txt_descripcion.Focus()
                Exit Function
            End If

            'If (ExistePerfil(txt_buscar.Text)) Then
            Dim cond1 As String = "per_nombre = '" & txt_buscar.Text & "' "
            Dim cond2 As String = "per_estado = 'A' "

            If (ExisteDato("seg_Perfil", cond1, cond2, "per_nombre", txt_buscar.Text) And id_perfil = 0) Then
                MsgBox("El perfil ya se encuentra registrado", MsgBoxStyle.Exclamation, "Perfil")
                Limpiar()
                Exit Function
            End If

            ValidarDatos = True
        Catch ex As Exception
            ValidarDatos = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function Grabar() As Boolean
        Try

            Grabar = False
            Dim nombre As String

            nombre = StrConv(txt_buscar.Text, VbStrConv.Lowercase)

            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_inserta_actualiza_perfil", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@per_id", id_perfil)
            cmd.Parameters.AddWithValue("@per_nombre", nombre)
            cmd.Parameters.AddWithValue("@per_descipcion", txt_descripcion.Text)
            cmd.Parameters.AddWithValue("@per_estado", "A")

            cmd.ExecuteNonQuery()
            Grabar = True

        Catch ex As Exception
            Grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function RecuperarPerfil(texto As String) As Boolean
        Try
            RecuperarPerfil = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from seg_Perfil where per_nombre = '" & texto & "' and per_estado = 'A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    ' MsgBox("Dentro del while")
                    id_perfil = dr("per_id")
                    txt_buscar.Text = dr("per_nombre")
                    txt_descripcion.Text = dr("per_descripcion")

                End While
                RecuperarPerfil = True
            End If

        Catch ex As Exception
            RecuperarPerfil = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub Limpiar()

        txt_buscar.Text = ""
        txt_descripcion.Text = ""
        txt_buscar.Focus()
        id_perfil = 0
    End Sub

    Private Sub frm_perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CargarTablaPerfil() = False Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If (ValidarDatos() = False) Then
                Exit Sub
            End If

            'Proceso para grabar
            If (Grabar()) Then

                If (id_perfil = 0) Then
                    MsgBox("Perfil registrados correctamente", MsgBoxStyle.Information, "Registrado")
                Else
                    MsgBox("Perfil actualizado", MsgBoxStyle.Information, "Actualizado")
                End If
                Limpiar()

                If (CargarTablaPerfil() = False) Then
                    End If
                End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If (txt_buscar.Text = String.Empty) Then
                MsgBox("Digite un perfil para eliminar", MsgBoxStyle.Information, "Perfil")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar el perfil: " & txt_buscar.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then
                'MsgBox("Procediendo a guardar la factura", MsgBoxStyle.Information, "Registrar datos")

                If (EliminarDatos("sp_eliminar_perfil", "@per_id", id_perfil)) Then
                    MsgBox("Perfil eliminado ", MsgBoxStyle.Information, "Perfil")
                    Limpiar()

                    If (CargarTablaPerfil() = False) Then
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            Dim nombre As String

            If e.RowIndex > -1 Then
                nombre = dgv_datos.Rows(e.RowIndex).Cells(1).Value
                RecuperarPerfil(nombre)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscar.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                If (RecuperarPerfil(txt_buscar.Text) = False) Then
                    txt_descripcion.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descripcion.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                btn_grabar.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class