Public Class LoginAdminForm
    Private Sub LoginAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Text = "Password"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "admin" Then
            Me.Hide()
            MainForm.Show()
        Else
            MsgBox("Wrong Password !!!", MsgBoxStyle.Information, "Login Status")
            txtPassword.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            If chkShowPass.Checked = False Then
                txtPassword.PasswordChar = "*"
            End If
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            If chkShowPass.Checked = False Then
                txtPassword.PasswordChar = ""
            End If
        End If
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.Orange
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.Yellow
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            If txtPassword.Text = "Password" Then
                txtPassword.PasswordChar = ""
            Else
                txtPassword.PasswordChar = "*"
            End If
        End If
    End Sub
End Class