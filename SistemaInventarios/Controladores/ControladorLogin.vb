Module ControladorLogin
    Public Sub VerificacionDatos(Usuario As String, Contraseña As String)
        ' Call conectarBD()
        If Usuario <> "" And Contraseña <> "" Then

            LoginUsuario(Usuario, Contraseña)


        Else
            MsgBox("Falta ingresar usuario o contraseña", vbCritical)

        End If
    End Sub

End Module
