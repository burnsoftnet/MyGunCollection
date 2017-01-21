Imports System.Windows.Forms
Imports BSMyGunCollection.MGC
Public Class frmViewAmmoInventory
    Public UpdatePending As Boolean
    'Sub LoadViewSize()
    '    If My.Settings.ViewAmmoInv_Width.Length > 0 And My.Settings.ViewAmmoInv_Height.Length > 0 Then
    '        Me.Height = My.Settings.ViewAmmoInv_Height
    '        Me.Width = My.Settings.ViewAmmoInv_Width
    '    End If
    '    If My.Settings.ViewAmmoInv_X.Length > 0 And My.Settings.ViewAmmoInv_Y.Length > 0 Then
    '        Me.Location = New System.Drawing.Point(My.Settings.ViewAmmoInv_X, My.Settings.ViewAmmoInv_Y)
    '    End If
    'End Sub
    'Sub SaveViewSize()
    '    My.Settings.ViewAmmoInv_Height = Me.Height
    '    My.Settings.ViewAmmoInv_Width = Me.Width
    '    My.Settings.ViewAmmoInv_X = Me.Location.X
    '    My.Settings.ViewAmmoInv_Y = Me.Location.Y
    '    My.Settings.Save()
    'End Sub

    Private Sub frmViewAmmoInventory_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'Call SaveViewSize()
        Dim ObjVS As New ViewSizeSettings
        ObjVS.SaveViewAmmoInv(Me.Height, Me.Width, Me.Location.X, Me.Location.Y)
        ObjVS = Nothing
    End Sub
    Private Sub frmViewAmmoInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Call LoadViewSize()
            Dim ObjVS As New ViewSizeSettings
            ObjVS.LoadViewAmmoInv(Me.Height, Me.Width, Me.Location)
            ObjVS = Nothing
            If AUDITAMMO Then
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
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub LoadData()
        Me.Gun_Collection_AmmoTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Ammo)
        Dim ObjGF As New GlobalFunctions
        tslAmmoTotal.Text = "Total Rounds in Inventory: " & ObjGF.GetTotalAmmoInventory
    End Sub
    Private Sub frmViewAmmoInventory_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.Height <> 0 Then
                DataGridView1.Height = Me.Height - 68
                DataGridView1.Width = Me.Width - 19
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Resize"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        Try
            If Me.UpdatePending Then
                Me.Gun_Collection_AmmoTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Ammo)
                Me.UpdatePending = False
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView1_RowValidated"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub GunCollectionAmmoBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionAmmoBindingSource.ListChanged
        Try
            If Me.MGCDataSet.HasChanges Then
                Me.UpdatePending = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "GunCollectionAmmoBindingSource_ListChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim RowID As Long = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(RowID).Selected = True
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim CurrentCount As String = DataGridView1.SelectedRows.Item(0).Cells.Item(7).Value
            Dim AddToQty As String = InputBox("Type in the amount to add to the Qty.", "Add to Qty")
            If Len(AddToQty) > 0 Then
                Dim lTotal As Long = CLng(CurrentCount) + CLng(AddToQty)
                Dim SQL As String = "UPDATE Gun_Collection_Ammo set Qty=" & lTotal & " where id=" & ItemID
                Dim Obj As New BSDatabase
                Obj.ConnExec(SQL)
            End If
            DataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton1_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Call LoadData()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim RowID As Long = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(RowID).Selected = True
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim strName As String = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value & " " & DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value
            Dim sAns As String = MsgBox("Are you sre you wish to delete " & strName & " from the inventory?", MsgBoxStyle.YesNo, Me.Text)
            If sAns = vbYes Then
                Dim SQL As String = "Delete from Gun_Collection_Ammo where id=" & ItemID
                Dim Obj As New BSDatabase
                Obj.ConnExec(SQL)
                SQL = "DELETE from Gun_Collection_Ammo_PriceAudit where AID=" & ItemID
                Obj.ConnExec(SQL)
            End If
            DataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton3_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim frmNew As New frmAddCollectionAmmo
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            Dim frmNew As New frmAddAmmoAudit
            Dim RowID As Long = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(RowID).Selected = True
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            frmNew.AID = ItemID
            frmNew.CurrentCount = DataGridView1.SelectedRows.Item(0).Cells.Item(7).Value
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton5_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim frmNew As New frmViewAmmoAuditList
        Dim RowID As Long = DataGridView1.SelectedCells.Item(0).RowIndex
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Rows(RowID).Selected = True
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmNew.AID = ItemID
        frmNew.sName = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value & " " & DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub
End Class