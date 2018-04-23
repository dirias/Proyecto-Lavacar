Public Class Extras
    Public Sub limpiarPantalla()
        txtCosto.Clear()
        txtNombre.Clear()
    End Sub

    Public Function validarDatosBlanco()
        If txtCosto.Text = "" And txtNombre.Text = "" Then
            MessageBox.Show("Debe ingresar todos los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnCrearExtra_Click(sender As Object, e As EventArgs) Handles btnRegistrarExtra.Click
        If validarDatosBlanco() Then
            Dim resultado = clsExtra.registrarExtra(txtNombre.Text, txtCosto.Text)
            If resultado Then
                Extras_Load(sender, e)
                MessageBox.Show("Extra registrada", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe registrar el nombre de la extra que desea eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim resultado = clsExtra.borrrarExtra(txtNombre.Text)
            If resultado Then
                Extras_Load(sender, e)
                MessageBox.Show("Extra eliminada", "Borrado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbLujan21DataSet4.tblExtras' table. You can move, or remove it, as needed.
        Me.TblExtrasTableAdapter.Fill(Me.DbLujan21DataSet4.tblExtras)
        limpiarPantalla()


    End Sub

    Private Sub dtgExtras_DoubleClick(sender As Object, e As EventArgs) Handles dtgExtras.DoubleClick
        Dim i As Integer

        i = dtgExtras.CurrentRow.Index

        txtNombre.Text = dtgExtras.Item(1, i).Value()
        txtCosto.Text = dtgExtras.Item(2, i).Value()
        btnModificar.Enabled = True
        tbControlUsuarios.SelectedIndex = 0
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If validarDatosBlanco() Then
            Dim i As Integer

            i = dtgExtras.CurrentRow.Index
            Dim id = dtgExtras.Item(0, i).Value()
            Dim resultado = clsExtra.modificarExtra(id, txtNombre.Text, txtCosto.Text)
            If resultado Then
                Extras_Load(sender, e)
                MessageBox.Show("Extra modificada", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnModificar.Enabled = False
            End If
        End If
    End Sub
End Class