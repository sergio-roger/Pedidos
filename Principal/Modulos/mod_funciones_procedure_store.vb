Module mod_funciones_procedure_store

    Public Function EliminarDatos(nombre_procedimiento As String, campo As String, id As Integer) As Boolean
        Try
            EliminarDatos = False

            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand(nombre_procedimiento, cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue(campo, id)

            cmd.ExecuteNonQuery()

            EliminarDatos = True
        Catch ex As Exception
            EliminarDatos = False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Public Function ExisteDato(tabla As String, condicion_busqueda As String, condicion_estado As String, campo_busqueda As String, texto_busqueda As String) As Boolean
        Try
            ExisteDato = False

            Dim cadenasql As String = "select * from " & tabla
            cadenasql = cadenasql & " where " & condicion_busqueda & " "
            cadenasql = cadenasql & " and " & condicion_estado

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(cadenasql)

            If (dr.HasRows) Then
                While (dr.Read)
                    If (texto_busqueda = dr(campo_busqueda)) Then
                        Return True
                    End If
                End While
            End If
        Catch ex As Exception
            ExisteDato = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Public Function CargarCombo(cadena As String, campo_id As String, campo_llenar As String, ByRef combo As ComboBox) As Boolean
        Try
            CargarCombo = False

            If (Conectar() = False) Then
                Exit Function
            End If

            dr = Execute_reader(cadena)

            If (dr.HasRows) Then
                Dim dt As New DataTable
                dt.Load(dr)
                combo.DataSource = dt
                combo.DisplayMember = campo_llenar
                combo.ValueMember = campo_id
                CargarCombo = True
            Else
                CargarCombo = False
            End If

        Catch ex As Exception
            CargarCombo = False
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Public Function ObtenerId(cadenaSql As String, campo_id As String) As Long
        Try
            ObtenerId = 0

            If Conectar() = False Then
                Exit Function
            End If
            dr = Execute_reader(cadenaSql)

            If dr.HasRows Then
                While dr.Read
                    ObtenerId = dr(campo_id)
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ObtenerId = 0
        Finally
            dr.Close()
            Desconectar()
        End Try
    End Function

    Public Function ActualizarPedido(idPedido As Integer, idEstado As Integer) As Boolean

        Try
            ActualizarPedido = False
            If (Conectar() = False) Then
                Exit Function
            End If

            cmd = New SqlClient.SqlCommand("sp_despachar_pedido", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id_pedido", idPedido)
            cmd.Parameters.AddWithValue("@id_estado", idEstado)

            cmd.ExecuteNonQuery()
            ActualizarPedido = True

        Catch ex As Exception
            ActualizarPedido = False
            MsgBox(ex.Message)
        End Try
    End Function
End Module
