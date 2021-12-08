<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IceCreamData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IceCreamData))
        Me.MenuTool = New System.Windows.Forms.ToolStrip()
        Me.tsbAddIce = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditIce = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeleteIce = New System.Windows.Forms.ToolStripButton()
        Me.dgIce = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIceName = New System.Windows.Forms.TextBox()
        Me.txtIcePrice = New System.Windows.Forms.TextBox()
        Me.IceTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.iceStatus = New System.Windows.Forms.StatusStrip()
        Me.lblIceStats = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblIceId = New System.Windows.Forms.Label()
        Me.MenuTool.SuspendLayout()
        CType(Me.dgIce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.iceStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuTool
        '
        Me.MenuTool.AutoSize = False
        Me.MenuTool.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAddIce, Me.tsbEditIce, Me.tsbDeleteIce})
        Me.MenuTool.Location = New System.Drawing.Point(0, 0)
        Me.MenuTool.Name = "MenuTool"
        Me.MenuTool.Size = New System.Drawing.Size(530, 30)
        Me.MenuTool.TabIndex = 0
        Me.MenuTool.Text = "MenuTool"
        '
        'tsbAddIce
        '
        Me.tsbAddIce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddIce.Image = CType(resources.GetObject("tsbAddIce.Image"), System.Drawing.Image)
        Me.tsbAddIce.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddIce.Name = "tsbAddIce"
        Me.tsbAddIce.Size = New System.Drawing.Size(29, 27)
        Me.tsbAddIce.Text = "Add Data"
        '
        'tsbEditIce
        '
        Me.tsbEditIce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditIce.Image = CType(resources.GetObject("tsbEditIce.Image"), System.Drawing.Image)
        Me.tsbEditIce.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditIce.Name = "tsbEditIce"
        Me.tsbEditIce.Size = New System.Drawing.Size(29, 27)
        Me.tsbEditIce.Text = "Edit Data"
        '
        'tsbDeleteIce
        '
        Me.tsbDeleteIce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDeleteIce.Image = CType(resources.GetObject("tsbDeleteIce.Image"), System.Drawing.Image)
        Me.tsbDeleteIce.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeleteIce.Name = "tsbDeleteIce"
        Me.tsbDeleteIce.Size = New System.Drawing.Size(29, 27)
        Me.tsbDeleteIce.Text = "Delete Data"
        '
        'dgIce
        '
        Me.dgIce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIce.Location = New System.Drawing.Point(46, 223)
        Me.dgIce.Name = "dgIce"
        Me.dgIce.Size = New System.Drawing.Size(449, 245)
        Me.dgIce.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ice Cream ID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ice Cream Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ice Cream Price"
        '
        'txtIceName
        '
        Me.txtIceName.Enabled = False
        Me.txtIceName.Location = New System.Drawing.Point(201, 109)
        Me.txtIceName.Name = "txtIceName"
        Me.txtIceName.Size = New System.Drawing.Size(184, 20)
        Me.txtIceName.TabIndex = 3
        '
        'txtIcePrice
        '
        Me.txtIcePrice.Enabled = False
        Me.txtIcePrice.Location = New System.Drawing.Point(201, 149)
        Me.txtIcePrice.Name = "txtIcePrice"
        Me.txtIcePrice.Size = New System.Drawing.Size(184, 20)
        Me.txtIcePrice.TabIndex = 3
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(201, 179)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(70, 38)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Save Change"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'iceStatus
        '
        Me.iceStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblIceStats})
        Me.iceStatus.Location = New System.Drawing.Point(0, 503)
        Me.iceStatus.Name = "iceStatus"
        Me.iceStatus.Size = New System.Drawing.Size(530, 22)
        Me.iceStatus.TabIndex = 5
        Me.iceStatus.Text = "IceStatus"
        '
        'lblIceStats
        '
        Me.lblIceStats.Name = "lblIceStats"
        Me.lblIceStats.Size = New System.Drawing.Size(39, 17)
        Me.lblIceStats.Text = "Status"
        '
        'lblIceId
        '
        Me.lblIceId.AutoSize = True
        Me.lblIceId.Location = New System.Drawing.Point(198, 69)
        Me.lblIceId.Name = "lblIceId"
        Me.lblIceId.Size = New System.Drawing.Size(31, 13)
        Me.lblIceId.TabIndex = 6
        Me.lblIceId.Text = "IceId"
        '
        'IceCreamData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 525)
        Me.Controls.Add(Me.lblIceId)
        Me.Controls.Add(Me.iceStatus)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtIcePrice)
        Me.Controls.Add(Me.txtIceName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgIce)
        Me.Controls.Add(Me.MenuTool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IceCreamData"
        Me.MenuTool.ResumeLayout(False)
        Me.MenuTool.PerformLayout()
        CType(Me.dgIce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.iceStatus.ResumeLayout(False)
        Me.iceStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuTool As ToolStrip
    Friend WithEvents tsbAddIce As ToolStripButton
    Friend WithEvents tsbEditIce As ToolStripButton
    Friend WithEvents tsbDeleteIce As ToolStripButton
    Friend WithEvents dgIce As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIceName As TextBox
    Friend WithEvents txtIcePrice As TextBox
    Friend WithEvents IceTips As ToolTip
    Friend WithEvents btnConfirm As Button
    Friend WithEvents iceStatus As StatusStrip
    Friend WithEvents lblIceStats As ToolStripStatusLabel
    Friend WithEvents lblIceId As Label
End Class
