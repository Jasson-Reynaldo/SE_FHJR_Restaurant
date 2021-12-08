Public Class OrderStatusForm

    Dim selectedOrder As String
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        selectedOrder = chlboxOrder.SelectedItem
        lsBoxDone.Items.Add(selectedOrder)
        chlboxOrder.Items.Remove(selectedOrder)
    End Sub

    Private Sub OrderStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsBoxDone.Items.Add("Completed Orders:")
    End Sub
End Class