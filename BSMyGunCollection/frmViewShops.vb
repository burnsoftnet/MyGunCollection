Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmViewShops
    Private Sub RefreshList()
        Me.Gun_Shop_DetailsTableAdapter.Fill(Me.MGCDataSet.Gun_Shop_Details)
    End Sub
    Private Sub frmViewShops_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshList()
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Dim MyValue As Long = ListBox1.SelectedValue
        Dim frmNew As New frmViewShopDetails
        frmNew.MdiParent = Me.MdiParent
        frmNew.ShopID = MyValue
        frmNew.Show()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim MyValue As Long = ListBox1.SelectedValue
        Dim ObjGF As New GlobalFunctions
        Dim strShopName As String = ObjGF.GetName("SELECT name from Gun_Shop_Details where ID=" & MyValue, "name")
        Dim Obj As New BSDatabase
        Dim SQL As String = "DELETE from Gun_Shop_Details where ID=" & MyValue
        Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strShopName & " from the database.", MsgBoxStyle.YesNo, "Delete a Shop")
        Dim intColTotal As Integer = ObjGF.HasCollectionAttached(MyValue, "SID")
        If sMsg = vbYes Then
            If intColTotal <> 0 Then
                MsgBox("Cannot delete " & strShopName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Shop")
            Else
                Obj.ConnExec(SQL)
                Call RefreshList()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim MyValue As String = FluffContent(InputBox("Please Type in the Shop Name.", "Add a new Shop."))
        If Len(MyValue) <> 0 Then
            Dim intShopCount As Integer = 0
            Dim ObjGF As New GlobalFunctions
            Dim errOut = ""
            Dim bDoesExist As Boolean = ObjGF.ContactExists("Gun_Shop_Details", "name", MyValue, intShopCount)
            ''Dim intShopCount As Integer = BurnSoft.Applications.MGC.PeopleAndPlaces.Shops.Count(ApplicationPathData & "\" & DatabaseName,MyValue,  errOut)
            ''Dim bDoesExist As Boolean = BurnSoft.Applications.MGC.PeopleAndPlaces.Shops.Exists(ApplicationPathData & "\" & DatabaseName,MyValue,  errOut)
            Dim sMsg As String = ""
            Dim strName As String = MyValue
            Dim SQL As String = ""
            Dim Obj As New BSDatabase
            If bDoesExist Then
                sMsg = MsgBox(MyValue & " already exists in database.  Do you still wish to add?", MsgBoxStyle.YesNo, "Shop Exists")
                If sMsg = vbYes Then
                    strName = MyValue & " #" & (intShopCount + 1)
                    Call Obj.InsertNewContact(strName, "Gun_Shop_Details", "Name")
                End If
            Else
                Call Obj.InsertNewContact(strName, "Gun_Shop_Details", "Name")
            End If
            Call RefreshList()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Call RefreshList()
    End Sub
End Class