Imports BSMyGunCollection.MGC
Public Class frmViewWishList

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_WishList
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmAddToWishList.MdiParent = Me.MdiParent
        frmAddToWishList.Show()
    End Sub
    Public Sub RefreshData()
        Me.WishlistTableAdapter.Fill(Me.MGCDataSet.Wishlist)
    End Sub
    Private Sub frmViewWishList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub
    Private Sub frmViewWishList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> 0 Then
            DataGridView1.Height = Me.Height - 68
            DataGridView1.Width = Me.Width - 10
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Call RefreshData()
    End Sub
    Sub DoEditItem()
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmEditWishlist.MdiParent = Me.MdiParent
        frmEditWishlist.ItemID = ItemID
        frmEditWishlist.Show()
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Call DoEditItem()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Call DoEditItem()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        Dim Obj As New BSDatabase
        Dim ObjG As New GlobalFunctions
        Dim strName As String = ObjG.GetWishListName(ItemID)
        Dim strAns As String = MsgBox("Are you sure you want to delete " & strName & "?", MsgBoxStyle.YesNo, "Delete Item from Wishlist")
        Dim SQL As String = "DELETE from Wishlist where ID=" & ItemID
        If strAns = vbYes Then Obj.ConnExec(SQL) : Call RefreshData()
    End Sub
End Class