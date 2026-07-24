Imports System.ComponentModel

Public Class frmViewBarrelSystemData

    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    Private Sub frmViewBarrelSystemData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MGCDataSet.Gun_Collection_Ext' table. You can move, or remove it, as needed.
        Me.Gun_Collection_ExtTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Ext)

    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If UpdatePending Then
            Gun_Collection_ExtTableAdapter.Update(MGCDataSet.Gun_Collection_Ext)
            UpdatePending = False
        End If
    End Sub

    ''' <summary>
    ''' Handles the ListChanged event of the GunGripTypeBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCollectionExtBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunCollectionExtBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePending = True
        End If
    End Sub
End Class