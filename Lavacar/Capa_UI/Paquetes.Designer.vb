<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paquetes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxTipo = New System.Windows.Forms.ComboBox()
        Me.GroupEstandar = New System.Windows.Forms.GroupBox()
        Me.rbpequeno = New System.Windows.Forms.RadioButton()
        Me.rbgrande = New System.Windows.Forms.RadioButton()
        Me.rbmediano = New System.Windows.Forms.RadioButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupTemporada = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupEstandar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupTemporada.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Tipo de paquete:"
        '
        'CbxTipo
        '
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CbxTipo.FormattingEnabled = True
        Me.CbxTipo.Items.AddRange(New Object() {"Estandar", "Temporada"})
        Me.CbxTipo.Location = New System.Drawing.Point(140, 30)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(147, 26)
        Me.CbxTipo.TabIndex = 63
        '
        'GroupEstandar
        '
        Me.GroupEstandar.Controls.Add(Me.Label2)
        Me.GroupEstandar.Controls.Add(Me.txtnumero)
        Me.GroupEstandar.Controls.Add(Me.Label4)
        Me.GroupEstandar.Controls.Add(Me.RichTextBox1)
        Me.GroupEstandar.Controls.Add(Me.rbpequeno)
        Me.GroupEstandar.Controls.Add(Me.rbgrande)
        Me.GroupEstandar.Controls.Add(Me.rbmediano)
        Me.GroupEstandar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupEstandar.Location = New System.Drawing.Point(24, 73)
        Me.GroupEstandar.Name = "GroupEstandar"
        Me.GroupEstandar.Size = New System.Drawing.Size(489, 215)
        Me.GroupEstandar.TabIndex = 64
        Me.GroupEstandar.TabStop = False
        Me.GroupEstandar.Text = "Estandar"
        '
        'rbpequeno
        '
        Me.rbpequeno.AutoSize = True
        Me.rbpequeno.Checked = True
        Me.rbpequeno.Location = New System.Drawing.Point(55, 29)
        Me.rbpequeno.Name = "rbpequeno"
        Me.rbpequeno.Size = New System.Drawing.Size(85, 22)
        Me.rbpequeno.TabIndex = 50
        Me.rbpequeno.TabStop = True
        Me.rbpequeno.Text = "Pequeño"
        Me.rbpequeno.UseVisualStyleBackColor = True
        '
        'rbgrande
        '
        Me.rbgrande.AutoSize = True
        Me.rbgrande.Location = New System.Drawing.Point(235, 29)
        Me.rbgrande.Name = "rbgrande"
        Me.rbgrande.Size = New System.Drawing.Size(75, 22)
        Me.rbgrande.TabIndex = 52
        Me.rbgrande.Text = "Grande"
        Me.rbgrande.UseVisualStyleBackColor = True
        '
        'rbmediano
        '
        Me.rbmediano.AutoSize = True
        Me.rbmediano.Location = New System.Drawing.Point(146, 29)
        Me.rbmediano.Name = "rbmediano"
        Me.rbmediano.Size = New System.Drawing.Size(83, 22)
        Me.rbmediano.TabIndex = 51
        Me.rbmediano.Text = "Mediano"
        Me.rbmediano.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(55, 93)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(419, 101)
        Me.RichTextBox1.TabIndex = 53
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Precio"
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtnumero.Location = New System.Drawing.Point(348, 48)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(126, 24)
        Me.txtnumero.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Descripción"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVerTodos)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnCrear)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 85)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'GroupTemporada
        '
        Me.GroupTemporada.Controls.Add(Me.TextBox2)
        Me.GroupTemporada.Controls.Add(Me.Label6)
        Me.GroupTemporada.Controls.Add(Me.Label3)
        Me.GroupTemporada.Controls.Add(Me.TextBox1)
        Me.GroupTemporada.Controls.Add(Me.Label5)
        Me.GroupTemporada.Controls.Add(Me.RichTextBox2)
        Me.GroupTemporada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTemporada.Location = New System.Drawing.Point(24, 66)
        Me.GroupTemporada.Name = "GroupTemporada"
        Me.GroupTemporada.Size = New System.Drawing.Size(489, 222)
        Me.GroupTemporada.TabIndex = 65
        Me.GroupTemporada.TabStop = False
        Me.GroupTemporada.Text = "Temporada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Descripción"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TextBox1.Location = New System.Drawing.Point(332, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 24)
        Me.TextBox1.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 21)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Precio:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(39, 92)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(419, 101)
        Me.RichTextBox2.TabIndex = 53
        Me.RichTextBox2.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TextBox2.Location = New System.Drawing.Point(116, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 24)
        Me.TextBox2.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 21)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Nombre:"
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnVerTodos.Image = Global.Lavacar.My.Resources.Resources.if_icon_45_note_list_314884
        Me.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerTodos.Location = New System.Drawing.Point(362, 30)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(115, 40)
        Me.btnVerTodos.TabIndex = 8
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerTodos.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBorrar.Image = Global.Lavacar.My.Resources.Resources.if_1_2058800
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(245, 30)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(115, 40)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCrear.Image = Global.Lavacar.My.Resources.Resources.if_AddThis_Social_Network_communicate_page_curl_437908
        Me.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrear.Location = New System.Drawing.Point(9, 30)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(115, 40)
        Me.btnCrear.TabIndex = 2
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
        Me.btnModificar.Location = New System.Drawing.Point(127, 30)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 40)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Paquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(538, 392)
        Me.Controls.Add(Me.GroupTemporada)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupEstandar)
        Me.Controls.Add(Me.CbxTipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Paquetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paquetes"
        Me.GroupEstandar.ResumeLayout(False)
        Me.GroupEstandar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupTemporada.ResumeLayout(False)
        Me.GroupTemporada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxTipo As ComboBox
    Friend WithEvents GroupEstandar As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents rbpequeno As RadioButton
    Friend WithEvents rbgrande As RadioButton
    Friend WithEvents rbmediano As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnVerTodos As Button
    Friend WithEvents GroupTemporada As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
End Class
