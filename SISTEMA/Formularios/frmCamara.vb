Imports AccesoDatos

Public Class frmCamara
    Dim Transacciones As TransaccionesCamara
    Dim Camaras As List(Of Camara)

#Region "ANIMACION BOTONES"
    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs) Handles btnNuevo.GotFocus
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnNuevo_LostFocus(sender As Object, e As EventArgs) Handles btnNuevo.LostFocus
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevo.MouseEnter
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs) Handles btnModificar.GotFocus
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnModificar_LostFocus(sender As Object, e As EventArgs) Handles btnModificar.LostFocus
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs) Handles btnModificar.MouseEnter
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_GotFocus(sender As Object, e As EventArgs) Handles btnGuardar.GotFocus
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnGuardar_LostFocus(sender As Object, e As EventArgs) Handles btnGuardar.LostFocus
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_GotFocus(sender As Object, e As EventArgs) Handles btnCancelar.GotFocus
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnCancelar_LostFocus(sender As Object, e As EventArgs) Handles btnCancelar.LostFocus
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelar.MouseEnter
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnEliminar_GotFocus(sender As Object, e As EventArgs) Handles btnEliminar.GotFocus
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnEliminar_LostFocus(sender As Object, e As EventArgs) Handles btnEliminar.LostFocus
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminarr_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnSalir_GotFocus(sender As Object, e As EventArgs) Handles btnSalir.GotFocus
        If btnSalir.Enabled = True Then
            btnSalir.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnSalir_LostFocus(sender As Object, e As EventArgs) Handles btnSalir.LostFocus
        If btnSalir.Enabled = True Then
            btnSalir.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnSalir_MouseEnter(sender As Object, e As EventArgs) Handles btnSalir.MouseEnter
        If btnSalir.Enabled = True Then
            btnSalir.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        If btnSalir.Enabled = True Then
            btnSalir.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        btnSalir.Enabled = False

        txtNombre.Enabled = True
        txtDireccion.Enabled = True
        txtLocalidad.Enabled = True
        txtCP.Enabled = True
        txtProvincia.Enabled = True
        txtBuscar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnSalir.BackColor = Color.FromArgb(35, 35, 35)

        txtBuscar.Text = ""

        UtilidadesDGV.DescargarDGV(dgvCamara)

        txtNombre.Select()
    End Sub

    Private Sub Cancelar()
        bnfLista.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True

        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        txtLocalidad.Enabled = False
        txtCP.Enabled = False
        txtProvincia.Enabled = False
        txtBuscar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnSalir.BackColor = Color.FromArgb(100, 100, 100)

        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtLocalidad.Text = ""
        txtCP.Text = ""
        txtProvincia.Text = ""
        txtIdCamara.Text = ""
        txtBuscar.Text = ""

        txtOrigen.Text = ""

        CargarDGV()

        btnNuevo.Select()
    End Sub

    Private Sub ConfigDGV()
        dgvCamara.ColumnCount = 6
        dgvCamara.Columns(0).Name = "idCamara"
        dgvCamara.Columns(1).Name = "NombreCamara"
        dgvCamara.Columns(2).Name = "Direccion"
        dgvCamara.Columns(3).Name = "Localidad"
        dgvCamara.Columns(4).Name = "CP"
        dgvCamara.Columns(5).Name = "Provincia"

        dgvCamara.Columns("idCamara").Visible = False

        dgvCamara.Columns("NombreCamara").HeaderText = "NOMBRE"
        dgvCamara.Columns("Direccion").HeaderText = "DIRECCION"
        dgvCamara.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvCamara.Columns("Provincia").HeaderText = "PROVINCIA"
        dgvCamara.Columns("CP").HeaderText = "COD POSTAL"

        dgvCamara.Columns("idCamara").DisplayIndex = 0
        dgvCamara.Columns("NombreCamara").DisplayIndex = 1
        dgvCamara.Columns("Direccion").DisplayIndex = 2
        dgvCamara.Columns("Localidad").DisplayIndex = 3
        dgvCamara.Columns("CP").DisplayIndex = 4
        dgvCamara.Columns("Provincia").DisplayIndex = 5

        dgvCamara.Columns("NombreCamara").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCamara.Columns("Direccion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCamara.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCamara.Columns("Provincia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCamara.Columns("CP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvCamara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarDGV()
        UtilidadesDGV.DescargarDGV(dgvCamara)

        Try
            Camaras = Transacciones.verRegistros()

            If Not IsNothing(Camaras) Then
                For Each Item In Camaras
                    dgvCamara.Rows.Add(Item.idCamara, Item.NombreCamara, Item.Direccion, Item.Localidad, Item.CP, Item.Provincia)
                Next

                UtilidadesDGV.CabeceraDGV(dgvCamara)
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub
#End Region

#Region "EVENTOS LOAD"
    Private Sub frmCamara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtilidadesDGV.FormatoDGVGeneral(dgvCamara)

        ConfigDGV()

        Transacciones = New TransaccionesCamara

        Cancelar()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtLocalidad.Text = ""
        txtCP.Text = ""
        txtProvincia.Text = ""
        txtIdCamara.Text = ""

        txtOrigen.Text = "Nuevo"

        Activar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmPPal.AbrirFrm(New frmInicio)

        Me.Close()
        Me.Hide()
    End Sub

    Private Sub bnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdCamara.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado una Camara para modificar.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            Activar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdCamara.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado una Camara para eliminar.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Camara ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Try
                    If Transacciones.elimRegistro(txtIdCamara.Text) > 0 Then
                        Notificaciones.MsgBox("Camara eliminada con exito !", Botones.OK, Iconos.OK)
                        Cancelar()
                    Else
                        Notificaciones.MsgBox("Error al eliminar los datos", Botones.OK, Iconos.ERR)
                    End If
                Catch ex As Exception
                    Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
                End Try
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            Notificaciones.MsgBox("El campo ""CAMARA"" es obligatorio.", Botones.OK, Iconos.ERR)
            txtNombre.Select()
        Else
            If txtDireccion.Text = "" Then
                Notificaciones.MsgBox("El campo ""DIRECCION"" es obligatorio.", Botones.OK, Iconos.ERR)
                txtDireccion.Select()
            Else
                If txtLocalidad.Text = "" Then
                    Notificaciones.MsgBox("El campo ""LOCALIDAD"" es obligatorio.", Botones.OK, Iconos.ERR)
                    txtLocalidad.Select()
                Else
                    If txtCP.Text = "" Then
                        Notificaciones.MsgBox("El campo ""COD. POSTAL"" es obligatorio.", Botones.OK, Iconos.ERR)
                        txtCP.Select()
                    Else
                        If txtProvincia.Text = "" Then
                            Notificaciones.MsgBox("El campo ""PROVINCIA"" es obligatorio.", Botones.OK, Iconos.ERR)
                            txtProvincia.Select()
                        Else
                            Dim datos As New Camara With {
                                .NombreCamara = txtNombre.Text,
                                .Direccion = txtDireccion.Text,
                                .Localidad = txtLocalidad.Text,
                                .CP = txtCP.Text,
                                .Provincia = txtProvincia.Text
                            }

                            If txtOrigen.Text = "Nuevo" Then
                                Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Camara ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                If resp = DialogResult.OK Then
                                    Try
                                        If Transacciones.insRegistro(datos) > 0 Then
                                            Notificaciones.MsgBox("Camara guardada con exito !", Botones.OK, Iconos.OK)
                                            Cancelar()
                                        Else
                                            Notificaciones.MsgBox("Error en la carga de datos", Botones.OK, Iconos.ERR)
                                        End If
                                    Catch ex As Exception
                                        Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
                                    End Try
                                End If
                            Else
                                Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Camara ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                If resp = DialogResult.OK Then
                                    datos.idCamara = txtIdCamara.Text

                                    Try
                                        If Transacciones.modRegistro(datos) > 0 Then
                                            Notificaciones.MsgBox("Camara modificada con exito !", Botones.OK, Iconos.OK)
                                            Cancelar()
                                        Else
                                            Notificaciones.MsgBox("Error en la carga de datos", Botones.OK, Iconos.ERR)
                                        End If
                                    Catch ex As Exception
                                        Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
                                    End Try
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvCamara_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCamara.CellClick
        If e.RowIndex > -1 Then
            txtIdCamara.Text = dgvCamara.CurrentRow.Cells("idCamara").Value
            txtNombre.Text = dgvCamara.CurrentRow.Cells("NombreCamara").Value
            txtDireccion.Text = dgvCamara.CurrentRow.Cells("Direccion").Value
            txtLocalidad.Text = dgvCamara.CurrentRow.Cells("Localidad").Value
            txtCP.Text = dgvCamara.CurrentRow.Cells("CP").Value
            txtProvincia.Text = dgvCamara.CurrentRow.Cells("Provincia").Value

            btnModificar.Select()
        Else
            dgvCamara.CurrentCell = Nothing

            txtNombre.Text = ""
            txtDireccion.Text = ""
            txtLocalidad.Text = ""
            txtCP.Text = ""
            txtProvincia.Text = ""
            txtIdCamara.Text = ""
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Camara)

        UtilidadesDGV.DescargarDGV(dgvCamara)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Camara)(Camaras, "NombreCamara", txtBuscar.Text)
        Else
            listFiltrada = Camaras
        End If

        For Each Item In listFiltrada
            dgvCamara.Rows.Add(Item.idCamara, Item.NombreCamara, Item.Direccion, Item.Localidad, Item.CP, Item.Provincia)
        Next

        UtilidadesDGV.CabeceraDGV(dgvCamara)
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtDireccion.SelectionLength = Len(txtDireccion.Text)
            txtDireccion.Select()
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtLocalidad.SelectionLength = Len(txtLocalidad.Text)
            txtLocalidad.Select()
        End If
    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCP.SelectionLength = Len(txtCP.Text)
            txtCP.Select()
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtProvincia.SelectionLength = Len(txtProvincia.Text)
            txtProvincia.Select()
        End If
    End Sub

    Private Sub txtProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProvincia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnGuardar.Select()
        End If
    End Sub
#End Region
End Class