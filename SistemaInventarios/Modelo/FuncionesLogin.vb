Imports System.Data.SqlClient

Module FuncionesLogin
    Public IDUsuarioPubl, UsuarioPubl, TipoUsuarioPubl, SucursalPubl As String


    Public Sub LoginUsuario(Usuario As String, Contraseña As String)
        'Try
        Call conectarBD()

        Dim comando As New SqlCommand("Select IDUsuario, Usuario, TipoUsuario,Password, Sucursal, CambioPass From VW_Usuarios where Usuario='" + Usuario + "'  ", ConInventarios)
        Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)
            ConInventarios.Close()

            Dim IDUsuario, UsuarioConsult, TipoUsuario, Password, Sucursal, CambioPasss As String
            IDUsuario = Convert.ToString(dt.Rows(0)("IDUsuario"))
            UsuarioConsult = Convert.ToString(dt.Rows(0)("Usuario"))
            TipoUsuario = Convert.ToString(dt.Rows(0)("TipoUsuario"))
            Password = Convert.ToString(dt.Rows(0)("Password"))
            Sucursal = Convert.ToString(dt.Rows(0)("Sucursal"))
        CambioPasss = Convert.ToString(dt.Rows(0)("CambioPass"))
        If Password = Contraseña Then
                If CambioPasss = "si" Then
                    Dim frmCambioContraseña As New CambioContraseña
                    frmCambioContraseña.ShowDialog()
                Else
                    IDUsuarioPubl = IDUsuario
                    UsuarioPubl = Usuario
                    TipoUsuarioPubl = TipoUsuario
                    SucursalPubl = Sucursal
                Dim frmLogin As New Login
                frmLogin.Close()
                Dim frmMenuPrincipal As New MenuPrincipal
                frmMenuPrincipal.Show()
            End If

            Else
                MsgBox("Contraseña Incorrecta", vbCritical)

            End If

        'Catch ex As Exception
        '    MsgBox("El usuario no existe", vbCritical)

        'End Try

    End Sub


End Module
