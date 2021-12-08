<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToppingData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToppingData))
        Me.MenuTool = New System.Windows.Forms.ToolStrip()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.dgTopping = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTopName = New System.Windows.Forms.TextBox()
        Me.txtTopPrice = New System.Windows.Forms.TextBox()
        Me.IceTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblTopId = New System.Windows.Forms.Label()
        Me.ToppingStatus = New System.Windows.Forms.StatusStrip()
        Me.lblTopStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuTool.SuspendLayout()
        CType(Me.dgTopping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToppingStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuTool
        '
        Me.MenuTool.AutoSize = False
        Me.MenuTool.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdd, Me.tsbEdit, Me.tsbDelete})
        Me.MenuTool.Location = New System.Drawing.Point(0, 0)
        Me.MenuTool.Name = "MenuTool"
        Me.MenuTool.Size = New System.Drawing.Size(530, 30)
        Me.MenuTool.TabIndex = 0
        Me.MenuTool.Text = "MenuTool"
        Me.IceTips.SetToolTip(Me.MenuTool, "Hello" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(29, 27)
        Me.tsbAdd.Text = "Add New Data"
        '
        'tsbEdit
        '
        Me.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEdit.Image = CType(resources.GetObject("tsbEdit.Image"), System.Drawing.Image)
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(29, 27)
        Me.tsbEdit.Text = "Edit Data"
        '
        'tsbDelete
        '
        Me.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(29, 27)
        Me.tsbDelete.Text = "Delete Data"
        '
        'dgTopping
        '
        Me.dgTopping.AllowUserToAddRows = False
        Me.dgTopping.AllowUserToDeleteRows = False
        Me.dgTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTopping.Location = New System.Drawing.Point(46, 223)
        Me.dgTopping.Name = "dgTopping"
        Me.dgTopping.ReadOnly = True
        Me.dgTopping.Size = New System.Drawing.Size(449, 245)
        Me.dgTopping.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Topping ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Topping Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Topping Price"
        '
        'txtTopName
        '
        Me.txtTopName.Enabled = False
        Me.txtTopName.Location = New System.Drawing.Point(201, 109)
        Me.txtTopName.Name = "txtTopName"
        Me.txtTopName.Size = New System.Drawing.Size(184, 20)
        Me.txtTopName.TabIndex = 3
        '
        'txtTopPrice
        '
        Me.txtTopPrice.Enabled = False
        Me.txtTopPrice.Location = New System.Drawing.Point(201, 149)
        Me.txtTopPrice.Name = "txtTopPrice"
        Me.txtTopPrice.Size = New System.Drawing.Size(184, 20)
        Me.txtTopPrice.TabIndex = 3
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(201, 175)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(88, 42)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Save"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'lblTopId
        '
        Me.lblTopId.AutoSize = True
        Me.lblTopId.Location = New System.Drawing.Point(198, 69)
        Me.lblTopId.Name = "lblTopId"
        Me.lblTopId.Size = New System.Drawing.Size(48, 13)
        Me.lblTopId.TabIndex = 5
        Me.lblTopId.Text = "Value ID"
        '
        'ToppingStatus
        '
        Me.ToppingStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTopStats})
        Me.ToppingStatus.Location = New System.Drawing.Point(0, 503)
        Me.ToppingStatus.Name = "ToppingStatus"
        Me.ToppingStatus.Size = New System.Drawing.Size(530, 22)
        Me.ToppingStatus.TabIndex = 6
        Me.ToppingStatus.Text = "statsTop"
        '
        'lblTopStats
        '
        Me.lblTopStats.Name = "lblTopStats"
        Me.lblTopStats.Size = New System.Drawing.Size(39, 17)
        Me.lblTopStats.Text = "Status"
        '
        'ToppingData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 525)
        Me.Controls.Add(Me.ToppingStatus)
        Me.Controls.Add(Me.lblTopId)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtTopPrice)
        Me.Controls.Add(Me.txtTopName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgTopping)
        Me.Controls.Add(Me.MenuTool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ToppingData"
        Me.MenuTool.ResumeLayout(False)
        Me.MenuTool.PerformLayout()
        CType(Me.dgTopping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToppingStatus.ResumeLayout(False)
        Me.ToppingStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuTool As ToolStrip
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbEdit As ToolStripButton
    Friend WithEvents tsbDelete As ToolStripButton
    Friend WithEvents dgTopping As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTopName As TextBox
    Friend WithEvents txtTopPrice As TextBox
    Friend WithEvents IceTips As ToolTip
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblTopId As Label
    Friend WithEvents ToppingStatus As StatusStrip
    Friend WithEvents lblTopStats As ToolStripStatusLabel
End Class
