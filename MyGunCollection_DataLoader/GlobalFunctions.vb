Imports System.Data
Imports System.IO
Imports System.Xml
Imports System
Imports System.Data.Odbc
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Text
Namespace GlobalFunctions
    Public Class BSRegistry
        Private _RegPath As String
        Public Property DefaultRegPath() As String
            Get
                Dim TempValue As String = ""
                If Len(_RegPath) = 0 Then
                    TempValue = "Software\\BurnSoft\\BSMGC"
                Else
                    TempValue = _RegPath
                End If
                Return TempValue
            End Get
            Set(ByVal value As String)
                _RegPath = value
            End Set
        End Property
        Public Sub UpDateAppDetails()
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("AppVer", Application.ProductVersion)
            MyReg.SetValue("AppName", Application.ProductName)
            MyReg.SetValue("AppEXE", Application.ExecutablePath())
            MyReg.SetValue("Path", Application.StartupPath)
            MyReg.Close()
        End Sub
        Public Sub GetAppDetails(ByRef AppVersion As String, ByRef AppName As String, ByRef AppPath As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            AppVersion = MyReg.GetValue("Version", "")
            AppName = MyReg.GetValue("AppName", "")
            AppPath = MyReg.GetValue("Path", "")
            MyReg.Close()
        End Sub
        Public Sub GetSettings(ByRef NumberFormat As String, ByRef TrackHistory As Boolean, ByRef TrackHistoryDays As Integer, ByRef AutoUpdate As Boolean, ByRef UseProxy As Boolean)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
                MyReg.SetValue("TrackHistoryDays", 30)
                MyReg.SetValue("TrackHistory", False)
                MyReg.SetValue("NumberFormat", "0000")
                MyReg.SetValue("AutoUpdate", False)
                MyReg.SetValue("UseProxy", False)
                MyReg.Close()
            End If
            If (Not MyReg Is Nothing) Then
                TrackHistoryDays = CInt(MyReg.GetValue("TrackHistoryDays", ""))
                TrackHistory = CBool(MyReg.GetValue("TrackHistory", ""))
                NumberFormat = CStr(MyReg.GetValue("NumberFormat", ""))
                AutoUpdate = CBool(MyReg.GetValue("AutoUpdate", ""))
                UseProxy = CBool(MyReg.GetValue("UseProxy", ""))
            Else
                TrackHistoryDays = 30
                TrackHistory = False
                NumberFormat = "0000"
                AutoUpdate = False
                UseProxy = False
            End If
        End Sub
        Public Sub SaveSettings(ByVal NumberFormat As String, ByVal TrackHistory As Boolean, ByVal TrackHistoryDays As Integer, ByVal AutoUpdate As Boolean, ByVal UseProxy As Boolean)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("TrackHistoryDays", TrackHistoryDays)
            MyReg.SetValue("TrackHistory", TrackHistory)
            MyReg.SetValue("NumberFormat", NumberFormat)
            MyReg.SetValue("AutoUpdate", AutoUpdate)
            MyReg.SetValue("UseProxy", UseProxy)
            MyReg.Close()
        End Sub
        Public Sub SaveLastWorkingDir(ByVal strPath As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("LastWorkingPath", strPath)
            MyReg.Close()
        End Sub
        Public Function GetLastWorkingDir() As String
            Dim sAns As String = ""
            Dim myReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            myReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If myReg Is Nothing Then
                myReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
                myReg.SetValue("LastWorkingPath", "")
            End If
            sAns = myReg.GetValue("LastWorkingPath", "")
            myReg.Close()
            Return sAns
        End Function
    End Class
    Public Class BSFileSystem
        Public Sub LogFile(ByVal strPath As String, ByVal strMessage As String)
            Dim SendMessage As String = DateTime.Now & vbTab & strMessage
            Call AppendToFile(strPath, SendMessage)
        End Sub
        Public Sub DeleteFile(ByVal strPath As String)
            If File.Exists(strPath) Then
                File.Delete(strPath)
            End If
        End Sub
        Public Function FileExists(ByVal strPath As String)
            Return File.Exists(strPath)
        End Function
        Private Sub CreateFile(ByVal strPath As String)
            If File.Exists(strPath) = False Then
                Dim fs As New FileStream(strPath, FileMode.Append, FileAccess.Write, FileShare.Write)
                fs.Close()
            End If
        End Sub
        Public Sub AppendToFile(ByVal strPath As String, ByVal strNewLine As String)
            If File.Exists(strPath) = False Then Call CreateFile(strPath)
            Dim sw As New StreamWriter(strPath, True, Encoding.ASCII)
            sw.WriteLine(strNewLine)
            sw.Close()
        End Sub
        Public Sub MoveFile(ByVal strFrom As String, ByVal strTo As String)
            If File.Exists(strFrom) Then
                File.Move(strFrom, strTo)
            End If
        End Sub
        Public Sub ReplaceFile(ByVal strFrom As String, ByVal strTo As String)
            If File.Exists(strTo) Then Call DeleteFile(strTo)
            Call CopyFile(strFrom, strTo)
        End Sub
        Public Sub CopyFile(ByVal strFrom As String, ByVal strTo As String)
            If File.Exists(strFrom) Then
                File.Copy(strFrom, strTo)
            End If
        End Sub
        Public Sub CreateDirectory(ByVal strPath As String)
            If Directory.Exists(strPath) Then
                Directory.CreateDirectory(strPath)
            End If
        End Sub
        Public Sub DeleteDirectory(ByVal strPath As String)
            If Directory.Exists(strPath) Then
                Directory.Delete(strPath)
            End If
        End Sub
        Public Function DirectoryExists(ByVal strPath As String) As Boolean
            Return Directory.Exists(strPath)
        End Function
        Public Sub MoveDirectory(ByVal strFrom As String, ByVal strTo As String)
            If Directory.Exists(strFrom) Then
                Directory.Move(strFrom, strTo)
            End If
        End Sub
        Public Sub RenameFile(ByVal strFrom As String, ByVal strTo As String)
            File.Move(strFrom, strTo)
        End Sub
        Public Function GetPathOfFile(ByVal strFile As String) As String
            Dim sAns As String = ""
            sAns = Path.GetDirectoryName(strFile)
            Return sAns
        End Function
        Public Function GetExtOfFile(ByVal strFile As String) As String
            Dim sAns As String = ""
            sAns = Path.GetExtension(strFile)
            Return sAns
        End Function
        Public Function GetNameOfFile(ByVal strFile As String) As String
            Dim sAns As String = ""
            sAns = Path.GetFileName(strFile)
            Return sAns
        End Function
        Public Function FileHasExtension(ByVal strFile As String) As Boolean
            Dim bAns As Boolean = False
            bAns = Path.HasExtension(strFile)
            Return bAns
        End Function
        Public Function GetNameOfFileWOExt(ByVal strFile As String) As String
            Dim sAns As String = ""
            sAns = Path.GetFileNameWithoutExtension(strFile)
            Return sAns
        End Function

    End Class
    Public Class MyGlobalFunctions
        Public Function ObjectExistsinDB(ByVal strObject As String, ByVal strField As String, ByVal strTable As String) As Boolean
            Try
                Dim bAns As Boolean = False
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = "SELECT " & strField & " from " & strTable & " where " & strField & "='" & strObject & "'"
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    bAns = True
                Else
                    bAns = False
                End If
                RS.Close()
                CMD = Nothing
                Call Obj.CloseDB()
                Return bAns
            Catch ex As Exception
                Dim ObjFS As New BSFileSystem
                Dim sMessage As String = "Globalunctions.ObjectExistsinDB" & "::" & Err.Number & "::" & ex.Message.ToString()
            End Try
        End Function
        Public Function ObjectExistsinDBSQL(ByVal SQL As String) As Boolean
            Try
                Dim bAns As Boolean = False
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    bAns = True
                Else
                    bAns = False
                End If
                RS.Close()
                CMD = Nothing
                Call Obj.CloseDB()
                Return bAns
            Catch ex As Exception
                Dim ObjFS As New BSFileSystem
                Dim sMessage As String = "Globalunctions.ObjectExistsinDB" & "::" & Err.Number & "::" & ex.Message.ToString()
            End Try
        End Function
        Public Function GetID(ByVal SQL As String) As Long
            Try
                Dim sAns As Long = 0
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    While (RS.Read())
                        sAns = CLng(RS("ID"))
                    End While
                Else
                    sAns = 0
                End If
                RS.Close()
                CMD = Nothing
                Call Obj.CloseDB()
                Return sAns
            Catch ex As Exception
                Dim ObjFS As New BSFileSystem
                Dim sMessage As String = "Globalunctions.GetID" & "::" & Err.Number & "::" & ex.Message.ToString()
            End Try
        End Function
        Private Function GetName(ByVal SQL As String, ByVal strValue As String) As String
            Dim sAns As String = "N/A"
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read())
                    If Not IsDBNull(RS(strValue)) Then
                        sAns = RS(strValue)
                    Else
                        sAns = 0
                    End If
                End While
            Else
                sAns = "N/A"
            End If
            RS.Close()
            CMD = Nothing
            Call Obj.CloseDB()
            Return sAns
        End Function
        Public Function GetXMLNode(ByVal instance As XmlNode) As String
            'NOTE:This will Get the Values that are stored in the XML Note.
            Dim MyAns As String = ""
            On Error Resume Next
            MyAns = instance.InnerText
            Return MyAns
        End Function
        Public Function GetApplicationID(ByVal strXML As String) As String
            Dim sAns As String = ""
            Dim doc As New XmlDocument
            doc.Load(strXML)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("GetAppVersion")
            Dim i As Integer
            For i = 0 To elemList.Count - 1
                sAns = GetXMLNode(elemList(i).Item("ID"))
            Next i
            doc = Nothing
            elemList = Nothing
            Return sAns
        End Function
        Public Sub GetApplicationDetail(ByVal strXML As String, ByRef ProdID As String, ByRef AppVer As String)
            Dim doc As New XmlDocument
            doc.Load(strXML)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("GetAppVersion")
            Dim i As Integer
            For i = 0 To elemList.Count - 1
                ProdID = GetXMLNode(elemList(i).Item("ProdID"))
                AppVer = GetXMLNode(elemList(i).Item("AppVer"))
            Next i
            doc = Nothing
            elemList = Nothing
        End Sub
    End Class
    Public Class BSDatabase
        Public Conn As OdbcConnection
        Public Function sConnect() As String
            Dim sAns As String = ""
            sAns = "Driver={Microsoft Access Driver (*.mdb)};dbq=" & APPLICATION_PATH_DATA & "\MGC.mdb;Pwd=14un0t2n0"
            Return sAns
        End Function
        Public Sub ConnectDB()
            Try
                Conn = New OdbcConnection(sConnect)
                Conn.Open()
            Catch ex As Exception
                Dim ObjFS As New BSFileSystem
                Dim sMessage As String = "MGC.BSDatabase.ConnectDB" & "::" & Err.Number & "::" & ex.Message.ToString()
            End Try
        End Sub
        Public Sub CloseDB()
            Try
                Conn.Close()
                Conn = Nothing
            Catch ex As Exception
                Dim ObjFS As New BSFileSystem
                Dim sMessage As String = "MGC.BSDatabase.CloseDB" & "::" & Err.Number & "::" & ex.Message.ToString()
            End Try
        End Sub
        Public Sub ConnExec(ByVal strSQL As String)
            Try
                Call ConnectDB()
                Dim CMD As New OdbcCommand
                CMD.Connection = Conn
                CMD.CommandText = strSQL
                CMD.ExecuteNonQuery()
                CMD.Connection.Close()
                CMD = Nothing
                Conn = Nothing
            Catch ex As Exception
                Dim ObjFS As New BSFileSystem
                Dim sMessage As String = "MGC.BSDatabase.ConnExec" & "::" & Err.Number & "::" & ex.Message.ToString()
            End Try
        End Sub
    End Class
End Namespace
