Public Class frmLinkFromExistingDoc
    Public GID As Long
    Private Sub frmLinkFromExistingDoc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub
    Sub RefreshData()
        Try
            Me.Gun_Collection_DocsTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Docs)
        Catch ex As Exception
            Dim sSubFunc As String = "RefreshData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim docName As String = cmbDoc.SelectedText
        Dim DocID As Long = cmbDoc.SelectedValue
        Dim objAddObject As New frmAddDocument
        If objAddObject.PerformDocLink(GID, DocID) Then
            Dim sAns As String = MsgBox(docName & " was linked to this firearm, Do you wish to add another?", MsgBoxStyle.YesNo, "Doc Linked")
            If sAns = vbYes Then
                Call RefreshData()
            Else
                Me.Close()
            End If
        Else
            MsgBox("An Error occured while attempt to link " & docName & " to firearm, Please try again.")
        End If
    End Sub
End Class