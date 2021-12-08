Imports System.Data.SqlClient
Public Class EmployeeData
    Dim EmpGend As String
    Private Sub EmployeeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Connect()
        ShowEmployeeData()
        resetcondition()
        lblEmpStats.Text = "Data Loaded!"
    End Sub

    Sub ShowEmployeeData()
        AdptEmployee = New SqlDataAdapter("SELECT * FROM EmployeeData", DBicecream)
        TblEmployeeData.Clear()
        AdptEmployee.Fill(TblEmployeeData)
        dgEmp.DataSource = TblEmployeeData
    End Sub

    Private Sub dgEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmp.CellClick
        Dim emprow = dgEmp.CurrentRow.Index
        With dgEmp
            lblEmpID.Text = .Item(0, emprow).Value
            txtEmpName.Text = .Item(1, emprow).Value
            dtpEmpDOB.Value = .Item(2, emprow).Value
            If .Item(3, emprow).Value = "Male" Then
                rdEmpMale.Checked = True
            Else
                rdEmpFemale.Checked = True
            End If
            txtAdd.Text = .Item(4, emprow).Value
            mskEmpPhone.Text = .Item(5, emprow).Value
            txtEmpEmail.Text = .Item(6, emprow).Value
            txtEmpRole.Text = .Item(7, emprow).Value
            txtEmpUname.Text = .Item(8, emprow).Value
            txtEmpPass.Text = .Item(9, emprow).Value
        End With
    End Sub
    Sub resetValue()
        lblEmpID.Text = "Value ID"
        txtEmpName.Clear()
        dtpEmpDOB.ResetText()
        rdEmpMale.Checked = True
        rdEmpFemale.Checked = False
        txtAdd.Clear()
        mskEmpPhone.Clear()
        txtEmpEmail.Clear()
        txtEmpRole.Clear()
        txtEmpUname.Clear()
        txtEmpPass.Clear()
    End Sub

    Sub resetcondition()
        btnEmpConfirm.Visible = False
        txtEmpName.Enabled = False
        dtpEmpDOB.Enabled = False
        rdEmpFemale.Enabled = False
        rdEmpMale.Enabled = False
        txtAdd.Enabled = False
        mskEmpPhone.Enabled = False
        txtEmpEmail.Enabled = False
        txtEmpRole.Enabled = False
        txtEmpUname.Enabled = False
        txtEmpPass.Enabled = False
        resetValue()
    End Sub

    Sub enablecondition()
        btnEmpConfirm.Visible = True
        txtEmpName.Enabled = True
        dtpEmpDOB.Enabled = True
        rdEmpFemale.Enabled = True
        rdEmpMale.Enabled = True
        txtAdd.Enabled = True
        mskEmpPhone.Enabled = True
        txtEmpEmail.Enabled = True
        txtEmpRole.Enabled = True
        txtEmpUname.Enabled = True
        txtEmpPass.Enabled = True
    End Sub

    Sub autoID()
        enablecondition()
        resetValue()
        btnEmpConfirm.Text = "Confirm Input"
        Dim propercode As String
        Dim countcode As Long
        CMDiceJr = New SqlCommand("SELECT * FROM EmployeeData WHERE EMP_ID IN (SELECT MAX(EMP_ID) FROM EmployeeData)", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        DTRiceJr.Read()
        If Not DTRiceJr.HasRows Then
            propercode = "E" + "001"
        Else
            countcode = Microsoft.VisualBasic.Right(DTRiceJr.GetString(0), 3) + 1
            propercode = "E" + Microsoft.VisualBasic.Right("000" & countcode, 3)
        End If
        lblEmpID.Text = propercode
        txtEmpName.Focus()
        DTRiceJr.Close()
    End Sub

    Sub Addingdata()
        CMDiceJr = New SqlCommand("insert into EmployeeData " &
                   " values (
                   '" & lblEmpID.Text & "'," &
                   "'" & txtEmpName.Text & "'," &
                   "'" & dtpEmpDOB.Value.ToString("yyyy/MM/dd") & "'," &
                   "'" & EmpGend & "'," &
                   "'" & txtAdd.Text & "'," &
                   "'" & mskEmpPhone.Text & "'," &
                   "'" & txtEmpEmail.Text & "'," &
                   "'" & txtEmpRole.Text & "'," &
                   "'" & txtEmpUname.Text & "'," &
                   "'" & txtEmpPass.Text & "')", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Adding data!")
        lblEmpStats.Text = "New Data Added!"
        ShowEmployeeData()
        resetcondition()
    End Sub

    Sub Updatingdata()
        CMDiceJr = New SqlCommand("UPDATE EmployeeData set " &
                    "EMP_ID ='" & lblEmpID.Text & "'," &
                    "EMP_NAME ='" & txtEmpName.Text & "'," &
                    "EMP_DOB ='" & dtpEmpDOB.Value.ToString("yyyy/MM/dd") & "'," &
                    "EMP_GENDER ='" & EmpGend & "'," &
                    "EMP_ADDRESS ='" & txtAdd.Text & "'," &
                    "EMP_PHONE ='" & mskEmpPhone.Text & "'," &
                    "EMP_EMAIL ='" & txtEmpEmail.Text & "'," &
                    "EMP_ROLE ='" & txtEmpRole.Text & "'," &
                    "EMP_USERNAME ='" & txtEmpUname.Text & "'," &
                    "EMP_PASSWORD ='" & txtEmpPass.Text & "' where " &
                    "EMP_ID ='" & lblEmpID.Text & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        MsgBox("Succesfull Editting data!")
        lblEmpID.Text = "Data Updated!"
        ShowEmployeeData()
        resetcondition()
    End Sub

    Sub editcondition()
        enablecondition()
        btnEmpConfirm.Text = "Confirm Edit"
        If txtEmpName.Text Is "" Then
            resetcondition()
        End If
    End Sub

    Sub editValidation()
        CMDiceJr = New SqlCommand("SELECT * FROM EmployeeData WHERE EMP_ID ='" & lblEmpID.Text & "'", DBicecream)
        DTRiceJr = CMDiceJr.ExecuteReader
        If DTRiceJr.Read Then
            editcondition()
        Else
            MsgBox("Please Select Any data", MsgBoxStyle.Information, "Help")
            resetcondition()
        End If
        DTRiceJr.Close()
    End Sub
    Sub Deletingdata()
        CMDiceJr = New SqlCommand(" DELETE from EmployeeData where EMP_ID ='" & dgEmp.SelectedCells(0).Value & "'", DBicecream)
        CMDiceJr.ExecuteNonQuery()
        ShowEmployeeData()
        lblEmpStats.Text = "successfully Deleting Data!"
        resetcondition()
    End Sub

    Private Sub btnEmpConfirm_Click(sender As Object, e As EventArgs) Handles btnEmpConfirm.Click
        If rdEmpMale.Checked = True Then
            EmpGend = "Male"
        ElseIf rdEmpFemale.Checked = True Then
            EmpGend = "Female"
        End If
        If btnEmpConfirm.Text = "Confirm Input" Then
            Addingdata()
        ElseIf btnEmpConfirm.Text = "Confirm Edit" Then
            Updatingdata()
        End If
    End Sub

    Private Sub tsbAddEmp_Click(sender As Object, e As EventArgs) Handles tsbAddEmp.Click
        autoID()
    End Sub

    Private Sub tsbEditEmp_Click(sender As Object, e As EventArgs) Handles tsbEditEmp.Click
        editValidation()
    End Sub

    Private Sub tsbDeleteEmp_Click(sender As Object, e As EventArgs) Handles tsbDeleteEmp.Click
        Deletingdata()
    End Sub
End Class