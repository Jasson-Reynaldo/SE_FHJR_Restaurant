Public Class OrderForm
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        If numUpDown.Value <> 0 Then
            If listMenu.SelectedIndex = 0 Then
                listOrder.Items.Add(numUpDown.Value & " Pie " & vbTab & vbTab & " Pizza")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Pizza" & vbTab & vbTab & vbTab & vbTab & "IDR 150.000")
            ElseIf listMenu.SelectedIndex = 1 Then
                listOrder.Items.Add(numUpDown.Value & " Piece " & vbTab & vbTab & " Fried Chicken")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Fried Chicken" & vbTab & vbTab & vbTab & "IDR 15.000")
            ElseIf listMenu.SelectedIndex = 2 Then
                listOrder.Items.Add(numUpDown.Value & " Set " & vbTab & vbTab & " Burger")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Burger" & vbTab & vbTab & vbTab & vbTab & "IDR 50.000")
            ElseIf listMenu.SelectedIndex = 3 Then
                listOrder.Items.Add(numUpDown.Value & " Plate " & vbTab & vbTab & " Fried Rice")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Fried Rice" & vbTab & vbTab & vbTab & "IDR 35.000")
            ElseIf listMenu.SelectedIndex = 4 Then
                listOrder.Items.Add(numUpDown.Value & " Portion " & vbTab & vbTab & " French Fries")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " French Fries" & vbTab & vbTab & vbTab & "IDR 15.000")
            ElseIf listMenu.SelectedIndex = 5 Then
                listOrder.Items.Add(numUpDown.Value & " Slice " & vbTab & vbTab & " Cake")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Cake" & vbTab & vbTab & vbTab & vbTab & "IDR 20.000")
            ElseIf listMenu.SelectedIndex = 6 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Soda")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Soda" & vbTab & vbTab & vbTab & vbTab & "IDR 15.000")
            ElseIf listMenu.SelectedIndex = 7 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Juice")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Juice" & vbTab & vbTab & vbTab & vbTab & "IDR 20.000")
            ElseIf listMenu.SelectedIndex = 8 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Mineral Water")
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Mineral Water" & vbTab & vbTab & vbTab & "IDR 5.000")
            End If
            numUpDown.Value = 0
        End If
    End Sub

    Private Sub btnResetOrder_Click(sender As Object, e As EventArgs) Handles btnResetOrder.Click
        numUpDown.Value = 0
        listOrder.Items.Clear()
        listMenu.ClearSelected()
        listOrder.Items.Add(vbTab & "Delicioso Restaurant")
        TransactionForm.listTransaction.Items.Clear()
        TransactionForm.listTransaction.Items.Add(vbTab & vbTab & " Deliciosso Restaurant ")
    End Sub

    Private Sub btnClaimOrder_Click(sender As Object, e As EventArgs) Handles btnClaimOrder.Click
        Me.Hide()
        MainForm.switchPanel(TransactionForm)
    End Sub
End Class