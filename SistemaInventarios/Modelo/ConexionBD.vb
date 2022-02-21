Imports System.Data.SqlClient

Module ConexionBD
    Public ConInventarios As New SqlConnection

    Sub conectarBD()
        Try
            ConInventarios.ConnectionString = ("Data Source= 10.48.132.136; Initial Catalog= Inventarios; User Id=SIInv; Password= Kenworth2022; Connect timeout= 200;")
            ConInventarios.Open()

        Catch ex As Exception

        End Try



    End Sub




End Module
