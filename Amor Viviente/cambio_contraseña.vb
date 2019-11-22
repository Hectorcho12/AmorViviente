Public Class cambio_contraseña

    Public conexion As New Conexiones

    Private Sub cambio_contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtpass.Text = contraseña Then

            If txtpass1.Text = txtpass2.Text Then
                Dim query = "exec Usr_Modificacion @ID = '" & User & "',@Pass = '" & txtpass2.Text & "',@cargo = '" & cargo & "',@estado = 1"
                conexion.insertar(query)
                conexion.insertar("Exec Bit_Registro @descripcion = 'Se ha Cambiado la contraseña de un usuario', @Usuario = '" & User & "',@fecha = '" & DateString & "'")

                MsgBox("Cambios Realizados con exito! Vuelva a iniciar secion", MsgBoxStyle.Information)
                Login.Show()
                Inicio.Close()
                Me.Close()
            Else
                MsgBox("Erorr al repetir contraseña", MsgBoxStyle.Critical)
            End If

        Else

            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical)
        End If
       

    End Sub

    Public Sub validar_txt()

        If txtpass.Text <> "" And txtpass1.Text <> "" And txtpass2.Text <> "" Then
            Button1.Enabled = True

        Else
            Button1.Enabled = False
        End If

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        validar_txt()
    End Sub

    Private Sub txtpass1_TextChanged(sender As Object, e As EventArgs) Handles txtpass1.TextChanged
        validar_txt()
    End Sub

    Private Sub txtpass2_TextChanged(sender As Object, e As EventArgs) Handles txtpass2.TextChanged
        validar_txt()
    End Sub
End Class