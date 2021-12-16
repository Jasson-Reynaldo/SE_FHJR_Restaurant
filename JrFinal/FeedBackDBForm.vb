Imports System.Data.SqlClient
Public Class FeedBackDBForm
    Dim sortCategory As String
    Sub totalFeed()
        CMDresto = New SqlCommand("SELECT COUNT(Feed_ID) AS TOTAL_FEEDBACK FROM Feedback", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Close()
        Dim totalfeed As Integer = Convert.ToInt16(CMDresto.ExecuteScalar())
        lblTotalFeedback.Text = totalfeed.ToString
    End Sub

    Sub ShowData()
        AdptFeedback = New SqlDataAdapter("SELECT * from Feedback", DBresto)
        TblFeedback.Clear()
        AdptFeedback.Fill(TblFeedback)
        dgFeedback.DataSource = TblFeedback
        resetcondition()
        resetValue()
        totalFeed()
    End Sub

    Sub resetValue()

        txtFeedDetail.Clear()
        cmbSearchChoice.ResetText()
        txtFind.Clear()
    End Sub

    Sub resetcondition()
        btnConfirmation.Visible = False

        txtFeedDetail.Enabled = False
        resetValue()
    End Sub

    Sub resetpartial()
        btnConfirmation.Visible = False

        txtFeedDetail.Enabled = False
    End Sub

    Sub enablecondition()
        btnConfirmation.Visible = True

        txtFeedDetail.Enabled = True
    End Sub

    Sub autoID()
        enablecondition()
        resetValue()
        btnConfirmation.Text = "Confirm Input"
        Dim propercode, propercode1 As String
        Dim countcode, countcode1 As Long
        CMDresto = New SqlCommand("SELECT * FROM Feedback WHERE CUS_ID IN (SELECT MAX(Feed_ID) FROM Feedback)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        If Not DTRresto.HasRows Then
            propercode = "F" + "0001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 7) + 1
            propercode = "F" + Microsoft.VisualBasic.Right("000" & countcode, 7)
        End If
        lblFeedID.Text = propercode

        CMDresto = New SqlCommand("SELECT * FROM Transactions WHERE Trans_ID IN (SELECT MAX(Trans_ID) FROM Transactions)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()

        If Not DTRresto.HasRows Then
                propercode = "T" + "0001"
            Else
            countcode1 = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 4) + 1
            propercode1 = "T" + Microsoft.VisualBasic.Right("000" & countcode1, 4)
        End If
            lblTransactionID.Text = propercode1

            DTRresto.Close()
    End Sub

    Sub Addingdata()
        CMDresto = New SqlCommand("insert into Customer " &
                   " values (
                           '" & lblFeedID.Text & "',", DBresto)

        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblStats.Text = "New Data Added!"
        ShowData()
        resetcondition()
    End Sub

    Sub Updatingdata()
        CMDresto = New SqlCommand("UPDATE Customer set " &
                    "Feed_ID ='" & lblFeedID.Text & "'," &
                    "Trans_ID ='" & lblTransactionID.Text & "'", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblStats.Text = "Data Updated!"
        ShowData()
        resetcondition()
    End Sub

    Sub editcondition()
        enablecondition()
        btnConfirmation.Text = "Confirm Edit"
        If txtFeedDetail.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub editValidation()
        CMDresto = New SqlCommand("SELECT * FROM Feedback WHERE Feed_ID ='" & lblFeedID.Text & "'", DBresto)
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
        CMDresto = New SqlCommand(" DELETE from Feedback where Feed_ID ='" & dgFeedback.SelectedCells(0).Value & "'", DBresto)
        CMDresto.ExecuteNonQuery()
        ShowData()
        MsgBox("Succesfull Deleting data!")
        lblStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub FeedbackDBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowData()
        resetcondition()
        lblStats.Text = "Data Loaded!"
    End Sub

    Private Sub dgFeedback_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFeedback.CellClick
        Dim cusrow = dgFeedback.CurrentRow.Index
        With dgFeedback
            lblFeedID.Text = .Item(0, cusrow).Value
            .Text = .Item(1, cusrow).Value
            lblTransactionID.Text = .Item(2, cusrow).Value
            .Text = .Item(1, cusrow).Value
        End With
    End Sub

    Private Sub MsEditFeed_Click(sender As Object, e As EventArgs) Handles MsEditFeed.Click
        editValidation()
    End Sub

    Private Sub CmsEditFeed_Click(sender As Object, e As EventArgs) Handles CmsEditFeed.Click
        editValidation()
    End Sub

    Private Sub CmsDelData_Click(sender As Object, e As EventArgs) Handles CmsDelData.Click
        Deletingdata()
    End Sub

    Private Sub MsDeleteFeed_Click(sender As Object, e As EventArgs) Handles MsDeleteFeed.Click
        Deletingdata()
    End Sub

    Private Sub MsInsertFeed_Click(sender As Object, e As EventArgs) Handles MsInsertFeed.Click
        autoID()
    End Sub

    Private Sub CmsAddFeed_Click(sender As Object, e As EventArgs) Handles CmsAddFeed.Click
        autoID()
    End Sub

    Private Sub btnConfirmation_Click(sender As Object, e As EventArgs) Handles btnConfirmation.Click
        If btnConfirmation.Text = "Confirm Input" Then
            Addingdata()
        ElseIf btnConfirmation.Text = "Confirm Edit" Then
            Updatingdata()
        End If
    End Sub

    Private Sub dgFeedback_MouseClick(sender As Object, e As MouseEventArgs) Handles dgFeedback.MouseClick
        resetpartial()
    End Sub

    Private Sub msRefresh_Click(sender As Object, e As EventArgs) Handles msRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        AdptFeedback = New SqlDataAdapter("SELECT * FROM Feedback WHERE " & cmbSearchChoice.Text & " like '%" & txtFind.Text & "%'", DBresto)
        TblFeedback.Clear()
        AdptFeedback.Fill(TblFeedback)
        dgFeedback.DataSource = TblFeedback
    End Sub

    Private Sub CmsRefresh_Click(sender As Object, e As EventArgs) Handles CmsRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Sub SortingDataASC()
        AdptFeedback = New SqlDataAdapter("SELECT * FROM Feedback ORDER BY " & sortCategory & " ASC", DBresto)
        TblFeedback.Clear()
        AdptFeedback.Fill(TblFeedback)
        dgFeedback.DataSource = TblFeedback
    End Sub

    Sub SortingDataDESC()
        AdptFeedback = New SqlDataAdapter("SELECT * FROM Customer ORDER BY " & sortCategory & " DESC", DBresto)
        TblFeedback.Clear()
        AdptFeedback.Fill(TblFeedback)
        dgFeedback.DataSource = TblFeedback
    End Sub

    Private Sub MsIdAsc_Click(sender As Object, e As EventArgs) Handles MsIdAsc.Click
        sortCategory = "Feed_ID"
        SortingDataASC()
    End Sub

    Private Sub MsIdDesc_Click(sender As Object, e As EventArgs) Handles MsIdDesc.Click
        sortCategory = "Feed_ID"
        SortingDataDESC()
    End Sub

    Private Sub MsNameAsc_Click(sender As Object, e As EventArgs) Handles MsNameAsc.Click
        sortCategory = "Trans_ID"
        SortingDataASC()
    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub lblMenuID_Click(sender As Object, e As EventArgs) Handles lblFeedID.Click

    End Sub

    Private Sub MsNameDesc_Click(sender As Object, e As EventArgs) Handles MsNameDesc.Click
        sortCategory = "Trans_ID"
        SortingDataDESC()
    End Sub
End Class