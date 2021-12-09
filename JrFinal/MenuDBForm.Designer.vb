<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuDBForm
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
        Me.txtMenuPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmation = New System.Windows.Forms.Button()
        Me.cmbSearchChoice = New System.Windows.Forms.ComboBox()
        Me.lblMenuID = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalMenu = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMenuName = New System.Windows.Forms.TextBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblmenutitle = New System.Windows.Forms.Label()
        Me.StatsCus = New System.Windows.Forms.StatusStrip()
        Me.lblStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgMenu = New System.Windows.Forms.DataGridView()
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
        Me.Panel3.SuspendLayout()
        Me.StatsCus.SuspendLayout()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDataMenu
        '
        Me.pnlDataMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlDataMenu.Controls.Add(Me.MsCustomer)
        Me.pnlDataMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDataMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlDataMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDataMenu.Name = "pnlDataMenu"
        Me.pnlDataMenu.Size = New System.Drawing.Size(973, 34)
        Me.pnlDataMenu.TabIndex = 0
        '
        'MsCustomer
        '
        Me.MsCustomer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MsCustomer.Location = New System.Drawing.Point(0, 0)
        Me.MsCustomer.Name = "MsCustomer"
        Me.MsCustomer.Size = New System.Drawing.Size(973, 28)
        Me.MsCustomer.TabIndex = 0
        Me.MsCustomer.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRefresh, Me.MsInsertCus, Me.MsEditCus, Me.MsDeleteCus})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.DataToolStripMenuItem.Text = "Tools"
        '
        'msRefresh
        '
        Me.msRefresh.Name = "msRefresh"
        Me.msRefresh.Size = New System.Drawing.Size(177, 26)
        Me.msRefresh.Text = "Refresh Data"
        '
        'MsInsertCus
        '
        Me.MsInsertCus.Name = "MsInsertCus"
        Me.MsInsertCus.Size = New System.Drawing.Size(177, 26)
        Me.MsInsertCus.Text = "Insert Data"
        '
        'MsEditCus
        '
        Me.MsEditCus.Name = "MsEditCus"
        Me.MsEditCus.Size = New System.Drawing.Size(177, 26)
        Me.MsEditCus.Text = "Update Data"
        '
        'MsDeleteCus
        '
        Me.MsDeleteCus.Name = "MsDeleteCus"
        Me.MsDeleteCus.Size = New System.Drawing.Size(177, 26)
        Me.MsDeleteCus.Text = "Delete Data"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsName, Me.SortByAgeToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ToolsToolStripMenuItem.Text = "Views"
        '
        'MsName
        '
        Me.MsName.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsNameAsc, Me.MsNameDesc})
        Me.MsName.Name = "MsName"
        Me.MsName.Size = New System.Drawing.Size(217, 26)
        Me.MsName.Text = "Sort data by Name"
        '
        'MsNameAsc
        '
        Me.MsNameAsc.Name = "MsNameAsc"
        Me.MsNameAsc.Size = New System.Drawing.Size(170, 26)
        Me.MsNameAsc.Text = "Ascending"
        '
        'MsNameDesc
        '
        Me.MsNameDesc.Name = "MsNameDesc"
        Me.MsNameDesc.Size = New System.Drawing.Size(170, 26)
        Me.MsNameDesc.Text = "Descending"
        '
        'SortByAgeToolStripMenuItem
        '
        Me.SortByAgeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsIdAsc, Me.MsIdDesc})
        Me.SortByAgeToolStripMenuItem.Name = "SortByAgeToolStripMenuItem"
        Me.SortByAgeToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.SortByAgeToolStripMenuItem.Text = "Sort by ID"
        '
        'MsIdAsc
        '
        Me.MsIdAsc.Name = "MsIdAsc"
        Me.MsIdAsc.Size = New System.Drawing.Size(170, 26)
        Me.MsIdAsc.Text = "Ascending"
        '
        'MsIdDesc
        '
        Me.MsIdDesc.Name = "MsIdDesc"
        Me.MsIdDesc.Size = New System.Drawing.Size(170, 26)
        Me.MsIdDesc.Text = "Descending"
        '
        'pnlMainData
        '
        Me.pnlMainData.AutoScroll = True
        Me.pnlMainData.Controls.Add(Me.splitCus)
        Me.pnlMainData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainData.Location = New System.Drawing.Point(0, 34)
        Me.pnlMainData.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMainData.Name = "pnlMainData"
        Me.pnlMainData.Size = New System.Drawing.Size(973, 612)
        Me.pnlMainData.TabIndex = 1
        '
        'splitCus
        '
        Me.splitCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitCus.Location = New System.Drawing.Point(0, 0)
        Me.splitCus.Margin = New System.Windows.Forms.Padding(4)
        Me.splitCus.Name = "splitCus"
        Me.splitCus.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitCus.Panel1
        '
        Me.splitCus.Panel1.Controls.Add(Me.Panel2)
        '
        'splitCus.Panel2
        '
        Me.splitCus.Panel2.AutoScroll = True
        Me.splitCus.Panel2.Controls.Add(Me.Panel3)
        Me.splitCus.Panel2.Controls.Add(Me.StatsCus)
        Me.splitCus.Panel2.Controls.Add(Me.dgMenu)
        Me.splitCus.Size = New System.Drawing.Size(973, 612)
        Me.splitCus.SplitterDistance = 203
        Me.splitCus.SplitterWidth = 5
        Me.splitCus.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtMenuPrice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnConfirmation)
        Me.Panel2.Controls.Add(Me.cmbSearchChoice)
        Me.Panel2.Controls.Add(Me.lblMenuID)
        Me.Panel2.Controls.Add(Me.txtFind)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblTotalMenu)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtMenuName)
        Me.Panel2.Controls.Add(Me.LabelTotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(973, 203)
        Me.Panel2.TabIndex = 4
        '
        'txtMenuPrice
        '
        Me.txtMenuPrice.Location = New System.Drawing.Point(305, 160)
        Me.txtMenuPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuPrice.Name = "txtMenuPrice"
        Me.txtMenuPrice.Size = New System.Drawing.Size(375, 26)
        Me.txtMenuPrice.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(153, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Menu :"
        '
        'btnConfirmation
        '
        Me.btnConfirmation.ForeColor = System.Drawing.Color.Black
        Me.btnConfirmation.Location = New System.Drawing.Point(780, 98)
        Me.btnConfirmation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmation.Name = "btnConfirmation"
        Me.btnConfirmation.Size = New System.Drawing.Size(100, 92)
        Me.btnConfirmation.TabIndex = 7
        Me.btnConfirmation.Text = "Confirm Input"
        Me.btnConfirmation.UseVisualStyleBackColor = True
        '
        'cmbSearchChoice
        '
        Me.cmbSearchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchChoice.FormattingEnabled = True
        Me.cmbSearchChoice.Items.AddRange(New Object() {"Menu_ID", "Menu_Name", "Menu_Price"})
        Me.cmbSearchChoice.Location = New System.Drawing.Point(309, 52)
        Me.cmbSearchChoice.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchChoice.Name = "cmbSearchChoice"
        Me.cmbSearchChoice.Size = New System.Drawing.Size(160, 28)
        Me.cmbSearchChoice.TabIndex = 3
        '
        'lblMenuID
        '
        Me.lblMenuID.AutoSize = True
        Me.lblMenuID.Location = New System.Drawing.Point(305, 98)
        Me.lblMenuID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuID.Name = "lblMenuID"
        Me.lblMenuID.Size = New System.Drawing.Size(72, 20)
        Me.lblMenuID.TabIndex = 6
        Me.lblMenuID.Text = "Menu ID"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(492, 53)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(192, 26)
        Me.txtFind.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(537, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Value"
        '
        'lblTotalMenu
        '
        Me.lblTotalMenu.AutoSize = True
        Me.lblTotalMenu.Location = New System.Drawing.Point(128, 4)
        Me.lblTotalMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalMenu.Name = "lblTotalMenu"
        Me.lblTotalMenu.Size = New System.Drawing.Size(139, 20)
        Me.lblTotalMenu.TabIndex = 1
        Me.lblTotalMenu.Text = "number of menus"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(360, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " Based On"
        '
        'txtMenuName
        '
        Me.txtMenuName.Location = New System.Drawing.Point(305, 127)
        Me.txtMenuName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuName.Name = "txtMenuName"
        Me.txtMenuName.Size = New System.Drawing.Size(375, 26)
        Me.txtMenuName.TabIndex = 1
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(4, 4)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(111, 20)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total Menus :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(176, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Menu Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(167, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Menu Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(203, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Menu ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblmenutitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 44)
        Me.Panel3.TabIndex = 8
        '
        'lblmenutitle
        '
        Me.lblmenutitle.AutoSize = True
        Me.lblmenutitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmenutitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblmenutitle.ForeColor = System.Drawing.Color.White
        Me.lblmenutitle.Location = New System.Drawing.Point(339, -1)
        Me.lblmenutitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmenutitle.Name = "lblmenutitle"
        Me.lblmenutitle.Size = New System.Drawing.Size(231, 36)
        Me.lblmenutitle.TabIndex = 1
        Me.lblmenutitle.Text = "All Menus Data"
        '
        'StatsCus
        '
        Me.StatsCus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatsCus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStats})
        Me.StatsCus.Location = New System.Drawing.Point(0, 378)
        Me.StatsCus.Name = "StatsCus"
        Me.StatsCus.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatsCus.Size = New System.Drawing.Size(973, 26)
        Me.StatsCus.TabIndex = 1
        Me.StatsCus.Text = "StatusStrip1"
        '
        'lblStats
        '
        Me.lblStats.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(56, 20)
        Me.lblStats.Text = "Status: "
        '
        'dgMenu
        '
        Me.dgMenu.AllowUserToAddRows = False
        Me.dgMenu.AllowUserToDeleteRows = False
        Me.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMenu.Location = New System.Drawing.Point(49, 86)
        Me.dgMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMenu.Name = "dgMenu"
        Me.dgMenu.ReadOnly = True
        Me.dgMenu.RowHeadersWidth = 51
        Me.dgMenu.Size = New System.Drawing.Size(871, 287)
        Me.dgMenu.TabIndex = 0
        '
        'cmsCustomer
        '
        Me.cmsCustomer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsRefresh, Me.CmsAddCus, Me.CmsDelData, Me.CmsEditCus})
        Me.cmsCustomer.Name = "ContextMenuStrip1"
        Me.cmsCustomer.Size = New System.Drawing.Size(164, 100)
        '
        'CmsRefresh
        '
        Me.CmsRefresh.Name = "CmsRefresh"
        Me.CmsRefresh.Size = New System.Drawing.Size(163, 24)
        Me.CmsRefresh.Text = "Refresh Data"
        '
        'CmsAddCus
        '
        Me.CmsAddCus.Name = "CmsAddCus"
        Me.CmsAddCus.Size = New System.Drawing.Size(163, 24)
        Me.CmsAddCus.Text = "Insert Data"
        '
        'CmsDelData
        '
        Me.CmsDelData.Name = "CmsDelData"
        Me.CmsDelData.Size = New System.Drawing.Size(163, 24)
        Me.CmsDelData.Text = "Delete Data"
        '
        'CmsEditCus
        '
        Me.CmsEditCus.Name = "CmsEditCus"
        Me.CmsEditCus.Size = New System.Drawing.Size(163, 24)
        Me.CmsEditCus.Text = "Update Data"
        '
        'MenuDBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(973, 646)
        Me.ContextMenuStrip = Me.cmsCustomer
        Me.Controls.Add(Me.pnlMainData)
        Me.Controls.Add(Me.pnlDataMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuDBForm"
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatsCus.ResumeLayout(False)
        Me.StatsCus.PerformLayout()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgMenu As DataGridView
    Friend WithEvents cmsCustomer As ContextMenuStrip
    Friend WithEvents CmsRefresh As ToolStripMenuItem
    Friend WithEvents CmsAddCus As ToolStripMenuItem
    Friend WithEvents CmsDelData As ToolStripMenuItem
    Friend WithEvents CmsEditCus As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMenuName As TextBox
    Friend WithEvents StatsCus As StatusStrip
    Friend WithEvents lblStats As ToolStripStatusLabel
    Friend WithEvents btnConfirmation As Button
    Friend WithEvents msRefresh As ToolStripMenuItem
    Friend WithEvents LabelTotal As Label
    Friend WithEvents lblTotalMenu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSearchChoice As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MsNameAsc As ToolStripMenuItem
    Friend WithEvents MsNameDesc As ToolStripMenuItem
    Friend WithEvents MsIdAsc As ToolStripMenuItem
    Friend WithEvents MsIdDesc As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblmenutitle As Label
    Friend WithEvents txtMenuPrice As TextBox
    Friend WithEvents lblMenuID As Label
End Class
