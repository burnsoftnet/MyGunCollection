Imports System.ComponentModel
Imports BSMyGunCollection.MGC

Public Class frmEditNationality
    Public UpdatePending As Boolean
    Private Sub frmEditNationality_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Gun_NationalityTableAdapter.Fill(Me.MGCDataSet.Gun_Nationality)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmEditNationality_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Try
            DataGridView1.Width = Me.Width - 15
            DataGridView1.Height = Me.Height - 39
        Catch ex As Exception
            Dim sSubFunc As String = "Resize"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub GunNationalityBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunNationalityBindingSource.ListChanged
        Try
            If Me.MGCDataSet.HasChanges Then
                Me.UpdatePending = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "GunNationalityBindingSource_ListChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Try
            If Me.UpdatePending Then
                Me.Gun_NationalityTableAdapter.Update(Me.MGCDataSet.Gun_Nationality)
                Dim Obj As New BSDatabase
                Obj.UpdateSyncDataTables("Gun_Nationality")
                Me.UpdatePending = False
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView1_RowValidated    "
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class