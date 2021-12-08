Public Class LoadingForm
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTime.Start()
    End Sub

    Private Sub loadTime_Tick(sender As Object, e As EventArgs) Handles loadTime.Tick
        progBar.Increment(7)
        If progBar.Value = 100 Then
            loadTime.Stop()
            Me.Hide()
            MainForm.Show()
        End If
    End Sub
End Class