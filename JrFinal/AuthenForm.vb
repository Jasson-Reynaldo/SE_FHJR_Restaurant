Public Class AuthenForm
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

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        LoginAdminForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.ImageIndex = 1
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.ImageIndex = 0
    End Sub

    Private Sub btnAdmin_MouseEnter(sender As Object, e As EventArgs) Handles btnAdmin.MouseHover
        btnAdmin.BackColor = Color.FromArgb(255, 171, 47)
    End Sub
    Private Sub btnAdmin_MouseLeave(sender As Object, e As EventArgs) Handles btnAdmin.MouseLeave
        btnAdmin.BackColor = Color.FromArgb(255, 210, 63)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        MainForm.Show()
        MainForm.btnTransactionDB.Visible = False
        MainForm.btnOrderDB.Visible = False
        MainForm.btnMenuDB.Visible = False
        MainForm.btnFeedbackDB.Visible = False
        MainForm.lblUrName.Text = "Customer"
    End Sub

    Private Sub btnCustomer_MouseEnter(sender As Object, e As EventArgs) Handles btnCustomer.MouseHover
        btnCustomer.BackColor = Color.FromArgb(255, 171, 47)

    End Sub

    Private Sub btnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer.MouseLeave
        btnCustomer.BackColor = Color.FromArgb(255, 210, 63)
    End Sub

    Private Sub AuthenForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        mousemoving()
    End Sub

    Private Sub AuthenForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mousemovedown()
    End Sub

    Private Sub AuthenForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mousemoveup()
    End Sub
End Class