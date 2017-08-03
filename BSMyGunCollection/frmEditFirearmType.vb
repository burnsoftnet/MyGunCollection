Public Class frmEditFirearmType
    Public UpdatePending As Boolean
    Private Sub frmEditFirearmType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gun_TypeTableAdapter.Fill(Me.MGCDataSet.Gun_Type)
    End Sub
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_TypeTableAdapter.Update(Me.MGCDataSet.Gun_Type)
            Me.UpdatePending = False
        End If
    End Sub
    Private Sub GunTypeBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunTypeBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
End Class