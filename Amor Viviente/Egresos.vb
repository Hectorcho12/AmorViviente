Public Class rbi
    Public conexion As New Conexiones
    Dim cuenta As Integer

    Dim ti As Integer
    Dim codigo As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtdesc.Text <> "" And txtmonto.Text <> "" And cbxtipo.Text <> "" Then

            If rbin.Checked = True Then

                Tipo()
                conexion.insertar("Exec Egr_Ingreso @descripcion ='" & txtdesc.Text & "',@monto ='" & txtmonto.Text & "',@fecha = '" & dtpfecha.Text & "', @Usuario = " & User & ", @tipo = " & cuenta)
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha ingresado un nuevo registro de egresos a la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
                MsgBox("Registro ingresado con exito!", MsgBoxStyle.Information)

                conexion.llenardgv(dgveg, "Exec Egr_Mostrar")

                txtdesc.Clear()
                txtmonto.Clear()


            ElseIf rbm.Checked = True Then

                conexion.insertar("Exec Egr_Modificacion @codigo = " & codigo & ",@descripcion = '" & txtdesc.Text & "',@monto = " & txtmonto.Text & ",@Usuario = " & User & ",@tipo =" & ti & ",@fecha = '" & dtpfecha.Text & "'")
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha modificado un registro de diezmos en la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
                MsgBox("Modificacion realizada con exito!", MsgBoxStyle.Information)

                conexion.llenardgv(dgveg, "Exec Egr_Mostrar")

            End If

        Else


            MsgBox("Falta campos", MsgBoxStyle.Critical)


        End If

    End Sub

    Private Sub Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio

        dgveg.SelectionMode = DataGridViewSelectionMode.FullRowSelect



        conexion.llenardgv(dgveg, "Exec Egr_Mostrar")
        dgveg.Columns(1).Width = 320


        dgveg.Columns(4).Visible = False


    End Sub

    Public Sub Tipo()
        If cbxtipo.Text = "Entrada" Then
            cuenta = 1
        End If
        If cbxtipo.Text = "Salida" Then
            cuenta = 2
        End If
        If cbxtipo.Text = "Capital" Then
            cuenta = 3
        End If
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbin.CheckedChanged
        If rbin.Checked = True Then
            Button1.Enabled = True
            MsgBox("Ingrese los datos correspondientes y de click en ingresar", MsgBoxStyle.Information)
            dgveg.Enabled = False
        End If
        
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbm.CheckedChanged
        If rbm.Checked = True Then
            dgveg.Enabled = True
            Button1.Enabled = True
            MsgBox("Escoja el Regristro a modificar, ingrese los datos que desea cambiar y de click en ingresar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress
        ClsLetrasyNumeros(e)
    End Sub

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        ClsNumeros(e)
    End Sub

    
    Private Sub dgveg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgveg.CellContentClick
        codigo = dgveg.CurrentRow.Cells.Item(0).Value.ToString
        txtdesc.Text = dgveg.CurrentRow.Cells.Item(1).Value.ToString
        txtmonto.Text = dgveg.CurrentRow.Cells.Item(2).Value.ToString
        dtpfecha.Text = dgveg.CurrentRow.Cells.Item(3).Value.ToString
        ti = dgveg.CurrentRow.Cells.Item(4).Value.ToString
    End Sub
End Class