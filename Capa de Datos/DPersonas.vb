Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DPersonas
    Inherits conexion
    Private Profesion, nombre, apellido As String
    Private fecha_Nacimiento, direccion As String


    Private Cmd As SqlCommand
    Public Sub New(FN As String, Profesion As String, apellido As String, nombre As String, direccion As String)

        Me.Profesion = Profesion
        Me.nombre = nombre
        Me.apellido = apellido
        Me.fecha_Nacimiento = FN
        Me.direccion = direccion

    End Sub
    Public Function insertarCliente(dp As DPersonas) As Boolean
        Try
            Conectar()
            Dim sql As String = " Insert into PERSONA (usuario, contrasena) values('" & dp.Profesion & "','" & dp.nombre & "','" & dp.apellido & "','" & dp.fecha_Nacimiento & "','" & dp.direccion & "')"
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
