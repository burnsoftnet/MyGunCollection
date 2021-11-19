Imports System.IO
Imports System.Text
Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports System.Globalization
Imports ADODB
Imports BurnSoft.Security.RegularEncryption.SHA
Imports Microsoft.Win32
Namespace MGC
    ''' <summary>
    ''' Class BSRegistry.
    ''' </summary>
    Public Class BSRegistry
        Private Const MY_CLASS_NAME = "MGC.BSRegistry"
        Private _RegPath As String
        Private _Reg_Successful As String
        Private _Reg_SetHistListtb As String
        Private _Reg_SetHistListdt As String
        Private _Reg_AlertOnBackUp As Boolean = True
        Private _Reg_TrackHistoryDays As Integer
        Private _Reg_LastPath As String
        Private _Reg_LastFile As String
        Private _Reg_BackupOnExit As Boolean = False
        Private _Reg_UseOrgImage As Boolean = False
        Private _Reg_ViewPetLoads As Boolean = True
        Private _Reg_IndvReports As Boolean = True
        Private _Reg_TrackHistory As Boolean = True
        Private _Reg_NumberFormat As String
        Private _Reg_AutoUpdate As Boolean = False
        Private _Reg_UseProxy As Boolean = False
        Private _Reg_UseNumberCatOnly As Boolean
        Private _Reg_AUDITAMMO As Boolean = False
        Private _Reg_USEAUTOASSIGN As Boolean = False
        Private _Reg_UNIQUECUSTCATID As Boolean = False
        Private _Reg_USESELECTIVEBOUNDBOOK As Boolean = False
        Public Property DefaultRegPath() As String
            Get
                If Len(_RegPath) = 0 Then _RegPath = "Software\\BurnSoft\\BSMGC"
                Return _RegPath
            End Get
            Set(ByVal value As String)
                _RegPath = value
            End Set
        End Property
        Private Property Reg_Successful() As String
            Get
                If Len(_Reg_Successful) = 0 Then _Reg_Successful = Now
                Return _Reg_Successful
            End Get
            Set(ByVal value As String)
                _Reg_Successful = value
            End Set
        End Property
        Private Property Reg_SetHistListtb() As String
            Get
                Return _Reg_SetHistListtb
            End Get
            Set(ByVal value As String)
                _Reg_SetHistListtb = value
            End Set
        End Property
        Private Property Reg_SetHistListdt() As String
            Get
                Return _Reg_SetHistListdt
            End Get
            Set(ByVal value As String)
                _Reg_SetHistListdt = value
            End Set
        End Property
        Private Property Reg_AlertOnBackUp() As Boolean
            Get
                Return _Reg_AlertOnBackUp
            End Get
            Set(ByVal value As Boolean)
                _Reg_AlertOnBackUp = value
            End Set
        End Property
        Private Property Reg_TrackHistoryDays() As Integer
            Get
                If _Reg_TrackHistoryDays = 0 Then _Reg_TrackHistoryDays = 15
                Return _Reg_TrackHistoryDays
            End Get
            Set(ByVal value As Integer)
                _Reg_TrackHistoryDays = value
            End Set
        End Property
        Private Property Reg_LastPath() As String
            Get
                If Len(_Reg_LastPath) = 0 Then _Reg_LastPath = "C:\"
                Return _Reg_LastPath
            End Get
            Set(ByVal value As String)
                _Reg_LastPath = value
            End Set
        End Property
        Private Property Reg_LastFile() As String
            Get
                If Len(_Reg_LastFile) = 0 Then _Reg_LastFile = "MGC.MDB"
                Return _Reg_LastFile
            End Get
            Set(ByVal value As String)
                _Reg_LastFile = value
            End Set
        End Property
        Private Property Reg_BackupOnExit() As Boolean
            Get
                Return _Reg_BackupOnExit
            End Get
            Set(ByVal value As Boolean)
                _Reg_BackupOnExit = value
            End Set
        End Property
        Private Property Reg_UseOrgImage() As Boolean
            Get
                Return _Reg_UseOrgImage
            End Get
            Set(ByVal value As Boolean)
                _Reg_UseOrgImage = value
            End Set
        End Property
        Private Property Reg_ViewPetLoads() As Boolean
            Get
                Return _Reg_ViewPetLoads
            End Get
            Set(ByVal value As Boolean)
                _Reg_ViewPetLoads = value
            End Set
        End Property
        Private Property Reg_IndvReports() As Boolean
            Get
                Return _Reg_IndvReports
            End Get
            Set(ByVal value As Boolean)
                _Reg_IndvReports = value
            End Set
        End Property
        Private Property Reg_TrackHistory() As Boolean
            Get
                Return _Reg_TrackHistory
            End Get
            Set(ByVal value As Boolean)
                _Reg_TrackHistory = value
            End Set
        End Property
        Private Property Reg_NumberFormat() As String
            Get
                If Len(_Reg_NumberFormat) = 0 Then _Reg_NumberFormat = "0000"
                Return _Reg_NumberFormat
            End Get
            Set(ByVal value As String)
                _Reg_NumberFormat = value
            End Set
        End Property
        Private Property Reg_AutoUpdate() As Boolean
            Get
                Return _Reg_AutoUpdate
            End Get
            Set(ByVal value As Boolean)
                _Reg_AutoUpdate = value
            End Set
        End Property
        Private Property Reg_UseProxy() As Boolean
            Get
                Return _Reg_UseProxy
            End Get
            Set(ByVal value As Boolean)
                _Reg_UseProxy = value
            End Set
        End Property
        Private Property Reg_AUDITAMMO() As Boolean
            Get
                Return _Reg_AUDITAMMO
            End Get
            Set(ByVal value As Boolean)
                _Reg_AUDITAMMO = value
            End Set
        End Property
        Private Property Reg_UseNumberCatOnly() As Boolean
            Get
                Return _Reg_UseNumberCatOnly
            End Get
            Set(ByVal value As Boolean)
                _Reg_UseNumberCatOnly = value
            End Set
        End Property
        Private Property Reg_USEAUTOASSIGN() As Boolean
            Get
                Return _Reg_USEAUTOASSIGN
            End Get
            Set(ByVal value As Boolean)
                _Reg_USEAUTOASSIGN = value
            End Set
        End Property
        Private Property Reg_UNIQUECUSTCATID() As Boolean
            Get
                Return _Reg_UNIQUECUSTCATID
            End Get
            Set(ByVal value As Boolean)
                _Reg_UNIQUECUSTCATID = value
            End Set
        End Property
        Private Property Reg_USESELECTIVEBOUNDBOOK() As Boolean
            Get
                Return _Reg_USESELECTIVEBOUNDBOOK
            End Get
            Set(ByVal value As Boolean)
                _Reg_USESELECTIVEBOUNDBOOK = value
            End Set
        End Property
        Public Sub UpDateAppDetails()
            Dim strValue As String = DefaultRegPath
            If Not RegSubKeyExists(strValue) Then Call CreateSubKey(strValue)
            Dim MyReg As RegistryKey
            MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            MyReg.SetValue("Version", Application.ProductVersion)
            MyReg.SetValue("AppName", Application.ProductName)
            MyReg.SetValue("AppEXE", Application.ExecutablePath())
            MyReg.SetValue("Path", ApplicationPath)
            MyReg.SetValue("LogPath", MyLogFile)
            MyReg.SetValue("DataBase", ApplicationPathData & "\" & DatabaseName)
            MyReg.SetValue("AppDataPath", ApplicationPathData)
            MyReg.Close()
        End Sub
        Public Sub CreateSubKey(ByVal strValue As String)
            Registry.CurrentUser.CreateSubKey(strValue)
        End Sub
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
        Public Function GetRegSubKeyValue(ByVal strKey As String, ByVal strValue As String, ByVal strDefault As String) As String
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
        Public Sub SetSettingDetails()
            If Not SettingsExists() Then
                Dim MyReg As RegistryKey
                Dim strValue As String = DefaultRegPath & "\Settings"
                MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)

                MyReg = Registry.CurrentUser.CreateSubKey(strValue)
                MyReg.SetValue("Successful", Reg_Successful)
                MyReg.SetValue("SetHistListtb", Reg_SetHistListtb)
                MyReg.SetValue("SetHistListdt", Reg_SetHistListdt)
                MyReg.SetValue("AlertOnBackUp", Reg_AlertOnBackUp)
                MyReg.SetValue("TrackHistoryDays", Reg_TrackHistoryDays)
                MyReg.SetValue("TrackHistory", Reg_TrackHistory)
                MyReg.SetValue("LastPath", Reg_LastPath)
                MyReg.SetValue("LastFile", Reg_LastFile)
                MyReg.SetValue("BackupOnExit", Reg_BackupOnExit)
                MyReg.SetValue("UseOrgImage", Reg_UseOrgImage)
                MyReg.SetValue("ViewPetLoads", Reg_ViewPetLoads)
                MyReg.SetValue("IndvReports", Reg_IndvReports)
                MyReg.SetValue("UseNumberCatOnly", Reg_UseNumberCatOnly)
                MyReg.SetValue("AUDITAMMO", Reg_AUDITAMMO)
                MyReg.Close()
            End If
        End Sub
        Public Function SettingsExists() As Boolean
            Dim bAns As Boolean = False
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            On Error Resume Next
            MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                bAns = False
            Else
                bAns = True
            End If
            Return bAns
        End Function
        Public Sub GetSettings(ByRef LastSucBackup As String, ByRef AlertOnBackUp As Boolean,
                            ByRef TrackHistoryDays As Integer, ByRef TrackHistory As Boolean,
                            ByRef AutoBackup As Boolean, ByRef UOIMG As Boolean, ByRef UsePL As Boolean,
                            ByRef UseIPer As Boolean, ByRef UseCCID As Boolean, ByRef USEAA As Boolean,
                            ByRef UseAACID As Boolean, ByRef UseUniqueCustID As Boolean, ByRef bUSESELECTIVEBOUNDBOOK As Boolean)
            Dim MyReg As RegistryKey
            Dim NumberFormat As String
            Dim UseProxy As Boolean
            Dim AutoUpdate As Boolean
            Dim strValue As String = DefaultRegPath & "\Settings"
            Try
                MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)
                If MyReg Is Nothing Then Call SetSettingDetails()
                If (Not MyReg Is Nothing) Then
                    TrackHistoryDays = CInt(GetRegSubKeyValue(strValue, "TrackHistoryDays", Reg_TrackHistoryDays)) 'CInt(MyReg.GetValue("TrackHistoryDays", ""))
                    TrackHistory = CBool(GetRegSubKeyValue(strValue, "TrackHistory", Reg_TrackHistory))
                    NumberFormat = CStr(GetRegSubKeyValue(strValue, "NumberFormat", Reg_NumberFormat))
                    AutoUpdate = CBool(GetRegSubKeyValue(strValue, "AutoUpdate", Reg_AutoUpdate))
                    UseProxy = CBool(GetRegSubKeyValue(strValue, "UseProxy", Reg_UseProxy))
                    LastSucBackup = GetRegSubKeyValue(strValue, "Successful", Reg_Successful)
                    AlertOnBackUp = CBool(GetRegSubKeyValue(strValue, "AlertOnBackUp", Reg_AlertOnBackUp))
                    AutoBackup = CBool(GetRegSubKeyValue(strValue, "BackupOnExit", Reg_BackupOnExit))
                    UOIMG = CBool(GetRegSubKeyValue(strValue, "UseOrgImage", Reg_UseOrgImage))
                    UsePL = CBool(GetRegSubKeyValue(strValue, "ViewPetLoads", Reg_ViewPetLoads))
                    UseIPer = CBool(GetRegSubKeyValue(strValue, "IndvReports", Reg_IndvReports))
                    UseCCID = CBool(GetRegSubKeyValue(strValue, "UseNumberCatOnly", Reg_UseNumberCatOnly))
                    USEAA = CBool(GetRegSubKeyValue(strValue, "AUDITAMMO", Reg_AUDITAMMO))
                    UseAACID = CBool(GetRegSubKeyValue(strValue, "USEAUTOASSIGN", Reg_USEAUTOASSIGN))
                    UseUniqueCustID = CBool(GetRegSubKeyValue(strValue, "DISABLEUNIQUECUSTCATID", Reg_UNIQUECUSTCATID))
                    bUSESELECTIVEBOUNDBOOK = CBool(GetRegSubKeyValue(strValue, "USESELECTIVEBOUNDBOOK", Reg_USESELECTIVEBOUNDBOOK))
                Else
                    TrackHistoryDays = Reg_TrackHistoryDays
                    TrackHistory = Reg_TrackHistory
                    NumberFormat = Reg_NumberFormat
                    AutoUpdate = Reg_AutoUpdate
                    UseProxy = Reg_UseProxy
                    LastSucBackup = Reg_Successful
                    AlertOnBackUp = Reg_AlertOnBackUp
                    AutoBackup = Reg_BackupOnExit
                    UOIMG = Reg_UseOrgImage
                    UsePL = Reg_ViewPetLoads
                    UseIPer = Reg_IndvReports
                    UseCCID = Reg_UseNumberCatOnly
                    USEAA = Reg_AUDITAMMO
                    UseAACID = Reg_USEAUTOASSIGN
                    UseUniqueCustID = Reg_UNIQUECUSTCATID
                    bUSESELECTIVEBOUNDBOOK = Reg_USESELECTIVEBOUNDBOOK
                End If
            Catch ex As Exception
                Dim MyErr As Long = Err.Number
                If MyErr = 13 Then Call SetSettingDetails()
            End Try
        End Sub
        Public Sub SaveSettings(ByVal NumberFormat As String, ByVal TrackHistory As Boolean,
                                ByVal TrackHistoryDays As Integer, ByVal AutoUpdate As Boolean,
                                ByVal UseProxy As Boolean, ByVal AlertOnBackUp As Boolean,
                                ByVal AutoBackup As Boolean, ByVal UOIMG As Boolean, ByVal UsePL As Boolean,
                                ByVal UseIPer As Boolean, ByVal USENCCID As Boolean, ByVal USEAA As Boolean,
                                ByVal UseAACID As Boolean, ByVal UseUniqueCustID As Boolean, ByVal bUSESELECTIVEBOUNDBOOK As Boolean)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("TrackHistoryDays", TrackHistoryDays)
            MyReg.SetValue("TrackHistory", TrackHistory)
            MyReg.SetValue("NumberFormat", NumberFormat)
            MyReg.SetValue("AutoUpdate", AutoUpdate)
            MyReg.SetValue("UseProxy", UseProxy)
            MyReg.SetValue("AlertOnBackUp", AlertOnBackUp)
            MyReg.SetValue("BackupOnExit", AutoBackup)
            MyReg.SetValue("UseOrgImage", UOIMG)
            MyReg.SetValue("ViewPetLoads", UsePL)
            MyReg.SetValue("IndvReports", UseIPer)
            MyReg.SetValue("UseNumberCatOnly", USENCCID)
            MyReg.SetValue("AUDITAMMO", USEAA)
            MyReg.SetValue("USEAUTOASSIGN", UseAACID)
            MyReg.SetValue("DISABLEUNIQUECUSTCATID", UseUniqueCustID)
            MyReg.SetValue("USESELECTIVEBOUNDBOOK", bUSESELECTIVEBOUNDBOOK)
            MyReg.Close()
        End Sub
        Public Sub SaveLastWorkingDir(ByVal strPath As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If MyReg Is Nothing Then
                MyReg = Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("LastWorkingPath", strPath)
            MyReg.Close()
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
        Public Sub SaveFirearmListSort(ByVal ConfigSort As String)
            Dim strValue As String = DefaultRegPath & "\Settings"
            If Not RegSubKeyExists(strValue) Then Call CreateSubKey(strValue)
            Dim MyReg As RegistryKey
            MyReg = Registry.CurrentUser.OpenSubKey(strValue, True)
            MyReg.SetValue("VIEW_FirearmList", ConfigSort)
            MyReg.Close()
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
    Public Class BSDatabase
        ''' <summary>
        ''' The Class Name for the error file
        ''' </summary>
        Private Const MY_CLASS_NAME = "MGC.BSDatabase"
        ''' <summary>
        ''' The connection
        ''' </summary>
        Public Conn As OdbcConnection
        ''' <summary>
        ''' ses the connect.
        ''' </summary>
        ''' <returns>System.String.</returns>
        Public Function sConnect() As String
            Dim sAns As String = ""
            sAns = "Driver={Microsoft Access Driver (*.mdb)};dbq=" & ApplicationPathData & "\" & DatabaseName & ";Pwd=14un0t2n0"
            Return sAns
        End Function
        ''' <summary>
        ''' ses the connect OLE.
        ''' </summary>
        ''' <returns>System.String.</returns>
        Public Function sConnectOLE() As String
            Dim sAns As String = ""
            'removed ; User Id=
            sAns = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=""" & ApplicationPathData & "\" & DatabaseName & """;Jet OLEDB:Database Password=14un0t2n0;"
            Return sAns
        End Function
        ''' <summary>
        ''' Connects the database.
        ''' </summary>
        Public Sub ConnectDB()
            Try
                Conn = New OdbcConnection(sConnect)
                Conn.Open()
            Catch ex As Exception
                Dim sSubFunc As String = "ConnectDB"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Closes the database.
        ''' </summary>
        Public Sub CloseDB()
            Try
                Conn.Close()
                Conn = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "CloseDB"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Connections the execute.
        ''' </summary>
        ''' <param name="strSQL">The string SQL.</param>
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
                Dim sSubFunc As String = "ConnExec"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
                Call LogError(MY_CLASS_NAME, sSubFunc, 0, "ConnExec.strSQL=" & strSQL)
            End Try
        End Sub

        ''' <summary>
        ''' Creates new contact.
        ''' </summary>
        ''' <param name="sValue">The s value.</param>
        ''' <param name="sTable">The s table.</param>
        ''' <param name="sColumn">The s column.</param>
        Public Sub InsertNewContact(sValue As String, sTable As String, sColumn As String)
            Dim Sql As String = "INSERT INTO " & sTable & "(" & sColumn & ",Address1,City,State,Zip,sync_lastupdate) VALUES('" & sValue & "','N/A','N/A','N/A','N/A',Now())"
            ConnExec(Sql)
        End Sub
    End Class
    ''' <summary>
    ''' Class AutoFillCollections.
    ''' </summary>
    Public Class AutoFillCollections
        ''' <summary>
        ''' Class name for the error log file
        ''' </summary>
        Private Const MY_CLASS_NAME = "MGC.AutoFillCollections"

        ''' <summary>
        ''' Documents the category.
        ''' </summary>
        ''' <returns>AutoCompleteStringCollection.</returns>
        Public Function Document_Category() As AutoCompleteStringCollection
            Dim iCol As New AutoCompleteStringCollection
            Try
                Dim SQL As String = "select distinct(doc_cat) as cat from Gun_Collection_Docs order by doc_cat asc"
                Dim Obj As New BSDatabase
                Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read
                    iCol.Add(RS("cat"))
                End While
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
                Obj = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "Document_Category"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return iCol
        End Function
        
    End Class
    ''' <summary>
    ''' Class GlobalFunctions. General Functions that is used through out the program
    ''' </summary>
    Public Class GlobalFunctions
        ''' <summary>
        ''' Class Name for error file to help locate where the error occurred
        ''' </summary>
        Private Const MY_CLASS_NAME = "MGC.GlobalFunctions"
        ''' <summary>
        ''' Objects the existsin database.
        ''' </summary>
        ''' <param name="strObject">The string object.</param>
        ''' <param name="strField">The string field.</param>
        ''' <param name="strTable">The string table.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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
                Dim sSubFunc As String = "ObjectExistsinDB"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Function
        ''' <summary>
        ''' Gets the identifier.
        ''' </summary>
        ''' <param name="SQL">The SQL.</param>
        ''' <returns>System.Int64.</returns>
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
                Dim sSubFunc As String = "GetID"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString & "::" & SQL)
            End Try
        End Function
        ''' <summary>
        ''' Gets the name.
        ''' </summary>
        ''' <param name="SQL">The SQL.</param>
        ''' <param name="strValue">The string value.</param>
        ''' <returns>System.String.</returns>
        Public Function GetName(ByVal SQL As String, ByVal strValue As String) As String
            Dim sAns As String = "N/A"
            Try
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
            Catch ex As Exception
                Dim sSubFunc As String = "GetName"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString & "::" & SQL)
            End Try
            Return sAns
        End Function
        ''' <summary>
        ''' Contacts the exists.
        ''' </summary>
        ''' <param name="strTable">The string table.</param>
        ''' <param name="strColumnName">Name of the string column.</param>
        ''' <param name="strName">Name of the string.</param>
        ''' <param name="intCount">The int count.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function ContactExists(ByVal strTable As String, ByVal strColumnName As String, ByVal strName As String, Optional ByRef intCount As Integer = 0) As Boolean
            Dim bAns As Boolean = False
            Dim SQL As String = "SELECT Count(*) as Total from " & strTable & " where " & strColumnName & " like '" & strName & "%'"
            Try
                intCount = 0
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    While (RS.Read)
                        intCount = RS("Total")
                    End While
                End If
                If intCount <> 0 Then bAns = True
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Call Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "ContactExists"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
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
            Dim SQL As String = "SELECT Count(*) as Total from " & strTableName & " where " & strColumnName & "='" & strName & "'"
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    While (RS.Read)
                        iAns = RS("Total")
                    End While
                End If
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Call Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "HasCollectionAttached"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return iAns
        End Function

        ''' <summary>
        ''' Gets the manufacturers identifier.
        ''' </summary>
        ''' <param name="strValue">The string value.</param>
        ''' <returns>System.Int64.</returns>
        Public Function GetManufacturersID(ByVal strValue As String) As Long
            Dim SQL As String = "SELECT ID from Gun_Manufacturer where Brand='" & strValue & "'"
            Dim iAns As Long = GetID(SQL)
            If iAns = 0 Then
                Dim Obj As New BSDatabase
                Obj.ConnExec("INSERT INTO Gun_Manufacturer(Brand,sync_lastupdate) VALUES('" & strValue & "',Now())")
                iAns = GetID(SQL)
            End If
            Return iAns
        End Function

        ''' <summary>
        ''' Gets the name of the wish list.
        ''' </summary>
        ''' <param name="strID">The string identifier.</param>
        ''' <returns>System.String.</returns>
        Public Function GetWishListName(ByVal strID As String) As String
            Dim sAns As String = ""
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = "SELECT * from WishList where ID=" & strID
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While (RS.Read)
                    sAns = RS("Manufacturer") & " " & RS("Model")
                End While
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "GetWishListName"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return sAns
        End Function

        ''' <summary>
        ''' Stolen buyer exists.
        ''' </summary>
        ''' <param name="strName">Name of the string.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function StolenBuyerExists(ByVal strName As String) As Boolean
            Dim bAns As Boolean = False
            Try
                Dim Obj As New BSDatabase
                Dim SQL As String = "SELECT * from Gun_Collection_SoldTo where Name='" & strName & "'"
                Call Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                bAns = RS.HasRows
                RS.Close()
                RS = Nothing
                CMD = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "StolenBuyerExists"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function

        ''' <summary>
        ''' Catalogs the is numeric.
        ''' </summary>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function CatalogIsNumeric() As Boolean
            Dim bAns As Boolean = False
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = "SELECT CustomID from Gun_Collection"
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                Dim sID As String = ""
                Dim iRowCount As Long = 0
                Dim iCount As Long = 0
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    While RS.Read
                        iRowCount += 1
                        sID = Trim(RS("CustomID"))
                        If Len(sID) = 0 Then sID = "N/A"
                        If IsNumeric(sID) Then iCount += 1
                    End While
                End If
                If iRowCount = iCount Then bAns = True
            Catch ex As Exception
                Dim sSubFunc As String = "CatalogIsNumeric"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Converts to numeric.
        ''' </summary>
        Public Sub SetCatalogValuesToNumeric()
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = "SELECT ID,CustomID from Gun_Collection"
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                Dim sID As String = ""
                Dim iRowCount As Long = 0
                Dim iCount As Long = 0
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    While RS.Read
                        iCount += 1
                        Obj.ConnExec("UPDATE Gun_Collection set CustomID='" & iCount & "',sync_lastupdate=Now() where ID=" & RS("ID"))
                    End While
                End If
            Catch ex As Exception
                Dim sSubFunc As String = "SetCatalogToNumeric"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Sets the type of the catalog.
        ''' </summary>
        ''' <param name="sType">Type of the s.</param>
        Public Sub SetCatalogType(ByVal sType As String)
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = ""
                Select Case LCase(sType)
                    Case "num"
                        SQL = "ALTER TABLE Gun_Collection ALTER COLUMN CustomID Integer;"
                    Case "let"
                        SQL = "ALTER TABLE Gun_Collection ALTER COLUMN CustomID Text(255);"
                    Case Else
                        SQL = "ALTER TABLE Gun_Collection ALTER COLUMN CustomID Text(255);"
                End Select
                Obj.ConnExec(SQL)
            Catch ex As Exception
                Dim sSubFunc As String = "SetCatalogType"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Gets the report SQL.
        ''' </summary>
        ''' <param name="RID">The rid.</param>
        ''' <returns>System.String.</returns>
        Public Function GetReportSQL(ByVal RID As Long) As String
            Dim sAns As String = ""
            sAns = GetName("SELECT * from CR_SavedReports where id=" & RID, "MySQL")
            Return sAns
        End Function
        ''' <summary>
        ''' Determines whether [has default picture] [the specified identifier].
        ''' </summary>
        ''' <param name="ID">The identifier.</param>
        ''' <param name="AddPic">if set to <c>true</c> [add pic].</param>
        ''' <returns><c>true</c> if [has default picture] [the specified identifier]; otherwise, <c>false</c>.</returns>
        Public Function HasDefaultPicture(ByVal ID As Long, Optional ByVal AddPic As Boolean = False) As Boolean
            Dim bAns As Boolean = False
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = "SELECT * from Gun_Collection_Pictures where CID=" & ID & " and IsMain=1"
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                bAns = RS.HasRows
                If Not bAns And AddPic Then Call AddDefaultPic(ID)
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
                Obj = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "HasDefaultPicture"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Adds the default pic.
        ''' </summary>
        ''' <param name="ItemID">The item identifier.</param>
        Sub AddDefaultPic(ByVal ItemID As Long)
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
                Dim st_t As New FileStream(sThumbName, FileMode.Open, FileAccess.Read)
                Dim mbr_t As BinaryReader = New BinaryReader(st_t)
                Dim buffer_t(st_t.Length) As Byte
                mbr_t.Read(buffer_t, 0, CInt(st_t.Length))
                st_t.Close()
                '--End Function to convert picture to thumbnail for database format--
                Dim Obj As New BSDatabase
                Dim MyConn As New Connection
                MyConn.Open(Obj.sConnect)
                Dim RS As New Recordset
                RS.Open("Gun_Collection_Pictures", MyConn, 2, 2)
                RS.AddNew()
                RS("CID").Value = ItemID
                RS("PICTURE").AppendChunk(buffer)
                RS("THUMB").AppendChunk(buffer_t)
                RS("ISMAIN").Value = 1
                RS("sync_lastupdate").Value = Now
                RS.Update()
                RS.Close()
            Catch ex As Exception
                Dim sSubFunc As String = "AddDefaultPic"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Determines whether [is currently in use barrel] [the specified bid].
        ''' </summary>
        ''' <param name="BID">The bid.</param>
        ''' <returns><c>true</c> if [is currently in use barrel] [the specified bid]; otherwise, <c>false</c>.</returns>
        Public Function IsCurrentlyinUseBarrel(ByVal BID As Long) As Boolean
            'TODO: #50 Convert this to use new library
            Dim bAns As Boolean = False
            Try
                Dim Obj As New BSDatabase
                Obj.ConnectDB()
                Dim SQL As String = "SELECT * from Gun_Collection where DBID=" & BID
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                bAns = RS.HasRows
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "IsCurrentlyinUseBarrel"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Deletes the barrel system.
        ''' </summary>
        ''' <param name="BID">The bid.</param>
        ''' <param name="sMsg">The s MSG.</param>
        Public Sub DeleteBarrelSystem(ByVal BID As Long, ByRef sMsg As String)
            Try
                'TODO: #50 Convert this to use new library
                'Currently in debate on if the gun maintenance section should be
                'effected due to the receiver still having to take the rounds.
                Dim Obj As New BSDatabase
                Dim SQL As String = ""
                sMsg = ""
                If Not IsCurrentlyinUseBarrel(BID) Then
                    SQL = "DELETE FROM Gun_Collection_Ext_Links where BSID=" & BID
                    Obj.ConnExec(SQL)
                    SQL = "DELETE FROM Gun_Collection_Ext where ID=" & BID
                    Obj.ConnExec(SQL)
                    sMsg = "Barrel/Conversion Kit was removed!"
                Else
                    sMsg = "Barrel/Conversion Kit is set as a default barrel." & Chr(10) & "Please correct before removing!"
                End If
            Catch ex As Exception
                Dim sSubFunc As String = "DeleteBarrelSystem"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
        ''' <summary>
        ''' Determines whether [has multi barrels listed] [the specified gid].
        ''' </summary>
        ''' <param name="GID">The gid.</param>
        ''' <returns><c>true</c> if [has multi barrels listed] [the specified gid]; otherwise, <c>false</c>.</returns>
        Function HasMultiBarrelsListed(ByVal GID As Long) As Boolean
            Dim bAns As Boolean = False
            Try
                'TODO #50 Updated from main Library once updated to the next version
                Dim Obj As New BSDatabase
                Obj.ConnectDB()
                Dim SQL As String = "SELECT Count(*) as Total from Gun_Collection_Ext where GID=" & GID
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                Dim tCount As Long = 0
                RS = CMD.ExecuteReader
                While RS.Read()
                    tCount = CLng(RS("Total"))
                    If tCount > 1 Then bAns = True
                End While
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
                Obj = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "HasMultiBarrelsListed"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Determines whether [has documents attached] [the specified gid].
        ''' </summary>
        ''' <param name="GID">The gid.</param>
        ''' <returns><c>true</c> if [has documents attached] [the specified gid]; otherwise, <c>false</c>.</returns>
        Function HasDocumentsAttached(GID As Long) As Boolean
            Dim bAns As Boolean = False
            Try
                Dim Obj As New BSDatabase
                Obj.ConnectDB()
                Dim SQL As String = "select * from Gun_Collection_Docs_Links where GID=" & GID
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                bAns = RS.HasRows
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
                Obj = Nothing
            Catch ex As Exception
                Dim sSubFunc As String = "HasDocumentsAttached"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        ''' <summary>
        ''' Adds the purchase price accessories.
        ''' </summary>
        ''' <param name="GID">The gid.</param>
        ''' <returns>System.Double.</returns>
        Function AddPurchasePriceAccessories(ByVal GID As Long) As Double
            Dim dAns As Double = 0
            Try
                Dim Obj As New BSDatabase
                Obj.ConnectDB()
                Dim SQL As String = "SELECT SUM(cdbl(PurValue)) as Total from Gun_Collection_Accessories where GID=" & GID
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                Dim tCount As Long = 0
                RS = CMD.ExecuteReader
                While RS.Read()
                    If Not IsDBNull(RS("Total")) Then dAns = CDbl(RS("Total"))
                End While
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "AddPurchasePriceAccessories"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
            Return (dAns)
        End Function
        ''' <summary>
        ''' Adds the appriased price accessories.
        ''' </summary>
        ''' <param name="GID">The gid.</param>
        ''' <returns>System.Double.</returns>
        Function AddAppriasedPriceAccessories(ByVal GID As Long) As Double
            Dim dAns As Double = 0
            Try
                Dim Obj As New BSDatabase
                Obj.ConnectDB()
                Dim SQL As String = "SELECT SUM(cdbl(AppValue)) as Total from Gun_Collection_Accessories where GID=" & GID & " and CIV=1"
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                Dim tCount As Long = 0
                RS = CMD.ExecuteReader
                While RS.Read()
                    If Not IsDBNull(RS("Total")) Then dAns = CDbl(RS("Total"))
                End While
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "AddAppriasedPriceAccessories"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
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
                Dim Obj As New BSDatabase
                Dim SQL As String = "SELECT top 1 dbver from DB_Version order by ID desc"
                Call Obj.ConnectDB()
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    While RS.Read()
                        dAns = CDbl(RS("dbver"))
                    End While
                Else
                    dAns = 0
                End If
                RS.Close()
                RS = Nothing
                CMD = Nothing
                Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "DatabaseVersion"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
                dAns = 0
            End Try

            Return dAns
        End Function
        ''' <summary>
        ''' Gets the user settings database.
        ''' </summary>
        ''' <param name="RecID">The record identifier.</param>
        ''' <param name="sName">Name of the s.</param>
        ''' <param name="sAddress">The s address.</param>
        ''' <param name="sCity">The s city.</param>
        ''' <param name="sState">State of the s.</param>
        ''' <param name="sZip">The s zip.</param>
        ''' <param name="sPhone">The s phone.</param>
        ''' <param name="sCCD">The s CCD.</param>
        Public Sub GetUserSettingsDB(ByRef RecID As Long, ByRef sName As String, ByRef sAddress As String,
                                    ByRef sCity As String, ByRef sState As String, ByRef sZip As String,
                                    ByRef sPhone As String, ByRef sCCD As String)
            Try
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                Dim SQL As String = "SELECT TOP 1 * from Owner_Info"
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    RS.Read()
                    RecID = CInt(RS("ID"))
                    sName = Trim(RS("name"))
                    sAddress = Trim(One.Decrypt(RS("address")))
                    sCity = Trim(RS("City"))
                    sState = Trim(RS("State"))
                    sZip = Trim(RS("Zip"))
                    sPhone = Trim(RS("Phone"))
                    sCCD = Trim(One.Decrypt(RS("CCDWL")))
                Else
                    RecID = 0
                End If
                RS.Close()
                CMD = Nothing
                RS = Nothing
                Obj.CloseDB()
            Catch ex As Exception
                Dim sSubFunc As String = "GetUserSettingsDB"
                Call LogError(MY_CLASS_NAME, sSubFunc, Err.Number, ex.Message.ToString)
            End Try
        End Sub
    End Class
    ''' <summary>
    ''' Class BSFileSystem.
    ''' </summary>
    Public Class BSFileSystem
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
