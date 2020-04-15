﻿Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmViewAppraisers
    Private Sub RefreshList()
        Me.Appriaser_Contact_DetailsTableAdapter.Fill(Me.MGCDataSet.Appriaser_Contact_Details)
    End Sub
    Private Sub frmViewAppraisers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshList()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim MyValue As String = FluffContent(InputBox("Please Type in the Appraisers Name.", "Add a new Appraiser."))
        If Len(MyValue) <> 0 Then
            Dim intShopCount As Integer = 0
            Dim ObjGF As New GlobalFunctions
            Dim bDoesExist As Boolean = ObjGF.ContactExists("Appriaser_Contact_Details", "aName", MyValue, intShopCount)
            Dim sMsg As String = ""
            Dim strName As String = MyValue
            Dim SQL As String = ""
            Dim Obj As New BSDatabase
            If bDoesExist Then
                sMsg = MsgBox(MyValue & " already eists in database.  Do you still wish to Add?", MsgBoxStyle.YesNo, "Gunsmith Exists")
                If sMsg = vbYes Then
                    strName = MyValue & " #" & (intShopCount + 1)
                    Call Obj.InsertNewContact(strName, "Appriaser_Contact_Details", "aName")
                End If
            Else
                Call Obj.InsertNewContact(strName, "Appriaser_Contact_Details", "aName")
            End If
            Call RefreshList()
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox1.DoubleClick
        Dim MyValue As Long = ListBox1.SelectedValue
        Dim frmNew As New frmViewAppraiserDetails
        frmNew.MdiParent = Me.MdiParent
        frmNew.ShopID = MyValue
        frmNew.Show()
    End Sub
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Dim MyValue As Long = ListBox1.SelectedValue
        Dim ObjGF As New GlobalFunctions
        Dim strShopName As String = ObjGF.GetName("SELECT aname from Appriaser_Contact_Details where ID=" & MyValue, "aname")
        Dim Obj As New BSDatabase
        Dim SQL As String = "DELETE from Appriaser_Contact_Details where ID=" & MyValue
        Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strShopName & " from the database.", MsgBoxStyle.YesNo, "Delete an Appraiser")
        Dim intColTotal As Integer = ObjGF.HasCollectionAttached(strShopName, "AppraisedBy")
        If sMsg = vbYes Then
            If intColTotal <> 0 Then
                MsgBox("Cannot delete " & strShopName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Appraiser")
            Else
                Obj.ConnExec(SQL)
                Call RefreshList()
            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Call RefreshList()
    End Sub
End Class