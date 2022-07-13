Public Class LoLogin
    Public Function insertarCliente(usuario As String, Contrasena As String)
        Dim dLL As New Login(usuario, Contrasena)
        If dLL.insertarCliente(dLL) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class
