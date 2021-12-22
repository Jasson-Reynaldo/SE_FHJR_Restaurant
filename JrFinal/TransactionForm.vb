Imports System.Data.SqlClient
Public Class TransactionForm
    Dim trans_id As String
    Private Sub btnFinishTrans_Click(sender As Object, e As EventArgs) Handles btnFinishTrans.Click
        Me.Close()
        lboxTrans.Items.Clear()
        listTransaction.Items.Clear()
        MainForm.switchPanel(feedbackForm)
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
    Sub FillTrans()
        Dim time_trans = TimeOfDay.ToString("hh:mm:ss tt"), date_trans = Date.Now.ToString("dddd, dd MMMM yyyy")
        lboxTrans.Items.Add("Transaction ID : " & trans_id)
        lboxTrans.Items.Add("Transaction Date : " & date_trans)
        lboxTrans.Items.Add("Transaction Time : " & time_trans)
    End Sub
    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        Autoidtrans()
        FillTrans()
    End Sub
End Class