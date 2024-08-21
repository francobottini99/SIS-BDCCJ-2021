Public Enum Botones
    OK
    OK_CANCEL
    SI_NO
End Enum

Public Enum Iconos
    ALERTA
    INFORMACION
    OK
    ERR
End Enum

Public Class Notificaciones
    Public Shared Function MsgBox(ByVal mensaje As String, ByVal boton As Botones, ByVal icono As Iconos) As DialogResult
        frmMsg.lblMsg.Text = mensaje

        If boton = Botones.OK_CANCEL Then
            frmMsg.btnCerrar.Visible = True

            frmMsg.btnCerrar.Text = "Cancelar"
            frmMsg.btnOK.Text = "Ok"
        ElseIf boton = Botones.OK Then
            frmMsg.btnCerrar.Visible = False

            frmMsg.btnOK.Text = "Ok"
        ElseIf boton = Botones.SI_NO Then
            frmMsg.btnCerrar.Visible = True

            frmMsg.btnCerrar.Text = "No"
            frmMsg.btnOK.Text = "Si"
        End If

        If icono = Iconos.ALERTA Then
            frmMsg.pbxAlerta.BringToFront()
        ElseIf icono = Iconos.ERR Then
            frmMsg.pbxError.BringToFront()
        ElseIf icono = Iconos.INFORMACION Then
            frmMsg.pbxInf.BringToFront()
        ElseIf icono = Iconos.OK Then
            frmMsg.pbxOk.BringToFront()
        End If

        frmMsg.btnOK.Select()

        Return frmMsg.ShowDialog()
    End Function

    Private Shared listFrmDisable As List(Of Form)
    Private Shared Sub BloquearForms()
        If IsNothing(listFrmDisable) Then
            listFrmDisable = New List(Of Form)
        End If

        For Each frm As Form In My.Application.OpenForms
            If frm.ContainsFocus Then
                listFrmDisable.Add(frm)
                frm.Enabled = False
            End If
        Next
    End Sub

    Private Shared Sub HabilitarForms()
        For Each frm As Form In listFrmDisable
            frm.Enabled = True
        Next

        listFrmDisable.Clear()
    End Sub
End Class
