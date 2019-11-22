<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_Egr
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Reportes_Egresos_entradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.Reportes_Egresos_salidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reportes_Egresos_capitalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtphasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Reportes_Egresos_entradasTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Egresos_entradasTableAdapter()
        Me.Reportes_Egresos_salidasTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Egresos_salidasTableAdapter()
        Me.Reportes_Egresos_capitalTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Egresos_capitalTableAdapter()
        CType(Me.Reportes_Egresos_entradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reportes_Egresos_salidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reportes_Egresos_capitalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reportes_Egresos_entradasBindingSource
        '
        Me.Reportes_Egresos_entradasBindingSource.DataMember = "Reportes_Egresos_entradas"
        Me.Reportes_Egresos_entradasBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reportes_Egresos_salidasBindingSource
        '
        Me.Reportes_Egresos_salidasBindingSource.DataMember = "Reportes_Egresos_salidas"
        Me.Reportes_Egresos_salidasBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Reportes_Egresos_capitalBindingSource
        '
        Me.Reportes_Egresos_capitalBindingSource.DataMember = "Reportes_Egresos_capital"
        Me.Reportes_Egresos_capitalBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtphasta)
        Me.GroupBox1.Controls.Add(Me.dtpdesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 287)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Reporte"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtphasta
        '
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(180, 116)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(108, 22)
        Me.dtphasta.TabIndex = 2
        '
        'dtpdesde
        '
        Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdesde.Location = New System.Drawing.Point(180, 66)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(108, 22)
        Me.dtpdesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(73, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(73, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Right
        ReportDataSource1.Name = "entradas"
        ReportDataSource1.Value = Me.Reportes_Egresos_entradasBindingSource
        ReportDataSource2.Name = "salidas"
        ReportDataSource2.Value = Me.Reportes_Egresos_salidasBindingSource
        ReportDataSource3.Name = "capital"
        ReportDataSource3.Value = Me.Reportes_Egresos_capitalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Amor_Viviente.Report_Egresos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(559, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(605, 537)
        Me.ReportViewer1.TabIndex = 4
        '
        'Reportes_Egresos_entradasTableAdapter
        '
        Me.Reportes_Egresos_entradasTableAdapter.ClearBeforeFill = True
        '
        'Reportes_Egresos_salidasTableAdapter
        '
        Me.Reportes_Egresos_salidasTableAdapter.ClearBeforeFill = True
        '
        'Reportes_Egresos_capitalTableAdapter
        '
        Me.Reportes_Egresos_capitalTableAdapter.ClearBeforeFill = True
        '
        'Rpt_Egr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1164, 537)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Rpt_Egr"
        Me.Text = "Rpt_Egr"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Reportes_Egresos_entradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reportes_Egresos_salidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reportes_Egresos_capitalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reportes_Egresos_entradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents Reportes_Egresos_salidasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reportes_Egresos_capitalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reportes_Egresos_entradasTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Egresos_entradasTableAdapter
    Friend WithEvents Reportes_Egresos_salidasTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Egresos_salidasTableAdapter
    Friend WithEvents Reportes_Egresos_capitalTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Egresos_capitalTableAdapter
End Class
