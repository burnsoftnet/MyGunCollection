Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Types


''' <summary>
''' Class frmEditCollectionDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditCollectionDetails
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The is sold
    ''' </summary>
' ReSharper disable once UnassignedField.Local
    Dim _isSold As Boolean
    ''' <summary>
    ''' The barrel identifier
    ''' </summary>
    Public BarrelId As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String = ""

    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim lst As List(Of GunCollectionList) = BurnSoft.Applications.MGC.Firearms.MyCollection.GetList(DatabasePath, ItemId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

            For Each o As GunCollectionList In lst
                Text = o.FullName
                txtManu.Text = o.Manufacturer
                txtModel.Text = o.ModelName
                txtSerial.Text = o.SerialNumber
                txtType.Text = o.Type
                If txtType.Text.Contains("shotgun") Then Call AddChokeOption()
                txtCal.Text = o.Caliber
                txtFinish.Text = o.Finish
                cmdCondition.Text = o.Condition
                txtPetLoads.Text = o.PetLoads
                txtNationality.Text = o.Nationality
                txtWeight.Text = o.Weight
                txtLength.Text = o.Height
                txtBarLen.Text = o.BarrelLength
                txtBarWid.Text  = o.BarrelWidth
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
                BarrelId = BarrelId
                txtChoke.Text = o.ShotGunChoke
                chkBoundBook.Checked = o.IsInBoundBook
                txtTwistOfRate.Text = o.TwistRate
                txtTriggerPull.Text = o.TriggerPullInPounds
                txtCaliber3.Text = o.Caliber3
                cmbClassification.Text = o.Classification
                If o.DateOfCAndR.Length > 0 Then
                    dtpDateofCR.Checked = True
                    dtpDateofCR.Value = o.DateOfCAndR
                    dtpDateofCR.Enabled = True
                End If
                txtClassIIIOwner.Text = o.Class3Owner
                chkClassIII.Checked = o.IsClass3Item
                chkBoxCR.Checked = o.IsCAndR
                If o.RemanufactureDate.Length > 0 Then
                    dtpReManDT.Checked = True
                    dtpReManDT.Value = o.RemanufactureDate
                    dtpReManDT.Enabled = True
                End If
                txtPOI.Text = o.Poi
                Call EnableDiableCandR()
                If o.DateTimeAdded.Length > 0 Then
                    dtpPurchased.Checked = True
                    dtpPurchased.Value = o.DateTimeAdded
                    dtpPurchased.Enabled = True
                End If
                txtAppValue.Text = o.AppriasedValue
                If o.AppraisalDate.Length > 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = o.AppraisalDate
                    dtpAppDate.Enabled = True
                End If
                txtAppBy.Text = o.AppriasedBy
                txtInsVal.Text = o.InsuredValue
                txtConCom.Text = o.ConditionComments
                txtAddNotes.Text = o.AdditionalNotes
                if o.ItemSold Then  dtpSold.Value = o.DateSold
                Label34.Visible = o.ItemSold
                dtpSold.Visible = o.ItemSold
                chkIsCompeition.Checked = o.IsCompetition
                chkNonLethal.Checked = o.IsNonLethal
            Next

        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
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
                
                txtManu.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Manufacturer(DatabasePath, _errOut)
                txtModel.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Model(DatabasePath, _errOut)
                txtType.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Type(DatabasePath, _errOut)
                txtCal.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Cal(DatabasePath, _errOut)
                txtNationality.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Nationality(DatabasePath, _errOut)
                txtPurchasedFrom.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.ShopDetails(DatabasePath, _errOut)
                txtGripType.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.GripType(DatabasePath, _errOut)
                txtAction.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.Action(DatabasePath, _errOut)
                txtStorage.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.StorageLocation(DatabasePath, _errOut)
                txtCustCatID.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.CustomId(DatabasePath, _errOut)
                txtFeed.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.Feedsystem(DatabasePath, _errOut)
                txtSights.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.Sights(DatabasePath, _errOut)
                txtPetLoads.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Cal(DatabasePath, _errOut)
                txtFinish.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.Finish(DatabasePath, _errOut)
                txtImporter.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.Importer(DatabasePath, _errOut)
                txtAppBy.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Appraisers.Name(DatabasePath, _errOut)
                txtCaliber3.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Cal(DatabasePath, _errOut)
                txtClassIIIOwner.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunCollection.ClassIII_owner(DatabasePath, _errOut)

                If Not Useselectiveboundbook Then
                    chkBoundBook.Checked = True
                    chkBoundBook.Enabled = False
                End If
            Else
                Close()
            End If
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
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
            Dim custIdExists As Boolean = False
            If Len(Trim(strCustCatId)) > 0 Then
                If UseNumberCatOnly Then
                    custIdExists = BurnSoft.Applications.MGC.Firearms.MyCollection.CatalogIDExists(DatabasePath,Convert.ToInt32(strCustCatId), _errOut)
                Else 
                    custIdExists = BurnSoft.Applications.MGC.Firearms.MyCollection.CatalogIDExists(DatabasePath,strCustCatId, _errOut)
                End If
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            End If
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
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
            Dim sTwist As String = FluffContent(txtTwistOfRate.Text)
            Dim sTrigger As String = FluffContent(txtTriggerPull.Text)
            Dim sClassification As String = FluffContent(cmbClassification.Text)
            Dim sDateOfCr As String = dtpDateofCR.Value
            Dim sClassIiiOwner As String = FluffContent(txtClassIIIOwner.Text)
            
            If Not Disableuniquecustcatid Then If custIdExists Then MsgBox(BurnSoft.Applications.MGC.Firearms.MyCollection.CatalogExistsDetails(DatabasePath, strCustCatId, _errOut)) : Exit Sub

            If Not Helpers.IsRequired(strManu, "Manufacturer", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strModel, "Model", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strSerial, "Serial", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strType, "Type", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strCal, "Caliber Or Gauge", Text, _errOut) Then Exit Sub


            Dim lngManId As Long = BurnSoft.Applications.MGC.Firearms.Manufacturers.GetId(DatabasePath,strManu, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim lngModelId As Long = BurnSoft.Applications.MGC.Firearms.Models.GetId(DatabasePath,strModel, lngManId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim lngNationalityId As Long = BurnSoft.Applications.MGC.Firearms.Nationality.GetId(DatabasePath, strRegion, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Dim lngGripId As Long = BurnSoft.Applications.MGC.Firearms.Grips.GetId(DatabasePath,strGripType, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

            Dim sReManDt As String = dtpReManDT.Value
            Dim sPoi As String = FluffContent(txtPOI.Text)

            if Not BurnSoft.Applications.MGC.Firearms.MyCollection.Update(DatabasePath, Convert.ToInt32(ItemId), UseNumberCatOnly,
                                                                          Convert.ToInt32(OwnerId), lngManId, strModel, lngModelId,
                                                                          strSerial, strType, strCal, strFinish, strCondition,strCustCatId,
                                                                          lngNationalityId, lngGripId, strWeight, strLength, strGripType,
                                                                          strBarLen, strBarWid, strBarHei, strAction, strfeed, strSights,
                                                                          strPurPrice,strPurchasedFrom, strAppValue, strAppDate, strAppBy,
                                                                          strInsVal, strStorage, strConCom, strAddNotes, strProduced, strPetLoads,
                                                                          strPurDate, chkBoxCR.Checked, strImporter, sReManDt, sPoi, sChoke, 
                                                                          chkBoundBook.Checked, sTwist, sTrigger, sCaliber3, sClassification,
                                                                          sDateOfCr, chkClassIII.Checked, _isSold, dtpSold.Value,sClassIiiOwner,chkIsCompeition.Checked,chkNonLethal.Checked, _errOut) Then Throw New Exception(_errOut)

                MDIParent1.RefreshCollection()
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnUpdate.Click", Err.Number, ex.Message.ToString)
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