Imports MySql.Data.MySqlClient

Public MustInherit Class Conexion
    Private ReadOnly cadenaConn As String

    Public Sub New()
        cadenaConn = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\BDCCJ\ConexionBD.txt")
    End Sub

    Protected Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(cadenaConn)
    End Function
End Class
