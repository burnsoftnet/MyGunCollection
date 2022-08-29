
Public Class frmViewMaintancePlanList
    ''' <summary>
    ''' Handles the Load event of the frmViewMaintancePlanList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewMaintancePlanList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Maintance_PlansTableAdapter.Fill(MGCDataSet.Maintance_Plans)
    End Sub

    ''' <summary>
    ''' Handles the DoubleClick1 event of the ListBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ListBox1_DoubleClick1(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.DoubleClick
        Dim myValue As Long = ListBox1.SelectedValue
        frmViewMaintancePlan.Id = myValue
        frmViewMaintancePlan.MdiParent = MdiParent
        frmViewMaintancePlan.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripLabel1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel1.Click
        frmAddMaintancePlans.MdiParent = MdiParent
        frmAddMaintancePlans.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripLabel3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripLabel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel3.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripLabel2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripLabel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel2.Click
        Maintance_PlansTableAdapter.Fill(MGCDataSet.Maintance_Plans)
    End Sub
End Class