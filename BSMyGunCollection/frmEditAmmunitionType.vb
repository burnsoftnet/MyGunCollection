Public Class frmEditAmmunitionType
    Public UpdatePending As Boolean
    Private Sub frmEditAmmunitionType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Gun_CalTableAdapter.Fill(Me.MGCDataSet.Gun_Cal)
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Try
            If Me.UpdatePending Then
                Me.Gun_CalTableAdapter.Update(Me.MGCDataSet.Gun_Cal)
                Dim Obj As New MGC.BSDatabase
                Obj.UpdateSyncDataTables("Gun_Cal")
                Me.UpdatePending = False
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView1_RowValidated"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub GunCalBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCalBindingSource.ListChanged
        Try
            If Me.MGCDataSet.HasChanges Then
                Me.UpdatePending = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "GunCalBindingSource_ListChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEditAmmunitionType_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            DataGridView1.Width = Me.Width - 15
            DataGridView1.Height = Me.Height - 39
        Catch ex As Exception
            Dim sSubFunc As String = "Resize"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class