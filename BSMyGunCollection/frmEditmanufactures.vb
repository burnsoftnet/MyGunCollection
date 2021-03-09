Imports System.ComponentModel
Imports BSMyGunCollection.MGC

''' <summary>
''' Edit Manufactures form
''' </summary>
' ReSharper disable once InconsistentNaming
Public Class frmEditmanufactures
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditmanufactures control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditmanufactures_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Gun_ManufacturerTableAdapter.Fill(Me.MGCDataSet.Gun_Manufacturer)
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_ManufacturerTableAdapter.Update(Me.MGCDataSet.Gun_Manufacturer)
            Dim Obj As New BSDatabase
            Obj.UpdateSyncDataTables("Gun_Manufacturer")
            Me.UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunManufacturerBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunManufacturerBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunManufacturerBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditmanufactures control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditmanufactures_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 15
        DataGridView1.Height = Me.Height - 39
    End Sub
End Class