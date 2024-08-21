Imports MySql.Data.MySqlClient

Public Class TransaccionesCamara
    Inherits Transacciones

    Public Function insRegistro(param As Camara) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cNom", param.NombreCamara))
        parametros.Add(New MySqlParameter("@cDir", param.Direccion))
        parametros.Add(New MySqlParameter("@cLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@cCod", param.CP))
        parametros.Add(New MySqlParameter("@cPro", param.Provincia))

        Return ExecuteNonQuery("bd_ana.insCamara")
    End Function

    Public Function modRegistro(param As Camara) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cIdC", param.idCamara))
        parametros.Add(New MySqlParameter("@cNom", param.NombreCamara))
        parametros.Add(New MySqlParameter("@cDir", param.Direccion))
        parametros.Add(New MySqlParameter("@cLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@cCod", param.CP))
        parametros.Add(New MySqlParameter("@cPro", param.Provincia))

        Return ExecuteNonQuery("bd_ana.modCamara")
    End Function

    Public Function elimRegistro(id As Integer) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cIdC", id))

        Return ExecuteNonQuery("bd_ana.elimCamara")
    End Function

    Public Function verRegistros() As List(Of Camara)
        Dim tabla As DataTable = ExecuteReader("bd_ana.verCamara")

        If tabla.Rows.Count > 0 Then
            Dim camaras As New List(Of Camara)

            For Each item As DataRow In tabla.Rows
                camaras.Add(New Camara With {
                    .idCamara = item("idCamara"),
                    .NombreCamara = item("NombreCamara"),
                    .Direccion = item("Direccion"),
                    .Localidad = item("Localidad"),
                    .CP = item("CP"),
                    .Provincia = item("Provincia")
                })
            Next

            Return camaras
        Else
            Return Nothing
        End If
    End Function
End Class
