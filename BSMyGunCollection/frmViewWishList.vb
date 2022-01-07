Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmViewWishList.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewWishList
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New FrmViewReportWishList
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        frmAddToWishList.MdiParent = MdiParent
        frmAddToWishList.Show()
    End Sub
    ''' <summary>
    ''' Refreshes the data.
    ''' </summary>
    Public Sub RefreshData()
        WishlistTableAdapter.Fill(MGCDataSet.Wishlist)
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewWishList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewWishList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmViewWishList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewWishList_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Height <> 0 Then
            DataGridView1.Height = Height - 68
            DataGridView1.Width = Width - 10
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click
        Call RefreshData()
    End Sub
    ''' <summary>
    ''' Does the edit item.
    ''' </summary>
    Sub DoEditItem()
        Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmEditWishlist.MdiParent = MdiParent
        frmEditWishlist.ItemId = itemId
        frmEditWishlist.Show()
    End Sub
    ''' <summary>
    ''' Handles the DoubleClick event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.DoubleClick
        Call DoEditItem()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        Call DoEditItem()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim errOut As String
            '' TODO: #50 Convert this function to use on from the updated library: BurnSoft.Applications.MGC.Other.WishList.GetName
            Dim objG As New GlobalFunctions
            Dim strName As String = objG.GetWishListName(itemId)
            Dim strAns As String = MsgBox("Are you sure you want to delete " & strName & "?", MsgBoxStyle.YesNo, "Delete Item from Wishlist")
            If strAns = vbYes Then 
                If Not BurnSoft.Applications.MGC.Other.WishList.Delete(DatabasePath, Convert.ToInt32(itemId), errOut) Then Throw New Exception(errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "DeleteToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
        Call RefreshData()
    End Sub
End Class