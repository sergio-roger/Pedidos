Public Class frm_login

    Private Function Leer_archivo_conexion() As Boolean
        Try
            Leer_archivo_conexion = False

            Dim g_str_servidor As String = ""
            Dim g_str_bd As String = ""
            Dim g_str_usuario_bd As String = ""
            Dim g_str_clave_bd As String = ""

            Dim directorio = System.AppDomain.CurrentDomain.BaseDirectory & "Datos-coneccion.txt" 'Obtengo donde se encuentra el .exe
            Dim obj_leer As New IO.StreamReader(directorio)
            Dim vector_txt As New ArrayList()
            Dim linea_txt As String = ""

            Do
                linea_txt = obj_leer.ReadLine

                If (Not linea_txt Is Nothing) Then
                    vector_txt.Add(linea_txt)
                End If
            Loop Until linea_txt Is Nothing

            obj_leer.Close()
            Dim cadena As String = ""

            For Each linea_txt In vector_txt
                cadena = cadena & linea_txt
            Next

            Dim partes = cadena.Split(":")
            g_str_servidor = partes(1)
            g_str_bd = partes(3)
            g_str_usuario_bd = partes(5)
            g_str_clave_bd = partes(7)
            g_str_formatoFecBd = partes(9)

            If (g_str_usuario_bd = "") Then
                'Conectar sin 
                str_coneccion = "Data Source=" & g_str_servidor & ";Initial Catalog=" & g_str_bd & ";Integrated Security=true;"
            Else
                'Conectar con clave
                str_coneccion = "Data Source=" & g_str_servidor & ";Initial Catalog=" & g_str_bd & ";User ID=" & g_str_usuario_bd & ";password=" & g_str_clave_bd
            End If

            Leer_archivo_conexion = True

        Catch ex As Exception
            Leer_archivo_conexion = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function Verificar_usuario(usuario As String, contra As String) As Boolean
        Try
            Verificar_usuario = False

            Dim clave_encri As String = ""
            clave_encri = Encriptar(contra)

            Dim str_cadena_sql As String = "select * from seg_Usuarios where  usu_usuario = '" & usuario & "' and usu_clave = '" & clave_encri & "'"

            '1.- Conectar a la bd
            If (Conectar() = False) Then
                Exit Function
            End If

            '2.- Hacer la tarea dentro de la bd 
            dr = Execute_reader(str_cadena_sql)

            If (dr.HasRows) Then  'Si trae filas
                While (dr.Read)
                    g_str_nombres = dr("usu_nombres") & " " & dr("usu_apellidos")
                    g_perfil_id = dr("per_id")
                    g_int_id_usuario = dr("usu_id")
                End While
                Verificar_usuario = True
            Else
                Verificar_usuario = False
            End If

        Catch ex As Exception
            Verificar_usuario = False
            MsgBox(ex.Message)
        Finally

            '3.- No te olvides de desconectar la bd
            Desconectar()
            dr.Close()
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            Validar = False

            If txt_usuario.Text = "" Then
                MsgBox("Ingrese el usuario", MsgBoxStyle.Information, "Usuario")
                Validar = False
                txt_usuario.Focus()
            End If

            If (txt_clave.Text = "") Then
                MsgBox("Ingrese clave", MsgBoxStyle.Information, "Clave")
                txt_clave.Focus()
                Exit Function
            End If
            Validar = True

        Catch ex As Exception
            Validar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Limpiar()
        txt_clave.Text = ""
        txt_usuario.Text = ""
        txt_usuario.Focus()
    End Sub

    Private Function Mesero(perfil_id As Integer) As Boolean
        Try
            Mesero = False
            Dim str_cadena_sql As String = "select * from seg_Perfil p where p.per_id = " & perfil_id & " and p.per_nombre like 'mesero'"

            '1.- Conectar a la bd
            If (Conectar() = False) Then
                Exit Function
            End If

            '2.- Hacer la tarea dentro de la bd 
            dr = Execute_reader(str_cadena_sql)

            If (dr.HasRows) Then  'Si trae filas
                While (dr.Read)
                    g_str_mesero = StrConv(dr("per_nombre"), VbStrConv.ProperCase)
                End While
                Mesero = True
            Else
                Mesero = False
            End If

        Catch ex As Exception
            Mesero = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btn_salir_MouseHover(sender As Object, e As EventArgs) Handles btn_salir.MouseHover
        btn_salir.BackColor = Color.Red

    End Sub

    Private Sub btn_salir_MouseLeave(sender As Object, e As EventArgs) Handles btn_salir.MouseLeave
        btn_salir.BackColor = Color.DimGray
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Try
            If Validar() = False Then
                Exit Sub
            End If

            If (Verificar_usuario(txt_usuario.Text, txt_clave.Text) = True) Then

                If (Mesero(g_perfil_id) = False) Then
                    Dim prin As New frm_principal
                    prin.Show()
                Else
                    Dim frm As New frm_mesero_principal
                    frm.Show()
                End If
                Me.Hide()

            Else
                MsgBox("Clave de accesso incorrecta", MsgBoxStyle.Critical, "Datos Incorrectos")
                Limpiar()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_usuario.Focus()
            g_str_mesero = ""

            If (Leer_archivo_conexion() = False) Then
                MsgBox("Error al cargar parametros de conexion, comunique al proveedor")
                Me.Dispose()
            Else
                'MsgBox("Coneccion exitosa :v papu")
            End If

            If (Conectar() = False) Then
                MsgBox("Error al conectar, comunicar al proveedor")
                Me.Dispose()
            Else
                Desconectar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                txt_clave.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clave.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                btn_iniciar.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class