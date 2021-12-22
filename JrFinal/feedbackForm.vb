Imports System.Data.SqlClient
Public Class feedbackForm
    Dim feed_id, trans_id As String
    Private Sub btnSubmitFB_Click(sender As Object, e As EventArgs) Handles btnSubmitFB.Click
        addfeedback()
        Me.Hide()
        MainForm.switchPanel(HomeForm)
        MainForm.btnFeedBack.Enabled = False
        MainForm.btnTransaction.Enabled = False
        resetall()
    End Sub
    Sub resetall()
        RichTextBox1.Text = ""
    End Sub
    Sub Autoidfeed()
        CMDresto = New SqlCommand("SELECT * FROM Feedback WHERE Feed_ID IN (SELECT MAX(Feed_ID) FROM Feedback)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        Dim propercode, countcode
        If Not DTRresto.HasRows Then
            propercode = "F" + "0001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 4) + 1
            propercode = "F" + Microsoft.VisualBasic.Right("000" & countcode, 4)
        End If
        feed_id = propercode
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
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 4)
            propercode = "T" + Microsoft.VisualBasic.Right("000" & countcode, 4)
        End If
        trans_id = propercode
        DTRresto.Close()
    End Sub
    Sub addfeedback()
        Autoidfeed()
        Autoidtrans()

        CMDresto = New SqlCommand("insert into Feedback " &
                   " values (
                           '" & feed_id & "'," &
                           "'" & RichTextBox1.text & "'," &
                           "'" & trans_id & "')", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
    End Sub
End Class