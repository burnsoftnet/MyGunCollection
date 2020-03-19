'Imports BSMGC_HotFixes.BSFileSystem
Imports BurnSoft.Universal
Module ModGlobal
    Public IsRunning As Boolean
    Public ReDo As Boolean
    Public strDBPath As String
    Public Const DATABASEPASSWORD = "14un0t2n0"
    Public Const RegRoot = "HKLM"
    Public Const RegKey = "Software\\BurnSoft\\BSMGC"
    Public Const MyLogFile = "mgchf_err.log"
    Public Const DebugLogFile = "hotfix.debug.log"
    Public Const ProductName = "My Gun Collector"
    Public Const HFVer = "6.0"
    Public SUPPRESS_CONSOLE_ERRORS
    Public APPLICATION_PATH_DATA As String
    Public MainApp As String
    Public CurPath As String
    Public BUGGERME As Boolean
    Public ConvertPicsOnly As Boolean
    'Public RUNACL As Boolean

    'Function GetCommand(ByVal strLookFor As String, ByVal strType As String, Optional ByRef DidExist As Boolean = False) As String
    'Dim sAns As String = ""
    '    DidExist = False
    '    Select Case LCase(strType)
    '        Case "string"
    '            sAns = ""
    '        Case "bool"
    '            sAns = "false"
    '        Case "int"
    '            sAns = 0
    '        Case Else
    '            sAns = ""
    '    End Select
    'Dim cmdLine() As String = System.Environment.GetCommandLineArgs
    'Dim i As Integer = 0
    'Dim intCount As Integer = cmdLine.Length
    'Dim strValue As String = ""
    '    If intCount > 1 Then
    '        For i = 1 To intCount - 1
    '            strValue = cmdLine(i)
    '            strValue = Replace(strValue, "/", "")
    '            strValue = Replace(strValue, "--", "")
    'Dim strSplit() As String = Split(strValue, "=")
    'Dim intLBound As Integer = LBound(strSplit)
    'Dim intUBound As Integer = UBound(strSplit)
    '            If LCase(strSplit(intLBound)) = LCase(strLookFor) Then
    '                If intUBound <> 0 Then
    '                    sAns = strSplit(intUBound)
    '                Else
    '                    sAns = "true"
    '                End If
    '                DidExist = True
    '                Exit For
    '            End If
    '        Next
    '    End If
    '    Return LCase(sAns)
    'End Function
    Public Sub LogError(ByVal sForm As String, ByVal sProcedure As String, ByVal iErrNo As Long, ByVal sErrorDesc As String)
        Try
            Dim ObjFS As New FileIO
            Dim sMessage As String = sForm & "." & sProcedure & "::" & iErrNo & "::" & sErrorDesc
            ObjFS.LogFile(APPLICATION_PATH_DATA & "\" & MyLogFile, sMessage)
            If BUGGERME Then Console.WriteLine(sMessage)
        Catch ex As Exception
            If Not SUPPRESS_CONSOLE_ERRORS Then
                Console.WriteLine("ERROR::" & sForm & "." & sProcedure & "::" & iErrNo & "::" & sErrorDesc)
                Console.WriteLine("Press the Enter Key to Continue.")
                Console.Read()
            End If
        End Try
    End Sub
    'Use debug option for more information, this will output to screen and or file
    Public Sub DebugLog(ByVal sSub As String, Optional ByVal sMsg As String = "", Optional ByVal sErrorType As String = "INFO")
        Try
            If BUGGERME Then
                Dim ObjFS As New FileIO
                Dim sMessage As String = sErrorType & "::" & sMsg & " from " & sSub
                ObjFS.LogFile(APPLICATION_PATH_DATA & "\" & DebugLogFile, sMessage)
                Console.WriteLine(sMessage)
            End If
        Catch ex As Exception
            If Not SUPPRESS_CONSOLE_ERRORS Then
                Console.WriteLine("ERROR::" & sMsg & " from " & sSub)
                Console.WriteLine("Press the Enter Key to Continue.")
                Console.Read()
            End If
        End Try
    End Sub
    'This doesn't retuen anything, you might be able to delete
    Sub RegHotfixExists()
        Dim BSReg As New BSRegistry
        Dim MyRead As String
        MyRead = BSReg.GetRegSubKeyValue(RegKey & "\\HotFix", "LastUpdate")
    End Sub
    'check to see if a hotfix exists from the registry
    Function HotFixExists(ByRef strID As String) As Boolean
        Dim bAns As Boolean = False
        Dim BSReg = New BSRegistry
        Dim MyRead As String
        MyRead = BSReg.GetRegSubKeyValue(RegKey & "\\HotFix", strID)
        If MyRead = "" Then
            bAns = False
        Else
            bAns = True
        End If
        HotFixExists = bAns
    End Function
    'this will get the last hostfix that was applied
    Sub UpdateLastUpdate(ByRef strUpdate As String)
        Dim BSReg As New BSRegistry
        Call BSReg.SaveRegValue(RegKey & "\HotFix", "LastUpdate", strUpdate)
    End Sub
    'Save and mark the hotfix as being applied in the registry
    Sub AppliedUpdates(ByRef strUpdate As String)
        Dim BSReg As New BSRegistry
        Call BSReg.SaveRegValue(RegKey & "\HotFix", strUpdate, CStr(Now))
    End Sub
    'Delete Registry Value
    Sub DelRegValue(ByRef strKey As String, ByRef strValue As String, ByRef strParameter As String)
        Dim BSReg As New BSRegistry
        Call BSReg.DeleteRegValue(RegKey & "\" & strKey, strValue)
    End Sub
    'Save the Registry Value
    Sub SaveRegValue(ByRef strKey As String, ByRef strValue As String, ByRef strParameter As String)
        Dim BSReg As New BSRegistry
        Call BSReg.SaveRegValue(RegKey & "\" & strKey, strValue, strParameter)
    End Sub
    'Convet a string value to a Double Value, This was mostly used when convering the grains string to a 
    'double to help with proper table sorting when the user clicked on the grains table header
    Public Function ConvToNum(ByVal strValue As String) As Double
        Dim dAns As Double : dAns = 0
        Dim intChar As Short : intChar = Len(strValue)
        Dim i As Short : i = 0
        Dim CurValue As String : CurValue = ""
        Dim NewValue As String : NewValue = ""
        Dim LastValue As String : LastValue = ""
        Dim NeedDiv As Boolean : NeedDiv = False
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
                    NewValue = NewValue & CurValue
                Else
                    NewValue = CStr(CShort(CurValue) / CShort(LastValue))
                End If
                NeedDiv = False
            Else
                Select Case CurValue
                    Case "."
                        NewValue = NewValue & CurValue
                        NeedDiv = False
                    Case "/"
                        NeedDiv = True
                End Select
            End If
        Next
        dAns = CDbl(NewValue)
        ConvToNum = dAns
    End Function
    'delete the file that was passed, only the file, it is using the global var curpath for the path
    Sub DeleteFile(ByRef strFile As String)
        Try
            Dim ObjFS As New FileIO
            ObjFS.DeleteFile(CurPath & "\" & strFile)
        Catch ex As Exception
            Call DebugLog("DeleteFile error")
            Call DebugLog("DeleteFile", Err.Number & " - " & Err.Description, "ERROR")
        End Try
    End Sub
    'rename the selected file, only the file, it is using the global var curpath for the path
    Sub RenameFile(ByRef sFrom As String, ByRef sTo As String)
        Dim ObjFS As New FileIO
        ObjFS.RenameFile(CurPath & "\" & sFrom, CurPath & "\" & sTo)
    End Sub
    'pass the path and file to see if it exists
    Function FileExists(ByRef sFile As String) As Boolean
        Dim ObjFS As New FileIO
        Return ObjFS.FileExists(sFile)
    End Function
    'format the string to help with the database insert
    Public Function FluffContent(ByVal strContent As String, Optional ByVal sDefault As String = " ") As String
        Dim sAns As String = ""
        Try
            sAns = Trim(Replace(strContent, "'", "''"))
            If Len(sAns) = 0 Then
                sAns = sDefault
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "FluffContent"
            Call LogError("modGlobal", sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
End Module
