Public Class Tribunales
    Public Property idTribunal As Integer
    Public Property NombreTribunal As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property CP As String
    Public Property Provincia As String

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(idTribunal As Integer, nombreTribunal As String, direccion As String, localidad As String, cP As String, provincia As String)
        Me.idTribunal = idTribunal
        Me.NombreTribunal = nombreTribunal
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.CP = cP
        Me.Provincia = provincia
    End Sub
End Class

