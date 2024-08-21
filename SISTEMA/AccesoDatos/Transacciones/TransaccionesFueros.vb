Imports MySql.Data.MySqlClient

Public Class TransaccionesFueros
    Inherits Transacciones

    Public Function insRegistro(param As Fueros) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fTip", param.TipoFuero))

        Return ExecuteNonQuery("bd_ana.insFueros")
    End Function

    Public Function modRegistro(param As Fueros) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fIdF", param.idFueros))
        parametros.Add(New MySqlParameter("@fTip", param.TipoFuero))

        Return ExecuteNonQuery("bd_ana.modFueros")
    End Function

    Public Function elimRegistro(id As Integer) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fIdF", id))

        Return ExecuteNonQuery("bd_ana.elimFueros")
    End Function

    Public Function verRegistros() As List(Of Fueros)
        Dim tabla As DataTable = ExecuteReader("bd_ana.verFueros")

        If tabla.Rows.Count > 0 Then
            Dim fueros As New List(Of Fueros)

            For Each item As DataRow In tabla.Rows
                fueros.Add(New Fueros With {
                    .idFueros = item("idFueros"),
                    .TipoFuero = item("TipoFuero")
                })
            Next

            Return fueros
        Else
            Return Nothing
        End If
    End Function
End Class
