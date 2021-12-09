Imports System.Data.SqlClient
Public Class OrderDBForm
    Dim CusGend, sortCategory As String
    Sub totalOrder()
        CMDresto = New SqlCommand("SELECT COUNT(Order_ID) AS TOTAL_Orders FROM Orders", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Close()
        Dim totalOrder As Integer = Convert.ToInt16(CMDresto.ExecuteScalar())
        lblTotalMenu.Text = totalOrder.ToString
    End Sub

    Sub ShowData()
        AdptOrders = New SqlDataAdapter("SELECT * from Orders", DBresto)
        TblOrders.Clear()
        AdptOrders.Fill(TblOrders)
        dgOrder.DataSource = TblOrders
        resetcondition()
        resetValue()
        totalOrder()
    End Sub

    Sub resetValue()
        txtMenuID.Clear()
        txtOrderQty.Clear()
        cmbSearchChoice.ResetText()
        txtFind.Clear()
    End Sub

    Sub resetcondition()
        btnConfirmation.Visible = False
        txtMenuID.Enabled = False
        txtOrderQty.Enabled = False
        resetValue()
    End Sub

    Sub resetpartial()
        btnConfirmation.Visible = False
        txtMenuID.Enabled = False
        txtOrderQty.Enabled = False
    End Sub

    Sub enablecondition()
        btnConfirmation.Visible = True
        txtMenuID.Enabled = True
        txtOrderQty.Enabled = True
    End Sub

    Sub autoID()
        enablecondition()
        resetValue()
        btnConfirmation.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDresto = New SqlCommand("SELECT * FROM Orders WHERE Order_ID IN (SELECT MAX(Order_ID) FROM Orders)", RestoDB)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        If Not DTRresto.HasRows Then
            propercode = "OD" + "001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 2) + 1
            propercode = "OD" + Microsoft.VisualBasic.Right("00" & countcode, 2)
        End If
        lblOrderID.Text = propercode

        DTRresto.Close()
    End Sub

    Sub Addingdata()
        CMDresto = New SqlCommand("insert into Orders " &
                   " values (
                           '" & lblOrderID.Text & "'," &
                           "'" & txtMenuID.Text & "'," &
                           "'" & txtOrderQty.Text & "',", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblStats.Text = "New Data Added!"
        ShowData()
        resetcondition()
    End Sub

    Sub Updatingdata()
        CMDresto = New SqlCommand("UPDATE Orders set " &
                    "Order_ID ='" & lblOrderID.Text & "'," &
                    "Menu_ID ='" & txtMenuID.Text & "'," &
                    "Order_Qty ='" & txtOrderQty.Text & "'," & "' where " &
                    "Order_ID ='" & lblOrderID.Text & "'", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblStats.Text = "Data Updated!"
        ShowData()
        resetcondition()
    End Sub

    Sub editcondition()
        enablecondition()
        btnConfirmation.Text = "Confirm Edit"
        If txtOrderQty.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub editValidation()
        CMDresto = New SqlCommand("SELECT * FROM Orders WHERE CUS_ID ='" & lblMenuID.Text & "'", DBresto)
        DTRresto = CMDresto.ExecuteReader
        If DTRresto.Read Then
            editcondition()
        Else
            MsgBox("Please Select    Any data", MsgBoxStyle.Information, "Help")
            resetcondition()
        End If
        DTRresto.Close()
    End Sub
    Sub Deletingdata()
        CMDresto = New SqlCommand(" DELETE from Orders where Order_ID ='" & dgOrder.SelectedCells(0).Value & "'", DBresto)
        CMDresto.ExecuteNonQuery()
        ShowData()
        MsgBox("Succesfull Deleting data!")
        lblStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub OrderDBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowData()
        resetcondition()
        lblStats.Text = "Data Loaded!"
    End Sub

    Private Sub dgOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrder.CellClick
        Dim cusrow = dgOrder.CurrentRow.Index
        With dgOrder
            lblMenuID.Text = .Item(0, cusrow).Value
            .Text = .Item(1, cusrow).Value
        End With
    End Sub

    Private Sub MsEditCus_Click(sender As Object, e As EventArgs) Handles MsEditCus.Click
        editValidation()
    End Sub

    Private Sub CmsEditCus_Click(sender As Object, e As EventArgs) Handles CmsEditCus.Click
        editValidation()
    End Sub

    Private Sub CmsDelData_Click(sender As Object, e As EventArgs) Handles CmsDelData.Click
        Deletingdata()
    End Sub

    Private Sub MsDeleteCus_Click(sender As Object, e As EventArgs) Handles MsDeleteCus.Click
        Deletingdata()
    End Sub

    Private Sub MsInsertCus_Click(sender As Object, e As EventArgs) Handles MsInsertCus.Click
        autoID()
    End Sub

    Private Sub CmsAddCus_Click(sender As Object, e As EventArgs) Handles CmsAddCus.Click
        autoID()
    End Sub

    Private Sub btnConfirmation_Click(sender As Object, e As EventArgs) Handles btnConfirmation.Click
        If btnConfirmation.Text = "Confirm Input" Then
            Addingdata()
        ElseIf btnConfirmation.Text = "Confirm Edit" Then
            Updatingdata()
        End If
    End Sub

    Private Sub dgOrder_MouseClick(sender As Object, e As MouseEventArgs) Handles dgOrder.MouseClick
        resetpartial()
    End Sub

    Private Sub msRefresh_Click(sender As Object, e As EventArgs) Handles msRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        AdptOrders = New SqlDataAdapter("SELECT * FROM Orders WHERE " & cmbSearchChoice.Text & " like '%" & txtFind.Text & "%'", DBresto)
        TblOrders.Clear()
        AdptOrders.Fill(TblOrders)
        dgOrder.DataSource = TblOrders
    End Sub

    Private Sub CmsRefresh_Click(sender As Object, e As EventArgs) Handles CmsRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Sub SortingDataASC()
        AdptOrders = New SqlDataAdapter("SELECT * FROM Orders ORDER BY " & sortCategory & " ASC", DBresto)
        TblOrders.Clear()
        AdptOrders.Fill(TblOrders)
        dgOrder.DataSource = TblOrders
    End Sub

    Sub SortingDataDESC()
        AdptOrders = New SqlDataAdapter("SELECT * FROM Orders ORDER BY " & sortCategory & " DESC", DBresto)
        TblOrders.Clear()
        AdptOrders.Fill(TblOrders)
        dgOrder.DataSource = TblOrders
    End Sub

    Private Sub MsIdAsc_Click(sender As Object, e As EventArgs) Handles MsIdAsc.Click
        sortCategory = "Order_ID"
        SortingDataASC()
    End Sub

    Private Sub MsIdDesc_Click(sender As Object, e As EventArgs) Handles MsIdDesc.Click
        sortCategory = "Order_ID"
        SortingDataDESC()
    End Sub

    Private Sub MsNameAsc_Click(sender As Object, e As EventArgs) Handles MsNameAsc.Click
        sortCategory = "Order_Qty"
        SortingDataASC()
    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub LabelTotal_Click(sender As Object, e As EventArgs) Handles LabelTotal.Click

    End Sub

    Private Sub MsNameDesc_Click(sender As Object, e As EventArgs) Handles MsNameDesc.Click
        sortCategory = "Order_Qty"
        SortingDataDESC()
    End Sub
End Class