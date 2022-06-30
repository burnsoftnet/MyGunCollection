Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' for to link firearm to existing document
''' </summary>
Public Class frmLinkFromExistingDoc
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public Gid As Long
    ''' <summary>
    ''' Handles the Load event of the frmLinkFromExistingDoc control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmLinkFromExistingDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub
    ''' <summary>
    ''' Refreshes the data.
    ''' </summary>
    Sub RefreshData()
        Try
            Gun_Collection_DocsTableAdapter.Fill(MGCDataSet.Gun_Collection_Docs)
        Catch ex As Exception
            Call LogError(Name, "RefreshData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim docName As String = cmbDoc.SelectedText
        Dim docId As Long = cmbDoc.SelectedValue
        'Dim objAddObject As New frmAddDocument
        'If objAddObject.PerformDocLink(Gid, docId) Then
        If Documents.PerformDocLink(DatabasePath, Gid, docId, _errOut) Then
            Dim sAns As String = MsgBox(docName & " was linked to this firearm, Do you wish to add another?", MsgBoxStyle.YesNo, "Doc Linked")
            If sAns = vbYes Then
                Call RefreshData()
            Else
                Close()
            End If
        Else
            MsgBox("An Error occurred while attempt to link " & docName & " to firearm, Please try again.")
        End If
    End Sub
End Class