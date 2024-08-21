Imports AccesoDatos

Public Class frmTipos
    Dim Transacciones As TransaccionesTipos
    Dim Tipos As List(Of Tipos)

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

        txtTipo.Enabled = True
        txtBuscar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnSalir.BackColor = Color.FromArgb(35, 35, 35)

        txtBuscar.Text = ""

        UtilidadesDGV.DescargarDGV(dgvTipo)

        txtTipo.Select()
    End Sub

    Private Sub Cancelar()
        bnfLista.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True

        txtTipo.Enabled = False
        txtBuscar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnSalir.BackColor = Color.FromArgb(100, 100, 100)

        txtTipo.Text = ""
        txtTipoAnt.Text = ""
        txtIdTipo.Text = ""
        txtBuscar.Text = ""

        txtOrigen.Text = ""

        CargarDGV()

        btnNuevo.Select()
    End Sub

    Private Sub ConfigDGV()
        dgvTipo.ColumnCount = 2
        dgvTipo.Columns(0).Name = "idTipos"
        dgvTipo.Columns(1).Name = "DetalleTipo"

        dgvTipo.Columns("idTipos").Visible = False

        dgvTipo.Columns("DetalleTipo").HeaderText = "NOMBRE"

        dgvTipo.Columns("idTipos").DisplayIndex = 0
        dgvTipo.Columns("DetalleTipo").DisplayIndex = 1

        dgvTipo.Columns("DetalleTipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarDGV()
        UtilidadesDGV.DescargarDGV(dgvTipo)

        Try
            Tipos = Transacciones.verRegistros()

            If Not IsNothing(Tipos) Then
                For Each Item In Tipos
                    dgvTipo.Rows.Add(Item.idTipos, Item.DetalleTipo)
                Next

                UtilidadesDGV.CabeceraDGV(dgvTipo)
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub
#End Region

#Region "EVENTOS LOAD"
    Private Sub frmTipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtilidadesDGV.FormatoDGVGeneral(dgvTipo)

        ConfigDGV()

        Transacciones = New TransaccionesTipos

        Cancelar()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTipo.Text = ""
        txtIdTipo.Text = ""
        txtTipoAnt.Text = ""

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
        If txtIdTipo.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Tipo para modificar.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            Activar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdTipo.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Tipo para eliminar.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Tipo ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Try
                    If Transacciones.elimRegistro(txtIdTipo.Text) > 0 Then
                        Notificaciones.MsgBox("Tipo eliminado con exito !", Botones.OK, Iconos.OK)
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
        If txtTipo.Text = "" Then
            Notificaciones.MsgBox("El campo ""TIPO"" es obligatorio.", Botones.OK, Iconos.ERR)
            txtTipo.Select()
        Else
            Dim exs As Boolean = False

            If Not IsNothing(Tipos) Then
                For Each item In Tipos
                    If UCase(item.DetalleTipo) = UCase(txtTipo.Text) And UCase(txtTipo.Text) <> UCase(txtTipoAnt.Text) Then
                        exs = True
                        Exit For
                    End If
                Next
            End If

            If exs Then
                Notificaciones.MsgBox("Ya existe un Tipo con ese nombre.", Botones.OK, Iconos.ERR)
                txtTipo.Select()
            Else
                Dim datos As New Tipos With {
                    .DetalleTipo = txtTipo.Text
                }

                If txtOrigen.Text = "Nuevo" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Tipo ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Try
                            If Transacciones.insRegistro(datos) > 0 Then
                                Notificaciones.MsgBox("Tipo guardado con exito !", Botones.OK, Iconos.OK)
                                Cancelar()
                            Else
                                Notificaciones.MsgBox("Error en la carga de datos", Botones.OK, Iconos.ERR)
                            End If
                        Catch ex As Exception
                            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
                        End Try
                    End If
                Else
                    Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Tipo ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        datos.idTipos = txtIdTipo.Text

                        Try
                            If Transacciones.modRegistro(datos) > 0 Then
                                Notificaciones.MsgBox("Tipo modificado con exito !", Botones.OK, Iconos.OK)
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
    End Sub

    Private Sub dgvTipo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        If e.RowIndex > -1 Then
            txtIdTipo.Text = dgvTipo.CurrentRow.Cells("idTipos").Value
            txtTipo.Text = dgvTipo.CurrentRow.Cells("DetalleTipo").Value
            txtTipoAnt.Text = txtTipo.Text

            btnModificar.Select()
        Else
            dgvTipo.CurrentCell = Nothing

            txtTipo.Text = ""
            txtIdTipo.Text = ""
            txtTipoAnt.Text = ""
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Tipos)

        UtilidadesDGV.DescargarDGV(dgvTipo)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Tipos)(Tipos, "DetalleTipo", txtBuscar.Text)
        Else
            listFiltrada = Tipos
        End If

        For Each Item In listFiltrada
            dgvTipo.Rows.Add(Item.idTipos, Item.DetalleTipo)
        Next

        UtilidadesDGV.CabeceraDGV(dgvTipo)
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnGuardar.Select()
        End If
    End Sub
#End Region

End Class