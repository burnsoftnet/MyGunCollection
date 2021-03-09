''Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
''' <summary>
''' Class frmViewShops. View, edit, add or delete the LIst of Shops in the database
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable InconsistentNaming
Public Class frmViewShops
    ' ReSharper restore InconsistentNaming    
    ''' <summary>
    ''' Refreshes the list.
    ''' </summary>
    Private Sub RefreshList()
        Gun_Shop_DetailsTableAdapter.Fill(MGCDataSet.Gun_Shop_Details)
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewShops control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewShops_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call RefreshList()
    End Sub
    ''' <summary>
    ''' Handles the DoubleClick event of the ListBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.DoubleClick
        Dim myValue As Long = ListBox1.SelectedValue
        Dim frmNew As New frmViewShopDetails
        frmNew.MdiParent = MdiParent
        frmNew.ShopId = myValue
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Dim myValue As Long = ListBox1.SelectedValue
        Dim errOut As String = ""
        'TODO #43 Removed used code
        ''Dim ObjGF As New GlobalFunctions
        ''Dim strShopName As String = ObjGF.GetName("SELECT name from Gun_Shop_Details where ID=" & MyValue, "name")
        Dim strShopName As String = Shops.GetName(DatabasePath, myValue, errOut)
        If errOut.Length > 0 Then Call LogError(errOut)
        ''Dim Obj As New BSDatabase
        ''Dim SQL As String = "DELETE from Gun_Shop_Details where ID=" & MyValue
        Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strShopName & " from the database.", MsgBoxStyle.YesNo, "Delete a Shop")
        ''Dim intColTotal As Integer = ObjGF.HasCollectionAttached(MyValue, "SID")
        
        Dim intColTotal As Integer = Shops.HasCollectionAttached(DatabasePath, myValue, errOut)
        If errOut.Length > 0 Then Call LogError(errOut)

        If sMsg = vbYes Then
            If intColTotal <> 0 Then
                MsgBox("Cannot delete " & strShopName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Shop")
            Else
                ''Obj.ConnExec(SQL)
                
                If Not Shops.Delete(DatabasePath, myValue, errOut) Then Call LogError(errOut)
                Call RefreshList()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Dim myValue As String = FluffContent(InputBox("Please Type in the Shop Name.", "Add a new Shop."))
        If Len(myValue) <> 0 Then
            
            ''Dim ObjGF As New GlobalFunctions
            Dim errOut = ""
            ''Dim intShopCount As Integer = 0
            ''Dim bDoesExist As Boolean = ObjGF.ContactExists("Gun_Shop_Details", "name", MyValue, intShopCount)
            Dim intShopCount As Integer = Shops.Count(DatabasePath,myValue,  errOut)
            Dim bDoesExist As Boolean = Shops.Exists(DatabasePath,myValue,  errOut)
            ''Dim sMsg As String = ""
            Dim strName As String = myValue
            ''Dim SQL As String = ""
            ''Dim Obj As New BSDatabase
            Dim doAdd As Boolean = False
            If bDoesExist Then
                Dim sMsg As String = MsgBox(myValue & " already exists in database.  Do you still wish to add?", MsgBoxStyle.YesNo, "Shop Exists")
                If sMsg = vbYes Then
                    strName = myValue & " #" & (intShopCount + 1)
                    ''Call Obj.InsertNewContact(strName, "Gun_Shop_Details", "Name")
                    doAdd = True
                End If
            Else
                ''Call Obj.InsertNewContact(strName, "Gun_Shop_Details", "Name")
                doAdd = True
            End If
            If doAdd Then
                If Not Shops.Add(DatabasePath, strName, errOut) Then Call LogError(errOut)
            End If
            Call RefreshList()
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Call RefreshList()
    End Sub
End Class