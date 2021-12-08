Imports System.Data.SqlClient
Public Class OrderDBForm
    Dim CusGend, sortCategory As String
    Sub totalCus()
        CMDiceJr = New SqlCommand("SELECT COUNT(CUS_ID) AS TOTAL_CUSTOMER FROM Customer", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Close()
        Dim totalcus As Integer = Convert.ToInt16(CMDiceJr.ExecuteScalar())
        lblTotalMenu.Text = totalcus.ToString
    End Sub

    Sub ShowData()
        AdptCustomer = New SqlDataAdapter("SELECT * from Customer", DBicecream)
        TblCustomer.Clear()
        AdptCustomer.Fill(TblCustomer)
        dgCustomer.DataSource = TblCustomer
        resetcondition()
        resetValue()
        totalCus()
    End Sub

    Sub resetValue()

        txtOrderQty.Clear()
        cmbSearchChoice.ResetText()
        txtFind.Clear()
    End Sub

    Sub resetcondition()
        btnConfirmation.Visible = False

        txtOrderQty.Enabled = False
        resetValue()
    End Sub

    Sub resetpartial()
        btnConfirmation.Visible = False

        txtOrderQty.Enabled = False
    End Sub

    Sub enablecondition()
        btnConfirmation.Visible = True

        txtOrderQty.Enabled = True
    End Sub

    Sub autoID()
        enablecondition()
        resetValue()
        btnConfirmation.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDiceJr = New SqlCommand("SELECT * FROM Customer WHERE CUS_ID IN (SELECT MAX(CUS_ID) FROM Customer)", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Read()
        If Not DTRiceJr.HasRows Then
            propercode = "C" + "0000001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRiceJr.GetString(0), 7) + 1
            propercode = "C" + Microsoft.VisualBasic.Right("0000000" & countcode, 7)
        End If
        lblMenuID.Text = propercode

        DTRiceJr.Close()
    End Sub

    Sub Addingdata()
        CMDiceJr = New SqlCommand("insert into Customer " &
                   " values (
                           '" & lblMenuID.Text & "'," &

        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblStats.Text = "New Data Added!"
        ShowData()
        resetcondition()
    End Sub

    Sub Updatingdata()
        CMDiceJr = New SqlCommand("UPDATE Customer set " &
                    "CUS_ID ='" & lblMenuID.Text & "'," &
                    "CUS_NAME ='" & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
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
        CMDiceJr = New SqlCommand("SELECT * FROM Customer WHERE CUS_ID ='" & lblMenuID.Text & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            editcondition()
        Else
            MsgBox("Please Select    Any data", MsgBoxStyle.Information, "Help")
            resetcondition()
        End If
        DTRiceJr.Close()
    End Sub
    Sub Deletingdata()
        CMDiceJr = New SqlCommand(" DELETE from Customer where CUS_ID ='" & dgCustomer.SelectedCells(0).Value & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        ShowData()
        MsgBox("Succesfull Deleting data!")
        lblStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub CustomerDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowData()
        resetcondition()
        lblStats.Text = "Data Loaded!"
    End Sub

    Private Sub dgCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomer.CellClick
        Dim cusrow = dgCustomer.CurrentRow.Index
        With dgCustomer
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

    Private Sub dgCustomer_MouseClick(sender As Object, e As MouseEventArgs) Handles dgCustomer.MouseClick
        resetpartial()
    End Sub

    Private Sub msRefresh_Click(sender As Object, e As EventArgs) Handles msRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        AdptCustomer = New SqlDataAdapter("SELECT * FROM Customer WHERE " & cmbSearchChoice.Text & " like '%" & txtFind.Text & "%'", DBicecream)
        TblCustomer.Clear()
        AdptCustomer.Fill(TblCustomer)
        dgCustomer.DataSource = TblCustomer
    End Sub

    Private Sub CmsRefresh_Click(sender As Object, e As EventArgs) Handles CmsRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Sub SortingDataASC()
        AdptCustomer = New SqlDataAdapter("SELECT * FROM Customer ORDER BY " & sortCategory & " ASC", DBicecream)
        TblCustomer.Clear()
        AdptCustomer.Fill(TblCustomer)
        dgCustomer.DataSource = TblCustomer
    End Sub

    Sub SortingDataDESC()
        AdptCustomer = New SqlDataAdapter("SELECT * FROM Customer ORDER BY " & sortCategory & " DESC", DBicecream)
        TblCustomer.Clear()
        AdptCustomer.Fill(TblCustomer)
        dgCustomer.DataSource = TblCustomer
    End Sub

    Private Sub MsIdAsc_Click(sender As Object, e As EventArgs) Handles MsIdAsc.Click
        sortCategory = "CUS_ID"
        SortingDataASC()
    End Sub

    Private Sub MsIdDesc_Click(sender As Object, e As EventArgs) Handles MsIdDesc.Click
        sortCategory = "CUS_ID"
        SortingDataDESC()
    End Sub

    Private Sub MsNameAsc_Click(sender As Object, e As EventArgs) Handles MsNameAsc.Click
        sortCategory = "CUS_NAME"
        SortingDataASC()
    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub MsNameDesc_Click(sender As Object, e As EventArgs) Handles MsNameDesc.Click
        sortCategory = "CUS_NAME"
        SortingDataDESC()
    End Sub
End Class