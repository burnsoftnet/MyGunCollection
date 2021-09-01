Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class FrmViewDocuments.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewDocuments
    ''' <summary>
    ''' Refreshes the data.
    ''' </summary>
    Public Sub RefreshData()
        Try
            Gun_Collection_DocsTableAdapter.Fill(MGCDataSet.Gun_Collection_Docs)
        Catch ex As Exception
            Dim sSubFunc As String = "RefreshData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
        Dim frmNew As New frmAddDocument
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
            Call GetDocumentfromDb(itemId)
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView1_CellContentDoubleClick"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the documentfrom database.  get the document from the database and store it to the Hard Drive
    ''' </summary>
    ''' <param name="itemId">The item identifier.</param>
    Public Sub GetDocumentfromDb(itemId As String)
        Try
            Dim obj As New BSDatabase
            obj.ConnectDB()
            Dim sql As String = "select doc_file,doc_ext from Gun_Collection_Docs where id=" & itemId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
' ReSharper disable once RedundantAssignment
            Dim saveTo As String = ""
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                saveTo = ApplicationPathData & "\mgc_doc_view." & rs("doc_ext")
                Call SaveDocToDhh(rs("doc_file"), saveTo)
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetDocumentfromDB"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Opens the file. After the file was saved the the hdd, open it with it's default program
    ''' if the default program is not installed, it will do nothing
    ''' You might want to find a way to fix that and warn the user
    ''' </summary>
    ''' <param name="sFile">The s file.</param>
    Sub OpenFile(sFile As String)
        Try
            Dim p As New Process
            Dim s As New ProcessStartInfo(sFile)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            p.StartInfo = s
            p.Start()
        Catch ex As Exception
            Dim sSubFunc As String = "OpenFile"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Saves the document to DHH. Dump the blob form the database to this sub to save it to the file and path that is passed
    ''' Once the file has been saved, open it with it's default program
    ''' </summary>
    ''' <param name="buffer">The buffer.</param>
    ''' <param name="pathAndFileName">Name of the path and file.</param>
    Private Sub SaveDocToDhh(buffer As Byte(), pathAndFileName As String)
        Try
            Dim obj As New BSFileSystem
            Call obj.DeleteFile(pathAndFileName)

            Dim fs As FileStream = New FileStream(pathAndFileName, FileMode.Create, FileAccess.ReadWrite)
            Dim bw As New BinaryWriter(fs)
            bw.Write(buffer)
            bw.Close()

            Call OpenFile(pathAndFileName)
        Catch ex As Exception
            Dim sSubFunc As String = "SaveDocToDHH"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ViewToolStripMenuItem control. Context Menu - View Documents
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        Call GetDocumentfromDb(itemId)
    End Sub
    ''' <summary>
    ''' Linked the docs. Return the number of firearms that are linked to the selected document
    ''' </summary>
    ''' <param name="docId">The document identifier.</param>
    ''' <returns>System.Int64.</returns>
    Function LinkedDocs(docId As Long) As Long
        Dim lAns As Long = 0
        Try
            Dim obj As New BSDatabase
            obj.ConnectDB()
            Dim sQl As String = "select count(*) as total from Gun_Collection_Docs_Links where did=" & docId
            Dim cmd As New OdbcCommand(sQl, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                lAns = rs("total")
            End While
            rs.Close()
            obj.CloseDB()

        Catch ex As Exception
            Dim sSubFunc As String = "LinkedDocs"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return lAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem control. Context Menu - Delete selected document
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim sql As String = "delete from Gun_Collection_Docs where id=" & itemId
' ReSharper disable RedundantAssignment
            Dim sMessage As String = ""
' ReSharper restore RedundantAssignment
            Dim lLinked As Long = LinkedDocs(itemId)

            If lLinked = 0 Then
                sMessage = "Are you sure you wish to delete this document?"
            Else
                sMessage = "There are " & lLinked & " firearm(s) linked to this document." & vbCrLf & "Are you sure you wish to delete this document?"
            End If

            Dim sAns As String = MsgBox(sMessage, MsgBoxStyle.YesNo, "Confirm")

            If sAns = vbYes Then
                Dim obj As New BSDatabase
                obj.ConnExec(sql)
                If lLinked > 0 Then
                    obj.ConnExec("delete from Gun_Collection_Docs_Links where did=" & itemId)
                End If

                Call RefreshData()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim frmNew As New frmLinkDocToFirearm
            frmNew.DocId = CLng(itemId)
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "AttachToFirearmToolStripMenuItem_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim frmNew As New frmAddDocument
        frmNew.Did = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmNew.EditMode = True
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
End Class