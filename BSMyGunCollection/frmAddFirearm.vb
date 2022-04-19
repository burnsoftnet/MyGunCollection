Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmAddFirearm.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddFirearm
    ''' <summary>
    ''' The error out container
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
    ''' Load the data on the form from start or refresh is available. when you select the copy firearm option to load everything except the importer and the serial number
    ''' </summary>
    Sub LoadData()
        Try
            Dim myData as List(Of GunCollectionList) = BurnSoft.Applications.MGC.Firearms.MyCollection.GetList(DatabasePath, Convert.ToInt32(CopyId), _errOut)
            
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
                txtGripType.Text = o.GripType
                txtProduced.Text = o.DateProduced
                txtAction.Text = o.Action
                txtFeed.Text = o.FeedSystem
                txtSights.Text = o.Sights
                txtStorage.Text = o.StorageLocation
                txtPurchasedFrom.Text = o.PurchaseFrom
                txtPurPrice.Text = o.PurchasePrice
                txtImporter.Text = o.Importer
                txtChoke.Text = o.ShotGunChoke
                chkBoundBook.Checked = o.IsInBoundBook
                txtTwistOfRate.Text = o.TwistRate
                txtTriggerPull.Text = o.TriggerPullInPounds
                txtCaliber3.Text = o.Caliber3
                cmbClassification.Text = o.Classification
                chkBoxCR.Checked = o.IsCAndR
                dtpDateofCR.Checked = o.DateOfCAndR.Length > 0
                dtpDateofCR.Value = o.DateOfCAndR
                dtpDateofCR.Enabled = dtpDateofCR.Checked 
                dtpPurchased.Value = o.DateTimeAdded
                dtpPurchased.Checked = o.DateTimeAdded.Length > 0
                dtpPurchased.Enabled = dtpPurchased.Checked 
                txtAppValue.Text = o.AppriasedValue
                dtpAppDate.Value = o.AppraisalDate
                dtpAppDate.Checked = o.AppraisalDate.Length > 0
                dtpAppDate.Enabled = dtpAppDate.Checked
                txtAppBy.Text = o.AppriasedBy
                txtInsVal.Text = o.InsuredValue
                txtConCom.Text = o.ConditionComments
                txtAddNotes.Text = o.AdditionalNotes
            Next
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
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
            Call LogError(Name, "DoAutoFill", Err.Number, ex.Message.ToString)
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
                    txtCustCatID.Text = BurnSoft.Applications.MGC.Firearms.MyCollection.GetCatalogNextIdNumber(DatabasePath, _errOut)
                    If _errOut.Length > 0 Then Throw New Exception(_errOut)
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
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strManu As String = FluffContent(txtManu.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSerial As String = FluffContent(txtSerial.Text)
            Dim strType As String = FluffContent(txtType.Text)
            Dim strCal As String = FluffContent(txtCal.Text)
            Dim strFinish As String = FluffContent(txtFinish.Text)
            Dim strCondition As String = FluffContent(cmdCondition.SelectedValue)
            Dim strPetLoads As String = FluffContent(txtPetLoads.Text)
            Dim strRegion As String = FluffContent(txtNationality.Text)
            Dim strWeight As String = FluffContent(txtWeight.Text)
            Dim strLength As String = FluffContent(txtLength.Text)
            Dim strBarLen As String = FluffContent(txtBarLen.Text)
            Dim strBarWid As String = FluffContent(txtBarWid.Text)
            Dim strBarHei As String = FluffContent(txtBarHei.Text)
            Dim strCustCatId As String = FluffContent(txtCustCatID.Text)
            Dim sChoke As String = FluffContent(txtChoke.Text)
            Dim custIdExists As Boolean = False
            If Len(Trim(strCustCatId)) > 0 Then
                If UseNumberCatOnly Then
                    custIdExists = BurnSoft.Applications.MGC.Firearms.MyCollection.CatalogIDExists(DatabasePath,Convert.ToInt32(strCustCatId), _errOut)
                Else 
                    custIdExists = BurnSoft.Applications.MGC.Firearms.MyCollection.CatalogIDExists(DatabasePath,strCustCatId, _errOut)
                End If
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            End If
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
            Dim sTwist As String = FluffContent(txtTwistOfRate.Text)
            Dim sTrigger As String = FluffContent(txtTriggerPull.Text)
            Dim sClassification As String = FluffContent(cmbClassification.Text)
            Dim sDateOfCr As String = dtpDateofCR.Value
            Dim sClassIiiOwner As String = FluffContent(txtClassIIIOwner.Text)

            If Not Disableuniquecustcatid Then If custIdExists Then MsgBox(BurnSoft.Applications.MGC.Firearms.MyCollection.CatalogExistsDetails(DatabasePath, strCustCatId, _errOut)) : Exit Sub
    
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            If Not Helpers.IsRequired(strManu, "Manufacturer", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strModel, "Model", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strSerial, "Serial", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strType, "Type", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strCal, "Caliber Or Gauge", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strPurchasedFrom, "Purchased From", Text, _errOut) Then Exit Sub

            If Len(Trim(strPurPrice)) > 0 And Len(Trim(strAppValue)) = 0 Then strAppValue = strPurPrice
            Dim strFullName As String = strManu & " " & strModel

            Dim lngManId As Long = BurnSoft.Applications.MGC.Firearms.Manufacturers.GetId(DatabasePath,strManu, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim lngModelId As Long = BurnSoft.Applications.MGC.Firearms.Models.GetId(DatabasePath,strModel, lngManId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim lngNationalityId As Long = BurnSoft.Applications.MGC.Firearms.Nationality.GetId(DatabasePath, strRegion, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim lngGripId As Long = BurnSoft.Applications.MGC.Firearms.Grips.GetId(DatabasePath,strGripType, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Call BurnSoft.Applications.MGC.Firearms.GunTypes.UpdateGunType(DatabasePath, strType, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
 
            if Not BurnSoft.Applications.MGC.Firearms.MyCollection.Add(DatabasePath, UseNumberCatOnly, OwnerId, lngManId, strFullName, strModel, lngModelId, strSerial,
                                                                       strType,strCal, strFinish, strCondition, strCustCatId, lngNationalityId, lngGripId, strWeight,
                                                                       strLength, strGripType, strBarLen, strBarWid, strBarHei, strAction, strfeed, strSights, strPurPrice,
                                                                       strPurchasedFrom, strAppValue, strAppDate, strAppBy, strInsVal, strStorage, strConCom, strAddNotes,
                                                                       strProduced, strPetLoads, strPurDate, chkBoxCR.Checked, strImporter, sReManDt, sPoi, 
                                                                       sChoke, chkBoundBook.Checked, sTwist, sTrigger, sCaliber3, sClassification, sDateOfCr,
                                                                       chkClassIII.Checked,sClassIiiOwner,chkIsCompeition.Checked,chkNonLethal.Checked, _errOut) Then Throw New Exception(_errOut)

            Lastviewedfirearm = BurnSoft.Applications.MGC.Firearms.MyCollection.GetLastId(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            MDIParent1.RefreshCollection()
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
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
        If txtType.Text.Contains("shotgun") Then Call AddChokeOption()
    End Sub

End Class