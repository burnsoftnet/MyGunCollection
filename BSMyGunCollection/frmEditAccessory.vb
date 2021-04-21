Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmEditAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditAccessory
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
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim lst As List(Of AccessoriesList) = BurnSoft.Applications.MGC.Firearms.Accessories.List(DatabasePath, cInt(ItemId), _errOut)
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
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditAccessory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditAccessory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Label10.Visible = IsShotGun
            chkIsChoke.Visible = IsShotGun
            txtMan.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Accessory.Manufacturer(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtModel.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Accessory.Model(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtUse.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Accessory.Use(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtPurVal.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Accessory.PurchaseValue(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Call LoadData()
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
            If Not IsRequired(strMan, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Text) Then Exit Sub
            If Not BurnSoft.Applications.MGC.Firearms.Accessories.Update(DatabasePath, Convert.ToInt32(ItemId),GunId, strMan, strModel, strSerial, strCondition, strNotes, strUse, Convert.ToDouble(strPurVal),dAppValue, chkCIV.Checked, chkIsChoke.Checked, _errOut) Then Throw New Exception(_errOut)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnEdit.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class