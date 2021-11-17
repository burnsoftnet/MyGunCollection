Imports System.Data.Odbc
Imports System.Xml
Imports BSMyGunCollection.MGC
''' <summary>
''' Class FrmImportFirearm.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmImportFirearm
    ''' <summary>
    ''' The default barrel identifier
    ''' </summary>
    Public DefaultBarrelId As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String = ""
    ''' <summary>
    ''' Handles the Click event of the btnOpen control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
        Try
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.Filter = $"XML File(*.xml)|*.xml"
            OpenFileDialog1.Title = $"Import Firearm from XML"
            OpenFileDialog1.FileName =""
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = OpenFileDialog1.FileName
            lblFile.Text = strFilePath
            If Len(strFilePath) > 0 Then btnImport.Enabled = True
        Catch ex As Exception
            Dim sSubFunc As String = "btnOpen.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the XML node.
    ''' </summary>
    ''' <param name="instance">The instance.</param>
    ''' <returns>System.String.</returns>
    Function GetXmlNode(ByVal instance As XmlNode) As String
        Dim sAns As String
        On Error Resume Next
        sAns = instance.InnerText
        Return sAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnImport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
        Call ProcessXmlToDb(lblFile.Text)
    End Sub
    ''' <summary>
    ''' Updates the status label.
    ''' </summary>
    ''' <param name="sValue">The s value.</param>
    Sub UpdateStatusLabel(ByVal sValue As String)
        lblProg.Text = sValue
        lblProg.Refresh()
    End Sub
    ''' <summary>
    ''' Updates the progress bar.
    ''' </summary>
    ''' <param name="iValue">The i value.</param>
    Sub UpdateProgressBar(ByVal iValue As Long)
        ProgressBar1.Value = iValue
        ProgressBar1.Refresh()
    End Sub
    ''' <summary>
    ''' Processes the XML to database.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    Sub ProcessXmlToDb(ByVal strPath As String)
        Try
            Dim fullName As String = ""
            Dim firearmId As Long 

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 5
            UseWaitCursor = True
            Dim I As Integer 

            I += 1
            Call UpdateStatusLabel("Getting Firearm Details")
            Call ProcessXMLToDB_Details(strPath, "Details", fullName, firearmId)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Accessories List")
            Call ProcessXMLToDB_Accessories(strPath, "Accessories", firearmId)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Maintance Details")
            Call ProcessXMLToDB_Maintance_Details(strPath, "Maintance_Details", firearmId)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting GunSmith Details")
            Call ProcessXMLToDB_GunSmith_Details(strPath, "GunSmith_Details", firearmId)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Barrel/Conversion Kit details")
            Call ProcessXMLToDB_BarrelConverstionKit_Details(strPath, "BarrelConverstionKit_Details", firearmId)
            Call UpdateProgressBar(I)
            UseWaitCursor = False
            MsgBox("Import of the " & fullName & " firearm is complete!")
            MDIParent1.RefreshCollection()
            Close()

        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
            UseWaitCursor = False
        End Try
    End Sub
    ''' <summary>
    ''' Processes the XML to database details.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    ''' <param name="strNodeName">Name of the string node.</param>
    ''' <param name="fullName">The full name.</param>
    ''' <param name="firearmId">The firearm identifier.</param>
    Sub ProcessXMLToDB_Details(ByVal strPath As String, ByVal strNodeName As String, ByRef fullName As String, ByRef firearmId As Long)
        Try
            Dim doc As New XmlDocument
            'Dim obj As New BSDatabase
            'Dim objGf As New GlobalFunctions
            Dim i As Integer 
            'Dim sql As String 
            Dim manufacturer As String 
            Dim modelName As String 
            Dim serialNumber As String
            Dim sType As String 
            Dim caliber As String 
            Dim finish As String 
            Dim condition As String 
            Dim customId As String 
            Dim natId As String 
            Dim gripId As String 
            Dim weight As String 
' ReSharper disable LocalVariableHidesMember
            Dim height As String 
            Dim barrelLength As String 
            Dim action As String 
            Dim feedsystem As String 
            Dim sights As String 
            Dim purchasedPrice As String 
            Dim purchasedFrom As String 
            Dim appraisedValue As String 
            Dim appraisalDate As String 
            Dim appraisedBy As String 
            Dim insuredValue As String 
            Dim storageLocation As String 
            Dim conditionComments As String 
            Dim additionalNotes As String 
            Dim sgChoke As String 
            Dim produced As String 
            Dim isCandR As String 
            Dim petLoads As String 
            Dim dtp As String 
            Dim importer As String 
            Dim reManDt As String 
            Dim poi As String 
            Dim manId As Long 
            Dim modId As Long 
            Dim lGripId As Long 
            Dim lNatId As Long 
            'Dim bid As Long 
            'Dim lIsCandR As Long 
' ReSharper disable NotAccessedVariable
            'Dim iBoundBook As Long 
            Dim bBoundBook As Boolean
            Dim sTwist As String 
            Dim sTrigger As String 
            Dim sCaliber3 As String 
            Dim sClassification As String 
            Dim sDateOfCr As String 
            dim strBarWid As String
            Dim strBarHei as string
            ' ReSharper restore LocalVariableHidesMember
            ' ReSharper restore NotAccessedVariable
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                fullName = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("FullName")))
                manufacturer = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Manufacturer")))
                modelName = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ModelName")))
                serialNumber = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("SerialNumber")))
                sType = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Type")))
                caliber = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Caliber")))
                finish = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Finish")))
                condition = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Condition")))
                customId = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("CustomID")))
                natId = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("NatID")))
                gripId = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("GripID")))
                weight = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Weight")))
                height = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Height")))
                barrelLength = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarrelLength")))
                action = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Action")))
                feedsystem = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Feedsystem")))
                sights = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Sights")))
                purchasedPrice = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedPrice")))
                purchasedFrom = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedFrom")))
                appraisedValue = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AppraisedValue")))
                appraisalDate = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AppraisalDate")))
                appraisedBy = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AppraisedBy")))
                insuredValue = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("InsuredValue")))
                sgChoke = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("SGChoke")))
                storageLocation = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("StorageLocation")))
                conditionComments = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ConditionComments")))
                additionalNotes = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AdditionalNotes ")))
                produced = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Produced")))
                isCandR = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("IsCandR")))
                petLoads = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PetLoads")))
                dtp = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("dtp")))
                importer = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Importer")))
                reManDt = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ReManDT")))
                bBoundBook = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BoundBook")))
                sCaliber3 = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Caliber3")))
                sTwist = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("TwistOfRate")))
                sTrigger = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("TriggerPull")))
                sClassification = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Classification")))
                sDateOfCr = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("DateofCR")))
                strBarWid = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarWid")))
                strBarHei= BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarHei")))
                Dim sClassIiiOwner as String = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ClassIiiOwner")))
                dim isClassIii as Boolean = CBool(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("IsClassIII"))))

                'If CBool(bBoundBook) Then iBoundBook = 1
                poi = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("POI")))
                manId = BurnSoft.Applications.MGC.Firearms.Manufacturers.GetId(DatabasePath,manufacturer, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                'modId = objGf.GetModelID(modelName, manId)
                modId = BurnSoft.Applications.MGC.Firearms.Models.GetId(DatabasePath,modelName, manId, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                'lGripId = objGf.GetGripID(gripId)
                lGripId =  BurnSoft.Applications.MGC.Firearms.Grips.GetId(DatabasePath,gripId, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                'lNatId = objGf.GetNationalityID(natId)
                lNatId = BurnSoft.Applications.MGC.Firearms.Nationality.GetId(DatabasePath, natId, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                'Call objGf.UpdateGunType(sType)
                'If CBool(isCandR) Then lIsCandR = 1
                Call BurnSoft.Applications.MGC.Firearms.GunTypes.UpdateGunType(DatabasePath, sType, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)


                if Not BurnSoft.Applications.MGC.Firearms.MyCollection.Add(DatabasePath, UseNumberCatOnly, OwnerId, manId, fullName, modelName, modId, serialNumber,
                                                                           sType, caliber, finish, condition, customId, lNatId, lGripId, weight,
                                                                           height, gripId, barrelLength, strBarWid, strBarHei, action, feedsystem, sights, purchasedPrice,
                                                                           purchasedFrom, appraisedValue, appraisalDate, appraisedBy, insuredValue, storageLocation, conditionComments, additionalNotes,
                                                                           produced, petLoads, dtp, CBool(isCandR), importer, reManDt, poi,
                                                                           sgChoke, CBool(bBoundBook), sTwist, sTrigger, sCaliber3, sClassification, sDateOfCr,
                                                                           isClassIii, sClassIiiOwner, _errOut) Then Throw New Exception(_errOut)


                'sql = "INSERT INTO Gun_Collection(OID,MID,FullName,ModelName,ModelID,SerialNumber,Type,Caliber,Finish,Condition," & _
                '        "CustomID,NatID,GripID,Qty,Weight,Height,StockType,BarrelLength,BarrelWidth,BarrelHeight," & _
                '        "Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,AppraisedValue,AppraisalDate,AppraisedBy," & _
                '        "InsuredValue,StorageLocation,ConditionComments,AdditionalNotes,Produced,PetLoads,dtp,IsCandR,Importer," & _
                '        "ReManDT,POI,SGChoke,sync_lastupdate) VALUES(" & _
                '        OwnerId & "," & manId & ",'" & fullName & "','" & modelName & "'," & modId & ",'" & serialNumber & "','" & _
                '        sType & "','" & caliber & "','" & finish & "','" & condition & "'," & objGf.SetCatalogINSType(customId) & "," & _
                '        lNatId & "," & lGripId & ",1,'" & weight & "','" & height & "','" & _
                '        gripId & "','" & barrelLength & "',' ',' ','" & action & "','" & _
                '        feedsystem & "','" & sights & "','" & purchasedPrice & "','" & purchasedFrom & "','" & appraisedValue & "','" & _
                '        appraisalDate & "','" & appraisedBy & "','" & insuredValue & "','" & storageLocation & "','" & conditionComments & "','" & additionalNotes & _
                '        "','" & produced & "','" & petLoads & "','" & dtp & "'," & lIsCandR & ",'" & importer & _
                '        "','" & reManDt & "','" & poi & "','" & sgChoke & "',Now())"
                'obj.ConnExec(sql)
                'firearmId = objGf.GetLastFirearmID
                'sql = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,Action," & _
                '    "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" & _
                '    firearmId & ",'Default Barrel','" & caliber & "','" & finish & "','" & barrelLength & _
                '    "','" & petLoads & "','" & action & "','" & feedsystem & "','" & sights & "','" & _
                '    "0.00','" & purchasedFrom & "',DATE(),'" & height & "','Fixed Barrel" & _
                '    "',1,Now())"
                'obj.ConnExec(sql)
                'bid = objGf.GetBarrelID(firearmId, 1)
                'DefaultBarrelId = bid
                'sql = "UPDATE Gun_Collection set DBID=" & bid & " where ID=" & firearmId
                'obj.ConnExec(sql)
                'sql = "INSERT INTO Gun_Collection_Ext_Links (BSID,GID,sync_lastupdate) VALUES(" & bid & "," & firearmId & ",Now())"
                'obj.ConnExec(sql)
                'If Len(Trim(purchasedFrom)) <> 0 Then
                '    'Dim objG As New GlobalFunctions
                '    'If Not objG.ObjectExistsinDB(purchasedFrom, "Name", "Gun_Shop_Details") Then
                '    '    sql = "INSERT INTO Gun_Shop_Details(Name,Address1,City,State,Zip,sync_lastupdate) VALUES('" & purchasedFrom & "','N/A','N/A','N/A','N/A',Now())"
                '    '    obj.ConnExec(sql)
                '    'End If
                '    'Dim gsid As Long = objGf.GetGunShopID(purchasedFrom)
                '    If Not BurnSoft.Applications.MGC.PeopleAndPlaces.Shops.Exists(DatabasePath, purchasedFrom, _errOut) Then
                '        If Not BurnSoft.Applications.MGC.PeopleAndPlaces.Shops.Add(DatabasePath, purchasedFrom, _errOut) Then Throw New Exception(_errOut)
                '    End If
                '    If _errOut.Length > 0  Then Throw new Exception(_errOut)
                '    dim gsid as Long = BurnSoft.Applications.MGC.PeopleAndPlaces.Shops.GetId(DatabasePath, purchasedFrom, _errOut)
                '    If _errOut.Length > 0  Then Throw new Exception(_errOut)
                '    'sql = "UPDATE Gun_Collection set SID=" & gsid & " where ID=" & firearmId
                '    'obj.ConnExec(sql)
                '    if Not BurnSoft.Applications.MGC.Firearms.MyCollection.UpdateSellerId(DatabasePath, gsid, firearmId, _errOut) Then Throw new Exception(_errOut)
                'End If
                'If Not objGf.CaliberExists(caliber) Then obj.ConnExec("INSERT INTO Gun_Cal (Cal,sync_lastupdate) VALUES('" & caliber & "',Now())")
                MDIParent1.RefreshCollection()
            Next
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmImportFirearm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmImportFirearm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        lblProg.Text = ""
        lblFile.Text = ""
    End Sub
    ''' <summary>
    ''' Processes the XML to database accessories.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    ''' <param name="strNodeName">Name of the string node.</param>
    ''' <param name="firearmId">The firearm identifier.</param>
    Sub ProcessXMLToDB_Accessories(ByVal strPath As String, ByVal strNodeName As String, ByVal firearmId As Long)
        Try
            Dim doc As New XmlDocument
            'Dim obj As New BSDatabase
            'Dim objGf As New GlobalFunctions
            Dim i As Integer 
            'Dim sql As String 
            Dim manufacturer As String 
            Dim model As String 
            Dim serialNumber As String 
            Dim condition As String 
            Dim notes As String 
            Dim use As String 
            Dim purValue As String 
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                manufacturer = Trim(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Manufacturer"))))
                If Len(manufacturer) > 0 Then
                    model = Trim(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Model"))))
                    serialNumber = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("SerialNumber")))
                    condition = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Condition")))
                    notes = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Notes")))
                    use = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Use")))
                    purValue = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurValue")))
                    Dim appValue As Double = Convert.ToDouble(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("appValue"))))
                    Dim civ As Boolean = CBool(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("civ"))))
                    Dim ic As Boolean = CBool(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ic"))))

                    If Not BurnSoft.Applications.MGC.Firearms.Accessories.Add(DatabasePath, firearmId, manufacturer, model, serialNumber, condition,
                                                                              notes, use, purValue, appValue, civ,ic, _errOut) Then Throw New Exception(_errOut)

                    'sql = "INSERT INTO Gun_Collection_Accessories(GID,Manufacturer,Model,SerialNumber,Condition,Notes,Use,PurValue,sync_lastupdate) VALUES(" & _
                    '        firearmId & ",'" & manufacturer & "','" & model & "','" & serialNumber & "','" & condition & "','" & _
                    '        notes & "','" & use & "','" & purValue & "',Now())"
                    'obj.ConnExec(sql)
                End If
            Next
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_Accessories"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Processes the XML to database maintance details.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    ''' <param name="strNodeName">Name of the string node.</param>
    ''' <param name="firearmId">The firearm identifier.</param>
    Sub ProcessXMLToDB_Maintance_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal firearmId As Long)
        Try
            Dim doc As New XmlDocument
            'Dim obj As New BSDatabase
            'Dim objGf As New GlobalFunctions
            Dim i As Integer 
            Dim mpid As Long 
            'Dim sql As String 
' ReSharper disable LocalVariableHidesMember
            Dim name As String 
' ReSharper restore LocalVariableHidesMember
            Dim opDate As String 
            Dim opDueDate As String 
            Dim rndFired As String 
            Dim notes As String 
            'Dim countInTotal As Integer 
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                name = Trim(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Name"))))
                If Len(name) > 0 Then
                    opDate = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("OpDate")))
                    opDueDate = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("OpDueDate")))
                    rndFired = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("RndFired")))
                    Dim ammoUsed As String = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ammoUsed")))
                    'If CLng(rndFired) > 0 Then
                    '    countInTotal = 1
                    'Else
                    '    countInTotal = 0
                    'End If
                    notes = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Notes")))
                    'mpid = objGf.GetID("SELECT ID from Maintance_Plans where Name='" & name & "'")
                    mpid = BurnSoft.Applications.MGC.Firearms.MaintancePlans.GetId(DatabasePath, name, _errOut)
                    If _errOut.Length > 0 Then Throw New Exception(_errOut)
                    If Not BurnSoft.Applications.MGC.Firearms.MaintanceDetails.Add(DatabasePath, name, firearmId, mpid, opDate, 
                                                                                   opDueDate, rndFired, notes, ammoUsed, DefaultBarrelId, CLng(rndFired) > 0, _errOut) Then Throw New Exception(_errOut)

                    'sql = "INSERT INTO Maintance_Details(gid,mpid,Name,OpDate,OpDueDate,RndFired,Notes,BSID,DC,sync_lastupdate) VALUES(" & _
                    '            firearmId & "," & mpid & ",'" & name & "','" & opDate & "','" & opDueDate & "','" & _
                    '            rndFired & "','" & notes & "'," & DefaultBarrelId & "," & _
                    '            countInTotal & ",Now())"
                    'obj.ConnExec(sql)
                End If
            Next

        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_Maintance_Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Processes the XML to database gun smith details.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    ''' <param name="strNodeName">Name of the string node.</param>
    ''' <param name="firearmId">The firearm identifier.</param>
    Sub ProcessXMLToDB_GunSmith_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal firearmId As Long)
        Try
            Dim doc As New XmlDocument
            Dim obj As New BSDatabase
            Dim objGf As New GlobalFunctions
            Dim i As Integer 
            Dim sql As String 
            Dim gsmith As String 
            Dim sdate As String 
            Dim rdate As String 
            Dim od As String 
            Dim notes As String 
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                gsmith = Trim(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("gsmith"))))
                If Len(gsmith) > 0 Then
                    sdate = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("sdate")))
                    rdate = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("rdate")))
                    od = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("od")))
                    notes = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("notes")))
                    sql = "INSERT INTO GunSmith_Details(GID,gsmith,od,notes,sdate,rdate,sync_lastupdate) VALUES(" & _
                                        firearmId & ",'" & gsmith & "','" & od & "','" & notes & "','" & _
                                        sdate & "','" & rdate & "',Now())"
                    obj.ConnExec(sql)
                End If
            Next
 
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_GunSmith_Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Barrels the convo kit exists.
    ''' </summary>
    ''' <param name="gid">The gid.</param>
    ''' <param name="modelname">The model name.</param>
    ''' <param name="caliber">The caliber.</param>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Function BarrelConvoKitExists(ByVal gid As Long, ByVal modelname As String, ByVal caliber As String) As Boolean
        Dim bAns As Boolean = True
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection_Ext where GID=" & gid & _
                    " and modelName='" & modelname & "' and caliber='" & caliber & "'"
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            bAns = rs.HasRows
            rs.Close()

            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "BarrelConvoKitExists"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Processes the XML to database barrel converstion kit details.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    ''' <param name="strNodeName">Name of the string node.</param>
    ''' <param name="firearmId">The firearm identifier.</param>
    Sub ProcessXMLToDB_BarrelConverstionKit_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal firearmId As Long)
        Try
            Dim doc As New XmlDocument
            Dim obj As New BSDatabase
            Dim objGf As New GlobalFunctions
            Dim i As Integer 
            Dim sql As String 
            Dim modelName As String 
            Dim caliber As String 
            Dim finish As String 
            Dim barrelLength As String 
            Dim petLoads As String 
            Dim action As String 
            Dim feedsystem As String 
            Dim sights As String 
            Dim purchasedPrice As String 
            Dim purchasedFrom As String 
            Dim dtp As String 
' ReSharper disable LocalVariableHidesMember
            Dim height As String 
' ReSharper restore LocalVariableHidesMember
            Dim type As String 
            Dim isDefault As Integer 

            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                modelName = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ModelName")))
                caliber = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Caliber")))
                finish = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Finish")))
                barrelLength = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarrelLength")))
                petLoads = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PetLoads")))
                action = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Action")))
                feedsystem = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Feedsystem")))
                sights = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Sights")))
                purchasedPrice = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedPrice")))
                purchasedFrom = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedFrom")))
                dtp = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("dtp")))
                height = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Height")))
                type = BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Type")))
                isDefault = CInt(BurnSoft.Applications.MGC.Global.Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("IsDefault"))))

                If Not BarrelConvoKitExists(firearmId, modelName, caliber) Then
                    sql = "INSERT INTO Gun_Collection_Ext(GID,ModelName,Caliber,Finish,BarrelLength," & _
                            "PetLoads,Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height," & _
                            "Type,IsDefault,sync_lastupdate) VALUES(" & firearmId & ",'" & modelName & "','" & caliber & _
                            "','" & finish & "','" & barrelLength & "','" & petLoads & "','" & action & _
                            "','" & feedsystem & "','" & sights & "','" & purchasedPrice & "','" & _
                            purchasedFrom & "','" & dtp & "','" & height & "','" & type & "'," & isDefault & ",Now())"
                    obj.ConnExec(sql)
                End If
            Next

        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_BarrelConverstionKit_Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class