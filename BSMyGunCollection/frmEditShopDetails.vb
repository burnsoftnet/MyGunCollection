Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
''' <summary>
''' Class frmEditShopDetails.  Edit the selected shop
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable once InconsistentNaming
Public Class frmEditShopDetails
    ''' <summary>
    ''' The shop identifier
    ''' </summary>
    Public ShopID As String
    ''' <summary>
    ''' The shop name
    ''' </summary>
    Public ShopName As String
    Sub PopData()
        Try
            Dim Obj As New BSDatabase
            Dim intSIB As Integer = 0
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Shop_Details where ID=" & ShopID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read)
                    If Not IsDBNull(RS("Name")) Then txtName.Text = Trim(RS("Name"))
                    If Not IsDBNull(RS("Address1")) Then txtAddress1.Text = Trim(RS("Address1"))
                    If Not IsDBNull(RS("Address2")) Then txtAddress2.Text = Trim(RS("Address2"))
                    If Not IsDBNull(RS("City")) Then txtCity.Text = Trim(RS("City"))
                    If Not IsDBNull(RS("State")) Then txtState.Text = Trim(RS("State"))
                    If Not IsDBNull(RS("Country")) Then txtCountry.Text = Trim(RS("Country"))
                    If Not IsDBNull(RS("Phone")) Then txtPhone.Text = Trim(RS("Phone"))
                    If Not IsDBNull(RS("fax")) Then txtFax.Text = Trim(RS("fax"))
                    If Not IsDBNull(RS("website")) Then txtWebSite.Text = Trim(RS("website"))
                    If Not IsDBNull(RS("email")) Then txteMail.Text = Trim(RS("email"))
                    If Not IsDBNull(RS("lic")) Then txtLic.Text = Trim(RS("lic"))
                    If Not IsDBNull(RS("Zip")) Then txtZip.Text = Trim(RS("Zip"))
                    intSIB = CInt(RS("SIB"))
                    ShopName = txtName.Text
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
            Dim sSubFunc As String = "PopData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmEditShopDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO - DELETE THIS FORM
        'TODELETE - THis form, was put in the view section.
        Call PopData()
    End Sub

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
            Dim bInBusiness As Boolean = chkSIB.Checked
            Dim intSIB As Integer = 0
            Dim SQL As String = ""
            If Not IsRequired(strName, "Name", Me.Text) Then Exit Sub
            If bInBusiness Then intSIB = 1
            Dim Obj As New BSDatabase
            SQL = "UPDATE Gun_Shop_Details set Name='" & strName & "',Address1='" & strAddress1 & "',Address2='" & _
                    strAddress2 & "',City='" & strCity & "',State='" & strState & "', Zip='" & _
                    strZip & "',Phone='" & strPhone & "', Country='" & strCountry & _
                    "',Fax='" & strFax & "',eMail='" & stremail & "',website='" & _
                    strWebsite & "',Lic='" & strLic & "', SIB=" & intSIB & ",sync_lastupdate=Now() where ID=" & ShopID
            Obj.ConnExec(SQL)
            If String.Compare(FluffContent(ShopName), strName) <> 0 Then
                Dim sAns As String = MsgBox("Shop Name Changed from " & ShopName & " to " & txtName.Text & "!" & Chr(10) & "Do you wish to update all your firearms with the update?", vbYesNo, "ShopID Name Change Alert!")
                If sAns = vbYes Then
                    SQL = "update gun_collection set PurchasedFrom='" & strName & "' where PurchasedFrom='" & FluffContent(ShopName) & "'"
                    Obj.ConnExec(SQL)
                End If
            End If
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class