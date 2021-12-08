Public Class Assets
    Public Sub switchPanel(ByVal contentPanel As Form)
        pnlTreeMain.Controls.Clear()
        contentPanel.TopLevel = False
        pnlTreeMain.Controls.Add(contentPanel)
        contentPanel.Dock = DockStyle.Fill
        contentPanel.BringToFront()
        contentPanel.Show()
    End Sub

    Private Sub treeAssets_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeAssets.AfterSelect
        If (e.Node.Text = "Ice Cream") Then
            switchPanel(IceCreamData)
        End If

        If (e.Node.Text = "Toppings") Then
            switchPanel(ToppingData)
        End If

        If (e.Node.Text = "Flavor") Then
            switchPanel(FlavorData)
        End If

        If (e.Node.Text = "Employee Data") Then
            switchPanel(EmployeeData)
        End If

        If (e.Node.Text = "Employee Rules") Then
            switchPanel(CVHolderForm)
            CVHolderForm.CvPdf.src = ("D:\IceCream\Documents\Rules.pdf")
        End If
    End Sub
End Class