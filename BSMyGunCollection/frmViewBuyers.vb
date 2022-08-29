Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.PeopleAndPlaces

''' <summary>
''' Class frmViewBuyers.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewBuyers
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Refreshes the list.
    ''' </summary>
    Sub RefreshList()
        Try
            Gun_Collection_SoldToTableAdapter.Fill(MGCDataSet.Gun_Collection_SoldTo)
        Catch ex As Exception
            Dim sSubFunc As String = "RefreshList"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewBuyers control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewBuyers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Call RefreshList()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the DoubleClick event of the ListBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.DoubleClick
        Try
            Dim myValue As Long = ListBox1.SelectedValue
            Dim frmNew As New FrmViewBuyerDetails
            frmNew.MdiParent = MdiParent
            frmNew.BuyerId = myValue
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "ListBox1_DoubleClick", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim myValue As Long = ListBox1.SelectedValue
            Dim strName As String = Buyers.GetName(DatabasePath, Convert.ToInt32(myValue), _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strName & " from the database.", MsgBoxStyle.YesNo, "Delete a Buyer")
            Dim intColTotal As Integer = MyCollection.HasCollectionAttached(DatabasePath, Convert.ToInt32(myValue), _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            If sMsg = vbYes Then
                If intColTotal <> 0 Then
                    MsgBox("Cannot delete " & strName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Buyer")
                Else
                    If Not Buyers.Delete(DatabasePath, Convert.ToInt32(myValue), _errOut) Then Throw New Exception(_errOut)
                    If _errOut.Length > 0 Then Throw New Exception(_errOut)
                    Call RefreshList()
                End If
            End If
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton1_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Call RefreshList()
    End Sub
End Class