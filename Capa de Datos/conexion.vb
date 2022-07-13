Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class conexion
    Dim SqlQ As String = "Data Source=LAPTOP-N3RQT13C;Initial Catalog=BuscaTalentos2;Integrated Security=True"
    Protected Con As New SqlConnection(SqlQ)
    Public Function Conectar() As Boolean
        Try
            Con.Open()
            MsgBox("Conexion EXITOSA")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub Desconectar()
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
