<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_Mbr
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
        Me.Reportes_MembresiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amor_VivienteDataSet1 = New Amor_Viviente.Amor_VivienteDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dgvmiembros = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxbuscador = New System.Windows.Forms.ComboBox()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Reportes_MembresiaTableAdapter = New Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_MembresiaTableAdapter()
        CType(Me.Reportes_MembresiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmiembros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reportes_MembresiaBindingSource
        '
        Me.Reportes_MembresiaBindingSource.DataMember = "Reportes_Membresia"
        Me.Reportes_MembresiaBindingSource.DataSource = Me.Amor_VivienteDataSet1
        '
        'Amor_VivienteDataSet1
        '
        Me.Amor_VivienteDataSet1.DataSetName = "Amor_VivienteDataSet1"
        Me.Amor_VivienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Right
        ReportDataSource1.Name = "Membresia"
        ReportDataSource1.Value = Me.Reportes_MembresiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Amor_Viviente.Report_Membresia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(690, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(862, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'dgvmiembros
        '
        Me.dgvmiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmiembros.Location = New System.Drawing.Point(112, 94)
        Me.dgvmiembros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvmiembros.Name = "dgvmiembros"
        Me.dgvmiembros.Size = New System.Drawing.Size(569, 464)
        Me.dgvmiembros.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por"
        '
        'cbxbuscador
        '
        Me.cbxbuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxbuscador.FormattingEnabled = True
        Me.cbxbuscador.Items.AddRange(New Object() {"Nombre", "Grupo", "Sector"})
        Me.cbxbuscador.Location = New System.Drawing.Point(192, 60)
        Me.cbxbuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxbuscador.Name = "cbxbuscador"
        Me.cbxbuscador.Size = New System.Drawing.Size(160, 24)
        Me.cbxbuscador.TabIndex = 3
        '
        'txtbuscador
        '
        Me.txtbuscador.Location = New System.Drawing.Point(380, 60)
        Me.txtbuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(288, 22)
        Me.txtbuscador.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(469, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Seleccion en la tabla el miembro, luego haga click en generar membresia"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(329, 565)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Generar Membresia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Reportes_MembresiaTableAdapter
        '
        Me.Reportes_MembresiaTableAdapter.ClearBeforeFill = True
        '
        'Rpt_Mbr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1552, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.cbxbuscador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvmiembros)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Rpt_Mbr"
        Me.Text = "Rpt_Mbr"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Reportes_MembresiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amor_VivienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmiembros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dgvmiembros As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxbuscador As System.Windows.Forms.ComboBox
    Friend WithEvents txtbuscador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Reportes_MembresiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Amor_VivienteDataSet1 As Amor_Viviente.Amor_VivienteDataSet1
    Friend WithEvents Reportes_MembresiaTableAdapter As Amor_Viviente.Amor_VivienteDataSet1TableAdapters.Reportes_MembresiaTableAdapter
End Class
