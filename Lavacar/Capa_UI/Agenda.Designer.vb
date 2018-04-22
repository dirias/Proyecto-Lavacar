<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agenda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agenda))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbDetalle = New System.Windows.Forms.RichTextBox()
        Me.mtbHora = New System.Windows.Forms.MaskedTextBox()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombreCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVercitas = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtgCitas = New System.Windows.Forms.DataGridView()
        Me.CitIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitPlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitMarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitHoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitTelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitDescripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbLujan21DataSet3 = New Lavacar.dbLujan21DataSet3()
        Me.DbLujan21DataSet1 = New Lavacar.dbLujan21DataSet1()
        Me.DbLujan21DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCitasTableAdapter = New Lavacar.dbLujan21DataSet3TableAdapters.tblCitasTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(595, 397)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(587, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reservar citas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lavacar.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(482, 296)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbDetalle)
        Me.GroupBox2.Controls.Add(Me.mtbHora)
        Me.GroupBox2.Controls.Add(Me.mtbTelefono)
        Me.GroupBox2.Controls.Add(Me.txtMarca)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPlaca)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtApellidos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtnombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 277)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'rtbDetalle
        '
        Me.rtbDetalle.Location = New System.Drawing.Point(208, 166)
        Me.rtbDetalle.Name = "rtbDetalle"
        Me.rtbDetalle.Size = New System.Drawing.Size(307, 93)
        Me.rtbDetalle.TabIndex = 50
        Me.rtbDetalle.Text = ""
        '
        'mtbHora
        '
        Me.mtbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbHora.Location = New System.Drawing.Point(372, 110)
        Me.mtbHora.Mask = "00:00"
        Me.mtbHora.Name = "mtbHora"
        Me.mtbHora.Size = New System.Drawing.Size(143, 24)
        Me.mtbHora.TabIndex = 49
        Me.mtbHora.ValidatingType = GetType(Date)
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbTelefono.Location = New System.Drawing.Point(35, 166)
        Me.mtbTelefono.Mask = "(999)0000-0000"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(143, 24)
        Me.mtbTelefono.TabIndex = 48
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(372, 54)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(143, 24)
        Me.txtMarca.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Marca"
        '
        'txtPlaca
        '
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(198, 54)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(143, 24)
        Me.txtPlaca.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Placa del vehículo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(212, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Detalle"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(198, 110)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(143, 24)
        Me.dtpFecha.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(406, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Teléfono"
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(34, 110)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(143, 24)
        Me.txtApellidos.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Apellidos"
        '
        'txtnombreCliente
        '
        Me.txtnombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreCliente.Location = New System.Drawing.Point(34, 54)
        Me.txtnombreCliente.Name = "txtnombreCliente"
        Me.txtnombreCliente.Size = New System.Drawing.Size(143, 24)
        Me.txtnombreCliente.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnVercitas)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnReservar)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 68)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnLimpiar.Image = Global.Lavacar.My.Resources.Resources.if_1_2058800
        Me.btnLimpiar.Location = New System.Drawing.Point(413, 17)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(40, 40)
        Me.btnLimpiar.TabIndex = 31
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnVercitas
        '
        Me.btnVercitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVercitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVercitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVercitas.Image = Global.Lavacar.My.Resources.Resources.if_icon_45_note_list_3148841
        Me.btnVercitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVercitas.Location = New System.Drawing.Point(278, 17)
        Me.btnVercitas.Name = "btnVercitas"
        Me.btnVercitas.Size = New System.Drawing.Size(130, 40)
        Me.btnVercitas.TabIndex = 30
        Me.btnVercitas.Text = "Ver citas      "
        Me.btnVercitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVercitas.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Lavacar.My.Resources.Resources.if_note_edit_66829
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(140, 18)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(130, 40)
        Me.btnModificar.TabIndex = 29
        Me.btnModificar.Text = "Modificar cita"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnReservar
        '
        Me.btnReservar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.Image = Global.Lavacar.My.Resources.Resources.if_AddThis_Social_Network_communicate_page_curl_437908
        Me.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservar.Location = New System.Drawing.Point(5, 18)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(130, 40)
        Me.btnReservar.TabIndex = 26
        Me.btnReservar.Text = "Reservar cita"
        Me.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReservar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgCitas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(587, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Citas reservadas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtgCitas
        '
        Me.dtgCitas.AllowUserToAddRows = False
        Me.dtgCitas.AllowUserToDeleteRows = False
        Me.dtgCitas.AllowUserToResizeColumns = False
        Me.dtgCitas.AllowUserToResizeRows = False
        Me.dtgCitas.AutoGenerateColumns = False
        Me.dtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCitas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CitIdDataGridViewTextBoxColumn, Me.CitNombreDataGridViewTextBoxColumn, Me.CitApellidosDataGridViewTextBoxColumn, Me.CitPlacaDataGridViewTextBoxColumn, Me.CitMarcaDataGridViewTextBoxColumn, Me.CitFechaDataGridViewTextBoxColumn, Me.CitHoraDataGridViewTextBoxColumn, Me.CitTelefonoDataGridViewTextBoxColumn, Me.CitDescripDataGridViewTextBoxColumn})
        Me.dtgCitas.DataSource = Me.TblCitasBindingSource
        Me.dtgCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCitas.Location = New System.Drawing.Point(3, 3)
        Me.dtgCitas.Name = "dtgCitas"
        Me.dtgCitas.Size = New System.Drawing.Size(581, 365)
        Me.dtgCitas.TabIndex = 0
        '
        'CitIdDataGridViewTextBoxColumn
        '
        Me.CitIdDataGridViewTextBoxColumn.DataPropertyName = "citId"
        Me.CitIdDataGridViewTextBoxColumn.HeaderText = "citId"
        Me.CitIdDataGridViewTextBoxColumn.Name = "CitIdDataGridViewTextBoxColumn"
        Me.CitIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CitNombreDataGridViewTextBoxColumn
        '
        Me.CitNombreDataGridViewTextBoxColumn.DataPropertyName = "citNombre"
        Me.CitNombreDataGridViewTextBoxColumn.HeaderText = "citNombre"
        Me.CitNombreDataGridViewTextBoxColumn.Name = "CitNombreDataGridViewTextBoxColumn"
        '
        'CitApellidosDataGridViewTextBoxColumn
        '
        Me.CitApellidosDataGridViewTextBoxColumn.DataPropertyName = "citApellidos"
        Me.CitApellidosDataGridViewTextBoxColumn.HeaderText = "citApellidos"
        Me.CitApellidosDataGridViewTextBoxColumn.Name = "CitApellidosDataGridViewTextBoxColumn"
        '
        'CitPlacaDataGridViewTextBoxColumn
        '
        Me.CitPlacaDataGridViewTextBoxColumn.DataPropertyName = "citPlaca"
        Me.CitPlacaDataGridViewTextBoxColumn.HeaderText = "citPlaca"
        Me.CitPlacaDataGridViewTextBoxColumn.Name = "CitPlacaDataGridViewTextBoxColumn"
        '
        'CitMarcaDataGridViewTextBoxColumn
        '
        Me.CitMarcaDataGridViewTextBoxColumn.DataPropertyName = "citMarca"
        Me.CitMarcaDataGridViewTextBoxColumn.HeaderText = "citMarca"
        Me.CitMarcaDataGridViewTextBoxColumn.Name = "CitMarcaDataGridViewTextBoxColumn"
        '
        'CitFechaDataGridViewTextBoxColumn
        '
        Me.CitFechaDataGridViewTextBoxColumn.DataPropertyName = "citFecha"
        Me.CitFechaDataGridViewTextBoxColumn.HeaderText = "citFecha"
        Me.CitFechaDataGridViewTextBoxColumn.Name = "CitFechaDataGridViewTextBoxColumn"
        '
        'CitHoraDataGridViewTextBoxColumn
        '
        Me.CitHoraDataGridViewTextBoxColumn.DataPropertyName = "citHora"
        Me.CitHoraDataGridViewTextBoxColumn.HeaderText = "citHora"
        Me.CitHoraDataGridViewTextBoxColumn.Name = "CitHoraDataGridViewTextBoxColumn"
        '
        'CitTelefonoDataGridViewTextBoxColumn
        '
        Me.CitTelefonoDataGridViewTextBoxColumn.DataPropertyName = "citTelefono"
        Me.CitTelefonoDataGridViewTextBoxColumn.HeaderText = "citTelefono"
        Me.CitTelefonoDataGridViewTextBoxColumn.Name = "CitTelefonoDataGridViewTextBoxColumn"
        '
        'CitDescripDataGridViewTextBoxColumn
        '
        Me.CitDescripDataGridViewTextBoxColumn.DataPropertyName = "citDescrip"
        Me.CitDescripDataGridViewTextBoxColumn.HeaderText = "citDescrip"
        Me.CitDescripDataGridViewTextBoxColumn.Name = "CitDescripDataGridViewTextBoxColumn"
        '
        'TblCitasBindingSource
        '
        Me.TblCitasBindingSource.DataMember = "tblCitas"
        Me.TblCitasBindingSource.DataSource = Me.DbLujan21DataSet3
        '
        'DbLujan21DataSet3
        '
        Me.DbLujan21DataSet3.DataSetName = "dbLujan21DataSet3"
        Me.DbLujan21DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbLujan21DataSet1
        '
        Me.DbLujan21DataSet1.DataSetName = "dbLujan21DataSet1"
        Me.DbLujan21DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbLujan21DataSet1BindingSource
        '
        Me.DbLujan21DataSet1BindingSource.DataSource = Me.DbLujan21DataSet1
        Me.DbLujan21DataSet1BindingSource.Position = 0
        '
        'TblCitasTableAdapter
        '
        Me.TblCitasTableAdapter.ClearBeforeFill = True
        '
        'Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 397)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rtbDetalle As RichTextBox
    Friend WithEvents mtbHora As MaskedTextBox
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombreCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVercitas As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnReservar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtgCitas As DataGridView
    Friend WithEvents DbLujan21DataSet1BindingSource As BindingSource
    Friend WithEvents DbLujan21DataSet1 As dbLujan21DataSet1
    Friend WithEvents DbLujan21DataSet3 As dbLujan21DataSet3
    Friend WithEvents TblCitasBindingSource As BindingSource
    Friend WithEvents TblCitasTableAdapter As dbLujan21DataSet3TableAdapters.tblCitasTableAdapter
    Friend WithEvents CitIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitPlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitMarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitFechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitHoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitTelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitDescripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
