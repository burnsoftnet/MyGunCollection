''' <summary>
''' Edit gun conditions
''' </summary>
Public Class frmEditGunConditions
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditGunConditions control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditGunConditions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gun_Collection_ConditionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Condition)
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_Collection_ConditionTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Condition)
            Dim Obj As New MGC.BSDatabase
            Obj.UpdateSyncDataTables("Gun_Collection_Condition")
            Me.UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged1 event of the GunCollectionConditionBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCollectionConditionBindingSource_ListChanged1(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionConditionBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
End Class