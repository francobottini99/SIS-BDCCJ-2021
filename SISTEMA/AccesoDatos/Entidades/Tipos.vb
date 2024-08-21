Public Class Tipos
    Public Property idTipos As Integer
    Public Property DetalleTipo As String

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(idTipos As Integer, detalleTipo As String)
        Me.idTipos = idTipos
        Me.DetalleTipo = detalleTipo
    End Sub
End Class
