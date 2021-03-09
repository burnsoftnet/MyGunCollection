Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Imports Microsoft.Win32
Public Class BSRegistry
    Private _RegPath As String
    Public Property DefaultRegPath() As String
        Get
            Return RegKey
        End Get
        Set(ByVal value As String)
            _RegPath = value
        End Set
    End Property
    'create Registry sub key
    Public Sub CreateSubKey(ByVal strValue As String)
        Registry.CurrentUser.CreateSubKey(strValue)
    End Sub
    'check to see if key exists for the current user - post version 5.5
    Public Function RegSubKeyExists(ByVal strValue As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim MyReg As RegistryKey
            MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                bAns = False
            Else
                bAns = True
            End If
        Catch ex As Exception
            bAns = False
        End Try
        Return bAns
    End Function
    'check to see if reg key existing in the local machine - pre version 5.5
    Public Function RegSubKeyExistsLocalMachine(ByVal strValue As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim MyReg As RegistryKey
            MyReg = Registry.LocalMachine.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                bAns = False
            Else
                bAns = True
            End If
        Catch ex As Exception
            bAns = False
        End Try
        Return bAns
    End Function
    'delete the reg value 
    Public Sub DeleteRegValue(ByVal sReg As String, ByVal sKey As String)
        Try
            Dim MyReg As RegistryKey
            MyReg = Registry.CurrentUser.OpenSubKey(sReg, True)
            MyReg.DeleteValue(sKey)
            MyReg.Close()
        Catch ex As Exception
            If Not SUPPRESS_CONSOLE_ERRORS Then Console.WriteLine("ERROR::" & _
                "BSRegistry" & "." & "DeleteREgValue" & "::" & _
                ex.Message.ToString)
        End Try
    End Sub
    'save the reg value
    Public Sub SaveRegValue(ByVal sReg As String, ByVal sKey As String, ByVal sValue As String)
        Dim MyReg As RegistryKey
        MyReg = Registry.CurrentUser.OpenSubKey(sReg, True)
        MyReg.SetValue(sKey, sValue)
        MyReg.Close()
    End Sub
    'get the sub key value for current user - post ver 5.5
    Public Function GetRegSubKeyValue(ByVal strKey As String, ByVal strValue As String, Optional ByVal strDefault As String = "") As String
        Dim sAns As String = ""
        Dim strMsg As String = ""
        Dim MyReg As RegistryKey
        Try
            If RegSubKeyExists(strKey) Then
                MyReg = Registry.CurrentUser.OpenSubKey(strKey, True)
                If Len(MyReg.GetValue(strValue)) > 0 Then
                    sAns = MyReg.GetValue(strValue)
                Else
                    MyReg.SetValue(strValue, strDefault)
                    sAns = strDefault
                End If
            Else
                Call CreateSubKey(strKey)
                MyReg = Registry.CurrentUser.OpenSubKey(strKey, True)
                MyReg.SetValue(strValue, strDefault)
                sAns = strDefault
            End If
        Catch ex As Exception
            sAns = strDefault
        End Try
        Return sAns
    End Function
    'get the sub key value for local machine - pre version 5.5 
    Private Function GetRegSubKeyValueLocalMachine(ByVal strKey As String, ByVal strValue As String, Optional ByVal strDefault As String = "") As String
        Dim sAns As String = ""
        Dim strMsg As String = ""
        Dim MyReg As RegistryKey
        Try
            If RegSubKeyExistsLocalMachine(strKey) Then
                MyReg = Registry.LocalMachine.OpenSubKey(strKey, True)
                If Len(MyReg.GetValue(strValue)) > 0 Then
                    sAns = MyReg.GetValue(strValue)
                Else
                    MyReg.SetValue(strValue, strDefault)
                    sAns = strDefault
                End If
            Else
                Call CreateSubKey(strKey)
                MyReg = Registry.CurrentUser.OpenSubKey(strKey, True)
                MyReg.SetValue(strValue, strDefault)
                sAns = strDefault
            End If
        Catch ex As Exception
            sAns = strDefault
        End Try
        Return sAns
    End Function
    'Get the application current version from the registry
    Public Function CurrentVersion() As String
        Return GetRegSubKeyValue(DefaultRegPath, "Version")
    End Function
    'get the application last path from the registry
    Public Function CurrentAppPath() As String
        Return GetRegSubKeyValue(DefaultRegPath, "Path")
    End Function
    'get the application last path and exe form the registry
    Public Function MainApplication() As String
        Return GetRegSubKeyValue(DefaultRegPath, "AppEXE")
    End Function
    'get the last database path and database name from the registry
    Public Function GetDatabasePath() As String
        Return GetRegSubKeyValue(DefaultRegPath, "DataBase")
    End Function
    'get only the database path, this is the writeable path in the users\appdata\roaming
    Public Function GetDataPath() As String
        Return GetRegSubKeyValue(DefaultRegPath, "AppDataPath")
    End Function
    'For version 5.5 we had to move the registry keys from local machine to current user for windows 7,8,10 compliance
    Public Sub MoveSettingKeys()
        Dim sValue As String = ""
        Dim strKey As String = DefaultRegPath
        Dim sKey As String = ""
        Dim DefaultRegPathSettings As String = DefaultRegPath & "\\Settings"
        Dim DefaultRegPathHotfix As String = DefaultRegPath & "\\HotFix"
        If RegSubKeyExistsLocalMachine(strKey) Then
            'Get the values from the root of the key
            Call CreateSubKey(strKey)
            sKey = "Version"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPath, sKey)
            Call SaveRegValue(DefaultRegPath, sKey, sValue)
            sKey = "AppEXE"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPath, sKey)
            Call SaveRegValue(DefaultRegPath, sKey, sValue)
            sKey = "AppName"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPath, sKey)
            Call SaveRegValue(DefaultRegPath, sKey, sValue)
            sKey = "DataBase"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPath, sKey)
            Call SaveRegValue(DefaultRegPath, sKey, sValue)
            sKey = "LogPath"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPath, sKey)
            Call SaveRegValue(DefaultRegPath, sKey, sValue)
            sKey = "Path"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPath, sKey)
            Call SaveRegValue(DefaultRegPath, sKey, sValue)
            'Get the values from the settings section
            Call CreateSubKey(DefaultRegPathSettings)
            sKey = "AlertOnBackUp"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "AUDITAMMO"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "AutoUpdate"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "BackupOnExit"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "Canceled"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "Database"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "DISABLEUNIQUECUSTCATID"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "HistKeyList"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "IndvReports"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "LastFile"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "LastPath"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "LastWorkingPath"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "NumberFormat"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "SetHistListdt"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "SetHistListtb"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "Successful"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "TrackHistory"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "TrackHistoryDays"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "UNIQUECUSTCATID"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "USEAUTOASSIGN"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "UseNumberCatOnly"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "UseOrgImage"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "UseProxy"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "VIEW_FirearmList"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)
            sKey = "ViewPetLoads"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathSettings, sKey)
            Call SaveRegValue(DefaultRegPathSettings, sKey, sValue)

            'Get the Values for the HotFix if any
            Call CreateSubKey(DefaultRegPathHotfix)
            sKey = "1"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "2"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "3"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "4"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "5"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "6"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "7"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "8"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)
            sKey = "LastUpdate"
            sValue = GetRegSubKeyValueLocalMachine(DefaultRegPathHotfix, sKey)
            Call SaveRegValue(DefaultRegPathHotfix, sKey, sValue)

            'Remove the old Settings

            Dim MyReg As RegistryKey
            MyReg = Registry.LocalMachine.OpenSubKey("Software\\BurnSoft\\", True)
            MyReg.DeleteSubKeyTree("BSMGC")
            MyReg.Close()
        End If
        

    End Sub
End Class
