<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsg))
        Me.bnfElipMsg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfDragMsg = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bnfBarraTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.bnfBtnOk = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.bnfBtnCerr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pbxOk = New System.Windows.Forms.PictureBox()
        Me.pbxAlerta = New System.Windows.Forms.PictureBox()
        Me.pbxError = New System.Windows.Forms.PictureBox()
        Me.pbxInf = New System.Windows.Forms.PictureBox()
        Me.bnfBarraTitulo.SuspendLayout()
        CType(Me.pbxOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxInf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnfElipMsg
        '
        Me.bnfElipMsg.ElipseRadius = 20
        Me.bnfElipMsg.TargetControl = Me
        '
        'bnfDragMsg
        '
        Me.bnfDragMsg.Fixed = True
        Me.bnfDragMsg.Horizontal = True
        Me.bnfDragMsg.TargetControl = Me
        Me.bnfDragMsg.Vertical = True
        '
        'bnfBarraTitulo
        '
        Me.bnfBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfBarraTitulo.BorderRadius = 5
        Me.bnfBarraTitulo.BottomSahddow = True
        Me.bnfBarraTitulo.color = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfBarraTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfBarraTitulo.LeftSahddow = False
        Me.bnfBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfBarraTitulo.Name = "bnfBarraTitulo"
        Me.bnfBarraTitulo.RightSahddow = True
        Me.bnfBarraTitulo.ShadowDepth = 20
        Me.bnfBarraTitulo.Size = New System.Drawing.Size(464, 42)
        Me.bnfBarraTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(440, 23)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Sistema de Alertas"
        '
        'lblMsg
        '
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.White
        Me.lblMsg.Location = New System.Drawing.Point(97, 51)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(355, 73)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfBtnOk
        '
        Me.bnfBtnOk.ElipseRadius = 10
        Me.bnfBtnOk.TargetControl = Me.btnOK
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(365, 136)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 40)
        Me.btnOK.TabIndex = 34
        Me.btnOK.Text = "Aceptar"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'bnfBtnCerr
        '
        Me.bnfBtnCerr.ElipseRadius = 10
        Me.bnfBtnCerr.TargetControl = Me.btnCerrar
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(272, 136)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(87, 40)
        Me.btnCerrar.TabIndex = 35
        Me.btnCerrar.Text = "Cancelar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'pbxOk
        '
        Me.pbxOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxOk.Image = Global.BDCCJ.My.Resources.Resources.IconoOk
        Me.pbxOk.Location = New System.Drawing.Point(12, 51)
        Me.pbxOk.Name = "pbxOk"
        Me.pbxOk.Size = New System.Drawing.Size(79, 73)
        Me.pbxOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxOk.TabIndex = 38
        Me.pbxOk.TabStop = False
        '
        'pbxAlerta
        '
        Me.pbxAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxAlerta.Image = Global.BDCCJ.My.Resources.Resources.Icono_Alerta1
        Me.pbxAlerta.Location = New System.Drawing.Point(12, 51)
        Me.pbxAlerta.Name = "pbxAlerta"
        Me.pbxAlerta.Size = New System.Drawing.Size(79, 73)
        Me.pbxAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxAlerta.TabIndex = 3
        Me.pbxAlerta.TabStop = False
        '
        'pbxError
        '
        Me.pbxError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxError.Image = Global.BDCCJ.My.Resources.Resources.IconoError1
        Me.pbxError.Location = New System.Drawing.Point(12, 51)
        Me.pbxError.Name = "pbxError"
        Me.pbxError.Size = New System.Drawing.Size(79, 73)
        Me.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxError.TabIndex = 37
        Me.pbxError.TabStop = False
        '
        'pbxInf
        '
        Me.pbxInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxInf.Image = Global.BDCCJ.My.Resources.Resources.Icono_Informacion
        Me.pbxInf.Location = New System.Drawing.Point(12, 51)
        Me.pbxInf.Name = "pbxInf"
        Me.pbxInf.Size = New System.Drawing.Size(79, 73)
        Me.pbxInf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxInf.TabIndex = 36
        Me.pbxInf.TabStop = False
        '
        'frmMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 188)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.bnfBarraTitulo)
        Me.Controls.Add(Me.pbxAlerta)
        Me.Controls.Add(Me.pbxError)
        Me.Controls.Add(Me.pbxInf)
        Me.Controls.Add(Me.pbxOk)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BDCCJ - SISTEMA DE ALERTAS"
        Me.bnfBarraTitulo.ResumeLayout(False)
        CType(Me.pbxOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxInf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bnfElipMsg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfDragMsg As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents bnfBarraTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxAlerta As PictureBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents bnfBtnOk As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfBtnCerr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pbxInf As PictureBox
    Friend WithEvents pbxError As PictureBox
    Friend WithEvents pbxOk As PictureBox
End Class
