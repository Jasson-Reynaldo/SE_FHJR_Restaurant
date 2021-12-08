Imports System.Data.SqlClient
Public Class Transactions_Data

    Private Sub Transactions_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        showOrderData()
        showOrderLine()
    End Sub

    Sub showOrderData()
        AdptOrder = New SqlDataAdapter("SELECT * FROM OrderData", DBicecream)
        TblOrder.Clear()
        AdptOrder.Fill(TblOrder)
        dgOrder.DataSource = TblOrder
    End Sub

    Sub showOrderLine()
        AdptLineOrder = New SqlDataAdapter("SELECT * FROM LineOrder", DBicecream)
        TblLineOrder.Clear()
        AdptLineOrder.Fill(TblLineOrder)
        dgLineOrder.DataSource = TblLineOrder
    End Sub

    Sub resetState()
        txtLlineOrderValue.Clear()
        txtOrderValue.Clear()
        cmbSearchLineOrder.ResetText()
        cmbSearchOrder.ResetText()
    End Sub

    Private Sub txtOrderValue_TextChanged(sender As Object, e As EventArgs) Handles txtOrderValue.TextChanged
        AdptOrder = New SqlDataAdapter("SELECT * FROM OrderData WHERE " & cmbSearchOrder.Text & " like '%" & txtOrderValue.Text & "%'", DBicecream)
        TblOrder.Clear()
        AdptOrder.Fill(TblOrder)
        dgOrder.DataSource = TblOrder
    End Sub

    Private Sub txtLlineOrderValue_TextChanged(sender As Object, e As EventArgs) Handles txtLlineOrderValue.TextChanged
        AdptLineOrder = New SqlDataAdapter("SELECT * FROM LineOrder WHERE " & cmbSearchLineOrder.Text & " like '%" & txtLlineOrderValue.Text & "%'", DBicecream)
        TblLineOrder.Clear()
        AdptLineOrder.Fill(TblLineOrder)
        dgLineOrder.DataSource = TblLineOrder
    End Sub

    Private Sub CMSRefreshTrans_Click(sender As Object, e As EventArgs) Handles CMSRefreshTrans.Click
        showOrderData()
        showOrderData()
        showOrderLine()
        resetState()
    End Sub
End Class