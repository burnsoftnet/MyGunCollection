﻿
Imports BSMyGunCollection.MGC
''' <summary>
''' Class FrmViewGunSmiths.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewGunSmiths
    ''' <summary>
    ''' Refreshes the list.
    ''' </summary>
    Private Sub RefreshList()
        GunSmith_Contact_DetailsTableAdapter.Fill(MGCDataSet.GunSmith_Contact_Details)
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewGunSmiths control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewGunSmiths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshList()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim myValue As String = FluffContent(InputBox("Please type in the Gunsmiths name.", "Add a new Gunsmith."))
        If Len(myValue) <> 0 Then
            Dim intShopCount As Integer = 0
            Dim objGf As New GlobalFunctions
            Dim bDoesExist As Boolean = objGf.ContactExists("GunSmith_Contact_Details", "gName", myValue, intShopCount)
            Dim sMsg As String
' ReSharper disable RedundantAssignment
            sMsg = ""
' ReSharper restore RedundantAssignment
            Dim strName As String = myValue
            Dim obj As New BSDatabase
            If bDoesExist Then
                sMsg = MsgBox(myValue & " already exists in database.  Do you still wish to Add?", MsgBoxStyle.YesNo, "Gunsmith Exists")
                If sMsg = vbYes Then
                    strName = myValue & " #" & (intShopCount + 1)
                    Call obj.InsertNewContact(strName, "GunSmith_Contact_Details", "gName")
                End If
            Else
                Call obj.InsertNewContact(strName, "GunSmith_Contact_Details", "gName")
            End If
            Call RefreshList()
        End If
    End Sub
    ''' <summary>
    ''' Handles the DoubleClick event of the ListBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim myValue As Long = ListBox1.SelectedValue
        Dim frmNew As New frmViewGunSmithDetails
        frmNew.MdiParent = MdiParent
        frmNew.ShopId = myValue
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Call RefreshList()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim myValue As Long = ListBox1.SelectedValue
        Dim objGf As New GlobalFunctions
        Dim strShopName As String = objGf.GetName("SELECT gname from GunSmith_Contact_Details where ID=" & myValue, "gname")
        Dim obj As New BSDatabase
        Dim sql As String = "DELETE from GunSmith_Contact_Details where ID=" & myValue
        Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strShopName & " from the database.", MsgBoxStyle.YesNo, "Delete a Shop")
        Dim intColTotal As Integer = objGf.HasCollectionAttached(strShopName, "gsmith", "GunSmith_Details")
        If sMsg = vbYes Then
            If intColTotal <> 0 Then
                MsgBox("Cannot delete " & strShopName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Shop")
            Else
                obj.ConnExec(sql)
                Call RefreshList()
            End If
        End If
    End Sub

End Class