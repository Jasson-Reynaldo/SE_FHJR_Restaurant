<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FlavorData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlavorData))
        Me.MenuToolFlavor = New System.Windows.Forms.ToolStrip()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.dgFlav = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFlavorName = New System.Windows.Forms.TextBox()
        Me.FlavTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblFlavID = New System.Windows.Forms.Label()
        Me.FlavStatus = New System.Windows.Forms.StatusStrip()
        Me.lblFlavStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuToolFlavor.SuspendLayout()
        CType(Me.dgFlav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlavStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuToolFlavor
        '
        Me.MenuToolFlavor.AutoSize = False
        Me.MenuToolFlavor.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuToolFlavor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdd, Me.tsbEdit, Me.tsbDelete})
        Me.MenuToolFlavor.Location = New System.Drawing.Point(0, 0)
        Me.MenuToolFlavor.Name = "MenuToolFlavor"
        Me.MenuToolFlavor.Size = New System.Drawing.Size(530, 30)
        Me.MenuToolFlavor.TabIndex = 0
        Me.MenuToolFlavor.Text = "MenuTool"
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(29, 27)
        Me.tsbAdd.Text = "Add Data"
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
        'dgFlav
        '
        Me.dgFlav.AllowUserToAddRows = False
        Me.dgFlav.AllowUserToDeleteRows = False
        Me.dgFlav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFlav.Location = New System.Drawing.Point(46, 223)
        Me.dgFlav.Name = "dgFlav"
        Me.dgFlav.ReadOnly = True
        Me.dgFlav.Size = New System.Drawing.Size(449, 245)
        Me.dgFlav.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Flavor ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Flavor Name"
        '
        'txtFlavorName
        '
        Me.txtFlavorName.Enabled = False
        Me.txtFlavorName.Location = New System.Drawing.Point(201, 113)
        Me.txtFlavorName.Name = "txtFlavorName"
        Me.txtFlavorName.Size = New System.Drawing.Size(184, 20)
        Me.txtFlavorName.TabIndex = 3
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(201, 157)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(70, 38)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Save Change"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'lblFlavID
        '
        Me.lblFlavID.AutoSize = True
        Me.lblFlavID.Location = New System.Drawing.Point(201, 75)
        Me.lblFlavID.Name = "lblFlavID"
        Me.lblFlavID.Size = New System.Drawing.Size(50, 13)
        Me.lblFlavID.TabIndex = 5
        Me.lblFlavID.Text = "Flavor ID"
        '
        'FlavStatus
        '
        Me.FlavStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFlavStats})
        Me.FlavStatus.Location = New System.Drawing.Point(0, 503)
        Me.FlavStatus.Name = "FlavStatus"
        Me.FlavStatus.Size = New System.Drawing.Size(530, 22)
        Me.FlavStatus.TabIndex = 6
        Me.FlavStatus.Text = "FlavStatus"
        '
        'lblFlavStats
        '
        Me.lblFlavStats.Name = "lblFlavStats"
        Me.lblFlavStats.Size = New System.Drawing.Size(39, 17)
        Me.lblFlavStats.Text = "Status"
        '
        'FlavorData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 525)
        Me.Controls.Add(Me.FlavStatus)
        Me.Controls.Add(Me.lblFlavID)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtFlavorName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgFlav)
        Me.Controls.Add(Me.MenuToolFlavor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FlavorData"
        Me.MenuToolFlavor.ResumeLayout(False)
        Me.MenuToolFlavor.PerformLayout()
        CType(Me.dgFlav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlavStatus.ResumeLayout(False)
        Me.FlavStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuToolFlavor As ToolStrip
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbEdit As ToolStripButton
    Friend WithEvents tsbDelete As ToolStripButton
    Friend WithEvents dgFlav As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFlavorName As TextBox
    Friend WithEvents FlavTips As ToolTip
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblFlavID As Label
    Friend WithEvents FlavStatus As StatusStrip
    Friend WithEvents lblFlavStats As ToolStripStatusLabel
End Class