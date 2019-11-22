<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos_Ingreso
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbm = New System.Windows.Forms.RadioButton()
        Me.rbn = New System.Windows.Forms.RadioButton()
        Me.SectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet = New Amor_Viviente.Amor_VivienteDataSet()
        Me.txtmiembros = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxbuscador = New System.Windows.Forms.ComboBox()
        Me.TxtBuscador = New System.Windows.Forms.TextBox()
        Me.SectoresTableAdapter = New Amor_Viviente.Amor_VivienteDataSetTableAdapters.SectoresTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sector = New System.Windows.Forms.TextBox()
        Me.zona = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.zona)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.sector)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbm)
        Me.GroupBox1.Controls.Add(Me.rbn)
        Me.GroupBox1.Controls.Add(Me.txtmiembros)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(647, 491)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(77, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Marque la opcion que desee realizar"
        '
        'rbm
        '
        Me.rbm.AutoSize = True
        Me.rbm.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.rbm.Location = New System.Drawing.Point(360, 96)
        Me.rbm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbm.Name = "rbm"
        Me.rbm.Size = New System.Drawing.Size(168, 24)
        Me.rbm.TabIndex = 2
        Me.rbm.TabStop = True
        Me.rbm.Text = "Modificar grupo"
        Me.rbm.UseVisualStyleBackColor = True
        '
        'rbn
        '
        Me.rbn.AutoSize = True
        Me.rbn.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.rbn.Location = New System.Drawing.Point(160, 96)
        Me.rbn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbn.Name = "rbn"
        Me.rbn.Size = New System.Drawing.Size(140, 24)
        Me.rbn.TabIndex = 1
        Me.rbn.TabStop = True
        Me.rbn.Text = "Nuevo grupo"
        Me.rbn.UseVisualStyleBackColor = True
        '
        'SectoresBindingSource
        '
        Me.SectoresBindingSource.DataMember = "Sectores"
        Me.SectoresBindingSource.DataSource = Me.Amor_VivienteDataSet
        '
        'Amor_VivienteDataSet
        '
        Me.Amor_VivienteDataSet.DataSetName = "Amor_VivienteDataSet"
        Me.Amor_VivienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtmiembros
        '
        Me.txtmiembros.Location = New System.Drawing.Point(348, 322)
        Me.txtmiembros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmiembros.MaxLength = 2
        Me.txtmiembros.Name = "txtmiembros"
        Me.txtmiembros.Size = New System.Drawing.Size(216, 26)
        Me.txtmiembros.TabIndex = 5
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(347, 156)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnombre.MaxLength = 30
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(216, 26)
        Me.txtnombre.TabIndex = 3
        '
        'btningresar
        '
        Me.btningresar.Enabled = False
        Me.btningresar.Location = New System.Drawing.Point(267, 401)
        Me.btningresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(133, 37)
        Me.btningresar.TabIndex = 6
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(78, 322)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Numero de miembros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(77, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sector"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(77, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del grupo"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(919, 119)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(592, 486)
        Me.DataGridView1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(992, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Seleccione el grupo a modificar"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(940, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Buscar por"
        '
        'cbxbuscador
        '
        Me.cbxbuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxbuscador.FormattingEnabled = True
        Me.cbxbuscador.Items.AddRange(New Object() {"Nombre", "Sector"})
        Me.cbxbuscador.Location = New System.Drawing.Point(1043, 86)
        Me.cbxbuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxbuscador.Name = "cbxbuscador"
        Me.cbxbuscador.Size = New System.Drawing.Size(161, 24)
        Me.cbxbuscador.TabIndex = 0
        '
        'TxtBuscador
        '
        Me.TxtBuscador.Location = New System.Drawing.Point(1243, 86)
        Me.TxtBuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscador.MaxLength = 5
        Me.TxtBuscador.Name = "TxtBuscador"
        Me.TxtBuscador.Size = New System.Drawing.Size(267, 22)
        Me.TxtBuscador.TabIndex = 0
        '
        'SectoresTableAdapter
        '
        Me.SectoresTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Amor_Viviente.My.Resources.Resources.Alerta_Roja
        Me.PictureBox2.Location = New System.Drawing.Point(919, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'sector
        '
        Me.sector.Location = New System.Drawing.Point(346, 212)
        Me.sector.Margin = New System.Windows.Forms.Padding(4)
        Me.sector.MaxLength = 2
        Me.sector.Name = "sector"
        Me.sector.Size = New System.Drawing.Size(216, 26)
        Me.sector.TabIndex = 7
        '
        'zona
        '
        Me.zona.Location = New System.Drawing.Point(346, 267)
        Me.zona.Margin = New System.Windows.Forms.Padding(4)
        Me.zona.MaxLength = 2
        Me.zona.Name = "zona"
        Me.zona.Size = New System.Drawing.Size(216, 26)
        Me.zona.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(77, 268)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Zona"
        '
        'Grupos_Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1552, 661)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TxtBuscador)
        Me.Controls.Add(Me.cbxbuscador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Grupos_Ingreso"
        Me.Text = "Grupos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SectoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbm As System.Windows.Forms.RadioButton
    Friend WithEvents rbn As System.Windows.Forms.RadioButton
    Friend WithEvents txtmiembros As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxbuscador As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents Amor_VivienteDataSet As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents SectoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectoresTableAdapter As Amor_Viviente.Amor_VivienteDataSetTableAdapters.SectoresTableAdapter
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents zona As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sector As System.Windows.Forms.TextBox
End Class
