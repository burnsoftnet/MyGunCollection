Imports System.ComponentModel
Imports BurnSoft.Applications.MGC

''' <summary>
''' Class FrmEditNationality.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditNationality
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditNationality control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditNationality_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_NationalityTableAdapter.Fill(MGCDataSet.Gun_Nationality)
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditNationality control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditNationality_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Try
            DataGridView1.Width = Width - 15
            DataGridView1.Height = Height - 39
        Catch ex As Exception
            Call LogError(Name, "Resize", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunNationalityBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunNationalityBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunNationalityBindingSource.ListChanged
        Try
            If MGCDataSet.HasChanges Then
                UpdatePending = True
            End If
        Catch ex As Exception
            Call LogError(Name, "GunNationalityBindingSource_ListChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Try
            If UpdatePending Then
                Gun_NationalityTableAdapter.Update(MGCDataSet.Gun_Nationality)
                Dim errOut As String = ""
                Database.UpdateSyncDataTables(DatabasePath,"Gun_Nationality", errOut)
                UpdatePending = False
            End If
        Catch ex As Exception
            Call LogError(Name, "DataGridView1_RowValidated", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class