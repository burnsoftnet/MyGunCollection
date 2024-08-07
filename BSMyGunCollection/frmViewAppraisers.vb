﻿Imports BSMyGunCollection.MGC
''' <summary>
''' Class FrmViewAppraisers.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewAppraisers
    ''' <summary>
    ''' Refreshes the list.
    ''' </summary>
    Private Sub RefreshList()
        Appriaser_Contact_DetailsTableAdapter.Fill(MGCDataSet.Appriaser_Contact_Details)
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewAppraisers control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewAppraisers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshList()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim myValue As String = FluffContent(InputBox("Please Type in the Appraisers Name.", "Add a new Appraiser."))
        If Len(myValue) <> 0 Then
            Dim intShopCount As Integer = 0
            Dim objGf As New GlobalFunctions
            Dim bDoesExist As Boolean = objGf.ContactExists("Appriaser_Contact_Details", "aName", myValue, intShopCount)
            Dim sMsg As String
            Dim strName As String = myValue
            Dim obj As New BSDatabase
            If bDoesExist Then
                sMsg = MsgBox(myValue & " already exists in database.  Do you still wish to Add?", MsgBoxStyle.YesNo, "Gunsmith Exists")
                If sMsg = vbYes Then
                    strName = myValue & " #" & (intShopCount + 1)
                    Call obj.InsertNewContact(strName, "Appriaser_Contact_Details", "aName")
                End If
            Else
                Call obj.InsertNewContact(strName, "Appriaser_Contact_Details", "aName")
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
        Dim frmNew As New frmViewAppraiserDetails
        frmNew.MdiParent = MdiParent
        frmNew.ShopId = myValue
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim myValue As Long = ListBox1.SelectedValue
        Dim objGf As New GlobalFunctions
        Dim strShopName As String = objGf.GetName("SELECT aname from Appriaser_Contact_Details where ID=" & myValue, "aname")
        Dim obj As New BSDatabase
        Dim sql As String = "DELETE from Appriaser_Contact_Details where ID=" & myValue
        Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strShopName & " from the database.", MsgBoxStyle.YesNo, "Delete an Appraiser")
        Dim intColTotal As Integer = objGf.HasCollectionAttached(strShopName, "AppraisedBy")
        If sMsg = vbYes Then
            If intColTotal <> 0 Then
                MsgBox("Cannot delete " & strShopName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Appraiser")
            Else
                obj.ConnExec(sql)
                Call RefreshList()
            End If
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