<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla))
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlavador = New System.Windows.Forms.TextBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbpequeno = New System.Windows.Forms.RadioButton()
        Me.rbmediano = New System.Windows.Forms.RadioButton()
        Me.rbgrande = New System.Windows.Forms.RadioButton()
        Me.gbSize = New System.Windows.Forms.GroupBox()
        Me.gbPaqueteE = New System.Windows.Forms.GroupBox()
        Me.rbChasis = New System.Windows.Forms.RadioButton()
        Me.rdMotor = New System.Windows.Forms.RadioButton()
        Me.rbmoto = New System.Windows.Forms.RadioButton()
        Me.rbfull = New System.Windows.Forms.RadioButton()
        Me.rbmedio = New System.Windows.Forms.RadioButton()
        Me.rbbasico = New System.Windows.Forms.RadioButton()
        Me.ChBoxChasis = New System.Windows.Forms.CheckBox()
        Me.ChBoxMotor = New System.Windows.Forms.CheckBox()
        Me.ChBox3 = New System.Windows.Forms.CheckBox()
        Me.ChBox4 = New System.Windows.Forms.CheckBox()
        Me.ChBox5 = New System.Windows.Forms.CheckBox()
        Me.ChBox6 = New System.Windows.Forms.CheckBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbPaqueteT = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTemporada = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipoCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTipoPaquete = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.rbOtroDia = New System.Windows.Forms.RadioButton()
        Me.rbPagaHoy = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CombosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosDelProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaquetesDelLavacarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LavadosRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesDelLavacarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitasRegistradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.gbSize.SuspendLayout()
        Me.gbPaqueteE.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbPaqueteT.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprecio
        '
        Me.txtprecio.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtprecio.Location = New System.Drawing.Point(136, 162)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(100, 24)
        Me.txtprecio.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Lavador*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Cliente "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Placa *"
        '
        'txtlavador
        '
        Me.txtlavador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtlavador.Location = New System.Drawing.Point(136, 57)
        Me.txtlavador.Name = "txtlavador"
        Me.txtlavador.Size = New System.Drawing.Size(100, 24)
        Me.txtlavador.TabIndex = 31
        '
        'txtcliente
        '
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtcliente.Location = New System.Drawing.Point(18, 111)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(100, 24)
        Me.txtcliente.TabIndex = 32
        '
        'txtplaca
        '
        Me.txtplaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtplaca.Location = New System.Drawing.Point(136, 111)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(100, 24)
        Me.txtplaca.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(364, 295)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ReadOnly = True
        Me.txtdescripcion.Size = New System.Drawing.Size(385, 128)
        Me.txtdescripcion.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(368, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 21)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Descripción"
        '
        'rbpequeno
        '
        Me.rbpequeno.AutoSize = True
        Me.rbpequeno.Checked = True
        Me.rbpequeno.Location = New System.Drawing.Point(17, 27)
        Me.rbpequeno.Name = "rbpequeno"
        Me.rbpequeno.Size = New System.Drawing.Size(85, 22)
        Me.rbpequeno.TabIndex = 46
        Me.rbpequeno.TabStop = True
        Me.rbpequeno.Text = "Pequeño"
        Me.rbpequeno.UseVisualStyleBackColor = True
        '
        'rbmediano
        '
        Me.rbmediano.AutoSize = True
        Me.rbmediano.Location = New System.Drawing.Point(17, 51)
        Me.rbmediano.Name = "rbmediano"
        Me.rbmediano.Size = New System.Drawing.Size(83, 22)
        Me.rbmediano.TabIndex = 47
        Me.rbmediano.Text = "Mediano"
        Me.rbmediano.UseVisualStyleBackColor = True
        '
        'rbgrande
        '
        Me.rbgrande.AutoSize = True
        Me.rbgrande.Location = New System.Drawing.Point(17, 76)
        Me.rbgrande.Name = "rbgrande"
        Me.rbgrande.Size = New System.Drawing.Size(75, 22)
        Me.rbgrande.TabIndex = 48
        Me.rbgrande.Text = "Grande"
        Me.rbgrande.UseVisualStyleBackColor = True
        '
        'gbSize
        '
        Me.gbSize.Controls.Add(Me.rbpequeno)
        Me.gbSize.Controls.Add(Me.rbgrande)
        Me.gbSize.Controls.Add(Me.rbmediano)
        Me.gbSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbSize.Location = New System.Drawing.Point(228, 148)
        Me.gbSize.Name = "gbSize"
        Me.gbSize.Size = New System.Drawing.Size(123, 115)
        Me.gbSize.TabIndex = 49
        Me.gbSize.TabStop = False
        Me.gbSize.Text = "Tamaño"
        '
        'gbPaqueteE
        '
        Me.gbPaqueteE.Controls.Add(Me.rbChasis)
        Me.gbPaqueteE.Controls.Add(Me.rdMotor)
        Me.gbPaqueteE.Controls.Add(Me.rbmoto)
        Me.gbPaqueteE.Controls.Add(Me.rbfull)
        Me.gbPaqueteE.Controls.Add(Me.rbmedio)
        Me.gbPaqueteE.Controls.Add(Me.rbbasico)
        Me.gbPaqueteE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbPaqueteE.Location = New System.Drawing.Point(26, 148)
        Me.gbPaqueteE.Name = "gbPaqueteE"
        Me.gbPaqueteE.Size = New System.Drawing.Size(188, 115)
        Me.gbPaqueteE.TabIndex = 50
        Me.gbPaqueteE.TabStop = False
        Me.gbPaqueteE.Text = "Paquete"
        '
        'rbChasis
        '
        Me.rbChasis.AutoSize = True
        Me.rbChasis.Location = New System.Drawing.Point(84, 51)
        Me.rbChasis.Name = "rbChasis"
        Me.rbChasis.Size = New System.Drawing.Size(72, 22)
        Me.rbChasis.TabIndex = 5
        Me.rbChasis.Text = "Chasis"
        Me.rbChasis.UseVisualStyleBackColor = True
        '
        'rdMotor
        '
        Me.rdMotor.AutoSize = True
        Me.rdMotor.Location = New System.Drawing.Point(84, 27)
        Me.rdMotor.Name = "rdMotor"
        Me.rdMotor.Size = New System.Drawing.Size(66, 22)
        Me.rdMotor.TabIndex = 4
        Me.rdMotor.Text = "Motor"
        Me.rdMotor.UseVisualStyleBackColor = True
        '
        'rbmoto
        '
        Me.rbmoto.AutoSize = True
        Me.rbmoto.Location = New System.Drawing.Point(84, 76)
        Me.rbmoto.Name = "rbmoto"
        Me.rbmoto.Size = New System.Drawing.Size(103, 22)
        Me.rbmoto.TabIndex = 3
        Me.rbmoto.Text = "Motocicleta"
        Me.rbmoto.UseVisualStyleBackColor = True
        '
        'rbfull
        '
        Me.rbfull.AutoSize = True
        Me.rbfull.Location = New System.Drawing.Point(13, 76)
        Me.rbfull.Name = "rbfull"
        Me.rbfull.Size = New System.Drawing.Size(49, 22)
        Me.rbfull.TabIndex = 2
        Me.rbfull.Text = "Full"
        Me.rbfull.UseVisualStyleBackColor = True
        '
        'rbmedio
        '
        Me.rbmedio.AutoSize = True
        Me.rbmedio.Location = New System.Drawing.Point(13, 51)
        Me.rbmedio.Name = "rbmedio"
        Me.rbmedio.Size = New System.Drawing.Size(67, 22)
        Me.rbmedio.TabIndex = 1
        Me.rbmedio.Text = "Medio"
        Me.rbmedio.UseVisualStyleBackColor = True
        '
        'rbbasico
        '
        Me.rbbasico.AutoSize = True
        Me.rbbasico.Checked = True
        Me.rbbasico.Location = New System.Drawing.Point(13, 27)
        Me.rbbasico.Name = "rbbasico"
        Me.rbbasico.Size = New System.Drawing.Size(72, 22)
        Me.rbbasico.TabIndex = 0
        Me.rbbasico.TabStop = True
        Me.rbbasico.Text = "Básico"
        Me.rbbasico.UseVisualStyleBackColor = True
        '
        'ChBoxChasis
        '
        Me.ChBoxChasis.AutoSize = True
        Me.ChBoxChasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ChBoxChasis.Location = New System.Drawing.Point(19, 16)
        Me.ChBoxChasis.Name = "ChBoxChasis"
        Me.ChBoxChasis.Size = New System.Drawing.Size(73, 22)
        Me.ChBoxChasis.TabIndex = 53
        Me.ChBoxChasis.Text = "Chasis"
        Me.ChBoxChasis.UseVisualStyleBackColor = True
        '
        'ChBoxMotor
        '
        Me.ChBoxMotor.AutoSize = True
        Me.ChBoxMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ChBoxMotor.Location = New System.Drawing.Point(19, 35)
        Me.ChBoxMotor.Name = "ChBoxMotor"
        Me.ChBoxMotor.Size = New System.Drawing.Size(67, 22)
        Me.ChBoxMotor.TabIndex = 54
        Me.ChBoxMotor.Text = "Motor"
        Me.ChBoxMotor.UseVisualStyleBackColor = True
        '
        'ChBox3
        '
        Me.ChBox3.AutoSize = True
        Me.ChBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ChBox3.Location = New System.Drawing.Point(19, 53)
        Me.ChBox3.Name = "ChBox3"
        Me.ChBox3.Size = New System.Drawing.Size(94, 22)
        Me.ChBox3.TabIndex = 55
        Me.ChBox3.Text = "Alfombras"
        Me.ChBox3.UseVisualStyleBackColor = True
        '
        'ChBox4
        '
        Me.ChBox4.AutoSize = True
        Me.ChBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ChBox4.Location = New System.Drawing.Point(19, 71)
        Me.ChBox4.Name = "ChBox4"
        Me.ChBox4.Size = New System.Drawing.Size(74, 22)
        Me.ChBox4.TabIndex = 56
        Me.ChBox4.Text = "Llantas"
        Me.ChBox4.UseVisualStyleBackColor = True
        '
        'ChBox5
        '
        Me.ChBox5.AutoSize = True
        Me.ChBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ChBox5.Location = New System.Drawing.Point(19, 89)
        Me.ChBox5.Name = "ChBox5"
        Me.ChBox5.Size = New System.Drawing.Size(98, 22)
        Me.ChBox5.TabIndex = 57
        Me.ChBox5.Text = "Parabrisas"
        Me.ChBox5.UseVisualStyleBackColor = True
        '
        'ChBox6
        '
        Me.ChBox6.AutoSize = True
        Me.ChBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ChBox6.Location = New System.Drawing.Point(19, 106)
        Me.ChBox6.Name = "ChBox6"
        Me.ChBox6.Size = New System.Drawing.Size(58, 22)
        Me.ChBox6.TabIndex = 58
        Me.ChBox6.Text = "Aros"
        Me.ChBox6.UseVisualStyleBackColor = True
        '
        'txtfecha
        '
        Me.txtfecha.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtfecha.Location = New System.Drawing.Point(257, 58)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(104, 24)
        Me.txtfecha.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 21)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 21)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Marca"
        '
        'txtmarca
        '
        Me.txtmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtmarca.Location = New System.Drawing.Point(17, 161)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(100, 24)
        Me.txtmarca.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 21)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Usuario"
        '
        'txtUser
        '
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtUser.Enabled = False
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtUser.Location = New System.Drawing.Point(19, 58)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(100, 24)
        Me.txtUser.TabIndex = 65
        '
        'Timer1
        '
        '
        'txthora
        '
        Me.txthora.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txthora.Enabled = False
        Me.txthora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txthora.Location = New System.Drawing.Point(257, 111)
        Me.txthora.Name = "txthora"
        Me.txthora.ReadOnly = True
        Me.txthora.Size = New System.Drawing.Size(104, 24)
        Me.txthora.TabIndex = 68
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(286, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 21)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Hora"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.gbPaqueteT)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.txtdescripcion)
        Me.GroupBox4.Controls.Add(Me.gbSize)
        Me.GroupBox4.Controls.Add(Me.gbPaqueteE)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(31, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 489)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lavados"
        '
        'gbPaqueteT
        '
        Me.gbPaqueteT.Controls.Add(Me.Label3)
        Me.gbPaqueteT.Controls.Add(Me.cbTemporada)
        Me.gbPaqueteT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbPaqueteT.Location = New System.Drawing.Point(26, 148)
        Me.gbPaqueteT.Name = "gbPaqueteT"
        Me.gbPaqueteT.Size = New System.Drawing.Size(188, 115)
        Me.gbPaqueteT.TabIndex = 79
        Me.gbPaqueteT.TabStop = False
        Me.gbPaqueteT.Text = "Paquete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Selecciona un paquete"
        '
        'cbTemporada
        '
        Me.cbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTemporada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbTemporada.FormattingEnabled = True
        Me.cbTemporada.Location = New System.Drawing.Point(16, 60)
        Me.cbTemporada.Name = "cbTemporada"
        Me.cbTemporada.Size = New System.Drawing.Size(156, 26)
        Me.cbTemporada.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.cbxTipoCliente)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.cbxTipoPaquete)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.Location = New System.Drawing.Point(26, 27)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(188, 115)
        Me.GroupBox7.TabIndex = 75
        Me.GroupBox7.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Tipo de cliente"
        '
        'cbxTipoCliente
        '
        Me.cbxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbxTipoCliente.FormattingEnabled = True
        Me.cbxTipoCliente.Items.AddRange(New Object() {"Con cita", "Sin cita"})
        Me.cbxTipoCliente.Location = New System.Drawing.Point(12, 30)
        Me.cbxTipoCliente.Name = "cbxTipoCliente"
        Me.cbxTipoCliente.Size = New System.Drawing.Size(156, 26)
        Me.cbxTipoCliente.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Tipo de paquete"
        '
        'cbxTipoPaquete
        '
        Me.cbxTipoPaquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbxTipoPaquete.FormattingEnabled = True
        Me.cbxTipoPaquete.Items.AddRange(New Object() {"Estandar", "Temporada"})
        Me.cbxTipoPaquete.Location = New System.Drawing.Point(11, 79)
        Me.cbxTipoPaquete.Name = "cbxTipoPaquete"
        Me.cbxTipoPaquete.Size = New System.Drawing.Size(156, 26)
        Me.cbxTipoPaquete.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtpFechaPago)
        Me.GroupBox5.Controls.Add(Me.rbOtroDia)
        Me.GroupBox5.Controls.Add(Me.rbPagaHoy)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(228, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(123, 115)
        Me.GroupBox5.TabIndex = 74
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fecha de pago"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(9, 79)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(107, 24)
        Me.dtpFechaPago.TabIndex = 2
        '
        'rbOtroDia
        '
        Me.rbOtroDia.AutoSize = True
        Me.rbOtroDia.Location = New System.Drawing.Point(9, 50)
        Me.rbOtroDia.Name = "rbOtroDia"
        Me.rbOtroDia.Size = New System.Drawing.Size(79, 22)
        Me.rbOtroDia.TabIndex = 1
        Me.rbOtroDia.TabStop = True
        Me.rbOtroDia.Text = "Otro día"
        Me.rbOtroDia.UseVisualStyleBackColor = True
        '
        'rbPagaHoy
        '
        Me.rbPagaHoy.AutoSize = True
        Me.rbPagaHoy.Location = New System.Drawing.Point(9, 26)
        Me.rbPagaHoy.Name = "rbPagaHoy"
        Me.rbPagaHoy.Size = New System.Drawing.Size(88, 22)
        Me.rbPagaHoy.TabIndex = 0
        Me.rbPagaHoy.TabStop = True
        Me.rbPagaHoy.Text = "Paga hoy"
        Me.rbPagaHoy.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnBuscar)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txtfecha)
        Me.GroupBox6.Controls.Add(Me.txtlavador)
        Me.GroupBox6.Controls.Add(Me.txtplaca)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txthora)
        Me.GroupBox6.Controls.Add(Me.txtcliente)
        Me.GroupBox6.Controls.Add(Me.txtprecio)
        Me.GroupBox6.Controls.Add(Me.txtmarca)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtUser)
        Me.GroupBox6.Location = New System.Drawing.Point(364, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(390, 232)
        Me.GroupBox6.TabIndex = 71
        Me.GroupBox6.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChBoxChasis)
        Me.GroupBox3.Controls.Add(Me.ChBoxMotor)
        Me.GroupBox3.Controls.Add(Me.ChBox3)
        Me.GroupBox3.Controls.Add(Me.ChBox4)
        Me.GroupBox3.Controls.Add(Me.ChBox6)
        Me.GroupBox3.Controls.Add(Me.ChBox5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(228, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(123, 134)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lavacar.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(26, 295)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button2.Image = Global.Lavacar.My.Resources.Resources.if_1_2058800
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(417, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Limpiar pantalla"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Lavacar.My.Resources.Resources.if_ic_local_car_wash_48px_352495
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(599, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 40)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Ver lavados     "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.Lavacar.My.Resources.Resources.if_magnifyingglass_1055031
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(257, 158)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(104, 32)
        Me.btnBuscar.TabIndex = 69
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Lavacar.My.Resources.Resources.if_print_54346
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(234, 434)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 40)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Imprimir tiquete"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_file_zip_alt_285690
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_schedule_3755
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_door_out_35979
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.CombosToolStripMenuItem, Me.PreciosToolStripMenuItem})
        Me.AdminToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_user_avatar_human_admin_login_2203549
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosDelProgramaToolStripMenuItem, Me.PaquetesDelLavacarToolStripMenuItem, Me.LavadosRealizadosToolStripMenuItem, Me.ClientesDelLavacarToolStripMenuItem, Me.CitasRegistradasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_Statistics_67373
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_onebit_17_12591
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'CombosToolStripMenuItem
        '
        Me.CombosToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_package_18168
        Me.CombosToolStripMenuItem.Name = "CombosToolStripMenuItem"
        Me.CombosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CombosToolStripMenuItem.Text = "Paquetes"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_add_on_3018515
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PreciosToolStripMenuItem.Text = "Extras"
        '
        'UsuariosDelProgramaToolStripMenuItem
        '
        Me.UsuariosDelProgramaToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_admin_60298
        Me.UsuariosDelProgramaToolStripMenuItem.Name = "UsuariosDelProgramaToolStripMenuItem"
        Me.UsuariosDelProgramaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.UsuariosDelProgramaToolStripMenuItem.Text = "Usuarios del programa"
        '
        'PaquetesDelLavacarToolStripMenuItem
        '
        Me.PaquetesDelLavacarToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_package_18168
        Me.PaquetesDelLavacarToolStripMenuItem.Name = "PaquetesDelLavacarToolStripMenuItem"
        Me.PaquetesDelLavacarToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PaquetesDelLavacarToolStripMenuItem.Text = "Paquetes del lavacar"
        '
        'LavadosRealizadosToolStripMenuItem
        '
        Me.LavadosRealizadosToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_ic_local_car_wash_48px_352495
        Me.LavadosRealizadosToolStripMenuItem.Name = "LavadosRealizadosToolStripMenuItem"
        Me.LavadosRealizadosToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LavadosRealizadosToolStripMenuItem.Text = "Lavados realizados"
        '
        'ClientesDelLavacarToolStripMenuItem
        '
        Me.ClientesDelLavacarToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_onebit_17_12591
        Me.ClientesDelLavacarToolStripMenuItem.Name = "ClientesDelLavacarToolStripMenuItem"
        Me.ClientesDelLavacarToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ClientesDelLavacarToolStripMenuItem.Text = "Clientes del lavacar"
        '
        'CitasRegistradasToolStripMenuItem
        '
        Me.CitasRegistradasToolStripMenuItem.Image = Global.Lavacar.My.Resources.Resources.if_Statistics_67373
        Me.CitasRegistradasToolStripMenuItem.Name = "CitasRegistradasToolStripMenuItem"
        Me.CitasRegistradasToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CitasRegistradasToolStripMenuItem.Text = "Citas registradas"
        '
        'Pantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(835, 567)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Pantalla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoLavado Lujan 21"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbSize.ResumeLayout(False)
        Me.gbSize.PerformLayout()
        Me.gbPaqueteE.ResumeLayout(False)
        Me.gbPaqueteE.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbPaqueteT.ResumeLayout(False)
        Me.gbPaqueteT.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlavador As System.Windows.Forms.TextBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CombosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbpequeno As System.Windows.Forms.RadioButton
    Friend WithEvents rbmediano As System.Windows.Forms.RadioButton
    Friend WithEvents rbgrande As System.Windows.Forms.RadioButton
    Friend WithEvents gbSize As System.Windows.Forms.GroupBox
    Friend WithEvents gbPaqueteE As System.Windows.Forms.GroupBox
    Friend WithEvents rbmoto As System.Windows.Forms.RadioButton
    Friend WithEvents rbfull As System.Windows.Forms.RadioButton
    Friend WithEvents rbmedio As System.Windows.Forms.RadioButton
    Friend WithEvents rbbasico As System.Windows.Forms.RadioButton
    Friend WithEvents ChBoxChasis As System.Windows.Forms.CheckBox
    Friend WithEvents ChBoxMotor As System.Windows.Forms.CheckBox
    Friend WithEvents ChBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents ChBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents ChBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents ChBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTipoPaquete As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbOtroDia As RadioButton
    Friend WithEvents rbPagaHoy As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTipoCliente As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Private WithEvents txtprecio As TextBox
    Private WithEvents txtfecha As TextBox
    Private WithEvents txtUser As TextBox
    Private WithEvents txthora As TextBox
    Private WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents rbChasis As RadioButton
    Friend WithEvents rdMotor As RadioButton
    Friend WithEvents gbPaqueteT As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTemporada As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents UsuariosDelProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaquetesDelLavacarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LavadosRealizadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesDelLavacarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CitasRegistradasToolStripMenuItem As ToolStripMenuItem
End Class
