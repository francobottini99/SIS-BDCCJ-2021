Imports MySql.Data.MySqlClient

Public Class TransaccionesTribunales
    Inherits Transacciones

    Public Function insRegistro(param As Tribunales) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@tNom", param.NombreTribunal))
        parametros.Add(New MySqlParameter("@tDir", param.Direccion))
        parametros.Add(New MySqlParameter("@tLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@tCod", param.CP))
        parametros.Add(New MySqlParameter("@tPro", param.Provincia))

        Return ExecuteNonQuery("bd_ana.insTribunal")
    End Function

    Public Function modRegistro(param As Tribunales) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@tIdT", param.idTribunal))
        parametros.Add(New MySqlParameter("@tNom", param.NombreTribunal))
        parametros.Add(New MySqlParameter("@tDir", param.Direccion))
        parametros.Add(New MySqlParameter("@tLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@tCod", param.CP))
        parametros.Add(New MySqlParameter("@tPro", param.Provincia))

        Return ExecuteNonQuery("bd_ana.modTribunal")
    End Function

    Public Function elimRegistro(id As Integer) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@tIdT", id))

        Return ExecuteNonQuery("bd_ana.elimTribunal")
    End Function

    Public Function verRegistros() As List(Of Tribunales)
        Dim tabla As DataTable = ExecuteReader("bd_ana.verTribunal")

        If tabla.Rows.Count > 0 Then
            Dim tribunales As New List(Of Tribunales)

            For Each item As DataRow In tabla.Rows
                tribunales.Add(New Tribunales With {
                    .idTribunal = item("idTribunal"),
                    .NombreTribunal = item("NombreTribunal"),
                    .Direccion = item("Direccion"),
                    .Localidad = item("Localidad"),
                    .CP = item("CP"),
                    .Provincia = item("Provincia")
                })
            Next

            Return tribunales
        Else
            Return Nothing
        End If
    End Function
End Class
