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
        Me.MsFeedback = New System.Windows.Forms.MenuStrip()
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
        Me.StatsFeedback = New System.Windows.Forms.StatusStrip()
        Me.lblStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgFeedback = New System.Windows.Forms.DataGridView()
        Me.cmsFeedback = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsAddFeed = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsDelData = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsEditFeed = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlDataMenu.SuspendLayout()
        Me.MsFeedback.SuspendLayout()
        Me.pnlMainData.SuspendLayout()
        CType(Me.splitCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitCus.Panel1.SuspendLayout()
        Me.splitCus.Panel2.SuspendLayout()
        Me.splitCus.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatsFeedback.SuspendLayout()
        CType(Me.dgFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFeedback.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDataMenu
        '
        Me.pnlDataMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlDataMenu.Controls.Add(Me.MsFeedback)
        Me.pnlDataMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDataMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlDataMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDataMenu.Name = "pnlDataMenu"
        Me.pnlDataMenu.Size = New System.Drawing.Size(973, 34)
        Me.pnlDataMenu.TabIndex = 0
        '
        'MsFeedback
        '
        Me.MsFeedback.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MsFeedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MsFeedback.Location = New System.Drawing.Point(0, 0)
        Me.MsFeedback.Name = "MsFeedback"
        Me.MsFeedback.Size = New System.Drawing.Size(973, 28)
        Me.MsFeedback.TabIndex = 0
        Me.MsFeedback.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRefresh, Me.MsInsertFeed, Me.MsEditFeed, Me.MsDeleteFeed})
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
        'MsInsertFeed
        '
        Me.MsInsertFeed.Name = "MsInsertFeed"
        Me.MsInsertFeed.Size = New System.Drawing.Size(177, 26)
        Me.MsInsertFeed.Text = "Insert Data"
        '
        'MsEditFeed
        '
        Me.MsEditFeed.Name = "MsEditFeed"
        Me.MsEditFeed.Size = New System.Drawing.Size(177, 26)
        Me.MsEditFeed.Text = "Update Data"
        '
        'MsDeleteFeed
        '
        Me.MsDeleteFeed.Name = "MsDeleteFeed"
        Me.MsDeleteFeed.Size = New System.Drawing.Size(177, 26)
        Me.MsDeleteFeed.Text = "Delete Data"
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
        Me.splitCus.Panel2.Controls.Add(Me.StatsFeedback)
        Me.splitCus.Panel2.Controls.Add(Me.dgFeedback)
        Me.splitCus.Size = New System.Drawing.Size(973, 612)
        Me.splitCus.SplitterDistance = 203
        Me.splitCus.SplitterWidth = 5
        Me.splitCus.TabIndex = 0
        '
        'Panel2
        '
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
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(973, 203)
        Me.Panel2.TabIndex = 4
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.Location = New System.Drawing.Point(305, 130)
        Me.lblTransactionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(119, 20)
        Me.lblTransactionID.TabIndex = 9
        Me.lblTransactionID.Text = "Transaction ID"
        '
        'txtFeedDetail
        '
        Me.txtFeedDetail.Location = New System.Drawing.Point(305, 160)
        Me.txtFeedDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFeedDetail.Name = "txtFeedDetail"
        Me.txtFeedDetail.Size = New System.Drawing.Size(375, 26)
        Me.txtFeedDetail.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(116, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search FeedBack:"
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
        Me.cmbSearchChoice.Items.AddRange(New Object() {"Feed_ID", "Feed_Detail", "Trans_ID"})
        Me.cmbSearchChoice.Location = New System.Drawing.Point(309, 52)
        Me.cmbSearchChoice.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchChoice.Name = "cmbSearchChoice"
        Me.cmbSearchChoice.Size = New System.Drawing.Size(160, 28)
        Me.cmbSearchChoice.TabIndex = 3
        '
        'lblFeedID
        '
        Me.lblFeedID.AutoSize = True
        Me.lblFeedID.Location = New System.Drawing.Point(305, 98)
        Me.lblFeedID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeedID.Name = "lblFeedID"
        Me.lblFeedID.Size = New System.Drawing.Size(106, 20)
        Me.lblFeedID.TabIndex = 6
        Me.lblFeedID.Text = "FeedBack ID"
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
        Me.Label9.Location = New System.Drawing.Point(556, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Value"
        '
        'lblTotalFeedback
        '
        Me.lblTotalFeedback.AutoSize = True
        Me.lblTotalFeedback.Location = New System.Drawing.Point(180, 4)
        Me.lblTotalFeedback.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalFeedback.Name = "lblTotalFeedback"
        Me.lblTotalFeedback.Size = New System.Drawing.Size(170, 20)
        Me.lblTotalFeedback.TabIndex = 1
        Me.lblTotalFeedback.Text = "number of Feedbacks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " Based On"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(4, 4)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(142, 20)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total Feedbacks :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(127, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "FeedBack Detail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(143, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transaction_ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(160, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "FeedBack ID:"
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
        Me.lblmenutitle.Size = New System.Drawing.Size(293, 36)
        Me.lblmenutitle.TabIndex = 1
        Me.lblmenutitle.Text = "All FeedBacks Data"
        '
        'StatsFeedback
        '
        Me.StatsFeedback.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatsFeedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStats})
        Me.StatsFeedback.Location = New System.Drawing.Point(0, 378)
        Me.StatsFeedback.Name = "StatsFeedback"
        Me.StatsFeedback.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatsFeedback.Size = New System.Drawing.Size(973, 26)
        Me.StatsFeedback.TabIndex = 1
        Me.StatsFeedback.Text = "StatusStrip1"
        '
        'lblStats
        '
        Me.lblStats.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(56, 20)
        Me.lblStats.Text = "Status: "
        '
        'dgFeedback
        '
        Me.dgFeedback.AllowUserToAddRows = False
        Me.dgFeedback.AllowUserToDeleteRows = False
        Me.dgFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFeedback.Location = New System.Drawing.Point(49, 86)
        Me.dgFeedback.Margin = New System.Windows.Forms.Padding(4)
        Me.dgFeedback.Name = "dgFeedback"
        Me.dgFeedback.ReadOnly = True
        Me.dgFeedback.RowHeadersWidth = 51
        Me.dgFeedback.Size = New System.Drawing.Size(871, 287)
        Me.dgFeedback.TabIndex = 0
        '
        'cmsFeedback
        '
        Me.cmsFeedback.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsFeedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsRefresh, Me.CmsAddFeed, Me.CmsDelData, Me.CmsEditFeed})
        Me.cmsFeedback.Name = "ContextMenuStrip1"
        Me.cmsFeedback.Size = New System.Drawing.Size(164, 100)
        '
        'CmsRefresh
        '
        Me.CmsRefresh.Name = "CmsRefresh"
        Me.CmsRefresh.Size = New System.Drawing.Size(210, 24)
        Me.CmsRefresh.Text = "Refresh Data"
        '
        'CmsAddFeed
        '
        Me.CmsAddFeed.Name = "CmsAddFeed"
        Me.CmsAddFeed.Size = New System.Drawing.Size(210, 24)
        Me.CmsAddFeed.Text = "Insert Data"
        '
        'CmsDelData
        '
        Me.CmsDelData.Name = "CmsDelData"
        Me.CmsDelData.Size = New System.Drawing.Size(210, 24)
        Me.CmsDelData.Text = "Delete Data"
        '
        'CmsEditFeed
        '
        Me.CmsEditFeed.Name = "CmsEditFeed"
        Me.CmsEditFeed.Size = New System.Drawing.Size(163, 24)
        Me.CmsEditFeed.Text = "Update Data"
        '
        'FeedBackDBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(973, 646)
        Me.ContextMenuStrip = Me.cmsFeedback
        Me.Controls.Add(Me.pnlMainData)
        Me.Controls.Add(Me.pnlDataMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FeedBackDBForm"
        Me.Text = "Customer Data Form"
        Me.pnlDataMenu.ResumeLayout(False)
        Me.pnlDataMenu.PerformLayout()
        Me.MsFeedback.ResumeLayout(False)
        Me.MsFeedback.PerformLayout()
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
        Me.StatsFeedback.ResumeLayout(False)
        Me.StatsFeedback.PerformLayout()
        CType(Me.dgFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFeedback.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDataMenu As Panel
    Friend WithEvents pnlMainData As Panel
    Friend WithEvents MsFeedback As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsInsertFeed As ToolStripMenuItem
    Friend WithEvents MsEditFeed As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsDeleteFeed As ToolStripMenuItem
    Friend WithEvents MsName As ToolStripMenuItem
    Friend WithEvents SortByAgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents splitCus As SplitContainer
    Friend WithEvents dgFeedback As DataGridView
    Friend WithEvents cmsFeedback As ContextMenuStrip
    Friend WithEvents CmsRefresh As ToolStripMenuItem
    Friend WithEvents CmsAddFeed As ToolStripMenuItem
    Friend WithEvents CmsDelData As ToolStripMenuItem
    Friend WithEvents CmsEditFeed As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatsFeedback As StatusStrip
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
