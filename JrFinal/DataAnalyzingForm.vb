Public Class DataAnalyzingForm
    Dim MiniFormCounter As Integer = 0
    Private Sub MsNewForm_Click(sender As Object, e As EventArgs) Handles MsNewForm.Click
        Dim MiniForm As New BlankForm
        MiniForm.MdiParent = Me
        MiniFormCounter += 1
        MiniForm.Text = "Blank Form " & MiniFormCounter
        MiniForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tsmHorizontal_Click(sender As Object, e As EventArgs) Handles tsmHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub tsmVertical_Click(sender As Object, e As EventArgs) Handles tsmVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub tsmCascade_Click(sender As Object, e As EventArgs) Handles tsmCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MsCustomerDataF_Click(sender As Object, e As EventArgs) Handles MsCustomerDataF.Click
        Dim Cusform As New CustomerDataForm
        CustomerDataForm.MdiParent = Me
        CustomerDataForm.Show()
        CustomerDataForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        CustomerDataForm.AutoScroll = True
    End Sub

    Private Sub MsEmployeeDataF_Click(sender As Object, e As EventArgs) Handles MsEmployeeDataF.Click
        Dim EmpForm As New EmployeeData
        EmpForm.MdiParent = Me
        EmpForm.Show()
        EmpForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub MsIceDataF_Click(sender As Object, e As EventArgs) Handles MsIceDataF.Click
        Dim IceForm As New IceCreamData
        IceForm.MdiParent = Me
        IceForm.Show()
        IceForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub MsToppingDataF_Click(sender As Object, e As EventArgs) Handles MsToppingDataF.Click
        Dim ToppingForm As New ToppingData
        ToppingForm.MdiParent = Me
        ToppingForm.Show()
        ToppingForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub MsFlavorDataF_Click(sender As Object, e As EventArgs) Handles MsFlavorDataF.Click
        Dim FlavorForm As New FlavorData
        FlavorForm.MdiParent = Me
        FlavorForm.Show()
        FlavorForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub CloseAllFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllFormToolStripMenuItem.Click
        For Each Miniform As Form In Me.MdiChildren
            Miniform.Close()
        Next
        CustomerDataForm.Close()
        EmployeeData.Close()
        IceCreamData.Close()
        ToppingData.Close()
        FlavorData.Close()
        Transactions_Data.Close()
    End Sub

    Private Sub tsmTransaction_Click(sender As Object, e As EventArgs) Handles tsmTransaction.Click
        Dim TransactionsForm As New Transactions_Data
        TransactionsForm.MdiParent = Me
        TransactionsForm.Show()
        TransactionsForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class
