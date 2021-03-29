
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC

''TODO: Convert code from FrmEditCollectionDetails #19

''' <summary>
''' Class frmEditCollectionDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditCollectionDetails
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The is sold
    ''' </summary>
    Dim _isSold As Boolean
    ''' <summary>
    ''' The barrel identifier
    ''' </summary>
    Public BarrelId As Long
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim obj As New BSDatabase
            Dim objGf As New GlobalFunctions
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection where ID=" & ItemId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                Text = Trim(rs("fullname"))
                txtManu.Text = Trim(objGf.GetManufacturersName(rs("MID")))
                If Not IsDBNull(rs("ModelName")) Then txtModel.Text = Trim(rs("ModelName"))
                If Not IsDBNull(rs("SerialNumber")) Then txtSerial.Text = Trim(rs("SerialNumber"))
                If Not IsDBNull(rs("Type")) Then txtType.Text = Trim(rs("Type"))
                If Found(txtType.Text, "shotgun") Then Call AddChokeOption()
                If Not IsDBNull(rs("Caliber")) Then txtCal.Text = Trim(rs("Caliber"))
                If Not IsDBNull(rs("Finish")) Then txtFinish.Text = Trim(rs("Finish"))
                If Not IsDBNull(rs("Condition")) Then cmdCondition.Text = Trim(rs("Condition"))
                If Not IsDBNull(rs("Petloads")) Then txtPetLoads.Text = Trim(rs("Petloads"))
                txtNationality.Text = Trim(objGf.GetNationalityName(rs("NatID")))
                If Not IsDBNull(rs("Weight")) Then txtWeight.Text = Trim(rs("Weight"))
                If Not IsDBNull(rs("Height")) Then txtLength.Text = Trim(rs("Height"))
                If Not IsDBNull(rs("BarrelLength")) Then txtBarLen.Text = Trim(rs("BarrelLength"))
                If Not IsDBNull(rs("BarrelWidth")) Then txtBarWid.Text = Trim(rs("BarrelWidth"))
                If Not IsDBNull(rs("BarrelHeight")) Then txtBarHei.Text = Trim(rs("BarrelHeight"))
                If Not IsDBNull(rs("CustomID")) Then txtCustCatID.Text = Trim(rs("CustomID"))
                txtGripType.Text = Trim(objGf.GetGripName(rs("GripID")))
                If Not IsDBNull(rs("Produced")) Then txtProduced.Text = Trim(rs("Produced"))
                If Not IsDBNull(rs("Action")) Then txtAction.Text = Trim(rs("Action"))
                If Not IsDBNull(rs("Feedsystem")) Then txtFeed.Text = Trim(rs("Feedsystem"))
                If Not IsDBNull(rs("Sights")) Then txtSights.Text = Trim(rs("Sights"))
                If Not IsDBNull(rs("StorageLocation")) Then txtStorage.Text = Trim(rs("StorageLocation"))
                If Not IsDBNull(rs("PurchasedFrom")) Then txtPurchasedFrom.Text = Trim(rs("PurchasedFrom"))
                If Not IsDBNull(rs("PurchasedPrice")) Then txtPurPrice.Text = Trim(rs("PurchasedPrice"))
                If Not IsDBNull(rs("Importer")) Then txtImporter.Text = Trim(rs("Importer"))
                If Not IsDBNull(rs("DBID")) Then BarrelId = CLng(rs("DBID"))
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


                Dim iClassIii As Integer = 0
                If Not IsDBNull(rs("IsClassIII")) Then iClassIii = rs("IsClassIII")
                If Not IsDBNull(rs("ClassIII_owner")) Then txtClassIIIOwner.Text = rs("ClassIII_owner")
                If iClassIii = 0 Then
                    chkClassIII.Checked = False
                Else
                    chkClassIII.Checked = True
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
                If Not IsDBNull(rs("ReManDT")) Then
                    dtpReManDT.Checked = True
                    dtpReManDT.Value = rs("ReManDT")
                    dtpReManDT.Enabled = True
                End If
                If Not IsDBNull(rs("POI")) Then txtPOI.Text = Trim(rs("poi"))

                Call EnableDiableCandR()

                If Not IsDBNull(rs("dtp")) Then
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = rs("dtp")
                    dtpPurchased.Enabled = True
                Else
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = rs("dt")
                    dtpPurchased.Enabled = True
                End If
                If Not IsDBNull(rs("AppraisedValue")) Then txtAppValue.Text = Trim(rs("AppraisedValue"))
                If Len(Trim(rs("AppraisalDate"))) <> 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = Trim(rs("AppraisalDate"))
                    dtpAppDate.Enabled = True
                End If
                If Not IsDBNull(rs("AppraisedBy")) Then txtAppBy.Text = Trim(rs("AppraisedBy"))
                If Not IsDBNull(rs("InsuredValue")) Then txtInsVal.Text = Trim(rs("InsuredValue"))
                If Not IsDBNull(rs("ConditionComments")) Then txtConCom.Text = Trim(rs("ConditionComments"))
                If Not IsDBNull(rs("AdditionalNotes")) Then txtAddNotes.Text = Trim(rs("AdditionalNotes"))

                If Not IsDBNull(rs("dtSold")) Then dtpSold.Value = rs("dtSold")
                If CInt(rs("ItemSold")) = 1 Then
                    _isSold = True
                Else
                    _isSold = False
                End If
                Label34.Visible = _isSold
                dtpSold.Visible = _isSold
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Adds the choke option.
    ''' </summary>
    Sub AddChokeOption()
        If txtChoke.Visible Then Exit Sub
        Dim moveDownXPoints As Integer = 26
        Label35.Visible = True
        txtChoke.Visible = True
        txtChoke.Location = New Point(txtStorage.Location.X, txtStorage.Location.Y)
        Label35.Location = New Point(Label27.Location.X, txtStorage.Location.Y)
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
    ''' Handles the Load event of the frmEditCollectionDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditCollectionDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_Collection_ClassificationTableAdapter.Fill(MGCDataSet.Gun_Collection_Classification)
            Gun_Collection_ConditionTableAdapter.Fill(MGCDataSet.Gun_Collection_Condition)
            If UseNumberCatOnly Then txtCustCatID.Text = 0
            txtPetLoads.Visible = UsePetLoads
            Label12.Visible = UsePetLoads

            If Len(ItemId) <> 0 Then
                Call LoadData()
                Dim objAf As New AutoFillCollections
                txtManu.AutoCompleteCustomSource = objAf.Gun_Manufacturer()
                txtModel.AutoCompleteCustomSource = objAf.Gun_Model
                txtType.AutoCompleteCustomSource = objAf.Gun_Type
                txtCal.AutoCompleteCustomSource = objAf.Gun_Cal
                txtNationality.AutoCompleteCustomSource = objAf.Gun_Nationality
                txtPurchasedFrom.AutoCompleteCustomSource = objAf.Gun_Shop_Details
                txtGripType.AutoCompleteCustomSource = objAf.Gun_GripType
                txtAction.AutoCompleteCustomSource = objAf.Gun_Collection_Action
                txtStorage.AutoCompleteCustomSource = objAf.Gun_Collection_StorageLocation
                txtCustCatID.AutoCompleteCustomSource = objAf.Gun_Collection_CustomID
                txtFeed.AutoCompleteCustomSource = objAf.Gun_Collection_FeedSystem
                txtSights.AutoCompleteCustomSource = objAf.Gun_Collection_Sights
                txtPetLoads.AutoCompleteCustomSource = objAf.Gun_Cal
                txtFinish.AutoCompleteCustomSource = objAf.Gun_Collection_Finish
                txtImporter.AutoCompleteCustomSource = objAf.Gun_Collection_Importer
                txtAppBy.AutoCompleteCustomSource = objAf.Appraisers_Name
                txtCaliber3.AutoCompleteCustomSource = objAf.Gun_Cal
                txtClassIIIOwner.AutoCompleteCustomSource = objAf.Gun_Collection_ClassIIIOwner
                If Not Useselectiveboundbook Then
                    chkBoundBook.Checked = True
                    chkBoundBook.Enabled = False
                End If
            Else
                Close()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
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
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
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
            Dim intIsCandR As Integer = 0
            Dim strPetLoads As String = FluffContent(txtPetLoads.Text)
            Dim strRegion As String = FluffContent(txtNationality.Text)
            Dim strWeight As String = FluffContent(txtWeight.Text)
            Dim strLength As String = FluffContent(txtLength.Text)
            Dim strBarLen As String = FluffContent(txtBarLen.Text)
            Dim strBarWid As String = FluffContent(txtBarWid.Text)
            Dim strBarHei As String = FluffContent(txtBarHei.Text)
            Dim strCustCatId As String = FluffContent(txtCustCatID.Text)
            Dim custIdExists As Boolean = False
            If Len(Trim(strCustCatId)) > 0 Then custIdExists = objGf.CatalogIDExists(strCustCatId, CLng(ItemId))
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
            Dim isDateApp As Boolean = dtpAppDate.Checked
            Dim strAppDate As String = "   "
            If isDateApp Then strAppDate = dtpAppDate.Value
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
            Dim sDateOfCr As String = dtpDateofCR.Value
            Dim iClassIii As Integer = 0
            If chkClassIII.Checked Then iClassIii = 1
            Dim sClassIiiOwner As String = FluffContent(txtClassIIIOwner.Text)

            If Not Disableuniquecustcatid Then If custIdExists Then MsgBox(objGf.CatalogExistsDetails(strCustCatId, CLng(ItemId))) : Exit Sub
            If Not IsRequired(strManu, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Text) Then Exit Sub
            If Not IsRequired(strSerial, "Serial", Text) Then Exit Sub
            If Not IsRequired(strType, "Type", Text) Then Exit Sub
            If Not IsRequired(strCal, "Caliber Or Gauge", Text) Then Exit Sub

            If chkBoxCR.Checked Then intIsCandR = 1

            Dim lngManId As Long = objGf.GetManufacturersID(strManu)
            Dim lngModelId As Long = objGf.GetModelID(strModel, lngManId)
            Dim lngNationalityId As Long = objGf.GetNationalityID(strRegion)
            Dim lngGripId As Long = objGf.GetGripID(strGripType)

            Dim sReManDt As String = dtpReManDT.Value
            Dim sPoi As String = FluffContent(txtPOI.Text)

            Dim sql As String = "UPDATE Gun_Collection set oid=" & OwnerId & ", MID=" & lngManId &
                    ", ModelName='" & strModel & "', ModelID=" & lngModelId & ", SerialNumber='" &
                    strSerial & "', Type='" & strType & "', Caliber='" & strCal & "', Finish='" & strFinish & "', Condition='" &
                    strCondition & "', CustomID=" & objGf.SetCatalogINSType(strCustCatId) & ", NatID=" & lngNationalityId & ", gripid=" & lngGripId &
                    ", Qty=" & strQty & ", Weight='" & strWeight & "', Height='" & strLength & "', StockType='" & strGripType &
                    "', BarrelLength='" & strBarLen & "', BarrelWidth='" & strBarWid & "', BarrelHeight='" &
                    strBarHei & "', Action='" & strAction & "', FeedSystem='" & strfeed & "', Sights='" & strSights &
                    "', PurchasedPrice='" & strPurPrice & "', PurchasedFrom='" & strPurchasedFrom & "', AppraisedValue='" & strAppValue &
                     "', AppraisalDate='" & strAppDate & "', AppraisedBy='" & strAppBy & "', InsuredValue='" & strInsVal & "', StorageLocation='" &
                     strStorage & "', ConditionComments='" & strConCom & "', AdditionalNotes='" & strAddNotes & "', Produced='" &
                     strProduced & "', IsCandR=" & intIsCandR & ", PetLoads='" & strPetLoads &
                    "', dtp='" & strPurDate & "', Importer='" & strImporter & "', " &
                    "ReManDT='" & sReManDt & "', POI='" & sPoi & "', SGChoke='" & sChoke & "',IsInBoundBook=" & iBoundBook &
                    ",lbs_trigger='" & sTrigger & "',TwistRate='" & sTwist & "',Caliber3='" & sCaliber3 &
                    "',Classification='" & sClassification & "',DateofCR='" & sDateOfCr & "', sync_lastupdate=now(),IsClassIII=" &
                    iClassIii & ",ClassIII_owner='" & sClassIiiOwner & "'"
            If _isSold Then sql &= ", dtsold='" & dtpSold.Value & "'"
            sql &= " where ID=" & ItemId
            obj.ConnExec(sql)
            sql = "UPDATE Gun_Collection_Ext set Caliber='" & strCal & "',Finish='" & strFinish &
                    "',BarrelLength='" & strBarLen & "',PetLoads='" & strPetLoads & "',Action='" &
                    strAction & "',Feedsystem='" & strAction & "',Sights='" & strSights &
                    "',PurchasedPrice='" & strPurPrice & "',PurchasedFrom='" & strPurchasedFrom &
                    "',Height='" & strLength & "',Type='" & strType & "', sync_lastupdate=now() where ID=" & BarrelId
            obj.ConnExec(sql)
            If Len(strPurchasedFrom) <> 0 Then
                If Not objGf.ObjectExistsinDB(strPurchasedFrom, "Name", "Gun_Shop_Details") Then
                    Call obj.InsertNewContact(strPurchasedFrom, "Gun_Shop_Details", "Name")
                End If
                Dim gsid As Long = objGf.GetGunShopID(strPurchasedFrom)
                sql = "UPDATE Gun_Collection set SID=" & gsid & ",sync_lastupdate=Now() where ID=" & ItemId
                obj.ConnExec(sql)
            End If

            If Not objGf.ObjectExistsinDB(strAppBy, "aName", "Appriaser_Contact_Details") And Len(strAppBy) > 0 Then
                Call obj.InsertNewContact(strAppBy, "Appriaser_Contact_Details", "aName")
            End If

            If Not objGf.CaliberExists(strCal) Then obj.ConnExec("INSERT INTO Gun_Cal (Cal,sync_lastupdate) VALUES('" & strCal & "',Now())")
            MDIParent1.RefreshCollection()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Enables the disable cand r.
    ''' </summary>
    Sub EnableDiableCandR()
        If chkBoxCR.Checked Then
            dtpReManDT.Enabled = True
            txtPOI.Enabled = True
        Else
            dtpReManDT.Enabled = False
            txtPOI.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the CheckedChanged event of the chkBoxCR control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkBoxCR_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxCR.CheckedChanged
        Call EnableDiableCandR()
    End Sub
End Class