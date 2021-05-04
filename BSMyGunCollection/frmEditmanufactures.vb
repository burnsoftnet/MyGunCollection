Imports System.ComponentModel
Imports BurnSoft.Applications.MGC

''' <summary>
''' Edit Manufactures form
''' </summary>
Public Class FrmEditmanufactures
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
        Gun_ManufacturerTableAdapter.Fill(MGCDataSet.Gun_Manufacturer)
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If UpdatePending Then
            Gun_ManufacturerTableAdapter.Update(MGCDataSet.Gun_Manufacturer)
            Dim errOut As String = ""
            Database.UpdateSyncDataTables(DatabasePath,"Gun_Manufacturer", errOut)
            UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunManufacturerBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunManufacturerBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunManufacturerBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePending = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditmanufactures control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditmanufactures_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Width - 15
        DataGridView1.Height = Height - 39
    End Sub
End Class