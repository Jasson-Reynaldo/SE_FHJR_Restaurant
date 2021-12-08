<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlankForm
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
        Me.txtBlank = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtBlank
        '
        Me.txtBlank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBlank.Location = New System.Drawing.Point(0, 0)
        Me.txtBlank.Name = "txtBlank"
        Me.txtBlank.Size = New System.Drawing.Size(211, 186)
        Me.txtBlank.TabIndex = 1
        Me.txtBlank.Text = ""
        '
        'BlankForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 186)
        Me.Controls.Add(Me.txtBlank)
        Me.Name = "BlankForm"
        Me.Text = "BlankForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBlank As RichTextBox
End Class
