Imports Lavacar.Cls_Usuario
Imports System.Configuration
Public Class Inicio



    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim resultado = clsUser.inicioSesión(txtUser.Text, txtPW.Text)

        If resultado Then
            ConfigurationSettings.AppSettings("usuarioActual") = txtUser.Text
            Pantalla.Show()
            Me.Hide()
            txtUser.Text = ""
            txtPW.Text = ""
        Else
            MsgBox("La contraseña o usuario es incorrecto" & vbCrLf & "Escriba nuevamente la contraseña y usuario.", vbCritical, "Error")
        End If
    End Sub
End Class
