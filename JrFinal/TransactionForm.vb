Public Class TransactionForm
    Private Sub btnFinishTrans_Click(sender As Object, e As EventArgs) Handles btnFinishTrans.Click
        Me.Hide()
        MainForm.switchPanel(feedbackForm)
    End Sub
End Class