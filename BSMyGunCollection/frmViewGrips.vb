Imports System.ComponentModel
''' <summary>
''' Class frmViewGrips.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewGrips
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmViewGrips control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewGrips_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Gun_GripTypeTableAdapter.FillBy_ViewEdit(MGCDataSet.Gun_GripType)
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If UpdatePending Then
            Gun_GripTypeTableAdapter.Update(MGCDataSet.Gun_GripType)
            UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunGripTypeBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunGripTypeBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunGripTypeBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePending = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmViewGrips control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewGrips_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Width - 13
        DataGridView1.Height = Height - 65
    End Sub
End Class