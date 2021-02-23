Imports System.Data.Odbc
Imports System.IO
Imports System.Xml
Imports System.Data
Imports BSMyGunCollection.MGC
Public Class frmImportFirearm
    Public DefaultBarrelID As Long
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Try
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.Filter = "XML File(*.xml)|*.xml"
            OpenFileDialog1.Title = "Import Firearm from XML"
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = OpenFileDialog1.FileName
            lblFile.Text = strFilePath
            If Len(strFilePath) > 0 Then btnImport.Enabled = True
        Catch ex As Exception
            Dim sSubFunc As String = "btnOpen.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Function GetXMLNode(ByVal instance As XmlNode) As String
        Dim sAns As String = ""
        On Error Resume Next
        sAns = instance.InnerText
        Return sAns
    End Function
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Call ProcessXMLToDB(lblFile.Text)
    End Sub
    Sub UpdateStatusLabel(ByVal sValue As String)
        lblProg.Text = sValue
        lblProg.Refresh()
    End Sub
    Sub UpdateProgressBar(ByVal iValue As Long)
        ProgressBar1.Value = iValue
        ProgressBar1.Refresh()
    End Sub
    Sub ProcessXMLToDB(ByVal strPath As String)
        Try
            Dim FullName As String = ""
            Dim FirearmID As Long = 0
            Dim ObjGF As New GlobalFunctions
            Dim Obj As New BSDatabase
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 5
            Me.UseWaitCursor = True
            Dim I As Integer = 0

            I += 1
            Call UpdateStatusLabel("Getting Firearm Details")
            Call ProcessXMLToDB_Details(strPath, "Details", FullName, FirearmID)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Accessories List")
            Call ProcessXMLToDB_Accessories(strPath, "Accessories", FirearmID)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Maintance Details")
            Call ProcessXMLToDB_Maintance_Details(strPath, "Maintance_Details", FirearmID)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting GunSmith Details")
            Call ProcessXMLToDB_GunSmith_Details(strPath, "GunSmith_Details", FirearmID)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Barrel/Conversion Kit details")
            Call ProcessXMLToDB_BarrelConverstionKit_Details(strPath, "BarrelConverstionKit_Details", FirearmID)
            Call UpdateProgressBar(I)
            Me.UseWaitCursor = False
            MsgBox("Import of the " & FullName & " firearm is complete!")
            MDIParent1.RefreshCollection()
            Me.Close()

        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
            Me.UseWaitCursor = False
        End Try
    End Sub
    Sub ProcessXMLToDB_Details(ByVal strPath As String, ByVal strNodeName As String, ByRef FullName As String, ByRef FirearmID As Long)
        Try
            Dim doc As New XmlDocument
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim i As Integer = 0
            Dim SQL As String = ""
            Dim Manufacturer As String = ""
            Dim ModelName As String = ""
            Dim SerialNumber As String = ""
            Dim sType As String = ""
            Dim Caliber As String = ""
            Dim Finish As String = ""
            Dim Condition As String = ""
            Dim CustomID As String = ""
            Dim NatID As String = ""
            Dim GripID As String = ""
            Dim Weight As String = ""
            Dim Height As String = ""
            Dim BarrelLength As String = ""
            Dim Action As String = ""
            Dim Feedsystem As String = ""
            Dim Sights As String = ""
            Dim PurchasedPrice As String = ""
            Dim PurchasedFrom As String = ""
            Dim AppraisedValue As String = ""
            Dim AppraisalDate As String = ""
            Dim AppraisedBy As String = ""
            Dim InsuredValue As String = ""
            Dim StorageLocation As String = ""
            Dim ConditionComments As String = ""
            Dim AdditionalNotes As String = ""
            Dim SGChoke As String = ""
            Dim Produced As String = ""
            Dim IsCandR As String = ""
            Dim PetLoads As String = ""
            Dim dtp As String = ""
            Dim Importer As String = ""
            Dim ReManDT As String = ""
            Dim POI As String = ""
            Dim ManID As Long = 0
            Dim ModID As Long = 0
            Dim lGripID As Long = 0
            Dim lNatID As Long = 0
            Dim BID As Long = 0
            Dim lIsCandR As Long = 0
            Dim iBoundBook As Long = 0
            Dim bBoundBook As Boolean = False
            Dim sTwist As String = ""
            Dim sTrigger As String = ""
            Dim sCaliber3 As String = ""
            Dim sClassification As String = ""
            Dim sDateOfCR As String = ""

            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                FullName = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("FullName")))
                Manufacturer = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Manufacturer")))
                ModelName = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("ModelName")))
                SerialNumber = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("SerialNumber")))
                sType = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Type")))
                Caliber = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Caliber")))
                Finish = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Finish")))
                Condition = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Condition")))
                CustomID = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("CustomID")))
                NatID = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("NatID")))
                GripID = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("GripID")))
                Weight = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Weight")))
                Height = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Height")))
                BarrelLength = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("BarrelLength")))
                Action = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Action")))
                Feedsystem = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Feedsystem")))
                Sights = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Sights")))
                PurchasedPrice = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PurchasedPrice")))
                PurchasedFrom = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PurchasedFrom")))
                AppraisedValue = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("AppraisedValue")))
                AppraisalDate = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("AppraisalDate")))
                AppraisedBy = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("AppraisedBy")))
                InsuredValue = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("InsuredValue")))
                SGChoke = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("SGChoke")))
                StorageLocation = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("StorageLocation")))
                ConditionComments = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("ConditionComments")))
                AdditionalNotes = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("AdditionalNotes ")))
                Produced = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Produced")))
                IsCandR = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("IsCandR")))
                PetLoads = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PetLoads")))
                dtp = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("dtp")))
                Importer = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Importer")))
                ReManDT = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("ReManDT")))
                bBoundBook = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("BoundBook")))
                sCaliber3 = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Caliber3")))
                sTwist = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("TwistOfRate")))
                sTrigger = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("TriggerPull")))
                sClassification = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Classification")))
                sDateOfCR = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("DateofCR")))
                If CBool(bBoundBook) Then iBoundBook = 1
                POI = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("POI")))
                ManID = ObjGF.GetManufacturersID(Manufacturer)
                ModID = ObjGF.GetModelID(ModelName, ManID)
                lGripID = ObjGF.GetGripID(GripID)
                lNatID = ObjGF.GetNationalityID(NatID)
                Call ObjGF.UpdateGunType(sType)
                If CBool(IsCandR) Then lIsCandR = 1
                SQL = "INSERT INTO Gun_Collection(OID,MID,FullName,ModelName,ModelID,SerialNumber,Type,Caliber,Finish,Condition," & _
                        "CustomID,NatID,GripID,Qty,Weight,Height,StockType,BarrelLength,BarrelWidth,BarrelHeight," & _
                        "Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,AppraisedValue,AppraisalDate,AppraisedBy," & _
                        "InsuredValue,StorageLocation,ConditionComments,AdditionalNotes,Produced,PetLoads,dtp,IsCandR,Importer," & _
                        "ReManDT,POI,SGChoke,sync_lastupdate) VALUES(" & _
                        OwnerID & "," & ManID & ",'" & FullName & "','" & ModelName & "'," & ModID & ",'" & SerialNumber & "','" & _
                        sType & "','" & Caliber & "','" & Finish & "','" & Condition & "'," & ObjGF.SetCatalogINSType(CustomID) & "," & _
                        lNatID & "," & lGripID & ",1,'" & Weight & "','" & Height & "','" & _
                        GripID & "','" & BarrelLength & "',' ',' ','" & Action & "','" & _
                        Feedsystem & "','" & Sights & "','" & PurchasedPrice & "','" & PurchasedFrom & "','" & AppraisedValue & "','" & _
                        AppraisalDate & "','" & AppraisedBy & "','" & InsuredValue & "','" & StorageLocation & "','" & ConditionComments & "','" & AdditionalNotes & _
                        "','" & Produced & "','" & PetLoads & "','" & dtp & "'," & lIsCandR & ",'" & Importer & _
                        "','" & ReManDT & "','" & POI & "','" & SGChoke & "',Now())"
                Obj.ConnExec(SQL)
                FirearmID = ObjGF.GetLastFirearmID
                SQL = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,Action," & _
                    "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" & _
                    FirearmID & ",'Default Barrel','" & Caliber & "','" & Finish & "','" & BarrelLength & _
                    "','" & PetLoads & "','" & Action & "','" & Feedsystem & "','" & Sights & "','" & _
                    "0.00','" & PurchasedFrom & "',DATE(),'" & Height & "','Fixed Barrel" & _
                    "',1,Now())"
                Obj.ConnExec(SQL)
                BID = ObjGF.GetBarrelID(FirearmID, 1)
                DefaultBarrelID = BID
                SQL = "UPDATE Gun_Collection set DBID=" & BID & " where ID=" & FirearmID
                Obj.ConnExec(SQL)
                SQL = "INSERT INTO Gun_Collection_Ext_Links (BSID,GID,sync_lastupdate) VALUES(" & BID & "," & FirearmID & ",Now())"
                Obj.ConnExec(SQL)
                If Len(Trim(PurchasedFrom)) <> 0 Then
                    Dim ObjG As New GlobalFunctions
                    If Not ObjG.ObjectExistsinDB(PurchasedFrom, "Name", "Gun_Shop_Details") Then
                        SQL = "INSERT INTO Gun_Shop_Details(Name,Address1,City,State,Zip,sync_lastupdate) VALUES('" & PurchasedFrom & "','N/A','N/A','N/A','N/A',Now())"
                        Obj.ConnExec(SQL)
                    End If
                    Dim GSID As Long = ObjGF.GetGunShopID(PurchasedFrom)
                    SQL = "UPDATE Gun_Collection set SID=" & GSID & " where ID=" & FirearmID
                    Obj.ConnExec(SQL)
                End If
                If Not ObjGF.CaliberExists(Caliber) Then Obj.ConnExec("INSERT INTO Gun_Cal (Cal,sync_lastupdate) VALUES('" & Caliber & "',Now())")
                MDIParent1.RefreshCollection()
            Next
            elemlist = Nothing
            doc = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_Details"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmImportFirearm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblProg.Text = ""
        lblFile.Text = ""
    End Sub
    Sub ProcessXMLToDB_Accessories(ByVal strPath As String, ByVal strNodeName As String, ByVal FirearmID As Long)
        Try
            Dim doc As New XmlDocument
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim i As Integer = 0
            Dim SQL As String = ""
            Dim Manufacturer As String = ""
            Dim Model As String = ""
            Dim SerialNumber As String = ""
            Dim Condition As String = ""
            Dim Notes As String = ""
            Dim Use As String = ""
            Dim PurValue As String = ""
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                Manufacturer = Trim(ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Manufacturer"))))
                If Len(Manufacturer) > 0 Then
                    Model = Trim(ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Model"))))
                    SerialNumber = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("SerialNumber")))
                    Condition = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Condition")))
                    Notes = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Notes")))
                    Use = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Use")))
                    PurValue = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PurValue")))

                    SQL = "INSERT INTO Gun_Collection_Accessories(GID,Manufacturer,Model,SerialNumber,Condition,Notes,Use,PurValue,sync_lastupdate) VALUES(" & _
                            FirearmID & ",'" & Manufacturer & "','" & Model & "','" & SerialNumber & "','" & Condition & "','" & _
                            Notes & "','" & Use & "','" & PurValue & "',Now())"
                    Obj.ConnExec(SQL)
                End If
            Next
            elemlist = Nothing
            doc = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_Accessories"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub ProcessXMLToDB_Maintance_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal FirearmID As Long)
        Try
            Dim doc As New XmlDocument
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim i As Integer = 0
            Dim MPID As Long = 0
            Dim SQL As String = ""
            Dim Name As String = ""
            Dim OpDate As String = ""
            Dim OpDueDate As String = ""
            Dim RndFired As String = ""
            Dim Notes As String = ""
            Dim CountInTotal As Integer = 0
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                Name = Trim(ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Name"))))
                If Len(Name) > 0 Then
                    OpDate = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("OpDate")))
                    OpDueDate = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("OpDueDate")))
                    RndFired = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("RndFired")))
                    If CLng(RndFired) > 0 Then
                        CountInTotal = 1
                    Else
                        CountInTotal = 0
                    End If
                    Notes = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Notes")))
                    MPID = ObjGF.GetID("SELECT ID from Maintance_Plans where Name='" & Name & "'")
                    SQL = "INSERT INTO Maintance_Details(gid,mpid,Name,OpDate,OpDueDate,RndFired,Notes,BSID,DC,sync_lastupdate) VALUES(" & _
                                FirearmID & "," & MPID & ",'" & Name & "','" & OpDate & "','" & OpDueDate & "','" & _
                                RndFired & "','" & Notes & "'," & DefaultBarrelID & "," & _
                                CountInTotal & ",Now())"
                    Obj.ConnExec(SQL)
                End If
            Next
            elemlist = Nothing
            doc = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_Maintance_Details"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub ProcessXMLToDB_GunSmith_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal FirearmID As Long)
        Try
            Dim doc As New XmlDocument
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim i As Integer = 0
            Dim SQL As String = ""
            Dim gsmith As String = ""
            Dim sdate As String = ""
            Dim rdate As String = ""
            Dim od As String = ""
            Dim notes As String = ""
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                gsmith = Trim(ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("gsmith"))))
                If Len(gsmith) > 0 Then
                    sdate = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("sdate")))
                    rdate = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("rdate")))
                    od = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("od")))
                    notes = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("notes")))
                    SQL = "INSERT INTO GunSmith_Details(GID,gsmith,od,notes,sdate,rdate,sync_lastupdate) VALUES(" & _
                                        FirearmID & ",'" & gsmith & "','" & od & "','" & notes & "','" & _
                                        sdate & "','" & rdate & "',Now())"
                    Obj.ConnExec(SQL)
                End If
            Next
            elemlist = Nothing
            doc = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_GunSmith_Details"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Function BarrelConvoKitExists(ByVal GID As Long, ByVal modelname As String, ByVal caliber As String) As Boolean
        Dim bAns As Boolean = True
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Ext where GID=" & GID & _
                    " and modelName='" & modelname & "' and caliber='" & caliber & "'"
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            bAns = RS.HasRows
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "BarrelConvoKitExists"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    Sub ProcessXMLToDB_BarrelConverstionKit_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal FirearmID As Long)
        Try
            Dim doc As New XmlDocument
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim i As Integer = 0
            Dim SQL As String = ""
            Dim ModelName As String = ""
            Dim Caliber As String = ""
            Dim Finish As String = ""
            Dim BarrelLength As String = ""
            Dim PetLoads As String = ""
            Dim Action As String = ""
            Dim Feedsystem As String = ""
            Dim Sights As String = ""
            Dim PurchasedPrice As String = ""
            Dim PurchasedFrom As String = ""
            Dim dtp As String = ""
            Dim Height As String = ""
            Dim Type As String = ""
            Dim IsDefault As Integer = 0

            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                ModelName = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("ModelName")))
                Caliber = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Caliber")))
                Finish = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Finish")))
                BarrelLength = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("BarrelLength")))
                PetLoads = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PetLoads")))
                Action = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Action")))
                Feedsystem = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Feedsystem")))
                Sights = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Sights")))
                PurchasedPrice = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PurchasedPrice")))
                PurchasedFrom = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("PurchasedFrom")))
                dtp = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("dtp")))
                Height = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Height")))
                Type = ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("Type")))
                IsDefault = CInt(ObjGF.FormatFromXML(GetXMLNode(elemlist(i).Item("IsDefault"))))

                If Not BarrelConvoKitExists(FirearmID, ModelName, Caliber) Then
                    SQL = "INSERT INTO Gun_Collection_Ext(GID,ModelName,Caliber,Finish,BarrelLength," & _
                            "PetLoads,Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height," & _
                            "Type,IsDefault,sync_lastupdate) VALUES(" & FirearmID & ",'" & ModelName & "','" & Caliber & _
                            "','" & Finish & "','" & BarrelLength & "','" & PetLoads & "','" & Action & _
                            "','" & Feedsystem & "','" & Sights & "','" & PurchasedPrice & "','" & _
                            PurchasedFrom & "','" & dtp & "','" & Height & "','" & Type & "'," & IsDefault & ",Now())"
                    Obj.ConnExec(SQL)
                End If
            Next
            elemlist = Nothing
            doc = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_BarrelConverstionKit_Details"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class