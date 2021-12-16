Imports System.Data.SqlClient

Public Class MenuDBForm
    Dim CusGend, sortCategory As String
    Sub totalMenu()
        CMDresto = New SqlCommand("SELECT COUNT(Menu_ID) AS TOTAL_MENU FROM Menu", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Close()
        Dim totalmenu As Integer = Convert.ToInt16(CMDresto.ExecuteScalar())
        lblTotalMenu.Text = totalmenu.ToString
    End Sub



    Sub ShowData()
        AdptMenu = New SqlDataAdapter("SELECT * from Menu", DBresto)
        TblMenu.Clear()
        AdptMenu.Fill(TblMenu)
        dgMenu.DataSource = TblMenu
        resetcondition()
        resetValue()
        totalMenu()
    End Sub

    Sub resetValue()
        txtMenuName.Clear()
        txtMenuPrice.Clear()
        cmbSearchChoice.ResetText()
        txtFind.Clear()
    End Sub

    Sub resetcondition()
        btnConfirmation.Visible = False
        txtMenuName.Enabled = False
        txtMenuPrice.Enabled = False
        resetValue()
    End Sub

    Sub resetpartial()
        btnConfirmation.Visible = False
        txtMenuName.Enabled = False
        txtMenuPrice.Enabled = False
    End Sub

    Sub enablecondition()
        btnConfirmation.Visible = True
        txtMenuName.Enabled = True
        txtMenuPrice.Enabled = True
    End Sub

    Sub autoID()
        enablecondition()
        resetValue()
        btnConfirmation.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDresto = New SqlCommand("SELECT * FROM Menu WHERE Menu_ID IN (SELECT MAX(Menu_ID) FROM Menu)", DBresto)
        DTRresto = CMDresto.ExecuteReader
        DTRresto.Read()
        If Not DTRresto.HasRows Then
            propercode = "M" + "0001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRresto.GetString(0), 3) + 1
            propercode = "M" + Microsoft.VisualBasic.Right("000" & countcode, 3)
        End If
        lblMenuID.Text = propercode
        txtMenuName.Focus()
        DTRresto.Close()
    End Sub

    Sub Addingdata()
        CMDresto = New SqlCommand("insert into Menu " &
                   " values (
                           '" & lblMenuID.Text & "'," &
                   "'" & txtMenuName.Text & "'," &
                   "'" & txtMenuPrice.Text & "')", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblStats.Text = "New Data Added!"
        ShowData()
        resetcondition()
    End Sub

    Sub Updatingdata()
        CMDresto = New SqlCommand("UPDATE Menu set " &
                    "Menu_ID ='" & lblMenuID.Text & "'," &
                    "Menu_NAME ='" & txtMenuName.Text & "'" &
                    "Menu_PRICE = '" & txtMenuPrice.Text & "," & "' Where " &
                    "Menu_ID = '" & lblMenuID.Text & "'", DBresto)
        CMDresto.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblStats.Text = "Data Updated!"
        ShowData()
        resetcondition()
    End Sub

    Sub editcondition()
        enablecondition()
        btnConfirmation.Text = "Confirm Edit"
        If txtMenuName.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub editValidation()
        CMDresto = New SqlCommand("SELECT * FROM Menu WHERE Menu_ID ='" & lblMenuID.Text & "'", DBresto)
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
        CMDresto = New SqlCommand(" DELETE from Menu where Menu_ID ='" & dgMenu.SelectedCells(0).Value & "'", DBresto)
        CMDresto.ExecuteNonQuery()
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

    Private Sub dgCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMenu.CellClick
        Dim cusrow = dgMenu.CurrentRow.Index
        With dgMenu
            lblMenuID.Text = .Item(0, cusrow).Value
            txtMenuName.Text = .Item(1, cusrow).Value
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

    Private Sub dgCustomer_MouseClick(sender As Object, e As MouseEventArgs) Handles dgMenu.MouseClick
        resetpartial()
    End Sub

    Private Sub msRefresh_Click(sender As Object, e As EventArgs) Handles msRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        AdptMenu = New SqlDataAdapter("SELECT * FROM Menu WHERE " & cmbSearchChoice.Text & " like '%" & txtFind.Text & "%'", DBresto)
        TblMenu.Clear()
        AdptMenu.Fill(TblMenu)
        dgMenu.DataSource = TblMenu
    End Sub

    Private Sub CmsRefresh_Click(sender As Object, e As EventArgs) Handles CmsRefresh.Click
        ShowData()
        lblStats.Text = "Data Refreshed!"
    End Sub

    Sub SortingDataASC()
        AdptMenu = New SqlDataAdapter("SELECT * FROM Menu ORDER BY " & sortCategory & " ASC", DBresto)
        TblMenu.Clear()
        AdptMenu.Fill(TblMenu)
        dgMenu.DataSource = TblMenu
    End Sub

    Sub SortingDataDESC()
        AdptMenu = New SqlDataAdapter("SELECT * FROM Menu ORDER BY " & sortCategory & " DESC", DBresto)
        TblMenu.Clear()
        AdptMenu.Fill(TblMenu)
        dgMenu.DataSource = TblMenu
    End Sub

    Private Sub MsIdAsc_Click(sender As Object, e As EventArgs) Handles MsIdAsc.Click
        sortCategory = "Menu_ID"
        SortingDataASC()
    End Sub

    Private Sub MsIdDesc_Click(sender As Object, e As EventArgs) Handles MsIdDesc.Click
        sortCategory = "Menu_ID"
        SortingDataDESC()
    End Sub

    Private Sub MsNameAsc_Click(sender As Object, e As EventArgs) Handles MsNameAsc.Click
        sortCategory = "Menu_NAME"
        SortingDataASC()
    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cmbSearchChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchChoice.SelectedIndexChanged

    End Sub

    Private Sub lblMenuID_Click(sender As Object, e As EventArgs) Handles lblMenuID.Click

    End Sub

    Private Sub txtMenuName_TextChanged(sender As Object, e As EventArgs) Handles txtMenuName.TextChanged

    End Sub

    Private Sub lblTotalMenu_Click(sender As Object, e As EventArgs) Handles lblTotalMenu.Click

    End Sub

    Private Sub MsNameDesc_Click(sender As Object, e As EventArgs) Handles MsNameDesc.Click
        sortCategory = "Menu_NAME"
        SortingDataDESC()
    End Sub
End Class