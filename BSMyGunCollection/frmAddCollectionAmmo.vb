Imports BurnSoft.Applications.MGC.Ammo
Imports BurnSoft.Applications.MGC.Global

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
            Dim errOut As String = ""
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strName As String = FluffContent(txtName.Text)
            Dim strCal As String = FluffContent(txtCal.Text)
            Dim strGrain As String = FluffContent(txtGrain.Text)
            Dim strJacket As String = FluffContent(txtJacket.Text)
            Dim strQty As String = CStr(txtQty.Value)
            Dim lVelocity As Long = FluffContent(txtVelocity.Text, 0)
            If Not Helpers.IsRequired(strMan, "Manufacturer", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strName, "Name", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strCal, "Caliber", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strGrain, "Grain", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strJacket, "Jacket", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strQty, "Qty", Text, errOut) Then Exit Sub
            'Dim ddValue As Double = ConvToNum(strGrain)
            Dim ddValue As Double = Helpers.ConvertTextToNumber(strGrain, errOut)
            if errOut.Length > 0 Then Throw New Exception(errOut)

            If Not Inventory.Add(DatabasePath, strMan, strName, strCal, strGrain, strJacket, Convert.ToInt32(strQty), ddValue, lVelocity, errOut) Then Throw New Exception(errOut)
            If Auditammo Then
                Dim aid As Long = Inventory.GetLastAmmoId(DatabasePath, errOut)
                Dim sValue As String = InputBox("How Much did you pay for this box?", "Ammo Audit", 0)
                If Len(sValue) = 0 Then sValue = 0
                Dim ppb As Double = CDbl(sValue) / CLng(strQty)
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