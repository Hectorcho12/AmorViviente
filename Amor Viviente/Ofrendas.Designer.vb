<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ofrendas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.cbxgrupo = New System.Windows.Forms.ComboBox()
        Me.GruposdispBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmorVivienteVistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_Viviente_Vistas = New Amor_Viviente.Amor_Viviente_Vistas()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.cbxsemana = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Amor_VivienteDataSet = New Amor_Viviente.Amor_VivienteDataSet()
        Me.EgresosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EgresosTableAdapter = New Amor_Viviente.Amor_VivienteDataSetTableAdapters.EgresosTableAdapter()
        Me.Grupos_dispTableAdapter = New Amor_Viviente.Amor_Viviente_VistasTableAdapters.Grupos_dispTableAdapter()
        Me.dgvofrendas = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxbuscador = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GruposdispBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmorVivienteVistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_Viviente_Vistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EgresosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvofrendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(100, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(172, 111)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(174, 22)
        Me.dtpfecha.TabIndex = 1
        '
        'cbxgrupo
        '
        Me.cbxgrupo.DataSource = Me.GruposdispBindingSource
        Me.cbxgrupo.DisplayMember = "GrpNom"
        Me.cbxgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxgrupo.FormattingEnabled = True
        Me.cbxgrupo.Location = New System.Drawing.Point(172, 167)
        Me.cbxgrupo.Name = "cbxgrupo"
        Me.cbxgrupo.Size = New System.Drawing.Size(174, 23)
        Me.cbxgrupo.TabIndex = 2
        Me.cbxgrupo.ValueMember = "GrpCod"
        '
        'GruposdispBindingSource
        '
        Me.GruposdispBindingSource.DataMember = "Grupos_disp"
        Me.GruposdispBindingSource.DataSource = Me.AmorVivienteVistasBindingSource
        '
        'AmorVivienteVistasBindingSource
        '
        Me.AmorVivienteVistasBindingSource.DataSource = Me.Amor_Viviente_Vistas
        Me.AmorVivienteVistasBindingSource.Position = 0
        '
        'Amor_Viviente_Vistas
        '
        Me.Amor_Viviente_Vistas.DataSetName = "Amor_Viviente_Vistas"
        Me.Amor_Viviente_Vistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(100, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grupo"
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(172, 225)
        Me.txtmonto.MaxLength = 5
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(174, 22)
        Me.txtmonto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(100, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ofrenda"
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(198, 374)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(98, 29)
        Me.btguardar.TabIndex = 6
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'cbxsemana
        '
        Me.cbxsemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsemana.FormattingEnabled = True
        Me.cbxsemana.Items.AddRange(New Object() {"Semana 1", "Semana 2", "Semana 3", "Semana 4", "Semana 5"})
        Me.cbxsemana.Location = New System.Drawing.Point(172, 276)
        Me.cbxsemana.Name = "cbxsemana"
        Me.cbxsemana.Size = New System.Drawing.Size(174, 23)
        Me.cbxsemana.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(101, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Semana"
        '
        'Amor_VivienteDataSet
        '
        Me.Amor_VivienteDataSet.DataSetName = "Amor_VivienteDataSet"
        Me.Amor_VivienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EgresosBindingSource
        '
        Me.EgresosBindingSource.DataMember = "Egresos"
        Me.EgresosBindingSource.DataSource = Me.Amor_VivienteDataSet
        '
        'EgresosTableAdapter
        '
        Me.EgresosTableAdapter.ClearBeforeFill = True
        '
        'Grupos_dispTableAdapter
        '
        Me.Grupos_dispTableAdapter.ClearBeforeFill = True
        '
        'dgvofrendas
        '
        Me.dgvofrendas.AllowUserToAddRows = False
        Me.dgvofrendas.AllowUserToDeleteRows = False
        Me.dgvofrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvofrendas.Location = New System.Drawing.Point(592, 113)
        Me.dgvofrendas.Name = "dgvofrendas"
        Me.dgvofrendas.ReadOnly = True
        Me.dgvofrendas.Size = New System.Drawing.Size(560, 343)
        Me.dgvofrendas.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(1097, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.cbxgrupo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxsemana)
        Me.GroupBox1.Controls.Add(Me.txtmonto)
        Me.GroupBox1.Controls.Add(Me.btguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 439)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Registro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(425, 45)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ingrese los datos para registrar las ofrendas de grupos de crecimiento." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si desea" & _
    " modificar algun registro simplemente introduzca los datos con " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el mes y el Año" & _
    " al cual se le hara el cambio"
        '
        'cbxbuscador
        '
        Me.cbxbuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxbuscador.FormattingEnabled = True
        Me.cbxbuscador.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbxbuscador.Location = New System.Drawing.Point(622, 80)
        Me.cbxbuscador.Name = "cbxbuscador"
        Me.cbxbuscador.Size = New System.Drawing.Size(142, 21)
        Me.cbxbuscador.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(589, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(814, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Año"
        '
        'txtbuscador
        '
        Me.txtbuscador.Location = New System.Drawing.Point(846, 80)
        Me.txtbuscador.MaxLength = 4
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(50, 20)
        Me.txtbuscador.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(963, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ofrendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1164, 537)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxbuscador)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgvofrendas)
        Me.Name = "Ofrendas"
        Me.Text = "Ofrendas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GruposdispBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmorVivienteVistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_Viviente_Vistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EgresosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvofrendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxgrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btguardar As System.Windows.Forms.Button
    Friend WithEvents cbxsemana As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Amor_VivienteDataSet As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents EgresosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EgresosTableAdapter As Amor_Viviente.Amor_VivienteDataSetTableAdapters.EgresosTableAdapter
    Friend WithEvents AmorVivienteVistasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_Viviente_Vistas As Amor_Viviente.Amor_Viviente_Vistas
    Friend WithEvents GruposdispBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grupos_dispTableAdapter As Amor_Viviente.Amor_Viviente_VistasTableAdapters.Grupos_dispTableAdapter
    Friend WithEvents dgvofrendas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxbuscador As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbuscador As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
