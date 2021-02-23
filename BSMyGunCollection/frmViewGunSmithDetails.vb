Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmViewGunSmithDetails
    Public ShopID As String
    Public ShopName As String
    Sub PopData()
        Try
            Dim Obj As New BSDatabase
            Dim intSIB As Integer = 0
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from GunSmith_Contact_Details where ID=" & ShopID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read)
                    If Not IsDBNull(RS("gName")) Then txtName.Text = RS("gName")
                    If Not IsDBNull(RS("Address1")) Then txtAddress1.Text = RS("Address1")
                    If Not IsDBNull(RS("Address2")) Then txtAddress2.Text = RS("Address2")
                    If Not IsDBNull(RS("City")) Then txtCity.Text = RS("City")
                    If Not IsDBNull(RS("State")) Then txtState.Text = RS("State")
                    If Not IsDBNull(RS("Country")) Then txtCountry.Text = RS("Country")
                    If Not IsDBNull(RS("Phone")) Then txtPhone.Text = RS("Phone")
                    If Not IsDBNull(RS("fax")) Then txtFax.Text = RS("fax")
                    If Not IsDBNull(RS("website")) Then txtWebSite.Text = RS("website")
                    If Not IsDBNull(RS("email")) Then txteMail.Text = RS("email")
                    If Not IsDBNull(RS("lic")) Then txtLic.Text = RS("lic")
                    If Not IsDBNull(RS("Zip")) Then txtZip.Text = RS("Zip")
                    ShopName = txtName.Text
                    intSIB = CInt(RS("SIB"))
                    If intSIB = 1 Then
                        chkSIB.Checked = True
                    Else
                        chkSIB.Checked = False
                    End If
                End While
            Else
                Me.Close()
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Call Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "PopLoad"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmViewGunSmithDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call PopData()
        Me.Gun_Collection_GunSmithsTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_GunSmiths, txtName.Text)
    End Sub
    Sub EnabledForm()
        txtName.ReadOnly = False
        txtAddress1.ReadOnly = False
        txtAddress2.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZip.ReadOnly = False
        txtCountry.ReadOnly = False
        txtPhone.ReadOnly = False
        txtFax.ReadOnly = False
        txteMail.ReadOnly = False
        txtLic.ReadOnly = False
        txtWebSite.ReadOnly = False
        chkSIB.Enabled = True
        btnSave.Visible = True
        btnEdit.Visible = False
    End Sub
    Sub DisableForm()
        txtName.ReadOnly = True
        txtAddress1.ReadOnly = True
        txtAddress2.ReadOnly = True
        txtCity.ReadOnly = True
        txtState.ReadOnly = True
        txtZip.ReadOnly = True
        txtCountry.ReadOnly = True
        txtPhone.ReadOnly = True
        txtFax.ReadOnly = True
        txteMail.ReadOnly = True
        txtLic.ReadOnly = True
        txtWebSite.ReadOnly = True
        chkSIB.Enabled = False
        btnEdit.Visible = True
        btnSave.Visible = False
    End Sub
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Call EnabledForm()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
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
            Dim bInBusiness As Boolean = chkSIB.Checked
            Dim intSIB As Integer = 0
            Dim SQL As String = ""
            If Not IsRequired(strName, "Name", Me.Text) Then Exit Sub
            If bInBusiness Then intSIB = 1
            Dim Obj As New BSDatabase
            SQL = "UPDATE GunSmith_Contact_Details set gName='" & strName & "',Address1='" & strAddress1 & "',Address2='" & _
                    strAddress2 & "',City='" & strCity & "',State='" & strState & "', Zip='" & _
                    strZip & "',Phone='" & strPhone & "', Country='" & strCountry & _
                    "',Fax='" & strFax & "',eMail='" & stremail & "',website='" & _
                    strWebsite & "',Lic='" & strLic & "', SIB=" & intSIB & ",sync_lastupdate=Now() where ID=" & ShopID
            Obj.ConnExec(SQL)
            If String.Compare(FluffContent(ShopName), strName) <> 0 Then
                Dim sAns As String = MsgBox("Gunsmith Name Changed from " & ShopName & " to " & txtName.Text & "!" & Chr(10) & "Do you wish to update all your firearms with the update?", vbYesNo, "Gunsmith Name Change Alert!")
                If sAns = vbYes Then
                    SQL = "update GunSmith_Details set gsmith='" & strName & "' where gsmith='" & FluffContent(ShopName) & "'"
                    Obj.ConnExec(SQL)
                End If
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnSave.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Call DisableForm()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class