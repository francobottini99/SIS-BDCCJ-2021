Imports AccesoDatos

Public Class frmInicio
    Private Sub Hora_Tick(sender As Object, e As EventArgs) Handles Hora.Tick
        lblHora.Text = Date.Now.ToLongTimeString
        lblFecha.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPPal.lblFrmActual.Text = "INICIO"

        lblHora.Text = Date.Now.ToLongTimeString
        lblFecha.Text = Date.Now.ToLongDateString

        Dim Transacciones_Casos As New TransaccionesCasos
        Dim Transacciones_Fueros As New TransaccionesFueros
        Dim Transacciones_Tipos As New TransaccionesTipos
        Dim Transacciones_Camara As New TransaccionesCamara
        Dim Transacciones_Tribunales As New TransaccionesTribunales

        Try
            Dim Casos As List(Of Casos) = Transacciones_Casos.verRegistros()
            Dim Fueros As List(Of Fueros) = Transacciones_Fueros.verRegistros()
            Dim Tipos As List(Of Tipos) = Transacciones_Tipos.verRegistros()
            Dim Camaras As List(Of Camara) = Transacciones_Camara.verRegistros()
            Dim Tribunales As List(Of Tribunales) = Transacciones_Tribunales.verRegistros()

            If Not IsNothing(Casos) Then
                lblCasos.Text = Casos.Count
            End If

            If Not IsNothing(Tribunales) Then
                lblTribunales.Text = Tribunales.Count
            End If

            If Not IsNothing(Camaras) Then
                lblCamara.Text = Camaras.Count
            End If

            If Not IsNothing(Tipos) Then
                lblTipo.Text = Tipos.Count
            End If

            If Not IsNothing(Fueros) Then
                lblFueros.Text = Fueros.Count
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub
End Class