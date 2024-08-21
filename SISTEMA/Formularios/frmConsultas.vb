Imports AccesoDatos

Public Class frmConsultas
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
    Private Sub btnLimpiar_GotFocus(sender As Object, e As EventArgs) Handles btnLimpiar.GotFocus
        If btnLimpiar.Enabled = True Then
            btnLimpiar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnLimpiar_LostFocus(sender As Object, e As EventArgs) Handles btnLimpiar.LostFocus
        If btnLimpiar.Enabled = True Then
            btnLimpiar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnLimpiar_MouseEnter(sender As Object, e As EventArgs) Handles btnLimpiar.MouseEnter
        If btnLimpiar.Enabled = True Then
            btnLimpiar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles btnLimpiar.MouseLeave
        If btnLimpiar.Enabled = True Then
            btnLimpiar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnAbrir_GotFocus(sender As Object, e As EventArgs) Handles btnAbrir.GotFocus
        If btnAbrir.Enabled = True Then
            btnAbrir.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnAbrir_LostFocus(sender As Object, e As EventArgs) Handles btnAbrir.LostFocus
        If btnAbrir.Enabled = True Then
            btnAbrir.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnAbrir_MouseEnter(sender As Object, e As EventArgs) Handles btnAbrir.MouseEnter
        If btnAbrir.Enabled = True Then
            btnAbrir.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnAbrir_MouseLeave(sender As Object, e As EventArgs) Handles btnAbrir.MouseLeave
        If btnAbrir.Enabled = True Then
            btnAbrir.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnConsultar_GotFocus(sender As Object, e As EventArgs) Handles btnConsultar.GotFocus
        If btnConsultar.Enabled = True Then
            btnConsultar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnConsultar_LostFocus(sender As Object, e As EventArgs) Handles btnConsultar.LostFocus
        If btnConsultar.Enabled = True Then
            btnConsultar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnConsultar_MouseEnter(sender As Object, e As EventArgs) Handles btnConsultar.MouseEnter
        If btnConsultar.Enabled = True Then
            btnConsultar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnConsultar_MouseLeave(sender As Object, e As EventArgs) Handles btnConsultar.MouseLeave
        If btnConsultar.Enabled = True Then
            btnConsultar.BackColor = Color.FromArgb(100, 100, 100)
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
        dgvCasos.Columns("LinkCausa").Visible = False

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

                UtilidadesDGV.CabeceraDGV(dgvCasos, DataGridViewAutoSizeColumnsMode.DisplayedCells)
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

#Region "LOAD"
    Private Sub frmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtilidadesDGV.FormatoDGVGeneral(dgvCasos)

        ConfigDGV()

        Transacciones_Casos = New TransaccionesCasos
        Transacciones_Fueros = New TransaccionesFueros
        Transacciones_Tipos = New TransaccionesTipos
        Transacciones_Camara = New TransaccionesCamara
        Transacciones_Tribunales = New TransaccionesTribunales

        btnAbrir.BackColor = Color.FromArgb(35, 35, 35)
        btnAbrir.Enabled = False

        CargarInstancias()
        CargarFueros()
        CargarTipos()
        CargarDGV()

        txtFecDesde.Select()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            If txtLink.Text <> "" Then
                Process.Start(txtLink.Text)
            Else
                Notificaciones.MsgBox("No seleccionaste ningun archivo para abrir.", Botones.OK, Iconos.ALERTA)
            End If
        Catch ex As Exception
            Notificaciones.MsgBox(ex.Message, Botones.OK, Iconos.ERR)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cbxInstancia.Text = ""
        cbxInstancia.SelectedItem = Nothing
        cbxFuero.Text = ""
        cbxFuero.SelectedItem = Nothing
        cbxTipo.Text = ""
        cbxTipo.SelectedItem = Nothing
        txtCausa.Text = ""
        txtCaratula.Text = ""
        txtExpediente.Text = ""
        lblHecho.Text = ""
        txtFecDesde.Text = ""
        txtFecHasta.Text = ""
        txtLink.Text = ""

        lblInstancia.Text = ""
        lblFuero.Text = ""
        lblTipo.Text = ""
        lblCausa.Text = ""
        lblCaratula.Text = ""
        lblExpediente.Text = ""
        lblHecho.Text = ""
        lblFecha.Text = ""
        txtLink.Text = ""

        btnAbrir.BackColor = Color.FromArgb(35, 35, 35)
        btnAbrir.Enabled = False

        UtilidadesDGV.DescargarDGV(dgvCasos)

        For Each Item In Casos
            dgvCasos.Rows.Add(Item.idCasos, Item.ascFueros.idFueros, Item.ascTipos.idTipos, Item.Instancia, Item.ascTipos.DetalleTipo, Item.ascFueros.TipoFuero,
                                      Item.Causa, Item.Caratula, Item.NumeroExpediente, Item.HechosOrigen, Format(CDate(Item.FechaPublicacion), "dd/MM/yyyy"), Item.LinkCausa)
        Next

        UtilidadesDGV.CabeceraDGV(dgvCasos, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmPPal.AbrirFrm(New frmInicio)

        Me.Close()
        Me.Hide()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        UtilidadesDGV.DescargarDGV(dgvCasos)

        For Each Item In Casos
            If UCase(Item.ascFueros.TipoFuero).Contains(UCase(cbxFuero.Text)) And UCase(Item.Instancia).Contains(UCase(cbxInstancia.Text)) And UCase(Item.ascTipos.DetalleTipo).Contains(UCase(cbxTipo.Text)) And UCase(Item.Causa).Contains(UCase(txtCausa.Text)) And UCase(Item.Caratula).Contains(UCase(txtCaratula.Text)) And UCase(Item.NumeroExpediente).Contains(UCase(txtExpediente.Text)) And UCase(Item.HechosOrigen).Contains(UCase(txtHechos.Text)) Then
                Dim Agg As Boolean = True

                If txtFecDesde.Text <> "" Then
                    If Item.FechaPublicacion < txtFecDesde.Text Then
                        Agg = False
                    End If
                End If

                If txtFecHasta.Text <> "" Then
                    If Item.FechaPublicacion > txtFecHasta.Text Then
                        Agg = False
                    End If
                End If

                If Agg Then
                    dgvCasos.Rows.Add(Item.idCasos, Item.ascFueros.idFueros, Item.ascTipos.idTipos, Item.Instancia, Item.ascTipos.DetalleTipo, Item.ascFueros.TipoFuero,
                                  Item.Causa, Item.Caratula, Item.NumeroExpediente, Item.HechosOrigen, Format(CDate(Item.FechaPublicacion), "dd/MM/yyyy"), Item.LinkCausa)
                End If
            End If
        Next

        UtilidadesDGV.CabeceraDGV(dgvCasos, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub

    Private Sub dgvCasos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCasos.CellClick
        If e.RowIndex > -1 Then
            lblInstancia.Text = dgvCasos.CurrentRow.Cells("Instancia").Value
            lblTipo.Text = dgvCasos.CurrentRow.Cells("Tipo").Value
            lblFuero.Text = dgvCasos.CurrentRow.Cells("Fuero").Value
            lblCausa.Text = dgvCasos.CurrentRow.Cells("Causa").Value
            lblCaratula.Text = dgvCasos.CurrentRow.Cells("Caratula").Value
            lblExpediente.Text = dgvCasos.CurrentRow.Cells("NumeroExpediente").Value
            lblHecho.Text = dgvCasos.CurrentRow.Cells("HechosOrigen").Value
            lblFecha.Text = dgvCasos.CurrentRow.Cells("FechaPublicacion").Value
            txtLink.Text = dgvCasos.CurrentRow.Cells("LinkCausa").Value

            btnAbrir.BackColor = Color.FromArgb(100, 100, 100)
            btnAbrir.Enabled = True

            btnAbrir.Select()
        Else
            dgvCasos.CurrentCell = Nothing

            lblInstancia.Text = ""
            lblFuero.Text = ""
            lblTipo.Text = ""
            lblCausa.Text = ""
            lblCaratula.Text = ""
            lblExpediente.Text = ""
            lblHecho.Text = ""
            lblFecha.Text = ""
            txtLink.Text = ""

            btnAbrir.BackColor = Color.FromArgb(35, 35, 35)
            btnAbrir.Enabled = False
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFecDesde_Validated(sender As Object, e As EventArgs) Handles txtFecDesde.Validated
        If txtFecDesde.Text <> "" Then
            If Not IsDate(txtFecDesde.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)

                txtFecDesde.Text = ""
            Else
                txtFecDesde.Text = Format(CDate(txtFecDesde.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtFecHas_Validated(sender As Object, e As EventArgs) Handles txtFecHasta.Validated
        If txtFecHasta.Text <> "" Then
            If Not IsDate(txtFecHasta.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)

                txtFecHasta.Text = ""
            Else
                txtFecHasta.Text = Format(CDate(txtFecHasta.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFecDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecDesde.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        End If
    End Sub

    Private Sub txtFecHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecHasta.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cbxInstancia.SelectionLength = Len(cbxInstancia.Text)
            cbxInstancia.Select()
        End If
    End Sub

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
        End If
    End Sub

    Private Sub cbxFuero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxFuero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCausa.SelectionLength = Len(txtCausa.TextLength)
            txtCausa.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
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

            txtHechos.SelectionLength = Len(txtHechos.Text)
            txtHechos.Select()
        End If
    End Sub

    Private Sub txtHechos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHechos.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnConsultar.Select()
        End If
    End Sub
#End Region
End Class