Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Login
    Inherits conexion
    Private Usuario As String
    Private Contrasena As String

    Private Cmd As SqlCommand
    Public Sub New(usu As String, Cont As String)
        Me.Usuario = usu
        Me.Contrasena = Cont
    End Sub
    Public Sub New()

    End Sub

    Public Function insertarCliente(dc As Login) As Boolean
        Try
            Conectar()
            Dim sql As String = " Insert into LOGIN (usuario, contrasena) values('" & dc.Usuario & "','" & dc.Contrasena & "') "
            Cmd = New SqlCommand(sql, Con)
            If Cmd.ExecuteNonQuery() Then
                MsgBox(" Ingreso correctamente ")
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


End Class
