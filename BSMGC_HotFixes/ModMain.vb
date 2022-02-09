Imports BSMGC_HotFixes.BSRegistry
Imports System.Windows.Forms
Imports BurnSoft.Universal
Module ModMain
    Dim HOTFIXONLY As Boolean
    Dim HOTFIX_NUMBER As Integer
    Dim PIC_THUMB_NUMBER As Integer
    Dim PIC_THUMB_ONLY As Boolean
    'Mostly to clean up the debug messages form the init
    'This will display the values set in the init
    Sub INIT_DEBUG()
        Call DebugLog("INIT", "Redo=" & ReDo)
        Call DebugLog("INIT", "debug=" & BUGGERME)
        Call DebugLog("INIT", "showerrors=" & SUPPRESS_CONSOLE_ERRORS)
        Call DebugLog("INIT", "ConvertPicturesToThumbNails=" & ConvertPicsOnly)
        Call DebugLog("RunApp", "DBPATH=" & strDBPath, "INFO")
        Call DebugLog("RunApp", "MAINAPPPATH=" & MainApp, "INFO")
        Call DebugLog("RunApp", "CURPATH=" & CurPath, "INFO")
        Call DebugLog("RunApp", "APPLICATION_PATH_DATA=" & APPLICATION_PATH_DATA, "INFO")
    End Sub
    'Initialize Global Vars with commands passed to the app, if any.
    Sub INIT()
        Try
            Dim Obj As New BSOtherObjects
            Dim ObjRS As New BSRegistry

            ReDo = Obj.GetCommand("redo", False)
            BUGGERME = Obj.GetCommand("debug", False)
            ConvertPicsOnly = Obj.GetCommand("conpics", False)
            SUPPRESS_CONSOLE_ERRORS = Obj.GetCommand("showerrors", False)
            HOTFIX_NUMBER = Obj.GetCommand("hotfix", 0, HOTFIXONLY)
            PIC_THUMB_NUMBER = Obj.GetCommand("picthumb", 0, PIC_THUMB_ONLY)

            strDBPath = ObjRS.GetDatabasePath
            MainApp = ObjRS.MainApplication()
            CurPath = ObjRS.CurrentAppPath()
            APPLICATION_PATH_DATA = ObjRS.GetDataPath()

            Obj = Nothing
            ObjRS = Nothing
            Call INIT_DEBUG()
        Catch ex As Exception
            Call LogError("ModMain", "INIT", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'This can be deleted, this is not longer in the build
    'Sub DoACLChange()
    ' Dim iOS As Integer = Environment.OSVersion.Version.Major
    '    If iOS >= 6 Then
    'Dim myProcess As New Process
    '        myProcess.StartInfo.FileName = Application.StartupPath & "\win7.bat"
    '        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
    '        myProcess.Start()
    '    Else
    '        Console.Write("Your OS Does not need the ACL to Be Changed since it is less then Windows Vista")
    '        Console.Read()
    '    End If
    'End Sub

    'Two convert pics subs, since one option was for stand alone by removing and
    'adding the password itself, it would conflict with the hotfix patch since
    'it already removed it, and still need to run other fixes before adding it back on
    'so this convert pics hf has the remove and add password subs removed from it
    Sub ConvertPicsHF()
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
            Console.WriteLine("An Error Occurred: " & ex.Message.ToString & " Press any key to continue!")
            Console.Read()
        End Try
    End Sub
    'Start the process to convert the pictures into thumbnails
    Sub ConvertPics()
        Try
            Dim sAns As String = vbYes
            Dim UpdateMsg As String = ""
            Call RemovePassword()
            Call ConvertPicsDB()
            Console.WriteLine(vbTab & "All Pictures now have it's own thumbnail")
            Call AddPassword()
            If ConvertPicsOnly Then Console.Read()
        Catch ex As Exception
            Call LogError("ModMain", "RunApp", Err.Number, ex.Message.ToString)
            Console.WriteLine("An Error Occurred: " & ex.Message.ToString & " Press any key to continue!")
            Console.Read()
        End Try
    End Sub
    'Remote the Password, run the hotfixed and updates, put back the password and start the app.
    Sub RunApp()
        Try
            Dim sAns As String = vbYes
            Dim UpdateMsg As String = ""

            Call RemovePassword()
            Call DoUpdates()
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
            Console.WriteLine("Error occurred: " & ex.Message.ToString & " Press any ley to continue")
            Console.Read()
        End Try
    End Sub
    'Header for when the application starts or if help is presented
    Sub Banner()
        Console.WriteLine("BurnSoft " & ProductName & " HotFix/Upgrade Assistant")
        Console.WriteLine("Version: " & HFVer & vbTab & "Copyright 1997-" & Now.Year)
        Console.WriteLine("Support and Updates at http://www.burnsoft.net")
        Console.WriteLine("")
    End Sub
    'Make sure the process is not running, if so, kill it.
    Private Sub CloseProcessesByName(processName As String)
        For Each p As Process In Process.GetProcessesByName(processName)
            ' Ask nicely for the process to close.
            p.CloseMainWindow()

            ' Wait up to 10 seconds for the process to close.
            p.WaitForExit(10000)

            If Not p.HasExited Then
                ' The process did not close itself so force it to close.
                p.Kill()
            End If

            ' Dispose the Process object, which is different to closing the running process.
            p.Close()
        Next
    End Sub
    'Main Start sub
    Sub Main()
        Try
            Call CloseProcessesByName("BSMyGunCollection")
            Call Banner()
            Call INIT()
            'After version 5 of my gun collection the registry key was moved from local to user.
            Dim bsreg As New BSRegistry
            Call bsreg.MoveSettingKeys()

            If ConvertPicsOnly Then
                Call ConvertPics()
            ElseIf Not ConvertPicsOnly And HOTFIXONLY Then
                Call RunSpecificHotFic(HOTFIX_NUMBER)
            ElseIf Not ConvertPicsOnly And Not HOTFIXONLY And PIC_THUMB_ONLY Then
                Call ConvertSelectedPictureByID(PIC_THUMB_NUMBER)
            Else
                If ReDo Then Call RedoAll()
                IsRunning = False
                HotFixApplied = False
                Call RunApp()
            End If

            bsreg = Nothing
        Catch ex As Exception
            Call LogError("ModMain", "Main", Err.Number, ex.Message.ToString)
            Console.WriteLine($"An Error Occurred: " & ex.Message.ToString & $" Press any key to continue!")
            Console.Read()
        End Try
    End Sub

End Module
