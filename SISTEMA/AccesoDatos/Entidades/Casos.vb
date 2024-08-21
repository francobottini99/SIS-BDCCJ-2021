Public Class Casos
    Public Property idCasos As Integer
    Public Property Instancia As String
    Public Property Causa As String
    Public Property Caratula As String
    Public Property NumeroExpediente As String
    Public Property HechosOrigen As String
    Public Property FechaPublicacion As Date
    Public Property LinkCausa As String
    Public Property ascFueros As Fueros
    Public Property ascTipos As Tipos

    'CONSTRUCTORES
    Public Sub New()
    End Sub

    Public Sub New(idCasos As Integer, instancia As String, causa As String, caratula As String, numeroExpediente As String, hechosOrigen As String,
                   fechaPublicacion As Date, linkCausa As String, ascFueros As Fueros, ascTipos As Tipos)
        Me.idCasos = idCasos
        Me.Instancia = instancia
        Me.Causa = causa
        Me.Caratula = caratula
        Me.NumeroExpediente = numeroExpediente
        Me.HechosOrigen = hechosOrigen
        Me.FechaPublicacion = fechaPublicacion
        Me.LinkCausa = linkCausa
        Me.ascFueros = ascFueros
        Me.ascTipos = ascTipos
    End Sub
End Class
