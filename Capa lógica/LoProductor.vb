Public Class LoProductor
    Public Function insertarCliente(Id As String, añosE As String, area As String)
        Dim dLpr As New Pelicula(Id, añosE, area)
        If dLpr.insertarCliente(dLpr) Then
            Return True
        Else
            Return False
        End If


    End Function
End Class
