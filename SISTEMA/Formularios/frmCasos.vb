Imports AccesoDatos

Public Class frmCasos
    Dim Transacciones_Casos As TransaccionesCasos
    Dim Transacciones_Fueros As TransaccionesFueros
    Dim Transacciones_Tipos As TransaccionesTipos
    Dim Transacciones_Camara As TransaccionesCamara
    Dim Transacciones_Tribunales As TransaccionesTribunales
    Dim Casos As List(Of Casos)
    Dim Fueros As List(Of Fueros)
    Dim Tipos As List(Of Tipos)
    Dim Camaras As List(Of Camara)
    Dim Tribunales As List(Of Tribunales)

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

        cbxInstancia.Enabled = True
        cbxFuero.Enabled = True
        cbxTipo.Enabled = True
        txtCausa.Enabled = True
        txtCaratula.Enabled = True
        txtExpediente.Enabled = True
        txtHecho.Enabled = True
        txtFecha.Enabled = True
        txtLink.Enabled = True
        txtBuscar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnSalir.BackColor = Color.FromArgb(35, 35, 35)

        txtBuscar.Text = ""

        UtilidadesDGV.DescargarDGV(dgvCasos)

        cbxInstancia.Select()
    End Sub

    Private Sub Cancelar()
        bnfLista.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True

        cbxInstancia.Enabled = False
        cbxFuero.Enabled = False
        cbxTipo.Enabled = False
        txtCausa.Enabled = False
        txtCaratula.Enabled = False
        txtExpediente.Enabled = False
        txtHecho.Enabled = False
        txtFecha.Enabled = False
        txtLink.Enabled = False
        txtBuscar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnSalir.BackColor = Color.FromArgb(100, 100, 100)

        cbxInstancia.Text = ""
        cbxInstancia.SelectedItem = Nothing
        cbxFuero.Text = ""
        cbxFuero.SelectedItem = Nothing
        cbxTipo.Text = ""
        cbxTipo.SelectedItem = Nothing
        txtCausa.Text = ""
        txtCaratula.Text = ""
        txtExpediente.Text = ""
        txtHecho.Text = ""
        txtFecha.Text = ""
        txtLink.Text = ""
        txtIdCaso.Text = ""
        txtIdFuero.Text = ""
        txtIdTipo.Text = ""
        txtBuscar.Text = ""

        txtOrigen.Text = ""

        CargarDGV()

        btnNuevo.Select()
    End Sub

    Private Sub ConfigDGV()
        dgvCasos.ColumnCount = 12
        dgvCasos.Columns(0).Name = "idCasos"
        dgvCasos.Columns(1).Name = "idFueros"
        dgvCasos.Columns(2).Name = "idTipos"
        dgvCasos.Columns(3).Name = "Instancia"
        dgvCasos.Columns(4).Name = "Tipo"
        dgvCasos.Columns(5).Name = "Fuero"
        dgvCasos.Columns(6).Name = "Causa"
        dgvCasos.Columns(7).Name = "Caratula"
        dgvCasos.Columns(8).Name = "NumeroExpediente"
        dgvCasos.Columns(9).Name = "HechosOrigen"
        dgvCasos.Columns(10).Name = "FechaPublicacion"
        dgvCasos.Columns(11).Name = "LinkCausa"

        dgvCasos.Columns("idCasos").Visible = False
        dgvCasos.Columns("idFueros").Visible = False
        dgvCasos.Columns("idTipos").Visible = False

        dgvCasos.Columns("Instancia").HeaderText = "INSTANCIA"
        dgvCasos.Columns("Tipo").HeaderText = "TIPO"
        dgvCasos.Columns("Fuero").HeaderText = "FUERO"
        dgvCasos.Columns("Causa").HeaderText = "CAUSA"
        dgvCasos.Columns("Caratula").HeaderText = "CARATULA"
        dgvCasos.Columns("NumeroExpediente").HeaderText = "N° EXPEDIENTE"
        dgvCasos.Columns("HechosOrigen").HeaderText = "HECHOS/ORIGEN"
        dgvCasos.Columns("FechaPublicacion").HeaderText = "FECHA PUBLIC."
        dgvCasos.Columns("LinkCausa").HeaderText = "LINK CAUSA"

        dgvCasos.Columns("idCasos").DisplayIndex = 0
        dgvCasos.Columns("idFueros").DisplayIndex = 1
        dgvCasos.Columns("idTipos").DisplayIndex = 2
        dgvCasos.Columns("Instancia").DisplayIndex = 3
        dgvCasos.Columns("Tipo").DisplayIndex = 4
        dgvCasos.Columns("Fuero").DisplayIndex = 5
        dgvCasos.Columns("Causa").DisplayIndex = 6
        dgvCasos.Columns("Caratula").DisplayIndex = 7
        dgvCasos.Columns("NumeroExpediente").DisplayIndex = 8
        dgvCasos.Columns("HechosOrigen").DisplayIndex = 9
        dgvCasos.Columns("FechaPublicacion").DisplayIndex = 10
        dgvCasos.Columns("LinkCausa").DisplayIndex = 11

        dgvCasos.Columns("Instancia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("Tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("Fuero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("Causa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("Caratula").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("NumeroExpediente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("HechosOrigen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCasos.Columns("FechaPublicacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCasos.Columns("LinkCausa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvCasos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarDGV()
        UtilidadesDGV.DescargarDGV(dgvCasos)

        Try
            Casos = Transacciones_Casos.verRegistros()

            If Not IsNothing(Casos) Then
                For Each Item In Casos
                    dgvCasos.Rows.Add(Item.idCasos, Item.ascFueros.idFueros, Item.ascTipos.idTipos, Item.Instancia, Item.ascTipos.DetalleTipo, Item.ascFueros.TipoFuero,
                                      Item.Causa, Item.Caratula, Item.NumeroExpediente, Item.HechosOrigen, Format(CDate(Item.FechaPublicacion), "dd/MM/yyyy"), Item.LinkCausa)
                Next

                UtilidadesDGV.CabeceraDGV(dgvCasos)
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub

    Private Sub CargarFueros()
        cbxFuero.Items.Clear()

        Try
            Fueros = Transacciones_Fueros.verRegistros()

            If Not IsNothing(Fueros) Then
                For Each item In Fueros
                    cbxFuero.Items.Add(item.TipoFuero)
                Next
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub

    Private Sub CargarTipos()
        cbxTipo.Items.Clear()

        Try
            Tipos = Transacciones_Tipos.verRegistros()

            If Not IsNothing(Tipos) Then
                For Each item In Tipos
                    cbxTipo.Items.Add(item.DetalleTipo)
                Next
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub

    Private Sub CargarInstancias()
        cbxInstancia.Items.Clear()

        Try
            Tribunales = Transacciones_Tribunales.verRegistros()
            Camaras = Transacciones_Camara.verRegistros()

            If Not IsNothing(Tribunales) Then
                For Each item In Tribunales
                    cbxInstancia.Items.Add(item.NombreTribunal)
                Next
            End If

            If Not IsNothing(Camaras) Then
                For Each item In Camaras
                    cbxInstancia.Items.Add(item.NombreCamara)
                Next
            End If

            cbxInstancia.Items.Add("Corte Suprema de Justicia de la Nación")
            cbxInstancia.Items.Add("Tribunal Superior de Justicia de la Provincia de Córdoba")
            cbxInstancia.Items.Add("Otros")
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
            Me.Close()
            Me.Hide()
        End Try
    End Sub
#End Region

#Region "EVENTOS LOAD"
    Private Sub frmCamara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtilidadesDGV.FormatoDGVGeneral(dgvCasos)

        ConfigDGV()

        Transacciones_Casos = New TransaccionesCasos
        Transacciones_Fueros = New TransaccionesFueros
        Transacciones_Tipos = New TransaccionesTipos
        Transacciones_Camara = New TransaccionesCamara
        Transacciones_Tribunales = New TransaccionesTribunales

        CargarInstancias()
        CargarFueros()
        CargarTipos()
        Cancelar()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cbxInstancia.Text = ""
        cbxInstancia.SelectedItem = Nothing
        cbxFuero.Text = ""
        cbxFuero.SelectedItem = Nothing
        cbxTipo.Text = ""
        cbxTipo.SelectedItem = Nothing
        txtCausa.Text = ""
        txtCaratula.Text = ""
        txtExpediente.Text = ""
        txtHecho.Text = ""
        txtFecha.Text = ""
        txtLink.Text = ""
        txtIdTipo.Text = ""
        txtIdFuero.Text = ""
        txtIdCaso.Text = ""

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
        If txtIdCaso.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Caso para modificar.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            Activar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdCaso.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Caso para eliminar.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Caso ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Try
                    If Transacciones_Casos.elimRegistro(txtIdCaso.Text) > 0 Then
                        Notificaciones.MsgBox("Caso eliminado con exito !", Botones.OK, Iconos.OK)
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
        If cbxInstancia.Text = "" Then
            Notificaciones.MsgBox("El campo ""INSTANCIA"" es obligatorio.", Botones.OK, Iconos.ERR)
            cbxInstancia.Select()
        Else
            If txtIdTipo.Text = "" Then
                Notificaciones.MsgBox("El campo ""TIPO"" es obligatorio.", Botones.OK, Iconos.ERR)
                cbxTipo.Select()
            Else
                If txtIdFuero.Text = "" Then
                    Notificaciones.MsgBox("El campo ""FUERO"" es obligatorio.", Botones.OK, Iconos.ERR)
                    cbxFuero.Select()
                Else
                    If txtCausa.Text = "" Then
                        Notificaciones.MsgBox("El campo ""CAUSA"" es obligatorio.", Botones.OK, Iconos.ERR)
                        txtCausa.Select()
                    Else
                        If txtCaratula.Text = "" Then
                            Notificaciones.MsgBox("El campo ""CARATULA"" es obligatorio.", Botones.OK, Iconos.ERR)
                            txtCaratula.Select()
                        Else
                            If txtExpediente.Text = "" Then
                                Notificaciones.MsgBox("El campo ""N° EXPEDIENTE"" es obligatorio.", Botones.OK, Iconos.ERR)
                                txtExpediente.Select()
                            Else
                                If txtHecho.Text = "" Then
                                    Notificaciones.MsgBox("El campo ""HECHOS/ORIGEN"" es obligatorio.", Botones.OK, Iconos.ERR)
                                    txtHecho.Select()
                                Else
                                    If txtFecha.Text = "" Then
                                        Notificaciones.MsgBox("El campo ""FECHA PUBLIC."" es obligatorio.", Botones.OK, Iconos.ERR)
                                        txtFecha.Select()
                                    Else
                                        If txtLink.Text = "" Then
                                            Notificaciones.MsgBox("El campo ""LINK CAUSA"" es obligatorio.", Botones.OK, Iconos.ERR)
                                            txtLink.Select()
                                        Else
                                            Dim datos As New Casos With {
                                                .Instancia = cbxInstancia.Text,
                                                .Causa = txtCausa.Text,
                                                .Caratula = txtCaratula.Text,
                                                .NumeroExpediente = txtExpediente.Text,
                                                .HechosOrigen = txtHecho.Text,
                                                .FechaPublicacion = txtFecha.Text,
                                                .LinkCausa = txtLink.Text,
                                                .ascFueros = New Fueros With {.idFueros = txtIdFuero.Text},
                                                .ascTipos = New Tipos With {.idTipos = txtIdTipo.Text}
                                            }

                                            If txtOrigen.Text = "Nuevo" Then
                                                Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Caso ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                                If resp = DialogResult.OK Then
                                                    Try
                                                        If Transacciones_Casos.insRegistro(datos) > 0 Then
                                                            Notificaciones.MsgBox("Caso guardado con exito !", Botones.OK, Iconos.OK)
                                                            Cancelar()
                                                        Else
                                                            Notificaciones.MsgBox("Error en la carga de datos", Botones.OK, Iconos.ERR)
                                                        End If
                                                    Catch ex As Exception
                                                        Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
                                                    End Try
                                                End If
                                            Else
                                                Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Caso ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                                If resp = DialogResult.OK Then
                                                    datos.idCasos = txtIdCaso.Text

                                                    Try
                                                        If Transacciones_Casos.modRegistro(datos) > 0 Then
                                                            Notificaciones.MsgBox("Caso modificado con exito !", Botones.OK, Iconos.OK)
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
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvCasos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCasos.CellClick
        If e.RowIndex > -1 Then
            txtIdCaso.Text = dgvCasos.CurrentRow.Cells("idCasos").Value
            txtIdTipo.Text = dgvCasos.CurrentRow.Cells("idTipos").Value
            txtIdFuero.Text = dgvCasos.CurrentRow.Cells("idFueros").Value

            For Each item As String In cbxInstancia.Items
                If item = dgvCasos.CurrentRow.Cells("Instancia").Value Then
                    cbxInstancia.SelectedItem = dgvCasos.CurrentRow.Cells("Instancia").Value
                End If
            Next

            If cbxInstancia.Text = "" Then
                cbxInstancia.Text = dgvCasos.CurrentRow.Cells("Instancia").Value
            End If

            cbxTipo.SelectedItem = dgvCasos.CurrentRow.Cells("Tipo").Value
            cbxFuero.SelectedItem = dgvCasos.CurrentRow.Cells("Fuero").Value
            txtCausa.Text = dgvCasos.CurrentRow.Cells("Causa").Value
            txtCaratula.Text = dgvCasos.CurrentRow.Cells("Caratula").Value
            txtExpediente.Text = dgvCasos.CurrentRow.Cells("NumeroExpediente").Value
            txtHecho.Text = dgvCasos.CurrentRow.Cells("HechosOrigen").Value
            txtFecha.Text = dgvCasos.CurrentRow.Cells("FechaPublicacion").Value
            txtLink.Text = dgvCasos.CurrentRow.Cells("LinkCausa").Value

            btnModificar.Select()
        Else
            dgvCasos.CurrentCell = Nothing

            cbxInstancia.Text = ""
            cbxInstancia.SelectedItem = Nothing
            cbxFuero.Text = ""
            cbxFuero.SelectedItem = Nothing
            cbxTipo.Text = ""
            cbxTipo.SelectedItem = Nothing
            txtCausa.Text = ""
            txtCaratula.Text = ""
            txtExpediente.Text = ""
            txtHecho.Text = ""
            txtFecha.Text = ""
            txtLink.Text = ""
            txtIdTipo.Text = ""
            txtIdFuero.Text = ""
            txtIdCaso.Text = ""
        End If
    End Sub

    Private Sub opdExplorar_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opdExplorar.FileOk
        Try
            txtLink.Text = opdExplorar.FileName

            txtLink.SelectionLength = Len(txtLink.Text)
        Catch
            Notificaciones.MsgBox("El formato del archivo no es compatible con el sistema.", Botones.OK, Iconos.ERR)
        End Try
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFec_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If txtFecha.Text <> "" Then
            If Not IsDate(txtFecha.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)

                txtFecha.Text = ""
            Else
                txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Casos)

        UtilidadesDGV.DescargarDGV(dgvCasos)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Casos)(Casos, "Caratula", txtBuscar.Text)
        Else
            listFiltrada = Casos
        End If

        For Each Item In listFiltrada
            dgvCasos.Rows.Add(Item.idCasos, Item.ascFueros.idFueros, Item.ascTipos.idTipos, Item.Instancia, Item.ascTipos.DetalleTipo, Item.ascFueros.TipoFuero,
                              Item.Causa, Item.Caratula, Item.NumeroExpediente, Item.HechosOrigen, Format(CDate(Item.FechaPublicacion), "dd/MM/yyyy"), Item.LinkCausa)
        Next

        UtilidadesDGV.CabeceraDGV(dgvCasos)
    End Sub

    Private Sub cbxFuero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFuero.SelectedIndexChanged
        txtIdFuero.Text = ""

        If cbxFuero.Text <> "" Then
            For Each item In Fueros
                If item.TipoFuero = cbxFuero.Text Then
                    txtIdFuero.Text = item.idFueros
                End If
            Next
        End If
    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        txtIdTipo.Text = ""

        If cbxTipo.Text <> "" Then
            For Each item In Tipos
                If item.DetalleTipo = cbxTipo.Text Then
                    txtIdTipo.Text = item.idTipos
                End If
            Next
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub cbxInstancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxInstancia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cbxTipo.SelectionLength = Len(cbxTipo.Text)
            cbxTipo.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cbxFuero.SelectionLength = Len(cbxFuero.Text)
            cbxFuero.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            txtIdTipo.Text = ""
        End If
    End Sub

    Private Sub cbxFuero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxFuero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCausa.SelectionLength = Len(txtCausa.TextLength)
            txtCausa.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            txtIdFuero.Text = ""
        End If
    End Sub

    Private Sub txtCausa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCausa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCaratula.SelectionLength = Len(txtCaratula.Text)
            txtCaratula.Select()
        End If
    End Sub

    Private Sub txtCaratula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaratula.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtExpediente.SelectionLength = Len(txtExpediente.Text)
            txtExpediente.Select()
        End If
    End Sub

    Private Sub txtExpediente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpediente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtHecho.SelectionLength = Len(txtHecho.Text)
            txtHecho.Select()
        End If
    End Sub

    Private Sub txtHecho_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHecho.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Select()
        End If
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtLink.SelectionLength = Len(txtLink.Text)
            txtLink.Select()
        End If
    End Sub

    Private Sub txtLink_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLink.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtLink.Text = "" Then
                opdExplorar.Filter = "Archivos de texto (*.pdf; *.txt; *.docx; *.doc; *.docm; *.dotx; *.dotm; *.dot)|*.PDF; *.TXT; *.DOCX; *.DOC; *.DOCM; *.DOTX; *.DOTM; *.DOT"
                opdExplorar.ShowDialog()
            Else
                btnGuardar.Select()
            End If
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class