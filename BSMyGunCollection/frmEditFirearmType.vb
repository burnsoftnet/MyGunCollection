Imports System.ComponentModel

''' <summary>
''' Edit Firearm Types form
''' </summary>
Public Class frmEditFirearmType
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditFirearmType control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditFirearmType_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Gun_TypeTableAdapter.Fill(Me.MGCDataSet.Gun_Type)
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_TypeTableAdapter.Update(Me.MGCDataSet.Gun_Type)
            Me.UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunTypeBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunTypeBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunTypeBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
End Class