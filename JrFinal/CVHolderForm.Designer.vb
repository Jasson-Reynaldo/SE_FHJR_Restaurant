<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CVHolderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CVHolderForm))
        Me.CvPdf = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.CvPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CvPdf
        '
        Me.CvPdf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CvPdf.Enabled = True
        Me.CvPdf.Location = New System.Drawing.Point(0, 0)
        Me.CvPdf.Name = "CvPdf"
        Me.CvPdf.OcxState = CType(resources.GetObject("CvPdf.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CvPdf.Size = New System.Drawing.Size(530, 525)
        Me.CvPdf.TabIndex = 0
        '
        'CVHolderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 525)
        Me.Controls.Add(Me.CvPdf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CVHolderForm"
        Me.Text = "CVHolderForm"
        CType(Me.CvPdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CvPdf As AxAcroPDFLib.AxAcroPDF
End Class
