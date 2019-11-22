<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_usuario
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
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgveliminar = New System.Windows.Forms.DataGridView()
        CType(Me.dgveliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnborrar
        '
        Me.btnborrar.Enabled = False
        Me.btnborrar.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.btnborrar.Location = New System.Drawing.Point(527, 400)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(109, 40)
        Me.btnborrar.TabIndex = 10
        Me.btnborrar.Text = "Eliminar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(518, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(377, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar por nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(363, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Escoja el usuario a borrar"
        '
        'dgveliminar
        '
        Me.dgveliminar.AllowUserToAddRows = False
        Me.dgveliminar.AllowUserToDeleteRows = False
        Me.dgveliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgveliminar.Location = New System.Drawing.Point(366, 192)
        Me.dgveliminar.Name = "dgveliminar"
        Me.dgveliminar.ReadOnly = True
        Me.dgveliminar.Size = New System.Drawing.Size(430, 187)
        Me.dgveliminar.TabIndex = 9
        '
        'Eliminar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1164, 537)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgveliminar)
        Me.Name = "Eliminar_usuario"
        Me.Text = "Eliminar_usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgveliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgveliminar As System.Windows.Forms.DataGridView
End Class
