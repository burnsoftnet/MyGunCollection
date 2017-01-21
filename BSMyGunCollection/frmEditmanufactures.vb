Public Class frmEditmanufactures
    Public UpdatePending As Boolean
    Private Sub frmEditmanufactures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gun_ManufacturerTableAdapter.Fill(Me.MGCDataSet.Gun_Manufacturer)
    End Sub
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_ManufacturerTableAdapter.Update(Me.MGCDataSet.Gun_Manufacturer)
            Dim Obj As New MGC.BSDatabase
            Obj.UpdateSyncDataTables("Gun_Manufacturer")
            Me.UpdatePending = False
        End If
    End Sub
    Private Sub GunManufacturerBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunManufacturerBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub

    Private Sub frmEditmanufactures_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 15
        DataGridView1.Height = Me.Height - 39
    End Sub
End Class