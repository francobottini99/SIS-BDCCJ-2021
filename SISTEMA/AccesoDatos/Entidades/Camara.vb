Public Class Camara
    Public Property idCamara As Integer
    Public Property NombreCamara As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property CP As String
    Public Property Provincia As String

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(idCamara As Integer, nombreCamara As String, direccion As String, localidad As String, cP As String, provincia As String)
        Me.idCamara = idCamara
        Me.NombreCamara = nombreCamara
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.CP = cP
        Me.Provincia = provincia
    End Sub
End Class
