Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
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
    ''' The askingprice
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
            If Not IsRequired(strName, "Name", Text) Then Exit Sub
            If Not IsRequired(strAddress1, "Address", Text) Then Exit Sub
            If Not IsRequired(strCity, "City", Text) Then Exit Sub
            If Not IsRequired(strState, "State", Text) Then Exit Sub
            If Not IsRequired(strZip, "Zip Code", Text) Then Exit Sub
            If Not IsRequired(strState, "State", Text) Then Exit Sub
            If Not IsRequired(sLic, sLicType, Text) Then Exit Sub
            If dobRequired Then
                If Not IsRequired(strDob, "Date of Birth", Text) Then Exit Sub
            Else
                strDob = DefaultDob
            End If
            If Not IsRequired(strRes, "Residency/Alien ID", Text) Then Exit Sub
            If Not IsRequired(sFinalPrice, "Final Sale Price", Text) Then Exit Sub

            Dim obj As New BSDatabase
            Dim objo As New GlobalFunctions
            If Not objo.BuyerExists(strName, strAddress1, strAddress2, strCity, strState, strZip, strDob, strDLic) Then
                Dim sql As String = "INSERT INTO Gun_Collection_SoldTo(Name,Address1," & _
                                    "Address2,City,State,Country,Phone,fax,website,email," & _
                                    "lic,DOB,Dlic,Resident,ZipCode,sync_lastupdate) VALUES('" & strName & "','" & _
                                    strAddress1 & "','" & strAddress2 & "','" & strCity & "','" & _
                                    strState & "','" & strCountry & "','" & strPhone & "','" & _
                                    strFax & "','" & strWebsite & "','" & stremail & "','" & _
                                    strLic & "','" & strDob & "','" & strDLic & "','" & _
                                    strRes & "','" & strZip & "',Now())"
                obj.ConnExec(sql)
            End If

            bid = objo.GetID("SELECT ID from Gun_Collection_SoldTo where Name='" & strName & "'")
            Dim uSql As String = "UPDATE Gun_Collection set ItemSold=1,BID=" & bid & ",dtSold='" & dtpSale.Value & "',AppraisedValue='" & sFinalPrice & "',sync_lastupdate=Now() where ID=" & ItemId
            obj.ConnExec(uSql)
            MDIParent1.RefreshCollection()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim obj As New BSDatabase
            Dim sbid As Long = cmbPrevBuyer.SelectedValue
            Dim sql As String = "SELECT * from Gun_Collection_SoldTo where ID=" & sbid
            Call obj.ConnectDB()
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                If Not IsDBNull(rs("Name")) Then txtName.Text = Trim(rs("Name"))
                If Not IsDBNull(rs("Address1")) Then txtAddress1.Text = Trim(rs("Address1"))
                If Not IsDBNull(rs("Address2")) Then txtAddress2.Text = Trim(rs("Address2"))
                If Not IsDBNull(rs("City")) Then txtCity.Text = Trim(rs("City"))
                If Not IsDBNull(rs("ZipCode")) Then txtZip.Text = Trim(rs("ZipCode"))
                If Not IsDBNull(rs("State")) Then txtState.Text = Trim(rs("State"))
                If Not IsDBNull(rs("Phone")) Then txtPhone.Text = Trim(rs("Phone"))
                If Not IsDBNull(rs("Country")) Then txtCountry.Text = Trim(rs("Country"))
                If Not IsDBNull(rs("fax")) Then txtFax.Text = Trim(rs("fax"))
                If Not IsDBNull(rs("email")) Then txteMail.Text = Trim(rs("email"))
                If Not IsDBNull(rs("website")) Then txtWebSite.Text = Trim(rs("website"))
                If Not IsDBNull(rs("lic")) Then txtLic.Text = Trim(rs("lic"))
                If Not IsDBNull(rs("Dlic")) Then txtDLic.Text = Trim(rs("Dlic"))
                If Not IsDBNull(rs("DOB")) Then
                    If rs("DOB") = DefaultDob Then
                        txtDOB.Text = ""
                    Else
                        txtDOB.Text = Trim(rs("DOB"))
                    End If
                End If
                If Not IsDBNull(rs("Resident")) Then txtRes.Text = Trim(rs("Resident"))
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "btnApply.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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