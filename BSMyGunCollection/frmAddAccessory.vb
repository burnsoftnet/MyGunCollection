Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global

Public Class frmAddAccessory
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The is shot gun
    ''' </summary>
    Public IsShotGun As Boolean
   
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
            
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSerial As String = FluffContent(txtSerial.Text)
            Dim strCondition As String = cmdCondition.SelectedItem.ToString
            Dim strUse As String = FluffContent(txtUse.Text)
            Dim strPurVal As String = FluffContent(txtPurVal.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim dAppValue As Double = FluffContent(txtAppValue.Text, 0.0)
            Dim errOut as String = ""
            If Not Helpers.IsRequired(strMan, "Manufacturer", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strModel, "Model", Text, errOut) Then Exit Sub

            If Not Accessories.Add(DatabasePath,Convert.ToInt32(ItemId),strMan,strModel, strSerial, strCondition,strNotes, strUse, Convert.ToDouble(strPurVal), dAppValue, chkCIV.Checked, chkIsChoke.Checked, errOut) Then Throw New Exception(errOut)
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddAccessory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddAccessory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Label10.Visible = IsShotGun
            chkIsChoke.Visible = IsShotGun
            Dim errOut As String = ""
            txtMan.AutoCompleteCustomSource = Accessory.Manufacturer(DatabasePath, errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtModel.AutoCompleteCustomSource = Accessory.Model(DatabasePath, errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtUse.AutoCompleteCustomSource = Accessory.Use(DatabasePath, errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtPurVal.AutoCompleteCustomSource = Accessory.PurchaseValue(DatabasePath, errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class