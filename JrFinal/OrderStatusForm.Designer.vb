<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderStatusForm
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
        Me.chlboxOrder = New System.Windows.Forms.CheckedListBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.lsBoxDone = New System.Windows.Forms.ListBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chlboxOrder
        '
        Me.chlboxOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.chlboxOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.chlboxOrder.ForeColor = System.Drawing.Color.White
        Me.chlboxOrder.FormattingEnabled = True
        Me.chlboxOrder.Location = New System.Drawing.Point(0, 0)
        Me.chlboxOrder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chlboxOrder.Name = "chlboxOrder"
        Me.chlboxOrder.ScrollAlwaysVisible = True
        Me.chlboxOrder.Size = New System.Drawing.Size(216, 328)
        Me.chlboxOrder.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnComplete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chlboxOrder)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lsBoxDone)
        Me.SplitContainer1.Size = New System.Drawing.Size(649, 525)
        Me.SplitContainer1.SplitterDistance = 216
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'btnComplete
        '
        Me.btnComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnComplete.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComplete.FlatAppearance.BorderSize = 0
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplete.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnComplete.Location = New System.Drawing.Point(0, 328)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(216, 194)
        Me.btnComplete.TabIndex = 1
        Me.btnComplete.Text = "Order Completed"
        Me.btnComplete.UseVisualStyleBackColor = False
        '
        'lsBoxDone
        '
        Me.lsBoxDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lsBoxDone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsBoxDone.ForeColor = System.Drawing.Color.White
        Me.lsBoxDone.FormattingEnabled = True
        Me.lsBoxDone.ItemHeight = 15
        Me.lsBoxDone.Location = New System.Drawing.Point(0, 0)
        Me.lsBoxDone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lsBoxDone.Name = "lsBoxDone"
        Me.lsBoxDone.ScrollAlwaysVisible = True
        Me.lsBoxDone.Size = New System.Drawing.Size(428, 525)
        Me.lsBoxDone.TabIndex = 0
        '
        'OrderStatusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 525)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "OrderStatusForm"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chlboxOrder As CheckedListBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lsBoxDone As ListBox
    Friend WithEvents btnComplete As Button
End Class
