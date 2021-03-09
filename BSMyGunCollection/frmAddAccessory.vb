'TODO #43 Clean Up code
''Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC
Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' Class frmAddAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable InconsistentNaming
Public Class frmAddAccessory
' ReSharper restore InconsistentNaming
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
            'Dim iCiv As Integer = 0
            'Dim iIc As Integer = 0
            'If chkCIV.Checked Then iCiv = 1
            'If chkIsChoke.CheckAlign Then iIc = 1
            If Not IsRequired(strMan, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Text) Then Exit Sub

            'Dim Obj As New BSDatabase
            'Dim SQL As String = "INSERT INTO Gun_Collection_Accessories(GID,Manufacturer,Model,SerialNumber,Condition,Notes,Use,PurValue,AppValue,CIV,IC,sync_lastupdate) VALUES(" &
            '        ItemId & ",'" & strMan & "','" & strModel & "','" & strSerial & "','" & strCondition & "','" &
            '        strNotes & "','" & strUse & "','" & strPurVal & "'," & dAppValue & "," & iCiv & "," & iIc & ",Now())"
            'Obj.ConnExec(SQL)
            Dim errOut as String = ""
            If Not Accessories.Add(DatabasePath,Convert.ToInt32(ItemId),strMan,strModel, strSerial, strCondition,strNotes, strUse, Convert.ToDouble(strPurVal), dAppValue, chkCIV.Checked, chkIsChoke.Checked, errOut) Then Throw New Exception(errOut)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            'Dim objAf As New AutoFillCollections
            'txtMan.AutoCompleteCustomSource = objAf.Accessory_Manufacturer
            'txtModel.AutoCompleteCustomSource = objAf.Accessory_Model
            'txtUse.AutoCompleteCustomSource = objAf.Accessory_Use
            'txtPurVal.AutoCompleteCustomSource = objAf.Accessory_PurValue
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
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class