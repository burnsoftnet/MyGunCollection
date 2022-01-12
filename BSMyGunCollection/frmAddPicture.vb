Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports ADODB
Imports BurnSoft.Applications.MGC.Firearms
''TODO: Convert code from FrmAddPicture #7
''' <summary>
''' Class frmAddPicture.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddPicture
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim errOut As String
    ''' <summary>
    ''' Handles the Click event of the btnBrowse control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 3
            OpenFileDialog1.Filter = $"Bmp Files(*.bmp)|*.bmp|Gif Files(*.gif)|*.gif|Jpg Files(*.jpg)|*.jpg"
            If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            Call LogError(Name, "btnBrowse.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            If Len(OpenFileDialog1.FileName) = 0 Then
                MsgBox("You need to select a picture!")
                Exit Sub
            End If
            Enabled = False
            Cursor = Cursors.WaitCursor

            Dim sName As String = FluffContent(txtName.Text, " ")
            Dim sNotes As String = FluffContent(txtNotes.Text, " ")
            Dim errOut As String = ""
            'TODO: #7 #50 Updated this function with the one from the new library once available and fully tested
            'If Not Pictures.Save(DatabasePath,OpenFileDialog1.FileName,ApplicationPathData,Convert.ToInt32(ItemId),sName, sNotes, errOut) Then Throw New Exception(errOut)

            Dim sFileName As String = OpenFileDialog1.FileName
            Dim sThumbName As String = ApplicationPathData & "\mgc_thumb.jpg"
            'Dim sName As String = FluffContent(txtName.Text, " ")
            'Dim sNotes As String = FluffContent(txtNotes.Text, " ")
            '---Start Function to convert picture to database format-----
            Dim st As New FileStream(sFileName, FileMode.Open, FileAccess.Read)
            Dim mbr As BinaryReader = New BinaryReader(st)
            Dim buffer(st.Length) As Byte
            mbr.Read(buffer, 0, CInt(st.Length))
            st.Close()
            '---End Function to convert picture to database format-----
            '--Start Function to convert picture to thumbnail for database format--
            Dim intPicHeight As Integer = 64
            Dim intPicWidth As Integer = 64
            Dim myNewPic As Image
            Dim myBitmap As Image
            myBitmap = Image.FromFile(OpenFileDialog1.FileName)
            Dim myPicCallback As Image.GetThumbnailImageAbort = Nothing
            myNewPic = myBitmap.GetThumbnailImage(intPicWidth, intPicHeight, myPicCallback,
                IntPtr.Zero)
            myBitmap.Dispose()
            File.Delete(sThumbName)
            myNewPic.Save(sThumbName, ImageFormat.Jpeg)
            myNewPic.Dispose()
            Dim stT As New FileStream(sThumbName, FileMode.Open, FileAccess.Read)
            Dim mbrT As BinaryReader = New BinaryReader(stT)
            Dim bufferT(stT.Length) As Byte
            mbrT.Read(bufferT, 0, CInt(stT.Length))
            stT.Close()
            '--End Function to convert picture to thumbnail for database format--
            Dim obj As New BsDatabase
            Dim myConn As New Connection
            myConn.Open(obj.SConnect)
            Dim rs As New Recordset
            rs.Open("Gun_Collection_Pictures", myConn, 2, 2)
            rs.AddNew()
            rs("CID").Value = ItemId
            rs("PICTURE").AppendChunk(buffer)
            rs("THUMB").AppendChunk(bufferT)
            'If IsFirstPic(ItemId) Then
            If Pictures.IsFirstPic(DatabasePath, Convert.ToInt32(ItemId), errOut) Then
                rs("ISMAIN").Value = 1
            Else
                rs("ISMAIN").Value = 0
            End If
            If errOut.Length > 0 Then Throw New Exception(errOut)

            rs("pd_name").Value = sName
            rs("pd_note").Value = sNotes
            rs("sync_lastupdate").Value = Now
            rs.Update()
            rs.Close()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Select Case Err.Number
                Case 5
                    MsgBox("You are currently out of memory!" & Chr(13) & " Please close some programs to free up memory")
                    Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
                Case Else
                    Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
            End Select
        End Try
        Cursor = Cursors.Arrow
        Enabled = True
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddPicture control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddPicture_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class