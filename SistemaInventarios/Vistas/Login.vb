Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnIngresa_Click(sender As Object, e As EventArgs) Handles BtnIngresa.Click
        Call VerificacionDatos(TxtUsuario.Text, TxtPass.Text)



    End Sub
End Class
