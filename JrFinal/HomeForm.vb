Public Class HomeForm
    Private Sub homeTime_Tick(sender As Object, e As EventArgs) Handles homeTime.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dddd, dd MMMM yyyy")
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homeTime.Start()
        lblTime.Text = DateTime.Now.ToLongDateString
    End Sub
End Class