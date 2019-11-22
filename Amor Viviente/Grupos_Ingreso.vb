Public Class Grupos_Ingreso

    Dim conexion As New Conexiones
    Public codigo As Integer

    Private Sub Grupos_Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        MdiParent = Inicio
        Dim Query = "Exec Grp_Mostrar"
        conexion.llenardgv(DataGridView1, Query)
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect




    End Sub

    
    Private Sub TxtBuscador_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscador.TextChanged
        If cbxbuscador.Text = "Nombre" Then
            TxtBuscador.MaxLength = 30
            conexion.llenardgv(DataGridView1, "Exec [Grp_Buscador-Nombre] @nombre = '" & TxtBuscador.Text & "'")
        End If
        If cbxbuscador.Text = "Sector" Then
            TxtBuscador.MaxLength = 2
            conexion.llenardgv(DataGridView1, "Exec [Grp_Buscador-Sector] @Sector = '" & TxtBuscador.Text + "'")
        End If

    End Sub

    Private Sub rbn_CheckedChanged(sender As Object, e As EventArgs) Handles rbn.CheckedChanged
        If rbn.Checked = True Then
            DataGridView1.Enabled = False
            Label6.Visible = False
            PictureBox2.Visible = False
        End If
        btningresar.Enabled = True
    End Sub

    Private Sub rbm_CheckedChanged(sender As Object, e As EventArgs) Handles rbm.CheckedChanged
        If rbm.Checked = True Then
            DataGridView1.Enabled = True
            Label6.Visible = True
            PictureBox2.Visible = True
        End If
        btningresar.Enabled = True
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        If txtnombre.Text <> "" And txtmiembros.Text <> "" And sector.Text <> "" And zona.Text <> "" Then

            If rbn.Checked = True Then
                conexion.insertar("Exec Grp_Ingreso @grupo ='" & txtnombre.Text & "', @sector = " & sector.Text & ",@Miembros =" & txtmiembros.Text & ",@estado= " & 1 & ", @zona = " & zona.Text)
                Dim Query = "Exec Grp_Mostrar"
                conexion.llenardgv(DataGridView1, Query)
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha ingresado un nuevo grupo a la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
                MsgBox("Grupo Ingresado con exito!", MsgBoxStyle.Information)
            End If
            If rbm.Checked = True Then

                conexion.insertar("Exec Grp_Modificacion @codigo = " & codigo & ", @grupo = '" & txtnombre.Text & "', @sector = " & sector.Text & ",@Miembros =" & txtmiembros.Text & ",@estado =" & 1 & ", @zona = " & zona.Text)
                Dim Query = "Exec Grp_Mostrar"
                conexion.llenardgv(DataGridView1, Query)
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha modificado un grupo en la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
                MsgBox("Grupo Modificado con exito!", MsgBoxStyle.Information)
            End If

        Else

            MsgBox("Faltan campos", MsgBoxStyle.Critical)

        End If
       
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        codigo = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtnombre.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        sector.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtmiembros.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        zona.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
    End Sub

   

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        ClsLetrasyNumeros(e)
    End Sub

    Private Sub txtmiembros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmiembros.KeyPress
        ClsNumeros(e)
    End Sub

    Private Sub TxtBuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscador.KeyPress
        If cbxbuscador.Text = "Nombre" Then
            ClsLetrasyNumeros(e)

        ElseIf cbxbuscador.Text = "Sector" Then
            ClsNumeros(e)
        End If

    End Sub

    Private Sub cbxbuscador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbuscador.SelectedIndexChanged
        TxtBuscador.Clear()
    End Sub
End Class