Imports System.Data.SqlClient
Public Class OrderFormSS
    Dim CustomerID, TransID, bname, email, gender, cusGend, strDate, bphone, iceorder(7), iceflavor(7), iceordamounts(7),
        iceprice(7), icesingleprice(7), coneflav, sunflav, addConeTop, addSunTop, addWafTop, paytype As String
    Dim DOB, nowDate As Date
    Dim ammTopCone, ammTopSun, ammTopWaf, priceTopCone, priceTopSun, priceTopWaf, bAge, icecounter, outcounter, iceconeamount, icesundaeamount, icewaffleamount, conePrice, sunPrice, totalPay As Integer
    Dim LineNum(7)

    Sub resetCondition()
        txtName.Clear()
        mskPhone.Clear()
        txtEmail.Clear()
        dateDOB.ResetText()
        rdMale.Checked = True
    End Sub

    Sub resetOrder()
        numCone.ResetText()
        numSun.ResetText()
        numWaf.ResetText()
        cmbCone.ResetText()
        cmbSun.ResetText()
        cmbTopWaf.ResetText()
        cmbWaf.ResetText()
        cmbTopCone.ResetText()
        cmbTopSun.ResetText()
    End Sub

    Sub determineConePrice()
        CMDiceJr = New SqlCommand("SELECT * FROM ToppingData WHERE TOPPING_NAME ='" & cmbTopCone.SelectedItem.ToString & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            priceTopCone = DTRiceJr(2)
        End If
        DTRiceJr.Close()
    End Sub

    Private Sub btnNextOrder_Click(sender As Object, e As EventArgs) Handles btnNextOrder.Click
        OrderStatusForm.chlboxOrder.Items.Add(gender + bname + "'s Order")
        lblTotalprice.Text = "Total Price"
        gbInvoice.Text = "Buyer's Info"
        autoID()
        AutoOrderID()
        defineLine()
        Adddata()
        AddOrder()
        AddInvoice()
        resetTotal()
        resetCondition()
    End Sub

    Sub determineSunPrice()
        CMDiceJr = New SqlCommand("SELECT * FROM ToppingData WHERE TOPPING_NAME ='" & cmbTopCone.SelectedItem.ToString & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            priceTopSun = DTRiceJr(2)
        End If
        DTRiceJr.Close()
    End Sub
    Sub determineWafPrice()
        CMDiceJr = New SqlCommand("SELECT * FROM ToppingData WHERE TOPPING_NAME ='" & cmbTopCone.SelectedItem.ToString & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            priceTopWaf = DTRiceJr(2)
        End If
        DTRiceJr.Close()
    End Sub

    Private Sub ckAddCone_CheckedChanged(sender As Object, e As EventArgs) Handles ckAddCone.CheckedChanged
        If ckAddCone.Checked Then
            cmbTopCone.Enabled = True
        Else
            cmbTopCone.Enabled = False
        End If
    End Sub

    Private Sub ckAddSun_CheckedChanged(sender As Object, e As EventArgs) Handles ckAddSun.CheckedChanged
        If ckAddSun.Checked Then
            cmbTopSun.Enabled = True
        Else
            cmbTopSun.Enabled = False
        End If
    End Sub


    Private Sub ckAddWaf_CheckedChanged(sender As Object, e As EventArgs) Handles ckAddWaf.CheckedChanged
        If ckAddWaf.Checked Then
            cmbTopWaf.Enabled = True
        Else
            cmbTopWaf.Enabled = False
        End If
    End Sub


    Sub addCombo()
        Dim cmbItems As String
        CMDiceJr = New SqlCommand("SELECT * FROM FlavorData", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        While DTRiceJr.Read()
            cmbItems = DTRiceJr.GetString(1)
            If cmbItems = "Original" Then
                Continue While
            End If
            cmbCone.Items.Add(cmbItems)
            cmbSun.Items.Add(cmbItems)
            cmbWaf.Items.Add(cmbItems)
        End While
        DTRiceJr.Close()
    End Sub

    Sub addCmbTop()
        Dim cmbItems1 As String
        CMDiceJr = New SqlCommand("SELECT * FROM ToppingData", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        While DTRiceJr.Read()
            cmbItems1 = DTRiceJr.GetString(1)
            cmbTopCone.Items.Add(cmbItems1)
            cmbTopSun.Items.Add(cmbItems1)
            cmbTopWaf.Items.Add(cmbItems1)
        End While
        DTRiceJr.Close()
    End Sub

    Sub Enableicecone()
        numCone.Enabled = True
        cmbCone.Enabled = True
        ckAddCone.Enabled = True
    End Sub

    Sub Enableicesundae()
        numSun.Enabled = True
        cmbSun.Enabled = True
        ckAddSun.Enabled = True
    End Sub

    Sub Enableicewaffle()
        numWaf.Enabled = True
        cmbWaf.Enabled = True
        ckAddWaf.Enabled = True
    End Sub
    Sub Disableicecone()
        numCone.Enabled = False
        cmbCone.Enabled = False
        ckAddCone.Enabled = False
    End Sub

    Sub Disableicesundae()
        numSun.Enabled = False
        cmbSun.Enabled = False
        ckAddSun.Enabled = False
    End Sub

    Sub Disableicewaffle()
        numWaf.Enabled = False
        cmbWaf.Enabled = False
        ckAddWaf.Enabled = False
    End Sub

    Sub Resetcheckbox()
        ckAddCone.Checked = False
        ckAddSun.Checked = False
        ckAddWaf.Checked = False
        ckCone.Checked = False
        ckSun.Checked = False
        ckWaf.Checked = False
    End Sub


    Private Sub IceStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        icecounter = -1
        outcounter = 0
        DB_Connect()
        addCombo()
        addCmbTop()
        invoiceTemplate()
        resetCondition()
    End Sub

    Private Sub rdMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged
        gender = "Mr. "
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemale.CheckedChanged
        gender = "Ms. "
    End Sub

    Sub buyersData()
        bname = txtName.Text.ToString
        email = txtEmail.Text.ToString
        DOB = dateDOB.Value
        strDate = DOB.Date.ToString("dd/MM/yyyy")
        bphone = mskPhone.Text.ToString
        nowDate = Date.Now()
        bAge = nowDate.Year - DOB.Year
        If (DOB.Month - nowDate.Month) <= 0 Then
            If (DOB.Day - nowDate.Day) < 0 Then
                bAge -= 1
            End If
        End If
        totalPay = 0
        totalPay = sumtotalpay(totalPay)
        gbInvoice.Text = "=== Invoice ===" + vbCrLf + vbCrLf +
                        "Order date: " + nowDate.ToString + vbCrLf + vbCrLf +
                        gender + bname + vbCrLf +
                        "Age: " + bAge.ToString + vbCrLf +
                        "Phone Number: " + bphone + vbCrLf +
                        "Email: " + email + vbCrLf +
                        "Total Shopping: IDR " + totalPay.ToString + vbCrLf +
                        "Thank you for coming, and have a nice day :D"
        lblTotalprice.Text = "IDR " + totalPay.ToString
    End Sub

    Private Sub ckCone_CheckedChanged(sender As Object, e As EventArgs) Handles ckCone.CheckedChanged
        If ckCone.Checked Then
            Enableicecone()
        Else
            Disableicecone()
        End If
    End Sub

    Private Sub ckSun_CheckedChanged(sender As Object, e As EventArgs) Handles ckSun.CheckedChanged
        If ckSun.Checked Then
            Enableicesundae()
        Else
            Disableicesundae()
        End If
    End Sub

    Private Sub ckwaf_CheckedChanged(sender As Object, e As EventArgs) Handles ckWaf.CheckedChanged
        If ckWaf.Checked Then
            Enableicewaffle()
        Else
            Disableicewaffle()
        End If
    End Sub



    Private Sub btnPutOrder_Click(sender As Object, e As EventArgs) Handles btnPutOrder.Click
        If ckCone.Checked Then
            icecounter = icecounter + 1
            iceconeamount = numCone.Text
            iceordamounts(icecounter) = iceconeamount.ToString
            iceflavor(icecounter) = cmbCone.SelectedItem.ToString
            iceprice(icecounter) = 10000 * iceconeamount
            iceorder(icecounter) = ckCone.Text
            icesingleprice(icecounter) = 10000
        End If

        If ckSun.Checked Then
            icecounter = icecounter + 1
            icesundaeamount = numSun.Text
            iceordamounts(icecounter) = icesundaeamount.ToString
            iceflavor(icecounter) = cmbSun.SelectedItem.ToString
            iceprice(icecounter) = 15000 * icesundaeamount
            iceorder(icecounter) = ckSun.Text
            icesingleprice(icecounter) = 15000
        End If

        If ckWaf.Checked Then
            icecounter = icecounter + 1
            icewaffleamount = numWaf.Text
            iceordamounts(icecounter) = icewaffleamount.ToString
            iceflavor(icecounter) = cmbWaf.SelectedItem.ToString
            iceprice(icecounter) = 18000 * icewaffleamount
            iceorder(icecounter) = ckWaf.Text
            icesingleprice(icecounter) = 18000
        End If

        If ckAddCone.Checked Then
            icecounter = icecounter + 1
            addConeTop = cmbTopCone.SelectedItem.ToString
            determineConePrice()
            ammTopCone = iceconeamount
            iceorder(icecounter) = addConeTop
            iceflavor(icecounter) = "Original"
            iceordamounts(icecounter) = ammTopCone.ToString
            iceprice(icecounter) = priceTopCone * ammTopCone
            icesingleprice(icecounter) = priceTopCone
        End If

        If ckAddSun.Checked Then
            icecounter = icecounter + 1
            addSunTop = cmbTopSun.SelectedItem.ToString
            determineSunPrice()
            ammTopSun = icesundaeamount
            iceorder(icecounter) = addSunTop
            iceflavor(icecounter) = "Original"
            iceordamounts(icecounter) = ammTopSun.ToString
            iceprice(icecounter) = priceTopSun * ammTopSun
            icesingleprice(icecounter) = priceTopSun
        End If

        If ckAddWaf.Checked Then
            icecounter = icecounter + 1
            addWafTop = cmbTopWaf.SelectedItem.ToString
            determineWafPrice()
            ammTopWaf = icewaffleamount
            iceorder(icecounter) = addWafTop
            iceflavor(icecounter) = "Original"
            iceordamounts(icecounter) = ammTopWaf.ToString
            iceprice(icecounter) = priceTopWaf * ammTopWaf
            icesingleprice(icecounter) = priceTopWaf
        End If

        btnPutOrder.Enabled = False
        buyersData()
        invoiceprint()
    End Sub

    Function sumtotalpay(ByVal pricing As Integer) As Integer
        Dim priceholder As Integer = pricing
        outcounter = 0
        While outcounter <= icecounter
            priceholder += iceprice(outcounter)
            outcounter += 1
        End While
        Return priceholder
    End Function

    Private Sub btnResetorder_Click(sender As Object, e As EventArgs) Handles btnResetorder.Click
        resetTotal()
    End Sub

    Sub resetTotal()
        Disableicecone()
        Disableicesundae()
        Disableicewaffle()
        Resetcheckbox()
        resetOrder()
        Erase iceorder
        Erase iceflavor
        Erase iceordamounts
        Erase iceprice
        ReDim iceorder(7)
        ReDim iceflavor(7)
        ReDim iceordamounts(7)
        ReDim iceprice(7)
        icecounter = -1
        outcounter = 0
        btnPutOrder.Enabled = True
        lsOutput.Items.Clear()
    End Sub

    Sub invoiceTemplate()
        lsOutput.View = View.Details
        lsOutput.GridLines = True
        lsOutput.FullRowSelect = True

        lsOutput.Columns.Add("Items", 100)
        lsOutput.Columns.Add("Flavor", 100)
        lsOutput.Columns.Add("Qty", 100)
        lsOutput.Columns.Add("Total Price", 100)
    End Sub
    Sub invoiceprint()
        Dim invoice(4) As String
        Dim items As ListViewItem
        outcounter = 0
        While outcounter <= icecounter
            invoice(0) = iceorder(outcounter)
            invoice(1) = iceflavor(outcounter)
            invoice(2) = iceordamounts(outcounter)
            invoice(3) = "IDR " + iceprice(outcounter).ToString
            outcounter = outcounter + 1
            items = New ListViewItem(invoice)
            lsOutput.Items.Add(items)
        End While
    End Sub

    Sub autoID()
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
        CustomerID = propercode
        DTRiceJr.Close()
    End Sub

    Sub Adddata()
        If rdMale.Checked = True Then
            cusGend = "Male"
        ElseIf rdFemale.Checked = True Then
            cusGend = "Female"
        End If
        CMDiceJr = New SqlCommand("insert into Customer " &
                   " values (
                   '" & CustomerID & "'," &
                   "'" & txtName.Text & "'," &
                   "'" & dateDOB.Value.ToString("yyyy/MM/dd") & "'," &
                   "'" & cusGend & "'," &
                   "'" & mskPhone.Text & "'," &
                   "'" & txtEmail.Text & "')", DBicecream)
        CMDiceJr.ExecuteNonQuery()
    End Sub

    Sub AddInvoice()
        outcounter = 0
        While outcounter <= icecounter
            CMDiceJr = New SqlCommand("INSERT INTO LineOrder " &
           " values (
           '" & TransID & "'," &
           "'" & LineNum(outcounter) & "'," &
           "'" & iceorder(outcounter) & "'," &
           "'" & iceflavor(outcounter) & "'," &
           "'" & icesingleprice(outcounter) & "'," &
           "'" & iceordamounts(outcounter) & "'," &
           "'" & iceprice(outcounter).ToString & "')", DBicecream)
            CMDiceJr.ExecuteNonQuery()
            outcounter += 1
        End While
    End Sub

    Sub AddOrder()
        CMDiceJr = New SqlCommand("INSERT INTO OrderData " &
           " values (
           '" & TransID & "'," &
           "'" & nowDate.ToString("yyyy/MM/dd") & "'," &
           "'" & totalPay.ToString & "'," &
           "'" & CustomerID & "')", DBicecream)
        CMDiceJr.ExecuteNonQuery()
    End Sub

    Sub AutoOrderID()
        Dim propercode1 As String
        Dim countcode1 As Long
        CMDiceJr = New SqlCommand("SELECT * FROM OrderData WHERE ORDER_ID IN (SELECT MAX(ORDER_ID) FROM OrderData)", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Read()
        If Not DTRiceJr.HasRows Then
            propercode1 = "O" + "0000001"
        Else
            countcode1 = Microsoft.VisualBasic.Right(DTRiceJr.GetString(0), 7) + 1
            propercode1 = "O" + Microsoft.VisualBasic.Right("0000000" & countcode1, 7)
        End If
        TransID = propercode1
        DTRiceJr.Close()
    End Sub

    Sub defineLine()
        LineNum(0) = 1
        LineNum(1) = 2
        LineNum(2) = 3
        LineNum(3) = 4
        LineNum(4) = 5
        LineNum(5) = 6
        LineNum(6) = 7
    End Sub

End Class