<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeData))
        Me.MenuToolEmployee = New System.Windows.Forms.ToolStrip()
        Me.tsbAddEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeleteEmp = New System.Windows.Forms.ToolStripButton()
        Me.dgEmp = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtEmpEmail = New System.Windows.Forms.TextBox()
        Me.txtEmpRole = New System.Windows.Forms.TextBox()
        Me.txtEmpUname = New System.Windows.Forms.TextBox()
        Me.txtEmpPass = New System.Windows.Forms.TextBox()
        Me.dtpEmpDOB = New System.Windows.Forms.DateTimePicker()
        Me.rdEmpMale = New System.Windows.Forms.RadioButton()
        Me.rdEmpFemale = New System.Windows.Forms.RadioButton()
        Me.mskEmpPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnEmpConfirm = New System.Windows.Forms.Button()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.EmpStatus = New System.Windows.Forms.StatusStrip()
        Me.lblEmpStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuToolEmployee.SuspendLayout()
        CType(Me.dgEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuToolEmployee
        '
        Me.MenuToolEmployee.AutoSize = False
        Me.MenuToolEmployee.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuToolEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAddEmp, Me.tsbEditEmp, Me.tsbDeleteEmp})
        Me.MenuToolEmployee.Location = New System.Drawing.Point(0, 0)
        Me.MenuToolEmployee.Name = "MenuToolEmployee"
        Me.MenuToolEmployee.Size = New System.Drawing.Size(530, 30)
        Me.MenuToolEmployee.TabIndex = 0
        Me.MenuToolEmployee.Text = "MenuTool"
        '
        'tsbAddEmp
        '
        Me.tsbAddEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddEmp.Image = CType(resources.GetObject("tsbAddEmp.Image"), System.Drawing.Image)
        Me.tsbAddEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddEmp.Name = "tsbAddEmp"
        Me.tsbAddEmp.Size = New System.Drawing.Size(29, 27)
        Me.tsbAddEmp.Text = "Add Data"
        '
        'tsbEditEmp
        '
        Me.tsbEditEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditEmp.Image = CType(resources.GetObject("tsbEditEmp.Image"), System.Drawing.Image)
        Me.tsbEditEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditEmp.Name = "tsbEditEmp"
        Me.tsbEditEmp.Size = New System.Drawing.Size(29, 27)
        Me.tsbEditEmp.Text = "Edit Data"
        '
        'tsbDeleteEmp
        '
        Me.tsbDeleteEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDeleteEmp.Image = CType(resources.GetObject("tsbDeleteEmp.Image"), System.Drawing.Image)
        Me.tsbDeleteEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeleteEmp.Name = "tsbDeleteEmp"
        Me.tsbDeleteEmp.Size = New System.Drawing.Size(29, 27)
        Me.tsbDeleteEmp.Text = "Delete Data"
        '
        'dgEmp
        '
        Me.dgEmp.AllowUserToAddRows = False
        Me.dgEmp.AllowUserToDeleteRows = False
        Me.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmp.Location = New System.Drawing.Point(40, 308)
        Me.dgEmp.Name = "dgEmp"
        Me.dgEmp.ReadOnly = True
        Me.dgEmp.Size = New System.Drawing.Size(449, 174)
        Me.dgEmp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee DOB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Employee Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Employee Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Employee Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Employee Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Employee Role"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(275, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Employee Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(275, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Employee Username"
        '
        'txtEmpName
        '
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Location = New System.Drawing.Point(137, 97)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(113, 20)
        Me.txtEmpName.TabIndex = 3
        '
        'txtAdd
        '
        Me.txtAdd.Enabled = False
        Me.txtAdd.Location = New System.Drawing.Point(137, 227)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(113, 20)
        Me.txtAdd.TabIndex = 3
        '
        'txtEmpEmail
        '
        Me.txtEmpEmail.Enabled = False
        Me.txtEmpEmail.Location = New System.Drawing.Point(399, 104)
        Me.txtEmpEmail.Name = "txtEmpEmail"
        Me.txtEmpEmail.Size = New System.Drawing.Size(113, 20)
        Me.txtEmpEmail.TabIndex = 3
        '
        'txtEmpRole
        '
        Me.txtEmpRole.Enabled = False
        Me.txtEmpRole.Location = New System.Drawing.Point(399, 144)
        Me.txtEmpRole.Name = "txtEmpRole"
        Me.txtEmpRole.Size = New System.Drawing.Size(113, 20)
        Me.txtEmpRole.TabIndex = 3
        '
        'txtEmpUname
        '
        Me.txtEmpUname.Enabled = False
        Me.txtEmpUname.Location = New System.Drawing.Point(399, 184)
        Me.txtEmpUname.Name = "txtEmpUname"
        Me.txtEmpUname.Size = New System.Drawing.Size(113, 20)
        Me.txtEmpUname.TabIndex = 3
        '
        'txtEmpPass
        '
        Me.txtEmpPass.Enabled = False
        Me.txtEmpPass.Location = New System.Drawing.Point(399, 224)
        Me.txtEmpPass.Name = "txtEmpPass"
        Me.txtEmpPass.Size = New System.Drawing.Size(113, 20)
        Me.txtEmpPass.TabIndex = 3
        '
        'dtpEmpDOB
        '
        Me.dtpEmpDOB.Enabled = False
        Me.dtpEmpDOB.Location = New System.Drawing.Point(137, 140)
        Me.dtpEmpDOB.Name = "dtpEmpDOB"
        Me.dtpEmpDOB.Size = New System.Drawing.Size(113, 20)
        Me.dtpEmpDOB.TabIndex = 4
        '
        'rdEmpMale
        '
        Me.rdEmpMale.AutoSize = True
        Me.rdEmpMale.Location = New System.Drawing.Point(137, 191)
        Me.rdEmpMale.Name = "rdEmpMale"
        Me.rdEmpMale.Size = New System.Drawing.Size(48, 17)
        Me.rdEmpMale.TabIndex = 5
        Me.rdEmpMale.TabStop = True
        Me.rdEmpMale.Text = "Male"
        Me.rdEmpMale.UseVisualStyleBackColor = True
        '
        'rdEmpFemale
        '
        Me.rdEmpFemale.AutoSize = True
        Me.rdEmpFemale.Location = New System.Drawing.Point(191, 191)
        Me.rdEmpFemale.Name = "rdEmpFemale"
        Me.rdEmpFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdEmpFemale.TabIndex = 5
        Me.rdEmpFemale.TabStop = True
        Me.rdEmpFemale.Text = "Female"
        Me.rdEmpFemale.UseVisualStyleBackColor = True
        '
        'mskEmpPhone
        '
        Me.mskEmpPhone.Enabled = False
        Me.mskEmpPhone.Location = New System.Drawing.Point(399, 54)
        Me.mskEmpPhone.Mask = "628-000-000-0000"
        Me.mskEmpPhone.Name = "mskEmpPhone"
        Me.mskEmpPhone.Size = New System.Drawing.Size(113, 20)
        Me.mskEmpPhone.TabIndex = 6
        '
        'btnEmpConfirm
        '
        Me.btnEmpConfirm.Location = New System.Drawing.Point(221, 264)
        Me.btnEmpConfirm.Name = "btnEmpConfirm"
        Me.btnEmpConfirm.Size = New System.Drawing.Size(75, 38)
        Me.btnEmpConfirm.TabIndex = 7
        Me.btnEmpConfirm.Text = "Confirm"
        Me.btnEmpConfirm.UseVisualStyleBackColor = True
        Me.btnEmpConfirm.Visible = False
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(137, 58)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(45, 13)
        Me.lblEmpID.TabIndex = 8
        Me.lblEmpID.Text = "ValueID"
        '
        'EmpStatus
        '
        Me.EmpStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmpStats})
        Me.EmpStatus.Location = New System.Drawing.Point(0, 503)
        Me.EmpStatus.Name = "EmpStatus"
        Me.EmpStatus.Size = New System.Drawing.Size(530, 22)
        Me.EmpStatus.TabIndex = 9
        Me.EmpStatus.Text = "StatusStrip1"
        '
        'lblEmpStats
        '
        Me.lblEmpStats.Name = "lblEmpStats"
        Me.lblEmpStats.Size = New System.Drawing.Size(39, 17)
        Me.lblEmpStats.Text = "Status"
        '
        'EmployeeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(530, 525)
        Me.Controls.Add(Me.EmpStatus)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.btnEmpConfirm)
        Me.Controls.Add(Me.mskEmpPhone)
        Me.Controls.Add(Me.rdEmpFemale)
        Me.Controls.Add(Me.rdEmpMale)
        Me.Controls.Add(Me.dtpEmpDOB)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtEmpPass)
        Me.Controls.Add(Me.txtEmpUname)
        Me.Controls.Add(Me.txtEmpRole)
        Me.Controls.Add(Me.txtEmpEmail)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgEmp)
        Me.Controls.Add(Me.MenuToolEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeData"
        Me.MenuToolEmployee.ResumeLayout(False)
        Me.MenuToolEmployee.PerformLayout()
        CType(Me.dgEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpStatus.ResumeLayout(False)
        Me.EmpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuToolEmployee As ToolStrip
    Friend WithEvents tsbAddEmp As ToolStripButton
    Friend WithEvents tsbEditEmp As ToolStripButton
    Friend WithEvents tsbDeleteEmp As ToolStripButton
    Friend WithEvents dgEmp As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtEmpEmail As TextBox
    Friend WithEvents txtEmpRole As TextBox
    Friend WithEvents txtEmpUname As TextBox
    Friend WithEvents txtEmpPass As TextBox
    Friend WithEvents dtpEmpDOB As DateTimePicker
    Friend WithEvents rdEmpMale As RadioButton
    Friend WithEvents rdEmpFemale As RadioButton
    Friend WithEvents mskEmpPhone As MaskedTextBox
    Friend WithEvents btnEmpConfirm As Button
    Friend WithEvents lblEmpID As Label
    Friend WithEvents EmpStatus As StatusStrip
    Friend WithEvents lblEmpStats As ToolStripStatusLabel
End Class
