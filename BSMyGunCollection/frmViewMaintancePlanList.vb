Public Class frmViewMaintancePlanList

    Private Sub frmViewMaintancePlanList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Maintance_PlansTableAdapter.Fill(Me.MGCDataSet.Maintance_Plans)
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddMaintancePlans.MdiParent = Me
        frmAddMaintancePlans.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ListBox1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Dim MyValue As Long = ListBox1.SelectedValue
        frmViewMaintancePlan.ID = MyValue
        frmViewMaintancePlan.MdiParent = Me.MdiParent
        frmViewMaintancePlan.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        frmAddMaintancePlans.MdiParent = Me.MdiParent
        frmAddMaintancePlans.Show()
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        Me.Close()
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Maintance_PlansTableAdapter.Fill(Me.MGCDataSet.Maintance_Plans)
    End Sub
End Class