<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Extras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Extras))
        Me.tbControlUsuarios = New System.Windows.Forms.TabControl()
        Me.tbRegistar = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegistrarExtra = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.tbTodos = New System.Windows.Forms.TabPage()
        Me.dtgExtras = New System.Windows.Forms.DataGridView()
        Me.DbLujan21DataSet4 = New Lavacar.dbLujan21DataSet4()
        Me.TblExtrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblExtrasTableAdapter = New Lavacar.dbLujan21DataSet4TableAdapters.tblExtrasTableAdapter()
        Me.ExtIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbControlUsuarios.SuspendLayout()
        Me.tbRegistar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tbTodos.SuspendLayout()
        CType(Me.dtgExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExtrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControlUsuarios
        '
        Me.tbControlUsuarios.Controls.Add(Me.tbRegistar)
        Me.tbControlUsuarios.Controls.Add(Me.tbTodos)
        Me.tbControlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbControlUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbControlUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tbControlUsuarios.Name = "tbControlUsuarios"
        Me.tbControlUsuarios.SelectedIndex = 0
        Me.tbControlUsuarios.Size = New System.Drawing.Size(458, 288)
        Me.tbControlUsuarios.TabIndex = 54
        '
        'tbRegistar
        '
        Me.tbRegistar.Controls.Add(Me.GroupBox1)
        Me.tbRegistar.Controls.Add(Me.GroupBox2)
        Me.tbRegistar.Location = New System.Drawing.Point(4, 22)
        Me.tbRegistar.Name = "tbRegistar"
        Me.tbRegistar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegistar.Size = New System.Drawing.Size(450, 262)
        Me.tbRegistar.TabIndex = 0
        Me.tbRegistar.Text = "Registro de extras"
        Me.tbRegistar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 178)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extras"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lavacar.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(294, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Costo:"
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(107, 103)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(160, 24)
        Me.txtCosto.TabIndex = 46
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(107, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 24)
        Me.txtNombre.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnRegistrarExtra)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 67)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnLimpiar.Image = Global.Lavacar.My.Resources.Resources.if_1_2058800
        Me.btnLimpiar.Location = New System.Drawing.Point(387, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(40, 40)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRegistrarExtra
        '
        Me.btnRegistrarExtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnRegistrarExtra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnRegistrarExtra.Image = Global.Lavacar.My.Resources.Resources.if_AddThis_Social_Network_communicate_page_curl_437908
        Me.btnRegistrarExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarExtra.Location = New System.Drawing.Point(13, 19)
        Me.btnRegistrarExtra.Name = "btnRegistrarExtra"
        Me.btnRegistrarExtra.Size = New System.Drawing.Size(115, 40)
        Me.btnRegistrarExtra.TabIndex = 0
        Me.btnRegistrarExtra.Text = "Crear"
        Me.btnRegistrarExtra.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Enabled = False
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnModificar.Image = Global.Lavacar.My.Resources.Resources.if_note_edit_66829
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(139, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 40)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBorrar.Image = Global.Lavacar.My.Resources.Resources.if_trashcan_delete2_44451
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(264, 19)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(115, 40)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'tbTodos
        '
        Me.tbTodos.Controls.Add(Me.dtgExtras)
        Me.tbTodos.Location = New System.Drawing.Point(4, 22)
        Me.tbTodos.Name = "tbTodos"
        Me.tbTodos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTodos.Size = New System.Drawing.Size(450, 262)
        Me.tbTodos.TabIndex = 1
        Me.tbTodos.Text = "Extras Registradas"
        Me.tbTodos.UseVisualStyleBackColor = True
        '
        'dtgExtras
        '
        Me.dtgExtras.AllowUserToAddRows = False
        Me.dtgExtras.AllowUserToDeleteRows = False
        Me.dtgExtras.AllowUserToResizeColumns = False
        Me.dtgExtras.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgExtras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgExtras.AutoGenerateColumns = False
        Me.dtgExtras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgExtras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExtIdDataGridViewTextBoxColumn, Me.ExtNombreDataGridViewTextBoxColumn, Me.ExtCostoDataGridViewTextBoxColumn})
        Me.dtgExtras.DataSource = Me.TblExtrasBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgExtras.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgExtras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgExtras.Location = New System.Drawing.Point(3, 3)
        Me.dtgExtras.Name = "dtgExtras"
        Me.dtgExtras.ReadOnly = True
        Me.dtgExtras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgExtras.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgExtras.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgExtras.Size = New System.Drawing.Size(444, 256)
        Me.dtgExtras.TabIndex = 0
        '
        'DbLujan21DataSet4
        '
        Me.DbLujan21DataSet4.DataSetName = "dbLujan21DataSet4"
        Me.DbLujan21DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblExtrasBindingSource
        '
        Me.TblExtrasBindingSource.DataMember = "tblExtras"
        Me.TblExtrasBindingSource.DataSource = Me.DbLujan21DataSet4
        '
        'TblExtrasTableAdapter
        '
        Me.TblExtrasTableAdapter.ClearBeforeFill = True
        '
        'ExtIdDataGridViewTextBoxColumn
        '
        Me.ExtIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ExtIdDataGridViewTextBoxColumn.DataPropertyName = "extId"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtIdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ExtIdDataGridViewTextBoxColumn.HeaderText = "Id de la extra"
        Me.ExtIdDataGridViewTextBoxColumn.Name = "ExtIdDataGridViewTextBoxColumn"
        Me.ExtIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExtNombreDataGridViewTextBoxColumn
        '
        Me.ExtNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ExtNombreDataGridViewTextBoxColumn.DataPropertyName = "extNombre"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtNombreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ExtNombreDataGridViewTextBoxColumn.HeaderText = "Nombre "
        Me.ExtNombreDataGridViewTextBoxColumn.Name = "ExtNombreDataGridViewTextBoxColumn"
        Me.ExtNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExtCostoDataGridViewTextBoxColumn
        '
        Me.ExtCostoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ExtCostoDataGridViewTextBoxColumn.DataPropertyName = "extCosto"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtCostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExtCostoDataGridViewTextBoxColumn.HeaderText = "Costo "
        Me.ExtCostoDataGridViewTextBoxColumn.Name = "ExtCostoDataGridViewTextBoxColumn"
        Me.ExtCostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Extras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 288)
        Me.Controls.Add(Me.tbControlUsuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Extras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de extras"
        Me.tbControlUsuarios.ResumeLayout(False)
        Me.tbRegistar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.tbTodos.ResumeLayout(False)
        CType(Me.dtgExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExtrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbControlUsuarios As TabControl
    Friend WithEvents tbRegistar As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegistrarExtra As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents tbTodos As TabPage
    Friend WithEvents dtgExtras As DataGridView
    Friend WithEvents DbLujan21DataSet4 As dbLujan21DataSet4
    Friend WithEvents TblExtrasBindingSource As BindingSource
    Friend WithEvents TblExtrasTableAdapter As dbLujan21DataSet4TableAdapters.tblExtrasTableAdapter
    Friend WithEvents ExtIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtCostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
