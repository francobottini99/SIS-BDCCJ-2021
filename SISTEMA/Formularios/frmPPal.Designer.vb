<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPPal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPPal))
        Me.pnlLateral = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnCasos = New System.Windows.Forms.Button()
        Me.btnCamara = New System.Windows.Forms.Button()
        Me.btnTipos = New System.Windows.Forms.Button()
        Me.btnFueros = New System.Windows.Forms.Button()
        Me.btnTribunal = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxMin = New System.Windows.Forms.PictureBox()
        Me.lblFrmActual = New System.Windows.Forms.Label()
        Me.pbxMax = New System.Windows.Forms.PictureBox()
        Me.pbxRest = New System.Windows.Forms.PictureBox()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLateral.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBarraTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlLateral.Controls.Add(Me.btnSalir)
        Me.pnlLateral.Controls.Add(Me.btnConsultas)
        Me.pnlLateral.Controls.Add(Me.btnCasos)
        Me.pnlLateral.Controls.Add(Me.btnCamara)
        Me.pnlLateral.Controls.Add(Me.btnTipos)
        Me.pnlLateral.Controls.Add(Me.btnFueros)
        Me.pnlLateral.Controls.Add(Me.btnTribunal)
        Me.pnlLateral.Controls.Add(Me.pnlLogo)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 0)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(220, 646)
        Me.pnlLateral.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Orchid
        Me.btnSalir.Image = Global.BDCCJ.My.Resources.Resources.IconoSalir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 541)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(220, 60)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConsultas
        '
        Me.btnConsultas.FlatAppearance.BorderSize = 0
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.ForeColor = System.Drawing.Color.Orchid
        Me.btnConsultas.Image = Global.BDCCJ.My.Resources.Resources.IconoConsultas
        Me.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Location = New System.Drawing.Point(0, 476)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConsultas.Size = New System.Drawing.Size(220, 60)
        Me.btnConsultas.TabIndex = 6
        Me.btnConsultas.Text = "CONSULTAS"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnCasos
        '
        Me.btnCasos.FlatAppearance.BorderSize = 0
        Me.btnCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCasos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCasos.ForeColor = System.Drawing.Color.Orchid
        Me.btnCasos.Image = Global.BDCCJ.My.Resources.Resources.iconoAltas
        Me.btnCasos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCasos.Location = New System.Drawing.Point(0, 410)
        Me.btnCasos.Name = "btnCasos"
        Me.btnCasos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCasos.Size = New System.Drawing.Size(220, 60)
        Me.btnCasos.TabIndex = 5
        Me.btnCasos.Text = "CASOS"
        Me.btnCasos.UseVisualStyleBackColor = True
        '
        'btnCamara
        '
        Me.btnCamara.FlatAppearance.BorderSize = 0
        Me.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCamara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamara.ForeColor = System.Drawing.Color.Orchid
        Me.btnCamara.Image = Global.BDCCJ.My.Resources.Resources.IconoBanco
        Me.btnCamara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCamara.Location = New System.Drawing.Point(0, 212)
        Me.btnCamara.Name = "btnCamara"
        Me.btnCamara.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCamara.Size = New System.Drawing.Size(220, 60)
        Me.btnCamara.TabIndex = 4
        Me.btnCamara.Text = "CAMARAS"
        Me.btnCamara.UseVisualStyleBackColor = True
        '
        'btnTipos
        '
        Me.btnTipos.FlatAppearance.BorderSize = 0
        Me.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipos.ForeColor = System.Drawing.Color.Orchid
        Me.btnTipos.Image = Global.BDCCJ.My.Resources.Resources.IconoCategorias
        Me.btnTipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipos.Location = New System.Drawing.Point(0, 278)
        Me.btnTipos.Name = "btnTipos"
        Me.btnTipos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnTipos.Size = New System.Drawing.Size(220, 60)
        Me.btnTipos.TabIndex = 3
        Me.btnTipos.Text = "TIPOS"
        Me.btnTipos.UseVisualStyleBackColor = True
        '
        'btnFueros
        '
        Me.btnFueros.FlatAppearance.BorderSize = 0
        Me.btnFueros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFueros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFueros.ForeColor = System.Drawing.Color.Orchid
        Me.btnFueros.Image = Global.BDCCJ.My.Resources.Resources.IconoNota
        Me.btnFueros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFueros.Location = New System.Drawing.Point(-1, 344)
        Me.btnFueros.Name = "btnFueros"
        Me.btnFueros.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnFueros.Size = New System.Drawing.Size(220, 60)
        Me.btnFueros.TabIndex = 2
        Me.btnFueros.Text = "FUEROS"
        Me.btnFueros.UseVisualStyleBackColor = True
        '
        'btnTribunal
        '
        Me.btnTribunal.FlatAppearance.BorderSize = 0
        Me.btnTribunal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTribunal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTribunal.ForeColor = System.Drawing.Color.Orchid
        Me.btnTribunal.Image = Global.BDCCJ.My.Resources.Resources.IconoBancos
        Me.btnTribunal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTribunal.Location = New System.Drawing.Point(0, 146)
        Me.btnTribunal.Name = "btnTribunal"
        Me.btnTribunal.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnTribunal.Size = New System.Drawing.Size(220, 60)
        Me.btnTribunal.TabIndex = 1
        Me.btnTribunal.Text = "TRIBUNALES"
        Me.btnTribunal.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.PictureBox1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 140)
        Me.pnlLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BDCCJ.My.Resources.Resources.Logo_1
        Me.PictureBox1.Location = New System.Drawing.Point(10, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlBarraTitulo
        '
        Me.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlBarraTitulo.Controls.Add(Me.pbxSalir)
        Me.pnlBarraTitulo.Controls.Add(Me.pbxMin)
        Me.pnlBarraTitulo.Controls.Add(Me.lblFrmActual)
        Me.pnlBarraTitulo.Controls.Add(Me.pbxMax)
        Me.pnlBarraTitulo.Controls.Add(Me.pbxRest)
        Me.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraTitulo.Location = New System.Drawing.Point(220, 0)
        Me.pnlBarraTitulo.Name = "pnlBarraTitulo"
        Me.pnlBarraTitulo.Size = New System.Drawing.Size(788, 80)
        Me.pnlBarraTitulo.TabIndex = 1
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.BDCCJ.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(751, 12)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 21
        Me.pbxSalir.TabStop = False
        '
        'pbxMin
        '
        Me.pbxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxMin.BackColor = System.Drawing.Color.Transparent
        Me.pbxMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxMin.Image = Global.BDCCJ.My.Resources.Resources.minimazar
        Me.pbxMin.Location = New System.Drawing.Point(670, 12)
        Me.pbxMin.Name = "pbxMin"
        Me.pbxMin.Size = New System.Drawing.Size(25, 25)
        Me.pbxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMin.TabIndex = 19
        Me.pbxMin.TabStop = False
        '
        'lblFrmActual
        '
        Me.lblFrmActual.AutoSize = True
        Me.lblFrmActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrmActual.ForeColor = System.Drawing.Color.Orchid
        Me.lblFrmActual.Location = New System.Drawing.Point(6, 29)
        Me.lblFrmActual.Name = "lblFrmActual"
        Me.lblFrmActual.Size = New System.Drawing.Size(64, 20)
        Me.lblFrmActual.TabIndex = 1
        Me.lblFrmActual.Text = "INICIO"
        '
        'pbxMax
        '
        Me.pbxMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxMax.BackColor = System.Drawing.Color.Transparent
        Me.pbxMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxMax.Image = Global.BDCCJ.My.Resources.Resources.maxi
        Me.pbxMax.Location = New System.Drawing.Point(711, 12)
        Me.pbxMax.Name = "pbxMax"
        Me.pbxMax.Size = New System.Drawing.Size(25, 25)
        Me.pbxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMax.TabIndex = 20
        Me.pbxMax.TabStop = False
        Me.pbxMax.Visible = False
        '
        'pbxRest
        '
        Me.pbxRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxRest.BackColor = System.Drawing.Color.Transparent
        Me.pbxRest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxRest.Image = Global.BDCCJ.My.Resources.Resources.res
        Me.pbxRest.Location = New System.Drawing.Point(711, 12)
        Me.pbxRest.Name = "pbxRest"
        Me.pbxRest.Size = New System.Drawing.Size(25, 25)
        Me.pbxRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxRest.TabIndex = 22
        Me.pbxRest.TabStop = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(220, 80)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(788, 566)
        Me.pnlContenedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(703, 521)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 36)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "ByB Soft"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPPal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 646)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlBarraTitulo)
        Me.Controls.Add(Me.pnlLateral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPPal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BDCCJ - INICIO"
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBarraTitulo.ResumeLayout(False)
        Me.pnlBarraTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLateral As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnCasos As Button
    Friend WithEvents btnCamara As Button
    Friend WithEvents btnTipos As Button
    Friend WithEvents btnFueros As Button
    Friend WithEvents btnTribunal As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlBarraTitulo As Panel
    Friend WithEvents lblFrmActual As Label
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents pbxMin As PictureBox
    Friend WithEvents pbxMax As PictureBox
    Friend WithEvents pbxRest As PictureBox
    Friend WithEvents Label1 As Label
End Class
