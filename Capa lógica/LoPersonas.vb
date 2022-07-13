Public Class LoPersonas
    Public Function insertarCliente(FN As String, Profesion As String, apellido As String, nombre As String, direccion As String)
        Dim dLpp As New DPersonas(FN, Profesion, apellido, nombre, direccion)
        If dLpp.insertarCliente(dLpp) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class
