Imports MySql.Data.MySqlClient

Public Class TransaccionesCasos
    Inherits Transacciones

    Public Function insRegistro(param As Casos) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cIns", param.Instancia))
        parametros.Add(New MySqlParameter("@cCau", param.Causa))
        parametros.Add(New MySqlParameter("@cCar", param.Caratula))
        parametros.Add(New MySqlParameter("@cNum", param.NumeroExpediente))
        parametros.Add(New MySqlParameter("@cHec", param.HechosOrigen))
        parametros.Add(New MySqlParameter("@cFec", param.FechaPublicacion))
        parametros.Add(New MySqlParameter("@cLin", param.LinkCausa))
        parametros.Add(New MySqlParameter("@cIdF", param.ascFueros.idFueros))
        parametros.Add(New MySqlParameter("@cIdT", param.ascTipos.idTipos))

        Return ExecuteNonQuery("bd_ana.insCasos")
    End Function

    Public Function modRegistro(param As Casos) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cIdC", param.idCasos))
        parametros.Add(New MySqlParameter("@cIns", param.Instancia))
        parametros.Add(New MySqlParameter("@cCau", param.Causa))
        parametros.Add(New MySqlParameter("@cCar", param.Caratula))
        parametros.Add(New MySqlParameter("@cNum", param.NumeroExpediente))
        parametros.Add(New MySqlParameter("@cHec", param.HechosOrigen))
        parametros.Add(New MySqlParameter("@cFec", param.FechaPublicacion))
        parametros.Add(New MySqlParameter("@cLin", param.LinkCausa))
        parametros.Add(New MySqlParameter("@cIdF", param.ascFueros.idFueros))
        parametros.Add(New MySqlParameter("@cIdT", param.ascTipos.idTipos))

        Return ExecuteNonQuery("bd_ana.modCasos")
    End Function

    Public Function elimRegistro(id As Integer) As Integer
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cIdC", id))

        Return ExecuteNonQuery("bd_ana.elimCasos")
    End Function

    Public Function verRegistros() As List(Of Casos)
        Dim tabla As DataTable = ExecuteReader("bd_ana.verCasos")

        If tabla.Rows.Count > 0 Then
            Dim casos As New List(Of Casos)

            For Each item As DataRow In tabla.Rows
                casos.Add(New Casos With {
                    .idCasos = item("idCasos"),
                    .Instancia = item("Instancia"),
                    .Causa = item("Causa"),
                    .Caratula = item("Caratula"),
                    .NumeroExpediente = item("NumeroExpediente"),
                    .HechosOrigen = item("HechosOrigen"),
                    .FechaPublicacion = item("FechaPublicacion"),
                    .LinkCausa = item("LinkCausa"),
                    .ascFueros = New Fueros With {
                        .idFueros = item("idFueros"),
                        .TipoFuero = item("TipoFuero")
                    },
                    .ascTipos = New Tipos With {
                        .idTipos = item("idTipos"),
                        .DetalleTipo = item("DetalleTipo")
                    }
                })
            Next

            Return casos
        Else
            Return Nothing
        End If
    End Function
End Class
