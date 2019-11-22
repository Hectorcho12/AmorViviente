Public Class Diezmos
    Public conexion As New Conexiones

    Dim fecha As Date
    Dim miembro = 0
    Dim validar As String
    Private Sub Diezmos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
        Dim query = "Exec Mbr_Mostrar"
        conexion.llenardgv(DataGridView1, query)
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        DataGridView1.Columns(2).Visible = False

        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(4).Width = 200


        


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtmonto.Text <> "" And miembro <> 0 Then
            conexion.insertar("Exec Dez_Ingreso @miembro =" & miembro & ",@monto = '" & txtmonto.Text & "',@mes = '" & dtpfecha.Text & "', @Usuario = " & User)
            conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha ingresado un diezmo nuevo a la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")

            MsgBox("El diezmo se ha ingresado con exito", MsgBoxStyle.DefaultButton1)
        Else
            MsgBox("No ha ingresado la cantidad o no ha seleccionado un miembro", MsgBoxStyle.DefaultButton1)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged
        If cbxbuscador.Text = "Nombre" Then
            conexion.llenardgv(DataGridView1, "Exec Mbr_Buscador @Nombre ='" & txtbuscador.Text & "'")
        End If

        If cbxbuscador.Text = "Grupo" Then
            conexion.llenardgv(DataGridView1, "Exec [Mbr_Buscador-grupo] @grupo ='" & txtbuscador.Text & "'")
        End If

        If cbxbuscador.Text = "Sector" Then
            conexion.llenardgv(DataGridView1, "Exec [Mbr_Buscador-Sector] @Sector = '" & txtbuscador.Text & "'")
        End If

    End Sub

    

    Private Sub dtpbuscador_ValueChanged(sender As Object, e As EventArgs) Handles dtpbuscador.ValueChanged
        Dim query2 = "Exec Dez_Registros @fecha = '" & Format(dtpbuscador.Value.Date.ToString, "short date") & "'"
        conexion.llenardgv(DataGridView2, query2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim codigo = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString
        Dim nombre = DataGridView2.CurrentRow.Cells.Item(3).Value.ToString

        If txtmodificacion.Text <> "" And validar <> "" Then
            conexion.insertar("Exec Dez_Modificacion @cod = " & codigo & ",@miembro = '" & miembro & "',@monto = " & txtmodificacion.Text & ",@mes = '" & Format(dtpbuscador.Value.Date.ToString, "short date") & "',@usuario ='" & User & "'")
            conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha modificado un diezmo de la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
            Dim query2 = "Exec Dez_Registros @fecha = '" & Format(dtpbuscador.Value.Date.ToString, "short date") & "'"
            conexion.llenardgv(DataGridView2, query2)
            MsgBox("La modificacion del diezmo se realizo con exito", MsgBoxStyle.DefaultButton1)

        Else
            MsgBox("No ingreso la cantidad o selecciono el registro")
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        miembro = DataGridView2.CurrentRow.Cells.Item(4).Value.ToString
        fecha = DataGridView2.CurrentRow.Cells.Item(2).Value.ToString
        validar = DataGridView2.CurrentRow.Cells.Item(3).Value.ToString
    End Sub

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        ClsNumeros(e)
    End Sub

    Private Sub txtbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscador.KeyPress
        If cbxbuscador.Text = "Nombre" Then
            ClsLetras(e)
        ElseIf cbxbuscador.Text = "Sector" Then
            ClsNumeros(e)

        ElseIf cbxbuscador.Text = "Grupo" Then
            ClsLetrasyNumeros(e)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        miembro = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
    End Sub

    Private Sub txtmodificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmodificacion.KeyPress
        ClsNumeros(e)
    End Sub

    Private Sub cbxbuscador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbuscador.SelectedIndexChanged
        If cbxbuscador.Text = "Nombre" Then
            txtbuscador.Clear()
            txtbuscador.MaxLength = 84
        ElseIf cbxbuscador.Text = "Sector" Then
            txtbuscador.Clear()
            txtbuscador.MaxLength = 2

        ElseIf cbxbuscador.Text = "Grupo" Then
            txtbuscador.Clear()
            txtbuscador.MaxLength = 30
        End If
    End Sub

   
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            MsgBox("Ingrese la fecha del registro a modificar", MsgBoxStyle.Information)
            GroupBox1.Enabled = False
            DataGridView1.Enabled = False
            cbxbuscador.Enabled = False
            txtbuscador.Enabled = False

            'dtpfecha.Text = DateString
        End If
        If CheckBox1.Checked = False Then

            GroupBox1.Enabled = True
            DataGridView1.Enabled = True
            cbxbuscador.Enabled = True
            txtbuscador.Enabled = True
        End If

    End Sub
End Class