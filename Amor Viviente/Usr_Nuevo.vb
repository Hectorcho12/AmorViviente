Public Class Usr_Nuevo

    Dim conexion As New Conexiones
    Dim crg As Integer
    Private Sub Usr_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If conexion.val("Exec Usr_mostrar") = False Then

            Label5.Visible = True
            cbxcargo.Text = "Administrador"
            cbxcargo.Enabled = False
        End If

        Me.MdiParent = Inicio
        cbxcargo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        If Txtpass.Text <> "" And txtpass2.Text <> "" And txtUsr.Text <> "" And cbxcargo.Text <> "" Then

            If Txtpass.Text = txtpass2.Text Then

                If cbxcargo.Text = "Administrador" Then
                    crg = 1
                Else
                    crg = 2
                End If
                Dim Query = "Exec Usr_Ingreso @ID = '" & txtUsr.Text & "',@Pass = '" & Txtpass.Text & "', @cargo = '" & crg & "', @estado =" & 1
                conexion.insertar(Query)
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha ingresado un nuevo usuario a la base de datos', @Usuario = '" & User & "',@fecha = '" & DateString & "'")
                MsgBox("Usuario Ingresado con exito!", MsgBoxStyle.DefaultButton1)

                If conexion.Contar("Exec Usr_mostrar") = 1 Then
                    Login.Show()
                    Me.Close()
                    Inicio.Close()
                End If

                txtUsr.Clear()
                    Txtpass.Clear()
                    txtpass2.Clear()
                    cbxcargo.Text = ""

                Else

                    MsgBox("Erro al repetir la contraseña", MsgBoxStyle.Critical)

            End If


        Else
            MsgBox("Faltan campos por llenar", MsgBoxStyle.Critical)
        End If

        

    End Sub

    Private Sub txtUsr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsr.KeyPress
        ClsLetrasyNumeros(e)
    End Sub

    Private Sub Txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpass.KeyPress
        ClsLetrasyNumeros(e)
    End Sub

    Private Sub txtpass2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass2.KeyPress
        ClsLetrasyNumeros(e)
    End Sub

    
End Class