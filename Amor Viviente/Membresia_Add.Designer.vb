<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membresia_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membresia_Add))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GruposBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet = New Amor_Viviente.Amor_VivienteDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rbf = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RbM = New System.Windows.Forms.RadioButton()
        Me.TxtSape = New System.Windows.Forms.TextBox()
        Me.TxtPape = New System.Windows.Forms.TextBox()
        Me.TxtSnom = New System.Windows.Forms.TextBox()
        Me.txtPnom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet()
        Me.GruposTableAdapter = New Amor_Viviente.Amor_VivienteDataSetTableAdapters.gruposTableAdapter()
        Me.Amor_VivienteDataSet11 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.GrpMostrarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Grp_MostrarTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Grp_MostrarTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GruposBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpMostrarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Rbf)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RbM)
        Me.GroupBox1.Controls.Add(Me.TxtSape)
        Me.GroupBox1.Controls.Add(Me.TxtPape)
        Me.GroupBox1.Controls.Add(Me.TxtSnom)
        Me.GroupBox1.Controls.Add(Me.txtPnom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(366, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de miembros"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GrpMostrarBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(275, 173)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 23)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "Codigo"
        '
        'GruposBindingSource1
        '
        Me.GruposBindingSource1.DataMember = "grupos"
        Me.GruposBindingSource1.DataSource = Me.Amor_VivienteDataSet
        '
        'Amor_VivienteDataSet
        '
        Me.Amor_VivienteDataSet.DataSetName = "Amor_VivienteDataSet"
        Me.Amor_VivienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(90, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Grupo de crecimiento"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(332, 314)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(90, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Rbf
        '
        Me.Rbf.AutoSize = True
        Me.Rbf.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Rbf.Location = New System.Drawing.Point(306, 261)
        Me.Rbf.Name = "Rbf"
        Me.Rbf.Size = New System.Drawing.Size(87, 19)
        Me.Rbf.TabIndex = 7
        Me.Rbf.TabStop = True
        Me.Rbf.Text = "Femenino"
        Me.Rbf.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(90, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Genero"
        '
        'RbM
        '
        Me.RbM.AutoSize = True
        Me.RbM.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.RbM.Location = New System.Drawing.Point(166, 261)
        Me.RbM.Name = "RbM"
        Me.RbM.Size = New System.Drawing.Size(87, 19)
        Me.RbM.TabIndex = 6
        Me.RbM.TabStop = True
        Me.RbM.Text = "Masculino"
        Me.RbM.UseVisualStyleBackColor = True
        '
        'TxtSape
        '
        Me.TxtSape.Location = New System.Drawing.Point(275, 139)
        Me.TxtSape.MaxLength = 20
        Me.TxtSape.Name = "TxtSape"
        Me.TxtSape.Size = New System.Drawing.Size(204, 22)
        Me.TxtSape.TabIndex = 4
        '
        'TxtPape
        '
        Me.TxtPape.Location = New System.Drawing.Point(275, 105)
        Me.TxtPape.MaxLength = 20
        Me.TxtPape.Name = "TxtPape"
        Me.TxtPape.Size = New System.Drawing.Size(204, 22)
        Me.TxtPape.TabIndex = 3
        '
        'TxtSnom
        '
        Me.TxtSnom.Location = New System.Drawing.Point(275, 73)
        Me.TxtSnom.MaxLength = 20
        Me.TxtSnom.Name = "TxtSnom"
        Me.TxtSnom.Size = New System.Drawing.Size(204, 22)
        Me.TxtSnom.TabIndex = 2
        '
        'txtPnom
        '
        Me.txtPnom.Location = New System.Drawing.Point(275, 40)
        Me.txtPnom.MaxLength = 20
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.Size = New System.Drawing.Size(204, 22)
        Me.txtPnom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(90, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Segundo Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(90, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(90, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Segundo Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer Nombre"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "grupos"
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'Amor_VivienteDataSet11
        '
        Me.Amor_VivienteDataSet11.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrpMostrarBindingSource
        '
        Me.GrpMostrarBindingSource.DataMember = "Grp_Mostrar"
        Me.GrpMostrarBindingSource.DataSource = Me.Amor_VivienteDataSet11
        '
        'Grp_MostrarTableAdapter
        '
        Me.Grp_MostrarTableAdapter.ClearBeforeFill = True
        '
        'Membresia_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1164, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Membresia_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membresia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GruposBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpMostrarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Rbf As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RbM As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSape As System.Windows.Forms.TextBox
    Friend WithEvents TxtPape As System.Windows.Forms.TextBox
    Friend WithEvents TxtSnom As System.Windows.Forms.TextBox
    Friend WithEvents txtPnom As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Amor_VivienteDataSet As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GruposBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As Amor_Viviente.Amor_VivienteDataSetTableAdapters.gruposTableAdapter
    Friend WithEvents Amor_VivienteDataSet11 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents GrpMostrarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grp_MostrarTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Grp_MostrarTableAdapter
End Class
