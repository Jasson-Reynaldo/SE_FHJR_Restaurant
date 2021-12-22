Imports System.Data.SqlClient
Public Class OrderForm
    Dim foodorder(20), order_id, trans_id As String
    Dim foodPrice(20), foodamount(20), foodcounter As Integer
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        If numUpDown.Value <> 0 Then
            If listMenu.SelectedIndex = 0 Then
                listOrder.Items.Add(numUpDown.Value & " Pie " & vbTab & vbTab & " Pizza")
                foodorder(foodcounter) = "M0001"
                foodPrice(foodcounter) = 150000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Pizza" & vbTab & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))
            ElseIf listMenu.SelectedIndex = 1 Then
                listOrder.Items.Add(numUpDown.Value & " Piece " & vbTab & vbTab & " Fried Chicken")
                foodorder(foodcounter) = "M0002"
                foodPrice(foodcounter) = 15000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Fried Chicken" & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))
            ElseIf listMenu.SelectedIndex = 2 Then
                listOrder.Items.Add(numUpDown.Value & " Set " & vbTab & vbTab & " Burger")
                foodorder(foodcounter) = "M0003"
                foodPrice(foodcounter) = 50000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Burger" & vbTab & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))
            ElseIf listMenu.SelectedIndex = 3 Then
                listOrder.Items.Add(numUpDown.Value & " Plate " & vbTab & vbTab & " Fried Rice")

                foodorder(foodcounter) = "M0004"
                foodPrice(foodcounter) = 35000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Fried Rice" & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))
            ElseIf listMenu.SelectedIndex = 4 Then
                listOrder.Items.Add(numUpDown.Value & " Portion " & vbTab & vbTab & " French Fries")
                foodorder(foodcounter) = "M0005"
                foodPrice(foodcounter) = 15000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " French Fries" & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))

            ElseIf listMenu.SelectedIndex = 5 Then
                listOrder.Items.Add(numUpDown.Value & " Slice " & vbTab & vbTab & " Cake")
                foodorder(foodcounter) = "M0006"
                foodPrice(foodcounter) = 20000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Cake" & vbTab & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))

            ElseIf listMenu.SelectedIndex = 6 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Soda")
                foodorder(foodcounter) = "M0007"
                foodPrice(foodcounter) = 15000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Soda" & vbTab & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))

            ElseIf listMenu.SelectedIndex = 7 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Juice")
                foodorder(foodcounter) = "M0008"
                foodPrice(foodcounter) = 20000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Juice" & vbTab & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))

            ElseIf listMenu.SelectedIndex = 8 Then
                listOrder.Items.Add(numUpDown.Value & " Glass " & vbTab & vbTab & " Mineral Water")
                foodorder(foodcounter) = "M0009"
                foodPrice(foodcounter) = 5000 * numUpDown.Value
                foodamount(foodcounter) = numUpDown.Value
                TransactionForm.listTransaction.Items.Add(numUpDown.Value & " Mineral Water" & vbTab & vbTab & vbTab & "IDR " & foodPrice(foodcounter))

            End If
            numUpDown.Value = 0
        End If
        foodcounter += 1
    End Sub

    Sub resetall()
        numUpDown.Value = 0
        listOrder.Items.Clear()
        listMenu.ClearSelected()
        listOrder.Items.Add(vbTab & "Delicioso Restaurant")
        Erase foodorder
        Erase foodPrice
        Erase foodamount
        ReDim foodorder(20)
        ReDim foodPrice(20)
        ReDim foodamount(20)
        foodcounter = 0
    End Sub
    Sub Autoidorder()
        CMDresto = New SqlCommand("SELECT * FROM Orders WHERE Order_ID IN (SELECT MAX(Order_ID) FROM Orders)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        Dim propercode, countcode
        If Not DTRresto.HasRows Then
            propercode = "OD" + "001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 3) + 1
            propercode = "OD" + Microsoft.VisualBasic.Right("00" & countcode, 3)
        End If
        order_id = propercode
        DTRresto.Close()
    End Sub
    Sub Autoidtrans()
        CMDresto = New SqlCommand("SELECT * FROM Transactions WHERE Trans_ID IN (SELECT MAX(Trans_ID) FROM Transactions)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        Dim propercode, countcode
        If Not DTRresto.HasRows Then
            propercode = "T" + "0001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 4) + 1
            propercode = "T" + Microsoft.VisualBasic.Right("000" & countcode, 4)
        End If
        trans_id = propercode
        DTRresto.Close()
    End Sub
    Sub addorder()
        Autoidorder()
        Dim outcounters = 0
        While outcounters < foodcounter
            CMDresto = New SqlCommand("insert into Orders (Order_ID, Menu_ID, Order_Qty)" &
                   " values (
                           '" & order_id & "'," &
                           "'" & foodorder(outcounters) & "'," &
                           "'" & foodamount(outcounters) & "')", DBresto)
            CMDresto.ExecuteNonQuery()
            outcounters += 1
        End While
        MsgBox("Succesfull Adding data!")
    End Sub
    Sub addtrans()
        Autoidtrans()
        Dim outcounter = 0
        Dim totalprice = 0
        While outcounter <= foodcounter
            totalprice += foodPrice(outcounter)
            outcounter += 1
        End While
        CMDresto = New SqlCommand("insert into Transactions " &
                   " values (
                           '" & trans_id & "'," &
                           "'" & order_id & "'," &
                           "'" & totalprice & "')", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("New Order Placed!")
    End Sub
    Private Sub btnResetOrder_Click(sender As Object, e As EventArgs) Handles btnResetOrder.Click
        resetall()
        TransactionForm.listTransaction.Items.Clear()
        TransactionForm.listTransaction.Items.Add(vbTab & vbTab & " Deliciosso Restaurant ")
    End Sub

    Private Sub btnClaimOrder_Click(sender As Object, e As EventArgs) Handles btnClaimOrder.Click
        addorder()
        addtrans()
        Autoidorder()
        Autoidtrans()
        lblOrderID.Text = order_id
        resetall()
        Me.Hide()
        MainForm.switchPanel(TransactionForm)
    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DB_Connect()
        Autoidorder()
        lblOrderID.Text = order_id
    End Sub
End Class