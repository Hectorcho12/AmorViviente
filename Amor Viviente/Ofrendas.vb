Public Class Ofrendas

    Public conexion As New Conexiones
    Dim rtn As New Date
    Dim M As Date
    Dim cod_grp As Integer

    Dim fechabuscador As Date
    Private Sub Ofrendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
        txtbuscador.Text = Year(Now)
        'TODO: esta línea de código carga datos en la tabla 'Amor_Viviente_Vistas.Grupos_disp' Puede moverla o quitarla según sea necesario.
        Me.Grupos_dispTableAdapter.Fill(Me.Amor_Viviente_Vistas.Grupos_disp)
        
        

    End Sub

    Public Function mes(fecha As Date) As Date
        fecha = dtpfecha.Text
        fecha = fecha.AddDays(-fecha.Day + 1)

        Return fecha
    End Function


   

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btguardar.Click

        If txtmonto.Text <> "" And cbxgrupo.Text <> "" And cbxsemana.Text <> "" Then


            M = mes(rtn)
            Dim query = "exec Ofr_ComprobarVal @grupo = " & cbxgrupo.SelectedValue & ",@fecha = '" & M & "'"
            If conexion.val(query) = True Then

                conexion.llenardgv(DataGridView1, query)
                DataGridView1.Rows(0).Selected = True
                DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
                cod_grp = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString



                If cbxsemana.Text.Trim() = "Semana 1" Then

                    conexion.insertar("Exec Ofr_Modificar_Sem1 @cod = " & cod_grp & ",@sem1 =" & txtmonto.Text)


                ElseIf cbxsemana.Text.Trim() = "Semana 2" Then

                    conexion.insertar("Exec Ofr_Modificar_Sem2 @cod = " & cod_grp & ",@sem2 =" & txtmonto.Text)


                ElseIf cbxsemana.Text.Trim() = "Semana 3" Then

                    conexion.insertar("Exec Ofr_Modificar_Sem3 @cod = " & cod_grp & ",@sem3 =" & txtmonto.Text)


                ElseIf cbxsemana.Text.Trim() = "Semana 4" Then

                    conexion.insertar("Exec Ofr_Modificar_Sem4 @cod = " & cod_grp & ",@sem4 =" & txtmonto.Text)


                ElseIf cbxsemana.Text.Trim() = "Semana 5" Then

                    conexion.insertar("Exec Ofr_Modificar_Sem5 @cod = " & cod_grp & ",@sem5 =" & txtmonto.Text)


                End If

            Else
                If cbxsemana.Text.Trim() = "Semana 1" Then

                    conexion.insertar("Exec Ofr_Ingreso @grupo = '" & cbxgrupo.SelectedValue & "',@sem1 ='" & txtmonto.Text & "',@sem2 = NULL, @sem3 = NULL, @sem4 = NULL, @sem5 = NULL, @mes = '" & M & "'")


                ElseIf cbxsemana.Text.Trim() = "Semana 2" Then

                    conexion.insertar("Exec Ofr_Ingreso @grupo = '" & cbxgrupo.SelectedValue & "',@sem1 = NULL,@sem2 = " & txtmonto.Text & " , @sem3 = NULL, @sem4 = NULL, @sem5 = NULL, @mes = '" & M & "'")


                ElseIf cbxsemana.Text.Trim() = "Semana 3" Then

                    conexion.insertar("Exec Ofr_Ingreso @grupo = '" & cbxgrupo.SelectedValue & "',@sem1 = NULL,@sem2 = NULL , @sem3 = " & txtmonto.Text & ", @sem4 = NULL, @sem5 = NULL, @mes = '" & M & "'")


                ElseIf cbxsemana.Text.Trim() = "Semana 4" Then

                    conexion.insertar("Exec Ofr_Ingreso @grupo = '" & cbxgrupo.SelectedValue & "',@sem1 = NULL,@sem2 = NULL , @sem3 = NULL, @sem4 = " & txtmonto.Text & ", @sem5 = NULL, @mes = '" & M & "'")


                ElseIf cbxsemana.Text.Trim() = "Semana 5" Then

                    conexion.insertar("Exec Ofr_Ingreso @grupo = '" & cbxgrupo.SelectedValue & "',@sem1 = NULL,@sem2 = NULL , @sem3 = NULL, @sem4 = NULL, @sem5 = " & txtmonto.Text & ", @mes = '" & M & "'")


                End If

                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha modificado una ofrenda de la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")

            End If
            MsgBox("Registro guardado con exito!", MsgBoxStyle.DefaultButton1)

        Else
            MsgBox("Faltan campos", MsgBoxStyle.Critical)
        End If



    End Sub

    Public Sub reconocerfecha()
        If cbxbuscador.Text = "Enero" Then
            fechabuscador = "01/01/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Febrero" Then
            fechabuscador = "01/02/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Marzo" Then
            fechabuscador = "01/03/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Abril" Then
            fechabuscador = "01/04/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Mayo" Then
            fechabuscador = "01/05/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Junio" Then
            fechabuscador = "01/06/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Julio" Then
            fechabuscador = "01/07/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Agosto" Then
            fechabuscador = "01/08/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Septiembre" Then
            fechabuscador = "01/09/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Octubre" Then
            fechabuscador = "01/10/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Noviembre" Then
            fechabuscador = "01/11/" & txtbuscador.Text

        ElseIf cbxbuscador.Text = "Diciembre" Then
            fechabuscador = "01/12/" & txtbuscador.Text

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtbuscador.Text <> "" And cbxbuscador.Text <> "" Then
            reconocerfecha()
            conexion.llenardgv(dgvofrendas, "Exec Ofr_Mostrar @mes ='" & fechabuscador & "'")

            dgvofrendas.Columns(1).Visible = False
            dgvofrendas.Columns(8).Visible = False

        Else
            MsgBox("Ingrese un año y un mes", MsgBoxStyle.Critical)
        End If
        
    End Sub

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        ClsNumeros(e)
    End Sub

    Private Sub txtbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscador.KeyPress
        ClsNumeros(e)
    End Sub

    Private Sub dgvofrendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvofrendas.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbxbuscador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbuscador.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged

    End Sub
End Class