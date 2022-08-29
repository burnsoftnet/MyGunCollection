Imports System.Collections.ObjectModel
Imports BSMyGunCollection.LogginAndSettings
Imports System.Configuration
''' <summary>
''' The My namespace.
''' </summary>
' ReSharper disable once CheckNamespace
Namespace My
    Partial Friend Class MyApplication
        'when the application initialize, setup the running path of the database and where the log file is going to be loaded.        
        ''' <summary>
        ''' Sets the visual styles, text display styles, and current principal for the main application thread (if the application uses Windows authentication), and initializes the splash screen, if defined.
        ''' </summary>
        ''' <param name="commandLineArgs">A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see langword="String" />, containing the command-line arguments as strings for the current application.</param>
        ''' <returns>A <see cref="T:System.Boolean" /> indicating if application startup should continue.</returns>
' ReSharper disable once ParameterHidesMember
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            Dim bsFileSystem As New BsFileSystem
            Try
                Dim debugMsg As String = ""
                Dim nl As String = vbCrLf

                DebugMode = ConfigurationManager.AppSettings("DEBUG_MODE")
                Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BurnSoft\MGC"
                Dim appDataPathExists As Boolean = bsFileSystem.DirectoryExists(appDataPath)
                ApplicationPath = Windows.Forms.Application.StartupPath
                ApplicationPathData = ApplicationPath
                debugMsg &= nl & "AppDataPath=" & appDataPath
                If appDataPathExists Then
                    debugMsg &= nl & "Found Application Data Path"
                    If bsFileSystem.FileExists(appDataPath & "\" & DatabaseName) Then
                        debugMsg &= nl & "Found Application Data"
                        ApplicationPathData = appDataPath
                    End If
                End If
                DatabasePath = ApplicationPathData & "\" & DatabaseName
                AppDomain.CurrentDomain.SetData("DataDirectory", ApplicationPathData)
                debugMsg &= nl & "Application Data Path=" & ApplicationPathData
                debugMsg &= nl & "Application Path=" & ApplicationPath
                debugMsg &= nl & "OS Version=" & Environment.OSVersion.Version.Major

                Dim batchExists As Boolean = bsFileSystem.FileExists(ApplicationPath & "\srh.bat")
                Dim iniExists As Boolean = bsFileSystem.FileExists(ApplicationPath & "\hotfix.ini")

                MyLogFile = ApplicationPathData & "\err.log"

                If batchExists Or iniExists Then
                    If batchExists Then debugMsg &= nl & "srh.bat exists"
                    If iniExists Then debugMsg &= nl & "hotfix.ini exists"
                    Dim myProcess As New Process
                    Dim runThiSApp As String = ApplicationPath & "\" & MyHotfixFile
                    myProcess.StartInfo.FileName = runThiSApp
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                    DoAutoBackup = False
                    myProcess.Start()
                    Windows.Forms.Application.Exit()
                End If
                Call Buggerme("My.MyApplication.OnInitialize", debugMsg)
                Return MyBase.OnInitialize(commandLineArgs)
            Catch ex As Exception
                Dim strProcedure As String = "OnInitialize"
                Call LogError("My.MyApplication", strProcedure, Err.Number, ex.Message.ToString)
            End Try
        End Function
    End Class
End Namespace
