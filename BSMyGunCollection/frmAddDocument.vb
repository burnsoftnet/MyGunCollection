Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmAddDocument.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddDocument
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
    ''' Ran after the document has been inserted into the database, this will check to see if a GID was passed, if so 
    ''' then it will get the last ID of the document and link it with the firearm.
    ''' </summary>
    Sub CheckForLink()
        Try
            If Gid > 0 Then
' ReSharper disable once LocalVariableHidesMember
                Dim did As Long = Documents.GetLastId(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                If Not Documents.PerformDocLink(DatabasePath, Gid, did, _errOut) Then Throw New Exception(_errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "CheckForLink", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Action to take once the browse button is clicked
    ''' This will allow the user to select the document to inert into the database
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.Filter = Documents.FileFilterList
            If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
                lblSelectedDoc.Text = OpenFileDialog1.FileName
                _selectedFileType = OpenFileDialog1.FilterIndex
                _fileWasSelected = True
            End If
        Catch ex As Exception
            Call LogError(Name, "btnBrowse.Click", Err.Number, ex.Message.ToString)
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
                If Not Documents.Add(DatabasePath, FluffContent(txtTitle.Text),FluffContent(txtDescription.Text),
                                     FluffContent(txtCat.Text),lblSelectedDoc.Text, _selectedFileType, _errOut ) Then Throw New Exception(_errOut)
                Call CheckForLink()
            Else
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