﻿Public Class EditGunClassications
    Public UpdatePending As Boolean
    'load the table with the database from the database
    Private Sub EditGunClassications_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Gun_Collection_ClassificationTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Classification)
    End Sub
    'check to see if the row was updated, if so then run the update command
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_Collection_ClassificationTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Classification)
            Dim Obj As New MGC.BSDatabase
            Obj.UpdateSyncDataTables("Gun_Collection_Classification")
            Me.UpdatePending = False
        End If
    End Sub
    'and update has occured, and mark that there is a update pending
    Private Sub GunManufacturerBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionClassificationBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
    'Size the Datagrid to fit the form
    Private Sub frmEditmanufactures_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 15
        DataGridView1.Height = Me.Height - 39
    End Sub
End Class