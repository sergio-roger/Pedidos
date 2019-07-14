Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions

Module mod_FuncionesGlobales
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Public Sub sub_convertirmayusculas(ByVal txt As TextBox)
        txt.Text = UCase(txt.Text)
        txt.SelectionStart = Len(txt.Text)
    End Sub

    Public Function fun_validafecha(ByVal strfecha As String) As Boolean
        Try
            fun_validafecha = False
            Dim intfecha As Integer
            intfecha = Len(strfecha)
            If intfecha <> 10 Then
                Exit Function
            End If
            If IsDate(strfecha) Then
                fun_validafecha = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_validafecha = False
        End Try
    End Function

    Public Function fun_validacedula(ByVal cedula As String) As Boolean
        fun_validacedula = False
        Dim tamanioc As Integer
        tamanioc = Int(Len(cedula))
        Dim u_digito, i As Integer
        Dim ST, SP, SI, digitov, SD As Integer
        ST = 0
        SP = 0
        SI = 0
        If tamanioc = 10 And IsNumeric(cedula) Then

            u_digito = Int(Mid(cedula, 10, 1))
            For i = 1 To 9
                If (i Mod 2) = 0 Then
                    'par
                    SP = SP + Int(Mid(cedula, i, 1))
                Else
                    'impar
                    If (Int(Mid(cedula, i, 1)) * 2) > 9 Then
                        SI = SI + ((Int(Mid(cedula, i, 1)) * 2) - 9)
                    Else
                        SI = SI + (Int(Mid(cedula, i, 1)) * 2)
                    End If
                End If
            Next
            ST = SP + SI
            SD = ST
            If (SD Mod 10) = 0 Then
                digitov = 0
            Else
                While ((SD Mod 10) <> 0)
                    SD = SD + 1
                End While
                digitov = SD - ST
            End If
            If digitov = u_digito Then
                fun_validacedula = True
            Else
                fun_validacedula = False
            End If
        Else
            fun_validacedula = False
        End If
    End Function

    Public Function fun_preguntaRespuesta(ByVal pregunta As String) As MsgBoxResult
        Try
            Dim style As MsgBoxStyle

            Dim respuesta As MsgBoxResult
            Dim mensaje, titulo As String
            mensaje = pregunta
            titulo = "Sistema de Registro de Ventas"
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
            respuesta = MsgBox(mensaje, style, titulo)
            Return respuesta
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try
    End Function

    'Funciones para encriptar la clave
    Public Function Encriptar(ByVal texto As String) As String
        Dim a As String
        Dim b As Integer
        Dim encri As String = ""

        a = UCase(texto)
        For b = 1 To Len(a)
            encri = encri & "0" & Asc(Mid(a, b, 1))
        Next b
        Return encri

    End Function

    Public Function PreguntaRespuesta(mensaje As String, titulo As String) As MsgBoxResult

        Dim respuesta As MsgBoxResult = Nothing
        Dim style As MsgBoxStyle

        Try
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
            respuesta = MsgBox(mensaje, style, titulo)

            Return respuesta
        Catch ex As Exception
            respuesta = MsgBoxResult.No
            Return respuesta
        End Try
    End Function

    Public Sub mensaje(titulo As String, detalle As String, tipo As String)
        Select Case tipo
            Case "info"
                MsgBox(detalle, MsgBoxStyle.Information, titulo)
            Case "danger"
                MsgBox(detalle, MsgBoxStyle.Critical, titulo)
            Case "alert"
                MsgBox(detalle, MsgBoxStyle.Exclamation, titulo)
        End Select
    End Sub

    Public Function Agregar_cero(numero As String) As String
        Dim ad As String = ""

        If (numero.Length = 4) Then
            ad = "0" & numero
        Else
            ad = numero
        End If
        Return ad
    End Function

    Public Function Obtener_perfil(id As Integer) As String
        Dim per As String = ""
        Try
            Dim str_cadena_sql As String = "select per_nombre from seg_Perfil where per_id = " & id

            '1.- Conectar a la bd
            If (Conectar() = False) Then
                Exit Function
            End If

            '2.- Hacer la tarea dentro de la bd 
            dr = Execute_reader(str_cadena_sql)

            If (dr.HasRows) Then  'Si trae filas
                While (dr.Read)
                    Return StrConv(dr("per_nombre"), VbStrConv.Uppercase)
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return per
        Finally
            '3.- No te olvides de desconectar la bd
            Desconectar()
            dr.Close()
        End Try
    End Function
End Module
