Public Class LoPelicula
    Public Function insertarCliente(ID_p As String, ID_pe As String, nP As String)
        Dim dLpe As New Pelicula(ID_p, ID_pe, nP)
        If dLpe.insertarCliente(dLpe) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class
