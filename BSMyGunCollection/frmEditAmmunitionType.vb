Imports System.ComponentModel
Imports BurnSoft.Applications.MGC

''' <summary>
''' Edit the Ammunition Type
''' </summary>
Public Class frmEditAmmunitionType
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditAmmunitionType control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditAmmunitionType_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_CalTableAdapter.Fill(MGCDataSet.Gun_Cal)
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Try
            If UpdatePending Then
                Gun_CalTableAdapter.Update(MGCDataSet.Gun_Cal)
                Dim errOut As String = ""
                Database.UpdateSyncDataTables(DatabasePath,"Gun_Cal", errOut)
                If errOut.Length > 0 Then Throw New Exception(errOut)
                UpdatePending = False
            End If
        Catch ex As Exception
            Call LogError(Name, "DataGridView1_RowValidated", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunCalBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCalBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunCalBindingSource.ListChanged
        Try
            If MGCDataSet.HasChanges Then
                UpdatePending = True
            End If
        Catch ex As Exception
            Call LogError(Name, "GunCalBindingSource_ListChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditAmmunitionType control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditAmmunitionType_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Try
            DataGridView1.Width = Width - 15
            DataGridView1.Height = Height - 39
        Catch ex As Exception
            Call LogError(Name, "Resize", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class