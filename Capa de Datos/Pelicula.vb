Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Pelicula
    Inherits conexion
    Private id_profesion, id_pelicula, nombrePelicula As String



    Private Cmd As SqlCommand
    Public Sub New(ID_p As String, ID_pe As String, nP As String)

        Me.id_profesion = ID_p
        Me.id_pelicula = ID_pe
        Me.nombrePelicula = nP


    End Sub
    Public Function insertarCliente(dpe As Pelicula) As Boolean
        Try
            Conectar()
            Dim sql As String = " Insert into PELICULA (usuario, contrasena) values('" & dpe.id_profesion & "','" & dpe.id_pelicula & "','" & dpe.nombrePelicula & "')"
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
