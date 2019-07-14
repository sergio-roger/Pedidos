Public Class frm_mesa

    Private id_mesa As Integer = 0

    Private Function CargarTablaMesa() As Boolean

        Try
            CargarTablaMesa = False

            If Conectar() = False Then
                Exit Function
            End If

            dr = Execute_reader("sp_buscar_mesa", txt_codigo.Text)
            dgv_datos.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    dgv_datos.Rows.Add(dr("mesa_id"), dr("mesa_codigo"), dr("mesa_n_asientos"), dr("mesa_estado"))
                End While
                CargarTablaMesa = True
            End If
        Catch ex As Exception
            CargarTablaMesa = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try

    End Function

    Private Sub Limpiar()
        txt_codigo.Text = ""
        txt_asientos.Text = ""
        txt_descripcion.Text = ""
        id_mesa = 0
        txt_codigo.Focus()
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            ValidarDatos = False

            If (txt_codigo.Text = "") Then
                MsgBox("Ingrese un código para la mesa", MsgBoxStyle.Information, "Codigo para Mesa")
                txt_codigo.Focus()
                Exit Function
            End If

            If (txt_asientos.Text = "") Then
                MsgBox("Ingrese cantidad de asientos", MsgBoxStyle.Information, "Cantidad Asientos")
                txt_asientos.Focus()
                Exit Function
            End If

            If (ExisteMesa(txt_codigo.Text) And id_mesa = 0) Then
                MsgBox("El codigo ya se encuentra registrado", MsgBoxStyle.Exclamation, "Mesa")
                Limpiar()
                Exit Function
            End If

            ValidarDatos = True
        Catch ex As Exception
            ValidarDatos = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function ExisteMesa(texto As String) As Boolean
        Try
            ExisteMesa = False

            Dim cadenasql As String = "select mesa_codigo from Mesa where mesa_estado = 'A' and mesa_codigo = '" & texto & "'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(cadenasql)

            If (dr.HasRows) Then
                While (dr.Read)
                    If (texto = dr("mesa_codigo")) Then
                        Return True
                    End If
                End While
            End If
        Catch ex As Exception
            ExisteMesa = False
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

            cmd = New SqlClient.SqlCommand("sp_inserta_actualiza_mesa_2", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@mesa_id", id_mesa)
            cmd.Parameters.AddWithValue("@mesa_n_asientos", CInt(txt_asientos.Text))
            cmd.Parameters.AddWithValue("@mesa_estado", "A")
            cmd.Parameters.AddWithValue("@mesa_codigo", txt_codigo.Text)
            cmd.Parameters.AddWithValue("@mesa_descripcion", txt_descripcion.Text)

            cmd.ExecuteNonQuery()
            Grabar = True

        Catch ex As Exception
            Grabar = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Private Function RecuperarMesa(texto As String) As Boolean
        Try
            RecuperarMesa = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = "select * from Mesa where mesa_codigo = '" & texto & "' and mesa_estado = 'A'"

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(str_cadenaSql)

            If (dr.HasRows) Then
                While (dr.Read)
                    id_mesa = dr("mesa_id")
                    txt_codigo.Text = dr("mesa_codigo")
                    txt_asientos.Text = dr("mesa_n_asientos")
                    txt_descripcion.Text = dr("mesa_descripcion")

                End While
                RecuperarMesa = True
            End If

        Catch ex As Exception
            RecuperarMesa = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function


    Private Sub frm_mesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CargarTablaMesa() = False Then
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

                If (id_mesa = 0) Then
                    MsgBox("Mesa registrados correctamente", MsgBoxStyle.Information, "Registrado")
                Else
                    MsgBox("Mesa actualizado", MsgBoxStyle.Information, "Actualizada")
                End If
                Limpiar()

                If (CargarTablaMesa() = False) Then
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                If (RecuperarMesa(txt_codigo.Text) = False) Then
                    txt_asientos.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_asientos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_asientos.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                txt_descripcion.Focus()
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

    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            Dim codigo As String

            If e.RowIndex > -1 Then
                codigo = dgv_datos.Rows(e.RowIndex).Cells(1).Value
                RecuperarMesa(codigo)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If (txt_codigo.Text = String.Empty) Then
                MsgBox("Digite un codigo de mesa a eliminar", MsgBoxStyle.Information, "Mesa")
                Exit Sub
            End If

            If (PreguntaRespuesta("Desea eliminar la mesa: " & txt_codigo.Text & " ? ", "Confirmar") = MsgBoxResult.Yes) Then

                If (EliminarDatos("sp_eliminar_mesa", "@mesa_id", id_mesa) = True) Then
                    MsgBox("Mesa eliminado ", MsgBoxStyle.Information, "Mesa")
                    Limpiar()
                    If (CargarTablaMesa() = False) Then
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class