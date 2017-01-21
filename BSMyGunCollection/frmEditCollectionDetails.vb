Imports System.IO
Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmEditCollectionDetails
    Public ItemID As String
    Dim IsSold As Boolean
    Public BarrelID As Long
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection where ID=" & ItemID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                Me.Text = Trim(RS("fullname"))
                txtManu.Text = Trim(ObjGF.GetManufacturersName(RS("MID")))
                If Not IsDBNull(RS("ModelName")) Then txtModel.Text = Trim(RS("ModelName"))
                If Not IsDBNull(RS("SerialNumber")) Then txtSerial.Text = Trim(RS("SerialNumber"))
                If Not IsDBNull(RS("Type")) Then txtType.Text = Trim(RS("Type"))
                If Found(txtType.Text, "shotgun") Then Call AddChokeOption()
                If Not IsDBNull(RS("Caliber")) Then txtCal.Text = Trim(RS("Caliber"))
                If Not IsDBNull(RS("Finish")) Then txtFinish.Text = Trim(RS("Finish"))
                If Not IsDBNull(RS("Condition")) Then cmdCondition.Text = Trim(RS("Condition"))
                If Not IsDBNull(RS("Petloads")) Then txtPetLoads.Text = Trim(RS("Petloads"))
                txtNationality.Text = Trim(ObjGF.GetNationalityName(RS("NatID")))
                If Not IsDBNull(RS("Weight")) Then txtWeight.Text = Trim(RS("Weight"))
                If Not IsDBNull(RS("Height")) Then txtLength.Text = Trim(RS("Height"))
                If Not IsDBNull(RS("BarrelLength")) Then txtBarLen.Text = Trim(RS("BarrelLength"))
                If Not IsDBNull(RS("BarrelWidth")) Then txtBarWid.Text = Trim(RS("BarrelWidth"))
                If Not IsDBNull(RS("BarrelHeight")) Then txtBarHei.Text = Trim(RS("BarrelHeight"))
                If Not IsDBNull(RS("CustomID")) Then txtCustCatID.Text = Trim(RS("CustomID"))
                txtGripType.Text = Trim(ObjGF.GetGripName(RS("GripID")))
                If Not IsDBNull(RS("Produced")) Then txtProduced.Text = Trim(RS("Produced"))
                If Not IsDBNull(RS("Action")) Then txtAction.Text = Trim(RS("Action"))
                If Not IsDBNull(RS("Feedsystem")) Then txtFeed.Text = Trim(RS("Feedsystem"))
                If Not IsDBNull(RS("Sights")) Then txtSights.Text = Trim(RS("Sights"))
                If Not IsDBNull(RS("StorageLocation")) Then txtStorage.Text = Trim(RS("StorageLocation"))
                If Not IsDBNull(RS("PurchasedFrom")) Then txtPurchasedFrom.Text = Trim(RS("PurchasedFrom"))
                If Not IsDBNull(RS("PurchasedPrice")) Then txtPurPrice.Text = Trim(RS("PurchasedPrice"))
                If Not IsDBNull(RS("Importer")) Then txtImporter.Text = Trim(RS("Importer"))
                If Not IsDBNull(RS("DBID")) Then BarrelID = CLng(RS("DBID"))
                If Not IsDBNull(RS("SGChoke")) Then txtChoke.Text = Trim(RS("SGChoke"))
                If Not IsDBNull(RS("IsInBoundBook")) Then
                    If CInt(RS("IsInBoundBook")) = 0 Then
                        chkBoundBook.Checked = False
                    Else
                        chkBoundBook.Checked = True
                    End If
                Else
                    chkBoundBook.Checked = True
                End If
                If Not IsDBNull(RS("TwistRate")) Then txtTwistOfRate.Text = Trim(RS("TwistRate"))
                If Not IsDBNull(RS("lbs_trigger")) Then txtTriggerPull.Text = Trim(RS("lbs_trigger"))
                If Not IsDBNull(RS("Caliber3")) Then txtCaliber3.Text = Trim(RS("Caliber3"))
                If Not IsDBNull(RS("Classification")) Then cmbClassification.Text = Trim(RS("Classification"))

                If Not IsDBNull(RS("DateofCR")) Then
                    dtpDateofCR.Checked = True
                    dtpDateofCR.Value = RS("DateofCR")
                    dtpDateofCR.Enabled = True
                End If

                If Not IsDBNull(RS("IsCandR")) Then
                    If CInt(RS("IsCandR")) = 0 Then
                        chkBoxCR.Checked = False
                    Else
                        chkBoxCR.Checked = True
                    End If
                Else
                    chkBoxCR.Checked = False
                End If
                If Not IsDBNull(RS("ReManDT")) Then
                    dtpReManDT.Checked = True
                    dtpReManDT.Value = RS("ReManDT")
                    dtpReManDT.Enabled = True
                End If
                If Not IsDBNull(RS("POI")) Then txtPOI.Text = Trim(RS("poi"))
                If chkBoxCR.Checked Then
                    dtpReManDT.Enabled = True
                    txtPOI.Enabled = True
                Else
                    dtpReManDT.Enabled = False
                    txtPOI.Enabled = False
                End If
                If Not IsDBNull(RS("dtp")) Then
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = RS("dtp")
                    dtpPurchased.Enabled = True
                Else
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = RS("dt")
                    dtpPurchased.Enabled = True
                End If
                If Not IsDBNull(RS("AppraisedValue")) Then txtAppValue.Text = Trim(RS("AppraisedValue"))
                If Len(Trim(RS("AppraisalDate"))) <> 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = Trim(RS("AppraisalDate"))
                    dtpAppDate.Enabled = True
                End If
                If Not IsDBNull(RS("AppraisedBy")) Then txtAppBy.Text = Trim(RS("AppraisedBy"))
                If Not IsDBNull(RS("InsuredValue")) Then txtInsVal.Text = Trim(RS("InsuredValue"))
                If Not IsDBNull(RS("ConditionComments")) Then txtConCom.Text = Trim(RS("ConditionComments"))
                If Not IsDBNull(RS("AdditionalNotes")) Then txtAddNotes.Text = Trim(RS("AdditionalNotes"))

                If Not IsDBNull(RS("dtSold")) Then dtpSold.Value = RS("dtSold")
                If CInt(RS("ItemSold")) = 1 Then
                    IsSold = True
                Else
                    IsSold = False
                End If
                Label34.Visible = IsSold
                dtpSold.Visible = IsSold
            End While
            RS.Close()
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub AddChokeOption()
        If txtChoke.Visible Then Exit Sub
        Dim MoveDownXPoints As Integer = 26
        Label35.Visible = True
        txtChoke.Visible = True
        txtChoke.Location = New System.Drawing.Point(txtStorage.Location.X, txtStorage.Location.Y)
        Label35.Location = New System.Drawing.Point(Label27.Location.X, txtStorage.Location.Y)
        Dim NewY As Integer = txtStorage.Location.Y + MoveDownXPoints
        Dim OldX As Integer = txtStorage.Location.X
        txtStorage.Location = New System.Drawing.Point(OldX, NewY)
        OldX = Label27.Location.X
        Label27.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label9.Location.Y + MoveDownXPoints
        OldX = Label9.Location.X
        Label9.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtFinish.Location.X
        txtFinish.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label6.Location.Y + MoveDownXPoints
        OldX = Label6.Location.X
        Label6.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtNationality.Location.X
        txtNationality.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label13.Location.Y + MoveDownXPoints
        OldX = Label13.Location.X
        Label13.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtWeight.Location.X
        txtWeight.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label14.Location.Y + MoveDownXPoints
        OldX = Label14.Location.X
        Label14.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtLength.Location.X
        txtLength.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label15.Location.Y + MoveDownXPoints
        OldX = Label15.Location.X
        Label15.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtBarLen.Location.X
        txtBarLen.Location = New System.Drawing.Point(OldX, NewY)
    End Sub
    Private Sub frmEditCollectionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Gun_Collection_ClassificationTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Classification)
            Me.Gun_Collection_ConditionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Condition)
            If UseNumberCatOnly Then txtCustCatID.Text = 0
            txtPetLoads.Visible = UsePetLoads
            Label12.Visible = UsePetLoads

            If Len(ItemID) <> 0 Then
                Call LoadData()
                Dim ObjAF As New AutoFillCollections
                txtManu.AutoCompleteCustomSource = ObjAF.Gun_Manufacturer()
                txtModel.AutoCompleteCustomSource = ObjAF.Gun_Model
                txtType.AutoCompleteCustomSource = ObjAF.Gun_Type
                txtCal.AutoCompleteCustomSource = ObjAF.Gun_Cal
                txtNationality.AutoCompleteCustomSource = ObjAF.Gun_Nationality
                txtPurchasedFrom.AutoCompleteCustomSource = ObjAF.Gun_Shop_Details
                txtGripType.AutoCompleteCustomSource = ObjAF.Gun_GripType
                txtAction.AutoCompleteCustomSource = ObjAF.Gun_Collection_Action
                txtStorage.AutoCompleteCustomSource = ObjAF.Gun_Collection_StorageLocation
                txtCustCatID.AutoCompleteCustomSource = ObjAF.Gun_Collection_CustomID
                txtFeed.AutoCompleteCustomSource = ObjAF.Gun_Collection_FeedSystem
                txtSights.AutoCompleteCustomSource = ObjAF.Gun_Collection_Sights
                txtPetLoads.AutoCompleteCustomSource = ObjAF.Gun_Cal
                txtFinish.AutoCompleteCustomSource = ObjAF.Gun_Collection_Finish
                txtImporter.AutoCompleteCustomSource = ObjAF.Gun_Collection_Importer
                txtAppBy.AutoCompleteCustomSource = ObjAF.Appraisers_Name
                txtCaliber3.AutoCompleteCustomSource = ObjAF.Gun_Cal
                If Not USESELECTIVEBOUNDBOOK Then
                    chkBoundBook.Checked = True
                    chkBoundBook.Enabled = False
                End If
            Else
                Me.Close()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim ObjGF As New GlobalFunctions
            Dim Obj As New BSDatabase
            Dim strManu As String = FluffContent(txtManu.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSerial As String = FluffContent(txtSerial.Text)
            Dim strType As String = FluffContent(txtType.Text)
            Dim strCal As String = FluffContent(txtCal.Text)
            Dim strFinish As String = FluffContent(txtFinish.Text)
            Dim strCondition As String = FluffContent(cmdCondition.SelectedValue)
            Dim strQty As Double = 1
            Dim intIsCandR As Integer = 0
            Dim strPetLoads As String = FluffContent(txtPetLoads.Text)
            Dim strRegion As String = FluffContent(txtNationality.Text)
            Dim strWeight As String = FluffContent(txtWeight.Text)
            Dim strLength As String = FluffContent(txtLength.Text)
            Dim strBarLen As String = FluffContent(txtBarLen.Text)
            Dim strBarWid As String = FluffContent(txtBarWid.Text)
            Dim strBarHei As String = FluffContent(txtBarHei.Text)
            Dim strCustCatID As String = FluffContent(txtCustCatID.Text)
            Dim CustIDExists As Boolean = False
            If Len(Trim(strCustCatID)) > 0 Then CustIDExists = ObjGF.CatalogIDExists(strCustCatID, CLng(ItemID))
            Dim strGripType As String = FluffContent(txtGripType.Text)
            Dim sChoke As String = FluffContent(txtChoke.Text)
            Dim strProduced As String = FluffContent(txtProduced.Text)
            Dim strAction As String = FluffContent(txtAction.Text)
            Dim strfeed As String = FluffContent(txtFeed.Text)
            Dim strSights As String = FluffContent(txtSights.Text)
            Dim strStorage As String = FluffContent(txtStorage.Text)
            Dim strPurchasedFrom As String = FluffContent(txtPurchasedFrom.Text)
            Dim strPurPrice As String = FluffContent(txtPurPrice.Text)
            Dim strPurDate As String = dtpPurchased.Value
            Dim strAppValue As String = FluffContent(txtAppValue.Text)
            Dim IsDateApp As Boolean = dtpAppDate.Checked
            Dim strAppDate As String = "   "
            If IsDateApp Then strAppDate = dtpAppDate.Value
            Dim strAppBy As String = FluffContent(txtAppBy.Text)
            Dim strInsVal As String = FluffContent(txtInsVal.Text)
            Dim strConCom As String = FluffContent(txtConCom.Text)
            Dim strAddNotes As String = FluffContent(txtAddNotes.Text)
            Dim strImporter As String = FluffContent(txtImporter.Text)
            Dim sCaliber3 As String = FluffContent(txtCaliber3.Text)
            Dim iBoundBook As Integer = 0
            If chkBoundBook.Checked Then iBoundBook = 1
            Dim sTwist As String = FluffContent(txtTwistOfRate.Text)
            Dim sTrigger As String = FluffContent(txtTriggerPull.Text)
            Dim sClassification As String = FluffContent(cmbClassification.Text)
            Dim sDateOfCR As String = dtpDateofCR.Value

            If Not DISABLEUNIQUECUSTCATID Then If CustIDExists Then MsgBox(ObjGF.CatalogExistsDetails(strCustCatID, CLng(ItemID))) : Exit Sub
            If Not IsRequired(strManu, "Manufacturer", Me.Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Me.Text) Then Exit Sub
            If Not IsRequired(strSerial, "Serial", Me.Text) Then Exit Sub
            If Not IsRequired(strType, "Type", Me.Text) Then Exit Sub
            If Not IsRequired(strCal, "Caliber Or Gauge", Me.Text) Then Exit Sub

            If chkBoxCR.Checked Then intIsCandR = 1
            Dim strFullName As String = strManu & " " & strModel
            Dim lngManID As Long = ObjGF.GetManufacturersID(strManu)
            Dim lngModelID As Long = ObjGF.GetModelID(strModel, lngManID)
            Dim lngNationalityID As Long = ObjGF.GetNationalityID(strRegion)
            Dim lngGripID As Long = ObjGF.GetGripID(strGripType)
            Dim intHasAss As Integer = 0
            Dim sReManDT As String = dtpReManDT.Value
            Dim sPOI As String = FluffContent(txtPOI.Text)

            Dim SQL As String = "UPDATE Gun_Collection set oid=" & OwnerID & ", MID=" & lngManID & _
                    ", ModelName='" & strModel & "', ModelID=" & lngModelID & ", SerialNumber='" & _
                    strSerial & "', Type='" & strType & "', Caliber='" & strCal & "', Finish='" & strFinish & "', Condition='" & _
                    strCondition & "', CustomID=" & ObjGF.SetCatalogINSType(strCustCatID) & ", NatID=" & lngNationalityID & ", gripid=" & lngGripID & _
                    ", Qty=" & strQty & ", Weight='" & strWeight & "', Height='" & strLength & "', StockType='" & strGripType & _
                    "', BarrelLength='" & strBarLen & "', BarrelWidth='" & strBarWid & "', BarrelHeight='" & _
                    strBarHei & "', Action='" & strAction & "', FeedSystem='" & strfeed & "', Sights='" & strSights & _
                    "', PurchasedPrice='" & strPurPrice & "', PurchasedFrom='" & strPurchasedFrom & "', AppraisedValue='" & strAppValue & _
                     "', AppraisalDate='" & strAppDate & "', AppraisedBy='" & strAppBy & "', InsuredValue='" & strInsVal & "', StorageLocation='" & _
                     strStorage & "', ConditionComments='" & strConCom & "', AdditionalNotes='" & strAddNotes & "', Produced='" & _
                     strProduced & "', IsCandR=" & intIsCandR & ", PetLoads='" & strPetLoads & _
                    "', dtp='" & strPurDate & "', Importer='" & strImporter & "', " & _
                    "ReManDT='" & sReManDT & "', POI='" & sPOI & "', SGChoke='" & sChoke & "',IsInBoundBook=" & iBoundBook & _
                    ",lbs_trigger='" & sTrigger & "',TwistRate='" & sTwist & "',Caliber3='" & sCaliber3 & _
                    "',Classification='" & sClassification & "',DateofCR='" & sDateOfCR & "', sync_lastupdate=now()"
            If IsSold Then SQL &= ", dtsold='" & dtpSold.Value & "'"
            SQL &= " where ID=" & ItemID
            Obj.ConnExec(SQL)
            SQL = "UPDATE Gun_Collection_Ext set Caliber='" & strCal & "',Finish='" & strFinish & _
                    "',BarrelLength='" & strBarLen & "',PetLoads='" & strPetLoads & "',Action='" & _
                    strAction & "',Feedsystem='" & strAction & "',Sights='" & strSights & _
                    "',PurchasedPrice='" & strPurPrice & "',PurchasedFrom='" & strPurchasedFrom & _
                    "',Height='" & strLength & "',Type='" & strType & "', sync_lastupdate=now() where ID=" & BarrelID
            Obj.ConnExec(SQL)
            If Len(strPurchasedFrom) <> 0 Then
                If Not ObjGF.ObjectExistsinDB(strPurchasedFrom, "Name", "Gun_Shop_Details") Then
                    Call Obj.InsertNewContact(strPurchasedFrom, "Gun_Shop_Details", "Name")
                End If
                Dim GSID As Long = ObjGF.GetGunShopID(strPurchasedFrom)
                SQL = "UPDATE Gun_Collection set SID=" & GSID & ",sync_lastupdate=Now() where ID=" & ItemID
                Obj.ConnExec(SQL)
            End If

            If Not ObjGF.ObjectExistsinDB(strAppBy, "aName", "Appriaser_Contact_Details") And Len(strAppBy) > 0 Then
                Call Obj.InsertNewContact(strAppBy, "Appriaser_Contact_Details", "aName")
            End If

            If Not ObjGF.CaliberExists(strCal) Then Obj.ConnExec("INSERT INTO Gun_Cal (Cal,sync_lastupdate) VALUES('" & strCal & "',Now())")
            MDIParent1.RefreshCollection()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub chkBoxCR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkBoxCR.Checked Then
            txtPOI.Enabled = True
            dtpReManDT.Enabled = True
        Else
            txtPOI.Enabled = False
            dtpReManDT.Enabled = False
        End If
    End Sub
End Class