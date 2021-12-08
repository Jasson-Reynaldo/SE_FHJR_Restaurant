
Public Class MainForm
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
    Public Sub switchPanel(ByVal contentPanel As Form)
        pnlMain.Controls.Clear()
        contentPanel.TopLevel = False
        pnlMain.Controls.Add(contentPanel)
        contentPanel.Dock = DockStyle.Fill
        contentPanel.BringToFront()
        contentPanel.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        LoadingForm.Close()
        LoginForm.Show()
    End Sub
    Sub logout()
        Me.Close()
        LoginForm.Show()
        LoadingForm.progBar.Value = 0
        LoadingForm.loadTime.Enabled = True
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        switchPanel(IceMenu)
    End Sub

    Private Sub btnOrderStatus_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        switchPanel(OrderStatusForm)
    End Sub

    Private Sub btnCusData_Click(sender As Object, e As EventArgs) Handles btnFeedBack.Click
        switchPanel(CustomerDataForm)
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        switchPanel(OrderFormSS)
    End Sub

    Private Sub btnTransData_Click(sender As Object, e As EventArgs) Handles btnMenuDB.Click
        switchPanel(Transactions_Data)
    End Sub

    Private Sub btnAssets_Click(sender As Object, e As EventArgs) Handles btnOrderDB.Click
        switchPanel(Assets)
    End Sub

    Private Sub btnDataAnalayze_Click(sender As Object, e As EventArgs) Handles btnTransactionDB.Click
        switchPanel(HomeForm)
        DataAnalyzingForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(HomeForm)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        switchPanel(HomeForm)
    End Sub
End Class