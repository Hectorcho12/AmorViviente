<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_Ofr
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Reportes_OfrendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Reportes_OfrendaTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_OfrendaTableAdapter()
        Me.ZonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet = New Amor_Viviente.Amor_VivienteDataSet()
        Me.SecMostrarCBXBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxzona = New System.Windows.Forms.TextBox()
        Me.cbxsector = New System.Windows.Forms.TextBox()
        Me.cbxmes = New System.Windows.Forms.ComboBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ZonasTableAdapter = New Amor_Viviente.Amor_VivienteDataSetTableAdapters.ZonasTableAdapter()
        Me.SecMostrarCBXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sec_Mostrar_CBXTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Sec_Mostrar_CBXTableAdapter()
        CType(Me.Reportes_OfrendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecMostrarCBXBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SecMostrarCBXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reportes_OfrendaBindingSource
        '
        Me.Reportes_OfrendaBindingSource.DataMember = "Reportes_Ofrenda"
        Me.Reportes_OfrendaBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Reportes_OfrendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Amor_Viviente.Report_Ofrenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 260)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1600, 581)
        Me.ReportViewer1.TabIndex = 0
        '
        'Reportes_OfrendaTableAdapter
        '
        Me.Reportes_OfrendaTableAdapter.ClearBeforeFill = True
        '
        'ZonasBindingSource
        '
        Me.ZonasBindingSource.DataMember = "Zonas"
        Me.ZonasBindingSource.DataSource = Me.Amor_VivienteDataSet
        '
        'Amor_VivienteDataSet
        '
        Me.Amor_VivienteDataSet.DataSetName = "Amor_VivienteDataSet"
        Me.Amor_VivienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SecMostrarCBXBindingSource1
        '
        Me.SecMostrarCBXBindingSource1.DataMember = "Sec_Mostrar_CBX"
        Me.SecMostrarCBXBindingSource1.DataSource = Me.Amor_VivienteDataSet1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(795, 60)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 52)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generar reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxzona)
        Me.GroupBox1.Controls.Add(Me.cbxsector)
        Me.GroupBox1.Controls.Add(Me.cbxmes)
        Me.GroupBox1.Controls.Add(Me.txtaño)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1075, 166)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar reporte"
        '
        'cbxzona
        '
        Me.cbxzona.Location = New System.Drawing.Point(440, 41)
        Me.cbxzona.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxzona.MaxLength = 4
        Me.cbxzona.Name = "cbxzona"
        Me.cbxzona.Size = New System.Drawing.Size(125, 26)
        Me.cbxzona.TabIndex = 12
        '
        'cbxsector
        '
        Me.cbxsector.Location = New System.Drawing.Point(440, 105)
        Me.cbxsector.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxsector.MaxLength = 4
        Me.cbxsector.Name = "cbxsector"
        Me.cbxsector.Size = New System.Drawing.Size(125, 26)
        Me.cbxsector.TabIndex = 11
        '
        'cbxmes
        '
        Me.cbxmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxmes.FormattingEnabled = True
        Me.cbxmes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbxmes.Location = New System.Drawing.Point(127, 42)
        Me.cbxmes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxmes.Name = "cbxmes"
        Me.cbxmes.Size = New System.Drawing.Size(125, 25)
        Me.cbxmes.TabIndex = 10
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(127, 106)
        Me.txtaño.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaño.MaxLength = 4
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(125, 26)
        Me.txtaño.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(55, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(338, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Zona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(338, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sector"
        '
        'ZonasTableAdapter
        '
        Me.ZonasTableAdapter.ClearBeforeFill = True
        '
        'SecMostrarCBXBindingSource
        '
        Me.SecMostrarCBXBindingSource.DataMember = "Sec_Mostrar_CBX"
        Me.SecMostrarCBXBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Sec_Mostrar_CBXTableAdapter
        '
        Me.Sec_Mostrar_CBXTableAdapter.ClearBeforeFill = True
        '
        'Rpt_Ofr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1600, 841)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Rpt_Ofr"
        Me.Text = "Rpt_Ofr"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Reportes_OfrendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecMostrarCBXBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SecMostrarCBXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reportes_OfrendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents Reportes_OfrendaTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_OfrendaTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxmes As System.Windows.Forms.ComboBox
    Friend WithEvents Amor_VivienteDataSet As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents ZonasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZonasTableAdapter As Amor_Viviente.Amor_VivienteDataSetTableAdapters.ZonasTableAdapter
    Friend WithEvents SecMostrarCBXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sec_Mostrar_CBXTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Sec_Mostrar_CBXTableAdapter
    Friend WithEvents SecMostrarCBXBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cbxzona As System.Windows.Forms.TextBox
    Friend WithEvents cbxsector As System.Windows.Forms.TextBox
End Class
