Public Class ModalDiezmos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        If (CheckBox1.Checked = True) Then
            Rpt_Dez_Sx.Show()
            Me.Close()
        Else
            Rpt_Dez.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (CheckBox1.Checked = True) Then
            Rpt_Dez_miem_Sx.Show()
            Me.Close()
        Else
            Rpt_Dez_miem.Show()
            Me.Close()
        End If
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (CheckBox1.Checked = True) Then
            Rpt_Dez_Zona_Sx.Show()
            Me.Close()
        Else
            Rpt_Dez_Zona.Show()
            Me.Close()
        End If
    End Sub
End Class