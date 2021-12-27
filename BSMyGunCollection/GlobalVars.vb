Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports BurnSoft.Security.RegularEncryption.SHA

''' <summary>
''' Global Variables and Functions
''' </summary>
Module GlobalVars
    ''' <summary>
    ''' The Owner ID
    ''' </summary>
    Public OwnerId As String
    ''' <summary>
    ''' The owner name
    ''' </summary>
    Public OwnerName As String
    ''' <summary>
    ''' The owner lic
    ''' </summary>
    Public OwnerLic As String
    ''' <summary>
    ''' The use login
    ''' </summary>
    Public UseLogin As Boolean
    ''' <summary>
    ''' The use my password
    ''' </summary>
    Public UseMyPwd As String
    ''' <summary>
    ''' The use my uid
    ''' </summary>
    Public UseMyUid As String
    ''' <summary>
    ''' The use my forgot word
    ''' </summary>
    Public UseMyForgotWord As String
    ''' <summary>
    ''' The use my forgot phrase
    ''' </summary>
    Public UseMyForgotPhrase As String
    ''' <summary>
    ''' The is logged in
    ''' </summary>
    Public IsLoggedIn As Boolean
    ''' <summary>
    ''' My log file
    ''' </summary>
    Public MyLogFile As String
    ''' <summary>
    ''' The do automatic backup
    ''' </summary>
    Public DoAutoBackup As Boolean
    ''' <summary>
    ''' The do original image
    ''' </summary>
    Public DoOriginalImage As Boolean
    ''' <summary>
    ''' The use pet loads
    ''' </summary>
    Public UsePetLoads As Boolean
    ''' <summary>
    ''' The personal mark
    ''' </summary>
    Public PersonalMark As Boolean
    ''' <summary>
    ''' The use number cat only
    ''' </summary>
    Public UseNumberCatOnly As Boolean
    ''' <summary>
    ''' The audit ammo
    ''' </summary>
    Public Auditammo As Boolean
    ''' <summary>
    ''' The use auto assign
    ''' </summary>
    Public Useautoassign As Boolean
    ''' <summary>
    ''' The last viewed firearm
    ''' </summary>
    Public Lastviewedfirearm As Long
    ''' <summary>
    ''' The disable unique cust cat id
    ''' </summary>
    Public Disableuniquecustcatid As Boolean
    ''' <summary>
    ''' The use selective bound book
    ''' </summary>
    Public Useselectiveboundbook As Boolean
    ''' <summary>
    ''' The application path
    ''' </summary>
    Public ApplicationPath As String
    ''' <summary>
    ''' The application path data
    ''' </summary>
    Public ApplicationPathData As String
    ''' <summary>
    ''' The database path
    ''' </summary>
    Public DatabasePath as String
    ''' <summary>
    ''' The debug mode
    ''' </summary>
    Public DebugMode As Boolean
    ''' <summary>
    ''' The show firearm gallery on start
    ''' </summary>
    Public ShowFirarmGalleryOnStart As Boolean
    ''' <summary>
    ''' The Database Version that we are expected for this version
    ''' </summary>
    Public Const MyDatabaseVersion As Double = 6.0
    ''' <summary>
    ''' The Help file name
    ''' </summary>
    Public Const MyHelpFile = "my_gun_collection_help.chm"
    ''' <summary>
    ''' Hot fix exe app
    ''' </summary>
    Public Const MyHotfixFile = "BSMGC_HotFixes.exe"
    ''' <summary>
    ''' back up application
    ''' </summary>
    Public Const MyBackup = "DBBackup.exe"
    ''' <summary>
    ''' restore application
    ''' </summary>
    Public Const MyRestore = "DBRestore.exe"
    ''' <summary>
    ''' Link to My Gun Collection Wiki Section
    ''' </summary>
    Public Const MenuWiki = "https://github.com/burnsoftnet/MyGunCollection/wiki"
    ''' <summary>
    ''' Link to bug report
    ''' </summary>
    Public Const MenuBug = "https://github.com/burnsoftnet/MyGunCollection/issues"
    ''' <summary>
    ''' Default Date of Birth
    ''' </summary>
    Public Const DefaultDob = "1/1/1900"
    ''' <summary>
    ''' Name of default firearm picture
    ''' </summary>
    Public Const DefaultPic = "mgc_default.jpg"
    ''' <summary>
    ''' default log file name
    ''' </summary>
    Public Const DebugFile = "mgc.debug.log"
    ''' <summary>
    ''' default database name
    ''' </summary>
    Public Const DatabaseName = "MGC.mdb"
    ''' <summary>
    ''' format the strings to be database friendly
    ''' </summary>
    ''' <param name="strContent"></param>
    ''' <param name="sDefault"></param>
    ''' <returns></returns>
    Public Function FluffContent(ByVal strContent As String, Optional ByVal sDefault As String = " ") As String
        Dim sAns As String = ""
        Try
            sAns = Trim(Replace(strContent, "'", "''"))
            If Len(sAns) = 0 Then
                sAns = sDefault
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "FluffContent"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' Format a string value into a double value
    ''' </summary>
    ''' <param name="strContent"></param>
    ''' <param name="lDefault"></param>
    ''' <returns></returns>
    Public Function FluffContent(ByVal strContent As String, ByVal lDefault As Double) As Double
        Dim sAns As Double = 0
        Try
            If Len(strContent) = 0 Then
                sAns = lDefault
            Else
                sAns = CDbl(strContent)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "FluffContent"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' format a string value into a long value
    ''' </summary>
    ''' <param name="strContent"></param>
    ''' <param name="lDefault"></param>
    ''' <returns></returns>
    Public Function FluffContent(ByVal strContent As String, ByVal lDefault As Long) As Long
        Dim lAns As Long = 0
        Try
            If Len(strContent) = 0 Then
                lAns = lDefault
            Else
                lAns = CLng(strContent)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "FluffContent"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return lAns
    End Function
    ''' <summary>
    ''' Check to see if a field is required and alert if the value is not blank and alert if it is required
    ''' </summary>
    ''' <param name="strValue"></param>
    ''' <param name="strField"></param>
    ''' <param name="strTitle"></param>
    ''' <returns></returns>
    Public Function IsRequired(ByVal strValue As String, ByVal strField As String, ByVal strTitle As String) As Boolean
        Dim bAns As Boolean = False
        ''TODO #50 Convert this code to use helpers.isrequired
        Try
            If Len(Trim(strValue)) = 0 Then
                bAns = False
            Else
                bAns = True
            End If
            If bAns = False Then MsgBox("Please put in a value for " & strField & "!", MsgBoxStyle.Critical, strTitle)
        Catch ex As Exception
            Dim sSubFunc As String = "IsRequired"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Verify that the field is filled in
    ''' </summary>
    ''' <param name="lValue"></param>
    ''' <param name="lDefault"></param>
    ''' <param name="strField"></param>
    ''' <param name="StrTitle"></param>
    ''' <returns></returns>
    Public Function IsRequired(ByVal lValue As Long, ByVal lDefault As Long, ByVal strField As String, ByVal StrTitle As String) As Boolean
        Dim bAns As Boolean = False
        Try
            If lValue = lDefault Then
                bAns = False
            Else
                bAns = True
            End If
            If bAns = False Then MsgBox("Please put in a value for " & strField & "!", MsgBoxStyle.Critical, StrTitle)
        Catch ex As Exception
            Dim sSubFunc As String = "IsRequired"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Override to verify that the field is required and has information
    ''' </summary>
    ''' <param name="lValue"></param>
    ''' <param name="lDefault"></param>
    ''' <param name="strField"></param>
    ''' <param name="StrTitle"></param>
    ''' <returns></returns>
    Public Function IsRequired(ByVal lValue As Double, ByVal lDefault As Double, ByVal strField As String, ByVal StrTitle As String) As Boolean
        Dim bAns As Boolean = False
        Try
            If lValue = lDefault Then
                bAns = False
            Else
                bAns = True
            End If
            If bAns = False Then MsgBox("Please put in a value for " & strField & "!", MsgBoxStyle.Critical, StrTitle)
        Catch ex As Exception
            Dim sSubFunc As String = "IsRequired"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Check to see if the login is enabled in the database
    ''' </summary>
    ''' <param name="PWD"></param>
    ''' <param name="UID"></param>
    ''' <param name="FW"></param>
    ''' <param name="FP"></param>
    ''' <returns></returns>
    Public Function LoginEnabled(ByRef PWD As String, ByRef UID As String, ByRef FW As String, ByRef FP As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL = "SELECT UsePWD,PWD,UID,forgot_word,forgot_phrase from Owner_Info"
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                Dim intUsePWD As Integer = CInt(RS("UsePWD"))
                If intUsePWD = 1 Then
                    If Not IsDBNull(RS("PWD")) Then
                        PWD = One.Decrypt(RS("PWD"))
                    Else
                        PWD = ""
                    End If
                    If Not IsDBNull(RS("UID")) Then
                        UID = One.Decrypt(RS("UID"))
                    Else
                        UID = "admin"
                    End If
                    If Not IsDBNull(RS("forgot_word")) And Len(RS("forgot_word")) > 0 Then
                        FW = One.Decrypt(RS("forgot_word"))
                    Else
                        FW = "burnsoft"
                    End If
                    If Not IsDBNull(RS("forgot_phrase")) And Len(RS("forgot_phrase")) > 0 Then
                        FP = One.Decrypt(RS("forgot_phrase"))
                    Else
                        FP = "The Company that made this App"
                    End If
                    bAns = True
                Else
                    bAns = False
                    PWD = ""
                    UID = "admin"
                    FP = "The Company that made this App"
                    FW = "burnsoft"
                End If
            Else
                bAns = False
                PWD = ""
                UID = "admin"
                FP = "The Company that made this App"
                FW = "burnsoft"
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LoginEnabled"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Get the Owner ID to look up the information and return the owner id
    ''' </summary>
    ''' <returns></returns>
    Public Function GetOwnerID() As Integer
        Dim iAns As Integer = 0
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT Top 1 ID,Name,CCDWL from Owner_Info"
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read)
                    iAns = RS("ID")
                    OwnerName = RS("Name")
                    If Not IsDBNull(RS("CCDWL")) Then
                        OwnerLic = Trim(One.Decrypt(RS("CCDWL")))
                    Else
                        OwnerLic = ""
                    End If
                End While
            Else
                iAns = 0
                OwnerName = "Trial User"
            End If
            RS.Close()
            RS = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetOwnerID"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return iAns
    End Function
    ''' <summary>
    ''' Convert string to a double
    ''' </summary>
    ''' <param name="strValue"></param>
    ''' <returns></returns>
    Public Function ConvToNum(ByVal strValue As String) As Double
        Dim dAns As Double = 0
        Try
            Dim intChar As Integer = Len(strValue)
            Dim i As Integer = 0
            Dim CurValue As String = ""
            Dim NewValue As String = ""
            Dim LastValue As String = ""
            Dim NeedDiv As Boolean = False
            For i = 1 To intChar
                CurValue = Mid(strValue, i, 1)
                If CurValue = " " Then Exit For
                If IsNumeric(CurValue) Then
                    If Len(LastValue) <> 0 Then
                        LastValue = Mid(NewValue, Len(NewValue), 1)
                    Else
                        LastValue = CurValue
                    End If
                    If Not NeedDiv Then
                        NewValue &= CurValue
                    Else
                        NewValue = CInt(CurValue) / CInt(LastValue)
                    End If
                    NeedDiv = False
                Else
                    Select Case CurValue
                        Case "."
                            NewValue &= CurValue
                            NeedDiv = False
                        Case "/"
                            NeedDiv = True
                    End Select
                End If
            Next
            dAns = CDbl(NewValue)
        Catch ex As Exception
            Dim sSubFunc As String = "ConvTonum"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return dAns
    End Function
    ''' <summary>
    ''' Dump information in the debug log if enabled
    ''' </summary>
    ''' <param name="sFrom"></param>
    ''' <param name="sMsg"></param>
    Public Sub Buggerme(ByVal sFrom As String, ByVal sMsg As String)
        If DebugMode Then
            Dim ObjFS As New BSFileSystem
            Dim sMessage As String = Now() & sFrom & " - " & sMsg
            Dim sPath As String = Application.LocalUserAppDataPath.ToString & "\" & DebugFile
            ObjFS.LogDebugFile(sPath, sMessage)
        End If
    End Sub
    ''' <summary>
    ''' Dump information into the error log
    ''' </summary>
    ''' <param name="sForm"></param>
    ''' <param name="sProcedure"></param>
    ''' <param name="iErrNo"></param>
    ''' <param name="sErrorDesc"></param>
    Public Sub LogError(ByVal sForm As String, ByVal sProcedure As String, ByVal iErrNo As Long, ByVal sErrorDesc As String)
        Try
            Dim objFs As New BSFileSystem
            Dim sMessage As String = sForm & "." & sProcedure & "::" & iErrNo & "::" & sErrorDesc
            objFs.LogFile(MyLogFile, sMessage)
        Catch ex As Exception
            Dim sMsg As String = "ERRROR Writing to Log File!" & Chr(13) & sForm & "." & sProcedure & "::" & iErrNo & "::" & sErrorDesc
            MsgBox(sMsg)
        End Try
    End Sub
    ''' <summary>
    ''' A simpler Log File Dump mostly to handle errors from the main library that was created in c#
    ''' </summary>
    ''' <param name="message">The message.</param>
    Public Sub LogError(ByVal message As String )
        Try
            Dim ObjFS As New BSFileSystem
            ObjFS.LogFile(MyLogFile, message)
        Catch ex As Exception
            Dim sMsg As String = "ERRROR Writing to Log File!" & Chr(13) & message
            MsgBox(sMsg)
        End Try
    End Sub
    ''' <summary>
    ''' Check to see if the picture in the database is a the default picture
    ''' </summary>
    ''' <param name="ID"></param>
    Sub CheckDefaultPic(ByVal ID As Long)
        Try
            Dim Obj As New GlobalFunctions
            Obj.HasDefaultPicture(ID, True)
        Catch ex As Exception
            Dim sSubFunc As String = "CheckDefaultPic"
            Call LogError("GlobalVars", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Module
