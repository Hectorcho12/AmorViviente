Public Class Rpt_Ofr_Sx
    Dim fechabuscador As Date
    Private Sub Rpt_Ofr_Sx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_Ofrenda' Puede moverla o quitarla según sea necesario.
        Me.MdiParent = Inicio
        txtaño.Text = Year(Now)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtaño.Text <> "" And cbxmes.Text <> "" And cbxsector.Text <> "" And cbxzona.Text <> "" Then
            reconocerfecha()
            Me.Reportes_OfrendaTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Ofrenda, fechabuscador, cbxzona.Text, cbxsector.Text)

            Me.ReportViewer1.RefreshReport()
        Else
            MsgBox("Faltan campos por llenar", MsgBoxStyle.DefaultButton1)
        End If
    End Sub

    Public Sub reconocerfecha()
        If cbxmes.Text = "Enero" Then
            fechabuscador = "01/01/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Febrero" Then
            fechabuscador = "01/02/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Marzo" Then
            fechabuscador = "01/03/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Abril" Then
            fechabuscador = "01/04/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Mayo" Then
            fechabuscador = "01/05/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Junio" Then
            fechabuscador = "01/06/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Julio" Then
            fechabuscador = "01/07/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Agosto" Then
            fechabuscador = "01/08/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Septiembre" Then
            fechabuscador = "01/09/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Octubre" Then
            fechabuscador = "01/10/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Noviembre" Then
            fechabuscador = "01/11/" & txtaño.Text.Trim()

        ElseIf cbxmes.Text = "Diciembre" Then
            fechabuscador = "01/12/" & txtaño.Text.Trim()

        End If

    End Sub

    

    Private Sub txtaño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaño.KeyPress
        ClsNumeros(e)
    End Sub
End Class