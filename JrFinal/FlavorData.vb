Imports System.Data.SqlClient
Public Class FlavorData
    Private Sub FlavorData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowFlavData()
    End Sub

    Sub ShowFlavData()
        AdptFlavor = New SqlDataAdapter("SELECT * FROM FlavorData", DBicecream)
        TblFlavor.Clear()
        AdptFlavor.Fill(TblFlavor)
        dgFlav.DataSource = TblFlavor
    End Sub

    Private Sub dgFlav_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFlav.CellClick
        Dim Flavrow = dgFlav.CurrentRow.Index
        With dgFlav
            lblFlavID.Text = .Item(0, Flavrow).Value
            txtFlavorName.Text = .Item(1, Flavrow).Value
        End With
    End Sub


    Sub autoID()
        enablecondition()
        btnConfirm.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDiceJr = New SqlCommand("SELECT * FROM FlavorData WHERE FLAV_ID IN (SELECT MAX(FLAV_ID) FROM FlavorData)", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Read()
        If Not DTRiceJr.HasRows Then
            propercode = "F" + "001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRiceJr.GetString(0), 3) + 1
            propercode = "F" + Microsoft.VisualBasic.Right("000" & countcode, 3)
        End If
        lblFlavID.Text = propercode
        txtFlavorName.Focus()
        DTRiceJr.Close()
    End Sub

    Sub Addingdata()
        CMDiceJr = New SqlCommand("insert into FlavorData " &
                   " values (
                   '" & lblFlavID.Text & "'," &
                   "'" & txtFlavorName.Text & "')", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblFlavStats.Text = "New Data Added!"
        ShowFlavData()
        resetcondition()
    End Sub

    Sub resetcondition()
        txtFlavorName.Clear()
        lblFlavID.Text = "Value ID"
        txtFlavorName.Enabled = False
        btnConfirm.Visible = False
    End Sub

    Sub editValidation()
        CMDiceJr = New SqlCommand("SELECT * FROM FlavorData WHERE FLAV_ID ='" & lblFlavID.Text & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            editcondition()
        Else
            MsgBox("Please Select Any data", MsgBoxStyle.Information, "Help")
            resetcondition()
        End If
        DTRiceJr.Close()
    End Sub

    Sub editcondition()
        enablecondition()
        btnConfirm.Text = "Confirm Edit"
        If txtFlavorName.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub enablecondition()
        txtFlavorName.Enabled = True
        btnConfirm.Visible = True
    End Sub

    Sub Updatingdata()
        CMDiceJr = New SqlCommand("UPDATE FlavorData SET " &
                    "FLAV_ID ='" & lblFlavID.Text & "'," &
                    "FLAV_NAME ='" & txtFlavorName.Text & "' where " &
                    "FLAV_ID ='" & lblFlavID.Text & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblFlavStats.Text = "Data Updated!"
        ShowFlavData()
        resetcondition()
    End Sub

    Sub Deletingdata()
        CMDiceJr = New SqlCommand(" DELETE from FlavorData where FLAV_ID ='" & dgFlav.SelectedCells(0).Value & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        ShowFlavData()
        lblFlavStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        autoID()
    End Sub

    Private Sub tsbEdit_Click(sender As Object, e As EventArgs) Handles tsbEdit.Click
        editValidation()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If btnConfirm.Text = "Confirm Input" Then
            Addingdata()
        ElseIf btnConfirm.Text = "Confirm Edit" Then
            Updatingdata()
        End If
    End Sub

    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        Deletingdata()
    End Sub
End Class