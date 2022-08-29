Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' Class frmViewDocuments.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewDocuments
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Refreshes the data.
    ''' </summary>
    Public Sub RefreshData()
        Try
            Gun_Collection_DocsTableAdapter.Fill(MGCDataSet.Gun_Collection_Docs)
        Catch ex As Exception
            Call LogError(Name, "RefreshData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewDocuments control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.  Tool Strip Bar - Add new Document to database
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New FrmAddDocument
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the CellContentDoubleClick event of the DataGridView1 control.  On double click start the getdocumentfromDB routine
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            If Not Documents.GetDocumentFromDb(DatabasePath, ApplicationPath, itemId, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "DataGridView1_CellContentDoubleClick", Err.Number, ex.Message.ToString)
        End Try
    End Sub
   
    ''' <summary>
    ''' Handles the Click event of the ViewToolStripMenuItem control. Context Menu - View Documents
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Try 
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            If Not Documents.GetDocumentFromDb(DatabasePath, ApplicationPath, itemId, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "ViewToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
   
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem control. Context Menu - Delete selected document
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim sMessage As String = "Are you sure you wish to delete this document?"
            Dim lLinked As Long = Documents.CountLinkedDocs(DatabasePath, itemId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

            If lLinked > 0 Then
                sMessage = "There are " & lLinked & " firearm(s) linked to this document." & vbCrLf & "Are you sure you wish to delete this document?"
            End If

            Dim sAns As String = MsgBox(sMessage, MsgBoxStyle.YesNo, "Confirm")

            If sAns = vbYes Then
                If lLinked > 0 Then
                    If Not Documents.Delete(DatabasePath, itemId, _errOut) Then Throw New Exception(_errOut)
                End If

                Call RefreshData()
            End If
        Catch ex As Exception
            Call LogError(Name, "DeleteToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control. Tool Bar strip -  Refresh data
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Call RefreshData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the AttachToFirearmToolStripMenuItem control. Context menu Attach document to firearm
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub AttachToFirearmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachToFirearmToolStripMenuItem.Click
        Try
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim frmNew As New FrmLinkDocToFirearm
            frmNew.DocId = CLng(itemId)
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "AttachToFirearmToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim frmNew As New FrmAddDocument
        frmNew.Did = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmNew.EditMode = True
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
End Class