Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class FrmSold.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmSold
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The asking price
    ''' </summary>
    Public Askingprice As String
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            Dim strAddress1 As String = FluffContent(txtAddress1.Text)
            Dim strAddress2 As String = FluffContent(txtAddress2.Text)
            Dim strCity As String = FluffContent(txtCity.Text)
            Dim strZip As String = FluffContent(txtZip.Text)
            Dim strState As String = FluffContent(txtState.Text)
            Dim strPhone As String = FluffContent(txtPhone.Text)
            Dim strCountry As String = FluffContent(txtCountry.Text)
            Dim strFax As String = FluffContent(txtFax.Text)
            Dim stremail As String = FluffContent(txteMail.Text)
            Dim strWebsite As String = FluffContent(txtWebSite.Text)
            Dim strLic As String = FluffContent(txtLic.Text)
            Dim strDLic As String = FluffContent(txtDLic.Text)
            Dim strDob As String = FluffContent(txtDOB.Text)
            Dim strRes As String = FluffContent(txtRes.Text)
            Dim sFinalPrice As String = FluffContent(txtPrice.Text)
            Dim bid As Long
            Dim sLic As String = ""
            Dim sLicType As String = "FFL License or Drivers License/Other"
            Dim dobRequired As Boolean = False
            If Len(Trim(strDLic)) > 0 Then
                sLic = strDLic
                sLicType = "Drivers License/Other"
                dobRequired = True
            Else
                If Len(Trim(strLic)) > 0 Then
                    sLic = strLic
                    sLicType = "FFL License"
                    dobRequired = False
                End If
            End If
            Dim errOut as String = ""
            If Not Helpers.IsRequired(strName, "Name", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strAddress1, "Address", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strCity, "City", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strState, "State", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strZip, "Zip Code", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strState, "State", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(sLic, sLicType, Text, errOut) Then Exit Sub
            If dobRequired Then
                If Not Helpers.IsRequired(strDob, "Date of Birth", Text, errOut) Then Exit Sub
            Else
                strDob = DefaultDob
            End If
            If Not Helpers.IsRequired(strRes, "Residency/Alien ID", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(sFinalPrice, "Final Sale Price", Text, errOut) Then Exit Sub

            if Not BurnSoft.Applications.MGC.PeopleAndPlaces.Buyers.Exists(DatabasePath,strName, strAddress1, strAddress2, strCity, strState, strZip, strDob, strDLic, errOut) Then
                If Not BurnSoft.Applications.MGC.PeopleAndPlaces.Buyers.Add(DatabasePath, strName, strAddress1, strAddress2, strCity, strState, strZip, strPhone, strCountry, stremail, strLic, strWebsite, strFax, strDob, strDLic, strRes, errOut) then Throw New Exception(errOut)
            End If
            bid = BurnSoft.Applications.MGC.PeopleAndPlaces.Buyers.GetId(DatabasePath, strName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            If Not BurnSoft.Applications.MGC.PeopleAndPlaces.Buyers.FirearmBought(DatabasePath, ItemId, bid, dtpSale.Value, sFinalPrice, errOut) Then Throw New Exception(errOut)

            MDIParent1.RefreshCollection()
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnUpdate.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmSold control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmSold_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Gun_Collection_SoldToTableAdapter.Fill(MGCDataSet.Gun_Collection_SoldTo)
        If Len(Askingprice) > 0 Then txtPrice.Text = Askingprice
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnApply control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
        Try
            Dim sbid As Long = cmbPrevBuyer.SelectedValue
            Dim errOut as String = ""
            Dim lst As List(Of BuyersList) = BurnSoft.Applications.MGC.PeopleAndPlaces.Buyers.Get(DatabasePath, sbid, errOut)

            For Each o As BuyersList In lst
                txtName.Text = o.Name
                txtAddress1.Text = o.Address1
                txtAddress2.Text = o.Address2
                txtCity.Text = o.City
                txtState.Text = o.State
                txtZip.Text = o.ZipCode
                txtPhone.Text = o.Phone
                txtCountry.Text = o.Country
                txtFax.Text = o.Fax
                txteMail.Text = o.Email
                txtWebSite.Text = o.WebSite
                txtLic.Text = o.Lic
                txtDLic.Text = o.Dlic
                txtDOB.Text = o.Dob
                txtRes.Text = o.Resident
            Next
        Catch ex As Exception
            Call LogError(Name,  "btnApply.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnNA control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnNA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNA.Click
        txtAddress1.Text = $"N/A"
        txtAddress2.Text = $"N/A"
        txtCity.Text = $"N/A"
        txtState.Text = $"N/A"
        txtZip.Text = $"N/A"
        txtCountry.Text = $"N/A"
        txtPhone.Text = $"N/A"
        txtFax.Text = $"N/A"
        txtWebSite.Text = $"N/A"
        txteMail.Text = $"N/A"
        txtDLic.Text = $"N/A"
        txtDOB.Text = $"1/1/1911"
        txtRes.Text = $"USA"
    End Sub
End Class