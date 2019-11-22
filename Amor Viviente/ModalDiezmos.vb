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
            Rpt_Dez_miembro_Sx.Show()
            Me.Close()
        Else
            Rpt_Dez_miembro.Show()
            Me.Close()
        End If
        
    End Sub
End Class