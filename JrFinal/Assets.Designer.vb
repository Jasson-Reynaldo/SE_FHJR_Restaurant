<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assets
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Rules")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Data")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ice Cream")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toppings")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flavor")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MenuData", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Me.treeAssets = New System.Windows.Forms.TreeView()
        Me.pnlTreeMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblmenutitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'treeAssets
        '
        Me.treeAssets.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.treeAssets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeAssets.Font = New System.Drawing.Font("Raleway Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeAssets.ForeColor = System.Drawing.Color.White
        Me.treeAssets.Location = New System.Drawing.Point(0, 0)
        Me.treeAssets.Name = "treeAssets"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "Employee Rules"
        TreeNode2.Name = "Node4"
        TreeNode2.Text = "Employee Data"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "Employee"
        TreeNode4.Name = "Node8"
        TreeNode4.Text = "Ice Cream"
        TreeNode5.Name = "Node9"
        TreeNode5.Text = "Toppings"
        TreeNode6.Name = "nodeFlavor"
        TreeNode6.Text = "Flavor"
        TreeNode7.Name = "node5"
        TreeNode7.Text = "MenuData"
        Me.treeAssets.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode7})
        Me.treeAssets.Size = New System.Drawing.Size(200, 481)
        Me.treeAssets.TabIndex = 0
        '
        'pnlTreeMain
        '
        Me.pnlTreeMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlTreeMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTreeMain.Location = New System.Drawing.Point(200, 44)
        Me.pnlTreeMain.Name = "pnlTreeMain"
        Me.pnlTreeMain.Size = New System.Drawing.Size(530, 481)
        Me.pnlTreeMain.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblmenutitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 44)
        Me.Panel2.TabIndex = 2
        '
        'lblmenutitle
        '
        Me.lblmenutitle.AutoSize = True
        Me.lblmenutitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmenutitle.Font = New System.Drawing.Font("Milkshake", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblmenutitle.ForeColor = System.Drawing.Color.White
        Me.lblmenutitle.Location = New System.Drawing.Point(288, 4)
        Me.lblmenutitle.Name = "lblmenutitle"
        Me.lblmenutitle.Size = New System.Drawing.Size(151, 37)
        Me.lblmenutitle.TabIndex = 1
        Me.lblmenutitle.Text = "Assets Data"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.treeAssets)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 481)
        Me.Panel1.TabIndex = 3
        '
        'Assets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.Controls.Add(Me.pnlTreeMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Assets"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treeAssets As TreeView
    Friend WithEvents pnlTreeMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblmenutitle As Label
End Class
