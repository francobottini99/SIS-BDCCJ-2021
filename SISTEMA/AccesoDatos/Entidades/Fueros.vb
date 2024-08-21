Public Class Fueros
    Public Property idFueros As Integer
    Public Property TipoFuero As String

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(idFueros As Integer, tipoFuero As String)
        Me.idFueros = idFueros
        Me.TipoFuero = tipoFuero
    End Sub
End Class
