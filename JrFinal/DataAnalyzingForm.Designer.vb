<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataAnalyzingForm
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsNewForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsCustomerDataF = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsEmployeeDataF = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDataFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsIceDataF = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsToppingDataF = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsFlavorDataF = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.FormViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsNewForm, Me.ToolStripSeparator1, Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MsNewForm
        '
        Me.MsNewForm.Name = "MsNewForm"
        Me.MsNewForm.Size = New System.Drawing.Size(180, 22)
        Me.MsNewForm.Text = "New Blank Form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsCustomerDataF, Me.tsmTransaction, Me.MsEmployeeDataF, Me.MenuDataFormToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'MsCustomerDataF
        '
        Me.MsCustomerDataF.Name = "MsCustomerDataF"
        Me.MsCustomerDataF.Size = New System.Drawing.Size(186, 22)
        Me.MsCustomerDataF.Text = "CustomerDataForm"
        '
        'MsEmployeeDataF
        '
        Me.MsEmployeeDataF.Name = "MsEmployeeDataF"
        Me.MsEmployeeDataF.Size = New System.Drawing.Size(186, 22)
        Me.MsEmployeeDataF.Text = "EmployeeDataForm"
        '
        'MenuDataFormToolStripMenuItem
        '
        Me.MenuDataFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsIceDataF, Me.MsToppingDataF, Me.MsFlavorDataF})
        Me.MenuDataFormToolStripMenuItem.Name = "MenuDataFormToolStripMenuItem"
        Me.MenuDataFormToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MenuDataFormToolStripMenuItem.Text = "MenuDataForm"
        '
        'MsIceDataF
        '
        Me.MsIceDataF.Name = "MsIceDataF"
        Me.MsIceDataF.Size = New System.Drawing.Size(154, 22)
        Me.MsIceDataF.Text = "Ice Cream Data"
        '
        'MsToppingDataF
        '
        Me.MsToppingDataF.Name = "MsToppingDataF"
        Me.MsToppingDataF.Size = New System.Drawing.Size(154, 22)
        Me.MsToppingDataF.Text = "Topping Data"
        '
        'MsFlavorDataF
        '
        Me.MsFlavorDataF.Name = "MsFlavorDataF"
        Me.MsFlavorDataF.Size = New System.Drawing.Size(154, 22)
        Me.MsFlavorDataF.Text = "Flavor Data"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllFormToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.WindowsToolStripMenuItem.Text = "Forms"
        '
        'CloseAllFormToolStripMenuItem
        '
        Me.CloseAllFormToolStripMenuItem.Name = "CloseAllFormToolStripMenuItem"
        Me.CloseAllFormToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllFormToolStripMenuItem.Text = "Close All Form"
        '
        'FormViewToolStripMenuItem
        '
        Me.FormViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCascade, Me.tsmHorizontal, Me.tsmVertical})
        Me.FormViewToolStripMenuItem.Name = "FormViewToolStripMenuItem"
        Me.FormViewToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.FormViewToolStripMenuItem.Text = "Form View"
        '
        'tsmCascade
        '
        Me.tsmCascade.Name = "tsmCascade"
        Me.tsmCascade.Size = New System.Drawing.Size(166, 22)
        Me.tsmCascade.Text = "Cascade"
        '
        'tsmHorizontal
        '
        Me.tsmHorizontal.Name = "tsmHorizontal"
        Me.tsmHorizontal.Size = New System.Drawing.Size(166, 22)
        Me.tsmHorizontal.Text = "View Horizontally"
        '
        'tsmVertical
        '
        Me.tsmVertical.Name = "tsmVertical"
        Me.tsmVertical.Size = New System.Drawing.Size(166, 22)
        Me.tsmVertical.Text = "View Vertically"
        '
        'tsmTransaction
        '
        Me.tsmTransaction.Name = "tsmTransaction"
        Me.tsmTransaction.Size = New System.Drawing.Size(186, 22)
        Me.tsmTransaction.Text = "TransactionDataForm"
        '
        'DataAnalyzingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 523)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "DataAnalyzingForm"
        Me.Text = "Data Anlyzing"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsNewForm As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsCustomerDataF As ToolStripMenuItem
    Friend WithEvents CloseAllFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmCascade As ToolStripMenuItem
    Friend WithEvents tsmHorizontal As ToolStripMenuItem
    Friend WithEvents tsmVertical As ToolStripMenuItem
    Friend WithEvents MsEmployeeDataF As ToolStripMenuItem
    Friend WithEvents MenuDataFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsIceDataF As ToolStripMenuItem
    Friend WithEvents MsToppingDataF As ToolStripMenuItem
    Friend WithEvents MsFlavorDataF As ToolStripMenuItem
    Friend WithEvents tsmTransaction As ToolStripMenuItem
End Class
