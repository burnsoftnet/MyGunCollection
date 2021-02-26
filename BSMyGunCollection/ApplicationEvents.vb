Imports BSMyGunCollection.MGC
Imports System.Configuration
Imports System.Security.Principal
Namespace My
    Partial Friend Class MyApplication
        'when the application initialize, setup the running path of the database and where the log file is going to be loaded.
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Dim Objf As New BSFileSystem
            Try
                Dim Debug_MSG As String = ""
                Dim NL As String = vbCrLf

                DebugMode = System.Configuration.ConfigurationManager.AppSettings("DEBUG_MODE")
                Dim AppDataPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) & "\BurnSoft\MGC"
                Dim APPDATAPATH_EXISTS As Boolean = Objf.DirectoryExists(AppDataPath)
                ApplicationPath = System.Windows.Forms.Application.StartupPath
                ApplicationPathData = ApplicationPath
                Debug_MSG &= NL & "AppDataPath=" & AppDataPath
                If APPDATAPATH_EXISTS Then
                    Debug_MSG &= NL & "Found Application Data Path"
                    If Objf.FileExists(AppDataPath & "\" & DatabaseName) Then
                        Debug_MSG &= NL & "Found Application Data"
                        ApplicationPathData = AppDataPath
                    End If
                End If
                AppDomain.CurrentDomain.SetData("DataDirectory", ApplicationPathData)
                Debug_MSG &= NL & "Application Data Path=" & ApplicationPathData
                Debug_MSG &= NL & "Application Path=" & ApplicationPath
                Debug_MSG &= NL & "OS Version=" & Environment.OSVersion.Version.Major

                Dim BATCH_EXISTS As Boolean = Objf.FileExists(ApplicationPath & "\srh.bat")
                Dim INI_EXISTS As Boolean = Objf.FileExists(ApplicationPath & "\hotfix.ini")

                MyLogFile = ApplicationPathData & "\err.log"

                If BATCH_EXISTS Or INI_EXISTS Then
                    If BATCH_EXISTS Then Debug_MSG &= NL & "srh.bat exists"
                    If INI_EXISTS Then Debug_MSG &= NL & "hotfix.ini exists"
                    Dim myProcess As New Process
                    Dim RunThiSApp As String = ApplicationPath & "\" & MyHotfixFile
                    myProcess.StartInfo.FileName = RunThiSApp
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                    DoAutoBackup = False
                    myProcess.Start()
                    Global.System.Windows.Forms.Application.Exit()
                End If
                Call Buggerme("My.MyApplication.OnInitialize", Debug_MSG)
                Dim ObjGF As New GlobalFunctions
                Dim IsComp As Boolean = ObjGF.DBIsCompliant
                Return MyBase.OnInitialize(commandLineArgs)
            Catch ex As Exception
                Dim strProcedure As String = "OnInitialize"
                Call LogError("My.MyApplication", strProcedure, Err.Number, ex.Message.ToString)
            End Try
        End Function
    End Class
End Namespace
