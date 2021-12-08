Public Class OrderForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        If numUpDown.Value <> 0 Then
            If listMenu.SelectedIndex = 0 Then
                listOrder.Items.Add(numUpDown.Value & " Pie " & vbTab & vbTab & " Pizza")
            ElseIf listMenu.SelectedIndex = 1 Then
                listOrder.Items.Add(numUpDown.Value & " Piece " & vbTab & vbTab & " Fried Chicken")
            ElseIf listMenu.SelectedIndex = 2 Then
                listOrder.Items.Add(numUpDown.Value & " Set " & vbTab & vbTab & " Burger")
            ElseIf listMenu.SelectedIndex = 3 Then
                listOrder.Items.Add(numUpDown.Value & " Plate " & vbTab & vbTab & " Fried Rice")
            ElseIf listMenu.SelectedIndex = 4 Then
                listOrder.Items.Add(numUpDown.Value & " Portion " & vbTab & vbTab & " French Fries")
            ElseIf listMenu.SelectedIndex = 5 Then
                listOrder.Items.Add(numUpDown.Value & " Slice " & vbTab & vbTab & " Cake")
            ElseIf listMenu.SelectedIndex = 6 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Soda")
            ElseIf listMenu.SelectedIndex = 7 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Juice")
            ElseIf listMenu.SelectedIndex = 8 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Mineral Water")
            End If
        End If
    End Sub

    Private Sub btnResetOrder_Click(sender As Object, e As EventArgs) Handles btnResetOrder.Click
        numUpDown.Value = 0
        listOrder.Items.Clear()
        listMenu.ClearSelected()
        listOrder.Items.Add(vbTab & "Delicioso Restaurant")
    End Sub
End Class