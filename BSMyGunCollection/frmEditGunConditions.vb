Public Class frmEditGunConditions
    Public UpdatePending As Boolean
    Private Sub frmEditGunConditions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gun_Collection_ConditionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Condition)
    End Sub
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_Collection_ConditionTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Condition)
            Dim Obj As New MGC.BSDatabase
            Obj.UpdateSyncDataTables("Gun_Collection_Condition")
            Me.UpdatePending = False
        End If
    End Sub
    Private Sub GunCollectionConditionBindingSource_ListChanged1(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionConditionBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
End Class