<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rbi
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbm = New System.Windows.Forms.RadioButton()
        Me.rbin = New System.Windows.Forms.RadioButton()
        Me.cbxtipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgveg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgveg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbm)
        Me.GroupBox1.Controls.Add(Me.rbin)
        Me.GroupBox1.Controls.Add(Me.cbxtipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtmonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 314)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'rbm
        '
        Me.rbm.AutoSize = True
        Me.rbm.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.rbm.Location = New System.Drawing.Point(292, 41)
        Me.rbm.Name = "rbm"
        Me.rbm.Size = New System.Drawing.Size(105, 19)
        Me.rbm.TabIndex = 9
        Me.rbm.TabStop = True
        Me.rbm.Text = "Modificacion"
        Me.rbm.UseVisualStyleBackColor = True
        '
        'rbin
        '
        Me.rbin.AutoSize = True
        Me.rbin.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.rbin.Location = New System.Drawing.Point(145, 41)
        Me.rbin.Name = "rbin"
        Me.rbin.Size = New System.Drawing.Size(72, 19)
        Me.rbin.TabIndex = 8
        Me.rbin.TabStop = True
        Me.rbin.Text = "Ingreso"
        Me.rbin.UseVisualStyleBackColor = True
        '
        'cbxtipo
        '
        Me.cbxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtipo.FormattingEnabled = True
        Me.cbxtipo.Items.AddRange(New Object() {"Entrada", "Salida", "Capital"})
        Me.cbxtipo.Location = New System.Drawing.Point(256, 260)
        Me.cbxtipo.Name = "cbxtipo"
        Me.cbxtipo.Size = New System.Drawing.Size(158, 23)
        Me.cbxtipo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(136, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "tipo"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(256, 217)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(158, 22)
        Me.dtpfecha.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(136, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(256, 171)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(158, 22)
        Me.txtmonto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(136, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(256, 89)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(158, 63)
        Me.txtdesc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(136, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(262, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgveg
        '
        Me.dgveg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgveg.Enabled = False
        Me.dgveg.Location = New System.Drawing.Point(589, 87)
        Me.dgveg.Name = "dgveg"
        Me.dgveg.Size = New System.Drawing.Size(563, 314)
        Me.dgveg.TabIndex = 2
        '
        'rbi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1164, 537)
        Me.Controls.Add(Me.dgveg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "rbi"
        Me.Text = "Egresos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgveg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgveg As System.Windows.Forms.DataGridView
    Friend WithEvents cbxtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbm As System.Windows.Forms.RadioButton
    Friend WithEvents rbin As System.Windows.Forms.RadioButton
End Class
