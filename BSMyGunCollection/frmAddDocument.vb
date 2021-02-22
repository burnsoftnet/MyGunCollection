Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Imports ADODB
Imports System.Data.OleDb
Public Class frmAddDocument
    Dim SelectedFileType As Integer
    Public GID As Long
    Public DID As Long
    Public EditMode As Boolean
    Dim FileWasSelected As Boolean
    'Get the ID of the last document that was inserted
    Function GetLastID() As Long
        Dim lAns As Long = 0
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "select top 1 id from Gun_Collection_Docs order by ID DESC"
            Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                lAns = RS("id")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetLastID"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return lAns
    End Function
    'Ran after the document has been inserted into the database, this will check to see if a GID was passed, if so 
    ' then it will get the last ID of the document and link it with the firearm.
    Sub CheckForLink()
        Try
            If GID > 0 Then
                Dim DID As Long = GetLastID()
                'Dim Obj As New BSDatabase
                'Dim SQL As String = "INSERT INTO Gun_Collection_Docs_Links (GID,DID) VALUES(" & GID & "," & DID & ")"
                'Obj.ConnExec(SQL)
                'Obj = Nothing
                PerformDocLink(GID, DID)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "CheckForLink"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Link the document to the firearm
    Public Function PerformDocLink(FirearmID As Long, DocumentID As Long) As BookmarkEnum
        Dim bAns As BookmarkEnum = False
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "INSERT INTO Gun_Collection_Docs_Links (GID,DID) VALUES(" & FirearmID & "," & DocumentID & ")"
            Obj.ConnExec(SQL)
            bAns = True
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "PerformDocLink"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    'Get the Document from the Hard Drive and return the byte version to be inserted into the database.
    Private Function GetDocFromHDD(p As String) As Byte()
        Dim btAns As Byte() = Nothing
        Try
            Dim fs As New FileStream(p, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fs)
            btAns = br.ReadBytes(CInt(fs.Length))
            br.Close()
            br = Nothing
            fs = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetDocFromHDD"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return btAns
    End Function
    'Insert or update the document and detail based on the Editmode switch
    Public Sub InsertDoc(DocPath As String)
        Try
            'Might not even you the doc type thumbnail for now.
            Dim Obj As New BSDatabase
            Dim doc As Byte() = GetDocFromHDD(DocPath)

            Dim Conn As New OleDbConnection(Obj.sConnectOLE)
            Dim SQL As String = "insert into Gun_Collection_Docs (doc_name,doc_description,doc_filename,doc_file,length,doc_ext,doc_cat) values(@doc_name,@doc_description,@doc_filename,@doc_file,@length,@doc_ext,@doc_cat)"

            Dim addDoc As New OleDbCommand(SQL, Conn)
            Dim MyDataAdapter As New OleDbDataAdapter()

            MyDataAdapter.InsertCommand = addDoc

            Dim ObjFS As New BSFileSystem
            Dim docName As New OleDbParameter("@doc_name", OleDbType.VarChar)
            Dim docDesc As New OleDbParameter("@doc_description", OleDbType.VarChar)
            Dim docCat As New OleDbParameter("@doc_cat", OleDbType.VarChar)

            Dim docFile As New OleDbParameter("@doc_filename", OleDbType.VarChar)
            Dim docPar As New OleDbParameter("@doc_file", OleDbType.VarBinary, doc.Length)
            Dim length As New OleDbParameter("@length", OleDbType.[Integer])
            Dim docType As New OleDbParameter("@doc_ext", OleDbType.VarChar)

            docPar.Value = doc
            length.Value = doc.Length
            docFile.Value = ObjFS.GetNameOfFile(lblSelectedDoc.Text)
            docType.Value = getDocType(SelectedFileType)

            docName.Value = txtTitle.Text
            docDesc.Value = txtDescription.Text
            docCat.Value = txtCat.Text

            MyDataAdapter.InsertCommand.Parameters.Add(docName)
            MyDataAdapter.InsertCommand.Parameters.Add(docDesc)
            MyDataAdapter.InsertCommand.Parameters.Add(docFile)
            MyDataAdapter.InsertCommand.Parameters.Add(docPar)
            MyDataAdapter.InsertCommand.Parameters.Add(length)
            MyDataAdapter.InsertCommand.Parameters.Add(docType)
            MyDataAdapter.InsertCommand.Parameters.Add(docCat)

            ' connect
            Conn.Open()
            ' insert)
            addDoc.ExecuteNonQuery()

            Conn.Close()

            Call CheckForLink()

            frmViewDocuments.RefreshData()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "InsertDoc"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try

    End Sub
    'update the document and detail based on the Editmode switch
    Public Sub UpdateDoc(DocPath As String)
        Dim SQL As String = ""
        Try
            'Might not even you the doc type thumbnail for now.
            'Note OLEDB is picky About the Order, so you need to add the paramters in the same order as it is in the SQL statement.
            Dim Obj As New BSDatabase
            Dim Conn As New OleDbConnection(Obj.sConnectOLE)
            ' connect
            Conn.Open()

            If FileWasSelected Then
                SQL = "update Gun_Collection_Docs set doc_name=@doc_name,doc_description=@doc_description,doc_cat=@doc_cat,doc_filename=@doc_filename,doc_file=@doc_file,length=@length,doc_ext=@doc_ext where id=@did"
            Else
                Sql = "update Gun_Collection_Docs set doc_name=@doc_name,doc_description=@doc_description,doc_cat=@doc_cat where id=@did"
            End If

            Dim addDoc As OleDbCommand = Conn.CreateCommand
            addDoc.CommandText = SQL
            addDoc.Connection = Conn
            addDoc.Parameters.Add(New OleDbParameter("@doc_name", txtTitle.Text))
            addDoc.Parameters.Add(New OleDbParameter("@doc_description", txtDescription.Text))
            addDoc.Parameters.Add(New OleDbParameter("@doc_cat", txtCat.Text))
            If FileWasSelected Then
                Dim ObjFS As New BSFileSystem
                Dim doc As Byte() = GetDocFromHDD(DocPath)
                addDoc.Parameters.Add(New OleDbParameter("@doc_filename", ObjFS.GetNameOfFile(lblSelectedDoc.Text)))
                addDoc.Parameters.Add(New OleDbParameter("@doc_file", doc))
                addDoc.Parameters.Add(New OleDbParameter("@length", doc.Length))
                addDoc.Parameters.Add(New OleDbParameter("@doc_ext", getDocType(SelectedFileType)))
            End If

            addDoc.Parameters.Add(New OleDbParameter("@did", DID))

            addDoc.ExecuteNonQuery()

            Conn.Close()

            frmViewDocuments.RefreshData()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "UpdateDoc"
            Dim sMsg As String = ex.Message.ToString & vbCrLf & "SQL=" & SQL
            Call LogError(Me.Name, sSubFunc, Err.Number, sMsg)
        End Try
    End Sub
    'Get the document type based on the index from teh Dialog box
    Function getDocType(selectedIndex As Integer) As String
        Dim sAns As String = ""

        Select Case selectedIndex
            Case 1
                sAns = "pdf"
            Case 2
                sAns = "txt"
            Case 3
                sAns = "jpg"
            Case 4
                sAns = "bmp"
            Case 5
                sAns = "doc"
            Case 6
                sAns = "docx"
            Case 7
                sAns = "png"
        End Select
        Return sAns
    End Function
    'Action to take once the browse button is clicked
    'This will allow the user to select the document to inert into the database
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|Text Files(*.txt)|*.txt|Jpg Files(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|Microsoft Word(*.doc)|*.doc|Microsoft Word Open XML(*.docx)|*.docx|Portable Network Graphics(*.png)|*.png"
            'If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
                lblSelectedDoc.Text = OpenFileDialog1.FileName
                SelectedFileType = OpenFileDialog1.FilterIndex
                FileWasSelected = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnBrowse.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Add/Save Button, when the user is ready they click this button to start the Add/Save data from the form details they filled out
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If Not EditMode Then
            Call InsertDoc(lblSelectedDoc.Text)
        Else
            Call UpdateDoc(lblSelectedDoc.Text)
        End If
    End Sub
    'Load the data when in edit mode, to mostly prepopulate the fields and the file they selected.
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "Select * from Gun_Collection_Docs where ID=" & DID
            Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                txtTitle.Text = RS("doc_name")
                txtDescription.Text = RS("doc_description")
                txtCat.Text = RS("doc_cat")
                lblSelectedDoc.Text = RS("doc_filename")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Form on Load
    Private Sub frmAddDocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadAutoFill()
        FileWasSelected = False
        If EditMode Then Call LoadData()
    End Sub
    'Load AUto Fill for texboxes
    Sub LoadAutoFill()
        Dim ObjAF As New AutoFillCollections
        txtCat.AutoCompleteCustomSource = ObjAF.Document_Category
    End Sub
End Class