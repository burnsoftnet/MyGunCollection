Imports BSMGC_HotFixes.BSRegistry
Imports System.Windows.Forms
Module ModMain
    Sub INIT()
        Try
            SUPPRESS_CONSOLE_ERRORS = True
            Dim TempBool As Boolean = False
            TempBool = GetCommand("redo", "bool", ReDo)
            TempBool = GetCommand("debug", "bool", BUGGERME)
            TempBool = GetCommand("conpics", "bool", ConvertPicsOnly)
            TempBool = GetCommand("acl", "bool", RUNACL)
            SUPPRESS_CONSOLE_ERRORS = CBool(GetCommand("showerrors", "bool", TempBool))
            If Not TempBool Then
                SUPPRESS_CONSOLE_ERRORS = True
            Else
                SUPPRESS_CONSOLE_ERRORS = False
            End If
            Call DebugLog("INIT", "Redo=" & ReDo)
            Call DebugLog("INIT", "debug=" & BUGGERME)
            Call DebugLog("INIT", "showerrors=" & SUPPRESS_CONSOLE_ERRORS)
            Call DebugLog("INIT", "ConvertPicturesToThumbNails=" & ConvertPicsOnly)
            Call DebugLog("INIT", "RUNACL=" & RUNACL)
        Catch ex As Exception
            Call LogError("ModMain", "INIT", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub DoACLChange()
        Dim iOS As Integer = Environment.OSVersion.Version.Major
        If iOS >= 6 Then
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = Application.StartupPath & "\win7.bat"
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            myProcess.Start()
        Else
            Console.Write("Your OS Does not need the ACL to Be Changed since it is less then Windows Vista")
            Console.Read()
        End If
    End Sub
    Sub ConvertPicsHF()
        'Two convertpics subs, since one option was for stand alone by removing and
        'adding the password itself, it would conflict with the hotfix patch since
        'it already removed it, and still need to run other fixes before adding it back on
        'so this convertpicshf has the remove and add password subs removed from it
        Try
            Dim sAns As String = vbYes
            Dim UpdateMsg As String = ""
            Dim ObjRS As New BSRegistry
            strDBPath = ObjRS.GetDatabasePath
            MainApp = ObjRS.MainApplication()
            CurPath = ObjRS.CurrentAppPath()
            Call ConvertPicsDB()
            Console.WriteLine()
            Console.WriteLine(vbTab & "All Pictures now have it's own thumbnail")
        Catch ex As Exception
            Call LogError("ModMain::ConvertPicsHF", "RunApp", Err.Number, ex.Message.ToString)
            Console.Read()
        End Try
    End Sub
    Sub ConvertPics()
        Try
            Dim sAns As String = vbYes
            Dim UpdateMsg As String = ""
            Dim ObjRS As New BSRegistry
            Call DebugLog("RunApp", "Getting DB Path", "INFO")
            strDBPath = ObjRS.GetDatabasePath
            Call DebugLog("RunApp", "DBPATH=" & strDBPath, "INFO")
            Call DebugLog("RunApp", "Getting Main App Path", "INFO")
            MainApp = ObjRS.MainApplication()
            Call DebugLog("RunApp", "MAINAPPPATH=" & MainApp, "INFO")
            Call DebugLog("RunApp", "Getting Current Path", "INFO")
            CurPath = ObjRS.CurrentAppPath()
            Call DebugLog("RunApp", "CURPATH=" & CurPath, "INFO")
            Call RemovePassword()
            Call ConvertPicsDB()
            Console.WriteLine(vbTab & "All Pictures now have it's own thumbnail")
            Call AddPassword()
            If ConvertPicsOnly Then Console.Read()
        Catch ex As Exception
            Call LogError("ModMain", "RunApp", Err.Number, ex.Message.ToString)
            Console.Read()
        End Try
    End Sub
    Sub RunApp()
        Try
            Dim sAns As String = vbYes
            Dim UpdateMsg As String = ""
            Dim ObjRS As New BSRegistry
            Call DebugLog("RunApp", "Getting DB Path", "INFO")
            strDBPath = ObjRS.GetDatabasePath
            Call DebugLog("RunApp", "DBPATH=" & strDBPath, "INFO")
            Call DebugLog("RunApp", "Getting Main App Path", "INFO")
            MainApp = ObjRS.MainApplication()
            Call DebugLog("RunApp", "MAINAPPPATH=" & MainApp, "INFO")
            Call DebugLog("RunApp", "Getting Current Path", "INFO")
            CurPath = ObjRS.CurrentAppPath()
            Call DebugLog("RunApp", "CURPATH=" & CurPath, "INFO")
            Call RemovePassword()
            Call RegHotfixExists()
            Call DoUpdates()
            Call DeleteUpdateFile()
            Call AddPassword()
            If HotFixApplied Then
                Console.WriteLine("Updates were applied!")
                sAns = "y"
            Else
                Console.WriteLine("No updates where applied.  You are currently up-to-date!")
                Console.WriteLine("Do you wish to start the " & ProductName & " Application Now (y/n)?")
                sAns = LCase(Console.ReadLine())
            End If
            Dim i As Integer
            If sAns = "y" Or sAns = "yes" Then
                i = Shell(MainApp, AppWinStyle.MaximizedFocus)
            End If
        Catch ex As Exception
            Call LogError("ModMain", "RunApp", Err.Number, ex.Message.ToString)
            Console.Read()
        End Try
    End Sub
    Sub Banner()
        Console.WriteLine("BurnSoft " & ProductName & " HotFix/Upgrade Assistant")
        Console.WriteLine("Version: " & HFVer & vbTab & "Copyright 1997-" & Now.Year)
        Console.WriteLine("Support and Updates at http://www.burnsoft.net")
        Console.WriteLine("")
    End Sub
    Sub Main()
        Try
            Call Banner()
            Call INIT()
            'After version 5 of my gun collection the registry key was moved from local to user.
            Dim bsreg As New BSRegistry
            Call bsreg.MoveSettingKeys()
            If Not RUNACL Then
                If Not ConvertPicsOnly Then
                    If ReDo Then Call RedoAll()
                    IsRunning = False
                    HotFixApplied = False
                    Call RunApp()
                Else
                    Call ConvertPics()
                End If
            Else
                Call DoACLChange()
            End If
        Catch ex As Exception
            Call LogError("ModMain", "Main", Err.Number, ex.Message.ToString)
            Console.Read()
        End Try
    End Sub

End Module
