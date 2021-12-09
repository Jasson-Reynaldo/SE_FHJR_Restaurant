<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.listMenu = New System.Windows.Forms.ListBox()
        Me.numUpDown = New System.Windows.Forms.NumericUpDown()
        Me.btnResetOrder = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.btnClaimOrder = New System.Windows.Forms.Button()
        Me.listOrder = New System.Windows.Forms.ListBox()
        CType(Me.numUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(62, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order ID:"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblOrderID.Location = New System.Drawing.Point(138, 56)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(53, 16)
        Me.lblOrderID.TabIndex = 1
        Me.lblOrderID.Text = "OD****"
        '
        'listMenu
        '
        Me.listMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listMenu.FormattingEnabled = True
        Me.listMenu.ItemHeight = 25
        Me.listMenu.Items.AddRange(New Object() {"Pizza", "Fried Chicken", "Burger", "Fried Rice", "French Fries", "Cake", "Soda", "Juice", "Mineral Water"})
        Me.listMenu.Location = New System.Drawing.Point(65, 74)
        Me.listMenu.Name = "listMenu"
        Me.listMenu.Size = New System.Drawing.Size(197, 154)
        Me.listMenu.TabIndex = 2
        '
        'numUpDown
        '
        Me.numUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.numUpDown.Location = New System.Drawing.Point(65, 268)
        Me.numUpDown.Name = "numUpDown"
        Me.numUpDown.Size = New System.Drawing.Size(196, 30)
        Me.numUpDown.TabIndex = 3
        '
        'btnResetOrder
        '
        Me.btnResetOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnResetOrder.Location = New System.Drawing.Point(65, 331)
        Me.btnResetOrder.Name = "btnResetOrder"
        Me.btnResetOrder.Size = New System.Drawing.Size(250, 60)
        Me.btnResetOrder.TabIndex = 6
        Me.btnResetOrder.Text = "Reset Order"
        Me.btnResetOrder.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnAddOrder.Location = New System.Drawing.Point(374, 331)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(250, 60)
        Me.btnAddOrder.TabIndex = 7
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'btnClaimOrder
        '
        Me.btnClaimOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnClaimOrder.Location = New System.Drawing.Point(216, 417)
        Me.btnClaimOrder.Name = "btnClaimOrder"
        Me.btnClaimOrder.Size = New System.Drawing.Size(250, 60)
        Me.btnClaimOrder.TabIndex = 8
        Me.btnClaimOrder.Text = "Claim Order"
        Me.btnClaimOrder.UseVisualStyleBackColor = True
        '
        'listOrder
        '
        Me.listOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.listOrder.FormattingEnabled = True
        Me.listOrder.ItemHeight = 25
        Me.listOrder.Items.AddRange(New Object() {"" & Global.Microsoft.VisualBasic.ChrW(9) & "Delicioso Restaurant"})
        Me.listOrder.Location = New System.Drawing.Point(296, 74)
        Me.listOrder.Name = "listOrder"
        Me.listOrder.Size = New System.Drawing.Size(361, 229)
        Me.listOrder.TabIndex = 9
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.Controls.Add(Me.listOrder)
        Me.Controls.Add(Me.btnClaimOrder)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.btnResetOrder)
        Me.Controls.Add(Me.numUpDown)
        Me.Controls.Add(Me.listMenu)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        CType(Me.numUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents listMenu As ListBox
    Friend WithEvents numUpDown As NumericUpDown
    Friend WithEvents btnResetOrder As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents btnClaimOrder As Button
    Friend WithEvents listOrder As ListBox
End Class
