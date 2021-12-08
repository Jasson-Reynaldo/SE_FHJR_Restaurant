Imports System.Data.SqlClient
Public Class ToppingData
    Private Sub ToppingData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowToppingData()
    End Sub
    Sub ShowToppingData()
        AdptTopping = New SqlDataAdapter("SELECT * FROM ToppingData", DBicecream)
        TblTopping.Clear()
        AdptTopping.Fill(TblTopping)
        dgTopping.DataSource = TblTopping
    End Sub

    Private Sub dgTopping_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTopping.CellClick
        Dim toprow = dgTopping.CurrentRow.Index
        Dim priceholder As Decimal
        With dgTopping
            lblTopId.Text = .Item(0, toprow).Value
            txtTopName.Text = .Item(1, toprow).Value
            priceholder = .Item(2, toprow).Value
            txtTopPrice.Text = priceholder.ToString
        End With
    End Sub

    Sub autoID()
        enablecondition()
        btnConfirm.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDiceJr = New SqlCommand("SELECT * FROM ToppingData WHERE TOPPING_ID IN (SELECT MAX(TOPPING_ID) FROM ToppingData)", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Read()
        If Not DTRiceJr.HasRows Then
            propercode = "T" + "001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRiceJr.GetString(0), 3) + 1
            propercode = "T" + Microsoft.VisualBasic.Right("000" & countcode, 3)
        End If
        lblTopId.Text = propercode
        txtTopName.Focus()
        DTRiceJr.Close()
    End Sub

    Sub Addingdata()
        CMDiceJr = New SqlCommand("insert into ToppingData " &
                   " values (
                   '" & lblTopId.Text & "'," &
                   "'" & txtTopName.Text & "'," &
                   "'" & txtTopPrice.Text & "')", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblTopStats.Text = "New Data Added!"
        ShowToppingData()
        resetcondition()
    End Sub

    Sub resetcondition()
        txtTopName.Clear()
        txtTopPrice.Clear()
        lblTopId.Text = "Value ID"
        txtTopName.Enabled = False
        txtTopPrice.Enabled = False
        btnConfirm.Visible = False
    End Sub

    Sub editValidation()
        CMDiceJr = New SqlCommand("SELECT * FROM ToppingData WHERE TOPPING_ID ='" & lblTopId.Text & "'", DBicecream)
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
        If txtTopName.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub enablecondition()
        txtTopName.Enabled = True
        txtTopPrice.Enabled = True
        btnConfirm.Visible = True
    End Sub

    Sub Updatingdata()
        CMDiceJr = New SqlCommand("UPDATE ToppingData SET " &
                    "TOPPING_ID ='" & lblTopId.Text & "'," &
                    "TOPPING_NAME ='" & txtTopName.Text & "'," &
                    "TOPPING_PRICE ='" & txtTopPrice.Text & "' where " &
                    "TOPPING_ID ='" & lblTopId.Text & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblTopStats.Text = "Data Updated!"
        ShowToppingData()
        resetcondition()
    End Sub

    Sub Deletingdata()
        CMDiceJr = New SqlCommand(" DELETE from ToppingData where TOPPING_ID ='" & dgTopping.SelectedCells(0).Value & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        ShowToppingData()
        lblTopStats.Text = "successfully Deleting Data!"
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