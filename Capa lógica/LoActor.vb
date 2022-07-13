Public Class LoActor
    Public Function insertarCliente(ta As String, CO As String, Pe As Decimal, alt As String)
        Dim dLa As New actor(ta, CO, Pe, alt)
        If dLa.insertarCliente(dLa) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class
