﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_Dez_miem_Sx
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hasta = New System.Windows.Forms.DateTimePicker()
        Me.desde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.cbxbuscador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvmiembros = New System.Windows.Forms.DataGridView()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.Reportes_Diezmos_MSXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reportes_Diezmos_MSXTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Diezmos_MSXTableAdapter()
        CType(Me.dgvmiembros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reportes_Diezmos_MSXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(637, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Desde"
        '
        'hasta
        '
        Me.hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.hasta.Location = New System.Drawing.Point(612, 363)
        Me.hasta.Margin = New System.Windows.Forms.Padding(4)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(133, 22)
        Me.hasta.TabIndex = 41
        Me.hasta.Value = New Date(2019, 11, 20, 22, 8, 17, 0)
        '
        'desde
        '
        Me.desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.desde.Location = New System.Drawing.Point(612, 265)
        Me.desde.Margin = New System.Windows.Forms.Padding(4)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(133, 22)
        Me.desde.TabIndex = 39
        Me.desde.Value = New Date(2019, 11, 20, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(640, 339)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Hasta"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(381, 592)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 42)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(642, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Seleccion en la tabla el miembro y ingrese las fechas deseadas, luego haga click " & _
    "en generar reporte"
        '
        'txtbuscador
        '
        Me.txtbuscador.Location = New System.Drawing.Point(343, 80)
        Me.txtbuscador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(214, 22)
        Me.txtbuscador.TabIndex = 35
        '
        'cbxbuscador
        '
        Me.cbxbuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxbuscador.FormattingEnabled = True
        Me.cbxbuscador.Items.AddRange(New Object() {"Nombre", "Grupo", "Sector"})
        Me.cbxbuscador.Location = New System.Drawing.Point(155, 80)
        Me.cbxbuscador.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxbuscador.Name = "cbxbuscador"
        Me.cbxbuscador.Size = New System.Drawing.Size(160, 24)
        Me.cbxbuscador.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Buscar por"
        '
        'dgvmiembros
        '
        Me.dgvmiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmiembros.Location = New System.Drawing.Point(75, 114)
        Me.dgvmiembros.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvmiembros.Name = "dgvmiembros"
        Me.dgvmiembros.Size = New System.Drawing.Size(482, 464)
        Me.dgvmiembros.TabIndex = 32
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Right
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Reportes_Diezmos_MSXBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Amor_Viviente.Report_Diezmo_miembro_Sx.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(869, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1030, 675)
        Me.ReportViewer1.TabIndex = 42
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reportes_Diezmos_MSXBindingSource
        '
        Me.Reportes_Diezmos_MSXBindingSource.DataMember = "Reportes_Diezmos_MSX"
        Me.Reportes_Diezmos_MSXBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Reportes_Diezmos_MSXTableAdapter
        '
        Me.Reportes_Diezmos_MSXTableAdapter.ClearBeforeFill = True
        '
        'Rpt_Dez_miem_Sx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1899, 675)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.cbxbuscador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvmiembros)
        Me.Name = "Rpt_Dez_miem_Sx"
        Me.Text = "Rpt_Dez_miem_Sx"
        CType(Me.dgvmiembros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reportes_Diezmos_MSXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbuscador As System.Windows.Forms.TextBox
    Friend WithEvents cbxbuscador As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvmiembros As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reportes_Diezmos_MSXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents Reportes_Diezmos_MSXTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_Diezmos_MSXTableAdapter
End Class
