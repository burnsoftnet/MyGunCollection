Imports BurnSoft.Applications.MGC

''' <summary>
''' Edit the Gun Classification Form
''' </summary>
Public Class EditGunClassications
    Public UpdatePending As Boolean
    ''' <summary>
    ''' load the table with the database from the database
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditGunClassications_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        Gun_Collection_ClassificationTableAdapter.Fill(MGCDataSet.Gun_Collection_Classification)
    End Sub
    ''' <summary>
    ''' check to see if the row was updated, if so then run the update command
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If UpdatePending Then
            Gun_Collection_ClassificationTableAdapter.Update(MGCDataSet.Gun_Collection_Classification)
            'TODO #43 Delete unused code
            'Dim Obj As New MGC.BSDatabase
            'Obj.UpdateSyncDataTables("Gun_Collection_Classification")
            Dim errOut As String = ""
            If Not Database.UpdateSyncDataTables(DatabasePath,"Gun_Collection_Classification",errOut ) Then Throw New Exception(errOut)
            UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunManufacturerBindingSource control and update has occurred, and mark that there is a update pending.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunManufacturerBindingSource_ListChanged(ByVal sender As Object, ByVal e As ComponentModel.ListChangedEventArgs) Handles GunCollectionClassificationBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePending = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frm Edit manufactures control. Size the Data grid to fit the form
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditmanufactures_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Width - 15
        DataGridView1.Height = Height - 39
    End Sub
End Class