Imports System.ComponentModel
Imports BSMyGunCollection.MGC

''' <summary>
''' Edit gun conditions
''' </summary>
Public Class FrmEditGunConditions
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditGunConditions control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditGunConditions_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Gun_Collection_ConditionTableAdapter.Fill(MGCDataSet.Gun_Collection_Condition)
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If UpdatePending Then
            Gun_Collection_ConditionTableAdapter.Update(MGCDataSet.Gun_Collection_Condition)
            Dim obj As New BSDatabase
            obj.UpdateSyncDataTables("Gun_Collection_Condition")
            UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged1 event of the GunCollectionConditionBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCollectionConditionBindingSource_ListChanged1(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunCollectionConditionBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePending = True
        End If
    End Sub
End Class