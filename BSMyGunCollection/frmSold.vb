Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmSold
    Public ItemID As String
    Public ASKINGPRICE As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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
            Dim strDOB As String = FluffContent(txtDOB.Text)
            Dim strRes As String = FluffContent(txtRes.Text)
            Dim sFinalPrice As String = FluffContent(txtPrice.Text)
            Dim BID As Long = 0
            Dim sLic As String = ""
            Dim sLic_type As String = "FFL License or Drivers License/Other"
            Dim DOBRequired As Boolean = False
            If Len(Trim(strDLic)) > 0 Then
                sLic = strDLic
                sLic_type = "Drivers License/Other"
                DOBRequired = True
            Else
                If Len(Trim(strLic)) > 0 Then
                    sLic = strLic
                    sLic_type = "FFL License"
                    DOBRequired = False
                End If
            End If
            If Not IsRequired(strName, "Name", Me.Text) Then Exit Sub
            If Not IsRequired(strAddress1, "Address", Me.Text) Then Exit Sub
            If Not IsRequired(strCity, "City", Me.Text) Then Exit Sub
            If Not IsRequired(strState, "State", Me.Text) Then Exit Sub
            If Not IsRequired(strZip, "Zip Code", Me.Text) Then Exit Sub
            If Not IsRequired(strState, "State", Me.Text) Then Exit Sub
            If Not IsRequired(sLic, sLic_type, Me.Text) Then Exit Sub
            If DOBRequired Then
                If Not IsRequired(strDOB, "Date of Birth", Me.Text) Then Exit Sub
            Else
                strDOB = DEFAULT_DOB
            End If
            If Not IsRequired(strRes, "Residency/Alien ID", Me.Text) Then Exit Sub
            If Not IsRequired(sFinalPrice, "Final Sale Price", Me.Text) Then Exit Sub

            Dim Obj As New BSDatabase
            Dim Objo As New GlobalFunctions
            If Not Objo.BuyerExists(strName, strAddress1, strAddress2, strCity, strState, strZip, strDOB, strDLic) Then
                Dim SQL As String = "INSERT INTO Gun_Collection_SoldTo(Name,Address1," & _
                                    "Address2,City,State,Country,Phone,fax,website,email," & _
                                    "lic,DOB,Dlic,Resident,ZipCode,sync_lastupdate) VALUES('" & strName & "','" & _
                                    strAddress1 & "','" & strAddress2 & "','" & strCity & "','" & _
                                    strState & "','" & strCountry & "','" & strPhone & "','" & _
                                    strFax & "','" & strWebsite & "','" & stremail & "','" & _
                                    strLic & "','" & strDOB & "','" & strDLic & "','" & _
                                    strRes & "','" & strZip & "',Now())"
                Obj.ConnExec(SQL)
            End If
            BID = Objo.GetID("SELECT ID from Gun_Collection_SoldTo where Name='" & strName & "'")
            Dim uSQL As String = "UPDATE Gun_Collection set ItemSold=1,BID=" & BID & ",dtSold='" & dtpSale.Value & "',AppraisedValue='" & sFinalPrice & "',sync_lastupdate=Now() where ID=" & ItemID
            Obj.ConnExec(uSQL)
            MDIParent1.RefreshCollection()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gun_Collection_SoldToTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_SoldTo)
        If Len(ASKINGPRICE) > 0 Then txtPrice.Text = ASKINGPRICE
    End Sub
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Try
            Dim Obj As New BSDatabase
            Dim SBID As Long = cmbPrevBuyer.SelectedValue
            Dim SQL As String = "SELECT * from Gun_Collection_SoldTo where ID=" & SBID
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                If Not IsDBNull(RS("Name")) Then txtName.Text = Trim(RS("Name"))
                If Not IsDBNull(RS("Address1")) Then txtAddress1.Text = Trim(RS("Address1"))
                If Not IsDBNull(RS("Address2")) Then txtAddress2.Text = Trim(RS("Address2"))
                If Not IsDBNull(RS("City")) Then txtCity.Text = Trim(RS("City"))
                If Not IsDBNull(RS("ZipCode")) Then txtZip.Text = Trim(RS("ZipCode"))
                If Not IsDBNull(RS("State")) Then txtState.Text = Trim(RS("State"))
                If Not IsDBNull(RS("Phone")) Then txtPhone.Text = Trim(RS("Phone"))
                If Not IsDBNull(RS("Country")) Then txtCountry.Text = Trim(RS("Country"))
                If Not IsDBNull(RS("fax")) Then txtFax.Text = Trim(RS("fax"))
                If Not IsDBNull(RS("email")) Then txteMail.Text = Trim(RS("email"))
                If Not IsDBNull(RS("website")) Then txtWebSite.Text = Trim(RS("website"))
                If Not IsDBNull(RS("lic")) Then txtLic.Text = Trim(RS("lic"))
                If Not IsDBNull(RS("Dlic")) Then txtDLic.Text = Trim(RS("Dlic"))
                If Not IsDBNull(RS("DOB")) Then
                    If RS("DOB") = DEFAULT_DOB Then
                        txtDOB.Text = ""
                    Else
                        txtDOB.Text = Trim(RS("DOB"))
                    End If
                End If
                If Not IsDBNull(RS("Resident")) Then txtRes.Text = Trim(RS("Resident"))
            End While
            RS.Close()
            RS = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "btnApply.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnNA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNA.Click
        txtAddress1.Text = "N/A"
        txtAddress2.Text = "N/A"
        txtCity.Text = "N/A"
        txtState.Text = "N/A"
        txtZip.Text = "N/A"
        txtCountry.Text = "N/A"
        txtPhone.Text = "N/A"
        txtFax.Text = "N/A"
        txtWebSite.Text = "N/A"
        txteMail.Text = "N/A"
        txtDLic.Text = "N/A"
        txtDOB.Text = "1/1/1911"
        txtRes.Text = "USA"
    End Sub
End Class