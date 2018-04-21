<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paquetes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbControlPaquetes = New System.Windows.Forms.TabControl()
        Me.tbPaquetes = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.CbxTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupTemporada = New System.Windows.Forms.GroupBox()
        Me.txtNombreT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtbDescripT = New System.Windows.Forms.RichTextBox()
        Me.GroupEstandar = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtbDescripE = New System.Windows.Forms.RichTextBox()
        Me.rbBásicoE = New System.Windows.Forms.RadioButton()
        Me.rbFullE = New System.Windows.Forms.RadioButton()
        Me.rbMedioE = New System.Windows.Forms.RadioButton()
        Me.tbListapaquetes = New System.Windows.Forms.TabPage()
        Me.gbTodos = New System.Windows.Forms.GroupBox()
        Me.dtgPaquetesTodos = New System.Windows.Forms.DataGridView()
        Me.PaqIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaqNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaqTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaqDescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaqCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblPaquetesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbLujan21DataSet2 = New Lavacar.dbLujan21DataSet2()
        Me.TblPaquetesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbLujan21DataSet1 = New Lavacar.dbLujan21DataSet1()
        Me.TblPaquetesTableAdapter = New Lavacar.dbLujan21DataSet1TableAdapters.tblPaquetesTableAdapter()
        Me.TblPaquetesTableAdapter1 = New Lavacar.dbLujan21DataSet2TableAdapters.tblPaquetesTableAdapter()
        Me.tbControlPaquetes.SuspendLayout()
        Me.tbPaquetes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupTemporada.SuspendLayout()
        Me.GroupEstandar.SuspendLayout()
        Me.tbListapaquetes.SuspendLayout()
        Me.gbTodos.SuspendLayout()
        CType(Me.dtgPaquetesTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaquetesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaquetesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControlPaquetes
        '
        Me.tbControlPaquetes.Controls.Add(Me.tbPaquetes)
        Me.tbControlPaquetes.Controls.Add(Me.tbListapaquetes)
        Me.tbControlPaquetes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbControlPaquetes.Location = New System.Drawing.Point(0, 0)
        Me.tbControlPaquetes.Name = "tbControlPaquetes"
        Me.tbControlPaquetes.SelectedIndex = 0
        Me.tbControlPaquetes.Size = New System.Drawing.Size(538, 392)
        Me.tbControlPaquetes.TabIndex = 67
        '
        'tbPaquetes
        '
        Me.tbPaquetes.Controls.Add(Me.GroupBox2)
        Me.tbPaquetes.Controls.Add(Me.CbxTipo)
        Me.tbPaquetes.Controls.Add(Me.Label1)
        Me.tbPaquetes.Controls.Add(Me.GroupTemporada)
        Me.tbPaquetes.Controls.Add(Me.GroupEstandar)
        Me.tbPaquetes.Location = New System.Drawing.Point(4, 22)
        Me.tbPaquetes.Name = "tbPaquetes"
        Me.tbPaquetes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPaquetes.Size = New System.Drawing.Size(530, 366)
        Me.tbPaquetes.TabIndex = 0
        Me.tbPaquetes.Text = "Registro de paquetes"
        Me.tbPaquetes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnCrear)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnVerTodos)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 67)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnLimpiar.Image = Global.Lavacar.My.Resources.Resources.if_1_2058800
        Me.btnLimpiar.Location = New System.Drawing.Point(470, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(40, 40)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCrear.Image = Global.Lavacar.My.Resources.Resources.if_AddThis_Social_Network_communicate_page_curl_437908
        Me.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrear.Location = New System.Drawing.Point(2, 19)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(115, 40)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnModificar.Image = Global.Lavacar.My.Resources.Resources.if_note_edit_66829
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(118, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 40)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnVerTodos.Image = Global.Lavacar.My.Resources.Resources.if_icon_45_note_list_314884
        Me.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerTodos.Location = New System.Drawing.Point(354, 19)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(115, 40)
        Me.btnVerTodos.TabIndex = 7
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerTodos.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBorrar.Image = Global.Lavacar.My.Resources.Resources.if_trashcan_delete2_44451
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(236, 19)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(115, 40)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'CbxTipo
        '
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CbxTipo.FormattingEnabled = True
        Me.CbxTipo.Items.AddRange(New Object() {"Estandar", "Temporada"})
        Me.CbxTipo.Location = New System.Drawing.Point(136, 18)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(147, 26)
        Me.CbxTipo.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Tipo de paquete:"
        '
        'GroupTemporada
        '
        Me.GroupTemporada.Controls.Add(Me.txtNombreT)
        Me.GroupTemporada.Controls.Add(Me.Label6)
        Me.GroupTemporada.Controls.Add(Me.Label3)
        Me.GroupTemporada.Controls.Add(Me.txtPrecioT)
        Me.GroupTemporada.Controls.Add(Me.Label5)
        Me.GroupTemporada.Controls.Add(Me.rtbDescripT)
        Me.GroupTemporada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTemporada.Location = New System.Drawing.Point(8, 56)
        Me.GroupTemporada.Name = "GroupTemporada"
        Me.GroupTemporada.Size = New System.Drawing.Size(514, 222)
        Me.GroupTemporada.TabIndex = 70
        Me.GroupTemporada.TabStop = False
        Me.GroupTemporada.Text = "Temporada"
        '
        'txtNombreT
        '
        Me.txtNombreT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtNombreT.Location = New System.Drawing.Point(98, 34)
        Me.txtNombreT.Name = "txtNombreT"
        Me.txtNombreT.Size = New System.Drawing.Size(147, 24)
        Me.txtNombreT.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 21)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Descripción"
        '
        'txtPrecioT
        '
        Me.txtPrecioT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPrecioT.Location = New System.Drawing.Point(342, 34)
        Me.txtPrecioT.Name = "txtPrecioT"
        Me.txtPrecioT.Size = New System.Drawing.Size(147, 24)
        Me.txtPrecioT.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(282, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 21)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Precio:"
        '
        'rtbDescripT
        '
        Me.rtbDescripT.Location = New System.Drawing.Point(24, 92)
        Me.rtbDescripT.Name = "rtbDescripT"
        Me.rtbDescripT.Size = New System.Drawing.Size(465, 110)
        Me.rtbDescripT.TabIndex = 53
        Me.rtbDescripT.Text = ""
        '
        'GroupEstandar
        '
        Me.GroupEstandar.Controls.Add(Me.Label2)
        Me.GroupEstandar.Controls.Add(Me.txtPrecioE)
        Me.GroupEstandar.Controls.Add(Me.Label4)
        Me.GroupEstandar.Controls.Add(Me.rtbDescripE)
        Me.GroupEstandar.Controls.Add(Me.rbBásicoE)
        Me.GroupEstandar.Controls.Add(Me.rbFullE)
        Me.GroupEstandar.Controls.Add(Me.rbMedioE)
        Me.GroupEstandar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupEstandar.Location = New System.Drawing.Point(8, 57)
        Me.GroupEstandar.Name = "GroupEstandar"
        Me.GroupEstandar.Size = New System.Drawing.Size(514, 221)
        Me.GroupEstandar.TabIndex = 69
        Me.GroupEstandar.TabStop = False
        Me.GroupEstandar.Text = "Estandar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Descripción"
        '
        'txtPrecioE
        '
        Me.txtPrecioE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPrecioE.Location = New System.Drawing.Point(359, 37)
        Me.txtPrecioE.Name = "txtPrecioE"
        Me.txtPrecioE.Size = New System.Drawing.Size(126, 24)
        Me.txtPrecioE.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Precio:"
        '
        'rtbDescripE
        '
        Me.rtbDescripE.Location = New System.Drawing.Point(20, 93)
        Me.rtbDescripE.Name = "rtbDescripE"
        Me.rtbDescripE.Size = New System.Drawing.Size(465, 110)
        Me.rtbDescripE.TabIndex = 53
        Me.rtbDescripE.Text = ""
        '
        'rbBásicoE
        '
        Me.rbBásicoE.AutoSize = True
        Me.rbBásicoE.Checked = True
        Me.rbBásicoE.Location = New System.Drawing.Point(22, 37)
        Me.rbBásicoE.Name = "rbBásicoE"
        Me.rbBásicoE.Size = New System.Drawing.Size(72, 22)
        Me.rbBásicoE.TabIndex = 50
        Me.rbBásicoE.TabStop = True
        Me.rbBásicoE.Text = "Básico"
        Me.rbBásicoE.UseVisualStyleBackColor = True
        '
        'rbFullE
        '
        Me.rbFullE.AutoSize = True
        Me.rbFullE.Location = New System.Drawing.Point(202, 37)
        Me.rbFullE.Name = "rbFullE"
        Me.rbFullE.Size = New System.Drawing.Size(49, 22)
        Me.rbFullE.TabIndex = 52
        Me.rbFullE.Text = "Full"
        Me.rbFullE.UseVisualStyleBackColor = True
        '
        'rbMedioE
        '
        Me.rbMedioE.AutoSize = True
        Me.rbMedioE.Location = New System.Drawing.Point(113, 37)
        Me.rbMedioE.Name = "rbMedioE"
        Me.rbMedioE.Size = New System.Drawing.Size(67, 22)
        Me.rbMedioE.TabIndex = 51
        Me.rbMedioE.Text = "Medio"
        Me.rbMedioE.UseVisualStyleBackColor = True
        '
        'tbListapaquetes
        '
        Me.tbListapaquetes.Controls.Add(Me.gbTodos)
        Me.tbListapaquetes.Location = New System.Drawing.Point(4, 22)
        Me.tbListapaquetes.Name = "tbListapaquetes"
        Me.tbListapaquetes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbListapaquetes.Size = New System.Drawing.Size(530, 366)
        Me.tbListapaquetes.TabIndex = 1
        Me.tbListapaquetes.Text = "Lista de paquetes"
        Me.tbListapaquetes.UseVisualStyleBackColor = True
        '
        'gbTodos
        '
        Me.gbTodos.Controls.Add(Me.dtgPaquetesTodos)
        Me.gbTodos.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbTodos.Location = New System.Drawing.Point(3, 3)
        Me.gbTodos.Name = "gbTodos"
        Me.gbTodos.Size = New System.Drawing.Size(524, 363)
        Me.gbTodos.TabIndex = 0
        Me.gbTodos.TabStop = False
        Me.gbTodos.Text = "Todos los paquetes"
        '
        'dtgPaquetesTodos
        '
        Me.dtgPaquetesTodos.AllowUserToAddRows = False
        Me.dtgPaquetesTodos.AllowUserToDeleteRows = False
        Me.dtgPaquetesTodos.AllowUserToResizeColumns = False
        Me.dtgPaquetesTodos.AllowUserToResizeRows = False
        Me.dtgPaquetesTodos.AutoGenerateColumns = False
        Me.dtgPaquetesTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPaquetesTodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaqIdDataGridViewTextBoxColumn, Me.PaqNombreDataGridViewTextBoxColumn, Me.PaqTipoDataGridViewTextBoxColumn, Me.PaqDescripcionDataGridViewTextBoxColumn, Me.PaqCostoDataGridViewTextBoxColumn})
        Me.dtgPaquetesTodos.DataSource = Me.TblPaquetesBindingSource1
        Me.dtgPaquetesTodos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPaquetesTodos.Location = New System.Drawing.Point(3, 16)
        Me.dtgPaquetesTodos.Name = "dtgPaquetesTodos"
        Me.dtgPaquetesTodos.Size = New System.Drawing.Size(518, 344)
        Me.dtgPaquetesTodos.TabIndex = 1
        '
        'PaqIdDataGridViewTextBoxColumn
        '
        Me.PaqIdDataGridViewTextBoxColumn.DataPropertyName = "paqId"
        Me.PaqIdDataGridViewTextBoxColumn.HeaderText = "paqId"
        Me.PaqIdDataGridViewTextBoxColumn.Name = "PaqIdDataGridViewTextBoxColumn"
        Me.PaqIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaqNombreDataGridViewTextBoxColumn
        '
        Me.PaqNombreDataGridViewTextBoxColumn.DataPropertyName = "paqNombre"
        Me.PaqNombreDataGridViewTextBoxColumn.HeaderText = "paqNombre"
        Me.PaqNombreDataGridViewTextBoxColumn.Name = "PaqNombreDataGridViewTextBoxColumn"
        '
        'PaqTipoDataGridViewTextBoxColumn
        '
        Me.PaqTipoDataGridViewTextBoxColumn.DataPropertyName = "paqTipo"
        Me.PaqTipoDataGridViewTextBoxColumn.HeaderText = "paqTipo"
        Me.PaqTipoDataGridViewTextBoxColumn.Name = "PaqTipoDataGridViewTextBoxColumn"
        '
        'PaqDescripcionDataGridViewTextBoxColumn
        '
        Me.PaqDescripcionDataGridViewTextBoxColumn.DataPropertyName = "paqDescripcion"
        Me.PaqDescripcionDataGridViewTextBoxColumn.HeaderText = "paqDescripcion"
        Me.PaqDescripcionDataGridViewTextBoxColumn.Name = "PaqDescripcionDataGridViewTextBoxColumn"
        '
        'PaqCostoDataGridViewTextBoxColumn
        '
        Me.PaqCostoDataGridViewTextBoxColumn.DataPropertyName = "paqCosto"
        Me.PaqCostoDataGridViewTextBoxColumn.HeaderText = "paqCosto"
        Me.PaqCostoDataGridViewTextBoxColumn.Name = "PaqCostoDataGridViewTextBoxColumn"
        '
        'TblPaquetesBindingSource1
        '
        Me.TblPaquetesBindingSource1.DataMember = "tblPaquetes"
        Me.TblPaquetesBindingSource1.DataSource = Me.DbLujan21DataSet2
        '
        'DbLujan21DataSet2
        '
        Me.DbLujan21DataSet2.DataSetName = "dbLujan21DataSet2"
        Me.DbLujan21DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPaquetesBindingSource
        '
        Me.TblPaquetesBindingSource.DataMember = "tblPaquetes"
        Me.TblPaquetesBindingSource.DataSource = Me.DbLujan21DataSet1
        '
        'DbLujan21DataSet1
        '
        Me.DbLujan21DataSet1.DataSetName = "dbLujan21DataSet1"
        Me.DbLujan21DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPaquetesTableAdapter
        '
        Me.TblPaquetesTableAdapter.ClearBeforeFill = True
        '
        'TblPaquetesTableAdapter1
        '
        Me.TblPaquetesTableAdapter1.ClearBeforeFill = True
        '
        'Paquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(538, 392)
        Me.Controls.Add(Me.tbControlPaquetes)
        Me.MaximizeBox = False
        Me.Name = "Paquetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paquetes"
        Me.tbControlPaquetes.ResumeLayout(False)
        Me.tbPaquetes.ResumeLayout(False)
        Me.tbPaquetes.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupTemporada.ResumeLayout(False)
        Me.GroupTemporada.PerformLayout()
        Me.GroupEstandar.ResumeLayout(False)
        Me.GroupEstandar.PerformLayout()
        Me.tbListapaquetes.ResumeLayout(False)
        Me.gbTodos.ResumeLayout(False)
        CType(Me.dtgPaquetesTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaquetesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaquetesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbControlPaquetes As TabControl
    Friend WithEvents tbPaquetes As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnVerTodos As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents CbxTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupEstandar As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecioE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rtbDescripE As RichTextBox
    Friend WithEvents rbBásicoE As RadioButton
    Friend WithEvents rbFullE As RadioButton
    Friend WithEvents rbMedioE As RadioButton
    Friend WithEvents GroupTemporada As GroupBox
    Friend WithEvents txtNombreT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rtbDescripT As RichTextBox
    Friend WithEvents DbLujan21DataSet1 As dbLujan21DataSet1
    Friend WithEvents TblPaquetesBindingSource As BindingSource
    Friend WithEvents TblPaquetesTableAdapter As dbLujan21DataSet1TableAdapters.tblPaquetesTableAdapter
    Friend WithEvents tbListapaquetes As TabPage
    Friend WithEvents gbTodos As GroupBox
    Friend WithEvents dtgPaquetesTodos As DataGridView
    Friend WithEvents PaqIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaqNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaqTipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaqDescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaqCostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DbLujan21DataSet2 As dbLujan21DataSet2
    Friend WithEvents TblPaquetesBindingSource1 As BindingSource
    Friend WithEvents TblPaquetesTableAdapter1 As dbLujan21DataSet2TableAdapters.tblPaquetesTableAdapter
End Class
