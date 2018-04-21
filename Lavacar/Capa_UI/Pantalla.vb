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
        monto = 4000
        txtprecio.Text = monto
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
        Precios.ShowDialog()
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
            gbPaquete.Visible = True
        Else
            gbPaquete.Visible = False
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
        If rbpequeno.Checked Then
            rbpequeno.Enabled = True
            rbmoto.Checked = False
            rbmoto.Enabled = False
            If rbbasico.Checked Then
                monto = 4000
                txtprecio.Text = monto
                txtdescripcion.Text = "Lavado exterior con champú + secado + aspirado interior"
            ElseIf rbmedio.Checked Then
                monto = 4900
                txtprecio.Text = monto
                txtdescripcion.Text = "Básico + cera + protector de llantas + abrillantador molduras + protección dash"
            ElseIf rbfull.Checked Then
                monto = 5500
                txtprecio.Text = monto
                txtdescripcion.Text = "MEDIO + antiempañado de parabrisas trasero y delantero+lavado alfombras+protector de aros."

            End If
        ElseIf rbmediano.Checked Then
            rbpequeno.Enabled = True
            rbmoto.Enabled = True
            If rbbasico.Checked Then
                monto = 5000
                txtprecio.Text = monto
                txtdescripcion.Text = "Lavado exterior con champú + secado + aspirado interior"
            ElseIf rbmedio.Checked Then
                monto = 6000
                txtprecio.Text = monto
                txtdescripcion.Text = "Básico + cera + protector de llantas + abrillantador molduras + protección dash"
            ElseIf rbfull.Checked Then
                monto = 6500
                txtprecio.Text = monto
                txtdescripcion.Text = "MEDIO + antiempañado de parabrisas trasero y delantero+lavado alfombras+protector de aros."
            ElseIf rbmoto.Checked Then
                monto = 3000
                txtprecio.Text = monto
                txtdescripcion.Text = "Lavado de moto"
            End If

        End If
    End Sub
    Private Sub rbpequeno_CheckedChanged(sender As Object, e As EventArgs) Handles rbpequeno.CheckedChanged

    End Sub

    Private Sub rbmediano_CheckedChanged(sender As Object, e As EventArgs) Handles rbmediano.CheckedChanged

    End Sub

    Private Sub rbgrande_CheckedChanged(sender As Object, e As EventArgs) Handles rbgrande.CheckedChanged

    End Sub

    Private Sub rbbasico_CheckedChanged(sender As Object, e As EventArgs) Handles rbbasico.CheckedChanged
        If rbbasico.Checked = True Then
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = 4000
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = 5000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = 6000
                txtprecio.Text = monto
            End If
            txtdescripcion.Text = "Lavado exterior con champú + secado + aspirado interior"
        End If
    End Sub

    Private Sub rbmedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbmedio.CheckedChanged
        If rbmedio.Checked = True Then
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = 4900
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = 6000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = 7300
                txtprecio.Text = monto
            End If
            txtdescripcion.Text = "Básico + cera + protector de llantas + abrillantador molduras + protección dash"
        End If
    End Sub

    Private Sub rbfull_CheckedChanged(sender As Object, e As EventArgs) Handles rbfull.CheckedChanged
        If rbfull.Checked = True Then
            rbpequeno.Enabled = True
            If rbpequeno.Checked Then
                monto = 5500
                txtprecio.Text = monto
            ElseIf rbmediano.Checked Then
                monto = 6500
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = 7700
                txtprecio.Text = monto
            End If
            txtdescripcion.Text = "MEDIO + antiempañado de parabrisas trasero y delantero+lavado alfombras + protector de aros."
        End If
    End Sub

    Private Sub rbmoto_CheckedChanged(sender As Object, e As EventArgs) Handles rbmoto.CheckedChanged
        If rbmoto.Checked = True Then
            rbmoto.Enabled = True
            rbpequeno.Enabled = False
            If rbmediano.Checked = True Then
                monto = 3000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked = True Then
                monto = 4500
                txtprecio.Text = monto
            ElseIf rbpequeno.Checked = True Then
                rbmediano.Checked = True
                monto = 3000
                txtprecio.Text = monto
            End If
            txtdescripcion.Text = "Lavado de moto"
        End If
    End Sub
End Class