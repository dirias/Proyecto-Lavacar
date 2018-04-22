Public Class Agenda
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbLujan21DataSet3.tblCitas' table. You can move, or remove it, as needed.
        Me.TblCitasTableAdapter.Fill(Me.DbLujan21DataSet3.tblCitas)
        dtpFecha.MinDate = DateTime.Today
        limpiarDatos()

    End Sub

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        If validarDatos() Then
            clsCitas.reservarCita(txtnombreCliente.Text, txtApellidos.Text, txtPlaca.Text, txtMarca.Text, dtpFecha.Value.Date, mtbHora.Text, mtbTelefono.Text, rtbDetalle.Text)
            MessageBox.Show("Datos registrados con exito", "Cita reservada",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Agenda_Load(sender, e)
        Else
            MessageBox.Show("Debe ingresar todos los datos", "No se pudo reservar la cita",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function validarDatos()
        If txtnombreCliente.Text = "" Or txtApellidos.Text = "" Or txtPlaca.Text = "" Or mtbHora.Text = "  :  " Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub limpiarDatos()
        txtnombreCliente.Text = ""
        txtApellidos.Text = ""
        txtPlaca.Text = ""
        txtMarca.Text = ""
        mtbHora.Text = ""
        mtbTelefono.Text = ""
        rtbDetalle.Text = ""
    End Sub

    Private Sub btnVercitas_Click(sender As Object, e As EventArgs) Handles btnVercitas.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarDatos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim i = dtgCitas.CurrentRow.Index

        Dim ID = dtgCitas.Item(0, i).Value()
        If validarDatos() Then
            clsCitas.modificarCita(ID, txtnombreCliente.Text, txtApellidos.Text, txtPlaca.Text, txtMarca.Text, dtpFecha.Value.Date, mtbHora.Text, mtbTelefono.Text, rtbDetalle.Text)
            MessageBox.Show("Datos modificados con exito", "Cita modificada",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Agenda_Load(sender, e)
        Else
            MessageBox.Show("Los datos a modificar están en blanco", "No se pudo modificar la cita",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub dtgCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCitas.CellClick
        Dim i As Integer

        i = dtgCitas.CurrentRow.Index

        txtnombreCliente.Text = dtgCitas.Item(1, i).Value()
        txtApellidos.Text = dtgCitas.Item(2, i).Value()
        txtPlaca.Text = dtgCitas.Item(3, i).Value()
        txtMarca.Text = dtgCitas.Item(4, i).Value()
        dtpFecha.Value = dtgCitas.Item(5, i).Value()

        mtbHora.Text = dtgCitas.Item(6, i).Value()
        mtbTelefono.Text = dtgCitas.Item(7, i).Value()
        rtbDetalle.Text = dtgCitas.Item(8, i).Value()

        TabControl1.SelectedIndex = 0
    End Sub
End Class