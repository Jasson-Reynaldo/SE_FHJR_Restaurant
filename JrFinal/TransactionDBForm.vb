﻿Imports System.Data.SqlClient
Public Class TransactionDBForm
    Dim sortCategory As String
    Sub totalTrans()
        CMDresto = New SqlCommand("SELECT COUNT(Trans_ID) AS TOTAL_TRANSACTION FROM Transaction", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Close()
        Dim totaltrans As Integer = Convert.ToInt16(CMDresto.ExecuteScalar())
        lblTotalTrans.Text = totaltrans.ToString
    End Sub

    Sub ShowData()
        AdptTransactions = New SqlDataAdapter("SELECT * from Transaction", DBresto)
        TblTransactions.Clear()
        AdptTransactions.Fill(TblTransactions)
        dgTransactions.DataSource = TblTransactions
        resetcondition()
        resetValue()
        totalTrans()
    End Sub

    Sub resetValue()

        txtTransTotal.Clear()
        cmbSearchChoice.ResetText()
        txtFind.Clear()
    End Sub

    Sub resetcondition()
        btnConfirmation.Visible = False

        txtTransTotal.Enabled = False
        resetValue()
    End Sub

    Sub resetpartial()
        btnConfirmation.Visible = False

        txtTransTotal.Enabled = False
    End Sub

    Sub enablecondition()
        btnConfirmation.Visible = True

        txtTransTotal.Enabled = True
    End Sub

    Sub autoID()
        enablecondition()
        resetValue()
        btnConfirmation.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDresto = New SqlCommand("SELECT * FROM Transaction WHERE Trans_ID IN (SELECT MAX(Trans_ID) FROM Transaction)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        If Not DTRresto.HasRows Then
            propercode = "T" + "0001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 7) + 1
            propercode = "T" + Microsoft.VisualBasic.Right("000" & countcode, 7)
        End If
        lblTransID.Text = propercode

        DTRresto.Close()
    End Sub

    Sub Addingdata()
        CMDresto = New SqlCommand("insert into Transaction " &
                   " values (
                           '" & lblTransID.Text & "',", DBresto)

        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblStats.Text = "New Data Added!"
        ShowData()
        resetcondition()
    End Sub

    Sub Updatingdata()
        CMDresto = New SqlCommand("UPDATE Transaction set " &
                    "Trans_ID ='" & lblTransID.Text & "'," &
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
        If txtTransTotal.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub editValidation()
        CMDresto = New SqlCommand("SELECT * FROM Transaction WHERE Trans_ID ='" & lblTransID.Text & "'", DBresto)
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
        CMDresto = New SqlCommand(" DELETE from Transaction where Trans_ID ='" & dgTransactions.SelectedCells(0).Value & "'", DBresto)
        CMDresto.ExecuteNonQuery()
        ShowData()
        MsgBox("Succesfull Deleting data!")
        lblStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub TransactionDBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowData()
        resetcondition()
        lblStats.Text = "Data Loaded!"
    End Sub

    Private Sub dgTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTransactions.CellClick
        Dim cusrow = dgTransactions.CurrentRow.Index
        With dgTransactions
            lblTransID.Text = .Item(0, cusrow).Value
            .Text = .Item(1, cusrow).Value
        End With
    End Sub

    Private Sub MsEditTrans_Click(sender As Object, e As EventArgs) Handles MsEditTrans.Click
        editValidation()
    End Sub

    Private Sub CmsEditTrans_Click(sender As Object, e As EventArgs) Handles CmsEditTrans.Click
        editValidation()
    End Sub

    Private Sub CmsDelData_Click(sender As Object, e As EventArgs) Handles CmsDelData.Click
        Deletingdata()
    End Sub

    Private Sub MsDeleteTrans_Click(sender As Object, e As EventArgs) Handles MsDeleteTrans.Click
        Deletingdata()
    End Sub

    Private Sub MsInsertTrans_Click(sender As Object, e As EventArgs) Handles MsInsertTrans.Click
        autoID()
    End Sub

    Private Sub CmsAddTrans_Click(sender As Object, e As EventArgs) Handles CmsAddTrans.Click
        autoID()
    End Sub

    Private Sub btnConfirmation_Click(sender As Object, e As EventArgs) Handles btnConfirmation.Click
        If btnConfirmation.Text = "Confirm Input" Then
            Addingdata()
        ElseIf btnConfirmation.Text = "Confirm Edit" Then
            Updatingdata()
        End If
    End Sub

    Private Sub dgTransactions_MouseClick(sender As Object, e As MouseEventArgs) Handles dgTransactions.MouseClick
        resetpartial()
    End Sub

    Private Sub msRefresh_Click(sender As Object, e As EventArgs) Handles msRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        AdptTransactions = New SqlDataAdapter("SELECT * FROM Transaction WHERE " & cmbSearchChoice.Text & " like '%" & txtFind.Text & "%'", DBresto)
        TblTransactions.Clear()
        AdptTransactions.Fill(TblTransactions)
        dgTransactions.DataSource = TblTransactions
    End Sub

    Private Sub CmsRefresh_Click(sender As Object, e As EventArgs) Handles CmsRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Sub SortingDataASC()
        AdptTransactions = New SqlDataAdapter("SELECT * FROM Transaction ORDER BY " & sortCategory & " ASC", DBresto)
        TblTransactions.Clear()
        AdptTransactions.Fill(TblTransactions)
        dgTransactions.DataSource = TblTransactions
    End Sub

    Sub SortingDataDESC()
        AdptTransactions = New SqlDataAdapter("SELECT * FROM Transaction ORDER BY " & sortCategory & " DESC", DBresto)
        TblTransactions.Clear()
        AdptTransactions.Fill(TblTransactions)
        dgTransactions.DataSource = TblTransactions
    End Sub

    Private Sub MsIdAsc_Click(sender As Object, e As EventArgs) Handles MsIdAsc.Click
        sortCategory = "Trans_ID"
        SortingDataASC()
    End Sub

    Private Sub MsIdDesc_Click(sender As Object, e As EventArgs) Handles MsIdDesc.Click
        sortCategory = "Trans_ID"
        SortingDataDESC()
    End Sub

    Private Sub MsNameAsc_Click(sender As Object, e As EventArgs) Handles MsNameAsc.Click
        sortCategory = "Order_ID"
        SortingDataASC()
    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub lblMenuID_Click(sender As Object, e As EventArgs) Handles lblTransID.Click

    End Sub

    Private Sub MsNameDesc_Click(sender As Object, e As EventArgs) Handles MsNameDesc.Click
        sortCategory = "Order_ID"
        SortingDataDESC()
    End Sub
End Class