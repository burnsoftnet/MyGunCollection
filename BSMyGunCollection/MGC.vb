Imports System.IO
Imports System.Text
Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports ADODB
Imports BurnSoft.Security.RegularEncryption.SHA

Namespace MGC
    ''' <summary>
    ''' Class BSDatabase.
    ''' </summary>
    Public Class BsDatabase
        ''' <summary>
        ''' The Class Name for the error file
        ''' </summary>
        Private Const MyClassName = "MGC.BSDatabase"
        ''' <summary>
        ''' The connection
        ''' </summary>
        Public Conn As OdbcConnection
        ''' <summary>
        ''' ses the connect.
        ''' </summary>
        ''' <returns>System.String.</returns>
        Public Function SConnect() As String
            Return "Driver={Microsoft Access Driver (*.mdb)};dbq=" & ApplicationPathData & "\" & DatabaseName & ";Pwd=14un0t2n0"
        End Function
        ''' <summary>
        ''' ses the connect OLE.
        ''' </summary>
        ''' <returns>System.String.</returns>
        Public Function SConnectOle() As String
            Return "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=""" & ApplicationPathData & "\" & DatabaseName & """;Jet OLEDB:Database Password=14un0t2n0;"
        End Function
        ''' <summary>
        ''' Connects the database.
        ''' </summary>
        Public Sub ConnectDb()
            Try
                Conn = New OdbcConnection(SConnect)
                Conn.Open()
            Catch ex As Exception
                Dim sSubFunc As String = "ConnectDB"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Closes the database.
        ''' </summary>
        Public Sub CloseDb()
            Try
                Conn.Close()
                Conn = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "CloseDB"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Connections the execute.
        ''' </summary>
        ''' <param name="strSql">The string SQL.</param>
        Public Sub ConnExec(ByVal strSql As String)
            Try
                Call ConnectDb()
                Dim cmd As New OdbcCommand
                cmd.Connection = Conn
                cmd.CommandText = strSql
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
                Conn = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "ConnExec"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
                Call LogError(MyClassName, sSubFunc, 0, "ConnExec.strSQL=" & strSql)
            End Try
        End Sub
    End Class

    ''' <summary>
    ''' Class GlobalFunctions. General Functions that is used through out the program
    ''' </summary>
    Public Class GlobalFunctions
        ''' <summary>
        ''' Class Name for error file to help locate where the error occurred
        ''' </summary>
        Private Const MyClassName = "MGC.GlobalFunctions"
        ''' <summary>
        ''' Determines whether [has default picture] [the specified identifier].
        ''' </summary>
        ''' <param name="id">The identifier.</param>
        ''' <param name="addPic">if set to <c>true</c> [add pic].</param>
        ''' <returns><c>true</c> if [has default picture] [the specified identifier]; otherwise, <c>false</c>.</returns>
        Public Function HasDefaultPicture(ByVal id As Long, Optional ByVal addPic As Boolean = False) As Boolean
            Dim bAns As Boolean = False
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim sql As String = "SELECT * from Gun_Collection_Pictures where CID=" & id & " and IsMain=1"
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                bAns = rs.HasRows
                If Not bAns And addPic Then Call AddDefaultPic(id)
                rs.Close()
                obj.CloseDb()
            Catch ex As Exception
                Call LogError(MyClassName, "HasDefaultPicture", Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Adds the default pic.
        ''' </summary>
        ''' <param name="itemId">The item identifier.</param>
        Sub AddDefaultPic(ByVal itemId As Long)
            Try
                Dim sFileName As String = ApplicationPath & "\" & DefaultPic
                Dim sThumbName As String = ApplicationPath & "\mgc_thumb.jpg"
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
                myBitmap = Image.FromFile(sFileName)
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
                rs("CID").Value = itemId
                rs("PICTURE").AppendChunk(buffer)
                rs("THUMB").AppendChunk(bufferT)
                rs("ISMAIN").Value = 1
                rs("sync_lastupdate").Value = Now
                rs.Update()
                rs.Close()
            Catch ex As Exception
                Dim sSubFunc As String = "AddDefaultPic"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Gets the user settings database.
        ''' </summary>
        ''' <param name="recId">The record identifier.</param>
        ''' <param name="sName">Name of the s.</param>
        ''' <param name="sAddress">The s address.</param>
        ''' <param name="sCity">The s city.</param>
        ''' <param name="sState">State of the s.</param>
        ''' <param name="sZip">The s zip.</param>
        ''' <param name="sPhone">The s phone.</param>
        ''' <param name="sCcd">The s CCD.</param>
        Public Sub GetUserSettingsDb(ByRef recId As Long, ByRef sName As String, ByRef sAddress As String,
                                    ByRef sCity As String, ByRef sState As String, ByRef sZip As String,
                                    ByRef sPhone As String, ByRef sCcd As String)
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim sql As String = "SELECT TOP 1 * from Owner_Info"
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    rs.Read()
                    recId = CInt(rs("ID"))
                    sName = Trim(rs("name"))
                    sAddress = Trim(One.Decrypt(rs("address")))
                    sCity = Trim(rs("City"))
                    sState = Trim(rs("State"))
                    sZip = Trim(rs("Zip"))
                    sPhone = Trim(rs("Phone"))
                    sCcd = Trim(One.Decrypt(rs("CCDWL")))
                Else
                    recId = 0
                End If
                rs.Close()
                obj.CloseDb()
            Catch ex As Exception
                Dim sSubFunc As String = "GetUserSettingsDB"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
    End Class
    ''' <summary>
    ''' Class BSFileSystem.
    ''' </summary>
    Public Class BsFileSystem
        ''' <summary>
        ''' Logs the file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strMessage">The string message.</param>
        Public Sub LogFile(ByVal strPath As String, ByVal strMessage As String)
            Dim sendMessage As String = DateTime.Now & vbTab & strMessage
            Call AppendToFile(strPath, sendMessage)
            MDIParent1.tsslErrorsFound.Visible = True
            MDIParent1.tsslErrorsFound.Enabled = True
        End Sub
        ''' <summary>
        ''' Logs the debug file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strMessage">The string message.</param>
        Public Sub LogDebugFile(ByVal strPath As String, ByVal strMessage As String)
            Dim sendMessage As String = DateTime.Now & vbTab & strMessage
            Call AppendToFile(strPath, sendMessage)
        End Sub

        ''' <summary>
        ''' Files the exists.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <returns>System.Object.</returns>
        Public Function FileExists(ByVal strPath As String)
            Return File.Exists(strPath)
        End Function
        ''' <summary>
        ''' Creates the file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        Private Sub CreateFile(ByVal strPath As String)
            If File.Exists(strPath) = False Then
                Dim fs As New FileStream(strPath, FileMode.Append, FileAccess.Write, FileShare.Write)
                fs.Close()
            End If
        End Sub
        ''' <summary>
        ''' Converts to file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strNewLine">Creates new line.</param>
        Private Sub AppendToFile(ByVal strPath As String, ByVal strNewLine As String)
            If File.Exists(strPath) = False Then Call CreateFile(strPath)
            Dim sw As New StreamWriter(strPath, True, Encoding.ASCII)
            sw.WriteLine(strNewLine)
            sw.Close()
        End Sub
        ''' <summary>
        ''' Directories the exists.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function DirectoryExists(ByVal strPath As String) As Boolean
            Return Directory.Exists(strPath)
        End Function
    End Class
    ''' <summary>
    ''' Class ViewSizeSettings.
    ''' </summary>
    Public Class ViewSizeSettings
        ''' <summary>
        ''' Loads the view collection details.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
' ReSharper disable once RedundantAssignment
        Sub LoadViewCollectionDetails(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If My.Settings.ViewCollectionDetails_Width.Length > 0 And My.Settings.ViewCollectionDetails_Height.Length > 0 Then
                height = My.Settings.ViewCollectionDetails_Height
                width = My.Settings.ViewCollectionDetails_Width
            End If
            If My.Settings.ViewCollectionDetails_X.Length > 0 And My.Settings.ViewCollectionDetails_Y.Length > 0 Then
' ReSharper disable once RedundantAssignment
                location = New Point(My.Settings.ViewCollectionDetails_X, My.Settings.ViewCollectionDetails_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view collection details.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        Sub SaveViewCollectionDetails(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            My.Settings.ViewCollectionDetails_Height = height
            My.Settings.ViewCollectionDetails_Width = width
            My.Settings.ViewCollectionDetails_X = x
            My.Settings.ViewCollectionDetails_Y = y
            My.Settings.Save()
        End Sub
        ''' <summary>
        ''' Loads the view view picture.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        Sub LoadViewViewPicture(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If My.Settings.ViewPicture_Width.Length > 0 And My.Settings.ViewPicture_Height.Length > 0 Then
                height = My.Settings.ViewPicture_Height
                width = My.Settings.ViewPicture_Width
            End If
            If My.Settings.ViewPicture_X.Length > 0 And My.Settings.ViewPicture_Y.Length > 0 Then
                location = New Point(My.Settings.ViewPicture_X, My.Settings.ViewPicture_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view picture.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        Sub SaveViewPicture(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            My.Settings.ViewPicture_Height = height
            My.Settings.ViewPicture_Width = width
            My.Settings.ViewPicture_X = x
            My.Settings.ViewPicture_Y = y
            My.Settings.Save()
        End Sub
        ''' <summary>
        ''' Loads the view ammo inv.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        Sub LoadViewAmmoInv(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If My.Settings.ViewAmmoInv_Width.Length > 0 And My.Settings.ViewAmmoInv_Height.Length > 0 Then
                height = My.Settings.ViewAmmoInv_Height
                width = My.Settings.ViewAmmoInv_Width
            End If
            If My.Settings.ViewAmmoInv_X.Length > 0 And My.Settings.ViewAmmoInv_Y.Length > 0 Then
                location = New Point(My.Settings.ViewAmmoInv_X, My.Settings.ViewAmmoInv_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view ammo inv.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        Sub SaveViewAmmoInv(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            My.Settings.ViewAmmoInv_Height = height
            My.Settings.ViewAmmoInv_Width = width
            My.Settings.ViewAmmoInv_X = x
            My.Settings.ViewAmmoInv_Y = y
            My.Settings.Save()
        End Sub
    End Class
End Namespace
