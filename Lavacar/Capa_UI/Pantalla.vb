Imports System.Configuration

Public Class Pantalla
    Dim monto As Integer
    Private Sub Pantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbpequeno.Visible = True
        txthora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        txtfecha.Text() = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
        cbxTipoCliente.SelectedIndex = 1
        cbxTipoPaquete.SelectedIndex = 0
        rbPagaHoy.Checked = True
        dtpFechaPago.Enabled = False
        txtUser.Text = ConfigurationSettings.AppSettings("usuarioActual")
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs)


    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxChasis.CheckedChanged
        rbbasico.Checked = False
        rbmedio.Checked = False
        rbfull.Checked = False
        rbmoto.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxMotor.CheckedChanged
        rbbasico.Checked = False
        rbmedio.Checked = False
        rbfull.Checked = False
        rbmoto.Checked = False
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        Agenda.ShowDialog()
    End Sub


    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Inicio.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.ShowDialog()
    End Sub

    Private Sub CombosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CombosToolStripMenuItem.Click
        Paquetes.ShowDialog()
    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Extras.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtfecha_TextChanged(sender As Object, e As EventArgs) Handles txtfecha.TextChanged
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txthora.Text() = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub rbOtroDia_CheckedChanged(sender As Object, e As EventArgs) Handles rbOtroDia.CheckedChanged
        If rbOtroDia.Checked = True Then
            dtpFechaPago.Enabled = True
        Else
            dtpFechaPago.Enabled = False
            rbPagaHoy.Checked = True
            dtpFechaPago.ResetText()

        End If
    End Sub

    Private Sub dtpFechaPago_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaPago.ValueChanged
        dtpFechaPago.MinDate = DateTime.Now
    End Sub

    Private Sub cbxTipoPaquete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoPaquete.SelectedIndexChanged
        If cbxTipoPaquete.SelectedIndex = 0 Then
            gbPaqueteE.Visible = True
            gbPaqueteT.Visible = False
            Pantalla_Load(sender, e)
        Else
            Dim lista = clsPaquetes.extraerPaqueteTemporada()
            If lista(1) = "Nada" Then
                MessageBox.Show("No hay paquetes de temporada registrados", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbxTipoPaquete.SelectedIndex = 0
            Else
                txtdescripcion.Text = ""
                txtprecio.Text = ""
                rbpequeno.Checked = False
                rbmediano.Checked = False
                rbgrande.Checked = False
                cbTemporada.Items.Clear()
                For Each item In lista
                    cbTemporada.Items.Add(lista(1))
                Next
                gbPaqueteE.Visible = False
                gbPaqueteT.Visible = True
            End If
        End If
    End Sub

    Private Sub Pantalla_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Inicio.Close()
    End Sub

    Public Sub limpiarPantalla()
        cbxTipoCliente.SelectedIndex = 1
        cbxTipoPaquete.SelectedIndex = 0
        rbPagaHoy.Checked = True
        rbpequeno.Checked = True
        rbbasico.Checked = True
        'Limpio extras'
        ChBoxChasis.Checked = False
        ChBoxMotor.Checked = False
        ChBox3.Checked = False
        ChBox4.Checked = False
        ChBox5.Checked = False
        ChBox6.Checked = False
        'Limpio txt'
        txtlavador.Text = ""
        txtcliente.Text = ""
        txtmarca.Text = ""
        txtplaca.Text = ""
        txtprecio.Text = ""
        txtdescripcion.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            limpiarPantalla()
        Catch ex As Exception
            MsgBox("Problemas al borrar")
        End Try
    End Sub
    Public Sub rbSize()
        Dim lista As New Collection
        If cbxTipoPaquete.SelectedIndex = 0 Then
            If rbpequeno.Checked Then
                rbpequeno.Enabled = True
                rbmoto.Checked = False
                rbmoto.Enabled = False
                If rbbasico.Checked Then
                    lista = clsPaquetes.buscarPaquete("Básico")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbmedio.Checked Then
                    lista = clsPaquetes.buscarPaquete("Medio")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbfull.Checked Then
                    lista = clsPaquetes.buscarPaquete("Full")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rdMotor.Checked Then
                    lista = clsPaquetes.buscarPaquete("Motor")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbChasis.Checked Then
                    lista = clsPaquetes.buscarPaquete("Chasis")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                End If
            ElseIf rbmediano.Checked Then
                rbpequeno.Enabled = True
                rbmoto.Enabled = True
                If rbbasico.Checked Then
                    lista = clsPaquetes.buscarPaquete("Básico")
                    txtprecio.Text = lista(3) + 1000
                    txtdescripcion.Text = lista(2)
                ElseIf rbmedio.Checked Then
                    lista = clsPaquetes.buscarPaquete("Medio")
                    monto = lista(3) + 1100
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbfull.Checked Then
                    lista = clsPaquetes.buscarPaquete("Full")
                    monto = lista(3) + 1000
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbmoto.Checked Then
                    lista = clsPaquetes.buscarPaquete("Motocicleta")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rdMotor.Checked Then
                    lista = clsPaquetes.buscarPaquete("Motor")
                    monto = lista(3) + 1000
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbChasis.Checked Then
                    lista = clsPaquetes.buscarPaquete("Chasis")
                    monto = lista(3)
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                End If
            ElseIf rbgrande.Checked Then
                rbpequeno.Enabled = True
                rbmoto.Enabled = True
                If rbbasico.Checked Then
                    lista = clsPaquetes.buscarPaquete("Básico")
                    monto = lista(3) + 2000
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbmedio.Checked Then
                    lista = clsPaquetes.buscarPaquete("Medio")
                    monto = lista(3) + 2400
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbfull.Checked Then
                    lista = clsPaquetes.buscarPaquete("Full")
                    monto = lista(3) + 2200
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rbmoto.Checked Then
                    lista = clsPaquetes.buscarPaquete("Motocicleta")
                    monto = lista(3) + 1500
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                ElseIf rdMotor.Checked Then
                    lista = clsPaquetes.buscarPaquete("Motor")
                    monto = lista(3)
                    txtprecio.Text = monto + 2000
                    txtdescripcion.Text = lista(2)
                ElseIf rbChasis.Checked Then
                    lista = clsPaquetes.buscarPaquete("Chasis")
                    monto = lista(3) + 1000
                    txtprecio.Text = monto
                    txtdescripcion.Text = lista(2)
                End If

            End If
        ElseIf cbxTipoPaquete.SelectedIndex = 1 Then
            If rbpequeno.Checked Then
                lista = clsPaquetes.buscarPaquete(cbTemporada.Text)
                monto = lista(3)
                txtprecio.Text = monto
                txtdescripcion.Text = lista(2)
            ElseIf rbmediano.Checked Then
                lista = clsPaquetes.buscarPaquete(cbTemporada.Text)
                monto = lista(3)
                txtprecio.Text = monto + 1000
                txtdescripcion.Text = lista(2)
            ElseIf rbgrande.Checked Then
                lista = clsPaquetes.buscarPaquete(cbTemporada.Text)
                monto = lista(3)
                txtprecio.Text = monto + 2000
                txtdescripcion.Text = lista(2)

            End If
        End If
    End Sub
    Private Sub rbpequeno_CheckedChanged(sender As Object, e As EventArgs) Handles rbpequeno.CheckedChanged
        rbSize()
    End Sub

    Private Sub rbmediano_CheckedChanged(sender As Object, e As EventArgs) Handles rbmediano.CheckedChanged
        rbSize()
    End Sub

    Private Sub rbgrande_CheckedChanged(sender As Object, e As EventArgs) Handles rbgrande.CheckedChanged
        rbSize()
    End Sub
    Public Sub rbTipo()
        Dim lista As New Collection
        If rbbasico.Checked = True Then
            lista = clsPaquetes.buscarPaquete("Básico")
            txtdescripcion.Text = lista(2)
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = lista(3) + 1000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = lista(3) + 2000
                txtprecio.Text = monto
            End If
        ElseIf rbmedio.Checked = True Then
            lista = clsPaquetes.buscarPaquete("Medio")
            txtdescripcion.Text = lista(2)
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = lista(3) + 1100
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = lista(3) + 2400
                txtprecio.Text = monto
            End If
        ElseIf rbfull.Checked = True Then
            lista = clsPaquetes.buscarPaquete("Full")
            txtdescripcion.Text = lista(2)
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = lista(3) + 1000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = lista(3) + 2200
                txtprecio.Text = monto
            End If
        ElseIf rdMotor.Checked = True Then
            lista = clsPaquetes.buscarPaquete("Motor")
            txtdescripcion.Text = lista(2)
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = lista(3) + 1000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = lista(3) + 2000
                txtprecio.Text = monto
            End If
        ElseIf rbChasis.Checked = True Then
            lista = clsPaquetes.buscarPaquete("Chasis")
            txtdescripcion.Text = lista(2)
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = lista(3) + 1000
                txtprecio.Text = monto
            End If
        ElseIf rbmoto.Checked = True Then
            lista = clsPaquetes.buscarPaquete("Motocicleta")
            txtdescripcion.Text = lista(2)
            rbpequeno.Enabled = True
            If rbmediano.Checked Then
                monto = lista(3)
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = lista(3) + 1500
                txtprecio.Text = monto
            End If

        End If

    End Sub
    Private Sub rbbasico_CheckedChanged(sender As Object, e As EventArgs) Handles rbbasico.CheckedChanged
        rbTipo()
    End Sub

    Private Sub rbmedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbmedio.CheckedChanged
        rbTipo()
    End Sub

    Private Sub rbfull_CheckedChanged(sender As Object, e As EventArgs) Handles rbfull.CheckedChanged
        rbTipo()
    End Sub

    Private Sub rbmoto_CheckedChanged(sender As Object, e As EventArgs) Handles rbmoto.CheckedChanged
        rbTipo()
    End Sub

    Private Sub rdMotor_CheckedChanged(sender As Object, e As EventArgs) Handles rdMotor.CheckedChanged
        rbTipo()
    End Sub

    Private Sub rbChasis_CheckedChanged(sender As Object, e As EventArgs) Handles rbChasis.CheckedChanged
        rbTipo()
    End Sub

    Private Sub cbTemporada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTemporada.SelectedIndexChanged
        rbSize()
    End Sub

    Public Sub limpiarTodo()

        limpiarPantalla()
        txtdescripcion.Text = ""
        txtprecio.Text = ""
        rbbasico.Checked = False
        rbmedio.Checked = False
        rbfull.Checked = False
        rdMotor.Checked = False
        rbChasis.Checked = False
        rbmoto.Checked = False
        rbpequeno.Checked = False
        rbmediano.Checked = False
        rbgrande.Checked = False

    End Sub

    Private Sub cbxTipoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoCliente.SelectedIndexChanged

        If cbxTipoCliente.SelectedIndex = 0 Then
            txtplaca.Enabled = False
            txtmarca.Enabled = False
            btnBuscar.Visible = True
            txtplaca.Clear()
            txtmarca.Clear()
            txtcliente.Clear()

        Else
            txtplaca.Enabled = True
            txtmarca.Enabled = True
            btnBuscar.Visible = False
            txtplaca.Clear()
            txtmarca.Clear()
            txtcliente.Clear()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim lista = clsCitas.buscarCita(txtcliente.Text)
        txtplaca.Text = lista(1)
        txtmarca.Text = lista(2)
    End Sub

    Private Sub UsuariosDelProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosDelProgramaToolStripMenuItem.Click
        FrmRpUsuario.ShowDialog()
    End Sub
End Class