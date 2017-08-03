Imports System.IO
Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmAddFirearm
    Public IsCopy As Boolean
    Public CopyID As String
    'Load the data on the form from start or refresh is available.
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection where ID=" & CopyID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                Me.Text = Trim(RS("fullname"))
                txtManu.Text = Trim(ObjGF.GetManufacturersName(RS("MID")))
                txtModel.Text = Trim(RS("ModelName"))
                txtType.Text = Trim(RS("Type"))
                txtCal.Text = Trim(RS("Caliber"))
                txtFinish.Text = Trim(RS("Finish"))
                cmdCondition.Text = Trim(RS("Condition"))
                If Not IsDBNull(RS("Petloads")) Then txtPetLoads.Text = RS("Petloads")
                txtNationality.Text = Trim(ObjGF.GetNationalityName(RS("NatID")))
                txtWeight.Text = Trim(RS("Weight"))
                txtLength.Text = Trim(RS("Height"))
                txtBarLen.Text = Trim(RS("BarrelLength"))
                txtBarWid.Text = Trim(RS("BarrelWidth"))
                txtBarHei.Text = Trim(RS("BarrelHeight"))
                txtCustCatID.Text = Trim(RS("CustomID"))
                txtGripType.Text = Trim(ObjGF.GetGripName(RS("GripID")))
                txtProduced.Text = Trim(RS("Produced"))
                txtAction.Text = Trim(RS("Action"))
                txtFeed.Text = Trim(RS("Feedsystem"))
                txtSights.Text = Trim(RS("Sights"))
                txtStorage.Text = Trim(RS("StorageLocation"))
                txtPurchasedFrom.Text = Trim(RS("PurchasedFrom"))
                txtPurPrice.Text = Trim(RS("PurchasedPrice"))
                If Not IsDBNull(RS("Importer")) Then txtImporter.Text = Trim(RS("Importer"))
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
                If Not IsDBNull(RS("dtp")) Then
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = RS("dtp")
                    dtpPurchased.Enabled = True
                Else
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = RS("dt")
                    dtpPurchased.Enabled = True
                End If
                txtAppValue.Text = Trim(RS("AppraisedValue"))
                If Len(Trim(RS("AppraisalDate"))) <> 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = Trim(RS("AppraisalDate"))
                    dtpAppDate.Enabled = True
                End If
                txtAppBy.Text = Trim(RS("AppraisedBy"))
                txtInsVal.Text = Trim(RS("InsuredValue"))
                txtConCom.Text = Trim(RS("ConditionComments"))
                txtAddNotes.Text = Trim(RS("AdditionalNotes"))
            End While
            RS.Close()
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Perform Auto Fill on the selected textboxes baseed on values in the database to help unify input
    Private Sub DoAutoFill()
        Try
            Dim ObjAF As New AutoFillCollections
            txtType.DataSource = ObjAF.Gun_Type
            txtType.AutoCompleteCustomSource = ObjAF.Gun_Type
            txtManu.AutoCompleteCustomSource = ObjAF.Gun_Manufacturer()
            txtModel.AutoCompleteCustomSource = ObjAF.Gun_Model
            txtCal.AutoCompleteCustomSource = ObjAF.Gun_Cal
            txtNationality.AutoCompleteCustomSource = ObjAF.Gun_Nationality
            txtPurchasedFrom.AutoCompleteCustomSource = ObjAF.Gun_Shop_Details
            txtGripType.AutoCompleteCustomSource = ObjAF.Gun_GripType
            txtAction.DataSource = ObjAF.Gun_Collection_Action
            txtAction.AutoCompleteCustomSource = ObjAF.Gun_Collection_Action
            txtStorage.DataSource = ObjAF.Gun_Collection_StorageLocation
            txtStorage.AutoCompleteCustomSource = ObjAF.Gun_Collection_StorageLocation
            txtCustCatID.AutoCompleteCustomSource = ObjAF.Gun_Collection_CustomID
            txtFeed.AutoCompleteCustomSource = ObjAF.Gun_Collection_FeedSystem
            txtSights.DataSource = ObjAF.Gun_Collection_Sights
            txtSights.AutoCompleteCustomSource = ObjAF.Gun_Collection_Sights
            txtPetLoads.AutoCompleteCustomSource = ObjAF.Gun_Cal
            txtFinish.AutoCompleteCustomSource = ObjAF.Gun_Collection_Finish
            txtImporter.AutoCompleteCustomSource = ObjAF.Gun_Collection_Importer
            txtAppBy.AutoCompleteCustomSource = ObjAF.Appraisers_Name
            txtPetLoads.AutoCompleteCustomSource = ObjAF.Gun_Cal
            txtCaliber3.AutoCompleteCustomSource = ObjAF.Gun_Cal
            txtClassIIIOwner.AutoCompleteCustomSource = ObjAF.Gun_Collection_ClassIIIOwner

            txtType.Text = ""
            txtAction.Text = ""
            txtStorage.Text = ""
            txtSights.Text = ""
        Catch ex As Exception
            Dim sSubFunc As String = "DoAutoFill"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'On form Load Will the  some of the droupdown boxes, 
    Private Sub frmAddFirearm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Gun_Collection_ClassificationTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Classification)
            Me.Gun_Collection_ConditionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Condition)
            If UseNumberCatOnly Then
                txtCustCatID.Text = 0
                If USEAUTOASSIGN Then
                    Dim ObjGF As New GlobalFunctions
                    txtCustCatID.Text = ObjGF.GetCatalogNextIDNumber
                End If
            End If
            txtPOI.Enabled = False
            dtpReManDT.Enabled = False
            Label12.Visible = UsePetLoads
            txtPetLoads.Visible = UsePetLoads
            If Not USESELECTIVEBOUNDBOOK Then
                chkBoundBook.Checked = True
                chkBoundBook.Enabled = False
            End If
            Call DoAutoFill()
            If IsCopy Then Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub txtModel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim strMan As String = Trim(Replace(txtManu.Text, "'", "''"))
            If Len(strMan) <> 0 Then
                Dim ObjAF As New AutoFillCollections
                txtModel.AutoCompleteCustomSource = ObjAF.Gun_Model_ByMan(strMan)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "txtModel.GotFocus"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
            Dim strPetLoads As String = FluffContent(txtPetLoads.Text)
            Dim intIsCandR As Integer = 0
            Dim strRegion As String = FluffContent(txtNationality.Text)
            Dim strWeight As String = FluffContent(txtWeight.Text)
            Dim strLength As String = FluffContent(txtLength.Text)
            Dim strBarLen As String = FluffContent(txtBarLen.Text)
            Dim strBarWid As String = FluffContent(txtBarWid.Text)
            Dim strBarHei As String = FluffContent(txtBarHei.Text)
            Dim strCustCatID As String = FluffContent(txtCustCatID.Text)
            Dim sChoke As String = FluffContent(txtChoke.Text)
            Dim CustIDExists As Boolean = False
            If Len(Trim(strCustCatID)) > 0 Then CustIDExists = ObjGF.CatalogIDExists(strCustCatID)
            Dim strGripType As String = FluffContent(txtGripType.Text)
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
            Dim sReManDT As String = dtpReManDT.Value
            Dim sPOI As String = FluffContent(txtPOI.Text)
            Dim sCaliber3 As String = FluffContent(txtCaliber3.Text)
            Dim iBoundBook As Integer = 0
            If chkBoundBook.Checked Then iBoundBook = 1
            Dim sTwist As String = FluffContent(txtTwistOfRate.Text)
            Dim sTrigger As String = FluffContent(txtTriggerPull.Text)
            Dim sClassification As String = FluffContent(cmbClassification.Text)
            Dim sDateOfCR As String = dtpDateofCR.Value
            Dim iClassIII As Integer = 0
            If chkClassIII.Checked Then iClassIII = 1
            Dim sClassIIIOwner As String = FluffContent(txtClassIIIOwner.Text)
            'If dtpDateofCR.Checked Then sDateOfCR = dtpDateofCR.Value

            If Not DISABLEUNIQUECUSTCATID Then If CustIDExists Then MsgBox(ObjGF.CatalogExistsDetails(strCustCatID)) : Exit Sub
            If Not IsRequired(strManu, "Manufacturer", Me.Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Me.Text) Then Exit Sub
            If Not IsRequired(strSerial, "Serial", Me.Text) Then Exit Sub
            If Not IsRequired(strType, "Type", Me.Text) Then Exit Sub
            If Not IsRequired(strCal, "Caliber Or Gauge", Me.Text) Then Exit Sub
            If Not IsRequired(strPurchasedFrom, "Purchased From", Me.Text) Then Exit Sub

            If chkBoxCR.Checked Then intIsCandR = 1
            If Len(Trim(strPurPrice)) > 0 And Len(Trim(strAppValue)) = 0 Then strAppValue = strPurPrice
            Dim strFullName As String = strManu & " " & strModel
            Dim lngManID As Long = ObjGF.GetManufacturersID(strManu)
            Dim lngModelID As Long = ObjGF.GetModelID(strModel, lngManID)
            Dim lngNationalityID As Long = ObjGF.GetNationalityID(strRegion)
            Dim lngGripID As Long = ObjGF.GetGripID(strGripType)
            Dim intHasAss As Integer = 0
            Call ObjGF.UpdateGunType(strType)
            Dim ItemID As Long = 0
            Dim BID As Long = 0


            Dim SQL As String = "INSERT INTO Gun_Collection(OID,MID,FullName,ModelName,ModelID,SerialNumber,Type,Caliber,Finish,Condition," & _
                    "CustomID,NatID,GripID,Qty,Weight,Height,StockType,BarrelLength,BarrelWidth,BarrelHeight," & _
                    "Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,AppraisedValue,AppraisalDate,AppraisedBy," & _
                    "InsuredValue,StorageLocation,ConditionComments,AdditionalNotes,Produced,PetLoads,dtp,IsCandR,Importer," & _
                    "ReManDT,POI,HasMB,DBID,SGChoke,IsInBoundBook,TwistRate,lbs_trigger,Caliber3,Classification,DateofCR,ItemSold,BID,sync_lastupdate,IsClassIII,ClassIII_owner) VALUES(" & _
                    OwnerID & "," & lngManID & ",'" & strFullName & "','" & strModel & "'," & lngModelID & ",'" & strSerial & "','" & _
                    strType & "','" & strCal & "','" & strFinish & "','" & strCondition & "'," & ObjGF.SetCatalogINSType(strCustCatID) & "," & _
                    lngNationalityID & "," & lngGripID & "," & strQty & ",'" & strWeight & "','" & strLength & "','" & _
                    strGripType & "','" & strBarLen & "','" & strBarWid & "','" & strBarHei & "','" & strAction & "','" & _
                    strfeed & "','" & strSights & "','" & strPurPrice & "','" & strPurchasedFrom & "','" & strAppValue & "','" & _
                    strAppDate & "','" & strAppBy & "','" & strInsVal & "','" & strStorage & "','" & strConCom & "','" & strAddNotes & _
                    "','" & strProduced & "','" & strPetLoads & "','" & strPurDate & "'," & intIsCandR & ",'" & strImporter & _
                    "','" & sReManDT & "','" & sPOI & "',0,0,'" & sChoke & "'," & iBoundBook & ",'" & sTwist & "','" & sTrigger & _
                    "','" & sCaliber3 & "','" & sClassification & "','" & sDateOfCR & "',0,2,Now()," & iClassIII & ",'" & sClassIIIOwner & "')"

            Obj.ConnExec(SQL)
            Dim ObjG As New GlobalFunctions
            ItemID = ObjGF.GetLastFirearmID
            If Len(Trim(strPurchasedFrom)) <> 0 Then
                If Not ObjG.ObjectExistsinDB(strPurchasedFrom, "Name", "Gun_Shop_Details") Then
                    Call Obj.InsertNewContact(strPurchasedFrom, "Gun_Shop_Details", "Name")
                End If
                Dim GSID As Long = ObjGF.GetGunShopID(strPurchasedFrom)
                SQL = "UPDATE Gun_Collection set SID=" & GSID & " where ID=" & ItemID
                Obj.ConnExec(SQL)
            End If

            If Not ObjG.ObjectExistsinDB(strAppBy, "aName", "Appriaser_Contact_Details") And Len(strAppBy) > 0 Then
                Call Obj.InsertNewContact(strPurchasedFrom, "Appriaser_Contact_Details", "aName")
            End If

            SQL = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,Action," & _
                    "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" & _
                    ItemID & ",'Default Barrel','" & strCal & "','" & strFinish & "','" & strBarLen & _
                    "','" & strPetLoads & "','" & strAction & "','" & strfeed & "','" & strSights & "','" & _
                    "0.00','" & strPurchasedFrom & "',DATE(),'" & strLength & "','Fixed Barrel" & _
                    "',1,Now())"
            Obj.ConnExec(SQL)
            BID = ObjGF.GetBarrelID(ItemID, 1)
            SQL = "UPDATE Gun_Collection set DBID=" & BID & " where ID=" & ItemID
            Obj.ConnExec(SQL)
            SQL = "INSERT INTO Gun_Collection_Ext_Links (BSID,GID,sync_lastupdate) VALUES(" & BID & "," & ItemID & ",Now())"
            Obj.ConnExec(SQL)
            If Not ObjGF.CaliberExists(strCal) Then Obj.ConnExec("INSERT INTO Gun_Cal (Cal,sync_lastupdate) VALUES('" & strCal & "',Now())")
            LASTVIEWEDFIREARM = ObjGF.GetLastFirearmID
            MDIParent1.RefreshCollection()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
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
    Sub AddChokeOption()
        If txtChoke.Visible Then Exit Sub
        Label34.Location = New System.Drawing.Point(Label27.Location.X, Label27.Location.Y)
        txtChoke.Location = New System.Drawing.Point(txtStorage.Location.X, txtStorage.Location.Y)
        Label34.Visible = True
        txtChoke.Visible = True
        Dim MoveDownXPoints As Integer = 26
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
    Private Sub txtType_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtType.LostFocus
        If Found(txtType.Text, "shotgun") Then Call AddChokeOption()
    End Sub

End Class