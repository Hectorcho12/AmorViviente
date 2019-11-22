Public Class Login
    Public con As New Conexiones
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.val("Exec Usr_mostrar") = False Then
            Inicio.Show()
            Usr_Nuevo.Show()
            Me.Close()

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexiones As New Conexiones
        Dim query = "exec Ingresar @usuario,@contraseña"
        conexiones.logearse(TextBox1.Text, TextBox2.Text, query)

        


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Button1.Enabled = True
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Button1.Enabled = False
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Button1.Enabled = True
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Button1.Enabled = False
        End If

    End Sub

    
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ClsLetrasyNumeros(e)
    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ClsLetrasyNumeros(e)
    End Sub
End Class