Imports System
Imports System.IO
Imports System.Text
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
            'Dim fs As FileStream = File.Create(strPath)
            Dim fs As New FileStream(strPath, FileMode.Append, FileAccess.Write, FileShare.Write)
            fs.Close()
        End If
    End Sub
    Private Sub AppendToFile(ByVal strPath As String, ByVal strNewLine As String)
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
    Public Function DirectoryExists(ByVal strPath As String) As Boolean
        Return Directory.Exists(strPath)
    End Function
    Public Sub DeleteDirectory(ByVal strPath As String)
        If Directory.Exists(strPath) Then
            Directory.Delete(strPath)
        End If
    End Sub
    Public Sub MoveDirectory(ByVal strFrom As String, ByVal strTo As String)
        If Directory.Exists(strFrom) Then
            Directory.Move(strFrom, strTo)
        End If
    End Sub
    Public Sub RenameFile(ByVal strFrom As String, ByVal strTo As String)
        'If File.Exists(strFrom) Then
        File.Move(strFrom, strTo)
        'name strFrom as strto\
        'End If
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
    Public Sub OutPutToFile(ByVal strPath As String, ByVal strNewLine As String)
        Call AppendToFile(strPath, strNewLine)
    End Sub
End Class
