Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmViewBuyerDetails
    Public BuyerID As String
    Sub LoadSellerData()
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_SoldTo where ID=" & BuyerID
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
                If Not IsDBNull(RS("Fax")) Then txtFax.Text = Trim(RS("Fax"))
                If Not IsDBNull(RS("eMail")) Then txteMail.Text = Trim(RS("eMail"))
                If Not IsDBNull(RS("WebSite")) Then txtWebSite.Text = Trim(RS("WebSite"))
                If Not IsDBNull(RS("Lic")) Then txtLic.Text = Trim(RS("Lic"))
                If Not IsDBNull(RS("DLic")) Then txtDLic.Text = Trim(RS("DLic"))
                If Not IsDBNull(RS("DOB")) Then
                    If RS("DOB") = DefaultDob Then
                        txtDOB.Text = ""
                    Else
                        txtDOB.Text = Trim(RS("DOB"))
                    End If
                End If
                If Not IsDBNull(RS("ResiDent")) Then txtRes.Text = Trim(RS("ResiDent"))
            End While
            RS.Close()
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadSellerData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmViewBuyerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Gun_CollectionTableAdapter.FillByBuyer(Me.MGCDataSet.Gun_Collection, BuyerID)
            Call LoadSellerData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanel.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
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
            Dim BID As Long = CLng(BuyerID)
            Dim DOBRequired As Boolean = False
            Dim sLic As String = ""
            Dim sLic_type As String = "FFL License or Drivers License/Other"
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
                strDOB = DefaultDob
            End If
            If Not IsRequired(strRes, "Residency", Me.Text) Then Exit Sub
            Dim Obj As New BSDatabase
            Dim SQL As String = "UPDATE Gun_Collection_SoldTo set Name='" & strName & "',Address1='" & strAddress1 & _
                                "',Address2='" & strAddress2 & "',City='" & strCity & "',State='" & strState & "',Country='" & _
                                strCountry & "',Phone='" & strPhone & "',fax='" & strFax & "',website='" & strWebsite & _
                                "',email='" & stremail & "',lic='" & strLic & "',DOB='" & strDOB & "',Dlic='" & strDLic & _
                                "',Resident='" & strRes & "',ZipCode='" & strZip & "' where ID=" & BID
            Obj.ConnExec(SQL)
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
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class