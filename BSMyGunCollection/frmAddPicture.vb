Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Imports ADODB
''' <summary>
''' Class frmAddPicture.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddPicture
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemID As String
    ''' <summary>
    ''' Handles the Click event of the btnBrowse control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 3
            OpenFileDialog1.Filter = "Bmp Files(*.bmp)|*.bmp|Gif Files(*.gif)|*.gif|Jpg Files(*.jpg)|*.jpg"
            If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            Dim sSubFunc As String = "btnBrowse.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Determines whether [is first pic] [the specified string cid].
    ''' </summary>
    ''' <param name="strCID">The string cid.</param>
    ''' <returns><c>true</c> if [is first pic] [the specified string cid]; otherwise, <c>false</c>.</returns>
    Function IsFirstPic(ByVal strCID As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Pictures where CID=" & strCID & " and ISMAIN=1"
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                bAns = False
            Else
                bAns = True
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Call Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "IsFirstPic"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If Len(OpenFileDialog1.FileName) = 0 Then
                MsgBox("You need to select a picture!")
                Exit Sub
            End If
            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim sFileName As String = OpenFileDialog1.FileName
            Dim sThumbName As String = APPLICATION_PATH_DATA & "\mgc_thumb.jpg"
            Dim sName As String = FluffContent(txtName.Text, " ")
            Dim sNotes As String = FluffContent(txtNotes.Text, " ")
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
            Dim myNewPic As System.Drawing.Image
            Dim myBitmap As System.Drawing.Image
            myBitmap = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            Dim myPicCallback As System.Drawing.Image.GetThumbnailImageAbort = Nothing
            myNewPic = myBitmap.GetThumbnailImage(intPicWidth, intPicHeight, myPicCallback,
                IntPtr.Zero)
            myBitmap.Dispose()
            System.IO.File.Delete(sThumbName)
            myNewPic.Save(sThumbName, System.Drawing.Imaging.ImageFormat.Jpeg)
            myNewPic.Dispose()
            Dim st_t As New FileStream(sThumbName, FileMode.Open, FileAccess.Read)
            Dim mbr_t As BinaryReader = New BinaryReader(st_t)
            Dim buffer_t(st_t.Length) As Byte
            mbr_t.Read(buffer_t, 0, CInt(st_t.Length))
            st_t.Close()
            '--End Function to convert picture to thumbnail for database format--
            Dim Obj As New BSDatabase
            Dim MyConn As New ADODB.Connection
            MyConn.Open(Obj.sConnect)
            Dim RS As New ADODB.Recordset
            RS.Open("Gun_Collection_Pictures", MyConn, 2, 2)
            RS.AddNew()
            RS("CID").Value = ItemID
            RS("PICTURE").AppendChunk(buffer)
            RS("THUMB").AppendChunk(buffer_t)
            If IsFirstPic(ItemID) Then
                RS("ISMAIN").Value = 1
            Else
                RS("ISMAIN").Value = 0
            End If
            RS("pd_name").Value = sName
            RS("pd_note").Value = sNotes
            RS("sync_lastupdate").Value = Now
            RS.Update()
            RS.Close()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Select Case Err.Number
                Case 5
                    MsgBox("You are currently out of memory!" & Chr(13) & " Please close some programs to free up memory")
                    Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
                Case Else
                    Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
            End Select
        End Try
        Me.Cursor = Cursors.Arrow
        Me.Enabled = True
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddPicture control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddPicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class