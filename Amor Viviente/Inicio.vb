Public Class Inicio

    Public con As New Conexiones
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.val("Exec Usr_mostrar") = False Then
            Button1.Enabled = False





        End If



        Panel1.Height = 22
        Label19.Text = "Bienvenido " & User

        Label21.Text = DateString


        If cargo = 1 Then

        ElseIf cargo = 2 Then
            lbingresar.Enabled = False
            lbrptdiezmo.Enabled = False
            lbrptofrendas.Enabled = False
            lbrptmembresia.Enabled = False
            lbrptbalance.Enabled = False
            Label2.Enabled = False
        End If



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        While (Panel1.Height < 125)
            Panel1.Height += 2
        End While

        '////codigo para mostrar todos los botones///
        Button2.Visible = True
        


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        While (Panel1.Height > 22)
            Panel1.Height -= 2
        End While
        Button1.Visible = True
        
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

   
    Private Sub Lbingresar_MouseEnter(sender As Object, e As EventArgs) Handles lbingresar.MouseEnter
        lbingresar.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Lbingresar_MouseLeave(sender As Object, e As EventArgs) Handles lbingresar.MouseLeave
        lbingresar.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbingresar.Click
        Usr_Nuevo.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Membresia_Add.Show()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lbrptmembresia.Click
        Rpt_Mbr.Show()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles lbrptmembresia.MouseEnter
        lbrptmembresia.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles lbrptmembresia.MouseLeave
        lbrptmembresia.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Grupos_Ingreso.Show()
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Membresia_Mod.Show()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Diezmos.Show()
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As EventArgs) Handles Label12.MouseEnter
        Label12.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label12_MouseLeave(sender As Object, e As EventArgs) Handles Label12.MouseLeave
        Label12.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Ofrendas.Show()
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter
        Label13.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        Label13.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        rbi.Show()
    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As EventArgs) Handles Label15.MouseEnter
        Label15.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label15_MouseLeave(sender As Object, e As EventArgs) Handles Label15.MouseLeave
        Label15.ForeColor = Color.AliceBlue
    End Sub

   
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        cambio_contraseña.Show()
    End Sub

    Private Sub Label17_MouseEnter(sender As Object, e As EventArgs) Handles Label17.MouseEnter
        Label17.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label17_MouseLeave(sender As Object, e As EventArgs) Handles Label17.MouseLeave
        Label17.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbrptofrendas.Click
        ModalOfrendas.ShowDialog()

    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles lbrptofrendas.MouseEnter
        lbrptofrendas.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles lbrptofrendas.MouseLeave
        lbrptofrendas.ForeColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label20.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Lbrptdiezmo_Click(sender As Object, e As EventArgs) Handles lbrptdiezmo.Click
        ModalDiezmos.ShowDialog()
    End Sub

    Private Sub Lbrptdiezmo_MouseEnter(sender As Object, e As EventArgs) Handles lbrptdiezmo.MouseEnter
        lbrptdiezmo.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Lbrptdiezmo_MouseLeave(sender As Object, e As EventArgs) Handles lbrptdiezmo.MouseLeave
        lbrptdiezmo.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles lbrptbalance.Click
        Rpt_Egr.Show()
    End Sub

    Private Sub Label22_MouseEnter(sender As Object, e As EventArgs) Handles lbrptbalance.MouseEnter
        lbrptbalance.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label22_MouseLeave(sender As Object, e As EventArgs) Handles lbrptbalance.MouseLeave
        lbrptbalance.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Eliminar__Usuario.Show()
    End Sub

    Private Sub Label23_MouseEnter(sender As Object, e As EventArgs) Handles Label23.MouseEnter
        Label23.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label23_MouseLeave(sender As Object, e As EventArgs) Handles Label23.MouseLeave
        Label23.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub Label24_MouseEnter(sender As Object, e As EventArgs) Handles Label24.MouseEnter
        Label24.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label24_MouseLeave(sender As Object, e As EventArgs) Handles Label24.MouseLeave
        Label24.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Eliminar_usuario.Show()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        bitacora.Show()
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.PaleVioletRed
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.AliceBlue
    End Sub
End Class
