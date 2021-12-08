Public Class TransactionForm
    Private Sub btnFinishTrans_Click(sender As Object, e As EventArgs) Handles btnFinishTrans.Click
        Me.Hide()
        feedbackForm.Show()
    End Sub
End Class