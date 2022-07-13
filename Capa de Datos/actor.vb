Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class actor

    Inherits conexion
        Private talla, colorOjo As String
        Private peso, altura As Decimal


        Private Cmd As SqlCommand
        Public Sub New(ta As String, CO As String, Pe As Decimal, alt As String)

            Me.talla = ta
            Me.colorOjo = CO
            Me.peso = Pe
            Me.altura = alt


        End Sub
    Public Function insertarCliente(da As actor) As Boolean
        Try
            Conectar()
            Dim sql As String = " Insert into ACTOR (usuario, contrasena) values('" & da.talla & "','" & da.colorOjo & "','" & da.peso & "','" & da.altura & "')"
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
