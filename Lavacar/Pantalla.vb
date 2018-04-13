Public Class Pantalla

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Registros.Show()
    End Sub

    Private Sub Pantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbpequeno.Visible = True

        txthora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        txtfecha.Text() = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim monto As Integer = 0
        txtprecio.Text = monto

        If rbpequeno.Checked Then
            If rbbasico.Checked Then
                monto = monto + 4000
                txtprecio.Text = monto
                txtdescripcion.Text = "Lavado exterior con champú + secado + aspirado interior"
            ElseIf rbmedio.Checked Then
                monto = monto + 4900
                txtprecio.Text = monto
                txtdescripcion.Text = "Básico + cera + protector de llantas + abrillantador molduras + protección dash"
            ElseIf rbfull.Checked Then
                monto = monto + 5500
                txtprecio.Text = monto
                txtdescripcion.Text = "Medio + antiempañado de parabrisas trasero y delantero + lavado alfombras + protector de aros"
            End If
        End If
        '-----------------------------------
        If rbmediano.Checked Then
            If rbbasico.Checked Then
                monto = monto + 5000
                txtprecio.Text = monto
                txtdescripcion.Text = "Lavado exterior con champú + secado + aspirado interior"
            ElseIf rbmedio.Checked Then
                monto = monto + 6000
                txtprecio.Text = monto
                txtdescripcion.Text = "Básico + cera + protector de llantas + abrillantador molduras + protección dash"
            ElseIf rbfull.Checked Then
                monto = monto + 6500
                txtprecio.Text = monto
                txtdescripcion.Text = "Medio + antiempañado de parabrisas trasero y delantero + lavado alfombras + protector de aros"
            End If
        End If
        '-----------------------------------
        If rbgrande.Checked Then
            If rbbasico.Checked Then
                monto = monto + 6000
                txtprecio.Text = monto
                txtdescripcion.Text = "Lavado exterior con champú + secado + aspirado interior"
            ElseIf rbmedio.Checked Then
                monto = monto + 7300
                txtprecio.Text = monto
                txtdescripcion.Text = "Básico + cera + protector de llantas + abrillantador molduras + protección dash"
            ElseIf rbfull.Checked Then
                monto = monto + 7700
                txtprecio.Text = monto
                txtdescripcion.Text = "Medio + antiempañado de parabrisas trasero y delantero + lavado alfombras + protector de aros"
            End If
        End If
        '-----------------------------------
        If rbmoto.Checked Then
            If rbmediano.Checked Then
                monto = monto + 3000
                txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = monto + 4500
                txtprecio.Text = monto
            End If
        End If
        If ChBox3.Checked Then
            monto = monto + 400
            txtprecio.Text = monto
        End If
        If ChBox4.Checked Then
            monto = monto + 400
            txtprecio.Text = monto
        End If
        If ChBox5.Checked Then
            monto = monto + 400
            txtprecio.Text = monto
        End If
        If ChBox6.Checked Then
            monto = monto + 400
            txtprecio.Text = monto
        End If
        '-----------------------------------
        If ChBoxChasis.Checked And ChBoxMotor.Checked Then
            If rbpequeno.Checked Then
                    monto = monto + 7500
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto          
            ElseIf rbmediano.Checked Then
                monto = monto + 8500
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
            ElseIf rbgrande.Checked Then
                monto = monto + 10500
                monto = monto - (monto * 0.13)
                txtprecio.Text = monto
            End If
        Else
            If ChBoxChasis.Checked Then
                If rbpequeno.Checked Then
                    monto = monto + 3500
                    txtprecio.Text = monto
                ElseIf rbmediano.Checked Then
                    monto = monto + 3500
                    txtprecio.Text = monto
                ElseIf rbgrande.Checked Then
                    monto = monto + 4500
                    txtprecio.Text = monto
                End If
                If rbbasico.Checked Then
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
                ElseIf rbmedio.Checked Then
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
                ElseIf rbfull.Checked Then
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
                End If
            End If
            '-----------------------------------
            If ChBoxMotor.Checked Then
                If rbpequeno.Checked Then
                    monto = monto + 4000
                    txtprecio.Text = monto
                ElseIf rbmediano.Checked Then
                    monto = monto + 5000
                    txtprecio.Text = monto
                ElseIf rbgrande.Checked Then
                    monto = monto + 6000
                    txtprecio.Text = monto
                End If
                If rbbasico.Checked Then
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
                ElseIf rbmedio.Checked Then
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
                ElseIf rbfull.Checked Then
                    monto = monto - (monto * 0.13)
                    txtprecio.Text = monto
                End If
            End If
        End If
        '-----------------------------------
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

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles rbmoto.CheckedChanged
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        Agenda.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.Show()
    End Sub

    Private Sub CombosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CombosToolStripMenuItem.Click

    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Precios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub txtfecha_TextChanged(sender As Object, e As EventArgs) Handles txtfecha.TextChanged
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txthora.Text() = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub
End Class