Public Class frmViewGrips
    Public UpdatePending As Boolean
    Private Sub frmViewGrips_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gun_GripTypeTableAdapter.FillBy_ViewEdit(Me.MGCDataSet.Gun_GripType)
    End Sub
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_GripTypeTableAdapter.Update(Me.MGCDataSet.Gun_GripType)
            Me.UpdatePending = False
        End If
    End Sub
    Private Sub GunGripTypeBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunGripTypeBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
    Private Sub frmViewGrips_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 13
        DataGridView1.Height = Me.Height - 65
    End Sub
End Class