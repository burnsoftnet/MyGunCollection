Module modHotFixes
    Public HotFixApplied As Boolean
    Public Const MAX_HOTFIX = 9
    Sub ApplyregistryHotfixes(ByVal sNumber As String)
        'This Sub will apply the hotfixes from a starting number to the max hot fix
        'This is mostly used by the DoVersionCheck sub
        Dim i As Integer = 0
        'For i = 1 To CInt(sNumber)
        For i = (CInt(sNumber) + 1) To CInt(MAX_HOTFIX)
            Call RunSpecificHotFic(i)
        Next
        'We are skipping to the last hotfix for the database version, but it is maxing at the number to loop to, but nothing past it
        'Need to do everything after that number
        'Check to see what else uses this sub.
    End Sub
    Sub AppliedregistryHotfixes(ByVal sNumber As String)
        'This Sub will apply the previous versions of the hotfix in registry since they should already exist in the database
        'This is mostly used by the DoVersionCheck sub
        Dim i As Integer = 0
        For i = 1 To CInt(sNumber)
            If Not HotFixExists(i) Then Call UpdateLastUpdate(i)
            Call AppliedUpdates(i)
        Next
        'We are skipping to the last hotfix for the database version, but it is maxing at the number to loop to, but nothing past it
        'Need to do everything after that number
        'Check to see what else uses this sub.
    End Sub
    Public Sub DoVersioncheck()
        Dim CurVer As String = GetLastDatabaseUpdate()
        Console.WriteLine("Current database Version: " & CurVer)
        Dim DoToVersion As Integer = 0
        Select Case CurVer
            Case "4.5"
                DoToVersion = 7
                AppliedregistryHotfixes(DoToVersion)
                Console.WriteLine("Last Database hotfix was " & DoToVersion & " for this database, appling hotfixes after this version.")
                ApplyregistryHotfixes(DoToVersion)
            Case "5.0"
                DoToVersion = 8
                AppliedregistryHotfixes(DoToVersion)
                Console.WriteLine("Last Database hotfix was " & DoToVersion & " for this database, appling hotfixes after this version.")
                ApplyregistryHotfixes(DoToVersion)
            Case "6.0"
                'Database Version was jumped to match the current version of the application
                'technically true, but was different since we started late in this.
                DoToVersion = 9
                AppliedregistryHotfixes(DoToVersion)
                Console.WriteLine("Last Database hotfix was " & DoToVersion & " for this database, appling hotfixes after this version.")
                ApplyregistryHotfixes(DoToVersion)
        End Select
    End Sub
    Public Sub RunSpecificHotFic(iFix As Integer)
        Select Case iFix
            Case 1
                Call HotFix_1()
            Case 2
                Call HotFix_2()
            Case 3
                Call HotFix_3()
            Case 4
                Call HotFix_4()
            Case 5
                Call HotFix_5()
            Case 6
                Call HotFix_6()
            Case 7
                Call HotFix_7()
            Case 8
                Call HotFix_8()
            Case 9
                Call HotFix_9()
        End Select
    End Sub
    Public Sub DoUpdates()
        Call DoVersioncheck()
        If Not HotFixExists("1") Then Call HotFix_1()
        If Not HotFixExists("2") Then Call HotFix_2()
        If Not HotFixExists("3") Then Call HotFix_3()
        If Not HotFixExists("4") Then Call HotFix_4()
        If Not HotFixExists("5") Then Call HotFix_5()
        If Not HotFixExists("6") Then Call HotFix_6()
        If Not HotFixExists("7") Then Call HotFix_7()
        If Not HotFixExists("8") Then Call HotFix_8()
        If Not HotFixExists("9") Then Call HotFix_9()
    End Sub
    Sub RedoAll()
        Call DelRegValue("HotFix", "1", "")
        Call DelRegValue("HotFix", "2", "")
        Call DelRegValue("HotFix", "3", "")
        Call DelRegValue("HotFix", "4", "")
        Call DelRegValue("HotFix", "5", "")
        Call DelRegValue("HotFix", "6", "")
        Call DelRegValue("HotFix", "7", "")
        Call DelRegValue("HotFix", "8", "")
        Call DelRegValue("HotFix", "9", "")
        Call DelRegValue("HotFix", "LastUpdate", "")
    End Sub
    Sub HotFix_1()
        Dim strUpdateName As String
        strUpdateName = "1"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        Call AddPassword()
        Call AddColumn("PetLoads", "Gun_Collection", "' '", "TEXT(255)")
        Call AddColumn("dtp", "Gun_Collection", "' '", "DATE")
        Call RunSQL("Update Gun_Collection set PetLoads=' '")
        Call AddColumn("IsCandR", "Gun_Collection", "0", "Number")
        'End Updates
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_2()
        Dim strUpdateName As String
        strUpdateName = "2"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        If Not ValueDoesExist("Gun_Cal", "Cal", "10 Gauge") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('10 Gauge')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", "12 Gauge") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('12 Gauge')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", "16 Gauge") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('16 Gauge')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", "20 Gauge") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('20 Gauge')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", "28 Gauge") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('28 Gauge')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", ".410 Gauge") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('.410 Gauge')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Black Powder") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Black Powder')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Semi-Auto Pistol") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Semi-Auto Pistol')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Semi-Auto") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Semi-Auto')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Single Action") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Single Action')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Slide Action") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Slide Action')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Commemorative") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Commemorative')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Fixed Barrel") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Fixed Barrel')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Flintlock") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Flintlock')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Derringer") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Derringer')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Pistol: Bolt Action") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Pistol: Bolt Action')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Pistol: Semi-Auto - SA/DA") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Pistol: Semi-Auto - SA/DA')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Pistol: Semi-Auto - SA Only") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Pistol: Semi-Auto - SA Only')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Pistol: Semi-Auto - DAO") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Pistol: Semi-Auto - DAO')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Pistol: Single Shot") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Pistol: Single Shot')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Pistol: Misc") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Pistol: Misc')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Revolver: SA/DA") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Revolver: SA/DA')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Revolver: SA only") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Revolver: SA only')"))
        If Not ValueDoesExist("Gun_Type", "Type", "Revolver: Misc") Then RunSQL(("INSERT INTO Gun_Type (Type) VALUES('Revolver: Misc')"))
        Call SwapGunColPurchaseValues("Gun_Collection", "dt", "dtp")
        'End Updates
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_3()
        Dim strUpdateName As String
        strUpdateName = "3"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        Call AddColumn("ISMAIN", "Gun_Collection_Pictures", "0", "Number")
        RunSQL(("UPDATE Gun_Collection_Pictures set ISMAIN=0 where ISMAIN <> 1"))
        Call SetMainPictures()
        'End Updates
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_4()
        Dim strUpdateName As String
        strUpdateName = "4"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!

        Call SaveRegValue("Settings", "BackupOnExit", "False")
        Call AddColumn("Importer", "Gun_Collection", "N/A", "Text(255)")
        Call DropTable("Gun_Collection_Ammo_Details")
        Call DropTable("Gun_Collection_Ammo_Details_Pictures")
        Call DropTable("Gun_Shop_SalesEmp")
        If Not ValueDoesExist("Gun_Cal", "Cal", ".223 Remington") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('.223 Remington')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", "5.56 x 45mm") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('5.56 x 45mm')"))
        If Not ValueDoesExist("Gun_Cal", "Cal", ".30-06") Then RunSQL(("INSERT INTO Gun_Cal (Cal) VALUES('.30-06')"))
        Call SaveRegValue("Settings", "UseOrgImage", "False")
        Call SaveRegValue("Settings", "ViewPetLoads", "True")
        Call SaveRegValue("Settings", "IndvReports", "True")
        Call AddColumn("UID", "Owner_Info", "N/A", "Memo")
        Call AddColumn("forgot_word", "Owner_Info", "N/A", "Memo")
        Call AddColumn("forgot_phrase", "Owner_Info", "N/A", "Memo")
        Call AddColumn("dcal", "Gun_Collection_Ammo", "N/A", "number")
        Call ConvertAmmoGrainsToNum()
        'End Updates
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_5()
        Dim strUpdateName As String
        strUpdateName = "5"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        Dim SQL As String
        SQL = "CREATE TABLE CR_ColumnList (ID AUTOINCREMENT PRIMARY KEY,TID INTEGER, Col Text(255), DN Text(255));"
        Call RunSQL(SQL)
        SQL = "CREATE TABLE CR_SavedReports (ID AUTOINCREMENT PRIMARY KEY,ReportName Text(255), MySQL MEMO,DTC DATETIME);"
        Call RunSQL(SQL)
        SQL = "CREATE TABLE CR_TableList (ID INTEGER PRIMARY KEY,Tables Text(255), DN Text(255));"
        Call RunSQL(SQL)
        Call RunSQL("DELETE from CR_ColumnList")
        Call RunSQL("DELETE from CR_TableList")
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (1,'Gun_Cal','Caliber List')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (2,'Gun_Collection_Ammo','Ammunition Inventory')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (3,'Gun_Manufacturer','Manufacturer List')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (4,'qryGunCollectionDetails','Gun Collection')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (5,'Gun_Shop_Details','Firearm Stores')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (6,'Gun_Collection_SoldTo','Buyer List')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_TableList (ID,Tables,DN) VALUES (7,'Wishlist','Wishlist')"
        Call RunSQL(SQL)
        'Call RunSQL("INSERT INTO CR_TableList (ID,Tables,DN) VALUES ('','')")
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(1,'Cal','Caliber')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(2,'Manufacturer','Manufacturer')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(2,'Name','Name')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(2,'Cal','Caliber')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(2,'Grain','Bullet Grains')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(2,'Jacket','Jacket')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(2,'Qty','Qty')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(3,'Brand','Name')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'FullName','Full Name')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'ModelName','Model Name')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'SerialNumber','Serial Number')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Type','Firearm Type')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Caliber','Caliber')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Finish','Finish')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Condition','Condition')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'CustomID','Custom ID')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'NatID','Place of Origin')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Weight','Weight')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Height','Height')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'StockType','Stock')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'BarrelLength','Barrel Length')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Action','Action')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'FeedSystem','Feed System')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Sights','Sights')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'PurchasedPrice','Purchased Price')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'PurchasedFrom','Purchased From')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'AppraisedValue','Appraised Value')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'AppraisedDate','Appraised Date')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'AppraisedBy','Appraised By')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'InsuredValue','Insured Value')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'StorageLocation','Storage Location')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Produced','Produced Date')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Dt','Date Added')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'dtSold','Date Sold')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'dtp','Date Purchased')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Importer','Importer')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'Brand','Manufacturer')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'Name','Name')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'Address1','Address')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'Address2','Address 2')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'City','City')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'State','State')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'Zip','Zip Code')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'Country','Country')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'Phone','Phone')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'fax','fax')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'website','website')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'email','email')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(5,'lic','FFL License')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Name','Name')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Address1','Address')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Address2','Address 2')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'City','City')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'State','State')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Country','Country')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Phone','Phone')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'fax','fax')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'website','website')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'email','email')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'lic','FFL/CCL')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'DOB','Date of Birth')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Dlic','Drivers License')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'Resident','Resident')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'ZipCode','Zip Code')"
        Call RunSQL(SQL)
        Call RunSQL("INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(7,'Manufacturer','Manufacturer')")
        Call RunSQL("INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(7,'Model','Model')")
        Call RunSQL("INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(7,'PlacetoBuy','Place to Buy')")
        Call RunSQL("INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(7,'Qty','Qty')")
        Call RunSQL("INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(7,'Value','Price')")
        If FileExists(CurPath & "\BSApplicationUpdater.exe.new") Then
            Call DeleteFile("BSApplicationUpdater.exe")
            Call RenameFile("BSApplicationUpdater.exe.new", "BSApplicationUpdater.exe")
        End If
        If FileExists(CurPath & "\BSApplicationUpdater.XmlSerializers.dll.new") Then
            Call DeleteFile("BSApplicationUpdater.XmlSerializers.dll")
            Call RenameFile("BSApplicationUpdater.XmlSerializers.dll.new", "BSApplicationUpdater.XmlSerializers.dll")
        End If

        'Call RunSQL("INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(6,'','')")
        'End Updates
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_6()
        Dim strUpdateName As String
        strUpdateName = "6"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        Dim SQL As String
        SQL = "CREATE TABLE Gun_Collection_Ammo_PriceAudit (ID AUTOINCREMENT PRIMARY KEY,AID INTEGER,DTA DATETIME,Qty INTEGER,PricePaid DOUBLE,PPB DOUBLE);"
        Call RunSQL(SQL)
        Call AddColumn("ReManDT", "Gun_Collection", "N/A", "DATETIME")
        Call AddColumn("POI", "Gun_Collection", "N/A", "Text(255)")
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'ReManDT','Remanufacture Date')"
        Call RunSQL(SQL)
        SQL = "INSERT INTO CR_ColumnList(TID,Col,DN) VALUES(4,'POI','Place Of Import')"
        Call RunSQL(SQL)
        If FileExists(CurPath & "\BSApplicationUpdater.exe.new") Then
            Call DeleteFile("BSApplicationUpdater.exe")
            Call RenameFile("BSApplicationUpdater.exe.new", "BSApplicationUpdater.exe")
        End If
        If FileExists(CurPath & "\BSApplicationUpdater.XmlSerializers.dll.new") Then
            Call DeleteFile("BSApplicationUpdater.XmlSerializers.dll")
            Call RenameFile("BSApplicationUpdater.XmlSerializers.dll.new", "BSApplicationUpdater.XmlSerializers.dll")
        End If

        If FileExists(CurPath & "\srh.bat") Then
            Call DeleteFile("srh.bat")
        End If
        'End Updates
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_7()
        Dim strUpdateName As String
        strUpdateName = "7"
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        'FINISH HOTFIX_7 for Next Release works as of 3/17/2011
        Dim DBVersion As String = "4.5"
        Dim sValue As String = ""
        Console.WriteLine("Applying Hotfix_" & strUpdateName)
        Dim SQL As String
        Console.WriteLine(vbTab & "Updating Maintenance Table")
        Call AddColumn("au", "Maintance_Details", "N/A", "Text(255)")
        SQL = "SELECT Gun_Collection.FullName, Maintance_Details.Name, Maintance_Details.OpDate, Maintance_Details.OpDueDate, Maintance_Details.RndFired, Maintance_Details.Notes, Maintance_Details.gid,Maintance_Details.au, Maintance_Details.id " & _
                "FROM Maintance_Details INNER JOIN Gun_Collection ON Maintance_Details.gid = Gun_Collection.ID;"

        Console.WriteLine(vbTab & "Altering Gun Maintenance View")
        Call DropView("gryGunMaintance")
        Call CreateView("gryGunMaintance", SQL)
        Console.WriteLine(vbTab & "Updating Pictures Table")
        Call AddColumn("thumb", "Gun_Collection_Pictures", "N/A", "OLEOBJECT")
        Call AddColumn("pd_name", "Gun_Collection_Pictures", "N/A", "Text(255)")
        Call AddColumn("pd_note", "Gun_Collection_Pictures", "N/A", "Text(255)")
        Console.WriteLine(vbTab & "Creating Thumbnails for Current Pictures")
        Call ConvertPicsHF()
        Console.WriteLine(vbTab & "Updating Accessories Tables")
        Call AddColumn("AppValue", "Gun_Collection_Accessories", "0", "DOUBLE")
        Call AddColumn("CIV", "Gun_Collection_Accessories", "0", "INTEGER")
        Call AddColumn("IC", "Gun_Collection_Accessories", "0", "INTEGER")
        SQL = "UPDATE Gun_Collection_Accessories Set AppValue=0.00, CIV=0, IC=0"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Updating Ammunition Tables")
        Call AddColumn("vel_t", "Gun_Collection_Ammo", "N/A", "Text(255)")
        Call AddColumn("vel_n", "Gun_Collection_Ammo", "N/A", "number")
        Call AddColumn("store", "Gun_Collection_Ammo_PriceAudit", "N/A", "Text(255)")
        SQL = "UPDATE Gun_Collection_Ammo set vel_n=0"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Updating Gun Collection Table")
        Call AddColumn("HasMB", "Gun_Collection", "0", "number")
        Call AddColumn("DBID", "Gun_Collection", "0", "number")
        Call AddColumn("SGChoke", "Gun_Collection", "N/A", "Text(255)")
        SQL = "UPDATE Gun_Collection set DBID=0 and HasMB=0"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Creating Gun Collection Extras Table.")
        SQL = "CREATE TABLE Gun_Collection_Ext (ID AUTOINCREMENT PRIMARY KEY,GID INTEGER,ModelName TEXT(255)," & _
                "Caliber TEXT(255),Finish TEXT(255),BarrelLength TEXT(255),PetLoads TEXT(255)," & _
                "[Action] TEXT(255),Feedsystem TEXT(255),Sights TEXT(255),PurchasedPrice TEXT(255)," & _
                "PurchasedFrom TEXT(255),dtp DATETIME,Height TEXT(255),Type TEXT(255),IsDefault INTEGER);"
        Call RunSQL(SQL)
        SQL = "CREATE TABLE Gun_Collection_Ext_Links (BSID INTEGER, GID INTEGER);"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Creating Database Version Table.")
        SQL = "CREATE TABLE DB_Version(ID AUTOINCREMENT PRIMARY KEY,dbver TEXT(255),dta DATETIME);"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Updating Maintanence Tables")
        Call AddColumn("BSID", "Maintance_Details", "N/A", "number")
        Call AddColumn("DC", "Maintance_Details", "N/A", "number")
        SQL = "UPDATE Maintance_Details set DC=1"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Adding information to Gun Collection Extras Table.")
        Call CopyBarrelInformation()
        Console.WriteLine(vbTab & "Creating Gun Collection Conditions Table.")
        SQL = "CREATE TABLE Gun_Collection_Condition (ID AUTOINCREMENT PRIMARY KEY, [Name] TEXT(255));"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Inserting Data into the Gun Collection Conditions Table.")
        sValue = "New"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.WriteLine(".")
        sValue = "New, Discontinued"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Perfect"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Perfect, Discontinued"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Excellent"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Excellent, Discontinued"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Very Good"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Good"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Good, Discontinued"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Fair"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Poor"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Factory New"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Excellent"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Fine"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Very Good"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Good"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Fair"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Antique Poor"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Refinished"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "100%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "98%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "95%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "90%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "80%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "70%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "60%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "50%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "40%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "30%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "20%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "10%"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Broken"
        If Not ValueDoesExist("Gun_Collection_Condition", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_Condition ([Name]) VALUES('" & sValue & "')"))
        Console.Write("FINISHED")
        Console.WriteLine(vbTab & "Creating Barrel System Types Table.")
        SQL = "CREATE TABLE Gun_Collection_BarrelSysTypes (ID AUTOINCREMENT PRIMARY KEY, [Name] TEXT(255));"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Inserting Data into the Barrel System Types Table.")
        sValue = "Regular Barrel"
        If Not ValueDoesExist("Gun_Collection_BarrelSysTypes", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_BarrelSysTypes ([Name]) VALUES('" & sValue & "')"))
        Console.WriteLine(".")
        sValue = "Ported Barrel"
        If Not ValueDoesExist("Gun_Collection_BarrelSysTypes", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_BarrelSysTypes ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Threaded Barrel"
        If Not ValueDoesExist("Gun_Collection_BarrelSysTypes", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_BarrelSysTypes ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Complete Upper"
        If Not ValueDoesExist("Gun_Collection_BarrelSysTypes", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_BarrelSysTypes ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        sValue = "Conversion Kit"
        If Not ValueDoesExist("Gun_Collection_BarrelSysTypes", "[Name]", sValue) Then Call ConnExec(("INSERT INTO Gun_Collection_BarrelSysTypes ([Name]) VALUES('" & sValue & "')"))
        Console.Write(".")
        'End Updates
        'last update 3/17/2011
        If Not ValueDoesExist("DB_Version", "dbver", DBVersion) Then
            Call SaveDatabaseVersion(DBVersion)
            Console.WriteLine(vbTab & "You are now updated to Database Version " & DBVersion)
        End If
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_8()
        Dim strUpdateName As String
        strUpdateName = "8"
        'This Hotfix is to create the ablity to sync the database if you have more then one computer
        Dim DBVersion As String = "5.0"
        Dim DBVerHasChanged As Boolean = True
        Dim sValue As String = ""
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        Dim SQL As String = ""
        Console.WriteLine(vbTab & "Creating Sync Tables Tables")
        Sql = "CREATE TABLE sync_tables(ID AUTOINCREMENT PRIMARY KEY,tblname TEXT(255));"
        Call RunSQL(SQL)
        Call AddSyncToTable("CR_SavedReports", True)
        Call AddSyncToTable("GunSmith_Details", True)
        Call AddSyncToTable("Gun_Cal", True)
        Call AddSyncToTable("Gun_Collection", True)
        Call AddSyncToTable("Gun_Collection_Accessories", True)
        Call AddSyncToTable("Gun_Collection_Ammo", True)
        Call AddSyncToTable("Gun_Collection_Ammo_PriceAudit", True)
        Call AddSyncToTable("Gun_Collection_BarrelSysTypes", True)
        Call AddSyncToTable("Gun_Collection_Condition", True)
        Call AddSyncToTable("Gun_Collection_Ext", True)
        Call AddSyncToTable("Gun_Collection_Ext_Links", True)
        Call AddSyncToTable("Gun_Collection_Pictures", True)
        Call AddSyncToTable("Gun_Collection_SoldTo", True)
        Call AddSyncToTable("Gun_GripType", True)
        Call AddSyncToTable("Gun_Manufacturer", True)
        Call AddSyncToTable("Gun_Model", True)
        Call AddSyncToTable("Gun_Nationality", True)
        Call AddSyncToTable("Gun_Shop_Details", True)
        Call AddSyncToTable("Gun_Type", True)
        Call AddSyncToTable("Maintance_Details", True)
        Call AddSyncToTable("Maintance_Plans", True)
        Call AddSyncToTable("Owner_Info", True)
        Call AddSyncToTable("Wishlist", True)
        'End Updates
        If DBVerHasChanged Then Call SaveDatabaseVersion(DBVersion)
        If DBVerHasChanged Then Console.WriteLine(vbTab & "You are now updated to Database Version " & DBVersion)
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
    Sub HotFix_9()
        Dim strUpdateName As String
        strUpdateName = "9"
        Dim DBVersion As String = "6.0"
        Dim DBVerHasChanged As Boolean = True
        Call DebugLog("HotFix_" & strUpdateName, "Starting HotFix " & strUpdateName)
        'INSERT UPDATES HERE!!
        Dim SQL As String = ""
        Console.WriteLine(vbTab & "Updating Column List")
        SQL = "UPDATE CR_ColumnList set Col='AppraisalDate' where Col='AppraisedDate'"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Adding Columns to Gun Collection Table")
        Call AddColumn("IsInBoundBook", "Gun_Collection", "N/A", "number")
        Call AddColumn("TwistRate", "Gun_Collection", "N/A", "Text(255)")
        Call AddColumn("lbs_trigger", "Gun_Collection", "N/A", "Text(255)")
        Call AddColumn("Caliber3", "Gun_Collection", "N/A", "Text(255)")
        Call AddColumn("Classification", "Gun_Collection", "N/A", "Text(255)")
        Call AddColumn("DateofCR", "Gun_Collection", "N/A", "DATETIME")
        SQL = "UPDATE Gun_Collection set IsInBoundBook=1"
        Call RunSQL(SQL)
        Console.WriteLine(vbTab & "Creating Appraiser Contact Details Table")
        SQL = "CREATE TABLE Appriaser_Contact_Details (ID AUTOINCREMENT PRIMARY KEY,aName Text(255), Address1 Text(255)" & _
                ", Address2 Text(255),City Text(255),State Text(255), Country Text(255), Phone Text(255), fax Text(255)" & _
                ",website Text(255), email Text(255), lic Text(255), zip Text(255), SIB INTEGER);"
        Call RunSQL(SQL)
        Call AddSyncToTable("Appriaser_Contact_Details", True)
        Console.WriteLine(vbTab & "Creating GunSmith Contact Details Table")
        SQL = "CREATE TABLE GunSmith_Contact_Details (ID AUTOINCREMENT PRIMARY KEY,gName Text(255), Address1 Text(255)" & _
               ", Address2 Text(255),City Text(255),State Text(255), Country Text(255), Phone Text(255), fax Text(255)" & _
               ",website Text(255), email Text(255), lic Text(255), zip Text(255), SIB INTEGER);"
        Call RunSQL(SQL)
        Call AddSyncToTable("GunSmith_Contact_Details", True)
        Console.WriteLine(vbTab & "Copying Distinct Appraisers to new table.")
        Call MoveAppraisers()
        Console.WriteLine(vbTab & "Copying Distinct GunSmiths to new table.")
        Call MoveGunSmiths()
        Console.WriteLine(vbTab & "Creating Documents Tables")
        SQL = "CREATE TABLE Gun_Collection_Docs (ID AUTOINCREMENT PRIMARY KEY,doc_name Text(255), doc_description Text(255)" & _
               ", doc_filename Text(255),dta (DATETIME),doc_file OLEOBJECT, doc_thumb OLEOBJECT)"
        Call RunSQL(SQL)
        Call AddSyncToTable("Gun_Collection_Docs", True)
        SQL = "CREATE TABLE Gun_Collection_Docs_Links (ID AUTOINCREMENT PRIMARY KEY,DID INTEGER, GID INTEGER,dta (DATETIME)"
        Call RunSQL(SQL)
        Call AddSyncToTable("Gun_Collection_Docs_Links", True)
        SQL = "CREATE TABLE Gun_Collection_Classification (ID AUTOINCREMENT PRIMARY KEY,myclass Text(255))"
        Call RunSQL(SQL)
        Call RunSQL("INSERT INTO Gun_Collection_Classification (myclass) VALUES('Antique')")
        Call RunSQL("INSERT INTO Gun_Collection_Classification (myclass) VALUES('C&R')")
        Call RunSQL("INSERT INTO Gun_Collection_Classification (myclass) VALUES('Modern')")

        Call AddSyncToTable("Gun_Collection_Classification", True)
        'End Updates
        If DBVerHasChanged Then Call SaveDatabaseVersion(DBVersion)
        If DBVerHasChanged Then Console.WriteLine(vbTab & "You are now updated to Database Version " & DBVersion)
        Call UpdateLastUpdate(strUpdateName)
        Call AppliedUpdates(strUpdateName)
        Console.WriteLine("HotFix_" & strUpdateName & " was applied!")
        HotFixApplied = True
    End Sub
End Module
