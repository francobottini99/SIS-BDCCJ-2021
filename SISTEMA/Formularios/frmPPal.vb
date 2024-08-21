Imports System.Globalization
Imports System.Runtime.InteropServices

Public Class frmPPal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pnlBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBarraTitulo.MouseDown
        ReleaseCapture()
        pbxMax.Visible = True
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Me.Size = New Size(1024, 685)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnTribunal_Click(sender As Object, e As EventArgs) Handles btnTribunal.Click
        lblFrmActual.Text = "ALTA DE TRIBUNALES"
        AbrirFrm(New frmTribunales)
    End Sub

    Private Sub btnCamara_Click(sender As Object, e As EventArgs) Handles btnCamara.Click
        lblFrmActual.Text = "ALTA DE CAMARAS"
        AbrirFrm(New frmCamara)
    End Sub

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        lblFrmActual.Text = "ALTA DE TIPOS "
        AbrirFrm(New frmTipos)
    End Sub

    Private Sub btnFueros_Click(sender As Object, e As EventArgs) Handles btnFueros.Click
        lblFrmActual.Text = "ALTA DE FUEROS"
        AbrirFrm(New frmFueros)
    End Sub

    Private Sub btnCasos_Click(sender As Object, e As EventArgs) Handles btnCasos.Click
        lblFrmActual.Text = "ALTA DE CASOS"
        AbrirFrm(New frmCasos)

    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        lblFrmActual.Text = "CONSULTA DE CASOS"
        AbrirFrm(New frmConsultas)
    End Sub

    Private Sub frmPPal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(Me.Location) Then
                Me.Size = item.WorkingArea.Size
                Me.Location = item.WorkingArea.Location
                Me.MaximizedBounds = item.WorkingArea
                pbxMax.Visible = False

                Exit For
            End If
        Next

        CultureInfo.DefaultThreadCurrentCulture = New System.Globalization.CultureInfo("es-AR")
        CultureInfo.DefaultThreadCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.NumberGroupSeparator = ","

        AbrirFrm(New frmInicio)
    End Sub

    Public Function AbrirFrm(ByVal FRM As Form)
        Dim FH As Form

        If Me.pnlContenedor.Controls.Count > 0 Then
            Me.pnlContenedor.Controls.RemoveAt(0)
        End If

        FH = FRM
        FH.TopLevel = False
        FH.Dock = DockStyle.Fill
        FH.Parent = Me.pnlContenedor
        FH.FormBorderStyle = FormBorderStyle.None
        Me.pnlContenedor.Controls.Add(FH)
        Me.pnlContenedor.Tag = FH
        FH.Show()

        Return FH
    End Function

    Private Sub pbxMax_Click(sender As Object, e As EventArgs) Handles pbxMax.Click
        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(Me.Location) Then
                Me.Size = item.WorkingArea.Size
                Me.Location = item.WorkingArea.Location
                Me.MaximizedBounds = item.WorkingArea
                pbxMax.Visible = False
                Exit For
            End If
        Next
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        End
    End Sub

    Private Sub pbxRest_Click(sender As Object, e As EventArgs) Handles pbxRest.Click
        Me.Size = New Size(1024, 685)
        Me.CenterToScreen()
        pbxMax.Visible = True
    End Sub

    Private Sub pbxMin_Click(sender As Object, e As EventArgs) Handles pbxMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
