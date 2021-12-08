Public Class AuthenForm
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
        btnAdmin.BackColor = Color.Orange
    End Sub
    Private Sub btnAdmin_MouseLeave(sender As Object, e As EventArgs) Handles btnAdmin.MouseLeave
        btnAdmin.BackColor = Color.Black
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        MainForm.Show()
        MainForm.btnTransactionDB.Visible = False
        MainForm.btnOrderDB.Visible = False
        MainForm.btnMenuDB.Visible = False
        MainForm.btnFeedBack.Visible = False
    End Sub

    Private Sub btnCustomer_MouseEnter(sender As Object, e As EventArgs) Handles btnCustomer.MouseHover
        btnCustomer.BackColor = Color.Orange
    End Sub

    Private Sub btnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer.MouseLeave
        btnCustomer.BackColor = Color.Black
    End Sub
End Class