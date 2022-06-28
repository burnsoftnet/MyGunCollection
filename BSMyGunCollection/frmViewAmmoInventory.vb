Imports System.ComponentModel
Imports BSMyGunCollection.LogginAndSettings
Imports BurnSoft.Applications.MGC.Ammo
''' <summary>
''' Class frmViewAmmoInventory. Form to view ammo inventory
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewAmmoInventory
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String

    ''' <summary>
    ''' Handles the Disposed event of the frmViewAmmoInventory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewAmmoInventory_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        Dim objVs As New ViewSizeSettings
        objVs.SaveViewAmmoInv(Height, Width, Location.X, Location.Y)

    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewAmmoInventory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewAmmoInventory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim objVs As New ViewSizeSettings
            objVs.LoadViewAmmoInv(Height, Width, Location)

            If Auditammo Then
                ToolStripButton5.Visible = True
                ToolStripButton6.Visible = True
                ToolStripButton1.Visible = False
            Else
                ToolStripButton5.Visible = False
                ToolStripButton6.Visible = False
                ToolStripButton1.Visible = True
            End If
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Gun_Collection_AmmoTableAdapter.Fill(MGCDataSet.Gun_Collection_Ammo)
            tslAmmoTotal.Text = $"Total Rounds in Inventory: " & Inventory.GetTotalInventory(DatabasePath, _errOut)
            if _errOut.Length > 0 Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmViewAmmoInventory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewAmmoInventory_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Try
            If Height <> 0 Then
                DataGridView1.Height = Height - 68
                DataGridView1.Width = Width - 19
            End If
        Catch ex As Exception
            Call LogError(Name, "Resize", Err.Number, ex.Message.ToString)
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
                Gun_Collection_AmmoTableAdapter.Update(MGCDataSet.Gun_Collection_Ammo)
                UpdatePending = False
            End If
        Catch ex As Exception
            Call LogError(Name, "DataGridView1_RowValidated", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunCollectionAmmoBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
' ReSharper disable once VBWarnings::BC42309
    ''' <param name="e">The <see cref="ComponentModel.ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCollectionAmmoBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunCollectionAmmoBindingSource.ListChanged
        Try
            If MGCDataSet.HasChanges Then
                UpdatePending = True
            End If
        Catch ex As Exception
            Call LogError(Name, "GunCollectionAmmoBindingSource_ListChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <exception cref="Exception"></exception>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim rowId As Long = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(rowId).Selected = True
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim currentCount As String = DataGridView1.SelectedRows.Item(0).Cells.Item(7).Value
            Dim addToQty As String = InputBox("Type in the amount to add to the Qty.", "Add to Qty")
            If Len(addToQty) > 0 Then
                Dim errOut As String=""
                If Not Inventory.UpdateQty(DatabasePath, CLng(itemId), CLng(currentCount), CInt(addToQty), errOut) Then Throw new Exception(errOut)
            End If
            DataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton1_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click
        Try
            Dim rowId As Long = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(rowId).Selected = True
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim strName As String = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value & " " & DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value
            Dim sAns As String = MsgBox("Are you sre you wish to delete " & strName & " from the inventory?", MsgBoxStyle.YesNo, Text)
            If sAns = vbYes Then
                Dim errOut as String=""
                if Not Inventory.Delete(DatabasePath, CLng(itemId), errOut) Then Throw New Exception(errOut)
            End If
            DataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton3_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click
        Dim frmNew As New frmAddCollectionAmmo
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton5 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton5.Click
        Try
            Dim frmNew As New frmAddAmmoAudit
            Dim rowId As Long = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(rowId).Selected = True
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            frmNew.Aid = itemId
            frmNew.CurrentCount = DataGridView1.SelectedRows.Item(0).Cells.Item(7).Value
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton5_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton6 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton6.Click
        Dim frmNew As New frmViewAmmoAuditList
        Dim rowId As Long = DataGridView1.SelectedCells.Item(0).RowIndex
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Rows(rowId).Selected = True
        Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmNew.Aid = itemId
        frmNew.SName = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value & " " & DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
End Class