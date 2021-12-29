Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class FrmViewBuyerDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewBuyerDetails
    ''TODO: #50 Convert This Section
    ''' <summary>
    ''' The buyer identifier
    ''' </summary>
    Public BuyerId As String
    ''' <summary>
    ''' Loads the seller data.
    ''' </summary>
    Sub LoadSellerData()
        Try
            Dim errOut as String = ""
            Dim lst As List(Of BuyersList) = Buyers.Get(DatabasePath, Convert.ToInt32(BuyerId), errOut)
            if errOut.Length > 0 Then Throw New Exception(errOut)
            For Each l As BuyersList In lst
                txtName.Text = l.Name
                txtAddress1.Text = l.Address1
                txtAddress2.Text = l.Address2
                txtCity.Text = l.City
                txtState.Text = l.State
                txtCountry.Text =l.Country
                txtPhone.Text = l.Phone
                txtFax.Text = l.Fax
                txtWebSite.Text = l.WebSite
                txteMail.Text = l.Email
                txtLic.Text = l.Lic
                txtZip.Text = l.ZipCode
                txtDLic.Text = l.Dlic
                txtDOB.Text = l.Dob
                If l.Dob.Equals(DefaultDob) Then txtDOB.Text = ""
                txtRes.Text = l.Resident
            Next

            'Dim obj As New BSDatabase
            'Call obj.ConnectDB()
            'Dim sql As String = "SELECT * from Gun_Collection_SoldTo where ID=" & BuyerId
            'Dim cmd As New OdbcCommand(sql, obj.Conn)
            'Dim rs As OdbcDataReader
            'rs = cmd.ExecuteReader
            'While rs.Read
            '    If Not IsDBNull(rs("Name")) Then txtName.Text = Trim(rs("Name"))
            '    If Not IsDBNull(rs("Address1")) Then txtAddress1.Text = Trim(rs("Address1"))
            '    If Not IsDBNull(rs("Address2")) Then txtAddress2.Text = Trim(rs("Address2"))
            '    If Not IsDBNull(rs("City")) Then txtCity.Text = Trim(rs("City"))
            '    If Not IsDBNull(rs("ZipCode")) Then txtZip.Text = Trim(rs("ZipCode"))
            '    If Not IsDBNull(rs("State")) Then txtState.Text = Trim(rs("State"))
            '    If Not IsDBNull(rs("Phone")) Then txtPhone.Text = Trim(rs("Phone"))
            '    If Not IsDBNull(rs("Country")) Then txtCountry.Text = Trim(rs("Country"))
            '    If Not IsDBNull(rs("Fax")) Then txtFax.Text = Trim(rs("Fax"))
            '    If Not IsDBNull(rs("eMail")) Then txteMail.Text = Trim(rs("eMail"))
            '    If Not IsDBNull(rs("WebSite")) Then txtWebSite.Text = Trim(rs("WebSite"))
            '    If Not IsDBNull(rs("Lic")) Then txtLic.Text = Trim(rs("Lic"))
            '    If Not IsDBNull(rs("DLic")) Then txtDLic.Text = Trim(rs("DLic"))
            '    If Not IsDBNull(rs("DOB")) Then
            '        If rs("DOB") = DefaultDob Then
            '            txtDOB.Text = ""
            '        Else
            '            txtDOB.Text = Trim(rs("DOB"))
            '        End If
            '    End If
            '    If Not IsDBNull(rs("ResiDent")) Then txtRes.Text = Trim(rs("ResiDent"))
            'End While
            'rs.Close()

            'obj.CloseDB()
        Catch ex As Exception
            Call LogError(Name, "LoadSellerData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewBuyerDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewBuyerDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_CollectionTableAdapter.FillByBuyer(MGCDataSet.Gun_Collection, BuyerId)
            Call LoadSellerData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCanel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCanel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        txtName.ReadOnly = False
        txtAddress1.ReadOnly = False
        txtAddress2.ReadOnly = False
        txtCity.ReadOnly = False
        txtZip.ReadOnly = False
        txtState.ReadOnly = False
        txtPhone.ReadOnly = False
        txtCountry.ReadOnly = False
        txtFax.ReadOnly = False
        txteMail.ReadOnly = False
        txtWebSite.ReadOnly = False
        txtLic.ReadOnly = False
        txtDLic.ReadOnly = False
        txtDOB.ReadOnly = False
        txtRes.ReadOnly = False
        btnUpdate.Visible = True
        btnEdit.Visible = False
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim errOut As String = ""
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
            Dim bid As Long = CLng(BuyerId)
            Dim dobRequired As Boolean = False
            Dim sLic As String = ""
            Dim sLicType As String = "FFL License or Drivers License/Other"
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
            If Not Helpers.IsRequired(strRes, "Residency", Text, errOut) Then Exit Sub
            If Not Buyers.Update(DatabasePath, bid, strName, strAddress1, strAddress2, strCity, strState, strZip, strPhone,
                                 strCountry, stremail, strLic, strWebsite, strFax, strDob, strDLic, strRes, errOut) Then Throw New Exception(errOut)
            'Dim obj As New BSDatabase
            'Dim sql As String = "UPDATE Gun_Collection_SoldTo set Name='" & strName & "',Address1='" & strAddress1 & _
            '                    "',Address2='" & strAddress2 & "',City='" & strCity & "',State='" & strState & "',Country='" & _
            '                    strCountry & "',Phone='" & strPhone & "',fax='" & strFax & "',website='" & strWebsite & _
            '                    "',email='" & stremail & "',lic='" & strLic & "',DOB='" & strDob & "',Dlic='" & strDLic & _
            '                    "',Resident='" & strRes & "',ZipCode='" & strZip & "' where ID=" & bid
            'obj.ConnExec(sql)
            txtName.ReadOnly = True
            txtAddress1.ReadOnly = True
            txtAddress2.ReadOnly = True
            txtCity.ReadOnly = True
            txtZip.ReadOnly = True
            txtState.ReadOnly = True
            txtPhone.ReadOnly = True
            txtCountry.ReadOnly = True
            txtFax.ReadOnly = True
            txteMail.ReadOnly = True
            txtWebSite.ReadOnly = True
            txtLic.ReadOnly = True
            txtDLic.ReadOnly = True
            txtDOB.ReadOnly = True
            txtRes.ReadOnly = True
            btnUpdate.Visible = False
            btnEdit.Visible = True
        Catch ex As Exception
            Call LogError(Name, "btnUpdate.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class