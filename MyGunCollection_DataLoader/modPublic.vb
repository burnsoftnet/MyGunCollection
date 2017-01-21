Imports System
Imports System.Data
Imports System.Data.Odbc
Imports MyGunCollection_DataLoader.GlobalFunctions
Module modPublic
    Public Const AppTitle As String = "My Gun Collection - Data Loader"
    Public bAmmo As Boolean
    Public bGripType As Boolean
    Public bManufacturer As Boolean
    Public bModel As Boolean
    Public BNationality As Boolean
    Public bType As Boolean
    Public BMaintPlan As Boolean
    Public Const DL_AMMO As String = "DL_AMMO.XML"
    Public Const DL_GRIPS As String = "DL_GRIPS.XML"
    Public Const DL_MANU As String = "DL_MANU.XML"
    Public Const DL_MOD As String = "DL_MOD.XML"
    Public Const DL_NAT As String = "DL_NAT.XML"
    Public Const DL_TYPES As String = "DL_TYPES.XML"
    Public Const DL_MAINT As String = "DL_MAINT.XML"
    Public Const WEBSERVICETIMEOUT As Long = 60000
    Public APPLICATION_PATH As String
    Public APPLICATION_PATH_DATA As String
    Public Const DATABASE_NAME = "MGC.mdb"
    Sub INIT()
        Dim ObjF As New bsfilesystem
        Dim AppDataPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) & "\BurnSoft\MGC"
        Dim APPDATAPATH_EXISTS As Boolean = Objf.DirectoryExists(AppDataPath)
        APPLICATION_PATH = System.Windows.Forms.Application.StartupPath
        APPLICATION_PATH_DATA = System.Windows.Forms.Application.StartupPath
        If APPDATAPATH_EXISTS Then
            If Objf.FileExists(AppDataPath & "\" & DATABASE_NAME) Then
                APPLICATION_PATH_DATA = AppDataPath
            End If
        End If
    End Sub
    Public Function FluffContent(ByVal strContent As String) As String
        Dim sAns As String = ""
        sAns = Trim(Replace(strContent, "'", "''"))
        If Len(sAns) = 0 Then
            sAns = "   "
        End If
        Return sAns
    End Function
End Module
