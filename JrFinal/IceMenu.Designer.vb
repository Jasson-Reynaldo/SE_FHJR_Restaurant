<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IceMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IceMenu))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Food", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Drink", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Pizza (IDR 150K) ", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Fried Chicken (IDR 15k)", 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Burger (IDR 50K)", 2)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Fried Rice (IDR 35K)", 3)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("French Fries (IDR 15K)", 4)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Cake (IDR 20K)", 5)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Soda(IDR 15K)", 6)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Juice (IDR 20K)", 7)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mineral Water (ID 5K)", 8)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblmenutitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.imgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.lsMenu = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 85)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblmenutitle)
        Me.Panel3.Location = New System.Drawing.Point(182, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(386, 69)
        Me.Panel3.TabIndex = 1
        '
        'lblmenutitle
        '
        Me.lblmenutitle.AutoSize = True
        Me.lblmenutitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmenutitle.Font = New System.Drawing.Font("Milkshake", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmenutitle.ForeColor = System.Drawing.Color.White
        Me.lblmenutitle.Location = New System.Drawing.Point(117, 6)
        Me.lblmenutitle.Name = "lblmenutitle"
        Me.lblmenutitle.Size = New System.Drawing.Size(171, 53)
        Me.lblmenutitle.TabIndex = 0
        Me.lblmenutitle.Text = "Our Menu"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 3)
        Me.Panel2.TabIndex = 0
        '
        'imgMenu
        '
        Me.imgMenu.ImageStream = CType(resources.GetObject("imgMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMenu.Images.SetKeyName(0, "Pizza.png")
        Me.imgMenu.Images.SetKeyName(1, "ayem.png")
        Me.imgMenu.Images.SetKeyName(2, "burgir.png")
        Me.imgMenu.Images.SetKeyName(3, "Nasgor.png")
        Me.imgMenu.Images.SetKeyName(4, "Kentank.png")
        Me.imgMenu.Images.SetKeyName(5, "kue.png")
        Me.imgMenu.Images.SetKeyName(6, "soda.png")
        Me.imgMenu.Images.SetKeyName(7, "Jus.png")
        Me.imgMenu.Images.SetKeyName(8, "mineral water.png")
        '
        'lsMenu
        '
        Me.lsMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsMenu.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup1.Header = "Food"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup1.Name = "Food"
        ListViewGroup2.Header = "Drink"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup2.Name = "Drink"
        Me.lsMenu.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lsMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsMenu.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.Group = ListViewGroup1
        ListViewItem5.Group = ListViewGroup1
        ListViewItem6.Group = ListViewGroup1
        ListViewItem7.Group = ListViewGroup2
        ListViewItem8.Group = ListViewGroup2
        ListViewItem9.Group = ListViewGroup2
        Me.lsMenu.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.lsMenu.LargeImageList = Me.imgMenu
        Me.lsMenu.Location = New System.Drawing.Point(0, 85)
        Me.lsMenu.Name = "lsMenu"
        Me.lsMenu.Size = New System.Drawing.Size(730, 440)
        Me.lsMenu.TabIndex = 1
        Me.lsMenu.UseCompatibleStateImageBehavior = False
        '
        'IceMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.Controls.Add(Me.lsMenu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IceMenu"
        Me.Text = "IceMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblmenutitle As Label
    Friend WithEvents imgMenu As ImageList
    Friend WithEvents lsMenu As ListView
End Class
