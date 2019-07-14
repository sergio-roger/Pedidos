Public Class frm_modalidad_aux
    Private id_modadalidad As Integer = 0

    Private Function CargarTablaModalidad() As Boolean
        Try
            CargarTablaModalidad = False

            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_buscar_modalidad", txt_descripcion.Text)
            dgv_datos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_datos.Rows.Add(dr("mod_id"), dr("mod_descripcion"), dr("mod_hora_empieza"), dr("mod_hora_termina"), dr("mod_estado"))
                End While
                CargarTablaModalidad = True
            End If
        Catch ex As Exception
            CargarTablaModalidad = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Public Sub Limpiar()
        id_modadalidad = 0
        txt_descripcion.Text = ""
        date_hora_empieza.Value = Date.Parse("00:00")
        date_hora_termina.Value = Date.Parse("00:00")
        txt_descripcion.Focus()
    End Sub

    Private Function RecuperarModalidad(texto As String) As Boolean
        Try
            RecuperarModalidad = False
            Dim hora_empieza As String
            Dim hora_termina As String

            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from Modalidad where mod_estado = 'A' and mod_descripcion = '" & texto & "'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    ' MsgBox("Dentro del while")
                    id_modadalidad = dr("mod_id")
                    txt_descripcion.Text = dr("mod_descripcion")
                    hora_empieza = String.Format(dr("mod_hora_empieza").ToString, "HH:mm:ss")
                    hora_termina = String.Format(dr("mod_hora_termina").ToString, "HH:mm:ss")

                    date_hora_empieza.Value = Date.Parse(hora_empieza)
                    date_hora_termina.Value = Date.Parse(hora_termina)

                End While
                RecuperarModalidad = True
            End If

        Catch ex As Exception
            RecuperarModalidad = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub frm_modalidad_aux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CargarTablaModalidad() = False Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ExisteDescripcion(texto As String) As Boolean
        Try
            ExisteDescripcion = False

            Dim cadenasql As String = "select * from Modalidad where mod_estado = 'A' and mod_descripcion = '" & texto & "'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(cadenasql)

            If (dr.HasRows) Then
                While (dr.Read)
                    If (texto = dr("mod_descripcion")) Then
                        Return True
                    End If
                End While
            End If
        Catch ex As Exception
            ExisteDescripcion = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar()
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            ValidarDatos = False

            If (txt_descripcion.Text = "") Then
                MsgBox("Ingrese una modalidad", MsgBoxStyle.Information, "Modalidad")
                txt_descripcion.Focus()
                Exit Function
            End If

            If (ExisteDescripcion(txt_descripcion.Text) And id_modadalidad = 0) Then
                MsgBox("La modalidad " & txt_descripcion.Text & " ya está registrada", MsgBoxStyle.Exclamation, "Modalidad")
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

            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_insertar_eliminar_modalidad", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@mod_id", id_modadalidad)
            cmd.Parameters.AddWithValue("@mod_descripcion", txt_descripcion.Text)
            cmd.Parameters.AddWithValue("@mod_hora_empieza", date_hora_empieza.Value.ToShortTimeString)
            cmd.Parameters.AddWithValue("@mod_hora_termina", date_hora_termina.Value.ToShortTimeString)
            cmd.Parameters.AddWithValue("@mod_estado", "A")

            cmd.ExecuteNonQuery()
            Grabar = True

        Catch ex As Exception
            Grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If (ValidarDatos() = False) Then
                Exit Sub
            End If

            'Proceso para grabar
            If (Grabar()) Then

                If (id_modadalidad = 0) Then
                    MsgBox("Modalidad registrados correctamente", MsgBoxStyle.Information, "Modalidad")
                Else
                    MsgBox("Modalidad actualizada", MsgBoxStyle.Information, "Actualizado")
                End If
                Limpiar()

                If (CargarTablaModalidad() = False) Then
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
            If (txt_descripcion.Text = String.Empty) Then
                MsgBox("Digite una modalidad a eliminar", MsgBoxStyle.Information, "Modalidad")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar la modalidad: " & txt_descripcion.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then

                If (EliminarDatos("sp_eliminar_modalidad", "@mod_id", id_modadalidad)) Then
                    MsgBox("Modalidad Eliminada ", MsgBoxStyle.Information, "Modalidad")
                    Limpiar()
                    If (CargarTablaModalidad() = False) Then
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
                RecuperarModalidad(nombre)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descripcion.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                If (RecuperarModalidad(txt_descripcion.Text) = False) Then
                    txt_descripcion.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class