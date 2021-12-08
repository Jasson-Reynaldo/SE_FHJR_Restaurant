<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuthenForm))
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgExit = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCustomer.Location = New System.Drawing.Point(416, 264)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(292, 93)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "CUSTOMER"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdmin.Location = New System.Drawing.Point(94, 264)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(292, 93)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.JrFinal.My.Resources.Resources.R_logo
        Me.PictureBox1.Location = New System.Drawing.Point(349, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Delliciosso Restaurant"
        '
        'imgExit
        '
        Me.imgExit.ImageStream = CType(resources.GetObject("imgExit.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgExit.TransparentColor = System.Drawing.Color.Transparent
        Me.imgExit.Images.SetKeyName(0, "power (1).png")
        Me.imgExit.Images.SetKeyName(1, "power.png")
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.imgExit
        Me.btnExit.Location = New System.Drawing.Point(764, 10)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 49)
        Me.btnExit.TabIndex = 8
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'AuthenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JrFinal.My.Resources.Resources.SE_BgResto_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 496)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AuthenForm"
        Me.Text = "AuthenForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents imgExit As ImageList
    Friend WithEvents btnExit As Button
End Class
