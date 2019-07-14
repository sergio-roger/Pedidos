Public Class frm_sexo

    Private id_sexo As Integer = 0

    Private Sub Limpiar()
        txt_sexo.Text = ""
        id_sexo = 0
        txt_sexo.Focus()
    End Sub

    Private Function ValidarDatos() As Boolean
        Try

            ValidarDatos = False

            If (txt_sexo.Text = "") Then
                MsgBox("Ingrese un género", MsgBoxStyle.Information, "Genero")
                txt_sexo.Focus()
                Exit Function
            End If

            If (ExisteGenero(txt_sexo.Text)) Then
                MsgBox("Este genero ya se encuentra registrado", MsgBoxStyle.Exclamation, "Genero")
                txt_sexo.Text = ""
                txt_sexo.Focus()
                Exit Function
            End If

            ValidarDatos = True

        Catch ex As Exception
            ValidarDatos = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function ExisteGenero(texto As String) As Boolean
        Try
            ExisteGenero = False

            Dim cadenasql As String = "select * from Sexo where sex_descripcion = '" & texto & "' and sex_estado = 'A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(cadenasql)

            If (dr.HasRows) Then
                While (dr.Read)
                    If (texto = dr("sex_descripcion")) Then
                        Return True
                    End If
                End While
            End If
        Catch ex As Exception
            ExisteGenero = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Function CargarTablaGenero() As Boolean

        Try
            CargarTablaGenero = False

            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_buscar_genero", txt_sexo.Text)
            dgv_datos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_datos.Rows.Add(dr("sex_id"), dr("sex_descripcion"), dr("sex_estado"))
                End While
                CargarTablaGenero = True
            End If
        Catch ex As Exception
            CargarTablaGenero = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try

    End Function

    Private Function RecuperarGenero(texto As String) As Boolean
        Try
            RecuperarGenero = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from Sexo where sex_descripcion = '" & texto & "' and sex_estado = 'A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    id_sexo = dr("sex_id")
                    txt_sexo.Text = dr("sex_descripcion")

                End While
                RecuperarGenero = True
            End If

        Catch ex As Exception
            RecuperarGenero = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Function Grabar() As Boolean
        Try

            Grabar = False

            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_insertar_actualizar_genero", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@sex_id", id_sexo)
            cmd.Parameters.AddWithValue("@sex_descripcion", txt_sexo.Text)
            cmd.Parameters.AddWithValue("@sex_estado", "A")

            cmd.ExecuteNonQuery()
            Grabar = True

        Catch ex As Exception
            Grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Sub frm_sexo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Limpiar()
            If CargarTablaGenero() = False Then
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
                RecuperarGenero(nombre)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_sexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sexo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                If (RecuperarGenero(txt_sexo.Text) = False) Then
                    btn_grabar.Focus()
                End If
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

                If (id_sexo = 0) Then
                    MsgBox("Género registrados correctamente", MsgBoxStyle.Information, "Registrado")
                Else
                    MsgBox("Género actualizado", MsgBoxStyle.Information, "Actualizado")
                End If
                Limpiar()

                If (CargarTablaGenero() = False) Then
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
            If (txt_sexo.Text = String.Empty) Then
                MsgBox("Digite un genero para eliminar", MsgBoxStyle.Information, "Genero")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar el género: " & txt_sexo.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then

                If (EliminarDatos("sp_eliminar_sexo", "@sex_id", id_sexo) = True) Then
                    MsgBox("Género eliminado ", MsgBoxStyle.Information, "Género")
                    Limpiar()
                    If (CargarTablaGenero() = False) Then
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_sexo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Limpiar()
    End Sub
End Class