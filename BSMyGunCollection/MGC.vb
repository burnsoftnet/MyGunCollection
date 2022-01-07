Imports System.IO
Imports System.Text
Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports ADODB
Imports BurnSoft.Security.RegularEncryption.SHA
Imports Microsoft.Win32
Namespace MGC
    ''' <summary>
    ''' Class BSRegistry.
    ''' </summary>
    Public Class BsRegistry
        ''Private Const MyClassName = "MGC.BSRegistry"
        Private _regPath As String
        Private _regSuccessful As String
        Private _regSetHistListtb As String
        Private _regSetHistListdt As String
        Private _regAlertOnBackUp As Boolean = True
        Private _regTrackHistoryDays As Integer
        Private _regLastPath As String
        Private _regLastFile As String
        Private _regBackupOnExit As Boolean = False
        Private _regUseOrgImage As Boolean = False
        Private _regViewPetLoads As Boolean = True
        Private _regIndvReports As Boolean = True
        Private _regTrackHistory As Boolean = True
        Private _regNumberFormat As String
        Private _regAutoUpdate As Boolean = False
        Private _regUseProxy As Boolean = False
        Private _regUseNumberCatOnly As Boolean
        Private _regAuditammo As Boolean = False
        Private _regUseautoassign As Boolean = False
        Private _regUniquecustcatid As Boolean = False
        Private _regUseselectiveboundbook As Boolean = False
        Public Property DefaultRegPath() As String
            Get
                If Len(_regPath) = 0 Then _regPath = "Software\\BurnSoft\\BSMGC"
                Return _regPath
            End Get
            Set(ByVal value As String)
                _regPath = value
            End Set
        End Property
        Private Property RegSuccessful() As String
            Get
                If Len(_regSuccessful) = 0 Then _regSuccessful = Now
                Return _regSuccessful
            End Get
            Set(ByVal value As String)
                _regSuccessful = value
            End Set
        End Property
        Private Property RegSetHistListtb() As String
            Get
                Return _regSetHistListtb
            End Get
            Set(ByVal value As String)
                _regSetHistListtb = value
            End Set
        End Property
        Private Property RegSetHistListdt() As String
            Get
                Return _regSetHistListdt
            End Get
            Set(ByVal value As String)
                _regSetHistListdt = value
            End Set
        End Property
        Private Property RegAlertOnBackUp() As Boolean
            Get
                Return _regAlertOnBackUp
            End Get
            Set(ByVal value As Boolean)
                _regAlertOnBackUp = value
            End Set
        End Property
        Private Property RegTrackHistoryDays() As Integer
            Get
                If _regTrackHistoryDays = 0 Then _regTrackHistoryDays = 15
                Return _regTrackHistoryDays
            End Get
            Set(ByVal value As Integer)
                _regTrackHistoryDays = value
            End Set
        End Property
        Private Property RegLastPath() As String
            Get
                If Len(_regLastPath) = 0 Then _regLastPath = "C:\"
                Return _regLastPath
            End Get
            Set(ByVal value As String)
                _regLastPath = value
            End Set
        End Property
        Private Property RegLastFile() As String
            Get
                If Len(_regLastFile) = 0 Then _regLastFile = "MGC.MDB"
                Return _regLastFile
            End Get
            Set(ByVal value As String)
                _regLastFile = value
            End Set
        End Property
        Private Property RegBackupOnExit() As Boolean
            Get
                Return _regBackupOnExit
            End Get
            Set(ByVal value As Boolean)
                _regBackupOnExit = value
            End Set
        End Property
        Private Property RegUseOrgImage() As Boolean
            Get
                Return _regUseOrgImage
            End Get
            Set(ByVal value As Boolean)
                _regUseOrgImage = value
            End Set
        End Property
        Private Property RegViewPetLoads() As Boolean
            Get
                Return _regViewPetLoads
            End Get
            Set(ByVal value As Boolean)
                _regViewPetLoads = value
            End Set
        End Property
        Private Property RegIndvReports() As Boolean
            Get
                Return _regIndvReports
            End Get
            Set(ByVal value As Boolean)
                _regIndvReports = value
            End Set
        End Property
        Private Property RegTrackHistory() As Boolean
            Get
                Return _regTrackHistory
            End Get
            Set(ByVal value As Boolean)
                _regTrackHistory = value
            End Set
        End Property
        Private Property RegNumberFormat() As String
            Get
                If Len(_regNumberFormat) = 0 Then _regNumberFormat = "0000"
                Return _regNumberFormat
            End Get
            Set(ByVal value As String)
                _regNumberFormat = value
            End Set
        End Property
        Private Property RegAutoUpdate() As Boolean
            Get
                Return _regAutoUpdate
            End Get
            Set(ByVal value As Boolean)
                _regAutoUpdate = value
            End Set
        End Property
        Private Property RegUseProxy() As Boolean
            Get
                Return _regUseProxy
            End Get
            Set(ByVal value As Boolean)
                _regUseProxy = value
            End Set
        End Property
        Private Property RegAuditammo() As Boolean
            Get
                Return _regAuditammo
            End Get
            Set(ByVal value As Boolean)
                _regAuditammo = value
            End Set
        End Property
        Private Property RegUseNumberCatOnly() As Boolean
            Get
                Return _regUseNumberCatOnly
            End Get
            Set(ByVal value As Boolean)
                _regUseNumberCatOnly = value
            End Set
        End Property
        Private Property RegUseautoassign() As Boolean
            Get
                Return _regUseautoassign
            End Get
            Set(ByVal value As Boolean)
                _regUseautoassign = value
            End Set
        End Property
        Private Property RegUniquecustcatid() As Boolean
            Get
                Return _regUniquecustcatid
            End Get
            Set(ByVal value As Boolean)
                _regUniquecustcatid = value
            End Set
        End Property
        Private Property RegUseselectiveboundbook() As Boolean
            Get
                Return _regUseselectiveboundbook
            End Get
            Set(ByVal value As Boolean)
                _regUseselectiveboundbook = value
            End Set
        End Property
        Public Sub UpDateAppDetails()
            Dim strValue As String = DefaultRegPath
            If Not RegSubKeyExists(strValue) Then Call CreateSubKey(strValue)
            Dim myReg As RegistryKey
            myReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            myReg.SetValue("Version", Application.ProductVersion)
            myReg.SetValue("AppName", Application.ProductName)
            myReg.SetValue("AppEXE", Application.ExecutablePath())
            myReg.SetValue("Path", ApplicationPath)
            myReg.SetValue("LogPath", MyLogFile)
            myReg.SetValue("DataBase", ApplicationPathData & "\" & DatabaseName)
            myReg.SetValue("AppDataPath", ApplicationPathData)
            myReg.Close()
        End Sub
        Public Sub CreateSubKey(ByVal strValue As String)
            Registry.CurrentUser.CreateSubKey(strValue)
        End Sub
        Public Function RegSubKeyExists(ByVal strValue As String) As Boolean
            Dim bAns As Boolean = False
            Try
                Dim myReg As RegistryKey
                myReg = Registry.CurrentUser.OpenSubKey(strValue, True)
                If myReg Is Nothing Then
                    bAns = False
                Else
                    bAns = True
                End If
            Catch ex As Exception
                bAns = False
            End Try
            Return bAns
        End Function
        Public Function GetRegSubKeyValue(ByVal strKey As String, ByVal strValue As String, ByVal strDefault As String) As String
            Dim sAns As String = ""
            Dim strMsg As String = ""
            Dim myReg As RegistryKey
            Try
                If RegSubKeyExists(strKey) Then
                    myReg = Registry.CurrentUser.OpenSubKey(strKey, True)
                    If Len(myReg.GetValue(strValue)) > 0 Then
                        sAns = myReg.GetValue(strValue)
                    Else
                        myReg.SetValue(strValue, strDefault)
                        sAns = strDefault
                    End If
                Else
                    Call CreateSubKey(strKey)
                    myReg = Registry.CurrentUser.OpenSubKey(strKey, True)
                    myReg.SetValue(strValue, strDefault)
                    sAns = strDefault
                End If
            Catch ex As Exception
                sAns = strDefault
            End Try
            Return sAns
        End Function
        Public Sub SetSettingDetails()
            If Not SettingsExists() Then
                Dim myReg As RegistryKey
                Dim strValue As String = DefaultRegPath & "\Settings"
                myReg = Registry.CurrentUser.OpenSubKey(strValue, True)

                myReg = Registry.CurrentUser.CreateSubKey(strValue)
                myReg.SetValue("Successful", RegSuccessful)
                myReg.SetValue("SetHistListtb", RegSetHistListtb)
                myReg.SetValue("SetHistListdt", RegSetHistListdt)
                myReg.SetValue("AlertOnBackUp", RegAlertOnBackUp)
                myReg.SetValue("TrackHistoryDays", RegTrackHistoryDays)
                myReg.SetValue("TrackHistory", RegTrackHistory)
                myReg.SetValue("LastPath", RegLastPath)
                myReg.SetValue("LastFile", RegLastFile)
                myReg.SetValue("BackupOnExit", RegBackupOnExit)
                myReg.SetValue("UseOrgImage", RegUseOrgImage)
                myReg.SetValue("ViewPetLoads", RegViewPetLoads)
                myReg.SetValue("IndvReports", RegIndvReports)
                myReg.SetValue("UseNumberCatOnly", RegUseNumberCatOnly)
                myReg.SetValue("AUDITAMMO", RegAuditammo)
                myReg.Close()
            End If
        End Sub
        Public Function SettingsExists() As Boolean
            Dim bAns As Boolean = False
            Dim myReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            On Error Resume Next
            myReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            If myReg Is Nothing Then
                bAns = False
            Else
                bAns = True
            End If
            Return bAns
        End Function
        Public Sub GetSettings(ByRef lastSucBackup As String, ByRef alertOnBackUp As Boolean,
                            ByRef trackHistoryDays As Integer, ByRef trackHistory As Boolean,
                            ByRef autoBackup As Boolean, ByRef uoimg As Boolean, ByRef usePl As Boolean,
                            ByRef useIPer As Boolean, ByRef useCcid As Boolean, ByRef useaa As Boolean,
                            ByRef useAacid As Boolean, ByRef useUniqueCustId As Boolean, ByRef bUseselectiveboundbook As Boolean)
            Dim myReg As RegistryKey
            Dim numberFormat As String
            Dim useProxy As Boolean
            Dim autoUpdate As Boolean
            Dim strValue As String = DefaultRegPath & "\Settings"
            Try
                myReg = Registry.CurrentUser.OpenSubKey(strValue, True)
                If myReg Is Nothing Then Call SetSettingDetails()
                If (Not myReg Is Nothing) Then
                    trackHistoryDays = CInt(GetRegSubKeyValue(strValue, "TrackHistoryDays", RegTrackHistoryDays)) 'CInt(MyReg.GetValue("TrackHistoryDays", ""))
                    trackHistory = CBool(GetRegSubKeyValue(strValue, "TrackHistory", RegTrackHistory))
                    numberFormat = CStr(GetRegSubKeyValue(strValue, "NumberFormat", RegNumberFormat))
                    autoUpdate = CBool(GetRegSubKeyValue(strValue, "AutoUpdate", RegAutoUpdate))
                    useProxy = CBool(GetRegSubKeyValue(strValue, "UseProxy", RegUseProxy))
                    lastSucBackup = GetRegSubKeyValue(strValue, "Successful", RegSuccessful)
                    alertOnBackUp = CBool(GetRegSubKeyValue(strValue, "AlertOnBackUp", RegAlertOnBackUp))
                    autoBackup = CBool(GetRegSubKeyValue(strValue, "BackupOnExit", RegBackupOnExit))
                    uoimg = CBool(GetRegSubKeyValue(strValue, "UseOrgImage", RegUseOrgImage))
                    usePl = CBool(GetRegSubKeyValue(strValue, "ViewPetLoads", RegViewPetLoads))
                    useIPer = CBool(GetRegSubKeyValue(strValue, "IndvReports", RegIndvReports))
                    useCcid = CBool(GetRegSubKeyValue(strValue, "UseNumberCatOnly", RegUseNumberCatOnly))
                    useaa = CBool(GetRegSubKeyValue(strValue, "AUDITAMMO", RegAuditammo))
                    useAacid = CBool(GetRegSubKeyValue(strValue, "USEAUTOASSIGN", RegUseautoassign))
                    useUniqueCustId = CBool(GetRegSubKeyValue(strValue, "DISABLEUNIQUECUSTCATID", RegUniquecustcatid))
                    bUseselectiveboundbook = CBool(GetRegSubKeyValue(strValue, "USESELECTIVEBOUNDBOOK", RegUseselectiveboundbook))
                Else
                    trackHistoryDays = RegTrackHistoryDays
                    trackHistory = RegTrackHistory
                    numberFormat = RegNumberFormat
                    autoUpdate = RegAutoUpdate
                    useProxy = RegUseProxy
                    lastSucBackup = RegSuccessful
                    alertOnBackUp = RegAlertOnBackUp
                    autoBackup = RegBackupOnExit
                    uoimg = RegUseOrgImage
                    usePl = RegViewPetLoads
                    useIPer = RegIndvReports
                    useCcid = RegUseNumberCatOnly
                    useaa = RegAuditammo
                    useAacid = RegUseautoassign
                    useUniqueCustId = RegUniquecustcatid
                    bUseselectiveboundbook = RegUseselectiveboundbook
                End If
            Catch ex As Exception
                Dim myErr As Long = Err.Number
                If myErr = 13 Then Call SetSettingDetails()
            End Try
        End Sub
        Public Sub SaveSettings(ByVal numberFormat As String, ByVal trackHistory As Boolean,
                                ByVal trackHistoryDays As Integer, ByVal autoUpdate As Boolean,
                                ByVal useProxy As Boolean, ByVal alertOnBackUp As Boolean,
                                ByVal autoBackup As Boolean, ByVal uoimg As Boolean, ByVal usePl As Boolean,
                                ByVal useIPer As Boolean, ByVal usenccid As Boolean, ByVal useaa As Boolean,
                                ByVal useAacid As Boolean, ByVal useUniqueCustId As Boolean, ByVal bUseselectiveboundbook As Boolean)
            Dim myReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            myReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            If myReg Is Nothing Then
                myReg = Registry.CurrentUser.CreateSubKey(strValue)
            End If
            myReg.SetValue("TrackHistoryDays", trackHistoryDays)
            myReg.SetValue("TrackHistory", trackHistory)
            myReg.SetValue("NumberFormat", numberFormat)
            myReg.SetValue("AutoUpdate", autoUpdate)
            myReg.SetValue("UseProxy", useProxy)
            myReg.SetValue("AlertOnBackUp", alertOnBackUp)
            myReg.SetValue("BackupOnExit", autoBackup)
            myReg.SetValue("UseOrgImage", uoimg)
            myReg.SetValue("ViewPetLoads", usePl)
            myReg.SetValue("IndvReports", useIPer)
            myReg.SetValue("UseNumberCatOnly", usenccid)
            myReg.SetValue("AUDITAMMO", useaa)
            myReg.SetValue("USEAUTOASSIGN", useAacid)
            myReg.SetValue("DISABLEUNIQUECUSTCATID", useUniqueCustId)
            myReg.SetValue("USESELECTIVEBOUNDBOOK", bUseselectiveboundbook)
            myReg.Close()
        End Sub
        Public Sub SaveLastWorkingDir(ByVal strPath As String)
            Dim myReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If myReg Is Nothing Then
                myReg = Registry.CurrentUser.CreateSubKey(strValue)
            End If
            myReg.SetValue("LastWorkingPath", strPath)
            myReg.Close()
        End Sub
        Public Function GetLastWorkingDir() As String
            Dim sAns As String = ""
            Dim myReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If myReg Is Nothing Then
                myReg = Registry.CurrentUser.CreateSubKey(strValue)
                myReg.SetValue("LastWorkingPath", "")
            End If
            sAns = myReg.GetValue("LastWorkingPath", "")
            myReg.Close()
            Return sAns
        End Function
        Public Sub SaveFirearmListSort(ByVal configSort As String)
            Dim strValue As String = DefaultRegPath & "\Settings"
            If Not RegSubKeyExists(strValue) Then Call CreateSubKey(strValue)
            Dim myReg As RegistryKey
            myReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            myReg.SetValue("VIEW_FirearmList", configSort)
            myReg.Close()
        End Sub
        Public Function GetViewSettings(ByVal sKey As String, Optional ByVal sDefault As String = "") As String
            Dim sAns As String = ""
            Dim strValue As String = DefaultRegPath & "\Settings"
            sAns = GetRegSubKeyValue(strValue, sKey, sDefault)
            Return sAns
        End Function
    End Class
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
        ''' Objects the existsin database.
        ''' </summary>
        ''' <param name="strObject">The string object.</param>
        ''' <param name="strField">The string field.</param>
        ''' <param name="strTable">The string table.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function ObjectExistsinDb(ByVal strObject As String, ByVal strField As String, ByVal strTable As String) As Boolean
            Try
                Dim bAns As Boolean = False
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim sql As String = "SELECT " & strField & " from " & strTable & " where " & strField & "='" & strObject & "'"
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    bAns = True
                Else
                    bAns = False
                End If
                rs.Close()
                cmd = Nothing
                Call obj.CloseDb()
                Return bAns
            Catch ex As Exception
                Dim sSubFunc As String = "ObjectExistsinDB"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Function
        ''' <summary>
        ''' Gets the identifier.
        ''' </summary>
        ''' <param name="sql">The SQL.</param>
        ''' <returns>System.Int64.</returns>
        Public Function GetId(ByVal sql As String) As Long
            Try
                Dim sAns As Long = 0
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    While (rs.Read())
                        sAns = CLng(rs("ID"))
                    End While
                Else
                    sAns = 0
                End If
                rs.Close()
                cmd = Nothing
                Call obj.CloseDb()
                Return sAns
            Catch ex As Exception
                Dim sSubFunc As String = "GetID"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString & "::" & sql)
            End Try
        End Function
        ''' <summary>
        ''' Gets the name.
        ''' </summary>
        ''' <param name="sql">The SQL.</param>
        ''' <param name="strValue">The string value.</param>
        ''' <returns>System.String.</returns>
        Public Function GetName(ByVal sql As String, ByVal strValue As String) As String
            Dim sAns As String = "N/A"
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    While (rs.Read())
                        If Not IsDBNull(rs(strValue)) Then
                            sAns = rs(strValue)
                        Else
                            sAns = 0
                        End If
                    End While
                Else
                    sAns = "N/A"
                End If
                rs.Close()
                cmd = Nothing
                Call obj.CloseDb()
            Catch ex As Exception
                Dim sSubFunc As String = "GetName"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString & "::" & sql)
            End Try
            Return sAns
        End Function

        ''' <summary>
        ''' Determines whether [has collection attached] [the specified string name].
        ''' </summary>
        ''' <param name="strName">Name of the string.</param>
        ''' <param name="strColumnName">Name of the string column.</param>
        ''' <param name="strTableName">Name of the string table.</param>
        ''' <returns>System.Int32.</returns>
        Public Function HasCollectionAttached(ByVal strName As String, ByVal strColumnName As String, Optional strTableName As String = "Gun_Collection") As Integer
            Dim iAns As Integer = 0
            Dim sql As String = "SELECT Count(*) as Total from " & strTableName & " where " & strColumnName & "='" & strName & "'"
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    While (rs.Read)
                        iAns = rs("Total")
                    End While
                End If
                rs.Close()
                rs = Nothing
                cmd = Nothing
                Call obj.CloseDb()
            Catch ex As Exception
                Dim sSubFunc As String = "HasCollectionAttached"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return iAns
        End Function

        ''' <summary>
        ''' Gets the name of the wish list.
        ''' </summary>
        ''' <param name="strId">The string identifier.</param>
        ''' <returns>System.String.</returns>
        Public Function GetWishListName(ByVal strId As String) As String
            Dim sAns As String = ""
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim sql As String = "SELECT * from WishList where ID=" & strId
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                While (rs.Read)
                    sAns = rs("Manufacturer") & " " & rs("Model")
                End While
                rs.Close()
                obj.CloseDb()
            Catch ex As Exception
                Call LogError(MyClassName, "GetWishListName", Err.Number, ex.Message.ToString)
            End Try
            Return sAns
        End Function

        ''' <summary>
        ''' Catalogs the is numeric.
        ''' </summary>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function CatalogIsNumeric() As Boolean
            Dim bAns As Boolean = False
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim sql As String = "SELECT CustomID from Gun_Collection"
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
' ReSharper disable once RedundantAssignment
                Dim sId As String = ""
                Dim iRowCount As Long = 0
                Dim iCount As Long = 0
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    While rs.Read
                        iRowCount += 1
                        sId = Trim(rs("CustomID"))
                        If Len(sId) = 0 Then sId = "N/A"
                        If IsNumeric(sId) Then iCount += 1
                    End While
                End If
                If iRowCount = iCount Then bAns = True
            Catch ex As Exception
                Dim sSubFunc As String = "CatalogIsNumeric"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Converts to numeric.
        ''' </summary>
        Public Sub SetCatalogValuesToNumeric()
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
                Dim sql As String = "SELECT ID,CustomID from Gun_Collection"
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
' ReSharper disable once UnusedVariable
                Dim sId As String = ""
' ReSharper disable once UnusedVariable
                Dim iRowCount As Long = 0
                Dim iCount As Long = 0
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    While rs.Read
                        iCount += 1
                        obj.ConnExec("UPDATE Gun_Collection set CustomID='" & iCount & "',sync_lastupdate=Now() where ID=" & rs("ID"))
                    End While
                End If
            Catch ex As Exception
                Dim sSubFunc As String = "SetCatalogToNumeric"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Sets the type of the catalog.
        ''' </summary>
        ''' <param name="sType">Type of the s.</param>
        Public Sub SetCatalogType(ByVal sType As String)
            Try
                Dim obj As New BsDatabase
                Call obj.ConnectDb()
' ReSharper disable once RedundantAssignment
                Dim sql As String = ""
                Select Case LCase(sType)
                    Case "num"
                        sql = "ALTER TABLE Gun_Collection ALTER COLUMN CustomID Integer;"
                    Case "let"
                        sql = "ALTER TABLE Gun_Collection ALTER COLUMN CustomID Text(255);"
                    Case Else
                        sql = "ALTER TABLE Gun_Collection ALTER COLUMN CustomID Text(255);"
                End Select
                obj.ConnExec(sql)
            Catch ex As Exception
                Dim sSubFunc As String = "SetCatalogType"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Gets the report SQL.
        ''' </summary>
        ''' <param name="rid">The rid.</param>
        ''' <returns>System.String.</returns>
        Public Function GetReportSql(ByVal rid As Long) As String
            Return GetName("SELECT * from CR_SavedReports where id=" & rid, "MySQL")
        End Function
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
        ''' Adds the purchase price accessories.
        ''' </summary>
        ''' <param name="gid">The gid.</param>
        ''' <returns>System.Double.</returns>
        Function AddPurchasePriceAccessories(ByVal gid As Long) As Double
            Dim dAns As Double = 0
            Try
                Dim obj As New BsDatabase
                obj.ConnectDb()
                Dim sql As String = "SELECT SUM(cdbl(PurValue)) as Total from Gun_Collection_Accessories where GID=" & gid
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
' ReSharper disable once UnusedVariable
                Dim tCount As Long = 0
                rs = cmd.ExecuteReader
                While rs.Read()
                    If Not IsDBNull(rs("Total")) Then dAns = CDbl(rs("Total"))
                End While
                rs.Close()
                obj.CloseDb()
            Catch ex As Exception
                Call LogError(MyClassName, "AddPurchasePriceAccessories", Err.Number, ex.Message.ToString)
            End Try
            Return (dAns)
        End Function
        ''' <summary>
        ''' Adds the appriased price accessories.
        ''' </summary>
        ''' <param name="gid">The gid.</param>
        ''' <returns>System.Double.</returns>
        Function AddAppriasedPriceAccessories(ByVal gid As Long) As Double
            Dim dAns As Double = 0
            Try
                Dim obj As New BsDatabase
                obj.ConnectDb()
                Dim sql As String = "SELECT SUM(cdbl(AppValue)) as Total from Gun_Collection_Accessories where GID=" & gid & " and CIV=1"
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                Dim tCount As Long = 0
                rs = cmd.ExecuteReader
                While rs.Read()
                    If Not IsDBNull(rs("Total")) Then dAns = CDbl(rs("Total"))
                End While
                rs.Close()
                rs = Nothing
                cmd = Nothing
                obj.CloseDb()
            Catch ex As Exception
                Dim sSubFunc As String = "AddAppriasedPriceAccessories"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return (dAns)
        End Function
        ''' <summary>
        ''' Databases the version.
        ''' </summary>
        ''' <returns>System.Double.</returns>
        Public Function DatabaseVersion() As Double
            Dim dAns As Double = 0
            Try
                Dim obj As New BsDatabase
                Dim sql As String = "SELECT top 1 dbver from DB_Version order by ID desc"
                Call obj.ConnectDb()
                Dim cmd As New OdbcCommand(sql, obj.Conn)
                Dim rs As OdbcDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    While rs.Read()
                        dAns = CDbl(rs("dbver"))
                    End While
                Else
                    dAns = 0
                End If
                rs.Close()
                rs = Nothing
                cmd = Nothing
                obj.CloseDb()
            Catch ex As Exception
                Dim sSubFunc As String = "DatabaseVersion"
                Call LogError(MyClassName, sSubFunc, Err.Number, ex.Message.ToString)
                dAns = 0
            End Try

            Return dAns
        End Function
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
                cmd = Nothing
                rs = Nothing
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
        ''' Deletes the file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        Public Sub DeleteFile(ByVal strPath As String)
            If File.Exists(strPath) Then
                File.Delete(strPath)
            End If
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
        ''' <summary>
        ''' Gets the name of file.
        ''' </summary>
        ''' <param name="strFile">The string file.</param>
        ''' <returns>System.String.</returns>
        Public Function GetNameOfFile(ByVal strFile As String) As String
            Dim sAns As String = ""
            sAns = Path.GetFileName(strFile)
            Return sAns
        End Function
        ''' <summary>
        ''' Converts to file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strNewLine">Creates new line.</param>
        Public Sub OutPutToFile(ByVal strPath As String, ByVal strNewLine As String)
            Call AppendToFile(strPath, strNewLine)
        End Sub
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
        Sub LoadViewCollectionDetails(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If My.Settings.ViewCollectionDetails_Width.Length > 0 And My.Settings.ViewCollectionDetails_Height.Length > 0 Then
                height = My.Settings.ViewCollectionDetails_Height
                width = My.Settings.ViewCollectionDetails_Width
            End If
            If My.Settings.ViewCollectionDetails_X.Length > 0 And My.Settings.ViewCollectionDetails_Y.Length > 0 Then
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
