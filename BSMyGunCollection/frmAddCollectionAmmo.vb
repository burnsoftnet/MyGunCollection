''TODO: #43 Clean up unused code
Imports BSMyGunCollection.MGC
'Imports BurnSoft.Applications.MGC
Imports BurnSoft.Applications.MGC.Ammo

''' <summary>
''' Class frmAddCollectionAmmo.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddCollectionAmmo
    ''' <summary>
    ''' Handles the Load event of the frmAddCollectionAmmo control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddCollectionAmmo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            'Dim objAf As New AutoFillCollections
            'txtMan.AutoCompleteCustomSource = objAf.Ammo_Manufacturer
            'txtCal.AutoCompleteCustomSource = objAf.Ammo_Cal
            'txtName.AutoCompleteCustomSource = objAf.Ammo_Name
            'txtGrain.AutoCompleteCustomSource = objAf.Ammo_Grain
            'txtJacket.AutoCompleteCustomSource = objAf.Ammo_Jacket
            Dim errOut as String = ""
            txtMan.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Ammo.Manufacturer(DatabaseName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            txtCal.AutoCompleteCustomSource =BurnSoft.Applications.MGC.AutoFill.Ammo.Caliber(DatabaseName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            txtName.AutoCompleteCustomSource =BurnSoft.Applications.MGC.AutoFill.Ammo.Name(DatabaseName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            txtGrain.AutoCompleteCustomSource =BurnSoft.Applications.MGC.AutoFill.Ammo.Grain(DatabaseName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            txtJacket.AutoCompleteCustomSource =BurnSoft.Applications.MGC.AutoFill.Ammo.Jacket(DatabaseName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            If Not IsNumeric(txtVelocity.Text) Then
                MsgBox("Please input a numeric value for Velocity!")
                Exit Sub
            End If
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strName As String = FluffContent(txtName.Text)
            Dim strCal As String = FluffContent(txtCal.Text)
            Dim strGrain As String = FluffContent(txtGrain.Text)
            Dim strJacket As String = FluffContent(txtJacket.Text)
            Dim strQty As String = CStr(txtQty.Value)
            Dim lVelocity As Long = FluffContent(txtVelocity.Text, 0)
            If Not IsRequired(strMan, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strName, "Name", Text) Then Exit Sub
            If Not IsRequired(strCal, "Caliber", Text) Then Exit Sub
            If Not IsRequired(strGrain, "Grain", Text) Then Exit Sub
            If Not IsRequired(strJacket, "Jacket", Text) Then Exit Sub
            If Not IsRequired(strQty, "Qty", Text) Then Exit Sub
            Dim ddValue As Double = ConvToNum(strGrain)
            Dim obj As New BSDatabase
            Dim sql As String = "INSERT INTO Gun_Collection_Ammo(Manufacturer,Name,Cal,Grain,Jacket,Qty,dcal,vel_n,sync_lastupdate) VALUES('" &
                                strMan & "','" & strName & "','" & strCal & "','" & strGrain & "','" & strJacket & "'," &
                                strQty & "," & ddValue & "," & lVelocity & ",Now())"
            obj.ConnExec(sql)
            Dim errOut As String = ""
            If Not Inventory.Add(DatabasePath, strMan, strName, strCal, strGrain, strJacket, Convert.ToInt32(strQty), ddValue, lVelocity, errOut) Then Throw New Exception(errOut)
            If Auditammo Then
                Dim objGf As New GlobalFunctions
                'Dim aid As Long = objGf.GetLastAmmoID
                Dim aid As Long = Inventory.GetLastAmmoId(DatabasePath, errOut)
                Dim sValue As String = InputBox("How Much did you pay for this box?", "Ammo Audit", 0)
                If Len(sValue) = 0 Then sValue = 0
                Dim ppb As Double = CDbl(sValue) / CLng(strQty)
                'obj.ConnExec("INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,sync_lastupdate) " &
                '            "VALUES(" & aid & ",'" & Now & "'," & strQty & "," & CDbl(sValue) & "," & ppb & ",Now())")
                If Not Audit.Add(DatabasePath, aid, Now,Convert.ToInt32(strQty),Convert.ToInt32(strQty), ppb, "", errOut  ) then Throw New Exception(errOut)
            End If
            MsgBox(strMan & " " & strName & " was added to the database!", MsgBoxStyle.Information, Text)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class