Public Class Paquetes


    Private Sub Paquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbLujan21DataSet2.tblPaquetes' table. You can move, or remove it, as needed.
        Me.TblPaquetesTableAdapter1.Fill(Me.DbLujan21DataSet2.tblPaquetes)
        CbxTipo.SelectedIndex = 0
        limpiarPantalla()
        ExtraerDatosEstandar()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If validarDatosEnBlancoT() Then
            If CbxTipo.SelectedIndex = 1 Then
                Dim resultado = clsPaquetes.registrarPaqueteTemporada(txtNombreT.Text, CbxTipo.Text, rtbDescripT.Text, txtPrecioT.Text)

                If resultado Then
                    MessageBox.Show("Datos registrados con exito", "Nuevo usuario agregado",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Call Paquetes_Load(sender, e)
                End If
            Else
                MsgBox("No se pueden registrar nuevos paquetes tipo Estandar" & vbCrLf & "Paquetes por defecto", vbCritical, "Error")
            End If
        Else
            MsgBox("Debe ingresar todos los datos" & vbCrLf & "Error al registrar", vbCritical, "Error")
        End If

    End Sub
    Public Function validarDatosEnBlancoT()
        If ((txtNombreT.Text IsNot "") Or (txtPrecioT.Text IsNot "") Or (rtbDescripT.Text IsNot "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function validarDatosEnBlancoE()
        If ((txtPrecioE.Text = "") Or (rtbDescripE.Text = "")) Then
            Return False
        Else
            Return True
        End If
    End Function



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim i = dtgPaquetesTodos.CurrentRow.Index
        Dim id = dtgPaquetesTodos.Item(0, i).Value()
        If CbxTipo.SelectedIndex = 0 Then
            If validarDatosEnBlancoE() Then
                Dim resultado
                If rbBásicoE.Checked = True Then
                    resultado = clsPaquetes.modificarPaqueteEstandar(rbBásicoE.Text, rtbDescripE.Text, txtPrecioE.Text)

                ElseIf rbMedioE.Checked = True Then
                    resultado = clsPaquetes.modificarPaqueteEstandar(rbMedioE.Text, rtbDescripE.Text, txtPrecioE.Text)
                Else
                    resultado = clsPaquetes.modificarPaqueteEstandar(rbFullE.Text, rtbDescripE.Text, txtPrecioE.Text)
                End If
                If resultado Then
                    MessageBox.Show("Datos modificados con exito", "Paquete modificado",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Paquetes_Load(sender, e)
                End If
            Else
                MsgBox("Debe ingresar todos los datos" & vbCrLf & "Error al modificar", vbCritical, "Error")
            End If
        Else
            If validarDatosEnBlancoT() Then
                clsPaquetes.modificarPaqueteTemporada(id, txtNombreT.Text, rtbDescripT.Text, txtPrecioT.Text)
                MessageBox.Show("Datos modificados con exito", "Paquete modificado",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Paquetes_Load(sender, e)
            Else
                MsgBox("Debe ingresar todos los datos" & vbCrLf & "Error al modificar", vbCritical, "Error")
            End If
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtNombreT.Text IsNot "" Then
            Dim resultado = clsPaquetes.borrarPaquete(txtNombreT.Text)

            If resultado Then
                MessageBox.Show("Paquete eliminado con exito", "Paquete eliminado",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Call Paquetes_Load(sender, e)
            End If
        Else
            MsgBox("Debe ingresar el nombre del paquete que quiere eliminar" & vbCrLf & "Error", vbCritical, "Error")
        End If
    End Sub


    Private Sub CbxTipo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CbxTipo.SelectedIndexChanged
        If CbxTipo.SelectedIndex = 0 Then
            GroupEstandar.Visible = True
            GroupTemporada.Visible = False
            btnCrear.Enabled = False
            btnBorrar.Enabled = False
            btnLimpiar.Enabled = False
        Else
            GroupEstandar.Visible = False
            GroupTemporada.Visible = True
            btnCrear.Enabled = True
            btnBorrar.Enabled = True
            btnLimpiar.Enabled = True
        End If
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        tbControlPaquetes.SelectedIndex = 1
    End Sub

    Public Sub limpiarPantalla()
        txtNombreT.Text = ""
        txtPrecioE.Text = ""
        txtPrecioT.Text = ""
        rtbDescripE.Text = ""
        rtbDescripT.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarPantalla()
    End Sub

    Public Sub ExtraerDatosEstandar()
        If CbxTipo.SelectedIndex = 0 Then
            btnLimpiar.Enabled = False
            Dim lista As New Collection
            If rbBásicoE.Checked = True Then
                lista = clsPaquetes.buscarPaqueteEstandar(rbBásicoE.Text)
                rtbDescripE.Text = lista(2)
                txtPrecioE.Text = lista(3)
            ElseIf rbMedioE.Checked = True Then
                lista = clsPaquetes.buscarPaqueteEstandar(rbMedioE.Text)
                rtbDescripE.Text = lista(2)
                txtPrecioE.Text = lista(3)
            ElseIf rbFullE.Checked = True Then
                lista = clsPaquetes.buscarPaqueteEstandar(rbFullE.Text)
                rtbDescripE.Text = lista(2)
                txtPrecioE.Text = lista(3)
            Else
                btnLimpiar.Enabled = True
            End If
        End If
    End Sub

    Private Sub rbBásicoE_CheckedChanged(sender As Object, e As EventArgs) Handles rbBásicoE.CheckedChanged
        ExtraerDatosEstandar()
    End Sub

    Private Sub rbMedioE_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedioE.CheckedChanged
        ExtraerDatosEstandar()
    End Sub

    Private Sub rbFullE_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullE.CheckedChanged
        ExtraerDatosEstandar()
    End Sub

    Private Sub dtgPaquetesTodos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPaquetesTodos.CellClick

        Dim i = dtgPaquetesTodos.CurrentRow.Index
        Dim tipo = dtgPaquetesTodos.Item(2, i).Value()
        tbControlPaquetes.SelectedIndex = 0
        If tipo = "Temporada" Then
            CbxTipo.SelectedIndex = 1
            txtNombreT.Text = dtgPaquetesTodos.Item(1, i).Value()
            rtbDescripT.Text = dtgPaquetesTodos.Item(3, i).Value()
            txtPrecioT.Text = dtgPaquetesTodos.Item(4, i).Value()
        Else
            CbxTipo.SelectedIndex = 0
            If rbBásicoE.Checked = True Then
                rtbDescripE.Text = dtgPaquetesTodos.Item(3, i).Value()
                txtPrecioE.Text = dtgPaquetesTodos.Item(4, i).Value()
            ElseIf rbMedioE.Checked = True Then
                rtbDescripE.Text = dtgPaquetesTodos.Item(3, i).Value()
                txtPrecioE.Text = dtgPaquetesTodos.Item(4, i).Value()
            Else
                rtbDescripE.Text = dtgPaquetesTodos.Item(3, i).Value()
                txtPrecioE.Text = dtgPaquetesTodos.Item(4, i).Value()
            End If
        End If
    End Sub
End Class