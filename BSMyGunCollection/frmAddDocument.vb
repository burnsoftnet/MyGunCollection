'Imports System.IO
'Imports BSMyGunCollection.MGC
'Imports System.Data.Odbc
'Imports ADODB
'Imports System.Data.OleDb
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Types
'' TODO #40 Need to Convert this section to the library
''' <summary>
''' Class frmAddDocument.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddDocument
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' The selected file type
    ''' </summary>
    Dim _selectedFileType As Integer
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As Long
    ''' <summary>
    ''' The did
    ''' </summary>
    Public Did As Long
    ''' <summary>
    ''' The edit mode
    ''' </summary>
    Public EditMode As Boolean
    ''' <summary>
    ''' The file was selected
    ''' </summary>
    Dim _fileWasSelected As Boolean
    ''' <summary>
    ''' Get the ID of the last document that was inserted
    ''' </summary>
    ''' <returns>System.Int64.</returns>
    'Function GetLastId() As Long
    '    Dim lAns As Long = 0
    '    Try
    '        Dim obj As New BSDatabase
    '        Dim sql As String = "select top 1 id from Gun_Collection_Docs order by ID DESC"
    '        obj.ConnectDB()
    '        Dim cmd As New OdbcCommand(sql, obj.Conn)
    '        Dim rs As OdbcDataReader
    '        rs = cmd.ExecuteReader
    '        While rs.Read
    '            lAns = rs("id")
    '        End While
    '        rs.Close()
    '        obj.CloseDB()
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "GetLastID"
    '        Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
    '    End Try
    '    Return lAns
    'End Function
    ''' <summary>
    ''' Ran after the document has been inserted into the database, this will check to see if a GID was passed, if so 
    ''' then it will get the last ID of the document and link it with the firearm.
    ''' </summary>
    Sub CheckForLink()
        Try
            If Gid > 0 Then
' ReSharper disable once LocalVariableHidesMember
                'Dim did As Long = GetLastId()
                Dim did As Long = Documents.GetLastId(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                'PerformDocLink(Gid, did)
                If Not Documents.PerformDocLink(DatabasePath, Gid, did, _errOut) Then Throw New Exception(_errOut)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "CheckForLink"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Link the document to the firearm
    ''' </summary>
    ''' <param name="firearmId">The firearm identifier.</param>
    ''' <param name="documentId">The document identifier.</param>
    ''' <returns>BookmarkEnum.</returns>
    'Public Function PerformDocLink(firearmId As Long, documentId As Long) As BookmarkEnum
    '    Dim bAns As BookmarkEnum = False
    '    Try
    '        Dim obj As New BSDatabase
    '        Dim sql As String = "INSERT INTO Gun_Collection_Docs_Links (GID,DID) VALUES(" & firearmId & "," & documentId & ")"
    '        obj.ConnExec(sql)
    '        bAns = True
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "PerformDocLink"
    '        Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
    '    End Try
    '    Return bAns
    'End Function
    ''' <summary>
    ''' Get the Document from the Hard Drive and return the byte version to be inserted into the database.
    ''' </summary>
    ''' <param name="p">The p.</param>
    ''' <returns>System.Byte().</returns>
    'Private Function GetDocFromHdd(p As String) As Byte()
    '    Dim btAns As Byte() = Nothing
    '    Try
    '        Dim fs As New FileStream(p, FileMode.Open, FileAccess.Read)
    '        Dim br As New BinaryReader(fs)
    '        btAns = br.ReadBytes(CInt(fs.Length))
    '        br.Close()
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "GetDocFromHDD"
    '        Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
    '    End Try
    '    Return btAns
    'End Function
    ''' <summary>
    ''' Insert or update the document and detail based on the Edit mode switch
    ''' </summary>
    ''' <param name="docPath">The document path.</param>
    'Public Sub InsertDoc(docPath As String)
    '    Try
    '        ''Might not even you the doc type thumbnail for now.
    '        'Dim obj As New BSDatabase
    '        'Dim doc As Byte() = GetDocFromHdd(docPath)

    '        'Dim conn As New OleDbConnection(obj.sConnectOLE)
    '        'Dim sql As String = "insert into Gun_Collection_Docs (doc_name,doc_description,doc_filename,doc_file,length,doc_ext,doc_cat) values(@doc_name,@doc_description,@doc_filename,@doc_file,@length,@doc_ext,@doc_cat)"

    '        'Dim addDoc As New OleDbCommand(sql, conn)
    '        'Dim myDataAdapter As New OleDbDataAdapter()

    '        'myDataAdapter.InsertCommand = addDoc

    '        'Dim objFs As New BSFileSystem
    '        'Dim docName As New OleDbParameter("@doc_name", OleDbType.VarChar)
    '        'Dim docDesc As New OleDbParameter("@doc_description", OleDbType.VarChar)
    '        'Dim docCat As New OleDbParameter("@doc_cat", OleDbType.VarChar)

    '        'Dim docFile As New OleDbParameter("@doc_filename", OleDbType.VarChar)
    '        'Dim docPar As New OleDbParameter("@doc_file", OleDbType.VarBinary, doc.Length)
    '        'Dim length As New OleDbParameter("@length", OleDbType.[Integer])
    '        'Dim docType As New OleDbParameter("@doc_ext", OleDbType.VarChar)

    '        'docPar.Value = doc
    '        'length.Value = doc.Length
    '        'docFile.Value = objFs.GetNameOfFile(lblSelectedDoc.Text)
    '        'docType.Value = GetDocType(_selectedFileType)

    '        'docName.Value = txtTitle.Text
    '        'docDesc.Value = txtDescription.Text
    '        'docCat.Value = txtCat.Text

    '        'myDataAdapter.InsertCommand.Parameters.Add(docName)
    '        'myDataAdapter.InsertCommand.Parameters.Add(docDesc)
    '        'myDataAdapter.InsertCommand.Parameters.Add(docFile)
    '        'myDataAdapter.InsertCommand.Parameters.Add(docPar)
    '        'myDataAdapter.InsertCommand.Parameters.Add(length)
    '        'myDataAdapter.InsertCommand.Parameters.Add(docType)
    '        'myDataAdapter.InsertCommand.Parameters.Add(docCat)

    '        '' connect
    '        'conn.Open()
    '        '' insert)
    '        'addDoc.ExecuteNonQuery()

    '        'conn.Close()

    '        Call CheckForLink()

    '        frmViewDocuments.RefreshData()
    '        Close()
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "InsertDoc"
    '        Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
    '    End Try

    'End Sub
    ''' <summary>
    ''' update the document and detail based on the Edit mode switch
    ''' </summary>
    ''' <param name="docPath">The document path.</param>
    'Public Sub UpdateDoc(docPath As String)
    '    Dim sql As String = ""
    '    Try
    '        'Might not even you the doc type thumbnail for now.
    '        'Note OLEDB is picky About the Order, so you need to add the parameters in the same order as it is in the SQL statement.
    '        Dim obj As New BSDatabase
    '        Dim conn As New OleDbConnection(obj.sConnectOLE)
    '        ' connect
    '        conn.Open()

    '        If _fileWasSelected Then
    '            sql = "update Gun_Collection_Docs set doc_name=@doc_name,doc_description=@doc_description,doc_cat=@doc_cat,doc_filename=@doc_filename,doc_file=@doc_file,length=@length,doc_ext=@doc_ext where id=@did"
    '        Else
    '            sql = "update Gun_Collection_Docs set doc_name=@doc_name,doc_description=@doc_description,doc_cat=@doc_cat where id=@did"
    '        End If

    '        Dim addDoc As OleDbCommand = conn.CreateCommand
    '        addDoc.CommandText = sql
    '        addDoc.Connection = conn
    '        addDoc.Parameters.Add(New OleDbParameter("@doc_name", txtTitle.Text))
    '        addDoc.Parameters.Add(New OleDbParameter("@doc_description", txtDescription.Text))
    '        addDoc.Parameters.Add(New OleDbParameter("@doc_cat", txtCat.Text))
    '        If _fileWasSelected Then
    '            Dim objFs As New BSFileSystem
    '            Dim doc As Byte() = GetDocFromHdd(docPath)
    '            addDoc.Parameters.Add(New OleDbParameter("@doc_filename", objFs.GetNameOfFile(lblSelectedDoc.Text)))
    '            addDoc.Parameters.Add(New OleDbParameter("@doc_file", doc))
    '            addDoc.Parameters.Add(New OleDbParameter("@length", doc.Length))
    '            addDoc.Parameters.Add(New OleDbParameter("@doc_ext", GetDocType(_selectedFileType)))
    '        End If

    '        addDoc.Parameters.Add(New OleDbParameter("@did", Did))

    '        addDoc.ExecuteNonQuery()

    '        conn.Close()

    '        frmViewDocuments.RefreshData()
    '        Close()
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "UpdateDoc"
    '        Dim sMsg As String = ex.Message.ToString & vbCrLf & "SQL=" & sql
    '        Call LogError(Name, sSubFunc, Err.Number, sMsg)
    '    End Try
    'End Sub
    ''' <summary>
    ''' Get the document type based on the index from teh Dialog box
    ''' </summary>
    ''' <param name="selectedIndex">Index of the selected.</param>
    ''' <returns>System.String.</returns>
    'Function GetDocType(selectedIndex As Integer) As String
    '    Dim sAns As String = ""

    '    Select Case selectedIndex
    '        Case 1
    '            sAns = "pdf"
    '        Case 2
    '            sAns = "txt"
    '        Case 3
    '            sAns = "jpg"
    '        Case 4
    '            sAns = "bmp"
    '        Case 5
    '            sAns = "doc"
    '        Case 6
    '            sAns = "docx"
    '        Case 7
    '            sAns = "png"
    '    End Select
    '    Return sAns
    'End Function
    ''' <summary>
    ''' Action to take once the browse button is clicked
    ''' This will allow the user to select the document to inert into the database
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 1
            'OpenFileDialog1.Filter = $"PDF Files(*.pdf)|*.pdf|Text Files(*.txt)|*.txt|Jpg Files(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|Microsoft Word(*.doc)|*.doc|Microsoft Word Open XML(*.docx)|*.docx|Portable Network Graphics(*.png)|*.png"
            OpenFileDialog1.Filter = Documents.FileFilterList
            If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
                lblSelectedDoc.Text = OpenFileDialog1.FileName
                _selectedFileType = OpenFileDialog1.FilterIndex
                _fileWasSelected = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnBrowse.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Add/Save Button, when the user is ready they click this button to start the Add/Save data from the form details they filled out
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not EditMode Then
                'Call InsertDoc(lblSelectedDoc.Text)
                If Not Documents.Add(DatabasePath, FluffContent(txtTitle.Text),FluffContent(txtDescription.Text),
                                     FluffContent(txtCat.Text),lblSelectedDoc.Text, _selectedFileType, _errOut ) Then Throw New Exception(_errOut)
                Call CheckForLink()
            Else
                'Call UpdateDoc(lblSelectedDoc.Text)
                If Not Documents.Update(DatabasePath, Did, _fileWasSelected, FluffContent(txtTitle.Text),FluffContent(txtDescription.Text),
                                        FluffContent(txtCat.Text),lblSelectedDoc.Text, _selectedFileType, _errOut ) Then Throw New Exception(_errOut)
            End If
            frmViewDocuments.RefreshData()
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnAdd_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Load the data when in edit mode, to mostly repopulate the fields and the file they selected.
    ''' </summary>
    Sub LoadData()
        Try
            Dim lst As List(Of DocumentList) = Documents.GetList(DatabasePath, Did, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each o As DocumentList In lst
                txtTitle.Text = o.DocName
                txtDescription.Text = o.DocDescription
                txtCat.Text = o.Category
                lblSelectedDoc.Text = o.DocFilename
            Next

        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Form on Load
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadAutoFill()
        _fileWasSelected = False
        If EditMode Then Call LoadData()
    End Sub
    ''' <summary>
    ''' Load AUto Fill for tex boxes
    ''' </summary>
    Sub LoadAutoFill()
        Try
            txtCat.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Documents.Category(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "LoadAutoFill", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class