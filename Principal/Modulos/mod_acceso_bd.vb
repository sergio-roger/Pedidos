Imports System.Data.SqlClient

Module mod_acceso_bd

    'Public g_str_servidor As String = "DESKTOP-D911EGN\SQLEXPRESS"
    'Public g_str_bd As String = "sexto_2019"
    'Public g_str_usuario_bd As String = "sergio"
    'Public g_str_clave_bd As String = "123roger"

    Public str_coneccion As String
    Public cnn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Public Function Conectar() As Boolean
        Try
            Conectar = False
            cnn = New SqlConnection
            cnn.ConnectionString = str_coneccion

            If (cnn.State = ConnectionState.Closed) Then
                cnn.Open()
                Conectar = True

            End If

        Catch ex As Exception
            Conectar = False
        End Try
    End Function

    Public Function Desconectar() As Boolean
        Try
            Desconectar = False

            If (cnn.State = ConnectionState.Open) Then
                cnn.Close()
                Desconectar = True

            End If
        Catch ex As Exception
            Desconectar = False
        End Try
    End Function

    'Función que permite hacer consultas
    Public Function Execute_reader(ByVal str_consulta As String) As SqlDataReader

        Try
            cmd = New SqlCommand
            cmd.CommandText = str_consulta
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Return cmd.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Function Execute_nonquery(cadena As String) As Boolean
        Try
            Execute_nonquery = False
            'Insert /update / delete
            cmd = New SqlCommand
            cmd.CommandText = cadena
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Execute_reader(ByVal cadenasql As String, ByVal ParamArray parametro() As String) As SqlDataReader
        Try
            Dim i As Integer
            cmd = New SqlCommand
            cmd.CommandText = cadenasql
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cargar los parámetros
            SqlCommandBuilder.DeriveParameters(cmd) 'trae los parámetros
            For i = 1 To parametro.Length
                CType(cmd.Parameters(i), SqlParameter).Value = parametro(i - 1)
            Next
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Execute_nonquery(ByVal procedimiento As String, ByVal ParamArray parametro() As String) As Boolean
        Dim i As Integer
        Try
            'graba o actualiza
            cmd = New SqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cargar los parametros
            SqlCommandBuilder.DeriveParameters(cmd) 'trae los parametros
            For i = 1 To parametro.Length
                CType(cmd.Parameters(i), SqlParameter).Value = parametro(i - 1)
            Next

            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function fun_iniciatransaccion() As Boolean
        Try
            fun_iniciatransaccion = False
            Dim cadenasql As String
            cadenasql = "BEGIN TRAN miproceso"

            If Execute_nonquery(cadenasql) = True Then
                fun_iniciatransaccion = True
            Else
                MsgBox("No se Pudo Iniciar la Transacción")
                fun_iniciatransaccion = False
            End If
        Catch ex As Exception
            fun_iniciatransaccion = False
        End Try
    End Function

    Public Function fun_commit() As Boolean
        Try
            fun_commit = False
            Dim cadenasql As String
            cadenasql = "COMMIT TRAN miproceso"
            If Execute_nonquery(cadenasql) = True Then
                fun_commit = True
            End If
        Catch ex As Exception
            fun_commit = False
        End Try
    End Function

    Public Function fun_rolbak() As Boolean
        Try
            fun_rolbak = False
            Dim cadenasql As String
            cadenasql = "ROLLBACK TRAN miproceso"
            If Execute_nonquery(cadenasql) = True Then
                fun_rolbak = True
            End If
        Catch ex As Exception
            fun_rolbak = False
        End Try
    End Function
End Module
