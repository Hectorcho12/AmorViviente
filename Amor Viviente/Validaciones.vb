Module Validaciones
    Public Sub ClsNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then 'Si es digito
            e.Handled = False 'Se ingresa
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es un control
            e.Handled = False 'Se ingresa
        Else  'sino se cumple la condicion
            e.Handled = True ' No se ingresa
        End If 'Finaliza Condicion
    End Sub
    
    Public Sub ClsCharacteres(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then 'Si es un digito
            e.Handled = True ' No se ingresa
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es un contol
            e.Handled = False 'Se ingresa
        Else  'sino se cumple la condicion
            e.Handled = False 'Se ingresa
        End If 'Finaliza Condicion
    End Sub


    Public Sub ClsLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then 'Si es una letra
            e.Handled = False 'Se ingresa
        ElseIf Char.IsControl(e.KeyChar) Then 'Si esun control
            e.Handled = False 'Se ingresa
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es un separador
            e.Handled = False 'Se ingresa
        Else  'sino se cumple la condicion
            e.Handled = True ' No se ingresa
        End If 'Finaliza Condicion
    End Sub
    
    Public Sub ClsCorreo(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then 'Si es un digito
            e.Handled = False 'Se ingresa
        ElseIf Asc(e.KeyChar) = 64 Then 'Si esun arroba
            e.Handled = False 'Se ingresa
        ElseIf Asc(e.KeyChar) = 45 Then 'Si es un guion 
            e.Handled = False 'Se ingresa
        ElseIf Asc(e.KeyChar) = 95 Then 'Si es un guion bajo
            e.Handled = False 'Se ingresa
        ElseIf Asc(e.KeyChar) = 46 Then 'Si es un punto
            e.Handled = False 'Se ingresa
        ElseIf Asc(e.KeyChar) = 32 Then 'Si es un espacio
            e.Handled = True ' No se ingresa
        ElseIf Char.IsControl(e.KeyChar) Then 'si es un control
            e.Handled = False 'Se ingresa
        ElseIf Char.IsLetter(e.KeyChar) Then 'si es una letra
            e.Handled = False 'Se ingresa
        Else  'sino se cumple la condicion
            e.Handled = True ' No se ingresa
        End If 'Finaliza Condicion
    End Sub

    Public Sub ClsLetrasyNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then 'Si es una letra
            e.Handled = False 'Se ingresa
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es un contol
            e.Handled = False 'Se ingresa
        ElseIf Char.IsDigit(e.KeyChar) Then 'Si es un digito
            e.Handled = False 'Se ingresa
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es un separador
            e.Handled = False 'Se ingresa
        Else  'sino se cumple la condicion
            e.Handled = True ' No se ingresa
        End If 'Finaliza Condicion
    End Sub
End Module
