Imports System.Data.Odbc
Imports ADODB
Imports System.IO
Module modDatabase
    ''' <summary>
    ''' Add the Database Password
    ''' </summary>
    Public Sub AddPassword()
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Open()
            End With
            Dim SQL As String
            SQL = "ALTER DATABASE PASSWORD " & DATABASEPASSWORD & " NULL"
            Conn.Execute(SQL)
            Conn.Close()
        Catch ex As Exception
            Select Case Err.Number
                Case -2147217843
                    Call DebugLog("AddPassword", "Old Password invalid or doesn't exist.", "ERROR")
                Case Else
                    'Call DebugLog("AddPassword", "AddPassword error", "ERROR")
                    Call DebugLog("AddPassword", Err.Number & " - " & Err.Description, "ERROR")
            End Select
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    ''' <summary>
    ''' Remove the database password
    ''' </summary>
    Public Sub RemovePassword()
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Open()
            End With
            Dim SQL As String
            SQL = "ALTER DATABASE PASSWORD NULL " & DATABASEPASSWORD
            Conn.Execute(SQL)
            Conn.Close()
        Catch ex As Exception
            Select Case Err.Number
                Case -2147467259
                    Call DebugLog("RemovePassword", "Password invalid or doesn't exist.", "ERROR")
                Case Else
                    Call DebugLog("RemovePassword", Err.Number & " - " & Err.Description, "ERROR")
            End Select
            Call LogError("modDatabase", "RemovePassword", Err.Number, ex.Message.ToString)
        End Try
        If Conn.State <> 0 Then Conn.Close()
        Conn = Nothing
    End Sub
    ''' <summary>
    ''' Remove Password then Add New Password
    ''' </summary>
    Sub ChangePassword()
        Call RemovePassword()
        Call AddPassword()
        Call DebugLog("ChangePassword", "ChangePassword", "INFO")
    End Sub
    ''' <summary>
    ''' Test database with no password
    ''' </summary>
    ''' <returns></returns>
    Public Function TestDBWithNoPWD() As Boolean
        Dim bAns As Boolean = False
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Open()
            End With
            bAns = True
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("TestDBWithNoPWD", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
        Return bAns
    End Function
    ''' <summary>
    ''' Test database with password
    ''' </summary>
    ''' <returns></returns>
    Function TestDBwithPWD() As Boolean
        Dim bAns As Boolean = False
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            bAns = True
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("TestDBWithPWD", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
        Return bAns
    End Function
    ''' <summary>
    ''' Run SQL statement, by default it will run in exclusive mode, unless you pass false in the second parameter
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <param name="RUNASADMIN"></param>
    Sub RunSQL(ByVal SQL As String, Optional ByVal RUNASADMIN As Boolean = True)
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                If RUNASADMIN Then .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Conn.Execute(SQL)
            Conn.Close()
        Catch ex As Exception
            Select Case Err.Number
                Case -2147217887
                    Call DebugLog("RunSQL", "Field Already Exists in Table", "WARN")
                    Call DebugLog("RunSQL", SQL)
                Case -2147217900
                    Call DebugLog("RunSQL", "Table Already Exists", "WARN")
                    Call DebugLog("RunSQL", Err.Number & " - " & ex.Message.ToString, "ERROR")
                    Call DebugLog("RunSQL", SQL)
                Case Else
                    Call DebugLog("RunSQL", SQL, "ERROR")
                    Call DebugLog("RunSQL", Err.Number & " - " & Err.Description, "ERROR")
            End Select
            'Call LogError("modDatabase", "RunSQL", Err.Number, ex.Message.ToString)
            'Call LogError("modDatabase", "RunSQL", "SQL STATEMENT", SQL)
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    ''' <summary>
    ''' Add Column to Table
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <param name="strTable"></param>
    ''' <param name="strDefaultValue"></param>
    ''' <param name="StrType"></param>
    Sub AddColumn(ByRef strName As String, ByRef strTable As String, ByRef strDefaultValue As String, ByRef StrType As String)
        Dim MySQL As String
        MySQL = "ALTER TABLE " & strTable & " ADD COLUMN " & strName & " " & StrType & ";"
        Call RunSQL(MySQL, False)
    End Sub
    'Add Column to Table with default value
    Sub AddColumnD(ByRef strName As String, ByRef strTable As String, ByRef strDefaultValue As String, ByRef StrType As String)
        Dim MySQL As String
        MySQL = "ALTER TABLE " & strTable & " ADD COLUMN " & strName & " " & StrType & " [""" & strDefaultValue & """];"
        'MySQL = "ALTER TABLE " & strTable & " ADD COLUMN " & strName & " " & StrType & " DEFAULT '" & strDefaultValue & "';"
        Call RunSQL(MySQL, False)
    End Sub
    'Drop database view
    Sub DropView(ByVal ViewName As String)
        Dim SQL As String
        SQL = "DROP VIEW " & ViewName
        Call RunSQL(SQL)
    End Sub
    'Create new View for database
    Sub CreateView(ByVal ViewName As String, ByVal SQL As String)
        Dim MySQL As String
        MySQL = "CREATE VIEW " & ViewName & " AS " & SQL
        Call RunSQL(MySQL)
    End Sub
    'Alter database view
    Sub AlterView(ByVal ViewName As String, ByVal SQL As String)
        Dim MySQL As String
        MySQL = "ALTER VIEW " & ViewName & " AS (" & SQL & ")"
        Call RunSQL(MySQL)
    End Sub
    'Alter database column in table
    Sub AlterColumn(ByRef strName As String, ByRef strTable As String, ByRef strDefaultValue As String, ByRef StrType As String)
        Dim MySQL As String
        MySQL = "ALTER TABLE " & strTable & " ALTER COLUMN " & strName & " " & StrType & ";"
        Call RunSQL(MySQL)
    End Sub
    'Drop Table
    Sub DropTable(ByRef strTable As String)
        Dim MySQL As String
        MySQL = "DROP TABLE " & strTable & ";"
        Call RunSQL(MySQL)
    End Sub
    'Check to see if value exists in selected table
    Function ValueDoesExist(ByRef strTable As String, ByRef strCol As String, ByRef strValue As String) As Boolean
        Dim bAns As Boolean = False
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                '.Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim SQL As String
            SQL = "SELECT * from " & strTable & " where " & strCol & "='" & strValue & "'"
            RS.Open(SQL, Conn, 1, 3)
            If Not RS.BOF And Not RS.EOF Then bAns = True
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call LogError("modDatabase", "ValueDoesExist", Err.Number, ex.Message.ToString)
            Call DebugLog("ValueDoesExist", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
        Return bAns
    End Function
    'Pass a SQL Statement to see if rows return or not
    Function RowsExists(SQL As String) As Boolean
        Dim bAns As BookmarkEnum = False
        Dim conn As OdbcConnection
        conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            conn.Open()
            Dim CMD As New OdbcCommand(SQL, conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            bAns = RS.HasRows
            RS.Close()
            RS = Nothing
            CMD = Nothing
            conn.Close()
        Catch ex As Exception
            Call DebugLog("RowsExists", Err.Number & " - " & Err.Description, "ERROR")
            Call LogError("modDatabase", "RowsExists", Err.Number, ex.Message.ToString)
        End Try
        If Conn.State <> 0 Then Conn.Close()
        Return bAns
    End Function
    'Swap old values to new in the gun collection, back when we had one value in one section and added another
    Sub SwapGunColPurchaseValues(ByRef strTable As String, ByRef strSourceCol As String, ByRef strDestCol As String)
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim MySQL As String = ""
            Dim SQL As String = "SELECT ID," & strSourceCol & ", " & strDestCol & " from " & strTable
            RS.Open(SQL, Conn, 1, 3)
            If Not RS.BOF And Not RS.EOF Then
                RS.MoveFirst()
                Do Until RS.EOF
                    If IsDBNull(RS.Fields(strDestCol).Value) Then
                        MySQL = "UPDATE " & strTable & " set " & strDestCol & "='" & RS.Fields(strSourceCol).Value & "' where id=" & RS.Fields("ID").Value
                        Conn.Execute(MySQL)
                    End If
                    RS.MoveNext()
                Loop
            End If
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("SwapGunColPurchaseValues", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Get the Main Picture from the pictures collection table
    Function GetMainPictureFirstListing(ByRef strCID As String) As Long
        Dim lAns As Long = 0
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim SQL As String
            SQL = "SELECT TOP 1 ID FROM Gun_Collection_Pictures where CID=" & strCID & " order by ID ASC"
            RS.Open(SQL, Conn, 1, 3)
            If Not RS.BOF And Not RS.EOF Then
                RS.MoveFirst()
                Do Until RS.EOF
                    lAns = CInt(RS.Fields("ID").Value)
                    RS.MoveNext()
                Loop
            End If
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("GetMainPictureFirstListing", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
        Return lAns
    End Function
    'Check to see if the selected firearm has a default picture setup
    Function HasDefaultPictureSet(ByRef strCID As String) As Boolean
        Dim bAns As Boolean = False
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim SQL As String = "SELECT * FROM Gun_Collection_Pictures where CID=" & strCID & " and ISMAIN=1"
            RS.Open(SQL, Conn, 1, 3)
            If Not RS.BOF And Not RS.EOF Then
                bAns = True
            Else
                bAns = False
            End If
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("HasDefaultPictureSet", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
        Return bAns
    End Function
    'Set the main picture of the firearm collection
    Sub SetMainPictures()
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim SQL As String
            Dim MySQL As String
            SQL = "SELECT DISTINCT(Gun_Collection_Pictures.CID) as CID FROM Gun_Collection_Pictures"
            RS.Open(SQL, Conn, 1, 3)
            Dim LID As Integer : LID = 0
            If Not RS.BOF And Not RS.EOF Then
                RS.MoveFirst()
                Do Until RS.EOF
                    If Not HasDefaultPictureSet(CStr(RS.Fields("CID").Value)) Then
                        LID = GetMainPictureFirstListing(CStr(RS.Fields("CID").Value))
                        If LID <> 0 Then
                            MySQL = "UPDATE Gun_Collection_Pictures set ISMAIN=1 where ID=" & LID
                            Conn.Execute(MySQL)
                        End If
                    End If
                    RS.MoveNext()
                Loop
            End If
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("SetMainPictures", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'New in version 6, get the names form the gunsmith table and put them in the contacts table
    Sub MoveGunSmiths()
        'ValueDoesExist
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            Conn.Open()
            Dim SQL As String = "SELECT DISTINCT(gsmith) as name from GunSmith_Details"
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim sName As String = ""
            While RS.Read
                sName = FluffContent(RS("name"))
                If Not ValueDoesExist("GunSmith_Contact_Details", "gName", sName) Then
                    'Call RunSQL("INSERT INTO GunSmith_Contact_Details(gName,Address1,City,State,Zip,sync_lastupdate) VALUES('" & sName & "','N/A','N/A','N/A','N/A',Now())", False)
                    Call ConnExec("INSERT INTO GunSmith_Contact_Details(gName,Address1,City,State,Zip,sync_lastupdate) VALUES('" & sName & "','N/A','N/A','N/A','N/A',Now())")
                End If
            End While
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("MoveGunSmiths", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'New in version 6, get the unique names of the appriaser and put the in the appraiser contact table
    Sub MoveAppraisers()
        'ValueDoesExist
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            Conn.Open()
            Dim SQL As String = "SELECT DISTINCT(AppraisedBy) as name from Gun_Collection"
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim sName As String = ""

            While RS.Read
                sName = FluffContent(RS("name"))
                If Not ValueDoesExist("Appriaser_Contact_Details", "aName", sName) Then
                    'Call RunSQL("INSERT INTO Appriaser_Contact_Details(aName,Address1,City,State,Zip,sync_lastupdate) VALUES('" & sName & "','N/A','N/A','N/A','N/A',Now())", False)
                    ' Conn.execute("INSERT INTO Appriaser_Contact_Details(aName,Address1,City,State,Zip,sync_lastupdate) VALUES('" & sName & "','N/A','N/A','N/A','N/A',Now())")
                    Call ConnExec("INSERT INTO Appriaser_Contact_Details(aName,Address1,City,State,Zip,sync_lastupdate) VALUES('" & sName & "','N/A','N/A','N/A','N/A',Now())")
                End If
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("MoveAppraisers", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Run through the accessories and put them in the linker table
    Public Sub LinkAccessories()
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            Conn.Open()
            Dim SQL As String = "select * from Gun_Collection_Accessories order by gid asc"
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim GID As Long
            Dim RID As Long

            While RS.Read
                GID = RS("gid")
                RID = RS("id")
                If Not RowsExists("SELECT * from Gun_Collection_Accessories_Link where gid=" & GID & " and rid=" & RID) Then
                    Call ConnExec("INSERT INTO Gun_Collection_Accessories_Link (GID,AID) VALUES (" & GID & "," & RID & ")")
                End If
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("MoveAppraisers", Err.Number & " - " & Err.Description, "ERROR")
        End Try
        If Conn.State <> 0 Then Conn.Close()
        Conn = Nothing
    End Sub
    'Save the selected picture by ID to hdd
    Sub SaveDBPic_Org(ByVal myID As Long, ByRef rPicName As String)
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            Conn.Open()
            Dim SQL As String = "SELECT PICTURE from Gun_Collection_Pictures where ID=" & myID
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim b() As Byte = CMD.ExecuteScalar
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                Dim bmp As System.Drawing.Image = New System.Drawing.Bitmap(stream)
                Dim sPicName As String = "mgc_org_pic.jpg"
                bmp.Save(sPicName, System.Drawing.Imaging.ImageFormat.Jpeg)
                bmp.Dispose()
                stream.Close()
                rPicName = sPicName
            End If
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("SaveDBPic_Org", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Save the Thumbnail of the picture by ID and the file name and location or the original
    'to save it to the database as a thumbnail.
    Sub SaveAsThumb(ByVal MyID As Long, ByVal sFileName As String)
        Dim MyConn As New ADODB.Connection
        Try
            Dim sThumbName As String = "mgc_thumb.jpg"
            Dim intPicHeight As Integer = 64
            Dim intPicWidth As Integer = 64
            Dim myNewPic As System.Drawing.Image
            Dim myBitmap As System.Drawing.Image
            myBitmap = System.Drawing.Image.FromFile(sFileName)
            Dim myPicCallback As System.Drawing.Image.GetThumbnailImageAbort = Nothing
            myNewPic = myBitmap.GetThumbnailImage(intPicWidth, intPicHeight, myPicCallback, _
                IntPtr.Zero)
            myBitmap.Dispose()
            System.IO.File.Delete(sThumbName)
            myNewPic.Save(sThumbName, System.Drawing.Imaging.ImageFormat.Jpeg)
            myNewPic.Dispose()
            Dim st_t As New FileStream(sThumbName, FileMode.Open, FileAccess.Read)
            Dim mbr_t As BinaryReader = New BinaryReader(st_t)
            Dim buffer_t(st_t.Length) As Byte
            mbr_t.Read(buffer_t, 0, CInt(st_t.Length))
            st_t.Close()
            MyConn.Open("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=14un0t2n0")
            Dim RS As New ADODB.Recordset
            RS.Open("Gun_Collection_Pictures", MyConn, 2, 2)
            RS.Filter = "ID = " & MyID
            RS("THUMB").AppendChunk(buffer_t)
            RS.Update()
            RS.Close()
            RS = Nothing
            MyConn.Close()
        Catch ex As Exception
            If MyConn.State <> 0 Then MyConn.Close()
        End Try

        MyConn = Nothing
    End Sub
    'Convert all the picture to have a thumbnail, this was new in version 4.0
    'to solve the issue of the original pics being create as thumbnails on load.
    'that method cause performance issue so thumbnails where created
    Sub ConvertPicsDB()
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            Conn.Open()
            Dim SQL As String = "SELECT * from Gun_Collection_Pictures order by ID ASC"
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim SaveName As String = ""
            Dim PicID As Long = 0
            Console.Write(vbTab)
            While RS.Read()
                PicID = RS("ID")
                Call SaveDBPic_Org(PicID, SaveName)
                Call SaveAsThumb(PicID, SaveName)
                Console.Write(".")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("ConvertPicsDB", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Convert only a selected picture to have a thumbnail
    'Added this in version 6, since I have noticed that there are pictures missing thumbnails
    Public Sub ConvertSelectedPictureByID(PicID As Long)
        Try
            Dim SaveName As String = ""
            Call SaveDBPic_Org(PicID, SaveName)
            Call SaveAsThumb(PicID, SaveName)
            Console.Write("Picture with the ID of " & PicID & " should have a thumbnail now!")
        Catch ex As Exception
            Call DebugLog("ConvertSelectedPictureByID", Err.Number & " - " & Err.Description, "ERROR")
        End Try
    End Sub
    'Convert the grains in the ammo inventory to a decimal value
    Sub ConvertAmmoGrainsToNum()
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeShareExclusive
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim SQL As String
            Dim MySQL As String
            SQL = "SELECT ID,Grain FROM Gun_Collection_Ammo"
            RS.Open(SQL, Conn, 1, 3)
            Dim intID As Integer : intID = 0
            Dim dValue As Double : dValue = 0
            If Not RS.BOF And Not RS.EOF Then
                RS.MoveFirst()
                Do Until RS.EOF
                    intID = RS.Fields("ID").Value
                    dValue = ConvToNum(RS.Fields("Grain").Value)
                    MySQL = "UPDATE Gun_Collection_Ammo set dcal=" & dValue & " where ID=" & intID
                    Conn.Execute(MySQL)
                    RS.MoveNext()
                Loop
            End If
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("ConvertAmmoGrainsToNum", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Get the barrel ID from from the extended table, usually to add the default barrel tha tit listed in the main table.
    Function GetBarrelID(ByVal FirearmID As Long) As Long
        Dim lAns As Long = 0
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)

        Try
            Conn.Open()
            Dim SQL As String = "SELECT id from Gun_Collection_ext where GID=" & FirearmID & " and IsDefault=1"
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read()
                lAns = CLng(RS("id"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("GetBarrelID", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
        Return lAns
    End Function
    'Connect to the database and issue an SQL Statement
    Public Sub ConnExec(ByVal strSQL As String)
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)

        Try
            Conn.Open()
            Dim CMD As New OdbcCommand
            CMD.Connection = Conn
            CMD.CommandText = strSQL
            CMD.ExecuteNonQuery()
            CMD.Connection.Close()
            CMD = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("ConnExec", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Copy the barrel information form the main collection to t
    Sub CopyBarrelInformation()
        Dim Conn As ADODB.Connection
        Conn = New ADODB.Connection
        Try
            Dim RS As ADODB.Recordset
            RS = New ADODB.Recordset
            With Conn
                .Provider = "Microsoft.Jet.OLEDB.4.0"
                .ConnectionString = "Data Source=" & strDBPath
                .Mode = ADODB.ConnectModeEnum.adModeReadWrite
                .Properties("Jet OLEDB:Database Password").Value = DATABASEPASSWORD
                .Open()
            End With
            Dim SQL As String
            SQL = "SELECT * from Gun_Collection order by ID ASC"
            RS.Open(SQL, Conn, 1, 3)
            Dim SQL2 As String = ""
            Dim DBID As Long = 0
            Dim GID As Long = 0
            Dim isListed As Boolean = False
            Console.Write(vbTab)
            If Not RS.BOF And Not RS.EOF Then
                RS.MoveFirst()
                Do Until RS.EOF
                    GID = RS.Fields("ID").Value
                    If Not IsDBNull(RS.Fields("DBID").Value) Then
                        If CInt(RS.Fields("DBID").Value) <> 0 Then
                            isListed = True
                        Else
                            isListed = False
                        End If
                    Else
                        isListed = False
                    End If
                    If Not isListed Then
                        SQL2 = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,[Action]," & _
                            "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault) VALUES(" & _
                            GID & ",'Default Barrel','" & FluffContent(RS.Fields("Caliber").Value) & "','" & FluffContent(RS.Fields("Finish").Value) & "','" & FluffContent(RS.Fields("BarrelLength").Value) & _
                            "','" & FluffContent(RS.Fields("PetLoads").Value) & "','" & FluffContent(RS.Fields("Action").Value) & "','" & FluffContent(RS.Fields("Feedsystem").Value) & "','" & FluffContent(RS.Fields("Sights").Value) & "','" & _
                            FluffContent(RS.Fields("PurchasedPrice").Value) & "','" & FluffContent(RS.Fields("PurchasedFrom").Value) & "',DATE(),'" & FluffContent(RS.Fields("Height").Value) & "','" & FluffContent(RS.Fields("Type").Value) & _
                            "',1)"
                        Conn.Execute(SQL2)
                    End If
                    Console.Write(".")
                    System.Threading.Thread.Sleep(5000)
                    DBID = GetBarrelID(GID)
                    SQL2 = "UPDATE Gun_Collection set DBID=" & DBID & ", HasMB=0 where id=" & GID
                    Conn.Execute(SQL2)
                    SQL2 = "UPDATE Maintance_Details set BSID=" & DBID & " where GID=" & GID
                    Conn.Execute(SQL2)
                    SQL2 = "INSERT INTO Gun_Collection_Ext_Links(BSID,GID) VALUES(" & DBID & "," & GID & ")"
                    Conn.Execute(SQL2)
                    RS.MoveNext()
                Loop
            End If
            RS.Close()
            RS = Nothing
            Conn.Close()
        Catch ex As Exception
            Call DebugLog("CopyBarrelInformation", Err.Number & " - " & Err.Description, "ERROR")
            If Conn.State <> 0 Then Conn.Close()
        End Try
        Conn = Nothing
    End Sub
    'Save the current or new database version at the end of a hot fix
    Public Sub SaveDatabaseVersion(ByVal newVer As String)
        Try
            Dim SQL As String = "INSERT INTO DB_Version (dbver,dta) VALUES('" & _
                newVer & "',DATE())"
            Call ConnExec(SQL)
        Catch ex As Exception
            Call DebugLog("SaveDatabaseVersion", Err.Number & " - " & Err.Description, "ERROR")
        End Try
    End Sub
    'Get the last database version applied from teh database
    Public Function GetLastDatabaseUpdate() As String
        Dim sAns As String = "0"
        Dim Conn As OdbcConnection
        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};dbq=" & strDBPath & ";Pwd=" & DATABASEPASSWORD)
        Try
            Conn.Open()
            Dim SQL As String = "SELECT top 1 * from DB_Version order by ID desc"
            Dim CMD As New OdbcCommand(SQL, Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read()
                sAns = RS("dbver")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
        Catch ex As Exception
            Call DebugLog("GetLastDatabaseUpdate", Err.Number & " - " & Err.Description, "ERROR")
            sAns = 0
        End Try
        If Conn.State <> 0 Then Conn.Close()
        Conn = Nothing
        Return sAns
    End Function
    'Add the sync column to the selected table
    Public Sub AddSyncToTable(ByVal sNewTableName As String, Optional ByVal UpdateField As Boolean = False, Optional ByVal SyncTableName As String = "sync_tables")
        Try
            If Not ValueDoesExist(SyncTableName, "tblname", sNewTableName) Then Call ConnExec("INSERT INTO " & SyncTableName & " (tblname) VALUES('" & sNewTableName & "')")
            Call AddColumn("sync_lastupdate", sNewTableName, "Now()", "DATETIME")
            If UpdateField Then Call ConnExec("UPDATE " & sNewTableName & " set sync_lastupdate=Now()")
        Catch ex As Exception
            Call DebugLog("AddSyncToTable", Err.Number & " - " & Err.Description, "ERROR")
        End Try
    End Sub
End Module
