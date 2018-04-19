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
        tbControlUsuarios.SelectedIndex = 0
        If validarDatosEnBlanco() Then
            Dim resultado = clsUser.registrarUsuario(txtNombre.Text, txtApellidos.Text, txtUsuario.Text, txtPW.Text, cbxRights.Text)
            If resultado Then
                MessageBox.Show("Datos registrados con exito", "Nuevo usuario agregado",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Call Usuarios_Load(sender, e)
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

    Private Sub dtgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellClick
        Dim i As Integer

        i = dtgUsuarios.CurrentRow.Index

        txtNombre.Text = dtgUsuarios.Item(0, i).Value()
        txtApellidos.Text = dtgUsuarios.Item(1, i).Value()
        txtUsuario.Text = dtgUsuarios.Item(2, i).Value()
        txtPW.Text = dtgUsuarios.Item(3, i).Value()
        cbxRights.Text = dtgUsuarios.Item(4, i).Value()

        tbControlUsuarios.SelectedIndex = 0
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        tbControlUsuarios.SelectedIndex = 0
        If txtUsuario.Text IsNot "" Then
            Dim resultado = clsUser.borrarUsuario(txtUsuario.Text)
            If resultado Then
                MessageBox.Show("Datos borrados con exito", "El usuario ha sido borrado",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                LimpiarInterfaz()
                Call Usuarios_Load(sender, e)
            Else
                MessageBox.Show("Hubo un error al borra los datos", "El usuario no se pudo borrar",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe digitar un nombre de usuario valido", "El usuario no se pudo borrar",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        tbControlUsuarios.SelectedIndex = 0
        LimpiarInterfaz()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tbControlUsuarios.SelectedIndex = 0
        If validarDatosEnBlanco() Then
            Dim resultado = clsUser.modificarUsuario(txtNombre.Text, txtApellidos.Text, txtUsuario.Text, txtPW.Text, cbxRights.Text)
            If resultado Then
                MessageBox.Show("Datos modificados con exito", "Usuario modificado",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Call Usuarios_Load(sender, e)
            End If
        Else
            MsgBox("Debe ingresar todos los datos" & vbCrLf & "Intentelo de nuevo", vbCritical, "Error")
        End If
    End Sub
End Class