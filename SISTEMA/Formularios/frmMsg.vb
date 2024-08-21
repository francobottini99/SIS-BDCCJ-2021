Public Class frmMsg

#Region "ANIMACION BOTONES"
    Private Sub btnCerrar_MouseEnter(sender As Object, e As EventArgs) Handles btnCerrar.MouseEnter
        If btnCerrar.Enabled = True Then
            btnCerrar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        If btnCerrar.Enabled = True Then
            btnCerrar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCerrar_GotFocus(sender As Object, e As EventArgs) Handles btnCerrar.GotFocus
        If btnCerrar.Enabled = True Then
            btnCerrar.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnCerrar_LostFocus(sender As Object, e As EventArgs) Handles btnCerrar.LostFocus
        If btnCerrar.Enabled = True Then
            btnCerrar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnOK_MouseEnter(sender As Object, e As EventArgs) Handles btnOK.MouseEnter
        If btnOK.Enabled = True Then
            btnOK.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnOK_MouseLeave(sender As Object, e As EventArgs) Handles btnOK.MouseLeave
        If btnOK.Enabled = True Then
            btnOK.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnOK_GotFocus(sender As Object, e As EventArgs) Handles btnOK.GotFocus
        If btnOK.Enabled = True Then
            btnOK.BackColor = Color.FromArgb(56, 126, 120)
        End If
    End Sub

    Private Sub btnOK_LostFocus(sender As Object, e As EventArgs) Handles btnOK.LostFocus
        If btnOK.Enabled = True Then
            btnOK.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
        Me.Hide()
        DialogResult = DialogResult.OK
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Hide()
        DialogResult = DialogResult.Cancel
    End Sub
#End Region

End Class