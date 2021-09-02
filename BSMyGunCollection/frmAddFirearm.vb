
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Types
''TODO: Convert code from FrmAddFirearm #13

''' <summary>
''' Class frmAddFirearm.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddFirearm
    ''' <summary>
    ''' 
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' The is copy
    ''' </summary>
    Public IsCopy As Boolean
    ''' <summary>
    ''' The copy identifier
    ''' </summary>
    Public CopyId As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim errOut as String 
    ''' <summary>
    ''' Load the data on the form from start or refresh is available.
    ''' </summary>
    Sub LoadData()
        Try
            ''TODO #43 Conver to library use list to return information
            Dim myData as List(Of GunCollectionList) = BurnSoft.Applications.MGC.Firearms.MyCollection.GetList(DatabasePath, Convert.ToInt32(CopyId), errOut)
            
            For Each o As GunCollectionList In myData
                Text = o.FullName
                txtManu.Text = o.Manufacturer
                txtModel.Text = o.ModelName
                txtType.Text = o.Type
                txtCal.Text = o.Caliber
                txtFinish.Text = o.Finish
                cmdCondition.Text = o.Condition
                txtPetLoads.Text = o.PetLoads
                txtNationality.Text = o.Nationality
                txtWeight.Text = o.Weight
                txtLength.Text = o.Height
                txtBarLen.Text = o.BarrelLength
                txtBarWid.Text = o.BarrelWidth
                txtBarHei.Text = o.BarrelHeight
                txtCustCatID.Text = o.CustomId
            Next
            
            Dim obj As New BSDatabase
            Dim objGf As New GlobalFunctions
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection where ID=" & CopyId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                'Text = Trim(rs("fullname"))
                'txtManu.Text = Trim(objGf.GetManufacturersName(rs("MID")))
                'txtModel.Text = Trim(rs("ModelName"))
                'txtType.Text = Trim(rs("Type"))
                'txtCal.Text = Trim(rs("Caliber"))
                'txtFinish.Text = Trim(rs("Finish"))
                'cmdCondition.Text = Trim(rs("Condition"))
                'If Not IsDBNull(rs("Petloads")) Then txtPetLoads.Text = rs("Petloads")
                'txtNationality.Text = Trim(objGf.GetNationalityName(rs("NatID")))
                'txtWeight.Text = Trim(rs("Weight"))
                'txtLength.Text = Trim(rs("Height"))
                'txtBarLen.Text = Trim(rs("BarrelLength"))
                'txtBarWid.Text = Trim(rs("BarrelWidth"))
                'txtBarHei.Text = Trim(rs("BarrelHeight"))
                'txtCustCatID.Text = Trim(rs("CustomID"))
                txtGripType.Text = Trim(objGf.GetGripName(rs("GripID")))
                txtProduced.Text = Trim(rs("Produced"))
                txtAction.Text = Trim(rs("Action"))
                txtFeed.Text = Trim(rs("Feedsystem"))
                txtSights.Text = Trim(rs("Sights"))
                txtStorage.Text = Trim(rs("StorageLocation"))
                txtPurchasedFrom.Text = Trim(rs("PurchasedFrom"))
                txtPurPrice.Text = Trim(rs("PurchasedPrice"))
                If Not IsDBNull(rs("Importer")) Then txtImporter.Text = Trim(rs("Importer"))
                If Not IsDBNull(rs("SGChoke")) Then txtChoke.Text = Trim(rs("SGChoke"))
                If Not IsDBNull(rs("IsInBoundBook")) Then
                    If CInt(rs("IsInBoundBook")) = 0 Then
                        chkBoundBook.Checked = False
                    Else
                        chkBoundBook.Checked = True
                    End If
                Else
                    chkBoundBook.Checked = True
                End If
                If Not IsDBNull(rs("TwistRate")) Then txtTwistOfRate.Text = Trim(rs("TwistRate"))
                If Not IsDBNull(rs("lbs_trigger")) Then txtTriggerPull.Text = Trim(rs("lbs_trigger"))
                If Not IsDBNull(rs("Caliber3")) Then txtCaliber3.Text = Trim(rs("Caliber3"))
                If Not IsDBNull(rs("Classification")) Then cmbClassification.Text = Trim(rs("Classification"))
                If Not IsDBNull(rs("DateofCR")) Then
                    dtpDateofCR.Checked = True
                    dtpDateofCR.Value = rs("DateofCR")
                    dtpDateofCR.Enabled = True
                End If

                If Not IsDBNull(rs("IsCandR")) Then
                    If CInt(rs("IsCandR")) = 0 Then
                        chkBoxCR.Checked = False
                    Else
                        chkBoxCR.Checked = True
                    End If
                Else
                    chkBoxCR.Checked = False
                End If
                If Not IsDBNull(rs("dtp")) Then
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = rs("dtp")
                    dtpPurchased.Enabled = True
                Else
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = rs("dt")
                    dtpPurchased.Enabled = True
                End If
                txtAppValue.Text = Trim(rs("AppraisedValue"))
                If Len(Trim(rs("AppraisalDate"))) <> 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = Trim(rs("AppraisalDate"))
                    dtpAppDate.Enabled = True
                End If
                txtAppBy.Text = Trim(rs("AppraisedBy"))
                txtInsVal.Text = Trim(rs("InsuredValue"))
                txtConCom.Text = Trim(rs("ConditionComments"))
                txtAddNotes.Text = Trim(rs("AdditionalNotes"))
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Perform Auto Fill on the selected text boxes based on values in the database to help unify input
    ''' </summary>
    Private Sub DoAutoFill()
        Try
            txtType.DataSource = Gun.Type(DatabasePath, _errOut)
            txtType.AutoCompleteCustomSource = Gun.Type(DatabasePath, _errOut)
            txtManu.AutoCompleteCustomSource = Gun.Manufacturer(DatabasePath, _errOut)
            txtModel.AutoCompleteCustomSource = Gun.Model(DatabasePath, _errOut)
            txtCal.AutoCompleteCustomSource = Gun.Cal(DatabasePath, _errOut)
            txtNationality.AutoCompleteCustomSource = Gun.Nationality(DatabasePath, _errOut)
            txtPurchasedFrom.AutoCompleteCustomSource = Gun.ShopDetails(DatabasePath, _errOut)
            txtGripType.AutoCompleteCustomSource = Gun.GripType(DatabasePath, _errOut)
            txtAction.DataSource = GunCollection.Action(DatabasePath, _errOut)
            txtAction.AutoCompleteCustomSource = GunCollection.Action(DatabasePath, _errOut)
            txtStorage.DataSource = GunCollection.StorageLocation(DatabasePath, _errOut)
            txtStorage.AutoCompleteCustomSource = GunCollection.StorageLocation(DatabasePath, _errOut)
            txtCustCatID.AutoCompleteCustomSource = GunCollection.CustomId(DatabasePath, _errOut)
            txtFeed.AutoCompleteCustomSource = GunCollection.Feedsystem(DatabasePath, _errOut)
            txtSights.DataSource = GunCollection.Sights(DatabasePath, _errOut)
            txtSights.AutoCompleteCustomSource = GunCollection.Sights(DatabasePath, _errOut)
            txtPetLoads.AutoCompleteCustomSource = Gun.Cal(DatabasePath, _errOut)
            txtFinish.AutoCompleteCustomSource = GunCollection.Finish(DatabasePath, _errOut)
            txtImporter.AutoCompleteCustomSource = GunCollection.Importer(DatabasePath, _errOut)
            txtAppBy.AutoCompleteCustomSource = Appraisers.Name(DatabasePath, _errOut)
            txtPetLoads.AutoCompleteCustomSource = Gun.Cal(DatabasePath, _errOut)
            txtCaliber3.AutoCompleteCustomSource = Gun.Cal(DatabasePath, _errOut)
            txtClassIIIOwner.AutoCompleteCustomSource = GunCollection.ClassIII_owner(DatabasePath, _errOut)

            txtType.Text = ""
            txtAction.Text = ""
            txtStorage.Text = ""
            txtSights.Text = ""
        Catch ex As Exception
            Dim sSubFunc As String = "DoAutoFill"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' On form Load Will the  some of the drop down boxes, 
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddFirearm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_Collection_ClassificationTableAdapter.Fill(MGCDataSet.Gun_Collection_Classification)
            Gun_Collection_ConditionTableAdapter.Fill(MGCDataSet.Gun_Collection_Condition)
            If UseNumberCatOnly Then
                txtCustCatID.Text = 0
                If Useautoassign Then
                    Dim objGf As New GlobalFunctions
                    txtCustCatID.Text = objGf.GetCatalogNextIDNumber
                End If
            End If
            txtPOI.Enabled = False
            dtpReManDT.Enabled = False
            Label12.Visible = UsePetLoads
            txtPetLoads.Visible = UsePetLoads
            If Not Useselectiveboundbook Then
                chkBoundBook.Checked = True
                chkBoundBook.Enabled = False
            End If
            Call DoAutoFill()
            If IsCopy Then Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim objGf As New GlobalFunctions
            Dim obj As New BSDatabase
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
            Dim strCustCatId As String = FluffContent(txtCustCatID.Text)
            Dim sChoke As String = FluffContent(txtChoke.Text)
            Dim custIdExists As Boolean = False
            If Len(Trim(strCustCatId)) > 0 Then custIdExists = objGf.CatalogIDExists(strCustCatId)
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
            Dim isDateApp As Boolean = dtpAppDate.Checked
            Dim strAppDate As String = "   "
            If isDateApp Then strAppDate = dtpAppDate.Value
            Dim strAppBy As String = FluffContent(txtAppBy.Text)
            Dim strInsVal As String = FluffContent(txtInsVal.Text)
            Dim strConCom As String = FluffContent(txtConCom.Text)
            Dim strAddNotes As String = FluffContent(txtAddNotes.Text)
            Dim strImporter As String = FluffContent(txtImporter.Text)
            Dim sReManDt As String = dtpReManDT.Value
            Dim sPoi As String = FluffContent(txtPOI.Text)
            Dim sCaliber3 As String = FluffContent(txtCaliber3.Text)
            Dim iBoundBook As Integer = 0
            If chkBoundBook.Checked Then iBoundBook = 1
            Dim sTwist As String = FluffContent(txtTwistOfRate.Text)
            Dim sTrigger As String = FluffContent(txtTriggerPull.Text)
            Dim sClassification As String = FluffContent(cmbClassification.Text)
            Dim sDateOfCr As String = dtpDateofCR.Value
            Dim iClassIii As Integer = 0
            If chkClassIII.Checked Then iClassIii = 1
            Dim sClassIiiOwner As String = FluffContent(txtClassIIIOwner.Text)
            'If dtpDateofCR.Checked Then sDateOfCR = dtpDateofCR.Value

            If Not Disableuniquecustcatid Then If custIdExists Then MsgBox(objGf.CatalogExistsDetails(strCustCatId)) : Exit Sub
            If Not IsRequired(strManu, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Text) Then Exit Sub
            If Not IsRequired(strSerial, "Serial", Text) Then Exit Sub
            If Not IsRequired(strType, "Type", Text) Then Exit Sub
            If Not IsRequired(strCal, "Caliber Or Gauge", Text) Then Exit Sub
            If Not IsRequired(strPurchasedFrom, "Purchased From", Text) Then Exit Sub

            If chkBoxCR.Checked Then intIsCandR = 1
            If Len(Trim(strPurPrice)) > 0 And Len(Trim(strAppValue)) = 0 Then strAppValue = strPurPrice
            Dim strFullName As String = strManu & " " & strModel
            Dim lngManId As Long = objGf.GetManufacturersID(strManu)
            Dim lngModelId As Long = objGf.GetModelID(strModel, lngManId)
            Dim lngNationalityId As Long = objGf.GetNationalityID(strRegion)
            Dim lngGripId As Long = objGf.GetGripID(strGripType)
            Call objGf.UpdateGunType(strType)
            Dim itemId As Long
            Dim bid As Long

            ''TODO #43 Conver to library

            Dim sql As String = "INSERT INTO Gun_Collection(OID,MID,FullName,ModelName,ModelID,SerialNumber,Type,Caliber,Finish,Condition," &
                    "CustomID,NatID,GripID,Qty,Weight,Height,StockType,BarrelLength,BarrelWidth,BarrelHeight," &
                    "Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,AppraisedValue,AppraisalDate,AppraisedBy," &
                    "InsuredValue,StorageLocation,ConditionComments,AdditionalNotes,Produced,PetLoads,dtp,IsCandR,Importer," &
                    "ReManDT,POI,HasMB,DBID,SGChoke,IsInBoundBook,TwistRate,lbs_trigger,Caliber3,Classification,DateofCR,ItemSold,BID,sync_lastupdate,IsClassIII,ClassIII_owner) VALUES(" &
                    OwnerId & "," & lngManId & ",'" & strFullName & "','" & strModel & "'," & lngModelId & ",'" & strSerial & "','" &
                    strType & "','" & strCal & "','" & strFinish & "','" & strCondition & "'," & objGf.SetCatalogINSType(strCustCatId) & "," &
                    lngNationalityId & "," & lngGripId & "," & strQty & ",'" & strWeight & "','" & strLength & "','" &
                    strGripType & "','" & strBarLen & "','" & strBarWid & "','" & strBarHei & "','" & strAction & "','" &
                    strfeed & "','" & strSights & "','" & strPurPrice & "','" & strPurchasedFrom & "','" & strAppValue & "','" &
                    strAppDate & "','" & strAppBy & "','" & strInsVal & "','" & strStorage & "','" & strConCom & "','" & strAddNotes &
                    "','" & strProduced & "','" & strPetLoads & "','" & strPurDate & "'," & intIsCandR & ",'" & strImporter &
                    "','" & sReManDt & "','" & sPoi & "',0,0,'" & sChoke & "'," & iBoundBook & ",'" & sTwist & "','" & sTrigger &
                    "','" & sCaliber3 & "','" & sClassification & "','" & sDateOfCr & "',0,2,Now()," & iClassIii & ",'" & sClassIiiOwner & "')"

            obj.ConnExec(sql)
            Dim objG As New GlobalFunctions
            itemId = objGf.GetLastFirearmID
            If Len(Trim(strPurchasedFrom)) <> 0 Then
                If Not objG.ObjectExistsinDB(strPurchasedFrom, "Name", "Gun_Shop_Details") Then
                    Call obj.InsertNewContact(strPurchasedFrom, "Gun_Shop_Details", "Name")
                End If
                Dim gsid As Long = objGf.GetGunShopID(strPurchasedFrom)
                sql = "UPDATE Gun_Collection set SID=" & gsid & " where ID=" & itemId
                obj.ConnExec(sql)
            End If

            If Not objG.ObjectExistsinDB(strAppBy, "aName", "Appriaser_Contact_Details") And Len(strAppBy) > 0 Then
                Call obj.InsertNewContact(strPurchasedFrom, "Appriaser_Contact_Details", "aName")
            End If

            sql = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,Action," &
                    "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" &
                    itemId & ",'Default Barrel','" & strCal & "','" & strFinish & "','" & strBarLen &
                    "','" & strPetLoads & "','" & strAction & "','" & strfeed & "','" & strSights & "','" &
                    "0.00','" & strPurchasedFrom & "',DATE(),'" & strLength & "','Fixed Barrel" &
                    "',1,Now())"
            obj.ConnExec(sql)
            bid = objGf.GetBarrelID(itemId, 1)
            sql = "UPDATE Gun_Collection set DBID=" & bid & " where ID=" & itemId
            obj.ConnExec(sql)
            sql = "INSERT INTO Gun_Collection_Ext_Links (BSID,GID,sync_lastupdate) VALUES(" & bid & "," & itemId & ",Now())"
            obj.ConnExec(sql)
            If Not objGf.CaliberExists(strCal) Then obj.ConnExec("INSERT INTO Gun_Cal (Cal,sync_lastupdate) VALUES('" & strCal & "',Now())")
            Lastviewedfirearm = objGf.GetLastFirearmID
            MDIParent1.RefreshCollection()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    ''' <summary>
    ''' Adds the choke option.
    ''' </summary>
    Sub AddChokeOption()
        If txtChoke.Visible Then Exit Sub
        Label34.Location = New Point(Label27.Location.X, Label27.Location.Y)
        txtChoke.Location = New Point(txtStorage.Location.X, txtStorage.Location.Y)
        Label34.Visible = True
        txtChoke.Visible = True
        Dim moveDownXPoints As Integer = 26
        Dim newY As Integer = txtStorage.Location.Y + moveDownXPoints
        Dim oldX As Integer = txtStorage.Location.X
        txtStorage.Location = New Point(oldX, newY)
        oldX = Label27.Location.X
        Label27.Location = New Point(oldX, newY)
        newY = Label9.Location.Y + moveDownXPoints
        oldX = Label9.Location.X
        Label9.Location = New Point(oldX, newY)
        oldX = txtFinish.Location.X
        txtFinish.Location = New Point(oldX, newY)
        newY = Label6.Location.Y + moveDownXPoints
        oldX = Label6.Location.X
        Label6.Location = New Point(oldX, newY)
        oldX = txtNationality.Location.X
        txtNationality.Location = New Point(oldX, newY)
        newY = Label13.Location.Y + moveDownXPoints
        oldX = Label13.Location.X
        Label13.Location = New Point(oldX, newY)
        oldX = txtWeight.Location.X
        txtWeight.Location = New Point(oldX, newY)
        newY = Label14.Location.Y + moveDownXPoints
        oldX = Label14.Location.X
        Label14.Location = New Point(oldX, newY)
        oldX = txtLength.Location.X
        txtLength.Location = New Point(oldX, newY)
        newY = Label15.Location.Y + moveDownXPoints
        oldX = Label15.Location.X
        Label15.Location = New Point(oldX, newY)
        oldX = txtBarLen.Location.X
        txtBarLen.Location = New Point(oldX, newY)
    End Sub
    ''' <summary>
    ''' Handles the LostFocus1 event of the txtType control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub txtType_LostFocus1(ByVal sender As Object, ByVal e As EventArgs) Handles txtType.LostFocus
        If Found(txtType.Text, "shotgun") Then Call AddChokeOption()
    End Sub

End Class