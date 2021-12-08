Imports System.Data.SqlClient
Public Class LoginForm
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


    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove
        mousemoving()
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseUp
        mousemoveup()
    End Sub

    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown
        mousemovedown()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        CMDiceJr = New SqlCommand("SELECT * FROM EmployeeData WHERE EMP_USERNAME ='" & txtUname.Text & "'AND EMP_PASSWORD='" & txtPass.Text & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            If DTRiceJr!EMP_ROLE = "Admin" Then
                Me.Hide()
                LoadingForm.Show()
                MainForm.lblStatsRole.Text = DTRiceJr(7)
                MainForm.lblUrName.Text = DTRiceJr(1)
            ElseIf DTRiceJr!EMP_ROLE = "Employee" Then
                Me.Hide()
                LoadingForm.Show()
                MainForm.btnDataAnalayze.Visible = False
                MainForm.btnAssets.Visible = False
                MainForm.btnTransData.Visible = False
                MainForm.btnCusData.Visible = False
                MainForm.lblStatsRole.Text = DTRiceJr(7)
                MainForm.lblUrName.Text = DTRiceJr(1)
            End If
            Me.Hide()
            LoadingForm.Show()
        Else
            MsgBox("Invalid User !!!", MsgBoxStyle.Information, "Login Status")
            txtUname.Clear()
            txtPass.Clear()
        End If
        DTRiceJr.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        If ckShowPass.Checked = False Then
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub ckShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ckShowPass.CheckedChanged
        If ckShowPass.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
