Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Imports ADODB
Imports System.Data.OleDb
Public Class frmAddDocument

    Private Sub frmAddDocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Function GetDocFromHDD(p As String) As Byte()
        Dim fs As New FileStream(p, FileMode.Open, FileAccess.Read)
        Dim br As New BinaryReader(fs)
        Return br.ReadBytes(CInt(fs.Length))

    End Function
    Public Sub InsertDoc(DocPath As String)
        Try
            Dim doc As Byte() = GetDocFromHDD(DocPath)
            Dim Obj As New BSDatabase
            Dim Conn As New OleDbConnection(Obj.sConnectOLE)
            Dim addDoc As New OleDbCommand("insert into table1 (doc_name,doc_description,doc_filename,doc_file,length) values(@doc_name,@doc_description,@doc_filename,@doc_file,@length)", Conn)
            Dim MyDataAdapter As New OleDbDataAdapter()
            MyDataAdapter.InsertCommand = addDoc

            Dim docName As New OleDbParameter("@doc_name", OleDbType.VarChar)
            Dim docDesc As New OleDbParameter("@doc_description", OleDbType.VarChar)
            Dim docFile As New OleDbParameter("@doc_filename", OleDbType.VarChar)

            Dim docPar As New OleDbParameter("@doc_file", OleDbType.VarBinary, doc.Length)
            docPar.Value = doc
            Dim length As New OleDbParameter("@length", OleDbType.[Integer])
            length.Value = doc.Length

            MyDataAdapter.InsertCommand.Parameters.Add(docName)
            MyDataAdapter.InsertCommand.Parameters.Add(docDesc)
            MyDataAdapter.InsertCommand.Parameters.Add(docFile)
            MyDataAdapter.InsertCommand.Parameters.Add(docPar)
            MyDataAdapter.InsertCommand.Parameters.Add(length)

            ' connect
            Conn.Open()
            ' insert)
            addDoc.ExecuteNonQuery()

            Conn.Close()
            '........
        Catch ex As Exception
            Dim sSubFunc As String = "frmAddDocument.InsertDoc"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 3
            OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|Text Files(*.txt)|*.txt|Jpg Files(*.jpg)|*.jpg"
            'If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then lblSelectedDoc.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            Dim sSubFunc As String = "btnBrowse.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Call InsertDoc(lblSelectedDoc.Text)
    End Sub
End Class