Public Class Inicio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt1.Text = "andres" And txt2.Text = "123" Then
            Pantalla.Show()
            Me.Hide()
            txt1.Text = ""
            txt2.Text = ""
        Else
            MsgBox("La contraseña o usuario es incorrecto" & vbCrLf & "Escriba nuevamente la contraseña y usuario.", vbCritical, "Error")
        End If

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
