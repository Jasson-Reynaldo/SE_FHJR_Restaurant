Public Class LoginAdminForm

    Dim dragable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Sub mousemovedown()
        dragable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Sub mousemoving()
        If dragable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Sub mousemoveup()
        dragable = False
    End Sub

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

    Private Sub LoginAdminForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        mousemoving()
    End Sub

    Private Sub LoginAdminForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mousemoveup()
    End Sub

    Private Sub LoginAdminForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mousemovedown()
    End Sub
End Class