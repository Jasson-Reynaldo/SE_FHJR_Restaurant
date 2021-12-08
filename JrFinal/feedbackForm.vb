Public Class feedbackForm
    Private Sub btnSubmitFB_Click(sender As Object, e As EventArgs) Handles btnSubmitFB.Click
        Me.Hide()
        MainForm.Show()
        MainForm.btnFeedBack.Enabled = False
        MainForm.btnTransaction.Enabled = False
    End Sub
End Class