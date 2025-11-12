Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Types
Imports BurnSoft.Applications.MGC
''' <summary>
''' Class frmEditAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditAccessory
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The gun identifier
    ''' </summary>
    Public GunId as Long
    ''' <summary>
    ''' The is shot gun
    ''' </summary>
    Public IsShotGun As Boolean
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String
    ''' <summary>
    ''' Toggle on when used for General Accessories, otherwise it assumes for firearm.
    ''' </summary>
    Public IsGeneral as Boolean = False
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            If Not IsGeneral Then
                Dim lst As List(Of AccessoriesList) = Firearms.Accessories.List(DatabasePath, cInt(ItemId), _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                For Each o As AccessoriesList In lst
                    txtMan.Text = o.Manufacturer
                    txtModel.Text = o.Model
                    txtSerial.Text = o.SerialNumber
                    cmdCondition.Text = o.Condition
                    txtUse.Text = o.Use
                    txtPurVal.Text = o.PurchaseValue
                    txtNotes.Text = o.Notes
                    txtAppValue.Text = o.AppriasedValue
                    chkCIV.Checked = o.CountInValue
                    chkIsChoke.Checked = o.IsChoke
                Next
            Else 
                Dim lst As List(Of GeneralAccessoriesList) = Other.GeneralAccessories.Lists(DatabasePath, CInt(ItemId), _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                For Each o As GeneralAccessoriesList In lst
                    txtMan.Text = o.Manufacturer
                    txtModel.Text = o.Model
                    txtSerial.Text = o.SerialNumber
                    cmdCondition.Text = o.Condition
                    txtUse.Text = o.Use
                    txtPurVal.Text = o.PurchaseValue
                    txtNotes.Text = o.Notes
                    txtAppValue.Text = o.AppriasedValue
                    chkCIV.Checked = o.CountInValue
                    chkIsChoke.Checked = o.IsChoke
                Next
            End If
            
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditAccessory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditAccessory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If Not IsGeneral Then
                Label10.Visible = IsShotGun
                chkIsChoke.Visible = IsShotGun
                txtMan.AutoCompleteCustomSource = AutoFill.Accessory.Manufacturer(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                txtModel.AutoCompleteCustomSource = AutoFill.Accessory.Model(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                txtUse.AutoCompleteCustomSource = AutoFill.Accessory.Use(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                txtPurVal.AutoCompleteCustomSource = AutoFill.Accessory.PurchaseValue(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Else 
                IsShotGun = True
                Label10.Visible = IsShotGun
                chkIsChoke.Visible = IsShotGun
                txtMan.AutoCompleteCustomSource = AutoFill.GeneralAccessories.Manufacturer(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                txtModel.AutoCompleteCustomSource = AutoFill.GeneralAccessories.Model(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                txtUse.AutoCompleteCustomSource = AutoFill.GeneralAccessories.Use(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                txtPurVal.AutoCompleteCustomSource = AutoFill.GeneralAccessories.PurchaseValue(DatabasePath, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            End If
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
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
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Try
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSerial As String = FluffContent(txtSerial.Text)
            Dim strCondition As String = cmdCondition.SelectedItem.ToString
            Dim strUse As String = FluffContent(txtUse.Text)
            Dim strPurVal As String = FluffContent(txtPurVal.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim dAppValue As Double = FluffContent(txtAppValue.Text, 0.0)
            Dim item As Long = Convert.ToInt32(ItemId)

            If Not Helpers.IsRequired(strMan, "Manufacturer", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strModel, "Model", Text, _errOut) Then Exit Sub
            if Not IsGeneral Then
                If Not Firearms.Accessories.Update(DatabasePath, item, GunId, strMan, 
                                                                             strModel, strSerial, strCondition, strNotes, strUse, 
                                                                             Convert.ToDouble(strPurVal),dAppValue, chkCIV.Checked, 
                                                                             chkIsChoke.Checked, _errOut) Then Throw New Exception(_errOut)
            Else
                If Not Other.GeneralAccessories.Update(DatabasePath, item, strMan, 
                                                                             strModel, strSerial, strCondition, strNotes, strUse, 
                                                                             Convert.ToDouble(strPurVal),dAppValue, chkCIV.Checked, 
                                                                             chkIsChoke.Checked, _errOut) Then Throw New Exception(_errOut)
                'If IsAttached(item) Then
                '    Dim lst As List(Of GeneralAccessoriesLinkers) = Other.GeneralAccessoriesLinking.Lists(DatabasePath, item, _errOut)
                '    If _errOut.Length > 0 Then Throw New Exception(_errOut)
                '    For Each o As GeneralAccessoriesLinkers In lst
                '        If Not Other.GeneralAccessoriesLinking.UpdateFirearm(DatabasePath, item, o.Gid, _errOut) Then Throw New Exception(_errOut)
                '    Next
                'End If
            End If
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnEdit.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Determines whether the specified item is attached to other firearms.
    ''' </summary>
    ''' <param name="item">The item.</param>
    ''' <returns><c>true</c> if the specified item is attached; otherwise, <c>false</c>.</returns>
    ''' <exception cref="System.Exception"></exception>
    'Private Function IsAttached(item As Integer) As Boolean
    '    Dim bAns As Boolean = False
    '    Try
    '        Dim lst As List(Of GeneralAccessoriesLinkers) = Other.GeneralAccessoriesLinking.Lists(DatabasePath, item, _errOut)
    '        If _errOut.Length > 0 Then Throw New Exception(_errOut)
    '        bAns = lst.Count > 0
    '    Catch ex As Exception
    '        Call LogError(Name, "IsAttached", Err.Number, ex.Message.ToString)
    '    End Try
    '    Return bAns
    'End Function
End Class