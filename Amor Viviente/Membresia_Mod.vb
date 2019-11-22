Imports System.Data.SqlClient
Public Class Membresia_Mod

    Dim conexion As New Conexiones
    Dim miembro As New Miembros

    Private Sub Membresia_Mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Grp_Mostrar' Puede moverla o quitarla según sea necesario.
        Me.Grp_MostrarTableAdapter.Fill(Me.Amor_VivienteDataSet1.Grp_Mostrar)

        Me.MdiParent = Inicio
        conexion.llenardgv(DataGridView1, "Exec [Mbr_Mostra-Modificacion]")
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect



        DataGridView1.Columns(5).Visible = False

        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 110
        DataGridView1.Columns(3).Width = 110
        DataGridView1.Columns(4).Width = 110
        DataGridView1.Columns(6).Width = 160
        DataGridView1.Columns(7).Width = 160


    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscador.KeyUp
        conexion.llenardgv(DataGridView1, "Exec Mbr_Buscador_Modificacion @nombre ='" & txtbuscador.Text & "'")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        txtpnom.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        txtsnom.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtpape.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        txtsape.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString

        If DataGridView1.CurrentRow.Cells.Item(5).Value.ToString = True Then
            rbm.Checked = True
        Else
            rbf.Checked = True
        End If
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString
        ComboBox1.Text = DataGridView1.CurrentRow.Cells.Item(7).Value.ToString

    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click

        If txtpnom.Text <> "" And txtpape.Text <> "" Then
            miembro.Codigo = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
            miembro.PrimerNombre = txtpnom.Text
            miembro.SegundoNombre = txtsnom.Text
            miembro.PrimerApellido = txtpape.Text
            miembro.SegundoApellido = txtsape.Text
            miembro.Grupo = ComboBox1.SelectedValue

            'TRUE = MASCULINO
            If rbm.Checked = True Then
                miembro.genero = True
            End If

            'FALSE = FEMENINO
            If rbf.Checked = True Then
                miembro.genero = False
            End If

            miembro.fecha = DateTimePicker1.Text

            miembro.Mbr_Modificacion()
            conexion.llenardgv(DataGridView1, "Exec [Mbr_Mostra-Modificacion]")
            conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha modificado un miembro de la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
            MsgBox("Modificacion realizada con exito", MsgBoxStyle.Information)

            txtpnom.Clear()
            txtsnom.Clear()
            txtpape.Clear()
            txtsape.Clear()

        Else
            MsgBox("faltan campos")

        End If



      
    End Sub

    
    
    Private Sub txtpnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpnom.KeyPress
        ClsLetras(e)
    End Sub

    Private Sub txtsnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsnom.KeyPress
        ClsLetras(e)
    End Sub

    Private Sub txtpape_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpape.KeyPress
        ClsLetras(e)
    End Sub

    Private Sub txtsape_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsape.KeyPress
        ClsLetras(e)
    End Sub

    
    Private Sub txtbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscador.KeyPress
        ClsLetras(e)
    End Sub
End Class