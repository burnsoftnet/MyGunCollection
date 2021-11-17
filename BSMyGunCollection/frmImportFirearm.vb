Imports System.Xml
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.PeopleAndPlaces

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
        'On Error Resume Next
        Try 
            If IsDBNull(instance) Then
                sAns = ""
            Else 
                sAns = instance.InnerText
            End If
        Catch ex As Exception
            sAns = ""
        End Try
        
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
            Dim i As Integer 
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
            Dim bBoundBook As Boolean
            Dim sTwist As String 
            Dim sTrigger As String 
            Dim sCaliber3 As String 
            Dim sClassification As String 
            Dim sDateOfCr As String 
            dim strBarWid As String
            Dim strBarHei as string
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                fullName = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("FullName")))
                manufacturer = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Manufacturer")))
                modelName = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ModelName")))
                serialNumber = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("SerialNumber")))
                sType = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Type")))
                caliber = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Caliber")))
                finish = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Finish")))
                condition = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Condition")))
                customId = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("CustomID")))
                natId = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("NatID")))
                gripId = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("GripID")))
                weight = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Weight")))
' ReSharper disable once LocalVariableHidesMember
                Dim height As String = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Height")))
                barrelLength = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarrelLength")))
                action = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Action")))
                feedsystem = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Feedsystem")))
                sights = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Sights")))
                purchasedPrice = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedPrice")))
                purchasedFrom = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedFrom")))
                appraisedValue = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AppraisedValue")))
                appraisalDate = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AppraisalDate")))
                appraisedBy = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AppraisedBy")))
                insuredValue = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("InsuredValue")))
                sgChoke = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("SGChoke")))
                storageLocation = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("StorageLocation")))
                conditionComments = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ConditionComments")))
                additionalNotes = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("AdditionalNotes ")))
                produced = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Produced")))
                isCandR = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("IsCandR")))
                petLoads = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PetLoads")))
                dtp = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("dtp")))
                importer = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Importer")))
                reManDt = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ReManDT")))
                bBoundBook = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BoundBook")))
                sCaliber3 = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Caliber3")))
                sTwist = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("TwistOfRate")))
                sTrigger = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("TriggerPull")))
                sClassification = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Classification")))
                sDateOfCr = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("DateofCR")))
                strBarWid = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarWid")))
                strBarHei= Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarHei")))
                Dim sClassIiiOwner as String = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ClassIiiOwner")))
                dim isClassIii as Boolean = CBool(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("IsClassIII"))))

                poi = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("POI")))
                manId = Manufacturers.GetId(DatabasePath,manufacturer, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)

                modId = Models.GetId(DatabasePath,modelName, manId, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)

                lGripId =  Grips.GetId(DatabasePath,gripId, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
    
                lNatId = Nationality.GetId(DatabasePath, natId, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)

                Call GunTypes.UpdateGunType(DatabasePath, sType, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)


                if Not MyCollection.Add(DatabasePath, UseNumberCatOnly, OwnerId, manId, fullName, modelName, modId, serialNumber,
                                                                           sType, caliber, finish, condition, customId, lNatId, lGripId, weight,
                                                                           height, gripId, barrelLength, strBarWid, strBarHei, action, feedsystem, sights, purchasedPrice,
                                                                           purchasedFrom, appraisedValue, appraisalDate, appraisedBy, insuredValue, storageLocation, conditionComments, additionalNotes,
                                                                           produced, petLoads, dtp, CBool(isCandR), importer, reManDt, poi,
                                                                           sgChoke, CBool(bBoundBook), sTwist, sTrigger, sCaliber3, sClassification, sDateOfCr,
                                                                           isClassIii, sClassIiiOwner, _errOut) Then Throw New Exception(_errOut)

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
            Dim i As Integer 
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
                manufacturer = Trim(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Manufacturer"))))
                If Len(manufacturer) > 0 Then
                    model = Trim(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Model"))))
                    serialNumber = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("SerialNumber")))
                    condition = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Condition")))
                    notes = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Notes")))
                    use = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Use")))
                    purValue = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurValue")))
                    Dim appValue As Double = Convert.ToDouble(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("appValue"))))
                    Dim civ As Boolean = CBool(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("civ"))))
                    Dim ic As Boolean = CBool(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ic"))))

                    If Not Accessories.Add(DatabasePath, firearmId, manufacturer, model, serialNumber, condition,
                                                                              notes, use, purValue, appValue, civ,ic, _errOut) Then Throw New Exception(_errOut)

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
            Dim i As Integer 
            Dim mpid As Long
            Dim opDate As String 
            Dim opDueDate As String 
            Dim rndFired As String 
            Dim notes As String 

            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
' ReSharper disable once LocalVariableHidesMember
                Dim name As String = Trim(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Name"))))
                If Len(name) > 0 Then
                    opDate = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("OpDate")))
                    opDueDate = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("OpDueDate")))
                    rndFired = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("RndFired")))
                    Dim ammoUsed As String = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ammoUsed")))

                    notes = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Notes")))
                    mpid = MaintancePlans.GetId(DatabasePath, name, _errOut)
                    If _errOut.Length > 0 Then Throw New Exception(_errOut)
                    If Not MaintanceDetails.Add(DatabasePath, name, firearmId, mpid, opDate, 
                                                                                   opDueDate, rndFired, notes, ammoUsed, DefaultBarrelId, CLng(rndFired) > 0, _errOut) Then Throw New Exception(_errOut)

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
            Dim i As Integer 
            Dim gsmith As String 
            Dim sdate As String 
            Dim rdate As String 
            Dim od As String 
            Dim notes As String 
            doc.Load(strPath)
            Dim elemlist As XmlNodeList = doc.GetElementsByTagName(strNodeName)
            For i = 0 To elemlist.Count - 1
                gsmith = Trim(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("gsmith"))))
                If Len(gsmith) > 0 Then
                    sdate = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("sdate")))
                    rdate = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("rdate")))
                    od = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("od")))
                    notes = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("notes")))

                    If Not GunSmiths.Exists(DatabasePath, gsmith, _errOut) Then
                        If Not GunSmiths.Add(DatabasePath, gsmith, _errOut) Then Throw New Exception(_errOut)
                    End If
                    Dim gid As Long = GunSmiths.GetId(DatabasePath, gsmith, _errOut)

                    If Not GunSmithDetails.Add(DatabasePath, firearmId, gsmith,gid , od,notes, sdate, rdate, _errOut) Then Throw New Exception(_errOut)

                End If
            Next
 
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_GunSmith_Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
 
    ''' <summary>
    ''' Processes the XML to database barrel converstion kit details.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    ''' <param name="strNodeName">Name of the string node.</param>
    ''' <param name="firearmId">The firearm identifier.</param>
    Sub ProcessXMLToDB_BarrelConverstionKit_Details(ByVal strPath As String, ByVal strNodeName As String, ByVal firearmId As Long)
        Try
            Dim doc As New XmlDocument
            Dim i As Integer 
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
                modelName = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("ModelName")))
                caliber = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Caliber")))
                finish = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Finish")))
                barrelLength = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("BarrelLength")))
                petLoads = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PetLoads")))
                action = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Action")))
                feedsystem = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Feedsystem")))
                sights = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Sights")))
                purchasedPrice = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedPrice")))
                purchasedFrom = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("PurchasedFrom")))
                dtp = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("dtp")))
                height = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Height")))
                type = Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("Type")))
                isDefault = CInt(Helpers.FormatFromXml(GetXmlNode(elemlist(i).Item("IsDefault"))))

                If Not ExtraBarrelConvoKits.Exists(DatabasePath, firearmId, modelName, caliber, finish,
                                                                                      barrelLength, petLoads,action, feedsystem, sights, purchasedPrice, 
                                                                                      purchasedFrom, height, type, (isDefault = 1), _errOut) Then
                    If Not ExtraBarrelConvoKits.Add(DatabasePath, firearmId, modelName, caliber, finish,
                                                    barrelLength, petLoads,action, feedsystem, sights, purchasedPrice, 
                                                    purchasedFrom, height, type, (isDefault = 1),dtp, _errOut) Then Throw New Exception(_errOut)
                End If

            Next

        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB_BarrelConverstionKit_Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class