<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_Dez
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
        Me.Reportes_DiezmosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Reportes_DiezmosTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_DiezmosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ZonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet = New Amor_Viviente.Amor_VivienteDataSet()
        Me.SecMostrarCBXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.desde = New System.Windows.Forms.DateTimePicker()
        Me.hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ZonasTableAdapter = New Amor_Viviente.Amor_VivienteDataSetTableAdapters.ZonasTableAdapter()
        Me.Sec_Mostrar_CBXTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Sec_Mostrar_CBXTableAdapter()
        Me.cbxzona = New System.Windows.Forms.TextBox()
        Me.cbxsector = New System.Windows.Forms.TextBox()
        CType(Me.Reportes_DiezmosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecMostrarCBXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reportes_DiezmosBindingSource
        '
        Me.Reportes_DiezmosBindingSource.DataMember = "Reportes_Diezmos"
        Me.Reportes_DiezmosBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Rpt_dez"
        ReportDataSource1.Value = Me.Reportes_DiezmosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Amor_Viviente.Report_Diezmos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(798, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1100, 660)
        Me.ReportViewer1.TabIndex = 0
        '
        'Reportes_DiezmosTableAdapter
        '
        Me.Reportes_DiezmosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(60, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Zona"
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
        'SecMostrarCBXBindingSource
        '
        Me.SecMostrarCBXBindingSource.DataMember = "Sec_Mostrar_CBX"
        Me.SecMostrarCBXBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(60, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(272, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta"
        '
        'desde
        '
        Me.desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.desde.Location = New System.Drawing.Point(355, 101)
        Me.desde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(133, 26)
        Me.desde.TabIndex = 6
        Me.desde.Value = New Date(2018, 7, 1, 12, 49, 0, 0)
        '
        'hasta
        '
        Me.hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.hasta.Location = New System.Drawing.Point(355, 169)
        Me.hasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(133, 26)
        Me.hasta.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(263, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Desde"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 282)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 49)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxsector)
        Me.GroupBox1.Controls.Add(Me.cbxzona)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.hasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.desde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 130)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 394)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Reporte"
        '
        'ZonasTableAdapter
        '
        Me.ZonasTableAdapter.ClearBeforeFill = True
        '
        'Sec_Mostrar_CBXTableAdapter
        '
        Me.Sec_Mostrar_CBXTableAdapter.ClearBeforeFill = True
        '
        'cbxzona
        '
        Me.cbxzona.Location = New System.Drawing.Point(147, 106)
        Me.cbxzona.Name = "cbxzona"
        Me.cbxzona.Size = New System.Drawing.Size(52, 26)
        Me.cbxzona.TabIndex = 10
        '
        'cbxsector
        '
        Me.cbxsector.Location = New System.Drawing.Point(147, 168)
        Me.cbxsector.Name = "cbxsector"
        Me.cbxsector.Size = New System.Drawing.Size(52, 26)
        Me.cbxsector.TabIndex = 11
        '
        'Rpt_Dez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1899, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Rpt_Dez"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Reportes_DiezmosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecMostrarCBXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reportes_DiezmosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents Reportes_DiezmosTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_DiezmosTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Amor_VivienteDataSet As Amor_Viviente.Amor_VivienteDataSet
    Friend WithEvents ZonasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZonasTableAdapter As Amor_Viviente.Amor_VivienteDataSetTableAdapters.ZonasTableAdapter
    Friend WithEvents SecMostrarCBXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sec_Mostrar_CBXTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Sec_Mostrar_CBXTableAdapter
    Friend WithEvents cbxsector As System.Windows.Forms.TextBox
    Friend WithEvents cbxzona As System.Windows.Forms.TextBox
End Class
