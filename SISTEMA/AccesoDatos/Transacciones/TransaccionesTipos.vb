Imports MySql.Data.MySqlClient

Public Class TransaccionesTipos
    Inherits Transacciones

    Public Function insRegistro(param As Tipos) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@tDet", param.DetalleTipo))

        Return ExecuteNonQuery("bd_ana.insTipos")
    End Function

    Public Function modRegistro(param As Tipos) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@tIdT", param.idTipos))
        parametros.Add(New MySqlParameter("@tDet", param.DetalleTipo))

        Return ExecuteNonQuery("bd_ana.modTipos")
    End Function

    Public Function elimRegistro(id As Integer) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@tIdT", id))

        Return ExecuteNonQuery("bd_ana.elimTipos")
    End Function

    Public Function verRegistros() As List(Of Tipos)
        Dim tabla As DataTable = ExecuteReader("bd_ana.verTipos")

        If tabla.Rows.Count > 0 Then
            Dim tipos As New List(Of Tipos)

            For Each item As DataRow In tabla.Rows
                tipos.Add(New Tipos With {
                    .idTipos = item("idTipos"),
                    .DetalleTipo = item("DetalleTipo")
                })
            Next

            Return tipos
        Else
            Return Nothing
        End If
    End Function

End Class
