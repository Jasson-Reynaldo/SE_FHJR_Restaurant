<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnFinishTrans = New System.Windows.Forms.Button()
        Me.listTransaction = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(90, 60)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(567, 113)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnFinishTrans
        '
        Me.btnFinishTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnFinishTrans.FlatAppearance.BorderSize = 0
        Me.btnFinishTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinishTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnFinishTrans.Location = New System.Drawing.Point(534, 421)
        Me.btnFinishTrans.Name = "btnFinishTrans"
        Me.btnFinishTrans.Size = New System.Drawing.Size(123, 50)
        Me.btnFinishTrans.TabIndex = 2
        Me.btnFinishTrans.Text = "Finish"
        Me.btnFinishTrans.UseVisualStyleBackColor = False
        '
        'listTransaction
        '
        Me.listTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.listTransaction.FormattingEnabled = True
        Me.listTransaction.ItemHeight = 25
        Me.listTransaction.Location = New System.Drawing.Point(90, 201)
        Me.listTransaction.Name = "listTransaction"
        Me.listTransaction.Size = New System.Drawing.Size(567, 204)
        Me.listTransaction.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Current Transaction"
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 525)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listTransaction)
        Me.Controls.Add(Me.btnFinishTrans)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransactionForm"
        Me.Text = "TransactionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnFinishTrans As Button
    Friend WithEvents listTransaction As ListBox
    Friend WithEvents Label1 As Label
End Class
