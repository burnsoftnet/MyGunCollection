Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
''' <summary>
''' Class FrmViewAppraiserDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewAppraiserDetails
    ''' <summary>
    ''' The shop identifier
    ''' </summary>
    Public ShopId As String
    ''' <summary>
    ''' The shop name
    ''' </summary>
    Public ShopName As String
    ''' <summary>
    ''' Pops the data.
    ''' </summary>
    Sub PopData()
        Try
            Dim obj As New BSDatabase
            Dim intSib As Integer
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Appriaser_Contact_Details where ID=" & ShopId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While (rs.Read)
                    If Not IsDBNull(rs("aName")) Then txtName.Text = rs("aName")
                    If Not IsDBNull(rs("Address1")) Then txtAddress1.Text = rs("Address1")
                    If Not IsDBNull(rs("Address2")) Then txtAddress2.Text = rs("Address2")
                    If Not IsDBNull(rs("City")) Then txtCity.Text = rs("City")
                    If Not IsDBNull(rs("State")) Then txtState.Text = rs("State")
                    If Not IsDBNull(rs("Country")) Then txtCountry.Text = rs("Country")
                    If Not IsDBNull(rs("Phone")) Then txtPhone.Text = rs("Phone")
                    If Not IsDBNull(rs("fax")) Then txtFax.Text = rs("fax")
                    If Not IsDBNull(rs("website")) Then txtWebSite.Text = rs("website")
                    If Not IsDBNull(rs("email")) Then txteMail.Text = rs("email")
                    If Not IsDBNull(rs("lic")) Then txtLic.Text = rs("lic")
                    If Not IsDBNull(rs("Zip")) Then txtZip.Text = rs("Zip")
                    ShopName = txtName.Text
                    intSib = CInt(rs("SIB"))
                    If intSib = 1 Then
                        chkSIB.Checked = True
                    Else
                        chkSIB.Checked = False
                    End If
                End While
            Else
                Close()
            End If
            rs.Close()
            Call obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "PopLoad"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Enables the form.
    ''' </summary>
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
    ''' <summary>
    ''' Disables the form.
    ''' </summary>
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
    ''' <summary>
    ''' Handles the Load event of the frmViewAppraiserDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewAppraiserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopData()
        Gun_CollectionTableAdapter.FillBy_AppraisedBy(MGCDataSet.Gun_Collection, txtName.Text)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
            Dim intSib As Integer = 0
            Dim sql As String
            If Not IsRequired(strName, "Name", Text) Then Exit Sub
            If bInBusiness Then intSib = 1
            Dim obj As New BSDatabase
            sql = "UPDATE Appriaser_Contact_Details set aName='" & strName & "',Address1='" & strAddress1 & "',Address2='" & _
                    strAddress2 & "',City='" & strCity & "',State='" & strState & "', Zip='" & _
                    strZip & "',Phone='" & strPhone & "', Country='" & strCountry & _
                    "',Fax='" & strFax & "',eMail='" & stremail & "',website='" & _
                    strWebsite & "',Lic='" & strLic & "', SIB=" & intSib & ",sync_lastupdate=Now() where ID=" & ShopId
            obj.ConnExec(sql)
            If String.Compare(FluffContent(ShopName), strName) <> 0 Then
                Dim sAns As String = MsgBox("Appraisers Name Changed from " & ShopName & " to " & txtName.Text & "!" & Chr(10) & "Do you wish to update all your firearms with the update?", vbYesNo, "Appraiser Name Change Alert!")
                If sAns = vbYes Then
                    sql = "update gun_collection set AppriasedBy='" & strName & "' where AppriasedBy='" & FluffContent(ShopName) & "'"
                    obj.ConnExec(sql)
                End If
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnSave.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Call DisableForm()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call EnabledForm()
    End Sub
End Class