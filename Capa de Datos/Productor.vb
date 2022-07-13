Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Productor

    Inherits conexion
    Private Id_productor, añosExperiencia, Area As String



    Private Cmd As SqlCommand
    Public Sub New(Id As String, añosE As String, area As String)

        Me.Id_productor = Id
        Me.añosExperiencia = añosE
        Me.Area = area


    End Sub
    Public Function consultarProductores()
        Try
            Conectar()

            Cmd = New SqlCommand("instruccion")

            Cmd.Connection = Con
            If Cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter
                adp.Fill(dt)
                Return dt
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function insertarCliente(dpr As Productor) As Boolean
        Try
            Conectar()
            Dim sql As String = " Insert into PRODUCTOR (usuario, contrasena) values('" & dpr.Id_productor & "','" & dpr.añosExperiencia & "','" & dpr.Area & "')"
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
