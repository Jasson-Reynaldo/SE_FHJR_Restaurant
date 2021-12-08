<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDataForm
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
        Me.pnlDataMenu = New System.Windows.Forms.Panel()
        Me.MsCustomer = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsInsertCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsEditCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsDeleteCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsName = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsNameAsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsNameDesc = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortByAgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsIdAsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsIdDesc = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMainData = New System.Windows.Forms.Panel()
        Me.splitCus = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConfirmation = New System.Windows.Forms.Button()
        Me.lblCusID = New System.Windows.Forms.Label()
        Me.mskPhoneCus = New System.Windows.Forms.MaskedTextBox()
        Me.dtpCus = New System.Windows.Forms.DateTimePicker()
        Me.rdMaleCus = New System.Windows.Forms.RadioButton()
        Me.rdFemaleCus = New System.Windows.Forms.RadioButton()
        Me.txtCusEmail = New System.Windows.Forms.TextBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbGend = New System.Windows.Forms.ComboBox()
        Me.cmbSearchChoice = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.lblTotalCus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblmenutitle = New System.Windows.Forms.Label()
        Me.StatsCus = New System.Windows.Forms.StatusStrip()
        Me.lblStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgCustomer = New System.Windows.Forms.DataGridView()
        Me.cmsCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsAddCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsDelData = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsEditCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlDataMenu.SuspendLayout()
        Me.MsCustomer.SuspendLayout()
        Me.pnlMainData.SuspendLayout()
        CType(Me.splitCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitCus.Panel1.SuspendLayout()
        Me.splitCus.Panel2.SuspendLayout()
        Me.splitCus.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatsCus.SuspendLayout()
        CType(Me.dgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDataMenu
        '
        Me.pnlDataMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlDataMenu.Controls.Add(Me.MsCustomer)
        Me.pnlDataMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDataMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlDataMenu.Name = "pnlDataMenu"
        Me.pnlDataMenu.Size = New System.Drawing.Size(730, 28)
        Me.pnlDataMenu.TabIndex = 0
        '
        'MsCustomer
        '
        Me.MsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MsCustomer.Location = New System.Drawing.Point(0, 0)
        Me.MsCustomer.Name = "MsCustomer"
        Me.MsCustomer.Size = New System.Drawing.Size(730, 24)
        Me.MsCustomer.TabIndex = 0
        Me.MsCustomer.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRefresh, Me.MsInsertCus, Me.MsEditCus, Me.MsDeleteCus})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DataToolStripMenuItem.Text = "Tools"
        '
        'msRefresh
        '
        Me.msRefresh.Name = "msRefresh"
        Me.msRefresh.Size = New System.Drawing.Size(140, 22)
        Me.msRefresh.Text = "Refresh Data"
        '
        'MsInsertCus
        '
        Me.MsInsertCus.Name = "MsInsertCus"
        Me.MsInsertCus.Size = New System.Drawing.Size(140, 22)
        Me.MsInsertCus.Text = "Insert Data"
        '
        'MsEditCus
        '
        Me.MsEditCus.Name = "MsEditCus"
        Me.MsEditCus.Size = New System.Drawing.Size(140, 22)
        Me.MsEditCus.Text = "Update Data"
        '
        'MsDeleteCus
        '
        Me.MsDeleteCus.Name = "MsDeleteCus"
        Me.MsDeleteCus.Size = New System.Drawing.Size(140, 22)
        Me.MsDeleteCus.Text = "Delete Data"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsName, Me.SortByAgeToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ToolsToolStripMenuItem.Text = "Views"
        '
        'MsName
        '
        Me.MsName.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsNameAsc, Me.MsNameDesc})
        Me.MsName.Name = "MsName"
        Me.MsName.Size = New System.Drawing.Size(172, 22)
        Me.MsName.Text = "Sort data by Name"
        '
        'MsNameAsc
        '
        Me.MsNameAsc.Name = "MsNameAsc"
        Me.MsNameAsc.Size = New System.Drawing.Size(136, 22)
        Me.MsNameAsc.Text = "Ascending"
        '
        'MsNameDesc
        '
        Me.MsNameDesc.Name = "MsNameDesc"
        Me.MsNameDesc.Size = New System.Drawing.Size(136, 22)
        Me.MsNameDesc.Text = "Descending"
        '
        'SortByAgeToolStripMenuItem
        '
        Me.SortByAgeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsIdAsc, Me.MsIdDesc})
        Me.SortByAgeToolStripMenuItem.Name = "SortByAgeToolStripMenuItem"
        Me.SortByAgeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SortByAgeToolStripMenuItem.Text = "Sort by ID"
        '
        'MsIdAsc
        '
        Me.MsIdAsc.Name = "MsIdAsc"
        Me.MsIdAsc.Size = New System.Drawing.Size(136, 22)
        Me.MsIdAsc.Text = "Ascending"
        '
        'MsIdDesc
        '
        Me.MsIdDesc.Name = "MsIdDesc"
        Me.MsIdDesc.Size = New System.Drawing.Size(136, 22)
        Me.MsIdDesc.Text = "Descending"
        '
        'pnlMainData
        '
        Me.pnlMainData.AutoScroll = True
        Me.pnlMainData.Controls.Add(Me.splitCus)
        Me.pnlMainData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainData.Location = New System.Drawing.Point(0, 28)
        Me.pnlMainData.Name = "pnlMainData"
        Me.pnlMainData.Size = New System.Drawing.Size(730, 497)
        Me.pnlMainData.TabIndex = 1
        '
        'splitCus
        '
        Me.splitCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitCus.Location = New System.Drawing.Point(0, 0)
        Me.splitCus.Name = "splitCus"
        Me.splitCus.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitCus.Panel1
        '
        Me.splitCus.Panel1.Controls.Add(Me.Panel2)
        Me.splitCus.Panel1.Controls.Add(Me.Splitter1)
        Me.splitCus.Panel1.Controls.Add(Me.Panel1)
        '
        'splitCus.Panel2
        '
        Me.splitCus.Panel2.AutoScroll = True
        Me.splitCus.Panel2.Controls.Add(Me.Panel3)
        Me.splitCus.Panel2.Controls.Add(Me.StatsCus)
        Me.splitCus.Panel2.Controls.Add(Me.dgCustomer)
        Me.splitCus.Size = New System.Drawing.Size(730, 497)
        Me.splitCus.SplitterDistance = 165
        Me.splitCus.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnConfirmation)
        Me.Panel2.Controls.Add(Me.lblCusID)
        Me.Panel2.Controls.Add(Me.mskPhoneCus)
        Me.Panel2.Controls.Add(Me.dtpCus)
        Me.Panel2.Controls.Add(Me.rdMaleCus)
        Me.Panel2.Controls.Add(Me.rdFemaleCus)
        Me.Panel2.Controls.Add(Me.txtCusEmail)
        Me.Panel2.Controls.Add(Me.txtCusName)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Raleway", 8.0!)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(222, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(508, 165)
        Me.Panel2.TabIndex = 4
        '
        'btnConfirmation
        '
        Me.btnConfirmation.ForeColor = System.Drawing.Color.Black
        Me.btnConfirmation.Location = New System.Drawing.Point(420, 88)
        Me.btnConfirmation.Name = "btnConfirmation"
        Me.btnConfirmation.Size = New System.Drawing.Size(75, 75)
        Me.btnConfirmation.TabIndex = 7
        Me.btnConfirmation.Text = "Confirm Input"
        Me.btnConfirmation.UseVisualStyleBackColor = True
        '
        'lblCusID
        '
        Me.lblCusID.AutoSize = True
        Me.lblCusID.Location = New System.Drawing.Point(144, 24)
        Me.lblCusID.Name = "lblCusID"
        Me.lblCusID.Size = New System.Drawing.Size(80, 13)
        Me.lblCusID.TabIndex = 6
        Me.lblCusID.Text = "CUSTOMERID"
        '
        'mskPhoneCus
        '
        Me.mskPhoneCus.Font = New System.Drawing.Font("Raleway", 8.0!)
        Me.mskPhoneCus.Location = New System.Drawing.Point(144, 124)
        Me.mskPhoneCus.Mask = "62800-0000-0000"
        Me.mskPhoneCus.Name = "mskPhoneCus"
        Me.mskPhoneCus.Size = New System.Drawing.Size(218, 20)
        Me.mskPhoneCus.TabIndex = 5
        '
        'dtpCus
        '
        Me.dtpCus.Location = New System.Drawing.Point(144, 70)
        Me.dtpCus.Name = "dtpCus"
        Me.dtpCus.Size = New System.Drawing.Size(218, 20)
        Me.dtpCus.TabIndex = 3
        '
        'rdMaleCus
        '
        Me.rdMaleCus.AutoSize = True
        Me.rdMaleCus.Location = New System.Drawing.Point(144, 98)
        Me.rdMaleCus.Name = "rdMaleCus"
        Me.rdMaleCus.Size = New System.Drawing.Size(50, 17)
        Me.rdMaleCus.TabIndex = 2
        Me.rdMaleCus.TabStop = True
        Me.rdMaleCus.Text = "Male"
        Me.rdMaleCus.UseVisualStyleBackColor = True
        '
        'rdFemaleCus
        '
        Me.rdFemaleCus.AutoSize = True
        Me.rdFemaleCus.Location = New System.Drawing.Point(212, 98)
        Me.rdFemaleCus.Name = "rdFemaleCus"
        Me.rdFemaleCus.Size = New System.Drawing.Size(62, 17)
        Me.rdFemaleCus.TabIndex = 2
        Me.rdFemaleCus.TabStop = True
        Me.rdFemaleCus.Text = "Female"
        Me.rdFemaleCus.UseVisualStyleBackColor = True
        '
        'txtCusEmail
        '
        Me.txtCusEmail.Location = New System.Drawing.Point(144, 147)
        Me.txtCusEmail.Name = "txtCusEmail"
        Me.txtCusEmail.Size = New System.Drawing.Size(218, 20)
        Me.txtCusEmail.TabIndex = 1
        '
        'txtCusName
        '
        Me.txtCusName.Location = New System.Drawing.Point(144, 43)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(218, 20)
        Me.txtCusName.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Customer Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Customer Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Customer Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer ID"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(219, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 165)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbGend)
        Me.Panel1.Controls.Add(Me.cmbSearchChoice)
        Me.Panel1.Controls.Add(Me.txtFind)
        Me.Panel1.Controls.Add(Me.lblTotalCus)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelTotal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Raleway", 8.0!)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 165)
        Me.Panel1.TabIndex = 2
        '
        'cmbGend
        '
        Me.cmbGend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGend.FormattingEnabled = True
        Me.cmbGend.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGend.Location = New System.Drawing.Point(118, 137)
        Me.cmbGend.Name = "cmbGend"
        Me.cmbGend.Size = New System.Drawing.Size(121, 21)
        Me.cmbGend.TabIndex = 3
        '
        'cmbSearchChoice
        '
        Me.cmbSearchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchChoice.FormattingEnabled = True
        Me.cmbSearchChoice.Items.AddRange(New Object() {"CUS_ID", "CUS_NAME", "CUS_EMAIL", "CUS_GENDER", "CUS_PHONE"})
        Me.cmbSearchChoice.Location = New System.Drawing.Point(118, 99)
        Me.cmbSearchChoice.Name = "cmbSearchChoice"
        Me.cmbSearchChoice.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchChoice.TabIndex = 3
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(261, 99)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 20)
        Me.txtFind.TabIndex = 2
        '
        'lblTotalCus
        '
        Me.lblTotalCus.AutoSize = True
        Me.lblTotalCus.Location = New System.Drawing.Point(115, 24)
        Me.lblTotalCus.Name = "lblTotalCus"
        Me.lblTotalCus.Size = New System.Drawing.Size(115, 13)
        Me.lblTotalCus.TabIndex = 1
        Me.lblTotalCus.Text = "number of Customer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(291, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Value"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " Based On"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Group by Gender :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Customer :"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(12, 24)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(92, 13)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total Customer :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblmenutitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 36)
        Me.Panel3.TabIndex = 8
        '
        'lblmenutitle
        '
        Me.lblmenutitle.AutoSize = True
        Me.lblmenutitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmenutitle.Font = New System.Drawing.Font("Milkshake", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblmenutitle.ForeColor = System.Drawing.Color.White
        Me.lblmenutitle.Location = New System.Drawing.Point(254, -1)
        Me.lblmenutitle.Name = "lblmenutitle"
        Me.lblmenutitle.Size = New System.Drawing.Size(230, 37)
        Me.lblmenutitle.TabIndex = 1
        Me.lblmenutitle.Text = "All Customers Data"
        '
        'StatsCus
        '
        Me.StatsCus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStats})
        Me.StatsCus.Location = New System.Drawing.Point(0, 306)
        Me.StatsCus.Name = "StatsCus"
        Me.StatsCus.Size = New System.Drawing.Size(730, 22)
        Me.StatsCus.TabIndex = 1
        Me.StatsCus.Text = "StatusStrip1"
        '
        'lblStats
        '
        Me.lblStats.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(45, 17)
        Me.lblStats.Text = "Status: "
        '
        'dgCustomer
        '
        Me.dgCustomer.AllowUserToAddRows = False
        Me.dgCustomer.AllowUserToDeleteRows = False
        Me.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomer.Location = New System.Drawing.Point(37, 70)
        Me.dgCustomer.Name = "dgCustomer"
        Me.dgCustomer.ReadOnly = True
        Me.dgCustomer.Size = New System.Drawing.Size(653, 233)
        Me.dgCustomer.TabIndex = 0
        '
        'cmsCustomer
        '
        Me.cmsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsRefresh, Me.CmsAddCus, Me.CmsDelData, Me.CmsEditCus})
        Me.cmsCustomer.Name = "ContextMenuStrip1"
        Me.cmsCustomer.Size = New System.Drawing.Size(141, 92)
        '
        'CmsRefresh
        '
        Me.CmsRefresh.Name = "CmsRefresh"
        Me.CmsRefresh.Size = New System.Drawing.Size(140, 22)
        Me.CmsRefresh.Text = "Refresh Data"
        '
        'CmsAddCus
        '
        Me.CmsAddCus.Name = "CmsAddCus"
        Me.CmsAddCus.Size = New System.Drawing.Size(140, 22)
        Me.CmsAddCus.Text = "Insert Data"
        '
        'CmsDelData
        '
        Me.CmsDelData.Name = "CmsDelData"
        Me.CmsDelData.Size = New System.Drawing.Size(140, 22)
        Me.CmsDelData.Text = "Delete Data"
        '
        'CmsEditCus
        '
        Me.CmsEditCus.Name = "CmsEditCus"
        Me.CmsEditCus.Size = New System.Drawing.Size(140, 22)
        Me.CmsEditCus.Text = "Update Data"
        '
        'CustomerDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.ContextMenuStrip = Me.cmsCustomer
        Me.Controls.Add(Me.pnlMainData)
        Me.Controls.Add(Me.pnlDataMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerDataForm"
        Me.Text = "Customer Data Form"
        Me.pnlDataMenu.ResumeLayout(False)
        Me.pnlDataMenu.PerformLayout()
        Me.MsCustomer.ResumeLayout(False)
        Me.MsCustomer.PerformLayout()
        Me.pnlMainData.ResumeLayout(False)
        Me.splitCus.Panel1.ResumeLayout(False)
        Me.splitCus.Panel2.ResumeLayout(False)
        Me.splitCus.Panel2.PerformLayout()
        CType(Me.splitCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitCus.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatsCus.ResumeLayout(False)
        Me.StatsCus.PerformLayout()
        CType(Me.dgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCustomer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDataMenu As Panel
    Friend WithEvents pnlMainData As Panel
    Friend WithEvents MsCustomer As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsInsertCus As ToolStripMenuItem
    Friend WithEvents MsEditCus As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsDeleteCus As ToolStripMenuItem
    Friend WithEvents MsName As ToolStripMenuItem
    Friend WithEvents SortByAgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents splitCus As SplitContainer
    Friend WithEvents dgCustomer As DataGridView
    Friend WithEvents cmsCustomer As ContextMenuStrip
    Friend WithEvents CmsRefresh As ToolStripMenuItem
    Friend WithEvents CmsAddCus As ToolStripMenuItem
    Friend WithEvents CmsDelData As ToolStripMenuItem
    Friend WithEvents CmsEditCus As ToolStripMenuItem
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCusEmail As TextBox
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents StatsCus As StatusStrip
    Friend WithEvents lblStats As ToolStripStatusLabel
    Friend WithEvents rdMaleCus As RadioButton
    Friend WithEvents rdFemaleCus As RadioButton
    Friend WithEvents dtpCus As DateTimePicker
    Friend WithEvents mskPhoneCus As MaskedTextBox
    Friend WithEvents lblCusID As Label
    Friend WithEvents btnConfirmation As Button
    Friend WithEvents msRefresh As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTotal As Label
    Friend WithEvents lblTotalCus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSearchChoice As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbGend As ComboBox
    Friend WithEvents MsNameAsc As ToolStripMenuItem
    Friend WithEvents MsNameDesc As ToolStripMenuItem
    Friend WithEvents MsIdAsc As ToolStripMenuItem
    Friend WithEvents MsIdDesc As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblmenutitle As Label
End Class
