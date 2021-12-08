Imports System.Data.SqlClient
Public Class IceCreamData
    Private Sub IceCreamData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowIceData()
    End Sub
    Sub ShowIceData()
        AdptIceCream = New SqlDataAdapter("SELECT * FROM IceCreamData", DBicecream)
        TblIceCream.Clear()
        AdptIceCream.Fill(TblIceCream)
        dgIce.DataSource = TblIceCream
    End Sub

    Private Sub dgIce_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgIce.CellClick
        Dim Icerow = dgIce.CurrentRow.Index
        Dim priceholderIce As Decimal
        With dgIce
            lblIceId.Text = .Item(0, Icerow).Value
            txtIceName.Text = .Item(1, Icerow).Value
            priceholderIce = .Item(2, Icerow).Value
            txtIcePrice.Text = priceholderIce.ToString
        End With
    End Sub

    Sub autoID()
        enablecondition()
        btnConfirm.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDiceJr = New SqlCommand("SELECT * FROM IceCreamData WHERE ICECREAM_ID IN (SELECT MAX(ICECREAM_ID) FROM IceCreamData)", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Read()
        If Not DTRiceJr.HasRows Then
            propercode = "S" + "001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRiceJr.GetString(0), 3) + 1
            propercode = "S" + Microsoft.VisualBasic.Right("000" & countcode, 3)
        End If
        lblIceId.Text = propercode
        txtIceName.Focus()
        DTRiceJr.Close()
    End Sub

    Sub Addingdata()
        CMDiceJr = New SqlCommand("insert into IceCreamData " &
                   " values (
                   '" & lblIceId.Text & "'," &
                   "'" & txtIceName.Text & "'," &
                   "'" & txtIcePrice.Text & "')", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblIceStats.Text = "New Data Added!"
        ShowIceData()
        resetcondition()
    End Sub

    Sub resetcondition()
        txtIceName.Clear()
        txtIcePrice.Clear()
        lblIceId.Text = "Value ID"
        txtIceName.Enabled = False
        txtIcePrice.Enabled = False
        btnConfirm.Visible = False
    End Sub

    Sub editValidation()
        CMDiceJr = New SqlCommand("SELECT * FROM IceCreamData WHERE ICECREAM_ID ='" & lblIceId.Text & "'", DBicecream)
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
        If txtIceName.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub enablecondition()
        txtIceName.Enabled = True
        txtIcePrice.Enabled = True
        btnConfirm.Visible = True
    End Sub

    Sub Updatingdata()
        CMDiceJr = New SqlCommand("UPDATE IceCreamData SET " &
                    "ICECREAM_ID ='" & lblIceId.Text & "'," &
                    "ICECREAM_NAME ='" & txtIceName.Text & "'," &
                    "ICECREAM_PRICE ='" & txtIcePrice.Text & "' where " &
                    "ICECREAM_ID ='" & lblIceId.Text & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblIceStats.Text = "Data Updated!"
        ShowIceData()
        resetcondition()
    End Sub

    Sub Deletingdata()
        CMDiceJr = New SqlCommand(" DELETE from IceCreamData where ICECREAM_ID ='" & dgIce.SelectedCells(0).Value & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        ShowIceData()
        lblIceStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub tsbAddIce_Click(sender As Object, e As EventArgs) Handles tsbAddIce.Click
        autoID()
    End Sub

    Private Sub tsbEditIce_Click(sender As Object, e As EventArgs) Handles tsbEditIce.Click
        editValidation()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If btnConfirm.Text = "Confirm Input" Then
            Addingdata()
        ElseIf btnConfirm.Text = "Confirm Edit" Then
            Updatingdata()
        End If
    End Sub

    Private Sub tsbDeleteIce_Click(sender As Object, e As EventArgs) Handles tsbDeleteIce.Click
        Deletingdata()
    End Sub
End Class