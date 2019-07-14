Public Class frm_mesero_principal

    Dim dtMenus As New DataTable

    Private Sub CargarMenus(id_Perfil As Int32)
        Try
            Dim cadenasql As String = ""
            cadenasql = cadenasql & "select m.* from seg_menu m "
            cadenasql = cadenasql & "where men_estado = 'A'  and men_Id in "
            cadenasql = cadenasql & "(select men_Id from seg_accesos "
            cadenasql = cadenasql & " where per_id=" & id_Perfil & " and acc_estado='A')"

            If Conectar() = False Then
                Exit Sub
            End If

            dr = Execute_reader(cadenasql)
            dtMenus.Load(dr) ' cargar data table a partior de un dataread
            dr.Close()

            For Each MenuPadre As DataRow In dtMenus.Select("men_Id_MenuPadre=0", "men_Posicion ASC")
                Dim Menu As ToolStripItem
                Menu = New ToolStripMenuItem()
                Menu.Name = MenuPadre("men_Id").ToString()
                Menu.Text = MenuPadre("men_Descripcion").ToString()
                Menu.Tag = MenuPadre("men_nombreFrm").ToString()
                'Averiguando si tiene Hijos o no
                If dtMenus.Select("men_Id_MenuPadre=" & MenuPadre("men_Id")).Length = 0 Then
                    'Sino tiene hijos lo agrego a la barra de menu principal
                    MenuPpal.Items.Add(Menu)
                Else
                    'Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                    MenuPpal.Items.Add(Menu)
                    AgregarMenuHijo(Menu)
                End If
            Next
            dtMenus.clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarMenuHijo(MenuItemPadre As ToolStripItem)
        Try
            Dim MenuPadre As ToolStripMenuItem = CType(MenuItemPadre, ToolStripMenuItem)
            'Obtengo el ID del menu Enviado para saber si tiene hijos o no
            Dim Id As String = MenuPadre.Name
            'Averiguando si tiene Hijos o no
            If dtMenus.Select("men_Id_MenuPadre=" & Id).Length = 0 Then
                'Si No tiene Hijos Solo Agrego el Evento
                AddHandler MenuPadre.Click, AddressOf AccionarMenu
            Else
                'Si Aun tiene Hijos
                For Each Menu As DataRow In dtMenus.Select("men_Id_MenuPadre=" & Id, "men_Posicion ASC")
                    Dim NuevoMenu As ToolStripItem
                    NuevoMenu = New ToolStripMenuItem()
                    NuevoMenu.Name = Menu("men_Id").ToString()
                    NuevoMenu.Text = Menu("men_Descripcion").ToString()
                    NuevoMenu.Tag = Menu("men_nombreFrm").ToString()
                    'Averiguo se es un separador
                    If Menu("men_Descripcion").ToString() = "-" Then
                        MenuPadre.DropDownItems.Add(NuevoMenu.Text)
                    Else
                        'Obtengo el ID del Menu del foreach
                        If dtMenus.Select("men_Id_MenuPadre=" & Menu("men_Id")).Length = 0 Then
                            'Sino tiene hijos lo agrego al Menu Padre
                            AddHandler NuevoMenu.Click, AddressOf AccionarMenu
                            MenuPadre.DropDownItems.Add(NuevoMenu)
                        Else
                            'Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                            MenuPadre.DropDownItems.Add(NuevoMenu)
                            AgregarMenuHijo(NuevoMenu)

                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub AccionarMenu(sender As Object, e As EventArgs)
        Try
            If sender.GetType() = GetType(ToolStripMenuItem) Then
                Dim NombreFormulario As String = (CType(sender, ToolStripItem)).Tag.ToString()

                If String.IsNullOrEmpty(NombreFormulario) = True Then
                    Exit Sub
                End If
                Dim nombrecompleto As String = Application.ProductName & "." & NombreFormulario
                Dim FormInstanceType As Type = Type.GetType(nombrecompleto, True, True)
                Dim FRM As Object
                FRM = CType(Activator.CreateInstance(FormInstanceType), Form)
                If EstaAbierto(FRM) Then
                    Exit Sub
                Else
                    FRM.MdiParent = Me
                    FRM.StartPosition = FormStartPosition.CenterScreen
                    FRM.MinimizeBox = False
                    FRM.Show()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function EstaAbierto(ByVal Myform As Form) As Boolean
        Try
            EstaAbierto = False
            For Each objForm In My.Application.OpenForms
                If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                    EstaAbierto = True
                End If
            Next
            Return EstaAbierto
        Catch ex As Exception
            EstaAbierto = False
        End Try
    End Function

    Private Sub frm_mesero_principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim frm As New frm_login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub frm_mesero_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CargarMenus(g_perfil_id)
            lbl_perfil.Text = Obtener_perfil(g_perfil_id)
            lbl_usuario.Text = g_str_nombres
            lbl_fecha.Text = DateTime.Now.ToShortDateString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = Date.Now.ToShortTimeString()
    End Sub
End Class