Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Imports ADODB
Imports System.Data.OleDb
Public Class frmViewDocuments
    Const FormName = "frmViewDocuments"
    Public Sub RefreshData()
        Try
            Me.Gun_Collection_DocsTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Docs)
        Catch ex As Exception
            Dim sSubFunc As String = FormName & ".RefreshData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmViewDocuments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New frmAddDocument
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Call GetDocumentfromDB(ItemID)
        Catch ex As Exception
            Dim sSubFunc As String = FormName & ".DataGridView1_CellContentDoubleClick"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub GetDocumentfromDB(ItemID As String)
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "select doc_file,doc_ext from Gun_Collection_Docs where id=" & ItemID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim SaveTo As String = ""
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                SaveTo = APPLICATION_PATH_DATA & "\mgc_doc_view." & RS("doc_ext")
                Call SaveDocToDHH(RS("doc_file"), SaveTo)
            End While
            RS.Close()
            RS = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = FormName & ".GetDocumentfromDB"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub OpenFile(sFile As String)
        Try
            Dim p As New System.Diagnostics.Process
            Dim s As New System.Diagnostics.ProcessStartInfo(sFile)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            p.StartInfo = s
            p.Start()
        Catch ex As Exception
            Dim sSubFunc As String = FormName & ".OpenFile"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub SaveDocToDHH(buffer As Byte(), PathAndFileName As String)
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
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        Call GetDocumentfromDB(ItemID)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        Dim SQL As String = "delete from Gun_Collection_Docs where id=" & ItemID
        Dim sAns As String = MsgBox("Are you sure you wish to delete this document?", MsgBoxStyle.YesNo, "Confirm")

        If sAns = vbYes Then
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
            Call RefreshData()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Call RefreshData()
    End Sub
End Class