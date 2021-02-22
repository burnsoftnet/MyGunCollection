Public Class EditGunClassications
    Public UpdatePending As Boolean
    ''' <summary>
    ''' load the table with the database from the database
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditGunClassications_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Gun_Collection_ClassificationTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Classification)
    End Sub
    ''' <summary>
    ''' check to see if the row was updated, if so then run the update command
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePending Then
            Me.Gun_Collection_ClassificationTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Classification)
            Dim Obj As New MGC.BSDatabase
            Obj.UpdateSyncDataTables("Gun_Collection_Classification")
            Me.UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunManufacturerBindingSource control and update has occured, and mark that there is a update pending.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunManufacturerBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionClassificationBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditmanufactures control. Size the Datagrid to fit the form
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditmanufactures_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 15
        DataGridView1.Height = Me.Height - 39
    End Sub
End Class