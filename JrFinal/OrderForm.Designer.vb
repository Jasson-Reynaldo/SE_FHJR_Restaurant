<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderForm
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
        Me.components = New System.ComponentModel.Container()
        Me.tabOrder = New System.Windows.Forms.TabControl()
        Me.tabBD = New System.Windows.Forms.TabPage()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.dateDOB = New System.Windows.Forms.DateTimePicker()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblfordob = New System.Windows.Forms.Label()
        Me.lblforemail = New System.Windows.Forms.Label()
        Me.lblforphone = New System.Windows.Forms.Label()
        Me.lblforgender = New System.Windows.Forms.Label()
        Me.lblforname = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnResetorder = New System.Windows.Forms.Button()
        Me.btnPutOrder = New System.Windows.Forms.Button()
        Me.ckAddWaf = New System.Windows.Forms.CheckBox()
        Me.ckAddSun = New System.Windows.Forms.CheckBox()
        Me.ckAddCone = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTopWaf = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTopSun = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTopCone = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numWaf = New System.Windows.Forms.NumericUpDown()
        Me.numSun = New System.Windows.Forms.NumericUpDown()
        Me.numCone = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbWaf = New System.Windows.Forms.ComboBox()
        Me.cmbSun = New System.Windows.Forms.ComboBox()
        Me.cmbCone = New System.Windows.Forms.ComboBox()
        Me.ckWaf = New System.Windows.Forms.CheckBox()
        Me.ckSun = New System.Windows.Forms.CheckBox()
        Me.ckCone = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lsOutput = New System.Windows.Forms.ListView()
        Me.gbInvoice = New System.Windows.Forms.GroupBox()
        Me.btnNextOrder = New System.Windows.Forms.Button()
        Me.gbPayment = New System.Windows.Forms.GroupBox()
        Me.lblTotalprice = New System.Windows.Forms.Label()
        Me.lblTotalpay = New System.Windows.Forms.Label()
        Me.orderTool = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabOrder.SuspendLayout()
        Me.tabBD.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numWaf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.gbPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOrder
        '
        Me.tabOrder.Controls.Add(Me.tabBD)
        Me.tabOrder.Controls.Add(Me.TabPage2)
        Me.tabOrder.Controls.Add(Me.TabPage1)
        Me.tabOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabOrder.Location = New System.Drawing.Point(0, 0)
        Me.tabOrder.Name = "tabOrder"
        Me.tabOrder.SelectedIndex = 0
        Me.tabOrder.Size = New System.Drawing.Size(730, 525)
        Me.tabOrder.TabIndex = 0
        '
        'tabBD
        '
        Me.tabBD.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tabBD.Controls.Add(Me.mskPhone)
        Me.tabBD.Controls.Add(Me.dateDOB)
        Me.tabBD.Controls.Add(Me.rdMale)
        Me.tabBD.Controls.Add(Me.rdFemale)
        Me.tabBD.Controls.Add(Me.txtEmail)
        Me.tabBD.Controls.Add(Me.txtName)
        Me.tabBD.Controls.Add(Me.lblfordob)
        Me.tabBD.Controls.Add(Me.lblforemail)
        Me.tabBD.Controls.Add(Me.lblforphone)
        Me.tabBD.Controls.Add(Me.lblforgender)
        Me.tabBD.Controls.Add(Me.lblforname)
        Me.tabBD.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.tabBD.Location = New System.Drawing.Point(4, 22)
        Me.tabBD.Name = "tabBD"
        Me.tabBD.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBD.Size = New System.Drawing.Size(722, 499)
        Me.tabBD.TabIndex = 0
        Me.tabBD.Text = "Buyer's Profile"
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(221, 100)
        Me.mskPhone.Mask = "62800-0000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(122, 22)
        Me.mskPhone.TabIndex = 15
        '
        'dateDOB
        '
        Me.dateDOB.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.dateDOB.Location = New System.Drawing.Point(221, 196)
        Me.dateDOB.Name = "dateDOB"
        Me.dateDOB.Size = New System.Drawing.Size(280, 22)
        Me.dateDOB.TabIndex = 14
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.rdMale.ForeColor = System.Drawing.Color.White
        Me.rdMale.Location = New System.Drawing.Point(221, 262)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(59, 19)
        Me.rdMale.TabIndex = 12
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.rdFemale.ForeColor = System.Drawing.Color.White
        Me.rdFemale.Location = New System.Drawing.Point(221, 295)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(78, 19)
        Me.rdFemale.TabIndex = 13
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.Location = New System.Drawing.Point(221, 151)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(122, 22)
        Me.txtEmail.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(221, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(122, 22)
        Me.txtName.TabIndex = 11
        '
        'lblfordob
        '
        Me.lblfordob.AutoSize = True
        Me.lblfordob.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblfordob.ForeColor = System.Drawing.Color.White
        Me.lblfordob.Location = New System.Drawing.Point(70, 202)
        Me.lblfordob.Name = "lblfordob"
        Me.lblfordob.Size = New System.Drawing.Size(38, 15)
        Me.lblfordob.TabIndex = 4
        Me.lblfordob.Text = "DOB"
        '
        'lblforemail
        '
        Me.lblforemail.AutoSize = True
        Me.lblforemail.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblforemail.ForeColor = System.Drawing.Color.White
        Me.lblforemail.Location = New System.Drawing.Point(69, 151)
        Me.lblforemail.Name = "lblforemail"
        Me.lblforemail.Size = New System.Drawing.Size(46, 15)
        Me.lblforemail.TabIndex = 5
        Me.lblforemail.Text = "Email"
        '
        'lblforphone
        '
        Me.lblforphone.AutoSize = True
        Me.lblforphone.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblforphone.ForeColor = System.Drawing.Color.White
        Me.lblforphone.Location = New System.Drawing.Point(69, 100)
        Me.lblforphone.Name = "lblforphone"
        Me.lblforphone.Size = New System.Drawing.Size(113, 15)
        Me.lblforphone.TabIndex = 6
        Me.lblforphone.Text = "Phone Number"
        '
        'lblforgender
        '
        Me.lblforgender.AutoSize = True
        Me.lblforgender.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblforgender.ForeColor = System.Drawing.Color.White
        Me.lblforgender.Location = New System.Drawing.Point(69, 251)
        Me.lblforgender.Name = "lblforgender"
        Me.lblforgender.Size = New System.Drawing.Size(59, 15)
        Me.lblforgender.TabIndex = 7
        Me.lblforgender.Text = "Gender"
        '
        'lblforname
        '
        Me.lblforname.AutoSize = True
        Me.lblforname.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblforname.ForeColor = System.Drawing.Color.White
        Me.lblforname.Location = New System.Drawing.Point(69, 45)
        Me.lblforname.Name = "lblforname"
        Me.lblforname.Size = New System.Drawing.Size(48, 15)
        Me.lblforname.TabIndex = 8
        Me.lblforname.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnResetorder)
        Me.TabPage2.Controls.Add(Me.btnPutOrder)
        Me.TabPage2.Controls.Add(Me.ckAddWaf)
        Me.TabPage2.Controls.Add(Me.ckAddSun)
        Me.TabPage2.Controls.Add(Me.ckAddCone)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(722, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ordering"
        '
        'btnResetorder
        '
        Me.btnResetorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnResetorder.FlatAppearance.BorderSize = 0
        Me.btnResetorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResetorder.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnResetorder.Location = New System.Drawing.Point(610, 423)
        Me.btnResetorder.Name = "btnResetorder"
        Me.btnResetorder.Size = New System.Drawing.Size(83, 34)
        Me.btnResetorder.TabIndex = 5
        Me.btnResetorder.Text = "Reset"
        Me.orderTool.SetToolTip(Me.btnResetorder, "Reset The Order")
        Me.btnResetorder.UseVisualStyleBackColor = False
        '
        'btnPutOrder
        '
        Me.btnPutOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPutOrder.FlatAppearance.BorderSize = 0
        Me.btnPutOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPutOrder.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnPutOrder.Location = New System.Drawing.Point(610, 324)
        Me.btnPutOrder.Name = "btnPutOrder"
        Me.btnPutOrder.Size = New System.Drawing.Size(83, 78)
        Me.btnPutOrder.TabIndex = 4
        Me.btnPutOrder.Text = "Put Order"
        Me.orderTool.SetToolTip(Me.btnPutOrder, "Put the Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnPutOrder.UseVisualStyleBackColor = False
        '
        'ckAddWaf
        '
        Me.ckAddWaf.AutoSize = True
        Me.ckAddWaf.Enabled = False
        Me.ckAddWaf.Font = New System.Drawing.Font("Raleway Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ckAddWaf.ForeColor = System.Drawing.Color.White
        Me.ckAddWaf.Location = New System.Drawing.Point(403, 263)
        Me.ckAddWaf.Name = "ckAddWaf"
        Me.ckAddWaf.Size = New System.Drawing.Size(159, 15)
        Me.ckAddWaf.TabIndex = 3
        Me.ckAddWaf.Text = "Buy Additional  Topping"
        Me.ckAddWaf.UseVisualStyleBackColor = True
        '
        'ckAddSun
        '
        Me.ckAddSun.AutoSize = True
        Me.ckAddSun.Enabled = False
        Me.ckAddSun.Font = New System.Drawing.Font("Raleway Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ckAddSun.ForeColor = System.Drawing.Color.White
        Me.ckAddSun.Location = New System.Drawing.Point(215, 263)
        Me.ckAddSun.Name = "ckAddSun"
        Me.ckAddSun.Size = New System.Drawing.Size(159, 15)
        Me.ckAddSun.TabIndex = 3
        Me.ckAddSun.Text = "Buy Additional  Topping"
        Me.ckAddSun.UseVisualStyleBackColor = True
        '
        'ckAddCone
        '
        Me.ckAddCone.AutoSize = True
        Me.ckAddCone.Enabled = False
        Me.ckAddCone.Font = New System.Drawing.Font("Raleway Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ckAddCone.ForeColor = System.Drawing.Color.White
        Me.ckAddCone.Location = New System.Drawing.Point(27, 263)
        Me.ckAddCone.Name = "ckAddCone"
        Me.ckAddCone.Size = New System.Drawing.Size(159, 15)
        Me.ckAddCone.TabIndex = 3
        Me.ckAddCone.Text = "Buy Additional  Topping"
        Me.ckAddCone.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cmbTopWaf)
        Me.GroupBox4.Font = New System.Drawing.Font("Raleway Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(403, 288)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 185)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Additional Toppings For Ice Cream Waffle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Choose Topping"
        '
        'cmbTopWaf
        '
        Me.cmbTopWaf.Enabled = False
        Me.cmbTopWaf.FormattingEnabled = True
        Me.cmbTopWaf.Location = New System.Drawing.Point(25, 91)
        Me.cmbTopWaf.Name = "cmbTopWaf"
        Me.cmbTopWaf.Size = New System.Drawing.Size(121, 21)
        Me.cmbTopWaf.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbTopSun)
        Me.GroupBox3.Font = New System.Drawing.Font("Raleway Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(215, 288)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 185)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Toppings For Ice Cream Sundae"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Choose Topping"
        '
        'cmbTopSun
        '
        Me.cmbTopSun.Enabled = False
        Me.cmbTopSun.FormattingEnabled = True
        Me.cmbTopSun.Location = New System.Drawing.Point(25, 91)
        Me.cmbTopSun.Name = "cmbTopSun"
        Me.cmbTopSun.Size = New System.Drawing.Size(121, 21)
        Me.cmbTopSun.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTopCone)
        Me.GroupBox1.Font = New System.Drawing.Font("Raleway Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(27, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 185)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Toppings For Ice Cream Cone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Choose Topping"
        '
        'cmbTopCone
        '
        Me.cmbTopCone.Enabled = False
        Me.cmbTopCone.FormattingEnabled = True
        Me.cmbTopCone.Location = New System.Drawing.Point(25, 91)
        Me.cmbTopCone.Name = "cmbTopCone"
        Me.cmbTopCone.Size = New System.Drawing.Size(121, 21)
        Me.cmbTopCone.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numWaf)
        Me.GroupBox2.Controls.Add(Me.numSun)
        Me.GroupBox2.Controls.Add(Me.numCone)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbWaf)
        Me.GroupBox2.Controls.Add(Me.cmbSun)
        Me.GroupBox2.Controls.Add(Me.cmbCone)
        Me.GroupBox2.Controls.Add(Me.ckWaf)
        Me.GroupBox2.Controls.Add(Me.ckSun)
        Me.GroupBox2.Controls.Add(Me.ckCone)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(27, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ice Cream Type"
        '
        'numWaf
        '
        Me.numWaf.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.numWaf.Location = New System.Drawing.Point(290, 151)
        Me.numWaf.Name = "numWaf"
        Me.numWaf.Size = New System.Drawing.Size(54, 20)
        Me.numWaf.TabIndex = 6
        '
        'numSun
        '
        Me.numSun.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.numSun.Location = New System.Drawing.Point(290, 93)
        Me.numSun.Name = "numSun"
        Me.numSun.Size = New System.Drawing.Size(54, 20)
        Me.numSun.TabIndex = 6
        '
        'numCone
        '
        Me.numCone.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.numCone.Location = New System.Drawing.Point(288, 41)
        Me.numCone.Name = "numCone"
        Me.numCone.Size = New System.Drawing.Size(56, 20)
        Me.numCone.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(438, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Ice Cream Flavor"
        '
        'cmbWaf
        '
        Me.cmbWaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWaf.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.cmbWaf.FormattingEnabled = True
        Me.cmbWaf.Location = New System.Drawing.Point(433, 151)
        Me.cmbWaf.Name = "cmbWaf"
        Me.cmbWaf.Size = New System.Drawing.Size(121, 21)
        Me.cmbWaf.TabIndex = 4
        '
        'cmbSun
        '
        Me.cmbSun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSun.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.cmbSun.FormattingEnabled = True
        Me.cmbSun.Location = New System.Drawing.Point(433, 92)
        Me.cmbSun.Name = "cmbSun"
        Me.cmbSun.Size = New System.Drawing.Size(121, 21)
        Me.cmbSun.TabIndex = 4
        '
        'cmbCone
        '
        Me.cmbCone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCone.Font = New System.Drawing.Font("Raleway Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.cmbCone.FormattingEnabled = True
        Me.cmbCone.Location = New System.Drawing.Point(433, 41)
        Me.cmbCone.Name = "cmbCone"
        Me.cmbCone.Size = New System.Drawing.Size(121, 21)
        Me.cmbCone.TabIndex = 4
        '
        'ckWaf
        '
        Me.ckWaf.AutoSize = True
        Me.ckWaf.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ckWaf.Location = New System.Drawing.Point(60, 150)
        Me.ckWaf.Name = "ckWaf"
        Me.ckWaf.Size = New System.Drawing.Size(144, 19)
        Me.ckWaf.TabIndex = 3
        Me.ckWaf.Text = "Ice Cream Waffle"
        Me.ckWaf.UseVisualStyleBackColor = True
        '
        'ckSun
        '
        Me.ckSun.AutoSize = True
        Me.ckSun.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ckSun.Location = New System.Drawing.Point(60, 94)
        Me.ckSun.Name = "ckSun"
        Me.ckSun.Size = New System.Drawing.Size(154, 19)
        Me.ckSun.TabIndex = 3
        Me.ckSun.Text = "Ice Cream Sundae"
        Me.ckSun.UseVisualStyleBackColor = True
        '
        'ckCone
        '
        Me.ckCone.AutoSize = True
        Me.ckCone.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.ckCone.Location = New System.Drawing.Point(60, 40)
        Me.ckCone.Name = "ckCone"
        Me.ckCone.Size = New System.Drawing.Size(138, 19)
        Me.ckCone.TabIndex = 3
        Me.ckCone.Text = "Ice Cream Cone"
        Me.ckCone.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Amount"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lsOutput)
        Me.TabPage1.Controls.Add(Me.gbInvoice)
        Me.TabPage1.Controls.Add(Me.btnNextOrder)
        Me.TabPage1.Controls.Add(Me.gbPayment)
        Me.TabPage1.Font = New System.Drawing.Font("Raleway Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(722, 499)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Confirmation"
        '
        'lsOutput
        '
        Me.lsOutput.HideSelection = False
        Me.lsOutput.Location = New System.Drawing.Point(103, 33)
        Me.lsOutput.Name = "lsOutput"
        Me.lsOutput.Size = New System.Drawing.Size(526, 194)
        Me.lsOutput.TabIndex = 6
        Me.lsOutput.UseCompatibleStateImageBehavior = False
        '
        'gbInvoice
        '
        Me.gbInvoice.ForeColor = System.Drawing.Color.White
        Me.gbInvoice.Location = New System.Drawing.Point(103, 278)
        Me.gbInvoice.Name = "gbInvoice"
        Me.gbInvoice.Size = New System.Drawing.Size(526, 175)
        Me.gbInvoice.TabIndex = 5
        Me.gbInvoice.TabStop = False
        Me.gbInvoice.Text = "Buyer's Info"
        '
        'btnNextOrder
        '
        Me.btnNextOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNextOrder.FlatAppearance.BorderSize = 0
        Me.btnNextOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextOrder.ForeColor = System.Drawing.Color.White
        Me.btnNextOrder.Location = New System.Drawing.Point(103, 459)
        Me.btnNextOrder.Name = "btnNextOrder"
        Me.btnNextOrder.Size = New System.Drawing.Size(101, 32)
        Me.btnNextOrder.TabIndex = 4
        Me.btnNextOrder.Text = "Next Order"
        Me.orderTool.SetToolTip(Me.btnNextOrder, "Go To Next Order")
        Me.btnNextOrder.UseVisualStyleBackColor = False
        '
        'gbPayment
        '
        Me.gbPayment.Controls.Add(Me.lblTotalprice)
        Me.gbPayment.Controls.Add(Me.lblTotalpay)
        Me.gbPayment.ForeColor = System.Drawing.Color.White
        Me.gbPayment.Location = New System.Drawing.Point(103, 233)
        Me.gbPayment.Name = "gbPayment"
        Me.gbPayment.Size = New System.Drawing.Size(526, 39)
        Me.gbPayment.TabIndex = 1
        Me.gbPayment.TabStop = False
        Me.gbPayment.Text = "Payment"
        '
        'lblTotalprice
        '
        Me.lblTotalprice.AutoSize = True
        Me.lblTotalprice.Location = New System.Drawing.Point(146, 16)
        Me.lblTotalprice.Name = "lblTotalprice"
        Me.lblTotalprice.Size = New System.Drawing.Size(169, 15)
        Me.lblTotalprice.TabIndex = 0
        Me.lblTotalprice.Text = "Total Payment Amount"
        '
        'lblTotalpay
        '
        Me.lblTotalpay.AutoSize = True
        Me.lblTotalpay.Location = New System.Drawing.Point(22, 16)
        Me.lblTotalpay.Name = "lblTotalpay"
        Me.lblTotalpay.Size = New System.Drawing.Size(121, 15)
        Me.lblTotalpay.TabIndex = 0
        Me.lblTotalpay.Text = "Total Payment : "
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.Controls.Add(Me.tabOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrderForm"
        Me.Text = "Order"
        Me.tabOrder.ResumeLayout(False)
        Me.tabBD.ResumeLayout(False)
        Me.tabBD.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numWaf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.gbPayment.ResumeLayout(False)
        Me.gbPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabOrder As TabControl
    Friend WithEvents tabBD As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblforemail As Label
    Friend WithEvents lblforphone As Label
    Friend WithEvents lblforgender As Label
    Friend WithEvents lblforname As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSun As ComboBox
    Friend WithEvents cmbCone As ComboBox
    Friend WithEvents ckSun As CheckBox
    Friend WithEvents ckCone As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents numSun As NumericUpDown
    Friend WithEvents numCone As NumericUpDown
    Friend WithEvents ckWaf As CheckBox
    Friend WithEvents numWaf As NumericUpDown
    Friend WithEvents cmbWaf As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckAddCone As CheckBox
    Friend WithEvents btnResetorder As Button
    Friend WithEvents btnPutOrder As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbPayment As GroupBox
    Friend WithEvents lblTotalprice As Label
    Friend WithEvents lblTotalpay As Label
    Friend WithEvents btnNextOrder As Button
    Friend WithEvents gbInvoice As GroupBox
    Friend WithEvents dateDOB As DateTimePicker
    Friend WithEvents lblfordob As Label
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents lsOutput As ListView
    Friend WithEvents orderTool As ToolTip
    Friend WithEvents cmbTopCone As ComboBox
    Friend WithEvents ckAddWaf As CheckBox
    Friend WithEvents ckAddSun As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTopWaf As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTopSun As ComboBox
    Friend WithEvents Label1 As Label
End Class
