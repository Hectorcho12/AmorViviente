<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membresia_Mod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membresia_Mod))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grupbox = New System.Windows.Forms.GroupBox()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GrpMostrarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.rbf = New System.Windows.Forms.RadioButton()
        Me.rbm = New System.Windows.Forms.RadioButton()
        Me.txtsape = New System.Windows.Forms.TextBox()
        Me.txtpape = New System.Windows.Forms.TextBox()
        Me.txtsnom = New System.Windows.Forms.TextBox()
        Me.txtpnom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.Amor_VivienteDataSet = New Amor_Viviente.Amor_VivienteDataSet()
        Me.Grp_MostrarTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Grp_MostrarTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupbox.SuspendLayout()
        CType(Me.GrpMostrarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(229, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(795, 233)
        Me.DataGridView1.TabIndex = 0
        '
        'grupbox
        '
        Me.grupbox.Controls.Add(Me.btnIn)
        Me.grupbox.Controls.Add(Me.DateTimePicker1)
        Me.grupbox.Controls.Add(Me.ComboBox1)
        Me.grupbox.Controls.Add(Me.rbf)
        Me.grupbox.Controls.Add(Me.rbm)
        Me.grupbox.Controls.Add(Me.txtsape)
        Me.grupbox.Controls.Add(Me.txtpape)
        Me.grupbox.Controls.Add(Me.txtsnom)
        Me.grupbox.Controls.Add(Me.txtpnom)
        Me.grupbox.Controls.Add(Me.Label9)
        Me.grupbox.Controls.Add(Me.Label8)
        Me.grupbox.Controls.Add(Me.Label7)
        Me.grupbox.Controls.Add(Me.Label6)
        Me.grupbox.Controls.Add(Me.Label5)
        Me.grupbox.Controls.Add(Me.Label4)
        Me.grupbox.Controls.Add(Me.Label3)
        Me.grupbox.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.grupbox.Location = New System.Drawing.Point(229, 329)
        Me.grupbox.Name = "grupbox"
        Me.grupbox.Size = New System.Drawing.Size(795, 168)
        Me.grupbox.TabIndex = 0
        Me.grupbox.TabStop = False
        Me.grupbox.Text = "Datos"
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(560, 125)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(133, 23)
        Me.btnIn.TabIndex = 9
        Me.btnIn.Text = "Ingresar"
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(652, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GrpMostrarBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(456, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 23)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "Codigo"
        '
        'GrpMostrarBindingSource
        '
        Me.GrpMostrarBindingSource.DataMember = "Grp_Mostrar"
        Me.GrpMostrarBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbf
        '
        Me.rbf.AutoSize = True
        Me.rbf.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.rbf.Location = New System.Drawing.Point(330, 111)
        Me.rbf.Name = "rbf"
        Me.rbf.Size = New System.Drawing.Size(87, 19)
        Me.rbf.TabIndex = 6
        Me.rbf.TabStop = True
        Me.rbf.Text = "Femenino"
        Me.rbf.UseVisualStyleBackColor = True
        '
        'rbm
        '
        Me.rbm.AutoSize = True
        Me.rbm.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.rbm.Location = New System.Drawing.Point(330, 63)
        Me.rbm.Name = "rbm"
        Me.rbm.Size = New System.Drawing.Size(87, 19)
        Me.rbm.TabIndex = 5
        Me.rbm.TabStop = True
        Me.rbm.Text = "Masculino"
        Me.rbm.UseVisualStyleBackColor = True
        '
        'txtsape
        '
        Me.txtsape.Location = New System.Drawing.Point(149, 130)
        Me.txtsape.MaxLength = 20
        Me.txtsape.Name = "txtsape"
        Me.txtsape.Size = New System.Drawing.Size(148, 22)
        Me.txtsape.TabIndex = 4
        '
        'txtpape
        '
        Me.txtpape.Location = New System.Drawing.Point(149, 95)
        Me.txtpape.MaxLength = 20
        Me.txtpape.Name = "txtpape"
        Me.txtpape.Size = New System.Drawing.Size(148, 22)
        Me.txtpape.TabIndex = 3
        '
        'txtsnom
        '
        Me.txtsnom.Location = New System.Drawing.Point(149, 60)
        Me.txtsnom.MaxLength = 20
        Me.txtsnom.Name = "txtsnom"
        Me.txtsnom.Size = New System.Drawing.Size(148, 22)
        Me.txtsnom.TabIndex = 2
        '
        'txtpnom
        '
        Me.txtpnom.Location = New System.Drawing.Point(149, 27)
        Me.txtpnom.MaxLength = 20
        Me.txtpnom.Name = "txtpnom"
        Me.txtpnom.Size = New System.Drawing.Size(148, 22)
        Me.txtpnom.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(649, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(453, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Grupo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(327, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Genero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(18, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Segundo Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(18, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Primer Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(18, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Segundo nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Primer Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecione el miembro a modificar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(717, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar"
        '
        'txtbuscador
        '
        Me.txtbuscador.Location = New System.Drawing.Point(800, 48)
        Me.txtbuscador.MaxLength = 84
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(148, 20)
        Me.txtbuscador.TabIndex = 0
        '
        'Amor_VivienteDataSet
        '
        Me.Amor_VivienteDataSet.DataSetName = "Amor_VivienteDataSet"
        Me.Amor_VivienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Grp_MostrarTableAdapter
        '
        Me.Grp_MostrarTableAdapter.ClearBeforeFill = True
        '
        'Membresia_Mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1164, 537)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grupbox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Membresia_Mod"
        Me.Text = "Membresia_Mod"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupbox.ResumeLayout(False)
        Me.grupbox.PerformLayout()
        CType(Me.GrpMostrarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grupbox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbuscador As System.Windows.Forms.TextBox
    Friend WithEvents btnIn As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents rbf As System.Windows.Forms.RadioButton
    Friend WithEvents rbm As System.Windows.Forms.RadioButton
    Friend WithEvents txtsape As System.Windows.Forms.TextBox
    Friend WithEvents txtpape As System.Windows.Forms.TextBox
    Friend WithEvents txtsnom As System.Windows.Forms.TextBox
    Friend WithEvents txtpnom As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Amor_VivienteDataSet As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents GrpMostrarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grp_MostrarTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Grp_MostrarTableAdapter
End Class
