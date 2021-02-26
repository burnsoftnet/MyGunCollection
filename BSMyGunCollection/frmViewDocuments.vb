Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Imports ADODB
Imports System.Data.OleDb
Public Class frmViewDocuments
    'Refresh the data in the able
    Public Sub RefreshData()
        Try
            Me.Gun_Collection_DocsTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Docs)
        Catch ex As Exception
            Dim sSubFunc As String = "RefreshData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Form Loads
    Private Sub frmViewDocuments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub
    'Tool Strip Bar - Add new Document to database
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New frmAddDocument
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub
    'On double click start the getdocumentfromDB routine
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Call GetDocumentfromDB(ItemID)
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView1_CellContentDoubleClick"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'get the document from the database and store it to the Hard Drive
    Public Sub GetDocumentfromDB(ItemID As String)
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "select doc_file,doc_ext from Gun_Collection_Docs where id=" & ItemID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim SaveTo As String = ""
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                SaveTo = ApplicationPathData & "\mgc_doc_view." & RS("doc_ext")
                Call SaveDocToDHH(RS("doc_file"), SaveTo)
            End While
            RS.Close()
            RS = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetDocumentfromDB"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'After the file was saved the the hdd, open it with it's default program
    ' if the default program is not installed, it will do nothing
    'You might want to find a way to fix that and warn the user
    Sub OpenFile(sFile As String)
        Try
            Dim p As New System.Diagnostics.Process
            Dim s As New System.Diagnostics.ProcessStartInfo(sFile)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            p.StartInfo = s
            p.Start()
        Catch ex As Exception
            Dim sSubFunc As String = "OpenFile"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Dump the blob form the database to this sub to save it to the file and path that is passed
    'Once the file has been saved, open it with it's default program
    Private Sub SaveDocToDHH(buffer As Byte(), PathAndFileName As String)
        Try
            Dim Obj As New BSFileSystem
            Call Obj.DeleteFile(PathAndFileName)
            Obj = Nothing
            Dim fs As FileStream = New FileStream(PathAndFileName, FileMode.Create, FileAccess.ReadWrite)
            Dim bw As New BinaryWriter(fs)
            bw.Write(buffer)
            bw.Close()
            bw = Nothing
            fs = Nothing
            Call OpenFile(PathAndFileName)
        Catch ex As Exception
            Dim sSubFunc As String = "SaveDocToDHH"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Context Menu - View Documents
    Private Sub ViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        Call GetDocumentfromDB(ItemID)
    End Sub
    'Return the number of firearms that are linked to the selected document
    Function LinkedDocs(DocID As Long) As Long
        Dim lAns As Long = 0
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQl As String = "select count(*) as total from Gun_Collection_Docs_Links where did=" & DocID
            Dim CMD As New OdbcCommand(SQl, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                lAns = RS("total")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LinkedDocs"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return lAns
    End Function
    'Context Menu - Delete selected document
    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim SQL As String = "delete from Gun_Collection_Docs where id=" & ItemID
            Dim sMessage As String = ""
            Dim lLinked As Long = LinkedDocs(ItemID)

            If lLinked = 0 Then
                sMessage = "Are you sure you wish to delete this document?"
            Else
                sMessage = "There are " & lLinked & " firearm(s) linked to this document." & vbCrLf & "Are you sure you wish to delete this document?"
            End If

            Dim sAns As String = MsgBox(sMessage, MsgBoxStyle.YesNo, "Confirm")

            If sAns = vbYes Then
                Dim Obj As New BSDatabase
                Obj.ConnExec(SQL)
                If lLinked > 0 Then
                    Obj.ConnExec("delete from Gun_Collection_Docs_Links where did=" & ItemID)
                End If
                Obj = Nothing
                Call RefreshData()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Tool Bar strip -  Refresh data
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Call RefreshData()
    End Sub
    'Context menu Attach document to firearm
    Private Sub AttachToFirearmToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AttachToFirearmToolStripMenuItem.Click
        Try
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim frmNew As New frmLinkDocToFirearm
            frmNew.DocID = CLng(ItemID)
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "AttachToFirearmToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim frmNew As New frmAddDocument
        frmNew.DID = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmNew.EditMode = True
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub
End Class