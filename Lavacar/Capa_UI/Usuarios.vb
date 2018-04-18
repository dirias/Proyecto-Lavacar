Imports Lavacar.Cls_Usuario

Public Class Usuarios

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbLujan21DataSet.tblAdmi' table. You can move, or remove it, as needed.
        Me.TblAdmiTableAdapter.Fill(Me.DbLujan21DataSet.tblAdmi)
        LimpiarInterfaz()
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        tbControlUsuarios.SelectedIndex = 1
    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        If validarDatosEnBlanco() Then
            Dim resultado = clsUser.registrarUsuario(txtNombre.Text, txtApellidos.Text, txtUsuario.Text, txtPW.Text, cbxRights.Text)
            If resultado Then
                MessageBox.Show("Datos registrados con exito", "Nuevo usuario agregado",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                LimpiarInterfaz()
            End If
        Else
            MsgBox("Debe ingresar todos los datos" & vbCrLf & "Intentelo de nuevo", vbCritical, "Error")
        End If
    End Sub

    Public Function validarDatosEnBlanco()
        If ((txtNombre.Text IsNot "") Or (txtApellidos.Text IsNot "") Or (txtPW.Text IsNot "") Or (txtUsuario.Text IsNot "") Or (cbxRights.SelectedIndex >= 1)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub LimpiarInterfaz()
        txtNombre.Text = ""
        txtApellidos.Text = ""
        txtUsuario.Text = ""
        txtPW.Text = ""
        cbxRights.SelectedIndex = -1
    End Sub
End Class