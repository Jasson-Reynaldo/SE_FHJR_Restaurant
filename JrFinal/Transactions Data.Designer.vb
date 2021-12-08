<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions_Data
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
        Me.pnlOrder = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderValue = New System.Windows.Forms.TextBox()
        Me.cmbSearchOrder = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblmenutitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgOrder = New System.Windows.Forms.DataGridView()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLlineOrderValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSearchLineOrder = New System.Windows.Forms.ComboBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.dgLineOrder = New System.Windows.Forms.DataGridView()
        Me.TransMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMSRefreshTrans = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlOrder.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLine.SuspendLayout()
        CType(Me.dgLineOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOrder
        '
        Me.pnlOrder.AutoScroll = True
        Me.pnlOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlOrder.Controls.Add(Me.Label2)
        Me.pnlOrder.Controls.Add(Me.Label1)
        Me.pnlOrder.Controls.Add(Me.txtOrderValue)
        Me.pnlOrder.Controls.Add(Me.cmbSearchOrder)
        Me.pnlOrder.Controls.Add(Me.Panel3)
        Me.pnlOrder.Controls.Add(Me.Panel2)
        Me.pnlOrder.Controls.Add(Me.dgOrder)
        Me.pnlOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOrder.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrder.Name = "pnlOrder"
        Me.pnlOrder.Size = New System.Drawing.Size(713, 350)
        Me.pnlOrder.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(236, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search By"
        '
        'txtOrderValue
        '
        Me.txtOrderValue.Location = New System.Drawing.Point(239, 82)
        Me.txtOrderValue.Name = "txtOrderValue"
        Me.txtOrderValue.Size = New System.Drawing.Size(148, 20)
        Me.txtOrderValue.TabIndex = 4
        '
        'cmbSearchOrder
        '
        Me.cmbSearchOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchOrder.FormattingEnabled = True
        Me.cmbSearchOrder.Items.AddRange(New Object() {"ORDER_ID", "CUS_ID"})
        Me.cmbSearchOrder.Location = New System.Drawing.Point(46, 82)
        Me.cmbSearchOrder.Name = "cmbSearchOrder"
        Me.cmbSearchOrder.Size = New System.Drawing.Size(146, 21)
        Me.cmbSearchOrder.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblmenutitle)
        Me.Panel3.Location = New System.Drawing.Point(191, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(386, 46)
        Me.Panel3.TabIndex = 2
        '
        'lblmenutitle
        '
        Me.lblmenutitle.AutoSize = True
        Me.lblmenutitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmenutitle.Font = New System.Drawing.Font("Milkshake", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblmenutitle.ForeColor = System.Drawing.Color.White
        Me.lblmenutitle.Location = New System.Drawing.Point(84, 3)
        Me.lblmenutitle.Name = "lblmenutitle"
        Me.lblmenutitle.Size = New System.Drawing.Size(243, 37)
        Me.lblmenutitle.TabIndex = 0
        Me.lblmenutitle.Text = "All Transaction Data"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 3)
        Me.Panel2.TabIndex = 1
        '
        'dgOrder
        '
        Me.dgOrder.AllowUserToAddRows = False
        Me.dgOrder.AllowUserToDeleteRows = False
        Me.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrder.Location = New System.Drawing.Point(46, 109)
        Me.dgOrder.Name = "dgOrder"
        Me.dgOrder.ReadOnly = True
        Me.dgOrder.Size = New System.Drawing.Size(630, 225)
        Me.dgOrder.TabIndex = 0
        '
        'pnlLine
        '
        Me.pnlLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlLine.Controls.Add(Me.Label4)
        Me.pnlLine.Controls.Add(Me.txtLlineOrderValue)
        Me.pnlLine.Controls.Add(Me.Label3)
        Me.pnlLine.Controls.Add(Me.cmbSearchLineOrder)
        Me.pnlLine.Controls.Add(Me.Splitter1)
        Me.pnlLine.Controls.Add(Me.dgLineOrder)
        Me.pnlLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLine.Location = New System.Drawing.Point(0, 350)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(713, 401)
        Me.pnlLine.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(236, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Value"
        '
        'txtLlineOrderValue
        '
        Me.txtLlineOrderValue.Location = New System.Drawing.Point(239, 33)
        Me.txtLlineOrderValue.Name = "txtLlineOrderValue"
        Me.txtLlineOrderValue.Size = New System.Drawing.Size(148, 20)
        Me.txtLlineOrderValue.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search By"
        '
        'cmbSearchLineOrder
        '
        Me.cmbSearchLineOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchLineOrder.FormattingEnabled = True
        Me.cmbSearchLineOrder.Items.AddRange(New Object() {"ORDER_ID", "LINE_ORDER_FLAVOR", "LINE_ORDER"})
        Me.cmbSearchLineOrder.Location = New System.Drawing.Point(56, 33)
        Me.cmbSearchLineOrder.Name = "cmbSearchLineOrder"
        Me.cmbSearchLineOrder.Size = New System.Drawing.Size(136, 21)
        Me.cmbSearchLineOrder.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(713, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dgLineOrder
        '
        Me.dgLineOrder.AllowUserToAddRows = False
        Me.dgLineOrder.AllowUserToDeleteRows = False
        Me.dgLineOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLineOrder.Location = New System.Drawing.Point(56, 60)
        Me.dgLineOrder.Name = "dgLineOrder"
        Me.dgLineOrder.ReadOnly = True
        Me.dgLineOrder.Size = New System.Drawing.Size(630, 302)
        Me.dgLineOrder.TabIndex = 0
        '
        'TransMenu
        '
        Me.TransMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMSRefreshTrans})
        Me.TransMenu.Name = "TransMenu"
        Me.TransMenu.Size = New System.Drawing.Size(141, 26)
        '
        'CMSRefreshTrans
        '
        Me.CMSRefreshTrans.Name = "CMSRefreshTrans"
        Me.CMSRefreshTrans.Size = New System.Drawing.Size(140, 22)
        Me.CMSRefreshTrans.Text = "Refresh Data"
        '
        'Transactions_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.ContextMenuStrip = Me.TransMenu
        Me.Controls.Add(Me.pnlLine)
        Me.Controls.Add(Me.pnlOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transactions_Data"
        Me.Text = "Transactions_Data"
        Me.pnlOrder.ResumeLayout(False)
        Me.pnlOrder.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLine.ResumeLayout(False)
        Me.pnlLine.PerformLayout()
        CType(Me.dgLineOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOrder As Panel
    Friend WithEvents pnlLine As Panel
    Friend WithEvents dgLineOrder As DataGridView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblmenutitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrderValue As TextBox
    Friend WithEvents cmbSearchOrder As ComboBox
    Friend WithEvents dgOrder As DataGridView
    Friend WithEvents txtLlineOrderValue As TextBox
    Friend WithEvents cmbSearchLineOrder As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TransMenu As ContextMenuStrip
    Friend WithEvents CMSRefreshTrans As ToolStripMenuItem
End Class
