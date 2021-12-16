<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeedBackDBForm
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
        Me.MsInsertFeed = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsEditFeed = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsDeleteFeed = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.lblTransactionID = New System.Windows.Forms.Label()
        Me.txtFeedDetail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmation = New System.Windows.Forms.Button()
        Me.cmbSearchChoice = New System.Windows.Forms.ComboBox()
        Me.lblFeedID = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalFeedback = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblmenutitle = New System.Windows.Forms.Label()
        Me.StatsCus = New System.Windows.Forms.StatusStrip()
        Me.lblStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgFeedback = New System.Windows.Forms.DataGridView()
        Me.cmsCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsAddFeed = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsDelData = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsEditFeed = New System.Windows.Forms.ToolStripMenuItem()
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
        CType(Me.dgFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRefresh, Me.MsInsertFeed, Me.MsEditFeed, Me.MsDeleteFeed})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DataToolStripMenuItem.Text = "Tools"
        '
        'msRefresh
        '
        Me.msRefresh.Name = "msRefresh"
        Me.msRefresh.Size = New System.Drawing.Size(180, 22)
        Me.msRefresh.Text = "Refresh Data"
        '
        'MsInsertFeed
        '
        Me.MsInsertFeed.Name = "MsInsertFeed"
        Me.MsInsertFeed.Size = New System.Drawing.Size(180, 22)
        Me.MsInsertFeed.Text = "Insert Data"
        '
        'MsEditFeed
        '
        Me.MsEditFeed.Name = "MsEditFeed"
        Me.MsEditFeed.Size = New System.Drawing.Size(180, 22)
        Me.MsEditFeed.Text = "Update Data"
        '
        'MsDeleteFeed
        '
        Me.MsDeleteFeed.Name = "MsDeleteFeed"
        Me.MsDeleteFeed.Size = New System.Drawing.Size(180, 22)
        Me.MsDeleteFeed.Text = "Delete Data"
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
        '
        'splitCus.Panel2
        '
        Me.splitCus.Panel2.AutoScroll = True
        Me.splitCus.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.splitCus.Panel2.Controls.Add(Me.Panel3)
        Me.splitCus.Panel2.Controls.Add(Me.StatsCus)
        Me.splitCus.Panel2.Controls.Add(Me.dgFeedback)
        Me.splitCus.Size = New System.Drawing.Size(730, 497)
        Me.splitCus.SplitterDistance = 165
        Me.splitCus.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTransactionID)
        Me.Panel2.Controls.Add(Me.txtFeedDetail)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnConfirmation)
        Me.Panel2.Controls.Add(Me.cmbSearchChoice)
        Me.Panel2.Controls.Add(Me.lblFeedID)
        Me.Panel2.Controls.Add(Me.txtFind)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblTotalFeedback)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LabelTotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 165)
        Me.Panel2.TabIndex = 4
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.ForeColor = System.Drawing.Color.Black
        Me.lblTransactionID.Location = New System.Drawing.Point(229, 106)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(100, 16)
        Me.lblTransactionID.TabIndex = 9
        Me.lblTransactionID.Text = "Transaction ID"
        '
        'txtFeedDetail
        '
        Me.txtFeedDetail.Location = New System.Drawing.Point(229, 130)
        Me.txtFeedDetail.Name = "txtFeedDetail"
        Me.txtFeedDetail.Size = New System.Drawing.Size(282, 23)
        Me.txtFeedDetail.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(87, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search FeedBack:"
        '
        'btnConfirmation
        '
        Me.btnConfirmation.ForeColor = System.Drawing.Color.Black
        Me.btnConfirmation.Location = New System.Drawing.Point(585, 80)
        Me.btnConfirmation.Name = "btnConfirmation"
        Me.btnConfirmation.Size = New System.Drawing.Size(75, 75)
        Me.btnConfirmation.TabIndex = 7
        Me.btnConfirmation.Text = "Confirm Input"
        Me.btnConfirmation.UseVisualStyleBackColor = True
        '
        'cmbSearchChoice
        '
        Me.cmbSearchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchChoice.FormattingEnabled = True
        Me.cmbSearchChoice.Items.AddRange(New Object() {"CUS_ID", "CUS_NAME", "CUS_EMAIL", "CUS_GENDER", "CUS_PHONE"})
        Me.cmbSearchChoice.Location = New System.Drawing.Point(232, 42)
        Me.cmbSearchChoice.Name = "cmbSearchChoice"
        Me.cmbSearchChoice.Size = New System.Drawing.Size(121, 23)
        Me.cmbSearchChoice.TabIndex = 3
        '
        'lblFeedID
        '
        Me.lblFeedID.AutoSize = True
        Me.lblFeedID.ForeColor = System.Drawing.Color.Black
        Me.lblFeedID.Location = New System.Drawing.Point(229, 80)
        Me.lblFeedID.Name = "lblFeedID"
        Me.lblFeedID.Size = New System.Drawing.Size(90, 16)
        Me.lblFeedID.TabIndex = 6
        Me.lblFeedID.Text = "FeedBack ID"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(369, 43)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(145, 23)
        Me.txtFind.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(417, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Value"
        '
        'lblTotalFeedback
        '
        Me.lblTotalFeedback.AutoSize = True
        Me.lblTotalFeedback.ForeColor = System.Drawing.Color.Black
        Me.lblTotalFeedback.Location = New System.Drawing.Point(135, 3)
        Me.lblTotalFeedback.Name = "lblTotalFeedback"
        Me.lblTotalFeedback.Size = New System.Drawing.Size(152, 16)
        Me.lblTotalFeedback.TabIndex = 1
        Me.lblTotalFeedback.Text = "number of Feedbacks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(258, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " Based On"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.ForeColor = System.Drawing.Color.Black
        Me.LabelTotal.Location = New System.Drawing.Point(3, 3)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(123, 16)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total Feedbacks :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(95, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "FeedBack Detail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(107, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transaction_ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(120, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "FeedBack ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
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
        Me.lblmenutitle.BackColor = System.Drawing.Color.Transparent
        Me.lblmenutitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmenutitle.Font = New System.Drawing.Font("Milkshake", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblmenutitle.ForeColor = System.Drawing.Color.Black
        Me.lblmenutitle.Location = New System.Drawing.Point(254, -1)
        Me.lblmenutitle.Name = "lblmenutitle"
        Me.lblmenutitle.Size = New System.Drawing.Size(238, 37)
        Me.lblmenutitle.TabIndex = 1
        Me.lblmenutitle.Text = "All FeedBacks Data"
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
        'dgFeedback
        '
        Me.dgFeedback.AllowUserToAddRows = False
        Me.dgFeedback.AllowUserToDeleteRows = False
        Me.dgFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFeedback.Location = New System.Drawing.Point(37, 70)
        Me.dgFeedback.Name = "dgFeedback"
        Me.dgFeedback.ReadOnly = True
        Me.dgFeedback.Size = New System.Drawing.Size(653, 233)
        Me.dgFeedback.TabIndex = 0
        '
        'cmsCustomer
        '
        Me.cmsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsRefresh, Me.CmsAddFeed, Me.CmsDelData, Me.CmsEditFeed})
        Me.cmsCustomer.Name = "ContextMenuStrip1"
        Me.cmsCustomer.Size = New System.Drawing.Size(141, 92)
        '
        'CmsRefresh
        '
        Me.CmsRefresh.Name = "CmsRefresh"
        Me.CmsRefresh.Size = New System.Drawing.Size(140, 22)
        Me.CmsRefresh.Text = "Refresh Data"
        '
        'CmsAddFeed
        '
        Me.CmsAddFeed.Name = "CmsAddFeed"
        Me.CmsAddFeed.Size = New System.Drawing.Size(140, 22)
        Me.CmsAddFeed.Text = "Insert Data"
        '
        'CmsDelData
        '
        Me.CmsDelData.Name = "CmsDelData"
        Me.CmsDelData.Size = New System.Drawing.Size(140, 22)
        Me.CmsDelData.Text = "Delete Data"
        '
        'CmsEditFeed
        '
        Me.CmsEditFeed.Name = "CmsEditFeed"
        Me.CmsEditFeed.Size = New System.Drawing.Size(140, 22)
        Me.CmsEditFeed.Text = "Update Data"
        '
        'FeedBackDBForm
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
        Me.Name = "FeedBackDBForm"
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
        CType(Me.dgFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCustomer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDataMenu As Panel
    Friend WithEvents pnlMainData As Panel
    Friend WithEvents MsCustomer As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsInsertFeed As ToolStripMenuItem
    Friend WithEvents MsEditFeed As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsDeleteFeed As ToolStripMenuItem
    Friend WithEvents MsName As ToolStripMenuItem
    Friend WithEvents SortByAgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents splitCus As SplitContainer
    Friend WithEvents dgFeedback As DataGridView
    Friend WithEvents cmsCustomer As ContextMenuStrip
    Friend WithEvents CmsRefresh As ToolStripMenuItem
    Friend WithEvents CmsAddFeed As ToolStripMenuItem
    Friend WithEvents CmsDelData As ToolStripMenuItem
    Friend WithEvents CmsEditFeed As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatsCus As StatusStrip
    Friend WithEvents lblStats As ToolStripStatusLabel
    Friend WithEvents btnConfirmation As Button
    Friend WithEvents msRefresh As ToolStripMenuItem
    Friend WithEvents LabelTotal As Label
    Friend WithEvents lblTotalFeedback As Label
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
    Friend WithEvents txtFeedDetail As TextBox
    Friend WithEvents lblFeedID As Label
    Friend WithEvents lblTransactionID As Label
End Class
