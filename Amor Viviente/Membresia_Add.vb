Public Class Membresia_Add

    'Dim conexion As New Conexiones
    Dim miembro As New Miembros
    Dim conexion As New Conexiones
    '/////////////////////// Carga el datagridview///////////////////////////////////
    Private Sub Membresia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet11.Grp_Mostrar' Puede moverla o quitarla según sea necesario.
        Me.Grp_MostrarTableAdapter.Fill(Me.Amor_VivienteDataSet11.Grp_Mostrar)
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.Amor_VivienteDataSet.grupos)
        Me.MdiParent = Inicio
        



        



    End Sub

    '////////////////// Ingreso de un nuevo miembro //////////////////////////////////
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPnom.Text <> "" And TxtPape.Text <> "" Then
            Try
                miembro.PrimerNombre = txtPnom.Text
                miembro.SegundoNombre = TxtSnom.Text
                miembro.PrimerApellido = TxtPape.Text
                miembro.SegundoApellido = TxtSape.Text

                'TRUE = MASCULINO
                If RbM.Checked = True Then
                    miembro.genero = True
                End If

                'FALSE = FEMENINO
                If Rbf.Checked = True Then
                    miembro.genero = False
                End If

                miembro.fecha = DateTimePicker1.Text
                miembro.Grupo = ComboBox1.SelectedValue

                miembro.Mbr_Ingreso()
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha ingresado un Miembro a la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")

                MsgBox("Miembro Registrado con exito!", MsgBoxStyle.Information)

                txtPnom.Clear()
                TxtSnom.Clear()
                TxtPape.Clear()
                TxtSape.Clear()


            Catch ex As Exception
                MsgBox("Error al Ingresar Miembro" & vbCrLf & ex.Message)
            End Try

        Else
            MsgBox("faltan campos")

        End If
       




    End Sub



    

    

    Private Sub txtPnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPnom.KeyPress
        ClsLetras(e)
    End Sub

    
    Private Sub TxtSnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSnom.KeyPress
        ClsLetras(e)
    End Sub



    Private Sub TxtPape_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPape.KeyPress
        ClsLetras(e)
    End Sub

    Private Sub TxtSape_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSape.KeyPress
        ClsLetras(e)
    End Sub
End Class