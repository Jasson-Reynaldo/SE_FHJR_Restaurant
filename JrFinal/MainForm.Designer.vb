<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.imgBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.MainTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDataAnalayze = New System.Windows.Forms.Button()
        Me.btnAssets = New System.Windows.Forms.Button()
        Me.btnTransData = New System.Windows.Forms.Button()
        Me.btnCusData = New System.Windows.Forms.Button()
        Me.btnOrderStatus = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUrName = New System.Windows.Forms.Label()
        Me.lblStatsRole = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBtn
        '
        Me.imgBtn.ImageStream = CType(resources.GetObject("imgBtn.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBtn.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBtn.Images.SetKeyName(0, "ExitButton.png")
        Me.imgBtn.Images.SetKeyName(1, "HomeButton.png")
        Me.imgBtn.Images.SetKeyName(2, "ExitButton.png")
        '
        'btnExit
        '
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.imgBtn
        Me.btnExit.Location = New System.Drawing.Point(912, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.TabIndex = 1
        Me.MainTips.SetToolTip(Me.btnExit, "Exit Form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDataAnalayze
        '
        Me.btnDataAnalayze.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDataAnalayze.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDataAnalayze.FlatAppearance.BorderSize = 0
        Me.btnDataAnalayze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDataAnalayze.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDataAnalayze.Location = New System.Drawing.Point(0, 360)
        Me.btnDataAnalayze.Name = "btnDataAnalayze"
        Me.btnDataAnalayze.Size = New System.Drawing.Size(203, 60)
        Me.btnDataAnalayze.TabIndex = 7
        Me.btnDataAnalayze.Text = "Data Analyze"
        Me.MainTips.SetToolTip(Me.btnDataAnalayze, "Opening Data Anlyze Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnDataAnalayze.UseVisualStyleBackColor = False
        '
        'btnAssets
        '
        Me.btnAssets.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAssets.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAssets.FlatAppearance.BorderSize = 0
        Me.btnAssets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAssets.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAssets.Location = New System.Drawing.Point(0, 300)
        Me.btnAssets.Name = "btnAssets"
        Me.btnAssets.Size = New System.Drawing.Size(203, 60)
        Me.btnAssets.TabIndex = 6
        Me.btnAssets.Text = "Assets"
        Me.MainTips.SetToolTip(Me.btnAssets, "Go to Assets")
        Me.btnAssets.UseVisualStyleBackColor = False
        '
        'btnTransData
        '
        Me.btnTransData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTransData.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransData.FlatAppearance.BorderSize = 0
        Me.btnTransData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransData.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransData.Location = New System.Drawing.Point(0, 240)
        Me.btnTransData.Name = "btnTransData"
        Me.btnTransData.Size = New System.Drawing.Size(203, 60)
        Me.btnTransData.TabIndex = 5
        Me.btnTransData.Text = "Transaction Data"
        Me.MainTips.SetToolTip(Me.btnTransData, "Go to Transaction Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnTransData.UseVisualStyleBackColor = False
        '
        'btnCusData
        '
        Me.btnCusData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCusData.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCusData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCusData.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCusData.Location = New System.Drawing.Point(0, 180)
        Me.btnCusData.Name = "btnCusData"
        Me.btnCusData.Size = New System.Drawing.Size(203, 60)
        Me.btnCusData.TabIndex = 4
        Me.btnCusData.Text = "Customer Data"
        Me.MainTips.SetToolTip(Me.btnCusData, "Go to Customer Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnCusData.UseVisualStyleBackColor = False
        '
        'btnOrderStatus
        '
        Me.btnOrderStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrderStatus.FlatAppearance.BorderSize = 0
        Me.btnOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrderStatus.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderStatus.Location = New System.Drawing.Point(0, 120)
        Me.btnOrderStatus.Name = "btnOrderStatus"
        Me.btnOrderStatus.Size = New System.Drawing.Size(203, 60)
        Me.btnOrderStatus.TabIndex = 3
        Me.btnOrderStatus.Text = "Order Status"
        Me.MainTips.SetToolTip(Me.btnOrderStatus, "Go to Order Status")
        Me.btnOrderStatus.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrder.FlatAppearance.BorderSize = 0
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrder.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrder.Location = New System.Drawing.Point(0, 60)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(203, 60)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "Order"
        Me.MainTips.SetToolTip(Me.btnOrder, "Go to OrderForm")
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenu.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(203, 60)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Menu"
        Me.MainTips.SetToolTip(Me.btnMenu, "Go to Menu Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblUrName)
        Me.pnlTop.Controls.Add(Me.lblStatsRole)
        Me.pnlTop.Controls.Add(Me.btnHome)
        Me.pnlTop.Controls.Add(Me.btnExit)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(950, 35)
        Me.pnlTop.TabIndex = 5
        '
        'lblUrName
        '
        Me.lblUrName.AutoSize = True
        Me.lblUrName.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUrName.ForeColor = System.Drawing.Color.White
        Me.lblUrName.Location = New System.Drawing.Point(140, 9)
        Me.lblUrName.Name = "lblUrName"
        Me.lblUrName.Size = New System.Drawing.Size(45, 19)
        Me.lblUrName.TabIndex = 2
        Me.lblUrName.Text = "User"
        '
        'lblStatsRole
        '
        Me.lblStatsRole.AutoSize = True
        Me.lblStatsRole.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatsRole.ForeColor = System.Drawing.Color.White
        Me.lblStatsRole.Location = New System.Drawing.Point(346, 7)
        Me.lblStatsRole.Name = "lblStatsRole"
        Me.lblStatsRole.Size = New System.Drawing.Size(45, 19)
        Me.lblStatsRole.TabIndex = 2
        Me.lblStatsRole.Text = "Role"
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ImageIndex = 1
        Me.btnHome.ImageList = Me.imgBtn
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(35, 35)
        Me.btnHome.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(298, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Role :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 525)
        Me.Panel1.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.btnDataAnalayze)
        Me.Panel3.Controls.Add(Me.btnAssets)
        Me.Panel3.Controls.Add(Me.btnTransData)
        Me.Panel3.Controls.Add(Me.btnCusData)
        Me.Panel3.Controls.Add(Me.btnOrderStatus)
        Me.Panel3.Controls.Add(Me.btnOrder)
        Me.Panel3.Controls.Add(Me.btnMenu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 382)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 143)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("A little sunshine", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(62, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ice Cream Shop"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Milkshake", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(39, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Frost JR"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 35)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(730, 525)
        Me.pnlMain.TabIndex = 11
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 560)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBtn As ImageList
    Friend WithEvents MainTips As ToolTip
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCusData As Button
    Friend WithEvents btnOrderStatus As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnDataAnalayze As Button
    Friend WithEvents btnAssets As Button
    Friend WithEvents btnTransData As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents lblUrName As Label
    Friend WithEvents lblStatsRole As Label
    Friend WithEvents Label4 As Label
End Class
